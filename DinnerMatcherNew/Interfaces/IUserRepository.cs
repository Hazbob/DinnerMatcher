using DinnerMatcherNew.Models;

namespace DinnerMatcherNew
{
    public interface IUserRepository
    {
        User? GetUser(int userId);
        IEnumerable<Friendship> GetFriends(int userId);
    }
}