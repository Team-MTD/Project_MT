namespace QLDACNTT_QUANLYKHO
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnAdd_Product = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDelete_Product = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEdit_Product = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnUpdate_Product = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbAdd_Product = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbEdit_Product = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDelete_Product = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbUpdate_Product = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gcData_Product = new DevExpress.XtraGrid.GridControl();
            this.gvData_Product = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.speciesProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.priceProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.providerProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barbtnExit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barBtnAdd_Product,
            this.barbtnDelete_Product,
            this.barbtnEdit_Product,
            this.barbtnUpdate_Product,
            this.barbtnExit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.Size = new System.Drawing.Size(755, 141);
            // 
            // barBtnAdd_Product
            // 
            this.barBtnAdd_Product.Caption = "Thêm sản phẩm";
            this.barBtnAdd_Product.Id = 1;
            this.barBtnAdd_Product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnAdd_Product.ImageOptions.SvgImage")));
            this.barBtnAdd_Product.Name = "barBtnAdd_Product";
            this.barBtnAdd_Product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAdd_Product_ItemClick);
            // 
            // barbtnDelete_Product
            // 
            this.barbtnDelete_Product.Caption = "Xoá sản phẩm";
            this.barbtnDelete_Product.Id = 2;
            this.barbtnDelete_Product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnDelete_Product.ImageOptions.SvgImage")));
            this.barbtnDelete_Product.Name = "barbtnDelete_Product";
            this.barbtnDelete_Product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDelete_Product_ItemClick);
            // 
            // barbtnEdit_Product
            // 
            this.barbtnEdit_Product.Caption = "Sửa thông tin sản phẩm";
            this.barbtnEdit_Product.Id = 3;
            this.barbtnEdit_Product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnEdit_Product.ImageOptions.SvgImage")));
            this.barbtnEdit_Product.Name = "barbtnEdit_Product";
            this.barbtnEdit_Product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEdit_Product_ItemClick);
            // 
            // barbtnUpdate_Product
            // 
            this.barbtnUpdate_Product.Caption = "Cập nhật dữ liệu";
            this.barbtnUpdate_Product.Id = 4;
            this.barbtnUpdate_Product.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnUpdate_Product.ImageOptions.SvgImage")));
            this.barbtnUpdate_Product.Name = "barbtnUpdate_Product";
            this.barbtnUpdate_Product.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnUpdate_Product_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbAdd_Product,
            this.rbEdit_Product,
            this.rbDelete_Product,
            this.rbUpdate_Product,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý sản phẩm";
            // 
            // rbAdd_Product
            // 
            this.rbAdd_Product.AllowTextClipping = false;
            this.rbAdd_Product.ItemLinks.Add(this.barBtnAdd_Product);
            this.rbAdd_Product.Name = "rbAdd_Product";
            this.rbAdd_Product.Text = "                                    ";
            // 
            // rbEdit_Product
            // 
            this.rbEdit_Product.AllowTextClipping = false;
            this.rbEdit_Product.ItemLinks.Add(this.barbtnEdit_Product);
            this.rbEdit_Product.Name = "rbEdit_Product";
            this.rbEdit_Product.Text = "                                 ";
            // 
            // rbDelete_Product
            // 
            this.rbDelete_Product.AllowTextClipping = false;
            this.rbDelete_Product.ItemLinks.Add(this.barbtnDelete_Product);
            this.rbDelete_Product.Name = "rbDelete_Product";
            this.rbDelete_Product.Text = "                                 ";
            this.rbDelete_Product.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.rbDelete_Product_CaptionButtonClick);
            // 
            // rbUpdate_Product
            // 
            this.rbUpdate_Product.AllowTextClipping = false;
            this.rbUpdate_Product.ItemLinks.Add(this.barbtnUpdate_Product);
            this.rbUpdate_Product.Name = "rbUpdate_Product";
            this.rbUpdate_Product.Text = "                                  ";
            this.rbUpdate_Product.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.rbUpdate_Product_CaptionButtonClick);
            // 
            // gcData_Product
            // 
            this.gcData_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcData_Product.Location = new System.Drawing.Point(0, 141);
            this.gcData_Product.MainView = this.gvData_Product;
            this.gcData_Product.Name = "gcData_Product";
            this.gcData_Product.Size = new System.Drawing.Size(755, 407);
            this.gcData_Product.TabIndex = 1;
            this.gcData_Product.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData_Product});
            // 
            // gvData_Product
            // 
            this.gvData_Product.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idProduct,
            this.nameProduct,
            this.unitProduct,
            this.speciesProduct,
            this.groupProduct,
            this.priceProduct,
            this.providerProduct});
            this.gvData_Product.GridControl = this.gcData_Product;
            this.gvData_Product.Name = "gvData_Product";
            // 
            // idProduct
            // 
            this.idProduct.AppearanceCell.Options.UseTextOptions = true;
            this.idProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.idProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.idProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.idProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.idProduct.Caption = "Mã sản phẩm";
            this.idProduct.FieldName = "idsanpham";
            this.idProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("idProduct.ImageOptions.Image")));
            this.idProduct.Name = "idProduct";
            this.idProduct.Visible = true;
            this.idProduct.VisibleIndex = 0;
            this.idProduct.Width = 84;
            // 
            // nameProduct
            // 
            this.nameProduct.AppearanceCell.Options.UseTextOptions = true;
            this.nameProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.nameProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nameProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.nameProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.nameProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.nameProduct.Caption = "Tên sản phẩm";
            this.nameProduct.FieldName = "tensanpham";
            this.nameProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("nameProduct.ImageOptions.Image")));
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Visible = true;
            this.nameProduct.VisibleIndex = 1;
            this.nameProduct.Width = 184;
            // 
            // unitProduct
            // 
            this.unitProduct.AppearanceCell.Options.UseTextOptions = true;
            this.unitProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unitProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.unitProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.unitProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.unitProduct.Caption = "Đơn vị";
            this.unitProduct.FieldName = "donvi";
            this.unitProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("unitProduct.ImageOptions.Image")));
            this.unitProduct.Name = "unitProduct";
            this.unitProduct.Visible = true;
            this.unitProduct.VisibleIndex = 2;
            this.unitProduct.Width = 63;
            // 
            // speciesProduct
            // 
            this.speciesProduct.AppearanceCell.Options.UseTextOptions = true;
            this.speciesProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.speciesProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.speciesProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.speciesProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.speciesProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.speciesProduct.Caption = "Loại sản phẩm";
            this.speciesProduct.FieldName = "loaisanpham";
            this.speciesProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("speciesProduct.ImageOptions.Image")));
            this.speciesProduct.Name = "speciesProduct";
            this.speciesProduct.Visible = true;
            this.speciesProduct.VisibleIndex = 3;
            this.speciesProduct.Width = 76;
            // 
            // groupProduct
            // 
            this.groupProduct.AppearanceCell.Options.UseTextOptions = true;
            this.groupProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.groupProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.groupProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.groupProduct.Caption = "Nhóm sản phẩm";
            this.groupProduct.FieldName = "nhomsanpham";
            this.groupProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupProduct.ImageOptions.Image")));
            this.groupProduct.Name = "groupProduct";
            this.groupProduct.Visible = true;
            this.groupProduct.VisibleIndex = 4;
            this.groupProduct.Width = 88;
            // 
            // priceProduct
            // 
            this.priceProduct.AppearanceCell.Options.UseTextOptions = true;
            this.priceProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.priceProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.priceProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.priceProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.priceProduct.Caption = "Đơn giá";
            this.priceProduct.DisplayFormat.FormatString = "{0:0,0 VND}";
            this.priceProduct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.priceProduct.FieldName = "dongia";
            this.priceProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("priceProduct.ImageOptions.Image")));
            this.priceProduct.Name = "priceProduct";
            this.priceProduct.Visible = true;
            this.priceProduct.VisibleIndex = 5;
            this.priceProduct.Width = 91;
            // 
            // providerProduct
            // 
            this.providerProduct.AppearanceCell.Options.UseTextOptions = true;
            this.providerProduct.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.providerProduct.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.providerProduct.AppearanceHeader.Options.UseTextOptions = true;
            this.providerProduct.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.providerProduct.AppearanceHeader.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.providerProduct.Caption = "Nhà cung cấp";
            this.providerProduct.FieldName = "nhacungcap";
            this.providerProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("providerProduct.ImageOptions.Image")));
            this.providerProduct.Name = "providerProduct";
            this.providerProduct.Visible = true;
            this.providerProduct.VisibleIndex = 6;
            this.providerProduct.Width = 189;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnExit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                                 ";
            // 
            // barbtnExit
            // 
            this.barbtnExit.Caption = "Đóng";
            this.barbtnExit.Id = 5;
            this.barbtnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barbtnExit.Name = "barbtnExit";
            this.barbtnExit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnExit_ItemClick);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 548);
            this.Controls.Add(this.gcData_Product);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProduct";
            this.Text = "QUẢN LÝ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbAdd_Product;
        private DevExpress.XtraGrid.GridControl gcData_Product;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData_Product;
        private DevExpress.XtraBars.BarButtonItem barBtnAdd_Product;
        private DevExpress.XtraBars.BarButtonItem barbtnDelete_Product;
        private DevExpress.XtraBars.BarButtonItem barbtnEdit_Product;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbEdit_Product;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDelete_Product;
        private DevExpress.XtraGrid.Columns.GridColumn idProduct;
        private DevExpress.XtraGrid.Columns.GridColumn nameProduct;
        private DevExpress.XtraGrid.Columns.GridColumn speciesProduct;
        private DevExpress.XtraGrid.Columns.GridColumn groupProduct;
        private DevExpress.XtraGrid.Columns.GridColumn priceProduct;
        private DevExpress.XtraGrid.Columns.GridColumn providerProduct;
        private DevExpress.XtraGrid.Columns.GridColumn unitProduct;
        private DevExpress.XtraBars.BarButtonItem barbtnUpdate_Product;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbUpdate_Product;
        private DevExpress.XtraBars.BarButtonItem barbtnExit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}