using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            return await _restaurantRepository.GetAllRestaurants();
        }

        public async Task<Restaurant> GetRestaurantById(int id)
        {
            return await _restaurantRepository.GetRestaurantById(id);
        }

        public async Task<Restaurant> CreateRestaurant(Restaurant restaurant)
        {
            return await _restaurantRepository.AddAsync(restaurant);
        }

        public async Task UpdateRestaurant(Restaurant restaurant)
        {
            await _restaurantRepository.UpdateAsync(restaurant);
        }

        public async Task DeleteRestaurant(int id)
        {
            await _restaurantRepository.DeleteAsync(id);
        }
    }
}
