namespace QLDACNTT_QUANLYKHO
{
    partial class frmProvider
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProvider));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnAddProvider = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEditProvider = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDelProvider = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnExitProvider = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcData_Provider = new DevExpress.XtraGrid.GridControl();
            this.gvData_Provider = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNameProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddressProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumProvider = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_Provider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtnAddProvider,
            this.barbtnEditProvider,
            this.barbtnDelProvider,
            this.barbtnExitProvider});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(726, 141);
            // 
            // barbtnAddProvider
            // 
            this.barbtnAddProvider.Caption = "Thêm nhà cung cấp";
            this.barbtnAddProvider.Id = 1;
            this.barbtnAddProvider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnAddProvider.ImageOptions.SvgImage")));
            this.barbtnAddProvider.Name = "barbtnAddProvider";
            this.barbtnAddProvider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnAddProvider_ItemClick);
            // 
            // barbtnEditProvider
            // 
            this.barbtnEditProvider.Caption = "Chỉnh sửa thông tin";
            this.barbtnEditProvider.Id = 2;
            this.barbtnEditProvider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnEditProvider.ImageOptions.SvgImage")));
            this.barbtnEditProvider.Name = "barbtnEditProvider";
            this.barbtnEditProvider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEditProvider_ItemClick);
            // 
            // barbtnDelProvider
            // 
            this.barbtnDelProvider.Caption = "Xoá nhà cung cấp";
            this.barbtnDelProvider.Id = 3;
            this.barbtnDelProvider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnDelProvider.ImageOptions.SvgImage")));
            this.barbtnDelProvider.Name = "barbtnDelProvider";
            this.barbtnDelProvider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDelProvider_ItemClick);
            // 
            // barbtnExitProvider
            // 
            this.barbtnExitProvider.Caption = "Đóng";
            this.barbtnExitProvider.Id = 4;
            this.barbtnExitProvider.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barbtnExitProvider.ImageOptions.SvgImage")));
            this.barbtnExitProvider.Name = "barbtnExitProvider";
            this.barbtnExitProvider.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnExitProvider_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý nhà cung cấp";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnAddProvider);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "                                            ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnEditProvider);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "                                           ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnDelProvider);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "                                     ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnExitProvider);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "                                 ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcData_Provider);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 141);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(726, 387);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcData_Provider
            // 
            this.gcData_Provider.Location = new System.Drawing.Point(12, 12);
            this.gcData_Provider.MainView = this.gvData_Provider;
            this.gcData_Provider.MenuManager = this.ribbonControl1;
            this.gcData_Provider.Name = "gcData_Provider";
            this.gcData_Provider.Size = new System.Drawing.Size(702, 363);
            this.gcData_Provider.TabIndex = 4;
            this.gcData_Provider.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData_Provider});
            // 
            // gvData_Provider
            // 
            this.gvData_Provider.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidProvider,
            this.colNameProvider,
            this.colAddressProvider,
            this.colPhoneNumProvider});
            this.gvData_Provider.GridControl = this.gcData_Provider;
            this.gvData_Provider.Name = "gvData_Provider";
            // 
            // colidProvider
            // 
            this.colidProvider.Caption = "Mã nhà cung cấp";
            this.colidProvider.FieldName = "idnhacungcap";
            this.colidProvider.Name = "colidProvider";
            this.colidProvider.Visible = true;
            this.colidProvider.VisibleIndex = 0;
            this.colidProvider.Width = 110;
            // 
            // colNameProvider
            // 
            this.colNameProvider.Caption = "Tên nhà cung cấp";
            this.colNameProvider.FieldName = "tennhacungcap";
            this.colNameProvider.Name = "colNameProvider";
            this.colNameProvider.Visible = true;
            this.colNameProvider.VisibleIndex = 1;
            this.colNameProvider.Width = 191;
            // 
            // colAddressProvider
            // 
            this.colAddressProvider.Caption = "Địa chỉ nhà cung cấp";
            this.colAddressProvider.FieldName = "diachinhacungcap";
            this.colAddressProvider.Name = "colAddressProvider";
            this.colAddressProvider.Visible = true;
            this.colAddressProvider.VisibleIndex = 2;
            this.colAddressProvider.Width = 210;
            // 
            // colPhoneNumProvider
            // 
            this.colPhoneNumProvider.Caption = "Số điện thoại";
            this.colPhoneNumProvider.FieldName = "sdtnhacungcap";
            this.colPhoneNumProvider.Name = "colPhoneNumProvider";
            this.colPhoneNumProvider.Visible = true;
            this.colPhoneNumProvider.VisibleIndex = 3;
            this.colPhoneNumProvider.Width = 173;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(726, 387);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcData_Provider;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(706, 367);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 528);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmProvider";
            this.Text = "Quản lý nhà cung cấp";
            this.Load += new System.EventHandler(this.frmProvider_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_Provider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barbtnAddProvider;
        private DevExpress.XtraBars.BarButtonItem barbtnEditProvider;
        private DevExpress.XtraBars.BarButtonItem barbtnDelProvider;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcData_Provider;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData_Provider;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem barbtnExitProvider;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.Columns.GridColumn colidProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colNameProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colAddressProvider;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumProvider;
    }
}