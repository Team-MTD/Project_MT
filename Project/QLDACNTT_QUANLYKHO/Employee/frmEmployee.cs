using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO_Data;
using BUS_KHOHANG;


namespace QLDACNTT_QUANLYKHO.Employee
{
    public partial class frmEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bus func = new bus();
        public delegate void DelegateShow(NhanSu ns);
        public frmEmployee()
        {
            InitializeComponent();
        }
        DelegateShow ShowForm;
        frmUpdateEmployee _frmUpdateEmployee;

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            //DataDemoDataContext db = new DataDemoDataContext();
            //var dsNS = db.NHANSUs.ToList();
            //gcData_Employee.DataSource = dsNS;
            this.gcData_Employee.DataSource = func.Get_NhanSu();
        }
        private NhanSu GetData(int id)
        {
            var data = func.KiemtraNhanSu(id);
            NhanSu prov = new NhanSu();

            if (data != null)
            {
                var x = data.ToList();

                prov.IdNhanSu = x[0].idnhansu;
                prov.DienThoai = x[0].dienthoai;
                prov.TenNhanSu = x[0].tennhansu;
                prov.DiaChi = x[0].diachi;
                return prov;
            }
            return null;
        }
        private void barbtnUpdateEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUpdateEmployee updateEmployee = new frmUpdateEmployee();
            updateEmployee.isAdd = true;
            updateEmployee.ShowDialog();
            loadData();
        }

        private void barbtnEditEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row_index = gvData_Employee.FocusedRowHandle;
            string col_fieldname = "idnhansu";
            object value = gvData_Employee.GetRowCellValue(row_index, col_fieldname);
            if (value != null)
            {
                frmUpdateEmployee _frmUpdateEmployee = new frmUpdateEmployee();
                _frmUpdateEmployee.Id = (int)(value);
                _frmUpdateEmployee.isAdd = false;
                _frmUpdateEmployee.ShowDialog();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn nhà cung cấp để chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barbtnDelEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //if (XtraMessageBox.Show("Bạn có muốn xoá nhân viên đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    int row_index = gvData_Employee.FocusedRowHandle;
            //    string col_fieldname = "idnhansu";
            //    string nameEmployee = "tennhansu";
            //    object value = gvData_Employee.GetRowCellValue(row_index, col_fieldname);
            //    object valueNameEmployee = gvData_Employee.GetRowCellValue(row_index, nameEmployee);
            //    if (value != null)
            //    {

            //        DataDemoDataContext db = new DataDemoDataContext();
            //        var _nhansu = db.NHANSUs.Where(s => s.idnhansu == (int)value).SingleOrDefault();
            //        //XtraMessageBox.Show("Id có giá trị là: " + value.ToString());
            //        if (_nhansu != null)
            //        {
            //            db.NHANSUs.DeleteOnSubmit(_nhansu);
            //            db.SubmitChanges();
            //            XtraMessageBox.Show("Đã xoá thành công nhân viên: " + valueNameEmployee.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            loadData();
            //        }
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("Chưa chọn nhân viên cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
        }
        private void barbtnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }
    }
}