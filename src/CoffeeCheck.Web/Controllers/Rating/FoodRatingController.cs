using AutoMapper;
using CoffeeCheck.Application.CQRS.Commands.Rating;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers.Rating
{
    public class FoodRatingController : CoffeeCheckController
    {
        public FoodRatingController(IMediator mediator, IMapper mapper) : base(mediator, mapper){}

        [HttpPatch("Update")]
        public async Task<IActionResult> UpdateRating(Guid restaurantId, double foodRating) /*TODO RequestModel*/
        {
            var query = new UpdateFoodRatingQuery { RestaurantId = restaurantId, NewFoodRating = foodRating };

            var result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
