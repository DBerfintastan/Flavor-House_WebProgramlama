using FlavorHouse.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Data
{


    public class DbInitializer : IDbInitializer
    {


        private readonly ApplicationDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(ApplicationDbContext db,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public async void Initialize()
        {

            if (_db.Database.GetPendingMigrations().Count() > 0)
            {
                _db.Database.Migrate();
            }

            //if (_db.Roles.Any(r => r.Name == "Admin")) return;

            _roleManager.CreateAsync(new IdentityRole("Admin")).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole("Customer")).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "b181210010@sakarya.edu.tr",
                Email = "b181210010@sakarya.edu.tr",
                EmailConfirmed = true,
                Name="Deniz",
                PhoneNumber = "123456789"
            }, "Admin123*").GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "b191210004@sakarya.edu.tr",
                Email = "b191210004@sakarya.edu.tr",
                EmailConfirmed = true,
                Name = "Melih",
                PhoneNumber = "123456789"
            }, "Admin123*").GetAwaiter().GetResult();

            _userManager.AddToRoleAsync(_db.Users.FirstOrDefaultAsync(u => u.Email == "b181210010@sakarya.edu.tr").GetAwaiter().GetResult(), "Admin").GetAwaiter().GetResult();
            _userManager.AddToRoleAsync(_db.Users.FirstOrDefaultAsync(u => u.Email == "b191210004@sakarya.edu.tr").GetAwaiter().GetResult(), "Admin").GetAwaiter().GetResult();


        }
    }
}

