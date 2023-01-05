namespace CoffeeCheck.Domain.Restaurant.Models
{
    public class CoffeeRatingModel
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double CoffeeRating { get; set; }
        public int CoffeeVotesQuantity { get; set; }
        public string ClientChoice { get; set; }
        public string Restaurant_Choice { get; set; }

        public RestaurantModel Restaurant { get; set; }
    }
}
