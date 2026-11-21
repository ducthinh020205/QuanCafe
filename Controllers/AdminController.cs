using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanCafe.Data;
namespace QuanCafe.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        } 

        public async Task<IActionResult> LienHe()
        {
            var tinNhan = await _context.LienHes.OrderByDescending(l => l.NgayGui).ToListAsync();
            return View(tinNhan);
        }

        [HttpPost]
        public async Task<IActionResult> XoaLienHe(int id)
        {

            var lienHe = await _context.LienHes.FindAsync(id);
            if(lienHe != null)
            {
                _context.LienHes.Remove(lienHe);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(LienHe));
            
        }
    }
}