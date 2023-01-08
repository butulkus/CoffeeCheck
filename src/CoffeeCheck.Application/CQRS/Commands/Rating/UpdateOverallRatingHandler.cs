using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Application.Helpers;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;
using Microsoft.Extensions.Logging;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateOverallRatingHandler : BaseCommandHandler<UpdateOverallRatingQuery, OverallRatingModel>
    {
        public UpdateOverallRatingHandler(
            ILogger<BaseCommandHandler<UpdateOverallRatingQuery, OverallRatingModel>> logger,
            IUnitOfWork uoW) : base(logger, uoW)
        {
        }

        protected override async Task<OverallRatingModel> ExecuteAsync(UpdateOverallRatingQuery request,
            CancellationToken cancellationToken)
        {
            var restaurant = await UoW.Restaurant.FindByIdAsync(request.RestaurantId);

            if (restaurant is null)
            {
                throw new ArgumentNullException($"No restaurant haven't been found in {request.RestaurantId}");
            }

            var candyRating = restaurant.CandyRating?.CandyRating;
            var coffeeRating = restaurant.CoffeeRating?.CoffeeRating;
            var foodRating = restaurant.FoodRating?.FoodRating;

            var overallCalculated = OverallRatingCalculator.CalculateRating(
                candyRating,
                coffeeRating,
                foodRating);

            if (overallCalculated is null)
            {
                throw new NullReferenceException("overall calculated value is null");
            }

            var newOverall = restaurant.OverallRating ?? new OverallRatingEntity()
            {
                Id = Guid.NewGuid(),
                RestaurantId = restaurant.Id,
                OverallRating = overallCalculated.Value,
            };

            OverallRatingModel? overallModel; 
            if (restaurant.OverallRating is null)
            {
                overallModel = await UoW.Overall.AddRatingAsync(newOverall);
            }
            else
            {
                overallModel = UoW.Overall.ChangeRating(newOverall);
            }

            try
            {
                //TODO падает на бонжур богеме -> System.OverflowException: Value was either too large or too small for a Decimal.
                await UoW.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "DB was not updated");
                throw;
            }

            return overallModel;
        }
    }
}
