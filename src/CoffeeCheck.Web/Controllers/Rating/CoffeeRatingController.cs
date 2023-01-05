using AutoMapper;
using CoffeeCheck.Application.CQRS.Commands.Rating;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers.Rating
{
    public class CoffeeRatingController : CoffeeCheckController
    {
        public CoffeeRatingController(IMediator mediator,
            IMapper mapper) : base(mediator, mapper)
        {
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> UpdateRating(Guid restaurantId, double coffeeRating) /*TODO RequestModel*/
        {
            var query = new UpdateCoffeeRatingQuery { RestaurantId = restaurantId, NewCoffeeRating = coffeeRating };

            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
