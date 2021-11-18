using System.Threading.Tasks;
using System.Collections.Generic;
using Managers.Models;
using Managers.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastManager _WeatherForecastManagers;
        public WeatherForecastController(IWeatherForecastManager weatherForecastManagers)
        {
            _WeatherForecastManagers = weatherForecastManagers;
        }

        [HttpGet]
        public async Task<IList<WeatherForecast>> GetAll() => await _WeatherForecastManagers.GetAll();
    }
}
