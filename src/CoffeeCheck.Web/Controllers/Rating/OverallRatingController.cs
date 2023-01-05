using AutoMapper;
using MediatR;

namespace CoffeeCheck.Web.Controllers.Rating
{
    public class OverallRatingController : CoffeeCheckController
    {
        public OverallRatingController(IMediator mediator,
            IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}
