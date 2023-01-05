using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CoffeeCheck.Infrastructure
{
    public class CoffeeCheckContext : DbContext
    {
        public CoffeeCheckContext(DbContextOptions<CoffeeCheckContext> options) : base(options)
        {
        }

        public DbSet<CandyRatingEntity> CandyRating { get; set; }
        public DbSet<CityEntity> City { get; set; }
        public DbSet<CoffeeRatingEntity> CoffeeRating { get; set; }
        public DbSet<FoodRatingEntity> FoodRating { get; set; }
        public DbSet<MainPictureEntity> MainPicture { get; set; }
        public DbSet<OverallRatingEntity> OverallRating { get; set; }
        public DbSet<RestaurantEntity> Restaurant { get; set; }
        public DbSet<RestaurantPictureEntity> RestaurantPicture { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
