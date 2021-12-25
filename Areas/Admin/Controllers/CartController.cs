using FlavorHouse.Data;
using FlavorHouse.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Areas.Admin.Controllers
{
    public class CartController : Controller
    {

        private readonly ApplicationDbContext _context;
        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var d = _context.carts.ToList<Cart>();
            return View();
        }
    }
}
