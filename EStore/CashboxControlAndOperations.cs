using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore
{
    public partial class CashboxControlAndOperations : UserControl
    {
        BindingList<History> bsSalesHistory = new BindingList<History>();
        MainModel dbContext = new MainModel();
        bool saleMode = true;

        public CashboxControlAndOperations(bool _mode = true)
        {
            saleMode = _mode;

            InitializeComponent();

            gridControl1.DataSource = bsSalesHistory;
            bsSalesHistory.AllowNew = true;
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[1].Visible = false;      
            gridView1.Columns[2].Width = gridView1.Columns[2].Width * 4;
            gridView1.Columns[2].Caption = "Product Name";

            DevExpress.XtraEditors.Repository.RepositoryItemComboBox riCbProducts = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            riCbProducts.AutoHeight = false;
            //riCbProducts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            //new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            riCbProducts.Items.AddRange(dbContext.Products.Select(p => p.product_name).ToArray());
            riCbProducts.Name = "riCbProducts";
            riCbProducts.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            gridView1.Columns[2].ColumnEdit = riCbProducts;

            gridView1.Columns[3].Caption = "Quantity";   
                      
            DevExpress.XtraEditors.NavigatorCustomButton button;
            button = gridControl1.EmbeddedNavigator.Buttons.CustomButtons.Add();
            button.Tag = "Process";
            if (saleMode == true)
            {
                button.Hint = "Process the sales";
            }
            else
            {
                groupControl2.Text = "Stock Purchasing And Other Operations";
                button.Hint = "Process the purchases";
            }
            button.ImageIndex = 18;


            DevExpress.XtraEditors.NavigatorCustomButton buttonLoadCash;
            buttonLoadCash = gridControl1.EmbeddedNavigator.Buttons.CustomButtons.Add();
            buttonLoadCash.Tag = "Load Cash";
            buttonLoadCash.Hint = "Load Cash";
            buttonLoadCash.ImageIndex = 12;

            gridControl1.EmbeddedNavigator.ButtonClick +=
                new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(EmbeddedNavigator_ButtonClick);
        }

        private void EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if ("Load Cash".Equals(e.Button.Tag))
            {
                try
                {
                    long lastStateChangeID = dbContext.Cashbox.Max(cb => cb.id);
                    Cashbox lastStateInfo = dbContext.Cashbox.Where(cb => cb.id == lastStateChangeID)
                                                            .Select(stateInfo => stateInfo).First();

                    Cashbox cashLoad = new Cashbox(lastStateInfo.amount_after, lastStateInfo.amount_after + 1000, DateTime.Now);
                    dbContext.Cashbox.Add(cashLoad);
                    EntityFrameworkTransactionsControl.Commit(dbContext);
                    UpdateState();
                }
                catch (Exception)
                {
                    MessageBox.Show("Cashbox State table is empty, please provide a starting amount."
                        , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if ("Process".Equals(e.Button.Tag))
            {
                #region SaleMode
                if (saleMode == true)
                {
                    List<History> processableSales = new List<History>();
                    int totalSalesQuantity = 0;
                    decimal cashGains = 0M;
                    string recipeHelper = "";
                    int recipeCount = 1;
                    DateTime dateOfSale = DateTime.Now;

                    foreach (var sale in bsSalesHistory)
                    {
                        if (sale.quantity <= 0)
                        {
                            MessageBox.Show(string.Format("Skipping product {0}, because selected quantity is invalid.",
                                sale.product_name == null ? "[Unnamed]" : sale.product_name), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        sale.Date = dateOfSale;
                        if (dbContext.Products.Any(p => p.product_name == sale.product_name))
                        {
                            var anonymousProductDetails = dbContext.Products.
                                Where(p => p.product_name == sale.product_name).
                                Select(s => new { Price = s.price_sell, Id = s.id }).ToList();
                            long quantityId = anonymousProductDetails[0].Id;

                            StockQuantities quantityAccumulator = dbContext.StockQuantities
                                                                                    .Where(sq => sq.product_id == quantityId)
                                                                                    .FirstOrDefault();
                            if (quantityAccumulator != null)
                            {
                                if (quantityAccumulator.quantity - sale.quantity < 0)
                                {
                                    MessageBox.Show(
                                        string.Format("There are not enough items from product [{0}] in stock to finish the sale.", sale.product_name), "Information",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    continue;
                                }
                                quantityAccumulator.quantity -= sale.quantity;
                                quantityAccumulator.reference_date = dateOfSale;
                                EntityFrameworkTransactionsControl.Commit(dbContext);                                
                            }
                            else
                            {
                                MessageBox.Show(
                                    string.Format("There is no information about the quantity of product {0}. Unable to complete the sale of the current product.", sale.product_name),
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            totalSalesQuantity += (int)sale.quantity;
                            cashGains += sale.quantity * anonymousProductDetails[0].Price;
                            recipeHelper +=
                                Environment.NewLine + string.Format("{0,-3})", recipeCount++) + string.Format("{0,-27}", sale.product_name) +
                                  string.Format("{0,-13}", anonymousProductDetails[0].Price) + sale.quantity + " items.";

                            processableSales.Add(sale);
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Product [{0}] is invalid. Please, register it first.", sale.product_name),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (processableSales.Count > 0)
                    {
                        dbContext.History.AddRange(processableSales);
                        try
                        {
                            long lastStateChangeID = dbContext.Cashbox.Max(cb => cb.id);

                            decimal lastStateAmount = dbContext.Cashbox.
                                                                     Where(cb => cb.id == lastStateChangeID).
                                                                     Select(stateInfo => stateInfo).
                                                                     First().amount_after;

                            dbContext.Cashbox.Add(new Cashbox(lastStateAmount, lastStateAmount + cashGains, DateTime.Now));
                            EntityFrameworkTransactionsControl.Commit(dbContext);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cashbox State table is empty, please provide a starting amount.",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EntityFrameworkTransactionsControl.Rollback(dbContext);
                            return;
                        }

                        MessageBox.Show("Sale complete!" + Environment.NewLine + Environment.NewLine +
                            "Product                       Price        Quantity" + Environment.NewLine +
                            "---------------------------------------------------" +
                            recipeHelper + Environment.NewLine +
                            "---------------------------------------------------" + Environment.NewLine +
                            string.Format("Total Items Sold {0}.", totalSalesQuantity) + Environment.NewLine +
                            string.Format("Total Cash Earned {0}$.", cashGains), "Sales information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UpdateState();
                    }
                }
                #endregion
                #region BuyMode
                else
                {
                    List<StockCharge> processChargeItems = new List<StockCharge>();
                    int totalBoughtQuantity = 0;
                    decimal cashToPay = 0M;
                    string recipeHelper = "";
                    int recipeCount = 1;
                    DateTime dateOfBuying = DateTime.Now;

                    foreach (var charge in bsSalesHistory)
                    {
                        if (charge.quantity <= 0)
                        {
                            MessageBox.Show(string.Format("Skipping product {0}, because the selected quantity is invalid.",
                                charge.product_name == null ? "[Unnamed]" : charge.product_name),
                                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            continue;
                        }
                        charge.Date = dateOfBuying;
                        if (dbContext.Products.Any(p => p.product_name == charge.product_name))
                        {
                            var anonymousProductDetails = dbContext.Products.
                                Where(p => p.product_name == charge.product_name).
                                Select(s => new { Id = s.id, Price = s.price_charge }).ToList();
                            long quantityId = anonymousProductDetails[0].Id;

                            StockQuantities quantityAccumulator = dbContext.StockQuantities
                                                                                    .Where(sq => sq.product_id == quantityId)
                                                                                    .FirstOrDefault();
                            if (quantityAccumulator != null)
                            {                               
                                quantityAccumulator.quantity += charge.quantity;
                                quantityAccumulator.reference_date = dateOfBuying;
                                EntityFrameworkTransactionsControl.Commit(dbContext);
                            }
                            else
                            {
                                MessageBox.Show(
                                    string.Format("There is no information about the quantity of product {0}. Unable to complete the purchase of the current product.", charge.product_name),
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                continue;
                            }

                            totalBoughtQuantity += (int)charge.quantity;
                            cashToPay += charge.quantity * anonymousProductDetails[0].Price;
                            recipeHelper +=
                                Environment.NewLine + string.Format("{0,-3})", recipeCount++) + string.Format("{0,-27}", charge.product_name) +
                                  string.Format("{0,-13}", anonymousProductDetails[0].Price) + charge.quantity + " items.";

                            processChargeItems.Add(new StockCharge(DateTime.Now, anonymousProductDetails[0].Id, charge.quantity));
                        }
                        else
                        {
                            MessageBox.Show(string.Format("Product [{0}] is invalid. Please, register it first.", charge.product_name),
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (processChargeItems.Count > 0)
                    {
                        dbContext.StockCharge.AddRange(processChargeItems);
                        try
                        {
                            long lastStateChangeID = dbContext.Cashbox.Max(cb => cb.id);

                            decimal lastStateAmount = dbContext.Cashbox.
                                                                     Where(cb => cb.id == lastStateChangeID).
                                                                     Select(stateInfo => stateInfo).
                                                                     First().amount_after;
                            decimal remainingCash = lastStateAmount - cashToPay;
                            if (remainingCash > 0)
                            {
                                dbContext.Cashbox.Add(new Cashbox(lastStateAmount, remainingCash, DateTime.Now));
                                EntityFrameworkTransactionsControl.Commit(dbContext);
                            }
                            else
                            {
                                MessageBox.Show("There is not enough cash to pay the charge! Aborting the operation.",
                                    "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                EntityFrameworkTransactionsControl.Rollback(dbContext);
                                return;
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Cashbox State table is empty, please provide a starting amount.",
                                "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            EntityFrameworkTransactionsControl.Rollback(dbContext);
                            return;
                        }

                        MessageBox.Show("Purchases complete!" + Environment.NewLine + Environment.NewLine +
                            "Product                       Price        Quantity" + Environment.NewLine +
                            "---------------------------------------------------" +
                            recipeHelper + Environment.NewLine +
                            "---------------------------------------------------" + Environment.NewLine +
                            string.Format("Total Items Bought {0}.", totalBoughtQuantity) + Environment.NewLine +
                            string.Format("Total Cash Payed {0}$.", cashToPay),
                            "Purchases information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UpdateState();
                    }
                }
                #endregion
            }
        }

        private void UpdateState()
        {
            try
            {
                long lastStateChangeID = dbContext.Cashbox.Max(cb => cb.id);
                Cashbox lastStateInfo = dbContext.Cashbox.Where(cb => cb.id == lastStateChangeID)
                                                        .Select(stateInfo => stateInfo).First();
                lblStateInfo.Text = string.Format("Last State Change: {0}", lastStateInfo.last_change_dttm);
                lblAmount.Text = string.Format("Available Amount: {0}$", lastStateInfo.amount_after);
            }
            catch (Exception)
            {
                MessageBox.Show("Cashbox State table is empty, please provide a starting amount."
                    , "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void CashboxAndSalesControl_Load(object sender, EventArgs e)
        {
            UpdateState();
        }
    }
}
