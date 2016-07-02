using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Home
{
    public class IrrigationAdvisorViewModel
    {
        

        private Farm farm { get; set; }
        private long positionId { get; set; }

        public String FarmName 
        { 
            get { return farm.Name; } 
        }

        public List<IrrigationUnit> IrrigationUnitList 
        { 
            get { return farm.IrrigationUnitList;}
        }

        public int has
        {
            get { return farm.Has; }
        }


        public IrrigationAdvisorViewModel(Farm pFarm)
        {
            this.farm = pFarm;
            this.positionId = pFarm.PositionId;

        }

        


    }
}