using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore
{
    using static EntityFrameworkTransactionsControl;
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            using (MainModel model = new MainModel())
            {
                cbManufacturers.DataSource = model.Manufacturers.ToList();
                cbManufacturers.ValueMember = "id";
                cbManufacturers.DisplayMember = "name";
            }

            using (MainModel model = new MainModel())
            {
                cbCategories.DataSource = model.Categories.ToList();
                cbCategories.ValueMember = "id";
                cbCategories.DisplayMember = "category_name";
            }
            cbMeasuringUnits.SelectedIndex = 0;
        }

        private void AddProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (txtName.Text == "" ||  
                    txtChargePrice.Text == "" || txtSellingPrice.Text == "" ||
                    cbCategories.SelectedValue == null || cbManufacturers.SelectedValue == null || 
                    cbMeasuringUnits.SelectedItem == null)
                {
                    throw new MissingFieldException("Unable to add the desired product due to invalid input data!");
                }

                if (txtName.Text.Length < 3)
                    throw new ArgumentException("Unable to add the desired product as it's name is not longer than 3 symbols!");
                using (MainModel model = new MainModel())
                {
                    Products product = new Products();
                    product.product_name = txtName.Text;

                    product.price_charge = decimal.Parse(txtChargePrice.Text);
                    product.price_sell = decimal.Parse(txtSellingPrice.Text);

                    product.category_id = int.Parse(cbCategories.SelectedValue.ToString());
                    product.measuring_unit = cbMeasuringUnits.SelectedItem.ToString();
                    product.manufacturer_id = int.Parse(cbManufacturers.SelectedValue.ToString());
                    model.Products.Add(product);                   
                    Commit(model);

                    model.Products.AsEnumerable().Max(p => p.id);
                    model.StockQuantities.Add(new StockQuantities(DateTime.Now, model.Products.AsEnumerable().Max(p => p.id), 0));
                    Commit(model);
                }                               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

#if DEBUG
            MessageBox.Show(
                "Categories debug info" + Environment.NewLine + 
                " index: " + cbCategories.SelectedIndex.ToString() + Environment.NewLine +
                " item  " + cbCategories.SelectedItem.ToString() + Environment.NewLine +
                " text  " + cbCategories.SelectedText.ToString() + Environment.NewLine +
                " value " + cbCategories.SelectedValue.ToString() + Environment.NewLine + Environment.NewLine +
               
                " Manufacturer debug info" + Environment.NewLine + 
                " index " + cbManufacturers.SelectedIndex.ToString() + Environment.NewLine +
                " item  " + cbManufacturers.SelectedItem.ToString() + Environment.NewLine +
                " text  " + cbManufacturers.SelectedText.ToString() + Environment.NewLine +
                " value " + cbManufacturers.SelectedValue.ToString() + Environment.NewLine);      
#endif
            

        }
    }
}