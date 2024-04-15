using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Services
{
    public class ServiceGame : IServiceGame
    {
        private readonly IGameRepository _gameRepository;
        public ServiceGame(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }
        public async Task<bool> ServiceCheckForRestaurant(int gameId, int restaurantId)
        {
            var restaurant = await _gameRepository.CheckForRestaurant(gameId, restaurantId);
            Console.WriteLine("Hello");
            Console.WriteLine((restaurant == null).ToString());
            if (restaurant == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public async Task AddRestaurantIdToLikes(int gameId, int restaurantId)
        {
            await _gameRepository.AddLikedRestaurant(gameId, restaurantId);
        }

        public async Task<Game> CreateGame(int userId)
        {
           var game =  await _gameRepository.CreateGame(userId);
           return game;
        }
    }
}