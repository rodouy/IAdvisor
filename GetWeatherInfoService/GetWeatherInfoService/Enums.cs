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

        public enum WeatherDataInputType
        {
            /// <summary>
            /// Input from code (Program)
            /// </summary>
            CodeInsert,

            /// <summary>
            /// Input from Win Service
            /// </summary>
            GetWeatherInfoService,

            /// <summary>
            /// Input manually from web
            /// </summary>
            WebInsert,

            /// <summary>
            /// Input for Calculate
            /// </summary>
            Prediction,

            /// <summary>
            /// Input for IniaWeather Service
            /// </summary>
            IniaWeatherService
        }
    }
}
