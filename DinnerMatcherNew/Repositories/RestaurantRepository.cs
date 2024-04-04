using DinnerMatcherNew.DataContext;
using DinnerMatcherNew.Interfaces;
using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private readonly DinnerContext _dinnerContext;

        public RestaurantRepository(DinnerContext dinnerContext)
        {
            _dinnerContext = dinnerContext;
        }

        public async Task<IEnumerable<Restaurant?>> GetRestaurants()
        {
            return _dinnerContext.Restaurants;
        }

        public Restaurant? GetRestaurantById(int restaurantId)
        {
            return _dinnerContext.Restaurants.FirstOrDefault(r => r != null && r.Id == restaurantId);
        }
    }
}