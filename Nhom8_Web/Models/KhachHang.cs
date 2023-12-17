using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Models
{
    public class KhachHang
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên khách hàng")]
        [StringLength(200)]
        public string HoVaTen { get; set;}

        [Display(Name = "Email")]
        [StringLength(200)]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Địa chỉ email không hợp lệ.")]
        public string Email { get; set;}

        [Display(Name = "Địa chỉ")]
        [StringLength(200)]
        public string DiaChi { get; set;}

        [Display(Name = "Số điện thoại")]
        [StringLength(12)]
        public string SDT {  get; set;}

        public byte[] HinhAnh { get; set; }

        [NotMapped]
        [Display(Name = "Hình ảnh")]
        public HttpPostedFileBase PictureUpload { get; set; }
    }
}