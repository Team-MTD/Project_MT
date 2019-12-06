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
    public partial class frmAddProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        public int Id = -1;
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            fillData(); 
        }
        public bool isAdd = true;
        private void fillData()
        {
            if (Id > 0)
            {
                DataDemoDataContext db = new DataDemoDataContext();
                var _product = db.SANPHAMs.Where(s => s.idsanpham == Convert.ToString(Id)).SingleOrDefault();
                if (_product != null)
                {
                    txtAdd_idProduct.Properties.ReadOnly = true;
                    txtAdd_idProduct.Properties.Appearance.BackColor = Color.Gainsboro;
                    txtAdd_idProduct.EditValue = _product.idsanpham;
                    txtAdd_nameProduct.EditValue = _product.tensanpham;
                    txtAdd_unitProduct.EditValue = _product.donvi;
                    txtAdd_SpeciesProduct.EditValue = _product.loaisanpham;
                    txtAdd_groupProduct.EditValue = _product.nhomsanpham;
                    txtAdd_priceProduct.EditValue = _product.dongia;
                    txtAdd_providerProduct.EditValue = _product.nhacungcap;
                }
            }
        }
        private bool save()
        {
            String _IdProduct="";
            String _NameProduct = "";
            String _UnitProduct = "";
            String _SpeciesProduct = "";
            String _GroupProduct = "";
            String _PriceProduct = "";
            String _ProviderProduct = "";
            if (txtAdd_idProduct.EditValue != null)
                _IdProduct = txtAdd_idProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mã sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_idProduct.Focus();
                return false;
            }
            if(txtAdd_nameProduct.EditValue != null)
                _NameProduct = txtAdd_nameProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_nameProduct.Focus();
                return false;
            }
            if (txtAdd_unitProduct.EditValue != null)
                _UnitProduct = txtAdd_unitProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập đơn vị sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_unitProduct.Focus();
                return false;
            }
            if(txtAdd_SpeciesProduct.EditValue != null)
                _SpeciesProduct = txtAdd_SpeciesProduct.EditValue.ToString();
            if(txtAdd_groupProduct.EditValue != null)
                _GroupProduct = txtAdd_groupProduct.EditValue.ToString();
            if(txtAdd_priceProduct.EditValue != null)
                _PriceProduct = txtAdd_priceProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập đơn giá sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdd_priceProduct.Focus();
                return false;
            }
            if (txtAdd_providerProduct.EditValue != null)
                _ProviderProduct = txtAdd_providerProduct.EditValue.ToString();
            try
            {
                DataDemoDataContext db = new DataDemoDataContext();
                SANPHAM _product = null;
                if (isAdd)
                {
                    _product = new SANPHAM();
                }
                else
                {
                    _product = db.SANPHAMs.Where(s => s.idsanpham == Convert.ToString(Id)).SingleOrDefault();
                }
                _product.idsanpham = _IdProduct;
                _product.tensanpham = _NameProduct;
                _product.donvi = _UnitProduct;
                _product.loaisanpham = _SpeciesProduct;
                _product.nhomsanpham = _GroupProduct;
                _product.dongia =Convert.ToInt32(_PriceProduct);
                _product.nhacungcap = _ProviderProduct;
                if (isAdd)
                {
                    db.SANPHAMs.InsertOnSubmit(_product);
                }
                db.SubmitChanges();
                if (isAdd)
                {
                    XtraMessageBox.Show("Thêm sản phẩm thành công: " +
                    "\nMã sản phẩm: " + _IdProduct +
                    "\nTên sản phẩm: " + _NameProduct +
                    "\nĐơn vị: " + _UnitProduct +
                    "\nLoại sản phẩm: " + _SpeciesProduct +
                    "\nNhóm sản phẩm: " + _GroupProduct +
                    "\nĐơn giá sản phẩm: " + _PriceProduct +
                    "\nNhà cung cấp sản phẩm: " + _ProviderProduct, "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Chỉnh sửa thông tin sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (isAdd)
                {
                    txtAdd_idProduct.EditValue = null;
                    txtAdd_nameProduct.EditValue = null;
                    txtAdd_unitProduct.EditValue = null;
                    txtAdd_SpeciesProduct.EditValue = null;
                    txtAdd_groupProduct.EditValue = null;
                    txtAdd_priceProduct.EditValue = null;
                    txtAdd_providerProduct.EditValue = null;
                }
                txtAdd_idProduct.Focus();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        private void barbtnSaveAddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            save();
        }

        private void barbtnCloseAddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtAdd_idProduct_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}