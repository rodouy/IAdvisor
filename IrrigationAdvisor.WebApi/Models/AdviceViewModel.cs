using System;

namespace IrrigationAdvisor.WebApi.Models
{
    public class AdviceViewModel
    {
        public string IrrigationType { get; set; }
        public double Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
