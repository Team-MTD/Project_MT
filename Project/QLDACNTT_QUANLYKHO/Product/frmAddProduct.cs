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
    public partial class frmAddProduct : DevExpress.XtraEditors.XtraForm
    {
        public bus func = new bus();

        public frmAddProduct()
        {
            InitializeComponent();
        }
        private void frmAddProduct_Load(object sender, EventArgs e)
        {
           
        }
        //public bool isAdd = true;

        #region //Method of form
        public void showData(Product pro)
        {
            txtAdd_idProduct.Text = pro.IdSanPham;
            txtAdd_nameProduct.Text = pro.TenSanPham;
            txtAdd_priceProduct.Text = pro.DonGia.ToString();
            txtAdd_providerProduct.Text = pro.NhaCungCap;
            txtAdd_unitProduct.Text = pro.DonVi;
            txtAdd_groupProduct.Text = pro.NhomSanPham;
            txtAdd_SpeciesProduct.Text = pro.LoaiSanPham;
        }
        #endregion

      

        #region Event Of Data

        private void barbtnCloseAddProduct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtAdd_idProduct_EditValueChanged(object sender, EventArgs e)
        {

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAdd_nameProduct.Text != "" && txtAdd_idProduct.Text != "" && txtAdd_priceProduct.Text != "")
            {
                try
                {
                    var product = new Product()
                    {
                        IdSanPham = txtAdd_idProduct.Text,
                        TenSanPham = txtAdd_nameProduct.Text,
                        DonVi = txtAdd_unitProduct.Text,
                        DonGia = Convert.ToInt32(txtAdd_priceProduct.Text),
                        LoaiSanPham = txtAdd_SpeciesProduct.Text,
                        NhaCungCap = txtAdd_providerProduct.Text,
                        NhomSanPham = txtAdd_groupProduct.Text
                    };
                    // Kiểm tra nếu sản phẩm tồn tại:
                    if (func.TimKiemSanPham(product.IdSanPham) == null)
                    {
                        // Cập nhật sản phẩm
                        if (func.Update_SanPham(product))
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
                        if (func.Insert_SanPham(product))
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

        }
        #endregion

    }
}