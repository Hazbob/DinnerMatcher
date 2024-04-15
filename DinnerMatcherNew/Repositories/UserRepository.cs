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
            // right now this doesnt check if accepted or not
            return _DinnerContext.Friendships.Where(f => f.FirstUserId == userId || f.SecondUserId == userId).ToList();
        }

        public async Task<User> CreateUserAsync(string username, string email, string password)
        {
            var newUser = new User()
            {
                Username = username,
                Email = email,
                Password = password
            };
             await _DinnerContext.Users.AddAsync(newUser);
             await _DinnerContext.SaveChangesAsync();

             return newUser;

        }
    }
}