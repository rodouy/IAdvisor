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
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Security.Cryptography;
using System.Web.Mvc;
using System.Web.Routing;

namespace IrrigationAdvisor.Controllers
{

    public class HomeController : Controller
    {
        //TODO: Refactor ErrorClass with code and text
        private const int AUTHENTICATION_ERROR_NR = 10001;
        private const string AUTHENTICATION_ERROR = "Credenciales inválidas";
        private const string NOT_ONLINE_SITE_STATUS = "El sitio se encuentra actualizando datos.";
        private const string NOT_ONLINE_WAITING_TIME = "Intente nuevamente en 10 minutos.";
        private const string USER_IS_NULL = "El usuario es nulo";
        private const int USER_IS_NULL_CODE = 10003;
        private const int NO_FARMS_FOR_USER_NR = 10002;
        private const string NO_FARMS_FOR_USER = "El usuario no tiene granjas asignadas";

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(GetGridPivotHome());
        }

        public ActionResult Contact()
        {
            return View();
        }

        /// <summary>
        /// Register log in
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <returns>Count of records added</returns>
        public int RegisterLogIn(string userName)
        {
            int result = 0;

            IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Refresh();

            try
            {
                User user = lContext.Users.Single(u => u.UserName.ToLower() == userName.ToLower());

                UserAccess userAccess = new UserAccess()
                {
                    UserId = user.UserId,
                    LogInDate = DateTime.Now
                };

                lContext.UserAccesses.Add(userAccess);
                result = lContext.SaveChanges();

                ManageSession.SetUserAccess(userAccess.UserAccessId);
            }
            catch (Exception)
            {
                IrrigationAdvisorContext.Refresh();
            }

            return result;
        }

