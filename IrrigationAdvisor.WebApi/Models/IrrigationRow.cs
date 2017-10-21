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

        public string Name { get; set; }
        public string Crop { get; set; }
        public DateTime HarvestDate { get; set; }
        public string Phenology { get; set; }
        public decimal Kc { get; set; }
        public decimal HydricBalance { get; set; }
        public List<AdviceViewModel> Advices { get; set; }
    }
}