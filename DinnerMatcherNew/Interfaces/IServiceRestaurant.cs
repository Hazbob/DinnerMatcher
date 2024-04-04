using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Interfaces
{
    public interface IServiceRestaurant
    {
        public Task<IEnumerable<Restaurant?>> ServiceGetRestaurants();

        public Restaurant? ServiceGetRestaurantById(int id);
        

    }
}