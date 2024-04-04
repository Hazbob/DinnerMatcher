using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Services
{
    public class ServiceRestaurant : IServiceRestaurant
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IGameRepository _gameRepository;

        public ServiceRestaurant(IRestaurantRepository restaurantRepository, IGameRepository gameRepository)
        {
            _restaurantRepository = restaurantRepository;
            _gameRepository = gameRepository;
        }


        public Task<IEnumerable<Restaurant?>> ServiceGetRestaurants()
        {
            var restaurants = _restaurantRepository.GetRestaurants();
            return restaurants;
        }


        public Restaurant? ServiceGetRestaurantById(int id)
        {
            var restaurant = _restaurantRepository.GetRestaurantById(id);
            return restaurant;
        }
        
    }
}