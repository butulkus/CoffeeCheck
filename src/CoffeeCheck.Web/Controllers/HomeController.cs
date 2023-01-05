using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeCheck.Web.Controllers
{
    public class HomeController : CoffeeCheckController
    {
        public HomeController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }
    }
}