using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCInia
{
    public class IniaDTO
    {
        public DateTime Date { get; set; }
        public double ET { get; set; }
        public double SolarRadiation { get; set; }
        public double RainDay { get; set; }
        public double AvgTemperature { get; set; }
        public double MaxTemperature { get; set; }
        public double MinTemperature { get; set; }
        public double AvgHumidity { get; set; }
        public double MaxHumidity { get; set; }
        public double MinHumidity { get; set; }
        public double WindSpeed { get; set; }
    }
}
