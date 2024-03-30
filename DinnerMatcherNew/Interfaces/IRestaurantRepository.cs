using DinnerMatcherNew.Models;

namespace DinnerMatcherNew
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant> GetRestaurants();
        
    }
}