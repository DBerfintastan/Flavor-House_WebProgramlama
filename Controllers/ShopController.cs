using FlavorHouse.Data;
using FlavorHouse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Controllers
{
    public class ShopController : Controller
    {
        
        private readonly ApplicationDbContext _context;
        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize]
        public IActionResult Index()
        {
            var data = _context.desserts.OrderByDescending(x => x.DessertName).Take(_context.desserts.Count()).ToList();
            return View(data);
        }
    }
}
