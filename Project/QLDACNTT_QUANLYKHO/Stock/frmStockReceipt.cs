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
    public partial class frmStockReceipt : DevExpress.XtraEditors.XtraForm
    {
        bus bus = new bus();
        List<SANPHAM> product;
        List<PROVIDER> provider;
        List<NHANSU> person;
        List<KHO> garage;
        List<NHAPKHO> list_NhapKho = new List<NHAPKHO>();
        List<PhieuThu> pt = new List<PhieuThu>();

        public frmStockReceipt()
        {
            InitializeComponent();

        }

        #region Method of Form
        public void Reset_Field()
        {
            Load_MaPhieuNhap();
            cboMa.Text = "";
            cboNCC.Text = "";
            cboNguoi.Text = "";
            cboKho.Text = "";
            cboTen.Text = "";

        }


        public void Load_MaPhieuNhap()
        {
            txtidphieunhap.Text = bus.Load_MaPhieuNhap();
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
            person = bus.Get_NhanSu().ToList();
            foreach (var item in person)
            {
                cboNguoi.Items.Add(item.tennhansu);
            }
        }

        public void Load_NhaCungCap()
        {
            provider = bus.Get_NhaCC().ToList();
            foreach (var item in provider)
            {
                cboNCC.Items.Add(item.tennhacungcap);
            }
        }

        public void Load_Kho()
        {
            garage = bus.Get_Kho().ToList();
            foreach (var item in garage)
            {
                cboKho.Items.Add(item.tenkho);
            }
        }

        #endregion

        private void resourcesComboBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void frmStockReceipt_Load(object sender, EventArgs e)
        {
            Load_MaPhieuNhap();
            Load_ThongTinSanPham();
            Load_NguoiNhapKho();
            Load_NhaCungCap();
            Load_Kho();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var findItem = bus.TimKiemSanPham(cboMa.SelectedItem.ToString().Trim()).ToList();
            cboTen.SelectedItem = findItem[0].tensanpham;
            dongia.Text = findItem[0].dongia.ToString();
            soluongton.Text = findItem[0].soluongton.ToString();
        }

        private void cboTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //Lấy index của các combobox
                var indexPerson = cboNguoi.SelectedIndex;
                var indexNhaCC = cboNCC.SelectedIndex;
                var indexKho = cboKho.SelectedIndex;


                //Object cho phiếu nhập
                PhieuThu phieu = new PhieuThu
                {
                    MaPhieuNhap = txtidphieunhap.Text,
                    MaSanPham = cboMa.SelectedItem.ToString(),
                    NgayNhapKho = ngaynhapkho.EditValue.ToString(),
                    NguoiNhap = cboNguoi.SelectedItem.ToString(),
                    NhaCungCap = cboNCC.SelectedItem.ToString(),
                    SoLuongNhap = Int32.Parse(soluongnhap.Text),
                    TenSanPham = cboTen.SelectedItem.ToString()
                };
                // Object cho nhập kho
                NHAPKHO nhapKho = new NHAPKHO
                {
                    idphieunhap = phieu.MaPhieuNhap,
                    ngaynhapkho = Convert.ToDateTime(ngaynhapkho.EditValue),
                    soluongnhap = phieu.SoLuongNhap,
                    idsanpham = phieu.MaSanPham,
                    idnhansu = person[indexPerson].idnhansu,
                    idnhacungcap = provider[indexNhaCC].idnhacungcap,
                    idkho = garage[indexKho].idkho
                };

                list_NhapKho.Add(nhapKho);
                pt.Add(phieu);
                gcData_Nhapkho.RefreshDataSource();
                gcData_Nhapkho.DataSource = pt;
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
                if (bus.Insert_NhapKho(list_NhapKho))
                {
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    gcData_Nhapkho.DataSource = null;
                    Reset_Field();
                    list_NhapKho = new List<NHAPKHO>();
                    pt = new List<PhieuThu>();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra vấn đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn xoá sản phẩm đang chọn?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int row_index = gridView1.FocusedRowHandle;
                pt.RemoveAt(row_index);
                gcData_Nhapkho.RefreshDataSource();
                gcData_Nhapkho.DataSource = pt;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int row_index = gridView1.FocusedRowHandle;
            string col_fieldname = "MaPhieuNhap";
            object idPhieuNhap = gridView1.GetRowCellValue(row_index, col_fieldname);
            txtidphieunhap.Text = idPhieuNhap.ToString();

            col_fieldname = "MaSanPham";
            object idMaSP = gridView1.GetRowCellValue(row_index, col_fieldname);
            cboMa.Text = idMaSP.ToString();


            col_fieldname = "NgayNhapKho";
            object NgayNhap = gridView1.GetRowCellValue(row_index, col_fieldname);
            ngaynhapkho.EditValue = NgayNhap;

            col_fieldname = "NguoiNhap";
            object NguoiNhap = gridView1.GetRowCellValue(row_index, col_fieldname);
            cboNguoi.Text = NguoiNhap.ToString();


            col_fieldname = "NhaCungCap";
            object NhaCC = gridView1.GetRowCellValue(row_index, col_fieldname);
            cboNCC.Text = NhaCC.ToString();



            col_fieldname = "SoLuongNhap";
            object Soluong = gridView1.GetRowCellValue(row_index, col_fieldname);
            soluongnhap.Text = Soluong.ToString();

        }

        private void thanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void soluongnhap_Leave(object sender, EventArgs e)
        {
            try
            {
                thanhtien.Text = "" + Convert.ToInt32(soluongnhap.Text) * Convert.ToInt32(dongia.Text);
            }
            catch
            {

            }
        }
    }
}