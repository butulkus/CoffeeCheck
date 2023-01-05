using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;
using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Rating
{
    public class CandyRatingRepository : Repository<CandyRatingEntity>, ICandyRatingRepository
    {
        public CandyRatingRepository(CoffeeCheckContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<CandyRatingEntity?> FindByIdAsync(Guid coffeeRatingId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Id.Equals(coffeeRatingId));

            return entity;
        }

        public async Task<CandyRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Restaurant.Id.Equals(restaurantId));

            return entity;
        }

        public CandyRatingModel? ChangeRating(CandyRatingEntity candyRatingEntity)
        {
            DbSet.Attach(candyRatingEntity);
            DbSet.Entry(candyRatingEntity).Property("FoodRating").IsModified = true;
            DbSet.Entry(candyRatingEntity).Property("FoodVotesQuantity").IsModified = true;

            var result = Mapper.Map<CandyRatingModel>(candyRatingEntity);

            return result;
        }
    }
}
