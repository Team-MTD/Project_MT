namespace QLDACNTT_QUANLYKHO.Report
{
    partial class Reportfrm
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
            this.btnExcelNhap = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLocXuat = new DevExpress.XtraEditors.SimpleButton();
            this.dtTo2 = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFrom2 = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcelOut = new DevExpress.XtraEditors.SimpleButton();
            this.gcDataOut_Export = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.dtTo1 = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom1 = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.gcData_Export = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataOut_Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcelNhap
            // 
            this.btnExcelNhap.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelNhap.Appearance.Options.UseFont = true;
            this.btnExcelNhap.Location = new System.Drawing.Point(928, 449);
            this.btnExcelNhap.Name = "btnExcelNhap";
            this.btnExcelNhap.Size = new System.Drawing.Size(182, 86);
            this.btnExcelNhap.TabIndex = 1;
            this.btnExcelNhap.Text = "Xuất Excel";
            this.btnExcelNhap.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(1177, 719);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupBox2);
            this.xtraTabPage2.Controls.Add(this.btnExcelOut);
            this.xtraTabPage2.Controls.Add(this.gcDataOut_Export);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1169, 680);
            this.xtraTabPage2.Text = "Thống kê xuất kho";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLocXuat);
            this.groupBox2.Controls.Add(this.dtTo2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtFrom2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(849, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 222);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc theo thời gian";
            // 
            // btnLocXuat
            // 
            this.btnLocXuat.Location = new System.Drawing.Point(81, 154);
            this.btnLocXuat.Name = "btnLocXuat";
            this.btnLocXuat.Size = new System.Drawing.Size(182, 38);
            this.btnLocXuat.TabIndex = 7;
            this.btnLocXuat.Text = "Lọc";
            this.btnLocXuat.Click += new System.EventHandler(this.btnLocXuat_Click);
            // 
            // dtTo2
            // 
            this.dtTo2.EditValue = null;
            this.dtTo2.Location = new System.Drawing.Point(59, 99);
            this.dtTo2.Name = "dtTo2";
            this.dtTo2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo2.Size = new System.Drawing.Size(238, 28);
            this.dtTo2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến:";
            // 
            // dtFrom2
            // 
            this.dtFrom2.EditValue = null;
            this.dtFrom2.Location = new System.Drawing.Point(59, 47);
            this.dtFrom2.Name = "dtFrom2";
            this.dtFrom2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom2.Size = new System.Drawing.Size(238, 28);
            this.dtFrom2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Từ:";
            // 
            // btnExcelOut
            // 
            this.btnExcelOut.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelOut.Appearance.Options.UseFont = true;
            this.btnExcelOut.Location = new System.Drawing.Point(930, 441);
            this.btnExcelOut.Name = "btnExcelOut";
            this.btnExcelOut.Size = new System.Drawing.Size(182, 86);
            this.btnExcelOut.TabIndex = 4;
            this.btnExcelOut.Text = "Xuất Excel";
            this.btnExcelOut.Click += new System.EventHandler(this.btnExcelOut_Click);
            // 
            // gcDataOut_Export
            // 
            this.gcDataOut_Export.Location = new System.Drawing.Point(-1, 3);
            this.gcDataOut_Export.MainView = this.gridView2;
            this.gcDataOut_Export.Name = "gcDataOut_Export";
            this.gcDataOut_Export.Size = new System.Drawing.Size(842, 684);
            this.gcDataOut_Export.TabIndex = 3;
            this.gcDataOut_Export.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gcDataOut_Export;
            this.gridView2.Name = "gridView2";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Controls.Add(this.gcData_Export);
            this.xtraTabPage1.Controls.Add(this.btnExcelNhap);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1169, 680);
            this.xtraTabPage1.Text = "Thống kê nhập kho";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.dtTo1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFrom1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(847, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 222);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc theo thời gian";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(81, 154);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(182, 38);
            this.btnLoc.TabIndex = 7;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dtTo1
            // 
            this.dtTo1.EditValue = null;
            this.dtTo1.Location = new System.Drawing.Point(59, 99);
            this.dtTo1.Name = "dtTo1";
            this.dtTo1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtTo1.Size = new System.Drawing.Size(238, 28);
            this.dtTo1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đến:";
            // 
            // dtFrom1
            // 
            this.dtFrom1.EditValue = null;
            this.dtFrom1.Location = new System.Drawing.Point(59, 47);
            this.dtFrom1.Name = "dtFrom1";
            this.dtFrom1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFrom1.Size = new System.Drawing.Size(238, 28);
            this.dtFrom1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Từ:";
            // 
            // gcData_Export
            // 
            this.gcData_Export.Location = new System.Drawing.Point(-1, 3);
            this.gcData_Export.MainView = this.gridView1;
            this.gcData_Export.Name = "gcData_Export";
            this.gcData_Export.Size = new System.Drawing.Size(842, 684);
            this.gcData_Export.TabIndex = 2;
            this.gcData_Export.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcData_Export;
            this.gridView1.Name = "gridView1";
            // 
            // Reportfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 718);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "Reportfrm";
            this.Text = "Reportfrm";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDataOut_Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtTo1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFrom1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcData_Export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnExcelNhap;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraGrid.GridControl gcData_Export;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.SimpleButton btnLocXuat;
        private DevExpress.XtraEditors.DateEdit dtTo2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtFrom2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnExcelOut;
        private DevExpress.XtraGrid.GridControl gcDataOut_Export;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
        private DevExpress.XtraEditors.DateEdit dtTo1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dtFrom1;
        private System.Windows.Forms.Label label1;
    }
}