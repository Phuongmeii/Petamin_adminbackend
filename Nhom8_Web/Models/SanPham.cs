using Nhom8_Web.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace Nhom8_Web.Models
{
    public class SanPham
    {
        public enum trangThai
        {
            ConHang,
            HetHang
        }
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên sản phẩm")]
        [StringLength(200)]
        public string TenSanPham { get; set; }

        [Display(Name = "Số lượng")]
        [Range(1, 1000, ErrorMessage = "Số lượng phải nằm trong khoảng từ 1 đến 1000")]
        public int SoLuong { get; set; }

        [Display(Name = "Giá Tiền")]
        [Range(5000, double.MaxValue)]
        [DisplayFormat(DataFormatString = "{0:0,000}")]
        public int GiaTien { get; set; }

        [Display(Name = "Giảm giá")]
        [Range(1, 100, ErrorMessage = "Giảm giá phải nằm trong khoảng từ 1 đến 100")]
        public int GiamGia { get; set; }

        [Display(Name = "Giá bán")]
        [DisplayFormat(DataFormatString = "{0:0,000}")]
        public int GiaBan {  get; set; }
        [Display(Name = "Trạng thái")]
        public trangThai TrangThai { get; set; }
        
        public byte[] HinhAnh { get; set; }

        [NotMapped]
        [Display(Name = "Hình ảnh")]
        public HttpPostedFileBase PictureUpload { get; set; }

        [ForeignKey("LoaiSanPhamObj")]
        public int? LoaiSanPhamID { get; set; }

        public virtual LoaiSanPham LoaiSanPhamObj { get; set; }
    }
}