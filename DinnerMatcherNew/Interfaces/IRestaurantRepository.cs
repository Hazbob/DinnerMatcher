using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Interfaces
{
    public interface IRestaurantRepository
    {
        Task<IEnumerable<Restaurant?>> GetRestaurants();

        Restaurant? GetRestaurantById(int restaurantId);
    }
}