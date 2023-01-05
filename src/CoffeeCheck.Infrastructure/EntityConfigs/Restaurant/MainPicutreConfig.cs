using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class MainPicutreConfig : IEntityTypeConfiguration<MainPictureEntity>
    {
        public void Configure(EntityTypeBuilder<MainPictureEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasDefaultValueSql("gen_random_uuid()");
            builder.HasOne(x => x.Restaurant)
                .WithOne(x => x.MainPicture)
                .HasForeignKey<MainPictureEntity>(x => x.RestaurantId);
        }
    }
}
