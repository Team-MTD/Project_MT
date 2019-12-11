using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_KHOHANG;
using Provider;
using DTO_Data;
namespace BUS_KHOHANG
{
    public class bus
    {
        private qal data = new qal();

        //Load san phẩm
        public IQueryable<SANPHAM> Get_SanPham()
        {
            var dat = data.Load_SanPham();
            return dat;
        }
        // Load Nhà cung cấp
        public IQueryable<PROVIDER> Get_NhaCC()
        {
            var nhacc = data.Load_NhaCC();
            return nhacc;
        }

        #region // Sản Phẩm
        // Tim Kiem San Pham
        public IQueryable<SANPHAM> TimKiemSanPham(string id)
        {
            var sp = data.Check_SP(id);
            return sp;
        }

        //Them San Pham
        public bool Insert_SanPham(Product sp)
        {
            return data.AddNew_SP(sp);
        }
        //Xoa San Pham
        public bool Delete_SanPham(string id)
        {
            return data.Delete_SP(id);
        }

        //Update San Pham
        public bool Update_SanPham(Product sp)
        {
            return data.Update_SP(sp);
        }

        #endregion


        #region // Nhà cung cấp


        // Tim Kiem Nha Cung Cap
        public IQueryable<PROVIDER> KiemtraNhaCC(int id)
        {
            var sp = data.Check_NhaCC(id);
            return sp;
        }

        //Tạo mới nhà cung cấp
        public bool Insert_NhaCC(NhaCC nhacc)
        {
            return data.AddNew_NhaCC(nhacc);
        }
        //Xóa nhà cung cấp
        public bool Delete_NhaCC(int id)
        {
            return data.Delete_NhaCC(id);
        }

        //Cập nhật lại nhà cung cấp
        public bool Update_NhaCC(NhaCC nhacc)
        {
            return data.Update_NhaCC(nhacc);
        }

        #endregion


        #region //Phiếu nhập kho 
        public string Load_MaPhieuNhap()
        {
            return data.Create_PhieuNhap();
        }


        public bool InsertPhieuNhap(NhapKho sp)
        {
            return data.AddNew_PhieuNhapKho(sp);
        }
        #endregion

        #region // Nhân sự
        public IQueryable<NHANSU> Get_NhanSu()
        {
            var dat = data.Load_Nhansu();
            return dat;
        }
        #endregion


        #region Kho
        public IEnumerable<KHO> Get_Kho()
        {
            return data.Load_ChiTietKho();
        }
        #endregion




        #region // Nhập Kho
        public bool Insert_NhapKho(IEnumerable<NHAPKHO> list)
        {
            return data.AddNew_NhapKhos(list);
        }
        #endregion
    }
}
