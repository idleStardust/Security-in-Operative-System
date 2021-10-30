using Data.Contracts;
using NUnit.Framework;
using System.Threading.Tasks;
using Data.Models;
using Data.Accessors;

namespace Test.Data.Accessors
{
    class WeatherForecastAccessorTest : AccessorTest<IWeatherForecastAccessor, WeatherForecast>
    {
        [SetUp]
        public new void SetUp()
        {
            base.SetUp();
            this.accessor = new WeatherForecastAccessor(context);
        }

        [Test]
        public new async Task GetAllTest()
        => await base.GetAllTest();

        [Test]
        public void GetTest()
        {
            int id = 0;
            base.GetTest(id);
        }

        [Test]
        public void PutTest()
        {
            WeatherForecast id = null;
            base.PutTest(id);
        }

        [Test]
        public void PostTest()
        {
            WeatherForecast id = null;
            base.PostTest(id);
        }
    }
}