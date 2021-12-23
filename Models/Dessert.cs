using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Models
{
    public class Dessert
    {
        public int DessertID { get; set; }
        public string DessertName { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }

        public int CategoryID { get; set; }
        public Category category { get; set; }

        public int CityID { get; set; }
        public City city { get; set; }
    }
}
