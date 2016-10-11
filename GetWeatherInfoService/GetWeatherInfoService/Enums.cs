using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeatherInfoService
{
    public class Enums
    {
        public enum StationType
        {
            /// <summary>
            /// Stations 
            /// </summary>
            NOWebInformation,
            /// <summary>
            /// Stations of INIA
            /// </summary>
            INIA,
            /// <summary>
            /// Stations using WeatherLink
            /// </summary>
            WeatherLink,
        }
    }
}
