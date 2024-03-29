using DinnerMatcherNew.Models;
using Microsoft.EntityFrameworkCore;

namespace DinnerMatcherNew.DataContext
{
    public class DinnerContext: DbContext
    {
        public DinnerContext(DbContextOptions<DinnerContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        
        
    }
}