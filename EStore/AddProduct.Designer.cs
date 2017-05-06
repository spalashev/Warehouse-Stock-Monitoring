namespace EStore
{
    partial class AddProduct
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtSellingPrice = new DevExpress.XtraEditors.TextEdit();
            this.cbMeasuringUnits = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.txtChargePrice = new DevExpress.XtraEditors.TextEdit();
            this.cbManufacturers = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellingPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtSellingPrice);
            this.groupControl1.Controls.Add(this.cbMeasuringUnits);
            this.groupControl1.Controls.Add(this.cbCategories);
            this.groupControl1.Controls.Add(this.txtChargePrice);
            this.groupControl1.Controls.Add(this.cbManufacturers);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(259, 182);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Product Information";
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.EditValue = "0.00";
            this.txtSellingPrice.Location = new System.Drawing.Point(94, 155);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtSellingPrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtSellingPrice.Properties.Mask.EditMask = "\\d{0,6}\\.\\d{2}";
            this.txtSellingPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtSellingPrice.Properties.Mask.ShowPlaceHolders = false;
            this.txtSellingPrice.Size = new System.Drawing.Size(158, 20);
            this.txtSellingPrice.TabIndex = 5;
            // 
            // cbMeasuringUnits
            // 
            this.cbMeasuringUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasuringUnits.FormattingEnabled = true;
            this.cbMeasuringUnits.Items.AddRange(new object[] {
            "Kilogram",
            "Litre"});
            this.cbMeasuringUnits.Location = new System.Drawing.Point(94, 77);
            this.cbMeasuringUnits.Name = "cbMeasuringUnits";
            this.cbMeasuringUnits.Size = new System.Drawing.Size(158, 21);
            this.cbMeasuringUnits.TabIndex = 2;
            // 
            // cbCategories
            // 
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(94, 104);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(158, 21);
            this.cbCategories.TabIndex = 3;
            // 
            // txtChargePrice
            // 
            this.txtChargePrice.EditValue = "0.00";
            this.txtChargePrice.Location = new System.Drawing.Point(94, 131);
            this.txtChargePrice.Name = "txtChargePrice";
            this.txtChargePrice.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtChargePrice.Properties.Appearance.Options.UseBackColor = true;
            this.txtChargePrice.Properties.Mask.EditMask = "\\d{0,6}\\.\\d{2}";
            this.txtChargePrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtChargePrice.Properties.Mask.ShowPlaceHolders = false;
            this.txtChargePrice.Size = new System.Drawing.Size(158, 20);
            this.txtChargePrice.TabIndex = 4;
            // 
            // cbManufacturers
            // 
            this.cbManufacturers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbManufacturers.FormattingEnabled = true;
            this.cbManufacturers.Location = new System.Drawing.Point(94, 50);
            this.cbManufacturers.Name = "cbManufacturers";
            this.cbManufacturers.Size = new System.Drawing.Size(158, 21);
            this.cbManufacturers.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 143);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Name\r\n\r\nManufacturer\r\n\r\nMeasuring Units\r\n\r\nCategory\r\n\r\nCharge Price\r\n\r\nSelling Pr" +
    "ice";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 24);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.txtName.Properties.Appearance.Options.UseBackColor = true;
            this.txtName.Size = new System.Drawing.Size(158, 20);
            this.txtName.TabIndex = 0;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 182);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProduct_FormClosing);
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSellingPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChargePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtSellingPrice;
        private System.Windows.Forms.ComboBox cbCategories;
        private DevExpress.XtraEditors.TextEdit txtChargePrice;
        private System.Windows.Forms.ComboBox cbManufacturers;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.ComboBox cbMeasuringUnits;
    }
}