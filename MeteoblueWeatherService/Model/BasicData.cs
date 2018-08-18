using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoblueWeatherService.Model
{
    public class BasicData
    {
        public BasicDataMetadata metadata { get; set; }
        public BasicDataUnits units { get; set; }
        public BasicDataDay data_day { get; set; }
    }
}
