using System;
using System.Diagnostics.CodeAnalysis;
using Data.Accessors;
using Data.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Data
{
    [ExcludeFromCodeCoverage]
    public static class Startup
    {
        public static void RegisterData(this IServiceCollection services)
        {

            //var connection = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");

            //services.AddDbContext<ApplicationDbContext>(
                //options => options.UseSqlServer(connection));
                
            services.AddScoped<IWeatherForecastAccessor, WeatherForecastAccessor>();
        }
    }
}
