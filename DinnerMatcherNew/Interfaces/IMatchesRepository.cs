using System.Text.RegularExpressions;
using DinnerMatcherNew.Models;
using Microsoft.AspNetCore.Mvc;

namespace DinnerMatcherNew.Interfaces
{
    public interface IMatchesRepository
    {
        public Task<Matches>? GetMatch(int gameId, int restaurantId);
        public Task<Matches> AddMatchToDb(int userId, int gameId, int restaurantId);
    }
}