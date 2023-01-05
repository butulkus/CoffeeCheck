using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers
{
    [ApiController]
    [Route("[controller]/")]
    public abstract class CoffeeCheckController : ControllerBase
    {
        protected readonly IMediator Mediator;
        protected readonly IMapper Mapper;

        public CoffeeCheckController(IMediator mediator, IMapper mapper)
        {
            Mediator = mediator;
            Mapper = mapper;
        }
    }
}
