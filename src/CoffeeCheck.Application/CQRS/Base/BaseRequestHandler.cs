using CoffeeCheck.Domain.Restaurant.Base;
using MediatR;

namespace CoffeeCheck.Application.CQRS.Base
{
    public abstract class BaseRequestHandler<TRequest, TResponse> 
        : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        protected readonly IUnitOfWork UoW;

        public BaseRequestHandler(IUnitOfWork uoW)
        {
            UoW = uoW;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request, cancellationToken);
        }

        protected abstract Task<TResponse> ExecuteAsync(TRequest request, CancellationToken cancellationToken);
    }
}
