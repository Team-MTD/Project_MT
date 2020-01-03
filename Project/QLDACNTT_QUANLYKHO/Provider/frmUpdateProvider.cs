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

namespace QLDACNTT_QUANLYKHO
{
    public partial class frmUpdateProvider : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {

        public bus func = new bus();

        public frmUpdateProvider()
        {
            InitializeComponent();
        }
        #region // Methods of form
        public void showData(NhaCC prov)
        {
            txtAdd_nameProvider.Text = prov.TenNhaCC;
            txtAdd_phoneProvider.Text = prov.PhoneNhaCC;
            txtAdd_idProvider.Text = prov.idNhaCC.ToString();
            txtAdd_addressProvider.Text = prov.DiaChiNhaCC;
        }

        #endregion


        private void barbtnExitAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barbtnSaveAddProvider_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

        }
        public bool isAdd = true;
        public int Id = -1;
        private void frmUpdateProvider_Load(object sender, EventArgs e)
        {
            
        }
        
        private void txtAdd_idProvider_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //Kiểm tra số điện thoại đủ 11 số
            if (txtAdd_phoneProvider.Text.Length > 11)
            {
                XtraMessageBox.Show("Số điện thoại không được nhiều hơn 11 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtAdd_nameProvider.Text != "" && txtAdd_addressProvider.Text != "" && txtAdd_phoneProvider.Text != "")
                {
                    var nhacc = new NhaCC()
                    {
                        idNhaCC = Convert.ToInt32(txtAdd_idProvider.Text.Trim()),
                        DiaChiNhaCC = txtAdd_addressProvider.Text,
                        PhoneNhaCC = txtAdd_phoneProvider.Text,
                        TenNhaCC = txtAdd_nameProvider.Text
                    };

                    // Kiểm tra nếu nhà cung cấp tồn tại:
                    if (func.KiemtraNhaCC(nhacc.idNhaCC).ToList().Count > 0)
                    {
                        // Cập nhật lại thông tin nhà cung cấp
                        if (func.Update_NhaCC(nhacc))
                        {
                            XtraMessageBox.Show("Cập nhật nhà cung cấp thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("Có vấn đề trong quá trình cập nhật ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Tạo mới một nhà cung cấp
                        if (func.Insert_NhaCC(nhacc))
                        {
                            XtraMessageBox.Show("Đã thêm thành công nhà cung cấp: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            XtraMessageBox.Show("Lỗi: ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
        }
    }
}