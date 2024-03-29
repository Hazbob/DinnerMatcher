namespace DinnerMatcherNew.Models
{
    public class Friendship
    {
        public int FriendshipId { get; set; }
        public int UserId1 { get; set; }
        public int UserId2 { get; set; }

        public User User1 { get; set; }
        public User User2 { get; set; }
    }
    
    
}