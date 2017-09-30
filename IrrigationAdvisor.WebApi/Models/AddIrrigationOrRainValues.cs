using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.WebApi.Models
{
    public class AddIrrigationOrRainValues
    {
        public string Token { get; set; }
        public int IrrigationUnitId { get; set; }
        public double Milimeters { get; set; }
        public DateTime Date { get; set; }
    }
}