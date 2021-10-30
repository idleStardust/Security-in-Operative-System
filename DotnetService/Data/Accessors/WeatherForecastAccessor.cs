using System;
using Data.Contracts;
using Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Accessors
{
    public class WeatherForecastAccessor : IWeatherForecastAccessor
    {
        private readonly ApplicationDbContext _context;
        public WeatherForecastAccessor(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<IEnumerable<WeatherForecast>> GetAll()
        {
            var result = await _context.WeatherForecasts.ToListAsync();
            return result;
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
