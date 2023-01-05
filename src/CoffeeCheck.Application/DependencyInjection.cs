using CoffeeCheck.Domain.Restaurant.Base;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeCheck.Application
{
    public static class DependencyInjection
    {
        public static void AddApplicationWithCfg(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUnitOfWork, UoW>();
        }
    }
}
