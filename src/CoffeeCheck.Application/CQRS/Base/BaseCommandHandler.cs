using CoffeeCheck.Domain.Restaurant.Base;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CoffeeCheck.Application.CQRS.Base
{
    public abstract class BaseCommandHandler<TRequest, TResponse>
        : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        protected readonly ILogger Logger;
        protected readonly IUnitOfWork UoW;

        public BaseCommandHandler(ILogger<BaseCommandHandler<TRequest, TResponse>> logger, IUnitOfWork uoW)
        {
            Logger = logger;
            UoW = uoW;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
        {
            return await ExecuteAsync(request, cancellationToken);
        }

        protected abstract Task<TResponse> ExecuteAsync(TRequest request, CancellationToken cancellationToken);
    }
}
