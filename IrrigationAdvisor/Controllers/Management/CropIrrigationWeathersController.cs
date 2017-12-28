using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Management;

using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext.Weather;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ViewModels.Management;

namespace IrrigationAdvisor.Controllers.Management
{
    public class CropIrrigationWeathersController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: CropIrrigationWeathers
        public ActionResult Index()
        {
            //return View(db.CropIrrigationWeathers.ToList());
            IrrigationAdvisorContext.Refresh();
            var lCropIrrigationWeathers = db.CropIrrigationWeathers.Include(m => m.MainWeatherStation)
                .Include(a => a.AlternativeWeatherStation);

            return View("~/Views/Management/CropIrrigationWeathers/Index.cshtml", lCropIrrigationWeathers.ToList());
        }

        // GET: CropIrrigationWeathers/Details/5
        public ActionResult Details(long? id)
        {
            IrrigationAdvisorContext.Refresh();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            if (cropIrrigationWeather == null)
            {
                return HttpNotFound();
            }

            return View("~/Views/Management/CropIrrigationWeathers/Details.cshtml", cropIrrigationWeather);
        }

        // GET: CropIrrigationWeathers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CropIrrigationWeathers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropIrrigationWeatherId,SowingDate,HarvestDate,CropDate,HydricBalance,SoilHydricVolume,TotalEvapotranspirationCropFromLastWaterInput,DaysAfterSowing,DaysAfterSowingModified,GrowingDegreeDaysAccumulated,GrowingDegreeDaysModified,PredeterminatedIrrigationQuantity,LastWaterInputDate,LastBigWaterInputDate,LastPartialWaterInputDate,LastPartialWaterInput,UsingMainWeatherStation,TotalEvapotranspirationCrop,TotalEffectiveRain,TotalRealRain,TotalIrrigation,TotalIrrigationInHydricBalance,TotalExtraIrrigation,TotalExtraIrrigationInHydricBalance,OutPut")] CropIrrigationWeather cropIrrigationWeather)
        {
            if (ModelState.IsValid)
            {
                db.CropIrrigationWeathers.Add(cropIrrigationWeather);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cropIrrigationWeather);
        }

        // GET: CropIrrigationWeathers/Edit/5
        public ActionResult EditShort(long? id)
        {
            IrrigationAdvisorContext.Refresh();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropIrrigationWeatherShortViewModel ciwS = new CropIrrigationWeatherShortViewModel();

            CropIrrigationWeather ciw = db.CropIrrigationWeathers.Find(id);
            if (ciw == null)
            {
                return HttpNotFound();
            }

            ciwS.CropIrrigationWeatherName = ciw.CropIrrigationWeatherName;
            ciwS.MainWeatherStationId = ciw.MainWeatherStationId;
            ciwS.AlternativeWeatherStationId = ciw.AlternativeWeatherStationId;
            ciwS.MainWeatherStation = this.LoadMainWeatherStation(ciw.MainWeatherStationId, ciw);
            ciwS.AlternativeWeatherStation = this.LoadAlternativeWeatherStation(ciw.AlternativeWeatherStationId, ciw);

            return View("~/Views/Management/CropIrrigationWeathers/EditShort.cshtml", ciwS);
        }

        // POST: CropIrrigationWeathers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropIrrigationWeatherId,SowingDate,HarvestDate,CropDate,HydricBalance,SoilHydricVolume,TotalEvapotranspirationCropFromLastWaterInput,DaysAfterSowing,DaysAfterSowingModified,GrowingDegreeDaysAccumulated,GrowingDegreeDaysModified,PredeterminatedIrrigationQuantity,LastWaterInputDate,LastBigWaterInputDate,LastPartialWaterInputDate,LastPartialWaterInput,UsingMainWeatherStation,TotalEvapotranspirationCrop,TotalEffectiveRain,TotalRealRain,TotalIrrigation,TotalIrrigationInHydricBalance,TotalExtraIrrigation,TotalExtraIrrigationInHydricBalance,OutPut")] CropIrrigationWeather cropIrrigationWeather)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cropIrrigationWeather).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cropIrrigationWeather);
        }

        // GET: CropIrrigationWeathers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            if (cropIrrigationWeather == null)
            {
                return HttpNotFound();
            }
            return View(cropIrrigationWeather);
        }

        // POST: CropIrrigationWeathers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            CropIrrigationWeather cropIrrigationWeather = db.CropIrrigationWeathers.Find(id);
            db.CropIrrigationWeathers.Remove(cropIrrigationWeather);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private List<System.Web.Mvc.SelectListItem> LoadMainWeatherStation(long? weatherStationId = null, CropIrrigationWeather cropIrrigationWeather = null)
        {
            WeatherStationConfiguration wsc = new WeatherStationConfiguration();
            List<WeatherStation> ws = wsc.GetAllWeatherStations();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in ws)
            {
                bool isSelected = false;
                if (cropIrrigationWeather != null && weatherStationId.HasValue)
                {
                    isSelected = (cropIrrigationWeather.MainWeatherStationId == weatherStationId);
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

        private List<System.Web.Mvc.SelectListItem> LoadAlternativeWeatherStation(long? weatherStationId = null, CropIrrigationWeather cropIrrigationWeather = null)
        {
            WeatherStationConfiguration wsc = new WeatherStationConfiguration();

            List<WeatherStation> ws = wsc.GetAllWeatherStations();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in ws)
            {
                bool isSelected = false;
                if (cropIrrigationWeather != null && weatherStationId.HasValue)
                {
                    isSelected = (cropIrrigationWeather.AlternativeWeatherStationId == weatherStationId);
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
    }
}
