using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;
using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace CoffeeCheck.Infrastructure.Repositories.Rating
{
    public class OverallRatingRepository : Repository<OverallRatingEntity>, IOverallRatingRepository
    {
        public OverallRatingRepository(CoffeeCheckContext context,
            IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<OverallRatingEntity?> FindByIdAsync(Guid overallRatingId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Id.Equals(overallRatingId));

            return entity;
        }

        public async Task<OverallRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId)
        {
            var entity = await DbSet.AsNoTracking()
                .Include(x => x.Restaurant)
                .FirstOrDefaultAsync(x => x.Restaurant.Id.Equals(restaurantId));

            return entity;
        }

        public OverallRatingModel? ChangeRating(OverallRatingEntity overallRatingEntity)
        {
            DbSet.Attach(overallRatingEntity);
            DbSet.Entry(overallRatingEntity).Property("OverallRating").IsModified = true;

            var result = Mapper.Map<OverallRatingModel>(overallRatingEntity);

            return result;
        }

        public async Task<OverallRatingModel?> AddRatingAsync(OverallRatingEntity overallRatingEntity)
        {
            var entity = await DbSet.AddAsync(overallRatingEntity);

            var result = Mapper.Map<OverallRatingModel>(entity.Entity);

            return result;
        }
    }
}
