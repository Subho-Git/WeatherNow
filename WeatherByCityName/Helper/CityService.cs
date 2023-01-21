using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherNow.Helper.IService;
using WeatherNow.Models;

namespace WeatherNow.Helper
{
    public class CityService : ICityService
    {
        public List<CityModel> FindAllCity()
        {
            var cities = File.ReadAllText(@"./Files/Cities.json");
            var cityDatabase = JsonSerializer.Deserialize<List<CityModel>>(cities, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return cityDatabase == null ? new List<CityModel>() : cityDatabase;
            //return cityDatabase;
        }

        public CityModel FindCityByName(string name, List<CityModel> cities)
        {
            if(name!=null && cities != null)
            {
                return cities.Find(x => x.City.ToUpper() == name.ToUpper());
            }
            return new CityModel();
        }
    }
}
