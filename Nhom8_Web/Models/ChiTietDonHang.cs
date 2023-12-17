using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("DonHangObj")]
        public int? DonHangID { get; set; }
        public virtual DonHang DonHangObj { get; set; }


        [ForeignKey("SanPhamObj")]
        public int? SanPhamID { get; set; }
        public virtual SanPham SanPhamObj { get; set; }
        
        [ForeignKey("DichVuObj")]
        public int? DichVuID { get; set; }

        public virtual DichVu DichVuObj { get; set; }

        [Display(Name = "Số lượng")]
        [Range(1, 1000, ErrorMessage = "Số lượng phải nằm trong khoảng từ 1 đến 1000")]
        public int SoLuong { get; set; }
    }
}