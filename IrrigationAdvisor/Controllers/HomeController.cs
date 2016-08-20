using IrrigationAdvisor.Authorize;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.GridHome;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.ViewModels.Home;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.ViewModels.Errors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Management;
using IrrigationAdvisor.DBContext.Water;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.ViewModels.Management;
using IrrigationAdvisor.ViewModels.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Agriculture;
using System.Data.Entity;
using IrrigationAdvisor.DBContext.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.ViewModels.Weather;
using IrrigationAdvisor.ViewModels.Irrigation;

namespace IrrigationAdvisor.Controllers
{

    public class HomeController : Controller
    {
        //TODO: Refactor ErrorClass with code and text
        private const int AUTHENTICATION_ERROR_NR = 10001;
        private const string AUTHENTICATION_ERROR = "Credenciales inválidas";
        private const int NO_FARMS_FOR_USER_NR = 10002;
        private const string NO_FARMS_FOR_USER = "El usuario no tiene granjas asignadas";

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

        public ActionResult Home(LoginViewModel pLoginViewModel)
        {
            Authentication lAuthentication;
            HomeViewModel lHVM;

            #region Configuration Variables
            UserConfiguration uc;
            FarmConfiguration fc;
            BombConfiguration bc;
            IrrigationUnitConfigurarion iuc;
            CropIrrigationWeatherConfiguration ciwc;
            DailyRecordConfiguration drc;
            RainConfiguration rc;
            IrrigationConfiguration ic;
 
            #endregion

            #region Local Variables
            DateTime lDateOfReference;
            DateTime lMinDateOfReference = Utils.MIN_DATETIME;
            DateTime lMaxDateOfReference = Utils.MAX_DATETIME;
            ErrorViewModel lErrorVM;
            FarmViewModel lFarmViewModel;
            User lLoggedUser;
            List<Farm> lFarmList;
            Farm lFirstFarm;
            List<FarmViewModel> lFarmViewModelList;
            List<Bomb> lBombList;
            List<IrrigationUnit> lIrrigationUnitList;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;
            Crop lCrop;
            CropIrrigationWeather lFirstCropIrrigationWeather;
            List<Rain> lRainList;
            List<Models.Water.Irrigation> lIrrigationList;
            List<DailyRecord> lDailyRecordList;

            List<DailyRecordViewModel> lDailyRecordViewModelList;
            List<RainViewModel> lRainViewModelList;
            List<IrrigationViewModel> lIrrigationViewModelList;
            
            #endregion

            try 
	            {

                if(!pLoginViewModel.UserName.Equals(string.Empty))
                {
                    ManageSession.SetLoginViewModel(pLoginViewModel);
                }else
                {
                    pLoginViewModel = ManageSession.GetLoginViewModel();
                }

                ManageSession.SetUserName(pLoginViewModel.UserName);
                ManageSession.SetUserPassword(pLoginViewModel.Password);

                
                lAuthentication = new Authentication(pLoginViewModel.UserName, pLoginViewModel.Password);
            
                if(!lAuthentication.IsAuthenticated())
                {
                    pLoginViewModel.InvalidPasswordMessage = AUTHENTICATION_ERROR;
                    return View("Index", pLoginViewModel);
                }

                #region Configuration - Instance
                uc = new UserConfiguration();
                fc = new FarmConfiguration();
                bc = new BombConfiguration();
                iuc = new IrrigationUnitConfigurarion();
                ciwc = new CropIrrigationWeatherConfiguration();
                drc = new DailyRecordConfiguration();
                rc = new RainConfiguration();
                ic = new IrrigationConfiguration();
                #endregion

                if(ManageSession.GetDateOfReference() >= Utils.MAX_DATETIME)
                {
                    lDateOfReference = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["DemoDateOfReference"]);
                    ManageSession.SetDateOfReference(lDateOfReference);
                }
                else
                {
                    lDateOfReference = ManageSession.GetDateOfReference();
                }

                ViewBag.DateOfReference = lDateOfReference;

                //Obtain logged user
                lLoggedUser = uc.GetUserByName(pLoginViewModel.UserName);

                //Get list of Farms from User
                lFarmList = fc.GetFarmListBy(lLoggedUser);

                lErrorVM = new ErrorViewModel();

                // If the user doesnt have farms
                if (lFarmList.Count == 0)
                {
                    lErrorVM.Code = NO_FARMS_FOR_USER_NR;
                    lErrorVM.Description = NO_FARMS_FOR_USER;

                    HomeViewModel HVMError = new HomeViewModel(lErrorVM);

                    return View(HVMError);
                }
                

                //Create View Model Farm list
                lFarmViewModelList = new List<FarmViewModel>();
                //Create Bomb List
                lBombList = new List<Bomb>();
                //Create IrrigationQuantity Units List
                lIrrigationUnitList = new List<IrrigationUnit>();

                
                //Map each farm with FarmViewModel and add to a list
                foreach (var farm in lFarmList)
                {
                    lBombList = farm.BombList;
                    lIrrigationUnitList = farm.IrrigationUnitList;
                    lFarmViewModel = new FarmViewModel(farm);
                    lFarmViewModelList.Add(lFarmViewModel);
                }

                lFirstFarm = lFarmList.FirstOrDefault();
                lFarmViewModel = new FarmViewModel(lFirstFarm);
                lIrrigationUnitList = iuc.GetIrrigationUnitListBy(lFirstFarm);

                lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                lDailyRecordList = new List<DailyRecord>();
                foreach (var lIrrigationUnit in lIrrigationUnitList)
                {
                    lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy(lIrrigationUnit, lDateOfReference);
                    //TODO Demo - First CropIrrigationWeather
                    lCrop = lCropIrrigationWeatherList.FirstOrDefault().Crop;
                    lDailyRecordList = ciwc.GetDailyRecordListIncludeDailyRecordListBy(lIrrigationUnit, lDateOfReference, lCrop);
                    lMinDateOfReference = ciwc.GetMinDateOfReferenceBy(lIrrigationUnit, lDateOfReference);
                    lMaxDateOfReference = ciwc.GetMaxDateOfReferenceBy(lIrrigationUnit, lDateOfReference);
                }

                //Demo - First CropIrrigationWeather
                lFirstCropIrrigationWeather = lCropIrrigationWeatherList.FirstOrDefault();
                //lDailyRecordList = lFirstCropIrrigationWeather.DailyRecordList;
                
                lRainList = lFirstCropIrrigationWeather.RainList;
                lRainViewModelList = new List<RainViewModel>();
                foreach (var rain in lRainList)
                {
                    lRainViewModelList.Add(new RainViewModel(rain));
                }

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

                List<CropIrrigationWeather> cropIrrigationVM = new List<CropIrrigationWeather>();
                cropIrrigationVM.Add(lFirstCropIrrigationWeather);
                //Demo - One Pivot
                lHVM = new HomeViewModel(lLoggedUser, lFarmViewModelList, lDateOfReference,
                    lFarmViewModel, cropIrrigationVM, lDailyRecordViewModelList,
                    lRainViewModelList, lIrrigationViewModelList, 
                    lMinDateOfReference, lMaxDateOfReference);

                //Create View Model of Home
                //HVM = new HomeViewModel(lLoggedUser, lFarmViewModelList, lDateOfReference);
                lHVM.DateOfReference = lDateOfReference;
                
                #region ViewBags

                //TODO: Change when implement multiple farms
                lHVM.IsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);
                ViewBag.SpecieId = lFirstCropIrrigationWeather.Crop.SpecieId;

