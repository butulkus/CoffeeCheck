using CoffeeCheck.Domain.Restaurant.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Restaurant
{
    public class RestaurantRepository : Repository<RestaurantEntity>
    {
        public RestaurantRepository(
            DbSet<RestaurantEntity> dbSet,
            CoffeeCheckContext context) : base(dbSet, context)
        {
        }


    }
}
