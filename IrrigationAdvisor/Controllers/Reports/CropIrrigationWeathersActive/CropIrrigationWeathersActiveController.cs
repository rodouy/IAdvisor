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
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.ViewModels.Errors;
using IrrigationAdvisor.ViewModels.Home;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.ViewModels.Management;
using IrrigationAdvisor.ViewModels.Water;
using IrrigationAdvisor.ViewModels.Weather;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection;

using System.Web.Mvc;


namespace IrrigationAdvisor.Controllers
{

    public class CropIrrigationWeathersActiveController : Controller
    {
        //TODO: Refactor ErrorClass with code and text

      

        public ActionResult Index()
        {
            IrrigationAdvisorContext.Instance();
            return View("~/Views/Reports/CropIrrigationWeathersActive/CropIrrigationWeathersActive.cshtml");
        }

 
        private Farm GetCurrentFarm(List<Farm> pFarmList)
        {
            string lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
            Uri lMyUri = new Uri(lURL);
            string lcurrentFarmViaUrl = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("farm");
            Farm lCurrentFarm;

            if (String.IsNullOrEmpty(lcurrentFarmViaUrl))
            {
                lCurrentFarm = pFarmList
                                    .Where(f => f.BombList.Count > 0
                                        && f.IrrigationUnitList.Count > 0)
                                    .FirstOrDefault();
            }
            else
            {
                int lFarmId = Convert.ToInt32(lcurrentFarmViaUrl);
                lCurrentFarm = pFarmList.Single(f => f.FarmId == lFarmId);
                if (lCurrentFarm == null)
                {
                    lCurrentFarm = pFarmList
                                    .Where(f => f.BombList.Count > 0
                                        && f.IrrigationUnitList.Count > 0)
                                    .FirstOrDefault();
                }
            }

            return lCurrentFarm;
        }
        

        private List<CropIrrigationWeather> GetCropIrrigationWeatherListByFarmId(long farmId, DateTime dateOfReference)
        {
            IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
            IrrigationUnitConfiguration iuc = new IrrigationUnitConfiguration();

            List<CropIrrigationWeather> lResult = null;

           Farm lCurrentFarm = lContext.Farms.FirstOrDefault(f => f.FarmId == farmId);

            if (lCurrentFarm != null)
            {
                List<IrrigationUnit> lIrrigationUnitList = iuc.GetIrrigationUnitListBy(lCurrentFarm);

                List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();

                foreach (var lIrrigationUnit in lIrrigationUnitList)
                {
                    var lGetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy = iuc.GetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy(lIrrigationUnit, dateOfReference);

                    foreach (var ciw in lGetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy)
                    {
                        if(!lCropIrrigationWeatherList.Any(c => c.CropIrrigationWeatherId == ciw.CropIrrigationWeatherId))
                        {
                            lCropIrrigationWeatherList.Add(ciw);
                        }
                    }

                    lResult = lCropIrrigationWeatherList;
                } 
            }

            return lResult;
        }

