using CoffeeCheck.Domain.Restaurant.Entities;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Queries.Restaurant
{
    public class GetRestaurantByIdQuery : IRequest<RestaurantEntity> 
    {
        public Guid RestaurantId { get; init; }
    }
}
