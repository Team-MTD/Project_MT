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
    public partial class frmStockChecking : DevExpress.XtraEditors.XtraForm
    {
        bus bus = new bus();
        List<SANPHAM> product;
        List<PROVIDER> provider;
        List<NHANSU> person;
        List<KHO> garage;
        List<KIEMKE> list_Kiemke = new List<KIEMKE>();
        List<Phieukiemke> pt = new List<Phieukiemke>();

        public frmStockChecking()
        {
            InitializeComponent();
        }
        public void Reset_Field()
        {
            //Load_MaPhieuXuat();
            cboMa.Text = "";
            cboTen.Text = "";
            sltonthucte.Text = "";
            //sltonmay.Text = "";
            txtKetqua.Text = "";
            txtNguyenhan.Text = "";
            ngaykiemke.EditValue = null;
        }

        public void Load_MaPhieuKiemKe()
        {
            txtidphieukiemke.Text = bus.Load_MaPhieuKiemKe();
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
        private void cboMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockChecking_Load(object sender, EventArgs e)
        {
            Load_MaPhieuKiemKe();
            Load_ThongTinSanPham();
        }

        private void cboMa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var findItem = bus.TimKiemSanPham(cboMa.SelectedItem.ToString().Trim()).ToList();
            cboTen.SelectedItem = findItem[0].tensanpham;
            sltonmay.Text = findItem[0].soluongton+"";
        }

        private void sltonthucte_Leave(object sender, EventArgs e)
        {
            try
            {
                txtKetqua.Text = "";
                int kq = 0;
                kq = Convert.ToInt32(sltonthucte.Text) - Convert.ToInt32(sltonmay.Text);
                if (kq > 0)
                {
                    txtKetqua.Text = "Dư " + kq.ToString() + " sản phẩm";
                }
                if (kq == 0)
                {
                    txtKetqua.Text = " Không có chênh lệch.";
                    txtNguyenhan.Properties.ReadOnly=true;
                }
                if (kq < 0)
                {
                    txtKetqua.Text = "Thiếu " + (kq*(-1)).ToString() + " sản phẩm";
                }
            }
            catch
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtThanhphan.Text);
            try
            {
                //Object cho phiếu nhập
                Phieukiemke phieu = new Phieukiemke
                {
                    MaPhieuKiemKe = txtidphieukiemke.Text,
                    MaSanPham = cboMa.SelectedItem.ToString(),
                    TenSanPham = cboTen.SelectedItem.ToString(),
                    NgayKiemKe = ngaykiemke.EditValue.ToString(),
                    SoLuongTonThucTe = Int32.Parse(sltonthucte.Text),
                    SoLuongTonTheoMay = Int32.Parse(sltonmay.Text),
                    NguoiKiemKe= txtThanhphan.Text,
                };


                // Object cho nhập kho
                KIEMKE kiemKe = new KIEMKE
                {
                    idphieukiemke = phieu.MaPhieuKiemKe,
                    ngaykiemke = Convert.ToDateTime(ngaykiemke.EditValue),
                    soluongtonkho = phieu.SoLuongTonThucTe,
                    idsanpham = phieu.MaSanPham,
                    nhansu = txtThanhphan.Text
                };

                list_Kiemke.Add(kiemKe);
                pt.Add(phieu);
                gcData_Kiemkekho.RefreshDataSource();
                gcData_Kiemkekho.DataSource = pt;
            }
            catch (Exception)
            {
                MessageBox.Show("Mời bạn nhập đầy đủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Reset_Field();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bus.Insert_Kiemke(list_Kiemke);
                gcData_Kiemkekho.DataSource = null;
                MessageBox.Show("Đã duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
            }
        }
    }
}