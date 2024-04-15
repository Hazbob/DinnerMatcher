
using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;
using Microsoft.AspNetCore.Mvc;

namespace DinnerMatcherNew.Controllers
{
    public class GameController : Controller
    {
        private readonly IServiceRestaurant _serviceRestaurant;
        private readonly IServiceGame _gameService;
        private readonly IServiceMatches _matchesService;


        public GameController(IServiceRestaurant serviceRestaurant, IServiceGame gameService, IServiceMatches matchesService)
        {
            _serviceRestaurant = serviceRestaurant;
            _gameService = gameService;
            _matchesService = matchesService;
        }

        [HttpPost("game")]
        public async Task<IActionResult> CreateGame(int userId)
        {
            var game =await  _gameService.CreateGame(userId);
            if (game is not null)
            {
                return Ok(game);
            }
            else
            {
                return BadRequest("failed to create game");
            }
        }
        
        // Post
        [HttpPost("game/{gameId}")]
        public async Task<IActionResult> LikeRestaurantTask( int restaurantId, int gameId, int userId)
        {
            var restaurant = _serviceRestaurant.ServiceGetRestaurantById(restaurantId);
            if (restaurant is null)
                return NotFound("No restaurant exists by that id");
            
            var doesRestaurantExistInGame = await _gameService.ServiceCheckForRestaurant(gameId, restaurantId );
            if (!doesRestaurantExistInGame)
            {
                await _gameService.AddRestaurantIdToLikes(gameId, restaurantId);
                return Created();
            }

            await _matchesService.AddRestaurantIdToLikes(userId, gameId, restaurantId);
            
            return Ok("Match Found");
            
            
        }
        
    }
}