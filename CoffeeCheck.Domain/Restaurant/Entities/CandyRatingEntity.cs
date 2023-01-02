namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class CandyRatingEntity
    {
        public int Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double CandyRating { get; set; }
        public int CandyVotesQuantity { get; set; }
        public string ClientChoice { get; set; }
        public string Restaurant_Choice { get; set; }

        public RestaurantEntity Restaurant { get; set; }
    }
}
