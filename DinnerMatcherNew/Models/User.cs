using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DinnerMatcherNew.Models
{
    public class User
    {
        public int Id { get; set; }
        public  string Username { get; set; }
        public  string Email { get; set; }
        public  string Password { get; set; }
        [JsonIgnore]
        public ICollection<Game>? Games { get; set; }
        
        public List<Game_User> GameUsers { get; set; }
        
        public List<Friendship> Friends { get; set; }
        public ICollection<Friendship> FirstUserFriendships { get; set; }
        public ICollection<Friendship> SecondUserFriendships { get; set; }
        public ICollection<Matches> Matches { get; set; }

        
    }
}