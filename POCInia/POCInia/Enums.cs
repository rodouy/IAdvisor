using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCInia
{
    public class Enums
    {
        public enum WeatherStations
        {
            LasBrujas = 1,
            LaEstanzuela = 2,
            SaltoGrande = 3,
            Tacuarembo = 4
        }

        /// <summary>
        /// Type of input of WeatherData
        /// CodeInsert, GetWeatherInfoService, WebInsert, Prediction
        /// </summary>
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
