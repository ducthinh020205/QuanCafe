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
                new MonAn {Id = 2, Ten = "Phở bò", Gia = 30000, MoTa = "Phở thịt bò", Nhom = "Đồ nước"}               
            );
        }
    }
}