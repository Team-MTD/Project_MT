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
            ConnectDB connectDB = new ConnectDB();
            var linq = from item in connectDB.cnn.SANPHAMs
                       select item;

            return linq;
        }

        // Kiểm tra tồn tại sản phẩm
        public IQueryable<SANPHAM> Check_SP(string id)
        {
            try
            {
                var data = from item in ConnectDB.cnn2.SANPHAMs
                           where item.idsanpham == id.Trim()
                           select item;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IQueryable<KHO> Check_KH(string id)
        {
            try
            {
                var data = from item in ConnectDB.cnn2.KHOs
                           where item.idkho == id.Trim()
                           select item;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IQueryable<NHANSU> Check_GT(string id)
        {
            try
            {
                var data = from item in ConnectDB.cnn2.NHANSUs
                           where item.idnhansu.ToString() == id.Trim()
                           select item;
                return data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IQueryable<KHO> Load_Kho()
        {
            ConnectDB connectDB = new ConnectDB();
            var linq = from item in connectDB.cnn.KHOs
                       select item;

            return linq;
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
                ConnectDB connectDB = new ConnectDB();
                connectDB.cnn.SANPHAMs.InsertOnSubmit(pro);
                connectDB.cnn.SubmitChanges();
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
                ConnectDB connectDB=new ConnectDB();
                SANPHAM sp = connectDB.cnn.SANPHAMs.Single(item => item.idsanpham == masp);
                connectDB.cnn.SANPHAMs.DeleteOnSubmit(sp);
                connectDB.cnn.SubmitChanges();
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
                ConnectDB connectDB=new ConnectDB();
                var linq = from item in connectDB.cnn.SANPHAMs
                           where product.IdSanPham.Equals(item.idsanpham)
                           select item;
                if (linq != null)
                {
                    SANPHAM sp = connectDB.cnn.SANPHAMs.Single(item => item.idsanpham == product.IdSanPham);
                    sp.loaisanpham = product.LoaiSanPham;
                    sp.nhacungcap = product.NhaCungCap;
                    sp.donvi = product.DonVi;
                    sp.dongia = product.DonGia;
                    sp.nhomsanpham = product.NhomSanPham;
                    sp.tensanpham = product.TenSanPham;
                    connectDB.cnn.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        //KHO
        // Thêm kho
        public bool AddNew_KH(Kho product)
        {
            try
            {
                KHO pro = new KHO
                {
                    idkho = product.MaKho.ToString(),
                    tenkho = product.TenKho,
                    vitrikho = product.ViTriKho
                };
                ConnectDB connectDB = new ConnectDB();
                connectDB.cnn.KHOs.InsertOnSubmit(pro);
                connectDB.cnn.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
        // Xóa kho
        public bool Delete_KH(string makho)
        {
            try
            {
                ConnectDB connectDB = new ConnectDB();
                KHO sp = connectDB.cnn.KHOs.Single(item => item.idkho == makho);
                connectDB.cnn.KHOs.DeleteOnSubmit(sp);
                connectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        //Update KHO
        public bool Update_KH(Kho product)
        {
            try
            {
                ConnectDB connectDB = new ConnectDB();
                var linq = from item in connectDB.cnn.KHOs
                           where product.MaKho.Equals(item.idkho)
                           select item;
                if (linq != null)
                {
                    KHO sp = connectDB.cnn.KHOs.Single(item => item.idkho == product.MaKho.ToString());
                    sp.tenkho = product.TenKho;
                    sp.vitrikho = product.ViTriKho;
                    connectDB.cnn.SubmitChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// NHAN SU
        /// 
        public IQueryable<NHANSU> Load_NhanVien()
        {
            ConnectDB connectDB=new ConnectDB();
            var linq = from item in connectDB.cnn.NHANSUs
                       select item;

            return linq;
        }

        public bool AddNew_NhanVien(NhanVien nhanVien)
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                NHANSU prov = new NHANSU()
                {
                    idnhansu = nhanVien.IdNhanVien,
                    diachi = nhanVien.DiaChi,
                    dienthoai = nhanVien.DienThoai,
                    tennhansu = nhanVien.TenNhanVien,
                    email = nhanVien.Email,
                    gioitinh = nhanVien.Gioitinh,
                    chucvu = nhanVien.ChucVu,
                    ngayvaolam = nhanVien.NgayVaoLam  
                };
                connectDB.cnn.NHANSUs.InsertOnSubmit(prov);
                connectDB.cnn.SubmitChanges();
                return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool Update_NhanVien(NhanVien nhanVien)
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                NHANSU sp = connectDB.cnn.NHANSUs.Single(item => item.idnhansu == nhanVien.IdNhanVien);
                sp.idnhansu = sp.idnhansu;
                sp.tennhansu = nhanVien.TenNhanVien;
                sp.dienthoai = nhanVien.DienThoai;
                sp.diachi = nhanVien.DiaChi;
                sp.email = nhanVien.Email;
                sp.chucvu = nhanVien.ChucVu;
                sp.gioitinh = nhanVien.Gioitinh;
                sp.ngayvaolam = nhanVien.NgayVaoLam;
                connectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete_NhanVien(int manhanVien)
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                NHANSU nhanvien = connectDB.cnn.NHANSUs.Single(item => item.idnhansu == manhanVien);
                connectDB.cnn.NHANSUs.DeleteOnSubmit(nhanvien);
                connectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        // Kiem tra xem nhan su đã tồn tại chưa
        public IQueryable<NHANSU> Check_NhanVien(int id)
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                var data = from item in connectDB.cnn.NHANSUs
                           where item.idnhansu == id
                           select item;
                return data != null ? data : null;
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
            ConnectDB connectDB = new ConnectDB();
            var linq = from item in connectDB.cnn.PROVIDERs
                       select item;

            return linq;
        }

        public bool AddNew_NhaCC(NhaCC nhaCC)
        {
            try
            {
                ConnectDB connectDB = new ConnectDB();
                PROVIDER prov = new PROVIDER()
                {
                    idnhacungcap = nhaCC.idNhaCC,
                    diachinhacungcap = nhaCC.DiaChiNhaCC,
                    sdtnhacungcap = nhaCC.PhoneNhaCC,
                    tennhacungcap = nhaCC.TenNhaCC
                };
                connectDB.cnn.PROVIDERs.InsertOnSubmit(prov);
                connectDB.cnn.SubmitChanges();
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
                ConnectDB connectDB = new ConnectDB();
                PROVIDER sp = connectDB.cnn.PROVIDERs.Single(item => item.idnhacungcap == prov.idNhaCC);
                sp.idnhacungcap = sp.idnhacungcap;
                sp.tennhacungcap = prov.TenNhaCC;
                sp.sdtnhacungcap = prov.PhoneNhaCC;
                sp.diachinhacungcap = prov.DiaChiNhaCC;
                connectDB.cnn.SubmitChanges();
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
                ConnectDB connectDB = new ConnectDB();
                PROVIDER nhacc = connectDB.cnn.PROVIDERs.Single(item => item.idnhacungcap == manhaCC);
                connectDB.cnn.PROVIDERs.DeleteOnSubmit(nhacc);
                connectDB.cnn.SubmitChanges();
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
                ConnectDB connectDB = new ConnectDB();
                var data = from item in connectDB.cnn.PROVIDERs
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

                ConnectDB connectDB=new ConnectDB();
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
                connectDB.cnn.NHAPKHOs.InsertOnSubmit(pro);
                connectDB.cnn.SubmitChanges();
                return true;

            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }

        public string Create_PhieuXuat()
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                var data = from item in connectDB.cnn.XUATKHOs
                           select item;
                string maN = "";
                var linq = data.ToList();
                if (linq.Count <= 0)
                {
                    maN = "XUAT001";
                }
                else
                {
                    int x;
                    maN = "XUAT";
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
        public string Create_PhieuNhap()
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                var data = from item in connectDB.cnn.NHAPKHOs
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
        //PHIẾU KIỂM KÊ
        public string Create_PhieuKiemKe()
        {
            try
            {
                ConnectDB connectDB = new ConnectDB();
                var data = from item in connectDB.cnn.KIEMKEs
                           select item;
                string maKK = "";
                var linq = data.ToList();
                if (linq.Count <= 0)
                {
                    maKK = "KIEMKE001";
                }
                else
                {
                    int x;
                    maKK = "KIEMKE";
                    x = linq.Count;
                    x = x + 1;
                    if (x < 10)
                    {
                        maKK = maKK + "00";
                    }
                    else if (x < 1000)
                    {
                        maKK = maKK + "0";
                    }
                    maKK = maKK + x.ToString();
                }
                return maKK;
            }
            catch (Exception)
            {
                throw;
            }

        }

        /// NHÂN SỰ
        public IQueryable<NHANSU> Load_Nhansu()
        {
            ConnectDB connectDB=new ConnectDB();
            var linq = from item in connectDB.cnn.NHANSUs
                       select item;
            return linq;
        }



        // KHO
        public IQueryable<KHO> Load_ChiTietKho()
        {
            ConnectDB connectDB=new ConnectDB();
            var linq = from item in connectDB.cnn.KHOs
                       select item;
            return linq;
        }


        // NHẬP KHO
        public bool AddNew_NhapKhos(IEnumerable<NHAPKHO> list)
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                connectDB.cnn.NHAPKHOs.InsertAllOnSubmit(list);
                connectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        // XUẤT KHO
        public bool AddNew_XuatKhos(IEnumerable<XUATKHO> list)
        {
            try
            {
                ConnectDB connectDB=new ConnectDB();
                connectDB.cnn.XUATKHOs.InsertAllOnSubmit(list);
                connectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        // KIỂM KÊ

        public IQueryable<KIEMKE> Load_KiemKe()
        {
            ConnectDB connectDB = new ConnectDB();
            var linq = from item in connectDB.cnn.KIEMKEs
                       select item;

            return linq;
        }


        public bool AddNew_KiemKes(IEnumerable<KIEMKE> list)
        {
            try
            {
                ConnectDB connectDB = new ConnectDB();
                connectDB.cnn.KIEMKEs.InsertAllOnSubmit(list);
                connectDB.cnn.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
