using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;

namespace CoffeeCheck.Infrastructure.MappingProfiles
{
    public class FoodRatingMapping : Profile
    {
        public FoodRatingMapping()
        {
            CreateMap<FoodRatingEntity, FoodRatingModel>().ReverseMap();
        }
    }
}
