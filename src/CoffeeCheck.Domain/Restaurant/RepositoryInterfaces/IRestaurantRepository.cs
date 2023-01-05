using CoffeeCheck.Domain.Restaurant.Entities;

namespace CoffeeCheck.Domain.Restaurant.RepositoryInterfaces
{
    public interface IRestaurantRepository
    {
        Task<RestaurantEntity?> FindByIdAsync(Guid restaurantId);
        Task<List<RestaurantEntity>?> FindAllByCityAsync(string cityName);
    }
}
