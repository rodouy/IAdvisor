using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.ViewModels.Wizard
{
    public class WizardFarmViewModel
    {
        [Required]
        public String Name { get; set; }

        [Required]
        public String Company { get; set; }

        public String Address { get; set; }

        [Required]
        public String Phone { get; set; }

        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Ingrese latitud válida")]
        public double Latitude { get; set; }

        [Required]
        [Range(double.MinValue, double.MaxValue, ErrorMessage = "Ingrese longitud válida")]
        public double Longitude { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Ingrese cantidad de hectareas válidas")]
        public int Has { get; set; }

        [Required]
        public long CityId { get; set; }

        [Required]
        public long WeatherStationId { get; set; }

        public List<System.Web.Mvc.SelectListItem> City { get; set; }

        
        public List<System.Web.Mvc.SelectListItem> WeatherStation { get; set; }
     
        public string BombsHidden { get; set; }

        public WizardFarmViewModel()
        {
            this.WeatherStation = new List<System.Web.Mvc.SelectListItem>();
            this.City = new List<System.Web.Mvc.SelectListItem>();
            
        }
      

    }

}