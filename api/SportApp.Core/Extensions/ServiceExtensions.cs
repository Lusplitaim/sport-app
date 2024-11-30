using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SportApp.Core.Services;

namespace SportApp.Core.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IExerciseService, ExerciseService>();

            return services;
        }
    }
}
