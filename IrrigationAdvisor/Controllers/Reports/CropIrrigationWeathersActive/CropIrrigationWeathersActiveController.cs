using IrrigationAdvisor.Authorize;
using IrrigationAdvisor.ComplementedUtils;
using IrrigationAdvisor.Controllers.Helpers;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.DBContext.Agriculture;
using IrrigationAdvisor.DBContext.Data;
using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Management;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.GridHome;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Reports.ReportPivotState;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.ViewModels.Water;
using IrrigationAdvisor.ViewModels.Weather;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using IrrigationAdvisor.ViewModels.Home;
using IrrigationAdvisor.ViewModels.Reports;

namespace IrrigationAdvisor.Controllers
{

    public class CropIrrigationWeathersActiveController : Controller
    {

        CropIrrigationWeathersActiveViewModel vm = new CropIrrigationWeathersActiveViewModel();

        public ActionResult Index()
        {
            IrrigationAdvisorContext.Instance();

            FarmConfiguration lFarmConfiguration;
            UserConfiguration lUserConfiguration;
            User lLoggedUser;
            List<Farm> lFarmList;
            

            #region Configuration - Instance
            lUserConfiguration = new UserConfiguration();
            lFarmConfiguration = new FarmConfiguration();
            #endregion

            lLoggedUser = lUserConfiguration.GetUserByName(ManageSession.GetUserName());
            lFarmList = lFarmConfiguration.GetFarmWithActiveCropIrrigationWeathersListBy(lLoggedUser);
 
            return View("~/Views/Reports/CropIrrigationWeathersActive/CropIrrigationWeathersActive.cshtml", lFarmList);
        }


        #region  Render Grid CIW water input

        [ChildActionOnly]
        public PartialViewResult InputWaterPerDayHeaderPartial()
        {
            return PartialView("~/Views/Reports/CropIrrigationWeathersActive/_InputWaterPerDayHeaderPartial.cshtml", GetGridDailyRecordIrrigationResumeTitles());
        }

        [ChildActionOnly]
        public PartialViewResult InputWaterPerDayPartial(IrrigationUnit pIrrigationUnit)
        {
            return PartialView("~/Views/Reports/CropIrrigationWeathersActive/_InputWaterPerDayPartial.cshtml", GetGridDailyRecordIrrigationResume(pIrrigationUnit));
        }
        #endregion
        #region Grid CIW water input

        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridReportPivotState> GetGridDailyRecordIrrigationResumeTitles()
        {

            #region Local Variables
            List<GridReportPivotState> lGridDailyRecordIrrigationResumeList = new List<GridReportPivotState>();
            GridReportPivotState lGridDailyRecordIrrigationResume;
            #endregion

            try
            {


                lGridDailyRecordIrrigationResume = new GridReportPivotState("Día", "Fecha", "Riego", "Lluvia");
                lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in CropIrrigationWeathersActiveViewModel.GetGridDailyRecordIrrigationResumeTitles");
                return null;
            }

            return lGridDailyRecordIrrigationResumeList;

        }


