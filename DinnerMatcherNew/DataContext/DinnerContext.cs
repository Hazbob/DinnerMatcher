using DinnerMatcherNew.Data;
using DinnerMatcherNew.Models;
using Microsoft.EntityFrameworkCore;

namespace DinnerMatcherNew.DataContext
{
    public class DinnerContext: DbContext
    {
        public DinnerContext(DbContextOptions<DinnerContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Friendship>()
                .HasKey(f => f.Id);
            
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.FirstUser)
                .WithMany(u => u.FirstUserFriendships)
                .HasForeignKey(f => f.FirstUserId)
                .HasConstraintName("FK_Friendships_Users_FirstUser")
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<Friendship>()
                .HasOne(f => f.SecondUser)
                .WithMany(u => u.SecondUserFriendships)
                .HasForeignKey(f => f.SecondUserId)
                .HasConstraintName("FK_Friendships_Users_SecondUser")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Game>()
                .HasMany<Restaurant>(g => g.Restaurants)
                .WithMany(r => r.Games);
            modelBuilder.Seed();
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        
        public DbSet<Game> Games { get; set; }

        public DbSet<Game_User> GameUsers { get; set; }
        public DbSet<Matches?> Matches { get; set; }


    }
}