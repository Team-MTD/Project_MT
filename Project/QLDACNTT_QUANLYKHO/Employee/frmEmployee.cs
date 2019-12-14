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
        public delegate void DelegateShow(NhanVien prov);
        public frmEmployee()
        {
            InitializeComponent();
        }

        //Delegate contructor
        DelegateShow ShowForm;

        //Form
        frmUpdateEmployee updateEmployee;

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            loadData();
        }
        #region Methods of form
        private NhanVien GetData(int id)
        {
            var data = func.KiemtraNhanVien(id);
            NhanVien prov = new NhanVien();

            if (data != null)
            {
                var x = data.ToList();
                foreach (var item in x)
                {
                    prov.IdNhanVien = item.idnhansu;
                    prov.TenNhanVien = item.tennhansu;
                    prov.Gioitinh = item.gioitinh.ToString();
                    prov.DiaChi = item.diachi;
                    prov.DienThoai = item.dienthoai;
                    prov.Email = item.email;
                    prov.ChucVu = item.chucvu;
                    prov.NgayVaoLam = item.ngayvaolam;
                }
                return prov;
            }
            return null;
        }
        #endregion
        private void loadData()
        {
            gcData_Employee.DataSource = func.Get_NhanVien();

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
                updateEmployee = new frmUpdateEmployee();
                ShowForm = new DelegateShow(updateEmployee.showData);       //Gọi sang hàm bên FrmUpdateProvider
                ShowForm(GetData((int)value));
                updateEmployee.ShowDialog();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn nhân sự để chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barbtnDelEmployee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá nhân viên đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData_Employee.FocusedRowHandle;
                string col_fieldname = "idnhansu";
                string name = "tennhansu";
                object value = gvData_Employee.GetRowCellValue(row_index, col_fieldname);
                object valueName = gvData_Employee.GetRowCellValue(row_index, name);
                if (value != null)
                {
                    if (func.Delete_NhanVien((int)value))
                    {
                        XtraMessageBox.Show("Đã xoá thành công nhân viên: " + valueName.ToString().ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Quá trình xóa đã gặp vấn đề: " + valueName.ToString().ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn nhân viên cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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