using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;

namespace CoffeeCheck.Domain.Restaurant.Base
{
    public interface IUnitOfWork
    {
        IRestaurantRepository Restaurant { get; }
        IFoodRatingRepository Food { get; }
        ICoffeeRatingRepository Coffee { get; }
        ICandyRatingRepository Candy { get; }
        Task<int> SaveChangesAsync();
    }
}
