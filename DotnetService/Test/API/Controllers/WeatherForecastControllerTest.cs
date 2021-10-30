using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Controllers;
using Data.Contracts;
using Managers.Contracts;
using Managers.Models;
using Moq;
using NUnit.Framework;
using DataModels = Data.Models;

namespace Test.API.Controllers
{
    public class WeatherForecastControllerTest : ControllerTest<
    WeatherForecastController, 
    WeatherForecast, 
    IWeatherForecastManager,
    DataModels.WeatherForecast, 
    IWeatherForecastAccessor>
    {
        [SetUp]
        public new void SetUp()
        {
            base.SetUp();

            List<WeatherForecast> value = new List<WeatherForecast>();
            value.Add(new WeatherForecast().Empty);

            this.manager.Setup(_ => _.GetAll()).ReturnsAsync(value);

            this.controller = new WeatherForecastController(this.manager.Object);
        }
        [Test]
        public async Task GetAllTest()
        {
            var value = await this.controller.GetAll();
            Assert.IsInstanceOf<IEnumerable<WeatherForecast>>(value);
        }
    }
}