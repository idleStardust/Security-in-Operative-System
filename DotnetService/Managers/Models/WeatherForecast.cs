using System;

namespace Managers.Models
{
    public class WeatherForecast : IModel<WeatherForecast>
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string Summary { get; set; }

        public WeatherForecast Empty => new WeatherForecast{
            Date = DateTime.Now,
            TemperatureC = 0,
            Summary = "Summ"
        };
    }
}
