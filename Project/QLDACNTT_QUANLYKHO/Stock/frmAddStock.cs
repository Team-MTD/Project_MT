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
using Provider;

namespace QLDACNTT_QUANLYKHO.Stock
{
    public partial class frmAddStock : DevExpress.XtraEditors.XtraForm
    {
        public bus func = new bus();
        bus bus = new bus();
        List<KHO> provider;
        public frmAddStock()
        {
            InitializeComponent();
        }
        public void showData(Kho pro)
        {
            txtidStock.Text = pro.MaKho;
            txtnameStock.Text = pro.TenKho;
            txtlocationStock.Text = pro.ViTriKho;
        }
        private void frmAddStock_Load(object sender, EventArgs e)
        {
            
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
        
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtidStock.Text != "" && txtnameStock.Text != "" && txtlocationStock.Text != "")
            {
                try
                {
                    var kho = new Kho()
                    {
                        MaKho = txtidStock.Text,
                        TenKho = txtnameStock.Text,
                        ViTriKho = txtlocationStock.Text
                    };
                    // Kiểm tra nếu sản phẩm tồn tại:
                    var x = func.TimKiemKho(kho.MaKho);
                    if (x.ToList().Count > 0)
                    {
                        // Cập nhật sản phẩm
                        if (func.Update_KH(kho))
                        {
                            XtraMessageBox.Show("Cập nhật sản phẩm thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Có vấn đề trong quá trình cập nhật ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Thêm sản phẩm mới
                        if (func.Insert_KH(kho))
                        {
                            XtraMessageBox.Show("Đã thêm thành công sản phẩm: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            XtraMessageBox.Show("Lỗi: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                }
                catch (Exception)
                {

                    throw;
                }

            }
            this.Close();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}