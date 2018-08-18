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

using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.ViewModels.Localization;
using IrrigationAdvisor.DBContext.Language;

namespace IrrigationAdvisor.Controllers.Localization
{
    public class CountriesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        
        // GET: Countries
        public ActionResult Index()
        {          
            return View("~/Views/Localization/Countries/Index.cshtml", db.Countries.ToList());
        }

        // GET: Countries/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }

            CountryViewModel vm = new CountryViewModel();
            vm.CountryId = country.CountryId;
            vm.Name = country.Name;
            vm.Capital = country.Capital;
            vm.Language = country.Language;
            City city = db.Cities.Find(country.CapitalId);
            vm.CapitalName = city.Name;
            vm.Languages = this.LoadLanguages();
            return View("~/Views/Localization/Countries/Details.cshtml",vm);

        }

        // GET: Countries/Create
        public ActionResult Create()
        {

            CountryViewModel vm = new CountryViewModel();

            vm.Capitals = this.LoadCities();
            vm.Languages = this.LoadLanguages ();
            return View("~/Views/Localization/Countries/Create.cshtml", vm);

        }

        // POST: Countries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CountryId,Name,LanguageId,CapitalId, CapitalName, CapitalLatitude, CapitalLongitude")] CountryViewModel countryMapped)
        {
            if (ModelState.IsValid)
            {
                long lLastCountryId;
                long lLastCityId;
                CountryConfiguration lCountryConfiguration;
                lCountryConfiguration = new CountryConfiguration(); 
                
                Country country = new Country();
               
                country.Name = countryMapped.Name;
                country.LanguageId = countryMapped.LanguageId;
                db.Countries.Add(country);
                db.SaveChanges();

                lLastCountryId = lCountryConfiguration.GetMaxCountryId();
                                
                City lCity;
                if (countryMapped.CapitalId == -1) //es una nueva ciudad, se debe ingresar.
                {
                    CityConfiguration lCityConfiguration;
                    lCityConfiguration = new CityConfiguration();

                    Position lPosition = new Position();
                    lCity = new City();
                    lCity.Name = countryMapped.CapitalName;
                    lPosition.Name = countryMapped.CapitalName + " - Ciudad";
                    lPosition.Latitude = double.Parse(countryMapped.CapitalLatitude);
                    lPosition.Longitude = double.Parse(countryMapped.CapitalLongitude);
                    lCity.Country = country;
                    lCity.CountryId = lLastCountryId;
                    db.Positions.Add(lPosition);
                    db.Cities.Add(lCity);
                    db.SaveChanges();
                    lLastCityId = lCityConfiguration.GetMaxCityId();
                }
                else
                {
                    lCity = db.Cities.Find(countryMapped.CapitalId);
                    lLastCityId = lCity.CityId;
                }

                //actualiza la informacion del pais con la capital
                country.Capital = lCity;
                country.CapitalId = lLastCityId;
                db.Entry(country).State = EntityState.Modified;
                db.SaveChanges();

              
            }
            return View("~/Views/Localization/Countries/Index.cshtml", db.Countries.ToList());
        }

        // GET: Countries/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }

            CountryViewModel vm = new CountryViewModel(country);
            vm.Capitals = this.LoadCities();
            vm.Languages = this.LoadLanguages();
            City city = db.Cities.Find(country.CapitalId);
            vm.CapitalName = city.Name;
            return View("~/Views/Localization/Countries/Edit.cshtml", vm);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CountryId,Name,LanguageId,CapitalId")] Country country)
        {
            if (ModelState.IsValid)
            {
                Country countryMapped = db.Countries.Find(country.CountryId);
                City capitalMapped = db.Cities.Find(country.CapitalId);
                countryMapped.Name = country.Name;
                countryMapped.CapitalId = country.CapitalId;
                countryMapped.LanguageId = country.LanguageId;
                countryMapped.Capital = capitalMapped;
                db.Entry(countryMapped).State = EntityState.Modified;
                db.SaveChanges();
                
            }
            return View("~/Views/Localization/Countries/Index.cshtml", db.Countries.ToList());

        }

        // GET: Countries/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Country country = db.Countries.Find(id);
            if (country == null)
            {
                return HttpNotFound();
            }

            CountryViewModel vm = new CountryViewModel(country);
            vm.Capitals = this.LoadCities();
            vm.Languages = this.LoadLanguages();
            City city = db.Cities.Find(country.CapitalId);
            vm.CapitalName = city.Name;
            return View("~/Views/Localization/Countries/Delete.cshtml", vm);

        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            try
            {
                Country country = db.Countries.Find(id);
                db.Countries.Remove(country);
                db.SaveChanges();
            }
                
            catch (Exception ex)
            {
                
            }
            return View("~/Views/Localization/Countries/Index.cshtml", db.Countries.ToList());
        }

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        private List<System.Web.Mvc.SelectListItem> LoadCities(long? cityId = null, Country country = null)
        {
            CityConfiguration cc = new CityConfiguration();

            List<City> cities = cc.GetAllCities();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in cities)
            {

                bool isSelected = false;
                if (country != null && cityId.HasValue)
                {
                    isSelected = (country.CapitalId == cityId);
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
    }
}
