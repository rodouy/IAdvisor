using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Errors
{
    public class ErrorViewModel
    {

        public int Code { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public List<CropIrrigationWeather> InactiveCropIrrigationWeatherList;


    }
}