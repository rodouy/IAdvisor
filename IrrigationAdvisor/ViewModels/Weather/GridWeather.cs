using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Weather
{

    public class GridWeather
    {
        public String high { get; set; }

        public String low { get; set; }

        public String weekday { get; set; }

        public String month { get; set; }

        public String urlImage { get; set; }

        public String Description { get; set; }

        public String ProbabilityRain { get; set; }

        public String mmRain { get; set; }

        public GridWeather(String pHigh, String pLow, String pWeekday,
                        String pMonth, String pUrlImage, String pDescription,
                        String pRobabilityRain, String pmmRain)
        {
            this.high = pHigh;
            this.low = pLow;
            this.weekday = pWeekday;
            this.month = pMonth;
            this.urlImage = pUrlImage;
            this.Description = pDescription;
            this.ProbabilityRain = pRobabilityRain;
            this.mmRain = pmmRain;
        }

    }

}