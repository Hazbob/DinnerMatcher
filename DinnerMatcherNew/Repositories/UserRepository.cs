using DinnerMatcherNew.DataContext;
using DinnerMatcherNew.Models;

namespace DinnerMatcherNew.Repositories
{
    
    public class UserRepository : IUserRepository
    {

        private DinnerContext _DinnerContext;
        public UserRepository(DinnerContext dinnerContext)
        {
            _DinnerContext = dinnerContext;
        }
        
        public User? GetUser(int userId)
        {
            return _DinnerContext.Users.FirstOrDefault(u => u != null && u.Id == userId);
        }

    

        public IEnumerable<Friendship> GetFriends(int userId)
        {
            return _DinnerContext.Friendships.Where(f => f.UserId1 == userId || f.UserId2 == userId).ToList();
        }
    }
}