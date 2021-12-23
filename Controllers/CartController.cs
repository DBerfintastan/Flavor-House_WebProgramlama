using FlavorHouse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Controllers
{
    
    public class CartController : Controller
    {
      
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

    
    }
}
