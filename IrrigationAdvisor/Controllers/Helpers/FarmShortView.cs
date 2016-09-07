using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Controllers.Helpers
{
    public class FarmShortView
    {
        public string ErrorMessage { get; set; }
        public long FarmId { get; set; }
        public string FarmDescription { get; set; }
    }
}