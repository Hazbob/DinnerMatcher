using DinnerMatcherNew.DataContext;
using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;
using Microsoft.EntityFrameworkCore;

namespace DinnerMatcherNew.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly DinnerContext _dinnerContext;
        public GameRepository(DinnerContext dinnerContext)
        {
            _dinnerContext = dinnerContext;
        }
        public async Task<Restaurant?> CheckForRestaurant(int gameId, int restaurantId)
        {
            var game = _dinnerContext.Games.FirstOrDefault(g => g.Id == gameId);
            var foundRestaurantId = game?.LikedRestaurant_Ids?.FirstOrDefault(resId => resId == restaurantId);
            var restaurant = _dinnerContext.Restaurants.FirstOrDefault(r => r.Id == foundRestaurantId);
            return restaurant;
        }

        public async Task AddLikedRestaurant(int gameId, int restaurantId)
        {
            // Retrieve the game entity from the database
            var game = await _dinnerContext.Games.FirstOrDefaultAsync(g => g.Id == gameId);

            // If the game exists, add the restaurantId to the LikedRestaurant_Ids collection
            if (game != null)
            {
                // Make sure LikedRestaurant_Ids is initialized
                if (game.LikedRestaurant_Ids == null)
                {
                    game.LikedRestaurant_Ids = new List<int>();
                }

                // Add the restaurantId to the collection
                game.LikedRestaurant_Ids.Add(restaurantId);

                // Save changes to the database
                await _dinnerContext.SaveChangesAsync();
            }
        }


    }
}