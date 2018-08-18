using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoblueWeatherService.Model
{
    public class AgroDataUnits
    {
        public string time { get; set; }
        public string leafwetness { get; set; }
        public string soilmoisture { get; set; }
        public string sensibleheatflux { get; set; }
        public string temperature { get; set; }
        public string transpiration { get; set; }
    }
}
