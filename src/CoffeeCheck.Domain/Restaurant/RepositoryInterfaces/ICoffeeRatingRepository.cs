using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Domain.Restaurant.RepositoryInterfaces
{
    public interface ICoffeeRatingRepository
    {
        Task<CoffeeRatingEntity?> FindByIdAsync(Guid coffeeRatingId);

        Task<CoffeeRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId);

        CoffeeRatingModel? ChangeRating(CoffeeRatingEntity coffeeRatingEntity);
    }
}
