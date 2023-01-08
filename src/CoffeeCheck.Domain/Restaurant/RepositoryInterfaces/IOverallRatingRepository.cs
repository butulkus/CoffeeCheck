using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Domain.Restaurant.RepositoryInterfaces
{
    public interface IOverallRatingRepository
    {
        Task<OverallRatingEntity?> FindByIdAsync(Guid overallRatingId);
        Task<OverallRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId);
        OverallRatingModel? ChangeRating(OverallRatingEntity overallRatingEntity);
        Task<OverallRatingModel?> AddRatingAsync(OverallRatingEntity overallRatingEntity);
    }
}
