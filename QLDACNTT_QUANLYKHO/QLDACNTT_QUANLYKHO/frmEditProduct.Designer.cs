namespace QLDACNTT_QUANLYKHO
{
    partial class frmEditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditProduct));
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barbtnSaveEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnCloseEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtEdit_idProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_nameProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_unitProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_SpeciesProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_groupProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_priceProduct = new DevExpress.XtraEditors.TextEdit();
            this.txtEdit_providerProduct = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Edit_IdProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Edit_NameProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Edit_UnitProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Edit_SpeciesProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Edit_GroupProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Edit_PriceProduct = new DevExpress.XtraLayout.LayoutControlItem();
            this.Edit_ProviderProduct = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_idProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_nameProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_unitProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_SpeciesProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_groupProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_priceProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_providerProduct.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_IdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_NameProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_UnitProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_SpeciesProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_GroupProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_PriceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_ProviderProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager2
            // 
            this.barManager2.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar4});
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            this.barManager2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnSaveEditProduct,
            this.barbtnCloseEditProduct});
            this.barManager2.MainMenu = this.bar2;
            this.barManager2.MaxItemId = 3;
            this.barManager2.StatusBar = this.bar4;
            // 
            // bar2
            // 
            this.bar2.BarName = "MainMenu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnSaveEditProduct),
            new DevExpress.XtraBars.LinkPersistInfo(this.barbtnCloseEditProduct)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "MainMenu";
            // 
            // barbtnSaveEditProduct
            // 
            this.barbtnSaveEditProduct.Caption = "Lưu";
            this.barbtnSaveEditProduct.Id = 0;
            this.barbtnSaveEditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnSaveEditProduct.ImageOptions.SvgImage")));
            this.barbtnSaveEditProduct.Name = "barbtnSaveEditProduct";
            this.barbtnSaveEditProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barbtnSaveEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnSaveEditProduct_ItemClick);
            // 
            // barbtnCloseEditProduct
            // 
            this.barbtnCloseEditProduct.Caption = "Đóng";
            this.barbtnCloseEditProduct.Id = 1;
            this.barbtnCloseEditProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnCloseEditProduct.ImageOptions.SvgImage")));
            this.barbtnCloseEditProduct.Name = "barbtnCloseEditProduct";
            this.barbtnCloseEditProduct.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar4
            // 
            this.bar4.BarName = "StatusBar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "StatusBar";
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(593, 24);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 215);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(593, 23);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 191);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(593, 24);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 191);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtEdit_idProduct);
            this.layoutControl1.Controls.Add(this.txtEdit_nameProduct);
            this.layoutControl1.Controls.Add(this.txtEdit_unitProduct);
            this.layoutControl1.Controls.Add(this.txtEdit_SpeciesProduct);
            this.layoutControl1.Controls.Add(this.txtEdit_groupProduct);
            this.layoutControl1.Controls.Add(this.txtEdit_priceProduct);
            this.layoutControl1.Controls.Add(this.txtEdit_providerProduct);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 24);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(593, 191);
            this.layoutControl1.TabIndex = 8;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtEdit_idProduct
            // 
            this.txtEdit_idProduct.Location = new System.Drawing.Point(121, 12);
            this.txtEdit_idProduct.Name = "txtEdit_idProduct";
            this.txtEdit_idProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_idProduct.StyleController = this.layoutControl1;
            this.txtEdit_idProduct.TabIndex = 4;
            // 
            // txtEdit_nameProduct
            // 
            this.txtEdit_nameProduct.Location = new System.Drawing.Point(121, 36);
            this.txtEdit_nameProduct.Name = "txtEdit_nameProduct";
            this.txtEdit_nameProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_nameProduct.StyleController = this.layoutControl1;
            this.txtEdit_nameProduct.TabIndex = 5;
            // 
            // txtEdit_unitProduct
            // 
            this.txtEdit_unitProduct.Location = new System.Drawing.Point(121, 60);
            this.txtEdit_unitProduct.Name = "txtEdit_unitProduct";
            this.txtEdit_unitProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_unitProduct.StyleController = this.layoutControl1;
            this.txtEdit_unitProduct.TabIndex = 6;
            // 
            // txtEdit_SpeciesProduct
            // 
            this.txtEdit_SpeciesProduct.Location = new System.Drawing.Point(121, 84);
            this.txtEdit_SpeciesProduct.Name = "txtEdit_SpeciesProduct";
            this.txtEdit_SpeciesProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_SpeciesProduct.StyleController = this.layoutControl1;
            this.txtEdit_SpeciesProduct.TabIndex = 7;
            // 
            // txtEdit_groupProduct
            // 
            this.txtEdit_groupProduct.Location = new System.Drawing.Point(121, 108);
            this.txtEdit_groupProduct.Name = "txtEdit_groupProduct";
            this.txtEdit_groupProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_groupProduct.StyleController = this.layoutControl1;
            this.txtEdit_groupProduct.TabIndex = 8;
            // 
            // txtEdit_priceProduct
            // 
            this.txtEdit_priceProduct.Location = new System.Drawing.Point(121, 132);
            this.txtEdit_priceProduct.Name = "txtEdit_priceProduct";
            this.txtEdit_priceProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_priceProduct.StyleController = this.layoutControl1;
            this.txtEdit_priceProduct.TabIndex = 9;
            // 
            // txtEdit_providerProduct
            // 
            this.txtEdit_providerProduct.Location = new System.Drawing.Point(121, 156);
            this.txtEdit_providerProduct.Name = "txtEdit_providerProduct";
            this.txtEdit_providerProduct.Size = new System.Drawing.Size(460, 20);
            this.txtEdit_providerProduct.StyleController = this.layoutControl1;
            this.txtEdit_providerProduct.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Edit_IdProduct,
            this.Edit_NameProduct,
            this.Edit_UnitProduct,
            this.Edit_SpeciesProduct,
            this.Edit_GroupProduct,
            this.Edit_PriceProduct,
            this.Edit_ProviderProduct});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(593, 191);
            this.Root.TextVisible = false;
            // 
            // Edit_IdProduct
            // 
            this.Edit_IdProduct.Control = this.txtEdit_idProduct;
            this.Edit_IdProduct.CustomizationFormText = "Mã sản phẩm";
            this.Edit_IdProduct.Location = new System.Drawing.Point(0, 0);
            this.Edit_IdProduct.Name = "Edit_IdProduct";
            this.Edit_IdProduct.Size = new System.Drawing.Size(573, 24);
            this.Edit_IdProduct.Text = "Mã sản phẩm";
            this.Edit_IdProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Edit_NameProduct
            // 
            this.Edit_NameProduct.Control = this.txtEdit_nameProduct;
            this.Edit_NameProduct.CustomizationFormText = "Tên sản phẩm";
            this.Edit_NameProduct.Location = new System.Drawing.Point(0, 24);
            this.Edit_NameProduct.Name = "Edit_NameProduct";
            this.Edit_NameProduct.Size = new System.Drawing.Size(573, 24);
            this.Edit_NameProduct.Text = "Tên sản phẩm";
            this.Edit_NameProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Edit_UnitProduct
            // 
            this.Edit_UnitProduct.Control = this.txtEdit_unitProduct;
            this.Edit_UnitProduct.CustomizationFormText = "Đơn vị";
            this.Edit_UnitProduct.Location = new System.Drawing.Point(0, 48);
            this.Edit_UnitProduct.Name = "Edit_UnitProduct";
            this.Edit_UnitProduct.Size = new System.Drawing.Size(573, 24);
            this.Edit_UnitProduct.Text = "Đơn vị";
            this.Edit_UnitProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Edit_SpeciesProduct
            // 
            this.Edit_SpeciesProduct.Control = this.txtEdit_SpeciesProduct;
            this.Edit_SpeciesProduct.CustomizationFormText = "Loại sản phẩm";
            this.Edit_SpeciesProduct.Location = new System.Drawing.Point(0, 72);
            this.Edit_SpeciesProduct.Name = "Edit_SpeciesProduct";
            this.Edit_SpeciesProduct.Size = new System.Drawing.Size(573, 24);
            this.Edit_SpeciesProduct.Text = "Loại sản phẩm";
            this.Edit_SpeciesProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Edit_GroupProduct
            // 
            this.Edit_GroupProduct.Control = this.txtEdit_groupProduct;
            this.Edit_GroupProduct.CustomizationFormText = "Sản phẩm thuộc nhóm";
            this.Edit_GroupProduct.Location = new System.Drawing.Point(0, 96);
            this.Edit_GroupProduct.Name = "Edit_GroupProduct";
            this.Edit_GroupProduct.Size = new System.Drawing.Size(573, 24);
            this.Edit_GroupProduct.Text = "Sản phẩm thuộc nhóm";
            this.Edit_GroupProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Edit_PriceProduct
            // 
            this.Edit_PriceProduct.Control = this.txtEdit_priceProduct;
            this.Edit_PriceProduct.CustomizationFormText = "Đơn giá";
            this.Edit_PriceProduct.Location = new System.Drawing.Point(0, 120);
            this.Edit_PriceProduct.Name = "Edit_PriceProduct";
            this.Edit_PriceProduct.Size = new System.Drawing.Size(573, 24);
            this.Edit_PriceProduct.Text = "Đơn giá";
            this.Edit_PriceProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // Edit_ProviderProduct
            // 
            this.Edit_ProviderProduct.Control = this.txtEdit_providerProduct;
            this.Edit_ProviderProduct.CustomizationFormText = "Nhà cung cấp";
            this.Edit_ProviderProduct.Location = new System.Drawing.Point(0, 144);
            this.Edit_ProviderProduct.Name = "Edit_ProviderProduct";
            this.Edit_ProviderProduct.Size = new System.Drawing.Size(573, 27);
            this.Edit_ProviderProduct.Text = "Nhà cung cấp";
            this.Edit_ProviderProduct.TextSize = new System.Drawing.Size(106, 13);
            // 
            // frmEditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 238);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "frmEditProduct";
            this.Text = "Chỉnh sửa thông tin sản phẩm";
            this.Load += new System.EventHandler(this.frmEditProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_idProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_nameProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_unitProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_SpeciesProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_groupProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_priceProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdit_providerProduct.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_IdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_NameProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_UnitProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_SpeciesProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_GroupProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_PriceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_ProviderProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barbtnSaveEditProduct;
        private DevExpress.XtraBars.BarButtonItem barbtnCloseEditProduct;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtEdit_idProduct;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Edit_IdProduct;
        private DevExpress.XtraEditors.TextEdit txtEdit_nameProduct;
        private DevExpress.XtraEditors.TextEdit txtEdit_unitProduct;
        private DevExpress.XtraEditors.TextEdit txtEdit_SpeciesProduct;
        private DevExpress.XtraEditors.TextEdit txtEdit_groupProduct;
        private DevExpress.XtraEditors.TextEdit txtEdit_priceProduct;
        private DevExpress.XtraEditors.TextEdit txtEdit_providerProduct;
        private DevExpress.XtraLayout.LayoutControlItem Edit_NameProduct;
        private DevExpress.XtraLayout.LayoutControlItem Edit_UnitProduct;
        private DevExpress.XtraLayout.LayoutControlItem Edit_SpeciesProduct;
        private DevExpress.XtraLayout.LayoutControlItem Edit_GroupProduct;
        private DevExpress.XtraLayout.LayoutControlItem Edit_PriceProduct;
        private DevExpress.XtraLayout.LayoutControlItem Edit_ProviderProduct;
    }
}