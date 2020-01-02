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
using System.Data.SqlClient;
using BUS_KHOHANG;
using DTO_Data;
using Provider;



namespace QLDACNTT_QUANLYKHO
{
    public partial class frmStockIssue : DevExpress.XtraEditors.XtraForm
    {
        bus bus = new bus();
        List<SANPHAM> product;
        List<PROVIDER> provider;
        List<NHANSU> person;
        List<KHO> garage;
        List<XUATKHO> list_XuatKho = new List<XUATKHO>();
        List<PhieuXuat> pt = new List<PhieuXuat>();


        public frmStockIssue()
        {
            InitializeComponent();
        }
        #region Method of Form
        public void Reset_Field()
        {
            Load_MaPhieuXuat();
            cboMa.Text = "";
            cboNguoi.Text = "";
            cbokho.Text = "";
            cboTen.Text = "";
            soluongton.Text = "";
            soluongxuat.Text = "";
            dongia.Text = "";
            dongia.Text = "";
            thanhtien.Text = "";
            ngayxuatkho.EditValue = null;
        }


        public void Load_MaPhieuXuat()
        {
            txtidphieuxuat.Text = bus.Load_MaPhieuXuat();
        }
        public void Load_ThongTinSanPham()
        {
            product = bus.Get_SanPham().ToList();
            foreach (var item in product)
            {
                cboMa.Items.Add(item.idsanpham);
                cboTen.Items.Add(item.tensanpham);
            }
        }

        public void Load_NguoiNhapKho()
        {
            var persons = bus.Get_NhanVien();
            foreach (var item in persons)
            {
                cboNguoi.Items.Add(item.tennhansu);
            }
        }
        /*
        public void Load_NhaCungCap()
        {
            provider = bus.Get_NhaCC().ToList();
            foreach (var item in provider)
            {
                cboNCC.Items.Add(item.tennhacungcap);
            }
        }*/

        public void Load_Kho()
        {
            garage = bus.Get_Kho().ToList();
            foreach (var item in garage)
            {
                cbokho.Items.Add(item.tenkho);
            }
        }

        #endregion


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmStockIssue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLKHODataSet.SANPHAM' table. You can move, or remove it, as needed.

            Load_MaPhieuXuat();
            Load_ThongTinSanPham();
            Load_NguoiNhapKho();
            Load_Kho();
        }

        private void cboMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var findItem = bus.TimKiemSanPham(cboMa.SelectedItem.ToString().Trim()).ToList();
            cboTen.SelectedItem = findItem[0].tensanpham;
            dongia.Text = findItem[0].dongia.ToString();
            soluongton.Text = findItem[0].soluongton.ToString();
        }

        private void soluongnhap_Leave(object sender, EventArgs e)
        {
            try
            {
                thanhtien.Text = "" + Convert.ToInt32(soluongxuat.Text) * Convert.ToInt32(dongia.Text);
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy index của các combobox
                var indexPerson = cboNguoi.SelectedIndex;
                var indexKho = cbokho.SelectedIndex;

                //Object cho phiếu nhập
                PhieuXuat phieu = new PhieuXuat
                {
                    MaPhieuXuat = txtidphieuxuat.Text,
                    MaSanPham = cboMa.SelectedItem.ToString(),
                    NgayNhapKho = ngayxuatkho.EditValue.ToString(),
                    NguoiNhap = cboNguoi.SelectedItem.ToString(),
                    SoLuongXuat = Int32.Parse(soluongxuat.Text),
                    TenSanPham = cboTen.SelectedItem.ToString()
                };
                // Object cho nhập kho
                XUATKHO xuatKho = new XUATKHO
                {
                    idphieuxuat = phieu.MaPhieuXuat,
                    ngayxuatkho = Convert.ToDateTime(ngayxuatkho.EditValue),
                    soluongxuat = phieu.SoLuongXuat,
                    idsanpham = phieu.MaSanPham,
                    idkho = garage[indexKho].idkho,
                    idnhansu = person[indexPerson].idnhansu.ToString()
                };

                list_XuatKho.Add(xuatKho);
                pt.Add(phieu);
                gcData_Xuatkho.RefreshDataSource();
                gcData_Xuatkho.DataSource = pt;
            }
            catch (Exception)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset_Field();
        }

        private void btnXuatkho_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus.Insert_XuatKho(list_XuatKho))
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    gcData_Xuatkho.DataSource = null;
                    Reset_Field();
                    list_XuatKho = new List<XUATKHO>();
                    pt = new List<PhieuXuat>();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra vấn đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thành Công");
            }
        }
    }
}