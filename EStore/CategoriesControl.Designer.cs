namespace EStore
{
    partial class CategoriesControl
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
            this.colcategory_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEditCategory = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemoveCategory = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddCategory = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 53);
            this.gridControl1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.gridControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(383, 242);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcategory_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colcategory_name
            // 
            this.colcategory_name.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colcategory_name.AppearanceHeader.Options.UseFont = true;
            this.colcategory_name.Caption = "Category Name";
            this.colcategory_name.FieldName = "category_name";
            this.colcategory_name.Name = "colcategory_name";
            this.colcategory_name.Visible = true;
            this.colcategory_name.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Location = new System.Drawing.Point(209, 13);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(383, 295);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnEditCategory);
            this.groupControl1.Controls.Add(this.btnRemoveCategory);
            this.groupControl1.Controls.Add(this.btnAddCategory);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(383, 53);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Operations";
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(110, 24);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(99, 24);
            this.btnEditCategory.TabIndex = 4;
            this.btnEditCategory.Text = "Edit Category";
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnRemoveCategory
            // 
            this.btnRemoveCategory.Location = new System.Drawing.Point(215, 24);
            this.btnRemoveCategory.Name = "btnRemoveCategory";
            this.btnRemoveCategory.Size = new System.Drawing.Size(99, 24);
            this.btnRemoveCategory.TabIndex = 3;
            this.btnRemoveCategory.Text = "Remove Category";
            this.btnRemoveCategory.Click += new System.EventHandler(this.btnRemoveCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(5, 24);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(99, 24);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add category";
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // CategoriesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl2);
            this.Name = "CategoriesControl";
            this.Size = new System.Drawing.Size(383, 295);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colcategory_name;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnRemoveCategory;
        private DevExpress.XtraEditors.SimpleButton btnAddCategory;
        private DevExpress.XtraEditors.SimpleButton btnEditCategory;
    }
}
