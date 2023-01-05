using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class FoodRatingConfig : IEntityTypeConfiguration<FoodRatingEntity>
    {
        public void Configure(EntityTypeBuilder<FoodRatingEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.Property(x => x.FoodRating).HasColumnType("numeric(4,2)");
        }
    }
}
