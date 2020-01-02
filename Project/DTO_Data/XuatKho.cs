using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class XuatKho
    {
        public string IdPhieuXuat { get; set; }
        public DateTime NgayXuat { get; set; }
        public int? SoLuongXuat { get; set; }
        public string IdSanPham { get; set; }
        public string IdNhanSu { get; set; }
        public string IdKho { get; set; }

        public XuatKho()
        {

        }
    }
}
