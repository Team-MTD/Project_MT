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

        //Load kho
        public IQueryable<SANPHAM> GetKho()
        {
            var dat = data.Load_Kho();
            return dat;
        }
        // Load Nhà cung cấp
        public IQueryable<PROVIDER> GetNhaCC()
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
        public bool InsertSanPham(Product sp)
        {
            return data.AddNew_SP(sp);
        }
        //Xoa San Pham
        public bool DeleteSanPham(string id)
        {
            return data.Delete_SP(id);
        }

        //Update San Pham
        public bool UpdateSanPham(Product sp)
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
        public bool InsertNhaCC(NhaCC nhacc)
        {
            return data.AddNew_NhaCC(nhacc);
        }
        //Xóa nhà cung cấp
        public bool DeleteNhaCC(int id)
        {
            return data.Delete_NhaCC(id);
        }

        //Cập nhật lại nhà cung cấp
        public bool UpdateNhaCC(NhaCC nhacc)
        {
            return data.Update_NhaCC(nhacc);
        }

        #endregion
    }
}
