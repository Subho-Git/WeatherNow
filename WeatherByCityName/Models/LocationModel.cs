using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNow.Models
{
    public class LocationModel
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public float Generationtime_ms { get; set; }
        public decimal Utc_offset_seconds { get; set; }
        public string Timezone { get; set; }
        public string Timezone_abbreviation { get; set; }
        public decimal Elevation { get; set; }
        public WeatherModel Current_weather { get; set; }
    }
}
