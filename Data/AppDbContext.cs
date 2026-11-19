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
    }
}