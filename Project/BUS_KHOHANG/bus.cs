﻿using System;
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
        // Load Nhan su
        public IQueryable<NHANSU> Get_NhanSu()
        {
            var nhansu = data.Load_NhanSu();
            return nhansu;
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


        #region // Nhà cung cấp & Nhan su


        // Tim Kiem Nha Cung Cap
        public IQueryable<PROVIDER> KiemtraNhaCC(int id)
        {
            var sp = data.Check_NhaCC(id);
            return sp;
        }
        // Tim Kiem Nhan su
        public IQueryable<NHANSU> KiemtraNhanSu(int id)
        {
            var sp = data.Check_NhanSu(id);
            return sp;
        }

        //Tạo mới nhà cung cấp
        public bool Insert_NhaCC(NhaCC nhacc)
        {
            return data.AddNew_NhaCC(nhacc);
        }
        //Tạo mới nhan su
        public bool Insert_NhanSu(NhanSu nhanSu)
        {
            return data.AddNew_Nhansu(nhanSu);
        }
        //Xóa nhà cung cấp
        public bool Delete_NhaCC(int id)
        {
            return data.Delete_NhaCC(id);
        }
        //Xóa nhan su
        public bool Delete_NhanSu(int id)
        {
            return data.Delete_NhanSu(id);
        }

        //Cập nhật lại nhà cung cấp
        public bool Update_NhaCC(NhaCC nhacc)
        {
            return data.Update_NhaCC(nhacc);
        }
        //Cập nhật lại nhan su
        public bool Update_NhanSu(NhanSu nhanSu)
        {
            return data.Update_NhanSu(nhanSu);
        }
        #endregion




        //   #region // Nhân sự
        //public IQueryable<NHANSU> Get_NhanSu()
        //  {
        //     var dat = data.Load_Nhansu();
        //        return dat;
        //  }
        //  #endregion


        #region // Kho
        public IEnumerable<KHO> Get_Kho()
        {
            return data.Load_ChiTietKho();
        }
        #endregion

        #region // Phiếu nhập kho 
        public string Load_MaPhieuNhap()
        {
            return data.Create_PhieuNhap();
        }


        public bool InsertPhieuNhap(NhapKho sp)
        {
            return data.AddNew_PhieuNhapKho(sp);
        }

        public bool Insert_NhapKho(IEnumerable<NHAPKHO> list)
        {
            return data.AddNew_NhapKhos(list);
        }
        #endregion


        #region // Xuất kho
        public string Load_MaPhieuXuat()
        {
            return data.Create_PhieuXuat();
        }

        public bool Insert_XuatKho(IEnumerable<XUATKHO> list)
        {
            return data.AddNew_XuatKhos(list);
        }
        #endregion
        #region // Kiểm kê kho
        public string Load_MaPhieuKiemKe()
        {
            return data.Create_PhieuKiemKe();
        }

        public bool Insert_Kiemke(IEnumerable<KIEMKE> list)
        {
            return data.AddNew_KiemKes(list);
        }
        #endregion
    }
}