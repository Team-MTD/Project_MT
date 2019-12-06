using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Data
{
    public class Product
    {
        public string IdSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string DonVi { get; set; }
        public string LoaiSanPham { get; set; }
        public string NhomSanPham { get; set; }
        public int DonGia { get; set; }
        public string NhaCungCap { get; set; }

        public Product()
        {

        }
    }
}
