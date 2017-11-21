using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.ViewModels.Wizard
{
    public class WizardSoilHorizonViewModel
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String ShortName { get; set; }

        public String Description { get; set; }

        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Ingrese latitud válida")]
        public double Latitude { get; set; }

        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Ingrese longitud válida")]
        public double Longitude { get; set; }

        [Required]
        public DateTime TestDate { get; set; }

        [Required]
        public double DepthLimit { get; set; }


        [Required]
        public long FarmId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Farm { get; set; }


        public string HorizonsHidden { get; set; }


        public WizardSoilHorizonViewModel()
        {
            this.Farm = new List<System.Web.Mvc.SelectListItem>();
        }
    }

}