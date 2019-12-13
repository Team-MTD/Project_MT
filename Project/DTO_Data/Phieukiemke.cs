using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class Phieukiemke
    {
        public string MaPhieuKiemKe { get; set; }
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public int SoLuongTonTheoMay { get; set; }
        public int SoLuongTonThucTe { get; set; }
        //public string Nguoi { get; set; }
        public string NgayKiemKe { get; set; }

        public Phieukiemke()
        {

        }
    }
}
