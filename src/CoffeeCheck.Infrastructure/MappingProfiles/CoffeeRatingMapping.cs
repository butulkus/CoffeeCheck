using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Infrastructure.MappingProfiles
{
    public class CoffeeRatingMapping : Profile
    {
        public CoffeeRatingMapping()
        {
            CreateMap<CoffeeRatingEntity, CoffeeRatingModel>().ReverseMap();
        }
    }
}
