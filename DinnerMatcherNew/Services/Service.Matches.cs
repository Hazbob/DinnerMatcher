using DinnerMatcherNew.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace DinnerMatcherNew.Services
{
    public class ServiceMatches : IServiceMatches
    {
        private readonly IMatchesRepository _matchesRepository;

        public ServiceMatches(IMatchesRepository matchesRepository)
        {
            _matchesRepository = matchesRepository;
        }
        public async Task AddRestaurantIdToLikes(int userId, int gameId, int restaurantId)
        {
            await _matchesRepository.AddMatchToDb(userId, gameId, restaurantId);
        }

     

    }
}