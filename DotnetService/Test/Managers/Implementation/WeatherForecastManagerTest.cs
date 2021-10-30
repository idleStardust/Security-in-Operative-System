using Data.Contracts;
using Managers.Implementation;
using NUnit.Framework;
using System.Threading.Tasks;
using DataModels = Data.Models;
using Managers.Models;
using System.Linq;

namespace Test.Managers.Implementation
{
    class WeatherForecastManagerTest : ManagerTest<IWeatherForecastAccessor, DataModels.WeatherForecast, WeatherForecastManager>
    {
        [SetUp]
        public new void SetUp()
        {
            base.SetUp();
            this.manager = new WeatherForecastManager(this.accessor.Object);
        }

        [Test]
        public async Task GetAllTest()
        {
            var value = (await this.manager.GetAll()).First();
            
            Assert.NotNull(value.TemperatureF);
            Assert.IsInstanceOf<WeatherForecast>(value);
        }
    }
}