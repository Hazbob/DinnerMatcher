using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Interfaces
{
    public interface IRestaurantRepository
    {
        IEnumerable<Restaurant?> GetRestaurants();

        Restaurant? GetRestaurant(int restaurantId);
    }
}