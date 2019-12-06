namespace QLDACNTT_QUANLYKHO
{
    partial class frmAddProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddProduct));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barbtnSaveAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCloseAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barLargeButtonItem1 = new DevExpress.XtraBars.BarLargeButtonItem();
            this.txtAdd_idProduct = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtAdd_providerProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtAdd_priceProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtAdd_groupProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtAdd_SpeciesProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtAdd_unitProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtAdd_nameProduct = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Add_IdProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_NameProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_UnitProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_SpeciesProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_GroupProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_PriceProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Add_ProviderProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_idProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_providerProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_priceProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_groupProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_SpeciesProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_unitProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_nameProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_IdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_NameProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_UnitProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_SpeciesProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_GroupProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PriceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_ProviderProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnSaveAddProduct,
            this.barbtnCloseAddProduct,
            this.barLargeButtonItem1});
            this.barManager1.MaxItemId = 4;
            // 
            // barbtnSaveAddProduct
            // 
            this.barbtnSaveAddProduct.Caption = "Lưu";
            this.barbtnSaveAddProduct.Id = 0;
            this.barbtnSaveAddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnSaveAddProduct.ImageOptions.SvgImage")));
            this.barbtnSaveAddProduct.Name = "barbtnSaveAddProduct";
            this.barbtnSaveAddProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbtnSaveAddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnSaveAddProduct_ItemClick);
            // 
            // barbtnCloseAddProduct
            // 
            this.barbtnCloseAddProduct.Caption = "Đóng";
            this.barbtnCloseAddProduct.Id = 1;
            this.barbtnCloseAddProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnCloseAddProduct.ImageOptions.SvgImage")));
            this.barbtnCloseAddProduct.Name = "barbtnCloseAddProduct";
            this.barbtnCloseAddProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbtnCloseAddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnCloseAddProduct_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(373, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 233);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(373, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 233);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(373, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 233);
            // 
            // barLargeButtonItem1
            // 
            this.barLargeButtonItem1.Caption = "barLargeButtonItem1";
            this.barLargeButtonItem1.Id = 3;
            this.barLargeButtonItem1.Name = "barLargeButtonItem1";
            // 
            // txtAdd_idProduct
            // 
            this.txtAdd_idProduct.Location = new System.Drawing.Point(121, 12);
            this.txtAdd_idProduct.MenuManager = this.barManager1;
            this.txtAdd_idProduct.Name = "txtAdd_idProduct";
            this.txtAdd_idProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_idProduct.StyleController = this.layoutControl1;
            this.txtAdd_idProduct.TabIndex = 4;
            this.txtAdd_idProduct.EditValueChanged += new System.EventHandler(this.txtAdd_idProduct_EditValueChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.txtAdd_providerProduct);
            this.layoutControl1.Controls.Add(this.txtAdd_priceProduct);
            this.layoutControl1.Controls.Add(this.txtAdd_groupProduct);
            this.layoutControl1.Controls.Add(this.txtAdd_SpeciesProduct);
            this.layoutControl1.Controls.Add(this.txtAdd_unitProduct);
            this.layoutControl1.Controls.Add(this.txtAdd_nameProduct);
            this.layoutControl1.Controls.Add(this.txtAdd_idProduct);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(373, 233);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.SvgImage = global::QLDACNTT_QUANLYKHO.Properties.Resources.saveas2;
            this.btnSave.Location = new System.Drawing.Point(12, 180);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(349, 38);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAdd_providerProduct
            // 
            this.txtAdd_providerProduct.Location = new System.Drawing.Point(121, 156);
            this.txtAdd_providerProduct.MenuManager = this.barManager1;
            this.txtAdd_providerProduct.Name = "txtAdd_providerProduct";
            this.txtAdd_providerProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_providerProduct.StyleController = this.layoutControl1;
            this.txtAdd_providerProduct.TabIndex = 10;
            // 
            // txtAdd_priceProduct
            // 
            this.txtAdd_priceProduct.Location = new System.Drawing.Point(121, 132);
            this.txtAdd_priceProduct.MenuManager = this.barManager1;
            this.txtAdd_priceProduct.Name = "txtAdd_priceProduct";
            this.txtAdd_priceProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_priceProduct.StyleController = this.layoutControl1;
            this.txtAdd_priceProduct.TabIndex = 9;
            // 
            // txtAdd_groupProduct
            // 
            this.txtAdd_groupProduct.Location = new System.Drawing.Point(121, 108);
            this.txtAdd_groupProduct.MenuManager = this.barManager1;
            this.txtAdd_groupProduct.Name = "txtAdd_groupProduct";
            this.txtAdd_groupProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_groupProduct.StyleController = this.layoutControl1;
            this.txtAdd_groupProduct.TabIndex = 8;
            // 
            // txtAdd_SpeciesProduct
            // 
            this.txtAdd_SpeciesProduct.Location = new System.Drawing.Point(121, 84);
            this.txtAdd_SpeciesProduct.MenuManager = this.barManager1;
            this.txtAdd_SpeciesProduct.Name = "txtAdd_SpeciesProduct";
            this.txtAdd_SpeciesProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_SpeciesProduct.StyleController = this.layoutControl1;
            this.txtAdd_SpeciesProduct.TabIndex = 7;
            // 
            // txtAdd_unitProduct
            // 
            this.txtAdd_unitProduct.Location = new System.Drawing.Point(121, 60);
            this.txtAdd_unitProduct.MenuManager = this.barManager1;
            this.txtAdd_unitProduct.Name = "txtAdd_unitProduct";
            this.txtAdd_unitProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_unitProduct.StyleController = this.layoutControl1;
            this.txtAdd_unitProduct.TabIndex = 6;
            // 
            // txtAdd_nameProduct
            // 
            this.txtAdd_nameProduct.Location = new System.Drawing.Point(121, 36);
            this.txtAdd_nameProduct.MenuManager = this.barManager1;
            this.txtAdd_nameProduct.Name = "txtAdd_nameProduct";
            this.txtAdd_nameProduct.Size = new System.Drawing.Size(240, 20);
            this.txtAdd_nameProduct.StyleController = this.layoutControl1;
            this.txtAdd_nameProduct.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Add_IdProduct,
            this.Add_NameProduct,
            this.Add_UnitProduct,
            this.Add_SpeciesProduct,
            this.Add_GroupProduct,
            this.Add_PriceProduct,
            this.Add_ProviderProduct,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(373, 233);
            this.Root.TextVisible = false;
            // 
            // Add_IdProduct
            // 
            this.Add_IdProduct.Control = this.txtAdd_idProduct;
            this.Add_IdProduct.Location = new System.Drawing.Point(0, 0);
            this.Add_IdProduct.Name = "Add_IdProduct";
            this.Add_IdProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_IdProduct.Text = "Mã sản phẩm";
            this.Add_IdProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Add_NameProduct
            // 
            this.Add_NameProduct.Control = this.txtAdd_nameProduct;
            this.Add_NameProduct.Location = new System.Drawing.Point(0, 24);
            this.Add_NameProduct.Name = "Add_NameProduct";
            this.Add_NameProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_NameProduct.Text = "Tên sản phẩm";
            this.Add_NameProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Add_UnitProduct
            // 
            this.Add_UnitProduct.Control = this.txtAdd_unitProduct;
            this.Add_UnitProduct.Location = new System.Drawing.Point(0, 48);
            this.Add_UnitProduct.Name = "Add_UnitProduct";
            this.Add_UnitProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_UnitProduct.Text = "Đơn vị";
            this.Add_UnitProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Add_SpeciesProduct
            // 
            this.Add_SpeciesProduct.Control = this.txtAdd_SpeciesProduct;
            this.Add_SpeciesProduct.Location = new System.Drawing.Point(0, 72);
            this.Add_SpeciesProduct.Name = "Add_SpeciesProduct";
            this.Add_SpeciesProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_SpeciesProduct.Text = "Loại sản phẩm";
            this.Add_SpeciesProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Add_GroupProduct
            // 
            this.Add_GroupProduct.Control = this.txtAdd_groupProduct;
            this.Add_GroupProduct.Location = new System.Drawing.Point(0, 96);
            this.Add_GroupProduct.Name = "Add_GroupProduct";
            this.Add_GroupProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_GroupProduct.Text = "Sản phẩm thuộc nhóm";
            this.Add_GroupProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Add_PriceProduct
            // 
            this.Add_PriceProduct.Control = this.txtAdd_priceProduct;
            this.Add_PriceProduct.Location = new System.Drawing.Point(0, 120);
            this.Add_PriceProduct.Name = "Add_PriceProduct";
            this.Add_PriceProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_PriceProduct.Text = "Đơn giá";
            this.Add_PriceProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Add_ProviderProduct
            // 
            this.Add_ProviderProduct.Control = this.txtAdd_providerProduct;
            this.Add_ProviderProduct.Location = new System.Drawing.Point(0, 144);
            this.Add_ProviderProduct.Name = "Add_ProviderProduct";
            this.Add_ProviderProduct.Size = new System.Drawing.Size(353, 24);
            this.Add_ProviderProduct.Text = "Nhà cung cấp";
            this.Add_ProviderProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(353, 45);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 233);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmAddProduct";
            this.Text = "Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_idProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_providerProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_priceProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_groupProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_SpeciesProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_unitProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdd_nameProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_IdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_NameProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_UnitProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_SpeciesProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_GroupProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_PriceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_ProviderProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barbtnSaveAddProduct;
        private DevExpress.XtraBars.BarButtonItem barbtnCloseAddProduct;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtAdd_priceProduct;
        private DevExpress.XtraEditors.TextEdit txtAdd_groupProduct;
        private DevExpress.XtraEditors.TextEdit txtAdd_SpeciesProduct;
        private DevExpress.XtraEditors.TextEdit txtAdd_unitProduct;
        private DevExpress.XtraEditors.TextEdit txtAdd_nameProduct;
        private DevExpress.XtraEditors.TextEdit txtAdd_idProduct;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Add_IdProduct;
        private DevExpress.XtraLayout.LayoutControlItem Add_NameProduct;
        private DevExpress.XtraLayout.LayoutControlItem Add_UnitProduct;
        private DevExpress.XtraLayout.LayoutControlItem Add_SpeciesProduct;
        private DevExpress.XtraLayout.LayoutControlItem Add_GroupProduct;
        private DevExpress.XtraLayout.LayoutControlItem Add_PriceProduct;
        private DevExpress.XtraBars.BarLargeButtonItem barLargeButtonItem1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtAdd_providerProduct;
        private DevExpress.XtraLayout.LayoutControlItem Add_ProviderProduct;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}