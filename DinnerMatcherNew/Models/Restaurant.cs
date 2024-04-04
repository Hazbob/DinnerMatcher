namespace DinnerMatcherNew.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public int PhoneNumber { get; set; }
        public required string GoogleMapsUri { get; set; }
        public bool IsOpen { get; set; }
        public string? Summary { get; set; }
        public ICollection<Game>? Games { get; set; }
    }
}