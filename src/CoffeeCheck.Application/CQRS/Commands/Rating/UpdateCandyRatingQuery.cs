using CoffeeCheck.Domain.Restaurant.Models;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateCandyRatingQuery : IRequest<CandyRatingModel>
    {
        public Guid RestaurantId { get; init; }
        public double NewCandyRating { get; init; }
        public Guid UserId { get; init; }
    }
}
