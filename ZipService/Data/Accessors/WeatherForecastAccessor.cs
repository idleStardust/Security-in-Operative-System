using System;
using Data.Contracts;
using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Accessors
{
    public class WeatherForecastAccessor : IWeatherForecastAccessor
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public WeatherForecastAccessor()
        {
        }
        public async Task<IList<WeatherForecast>> GetAll()
        {
            var rng = new Random();
            List<WeatherForecast> result = new List<WeatherForecast>{
                new WeatherForecast
                {
                    ID = Guid.NewGuid(),
                    Date = DateTime.Now,
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                }
            };

            return await Task.FromResult<IList<WeatherForecast>>(result);
        }

        public Task Post(WeatherForecast model)
        {
            throw new NotImplementedException();
        }

        public Task Put(WeatherForecast model)
        {
            throw new NotImplementedException();
        }

        public Task<WeatherForecast> Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
