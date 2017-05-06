namespace EStore
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.beiUsername = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.beiPassword = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barBtnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.btnConfig = new DevExpress.XtraBars.BarButtonItem();
            this.groupControlInterfaceController = new DevExpress.XtraEditors.GroupControl();
            this.pbReports = new System.Windows.Forms.PictureBox();
            this.pbStockCharge = new System.Windows.Forms.PictureBox();
            this.pbCashbox = new System.Windows.Forms.PictureBox();
            this.pbProducts = new System.Windows.Forms.PictureBox();
            this.pbManufacturers = new System.Windows.Forms.PictureBox();
            this.pbCategories = new System.Windows.Forms.PictureBox();
            this.groupControlInterfaceDisplay = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInterfaceController)).BeginInit();
            this.groupControlInterfaceController.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockCharge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCashbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManufacturers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInterfaceDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.beiUsername,
            this.barBtnLogin,
            this.barBtnAbout,
            this.skinBarSubItem1,
            this.barEditItem2,
            this.beiPassword,
            this.btnConfig});
            this.barManager1.MaxItemId = 7;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(287, 164);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.beiUsername, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.beiPassword, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnLogin),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtnAbout)});
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // beiUsername
            // 
            this.beiUsername.Caption = "Username";
            this.beiUsername.Edit = this.repositoryItemTextEdit1;
            this.beiUsername.Id = 0;
            this.beiUsername.Name = "beiUsername";
            this.beiUsername.Width = 110;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // beiPassword
            // 
            this.beiPassword.Caption = "Password";
            this.beiPassword.Edit = this.repositoryItemTextEdit3;
            this.beiPassword.Id = 5;
            this.beiPassword.Name = "beiPassword";
            this.beiPassword.Width = 91;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            this.repositoryItemTextEdit3.PasswordChar = '*';
            this.repositoryItemTextEdit3.UseSystemPasswordChar = true;
            // 
            // barBtnLogin
            // 
            this.barBtnLogin.Caption = "Login";
            this.barBtnLogin.Id = 1;
            this.barBtnLogin.Name = "barBtnLogin";
            this.barBtnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnLogin_ItemClick);
            // 
            // barBtnAbout
            // 
            this.barBtnAbout.Caption = "About";
            this.barBtnAbout.Id = 2;
            this.barBtnAbout.Name = "barBtnAbout";
            this.barBtnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAbout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(612, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 368);
            this.barDockControlBottom.Size = new System.Drawing.Size(612, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 339);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(612, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 339);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "skinBarSubItem1";
            this.skinBarSubItem1.Id = 3;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = this.repositoryItemTextEdit2;
            this.barEditItem2.Id = 4;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // btnConfig
            // 
            this.btnConfig.Caption = "Configuration";
            this.btnConfig.Id = 6;
            this.btnConfig.Name = "btnConfig";
            // 
            // groupControlInterfaceController
            // 
            this.groupControlInterfaceController.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlInterfaceController.Appearance.Options.UseBackColor = true;
            this.groupControlInterfaceController.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlInterfaceController.Controls.Add(this.pbReports);
            this.groupControlInterfaceController.Controls.Add(this.pbStockCharge);
            this.groupControlInterfaceController.Controls.Add(this.pbCashbox);
            this.groupControlInterfaceController.Controls.Add(this.pbProducts);
            this.groupControlInterfaceController.Controls.Add(this.pbManufacturers);
            this.groupControlInterfaceController.Controls.Add(this.pbCategories);
            this.groupControlInterfaceController.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControlInterfaceController.Location = new System.Drawing.Point(0, 29);
            this.groupControlInterfaceController.Name = "groupControlInterfaceController";
            this.groupControlInterfaceController.ShowCaption = false;
            this.groupControlInterfaceController.Size = new System.Drawing.Size(612, 65);
            this.groupControlInterfaceController.TabIndex = 4;
            this.groupControlInterfaceController.Text = "groupControl1";
            this.groupControlInterfaceController.Visible = false;
            // 
            // pbReports
            // 
            this.pbReports.Image = global::EStore.Properties.Resources.report;
            this.pbReports.Location = new System.Drawing.Point(447, 6);
            this.pbReports.Name = "pbReports";
            this.pbReports.Size = new System.Drawing.Size(64, 59);
            this.pbReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReports.TabIndex = 6;
            this.pbReports.TabStop = false;
            this.pbReports.Click += new System.EventHandler(this.pbReports_Click);
            // 
            // pbStockCharge
            // 
            this.pbStockCharge.Image = global::EStore.Properties.Resources.stock_charge;
            this.pbStockCharge.Location = new System.Drawing.Point(377, 6);
            this.pbStockCharge.Name = "pbStockCharge";
            this.pbStockCharge.Size = new System.Drawing.Size(64, 59);
            this.pbStockCharge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStockCharge.TabIndex = 5;
            this.pbStockCharge.TabStop = false;
            this.pbStockCharge.Click += new System.EventHandler(this.pbStockCharge_Click);
            // 
            // pbCashbox
            // 
            this.pbCashbox.Image = global::EStore.Properties.Resources.cashbox;
            this.pbCashbox.Location = new System.Drawing.Point(307, 6);
            this.pbCashbox.Name = "pbCashbox";
            this.pbCashbox.Size = new System.Drawing.Size(64, 59);
            this.pbCashbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCashbox.TabIndex = 4;
            this.pbCashbox.TabStop = false;
            this.pbCashbox.Click += new System.EventHandler(this.pbCashbox_Click);
            // 
            // pbProducts
            // 
            this.pbProducts.Image = global::EStore.Properties.Resources.products;
            this.pbProducts.Location = new System.Drawing.Point(237, 6);
            this.pbProducts.Name = "pbProducts";
            this.pbProducts.Size = new System.Drawing.Size(64, 59);
            this.pbProducts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProducts.TabIndex = 3;
            this.pbProducts.TabStop = false;
            this.pbProducts.Click += new System.EventHandler(this.pbProducts_Click);
            // 
            // pbManufacturers
            // 
            this.pbManufacturers.Image = global::EStore.Properties.Resources.manufacturers;
            this.pbManufacturers.Location = new System.Drawing.Point(167, 6);
            this.pbManufacturers.Name = "pbManufacturers";
            this.pbManufacturers.Size = new System.Drawing.Size(64, 59);
            this.pbManufacturers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbManufacturers.TabIndex = 2;
            this.pbManufacturers.TabStop = false;
            this.pbManufacturers.Click += new System.EventHandler(this.pbManufacturers_Click);
            // 
            // pbCategories
            // 
            this.pbCategories.Image = global::EStore.Properties.Resources.catalogue;
            this.pbCategories.Location = new System.Drawing.Point(97, 6);
            this.pbCategories.Name = "pbCategories";
            this.pbCategories.Size = new System.Drawing.Size(64, 59);
            this.pbCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCategories.TabIndex = 1;
            this.pbCategories.TabStop = false;
            this.pbCategories.Click += new System.EventHandler(this.pbCategories_Click);
            // 
            // groupControlInterfaceDisplay
            // 
            this.groupControlInterfaceDisplay.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlInterfaceDisplay.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.groupControlInterfaceDisplay.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.groupControlInterfaceDisplay.Appearance.Options.UseBackColor = true;
            this.groupControlInterfaceDisplay.Appearance.Options.UseBorderColor = true;
            this.groupControlInterfaceDisplay.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlInterfaceDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlInterfaceDisplay.Location = new System.Drawing.Point(0, 94);
            this.groupControlInterfaceDisplay.Name = "groupControlInterfaceDisplay";
            this.groupControlInterfaceDisplay.ShowCaption = false;
            this.groupControlInterfaceDisplay.Size = new System.Drawing.Size(612, 274);
            this.groupControlInterfaceDisplay.TabIndex = 9;
            this.groupControlInterfaceDisplay.Text = "groupControl2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EStore.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(612, 368);
            this.Controls.Add(this.groupControlInterfaceDisplay);
            this.Controls.Add(this.groupControlInterfaceController);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Private Market";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInterfaceController)).EndInit();
            this.groupControlInterfaceController.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockCharge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCashbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbManufacturers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlInterfaceDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem beiUsername;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem barBtnLogin;
        private DevExpress.XtraBars.BarButtonItem barBtnAbout;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private DevExpress.XtraBars.BarEditItem beiPassword;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraBars.BarButtonItem btnConfig;
        private DevExpress.XtraEditors.GroupControl groupControlInterfaceController;
        private System.Windows.Forms.PictureBox pbCategories;
        private DevExpress.XtraEditors.GroupControl groupControlInterfaceDisplay;
        private System.Windows.Forms.PictureBox pbManufacturers;
        private System.Windows.Forms.PictureBox pbProducts;
        private System.Windows.Forms.PictureBox pbReports;
        private System.Windows.Forms.PictureBox pbStockCharge;
        private System.Windows.Forms.PictureBox pbCashbox;
    }
}

