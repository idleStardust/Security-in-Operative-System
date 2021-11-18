using System.Diagnostics.CodeAnalysis;
using Managers.Contracts;
using Managers.Implementation;
using Microsoft.Extensions.DependencyInjection;


namespace Managers
{
    [ExcludeFromCodeCoverage]
    public static class Startup
    {
        public static void RegisterManagers(this IServiceCollection services)
        {
            services.AddScoped<IWeatherForecastManager, WeatherForecastManager>();
            services.AddScoped<IZipManager, ZipManager>();
        }
    }
}
