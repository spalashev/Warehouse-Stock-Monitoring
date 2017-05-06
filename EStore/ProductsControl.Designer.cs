namespace EStore
{
    partial class ProductsControl
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnShowProducts = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(498, 219);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDeleteProduct);
            this.groupControl1.Controls.Add(this.btnEditProduct);
            this.groupControl1.Controls.Add(this.btnAddProduct);
            this.groupControl1.Controls.Add(this.btnShowProducts);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 51);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Operations";
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(86, 24);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 3;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(5, 24);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 2;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnShowProducts
            // 
            this.btnShowProducts.Location = new System.Drawing.Point(256, 24);
            this.btnShowProducts.Name = "btnShowProducts";
            this.btnShowProducts.Size = new System.Drawing.Size(98, 23);
            this.btnShowProducts.TabIndex = 1;
            this.btnShowProducts.Text = "Show Products";
            this.btnShowProducts.Click += new System.EventHandler(this.btnShowProducts_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 51);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(502, 223);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "groupControl2";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(167, 24);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(83, 23);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete Product";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ProductsControl";
            this.Size = new System.Drawing.Size(502, 274);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.SimpleButton btnShowProducts;
        private DevExpress.XtraEditors.SimpleButton btnEditProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
    }
}