        /// <summary>
        /// Return Grid Datail from dailyrecord days
        /// </summary>
        /// <returns></returns>
        public List<GridReportPivotState> GetGridDailyRecordIrrigationResume(IrrigationUnit pIrrigationUnit)
        {
            #region Local Variables
            string lEffectiveRain;
            string lEffectiveInputWater;
            double lEffectiveRainDouble;
            double lEffectiveInputWaterDouble;

            List<GridReportPivotState> lGridIrrigationUnitList = new List<GridReportPivotState>();
            List<GridReportPivotState> lGridDailyRecordIrrigationResumeList = new List<GridReportPivotState>();
            GridReportPivotState lGridDailyRecordIrrigationResume = null;
            DateTime lDateOfReference;

            List<DailyRecord> lDailyRecordList;
            DailyRecordConfiguration lDailyRecordConfiguration;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration;
            #endregion

            try
            {
                lDateOfReference = Utils.GetDateOfReference().Value;
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lDailyRecordConfiguration = new DailyRecordConfiguration();

                lCropIrrigationWeatherList = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListIncludeCropMainWeatherStationRainListIrrigationListBy(pIrrigationUnit, lDateOfReference);
                foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                {
                    lDailyRecordList = lDailyRecordConfiguration.GetDailyRecordsListDataUntilDateBy(lCropIrrigationWeather.CropIrrigationWeatherId, lDateOfReference);

                    foreach (var lDailyRecordUnit in lDailyRecordList)
                    {
                        lEffectiveRain = "";
                        lEffectiveInputWater = "";
                        lEffectiveRainDouble = 0;
                        lEffectiveInputWaterDouble = 0;

                        if (lDailyRecordUnit.Rain != null)
                        {
                            lEffectiveRainDouble = lDailyRecordUnit.Rain.ExtraInput + lDailyRecordUnit.Rain.Input;
                        }

                        if (lDailyRecordUnit.Irrigation != null)
                        {
                            lEffectiveInputWaterDouble = lDailyRecordUnit.Irrigation.ExtraInput + lDailyRecordUnit.Irrigation.Input;
                        }
                        if (lEffectiveRainDouble + lEffectiveInputWaterDouble > 0) // not input
                        {
                            if (lEffectiveRainDouble != 0)
                                lEffectiveRain = lEffectiveRainDouble.ToString();

                            if (lEffectiveInputWaterDouble != 0)
                                lEffectiveInputWater = lEffectiveInputWaterDouble.ToString();

                            lGridDailyRecordIrrigationResume = new GridReportPivotState(lDailyRecordUnit.DaysAfterSowing.ToString(), lDailyRecordUnit.DailyRecordDateTime.ToShortDateString(), lEffectiveRain, lEffectiveInputWater);
                            lGridDailyRecordIrrigationResumeList.Add(lGridDailyRecordIrrigationResume);
                        }
                    }
                }

            }


            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in ReportPivotState.GetGridDailyRecordIrrigationResume \n {0} ");
                return null;
            }

            return lGridDailyRecordIrrigationResumeList;

        }
        #endregion


        #region  Render Grid Pivot Irrigation

        [ChildActionOnly]
        public PartialViewResult FrontPagePartial(Farm pFarm)
        {
            return PartialView("~/Views/Reports/CropIrrigationWeathersActive/_FrontPagePartial.cshtml", GetGridPivotHome(pFarm));
        }

        [ChildActionOnly]
        public PartialViewResult FrontPageHeaderPartial()
        {
            
            
            return PartialView("~/Views/Reports/CropIrrigationWeathersActive/_FrontPageHeaderPartial.cshtml", GetGridPivotHomeTitles());
        }
        #endregion
        #region Grid Pivot Irrigation

        private readonly List<GridPivotHome> gridIrrigationUnitHomeList = new List<GridPivotHome>();

        /// <summary>
        /// Return Grid Irrigation Unit for Home Titles
        /// </summary>
        /// <returns></returns>
        public List<GridPivotHome> GetGridPivotHomeTitles()
        {

            #region Local Variables
            List<GridPivotHome> lGridIrrigationUnitList = new List<GridPivotHome>();
            GridPivotHome lGridIrrigationUnit;
            List<GridPivotDetailHome> lGridIrrigationUnitDetailRow;
            GridPivotDetailHome lGridIrrigationUnitRow;
            DateTime lDateOfReference;

            #endregion

            try
            {

                lDateOfReference = ManageSession.GetNavigationDate();

                //Grid of irrigation data
                lGridIrrigationUnitDetailRow = new List<GridPivotDetailHome>();

                for (int i = -InitialTables.MIN_DAY_SHOW_IN_GRID_BEFORE_TODAY; i <= InitialTables.MAX_DAY_SHOW_IN_GRID_AFTER_TODAY; i++)
                {
                    //Day i
                    lGridIrrigationUnitRow = AddGridIrrigationUnitDays(lDateOfReference, lDateOfReference.AddDays(i));
                    lGridIrrigationUnitDetailRow.Add(lGridIrrigationUnitRow);
                }

                var homeViewModel = ManageSession.GetHomeViewModel();
                //Add all the days for the IrrigationUnit
                lGridIrrigationUnit = new GridPivotHome("Nombre", 
                                                        "Cultivo", 
                                                        "Siembra", 
                                                        "Fen.", 
                                                        "Balance H.", 
                                                        "KC", 
                                                        homeViewModel.IsUserAdministrator,
                                                        new List<double>(),
                                                        lGridIrrigationUnitDetailRow,
                                                        0);

                lGridIrrigationUnitList.Add(lGridIrrigationUnit);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetGridPivotHomeTitles ");
                throw ex;
            }

            return lGridIrrigationUnitList;

        }

