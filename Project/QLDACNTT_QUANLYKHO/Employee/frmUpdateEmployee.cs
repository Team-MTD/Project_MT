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
using BUS_KHOHANG;
using DTO_Data;

namespace QLDACNTT_QUANLYKHO.Employee
{
    public partial class frmUpdateEmployee : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public bus func = new bus();
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }
        
        #region // Methods of form
        public void showData(NhanVien proz)
        {
            txtIdEmployee.Text = proz.IdNhanVien.ToString();
            txtNameEmployee.Text = proz.TenNhanVien;
            txtAddressEmployee.Text = proz.DiaChi;
            txtEmailEmployee.Text = proz.Email;
            txtPhoneEployee.Text = proz.DienThoai;
            txtChucvu.Text = proz.ChucVu;
            cboGioitinh.Text = proz.Gioitinh;
        }

        #endregion
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
        public bool isAdd = true;
        public int Id = -1;

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {


        }
        private void dropPosition_Click(object sender, EventArgs e)
        {

        }
        
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUpdateEmployee_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the 'qLKHODataSet.NHANSU' table. You can move, or remove it, as needed.
                //this.nHANSUTableAdapter.Fill(this.qLKHODataSet.NHANSU);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
                
            
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtIdEmployee.Text != "" && txtNameEmployee.Text != "" && txtPhoneEployee.Text != ""
                && txtAddressEmployee.Text != "" && txtChucvu.Text != "")
            {
                var nhanvien = new NhanVien()
                {
                    IdNhanVien = Convert.ToInt32(txtIdEmployee.Text),
                    TenNhanVien = txtNameEmployee.Text,
                    DiaChi = txtAddressEmployee.Text,
                    DienThoai = txtPhoneEployee.Text,
                    ChucVu = txtChucvu.Text,
                    Gioitinh = cboGioitinh.SelectedValue.ToString(),
                    Email = txtEmailEmployee.Text,
                    NgayVaoLam = ngayvaolam.DateTime,
                };
                // Kiểm tra nếu nhân viên tồn tại:
                if (func.KiemtraNhanVien(nhanvien.IdNhanVien) != null)
                {
                    // Cập nhật lại thông tin nhân viên
                    if (func.Update_NhanVien(nhanvien))
                    {
                        XtraMessageBox.Show("Cập nhật nhân viên thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Có vấn đề trong quá trình cập nhật ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Tạo mới một nhân viên
                    if (func.Insert_NhanVien(nhanvien))
                    {
                        XtraMessageBox.Show("Đã thêm thành công nhà cung cấp: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Lỗi: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            this.Close();
        }
    } 
}