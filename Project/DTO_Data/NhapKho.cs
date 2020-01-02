using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class NhapKho
    {
        public string IdPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public string IdSanPham { get; set; }
        public int? IdNhanSu { get; set; }
        public int? IdNhaCungCap { get; set; }
        public string IdKho { get; set; }

        public NhapKho()
        {

        }
    }
}
