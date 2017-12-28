using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.ViewModels.Management
{
    public class CropIrrigationWeatherShortViewModel
    {


        public long CropIrrigationWeatherId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public String CropIrrigationWeatherName { get; set; }

   
        public long MainWeatherStationId { get; set; }

        [Required]
        [Display(Name = "Estación meteorolígica principal")]
        public List<System.Web.Mvc.SelectListItem> MainWeatherStation { get; set; }


        public long AlternativeWeatherStationId { get; set; }
        [Required]
        [Display(Name = "Estación meteorolígica alternativa")]
        public List<System.Web.Mvc.SelectListItem> AlternativeWeatherStation { get; set; }

        public CropIrrigationWeatherShortViewModel()
        {
            this.MainWeatherStation = new List<System.Web.Mvc.SelectListItem>();
            this.AlternativeWeatherStation = new List<System.Web.Mvc.SelectListItem>();
        }
    }
}