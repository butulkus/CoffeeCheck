using CoffeeCheck.Domain.Restaurant.Models;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateFoodRatingQuery : IRequest<FoodRatingModel>
    {
        public Guid RestaurantId { get; init; }
        public double NewFoodRating { get; init; }
        public Guid UserId { get; init; }
    }
}
