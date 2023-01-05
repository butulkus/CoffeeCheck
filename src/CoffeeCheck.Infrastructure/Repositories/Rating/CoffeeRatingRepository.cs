using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;
using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Rating
{
    public class CoffeeRatingRepository : Repository<CoffeeRatingEntity>, ICoffeeRatingRepository
    {
        public CoffeeRatingRepository(CoffeeCheckContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<CoffeeRatingEntity?> FindByIdAsync(Guid coffeeRatingId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Id.Equals(coffeeRatingId));

            return entity;
        }

        public async Task<CoffeeRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Restaurant.Id.Equals(restaurantId));

            return entity;
        }

        public CoffeeRatingModel? ChangeRating(CoffeeRatingEntity coffeeRatingEntity)
        {
            DbSet.Attach(coffeeRatingEntity);
            DbSet.Entry(coffeeRatingEntity).Property("CoffeeRating").IsModified = true;
            DbSet.Entry(coffeeRatingEntity).Property("CoffeeVotesQuantity").IsModified = true;

            var result = Mapper.Map<CoffeeRatingModel>(coffeeRatingEntity);

            return result;
        }
    }
}
