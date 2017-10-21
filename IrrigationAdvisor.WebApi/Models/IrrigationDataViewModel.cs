using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.WebApi.Models
{
    public class IrrigationDataViewModel
    {
        public IrrigationDataViewModel()
        {
            IrrigationRows = new List<IrrigationRow>();
        }
        public DateTime ReferenceDate { get; set; }
        public FarmViewModel Farm { get; set; }
        public List<IrrigationRow> IrrigationRows { get; set; }
    }
}