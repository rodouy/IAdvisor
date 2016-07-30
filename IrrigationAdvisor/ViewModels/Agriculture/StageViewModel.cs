using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class StageViewModel
    {

        public long StageId { get; set; }
        public String Name { get; set; }
        public String ShortName { get; set; }
        public String Description { get; set; }
        public int order { get; set; }
        
    }
}