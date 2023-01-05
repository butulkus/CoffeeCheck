using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Application.Helpers;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.Models;
using Microsoft.Extensions.Logging;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateCoffeeRatingHandler : BaseCommandHandler<UpdateCoffeeRatingQuery, CoffeeRatingModel>
    {
        public UpdateCoffeeRatingHandler(
            ILogger<BaseCommandHandler<UpdateCoffeeRatingQuery,
                CoffeeRatingModel>> logger, IUnitOfWork uoW) : base(logger, uoW)
        {
        }

        protected override async Task<CoffeeRatingModel> ExecuteAsync(UpdateCoffeeRatingQuery request, CancellationToken cancellationToken)
        {
            var oldEntity = await UoW.Coffee.FindByRestaurantIdAsync(request.RestaurantId);

            if (oldEntity is null)
            {
                throw new ArgumentNullException($"No restaurant haven't been found in {request.RestaurantId}");
            }

            int newVotesQuantity = oldEntity.CoffeeVotesQuantity + 1;
            double newRating = RatingCalculator.CalculateRating(
                oldEntity.CoffeeRating,
                request.NewCoffeeRating,
                newVotesQuantity);

            oldEntity.CoffeeRating = newRating;
            oldEntity.CoffeeVotesQuantity = newVotesQuantity;

            var entityModel = UoW.Coffee.ChangeRating(oldEntity);

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
