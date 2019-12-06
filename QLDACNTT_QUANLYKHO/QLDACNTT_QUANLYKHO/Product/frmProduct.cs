using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDACNTT_QUANLYKHO
{
    public partial class frmProduct : DevExpress.XtraEditors.XtraForm
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            DataDemoDataContext db = new DataDemoDataContext();
            var dsSP = db.SANPHAMs.ToList();
            gcData_Product.DataSource = dsSP;
        }

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
            if(XtraMessageBox.Show("Bạn có muốn xoá sản phẩm đang chọn?","Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData_Product.FocusedRowHandle;
                string col_fieldname = "idsanpham";
                string nameProduct = "tensanpham";
                object value = gvData_Product.GetRowCellValue(row_index, col_fieldname);
                object valueNameProduct = gvData_Product.GetRowCellValue(row_index, nameProduct);
                if (value != null)
                {
                    
                    DataDemoDataContext db = new DataDemoDataContext();
                    var _sanpham = db.SANPHAMs.Where(s=>s.idsanpham == (String)value).SingleOrDefault();
                    //XtraMessageBox.Show("Id có giá trị là: " + value.ToString());
                    if (_sanpham != null)
                    {
                        db.SANPHAMs.DeleteOnSubmit(_sanpham);
                        db.SubmitChanges();
                        XtraMessageBox.Show("Đã xoá thành công sản phẩm: "+ valueNameProduct.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
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
            add.isAdd = true;
            add.ShowDialog();
            loadData();
        }
        private void barbtnEdit_Product_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row_index = gvData_Product.FocusedRowHandle;
            string col_fieldname = "idsanpham";
            object value = gvData_Product.GetRowCellValue(row_index, col_fieldname);
            if (value != null)
            {
                frmAddProduct _frmAddProduct = new frmAddProduct();
                _frmAddProduct.Id =Convert.ToInt32 (value);
                _frmAddProduct.isAdd = false;
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
    }
}