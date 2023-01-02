using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class OverallRatingConfig : IEntityTypeConfiguration<OverallRatingEntity>
    {
        public void Configure(EntityTypeBuilder<OverallRatingEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
