using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuanCafe.Models
{
    public class MonAn
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên món ăn")]
        [StringLength(100)]
        [Display(Name = "Tên món")]
        public string Ten { get; set; } = string.Empty;

        [Range(0, 10000000, ErrorMessage = "Giá không hợp lệ")]
        [Display(Name = "Giá (VNĐ)")]
        public int Gia { get; set; }

        [StringLength(500)]
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; } = string.Empty;

        [StringLength(300)]
        [Display(Name = "Ảnh")]
        public string AnhUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng chọn nhóm món")]
        [StringLength(50)]
        [Display(Name = "Nhóm")]
        public string Nhom { get; set; } = string.Empty;
    }
}