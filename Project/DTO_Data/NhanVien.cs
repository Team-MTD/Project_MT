using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class NhanVien
    {
            public string TenNhanVien { get; set; }
            public int IdNhanVien { get; set; }
            public string Gioitinh { get; set; }
            public string ChucVu { get; set; }
            public string DienThoai { get; set; }
            public string DiaChi { get; set; }
            public string Email { get; set; }
            public DateTime NgayVaoLam { get; set; }
            public NhanVien()
            {

            }
    }
}
