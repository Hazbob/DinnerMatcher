namespace DinnerMatcherNew.Models
{
    public class Matches
    {
        public int Id{ get; set; }
        
      
        public List<int> UserIds { get; set; }

        public int GameId { get; set; }
        public Game Game { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        
    }
}