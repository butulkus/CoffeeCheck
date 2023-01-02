namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class FoodRatingEntity
    {
        public int Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double FoodRating { get; set; }
        public int FoodVotesQuantity { get; set; }
        public string ClientChoice { get; set; }
        public string Restaurant_Choice { get; set; }

        public RestaurantEntity Restaurant { get; set; }
    }
}