        /// <summary>
        /// Return Grid Irrigation Unit for Home
        /// </summary>
        /// <returns></returns>
        public List<GridPivotHome> GetGridPivotHome(Farm pFarm)
        {
            
            #region Local Variables
            String lSomeData = "";
            List<GridPivotHome> lGridIrrigationUnitList = new List<GridPivotHome>();
            GridPivotHome lGridIrrigationUnit;
            List<GridPivotDetailHome> lGridIrrigationUnitDetailRow;
            GridPivotDetailHome lGridIrrigationUnitRow;
            DateTime lDateOfReference;
            FarmViewModel lFarmViewModel;
            List<IrrigationUnit> lIrrigationUnitList;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;
            String lFirstPivotName = "";
            List<Rain> lRainList;
            List<Models.Water.Irrigation> lIrrigationList;
            List<DailyRecord> lDailyRecordList;
            String lSowingDate;
            String lPhenologicalStageToday;
            Double lHydricBalancePercentage;
            DailyRecord lDailyRecord;
            String lCropCoefficient;
            List<Double> lETcList;
            Double lETcItem;
            HomeViewModel lHomeViewModel;
            #endregion

            #region Configuration Variables
            //UserConfiguration lUserConfiguration;
            //FarmConfiguration lFarmConfiguration;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration;
            IrrigationAdvisorContext lIrrigationAdvisorContext;
            #endregion

            try
            {

                #region Configuration - Instance
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();
                lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();
                #endregion

                lDateOfReference = ManageSession.GetNavigationDate();
                lSomeData = lSomeData + "Date: " + lDateOfReference.Date + "-";



                //Create IrrigationQuantity Units List
                lIrrigationUnitList = new List<IrrigationUnit>();
                lSomeData = lSomeData + "Farm: " + pFarm.Name + "-";
                lFarmViewModel = new FarmViewModel(pFarm);

                lIrrigationUnitList = lIrrigationUnitConfiguration.GetIrrigationUnitListBy(pFarm);

                lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                lDailyRecordList = new List<DailyRecord>();

                foreach (var lIrrigationUnit in lIrrigationUnitList)
                {
                    lCropIrrigationWeatherList = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListIncludeCropMainWeatherStationRainListIrrigationListBy(lIrrigationUnit, lDateOfReference);

                    lFirstPivotName = "";
                    lETcList = new List<Double>();
                    foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                    {
                        lSomeData = lSomeData + "CropIrrigationWeather: " + lCropIrrigationWeather.CropIrrigationWeatherName + "-";

                        lDailyRecordList = lCropIrrigationWeatherConfiguration.GetDailyRecordListIncludeDailyRecordListBy(lIrrigationUnit, lDateOfReference, lCropIrrigationWeather.Crop);

                        lRainList = lCropIrrigationWeather.RainList;
                        lIrrigationList = lCropIrrigationWeather.IrrigationList;
                        lSowingDate = lCropIrrigationWeather.SowingDate.Day.ToString()
                                + "/" + lCropIrrigationWeather.SowingDate.Month.ToString();
                        //Grid of irrigation data
                        lGridIrrigationUnitDetailRow = new List<GridPivotDetailHome>();

                        lCropCoefficient = String.Empty;
                        lPhenologicalStageToday = String.Empty;
                        lHydricBalancePercentage = 0;

                        for (int i = -InitialTables.MIN_DAY_SHOW_IN_GRID_BEFORE_TODAY; i <= InitialTables.MAX_DAY_SHOW_IN_GRID_AFTER_TODAY; i++)
                        {
                            //Day i
                            lGridIrrigationUnitRow = AddGridIrrigationUnit(lDateOfReference, lDateOfReference.AddDays(i), lIrrigationList, lRainList, lDailyRecordList);
                            lGridIrrigationUnitDetailRow.Add(lGridIrrigationUnitRow);
                            if (i == 0) //TODAY
                            {
                                //Obtain All data for today from DailyRecord
                                lPhenologicalStageToday = lGridIrrigationUnitRow.Phenology;
                                lDailyRecord = lGridIrrigationUnitRow.DailyRecord;
                                if (lDailyRecord != null)
                                {
                                    lCropCoefficient = lDailyRecord.CropCoefficient.ToString();
                                    lPhenologicalStageToday = lDailyRecord.PhenologicalStage.Stage.ShortName;
                                    lHydricBalancePercentage = lDailyRecord.PercentageOfHydricBalance;

                                }
                            }
                            if (lGridIrrigationUnitRow.DailyRecord == null)
                            {
                                if (lCropIrrigationWeather.MainWeatherStationId > 0)
                                {
                                    lETcItem = lIrrigationAdvisorContext.WeatherDatas
                                                    .Where(wd => wd.Date == lGridIrrigationUnitRow.DateOfData.Date
                                                        && wd.WeatherStationId == lCropIrrigationWeather.MainWeatherStationId)
                                                        .Select(wd => wd.Evapotranspiration).FirstOrDefault();
                                }
                                else
                                {
                                    lETcItem = lIrrigationAdvisorContext.WeatherDatas
                                                    .Where(wd => wd.Date == lGridIrrigationUnitRow.DateOfData.Date
                                                        && wd.WeatherStationId == lCropIrrigationWeather.AlternativeWeatherStationId)
                                                        .Select(wd => wd.Evapotranspiration).FirstOrDefault();
                                }
                            }
                            else
                            {
                                lETcItem = Math.Round(lGridIrrigationUnitRow.DailyRecord.EvapotranspirationCrop.Output / lGridIrrigationUnitRow.DailyRecord.CropCoefficient, 2);
                            }
                            lETcList.Add(Math.Round(lETcItem, 2));
                        }
                        if (String.IsNullOrEmpty(lFirstPivotName))
                        {
                            lFirstPivotName = lCropIrrigationWeather.IrrigationUnit.ShortName;
                        }
                        else if (lFirstPivotName == lCropIrrigationWeather.IrrigationUnit.ShortName)
                        {
                            lFirstPivotName = "";
                        }

                        lHomeViewModel = ManageSession.GetHomeViewModel();

                        //Add all the days for the IrrigationUnit
                        lGridIrrigationUnit = new GridPivotHome(lFirstPivotName,
                                                                lCropIrrigationWeather.Crop.ShortName,
                                                                lSowingDate,
                                                                lPhenologicalStageToday,
                                                                lHydricBalancePercentage.ToString() + " %",
                                                                lCropCoefficient,
                                                                lHomeViewModel.IsUserAdministrator,
                                                                lETcList,
                                                                lGridIrrigationUnitDetailRow,
                                                                lCropIrrigationWeather.CropIrrigationWeatherId);

                        lGridIrrigationUnitList.Add(lGridIrrigationUnit);
                    }
                }

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetGridPivotHome \n {0} ", lSomeData);
                throw ex;
            }

            return lGridIrrigationUnitList;

        }

