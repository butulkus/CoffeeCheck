using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Infrastructure.MappingProfiles
{
    public class CandyRatingMapping : Profile
    {
        public CandyRatingMapping()
        {
            CreateMap<CandyRatingEntity, CandyRatingModel>().ReverseMap();
        }
    }
}
