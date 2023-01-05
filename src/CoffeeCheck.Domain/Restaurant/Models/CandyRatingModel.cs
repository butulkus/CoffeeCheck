namespace CoffeeCheck.Domain.Restaurant.Models
{
    public class CandyRatingModel
    {
        public Guid Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double CandyRating { get; set; }
        public int CandyVotesQuantity { get; set; }
        public string ClientChoice { get; set; }
        public string Restaurant_Choice { get; set; }

        public RestaurantModel Restaurant { get; set; }
    }
}
