using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.ViewModels.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Home
{
    public class HomeViewModel
    {

        #region Consts
        #endregion

        #region Fields
        
        #endregion

        #region Properties

        public List<FarmViewModel> FarmList { get; set; }

        public FarmViewModel DefaultFarm { get; set; }

        public List<IrrigationUnitViewModel> IrrigationUnitList {get; set; }


        public ErrorViewModel ErrorViewModel { get; set; }

        #endregion

        #region Construction

        public HomeViewModel(ErrorViewModel pErrorVM)
        {
            ErrorViewModel = pErrorVM;
        }

        public HomeViewModel(User pUser, List<FarmViewModel> pFarmList)
        {
            FarmList = pFarmList;
            if(FarmList != null && FarmList.Count() > 0)
            {
                DefaultFarm = FarmList.FirstOrDefault();

                IrrigationUnitList = DefaultFarm.IrrigationUnitViewModelList;
            }
            //TODO: when no farm is assigned to user
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion


    }
}