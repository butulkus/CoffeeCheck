using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Infrastructure.MappingProfiles
{
    public class OverallRatingMapping : Profile
    {
        public OverallRatingMapping()
        {
            CreateMap<OverallRatingEntity, OverallRatingModel>().ReverseMap();
        }
    }
}
