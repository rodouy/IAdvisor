using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoblueWeatherService.Model
{
    public class AgroData
    {
        public AgroDataMetadata metadata { get; set; }
        public AgroDataUnits units { get; set; }
        public AgroDataDay data_day { get; set; }
    }
}
