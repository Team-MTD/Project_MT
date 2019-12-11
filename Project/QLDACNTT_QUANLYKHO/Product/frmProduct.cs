using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using BUS_KHOHANG;
using DTO_Data;


namespace QLDACNTT_QUANLYKHO
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        public bus func = new bus();
        public delegate void DelegateShow(Product pro);




        //Delegate contructor
        DelegateShow ShowForm;

        //Form
        frmAddProduct _frmAddProduct;

        /// <summary>
        /// 
        /// </summary>
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }


        #region //Method of form
        private void loadData()
        {
            this.gcData_Product.DataSource = func.Get_SanPham();
        }

                
        private Product GetData(string id)
        {
            var data = func.TimKiemSanPham(id);
            Product prod = new Product();
            
            if (data!=null)
            {
                var x = data.ToList();
                foreach (var item in x)
                {
                    prod.IdSanPham = item.idsanpham;
                    prod.TenSanPham = item.tensanpham;
                    prod.NhomSanPham = item.nhomsanpham;
                    prod.NhaCungCap = item.nhacungcap;
                    prod.LoaiSanPham = item.loaisanpham;
                    prod.DonGia = item.dongia;
                    prod.DonVi = item.donvi;
                    prod.NhomSanPham = item.nhomsanpham;
                }
                return prod;
            }
            return null;
        }
        #endregion

        #region Event of form
        private void rbUpdate_Product_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
            loadData();
        }

        private void barbtnUpdate_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
        }

        private void barbtnDelete_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá sản phẩm đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData_Product.FocusedRowHandle;
                string col_fieldname = "idsanpham";
                string nameProduct = "tensanpham";
                object value = gvData_Product.GetRowCellValue(row_index, col_fieldname);
                object valueNameProduct = gvData_Product.GetRowCellValue(row_index, nameProduct);
                if (value != null)
                {
                    if (func.Delete_SanPham((string)value))
                    {
                        XtraMessageBox.Show("Đã xoá thành công sản phẩm: " + valueNameProduct.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Quá trình xóa đã gặp vấn đề: " + valueNameProduct.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn sản phẩm cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void rbDelete_Product_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {

        }

        private void barBtnAdd_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddProduct add = new frmAddProduct();
            //add.isAdd = true;
            add.ShowDialog();
            loadData(); //Load data after close form add_product
        }


        private void barbtnEdit_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row_index = gvData_Product.FocusedRowHandle;
            string col_fieldname = "idsanpham";
            object value = gvData_Product.GetRowCellValue(row_index, col_fieldname);
            if (value != null)
            {
                _frmAddProduct = new frmAddProduct();
                //_frmAddProduct.isAdd = false;
                ShowForm = new DelegateShow(_frmAddProduct.showData);       //Gọi sang hàm bên FrmAdd
                ShowForm(GetData((string)value));
                _frmAddProduct.ShowDialog();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn sản phẩm để chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void barbtnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}