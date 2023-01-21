using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherNow.Helper;
using WeatherNow.Models;

namespace WeatherByCityName
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(Environment.NewLine+"       ###################################  Welcome to WeatherNow!  ##################################");

            var cityService = new CityService();
            var cityDatabase = cityService.FindAllCity();
            bool validCitySelected = false;
            var citySelected = new CityModel();
            do
            {
                Console.WriteLine("Please select your city : ");
                var city = Console.ReadLine();
                citySelected = cityService.FindCityByName(city, cityDatabase);
                if (citySelected != null)
                {
                    Console.WriteLine("Oh you have chosen a valid city .Let me fetch weather details for you!");
                    validCitySelected = true;
                }
                else
                {
                    Console.WriteLine("OOPS! You have not chosen a valid City! ");
                }
            } while (!validCitySelected);

            var weatherService = new WeatherService();
            var weatherDetails =await weatherService.GetWeatherDetailsAsync(citySelected.Lat, citySelected.Lng);

            if (weatherDetails == null)
            {
                Console.WriteLine("Sorry, We do not have any weather details for your city!");
            }
            else
            {
                var printData = String.Format("Temperature : {0} ,Wind Speed : {1} ,Wind Direction : {2} ,Time : {3}", weatherDetails.Current_weather.Temperature, weatherDetails.Current_weather.Windspeed, weatherDetails.Current_weather.Winddirection, weatherDetails.Current_weather.Time);
                
                Console.WriteLine(printData);
            }
            
        }
    }
}
