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
using QLDACNTT_QUANLYKHO.Stock;
//using QLDACNTT_QUANLYKHO.Stock;

namespace QLDACNTT_QUANLYKHO
{
    public partial class frmStock : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bus func = new bus();
        public delegate void DelegateShow(Kho pro);
        //Delegate contructor
        DelegateShow ShowForm;

        //Form
        frmAddStock _frmAddStock;
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
            //DataDemoDataContext db = new DataDemoDataContext();
            //var dsKHO = db.KHOs.ToList();
            this.gcData_Stock.DataSource = func.Get_Kho();
        }
        private Kho GetData(string id)
        {
            var data = func.TimKiemKho(id);
            Kho prod = new Kho();

            if (data != null)
            {
                var x = data.ToList();
                foreach (var item in x)
                {
                    prod.MaKho = item.idkho;
                    prod.TenKho = item.tenkho;
                    prod.ViTriKho = item.vitrikho;
                }
                return prod;
            }
            return null;
        }
        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá kho đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData_stock.FocusedRowHandle;
                string col_fieldname = "idkho";
                string name = "tenkho";
                object value = gvData_stock.GetRowCellValue(row_index, col_fieldname);
                object valueName = gvData_stock.GetRowCellValue(row_index, name);
                if (value != null)
                {
                    if (func.Delete_KH((string)value))
                    {
                        XtraMessageBox.Show("Đã xoá thành công kho: " + valueName.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Quá trình xóa đã gặp vấn đề: " + valueName.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                _frmAddStock = new frmAddStock();
                //_frmAddProduct.isAdd = false;
                ShowForm = new DelegateShow(_frmAddStock.showData);       //Gọi sang hàm bên FrmAdd
                ShowForm(GetData((string)value));
                _frmAddStock.ShowDialog();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn kho để chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmAddStock add = new frmAddStock();
            //add.isAdd = true;
            add.ShowDialog();
            loadData();
        }
    }
}