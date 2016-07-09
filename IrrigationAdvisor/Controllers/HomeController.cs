using AutoMapper;
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
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace IrrigationAdvisor.Controllers
{

    public class HomeController : Controller
    {
        private const string AUTHENTICATION_ERROR = "Credenciales inválidas";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View(getGridPivotHome());
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Home(LoginViewModel loginViewModel)
        {
            Authentication lAuthentication;
            UserConfiguration uc;
            FarmConfiguration fc;
            BombConfiguration bc;
            IrrigationUnitConfigurarion iuc;

            User lLoggedUser;
            List<Farm> lFarmList;
            List<FarmViewModel> lFarmViewModelList;
            List<Bomb> lBombList;
            List<IrrigationUnit> lIrrigationUnitList;

            ManageSession.SetUserName(loginViewModel.UserName);
            ManageSession.SetUserPassword(loginViewModel.Password);


            lAuthentication = new Authentication(loginViewModel.UserName, loginViewModel.Password);

            uc = new UserConfiguration();
            fc = new FarmConfiguration();
            bc = new BombConfiguration();
            iuc = new IrrigationUnitConfigurarion();

            FarmViewModel lFarmViewModel;

            if(!lAuthentication.IsAuthenticated())
            {
                loginViewModel.InvalidPasswordMessage = AUTHENTICATION_ERROR;
                return View("Index", loginViewModel);
                
            }
            else
            {
                //Obtain logged user
                lLoggedUser = uc.GetUserByName(loginViewModel.UserName);

                //Get list of Farms from User
                lFarmList = fc.GetFarmListBy(lLoggedUser);

                //Create View Model Farm list
                lFarmViewModelList = new List<FarmViewModel>();

                //Create Bomb List
                lBombList = new List<Bomb>();

                //Create Irrigation Units List
                lIrrigationUnitList = new List<IrrigationUnit>();

                //Map each farm with FarmViewModel and add to a list
                foreach (var farm in lFarmList)
                {
                    lBombList = farm.BombList;
                    lIrrigationUnitList = farm.IrrigationUnitList;
                    lFarmViewModel = new FarmViewModel(farm);
                    lFarmViewModelList.Add(lFarmViewModel);

                }
                //Create View Model of Home
                HomeViewModel HVM = new HomeViewModel(lLoggedUser, lFarmViewModelList);
                return View(HVM);
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

        public ActionResult LogOut()
        {
            ManageSession.CleanSession();
            return View("Index", new LoginViewModel());

        }


        [HttpPost]
        public ActionResult AddIrrigation(string irrigation, string pivot)
        {

            return Json("Finished");
        }

        [ChildActionOnly]
        public PartialViewResult FrontPagePartial()
        {
            return PartialView("_FrontPagePartial", getGridPivotHome());
        }

        [ChildActionOnly]
        public PartialViewResult FrontPageHeaderPartial()
        {
            return PartialView("_FrontPageHeaderPartial", getGridPivotHome());
        }
        [ChildActionOnly]
        public PartialViewResult WeatherPartial()
        {
            return PartialView("_WeatherPartial", getWeatherHome());
        }
        public PartialViewResult WeatherHomePartial()
        {
            return PartialView("_WeatherHomePartial", getWeatherHome());
        }

        [ChildActionOnly]
        public PartialViewResult LoginHomePartial()
        {


            if(ManageSession.GetUserName() == null)
                return PartialView("_LoginHomePartial", new LoginViewModel());

            
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

            if (user != null && user.RoleId == 1)
                menuVM.IsAdministrator = true;
            else
                menuVM.IsAdministrator = false;

            return PartialView("_GenerateMenu", menuVM);
        }

        public PartialViewResult ContactPartial()
        {
            return PartialView("_ContactPartial");
        }
        
        [HttpPost]
        public void SendEmail()
        {

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


        private readonly List<GridPivotHome> gridPivotHome = new List<GridPivotHome>();
        public List<GridPivotHome> getGridPivotHome()
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



            gridPivotHome.Add(new GridPivotHome("Piv. 1", "v0", "Maiz", gridPivotDetailHome2));
            gridPivotHome.Add(new GridPivotHome("Piv. 2", "v2", "Soja", gridPivotDetailHome1));

            return gridPivotHome;

        }

        public List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather> getWeather()
        {

            List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather> GridWeatherList = new List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather>();

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
            IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject jsonObj = JsonConvert.DeserializeObject<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject>(json);

            // Iterate ForecastDay
            foreach (var item in jsonObj.forecast.simpleforecast.forecastday)
            {
                if (GridWeatherList.Count <= 2)
                {
                    high = item.high.celsius;
                    low = item.low.celsius;
                    month = item.date.month.ToString();
                    weekday = item.date.weekday;
                    urlImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                    description = item.conditions;
                    probabilityRain = item.pop.ToString();
                    mmRain = item.qpf_allday.mm.ToString();
                    GridWeatherList.Add(new IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather(high, low, weekday, month, urlImage, description, probabilityRain, mmRain));
                }
            }



            return GridWeatherList;
        }

        public IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject getWeatherHome()
        {

            List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather> GridWeatherList = new List<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather>();

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
            IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject jsonObj = JsonConvert.DeserializeObject<IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.RootObject>(json);

            // Iterate ForecastDay
            foreach (var item in jsonObj.forecast.simpleforecast.forecastday)
            {
                if (GridWeatherList.Count <= 2)
                {
                    high = item.high.celsius;
                    low = item.low.celsius;
                    month = item.date.month.ToString();
                    weekday = item.date.weekday;
                    urlImage = "//icons.wxug.com/i/c/v4/" + item.icon + ".svg";
                    description = item.conditions;
                    probabilityRain = item.pop.ToString();
                    mmRain = item.qpf_allday.mm.ToString();
                    GridWeatherList.Add(new IrrigationAdvisor.Models.Weather.ResultUnderGroundToSharp.GridWeather(high, low, weekday, month, urlImage, description, probabilityRain, mmRain));
                }
            }

            jsonObj.forecast.simpleforecast.forecastday = jsonObj.forecast.simpleforecast.forecastday.Skip(6).ToList(); ;

            return jsonObj;
        }

        public PartialViewResult AddIrrigation()
        {

            IrrigationSystem testIrrigationSystem;
            Utils.IrrigationUnitType lType = Utils.IrrigationUnitType.Pivot;
            testIrrigationSystem = IrrigationSystem.Instance;

            testIrrigationSystem.IrrigationUnitList = new List<IrrigationUnit>();
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 1", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 2", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 3", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 4", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));
            testIrrigationSystem.IrrigationUnitList.Add(new IrrigationUnit(1, "Pivot 5", lType, 1, null, 1, 0, 0, Utils.PredeterminatedIrrigationQuantity));

            IrrigationAdvisorContext var = new IrrigationAdvisorContext();
            //var.Farms.Where(q => q.Name == "Santa Lucia").First().IrrigationUnitList
            // var x =  var.Stages.Add(new Models.Agriculture.Stage(1,"Prueba", "desc"));

            return PartialView("_AddIrrigation", testIrrigationSystem.IrrigationUnitList);
        }

    }
}