namespace QLDACNTT_QUANLYKHO.Employee
{
    partial class frmUpdateEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateEmployee));
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbbgioitinh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.qLKHODataSet = new QLDACNTT_QUANLYKHO.QLKHODataSet();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.nHANSUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateJobEmployee = new System.Windows.Forms.DateTimePicker();
            this.txtAddressEmployee = new DevExpress.XtraEditors.TextEdit();
            this.txtEmailEmployee = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneEployee = new DevExpress.XtraEditors.TextEdit();
            this.txtNameEmployee = new DevExpress.XtraEditors.TextEdit();
            this.txtIdEmployee = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboPositon = new DevExpress.XtraLayout.LayoutControlItem();
            this.cboGender = new DevExpress.XtraLayout.LayoutControlItem();
            this.nHANSUTableAdapter = new QLDACNTT_QUANLYKHO.QLKHODataSetTableAdapters.NHANSUTableAdapter();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbgioitinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANSUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddressEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneEployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPositon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButton1);
            this.layoutControl1.Controls.Add(this.cbbgioitinh);
            this.layoutControl1.Controls.Add(this.comboBoxEdit1);
            this.layoutControl1.Controls.Add(this.dateJobEmployee);
            this.layoutControl1.Controls.Add(this.txtAddressEmployee);
            this.layoutControl1.Controls.Add(this.txtEmailEmployee);
            this.layoutControl1.Controls.Add(this.txtPhoneEployee);
            this.layoutControl1.Controls.Add(this.txtNameEmployee);
            this.layoutControl1.Controls.Add(this.txtIdEmployee);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 80);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(473, 258);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.qLKHODataSet, "NHANSU.gioitinh", true));
            this.cbbgioitinh.Location = new System.Drawing.Point(83, 60);
            this.cbbgioitinh.MenuManager = this.ribbonControl1;
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbgioitinh.Properties.Tag = "<Null>";
            this.cbbgioitinh.Size = new System.Drawing.Size(378, 20);
            this.cbbgioitinh.StyleController = this.layoutControl1;
            this.cbbgioitinh.TabIndex = 14;
            // 
            // qLKHODataSet
            // 
            this.qLKHODataSet.DataSetName = "QLKHODataSet";
            this.qLKHODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.nHANSUBindingSource, "chucvu", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "(\"chucvu\")"));
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", this.nHANSUBindingSource, "chucvu", true));
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.nHANSUBindingSource, "chucvu", true));
            this.comboBoxEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHANSUBindingSource, "chucvu", true));
            this.comboBoxEdit1.EditValue = "<Null>";
            this.comboBoxEdit1.Location = new System.Drawing.Point(83, 84);
            this.comboBoxEdit1.MenuManager = this.ribbonControl1;
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(378, 20);
            this.comboBoxEdit1.StyleController = this.layoutControl1;
            this.comboBoxEdit1.TabIndex = 13;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // nHANSUBindingSource
            // 
            this.nHANSUBindingSource.DataMember = "NHANSU";
            this.nHANSUBindingSource.DataSource = this.qLKHODataSet;
            // 
            // dateJobEmployee
            // 
            this.dateJobEmployee.CustomFormat = "{:dd/MM/yyyy}";
            this.dateJobEmployee.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.nHANSUBindingSource, "ngayvaolam", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.dateJobEmployee.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateJobEmployee.Location = new System.Drawing.Point(83, 180);
            this.dateJobEmployee.Name = "dateJobEmployee";
            this.dateJobEmployee.Size = new System.Drawing.Size(378, 21);
            this.dateJobEmployee.TabIndex = 12;
            // 
            // txtAddressEmployee
            // 
            this.txtAddressEmployee.Location = new System.Drawing.Point(83, 156);
            this.txtAddressEmployee.MenuManager = this.ribbonControl1;
            this.txtAddressEmployee.Name = "txtAddressEmployee";
            this.txtAddressEmployee.Size = new System.Drawing.Size(378, 20);
            this.txtAddressEmployee.StyleController = this.layoutControl1;
            this.txtAddressEmployee.TabIndex = 11;
            // 
            // txtEmailEmployee
            // 
            this.txtEmailEmployee.Location = new System.Drawing.Point(83, 132);
            this.txtEmailEmployee.MenuManager = this.ribbonControl1;
            this.txtEmailEmployee.Name = "txtEmailEmployee";
            this.txtEmailEmployee.Size = new System.Drawing.Size(378, 20);
            this.txtEmailEmployee.StyleController = this.layoutControl1;
            this.txtEmailEmployee.TabIndex = 10;
            // 
            // txtPhoneEployee
            // 
            this.txtPhoneEployee.Location = new System.Drawing.Point(83, 108);
            this.txtPhoneEployee.MenuManager = this.ribbonControl1;
            this.txtPhoneEployee.Name = "txtPhoneEployee";
            this.txtPhoneEployee.Size = new System.Drawing.Size(378, 20);
            this.txtPhoneEployee.StyleController = this.layoutControl1;
            this.txtPhoneEployee.TabIndex = 9;
            // 
            // txtNameEmployee
            // 
            this.txtNameEmployee.Location = new System.Drawing.Point(83, 36);
            this.txtNameEmployee.MenuManager = this.ribbonControl1;
            this.txtNameEmployee.Name = "txtNameEmployee";
            this.txtNameEmployee.Size = new System.Drawing.Size(378, 20);
            this.txtNameEmployee.StyleController = this.layoutControl1;
            this.txtNameEmployee.TabIndex = 5;
            // 
            // txtIdEmployee
            // 
            this.txtIdEmployee.Location = new System.Drawing.Point(83, 12);
            this.txtIdEmployee.MenuManager = this.ribbonControl1;
            this.txtIdEmployee.Name = "txtIdEmployee";
            this.txtIdEmployee.Size = new System.Drawing.Size(378, 20);
            this.txtIdEmployee.StyleController = this.layoutControl1;
            this.txtIdEmployee.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.cboPositon,
            this.cboGender,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(473, 258);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtIdEmployee;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem1.Text = "Mã nhân viên";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(68, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 192);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(226, 46);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNameEmployee;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem2.Text = "Tên nhân viên";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPhoneEployee;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem6.Text = "Số điện thoại";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtEmailEmployee;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem7.Text = "Email";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtAddressEmployee;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem8.Text = "Địa chỉ";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(68, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.dateJobEmployee;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 168);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(453, 24);
            this.layoutControlItem9.Text = "Ngày vào làm";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(68, 13);
            // 
            // cboPositon
            // 
            this.cboPositon.Control = this.comboBoxEdit1;
            this.cboPositon.Location = new System.Drawing.Point(0, 72);
            this.cboPositon.Name = "cboPositon";
            this.cboPositon.Size = new System.Drawing.Size(453, 24);
            this.cboPositon.Text = "Chức vụ";
            this.cboPositon.TextSize = new System.Drawing.Size(68, 13);
            // 
            // cboGender
            // 
            this.cboGender.Control = this.cbbgioitinh;
            this.cboGender.Location = new System.Drawing.Point(0, 48);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(453, 24);
            this.cboGender.Text = "Giới tính";
            this.cboGender.TextSize = new System.Drawing.Size(68, 13);
            // 
            // nHANSUTableAdapter
            // 
            this.nHANSUTableAdapter.ClearBeforeFill = true;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.simpleButton1;
            this.layoutControlItem3.Location = new System.Drawing.Point(226, 192);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(227, 46);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 0);
            this.simpleButton1.Location = new System.Drawing.Point(238, 204);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(223, 38);
            this.simpleButton1.StyleController = this.layoutControl1;
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Lưu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 1;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Name = "btnSave";
            this.btnSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "Đóng";
            this.btnClose.Id = 2;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Name = "btnClose";
            this.btnClose.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.TabletOffice;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(473, 80);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // frmUpdateEmployee
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 338);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmUpdateEmployee";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Cập nhật nhân viên";
            this.Load += new System.EventHandler(this.frmUpdateEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbgioitinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLKHODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHANSUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddressEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmailEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneEployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboPositon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.DateTimePicker dateJobEmployee;
        private DevExpress.XtraEditors.TextEdit txtAddressEmployee;
        private DevExpress.XtraEditors.TextEdit txtEmailEmployee;
        private DevExpress.XtraEditors.TextEdit txtPhoneEployee;
        private DevExpress.XtraEditors.TextEdit txtNameEmployee;
        private DevExpress.XtraEditors.TextEdit txtIdEmployee;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraLayout.LayoutControlItem cboPositon;
        private QLKHODataSet qLKHODataSet;
        private System.Windows.Forms.BindingSource nHANSUBindingSource;
        private QLKHODataSetTableAdapters.NHANSUTableAdapter nHANSUTableAdapter;
        private DevExpress.XtraEditors.ComboBoxEdit cbbgioitinh;
        private DevExpress.XtraLayout.LayoutControlItem cboGender;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnClose;
    }
}