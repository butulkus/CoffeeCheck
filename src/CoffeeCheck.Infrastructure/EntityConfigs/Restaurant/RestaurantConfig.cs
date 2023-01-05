using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class RestaurantConfig : IEntityTypeConfiguration<RestaurantEntity>
    {
        public void Configure(EntityTypeBuilder<RestaurantEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.Property(x => x.YandexLatitude).HasColumnType("numeric(38,17)");
            builder.Property(x => x.YandexLongitude).HasColumnType("numeric(38,17)");

            builder.HasOne(x => x.City)
                .WithMany(x => x.Restaurants)
                .HasForeignKey(x => x.CityId);
            builder.HasMany(x => x.RestaurantPicture)
                .WithOne(x => x.Restaurant)
                .HasForeignKey(x => x.RestaurantId);
            builder.HasOne(x => x.OverallRating)
                .WithOne(x => x.Restaurant)
                .HasForeignKey<OverallRatingEntity>(x => x.RestaurantId);
            builder.HasOne(x => x.CoffeeRating)
                .WithOne(x => x.Restaurant)
                .HasForeignKey<CoffeeRatingEntity>(x => x.RestaurantId);
            builder.HasOne(x => x.FoodRating)
                .WithOne(x => x.Restaurant)
                .HasForeignKey<FoodRatingEntity>(x => x.RestaurantId);
            builder.HasOne(x => x.CandyRating)
                .WithOne(x => x.Restaurant)
                .HasForeignKey<CandyRatingEntity>(x => x.RestaurantId);
        }
    }
}
