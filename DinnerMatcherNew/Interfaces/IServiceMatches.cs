namespace DinnerMatcherNew.Interfaces
{
    public interface IServiceMatches
    {
        public  Task AddRestaurantIdToLikes(int userId, int gameId, int restaurantId);
        
    }
}
