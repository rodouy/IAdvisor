using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.ViewModels.Wizard;

using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.DBContext.Weather;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.ViewModels.Localization;
using Newtonsoft.Json;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Controllers.Localization
{
    public class FarmsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Farms
        public ActionResult Index()
        {

            return View("~/Views/Localization/Farms/Index.cshtml", db.Farms.ToList().Where(f => f.IsActive== true));

        }

        // GET: Users/Wizard
        public ActionResult Wizard()
        {

            WizardFarmViewModel vm = new WizardFarmViewModel();
            vm.City = this.LoadCity();
            vm.WeatherStation = this.LoadWeatherStation();
            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml", vm);


        }

        // GET: Farms/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farm farm = db.Farms.Find(id);
            
            if (farm == null)
            {
                return HttpNotFound();
            }


            FarmViewModel vm = new FarmViewModel(farm);
            vm.Cities = this.LoadCity(farm.CityId, farm);
            vm.Countries = this.LoadCountry();
            vm.WeatherStations = this.LoadWeatherStation(farm.WeatherStationId, farm);
            return View("~/Views/Localization/Farms/Edit.cshtml", vm);
            
        }

        // GET: Farms/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farm farm = db.Farms.Find(id);
            if (farm == null)
            {
                return HttpNotFound();
            }
            FarmViewModel vm = new FarmViewModel(farm);
            vm.Cities = this.LoadCity(farm.CityId, farm);
            vm.Countries = this.LoadCountry();
            vm.WeatherStations = this.LoadWeatherStation(farm.WeatherStationId, farm);
            
            return View("~/Views/Localization/Farms/Details.cshtml", vm);
        }

        // GET: Farms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create;
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, Company, Phone, Address, Latitude, Longitude, Has, WeatherStationId, CityId, BombsHidden")] WizardFarmViewModel vm)
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
                    positionFarm.Name = vm.Name + " - Establecimiento";
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
                    double bombLongitude = Convert.ToDouble((String)item.bombLongitude);

                    Bomb newbomb = new Bomb();
                    newbomb.Name = vm.Name + " - " + item.bombShortName;
                    newbomb.ShortName = item.bombShortName;
                    newbomb.SerialNumber = item.serialNumber;

                    newbomb.ServiceDate = ((String)item.serviceDate == "") ? Utils.MIN_DATETIME : item.serviceDate;
                    newbomb.PurchaseDate = ((String)item.purchaseDate == "") ? Utils.MIN_DATETIME : item.purchaseDate;

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
                            positionBomb.Name = Convert.ToString(item.bombLatitude) + " - " + Convert.ToString(item.bombLatitude);
                            newbomb.Position = positionBomb;
                        }
                        else
                        {
                            newbomb.PositionId = lBombPositionId;
                        }
                    }
                    else
                    {
                        newbomb.PositionId = lFarmPositionId;
                    }

                    farmMapped.AddBomb(newbomb);
                }

                farmMapped.Name = vm.Name;
                farmMapped.Company = vm.Company;
                farmMapped.Address = vm.Address;
                farmMapped.Phone = vm.Phone;
                farmMapped.Has = vm.Has;
                farmMapped.WeatherStationId = vm.WeatherStationId;
                farmMapped.CityId = vm.CityId;

                db.Farms.Add(farmMapped);
                db.SaveChanges();


            }
            return Redirect("/Farms");
            //return View("~/Views/Localization/Farms/Index.cshtml", db.Farms.ToList());

        }

        // POST: Farms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FarmId,Name,Company,Address,Phone,Has,CityId,IrrigationUnitReportShowAvailableWater,IrrigationUnitReportShowEvapotranspiration,IrrigationUnitReportShowTemperature,WeatherStationId")] Farm farm)
        {
            if (ModelState.IsValid)           
            {
                Farm updatedFarm = db.Farms.Find(farm.FarmId);
                if (updatedFarm == null)
                {
                    return HttpNotFound();
                }

                updatedFarm.Name = farm.Name;
                updatedFarm.Company = farm.Company;
                updatedFarm.Address = farm.Address;
                updatedFarm.Phone = farm.Phone;
                updatedFarm.Has = farm.Has;
                updatedFarm.CityId = farm.CityId;
                updatedFarm.IrrigationUnitReportShowAvailableWater = farm.IrrigationUnitReportShowAvailableWater;
                updatedFarm.IrrigationUnitReportShowEvapotranspiration = farm.IrrigationUnitReportShowEvapotranspiration;
                updatedFarm.IrrigationUnitReportShowTemperature = farm.IrrigationUnitReportShowTemperature;
                updatedFarm.WeatherStationId = farm.WeatherStationId;

                db.Entry(updatedFarm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(farm);
        }

        // GET: Farms/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Farm farm = db.Farms.Find(id);
            if (farm == null)
            {
                return HttpNotFound();
            }
            FarmViewModel vm = new FarmViewModel(farm);
            vm.Cities = this.LoadCity(farm.CityId, farm);
            vm.Countries = this.LoadCountry();
            vm.WeatherStations = this.LoadWeatherStation(farm.WeatherStationId, farm);

            return View("~/Views/Localization/Farms/Delete.cshtml", vm);

        }

        // POST: Farms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Farm updatedFarm = db.Farms.Find(id);
            if (updatedFarm == null)
            {
                return HttpNotFound();
            }

            FarmConfiguration fc = new FarmConfiguration();
            Farm farm = db.Farms.Find(id);

            fc.Disable(farm);
            db.SaveChanges();
            //updatedFarm.IsActive = false;

            //db.Entry(updatedFarm).State = EntityState.Modified;
            //db.SaveChanges();
                 
            return RedirectToAction("Index");
        }

        private List<System.Web.Mvc.SelectListItem> LoadWeatherStation(long? weatherStationId = null, Farm farm = null)
        {
            WeatherStationConfiguration rc = new WeatherStationConfiguration();
            List<WeatherStation> weatherStationConfiguration = rc.GetAllWeatherStations();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in weatherStationConfiguration)
            {

                bool isSelected = false;

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

        private List<System.Web.Mvc.SelectListItem> LoadCity(long? cityId = null, Farm farm = null)
        {
            CityConfiguration rc = new CityConfiguration();
            List<City> cityConfiguration = rc.GetAllCities();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in cityConfiguration)
            {

                bool isSelected = false;

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

        private List<System.Web.Mvc.SelectListItem> LoadCountry(long? countryId = null)
        {
            CountryConfiguration rc = new CountryConfiguration();
            List<Country> countryList = rc.GetAllCountries ();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in countryList)
            {
                bool isSelected = false;

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.CountryId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };
                result.Add(sl);
            }
            return result;
        }

        public JsonResult GetCities()
        {
            CityConfiguration rc = new CityConfiguration();
            List<City> cityConfiguration = rc.GetAllCities();
            return Json(cityConfiguration, JsonRequestBehavior.AllowGet);   
        }

        
        [HttpGet]
        public JsonResult AddCity(String pCityName, int pCountryId, String pCityLatitude, String pCityLongitude)
        {
            //CityConfiguration rc = new CityConfiguration();

            Position lPosition = new Position();
            lPosition.Name = pCityName;
            lPosition.Latitude = double.Parse(pCityLatitude);
            lPosition.Longitude = double.Parse(pCityLongitude);
            db.Positions.Add(lPosition);

            City lCity = new City();
            lCity.Name = pCityName;
            lCity.Position = lPosition;
            lCity.CountryId = pCountryId;
            db.Cities.Add(lCity);
            db.SaveChanges();

            return Json(new { success = true, responseText = lCity.CityId }, JsonRequestBehavior.AllowGet);

        }
   
            #region private methondaux

        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud(pLatitude, pLongitude);
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
