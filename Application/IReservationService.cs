using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IReservationService
    {

        Task<Reservation> CreateReservation(Reservation reservation);
        Task<IEnumerable<Reservation>> GetReservationsByRestaurant(int restaurantId);
        Task CancelReservation(int reservationId);
        Task<Reservation> GetReservationById(int id);
    }
}
