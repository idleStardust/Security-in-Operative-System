using System.Threading.Tasks;
using Managers.Models;
using System.Collections.Generic;
using Managers.Implementation;

namespace Managers.Contracts
{
    public interface IWeatherForecastManager : IManager
    {
        Task<IList<WeatherForecast>> GetAll();
    }
}
