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
            HomeViewModel HVM;

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

                if(ManageSession.GetDateOfReference() == Utils.MAX_DATETIME)
                {
                    lDateOfReference = Convert.ToDateTime(System.Configuration.ConfigurationManager.AppSettings["DemoDateOfReference"]);
                    ManageSession.SetDateOfReference(lDateOfReference);
                }
                else
                {
                    lDateOfReference = ManageSession.GetDateOfReference();
                }

                ViewBag.DateOfReference = lDateOfReference;

                bool isDebug = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["Debug"]);

                if (ManageSession.GetHomeViewModel() != null && isDebug)
                    return View((HomeViewModel)ManageSession.GetHomeViewModel());
                
                
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

                //Demo - One Pivot
                HVM = new HomeViewModel(lLoggedUser, lFarmViewModelList, lDateOfReference,
                    lFarmViewModel, lFirstCropIrrigationWeather, lDailyRecordViewModelList,
                    lRainViewModelList, lIrrigationViewModelList);
                
                //Create View Model of Home
                //HVM = new HomeViewModel(lLoggedUser, lFarmViewModelList, lDateOfReference);

                

                HVM.IsUserAdministrator = (lLoggedUser.RoleId == (int)Utils.UserRoles.Administrator);

                
                ManageSession.SetHomeViewModel(HVM);

                return View(HVM);

	        }
	        catch (Exception ex)
	        {
		        throw ex;
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

        [HttpGet]
        public ActionResult AddIrrigation(  double pMilimeters,
                                            int pIrrigationUnitId,
                                            int pDay,
                                            int pMonth,
                                            int pYear)
        {
            HomeViewModel lHomeViewModel = ManageSession.GetHomeViewModel();

            DateTime lDateResult = new DateTime(pYear, pMonth, pDay);
            DateTime? lReferenceDate = ManageSession.GetDateOfReference();

            IrrigationAdvisorContext lContext = new IrrigationAdvisorContext();
            CropIrrigationWeatherConfiguration lCropConf = new CropIrrigationWeatherConfiguration();

            CropIrrigationWeather lCropIrrigationWeather = null;

            ManageSession.SetFromDateTime(lDateResult);

            if (pIrrigationUnitId > -1)
            {
                lCropIrrigationWeather = lContext.CropIrrigationWeathers.Where(c => c.IrrigationUnitId == pIrrigationUnitId && c.SowingDate <= lReferenceDate && c.HarvestDate >= lReferenceDate).FirstOrDefault();
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lDateResult, new Pair<double, Utils.WaterInputType>(pMilimeters, Utils.WaterInputType.Irrigation), true);
                lContext.SaveChanges();
            }
            else
            {
                foreach (var item in lHomeViewModel.IrrigationUnitViewModelList)
                {
                    lCropIrrigationWeather = lContext.CropIrrigationWeathers.Where(c => c.IrrigationUnitId == item.IrrigationUnitId && c.SowingDate <= lReferenceDate && c.HarvestDate >= lReferenceDate).FirstOrDefault();
                    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lDateResult, new Pair<double, Utils.WaterInputType>(pMilimeters, Utils.WaterInputType.Irrigation), true);
                    lContext.SaveChanges();
                }
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

                IrrigationAdvisorContext lContext = new IrrigationAdvisorContext();
                IrrigationUnitConfigurarion iuc = new IrrigationUnitConfigurarion();
                CropIrrigationWeatherConfiguration ciwc = new CropIrrigationWeatherConfiguration();

                IrrigationUnit lIrrigationUnit = null;
                List<CropIrrigationWeather> lCropIrrigationWeatherList;
                //List<DailyRecord> lDailyRecordList;

                ManageSession.SetFromDateTime(lDateResult);

                if (pIrrigationUnitId > -1)
                {
                    lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == pIrrigationUnitId).FirstOrDefault();
                    lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);
                    //lDailyRecordList = ciwc.GetDailyRecordListBy(lIrrigationUnit, lReferenceDate);
                    foreach (var item in lCropIrrigationWeatherList)
                    {
                        item.AddRainDataToList(lDateResult, pMilimeters);
                        item.AddInformationToIrrigationUnits(lDateResult, lReferenceDate);
                    }
                    lContext.SaveChanges();
                }
                else
                {
                    foreach (var item in lHomeViewModel.IrrigationUnitViewModelList)
                    {
                        lIrrigationUnit = lContext.IrrigationUnits.Where(iu => iu.IrrigationUnitId == item.IrrigationUnitId).FirstOrDefault();
                        lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListBy(lIrrigationUnit, lReferenceDate);
                        //lDailyRecordList = ciwc.GetDailyRecordListBy(lIrrigationUnit, lReferenceDate);
                        foreach (var lCIW in lCropIrrigationWeatherList)
                        {
                            lCIW.AddRainDataToList(lDateResult, pMilimeters);
                            lCIW.AddInformationToIrrigationUnits(lDateResult, lReferenceDate);
                        }
                        lContext.SaveChanges();
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
            return PartialView("_WeatherPartial", GetWeatherHome());
        }

        public PartialViewResult WeatherHomePartial()
        {
            return PartialView("_WeatherHomePartial", GetWeatherHome());
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

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();

            //set the addresses
            mail.From = new MailAddress(email);
            mail.To.Add(email);

            //set the content
            mail.Subject = "Valorem - Start a project";

            //Generate an email message object to send
            var emailUser = new StringBuilder();
            string EmailUserLineFormat = "<p>{0}</p>";

            emailUser.AppendFormat(EmailUserLineFormat, mensaje);

            SmtpClient server = new SmtpClient();
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

                for (int i = -2; i < 5; i++)
                {
                    //Day i
                    lGridIrrigationUnitRow = AddGridIrrigationUnitDays(lDateOfReference, lDateOfReference.AddDays(i));
                    lGridIrrigationUnitDetailRow.Add(lGridIrrigationUnitRow);
                }

                //Add all the days for the IrrigationUnit
                lGridIrrigationUnit = new GridPivotHome("Nombre", "Fenologia", "Cultivo", lGridIrrigationUnitDetailRow);

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

            #endregion

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

            try
            {
                
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
                foreach (var lIrrigationUnit in lIrrigationUnitList)
                {
                    lCropIrrigationWeatherList = iuc.GetCropIrrigationWeatherListIncludeCropMainWeatherStationRainListIrrigationListBy(lIrrigationUnit, lDateOfReference);
                    lDailyRecordList = ciwc.GetDailyRecordListBy(lIrrigationUnit, lDateOfReference);

                    //Demo - First CropIrrigationWeather
                    lFirstCropIrrigationWeather = lCropIrrigationWeatherList.FirstOrDefault();
                    lRainList = lFirstCropIrrigationWeather.RainList;
                    lIrrigationList = lFirstCropIrrigationWeather.IrrigationList;
                    
                    //Grid of irrigation data
                    lGridIrrigationUnitDetailRow = new List<GridPivotDetailHome>();

                    for (int i = -2; i < 5; i++)
                    {
                        //Day i
                        lGridIrrigationUnitRow = AddGridIrrigationUnit(lDateOfReference, lDateOfReference.AddDays(i), lIrrigationList, lRainList, lDailyRecordList);
                        lGridIrrigationUnitDetailRow.Add(lGridIrrigationUnitRow);
                        
                    }

                    //Add all the days for the IrrigationUnit
                    lGridIrrigationUnit = new GridPivotHome(lFirstCropIrrigationWeather.IrrigationUnit.ShortName, 
                                                            lFirstCropIrrigationWeather.PhenologicalStage.Stage.ShortName,
                                                            lFirstCropIrrigationWeather.Crop.ShortName, lGridIrrigationUnitDetailRow);

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
            Utils.IrrigationStatus lIrrigationStatus = Utils.IrrigationStatus.Green; 

            lDateOfData = pDayOfData;
            lIsToday = pDayOfData == pDayOfReference;

            lReturn = new GridPivotDetailHome(lIrrigationQuantity, lRainQuantity, 
                                                lForcastIrrigationQuantity,
                                                lDateOfData, lIsToday, 
                                                lIrrigationStatus);
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
            Utils.IrrigationStatus lIrrigationStatus = Utils.IrrigationStatus.Green; ;

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
            if (lDailyRecord != null && pDayOfData > pDayOfReference)
            {
                if (lDailyRecord.Irrigation != null && lDailyRecord.Irrigation.Input > 0)
                {
                    lForcastIrrigationQuantity = lDailyRecord.Irrigation.Input;
                }
            }
            

            lIsToday = pDayOfData == pDayOfReference;

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
                lIrrigationStatus = Utils.IrrigationStatus.Red;
            }
            else
            {
                lIrrigationStatus = Utils.IrrigationStatus.Green;
            }

            lReturn = new GridPivotDetailHome(lIrrigationQuantity, lRainQuantity, lForcastIrrigationQuantity,
                                                            lDateOfData, lIsToday, lIrrigationStatus);
            return lReturn;
        }

        public List<GridPivotHome> GetGridPivotHomeOld()
        {
            List<GridPivotDetailHome> gridPivotDetailHome2 = new List<GridPivotDetailHome>();
            List<GridPivotDetailHome> gridPivotDetailHome1 = new List<GridPivotDetailHome>();

            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 10, 0, DateTime.Now.AddDays(-3), false, Models.Utilities.Utils.IrrigationStatus.Cyan));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(10, 0, 0, DateTime.Now.AddDays(-2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(-1), false, Models.Utilities.Utils.IrrigationStatus.Blue));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 10, DateTime.Now, true, Models.Utilities.Utils.IrrigationStatus.Red));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+1), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome2.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+3), false, Models.Utilities.Utils.IrrigationStatus.Green));


            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 10, DateTime.Now.AddDays(-3), false, Models.Utilities.Utils.IrrigationStatus.Cyan));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(-2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 5, 0, DateTime.Now.AddDays(-1), false, Models.Utilities.Utils.IrrigationStatus.Blue));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now, true, Models.Utilities.Utils.IrrigationStatus.Red));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+1), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(10, 0, 0, DateTime.Now.AddDays(+2), false, Models.Utilities.Utils.IrrigationStatus.Green));
            gridPivotDetailHome1.Add(new GridPivotDetailHome(0, 0, 0, DateTime.Now.AddDays(+3), false, Models.Utilities.Utils.IrrigationStatus.Green));



            gridIrrigationUnitHomeList.Add(new GridPivotHome("Piv. 1", "v0", "Maiz", gridPivotDetailHome2));
            gridIrrigationUnitHomeList.Add(new GridPivotHome("Piv. 2", "v2", "Soja", gridPivotDetailHome1));

            return gridIrrigationUnitHomeList;

        }

        public List<ResultUnderGroundToSharp.GridWeather> GetWeather()
        {

            List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather> GridWeatherList = new List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather>();

            String city = string.Empty;
            String high = string.Empty;
            String low = string.Empty;
            String weekday = string.Empty;
            String month = string.Empty;
            String urlImage = string.Empty;
            String description = string.Empty;
            String probabilityRain = string.Empty;
            String mmRain = string.Empty;


            // TODO Replace Url To web Config Diego E.
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("http://api.wunderground.com/api/ac6d819f785ccfa5/forecast10day/lang:SP/q/-34.8172490,-56.1590040.json");
            httpWebRequest.Method = WebRequestMethods.Http.Get;
            httpWebRequest.Accept = "application/json";
            var response = (HttpWebResponse)httpWebRequest.GetResponse();

            string json = string.Empty;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                json = sr.ReadToEnd();
            }

            // Json To C#  DeserializeJsno to IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject
            ResultUnderGroundToSharp.RootObject jsonObj = JsonConvert.DeserializeObject<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject>(json);

            // Iterate ForecastDay
            foreach (var item in jsonObj.forecast.simpleforecast.forecastday)
            {
                if (GridWeatherList.Count <= 2)
                {
                    city = item.city;
                    high = item.high.celsius;
                    low = item.low.celsius;
                    month = item.date.month.ToString();
                    weekday = item.date.weekday;
                    urlImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                    description = item.conditions;
                    probabilityRain = item.pop.ToString();
                    mmRain = item.qpf_allday.mm.ToString();
                    GridWeatherList.Add(new ResultUnderGroundToSharp.GridWeather(city, high, low, weekday, month, urlImage, description, probabilityRain, mmRain));
                }
            }



            return GridWeatherList;
        }

        public ResultUnderGroundToSharp.RootObject GetWeatherHome()
        {
            #region Local Variables
            ResultUnderGroundToSharp.RootObject lReturn = null;

            User lLoggedUser;
            List<Farm> lFarmList;
            Farm lFirstFarm;
            long lPositionId;
            Double lLatitude;
            Double lLongitude;
            String lLinkAPIWUnderground;
            UserConfiguration uc;
            FarmConfiguration fc;
            
            List<ResultUnderGroundToSharp.GridWeather> lGridWeatherList = new List<ResultUnderGroundToSharp.GridWeather>();
            
            String lCity = String.Empty;
            String lTempHigh = String.Empty;
            String lTempLow = String.Empty;
            String lWeekday = String.Empty;
            String lMonth = String.Empty;
            String lURLImage = String.Empty;
            String lDescription = String.Empty;
            String lProbabilityRain = String.Empty;
            String lRainMM = String.Empty;

            HttpWebRequest lHttpWebRequest;
            string lJson;
            ResultUnderGroundToSharp.RootObject lJsonObj;
            string lURL;
            WebClient lWebClient;
            string lJSONstring;
            dynamic lDynamicObj;

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
                    lURL = "http://freegeoip.net/json/";
                    lWebClient = new WebClient();
                    lJSONstring = lWebClient.DownloadString(lURL);

                    lDynamicObj = JsonConvert.DeserializeObject(lJSONstring);

                    lLatitude = lDynamicObj.latitude;
                    lLongitude = lDynamicObj.longitude;
                }
                //http://api.wunderground.com/api/ac6d819f785ccfa5/forecast10day/lang:SP/q/-34.8172490,-56.1590040.json
                lLinkAPIWUnderground = "http://api.wunderground.com/api/ac6d819f785ccfa5/forecast10day/lang:SP/q/" + lLatitude + "," + lLongitude + ".json";
                // TODO Replace Url To web Config Diego E.
                lHttpWebRequest = (HttpWebRequest)WebRequest.Create(lLinkAPIWUnderground);
                lHttpWebRequest.Method = WebRequestMethods.Http.Get;
                lHttpWebRequest.Accept = "application/json";
                var lResponse = (HttpWebResponse)lHttpWebRequest.GetResponse();

                lJson = string.Empty;
                using (var sr = new StreamReader(lResponse.GetResponseStream()))
                {
                    lJson = sr.ReadToEnd();
                }

                // Json To C#  DeserializeJsno to IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject
                lJsonObj = JsonConvert.DeserializeObject<ResultUnderGroundToSharp.RootObject>(lJson);

                // Iterate ForecastDay
                foreach (var item in lJsonObj.forecast.simpleforecast.forecastday)
                {
                    if (lGridWeatherList.Count <= 2)
                    {
                        lCity = item.city;
                        lTempHigh = item.high.celsius;
                        lTempLow = item.low.celsius;
                        lMonth = item.date.month.ToString();
                        lWeekday = item.date.weekday;
                        lURLImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                        lDescription = item.conditions;
                        lProbabilityRain = item.pop.ToString();
                        lRainMM = item.qpf_allday.mm.ToString();
                        lGridWeatherList.Add(new ResultUnderGroundToSharp
                                                        .GridWeather(lCity, lTempHigh, lTempLow, lWeekday, lMonth,
                                                        lURLImage, lDescription, lProbabilityRain, lRainMM));
                    }
                }

                lJsonObj.forecast.simpleforecast.forecastday = lJsonObj.forecast.simpleforecast.forecastday.Skip(6).ToList(); ;
                lReturn = lJsonObj;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

            return lReturn;
        }

        public PartialViewResult AddIrrigation()
        {

            IrrigationSystem testIrrigationSystem;
            Utils.IrrigationUnitType lType = Utils.IrrigationUnitType.Pivot;
            testIrrigationSystem = IrrigationSystem.Instance;

            testIrrigationSystem.IrrigationUnitList = new List<IrrigationUnit>();
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 1", "Pivot 1", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 2", "Pivot 2", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 3", "Pivot 3", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 4", "Pivot 4", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 5", "Pivot 5", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));

            IrrigationAdvisorContext var = new IrrigationAdvisorContext();
            //var.Farms.Where(q => q.Name == "Santa Lucia").First().IrrigationUnitViewModelList
            // var x =  var.Stages.Add(new Models.Agriculture.Stage(1,"Prueba", "desc"));

            return PartialView("_AddIrrigation", testIrrigationSystem.IrrigationUnitList);
        }

    }
}