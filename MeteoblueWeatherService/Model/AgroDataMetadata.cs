using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoblueWeatherService.Model
{
    public class AgroDataMetadata
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int height { get; set; }
        public string timezone_abbrevation { get; set; }
        public double utc_timeoffset { get; set; }
        public string modelrun_utc { get; set; }
        public string modelrun_updatetime_utc { get; set; }
    }
}
