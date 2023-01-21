using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherNow.Models;

namespace WeatherNow.Helper.IService
{
    public interface ICityService
    {
        public List<CityModel> FindAllCity();
        public CityModel FindCityByName(string name,List<CityModel> cities);
    }
}
