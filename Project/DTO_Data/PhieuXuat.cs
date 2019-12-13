using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class PhieuXuat
    {
        public string MaPhieuXuat { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongXuat { get; set; }
        public string NguoiNhap { get; set; }
        public string NgayNhapKho { get; set; }

        public PhieuXuat()
        {

        }
    }
}
