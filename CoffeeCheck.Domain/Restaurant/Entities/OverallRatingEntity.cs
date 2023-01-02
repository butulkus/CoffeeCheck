namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class OverallRatingEntity
    {
        public int Id { get; set; }
        public Guid RestaurantId { get; set; }

        public RestaurantEntity Restaurant { get; set; }
    }
}
