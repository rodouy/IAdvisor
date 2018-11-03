using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.WebApi.Models
{
    public class IrrigationEntryViewModel
    {
        public long IrrigationUnitId { get; set; }
        public double Milimeters { get; set; }
        public DateTime Date { get; set; }
    }
}