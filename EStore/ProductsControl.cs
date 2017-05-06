using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;
using System.Globalization;

namespace EStore
{
    public partial class ProductsControl : UserControl
    {
        MainModel dbContext = new MainModel();
        public ProductsControl()
        {
            InitializeComponent();

        }

        private void btnShowProducts_Click(object sender, EventArgs e)
        {
            var productsInfo = (from product in dbContext.Products
                                join category in dbContext.Categories
                                on product.category_id equals category.id
                                join manufacturer in dbContext.Manufacturers
                                on product.manufacturer_id equals manufacturer.id
                                select new
                                {
                                    Name = product.product_name,
                                    Manufacturer = manufacturer.name,
                                    MeasuringUnit = product.measuring_unit,
                                    Category = category.category_name,
                                    ChargeCost = product.price_charge,
                                    SellingPrice = product.price_sell
                                }).ToList();
            gridControl1.DataSource = productsInfo;

            gridView1.Columns[4].DisplayFormat.FormatType = FormatType.Numeric;
            gridView1.Columns[4].DisplayFormat.Format = new CultureInfo("en-US");
            gridView1.Columns[4].DisplayFormat.FormatString = "c2";
            gridView1.Columns[5].DisplayFormat.FormatType = FormatType.Numeric;
            gridView1.Columns[5].DisplayFormat.Format = new CultureInfo("en-US");
            gridView1.Columns[5].DisplayFormat.FormatString = "c2";

            gridControl1.Refresh();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct();
            f.ShowDialog();
            btnShowProducts.PerformClick();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            int[] rowHandles = gridView1.GetSelectedRows();
            if (rowHandles.Count() == 0)
            {
                MessageBox.Show("Please select a product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string oldProductName = gridView1.GetRowCellValue(rowHandles[0], gridView1.Columns[0]).ToString();

            string newProductName = Microsoft.VisualBasic.Interaction.
              InputBox("Please, enter the new name of the product.", "Edit product");
            if (newProductName == string.Empty)
                return;

            if (newProductName.Length < 3)
            {
                MessageBox.Show("Invalid product name. Product names should be longer than 3 symbols.",
                     "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (newProductName == oldProductName)
            {
                return;
            }
            else
            {
                Products modifiedProduct = dbContext.Products.Where(p => p.product_name == oldProductName).FirstOrDefault();
                if (modifiedProduct != null)
                {
                    modifiedProduct.product_name = newProductName;
                    EntityFrameworkTransactionsControl.Commit(dbContext);
                    btnShowProducts.PerformClick();
                }
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            int[] rowHandles = gridView1.GetSelectedRows();
            if (rowHandles.Count() == 0)
            {
                MessageBox.Show("Please select a product.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string productName = gridView1.GetRowCellValue(rowHandles[0], gridView1.Columns[0]).ToString();
            Products productToDelete = dbContext.Products.Where(p => p.product_name == productName).FirstOrDefault();
            if (productToDelete != null)
            {
                if (dbContext.History.Any(h => h.product_name == productToDelete.product_name) ||
                    dbContext.StockCharge.Any(sc => sc.product_id == productToDelete.id))
                {
                    MessageBox.Show(
                        string.Format("Unable to delete the product [{0}] because it has already been bought or sold."
                        , productToDelete.product_name), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dbContext.Products.Remove(productToDelete);
                    EntityFrameworkTransactionsControl.Commit(dbContext);
                    btnShowProducts.PerformClick();
                }
            }
        }
    }
}
