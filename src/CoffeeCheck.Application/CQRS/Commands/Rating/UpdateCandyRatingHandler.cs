using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Application.Helpers;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.Models;
using Microsoft.Extensions.Logging;

namespace CoffeeCheck.Application.CQRS.Commands.Rating
{
    public class UpdateCandyRatingHandler : BaseCommandHandler<UpdateCandyRatingQuery, CandyRatingModel>
    {
        public UpdateCandyRatingHandler(
            ILogger<BaseCommandHandler<UpdateCandyRatingQuery, CandyRatingModel>> logger,
            IUnitOfWork uoW) : base(logger, uoW){}

        protected override async Task<CandyRatingModel> ExecuteAsync(UpdateCandyRatingQuery request, CancellationToken cancellationToken)
        {
            var oldEntity = await UoW.Candy.FindByRestaurantIdAsync(request.RestaurantId);

            if (oldEntity is null)
            {
                throw new ArgumentNullException($"No restaurant haven't been found in {request.RestaurantId}");
            }

            int newVotesQuantity = oldEntity.CandyVotesQuantity + 1;
            double newRating = RatingCalculator.CalculateRating(
                oldEntity.CandyRating,
                request.NewCandyRating,
                newVotesQuantity);

            oldEntity.CandyRating = newRating;
            oldEntity.CandyVotesQuantity = newVotesQuantity;

            var entityModel = UoW.Candy.ChangeRating(oldEntity);

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
