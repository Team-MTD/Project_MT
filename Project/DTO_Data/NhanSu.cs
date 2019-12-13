using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class NhanSu
    {
        public int IdNhanSu { get; set; }
        public string TenNhanSu { get; set; }
        public string ChucVu { get; set; }
        public bool GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string NgayVaoLam { get; set; }

        public NhanSu()
        {

        }
    }
}
