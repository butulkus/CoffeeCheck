using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.Entities;

namespace CoffeeCheck.Application.CQRS.Queries.Restaurant
{
    public class GetRestaurantByIdHandler : BaseRequestHandler<GetRestaurantByIdQuery, RestaurantEntity>
    {
        public GetRestaurantByIdHandler(IUnitOfWork unitOfWork) : base(unitOfWork) {}

        protected override async Task<RestaurantEntity> ExecuteAsync(GetRestaurantByIdQuery request,
            CancellationToken cancellationToken)
        {
            var entity = await UoW.Restaurant.FindByIdAsync(request.RestaurantId);

            if (entity is null)
            {
                throw new ArgumentNullException($"No restaurant have been found with id: {request.RestaurantId}");
            }

            return entity;
        }
    }
}
