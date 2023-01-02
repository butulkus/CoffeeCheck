using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class CoffeeRatingConfig : IEntityTypeConfiguration<CoffeeRatingEntity>
    {
        public void Configure(EntityTypeBuilder<CoffeeRatingEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
