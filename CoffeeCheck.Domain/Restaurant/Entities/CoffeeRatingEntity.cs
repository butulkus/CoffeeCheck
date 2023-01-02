namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class CoffeeRatingEntity
    {
        public int Id { get; set; }
        public Guid RestaurantId { get; set; }
        public double CoffeeRating { get; set; }
        public int CoffeeVotesQuantity { get; set; }
        public string ClientChoice { get; set; }
        public string Restaurant_Choice { get; set; }

        public RestaurantEntity Restaurant { get; set; }
    }
}
