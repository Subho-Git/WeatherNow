using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherNow.Models
{
    public class CityModel
    {
        public string City { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Country { get; set; }
        public string Iso2 { get; set; }
        public string Admin_name { get; set; }
        public string Capital { get; set; }
        public string Population { get; set; }
        public string Population_proper { get; set; }
    }
}
