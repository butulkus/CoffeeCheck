namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class RestaurantEntity
    {
        public Guid Id { get; set; }
        public int CityId { get; set; }
        public string RestaurantName { get; set; }
        public double YandexLatitude { get; set; }
        public double YandexLongitude { get; set; }

        public CityEntity City { get; set; }
        public IList<RestaurantPictureEntity> RestaurantPicture { get; set; }
        public OverallRatingEntity OverallRating { get; set; }
        public CoffeeRatingEntity CoffeeRating { get; set; }
        public FoodRatingEntity FoodRating { get; set; }
        public CandyRatingEntity CandyRating { get; set; }
        public MainPictureEntity MainPicture { get; set; }
    }
}
