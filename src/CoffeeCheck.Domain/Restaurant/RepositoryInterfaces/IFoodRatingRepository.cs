using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Domain.Restaurant.RepositoryInterfaces
{
    public interface IFoodRatingRepository
    {
        FoodRatingModel? ChangeRating(FoodRatingEntity foodRatingEntity);
        Task<FoodRatingEntity?> FindByRestaurantIdAsync(Guid restaurantId);
        Task<FoodRatingEntity?> FindByIdAsync(Guid foodRatingId);
    }
}
