using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class RestaurantPictureConfig : IEntityTypeConfiguration<RestaurantPictureEntity>
    {
        public void Configure(EntityTypeBuilder<RestaurantPictureEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.HasOne(x => x.Restaurant)
                .WithMany(x => x.RestaurantPicture)
                .HasForeignKey(x => x.RestaurantId);
        }
    }
}
