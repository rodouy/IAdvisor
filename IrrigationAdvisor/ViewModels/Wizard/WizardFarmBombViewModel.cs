using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.ViewModels.Wizard
{
    public class WizardFarmBombViewModel
    {

        public WizardFarmViewModel WizardFarmViewModel { get; set; }
        public WizardBombViewModel WizardBombViewModel { get; set; }
        
        
        public WizardFarmBombViewModel()
        {
            this.WizardFarmViewModel = new WizardFarmViewModel();
            this.WizardBombViewModel = new WizardBombViewModel();
         }

        
         
   

    }

}