namespace CoffeeCheck.Domain.Restaurant.Models
{
    public class FoodRatingModel
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double FoodRating { get; set; }
        public int FoodVotesQuantity { get; set; }
        public string ClientChoice { get; set; }
        public string Restaurant_Choice { get; set; }

        public RestaurantModel Restaurant { get; set; }
    }
}
