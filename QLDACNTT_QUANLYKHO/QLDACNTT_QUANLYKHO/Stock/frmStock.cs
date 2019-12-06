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
using QLDACNTT_QUANLYKHO.Stock;

namespace QLDACNTT_QUANLYKHO
{
    public partial class frmStock : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmStock()
        {
            InitializeComponent();
        }

        private void btnClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            DataDemoDataContext db = new DataDemoDataContext();
            var dsKHO = db.KHOs.ToList();
            gcData_Stock.DataSource = dsKHO;
        }
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá kho đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData_stock.FocusedRowHandle;
                string col_fieldname = "idkho";
                string nameProduct = "tenkho";
                object value = gvData_stock.GetRowCellValue(row_index, col_fieldname);
                object valueNameStock = gvData_stock.GetRowCellValue(row_index, nameProduct);
                if (value != null)
                {

                    DataDemoDataContext db = new DataDemoDataContext();
                    var _kho = db.KHOs.Where(s => s.idkho == (String)value).SingleOrDefault();
                    //XtraMessageBox.Show("Id có giá trị là: " + value.ToString());
                    if (_kho != null)
                    {
                        db.KHOs.DeleteOnSubmit(_kho);
                        db.SubmitChanges();
                        XtraMessageBox.Show("Đã xoá thành công kho: " + valueNameStock.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn kho cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int row_index = gvData_stock.FocusedRowHandle;
            string col_fieldname = "idkho";
            object value = gvData_stock.GetRowCellValue(row_index, col_fieldname);
            if (value != null)
            {
                frmAddStock _frmAddStock = new frmAddStock();
                _frmAddStock.Id = Convert.ToInt32(value);
                _frmAddStock.isAdd = false;
                _frmAddStock.ShowDialog();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn sản phẩm để chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadData();
            frmAddStock _stock = new frmAddStock();
            _stock.isAdd = true;
            _stock.ShowDialog();
            loadData();
        }
    }
}