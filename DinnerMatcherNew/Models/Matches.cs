namespace DinnerMatcherNew.Models
{
    public class Matches
    {
        public int Id{ get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        
    }
}