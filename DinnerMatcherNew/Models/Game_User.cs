namespace DinnerMatcherNew.Models
{
    public class Game_User
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public Game Game { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}