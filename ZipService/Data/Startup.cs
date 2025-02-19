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
            services.AddScoped<IZipAccessor, ZipAccessor>();
        }
    }
}
