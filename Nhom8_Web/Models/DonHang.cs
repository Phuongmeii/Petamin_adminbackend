using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Models
{
    public class DonHang
    {
        public DonHang() 
        {
            ChiTietDonHangs = new List<ChiTietDonHang>();
        }    

        public enum TT
        {
            DaGiao,
            DangGiao,
            ChoDuyet,
            Huy
        }

        public enum TTThanhToan
        {
            DaThanhToan,
            ChuaThanhToan
        }
        [Key]
        public int ID { get; set; }


        public TT TrangThai { get; set; }

        public TTThanhToan TrangThaiThanhToan { get; set; }

        public IList<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public double TongTien { get; set; }
        public DateTime NgayLap { get; set; }

        [ForeignKey("KhachHangObj")]
        public int? KhachHangID { get; set; }
        public virtual KhachHang KhachHangObj { get; set; }
    }
}