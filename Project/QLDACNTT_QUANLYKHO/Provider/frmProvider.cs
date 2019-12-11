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
using DTO_Data;
using BUS_KHOHANG;


namespace QLDACNTT_QUANLYKHO
{
    public partial class frmProvider : DevExpress.XtraEditors.XtraForm
    {
        public bus func = new bus();
        public delegate void DelegateShow(NhaCC pro);


        //Delegate contructor
        DelegateShow ShowForm;

        //Form
        frmUpdateProvider updateProvider;

        public frmProvider()
        {
            InitializeComponent();
        }

        private void frmProvider_Load(object sender, EventArgs e)
        {
            loadData();
        }

        #region Methods of form
        private NhaCC GetData(int id)
        {
            var data = func.KiemtraNhaCC(id);
            NhaCC prov = new NhaCC();

            if (data != null)
            {
                var x = data.ToList();
                foreach (var item in x)
                {
                    prov.idNhaCC = item.idnhacungcap;
                    prov.PhoneNhaCC = item.sdtnhacungcap;
                    prov.TenNhaCC = item.tennhacungcap;
                    prov.DiaChiNhaCC = item.diachinhacungcap;
                }
                return prov;
            }
            return null;
        }
        private void loadData()
        {
            gcData_Provider.DataSource = func.Get_NhaCC();
        }
        #endregion

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
                    if (func.Delete_NhaCC((int)value))
                    {
                        XtraMessageBox.Show("Đã xoá thành công sản phẩm: " + valueNameProvider.ToString().ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    else
                    {
                        XtraMessageBox.Show("Quá trình xóa đã gặp vấn đề: " + valueNameProvider.ToString().ToString(), "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Chưa chọn sản phẩm cần xoá!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                updateProvider = new frmUpdateProvider();
                ShowForm = new DelegateShow(updateProvider.showData);       //Gọi sang hàm bên FrmUpdateProvider
                ShowForm(GetData((int)value));
                updateProvider.ShowDialog();
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