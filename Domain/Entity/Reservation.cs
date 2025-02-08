using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public int PartySize { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsCancelled { get; set; }

        // Navigation Property: Reservation bir kullanıcıya ait
        public User User { get; set; }

        // Navigation Property: Reservation bir restorana ait
        public Restaurant Restaurant { get; set; }
    }
}
