using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Models
{
    public class DichVu
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên dịch vụ")]
        [StringLength(200)]
        public string TenDichVu { get; set; }

        [Display(Name = "Số lượng")]
        [Range(1, 1000, ErrorMessage = "Số lượng phải nằm trong khoảng từ 1 đến 1000")]
        public int SoLuong { get; set; }
        [Display(Name = "Mô tả")]
        [Column(TypeName = "nvarchar(max)")]
        public string MoTa {  get; set; }

        [Display(Name = "Giá Tiền")]
        [Range(5000, double.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:0,000}")]
        public double GiaTien { get; set; }

        public byte[] HinhAnh { get; set; }

        [NotMapped]
        [Display(Name = "Hình ảnh")]
        public HttpPostedFileBase PictureUpload { get; set; }
    }
}