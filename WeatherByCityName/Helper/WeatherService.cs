using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherNow.Helper.IService;
using WeatherNow.Models;

namespace WeatherNow.Helper
{
    public class WeatherService : IWeatherService
    {
        public async Task<LocationModel> GetWeatherDetailsAsync(string latitude, string longitude)
        {
            if (latitude!=null && longitude != null)
            {
                var httpClient = new HttpClient()
                {
                    BaseAddress = new Uri("https://api.open-meteo.com/")
                };
                var response = await httpClient.GetAsync(@"/v1/forecast?latitude=" + latitude + "&longitude=" + longitude + "&current_weather=true");
                var result = JsonSerializer.Deserialize<LocationModel>(response.Content.ReadAsStringAsync().Result, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return result;
            }
            return new LocationModel();
        }
    }
}
