using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Domain.Restaurant.RepositoryInterfaces
{
    public interface ICandyRatingRepository
    {
        Task<CandyRatingEntity?> FindByIdAsync(Guid coffeeRatingId);

        Task<CandyRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId);

        CandyRatingModel? ChangeRating(CandyRatingEntity candyRatingEntity);
    }
}
