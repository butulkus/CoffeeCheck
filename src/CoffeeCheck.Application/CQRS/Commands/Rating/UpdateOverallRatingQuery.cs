using CoffeeCheck.Domain.Restaurant.Models;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateOverallRatingQuery : IRequest<OverallRatingModel>
    {
    }
}
