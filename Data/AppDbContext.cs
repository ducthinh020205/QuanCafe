using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanCafe.Models;

namespace QuanCafe.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<LienHe> LienHes {get; set;}
        public DbSet<MonAn> MonAns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MonAn>().HasData(
                new MonAn {Id = 1, Ten = "Bánh mì", Gia = 30000, MoTa = "Bánh mì trứng chả xúc xích thịt", Nhom = "Đồ ăn nhanh"},
                new MonAn {Id = 2, Ten = "Phở bò", Gia = 30000, MoTa = "Phở thịt bò", Nhom = "Đồ nước"},   
                new MonAn {Id = 3, Ten = "Phở gà", Gia = 30000, MoTa = "Phở thịt gà", Nhom = "Đồ nước"},
                new MonAn {Id = 4, Ten = "Phở lợn", Gia = 35000, MoTa = "Phở thịt lợn", Nhom = "Đồ nước"},
                new MonAn {Id = 5, Ten = "Bún Riêu", Gia = 40000, MoTa = "Bún riêu cua", Nhom = "Đồ nước"},
                new MonAn {Id = 6, Ten = "Cà phê đá", Gia = 20000, MoTa = "Cà phê thêm đã", Nhom = "Thức uống"},
                new MonAn {Id = 7, Ten = "Cà phê đen", Gia = 20000, MoTa = "Cà phê đậm đặc", Nhom = "Thức uống"},
                new MonAn {Id = 8, Ten = "Nước cam", Gia = 30000, MoTa = "Nước ép cam pha chế", Nhom = "Thức uống"},
                new MonAn {Id = 9, Ten = "Trà tắc", Gia = 15000, MoTa = "Nước tắc pha chế", Nhom = "Thức uống"},
                new MonAn {Id = 10, Ten = "Trà chanh", Gia = 15000, MoTa = "Nước Chanh pha chế", Nhom = "Thức uống"}            
            );
        }
    }
}