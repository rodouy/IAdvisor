using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.WebApi.Models
{
    public class IrrigationEntyListViewModel
    {
        public string Token { get; set; }
        public List<IrrigationEntryViewModel> IrrigationEntries { get; set; }
        public List<IrrigationEntryViewModel> RainEntries { get; set; }
    }
}