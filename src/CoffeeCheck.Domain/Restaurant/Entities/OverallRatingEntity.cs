namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class OverallRatingEntity
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double OverallRating { get; set; }

        public RestaurantEntity Restaurant { get; set; }
    }
}
