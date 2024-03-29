namespace DinnerMatcherNew.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
        public double Review { get; set; }
        public int PhoneNumber { get; set; }
        public required string GoogleMapsUri { get; set; }
        public bool IsOpen { get; set; }
        public string? Summary { get; set; }
    }
}