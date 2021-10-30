using System.Threading.Tasks;
using Managers.Models;
using System.Collections.Generic;
using Managers.Implementation;
using Data.Contracts;

namespace Managers.Contracts
{
    public interface IWeatherForecastManager : IManager
    {
        Task<IEnumerable<WeatherForecast>> GetAll();
    }
}
