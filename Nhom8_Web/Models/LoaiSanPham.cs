using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Models
{
    public class LoaiSanPham
    {
        [Key]
        public int ID {  get; set; }

        [Display(Name = "Tên loại sản phẩm")]
        [Required]
        [StringLength(200)]
        public string Name {  get; set; }

        public virtual IList<SanPham> SanPhams { get; set; }
    }
}