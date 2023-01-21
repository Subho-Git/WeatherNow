using NUnit.Framework;
using WeatherNow.Helper;
using WeatherNow.Helper.IService;
using WeatherNow.Models;

namespace TestProjectWeatherNow
{
    [TestFixture]
    public class Tests
    {
        private ICityService _cityService;
        private IWeatherService _weatherService;
        [SetUp]
        public void Setup()
        {
            _cityService = new CityService();
            _weatherService = new WeatherService();
        }

        [Test]
        public void FindAllCitiesTest()
        {
            var cities = _cityService.FindAllCity();
            Assert.IsNotNull(cities);
        }

        [Test]
        public void FindCitybyNameTest()
        {
            var city = _cityService.FindCityByName("Kolkata",_cityService.FindAllCity());
            
            Assert.AreEqual(city.Lat, "22.5411");
            Assert.AreEqual(city.Lng, "88.3378");
        }

        [Test]
        public void GetWeatherDetailsTest()
        {
            var weatherKolkata = _weatherService.GetWeatherDetailsAsync("22.5411", "88.3378");
            Assert.IsNotNull(weatherKolkata);
        }

    }
}