using AutoMapper;
using CoffeeCheck.Application.CQRS.Commands.Rating;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers.Rating
{
    public class OverallRatingController : CoffeeCheckController
    {
        public OverallRatingController(IMediator mediator,
            IMapper mapper) : base(mediator, mapper)
        {
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> UpdateRating(Guid restaurantId)
        {
            var query = new UpdateOverallRatingQuery { RestaurantId = restaurantId };

            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
