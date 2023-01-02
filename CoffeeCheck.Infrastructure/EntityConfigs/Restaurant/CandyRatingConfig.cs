using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class CandyRatingConfig : IEntityTypeConfiguration<CandyRatingEntity>
    {
        public void Configure(EntityTypeBuilder<CandyRatingEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
