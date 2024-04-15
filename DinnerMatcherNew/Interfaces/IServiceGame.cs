using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Interfaces
{
    public interface IServiceGame
    {
        public Task<bool> ServiceCheckForRestaurant(int gameId, int restaurantId);
        Task AddRestaurantIdToLikes(int gameId, int restaurantId);

        Task<Game> CreateGame(int userId);
    }
}