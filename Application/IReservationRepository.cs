using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IReservationRepository
    {
        Task<Reservation> AddAsync(Reservation reservation);
        Task<Reservation> GetByIdAsync(int id);
        Task<IEnumerable<Reservation>> GetReservationsByRestaurant(int restaurantId);
        Task<IEnumerable<Reservation>> GetAllReservations();
        Task UpdateAsync(Reservation reservation);
        Task DeleteAsync(int id);
    }
}
