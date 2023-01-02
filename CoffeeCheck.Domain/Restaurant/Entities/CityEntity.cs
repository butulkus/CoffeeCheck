using CoffeeCheck.Domain.Restaurant.Entities;

namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class CityEntity
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        
        public IList<RestaurantEntity> Restaurants { get; set; }
    }
}
