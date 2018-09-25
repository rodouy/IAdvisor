using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class WebApiIrrigationRainViewModel
    {
        public List<IrrigationValueViewModel> Irrigations { get; set; }
        public List<IrrigationValueViewModel> Rains { get; set; }

        public WebApiIrrigationRainViewModel()
        {
            Irrigations = new List<IrrigationValueViewModel>();
            Rains = new List<IrrigationValueViewModel>();
        }     
    }
}