using AutoMapper;
using CoffeeCheck.Application.CQRS.Queries.Restaurant;
using CoffeeCheck.Domain.Restaurant.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers.Restaurant
{
    public class RestaurantController : CoffeeCheckController
    {
        public RestaurantController(
            IMediator mediator,
            IMapper mapper) : base(mediator, mapper)
        {
        }

        [HttpGet("{restaurantId}")]
        public async Task<IActionResult> GetById([FromRoute] Guid restaurantId)
        {
            var query = new GetRestaurantByIdQuery { RestaurantId = restaurantId };

            var result = await Mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("Restaurants/{cityName}")]
        public async Task<IActionResult> GetAllByCity([FromRoute] string cityName)
        {
            var query = new GetRestaurantsByCityQuery { CityName = cityName };
            
            //Exeption possibility
            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
