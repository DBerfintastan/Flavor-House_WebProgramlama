using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Models
{
    public class Cart
    {
        public int CartId { get; set; }


        public string DessertName { get; set; }
        public Dessert dessert { get; set; }


        public string Address { get; set; }
        public ApplicationUser applicationUser { get; set; }


        public string UserName { get; set; }
        public ApplicationUser applicationUser1 { get; set; }


        public int Price { get; set; }
        public Dessert dessert1 { get; set; }

    }
}
