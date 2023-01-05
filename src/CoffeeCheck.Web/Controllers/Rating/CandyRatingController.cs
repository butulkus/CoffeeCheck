using AutoMapper;
using CoffeeCheck.Application.CQRS.Commands.Rating;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers.Rating
{
    public class CandyRatingController : CoffeeCheckController
    {
        public CandyRatingController(IMediator mediator,
            IMapper mapper) : base(mediator, mapper)
        {
        }

        [HttpPatch("Update")]
        public async Task<IActionResult> UpdateRating(Guid restaurantId, double candyRating) /*TODO RequestModel*/
        {
            var query = new UpdateCandyRatingQuery { RestaurantId = restaurantId, NewCandyRating = candyRating };

            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
