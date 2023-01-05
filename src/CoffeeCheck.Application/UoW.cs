using AutoMapper;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.RepositoryInterfaces;
using CoffeeCheck.Infrastructure;
using CoffeeCheck.Infrastructure.Repositories.Rating;
using CoffeeCheck.Infrastructure.Repositories.Restaurant;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoffeeCheck.Application
{
    public class UoW : IUnitOfWork
    {
        private readonly CoffeeCheckContext _context;
        private readonly IConfiguration _configuration;
        private IRestaurantRepository _restaurant;
        private IFoodRatingRepository _food;
        private ICoffeeRatingRepository _coffee;
        private ICandyRatingRepository _candy;
        private IMapper _mapper;

        public UoW(
            CoffeeCheckContext context,
            IConfiguration configuration,
            IMapper mapper)
        {
            _context = context;
            _configuration = configuration;
            _mapper = mapper;
        }

        public IRestaurantRepository Restaurant
        {
            get
            {
                if (_restaurant is null)
                {
                    _restaurant = new RestaurantRepository(_context, _mapper);
                }

                return _restaurant;
            }
        }

        public IFoodRatingRepository Food
        {
            get
            {
                if (_food is null)
                {
                    _food = new FoodRatingRepository(_context, _mapper);
                }

                return _food;
            }
        }

        public ICoffeeRatingRepository Coffee
        {
            get
            {
                if (_coffee is null)
                {
                    _coffee = new CoffeeRatingRepository(_context, _mapper);
                }

                return _coffee;
            }
        }

        public ICandyRatingRepository Candy
        {
            get
            {
                if (_candy is null)
                {
                    _candy = new CandyRatingRepository(_context, _mapper);
                }

                return _candy;
            }
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
