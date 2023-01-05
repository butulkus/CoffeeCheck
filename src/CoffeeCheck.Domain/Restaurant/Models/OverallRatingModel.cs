using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Domain.Restaurant.Models
{
    public class OverallRatingModel
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double OverallRating { get; set; }

        public RestaurantModel Restaurant { get; set; }
    }
}
