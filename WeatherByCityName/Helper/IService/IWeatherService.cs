using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherNow.Models;

namespace WeatherNow.Helper.IService
{
    public interface IWeatherService
    {
        public Task<LocationModel> GetWeatherDetailsAsync(string latitude,string longitude);
    }
}
