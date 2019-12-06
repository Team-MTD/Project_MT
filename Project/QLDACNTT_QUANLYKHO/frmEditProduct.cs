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
    public partial class frmEditProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmEditProduct()
        {
            InitializeComponent();
        }
        public int Id = -1;
        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            fillData();
        }
        public void fillData()
        {
            if (Id > 0)
            {
                DataDemoDataContext db = new DataDemoDataContext();
                var _product = db.SANPHAMs.Where(s => s.idsanpham == Convert.ToString(Id)).SingleOrDefault();
                if (_product != null)
                {
                    txtEdit_idProduct.EditValue = _product.idsanpham;
                    txtEdit_nameProduct.EditValue = _product.tensanpham;
                    txtEdit_unitProduct.EditValue = _product.donvi;
                    txtEdit_SpeciesProduct.EditValue = _product.loaisanpham;
                    txtEdit_groupProduct.EditValue = _product.nhomsanpham;
                    txtEdit_priceProduct.EditValue = _product.dongia;
                    txtEdit_providerProduct.EditValue = _product.nhacungcap;
                }
            }
        }
        private bool saveEdit()
        {
            String _IdProduct = "";
            String _NameProduct = "";
            String _UnitProduct = "";
            String _SpeciesProduct = "";
            String _GroupProduct = "";
            String _PriceProduct = "";
            String _ProviderProduct = "";
            if (txtEdit_idProduct.EditValue != null)
                _IdProduct = txtEdit_idProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập mã sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEdit_idProduct.Focus();
                return false;
            }
            if (txtEdit_nameProduct.EditValue != null)
                _NameProduct = txtEdit_nameProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập tên sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEdit_nameProduct.Focus();
                return false;
            }
            if (txtEdit_unitProduct.EditValue != null)
                _UnitProduct = txtEdit_unitProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập đơn vị sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEdit_unitProduct.Focus();
                return false;
            }
            if (txtEdit_SpeciesProduct.EditValue != null)
                _SpeciesProduct = txtEdit_SpeciesProduct.EditValue.ToString();
            if (txtEdit_groupProduct.EditValue != null)
                _GroupProduct = txtEdit_groupProduct.EditValue.ToString();
            if (txtEdit_priceProduct.EditValue != null)
                _PriceProduct = txtEdit_priceProduct.EditValue.ToString();
            else
            {
                XtraMessageBox.Show("Bạn chưa nhập đơn giá sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEdit_priceProduct.Focus();
                return false;
            }
            if (txtEdit_providerProduct.EditValue != null)
                _ProviderProduct = txtEdit_providerProduct.EditValue.ToString();
            try
            {
                DataDemoDataContext db = new DataDemoDataContext();
                var _product = db.SANPHAMs.Where(s => s.idsanpham == Convert.ToString(Id)).SingleOrDefault();
                _product = new SANPHAM();
                _product.idsanpham = _IdProduct;
                _product.tensanpham = _NameProduct;
                _product.donvi = _UnitProduct;
                _product.loaisanpham = _SpeciesProduct;
                _product.nhomsanpham = _GroupProduct;
                _product.dongia = Convert.ToInt32(_PriceProduct);
                _product.nhacungcap = _ProviderProduct;
                db.SubmitChanges();
                XtraMessageBox.Show("Chỉnh sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEdit_idProduct.Focus();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        private void barbtnSaveEditProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //saveEdit();
        }
    }
}