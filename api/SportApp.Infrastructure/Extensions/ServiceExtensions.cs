using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportApp.Core.Data;
using SportApp.Infrastructure.Data;

namespace SportApp.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseContext(configuration);
            services.AddUnitOfWork();

            return services;
        }

        private static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        private static IServiceCollection AddDatabaseContext(this IServiceCollection services, IConfiguration configuration)
        {
            return services.AddDbContextPool<DatabaseContext>(opts =>
            {
                opts.UseNpgsql(configuration["DatabaseConnections:PostgreSQL"]);
            });
        }
    }
}
