
using DinnerMatcherNew.Models;
using Microsoft.EntityFrameworkCore;

namespace DinnerMatcherNew.Data
{
    public static class RestaurantSeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
       

            modelBuilder.Entity<Game_User>().HasData(
                new Game_User { Id = 1, GameId = 1, UserId = 1 },
                new Game_User { Id = 2, GameId = 1, UserId = 2 }
            );
            
            modelBuilder.Entity<Game>().HasData(
                new Game
                {
                    Id = 1,
                    LatitudeMain = 0.0,
                    LongitudeMain = 0.0,
                    LikedRestaurant_Ids = new List<int>(){1},
                    Restaurants = null,
                    Users = null,
                }
            );
            
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    Id = 1,
                    Name = "Dishoom",
                    Address = "32 Bridge St, Manchester M3 3BT, UK",
                    Rating = 4.7,
                    PhoneNumber = 1615373737,
                    GoogleMapsUri = "https://maps.google.com/?cid=7531015505938905277",
                    Summary = "Trendy restaurant serving modern Indian cuisine amid elegant surroundings & stained glass windows."
                },
                new Restaurant
                {
                    Id = 2,
                    Name = "Fat Pat’s",
                    Address = "88 Portland St, Manchester M1 4GX, UK",
                    Rating = 4.2,
                    PhoneNumber = 0, // No phone number provided
                    GoogleMapsUri = "https://maps.google.com/?cid=14636860895556749090",
                    Summary = "Buzzy take-out window dispensing hefty sub sandwiches like cheesesteaks & hot honey chicken."
                },
                new Restaurant
                {
                    Id = 3,
                    Name = "Cosmo",
                    Address = "48-58 Deansgate, Manchester M3 2EG, UK",
                    Rating = 4.1,
                    PhoneNumber = 1619891388,
                    GoogleMapsUri = "https://maps.google.com/?cid=15890343035137462782",
                    Summary = "Stylish, modern chain dining room with cooking stations producing a range of global dishes."
                },
                new Restaurant
                {
                    Id = 4,
                    Name = "San Carlo",
                    Address = "42 King St W, Manchester M3 2WY, UK",
                    Rating = 4.2,
                    PhoneNumber = 1618346226,
                    GoogleMapsUri = "https://maps.google.com/?cid=6290816004385542980",
                    Summary = "Sleek, high-end Italian destination restaurant known for its sceney, celebrity-studded clientele."
                },
                new Restaurant
                {
                    Id = 5,
                    Name = "Rudy's Pizza Napoletana - Peter Street",
                    Address = "Petersfield House, Peter St, Manchester M2 5QJ, UK",
                    Rating = 4.7,
                    PhoneNumber = 1616608040,
                    GoogleMapsUri = "https://maps.google.com/?cid=11185039208312255219"
                },
                new Restaurant
                {
                    Id = 6,
                    Name = "El Gato Negro Tapas Manchester",
                    Address = "52 King St, Manchester M2 4LY, UK",
                    Rating = 4.6,
                    PhoneNumber = 1616948585,
                    GoogleMapsUri = "https://maps.google.com/?cid=18426442113561219475",
                    Summary = "Tapas & drinks are provided in this 3-storey converted townhouse that has stylish interiors."
                },
                new Restaurant
                {
                    Id = 7,
                    Name = "Moose Coffee",
                    Address = "20 York St, Manchester M2 2BB, UK",
                    Rating = 4.5,
                    PhoneNumber = 1612287994,
                    GoogleMapsUri = "https://maps.google.com/?cid=6408130840566072891",
                    Summary = "Elegant, traditional diner serving hearty American-style breakfasts, brunches and coffee."
                },
                new Restaurant
                {
                    Id = 8,
                    Name = "Society",
                    Address = "Basement, 100 Barbirolli Square, Manchester M2 3BD, UK",
                    Rating = 4.5,
                    PhoneNumber = 0, // No phone number provided
                    GoogleMapsUri = "https://maps.google.com/?cid=991045946514577218",
                    Summary = "Chill destination featuring stands doling out global street foods, plus craft beer & cocktails."
                },
                new Restaurant
                {
                    Id = 9,
                    Name = "Gaucho Manchester",
                    Address = "2A St Mary's St, Manchester M3 2LB, UK",
                    Rating = 4.5,
                    PhoneNumber = 2079253900,
                    GoogleMapsUri = "https://maps.google.com/?cid=1253734206550260659",
                    Summary = "Designer furnishings & cowhide fabrics create a lavish backdrop for Argentine food & wine."
                },
                new Restaurant
                {
                    Id = 10,
                    Name = "Rudy's Pizza Napoletana - Portland Street",
                    Address = "30 Portland St, Manchester M1 4GS, UK",
                    Rating = 4.7,
                    PhoneNumber = 1615322922,
                    GoogleMapsUri = "https://maps.google.com/?cid=10486315685157041285"
                },
                new Restaurant
                {
                    Id = 11,
                    Name = "Gusto Italian",
                    Address = "4 Lloyd St, Manchester M2 5AB, UK",
                    Rating = 4.4,
                    PhoneNumber = 1616411120,
                    GoogleMapsUri = "https://maps.google.com/?cid=13638348935372707988",
                    Summary = "Polished Sicilian restaurant serving char-grilled dishes, stone-baked pizzas & seafood."
                },
                new Restaurant
                {
                    Id = 12,
                    Name = "Six by Nico Spring Gardens",
                    Address = "60 Spring Gardens, Manchester M2 2BQ, UK",
                    Rating = 4.6,
                    PhoneNumber = 1618321815,
                    GoogleMapsUri = "https://maps.google.com/?cid=4984268512638993458"
                },
                new Restaurant
                {
                    Id = 13,
                    Name = "Comptoir Libanais",
                    Address = "18-19 The Avenue, Manchester M3 3HF, UK",
                    Rating = 4.3,
                    PhoneNumber = 1616723999,
                    GoogleMapsUri = "https://maps.google.com/?cid=8092230557133234279"
                },
                new Restaurant
                {
                    Id = 14,
                    Name = "Pho Cue",
                    Address = "52a Faulkner St, Manchester M1 4FH, UK",
                    Rating = 4.6,
                    PhoneNumber = 1612375664,
                    GoogleMapsUri = "https://maps.google.com/?cid=9678613109120993862",
                    Summary = "Straightforward restaurant specialising in Vietnamese cuisine, including soups & sandwiches."
                },
                new Restaurant
                {
                    Id = 15,
                    Name = "American Pies Mcr",
                    Address = "unit 1, 58 W Mosley St, Manchester M2 3HZ, UK",
                    Rating = 4.5,
                    PhoneNumber = 1616376776,
                    GoogleMapsUri = "https://maps.google.com/?cid=604196843788206545",
                    Summary = "Restaurant with a laid-back vibe serving American-style pizzas, calzones & dessert pies."
                },
                new Restaurant
                {
                    Id = 16,
                    Name = "wagamama manchester st peters square",
                    Address = "2 St Peter's Sq, Manchester M2 3LQ, UK",
                    Rating = 4.3,
                    PhoneNumber = 1613024630,
                    GoogleMapsUri = "https://maps.google.com/?cid=16250524245534901885",
                    Summary = "Casual restaurant serving Asian dishes in a Japanese-inspired setting with long communal benches."
                },
                new Restaurant
                {
                    Id = 17,
                    Name = "Maki & Ramen",
                    Address = "11 York St, Manchester M2 2AW, UK",
                    Rating = 4.7,
                    PhoneNumber = 1614707019,
                    GoogleMapsUri = "https://maps.google.com/?cid=10526132420135364650"
                },
                new Restaurant
                {
                    Id = 18,
                    Name = "Thaikhun",
                    Address = "The Avenue Spinningfields, Manchester M3 3HF, UK",
                    Rating = 4.4,
                    PhoneNumber = 1614140264,
                    GoogleMapsUri = "https://maps.google.com/?cid=8641579490415565491",
                    Summary = "Lively, ephemera-packed Thai joint with street-market furniture and an open kitchen, plus a tuk-tuk."
                },
                new Restaurant
                {
                    Id = 19,
                    Name = "Honest Burgers Manchester",
                    Address = "36 Bridge St, Manchester M3 3BT, UK",
                    Rating = 4.5,
                    PhoneNumber = 1616763890,
                    GoogleMapsUri = "https://maps.google.com/?cid=4741104865423632753"
                },
                new Restaurant
                {
                    Id = 20,
                    Name = "POT KETTLE BLACK Barton Arcade",
                    Address = "Barton Arcade, Manchester M3 2BW, UK",
                    Rating = 4.5,
                    PhoneNumber = 0, // No phone number provided
                    GoogleMapsUri = "https://maps.google.com/?cid=5724952766288945264",
                    Summary = "Airy cafe with reclaimed floorboards, in Victorian arcade, for gourmet coffee, tea and snacks."
                }
            );
        }
    }
}
