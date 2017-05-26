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
using IrrigationAdvisor.Models.Utilities;




namespace IrrigationAdvisor.Controllers.Wizard
{
    public class WizardFarmBombController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        // GET: Users/Create
        public ActionResult Index()
        {
            //WizardFarmBombViewModel vm = new WizardFarmBombViewModel();

            WizardFarmViewModel vm = new WizardFarmViewModel();


            vm.City = this.LoadCities();
            vm.WeatherStation = this.LoadWeatherStations();

            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml", vm);
        }


        // POST: Users/Create;
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Company, Phone, Address, Latitude, Longitude, Has, WeatherStationId, CityId, BombsHidden")] WizardFarmViewModel vm)
        
        {
  
            if (ModelState.IsValid)
            {

                Farm farmMapped = new Farm();
                long lFarmPositionId = GetPositionId(vm.Latitude, vm.Longitude);
                long lBombPositionId;

                 Position positionFarm = new Position();              
                //Not exist position to farm
                 if (lFarmPositionId == 0)
                 {
                     positionFarm.Latitude = vm.Latitude;
                     positionFarm.Longitude = vm.Longitude;
                     positionFarm.Name = "DEFINIR El NOMBRE DE LA POS";
                     farmMapped.Position = positionFarm;
                 }
                 else
                 {
                     farmMapped.PositionId = lFarmPositionId;
                 }

                // working whit bombs
                dynamic items = JsonConvert.DeserializeObject(vm.BombsHidden);
                foreach (var item in items.items)
                {
                    double bombLatitud = Convert.ToDouble((String)(item.bombLatitude));
                    double bombLongitude =  Convert.ToDouble((String)item.bombLongitude);

                    Bomb b = new Bomb();
                    b.Name = item.bombName;
                    b.SerialNumber = item.serialNumber;

                    b.ServiceDate = ((String)item.serviceDate == "") ? Utils.MIN_DATETIME : item.serviceDate  ;
                    b.PurchaseDate = ((String)item.purchaseDate == "") ? Utils.MIN_DATETIME : item.purchaseDate;
                    
                    //position bomb is diferent to position farm, find position to bomb
                    if (vm.Latitude != bombLatitud || vm.Longitude != bombLongitude)
                    {
                        lBombPositionId = GetPositionId((double)item.bombLatitude, (double)item.bombLongitude);

                        //Not exist position to bomb
                        if (lBombPositionId == 0)
                        {
                            Position positionBomb = new Position();
                            positionBomb.Latitude = item.bombLatitude;
                            positionBomb.Longitude = item.bombLongitude;
                            positionBomb.Name = "DEFINIR El NOMBRE DE LA POS";
                            b.Position = positionBomb;
                        }
                        else
                        {
                            b.PositionId = lBombPositionId;
                        }
                    }
                    else
                    {
                        b.PositionId = lFarmPositionId;
                    }

                    farmMapped.AddBomb(b); 
                }

                farmMapped.Name = vm.Name;
                farmMapped.Company = vm.Company;
                farmMapped.Address = vm.Address;
                farmMapped.Phone = vm.Phone;
                farmMapped.Has = vm.Has;
                farmMapped.WeatherStationId = vm.WeatherStationId;
                farmMapped.CityId = vm.CityId;
 
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
