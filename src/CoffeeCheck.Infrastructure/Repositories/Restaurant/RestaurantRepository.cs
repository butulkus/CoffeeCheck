using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Restaurant
{
    public class RestaurantRepository : Repository<RestaurantEntity>, IRestaurantRepository
    {
        public RestaurantRepository(
            CoffeeCheckContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<RestaurantEntity?> FindByIdAsync(Guid restaurantId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.City)
                .Include(x => x.RestaurantPicture)
                .Include(x => x.OverallRating)
                .Include(x => x.CoffeeRating)
                .Include(x => x.FoodRating)
                .Include(x => x.CandyRating)
                .Include(x => x.MainPicture)
                .FirstOrDefaultAsync(x => x.Id.Equals(restaurantId));

            return entity;
        }

        public async Task<List<RestaurantEntity>?> FindAllByCityAsync(string cityName)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.MainPicture)
                .Include(x => x.OverallRating)
                .Include(x => x.CoffeeRating)
                .Include(x => x.FoodRating)
                .Include(x => x.CandyRating)
                .Where(x => x.City.CityName.Equals(cityName))
                .ToListAsync();

            return entity;
        }
    }
}
