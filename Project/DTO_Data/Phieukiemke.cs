using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DTO_Data
{
    public class Phieukiemke
    {
        [Display(Name = "Mã phiếu kiểm kê")]
        public string MaPhieuKiemKe { get; set; }

        [Display(Name = "Mã sản phẩm")]
        public string MaSanPham { get; set; }

        [Display(Name = "Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [Display(Name = "Số lượng tồn theo máy")]
        public int SoLuongTonTheoMay { get; set; }

        [Display(Name = "Số lượng tồn thực tế")]
        public int SoLuongTonThucTe { get; set; }

        [Display(Name = "Ngày kiểm kê")]
        public string NgayKiemKe { get; set; }

        [Display(Name="Người kiểm kê")]
        public string NguoiKiemKe { get; set; }


        public Phieukiemke()
        {

        }
    }
}
