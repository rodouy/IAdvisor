using System;

namespace IrrigationAdvisor.WebApi.Models
{
    public class AdviceViewModel
    {
        public string IrrigationType { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
