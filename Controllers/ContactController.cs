using FlavorHouse.Data;
using FlavorHouse.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Controllers
{
    public class ContactController : Controller
    {

        private readonly ApplicationDbContext _context;
        public ContactController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.contacts.Add(contact);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
