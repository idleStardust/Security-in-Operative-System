using Managers.Contracts;
using Data.Contracts;
using Managers.Models;
using Managers.Extensions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace Managers.Implementation
{
    public class WeatherForecastManager : IWeatherForecastManager
    {
        private readonly IWeatherForecastAccessor _accessor;

        public WeatherForecastManager(IWeatherForecastAccessor weatherForecastAccessor) 
        { 
            _accessor = weatherForecastAccessor;
        }

        public async Task<IEnumerable<WeatherForecast>> GetAll()
        {
            var list = await _accessor.GetAll();
            return list.Select(t => new WeatherForecast().LoadFrom(t));
        }
    }
}
