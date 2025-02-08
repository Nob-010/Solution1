using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }

        // Navigation Property: Menu bir restorana ait
        public Restaurant Restaurant { get; set; }
    }
}
