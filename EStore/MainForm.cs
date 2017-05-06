using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStore
{
    public partial class MainForm : Form
    {
        MainModel mm = new MainModel();

        public MainForm()
        {
            InitializeComponent();
        }

        private void barBtnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {           
            //groupControlInterfaceController.Visible = true;           
            //return;
            if (Username == "" || Password == "")
            {
                MessageBox.Show("Invalid login credentials.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                using (MainModel dbContext = new MainModel())
                {
                    if (dbContext.Users.Any(u => u.username == Username))
                    {
                        Users pendingUser = dbContext.Users.First(u => u.username == Username);
                        if (pendingUser.password == Password)
                            groupControlInterfaceController.Visible = true;
                        else                        
                            beiPassword.EditValue = null;
                    }
                        
                }                
            }    
        }

        private string Username
        {
            get
            {
                if (beiUsername.EditValue == null)
                {
                    return "";
                }
                return beiUsername.EditValue.ToString();
            }
            set { beiUsername.EditValue = value; }
        }

        private string Password
        {
            get
            {
                if (beiPassword.EditValue == null)
                {
                    return "";
                }
                return beiPassword.EditValue.ToString();
            }

            set { beiPassword.EditValue = value; }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SQL.Connection = "Data Source=localhost;Initial Catalog=EStore;User Id=SA;Password=sqlpwcabal;Pooling=false";
        }

        private void pbCategories_Click(object sender, EventArgs e)
        {
            groupControlInterfaceDisplay.Controls.Clear();
            CategoriesControl cc = new CategoriesControl();
            cc.Dock = DockStyle.Fill;
            groupControlInterfaceDisplay.Controls.Add(cc);
        }
              
        private void pbManufacturers_Click(object sender, EventArgs e)
        {
            groupControlInterfaceDisplay.Controls.Clear();
            ManufacturersControl mc = new ManufacturersControl();
            mc.Dock = DockStyle.Fill;
            groupControlInterfaceDisplay.Controls.Add(mc);
        }

        private void pbProducts_Click(object sender, EventArgs e)
        {
            groupControlInterfaceDisplay.Controls.Clear();
            ProductsControl pc = new ProductsControl();
            pc.Dock = DockStyle.Fill;
            groupControlInterfaceDisplay.Controls.Add(pc);
        }

        private void pbCashbox_Click(object sender, EventArgs e)
        {
            groupControlInterfaceDisplay.Controls.Clear();
            CashboxControlAndOperations cco = new CashboxControlAndOperations();
            cco.Dock = DockStyle.Fill;
            groupControlInterfaceDisplay.Controls.Add(cco);
        }

        private void pbStockCharge_Click(object sender, EventArgs e)
        {
            groupControlInterfaceDisplay.Controls.Clear();
            CashboxControlAndOperations cco = new CashboxControlAndOperations(false);
            cco.Dock = DockStyle.Fill;
            groupControlInterfaceDisplay.Controls.Add(cco);
        }

        private void pbReports_Click(object sender, EventArgs e)
        {
            groupControlInterfaceDisplay.Controls.Clear();
            ReportsControl rc = new ReportsControl();
            rc.Dock = DockStyle.Fill;
            groupControlInterfaceDisplay.Controls.Add(rc);
        }

        private void barBtnAbout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }       
    }
}
