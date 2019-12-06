namespace QLDACNTT_QUANLYKHO.Employee
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.toolbarFormManager1 = new DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barbtnUpdateEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnEditEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnDelEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnClose = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcData_Employee = new DevExpress.XtraGrid.GridControl();
            this.gvData_Employee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidnhansu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltennhansu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgioitinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colchucvu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsodienthoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiachi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colngayvaolam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbarFormManager1
            // 
            this.toolbarFormManager1.DockControls.Add(this.barDockControlTop);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlBottom);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlLeft);
            this.toolbarFormManager1.DockControls.Add(this.barDockControlRight);
            this.toolbarFormManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.toolbarFormManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 540);
            this.barDockControlBottom.Manager = this.toolbarFormManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(892, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.toolbarFormManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 540);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(892, 0);
            this.barDockControlRight.Manager = this.toolbarFormManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 540);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barbtnUpdateEmployee,
            this.barbtnEditEmployee,
            this.barbtnDelEmployee,
            this.barbtnClose,
            this.btnRefresh});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(892, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // barbtnUpdateEmployee
            // 
            this.barbtnUpdateEmployee.Caption = "Thêm nhân viên mới";
            this.barbtnUpdateEmployee.Id = 1;
            this.barbtnUpdateEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnUpdateEmployee.ImageOptions.Image")));
            this.barbtnUpdateEmployee.Name = "barbtnUpdateEmployee";
            this.barbtnUpdateEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnUpdateEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnUpdateEmployee_ItemClick);
            // 
            // barbtnEditEmployee
            // 
            this.barbtnEditEmployee.Caption = "Chỉnh sửa thông tin";
            this.barbtnEditEmployee.Id = 2;
            this.barbtnEditEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnEditEmployee.ImageOptions.Image")));
            this.barbtnEditEmployee.Name = "barbtnEditEmployee";
            this.barbtnEditEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnEditEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnEditEmployee_ItemClick);
            // 
            // barbtnDelEmployee
            // 
            this.barbtnDelEmployee.Caption = "Xoá nhân viên";
            this.barbtnDelEmployee.Id = 3;
            this.barbtnDelEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnDelEmployee.ImageOptions.Image")));
            this.barbtnDelEmployee.Name = "barbtnDelEmployee";
            this.barbtnDelEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnDelEmployee.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnDelEmployee_ItemClick);
            // 
            // barbtnClose
            // 
            this.barbtnClose.Caption = "Đóng";
            this.barbtnClose.Id = 4;
            this.barbtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnClose.ImageOptions.Image")));
            this.barbtnClose.Name = "barbtnClose";
            this.barbtnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barbtnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnClose_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Cập nhật dữ liệu";
            this.btnRefresh.Id = 5;
            this.btnRefresh.ImageOptions.Image = global::QLDACNTT_QUANLYKHO.Properties.Resources.reset2_16x16;
            this.btnRefresh.ImageOptions.LargeImage = global::QLDACNTT_QUANLYKHO.Properties.Resources.reset2_32x32;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup4});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtnUpdateEmployee);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "                                ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barbtnEditEmployee);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "                                ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barbtnDelEmployee);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            this.ribbonPageGroup3.Text = "                                ";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barbtnClose);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            this.ribbonPageGroup4.Text = "                                ";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.btnRefresh);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            this.ribbonPageGroup5.Text = "                                ";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 509);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(892, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcData_Employee);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 143);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 158, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(892, 366);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcData_Employee
            // 
            this.gcData_Employee.Location = new System.Drawing.Point(12, 12);
            this.gcData_Employee.MainView = this.gvData_Employee;
            this.gcData_Employee.MenuManager = this.toolbarFormManager1;
            this.gcData_Employee.Name = "gcData_Employee";
            this.gcData_Employee.Size = new System.Drawing.Size(868, 342);
            this.gcData_Employee.TabIndex = 4;
            this.gcData_Employee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvData_Employee});
            // 
            // gvData_Employee
            // 
            this.gvData_Employee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidnhansu,
            this.coltennhansu,
            this.colgioitinh,
            this.colchucvu,
            this.colsodienthoai,
            this.colemail,
            this.coldiachi,
            this.colngayvaolam});
            this.gvData_Employee.GridControl = this.gcData_Employee;
            this.gvData_Employee.Name = "gvData_Employee";
            // 
            // colidnhansu
            // 
            this.colidnhansu.Caption = "Mã nhân viên";
            this.colidnhansu.FieldName = "idnhansu";
            this.colidnhansu.Name = "colidnhansu";
            this.colidnhansu.OptionsColumn.AllowEdit = false;
            this.colidnhansu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colidnhansu.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colidnhansu.OptionsColumn.AllowMove = false;
            this.colidnhansu.OptionsColumn.AllowShowHide = false;
            this.colidnhansu.Visible = true;
            this.colidnhansu.VisibleIndex = 0;
            // 
            // coltennhansu
            // 
            this.coltennhansu.Caption = "Tên nhân viên";
            this.coltennhansu.FieldName = "tennhansu";
            this.coltennhansu.Name = "coltennhansu";
            this.coltennhansu.OptionsColumn.AllowEdit = false;
            this.coltennhansu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.coltennhansu.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.coltennhansu.OptionsColumn.AllowMove = false;
            this.coltennhansu.OptionsColumn.AllowShowHide = false;
            this.coltennhansu.Visible = true;
            this.coltennhansu.VisibleIndex = 1;
            this.coltennhansu.Width = 145;
            // 
            // colgioitinh
            // 
            this.colgioitinh.Caption = "Giới tính";
            this.colgioitinh.FieldName = "gioitinh";
            this.colgioitinh.Name = "colgioitinh";
            this.colgioitinh.OptionsColumn.AllowEdit = false;
            this.colgioitinh.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colgioitinh.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colgioitinh.OptionsColumn.AllowMove = false;
            this.colgioitinh.OptionsColumn.AllowShowHide = false;
            this.colgioitinh.Visible = true;
            this.colgioitinh.VisibleIndex = 2;
            this.colgioitinh.Width = 46;
            // 
            // colchucvu
            // 
            this.colchucvu.Caption = "Chức vụ";
            this.colchucvu.FieldName = "chucvu";
            this.colchucvu.Name = "colchucvu";
            this.colchucvu.OptionsColumn.AllowEdit = false;
            this.colchucvu.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colchucvu.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colchucvu.OptionsColumn.AllowMove = false;
            this.colchucvu.OptionsColumn.AllowShowHide = false;
            this.colchucvu.Visible = true;
            this.colchucvu.VisibleIndex = 3;
            this.colchucvu.Width = 81;
            // 
            // colsodienthoai
            // 
            this.colsodienthoai.Caption = "Số điện thoại";
            this.colsodienthoai.FieldName = "dienthoai";
            this.colsodienthoai.Name = "colsodienthoai";
            this.colsodienthoai.OptionsColumn.AllowEdit = false;
            this.colsodienthoai.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colsodienthoai.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colsodienthoai.OptionsColumn.AllowMove = false;
            this.colsodienthoai.OptionsColumn.AllowShowHide = false;
            this.colsodienthoai.Visible = true;
            this.colsodienthoai.VisibleIndex = 4;
            this.colsodienthoai.Width = 78;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colemail.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colemail.OptionsColumn.AllowMove = false;
            this.colemail.OptionsColumn.AllowShowHide = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 5;
            this.colemail.Width = 114;
            // 
            // coldiachi
            // 
            this.coldiachi.Caption = "Địa chỉ";
            this.coldiachi.FieldName = "diachi";
            this.coldiachi.Name = "coldiachi";
            this.coldiachi.OptionsColumn.AllowEdit = false;
            this.coldiachi.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.coldiachi.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.coldiachi.OptionsColumn.AllowMove = false;
            this.coldiachi.OptionsColumn.AllowShowHide = false;
            this.coldiachi.Visible = true;
            this.coldiachi.VisibleIndex = 6;
            this.coldiachi.Width = 170;
            // 
            // colngayvaolam
            // 
            this.colngayvaolam.Caption = "Ngày vào làm";
            this.colngayvaolam.FieldName = "ngayvaolam";
            this.colngayvaolam.Name = "colngayvaolam";
            this.colngayvaolam.OptionsColumn.AllowEdit = false;
            this.colngayvaolam.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.colngayvaolam.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.colngayvaolam.OptionsColumn.AllowMove = false;
            this.colngayvaolam.OptionsColumn.AllowShowHide = false;
            this.colngayvaolam.Visible = true;
            this.colngayvaolam.VisibleIndex = 7;
            this.colngayvaolam.Width = 141;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(892, 366);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcData_Employee;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(872, 346);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 540);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmEmployee";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toolbarFormManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvData_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.ToolbarForm.ToolbarFormManager toolbarFormManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcData_Employee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvData_Employee;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem barbtnUpdateEmployee;
        private DevExpress.XtraBars.BarButtonItem barbtnEditEmployee;
        private DevExpress.XtraBars.BarButtonItem barbtnDelEmployee;
        private DevExpress.XtraBars.BarButtonItem barbtnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraGrid.Columns.GridColumn colidnhansu;
        private DevExpress.XtraGrid.Columns.GridColumn coltennhansu;
        private DevExpress.XtraGrid.Columns.GridColumn colgioitinh;
        private DevExpress.XtraGrid.Columns.GridColumn colchucvu;
        private DevExpress.XtraGrid.Columns.GridColumn colsodienthoai;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn coldiachi;
        private DevExpress.XtraGrid.Columns.GridColumn colngayvaolam;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
    }
}