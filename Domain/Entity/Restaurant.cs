using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Gmail { get; set; }

        // Navigation Property: Restaurant'a ait menüler
        public ICollection<Menu> Menus { get; set; }

        // Navigation Property: Restaurant'a ait rezervasyonlar
        public ICollection<Reservation> Reservations { get; set; }
    }
}
