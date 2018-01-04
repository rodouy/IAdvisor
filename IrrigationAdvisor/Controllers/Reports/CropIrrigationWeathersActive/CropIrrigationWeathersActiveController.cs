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

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            return View();
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
        
        public ActionResult Home(LoginViewModel pLoginViewModel)
        {
            Authentication lAuthentication;
            HomeViewModel lHomeViewModel;

            #region Configuration Variables
            UserConfiguration uc;
            FarmConfiguration fc;
            IrrigationUnitConfiguration iuc;
            CropIrrigationWeatherConfiguration ciwc;
            StatusConfiguration sc;
            #endregion

            #region Local Variables
            String lSomeData = "";
            DateTime lDateOfReference;
            DateTime lMinDateOfReference = Utils.MIN_DATETIME;
            DateTime lMaxDateOfReference = Utils.MAX_DATETIME;
            FarmViewModel lFarmViewModel;
            ErrorViewModel lErrorVM;
            User lLoggedUser;
            List<Farm> lFarmList;
            Farm lCurrentFarm;
            String lCurrentFarmLatitude;
            String lCurrentFarmLongitude;
            List<FarmViewModel> lFarmViewModelList;
            List<Bomb> lBombList;
            List<IrrigationUnit> lIrrigationUnitList;
            List<CropIrrigationWeather> lPosibleCropIrrigationWeatherList;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;
            Crop lCrop;
            CropIrrigationWeather lFirstCropIrrigationWeather;
            List<Rain> lRainList;
            List<Models.Water.Irrigation> lIrrigationList;
            List<DailyRecord> lDailyRecordList;

            List<DailyRecordViewModel> lDailyRecordViewModelList;
            List<RainViewModel> lRainViewModelList;
            List<IrrigationViewModel> lIrrigationViewModelList;

            List<CropIrrigationWeather> lCropIrrigationWeatherVM;
            sc = new StatusConfiguration();
            lErrorVM = new ErrorViewModel();
            #endregion

            int trace = 0;
            try
            {
                //IrrigationAdvisorContext.Refresh();
                IrrigationAdvisorContext.Instance();

                #region Manage Session, Get Login from Session
                
                if (pLoginViewModel != null && !string.IsNullOrEmpty(pLoginViewModel.UserName))
                {
                    ManageSession.SetLoginViewModel(pLoginViewModel);                   
                }
                else
                {
                    LoginViewModel localLgM = ManageSession.GetLoginViewModel();

                    if(localLgM == null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        pLoginViewModel = ManageSession.GetLoginViewModel();
                    }
                }

                ViewBag.UserName = pLoginViewModel.UserName;

                trace = 10;
                ManageSession.SetUserName(pLoginViewModel.UserName);
                ManageSession.SetUserPassword(pLoginViewModel.Password);

                trace = 20;
                lAuthentication = new Authentication(pLoginViewModel.UserName, pLoginViewModel.Password);
                lSomeData = lSomeData + "Authentication: " + lAuthentication.UserName + "-";
                
                if (!lAuthentication.IsAuthenticated())
                {
                    var routes = new RouteValueDictionary { { "msg", AUTHENTICATION_ERROR }};
                    return RedirectToAction("Index", routes);
                }

                RegisterLogIn(lAuthentication.UserName);

                bool lIsOnline = Utils.IsOnline(System.Configuration.ConfigurationManager.AppSettings["Status"]);

                if(!lIsOnline)
                {
                    var routes = new RouteValueDictionary { { "msg", NOT_ONLINE_SITE_STATUS } , { "msg2", NOT_ONLINE_WAITING_TIME } };
                    return RedirectToAction("Index", routes);
                }

                trace = 30;
                #endregion

                #region new Instances - Configurations/ErrorVM 
                //uc - GetUserByName
                uc = new UserConfiguration();
                //fc - GetFarmListBy - GetLatitudeBy - GetLongitudeBy
                fc = new FarmConfiguration();
                //iuc - GetIrrigationUnitListBy - GetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy
                iuc = new IrrigationUnitConfiguration();
                //ciwc - GetDailyRecordListIncludeDailyRecordListBy - GetMinDateOfReferenceBy - GetMaxDateOfReferenceBy
                ciwc = new CropIrrigationWeatherConfiguration();
                #endregion

                trace = 40;
                #region Date of Reference
                if (ManageSession.GetNavigationDate() >= Utils.MAX_DATETIME)
                {
                    //Get date of reference from the database
                    lDateOfReference = Utils.GetDateOfReference().Value;
                    ManageSession.SetNavigationDate(lDateOfReference);
                }
                else
                {
                    lDateOfReference = ManageSession.GetNavigationDate();
                }
                lSomeData = lSomeData + "DateOfReference: " + lDateOfReference.Date + "-";

                ViewBag.DateOfReference = lDateOfReference;
                #endregion
                trace = 50;
                //Obtain logged user
                lLoggedUser = uc.GetUserByName(pLoginViewModel.UserName);
                
                #region Get list of Farms from User
                if(lLoggedUser != null)
                {
                    lFarmList = fc.GetFarmWithActiveCropIrrigationWeathersListBy(lLoggedUser);
                }
                else
                {
                    lErrorVM.Code = USER_IS_NULL_CODE;
                    lErrorVM.Description = USER_IS_NULL;

                    HomeViewModel HVMError = new HomeViewModel(lErrorVM);
                    logger.Debug(USER_IS_NULL);
                    return View(HVMError);
                }
                
                
                trace = 60;
                // If the user doesnt have farms
                if (lFarmList.Count == 0)
                {
                    lErrorVM.Code = NO_FARMS_FOR_USER_NR;
                    lErrorVM.Description = NO_FARMS_FOR_USER;

                    HomeViewModel HVMError = new HomeViewModel(lErrorVM);
                    logger.Debug(NO_FARMS_FOR_USER);
                    return View(HVMError);
                }
                #endregion

                #region ViewModel - Farm List, Bomb List, IrrigationUnit List
                //Create View Model Farm list
                lFarmViewModelList = new List<FarmViewModel>();
                //Create Bomb List
                lBombList = new List<Bomb>();
                //Create IrrigationQuantity Units List
                lIrrigationUnitList = new List<IrrigationUnit>();

                trace = 70;
                //Map each farm with FarmViewModel and add to a list
                foreach (var lFarm in lFarmList)
                {
                    lBombList = lFarm.BombList;
                    lIrrigationUnitList = iuc.GetIrrigationUnitListBy(lFarm);

                    lFarmViewModel = new FarmViewModel(lFarm);
                    lFarmViewModel.SetIrrigationUnitListBy(lIrrigationUnitList);
                    if (lBombList.Count > 0 && lIrrigationUnitList.Count > 0)
                    {
                        lFarmViewModelList.Add(lFarmViewModel);
                    }
                    else
                    {
                        //TODO: throw error No IrrigationUnit to the farm selected
                    }
                }
                #endregion

                trace = 80;
                #region Current Farm
                lCurrentFarm = GetCurrentFarm(lFarmList);
                lSomeData = lSomeData + "Farm: " + lCurrentFarm.Name + "-";

                lCurrentFarmLatitude = fc.GetLatitudeBy(lCurrentFarm.PositionId).ToString().Replace(",", ".");
                lCurrentFarmLongitude = fc.GetLongitudeBy(lCurrentFarm.PositionId).ToString().Replace(",", ".");
                lFarmViewModel = new FarmViewModel(lCurrentFarm);
                lIrrigationUnitList = iuc.GetIrrigationUnitListBy(lCurrentFarm);
                #endregion

                trace = 90;

                lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                lDailyRecordList = new List<DailyRecord>();
                foreach (var lIrrigationUnit in lIrrigationUnitList)
                {
                    lPosibleCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy(lIrrigationUnit, lDateOfReference);
                    //Only using Active CropIrrigationWeather, depending in DateOfReference 
                    if (lPosibleCropIrrigationWeatherList != null && lPosibleCropIrrigationWeatherList.Count() > 0)
                    {
                        lCrop = lPosibleCropIrrigationWeatherList.FirstOrDefault().Crop;
                        lDailyRecordList = ciwc.GetDailyRecordListIncludeDailyRecordListBy(lIrrigationUnit, lDateOfReference, lCrop);
                        lMinDateOfReference = ciwc.GetMinDateOfReferenceBy(lIrrigationUnit, lDateOfReference);
                        lMaxDateOfReference = ciwc.GetMaxDateOfReferenceBy(lIrrigationUnit, lDateOfReference);
                        lCropIrrigationWeatherList.AddRange(lPosibleCropIrrigationWeatherList);
                    }
                    else
                    {
                        trace = 95;
                    }
                }

                trace = 100;
                //TODO Change First CropIrrigationWeather
                lFirstCropIrrigationWeather = lCropIrrigationWeatherList.FirstOrDefault();
                lSomeData = lSomeData + "CropIrrigationWeather: " + lFirstCropIrrigationWeather.CropIrrigationWeatherName + "-";

                //lDailyRecordList = lFirstCropIrrigationWeather.DailyRecordList;

                lRainList = lFirstCropIrrigationWeather.RainList;
                lRainViewModelList = new List<RainViewModel>();
                foreach (var rain in lRainList)
                {
                    lRainViewModelList.Add(new RainViewModel(rain));
                }

                trace = 110;
                lIrrigationList = lFirstCropIrrigationWeather.IrrigationList;
                lIrrigationViewModelList = new List<IrrigationViewModel>();
                foreach (var irrigation in lIrrigationList)
                {
                    lIrrigationViewModelList.Add(new IrrigationViewModel(irrigation));
                }

                lDailyRecordViewModelList = new List<DailyRecordViewModel>();
                foreach (var daily in lDailyRecordList)
                {
                    lDailyRecordViewModelList.Add(new DailyRecordViewModel(daily));
                }

                trace = 120;
                lCropIrrigationWeatherVM = new List<CropIrrigationWeather>();
                lCropIrrigationWeatherVM.AddRange(lCropIrrigationWeatherList);

                //Demo - One Pivot
                lHomeViewModel = new HomeViewModel(lLoggedUser, lFarmViewModelList, lDateOfReference,
                    lFarmViewModel, lCurrentFarmLatitude, lCurrentFarmLongitude, lCropIrrigationWeatherVM,
                    lDailyRecordViewModelList, lRainViewModelList, lIrrigationViewModelList,
                    lMinDateOfReference, lMaxDateOfReference);

                trace = 130;
                //Create View Model of Home
                //HVM = new HomeViewModel(lLoggedUser, lFarmViewModelList, lDateOfReference);
                lHomeViewModel.DateOfReference = lDateOfReference;
                
                //Set User as Administrator
                lHomeViewModel.IsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);

                //Set User as Intermediate
                lHomeViewModel.IsUserIntermediate = (lLoggedUser.RoleId == (int)Utils.UserRoles.Intermediate);

                trace = 140;
                ManageSession.SetHomeViewModel(lHomeViewModel);

                trace = 150;
                return View(lHomeViewModel);

            }
            catch (NullReferenceException ex)
            {
                Utils.LogError(ex, "Trace: " + trace + " - Exception in HomeController.Home", lSomeData);
                ManageSession.CleanSession();

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Trace: " + trace + " - Exception in HomeController.Home", lSomeData);
                ManageSession.CleanSession();
                return RedirectToAction("Index");
            }

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
        /// TODO: define function
        /// </summary>
        /// <param name="pCropIrrigationWeatherList"></param>
        /// <param name="pDateFrom"></param>
        /// <returns></returns>
        private bool InternalCalculateAllActiveCropIrrigationWeather(List<CropIrrigationWeather> pCropIrrigationWeatherList, DateTime? pDateFrom = null)
        {
            bool lResult = false;
            IrrigationAdvisorContext lContext;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;

            string lConfiguraitonStatus;
            Status lStatus;
            DateTime lDateOfReference;

            DateTime lDateFrom = Utils.MIN_DATETIME;

            try
            {

                lContext = IrrigationAdvisorContext.Instance();
                lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();
                lCropIrrigationWeatherList = new List<CropIrrigationWeather>();

                lConfiguraitonStatus = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["Status"]);
                lStatus = ManageSession.GetCurrentStatus();
                lDateOfReference = lStatus.DateOfReference;

                lDateFrom = Utils.MIN_DATETIME;

                if (lStatus.WebStatus == Utils.IrrigationAdvisorWebStatus.Online)
                {
                    bool lStatusResult = Utils.SetStatusAsMaintenaince(lConfiguraitonStatus);

                    if (lStatusResult)
                    {
                        lCropIrrigationWeatherList = pCropIrrigationWeatherList;

                        //if (lStatus.Name == "Production" && pDateFrom == null)
                        // TO-DO : Verlo con Rodo
                        if (pDateFrom == null)
                        {
                            lDateFrom = lDateOfReference;
                            ProcessInformationToIrrigationUnits(lCropIrrigationWeatherList, lDateFrom, DateTime.Now);
                            lDateOfReference = DateTime.Now;
                        }
                        else
                        {
                            lDateFrom = Utils.MinDateTimeBetween(pDateFrom.Value, lDateOfReference);
                            ProcessInformationToIrrigationUnits(lCropIrrigationWeatherList, lDateFrom, lDateOfReference);
                        }

                        #region before 
                        //foreach (CropIrrigationWeather lCIW in lCropIrrigationWeatherList)
                        //{
                        //    //If Error, continue with others CIWs
                        //    try
                        //    {

                        //        logger.Info("CalculateAllActiveCropIrrigationWeather: CIWid=" + lCIW.CropIrrigationWeatherId +
                        //                    " - DateOfReference=" + lDateOfReference +
                        //                    " - Today=" + lToday + "");
                        //        lCIW.AddInformationToIrrigationUnits(lDateOfReference, lToday, lContext);
                        //        lContext.SaveChanges();

                        //    }
                        //    catch (Exception ex)
                        //    {
                        //        logger.Error(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather " + "\n" + ex.Message + "\n" + ex.StackTrace);
                        //        continue;
                        //    }
                        //}
                        #endregion

                        StatusConfiguration sc = new StatusConfiguration();
                        lResult = sc.SetDateOfReferenceStatus(lDateOfReference, lStatus.Name);

                        lStatusResult = Utils.SetStatusAsOnline(lConfiguraitonStatus);

                        #region Re - try Set Web Status as Online
                        if (!lStatusResult)
                        {
                            int tries = 3;

                            do
                            {
                                lStatusResult = Utils.SetStatusAsOnline(lConfiguraitonStatus);
                                tries--;

                            } while (tries == 0 || lStatusResult);

                            if (!lStatusResult)
                            {
                                logger.Error("The method Utils.SetStatusAsOnline fail " + tries + "times " + "It's necessary to update the record manually in the database to set the web site as online.");
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        logger.Error("In the CalculateAllActiveCropIrrigationWeather fail when the app call the method Utils.SetStatusAsMaintenaince. The method couldn't complete");
                    }
                }
                else
                {
                    logger.Info("CalculateAllActiveCropIrrigationWeather will not run because the site has the Maint status");
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather ");
                lResult = false;
            }

            return lResult;
        }

        /// <summary>
        /// Calculate Active CropIrrigationWeather by id from a Date
        /// A CropIrrigationWeather is Active when Date of Reference is between Date of Sowing and Date of Harvest
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pDateOfReference"></param>
        /// <param name="pDateFrom"></param>
        /// <returns></returns>
        private bool CalculateCropIrrigationWeather(long pCropIrrigationWeatherId, DateTime pDateOfReference, DateTime pDateFrom)
        {
            bool lResult = false;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();
            List<long> lCropIrrigationWeatherIdList = new List<long>();
            
            try
            {
                lCropIrrigationWeatherIdList.Add(pCropIrrigationWeatherId);
                List<CropIrrigationWeather> lCropIrrigationWeatherList = lCropIrrigationWeatherConfiguration.GetCropIrrigationWeatherByIds(lCropIrrigationWeatherIdList, pDateOfReference);
                lResult = InternalCalculateAllActiveCropIrrigationWeather(lCropIrrigationWeatherList, pDateFrom);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculateCropIrrigationWeather ");

            }

            return lResult;
        }

        /// <summary>
        /// Calculate All Active CropIrrigationWeather by Farm from a Date
        /// A CropIrrigationWeather is Active when Date of Reference is between Date of Sowing and Date of Harvest
        /// </summary>
        /// <param name="pFarmId"></param>
        /// <param name="pDateOfReference"></param>
        /// <param name="pDateFrom"></param>
        /// <returns></returns>
        private bool CalculateAllActiveCropIrrigationWeather(long pFarmId, DateTime pDateOfReference, DateTime pDateFrom)
        {
            bool lResult = false;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();
            try
            {
                List<CropIrrigationWeather> lCropIrrigationWeatherList = lCropIrrigationWeatherConfiguration.GetCropIrrigationWeatherByFarm(pFarmId, pDateOfReference);
                lResult = InternalCalculateAllActiveCropIrrigationWeather(lCropIrrigationWeatherList, pDateFrom);
                
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather ");
               
            }

            return lResult;
        }

        /// <summary>
        /// Calculate All CropIrrigationWeather by Date Of Reference to Now (System Date)
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        private bool CalculateAllActiveCropIrrigationWeather(DateTime pDateOfReference)
        {
            bool lResult = false;
            CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();

            try
            {
                List<CropIrrigationWeather> lCropIrrigationWeatherList = ciwc.GetActiveCropIrrigationWeatherListBy(pDateOfReference);
                lResult = InternalCalculateAllActiveCropIrrigationWeather(lCropIrrigationWeatherList);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather ");
                lResult = false;
            }

            return lResult;
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

        /// <summary>
        /// Calculate for a Farm and from a Date
        /// EX: ../Home/CalculateByFarm?farmid=6&pDateFrom=2016-12-19
        /// </summary>
        /// <param name="farmId"></param>
        /// <param name="pDateFrom"></param>
        public void CalculateByFarm(long farmId, DateTime pDateFrom)
        {
            CalculateAllActiveCropIrrigationWeatherByFarmId("Demo", "lluvia", farmId, pDateFrom);
        }

        /// <summary>
        /// Test Calculate all Active CropIrrigationWeather
        /// </summary>
        public void TestCalculate()
        {
            CalculateAllActiveCropIrrigationWeather("Admin", "Irrigation4dvis0r");
        }

        /// <summary>
        /// Calculate Prediction WeatherData
        /// </summary>
        public void CalculatePredictionWeatherData()
        {
            CalculatePredictionWeatherData("Admin", "Irrigation4dvis0r");
        }

        [HttpPost]
        public ActionResult CalculateAllActiveCropIrrigationWeatherByFarmId(string pUserName, string pPassword, long pFarmId, DateTime pDateFrom)
        {
            try
            {
                bool lResult = false;

                if (Login(pUserName, pPassword))
                {
                    PredictionWeatherData(); //To-DO: By farm

                    DateTime lReferenceDate = Utils.GetDateOfReference().Value;

                    lResult = CalculateAllActiveCropIrrigationWeather(pFarmId, lReferenceDate, pDateFrom);
                    
                    if (lResult)
                    {
                        return Content("Ok");
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather ");
            }

            return Content("Error al calcular los Cultivos activos");
        }

        /// <summary>
        ///  Calculate for a Farm and from a Date
        /// EX: ../Home/CalculateAllActiveCropIrrigationWeather?pUserName=Admin&pPassword=Irrigation4dvis0r
        /// "http://iradvisor.pgwwater.com.uy:8080/Home/CalculateAllActiveCropIrrigationWeather"
        /// http://localhost:1938/Home/CalculateAllActiveCropIrrigationWeather
        /// </summary>
        /// <param name="pUserName"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CalculateAllActiveCropIrrigationWeather(string pUserName, string pPassword)
        {
            try
            {
                bool lResult = false;

                if (Login(pUserName, pPassword))
                {
                    PredictionWeatherData();

                    DateTime lReferenceDate = Utils.GetDateOfReference().Value;
                    
                    lResult = CalculateAllActiveCropIrrigationWeather(lReferenceDate);
                    
                    if (lResult)
                    {
                        return Content("Ok");
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather ");
                //return Content("Exception in HomeController.CalculateAllActiveCropIrrigationWeather " + "\n" + ex.Message);
            }

            return Content("Error al calcular los Cultivos activos");
        }
        
        /// <summary>
        /// Prediction Weather Data
        /// </summary>
        /// <param name="pUserName"></param>
        /// <param name="pPassword"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CalculatePredictionWeatherData(string pUserName, string pPassword)
        {
            try
            {
                bool lResult = false;

                if (Login(pUserName, pPassword))
                {
                    lResult = PredictionWeatherData();

                    if (lResult)
                    {
                        return Content("Ok");
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.CalculatePredictionWeatherData ");
                //return Content("Exception in HomeController.CalculatePredictionWeatherData " + "\n" + ex.Message);
            }

            return Content("Error al calcular los Cultivos activos");
        }

        /// <summary>
        /// Update Phenology of a CropIrrigationWeather by Date and Stage
        /// </summary>
        /// <param name="pDate"></param>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pStageId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddPhenology(DateTime pDate,
                                          int pCropIrrigationWeatherId,
                                          int pStageId)
        {

            IrrigationAdvisorContext lContext;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration;
            CropIrrigationWeather lCropIrrigationWeather;
            DateTime lReferenceDate;
            int lDatabaseChangeResult = 0;
            Stage lStageToChange;
            PhenologicalStage lPhenologicalStage;

            try
            {
                lContext = IrrigationAdvisorContext.Instance();
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lReferenceDate = Utils.GetDateOfReference().Value;

                lCropIrrigationWeather = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListBy(pCropIrrigationWeatherId);

                //First Change
                lStageToChange = (from stage in lContext.Stages
                                        where stage.StageId == pStageId
                                        select stage).FirstOrDefault();

                lPhenologicalStage = (from phenologicalstage in lContext.PhenologicalStages
                                        where phenologicalstage.SpecieId.Equals(lCropIrrigationWeather.Crop.SpecieId)
                                        && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                        select phenologicalstage).FirstOrDefault();


                string lObservation = string.Format("Real Stage is {0}, {1}.", lStageToChange.Name, lStageToChange.Description);


                string lName = string.Format("Adjustement {0} {1} ", lStageToChange.Name, pDate.ToString());

                lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCropIrrigationWeather.Crop, pDate,
                                                         lStageToChange, lPhenologicalStage, lObservation);

                lDatabaseChangeResult = lContext.SaveChanges();

                lCropIrrigationWeather.AddInformationToIrrigationUnits(pDate, lReferenceDate, lContext);
                lDatabaseChangeResult = lContext.SaveChanges();

                // Change navigation date of reference
                // When the user add an irrigation the navigation date changes by the date of reference from the database
                ManageSession.SetNavigationDate(lReferenceDate);
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.AddPhenology ");
                return Content("Exception in HomeController.AddPhenology " + "\n" + ex.Message);
            }

            return Content("Ok");
        }

  
        [ChildActionOnly]
        public PartialViewResult FrontPagePartial()
        {
            return PartialView("_FrontPagePartial", GetGridPivotHome());
        }

        [ChildActionOnly]
        public PartialViewResult FrontPageHeaderPartial()
        {
            return PartialView("_FrontPageHeaderPartial", GetGridPivotHomeTitles());
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
            Farm lCurrentFarm;
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

                lCurrentFarm = GetCurrentFarm(lFarmList);
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