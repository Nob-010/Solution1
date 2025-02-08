using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ReservationService : IReservationService
    {

        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            // Rezervasyonu eklerken, eklemek için repository'i kullanıyoruz.
            return await _reservationRepository.AddAsync(reservation);
        }

        public async Task<IEnumerable<Reservation>> GetReservationsByRestaurant(int restaurantId)
        {
            // Belirli bir restorana ait tüm rezervasyonları alıyoruz.
            return await _reservationRepository.GetReservationsByRestaurant(restaurantId);
        }

        public async Task CancelReservation(int reservationId)
        {
            // Rezervasyonu iptal etme işlemi
            var reservation = await _reservationRepository.GetByIdAsync(reservationId);
            if (reservation == null)
            {
                throw new ArgumentException("Reservation oluşmadi.");
            }

            reservation.IsCancelled = true;
            await _reservationRepository.UpdateAsync(reservation);
        }

        public Task<Reservation> GetReservationById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

