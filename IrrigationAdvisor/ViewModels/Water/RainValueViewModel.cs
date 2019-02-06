using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class RainValueViewModel
    {
        public long IrrigationUnitId { get; set; }
        public double Milimeters { get; set; }
        public DateTime Date { get; set; }
    }
}