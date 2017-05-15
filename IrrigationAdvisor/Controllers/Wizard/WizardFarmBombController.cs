using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Wizard;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Weather;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models;

using IrrigationAdvisor.Models.Irrigation;
using Newtonsoft.Json;




namespace IrrigationAdvisor.Controllers.Wizard
{
    public class WizardFarmBombController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        // GET: Users/Create
        public ActionResult Index()
        {
            WizardFarmBombViewModel vm = new WizardFarmBombViewModel();

            vm.WizardFarmViewModel.City = this.LoadCities();
            vm.WizardFarmViewModel.WeatherStation = this.LoadWeatherStations();

            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml", vm);
        }


        // POST: Users/Create;
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name,Company, Phone, Address, Latitude, Longitude, Has, WeatherStationId, CityId, BombsHidden")] WizardFarmBombViewModel vm)
        {
   
            string BombsHidden = @"{""items"":[{""id"":""0"",""bombName"":""d"",""serialNumber"":""d"",""serviceDate"":"""",""purchaseDate"":"""",""bombLatitude"":""a"",""bombLongitude"":""a""}]}";
            double Latitude = -2232; //vm.WizardFarmViewModel.Latitude;
            double Longitude = -3232323; //vm.WizardFarmViewModel.Longitude;

            if (ModelState.IsValid)
            {

                Farm farmMapped = new Farm();
                long lFarmPositionId = GetPositionId(Latitude, Longitude);

                //Not exist farm position, create, and get id
                if (lFarmPositionId == 0)
                {
                    // FALTA CREAR POSICION NUEVA 
                    // OBTENER EL ID
                    // db.Positions.Add()
                    //lFarmPositionId= db.Positions.ma
                }

                
                dynamic items = JsonConvert.DeserializeObject(BombsHidden);
                foreach (var item in items.items)
                {
                    Bomb b = new Bomb();
                    b.Name = item.bombName;
                    b.SerialNumber = item.serialNumber;
                    b.ServiceDate = item.serviceDate;
                    b.PurchaseDate = item.purchaseDate;

                    //position bomb is diferent to position farm
                    if (vm.WizardFarmViewModel.Latitude != item.bombLatitude || vm.WizardFarmViewModel.Longitude != item.bombLongitude)
                        b.PositionId = GetPositionId(item.bombLatitude, item.bombLongitude);

                    farmMapped.AddBomb(b);
                }
                
                farmMapped.Name = vm.WizardFarmViewModel.Name;
                farmMapped.Company = vm.WizardFarmViewModel.Company;
                farmMapped.Address = vm.WizardFarmViewModel.Address;
                farmMapped.Phone = vm.WizardFarmViewModel.Phone;
                farmMapped.PositionId = lFarmPositionId;
                farmMapped.Has = vm.WizardFarmViewModel.Has;
                farmMapped.WeatherStationId = vm.WizardFarmViewModel.WeatherStationId;
                farmMapped.CityId = vm.WizardFarmViewModel.CityId;
 
                db.SaveChanges();

                //return RedirectToAction("Index");
            }

            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml",vm);
        }

        #region private methondaux

        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud( pLatitude, pLongitude);
        }

        private List<System.Web.Mvc.SelectListItem> LoadCities(long? cityId = null, City city = null)
        {

            CityConfiguration cc = new CityConfiguration();

            List<City> cities = cc.GetAllCities();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in cities)
            {

                bool isSelected = false;
                if (city != null && cityId.HasValue)
                {
                    isSelected = (city.CityId == cityId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.CityId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }

        private List<System.Web.Mvc.SelectListItem> LoadWeatherStations(long? weatherStationId = null, WeatherStation weatherStation = null)
        {
            WeatherStationConfiguration wsc = new WeatherStationConfiguration();

            List<WeatherStation> weatherStations = wsc.GetAllWeatherStations();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in weatherStations)
            {

                bool isSelected = false;
                if (weatherStation != null && weatherStationId.HasValue)
                {
                    isSelected = (weatherStation.WeatherStationId == weatherStationId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.WeatherStationId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
        #endregion


    }
}
