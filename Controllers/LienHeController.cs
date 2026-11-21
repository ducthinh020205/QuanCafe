using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanCafe.Data;
using Microsoft.EntityFrameworkCore;
using QuanCafe.Models;

namespace QuanCafe.Controllers
{
    public class LienHeController : Controller
    {
        private readonly AppDbContext _context;
        public LienHeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LienHe model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.NgayGui = DateTime.Now;
            _context.LienHes.Add(model);
            await _context.SaveChangesAsync();

            TempData["Thanh Cong"] = "Cam on ban, Quan da nhan duoc tin nhan";
            return RedirectToAction(nameof(Index));
        }
    }
}