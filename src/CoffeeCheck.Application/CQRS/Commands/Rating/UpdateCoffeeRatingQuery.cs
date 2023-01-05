using CoffeeCheck.Domain.Restaurant.Models;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateCoffeeRatingQuery : IRequest<CoffeeRatingModel>
    {
        public Guid RestaurantId { get; init; }
        public double NewCoffeeRating { get; init; }
        public Guid UserId { get; init; }
    }
}
