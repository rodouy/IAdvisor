using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.ViewModels.Wizard
{
    public class WizardFarmViewModel
    {

         public WizardFarmViewModel()
        {
            //this.WeatherStation = new List<System.Web.Mvc.SelectListItem>();
            //this.City = new List<System.Web.Mvc.SelectListItem>();
         }


         
        [Required]
        public String Name { get; set; }

        [Required]
        public String Company { get; set; }

        public String Address { get; set; }

        public String Phone { get; set; }
 
        [Required]
        public String Latitude { get; set; }   
     
        [Required]
        public String Longitude { get; set; }
        
        [Required]
        public int Has { get; set; }        

        [Required]
        public List<System.Web.Mvc.SelectListItem> WeatherStation { get; set; }
        
     //   [Required]
       // public List<System.Web.Mvc.SelectListItem> Bo { get; set; }
    }

}