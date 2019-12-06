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

namespace QLDACNTT_QUANLYKHO.Employee
{
    public partial class frmUpdateEmployee : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmUpdateEmployee()
        {
            InitializeComponent();
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fillData();
            save();
        }
        public bool isAdd = true;
        public int Id = -1;

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            if (Id > 0)
            {
                DataDemoDataContext db = new DataDemoDataContext();
                var _nhansu = db.NHANSUs.Where(s => s.idnhansu == Convert.ToInt32(Id)).SingleOrDefault();
                if (_nhansu != null)
                {
                    
                    txtIdEmployee.Properties.ReadOnly = true;
                    txtIdEmployee.Properties.Appearance.BackColor = Color.Gainsboro;
                    txtIdEmployee.EditValue = _nhansu.idnhansu;
                    txtNameEmployee.EditValue = _nhansu.tennhansu;
                    txtAddressEmployee.EditValue = _nhansu.diachi;
                    txtPhoneEployee.EditValue = _nhansu.dienthoai;
                    txtEmailEmployee.EditValue = _nhansu.email;
                    
                }
            }
        }
        private bool save()
        {
            String _idEmployee = "";
            String _nameEmployee = "";
            String _addressEmployee = "";
            String _phoneEmployee = "";
            String _emailEmployee = "";

            if  (txtIdEmployee.EditValue != null)
                _idEmployee = txtIdEmployee.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mã nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdEmployee.Focus();
                return false;
            }
            if (txtNameEmployee.EditValue != null)
                _nameEmployee = txtNameEmployee.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tên nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNameEmployee.Focus();
                return false;
            }
            if (txtAddressEmployee.EditValue != null)
                _addressEmployee = txtAddressEmployee.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập địa chỉ nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddressEmployee.Focus();
                return false;
            }
            if (txtPhoneEployee.EditValue != null)
                _phoneEmployee = txtPhoneEployee.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập số điện thoại của nhân viên!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhoneEployee.Focus();
                return false;
            }
            //if (txtEmailEmployee.EditValue != null)
              //  _emailEmployee = txtEmailEmployee.EditValue.ToString();
            try
            {
                DataDemoDataContext db = new DataDemoDataContext();
                NHANSU _nhansu = null;
                if (isAdd)
                {
                    _nhansu = new NHANSU();
                }
                else
                {
                    _nhansu = db.NHANSUs.Where(s => s.idnhansu == (Id)).SingleOrDefault();
                }
                _nhansu.idnhansu =Convert.ToInt32(_idEmployee);
                _nhansu.tennhansu= _nameEmployee;
                _nhansu.diachi = _addressEmployee;
                _nhansu.dienthoai = _phoneEmployee;
                if (isAdd)
                {
                    db.NHANSUs.InsertOnSubmit(_nhansu);
                }
                db.SubmitChanges();
                if (isAdd)
                {
                    XtraMessageBox.Show("Thêm nhân viên thành công: " +
                    "\nMã nhân viên: " + _idEmployee.ToString() +
                    "\nTên nhân viên: " + _nameEmployee +
                    "\nĐịa chỉ nhân viên: " + _addressEmployee +
                    "\nSố điện thoại: " + _phoneEmployee.ToString()+
                    "\nEmail: " + _emailEmployee, "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Chỉnh sửa thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (isAdd)
                {
                    txtIdEmployee.EditValue = null;
                    txtNameEmployee.EditValue = null;
                    txtAddressEmployee.EditValue = null;
                    txtEmailEmployee.EditValue = null;
                    txtPhoneEployee.EditValue = null;
                }
                txtIdEmployee.Focus();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
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
            this.nHANSUTableAdapter.Fill(this.qLKHODataSet.NHANSU);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}