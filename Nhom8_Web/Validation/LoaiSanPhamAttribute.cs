using Nhom8_Web.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nhom8_Web.Validation
{
    public class LoaiSanPhamAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext
validationContext)
        {
            int loaisanpham_ID = int.Parse(value.ToString());
            var db = new ApplicationDbContext();
            if (db.LoaiSanPhams.Any(x => x.ID == loaisanpham_ID))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(
            ErrorMessage ?? "Loại sản phẩm không tồn tại");
        }
    }
}