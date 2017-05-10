using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.ViewModels.Wizard
{
    public class WizardBombViewModel
    {

        public WizardBombViewModel()
        {
            
        }
         
        [Required]
        public String Name { get; set; }

        public String SerialNumber { get; set; }
       
        public DateTime ServiceDate { get; set; }

        public DateTime PurchaseDate { get; set; }
 
        [Required]
        public String Latitude { get; set; }   
     
        [Required]
        public String Longitude { get; set; }
        
        [Required]
        public int Farm_FarmId { get; set; }        

    }

}