                #endregion
                

                ManageSession.SetHomeViewModel(lHVM);

                return View(lHVM);

	        }
            catch (NullReferenceException ex)
            {
                ManageSession.CleanSession();

                Console.WriteLine(ex.Message, ex);
                return RedirectToAction("Index");
            }
	        catch (Exception ex)
	        {
                ManageSession.CleanSession();

                Console.WriteLine(ex.Message, ex);
		        throw ex;
	        }

        }
        
        public JsonResult GetStagesBy(long pSpecieId, long pCropIrrigationWeatherId)
        {
            
            StageConfiguration st = new StageConfiguration();
            List<StageViewModel> lStageViewModelList = new List<StageViewModel>();

            IrrigationAdvisorContext context = new IrrigationAdvisorContext();

            CropIrrigationWeather ciw = context.CropIrrigationWeathers.Where(c => c.CropIrrigationWeatherId == pCropIrrigationWeatherId).FirstOrDefault();
            
            Stage foundStage = context.Stages.Where(s => s.StageId == ciw.PhenologicalStage.PhenologicalStageId).FirstOrDefault();

            //irrigationUnit
            try
            {

                List<Stage> lStageResult = st.GetStageBy(pSpecieId, foundStage.Order);

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

                return Json(lStageResult, JsonRequestBehavior.AllowGet);

            }
            catch (Exception ex)
            {

                throw;
            }
            
        }
        
        /// <summary>
        /// Change the Date of Reference
        /// </summary>
        /// <param name="pDay"></param>
        /// <param name="pMonth"></param>
        /// <param name="pYear"></param>
        /// <returns></returns>
        public ActionResult ChangeDateOfReference(  int pDay,
                                                    int pMonth,
                                                    int pYear)
        {

            DateTime newDateOfReference = new DateTime(pYear,
                                                        pMonth,
                                                        pDay);

            try
            {
                ManageSession.SetDateOfReference(newDateOfReference);

                return Content("Ok");
            }
            catch (Exception ex)
            {

                return Content(ex.Message);
            }

            

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

        public ActionResult SendEmails(string subject, string body)
        {
            try
            {
                string smtpAddress = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["smtpAddress"]);
                int portNumber = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
                bool enableSSL = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ssl"]);
                string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
                string password = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["password"]);
                string emailTo = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailTo"]);


                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;
                    // Can set to false, if you are sending pure text.


                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;
                        smtp.Send(mail);
                    }
                }
                
            }
            catch (Exception ex)
            {
                return Content(ex.Message); ;
            }


            return Content("Ok");
        }

        public ActionResult LogOut()
        {
            ManageSession.CleanSession();
            return View("Index", new LoginViewModel());
        }

        [HttpGet]
        public ActionResult AddDateOfReference()
        {
            DateTime date = ManageSession.GetDateOfReference();
            date = date.AddDays(1);
            ManageSession.SetDateOfReference(date);
            //LoginViewModel lvm = ManageSession.GetLoginViewModel();

            return RedirectToAction("Home");
        }

        public ActionResult AddPhenology( DateTime  pDate,
                                          int       pCropIrrigationWeatherId,
                                          int       pStageId)
        {

            IrrigationAdvisorContext lContext = new IrrigationAdvisorContext();
            IrrigationUnitConfigurarion iuc = new IrrigationUnitConfigurarion();

            try
            {
                DateTime lReferenceDate = ManageSession.GetDateOfReference();

                CropIrrigationWeather lCiw = iuc.GetCropIrrigationWeatherListBy(pCropIrrigationWeatherId);
                
                //First Change
                Stage lStageToChange = (from stage in lContext.Stages
                                        where stage.StageId == pStageId
                                        select stage).FirstOrDefault();

                PhenologicalStage lPhenologicalStage = (from phenologicalstage in lContext.PhenologicalStages
                                                        where phenologicalstage.SpecieId.Equals(lCiw.Crop.SpecieId)
                                                        && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                                        select phenologicalstage).FirstOrDefault();

               
                string lObservation = string.Format("Real Stage is {0}, {1}.", lStageToChange.Name, lStageToChange.Description);

                
                string lName = string.Format("Adjustement {0} {1} ", lStageToChange.Name, pDate.ToString());

                lCiw.AddPhenologicalStageAdjustmentToList(lName, lCiw.Crop, pDate,
                                                         lStageToChange, lPhenologicalStage, lObservation);

                lContext.SaveChanges();

                lCiw.AddInformationToIrrigationUnits(pDate, lReferenceDate, lContext);
                lContext.SaveChanges();


                return Content("Ok");

            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

        }

        [HttpGet]
        public ActionResult AddIrrigation(  double pMilimeters,
                                            int pIrrigationUnitId,
                                            int pDay,
                                            int pMonth,
                                            int pYear)
        {
            try
            {
                HomeViewModel lHomeViewModel = ManageSession.GetHomeViewModel();

                DateTime lDateResult = new DateTime(pYear, pMonth, pDay);
                DateTime lReferenceDate = ManageSession.GetDateOfReference();

                IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
                IrrigationUnitConfigurarion iuc = new IrrigationUnitConfigurarion();
                CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();

                IrrigationUnit lIrrigationUnit = null; 
                List<CropIrrigationWeather> lCropIrrigationWeatherList;

                ManageSession.SetFromDateTime(lDateResult);

                int lSaveChanges = 0;

                if (pIrrigationUnitId > -1)
                {
                    lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == pIrrigationUnitId).FirstOrDefault();
                    lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);
                    
                    foreach (var item in lCropIrrigationWeatherList)
                    {
                        item.AddOrUpdateIrrigationDataToList(lDateResult, new Pair<double, Utils.WaterInputType>(pMilimeters, Utils.WaterInputType.Irrigation), true);
                        lSaveChanges = lContext.SaveChanges();

                        item.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lContext);
                        lSaveChanges = lContext.SaveChanges();
                    }
                    lSaveChanges = lContext.SaveChanges();
                }
                else
                {
                    foreach (var item in lHomeViewModel.IrrigationUnitViewModelList)
                    {
                        lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == item.IrrigationUnitId).FirstOrDefault();
                        lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);
                        
                        foreach (var lCIW in lCropIrrigationWeatherList)
                        {
                            lCIW.AddOrUpdateIrrigationDataToList(lDateResult, new Pair<double, Utils.WaterInputType>(pMilimeters, Utils.WaterInputType.Irrigation), true);
                            lSaveChanges = lContext.SaveChanges();

                            lCIW.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lContext);
                            lSaveChanges = lContext.SaveChanges();
                        }
                        lSaveChanges = lContext.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return RedirectToAction("Home");
        }


        [HttpGet]
        public ActionResult AddRain(double pMilimeters, 
                                    long pIrrigationUnitId, 
                                    int pDay, 
                                    int pMonth, 
                                    int pYear)
        {

            try
            {
                
                HomeViewModel lHomeViewModel = ManageSession.GetHomeViewModel();
               
                DateTime lDateResult = new DateTime(pYear, pMonth, pDay);
                DateTime lReferenceDate = ManageSession.GetDateOfReference();

                IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();
                IrrigationUnitConfigurarion iuc = new IrrigationUnitConfigurarion();
                CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();

                IrrigationUnit lIrrigationUnit = null;
                List<CropIrrigationWeather> lCropIrrigationWeatherList;

                int lSaveChanges = 0;

                ManageSession.SetFromDateTime(lDateResult);

                if (pIrrigationUnitId > -1)
                {
                    lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == pIrrigationUnitId).FirstOrDefault();
                    lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);

                    foreach (var item in lCropIrrigationWeatherList)
                    {
                        item.AddRainDataToList(lDateResult, pMilimeters);
                        lSaveChanges = lContext.SaveChanges();

                        item.AddInformationToIrrigationUnits(lDateResult, lReferenceDate, lContext);
                        lSaveChanges = lContext.SaveChanges();
                    }
                    lSaveChanges = lContext.SaveChanges();
                }
                else
                {
                    foreach (var item in lHomeViewModel.IrrigationUnitViewModelList)
                    {
                        lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == item.IrrigationUnitId).FirstOrDefault();
                        lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);

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
            }
            catch (Exception ex)
            {

                throw ex;
            }
            

            return RedirectToAction("Home");
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

        public PartialViewResult GenerateMenu()
        {

            MenuViewModel menuVM = new MenuViewModel();

            string lLoggedUser = ManageSession.GetUserName();

            UserConfiguration uc = new UserConfiguration();
            User user = uc.GetUserByName(lLoggedUser);

            if (user != null && user.RoleId == (int)Utils.UserRoles.Administrator)
                menuVM.IsAdministrator = true;
            else
                menuVM.IsAdministrator = false;

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

        public ActionResult SaveDetailedInfo(string mensaje, string nombre, string email)
        {
            System.Net.Mail.MailMessage mail;
            var emailUser = new StringBuilder();;
            string EmailUserLineFormat;
            SmtpClient server;

            mail = new System.Net.Mail.MailMessage();

            //set the addresses
            mail.From = new MailAddress(email);
            mail.To.Add(email);

            //set the content
            mail.Subject = "Valorem - Start a project";

            //Generate an email message object to send
            emailUser = new StringBuilder();
            EmailUserLineFormat = "<p>{0}</p>";

            emailUser.AppendFormat(EmailUserLineFormat, mensaje);

            server = new SmtpClient();
            server.EnableSsl = true;
            server.Host = "smtp.live.com";
            server.Port = 587;
            server.UseDefaultCredentials = false;

            server.EnableSsl = true;
            server.Credentials = new System.Net.NetworkCredential("despinosa@overactiveinc.com", "Diego4749");
            server.Timeout = 5000;

            //send the message

            server.DeliveryMethod = SmtpDeliveryMethod.Network;

            server.Send(mail);

            //Send the email to User
            //library.SendMail(username, model.EmailFrom, "Valorem - Start a project", emailUser.ToString(), true);

            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                            ex.ToString());
            }

            return Json(new { status = "Success", message = "Success" });
        }


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
            ErrorViewModel lErrorVM;
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

                lDateOfReference = ManageSession.GetDateOfReference();

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

                //Add all the days for the IrrigationUnit
                lGridIrrigationUnit = new GridPivotHome("Nombre", "Cultivo", "Siembra", "Fen.", lGridIrrigationUnitDetailRow);

                lGridIrrigationUnitList.Add(lGridIrrigationUnit);

            }
            catch (Exception ex)
            {

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
            List<GridPivotHome> lGridIrrigationUnitList = new List<GridPivotHome>();
            GridPivotHome lGridIrrigationUnit;
            List<GridPivotDetailHome> lGridIrrigationUnitDetailRow;
            GridPivotDetailHome lGridIrrigationUnitRow;
            DateTime lDateOfReference;
            ErrorViewModel lErrorVM;
            FarmViewModel lFarmViewModel;
            User lLoggedUser;
            List<Farm> lFarmList;
            Farm lFirstFarm;
            List<IrrigationUnit> lIrrigationUnitList;
            List<CropIrrigationWeather> lCropIrrigationWeatherList;
            CropIrrigationWeather lFirstCropIrrigationWeather;
            List<Rain> lRainList;
            List<Models.Water.Irrigation> lIrrigationList;
            List<DailyRecord> lDailyRecordList;
            String lSowingDate;
            String lPhenologicalStageToday;

            #endregion

            #region Configuration Variables
            UserConfiguration uc;
            FarmConfiguration fc;
            IrrigationUnitConfigurarion iuc;
            CropIrrigationWeatherConfiguration ciwc;
            #endregion

            try
            {
                
                #region Configuration - Instance
                uc = new UserConfiguration();
                fc = new FarmConfiguration();
                iuc = new IrrigationUnitConfigurarion();
                ciwc = new CropIrrigationWeatherConfiguration();
                #endregion

                lDateOfReference = ManageSession.GetDateOfReference();

                //Obtain logged user
                lLoggedUser = uc.GetUserByName(ManageSession.GetUserName());

                //Get list of Farms from User
                lFarmList = fc.GetFarmListBy(lLoggedUser);

                //Create IrrigationQuantity Units List
                lIrrigationUnitList = new List<IrrigationUnit>();

                lFirstFarm = lFarmList.FirstOrDefault();
                lFarmViewModel = new FarmViewModel(lFirstFarm);
                lIrrigationUnitList = iuc.GetIrrigationUnitListBy(lFirstFarm);

                lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
                lDailyRecordList = new List<DailyRecord>();

                Dictionary<long, CropIrrigationWeather> dic = new Dictionary<long, CropIrrigationWeather>();

                foreach (var lIrrigationUnit in lIrrigationUnitList)
                {
                    lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListIncludeCropMainWeatherStationRainListIrrigationListBy(lIrrigationUnit, lDateOfReference);
                    lDailyRecordList = ciwc.GetDailyRecordListBy(lIrrigationUnit, lDateOfReference);

                    //Demo - First CropIrrigationWeather
                    lFirstCropIrrigationWeather = lCropIrrigationWeatherList.FirstOrDefault();
                    
                    lRainList = lFirstCropIrrigationWeather.RainList;
                    lIrrigationList = lFirstCropIrrigationWeather.IrrigationList;
                    lPhenologicalStageToday = lFirstCropIrrigationWeather.PhenologicalStage.Stage.ShortName;
                    lSowingDate = lFirstCropIrrigationWeather.SowingDate.Day.ToString() 
                            + "/" + lFirstCropIrrigationWeather.SowingDate.Month.ToString();
                    //Grid of irrigation data
                    lGridIrrigationUnitDetailRow = new List<GridPivotDetailHome>();

                    for (int i = -InitialTables.MIN_DAY_SHOW_IN_GRID_BEFORE_TODAY; i <= InitialTables.MAX_DAY_SHOW_IN_GRID_AFTER_TODAY; i++)
                    {
                        //Day i
                        lGridIrrigationUnitRow = AddGridIrrigationUnit(lDateOfReference, lDateOfReference.AddDays(i), lIrrigationList, lRainList, lDailyRecordList);
                        lGridIrrigationUnitDetailRow.Add(lGridIrrigationUnitRow);
                        if(i == 0) //TODAY
                        {

                            lPhenologicalStageToday = lGridIrrigationUnitRow.Phenology;
                        }
                    }
                    
                    //Add all the days for the IrrigationUnit
                    lGridIrrigationUnit = new GridPivotHome(lFirstCropIrrigationWeather.IrrigationUnit.ShortName,
                                                            lFirstCropIrrigationWeather.Crop.ShortName,
                                                            lSowingDate,
                                                            lPhenologicalStageToday,
                                                            lGridIrrigationUnitDetailRow);

                    lGridIrrigationUnitList.Add(lGridIrrigationUnit);
                }
                
            }
            catch (Exception ex)
            {
                
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
            GridPivotDetailHome lReturn;

            Double lIrrigationQuantity = 0;
            Double lRainQuantity = 0;
            Double lForcastIrrigationQuantity = 0;
            DateTime lDateOfData = Utils.MIN_DATETIME;
            bool lIsToday = false;
            Utils.IrrigationStatus lIrrigationStatus = Utils.IrrigationStatus.Gray;
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
            GridPivotDetailHome lReturn;

            Double lIrrigationQuantity = 0;
            Double lRainQuantity = 0;
            Double lForcastIrrigationQuantity = 0;
            DateTime lDateOfData = Utils.MIN_DATETIME;
            bool lIsToday = false;
            Utils.IrrigationStatus lIrrigationStatus = Utils.IrrigationStatus.Gray;
            String lPhenology = "";

            Models.Water.Irrigation lIrrigation;
            Rain lRain;
            DailyRecord lDailyRecord;

            lDateOfData = pDayOfData;

            //Find Irrigation of the Date of Data
            lIrrigation = pIrrigationList.Where(ir => ir.Date == lDateOfData).FirstOrDefault();
            if (lIrrigation != null && lIrrigation.Input > 0 && pDayOfData < pDayOfReference)
            {
                lIrrigationQuantity = lIrrigation.Input;
            }

            lIrrigation = pIrrigationList.Where(ir => ir.ExtraDate == lDateOfData).FirstOrDefault();
            if (lIrrigation != null && lIrrigation.ExtraInput > 0 && pDayOfData < pDayOfReference)
            {
                lIrrigationQuantity += lIrrigation.ExtraInput;
            }
            //Find Rain of the Date of Data
            lRain = pRainList.Where(r => r.Date == lDateOfData).FirstOrDefault();
            if (lRain != null && lRain.Input > 0)
            {
                lRainQuantity = lRain.Input;
            }

            //Find Daily Record of the Date of Data
            lDailyRecord = pDailyRecordList.Where(dr => dr.DailyRecordDateTime == lDateOfData).FirstOrDefault();
            if (lDailyRecord != null && pDayOfData >= pDayOfReference)
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

            lIsToday = pDayOfData == pDayOfReference;

            if(lIsToday)
            {
                lPhenology = lDailyRecord.PhenologicalStage.Stage.ShortName;
            }

            if(lRainQuantity > 0)
            {
                lIrrigationStatus = Utils.IrrigationStatus.Cyan;
            }
            else if(lIrrigationQuantity > 0)
            {
                lIrrigationStatus = Utils.IrrigationStatus.Blue;
            }
            else if(lForcastIrrigationQuantity > 0)
            {
                lIrrigationStatus = Utils.IrrigationStatus.Green;
            }
            else
            {
                lIrrigationStatus = Utils.IrrigationStatus.Gray;
            }

            lReturn = new GridPivotDetailHome(lIrrigationQuantity, lRainQuantity, lForcastIrrigationQuantity,
                                                            lDateOfData, lIsToday, lIrrigationStatus,
                                                            lPhenology);
            return lReturn;
        }



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
            Farm lFirstFarm;
            long lPositionId;
            Double lLatitude;
            Double lLongitude;
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
            string lStrLatitude;
            string lStrLongitude;
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

                if(lLoggedUser != null)
                {
                    //Get list of Farms from User
                    lFarmList = fc.GetFarmListBy(lLoggedUser);

                    lFirstFarm = lFarmList.FirstOrDefault();
                    lPositionId = lFirstFarm.PositionId;

                    lLatitude = fc.GetLatitudeBy(lPositionId);
                    lLongitude = fc.GetLongitudeBy(lPositionId);
                }
                else
                {
                    lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
                    lMyUri = new Uri(lURL);
                    lStrLatitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("latitude");
                    if(lStrLatitude != null)
                    {
                        lLatitude = Convert.ToDouble(lStrLatitude);
                    }
                    else
                    {
                        lCantGetWeatherData = true;
                        lLatitude = -34.8172490;
                    }
                    lStrLongitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("longitude");
                    if(lStrLongitude != null)
                    {
                        lLongitude = Convert.ToDouble(lStrLongitude);
                    }
                    else
                    {
                        lCantGetWeatherData = true;
                        lLongitude = -56.1590040;
                    }
                }
                
                lAPIWUndergroundBase = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIbase"]);
                lAPIWUndergroundKey = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIkeyIndex"]);
                lAPIWUndergroundForcast10Days = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIforcast10days"]);
                lAPIWUndergroundConditions = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIconditions"]);
                lAPIWUndergroundAstronomy = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["WUndergroundAPIastronomy"]);

                if(lCantGetWeatherData)
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
                        Console.WriteLine(ex.Message, ex);
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
                        Console.WriteLine(ex.Message, ex);
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
                        Console.WriteLine(ex.Message, ex);
                    }
                    #endregion

                    lWeatherDataToShow = new WeatherDataToShow(lCity, lURLImage, lConditions, lAverageTemperature,
                                                    lDay, lSunriseTime, lSunsetTime, lTempHigh, lTempLow, lRelativeHumidity,
                                                    lAverageWind, lPressure, lVisibility, lDewPoint, lWeatherDataItemList);
                }
                
                lReturn = lWeatherDataToShow;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex);
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
            Farm lFirstFarm;
            long lPositionId;
            Double lLatitude;
            Double lLongitude;
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
            string lStrLatitude;
            string lStrLongitude;
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

                if (lLoggedUser != null)
                {
                    //Get list of Farms from User
                    lFarmList = fc.GetFarmListBy(lLoggedUser);

                    lFirstFarm = lFarmList.FirstOrDefault();
                    lPositionId = lFirstFarm.PositionId;

                    lLatitude = fc.GetLatitudeBy(lPositionId);
                    lLongitude = fc.GetLongitudeBy(lPositionId);
                }
                else
                {
                    lURL = System.Web.HttpContext.Current.Request.Url.AbsoluteUri;
                    lMyUri = new Uri(lURL);
                    lStrLatitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("latitude");
                    if (lStrLatitude != null)
                    {
                        lLatitude = Convert.ToDouble(lStrLatitude);
                    }
                    else
                    {
                        lCantGetWeatherData = true;
                        lLatitude = -34.8172490;
                    }
                    lStrLongitude = System.Web.HttpUtility.ParseQueryString(lMyUri.Query).Get("longitude");
                    if (lStrLongitude != null)
                    {
                        lLongitude = Convert.ToDouble(lStrLongitude);
                    }
                    else
                    {
                        lCantGetWeatherData = true;
                        lLongitude = -56.1590040;
                    }

                }

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
                        Console.WriteLine(ex.Message, ex);
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
                        Console.WriteLine(ex.Message, ex);
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
                        Console.WriteLine(ex.Message, ex);
                    }
                    #endregion

                    lWeatherDataToShow = new WeatherDataToShow(lCity, lURLImage, lConditions, lAverageTemperature,
                                                    lDay, lSunriseTime, lSunsetTime, lTempHigh, lTempLow, lRelativeHumidity,
                                                    lAverageWind, lPressure, lVisibility, lDewPoint, lWeatherDataItemList);
                }

                lReturn = lWeatherDataToShow;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, ex);
                throw ex;
            }

            return lReturn;
        }


        #endregion
    }
}