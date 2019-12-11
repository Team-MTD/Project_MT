using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Provider;
using DTO_Data;
using System.Data;
using System.Data.SqlClient;

namespace DAL_KHOHANG
{
    public class qal
    {
        //Get Sản phẩm trong kho
        public IQueryable<SANPHAM> Load_SanPham()
        {
            var linq = from item in ConnectDB.cnn.SANPHAMs
                       select item;

            return linq;
        }

        // Kiểm tra tồn tại sản phẩm
        public IQueryable<SANPHAM> Check_SP(string id)
        {
            try
            {
                var data = from item in ConnectDB.cnn.SANPHAMs
                           where item.idsanpham == id.Trim()
                           select item;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// 
        /// SẢN PHẨM
        /// 
        // Thêm sản phẩm
        public bool AddNew_SP(Product product)
        {
            try
            {
                SANPHAM pro = new SANPHAM
                {
                    idsanpham = product.IdSanPham,
                    tensanpham = product.TenSanPham,
                    dongia = product.DonGia,
                    donvi = product.DonVi,
                    loaisanpham = product.LoaiSanPham,
                    nhacungcap = product.NhaCungCap,
                    nhomsanpham = product.NhomSanPham
                };
                ConnectDB.cnn.SANPHAMs.InsertOnSubmit(pro);
                ConnectDB.cnn.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
        // Xóa sản phẩm
        public bool Delete_SP(string masp)
        {
            try
            {
                SANPHAM sp = ConnectDB.cnn.SANPHAMs.Single(item => item.idsanpham == masp);
                ConnectDB.cnn.SANPHAMs.DeleteOnSubmit(sp);
                ConnectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        //Update sản phẩm
        public bool Update_SP(Product product)
        {
            try
            {
                var linq = from item in ConnectDB.cnn.SANPHAMs
                           where product.IdSanPham.Equals(item.idsanpham)
                           select item;
                if (linq != null)
                {
                    SANPHAM sp = ConnectDB.cnn.SANPHAMs.Single(item => item.idsanpham == product.IdSanPham);
                    sp.loaisanpham = product.LoaiSanPham;
                    sp.nhacungcap = product.NhaCungCap;
                    sp.donvi = product.DonVi;
                    sp.dongia = product.DonGia;
                    sp.nhomsanpham = product.NhomSanPham;
                    sp.tensanpham = product.TenSanPham;
                    ConnectDB.cnn.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// NHÀ CUNG CẤP
        /// 
        public IQueryable<PROVIDER> Load_NhaCC()
        {
            var linq = from item in ConnectDB.cnn.PROVIDERs
                       select item;

            return linq;
        }

        public bool AddNew_NhaCC(NhaCC nhaCC)
        {
            try
            {
                PROVIDER prov = new PROVIDER()
                {
                    idnhacungcap = nhaCC.idNhaCC,
                    diachinhacungcap = nhaCC.DiaChiNhaCC,
                    sdtnhacungcap = nhaCC.PhoneNhaCC,
                    tennhacungcap = nhaCC.TenNhaCC
                };
                ConnectDB.cnn.PROVIDERs.InsertOnSubmit(prov);
                ConnectDB.cnn.SubmitChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Update_NhaCC(NhaCC prov)
        {
            try
            {
                PROVIDER sp = ConnectDB.cnn.PROVIDERs.Single(item => item.idnhacungcap == prov.idNhaCC);
                sp.idnhacungcap = sp.idnhacungcap;
                sp.tennhacungcap = prov.TenNhaCC;
                sp.sdtnhacungcap = prov.PhoneNhaCC;
                sp.diachinhacungcap = prov.DiaChiNhaCC;
                ConnectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete_NhaCC(int manhaCC)
        {
            try
            {
                PROVIDER nhacc = ConnectDB.cnn.PROVIDERs.Single(item => item.idnhacungcap == manhaCC);
                ConnectDB.cnn.PROVIDERs.DeleteOnSubmit(nhacc);
                ConnectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        // Kiem tra xem nhà cung cấp đã tồn tại chưa
        public IQueryable<PROVIDER> Check_NhaCC(int id)
        {
            try
            {
                var data = from item in ConnectDB.cnn.PROVIDERs
                           where item.idnhacungcap == id
                           select item;
                return data != null ? data : null;
            }
            catch (Exception)
            {
                throw;
            }
        }


       

        ///Nhập phiếu nhập kho
        public bool AddNew_PhieuNhapKho(NhapKho product)
        {
            try
            {

                NHAPKHO pro = new NHAPKHO
                {
                    idphieunhap = product.IdPhieuNhap,
                    ngaynhapkho = product.NgayNhap,
                    soluongnhap = product.SoLuongNhap,
                    idsanpham = product.IdSanPham,
                    idnhansu = product.IdNhanSu,
                    idnhacungcap = product.IdNhaCungCap,
                    idkho = product.IdKho
                };
                ConnectDB.cnn.NHAPKHOs.InsertOnSubmit(pro);
                ConnectDB.cnn.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }


        public string Create_PhieuNhap()
        {
            try
            {
                var data = from item in ConnectDB.cnn.NHAPKHOs
                           select item;
                string maN = "";
                var linq = data.ToList();
                if (linq.Count <= 0)
                {
                    maN = "NHAP001";
                }
                else
                {
                    int x;
                    maN = "NHAP";
                    x = linq.Count;
                    x = x + 1;
                    if (x < 10)
                    {
                        maN = maN + "00";
                    }
                    else if (x < 1000)
                    {
                        maN = maN + "0";
                    }
                    maN = maN + x.ToString();
                }
                return maN;
            }
            catch (Exception)
            {
                throw;
            }

        }


        /// NHÂN SỰ
        public IQueryable<NHANSU> Load_Nhansu()
        {
            var linq = from item in ConnectDB.cnn.NHANSUs
                       select item;
            return linq;
        }



        // KHO
        public IQueryable<KHO> Load_ChiTietKho()
        {
            var linq = from item in ConnectDB.cnn.KHOs
                       select item;
            return linq;
        }




        // NHẬP KHO
        public bool AddNew_NhapKhos(IEnumerable<NHAPKHO> list)
        {
            try
            {
                ConnectDB.cnn.NHAPKHOs.InsertAllOnSubmit(list);
                ConnectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
