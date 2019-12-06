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

namespace QLDACNTT_QUANLYKHO
{
    public partial class frmUpdateProvider : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        public frmUpdateProvider()
        {
            InitializeComponent();
        }

        private void barbtnExitAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barbtnSaveAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
            this.Close();

        }
        public bool isAdd = true;
        public int Id = -1;
        private void frmUpdateProvider_Load(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            if (Id > 0)
            {
                DataDemoDataContext db = new DataDemoDataContext();
                var _provider = db.PROVIDERs.Where(s => s.idnhacungcap == (Id)).SingleOrDefault();
                if (_provider != null)
                {
                    //txtAdd_idProvider.Visible = true;
                    //txtAdd_idProvider.ReadOnly = true;
                    txtAdd_idProvider.Properties.ReadOnly = true;
                    //txtAdd_idProvider.Properties.AppearanceReadOnly.ForeColor = Color.Black;
                    //txtAdd_idProvider.Properties.Appearance.ForeColor = Color.Black;
                    //txtAdd_idProvider.Properties.AppearanceReadOnly.BackColor = Color.White;
                    txtAdd_idProvider.Properties.Appearance.BackColor = Color.Gainsboro;
                    txtAdd_idProvider.EditValue = _provider.idnhacungcap;
                    txtAdd_nameProvider.EditValue = _provider.tennhacungcap;
                    txtAdd_addressProvider.EditValue = _provider.diachinhacungcap;
                    txtAdd_phoneProvider.EditValue = _provider.sdtnhacungcap.ToString();
                }
            }
        }
        private bool save()
        {
            String _idProvider = "";
            String _nameProvider = "";
            String _addressProvider = "";
            String _phoneProvider = "";

            if (txtAdd_idProvider.EditValue != null)
                _idProvider = txtAdd_idProvider.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mã nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_idProvider.Focus();
                return false;
            }
            if (txtAdd_nameProvider.EditValue != null)
                _nameProvider = txtAdd_nameProvider.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tên nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_nameProvider.Focus();
                return false;
            }
            if (txtAdd_addressProvider.EditValue != null)
                _addressProvider = txtAdd_addressProvider.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập địa chỉ nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_addressProvider.Focus();
                return false;
            }
            if (txtAdd_phoneProvider.EditValue != null)
                _phoneProvider = txtAdd_phoneProvider.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập số điện thoại của nhà cung cấp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_phoneProvider.Focus();
                return false;
            }
            try
            {
                DataDemoDataContext db = new DataDemoDataContext();
                PROVIDER _provider = null;
                if (isAdd)
                {
                    _provider = new PROVIDER();
                }
                else
                {
                    _provider = db.PROVIDERs.Where(s => s.idnhacungcap == (Id)).SingleOrDefault();
                }
                _provider.idnhacungcap = Convert.ToInt16(_idProvider);
                _provider.tennhacungcap = _nameProvider;
                _provider.diachinhacungcap = _addressProvider;
                _provider.sdtnhacungcap = _phoneProvider;
                if (isAdd)
                {
                    db.PROVIDERs.InsertOnSubmit(_provider);
                }
                db.SubmitChanges();
                if (isAdd)
                {
                    XtraMessageBox.Show("Thêm nhà cung cấp thành công: " +
                    "\nMã nhà cung cấp: " + _idProvider.ToString() +
                    "\nTên nhà cung cấp: " + _nameProvider +
                    "\nĐịa chỉ nhà cung cấp: " + _addressProvider +
                    "\nSố điện thoại nhà cung cấp: " + _phoneProvider.ToString(), "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Chỉnh sửa thông tin nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (isAdd)
                {
                    txtAdd_idProvider.EditValue = null;
                    txtAdd_nameProvider.EditValue = null;
                    txtAdd_addressProvider.EditValue = null;
                    txtAdd_phoneProvider.EditValue = null;
                }
                txtAdd_idProvider.Focus();
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }
        private void txtAdd_idProvider_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
            this.Close();
        }
    }
}