        /// <summary>
        /// Add Grid Irrigation Unit only with day
        /// </summary>
        /// <param name="pDayOfReference"></param>
        /// <param name="pDayOfData"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pRainList"></param>
        /// <param name="pDailyRecordList"></param>
        /// <returns></returns>
        private GridPivotDetailHome AddGridIrrigationUnitDays(DateTime pDayOfReference, DateTime pDayOfData)
        {
            GridPivotDetailHome lReturn = null;

            Double lIrrigationQuantity = 0;
            Double lRainQuantity = 0;
            Double lForcastIrrigationQuantity = 0;
            DateTime lDateOfData = Utils.MIN_DATETIME;
            bool lIsToday = false;
            Utils.IrrigationStatus lIrrigationStatus = Utils.IrrigationStatus.Default;
            String lPhenology = "";

            lDateOfData = pDayOfData;
            lIsToday = pDayOfData == pDayOfReference;

            lReturn = new GridPivotDetailHome(lIrrigationQuantity, lRainQuantity,
                                                lForcastIrrigationQuantity,
                                                lDateOfData, lIsToday,
                                                lIrrigationStatus,
                                                lPhenology);
            return lReturn;
        }

        /// <summary>
        /// Add Grid Irrigation Unit with all columns data
        /// Using DailyRecords for obtain Irrigation, Rain information.
        /// </summary>
        /// <param name="pDayOfReference"></param>
        /// <param name="pDayOfData"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pRainList"></param>
        /// <param name="pDailyRecordList"></param>
        /// <returns></returns>
        private GridPivotDetailHome AddGridIrrigationUnit(DateTime pDayOfReference, DateTime pDayOfData, List<Models.Water.Irrigation> pIrrigationList,
                                                        List<Rain> pRainList, List<DailyRecord> pDailyRecordList)
        {
            #region local variables
            String lSomeData = "";
            GridPivotDetailHome lReturn = null;

            Double lIrrigationQuantity = 0;
            Double lRainQuantity = 0;
            Double lForcastIrrigationQuantity = 0;
            Double lWaterQuantity = 0;
            DateTime lDateOfData = Utils.MIN_DATETIME;
            DateTime lDayOfReference = Utils.MIN_DATETIME;
            bool lIsToday = false;
            Utils.IrrigationStatus lIrrigationStatus = Utils.IrrigationStatus.Default;
            String lPhenology = "";

            Rain lRain = null;
            DailyRecord lDailyRecord = null;
            #endregion

            try
            {
                lDateOfData = pDayOfData.Date;
                lDayOfReference = pDayOfReference.Date;
                lSomeData = lSomeData + "DayOfReference: " + lDayOfReference.Date + "-";
                lSomeData = lSomeData + "DateOfData: " + lDateOfData.Date + "-";

                //Find Daily Record of the Date of Data
                lDailyRecord = pDailyRecordList.Where(dr => dr.DailyRecordDateTime.Date == lDateOfData.Date).FirstOrDefault();

                #region Irrigation in the past
                if (lDailyRecord != null && lDateOfData < lDayOfReference)
                {
                    if (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.Input > 0)
                    {
                        lIrrigationQuantity += lDailyRecord.Irrigation.Input;
                    }
                    else if (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.ExtraInput > 0)
                    {
                        lIrrigationQuantity += lDailyRecord.Irrigation.ExtraInput;
                    }
                }
                #endregion

                lWaterQuantity = lIrrigationQuantity;
                lSomeData = lSomeData + "IrrigationQuantity: " + lIrrigationQuantity + "-";

                #region Rain
                //Find Rain of the Date of Data
                lRain = pRainList.Where(r => r.Date.Date == lDateOfData || r.ExtraDate.Date == lDateOfData).FirstOrDefault();
                if (lRain != null && lRain.GetTotalInput() > 0)
                {
                    lRainQuantity = lRain.GetTotalInput();
                }
                #endregion

                lWaterQuantity += lRainQuantity;
                lSomeData = lSomeData + "RainQuantity: " + lRainQuantity + "-";

                #region Irrigation for today or in the future
                //Find Daily Record of the Date of Data
                lDailyRecord = pDailyRecordList.Where(dr => dr.DailyRecordDateTime.Date == lDateOfData).FirstOrDefault();
                if (lDailyRecord != null && lDateOfData >= lDayOfReference)
                {
                    if (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.Input > 0)
                    {
                        lForcastIrrigationQuantity += lDailyRecord.Irrigation.Input;
                    }
                    else if (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.ExtraInput > 0)
                    {
                        lForcastIrrigationQuantity += lDailyRecord.Irrigation.ExtraInput;
                    }
                }
                #endregion

                lWaterQuantity += lForcastIrrigationQuantity;
                lSomeData = lSomeData + "ForcastIrrigationQuantity: " + lForcastIrrigationQuantity + "-";

                lIsToday = lDateOfData == lDayOfReference;

                if (lIsToday && lDailyRecord != null)
                {
                    lPhenology = lDailyRecord.PhenologicalStage.Stage.ShortName;
                }

                #region IrrigationStatus
                if (lRainQuantity > 0 && lRainQuantity >= (lWaterQuantity - lRainQuantity))
                {
                    lIrrigationStatus = Utils.IrrigationStatus.Rain;
                }
                else if (lIrrigationQuantity > 0 && lIrrigationQuantity > lRainQuantity)
                {
                    lIrrigationStatus = Utils.IrrigationStatus.Irrigated;
                }
                else if (lForcastIrrigationQuantity > 0 && lForcastIrrigationQuantity > lRainQuantity)
                {
                    lIrrigationStatus = Utils.IrrigationStatus.NextIrrigation;
                }
                else if (lDailyRecord != null && (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.Type == Utils.WaterInputType.CantIrrigate))
                {
                    lIrrigationStatus = Utils.IrrigationStatus.CantIrrigate;
                }
                else if (lDailyRecord != null && (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.Type == Utils.WaterInputType.IrrigationWasNotDecided))
                {
                    lIrrigationStatus = Utils.IrrigationStatus.IrrigationWasNotDecided;
                }
                else
                {
                    lIrrigationStatus = Utils.IrrigationStatus.Default;
                }
                #endregion

                lSomeData = lSomeData + "IrrigationStatus: " + lIrrigationStatus.ToString() + "-";

                lReturn = new GridPivotDetailHome(lIrrigationQuantity, lRainQuantity, lForcastIrrigationQuantity,
                                                                lDateOfData, lIsToday, lIrrigationStatus,
                                                                lPhenology, lDailyRecord);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.AddGridIrrigationUnit \n {0}", lSomeData);
                throw ex;
            }

            return lReturn;
        }

        #endregion

    }
}