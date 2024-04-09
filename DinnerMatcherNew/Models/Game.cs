using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace DinnerMatcherNew.Models
{
    public class Game
    {
        public int Id { get; set; }
        public double LongitudeMain { get; set; }
        public double LatitudeMain { get; set; }
        public List<User> Users { get; set; }
        public List<Game_User> GameUsers { get; set; }
        public List<int> LikedRestaurant_Ids { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
        public ICollection<Matches> Matches { get; set; }

    }
}