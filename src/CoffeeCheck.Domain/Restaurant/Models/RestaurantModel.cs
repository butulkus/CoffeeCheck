namespace CoffeeCheck.Domain.Restaurant.Models
{
    public class RestaurantModel
    {
        public Guid Id { get; set; }
        public int CityId { get; set; }
        public string RestaurantName { get; set; }
        public double YandexLatitude { get; set; }
        public double YandexLongitude { get; set; }
    }
}
