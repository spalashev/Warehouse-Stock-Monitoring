namespace EStore
{
    partial class ReportsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.lblPeriodTo = new DevExpress.XtraEditors.LabelControl();
            this.lblPeriodFrom = new DevExpress.XtraEditors.LabelControl();
            this.btnPastQuantities = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnSalesReport = new DevExpress.XtraEditors.SimpleButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnReportQuantities = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGenerateReport);
            this.groupControl1.Controls.Add(this.lblPeriodTo);
            this.groupControl1.Controls.Add(this.lblPeriodFrom);
            this.groupControl1.Controls.Add(this.btnPastQuantities);
            this.groupControl1.Controls.Add(this.dateTimePicker2);
            this.groupControl1.Controls.Add(this.btnSalesReport);
            this.groupControl1.Controls.Add(this.dateTimePicker1);
            this.groupControl1.Controls.Add(this.btnReportQuantities);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(503, 111);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Report Types";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGenerateReport.Location = new System.Drawing.Point(356, 21);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(145, 88);
            this.btnGenerateReport.TabIndex = 5;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // lblPeriodTo
            // 
            this.lblPeriodTo.Location = new System.Drawing.Point(154, 66);
            this.lblPeriodTo.Name = "lblPeriodTo";
            this.lblPeriodTo.Size = new System.Drawing.Size(45, 13);
            this.lblPeriodTo.TabIndex = 4;
            this.lblPeriodTo.Text = "Period To";
            // 
            // lblPeriodFrom
            // 
            this.lblPeriodFrom.Location = new System.Drawing.Point(154, 24);
            this.lblPeriodFrom.Name = "lblPeriodFrom";
            this.lblPeriodFrom.Size = new System.Drawing.Size(57, 13);
            this.lblPeriodFrom.TabIndex = 3;
            this.lblPeriodFrom.Text = "Period From";
            // 
            // btnPastQuantities
            // 
            this.btnPastQuantities.Location = new System.Drawing.Point(5, 53);
            this.btnPastQuantities.Name = "btnPastQuantities";
            this.btnPastQuantities.Size = new System.Drawing.Size(145, 23);
            this.btnPastQuantities.TabIndex = 2;
            this.btnPastQuantities.Text = "Past Quantities Report";
            this.btnPastQuantities.Click += new System.EventHandler(this.btnPastQuantities_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(154, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(3, 82);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(145, 23);
            this.btnSalesReport.TabIndex = 1;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(154, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btnReportQuantities
            // 
            this.btnReportQuantities.Location = new System.Drawing.Point(5, 24);
            this.btnReportQuantities.Name = "btnReportQuantities";
            this.btnReportQuantities.Size = new System.Drawing.Size(145, 23);
            this.btnReportQuantities.TabIndex = 0;
            this.btnReportQuantities.Text = "Current Quantities Report";
            this.btnReportQuantities.Click += new System.EventHandler(this.btnReportQuantities_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl3);
            this.groupControl2.Controls.Add(this.gridControl2);
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 111);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(503, 256);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(499, 252);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(2, 2);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(499, 252);
            this.gridControl2.TabIndex = 3;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl3
            // 
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(2, 2);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(499, 252);
            this.gridControl3.TabIndex = 4;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ReportsControl";
            this.Size = new System.Drawing.Size(503, 367);
            this.Load += new System.EventHandler(this.ReportsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnPastQuantities;
        private DevExpress.XtraEditors.SimpleButton btnSalesReport;
        private DevExpress.XtraEditors.SimpleButton btnReportQuantities;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DevExpress.XtraEditors.LabelControl lblPeriodTo;
        private DevExpress.XtraEditors.LabelControl lblPeriodFrom;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnGenerateReport;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
    }
}
