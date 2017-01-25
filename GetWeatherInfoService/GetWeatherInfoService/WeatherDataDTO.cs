using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeatherInfoService
{
    public class WeatherDataDTO
    {
        public double Temperature
        {
            get
            {
                return (MaxTemperature + MinTemperature) / 2;
            }
            private set { }
        }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set;}
        string TemperatureExceptionMessage { get; set; }

        public double EvapotranspirationDay { get; set;}
        public double EvapotranspirationMonth { get; set;}
        public double EvapotranspirationYear { get; set;}

        public double MaxHumidity { get; set;}
        public double MinHumidity { get; set;}

        public double MinBarometer { get; set;}
        public double MaxBarometer { get; set;}

        public double MaxDewTemperature { get; set;}
        public double MinDewTemperature { get; set;}

        public double RainDay { get; set;}
        public double RainMonth { get; set;}
        public double RainYear { get; set;}
        public double RainStorm { get; set;}

        public double SolarRadiation { get; set;}

        public double UvRadiation { get; set;}
        public double WindSpeed { get; set; }
        public string Observations { get; set; }
    }
}
