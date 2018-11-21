using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.Models.Agriculture
{
    public class HydricBalanceAdjustment
    {
        public long HydricBalanceAdjustmentId { get; set; }
        public double Percentage { get; set; }
        public double HydricBalance { get; set; }
        public DateTime Date { get; set; }
        public long CropIrrigationWeatherId { get; set; }

        public virtual CropIrrigationWeather CropIrrigationWeather { get; set; }
    }
}