using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.ViewModels.Security;
using IrrigationAdvisor.ViewModels.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Localization
{
    public class FarmViewModel
    {

        #region Consts
        #endregion

        #region Fields

        private Farm farm;
        private String name;
        private String company;
        private String phone;
        private int has;
        private WeatherStationViewModel weatherStationViewModel;
        private List<BombViewModel> bombViewModelList;
        private List<IrrigationUnitViewModel> irrigationUnitViewModelList;
        private UserViewModel userViewModel;

        #endregion

        #region Properties

        private Farm Farm {get;set;}

        public String Name
        {
            get { return Farm.Name; }
        }
        #endregion

        #region Construction
        public FarmViewModel(Farm pFarm)
        {
            this.Farm = pFarm;
            this.name = pFarm.Name;
            this.has = pFarm.Has;
            this.irrigationUnitViewModelList = this.getIrrigationUnitViewModelListBy(pFarm);

        }
        #endregion

        #region Private Helpers


        private List<IrrigationUnitViewModel> getIrrigationUnitViewModelListBy(Farm pFarm)
        {
            List<IrrigationUnitViewModel> lReturn;

            lReturn = new List<IrrigationUnitViewModel>();
            //TODO: finalize getIrrigationUnitViewModelListBy
            return lReturn;
        }

        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

    }
}