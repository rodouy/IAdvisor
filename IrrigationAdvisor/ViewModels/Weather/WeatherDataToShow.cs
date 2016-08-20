using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Weather
{

    public class WeatherDataItem
    {

        public String high { get; set; }

        public String low { get; set; }

        public String month { get; set; }

        public String weekday { get; set; }

        public String urlImage { get; set; }

        public String description { get; set; }

        public String probabilityofrain { get; set; }

        public String mmRain { get; set; }

        public WeatherDataItem(String pTempHigh, String pTempLow,
                        String pMonth, String pWeekday, 
                        String pURLimage, String pDesription, 
                        String pProbabilityOfRain, String pMMRain)
        {
            this.high = pTempHigh;
            this.low = pTempLow;
            this.month = pMonth;
            this.weekday = pWeekday;
            this.urlImage = pURLimage;
            this.description = pDesription;
            this.probabilityofrain = pProbabilityOfRain;
            this.mmRain = pMMRain;

        }

    }

    public class WeatherDataToShow
    {

        public String city { get; set; }

        public String urlImage { get; set; }

        public String conditions { get; set; }

        public String averageTemperature { get; set; }

        public String day { get; set; }

        public String sunriseTime { get; set; }

        public String sunsetTime { get; set; }

        public String high { get; set; }

        public String low { get; set; }

        public String relativeHumidity { get; set; }

        public String averageWind { get; set; }

        public String pressure { get; set; }

        public String visibility { get; set; }

        public String dewPoint { get; set; }
             

        public List<WeatherDataItem> weatherDataItemList {get; set;}

        public WeatherDataToShow(String pCity, String pURLImage, String pConditions, 
                        String pAverageTemperature, String pDay, String pSunriseTime, 
                        String pSunsetTime, String pHigh, String pLow, 
                        String pRelativeHumidity, String pAverageWind, String pPressure, 
                        String pVisibility, String pDewPoint,
                        List<WeatherDataItem> pWeatherDataItemList)
        {
            this.city = pCity;
            this.urlImage = pURLImage;
            this.conditions = pConditions;
            this.averageTemperature = pAverageTemperature;
            this.day = pDay;
            this.sunriseTime = pSunriseTime;
            this.sunsetTime = pSunsetTime;
            this.high = pHigh;
            this.low = pLow;
            this.relativeHumidity = pRelativeHumidity;
            this.averageWind = pAverageWind;
            this.pressure = pPressure;
            this.visibility = pVisibility;
            this.dewPoint = pDewPoint;
            this.weatherDataItemList = pWeatherDataItemList;
        }

    }
}