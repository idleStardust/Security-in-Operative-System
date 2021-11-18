using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public class WeatherForecast : IModel<WeatherForecast>
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int TemperatureC { get; set; }
        [Required]
        public string Summary { get; set; }

        public WeatherForecast Empty => new WeatherForecast{
            ID = Guid.Empty,
            Date = DateTime.Now,
            TemperatureC = 0,
            Summary = "Summ"
        };
    }
}
