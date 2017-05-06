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
    public partial class ReportsControl : UserControl
    {
        MainModel dbContext = new MainModel();
        private enum ReportMode : short
        {
            CurrentQuantities = 0,
            PastQuantities = 1,
            SalesReport = 2,
            None = 3,
        }

        ReportMode reportMode = ReportMode.None;

        public ReportsControl()
        {
            InitializeComponent();
        }

        private void btnReportQuantities_Click(object sender, EventArgs e)
        {
            reportMode = ReportMode.CurrentQuantities;
            dateTimePicker1.Visible = dateTimePicker2.Visible = false;
            lblPeriodFrom.Visible = lblPeriodTo.Visible = false;
        }

        private void btnPastQuantities_Click(object sender, EventArgs e)
        {
            reportMode = ReportMode.PastQuantities;
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = false;
            lblPeriodFrom.Visible = true;
            lblPeriodTo.Visible = false;
            lblPeriodFrom.Text = "Period";
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            reportMode = ReportMode.SalesReport;
            dateTimePicker1.Visible = dateTimePicker2.Visible = true;
            lblPeriodFrom.Visible = lblPeriodTo.Visible = true;
            lblPeriodFrom.Text = "Period From";            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {          
            switch (reportMode)
            {
                case ReportMode.CurrentQuantities:
                    gridControl1.Visible = true;
                    gridControl2.Visible = gridControl3.Visible = false;
                    var currentQuantitiesReportSource = (from sq in dbContext.StockQuantities
                                        join pr in dbContext.Products
                                           on sq.product_id equals pr.id
                                        select new
                                        {
                                            Name = pr.product_name,
                                            Quantity = sq.quantity
                                        }).ToList();
                    gridControl1.DataSource = currentQuantitiesReportSource;
                    gridControl1.Refresh();
                    gridView1.Columns[1].Width = 50;
                    break;
                case ReportMode.PastQuantities:
                    gridControl1.Visible = gridControl3.Visible = false;
                    gridControl2.Visible = true;
                    DateTime period = dateTimePicker1.Value;

                    var pastQuantitiesReportSource = (from sq in dbContext.StockQuantities
                                                      join pr in dbContext.Products
                                                      on sq.product_id equals pr.id
                                                      where sq.reference_date <= period
                                                      select new
                                                      {
                                                          ProductName = pr.product_name,
                                                          ProductQuantity = sq.quantity,
                                                          ReferenceDate = sq.reference_date
                                                      }).ToList();
                    gridControl2.DataSource = pastQuantitiesReportSource;
                    gridControl2.Refresh();                                                       
                    break;
                case ReportMode.SalesReport:
                    gridControl1.Visible = gridControl2.Visible = false;
                    gridControl3.Visible = true;
                    DateTime dateFrom = dateTimePicker1.Value;
                    DateTime dateTo = dateTimePicker2.Value;

                    dateFrom = new DateTime(dateFrom.Year, dateFrom.Month, dateFrom.Day);
                    dateTo = new DateTime(dateTo.Year, dateTo.Month, dateTo.Day);

                    var salesReportSource = (from h in dbContext.History
                                        where h.Date >= dateFrom
                                        && h.Date <= dateTo
                                        select new
                                        {
                                            ProductName = h.product_name,
                                            ProductQuantity = h.quantity,
                                            Date = h.Date
                                        }).ToList();
                    gridControl3.DataSource = salesReportSource;
                    gridControl3.Refresh();
                    break;
                case ReportMode.None:
                    MessageBox.Show("Please, select a type of report by clicking on one of the report types buttons.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    break;
            }
                 
        }

        private void ReportsControl_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = dateTimePicker2.Visible = false;
            lblPeriodFrom.Visible = lblPeriodTo.Visible = false;
        }
    }
}
