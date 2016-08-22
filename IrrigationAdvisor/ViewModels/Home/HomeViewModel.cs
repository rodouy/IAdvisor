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
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.Models.Utilities;

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

        public Double DefaultFarmLatitude { get; set; }

        public Double DefaultFarmLongitude { get; set; }

        public List<IrrigationUnitViewModel> IrrigationUnitViewModelList {get; set; }

        public List<RainViewModel> RainViewModelList { get; set; }

        public List<IrrigationViewModel> IrrigationViewModelList { get; set; }

        public IrrigationUnitViewModel TestIrrigationUnitViewModel { get; set; }

        public List<CropIrrigationWeatherViewModel> CropIrrigationWeatherViewModelList { get; set; }

        public List<DailyRecordViewModel> DailyRecordViewModelList { get; set; }

        public ErrorViewModel ErrorViewModel { get; set; }

        public bool IsUserAdministrator { get; set; }

        public DateTime DateOfReference { get; set; }

        public DateTime MinDateOfReference { get; set; }

        public DateTime MaxDateOfReference { get; set; }

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
                            Double pDefaultFarmLatitude, Double pDefaultFarmLongitude,
                            List<CropIrrigationWeather> pCropIrrigationWeatherList,
                            List<DailyRecordViewModel> pDailyRecordList,
                            List<RainViewModel> pRainList,
                            List<IrrigationViewModel> pIrrigationList,
                            DateTime pMinDateOfReference,
                            DateTime pMaxDateOfReference)
        {
            FarmViewModelList = pFarmList;
            DateOfReference = pDateOfReference;
            DefaultFarmViewModel = pFirstFarm;
            DefaultFarmLatitude = pDefaultFarmLatitude;
            DefaultFarmLongitude = pDefaultFarmLongitude;

            IrrigationUnitViewModelList = DefaultFarmViewModel.IrrigationUnitViewModelList;
            
            TestIrrigationUnitViewModel = IrrigationUnitViewModelList.FirstOrDefault();
            List<CropIrrigationWeatherViewModel> lCropIrrigationWeatherViewModel = new List<CropIrrigationWeatherViewModel>();
            lCropIrrigationWeatherViewModel.Add(new CropIrrigationWeatherViewModel(pCropIrrigationWeatherList.FirstOrDefault()));
            CropIrrigationWeatherViewModelList = lCropIrrigationWeatherViewModel;

            RainViewModelList = pRainList;
            IrrigationViewModelList = pIrrigationList;

            DailyRecordViewModelList = pDailyRecordList;
            
            MinDateOfReference = pMinDateOfReference;
            MaxDateOfReference = pMaxDateOfReference;
            
        }
        #endregion

        #region Private Helpers

        #endregion

        #region Public Methods

        /// <summary>
        /// Get Date of Reference
        /// </summary>
        /// <returns></returns>
        public String DateOfRefernceAsLocal()
        {
            return Utils.GetDateTimeForClientScripts(DateOfReference);
        }

        /// <summary>
        /// Get Min valid Date of Reference
        /// </summary>
        /// <returns></returns>
        public String MinDateOfRefernceAsLocal()
        {
            //YYYY-MM-DD
            String lResult = null;

            lResult = String.Format("{0}-{1}-{2}",
                                    MinDateOfReference.Year,
                                    MinDateOfReference.Month,
                                    MinDateOfReference.Day);

            return lResult;
        }

        /// <summary>
        /// Get Max valid Date of Reference
        /// </summary>
        /// <returns></returns>
        public String MaxDateOfRefernceAsLocal()
        {
            //YYYY-MM-DD
            String lResult = null;

            lResult = String.Format("{0}-{1}-{2}",
                                    MaxDateOfReference.Year,
                                    MaxDateOfReference.Month,
                                    MaxDateOfReference.Day);

            return lResult;
        }

        /// <summary>
        /// Get String of DefaultFarmLatitude
        /// </summary>
        /// <returns></returns>
        public String GetDefaultFarmLatitude()
        {
            String lReturn = null;

            lReturn = DefaultFarmLatitude.ToString();

            return lReturn;
        }

        /// <summary>
        /// Get String of DefaultFarmLongitude
        /// </summary>
        /// <returns></returns>
        public String GetDefaultFarmLongitude()
        {
            String lReturn = null;

            lReturn = DefaultFarmLongitude.ToString();

            return lReturn;
        }

        #endregion

        #region Overrides
        #endregion


    }
}