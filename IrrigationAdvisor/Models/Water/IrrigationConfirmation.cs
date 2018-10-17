using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Water
{
    public class IrrigationConfirmation
    {
        public long IrrigationConfirmationId { get; set; }
        public DateTime Date { get; set; }
        public long IrrigationId { get; set; }
        public virtual Irrigation Irrigation { get; set; }
    }
}