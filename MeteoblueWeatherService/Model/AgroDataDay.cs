using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoblueWeatherService.Model
{
    public class AgroDataDay
    {
        public List<string> time { get; set; }
        public List<decimal?> soiltemperature_0to10cm_max { get; set; }
        public List<decimal?> soiltemperature_0to10cm_min { get; set; }
        public List<decimal?> soiltemperature_0to10cm_mean { get; set; }
        public List<int?> soilmoisture_0to10cm_max { get; set; }
        public List<int?> soilmoisture_0to10cm_min { get; set; }
        public List<int?> soilmoisture_0to10cm_mean { get; set; }
        public List<decimal?> skintemperature_max { get; set; }
        public List<decimal?> skintemperature_min { get; set; }
        public List<decimal?> skintemperature_mean { get; set; }
        public List<decimal?> evapotranspiration { get; set; }
        public List<decimal?> leafwetnessindex { get; set; }
        public List<decimal?> potentialevapotranspiration { get; set; }
        public List<decimal?> dewpointtemperature_max { get; set; }
        public List<decimal?> dewpointtemperature_min { get; set; }
        public List<decimal?> dewpointtemperature_mean { get; set; }
        public List<decimal?> referenceevapotranspiration_fao { get; set; }
        public List<decimal?> sensibleheatflux { get; set; }
    }
}
