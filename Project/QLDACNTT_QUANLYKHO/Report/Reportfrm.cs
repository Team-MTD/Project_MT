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
using System.IO;
using DTO_Data;
using Provider;


namespace QLDACNTT_QUANLYKHO.Report
{
    public partial class Reportfrm : DevExpress.XtraEditors.XtraForm
    {
        bus bus = new bus();
        public Reportfrm()
        {
            InitializeComponent();
            Load_Data();
        }
        #region // Methods of Form
        public void Load_Data()
        {
            gcData_Export.DataSource = Fixed_Data_PhieuNhap(bus.Load_PhieuNhap());
            gcDataOut_Export.DataSource =Fixed_Data_PhieuXuat(bus.Load_PhieuXuat());
        }
        #endregion



        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string Filename = @"C:\Users\phamh\Desktop\ThongKe-NhapKho.xlsx";
                gcData_Export.ExportToXlsx(Filename);
                this.Hide();
            }
            catch (Exception)
            {
                throw;
            }
        }


        
        // sửa lại dữ liệu để hiển thị
        public List<NhapKho> Fixed_Data_PhieuNhap(IQueryable<NHAPKHO> par)
        {
            List<NhapKho> lstNhapKho = new List<NhapKho>();
            foreach (var item in par.ToList())
            {
                NhapKho nk = new NhapKho
                {
                    IdKho = item.idkho,
                    IdNhaCungCap = item.idnhacungcap,
                    IdNhanSu = item.idnhansu,
                    IdPhieuNhap = item.idphieunhap,
                    IdSanPham = item.idsanpham,
                    NgayNhap = item.ngaynhapkho,
                    SoLuongNhap = item.soluongnhap
                };
                lstNhapKho.Add(nk);
            }
            return lstNhapKho;
        }

        public List<XuatKho> Fixed_Data_PhieuXuat(IQueryable<XUATKHO> par)
        {
            List<XuatKho> lstNhapKho = new List<XuatKho>();
            foreach (var item in par.ToList())
            {
                XuatKho nk = new XuatKho
                {
                    IdKho = item.idkho,
                    IdNhanSu = item.idnhansu,
                    IdSanPham = item.idsanpham,
                    NgayXuat = item.ngayxuatkho,
                    SoLuongXuat = item.soluongxuat,
                    IdPhieuXuat=item.idphieuxuat,
                };
                lstNhapKho.Add(nk);
            }
            return lstNhapKho;
        }


        private void btnLocXuat_Click(object sender, EventArgs e)
        {
            gcDataOut_Export.DataSource = Fixed_Data_PhieuXuat(bus.Load_PhieuXuat_Date(Convert.ToDateTime(dtFrom2.EditValue), Convert.ToDateTime(dtTo2.EditValue)));
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            gcData_Export.DataSource = Fixed_Data_PhieuNhap(bus.Load_PhieuNhap_Date(Convert.ToDateTime(dtFrom1.EditValue), Convert.ToDateTime(dtTo1.EditValue)));
        }

        private void btnExcelOut_Click(object sender, EventArgs e)
        {
            try
            {
                string Filename = @"C:\Users\phamh\Desktop\ThongKe-XuatKho.xlsx";
                gcData_Export.ExportToXlsx(Filename);
                this.Hide();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}