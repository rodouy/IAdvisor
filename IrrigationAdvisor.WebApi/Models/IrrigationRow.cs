using System;
using System.Collections.Generic;

namespace IrrigationAdvisor.WebApi.Models
{
    public class IrrigationRow
    {
        public IrrigationRow()
        {
            Advices = new List<AdviceViewModel>();
        }

        public long IrrigationUnitId { get; set; }
        public string Name { get; set; }
        public string Crop { get; set; }
        public DateTime HarvestDate { get; set; }
        public string Phenology { get; set; }
        public double Kc { get; set; }
        public double HydricBalance { get; set; }
        public List<AdviceViewModel> Advices { get; set; }
    }
}