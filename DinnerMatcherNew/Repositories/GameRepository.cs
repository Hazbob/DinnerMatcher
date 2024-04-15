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

        public async Task<Game> CreateGame(int userId)
        {
            var user = await _dinnerContext.Users.FirstOrDefaultAsync(u => u.Id == userId);
            if (user is null)
                throw new ArgumentNullException();
            Game newGame = new Game()
            {
                Users = new List<User>(){user}
            };

             await _dinnerContext.Games.AddAsync(newGame);
             await _dinnerContext.SaveChangesAsync();
            return newGame;
        }

        public async Task<Restaurant?> CheckForRestaurant(int gameId, int restaurantId)
        {
            var game =await  _dinnerContext.Games.FirstOrDefaultAsync(g => g.Id == gameId);
            var foundRestaurantId =  game?.LikedRestaurant_Ids?.FirstOrDefault(resId => resId == restaurantId);
            var restaurant = await _dinnerContext.Restaurants.FirstOrDefaultAsync(r => r.Id == foundRestaurantId);
            await _dinnerContext.SaveChangesAsync();
            return restaurant;
        }

        public async Task AddLikedRestaurant(int gameId, int restaurantId)
        {
           
            var game = await _dinnerContext.Games.FirstOrDefaultAsync(g => g.Id == gameId);

            if (game != null)
            {
                
                if (game.LikedRestaurant_Ids == null)
                {
                    game.LikedRestaurant_Ids = new List<int>();
                }

                
                game.LikedRestaurant_Ids.Add(restaurantId);
                

           
                await _dinnerContext.SaveChangesAsync();
            }
        }


    }
}