using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoffeeCheck.Infrastructure.EntityConfigs.Restaurant
{
    public class CityConfig : IEntityTypeConfiguration<CityEntity>
    {
        public void Configure(EntityTypeBuilder<CityEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
