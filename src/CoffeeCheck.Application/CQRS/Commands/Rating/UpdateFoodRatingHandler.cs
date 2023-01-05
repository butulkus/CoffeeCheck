using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Application.Helpers;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.Entities;
using CoffeeCheck.Domain.Restaurant.Models;
using Microsoft.Extensions.Logging;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateFoodRatingHandler : BaseCommandHandler<UpdateFoodRatingQuery, FoodRatingModel>
    {
        public UpdateFoodRatingHandler(IUnitOfWork uoW,
            ILogger<BaseCommandHandler<UpdateFoodRatingQuery, FoodRatingModel>> logger) : base(logger, uoW) { }

        protected override async Task<FoodRatingModel> ExecuteAsync(UpdateFoodRatingQuery request,
            CancellationToken cancellationToken)
        {
            var oldEntity = await UoW.Food.FindByRestaurantIdAsync(request.RestaurantId);

            if (oldEntity is null)
            {
                throw new ArgumentNullException($"No restaurant haven't been found in {request.RestaurantId}");
            }

            //TODO подумать как сделать чтобы каждый запрос с бд получал последние данные
            int newVotesQuantity = oldEntity.FoodVotesQuantity + 1;
            double newRating = RatingCalculator.CalculateRating(
                oldEntity.FoodRating,
                request.NewFoodRating,
                newVotesQuantity);

            oldEntity.FoodRating = newRating;
            oldEntity.FoodVotesQuantity = newVotesQuantity;

            //TODO можно сделать апдейт 1м запрсом с помощью только даппера
            var entityModel = UoW.Food.ChangeRating(oldEntity);

            try
            {
                await UoW.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Logger.LogError(ex, "DB was not updated");
                throw;
            }

            return entityModel;
        }
    }
}
