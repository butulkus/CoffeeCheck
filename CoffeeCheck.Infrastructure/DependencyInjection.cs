using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CoffeeCheck.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddDatabaseWithCfg(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CoffeeCheckContext>(options =>
                options.UseNpgsql(
                    configuration.GetConnectionString("IdentityConnection"),
                    b => b.MigrationsAssembly("CoffeeCheck.Infrastructure")));
        }
    }
}
