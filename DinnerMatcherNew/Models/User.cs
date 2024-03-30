namespace DinnerMatcherNew.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public ICollection<Friendship> Friendships { get; set; }
        public ICollection<Game>? Games { get; set; }
        public List<Game_User> GameUsers { get; set; }
        
    }
}