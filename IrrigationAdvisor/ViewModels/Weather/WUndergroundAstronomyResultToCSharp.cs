using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Weather
{
    public class WUndergroundAstronomyResultToCSharp
    {

        public class Features
        {
            public int astronomy { get; set; }
        }

        public class Response
        {
            public string version { get; set; }
            public string termsofService { get; set; }
            public Features features { get; set; }
        }

        public class CurrentTime
        {
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class Sunrise
        {
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class Sunset
        {
            public string hour { get; set; }
            public string minute { get; set; }
        }

        public class MoonPhase
        {
            public string percentIlluminated { get; set; }
            public string ageOfMoon { get; set; }
            public CurrentTime current_time { get; set; }
            public Sunrise sunrise { get; set; }
            public Sunset sunset { get; set; }
        }

        public class RootObject
        {
            [JsonProperty(PropertyName = "response")]
            public Response response { get; set; }
            [JsonProperty(PropertyName = "moon_phase")]
            public MoonPhase moon_phase { get; set; }
        }

    }
}