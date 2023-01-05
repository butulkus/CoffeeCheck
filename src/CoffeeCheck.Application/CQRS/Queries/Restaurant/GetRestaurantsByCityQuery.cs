using CoffeeCheck.Domain.Restaurant.Entities;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Queries.Restaurant
{
    public class GetRestaurantsByCityQuery : IRequest<List<RestaurantEntity>>
    {
        public string CityName { get; init; }
    }
}
