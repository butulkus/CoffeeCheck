using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Domain.Restaurant.Base;
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

        protected override Task<OverallRatingModel> ExecuteAsync(UpdateOverallRatingQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
