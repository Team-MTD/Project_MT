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
    public partial class frmProvider : DevExpress.XtraEditors.XtraForm
    {
        public frmProvider()
        {
            InitializeComponent();
        }

        private void frmProvider_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            DataDemoDataContext db = new DataDemoDataContext();
            var dsNCC = db.PROVIDERs.ToList();
            gcData_Provider.DataSource = dsNCC;
        }
        private void barbtnDelProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá nhà cung cấp đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gvData_Provider.FocusedRowHandle;
                string col_fieldname = "idnhacungcap";
                string nameProvider = "tennhacungcap";
                object value = gvData_Provider.GetRowCellValue(row_index, col_fieldname);
                object valueNameProvider = gvData_Provider.GetRowCellValue(row_index, nameProvider);
                if (value != null)
                {

                    DataDemoDataContext db = new DataDemoDataContext();
                    var _nhacungcap = db.PROVIDERs.Where(s => s.idnhacungcap == (int)value).SingleOrDefault();
                    //XtraMessageBox.Show("Id có giá trị là: " + value.ToString());
                    if (_nhacungcap != null)
                    {
                        db.PROVIDERs.DeleteOnSubmit(_nhacungcap);
                        db.SubmitChanges();
                        XtraMessageBox.Show("Đã xoá thành công nhà cung cấp: " + valueNameProvider.ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn nhà cung cấp cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void barbtnAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUpdateProvider updateProvider = new frmUpdateProvider();
            updateProvider.isAdd = true;
            updateProvider.ShowDialog();
            loadData();
        }

        private void barbtnEditProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            int row_index = gvData_Provider.FocusedRowHandle;
            string col_fieldname = "idnhacungcap";
            object value = gvData_Provider.GetRowCellValue(row_index, col_fieldname);
            if (value != null)
            {
                frmUpdateProvider _frmUpdateProvider = new frmUpdateProvider();
                _frmUpdateProvider.Id = Convert.ToInt32(value);
                _frmUpdateProvider.isAdd = false;
                _frmUpdateProvider.ShowDialog();
                loadData();
            }
            else
            {
                XtraMessageBox.Show("Chưa chọn nhà cung cấp để chỉnh sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void barbtnExitProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}