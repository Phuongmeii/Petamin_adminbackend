using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên blog")]
        [StringLength(200)]

        public string TenBlog { get; set; }

        [Display(Name = "Nội dung")]
        [Column(TypeName = "nvarchar(max)")]
        public string NoiDung { get; set; }
    }
}