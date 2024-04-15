using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Interfaces
{
    public interface IGameRepository
    {
        public Task<Game> CreateGame(int userId);
        public Task<Restaurant?> CheckForRestaurant(int gameId, int restaurantId);
        Task AddLikedRestaurant(int gameId, int restaurantId);
    }
}