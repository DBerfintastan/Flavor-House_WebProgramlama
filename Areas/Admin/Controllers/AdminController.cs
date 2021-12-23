using FlavorHouse.Data;
using FlavorHouse.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
             private readonly ApplicationDbContext _context;
             public AdminController(ApplicationDbContext context)
             {
                 _context = context;
             }
            public IActionResult Index()
            {
                return View();
            }

            
            public IActionResult Desserts()
            {
                var d = _context.desserts.ToList<Dessert>();
                return View(d);
            }

            [HttpGet]
            public IActionResult AddNewDessert()
            {
                return View();
            }

            [HttpPost]
            public IActionResult AddNewDessert(Dessert dessert)
            {
                _context.desserts.Add(dessert);
                _context.SaveChanges();

                return RedirectToAction("Desserts");
            }

            public IActionResult DeleteDessert(int id)
            {
                var dep = _context.desserts.Find(id);
                _context.desserts.Remove(dep);
                _context.SaveChanges();
                return RedirectToAction("Desserts");
            }

            public IActionResult GetDessert(int id)
            {
                var des = _context.desserts.Find(id);
                return View("GetDessert", des);

            }
            public IActionResult UpdateDessert(Dessert dessert)
            {
                var des = _context.desserts.Find(dessert.DessertID);
                des.DessertName = dessert.DessertName;
                des.Price = dessert.Price;
                des.Picture = dessert.Picture;
                des.CategoryID = dessert.CategoryID;
                des.CityID = dessert.CityID;
                _context.SaveChanges();
                return RedirectToAction("Desserts");
            }
    }

}

