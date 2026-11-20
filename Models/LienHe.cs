using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuanCafe.Models
{
    public class LienHe
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Quý khách vui lòng nhập Họ Tên!!!")]
        [StringLength(100)]
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; } = string.Empty;
        [Required(ErrorMessage = "Quý khách vui lòng nhập số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không hợp lệ")]
        [StringLength(15)]
        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; } = string.Empty;
        [Required(ErrorMessage = "Vui Lòng nhập nội dung")]
        [StringLength(2000)]
        [Display(Name = "Nội dung")]
        public string NoiDung { get; set; } = string.Empty;
        [Display(Name = "Ngày gửi")]
        public DateTime NgayGui { get; set; } = DateTime.Now;
    }
}