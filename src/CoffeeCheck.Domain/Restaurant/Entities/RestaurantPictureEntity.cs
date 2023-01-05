namespace CoffeeCheck.Domain.Restaurant.Entities
{
    public class RestaurantPictureEntity
    {
        public Guid Id { get; set; }
        public byte[] Picture { get; set; }
        public string Format { get; set; }
        public Guid RestaurantId { get; set; }

        public RestaurantEntity Restaurant { get; set; } 
    }
}
