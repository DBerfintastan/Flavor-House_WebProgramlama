using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlavorHouse.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public int? DessertID { get; set; }
        [ForeignKey("DessertID")]
        public Dessert dessert { get; set; }

        public string UserName { get; set; }
        [ForeignKey("UserName")]
        public ApplicationUser ApplicationUser { get; set; }

        public double Quantity { get; set; }

        public double Price { get; set; }

        [NotMapped]
        public double Total
        {
            get
            {
                return Quantity * Price;
            }
        }

    }
}
