using DinnerMatcherNew.DataContext;
using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;
using Microsoft.EntityFrameworkCore;

namespace DinnerMatcherNew.Repositories
{
    public class MatchesRepository : IMatchesRepository
    {
        private readonly DinnerContext _dinnerContext;


        public MatchesRepository(DinnerContext dinnerContext)
        {
            _dinnerContext = dinnerContext;
        }
        
        public async Task<Matches> GetMatch(int gameId, int restaurantId)
        {
            return await _dinnerContext.Matches.FirstOrDefaultAsync(match =>  match.RestaurantId == restaurantId && match.GameId == gameId);
        }
        public async Task<Matches> AddMatchToDb(int userId, int gameId, int restaurantId)
        {
            var match = await GetMatch(gameId, restaurantId);
            //if match
            if (match != null)
            {
                if (match.UserIds.Contains(userId))
                {
                    
                    return match;
                }
                match.UserIds.Add(userId);
               
                await _dinnerContext.SaveChangesAsync();
                return match;
            }
            else
            {
                var newMatch = new Matches()
                {
                    GameId = gameId,
                    RestaurantId = restaurantId,
                    UserIds = new List<int>() { userId }
                };
    
                _dinnerContext.Matches.Add(newMatch);
                await _dinnerContext.SaveChangesAsync();
                return newMatch;
            }
        }

        
    }
}