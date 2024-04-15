﻿// <auto-generated />
using DinnerMatcherNew.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DinnerMatcherNew.Migrations
{
    [DbContext(typeof(DinnerContext))]
    [Migration("20240409232550_matchesfixnullable")]
    partial class matchesfixnullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DinnerMatcherNew.Models.Friendship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FirstUserId")
                        .HasColumnType("int");

                    b.Property<int>("SecondUserId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FirstUserId");

                    b.HasIndex("SecondUserId");

                    b.HasIndex("UserId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("LikedRestaurant_Ids")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LikedRestaurant_Ids = "[1]"
                        });
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Game_User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("UserId");

                    b.ToTable("GameUsers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameId = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            GameId = 1,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Matches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("UserId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GoogleMapsUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "32 Bridge St, Manchester M3 3BT, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=7531015505938905277",
                            IsOpen = false,
                            Name = "Dishoom",
                            PhoneNumber = 1615373737,
                            Rating = 4.7000000000000002,
                            Summary = "Trendy restaurant serving modern Indian cuisine amid elegant surroundings & stained glass windows."
                        },
                        new
                        {
                            Id = 2,
                            Address = "88 Portland St, Manchester M1 4GX, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=14636860895556749090",
                            IsOpen = false,
                            Name = "Fat Pat’s",
                            PhoneNumber = 0,
                            Rating = 4.2000000000000002,
                            Summary = "Buzzy take-out window dispensing hefty sub sandwiches like cheesesteaks & hot honey chicken."
                        },
                        new
                        {
                            Id = 3,
                            Address = "48-58 Deansgate, Manchester M3 2EG, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=15890343035137462782",
                            IsOpen = false,
                            Name = "Cosmo",
                            PhoneNumber = 1619891388,
                            Rating = 4.0999999999999996,
                            Summary = "Stylish, modern chain dining room with cooking stations producing a range of global dishes."
                        },
                        new
                        {
                            Id = 4,
                            Address = "42 King St W, Manchester M3 2WY, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=6290816004385542980",
                            IsOpen = false,
                            Name = "San Carlo",
                            PhoneNumber = 1618346226,
                            Rating = 4.2000000000000002,
                            Summary = "Sleek, high-end Italian destination restaurant known for its sceney, celebrity-studded clientele."
                        },
                        new
                        {
                            Id = 5,
                            Address = "Petersfield House, Peter St, Manchester M2 5QJ, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=11185039208312255219",
                            IsOpen = false,
                            Name = "Rudy's Pizza Napoletana - Peter Street",
                            PhoneNumber = 1616608040,
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 6,
                            Address = "52 King St, Manchester M2 4LY, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=18426442113561219475",
                            IsOpen = false,
                            Name = "El Gato Negro Tapas Manchester",
                            PhoneNumber = 1616948585,
                            Rating = 4.5999999999999996,
                            Summary = "Tapas & drinks are provided in this 3-storey converted townhouse that has stylish interiors."
                        },
                        new
                        {
                            Id = 7,
                            Address = "20 York St, Manchester M2 2BB, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=6408130840566072891",
                            IsOpen = false,
                            Name = "Moose Coffee",
                            PhoneNumber = 1612287994,
                            Rating = 4.5,
                            Summary = "Elegant, traditional diner serving hearty American-style breakfasts, brunches and coffee."
                        },
                        new
                        {
                            Id = 8,
                            Address = "Basement, 100 Barbirolli Square, Manchester M2 3BD, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=991045946514577218",
                            IsOpen = false,
                            Name = "Society",
                            PhoneNumber = 0,
                            Rating = 4.5,
                            Summary = "Chill destination featuring stands doling out global street foods, plus craft beer & cocktails."
                        },
                        new
                        {
                            Id = 9,
                            Address = "2A St Mary's St, Manchester M3 2LB, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=1253734206550260659",
                            IsOpen = false,
                            Name = "Gaucho Manchester",
                            PhoneNumber = 2079253900,
                            Rating = 4.5,
                            Summary = "Designer furnishings & cowhide fabrics create a lavish backdrop for Argentine food & wine."
                        },
                        new
                        {
                            Id = 10,
                            Address = "30 Portland St, Manchester M1 4GS, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=10486315685157041285",
                            IsOpen = false,
                            Name = "Rudy's Pizza Napoletana - Portland Street",
                            PhoneNumber = 1615322922,
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 11,
                            Address = "4 Lloyd St, Manchester M2 5AB, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=13638348935372707988",
                            IsOpen = false,
                            Name = "Gusto Italian",
                            PhoneNumber = 1616411120,
                            Rating = 4.4000000000000004,
                            Summary = "Polished Sicilian restaurant serving char-grilled dishes, stone-baked pizzas & seafood."
                        },
                        new
                        {
                            Id = 12,
                            Address = "60 Spring Gardens, Manchester M2 2BQ, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=4984268512638993458",
                            IsOpen = false,
                            Name = "Six by Nico Spring Gardens",
                            PhoneNumber = 1618321815,
                            Rating = 4.5999999999999996
                        },
                        new
                        {
                            Id = 13,
                            Address = "18-19 The Avenue, Manchester M3 3HF, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=8092230557133234279",
                            IsOpen = false,
                            Name = "Comptoir Libanais",
                            PhoneNumber = 1616723999,
                            Rating = 4.2999999999999998
                        },
                        new
                        {
                            Id = 14,
                            Address = "52a Faulkner St, Manchester M1 4FH, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=9678613109120993862",
                            IsOpen = false,
                            Name = "Pho Cue",
                            PhoneNumber = 1612375664,
                            Rating = 4.5999999999999996,
                            Summary = "Straightforward restaurant specialising in Vietnamese cuisine, including soups & sandwiches."
                        },
                        new
                        {
                            Id = 15,
                            Address = "unit 1, 58 W Mosley St, Manchester M2 3HZ, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=604196843788206545",
                            IsOpen = false,
                            Name = "American Pies Mcr",
                            PhoneNumber = 1616376776,
                            Rating = 4.5,
                            Summary = "Restaurant with a laid-back vibe serving American-style pizzas, calzones & dessert pies."
                        },
                        new
                        {
                            Id = 16,
                            Address = "2 St Peter's Sq, Manchester M2 3LQ, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=16250524245534901885",
                            IsOpen = false,
                            Name = "wagamama manchester st peters square",
                            PhoneNumber = 1613024630,
                            Rating = 4.2999999999999998,
                            Summary = "Casual restaurant serving Asian dishes in a Japanese-inspired setting with long communal benches."
                        },
                        new
                        {
                            Id = 17,
                            Address = "11 York St, Manchester M2 2AW, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=10526132420135364650",
                            IsOpen = false,
                            Name = "Maki & Ramen",
                            PhoneNumber = 1614707019,
                            Rating = 4.7000000000000002
                        },
                        new
                        {
                            Id = 18,
                            Address = "The Avenue Spinningfields, Manchester M3 3HF, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=8641579490415565491",
                            IsOpen = false,
                            Name = "Thaikhun",
                            PhoneNumber = 1614140264,
                            Rating = 4.4000000000000004,
                            Summary = "Lively, ephemera-packed Thai joint with street-market furniture and an open kitchen, plus a tuk-tuk."
                        },
                        new
                        {
                            Id = 19,
                            Address = "36 Bridge St, Manchester M3 3BT, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=4741104865423632753",
                            IsOpen = false,
                            Name = "Honest Burgers Manchester",
                            PhoneNumber = 1616763890,
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 20,
                            Address = "Barton Arcade, Manchester M3 2BW, UK",
                            GoogleMapsUri = "https://maps.google.com/?cid=5724952766288945264",
                            IsOpen = false,
                            Name = "POT KETTLE BLACK Barton Arcade",
                            PhoneNumber = 0,
                            Rating = 4.5,
                            Summary = "Airy cafe with reclaimed floorboards, in Victorian arcade, for gourmet coffee, tea and snacks."
                        });
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GameRestaurant", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantsId")
                        .HasColumnType("int");

                    b.HasKey("GamesId", "RestaurantsId");

                    b.HasIndex("RestaurantsId");

                    b.ToTable("GameRestaurant");
                });

            modelBuilder.Entity("GameUser", b =>
                {
                    b.Property<int>("GamesId")
                        .HasColumnType("int");

                    b.Property<int>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("GamesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("GameUser");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Friendship", b =>
                {
                    b.HasOne("DinnerMatcherNew.Models.User", "FirstUser")
                        .WithMany("FirstUserFriendships")
                        .HasForeignKey("FirstUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Friendships_Users_FirstUser");

                    b.HasOne("DinnerMatcherNew.Models.User", "SecondUser")
                        .WithMany("SecondUserFriendships")
                        .HasForeignKey("SecondUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("FK_Friendships_Users_SecondUser");

                    b.HasOne("DinnerMatcherNew.Models.User", null)
                        .WithMany("Friends")
                        .HasForeignKey("UserId");

                    b.Navigation("FirstUser");

                    b.Navigation("SecondUser");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Game_User", b =>
                {
                    b.HasOne("DinnerMatcherNew.Models.Game", "Game")
                        .WithMany("GameUsers")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DinnerMatcherNew.Models.User", "User")
                        .WithMany("GameUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Matches", b =>
                {
                    b.HasOne("DinnerMatcherNew.Models.Game", "Game")
                        .WithMany("Matches")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DinnerMatcherNew.Models.Restaurant", "Restaurant")
                        .WithMany("Matches")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DinnerMatcherNew.Models.User", null)
                        .WithMany("Matches")
                        .HasForeignKey("UserId");

                    b.Navigation("Game");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("GameRestaurant", b =>
                {
                    b.HasOne("DinnerMatcherNew.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DinnerMatcherNew.Models.Restaurant", null)
                        .WithMany()
                        .HasForeignKey("RestaurantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GameUser", b =>
                {
                    b.HasOne("DinnerMatcherNew.Models.Game", null)
                        .WithMany()
                        .HasForeignKey("GamesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DinnerMatcherNew.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Game", b =>
                {
                    b.Navigation("GameUsers");

                    b.Navigation("Matches");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.Restaurant", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("DinnerMatcherNew.Models.User", b =>
                {
                    b.Navigation("FirstUserFriendships");

                    b.Navigation("Friends");

                    b.Navigation("GameUsers");

                    b.Navigation("Matches");

                    b.Navigation("SecondUserFriendships");
                });
#pragma warning restore 612, 618
        }
    }
}
