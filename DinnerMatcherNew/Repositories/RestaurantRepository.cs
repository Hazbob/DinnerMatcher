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

        public IEnumerable<Restaurant?> GetRestaurants()
        {
            return _dinnerContext.Restaurants;
        }

        public Restaurant? GetRestaurant(int restaurantId)
        {
            return _dinnerContext.Restaurants.FirstOrDefault(r => r != null && r.Id == restaurantId);
        }
    }
}