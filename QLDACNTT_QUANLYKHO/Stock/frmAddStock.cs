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

namespace QLDACNTT_QUANLYKHO.Stock
{
    public partial class frmAddStock : DevExpress.XtraEditors.XtraForm
    {
        public frmAddStock()
        {
            InitializeComponent();
        }
        public int Id = -1;
        public bool isAdd = true;
        private void frmAddStock_Load(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            //if (Id > 0)
            //{
            //    DataDemoDataContext db = new DataDemoDataContext();
            //    var _kho = db.KHOs.Where(s => s.idkho == Convert.ToString(Id)).SingleOrDefault();
            //    if (_kho != null)
            //    {
            //        txtidStock.Properties.ReadOnly = true;
            //        txtidStock.Properties.Appearance.BackColor = Color.Gainsboro;
            //        txtidStock.EditValue = _kho.idkho;
            //        txtnameStock.EditValue = _kho.tenkho;
            //        txtlocationStock.EditValue = _kho.vitrikho;
            //    }
            //}
        }
        private bool save()
        {
            String _idStock = "";
            String _nameStock = "";
            String _locationStock = "";
            if (txtidStock.EditValue != null)
                _idStock = txtidStock.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mã kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidStock.Focus();
                return false;
            }
            if (txtnameStock.EditValue != null)
                _nameStock = txtnameStock.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tên kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnameStock.Focus();
                return false;
            }
            if (txtlocationStock.EditValue != null)
                _locationStock = txtlocationStock.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập vị trí kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtlocationStock.Focus();
                return false;
            }
            //try
            //{
            //    DataDemoDataContext db = new DataDemoDataContext();
            //    KHO _kho = null;
            //    if (isAdd)
            //    {
            //        _kho = new KHO();
            //    }
            //    else
            //    {
            //        _kho = db.KHOs.Where(s => s.idkho == Convert.ToString(Id)).SingleOrDefault();
            //    }
            //    _kho.idkho = _idStock;
            //    _kho.tenkho = _nameStock;
            //    _kho.vitrikho = _locationStock;
            //    if (isAdd)
            //    {
            //        db.KHOs.InsertOnSubmit(_kho);   
            //    }
            //    db.SubmitChanges();
            //    if (isAdd)
            //    {
            //        XtraMessageBox.Show("Thêm kho mới thành công: " +
            //        "\nMã kho: " + _idStock +
            //        "\nTên kho: " + _nameStock +
            //        "\nVị trí kho: " + _locationStock , "Thông báo",
            //         MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        XtraMessageBox.Show("Chỉnh sửa thông tin kho thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    if (isAdd)
            //    {
            //        txtidStock.EditValue = null;
            //        txtnameStock.EditValue = null;
            //        txtlocationStock.EditValue = null;
            //    }
            //    txtidStock.Focus();
            //    return true;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
            return false;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}