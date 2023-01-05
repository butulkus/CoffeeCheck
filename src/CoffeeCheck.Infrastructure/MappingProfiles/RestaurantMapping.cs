using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Infrastructure.MappingProfiles
{
    public class RestaurantMapping : Profile
    {
        public RestaurantMapping()
        {
            CreateMap<RestaurantEntity, RestaurantModel>().ReverseMap();
        }
    }
}
