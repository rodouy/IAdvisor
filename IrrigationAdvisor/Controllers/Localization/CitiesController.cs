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

using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Language;

namespace IrrigationAdvisor.Controllers.Localization
{
    public class CitiesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Cities
        public ActionResult Index()
        {
            //var cities = db.Cities.Include(c => c.Country);

            return View("~/Views/Localization/Cities/Index.cshtml", db.Cities.ToList());

        }

        // GET: Cities/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            CityViewModel vm = new CityViewModel();
            vm.CityId = city.CityId;
            vm.PositionId = city.PositionId;
            vm.Name = city.Name;
            vm.Longitude = city.Position.Longitude;
            vm.Latitude = city.Position.Latitude;
            vm.CountryId = city.CountryId;

            Country lCountry = db.Countries.Find(city.CountryId);
            if (lCountry != null)
                vm.CountryName = lCountry.Name;

            return View("~/Views/Localization/Cities/Details.cshtml", vm);

        }

        // GET: Cities/Create
        public ActionResult Create()
        {

            CityViewModel vm = new CityViewModel();
            vm.Countries = this.LoadCountries();
            vm.Languages = this.LoadLanguages();
            return View("~/Views/Localization/Cities/Create.cshtml", vm);
        }

        // POST: Cities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CityId, Name, Latitude, Longitude, CountryId, CountryName, CountryLanguageId")] CityViewModel cityViewModelMapped)
        {
            if (ModelState.IsValid)
            {
                City city = new City(); 
                
                long positionId = GetPositionId(cityViewModelMapped.Latitude, cityViewModelMapped.Longitude);
                Position positionCity = new Position();
                //Not exist position
                if (positionId == 0)
                {
                    positionCity.Latitude = cityViewModelMapped.Latitude;
                    positionCity.Longitude = cityViewModelMapped.Longitude;
                    positionCity.Name = cityViewModelMapped.Name + " - Ciudad";
                    city.Position = positionCity;
                }
                else
                {
                    city.PositionId = positionId;
                }

                Country country;
                if (cityViewModelMapped.CountryId == -1) //es una nueva pais, se debe ingresar.
                {
                    CountryConfiguration lCountryConfiguration = new CountryConfiguration();
                    country = new Country();
                    country.Name = cityViewModelMapped.CountryName;
                    country.LanguageId = cityViewModelMapped.CountryLanguageId;
                    db.Countries.Add(country);
                    city.Country = country;
                    db.SaveChanges();
                    city.CountryId = lCountryConfiguration.GetMaxCountryId();
                }
                else 
                {
                    city.CountryId = cityViewModelMapped.CountryId;
                }

                city.Name = cityViewModelMapped.Name;

                db.Cities.Add(city);
                db.SaveChanges();

            }

            return View("~/Views/Localization/Cities/Index.cshtml", db.Cities.ToList());
        }

        // GET: Cities/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            CityViewModel vm = new CityViewModel();
            vm.CityId = city.CityId;
            vm.PositionId = city.PositionId;
            vm.Name = city.Name;
            vm.Longitude = city.Position.Longitude;
            vm.Latitude = city.Position.Latitude;
            vm.CountryId = city.CountryId;
            vm.Countries = this.LoadCountries();

            return View("~/Views/Localization/Cities/Edit.cshtml", vm);

        }

        // POST: Cities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CityId, Name, Latitude, Longitude, PositionId, CountryId")] CityViewModel cityViewModelMapped)
        {
            if (ModelState.IsValid)
            {
                Position lPosition = db.Positions.Find(cityViewModelMapped.PositionId);
                lPosition.Latitude = cityViewModelMapped.Latitude;
                lPosition.Longitude = cityViewModelMapped.Longitude;

                City lCity = db.Cities.Find(cityViewModelMapped.CityId);
                lCity.Name = cityViewModelMapped.Name;
                lCity.CountryId = cityViewModelMapped.CountryId;

                db.Entry(lPosition).State = EntityState.Modified;
                db.Entry(lCity).State = EntityState.Modified;
                db.SaveChanges();

            }
            return View("~/Views/Localization/Cities/Index.cshtml", db.Cities.ToList());
        }

        // GET: Cities/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            City city = db.Cities.Find(id);
            if (city == null)
            {
                return HttpNotFound();
            }
            CityViewModel vm = new CityViewModel();
            vm.CityId = city.CityId;
            vm.PositionId = city.PositionId;
            vm.Name = city.Name;
            vm.Longitude = city.Position.Longitude;
            vm.Latitude = city.Position.Latitude;
            vm.CountryId = city.CountryId;

            Country lCountry = db.Countries.Find(city.CountryId);
            if (lCountry != null)
                vm.CountryName = lCountry.Name;

            return View("~/Views/Localization/Cities/Delete.cshtml", vm);
        }

        // POST: Cities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            City city = db.Cities.Find(id);
            db.Cities.Remove(city);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<System.Web.Mvc.SelectListItem> LoadCountries(long? countryId = null, City city = null)
        {
            CountryConfiguration cc = new CountryConfiguration();

            List<Country> countries = cc.GetAllCountries();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in countries)
            {

                bool isSelected = false;
                if (city != null && countryId.HasValue)
                {
                    isSelected = (city.CountryId == countryId);
                }

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


        private List<System.Web.Mvc.SelectListItem> LoadLanguages(long? languageId = null, Country country = null)
        {
            LanguageConfiguration lc = new LanguageConfiguration();
            List<IrrigationAdvisor.Models.Language.Language> roles = lc.GetAllLanguages();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in roles)
            {

                bool isSelected = false;
                if (country != null && languageId.HasValue)
                {
                    isSelected = (country.LanguageId == languageId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.LanguageId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud(pLatitude, pLongitude);
        }

    }
}
