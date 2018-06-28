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

namespace IrrigationAdvisor.Controllers.Localization
{
    public class FarmsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Farms
        public ActionResult Index()
        {

            return View("~/Views/Localization/Farms/Index.cshtml", db.Farms.ToList());

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

        // POST: Farms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FarmId,Name,Address,Phone,Has")] Farm farm)
        {
            if (ModelState.IsValid)
            {
                db.Farms.Add(farm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(farm);
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
            //Farm farm = db.Farms.Find(id);
            //db.Farms.Remove(farm);
            //db.SaveChanges();
            Farm updatedFarm = db.Farms.Find(id);
            if (updatedFarm == null)
            {
                return HttpNotFound();
            }
            updatedFarm.IsActive = false;

            db.Entry(updatedFarm).State = EntityState.Modified;
            db.SaveChanges();
          
            
            return RedirectToAction("Index");
        }

        /*        protected override void Dispose(bool disposing)
                {
                    if (disposing)
                    {
                        db.Dispose();
                    }
                    base.Dispose(disposing);
                }
         * */
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
    }

}
