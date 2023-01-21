using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNow.Models
{
    public class WeatherModel
    {
        public decimal Temperature { get; set; }
        public decimal Windspeed { get; set; }
        public decimal Winddirection { get; set; }
        public decimal Weathercode { get; set; }
        public string Time { get; set; }
    }
}
