using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;
using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Rating
{
    public class FoodRatingRepository : Repository<FoodRatingEntity>, IFoodRatingRepository
    {
        public FoodRatingRepository(CoffeeCheckContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<FoodRatingEntity?> FindByIdAsync(Guid foodRatingId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Id.Equals(foodRatingId));

            return entity;
        }

        public async Task<FoodRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Restaurant.Id.Equals(restaurantId));

            return entity;
        }

        public FoodRatingModel? ChangeRating(FoodRatingEntity foodRatingEntity)
        {
            DbSet.Attach(foodRatingEntity);
            DbSet.Entry(foodRatingEntity).Property("FoodRating").IsModified = true;
            DbSet.Entry(foodRatingEntity).Property("FoodVotesQuantity").IsModified = true;

            var result = Mapper.Map<FoodRatingModel>(foodRatingEntity);

            return result;
        }
    }
}