        /// <summary>
        /// Register log ou
        /// </summary>
        /// <param name="userName">user Name</param>
        /// <returns>Count of records added</returns>
        public int RegisterLogOut(long userAccessId)
        {
            int result = 0;

            IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Refresh();

            try
            {
                UserAccess userAccess = lContext.UserAccesses.SingleOrDefault(u => u.UserAccessId == userAccessId);

                if (userAccess != null)
                {
                    userAccess.LogOutDate = DateTime.Now;
                    result = lContext.SaveChanges();
                }
            }
            catch (Exception)
            {
                IrrigationAdvisorContext.Refresh();
            }

            return result;
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
        /// Get Farms for the current user
        /// </summary>
        /// <returns>Json with the Farms</returns>
        public JsonResult GetFarmsByUser()
        {       
            List<FarmShortView> lFarmShortViews = new List<FarmShortView>();

            try
            {
                LoginViewModel lLoginViewModel = ManageSession.GetLoginViewModel();

                if (lLoginViewModel != null)
                {
                    string lUserName = lLoginViewModel.UserName;
      
                    List<Farm> lFarmList = GetFarmsByUserAsList();

                    if (lFarmList != null)
                    {
                        foreach (var item in lFarmList)
                        {
                            FarmShortView lFarmShortView = new FarmShortView()
                            {
                                FarmId = item.FarmId,
                                FarmDescription = item.Name
                            };

                            lFarmShortViews.Add(lFarmShortView);
                        } 
                    }
                    else
                    {
                        // Que pasa cuando no encuentro en User ?
                        return Json("The user not exists", JsonRequestBehavior.AllowGet);
                    }

                    return Json(lFarmShortViews, JsonRequestBehavior.AllowGet);                              
                }
                else
                {
                    return Json("The loginViewModel is null", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetFarmsByUser ");
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult ForgetPassword(string userName, string email)
        {
            try
            {
                UserConfiguration lUserConfiguration = new UserConfiguration();

                IrrigationAdvisorContext lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();

                User lUser = lUserConfiguration.GetUserByName(userName.Trim());

                string subject = "Recuperación de contraseña PGG Wrightson";
                string wrongBody = string.Format("Han intentado restablecer una constraseña sin éxito el User: {0}. El mail no coincidió {1} debería haber sido {2}",
                                                lUser.UserName, email, lUser.Email);

                string randomPassword = RandomPassword();
                string body = string.Format("Ingrese con la siguiente contraseña temporal para acceder {0}", randomPassword);

                if (lUser.Email.ToLower().Trim().Equals(email.ToLower().Trim()))
                {

                    MD5 md5Hash = MD5.Create();

                    User toModify = lIrrigationAdvisorContext.Users.Single(n => n.UserName == lUser.UserName);

                    toModify.Password = CryptoUtils.GetMd5Hash(md5Hash, randomPassword);

                    lIrrigationAdvisorContext.SaveChanges();

                    SendEmails(subject,
                            body,
                            lUser.Email);

                    return Json("Ok", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    SendEmails(subject,
                               wrongBody);

                    return Json("No se ha podido recuperar su contraseña contacte a su administrador", JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.ForgetPassword.");

                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        private string RandomPassword()
        {
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();

            byte[] data = new byte[64];
            rngCsp.GetBytes(data);

            string dataAsString = Convert.ToBase64String(data);

            return dataAsString.Substring(0, 10);
            
        }

        /// <summary>
        /// Move irrigations
        /// </summary>
        /// <param name="pDateToMove">Date to move</param>
        /// <returns></returns>
        public ActionResult MoveIrrigation(DateTime pDateToMove, long pWaterInputId)
        {
            try
            {
                IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
                int lDatabaseChangeResult = 0;

                var waterInput = lContext.Irrigations.Single(w => w.WaterInputId == pWaterInputId);

                //if (waterInput.ExtraInput > 0)
                //{
                //    waterInput.ExtraDate = pDateToMove;
                //}

                string observation = "Move Irrigation from " + waterInput.Date.ToShortDateString() + " to " + pDateToMove.ToShortDateString();

                if (waterInput.Date < pDateToMove)
                {
                    AddNoIrrigation(waterInput.Date, pDateToMove.AddDays(-1),
                                waterInput.CropIrrigationWeatherId.ToString(),
                                (int)Utils.NoIrrigationReason.MoveIrrigation,
                                observation);

                    lDatabaseChangeResult = lContext.SaveChanges();
                }
                else
                {
                    // Not implemented yet.
                }


                return Content("Ok");

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.MoveIrrigation ");
                return Json(ex.Message, JsonRequestBehavior.AllowGet);
            }
        }

        /// <summary>
        /// TODO: Description of GetStagesBy
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <returns></returns>
        public JsonResult GetStagesBy(long pCropIrrigationWeatherId)
        {

            StageConfiguration st = new StageConfiguration();
            List<StageViewModel> lStageViewModelList = new List<StageViewModel>();

            IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
            List<Stage> lStageResult = null;

            //irrigationUnit
            try
            {
                CropIrrigationWeather ciw = lContext.CropIrrigationWeathers.Where(c => c.CropIrrigationWeatherId == pCropIrrigationWeatherId).FirstOrDefault();

                Stage foundStage = lContext.Stages.Where(s => s.StageId == ciw.PhenologicalStage.StageId).FirstOrDefault();

                if (ciw != null)
                {
                    if (foundStage != null)
                    {
                        lStageResult = st.GetStageBy(ciw.Crop.SpecieId, foundStage.Order);

                        if (lStageResult != null)
                        {
                            foreach (var stageItem in lStageResult)
                            {

                                StageViewModel stageViewModel = new StageViewModel
                                {
                                    Description = stageItem.Description,
                                    Name = stageItem.Name,
                                    order = stageItem.Order,
                                    ShortName = stageItem.ShortName,
                                    StageId = stageItem.StageId
                                };

                                lStageViewModelList.Add(stageViewModel);
                            }
                        }
                        else
                        {
                            logger.Warn("No se ha podido encontrar un stage en el método GetStageBy en el método {0}", MethodBase.GetCurrentMethod().Name);
                        }
                    }
                    else
                    {
                        logger.Warn("No se ha podido encontrar el StageId = {0} en el método {1}", ciw.PhenologicalStage.StageId, MethodBase.GetCurrentMethod().Name);
                    } 
                }
                else
                {
                    logger.Warn("No se ha podido encontrar el CropIrrigationWeatherId = {0} en el método {1}", pCropIrrigationWeatherId, MethodBase.GetCurrentMethod().Name);
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetStagesBy");
            }

            return Json(lStageResult, JsonRequestBehavior.AllowGet);
        }


        /// <summary>
        /// Change the Date of Reference
        /// </summary>
        /// <param name="pDay"></param>
        /// <param name="pMonth"></param>
        /// <param name="pYear"></param>
        /// <returns></returns>
        public ActionResult ChangeDateOfReference(int pDay, int pMonth, int pYear, int pFarmId)
        {

            DateTime newDateOfReference = new DateTime(pYear, pMonth, pDay);

            try
            {
                ManageSession.SetNavigationDate(newDateOfReference);

                if (pFarmId > -1)
                {
                    return Content("./home?farm=" + pFarmId);
                }
                else
                {
                    return Content("./home");
                }

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.ChangeDateOfReference ");
                return Content(ex.Message);
            }

        }

        public ActionResult ReturnText()
        {
            return Content("Ok");
        }

        [CustomAuthorize]
        public ActionResult HomeAuth()
        {
            return View("Home");
        }

        public ActionResult Company()
        {
            return View();
        }

        private MailMessage GetMailMessage(string subject, string body, string pEmailTo = null)
        {
            MailMessage mail = new MailMessage();
            string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
            string emailTo = pEmailTo == null ? Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailTo"]) : pEmailTo;

            mail.From = new MailAddress(emailFrom);
            mail.To.Add(emailTo);
            mail.Subject = subject;
            body = body.Replace("[br]", "<br>");
            mail.Body = body;
            mail.IsBodyHtml = true;

            return mail;
        }

        private SmtpClient GetSmtpClient()
        {
            string smtpAddress = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["smtpAddress"]);
            int portNumber = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
            bool enableSSL = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ssl"]);
            string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
            string password = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["password"]);

            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);

            smtp.Credentials = new NetworkCredential(emailFrom, password);
            smtp.EnableSsl = enableSSL;

            return smtp;
        }


        /// <summary>
        /// TODO: Description of SendEmails
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public ActionResult SendEmails(string subject, string body, string pEmail = null)
        {
            try
            {

                SmtpClient smtp = GetSmtpClient();
                MailMessage mail = GetMailMessage(subject, body, pEmail);

                smtp.Send(mail);

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.SendEmails ");
                return Content(ex.Message);
            }


            return Content("Ok");
        }

        public ActionResult LogOut()
        {
            long userAccessId = ManageSession.GetUserAccess();
            RegisterLogOut(userAccessId);

            ManageSession.CleanSession();

            // discard changes
            IrrigationAdvisorContext.Refresh();

            return View("Index", new LoginViewModel());
        }
        
        /// <summary>
        /// Add a day to the Date of Reference
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddDateOfReference()
        {
            DateTime date = ManageSession.GetNavigationDate();
            date = date.AddDays(1);
            ManageSession.SetNavigationDate(date);
            LoginViewModel lvm = ManageSession.GetLoginViewModel();

            return RedirectToAction("Home");
        }

        private void ProcessInformationToIrrigationUnits(List<CropIrrigationWeather> pCropIrrigationWeatherList, DateTime pDateOfReference, DateTime pToday)
        {
            IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
            int lDatabaseChangeResult = 0;

            if (pCropIrrigationWeatherList != null)
            {
                foreach (CropIrrigationWeather lCIW in pCropIrrigationWeatherList)
                {
                    //If Error, continue with others CIWs
                    try
                    {

                        logger.Info("CalculateAllActiveCropIrrigationWeather: CIWid=" + lCIW.CropIrrigationWeatherId +
                                    " - DateOfReference=" + pDateOfReference +
                                    " - Today=" + pToday + "");
                        lCIW.AddInformationToIrrigationUnits(pDateOfReference, pToday, lContext);
                        lDatabaseChangeResult = lContext.SaveChanges();

                    }
                    catch (Exception ex)
                    {
                        Utils.LogError(ex, "Exception in HomeController.CalculateAllActiveCropIrrigationWeather ");
                        continue;
                    }
                } 
            }
            else
            {
                logger.Error("Exception in HomeController.ProcessInformationToIrrigationUnits pCropIrrigationWeatherList is null");
            }
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

        /// <summary>
        /// Add Irrigation to Irrigatoin Unit by Date and Milimiters of water
        /// </summary>
        /// <param name="pMilimeters"></param>
        /// <param name="pIrrigationUnitId"></param>
        /// <param name="pDay"></param>
        /// <param name="pMonth"></param>
        /// <param name="pYear"></param>
        /// <param name="ignoreSession"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddIrrigation(double pMilimeters, 
                                          int pIrrigationUnitId,
                                          int pDay, 
                                          int pMonth, 
                                          int pYear, 
                                          bool pIsFertigation, 
                                          bool ignoreSession = false)
        {
            #region local variables
            String lSomeData = "";
            bool lIsExtraIrrigation = true;
            DateTime lDateResult;
            DateTime lReferenceDate;
            string lObservations = pIsFertigation ? "Fertigation" : "Add Irrigation OK.";

            IrrigationAdvisorContext lIrrigationAdvisorContext;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration;
            IrrigationUnit lIrrigationUnit = null;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;

            int lSaveChanges = 0;
            #endregion

            HomeViewModel lHomeViewModel = null;
            try
            {

                // The ignoreSession variable is created for the compatibility with the web api and the external calls.
                // I suggest that exists new methods to add rain and irrigation.
                if (!ignoreSession)
                {
                    lSomeData = lSomeData + " UserName: " + ManageSession.GetUserName() + "-";
                    lSomeData = lSomeData + " NavigationDate: " + ManageSession.GetNavigationDate() + "-";
                    lSomeData = lSomeData + " DefaultFarmName: " + ManageSession.GetHomeViewModel().DefaultFarmViewModel.Name + "-";

                    lHomeViewModel = ManageSession.GetHomeViewModel();
                }
                      
                lDateResult = new DateTime(pYear, pMonth, pDay);
                lReferenceDate = Utils.GetDateOfReference().Value;

                lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();

                if (!ignoreSession)
                {
                    ManageSession.SetFromDateTime(lDateResult);
                }
                
                if (pIrrigationUnitId > -1)
                {
                    lIrrigationUnit = lIrrigationAdvisorContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == pIrrigationUnitId).FirstOrDefault();
                    lCropIrrigationWeatherList = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);

                    foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                    {
                        lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lDateResult, new Pair<double, Utils.WaterInputType>(pMilimeters, Utils.WaterInputType.Irrigation), 
                                                                                lIsExtraIrrigation, Utils.NoIrrigationReason.Other, lObservations);
                        lSaveChanges = lIrrigationAdvisorContext.SaveChanges();
                        
                        if (pMilimeters >= 0)
                        {
                            lCropIrrigationWeather.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lIrrigationAdvisorContext);
                            lSaveChanges = lIrrigationAdvisorContext.SaveChanges();
                        }
                    }
                    lSaveChanges = lIrrigationAdvisorContext.SaveChanges();
                }
                else if (!ignoreSession)
                {
                    foreach (IrrigationUnitViewModel lIrrigationUnitViewModel in lHomeViewModel.IrrigationUnitViewModelList)
                    {
                        lIrrigationUnit = lIrrigationAdvisorContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == lIrrigationUnitViewModel.IrrigationUnitId).FirstOrDefault();
                        lCropIrrigationWeatherList = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);

                        foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                        {
                            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lDateResult, new Pair<double, Utils.WaterInputType>(pMilimeters, Utils.WaterInputType.Irrigation),
                                                                                lIsExtraIrrigation, Utils.NoIrrigationReason.Other, lObservations);
                            lSaveChanges = lIrrigationAdvisorContext.SaveChanges();

                            if (pMilimeters > 0)
                            {
                                lCropIrrigationWeather.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lIrrigationAdvisorContext);
                                lSaveChanges = lIrrigationAdvisorContext.SaveChanges();
                            }
                        }
                        lSaveChanges = lIrrigationAdvisorContext.SaveChanges();
                    }
                }

                // Change navigation date of reference
                // When the user add an irrigation the navigation date changes by the date of reference from the database
                if (!ignoreSession)
                {
                    ManageSession.SetNavigationDate(lReferenceDate);
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.AddIrrigation - {0} ", lSomeData);
                return Content("Exception in HomeController.AddIrrigation " + "\n" + ex.Message + "\n" + lSomeData);
            }

            return Content("Ok");
        }

        /// <summary>
        /// Add Rain to Irrigatoin Unit by Date and Milimiters of water
        /// </summary>
        /// <param name="pMilimeters"></param>
        /// <param name="pIrrigationUnitId"></param>
        /// <param name="pDay"></param>
        /// <param name="pMonth"></param>
        /// <param name="pYear"></param>
        /// <param name="pIgnoreSession">Parametero to avoid session sentences.</param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult AddRain(double pMilimeters, long pIrrigationUnitId,
                                    int pDay, int pMonth, int pYear, bool pIgnoreSession = false)
        {

            #region local variables

            String lSomeData = "";
            DateTime lDateResult;
            DateTime lReferenceDate;
            IrrigationAdvisorContext lContext;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration;
            IrrigationUnit lIrrigationUnit = null;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;
            int lSaveChanges = 0;

            HomeViewModel lHomeViewModel = null;

            #endregion

            try
            {

                // The ignoreSession variable is created for the compatibility with the web api and the external calls.
                // I suggest that exists new methods to add rain and irrigation.
                if (!pIgnoreSession)
                {
                    lSomeData = lSomeData + " UserName: " + ManageSession.GetUserName() + "-";
                    lSomeData = lSomeData + " NavigationDate: " + ManageSession.GetNavigationDate() + "-";
                    lSomeData = lSomeData + " DefaultFarmName: " + ManageSession.GetHomeViewModel().DefaultFarmViewModel.Name + "-";

                    lHomeViewModel = ManageSession.GetHomeViewModel();
                }
                

                lDateResult = new DateTime(pYear, pMonth, pDay);
                lReferenceDate = Utils.GetDateOfReference().Value;

                lContext = IrrigationAdvisorContext.Instance();
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();

                if(!pIgnoreSession)
                {
                    ManageSession.SetFromDateTime(lDateResult);
                }
                

                if (pIrrigationUnitId > -1)
                {
                    lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == pIrrigationUnitId).FirstOrDefault();
                    lCropIrrigationWeatherList = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);

                    foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
                    {
                        lCropIrrigationWeather.AddRainDataToList(lDateResult, pMilimeters);
                        lSaveChanges = lContext.SaveChanges();

                        lCropIrrigationWeather.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lContext);
                        lSaveChanges = lContext.SaveChanges();
                    }
                    lSaveChanges = lContext.SaveChanges();
                }
                else if (!pIgnoreSession)
                {
                    foreach (IrrigationUnitViewModel lIrrigationUnitViewModel in lHomeViewModel.IrrigationUnitViewModelList)
                    {
                        lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == lIrrigationUnitViewModel.IrrigationUnitId).FirstOrDefault();
                        lCropIrrigationWeatherList = lIrrigationUnitConfiguration.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);

                        foreach (var lCIW in lCropIrrigationWeatherList)
                        {
                            lCIW.AddRainDataToList(lDateResult, pMilimeters);
                            lSaveChanges = lContext.SaveChanges();

                            lCIW.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lContext);
                            lSaveChanges = lContext.SaveChanges();
                        }
                        lSaveChanges = lContext.SaveChanges();
                    }
                }

                // Change navigation date of reference
                // When the user add an irrigation the navigation date changes by the date of reference from the database
                if (!pIgnoreSession)
                {
                    ManageSession.SetNavigationDate(lReferenceDate);
                }
                
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.AddRain - {0} ", lSomeData);
                return Content("Exception in HomeController.AddRain " + "\n" + ex.Message + "\n" + lSomeData);
            }
            
            return Content("Ok");
        }

        private void AddOrUpdateIrrigationDataToListForCantIrrigate(DateTime pDateFrom, DateTime pDateTo, CropIrrigationWeather pCropIrrigationWeather,
                                                                    Utils.NoIrrigationReason pReason, String pObservations) //IrrigationAdvisorContext pContext, 
        {
            DateTime lDateIterator = pDateFrom;
            DateTime lReferenceDate = Utils.GetDateOfReference().Value;
            bool lIsExtraIrrigation = true;
            //int lDatabaseChangeResult = 0;

            while (lDateIterator <= pDateTo)
            {
                pCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lDateIterator, new Pair<double, Utils.WaterInputType>(0, Utils.WaterInputType.CantIrrigate), 
                                                                        lIsExtraIrrigation, pReason, pObservations);
                lDateIterator = lDateIterator.AddDays(1);
            }

            //lDatabaseChangeResult = pContext.SaveChanges();

            lDateIterator = pDateFrom;

            ////while (lDateIterator <= pDateTo)
            ////{
            ////    pCIW.AddInformationToIrrigationUnits(lDateIterator, lReferenceDate, pContext);
            ////    pContext.SaveChanges();
            ////    lDateIterator = lDateIterator.AddDays(1);
            ////}

            
        }

        [HttpGet]
        public ActionResult NoIrri()
        {
            AddNoIrrigation(new DateTime(2017, 1, 4), new DateTime(2017, 1, 5), "1", 1, "Test Observations");
            return Content("Ok");
        }

        [HttpGet]
        public ActionResult AddNoIrrigation(DateTime pDateFrom, DateTime pDateTo,
                                            String pCropIrrigationWeatherList, int pReasonId, 
                                            String pObservations, bool ignoreSession = false)
        {
            #region local variables
            HomeViewModel lHomeViewModel = null;
            string lSomeData = string.Empty;
            Utils.NoIrrigationReason lReason;
            DateTime lReferenceDate;
            IrrigationAdvisorContext lIrrigationAdvisorContext;
            IrrigationUnitConfiguration lIrrigationUnitConfiguration ;
            CropIrrigationWeatherConfiguration lCropIrrigationWeatherConfiguration;
            List<long> lSelectedCropIrrigationWeather;
            List<CropIrrigationWeather> lFilteredCropIrrigationWeather;
            int lDatabaseChangeResult;
            string lFarmIdFromURL;
            long lFarmId;
            DateTime lCalculateFrom;
            DateTime lCalculateTo;

            #endregion

            try
            {
                if (!ignoreSession)
                {
                    lSomeData = lSomeData + " UserName: " + ManageSession.GetUserName() + "-";
                    lSomeData = lSomeData + " NavigationDate: " + ManageSession.GetNavigationDate() + "-";
                    lSomeData = lSomeData + " DefaultFarmName: " + ManageSession.GetHomeViewModel().DefaultFarmViewModel.Name + "-";

                    lHomeViewModel = ManageSession.GetHomeViewModel();
                }

                lReferenceDate = Utils.GetDateOfReference().Value;
                lReason = (Utils.NoIrrigationReason)pReasonId;

                lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();
                lIrrigationUnitConfiguration = new IrrigationUnitConfiguration();
                lCropIrrigationWeatherConfiguration = new CropIrrigationWeatherConfiguration();

                lDatabaseChangeResult = 0;

                lSelectedCropIrrigationWeather = (from p in pCropIrrigationWeatherList.Split(',').ToList()
                                                 select Convert.ToInt64(p)).ToList();

                lFilteredCropIrrigationWeather = lCropIrrigationWeatherConfiguration.GetCropIrrigationWeatherByIds(lSelectedCropIrrigationWeather, lReferenceDate);

                foreach (CropIrrigationWeather lCropIrrigationWeather in lFilteredCropIrrigationWeather)
                {
                    AddOrUpdateIrrigationDataToListForCantIrrigate(pDateFrom, pDateTo, lCropIrrigationWeather, lReason, pObservations);
                    lDatabaseChangeResult = lIrrigationAdvisorContext.SaveChanges();
                }

                lFarmIdFromURL = Utils.GetUrlParameter("farm");

                lFarmId = 0;

                if (lFarmIdFromURL != null)
                {
                    lFarmId = Convert.ToInt32(lFarmIdFromURL);
                }
                else
                {
                    lFarmId = GetFarmsByUserAsList().First().FarmId;
                }
                //Date not to be later than Date of Reference
                if(pDateFrom < lReferenceDate)
                {
                    lCalculateFrom = pDateFrom;
                }
                else
                {
                    lCalculateFrom = lReferenceDate;
                }

                //Date not to be later than Date of Reference
                if (pDateTo < lReferenceDate)
                {
                    lCalculateTo = pDateTo;
                }
                else
                {
                    lCalculateTo = lReferenceDate;
                }

                foreach (CropIrrigationWeather lCropIrrigationWeather in lFilteredCropIrrigationWeather)
                {
                    this.CalculateCropIrrigationWeather(lCropIrrigationWeather.CropIrrigationWeatherId, lCalculateFrom, lCalculateTo);
                }
                // Change navigation date of reference
                // When the user add an irrigation the navigation date changes by the date of reference from the database
                if (!ignoreSession)
                {
                    ManageSession.SetNavigationDate(lReferenceDate);
                }
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.AddNoIrrigation - {0} ", lSomeData);
                return Content("Exception in HomeController.AddNoIrrigation " + "\n" + ex.Message + "\n" + lSomeData);
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

        [ChildActionOnly]
        public PartialViewResult WeatherPartial()
        {
            return PartialView("_WeatherPartial", GetWeatherDataFromWUnderground());
        }

        public PartialViewResult WeatherHomePartial()
        {
            return PartialView("_WeatherHomePartial", GetWeatherDataFromWUndergroundHome());
        }

        [ChildActionOnly]
        public PartialViewResult LoginHomePartial()
        {

            if (ManageSession.GetUserName() == null)
            {
                return PartialView("_LoginHomePartial", new LoginViewModel());
            }

            Authentication auth = new Authentication(ManageSession.GetUserName(), ManageSession.GetUserPassword());
            LoginViewModel login = new LoginViewModel();
            if (!auth.IsAuthenticated())
            {
                login.InvalidPasswordMessage = AUTHENTICATION_ERROR;
            }

            return PartialView("_LoginHomePartial", login);
        }

        /// <summary>
        /// Generate Menu
        /// </summary>
        /// <returns></returns>
        public PartialViewResult GenerateMenu()
        {

            MenuViewModel menuVM = new MenuViewModel();

            string lLoggedUser = ManageSession.GetUserName();

            if (lLoggedUser != null)
            {
                UserConfiguration uc = new UserConfiguration();
                User user = uc.GetUserByName(lLoggedUser);

                bool lIsOnline = Utils.IsOnline(System.Configuration.ConfigurationManager.AppSettings["Status"]);

                if (user != null && user.RoleId == (int)Utils.UserRoles.Administrator && lIsOnline)
                    menuVM.IsAdministrator = true;
                else
                    menuVM.IsAdministrator = false; 
            }
            else
            {
                menuVM.IsAdministrator = false;
            }

            return PartialView("_GenerateMenu", menuVM);
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView("_ContactPartial");
        }

        public PartialViewResult _Create(string contact_name)
        {
            return PartialView("_ContactPartial");
        }

        /// <summary>
        /// Login User Name & Password
        /// </summary>
        /// <param name="pUserName"></param>
        /// <param name="pPassWord"></param>
        /// <returns></returns>
        private bool Login(string pUserName, string pPassWord)
        {
            bool lResult = false;
            try
            {
                Authentication lAuthentication = new Authentication(pUserName, pPassWord);

                if (lAuthentication.IsAuthenticated())
                {
                    lResult = true;
                }

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.Login ");
            }

            return lResult;

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
        /// Change phenology.
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pStageId"></param>
        public void ChangePhenology(long pCropIrrigationWeatherId, long pStageId)
        {
            var lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();

            var lCropIrrigationWeather = lIrrigationAdvisorContext.CropIrrigationWeathers
                                         .Include(n => n.Crop)
                                         .Where(n => n.CropIrrigationWeatherId == pCropIrrigationWeatherId)
                                         .First();

            DateTime referenceDate = ManageSession.GetNavigationDate().Date;

            var lDailyRecord = lIrrigationAdvisorContext
                                .DailyRecords
                                .Where(n => n.DailyRecordDateTime == referenceDate && n.CropIrrigationWeatherId == pCropIrrigationWeatherId)
                                .First();

            var crop = lIrrigationAdvisorContext.Crops.First(n => n.CropId == lCropIrrigationWeather.CropId);

            var stage = lIrrigationAdvisorContext
                                    .Stages
                                    .Where(n => n.StageId == pStageId)
                                    .First();

            var phenologicalStage = lIrrigationAdvisorContext.PhenologicalStages.First(n => n.StageId == stage.StageId && n.SpecieId == crop.SpecieId);

            ChangePhenology(lCropIrrigationWeather, 
                            lDailyRecord,
                            phenologicalStage);        
        }

        /// <summary>
        /// Change phenology.
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDailyRecord"></param>
        /// <param name="pPhenologicalStage"></param>
        private void ChangePhenology(CropIrrigationWeather pCropIrrigationWeather, 
                                     DailyRecord pDailyRecord, 
                                     PhenologicalStage pPhenologicalStage)
        {
            string lSomeData = string.Format("pCropIrrigationWeatherId: {0}, pDailyRecordId: {1}, pPhenologicalStageId: {2}", 
                                                pCropIrrigationWeather.CropIrrigationWeatherId, 
                                                pDailyRecord.DailyRecordId,
                                                pPhenologicalStage.PhenologicalStageId);
            try
            {
                var lIrrigationAdvisorContext = IrrigationAdvisorContext.Instance();

                double lGrowingDegreeDays = (pPhenologicalStage.MaxDegree + pPhenologicalStage.MinDegree) / 2;

                pDailyRecord.PhenologicalStageId = pPhenologicalStage.PhenologicalStageId;
                pDailyRecord.GrowingDegreeDaysModified = lGrowingDegreeDays;
                pDailyRecord.GrowingDegreeDaysAccumulated = lGrowingDegreeDays;

                pCropIrrigationWeather.GrowingDegreeDaysAccumulated = lGrowingDegreeDays;
                pCropIrrigationWeather.GrowingDegreeDaysModified = lGrowingDegreeDays;
                pCropIrrigationWeather.PhenologicalStageId = pPhenologicalStage.PhenologicalStageId;

                var adjustment = new PhenologicalStageAdjustment()
                {
                    CropId = pCropIrrigationWeather.CropId,
                    DateOfChange = ManageSession.GetNavigationDate(),
                    PhenologicalStageId = pPhenologicalStage.PhenologicalStageId,
                    StageId = pPhenologicalStage.StageId,
                    CropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId
                };

                lIrrigationAdvisorContext.PhenologicalStageAdjustments.Add(adjustment);

                lIrrigationAdvisorContext.SaveChanges();
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.ChangePhenology \n {0} ", lSomeData);
                throw ex;
            }
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
                        lIrrigationQuantity = lDailyRecord.Irrigation.Input;
                    }
                    else if (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.ExtraInput > 0)
                    {
                        lForcastIrrigationQuantity += lDailyRecord.Irrigation.ExtraInput;
                        lIrrigationQuantity = lDailyRecord.Irrigation.ExtraInput;
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
                else if (lForcastIrrigationQuantity > 0 && lForcastIrrigationQuantity > lRainQuantity)
                {
                    lIrrigationStatus = Utils.IrrigationStatus.NextIrrigation;
                }
                else if (lIrrigationQuantity > 0 && lIrrigationQuantity > lRainQuantity)
                {
                    lIrrigationStatus = Utils.IrrigationStatus.Irrigated;
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

        #region Weather

        /// <summary>
        /// Get Weather Data from WUnderground to show in the Index Page
        /// </summary>
        /// <returns></returns>
        public WeatherDataToShow GetWeatherDataFromWUnderground()
        {
            #region Local Variables
            WeatherDataToShow lReturn = null;

            User lLoggedUser;
            List<Farm> lFarmList;
            Farm lCurrentFarm;
            long lPositionId;
            String lLatitude;
            String lLongitude;
            String lLinkAPIWUnderground;
            UserConfiguration uc;
            FarmConfiguration fc;

            WeatherDataToShow lWeatherDataToShow;
            List<WeatherDataItem> lWeatherDataItemList;

            String lCity = String.Empty;
            String lURLImage = String.Empty;
            String lConditions = String.Empty;
            String lAverageTemperature = String.Empty;
            String lDay = String.Empty;
            String lSunriseTime = String.Empty;
            String lSunsetTime = String.Empty;
            String lTempHigh = String.Empty;
            String lTempLow = String.Empty;
            String lRelativeHumidity = String.Empty;
            String lAverageWind = String.Empty;
            String lPressure = String.Empty;
            String lVisibility = String.Empty;
            String lDewPoint = String.Empty;

            String lItemTempHigh = String.Empty;
            String lItemTempLow = String.Empty;
            String lItemMonth = String.Empty;
            String lItemWeekday = String.Empty;
            String lItemURLImage = String.Empty;
            String lItemDescription = String.Empty;
            String lItemProbabilityRain = String.Empty;
            String lItemRainMM = String.Empty;

            String lAPIWUndergroundBase;
            String lAPIWUndergroundKey;
            String lAPIWUndergroundForcast10Days;
            String lAPIWUndergroundConditions;
            String lAPIWUndergroundAstronomy;
            String lAPIWUnderground;
            HttpWebRequest lHttpWebRequest;
            string lJson;
            WUndergroundForecast10daysResultToCSharp.RootObject lJsonObjForcast10Days;
            WUndergroundConditionsResultToCSharp.RootObject lJsonObjConditions;
            WUndergroundAstronomyResultToCSharp.RootObject lJsonObjAstronomy;
            string lURL;

            Uri lMyUri;
            int lToday = 0;

            bool lCantGetWeatherData = false;

            #endregion

            #region Configuration - Instance
            uc = new UserConfiguration();
            fc = new FarmConfiguration();
            #endregion

            try
            {
                //Obtain logged user
                lLoggedUser = uc.GetUserByName(ManageSession.GetUserName());

                #region Get Latitude, Longitude
                if (lLoggedUser != null)
                {
                    //Get list of Farms from User
                    lFarmList = fc.GetFarmWithActiveCropIrrigationWeathersListBy(lLoggedUser);

                    lCurrentFarm = GetCurrentFarm(lFarmList);
                    lPositionId = lCurrentFarm.PositionId;

                    lLatitude = fc.GetLatitudeBy(lPositionId).ToString().Replace(",", ".");
                    lLongitude = fc.GetLongitudeBy(lPositionId).ToString().Replace(",", ".");
                }
                else
                {
                    lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
                    lMyUri = new Uri(lURL);
                    lLatitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("latitude");
                    if (String.IsNullOrEmpty(lLatitude))
                    {
                        lCantGetWeatherData = true;
                        lLatitude = "-34.8172490";
                    }
                    else
                    {
                        lLatitude.Replace(",", ".");
                    }
                    lLongitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("longitude");
                    if (String.IsNullOrEmpty(lLongitude))
                    {
                        lCantGetWeatherData = true;
                        lLongitude = "-56.1590040";
                    }
                    else
                    {
                        lLongitude.Replace(",", ".");
                    }
                }
                #endregion

                lAPIWUndergroundBase = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIbase"]);
                lAPIWUndergroundKey = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIkeyIndex"]);
                lAPIWUndergroundForcast10Days = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIforcast10days"]);
                lAPIWUndergroundConditions = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIconditions"]);
                lAPIWUndergroundAstronomy = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIastronomy"]);

                if (lCantGetWeatherData)
                {
                    lWeatherDataToShow = null;
                }
                else
                {

                    lWeatherDataItemList = new List<WeatherDataItem>();

                    #region Request Forcast 10 days
                    try
                    {
                        lAPIWUnderground = lAPIWUndergroundBase + lAPIWUndergroundKey + lAPIWUndergroundForcast10Days;
                        lLinkAPIWUnderground = lAPIWUnderground + lLatitude + "," + lLongitude + ".json";
                        lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                        lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                        lHttpWebRequest.Accept = "application/json";
                        var lResponseForcast10Days = (HttpWebResponse)lHttpWebRequest.GetResponse();

                        lJson = string.Empty;
                        using (var sr = new StreamReader(lResponseForcast10Days.GetResponseStream()))
                        {
                            lJson = sr.ReadToEnd();
                        }

                        // Json To C#  DeserializeJsno to IrrigationAdvisor.ViewModels.Weather.WUndergroundForecast10daysResultToCSharp.RootObject
                        lJsonObjForcast10Days = JsonConvert.DeserializeObject<WUndergroundForecast10daysResultToCSharp.RootObject>(lJson);

                        //Data of Forcast 10 days
                        // Iterate ForecastDay
                        foreach (var item in lJsonObjForcast10Days.forecast.simpleforecast.forecastday)
                        {
                            lToday++;
                            if (lToday > 1 && lWeatherDataItemList.Count <= 2)
                            {
                                lItemTempHigh = item.high.celsius;
                                lItemTempLow = item.low.celsius;
                                lItemMonth = item.date.month.ToString();
                                lItemWeekday = item.date.weekday;
                                lItemURLImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                                lItemDescription = item.conditions;
                                lItemProbabilityRain = item.pop.ToString();
                                lItemRainMM = item.qpf_allday.mm.ToString();
                                lWeatherDataItemList.Add(new WeatherDataItem(lItemTempHigh, lItemTempLow,
                                                                            lItemMonth, lItemWeekday,
                                                                            lItemURLImage, lItemDescription,
                                                                            lItemProbabilityRain, lItemRainMM));
                            }
                            else if (lToday > 2)
                            {
                                break;
                            }
                        }
                        lToday = 0;
                        lURLImage = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].icon_url;
                        lConditions = lJsonObjForcast10Days.forecast.txt_forecast.forecastday[lToday].fcttext_metric;
                        lDay = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].date.weekday;
                        lTempHigh = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].high.celsius.ToString();
                        lTempLow = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].low.celsius.ToString();
                        lAverageWind = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].avewind.kph.ToString();
                        lRelativeHumidity = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].avehumidity.ToString();
                    }
                    catch (Exception ex)
                    {
                        lCantGetWeatherData = true;
                        //Do nothing
                        logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                    }
                    #endregion

                    #region Conditions
                    try
                    {
                        lAPIWUnderground = lAPIWUndergroundBase + lAPIWUndergroundKey + lAPIWUndergroundConditions;
                        lLinkAPIWUnderground = lAPIWUnderground + lLatitude + "," + lLongitude + ".json";
                        lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                        lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                        lHttpWebRequest.Accept = "application/json";
                        var lResponseConditions = (HttpWebResponse)lHttpWebRequest.GetResponse();

                        lJson = string.Empty;
                        using (var sr = new StreamReader(lResponseConditions.GetResponseStream()))
                        {
                            lJson = sr.ReadToEnd();
                        }

                        lJsonObjConditions = JsonConvert.DeserializeObject<WUndergroundConditionsResultToCSharp.RootObject>(lJson);

                        //Data of Conditions
                        lCity = lJsonObjConditions.current_observation.display_location.full;
                        lRelativeHumidity = lJsonObjConditions.current_observation.relative_humidity;
                        lPressure = lJsonObjConditions.current_observation.pressure_mb;
                        lVisibility = lJsonObjConditions.current_observation.visibility_km;
                        lDewPoint = lJsonObjConditions.current_observation.dewpoint_c.ToString();
                        lAverageTemperature = lJsonObjConditions.current_observation.temp_c.ToString();
                    }
                    catch (Exception ex)
                    {
                        lCantGetWeatherData = true;
                        //Do nothing
                        logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                    }
                    #endregion

                    #region Astronomy
                    try
                    {
                        lAPIWUnderground = lAPIWUndergroundBase + lAPIWUndergroundKey + lAPIWUndergroundAstronomy;
                        lLinkAPIWUnderground = lAPIWUnderground + lLatitude + "," + lLongitude + ".json";
                        lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                        lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                        lHttpWebRequest.Accept = "application/json";
                        var lResponseAstronomy = (HttpWebResponse)lHttpWebRequest.GetResponse();

                        lJson = string.Empty;
                        using (var sr = new StreamReader(lResponseAstronomy.GetResponseStream()))
                        {
                            lJson = sr.ReadToEnd();
                        }

                        // Json To C#  DeserializeJsno to IrrigationAdvisor.ViewModels.Weather.WUndergroundAstronomyResultToCSharp.RootObject
                        lJsonObjAstronomy = JsonConvert.DeserializeObject<WUndergroundAstronomyResultToCSharp.RootObject>(lJson);

                        lSunriseTime = lJsonObjAstronomy.moon_phase.sunrise.hour.ToString() + ":" + lJsonObjAstronomy.moon_phase.sunrise.minute.ToString();
                        lSunsetTime = lJsonObjAstronomy.moon_phase.sunset.hour.ToString() + ":" + lJsonObjAstronomy.moon_phase.sunset.minute.ToString();

                    }
                    catch (Exception ex)
                    {
                        lCantGetWeatherData = true;
                        //Do nothing
                        logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                    }
                    #endregion

                    if (lCantGetWeatherData)
                    {
                        lWeatherDataToShow = null;
                    }
                    else
                    {
                        lWeatherDataToShow = new WeatherDataToShow(lCity, lURLImage, lConditions, lAverageTemperature,
                                                        lDay, lSunriseTime, lSunsetTime, lTempHigh, lTempLow, lRelativeHumidity,
                                                        lAverageWind, lPressure, lVisibility, lDewPoint, lWeatherDataItemList);
                    }
                }

                lReturn = lWeatherDataToShow;

            }
            catch (System.InvalidOperationException ex)
            {
                logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                //throw ex;
            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetWeatherDataFromWUnderground ");
                throw ex;
            }

            return lReturn;
        }

        /// <summary>
        /// Get Weather Data from WUnderground to show in the Home Page
        /// </summary>
        /// <returns></returns>
        public WeatherDataToShow GetWeatherDataFromWUndergroundHome()
        {
            #region Local Variables
            WeatherDataToShow lReturn = null;

            User lLoggedUser;
            List<Farm> lFarmList;
            Farm lCurrentFarm;
            long lPositionId;
            String lLatitude;
            String lLongitude;
            String lLinkAPIWUnderground;
            UserConfiguration uc;
            FarmConfiguration fc;

            WeatherDataToShow lWeatherDataToShow;
            List<WeatherDataItem> lWeatherDataItemList;

            String lCity = String.Empty;
            String lURLImage = String.Empty;
            String lConditions = String.Empty;
            String lAverageTemperature = String.Empty;
            String lDay = String.Empty;
            String lSunriseTime = String.Empty;
            String lSunsetTime = String.Empty;
            String lTempHigh = String.Empty;
            String lTempLow = String.Empty;
            String lRelativeHumidity = String.Empty;
            String lAverageWind = String.Empty;
            String lPressure = String.Empty;
            String lVisibility = String.Empty;
            String lDewPoint = String.Empty;

            String lItemTempHigh = String.Empty;
            String lItemTempLow = String.Empty;
            String lItemMonth = String.Empty;
            String lItemWeekday = String.Empty;
            String lItemURLImage = String.Empty;
            String lItemDescription = String.Empty;
            String lItemProbabilityRain = String.Empty;
            String lItemRainMM = String.Empty;

            String lAPIWUndergroundBase;
            String lAPIWUndergroundKey;
            String lAPIWUndergroundForcast10Days;
            String lAPIWUndergroundConditions;
            String lAPIWUndergroundAstronomy;
            String lAPIWUnderground;
            HttpWebRequest lHttpWebRequest;
            string lJson;
            WUndergroundForecast10daysResultToCSharp.RootObject lJsonObjForcast10Days;
            WUndergroundConditionsResultToCSharp.RootObject lJsonObjConditions;
            WUndergroundAstronomyResultToCSharp.RootObject lJsonObjAstronomy;
            string lURL;

            Uri lMyUri;
            int lToday = 0;

            bool lCantGetWeatherData = false;

            #endregion

            #region Configuration - Instance
            uc = new UserConfiguration();
            fc = new FarmConfiguration();
            #endregion

            try
            {
                //Obtain logged user
                lLoggedUser = uc.GetUserByName(ManageSession.GetUserName());

                #region Get Latitude, Longitude
                if (lLoggedUser != null)
                {
                    //Get list of Farms from User
                    lFarmList = fc.GetFarmWithActiveCropIrrigationWeathersListBy(lLoggedUser);

                    lCurrentFarm = GetCurrentFarm(lFarmList);
                    lPositionId = lCurrentFarm.PositionId;

                    lLatitude = fc.GetLatitudeBy(lPositionId).ToString().Replace(",", ".");
                    lLongitude = fc.GetLongitudeBy(lPositionId).ToString().Replace(",", ".");
                }
                else
                {
                    lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
                    lMyUri = new Uri(lURL);
                    lLatitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("latitude");
                    if (String.IsNullOrEmpty(lLatitude))
                    {
                        lCantGetWeatherData = true;
                        lLatitude = "-34.8172490";
                    }
                    else
                    {
                        lLatitude.Replace(",", ".");
                    }
                    lLongitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("longitude");
                    if (String.IsNullOrEmpty(lLongitude))
                    {
                        lCantGetWeatherData = true;
                        lLongitude = "-56.1590040";
                    }
                    else
                    {
                        lLongitude.Replace(",", ".");
                    }
                }
                #endregion

                lAPIWUndergroundBase = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIbase"]);
                lAPIWUndergroundKey = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIkeyHome"]);
                lAPIWUndergroundForcast10Days = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIforcast10days"]);
                lAPIWUndergroundConditions = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIconditions"]);
                lAPIWUndergroundAstronomy = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIastronomy"]);

                if (lCantGetWeatherData)
                {
                    lWeatherDataToShow = null;
                }
                else
                {

                    lWeatherDataItemList = new List<WeatherDataItem>();

                    #region Request Forcast 10 days
                    if (!lCantGetWeatherData)
                    {
                        try
                        {
                            lAPIWUnderground = lAPIWUndergroundBase + lAPIWUndergroundKey + lAPIWUndergroundForcast10Days;
                            lLinkAPIWUnderground = lAPIWUnderground + lLatitude + "," + lLongitude + ".json";
                            lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                            lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                            lHttpWebRequest.Accept = "application/json";
                            var lResponseForcast10Days = (HttpWebResponse)lHttpWebRequest.GetResponse();

                            lJson = string.Empty;
                            using (var sr = new StreamReader(lResponseForcast10Days.GetResponseStream()))
                            {
                                lJson = sr.ReadToEnd();
                            }

                            // Json To C#  DeserializeJsno to IrrigationAdvisor.ViewModels.Weather.WUndergroundForecast10daysResultToCSharp.RootObject
                            lJsonObjForcast10Days = JsonConvert.DeserializeObject<WUndergroundForecast10daysResultToCSharp.RootObject>(lJson);

                            //Data of Forcast 10 days
                            // Iterate ForecastDay
                            foreach (var item in lJsonObjForcast10Days.forecast.simpleforecast.forecastday)
                            {
                                lToday++;
                                if (lToday > 1 && lWeatherDataItemList.Count <= 2)
                                {
                                    lItemTempHigh = item.high.celsius;
                                    lItemTempLow = item.low.celsius;
                                    lItemMonth = item.date.month.ToString();
                                    lItemWeekday = item.date.weekday;
                                    lItemURLImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                                    lItemDescription = item.conditions;
                                    lItemProbabilityRain = item.pop.ToString();
                                    lItemRainMM = item.qpf_allday.mm.ToString();
                                    lWeatherDataItemList.Add(new WeatherDataItem(lItemTempHigh, lItemTempLow,
                                                                                lItemMonth, lItemWeekday,
                                                                                lItemURLImage, lItemDescription,
                                                                                lItemProbabilityRain, lItemRainMM));
                                }
                                else if (lToday > 2)
                                {
                                    break;
                                }
                            }
                            lToday = 0;
                            lURLImage = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].icon_url;
                            lConditions = lJsonObjForcast10Days.forecast.txt_forecast.forecastday[lToday].fcttext_metric;
                            lDay = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].date.weekday;
                            lTempHigh = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].high.celsius.ToString();
                            lTempLow = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].low.celsius.ToString();
                            lAverageWind = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].avewind.kph.ToString();
                            lRelativeHumidity = lJsonObjForcast10Days.forecast.simpleforecast.forecastday[lToday].avehumidity.ToString();
                        }
                        catch (Exception ex)
                        {
                            lCantGetWeatherData = true;
                            //Do nothing
                            logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                        }
                    }
                    #endregion

                    #region Conditions
                    if (!lCantGetWeatherData)
                    {
                        try
                        {
                            lAPIWUnderground = lAPIWUndergroundBase + lAPIWUndergroundKey + lAPIWUndergroundConditions;
                            lLinkAPIWUnderground = lAPIWUnderground + lLatitude + "," + lLongitude + ".json";
                            lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                            lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                            lHttpWebRequest.Accept = "application/json";
                            var lResponseConditions = (HttpWebResponse)lHttpWebRequest.GetResponse();

                            lJson = string.Empty;
                            using (var sr = new StreamReader(lResponseConditions.GetResponseStream()))
                            {
                                lJson = sr.ReadToEnd();
                            }

                            lJsonObjConditions = JsonConvert.DeserializeObject<WUndergroundConditionsResultToCSharp.RootObject>(lJson);

                            //Data of Conditions
                            lCity = lJsonObjConditions.current_observation.display_location.full;
                            lRelativeHumidity = lJsonObjConditions.current_observation.relative_humidity;
                            lPressure = lJsonObjConditions.current_observation.pressure_mb;
                            lVisibility = lJsonObjConditions.current_observation.visibility_km;
                            lDewPoint = lJsonObjConditions.current_observation.dewpoint_c.ToString();
                            lAverageTemperature = lJsonObjConditions.current_observation.temp_c.ToString();
                        }
                        catch (Exception ex)
                        {
                            lCantGetWeatherData = true;
                            //Do nothing
                            logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                        }
                    }
                    #endregion

                    #region Astronomy
                    if (!lCantGetWeatherData)
                    {
                        try
                        {
                            lAPIWUnderground = lAPIWUndergroundBase + lAPIWUndergroundKey + lAPIWUndergroundAstronomy;
                            lLinkAPIWUnderground = lAPIWUnderground + lLatitude + "," + lLongitude + ".json";
                            lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                            lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                            lHttpWebRequest.Accept = "application/json";
                            var lResponseAstronomy = (HttpWebResponse)lHttpWebRequest.GetResponse();

                            lJson = string.Empty;
                            using (var sr = new StreamReader(lResponseAstronomy.GetResponseStream()))
                            {
                                lJson = sr.ReadToEnd();
                            }

                            // Json To C#  DeserializeJsno to IrrigationAdvisor.ViewModels.Weather.WUndergroundAstronomyResultToCSharp.RootObject
                            lJsonObjAstronomy = JsonConvert.DeserializeObject<WUndergroundAstronomyResultToCSharp.RootObject>(lJson);

                            lSunriseTime = lJsonObjAstronomy.moon_phase.sunrise.hour.ToString() + ":" + lJsonObjAstronomy.moon_phase.sunrise.minute.ToString();
                            lSunsetTime = lJsonObjAstronomy.moon_phase.sunset.hour.ToString() + ":" + lJsonObjAstronomy.moon_phase.sunset.minute.ToString();

                        }
                        catch (Exception ex)
                        {
                            lCantGetWeatherData = true;
                            //Do nothing
                            logger.Info(ex, "Exception in HomeController.GetWeatherDataFromWUnderground " + "\n" + ex.Message + "\n" + ex.StackTrace);
                        }
                    }
                    #endregion

                    if (lCantGetWeatherData)
                    {
                        lWeatherDataToShow = null;
                    }
                    else
                    {
                        lWeatherDataToShow = new WeatherDataToShow(lCity, lURLImage, lConditions, lAverageTemperature,
                                                        lDay, lSunriseTime, lSunsetTime, lTempHigh, lTempLow, lRelativeHumidity,
                                                        lAverageWind, lPressure, lVisibility, lDewPoint, lWeatherDataItemList);
                    }
                }

                lReturn = lWeatherDataToShow;

            }
            catch (Exception ex)
            {
                Utils.LogError(ex, "Exception in HomeController.GetWeatherDataFromWUndergroundHome ");
                throw ex;
            }

            return lReturn;
        }


        #endregion
    }
}