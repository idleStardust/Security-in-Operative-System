using Managers.Contracts;
using Managers.Models;
using Managers.Extensions;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Data.Contracts;

namespace Managers.Implementation
{
    public class WeatherForecastManager : IWeatherForecastManager
    {
        private readonly IWeatherForecastAccessor _accessor;

        public WeatherForecastManager(IWeatherForecastAccessor weatherForecastAccessor) 
        { 
            _accessor = weatherForecastAccessor;
        }

        public async Task<IList<WeatherForecast>> GetAll()
        {
            IList<Data.Models.WeatherForecast> list = await _accessor.GetAll();

            var result = list.Select(value => new WeatherForecast().LoadFrom(value)).ToList();

            return result;
        }
    }
}