        private List<Farm> GetFarmsByUserAsList()
        {
            UserConfiguration lUserConfiguration = new UserConfiguration();
            FarmConfiguration lFarmConfiguration = new FarmConfiguration();

            try
            {
                LoginViewModel lLoginViewModel = ManageSession.GetLoginViewModel();

                if (lLoginViewModel != null)
                {
                    string lUserName = lLoginViewModel.UserName;

                    User lUser = lUserConfiguration.GetUserByName(lUserName);

                    if (lUser != null)
                    {
                        return lFarmConfiguration.GetFarmWithActiveCropIrrigationWeathersListBy(lUser);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetFarmsByUserAsList ");
            }

            return null;
        }


        /// <summary>
        /// Get WeatherStation list, without repeating it.
        /// One for all CropIrrigationWeather in list parameter.
        /// </summary>
        /// <param name="pCropIrrigationWeatherList"></param>
        /// <returns></returns>
        private List<WeatherStation> GetUniqueWeatherStationList(List<CropIrrigationWeather> pCropIrrigationWeatherList)
        {
            List<WeatherStation> lResult = null;
            List<WeatherStation> lWeatherStationList = new List<WeatherStation>();

            if (pCropIrrigationWeatherList != null && pCropIrrigationWeatherList.Any())
            {
                //Add all Weather Stations in use.
                foreach (CropIrrigationWeather lCIW in pCropIrrigationWeatherList)
                {
                    if (lCIW.MainWeatherStation != null)
                    {
                        if (!lWeatherStationList.Contains(lCIW.MainWeatherStation))
                        {
                            lWeatherStationList.Add(lCIW.MainWeatherStation);
                        }
                    }
                    if (lCIW.AlternativeWeatherStation != null)
                    {
                        if (!lWeatherStationList.Contains(lCIW.AlternativeWeatherStation))
                        {
                            lWeatherStationList.Add(lCIW.AlternativeWeatherStation);
                        }
                    }
                }
                lResult = lWeatherStationList;
            }

            return lResult;
        }

        private bool PredictionWeatherData()
        {
            bool lResult = false;
            try
            {
                IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
                CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();
                List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                List<WeatherStation> lWeatherStationList = new List<WeatherStation>();

                Status lStatus = ManageSession.GetCurrentStatus();
                DateTime lDateOfReference = Utils.GetDateOfReference().Value;
                DateTime lToday = lDateOfReference;

                if (lStatus.Name == "Production")
                {
                    lToday = System.DateTime.Now;
                }

                lCropIrrigationWeatherList = lCropIrrigationWeatherConfiguration.GetCropIrrigationWeatherListWithWeatherDataBy(lDateOfReference);

                lWeatherStationList = this.GetUniqueWeatherStationList(lCropIrrigationWeatherList);

                if (lWeatherStationList != null && lWeatherStationList.Any())
                {
                    foreach (WeatherStation lWeatherStation in lWeatherStationList)
                    {
                        try
                        {
                            if (lWeatherStation.WeatherDataList != null && lWeatherStation.WeatherDataList.Any())
                            {
                                lWeatherStation.GeneratePredictionWeatherData(lDateOfReference);
                            }
                        }
                        catch (Exception ex)
                        {
                        Utils.LogError(ex, "Exception in HomeController.PredictionWeatherData ");
                            continue;
                        }
                    }
                }
                lResult = true;
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.PredictionWeatherData ");
                lResult = false;
            }

            return lResult;
        }







  
        [ChildActionOnly]
        public PartialViewResult FrontPagePartial()
        {
            return PartialView("~/Views/Reports/CropIrrigationWeathersActive/_FrontPagePartial.cshtml", GetGridPivotHome());
        }

        [ChildActionOnly]
        public PartialViewResult FrontPageHeaderPartial()
        {
            
            
            return PartialView("~/Views/Reports/CropIrrigationWeathersActive/_FrontPageHeaderPartial.cshtml", GetGridPivotHomeTitles());
        }

 

        #region Grid Pivot Home

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
            User lLoggedUser;
            List<Farm> lFarmList;

            #endregion

            #region Configuration Variables
            UserConfiguration uc;
            FarmConfiguration fc;
            #endregion

            try
            {

                #region Configuration - Instance
                uc = new UserConfiguration();
                fc = new FarmConfiguration();
                #endregion

                lDateOfReference = ManageSession.GetNavigationDate();

                //Obtain logged user
                lLoggedUser = uc.GetUserByName(ManageSession.GetUserName());

                //Get list of Farms from User
                lFarmList = fc.GetFarmListIncludedIrrigationUnitListCityBy(lLoggedUser);

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
        public List<GridPivotHome> GetGridPivotHome()
        {
            #region Local Variables
            String lSomeData = "";
            List<GridPivotHome> lGridIrrigationUnitList = new List<GridPivotHome>();
            GridPivotHome lGridIrrigationUnit;
            List<GridPivotDetailHome> lGridIrrigationUnitDetailRow;
            GridPivotDetailHome lGridIrrigationUnitRow;
            DateTime lDateOfReference;
            FarmViewModel lFarmViewModel;
            User lLoggedUser;
            List<Farm> lFarmList;
           // Farm lCurrentFarm;
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
            UserConfiguration lUserConfiguration;
            FarmConfiguration lFarmConfiguration;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration;
            IrrigationAdvisorContext lIrrigationAdvisorContext;
            #endregion

            try
            {

                #region Configuration - Instance
                lUserConfiguration = new UserConfiguration();
                lFarmConfiguration = new FarmConfiguration();
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();
                lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();
                #endregion

                lDateOfReference = ManageSession.GetNavigationDate();
                lSomeData = lSomeData + "Date: " + lDateOfReference.Date + "-";

                //Obtain logged user
                lLoggedUser = lUserConfiguration.GetUserByName(ManageSession.GetUserName());
                lSomeData = lSomeData + "User: " + lLoggedUser.Name + "-";

                //Get list of Farms from User
                lFarmList = lFarmConfiguration.GetFarmWithActiveCropIrrigationWeathersListBy(lLoggedUser);

                //Create IrrigationQuantity Units List
                lIrrigationUnitList = new List<IrrigationUnit>();
                foreach (Farm lCurrentFarm in lFarmList)
                {


                    lSomeData = lSomeData + "Farm: " + lCurrentFarm.Name + "-";
                    lFarmViewModel = new FarmViewModel(lCurrentFarm);
                   
                    lIrrigationUnitList = lIrrigationUnitConfiguration.GetIrrigationUnitListBy(lCurrentFarm);

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
                            lGridIrrigationUnit = new GridPivotHome(lCurrentFarm.Name + " | " + lFirstPivotName,
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