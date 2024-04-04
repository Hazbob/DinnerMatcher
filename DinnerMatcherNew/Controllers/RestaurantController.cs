using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;
using Microsoft.AspNetCore.Mvc;

namespace DinnerMatcherNew.Controllers
{
    public class RestaurantController : Controller
    {
        private readonly IServiceRestaurant _serviceRestaurant;

        //GET
        public RestaurantController(IServiceRestaurant serviceRestaurant)
        {
            _serviceRestaurant = serviceRestaurant;
        }
        [HttpGet("restaurant/{restaurantId}")]
        public async Task<IActionResult> GetRestaurantByIdTask([FromRoute] int restaurantId)
        {
            var restaurant = _serviceRestaurant.ServiceGetRestaurantById(restaurantId);
            return Ok(restaurant);
        }
    }
}