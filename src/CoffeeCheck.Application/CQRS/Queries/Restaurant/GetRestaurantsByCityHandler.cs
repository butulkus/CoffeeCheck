using CoffeeCheck.Application.CQRS.Base;
using CoffeeCheck.Domain.Restaurant.Base;
using CoffeeCheck.Domain.Restaurant.Entities;

namespace CoffeeCheck.Application.CQRS.Queries.Restaurant
{
    public class GetRestaurantsByCityHandler : BaseRequestHandler<GetRestaurantsByCityQuery, List<RestaurantEntity>>
    {
        public GetRestaurantsByCityHandler(IUnitOfWork unitOfWork) : base(unitOfWork) {}

        protected override async Task<List<RestaurantEntity>> ExecuteAsync(GetRestaurantsByCityQuery request, CancellationToken cancellationToken)
        {
            var entity = await UoW.Restaurant.FindAllByCityAsync(request.CityName);

            if (entity is null)
            {
                //TODO кастомны ошибки будут круче
                throw new ArgumentNullException($"No restaurant have been found in {request.CityName}");
            }

            return entity;
        }
    }
}
