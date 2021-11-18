using Managers.Models;

namespace Managers.Extensions
{
    public static class WeatherForecastEx
    {
        public static WeatherForecast LoadFrom(this WeatherForecast dest, Data.Models.WeatherForecast src)
        {
            dest.ID = src.ID;
            dest.Date = src.Date;
            dest.TemperatureC = src.TemperatureC;
            dest.Summary = src.Summary;

            return dest;
        }
    }
}
