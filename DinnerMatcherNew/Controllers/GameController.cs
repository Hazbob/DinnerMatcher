
using DinnerMatcherNew.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DinnerMatcherNew.Controllers
{
    public class GameController : Controller
    {
        private readonly IServiceRestaurant _serviceRestaurant;
        private readonly IServiceGame _gameService;


        public GameController(IServiceRestaurant serviceRestaurant, IServiceGame gameService)
        {
            _serviceRestaurant = serviceRestaurant;
            _gameService = gameService;
        }
        
        
        
        
        // Post
        [HttpPost("game/{gameId}")]
        public async Task<IActionResult> LikeRestaurantTask([FromQuery] int restaurantId, [FromRoute]int gameId)
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
            //here is if the restaurant already exists in the database
            //this shouldnt return ok it should call the match found function
            return Ok();


        }
        
    }
}