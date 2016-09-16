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
using IrrigationAdvisor.Models.Irrigation;

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

        public String DefaultFarmLatitude { get; set; }

        public String DefaultFarmLongitude { get; set; }

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


        public HomeViewModel(User pUser, List<FarmViewModel> pFarmViewModelList,
                            DateTime pDateOfReference,
                            FarmViewModel pDefaultFarmViewModel, 
                            String pDefaultFarmLatitude, String pDefaultFarmLongitude,
                            List<CropIrrigationWeather> pCropIrrigationWeatherViewModelList,
                            List<DailyRecordViewModel> pDailyRecordViewModelList,
                            List<RainViewModel> pRainViewModelList,
                            List<IrrigationViewModel> pIrrigationViewModelList,
                            DateTime pMinDateOfReference,
                            DateTime pMaxDateOfReference)
        {
            FarmViewModelList = pFarmViewModelList;
            DateOfReference = pDateOfReference;
            DefaultFarmViewModel = pDefaultFarmViewModel;
            DefaultFarmLatitude = pDefaultFarmLatitude;
            DefaultFarmLongitude = pDefaultFarmLongitude;

            IrrigationUnitViewModelList = DefaultFarmViewModel.IrrigationUnitViewModelList;
            
            TestIrrigationUnitViewModel = IrrigationUnitViewModelList.FirstOrDefault();
            CropIrrigationWeatherViewModelList = GetCropIrrigationWeatherViewModelListBy(pCropIrrigationWeatherViewModelList);

            RainViewModelList = pRainViewModelList;
            IrrigationViewModelList = pIrrigationViewModelList;

            DailyRecordViewModelList = pDailyRecordViewModelList;
            
            MinDateOfReference = pMinDateOfReference;
            MaxDateOfReference = pMaxDateOfReference;
            
        }



        #endregion

        #region Private Helpers

        #endregion

        #region Public Methods


        #region Date of Reference
        /// <summary>
        /// Get Date of Reference
        /// </summary>
        /// <returns></returns>
        public String DateOfReferenceAsLocal()
        {
            return Utils.GetDateTimeForClientScripts(DateOfReference);
        }

        /// <summary>
        /// Get Min valid Date of Reference
        /// </summary>
        /// <returns></returns>
        public String MinDateOfReferenceAsLocal()
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
        public String MaxDateOfReferenceAsLocal()
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

            lReturn = DefaultFarmLatitude.ToString().Replace(",",".");

            return lReturn;
        }

        /// <summary>
        /// Get String of DefaultFarmLongitude
        /// </summary>
        /// <returns></returns>
        public String GetDefaultFarmLongitude()
        {
            String lReturn = null;

            lReturn = DefaultFarmLongitude.ToString().Replace(",", ".");

            return lReturn;
        }

        #endregion


        /// <summary>
        /// Get CropIrrigationWeatherViewModel list by CropIrrigationWeather list
        /// </summary>
        /// <param name="pCropIrrigationWeatherList"></param>
        /// <returns></returns>
        public List<CropIrrigationWeatherViewModel> GetCropIrrigationWeatherViewModelListBy(List<CropIrrigationWeather> pCropIrrigationWeatherList)
        {
            List<CropIrrigationWeatherViewModel> lReturn = new List<CropIrrigationWeatherViewModel>();

            if (pCropIrrigationWeatherList != null && pCropIrrigationWeatherList.Count() > 0)
            {
                foreach (CropIrrigationWeather item in pCropIrrigationWeatherList)
                {
                    CropIrrigationWeatherViewModel lBomb = new CropIrrigationWeatherViewModel(item);
                    lReturn.Add(lBomb);
                }
            }

            return lReturn;
        }


        /// <summary>
        /// Get IrrigationUnitViewModel list by IrrigationUnit list
        /// </summary>
        /// <param name="pIrrigationUnitList"></param>
        /// <returns></returns>
        public List<IrrigationUnitViewModel> GetIrrigationUnitViewModelListBy(List<IrrigationUnit> pIrrigationUnitList)
        {
            List<IrrigationUnitViewModel> lReturn = new List<IrrigationUnitViewModel>();

            if (pIrrigationUnitList != null && pIrrigationUnitList.Count() > 0)
            {
                foreach (IrrigationUnit item in pIrrigationUnitList)
                {
                    IrrigationUnitViewModel lIrrigationUnit = new IrrigationUnitViewModel(item);
                    lReturn.Add(lIrrigationUnit);
                }
            }

            return lReturn;
        }


        #endregion

        #region Overrides
        #endregion


    }
}