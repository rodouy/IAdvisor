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
        public List<double> soiltemperature_0to10cm_max { get; set; }
        public List<double> soiltemperature_0to10cm_min { get; set; }
        public List<double> soiltemperature_0to10cm_mean { get; set; }
        public List<int> soilmoisture_0to10cm_max { get; set; }
        public List<int> soilmoisture_0to10cm_min { get; set; }
        public List<int> soilmoisture_0to10cm_mean { get; set; }
        public List<double> skintemperature_max { get; set; }
        public List<double> skintemperature_min { get; set; }
        public List<double> skintemperature_mean { get; set; }
        public List<double> evapotranspiration { get; set; }
        public List<double> leafwetnessindex { get; set; }
        public List<double> potentialevapotranspiration { get; set; }
        public List<double> dewpointtemperature_max { get; set; }
        public List<double> dewpointtemperature_min { get; set; }
        public List<double> dewpointtemperature_mean { get; set; }
        public List<double> referenceevapotranspiration_fao { get; set; }
        public List<double> sensibleheatflux { get; set; }
    }
}
