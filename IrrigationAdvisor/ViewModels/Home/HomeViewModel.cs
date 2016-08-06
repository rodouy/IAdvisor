using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.ViewModels.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.ViewModels.Management;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.ViewModels.Water;

namespace IrrigationAdvisor.ViewModels.Home
{
    public class HomeViewModel
    {

        #region Consts
        #endregion

        #region Fields
        
        #endregion

        #region Properties

        public List<FarmViewModel> FarmViewModelList { get; set; }

        public FarmViewModel DefaultFarmViewModel { get; set; }

        public List<IrrigationUnitViewModel> IrrigationUnitViewModelList {get; set; }

        public List<RainViewModel> RainViewModelList { get; set; }

        public List<IrrigationViewModel> IrrigationViewModelList { get; set; }

        public IrrigationUnitViewModel TestIrrigationUnitViewModel { get; set; }

        public CropIrrigationWeatherViewModel CropIrrigationWeatherViewModel { get; set; }

        public List<DailyRecordViewModel> DailyRecordViewModelList { get; set; }

        public ErrorViewModel ErrorViewModel { get; set; }

        public bool IsUserAdministrator { get; set; }
        public DateTime DateOfReference { get; set; }

        #endregion

        #region Construction

        public HomeViewModel(ErrorViewModel pErrorVM)
        {
            ErrorViewModel = pErrorVM;
        }

        public HomeViewModel(User pUser, List<FarmViewModel> pFarmList,
                            DateTime pDateOfReference)
        {
            FarmViewModelList = pFarmList;
            DateOfReference = pDateOfReference;

            if(FarmViewModelList != null && FarmViewModelList.Count() > 0)
            {
                DefaultFarmViewModel = FarmViewModelList.FirstOrDefault();

                IrrigationUnitViewModelList = DefaultFarmViewModel.IrrigationUnitViewModelList;
            }

        }


        public HomeViewModel(User pUser, List<FarmViewModel> pFarmList,
                            DateTime pDateOfReference,
                            FarmViewModel pFirstFarm,
                            CropIrrigationWeather pCropIrrigationWeather,
                            List<DailyRecordViewModel> pDailyRecordList,
                            List<RainViewModel> pRainList,
                            List<IrrigationViewModel> pIrrigationList)
        {
            FarmViewModelList = pFarmList;
            DateOfReference = pDateOfReference;
            DefaultFarmViewModel = pFirstFarm;
            
            IrrigationUnitViewModelList = DefaultFarmViewModel.IrrigationUnitViewModelList;
            
            TestIrrigationUnitViewModel = IrrigationUnitViewModelList.FirstOrDefault();
            CropIrrigationWeatherViewModel = new CropIrrigationWeatherViewModel(pCropIrrigationWeather);

            RainViewModelList = pRainList;
            IrrigationViewModelList = pIrrigationList;

            DailyRecordViewModelList = pDailyRecordList;
            
        }
        #endregion

        #region Private Helpers

        public string DateOfRefernceAsLocal()
        {
            //YYYY-MM-DD
            string lResult = null;

            string lMonth = null;
            string lDay = null;

            if(DateOfReference.Month < 10)
            {
                lMonth = "0" + DateOfReference.Month.ToString();
            }
            else
            {
                lMonth = DateOfReference.Month.ToString();
            }

            if(DateOfReference.Day < 10)
            {
                lDay = "0" + DateOfReference.Day.ToString();
            }
            else
            {
                lDay = DateOfReference.Day.ToString();
            }

            lResult = string.Format("{0}-{1}-{2}",
                                    DateOfReference.Year,
                                    lMonth,
                                    lDay);

            return lResult;
        }

        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion


    }
}