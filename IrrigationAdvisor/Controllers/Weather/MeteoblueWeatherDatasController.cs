using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ViewModels.Weather;

namespace IrrigationAdvisor.Views
{
    public class MeteoblueWeatherDatasController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: MeteoblueWeatherDatas
        public ActionResult Index(DateTime? dateFrom, DateTime? dateTo, int weatherStationId = 0)
        {
            if (!dateFrom.HasValue && !dateTo.HasValue && weatherStationId == 0)
            {
                return View(db.MeteoblueWeatherDatas
                            .Include(n => n.WeatherStation).ToList());
            }
            else
            {
                var query = db.MeteoblueWeatherDatas
                        .Include(n => n.WeatherStation)
                        .Where(n => n.WeatherDate >= dateFrom &&
                                    n.WeatherDate <= dateTo);

                if (weatherStationId > 0)
                {
                    query = query.Where(n => n.WeatherStationId == weatherStationId);
                }

                return View(query.ToList());
            }  
        }

        // GET: MeteoblueWeatherDatas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeteoblueWeatherData meteoblueWeatherData = db.MeteoblueWeatherDatas.Find(id);
            if (meteoblueWeatherData == null)
            {
                return HttpNotFound();
            }
            return View(meteoblueWeatherData);
        }

        // GET: MeteoblueWeatherDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeteoblueWeatherDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeteoblueWeatherDataId,WeatherStationId,WeatherDate,UvIndex,TemperatureMax,TemperatureMin,TemperatureMean,FeltTemperatureMax,FeltTemperatureMin,WindDirection,PrecipitationProbability,Rainspot,PredictabilityClass,Predictability,Precipitation,SnowFraction,SealevelPressureMax,SealevelPressureMin,SealevelPressureMean,WindSpeedMax,WindSpeedMean,WindSpeedMin,RelativeHumidityMax,RelativeHumidityMin,RelativehumidityMean,ConvectivePrecipitation,PrecipitationHours,HumidityGreater90Hours,SoilTemperatureMax,SoilTemperatureMin,SoilTemperatureMean,SoilMoistureMax,SoilMoistureMin,SoilMoistureMean,SkinTemperatureMax,SkinTemperatureMin,SkinTemperatureMean,Evapotranspiration,LeafWetnessIndex,PotentialEvapotranspiration,DewPointTemperatureMax,DewPointTemperatureMin,DewPointTemperatureMean,ReferenceEvapotranspirationFao,SensibleHeatFlux,LastModificationDate,BasicJson,BasicUrl,AgroJson,AgroUrl")] MeteoblueWeatherData meteoblueWeatherData)
        {
            if (ModelState.IsValid)
            {
                meteoblueWeatherData.LastModificationDate = DateTime.Now;
                db.MeteoblueWeatherDatas.Add(meteoblueWeatherData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meteoblueWeatherData);
        }

        // GET: MeteoblueWeatherDatas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeteoblueWeatherData meteoblueWeatherData = db.MeteoblueWeatherDatas.Find(id);
            if (meteoblueWeatherData == null)
            {
                return HttpNotFound();
            }
            return View(meteoblueWeatherData);
        }

        // POST: MeteoblueWeatherDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeteoblueWeatherDataId,WeatherStationId,WeatherDate,UvIndex,TemperatureMax,TemperatureMin,TemperatureMean,FeltTemperatureMax,FeltTemperatureMin,WindDirection,PrecipitationProbability,Rainspot,PredictabilityClass,Predictability,Precipitation,SnowFraction,SealevelPressureMax,SealevelPressureMin,SealevelPressureMean,WindSpeedMax,WindSpeedMean,WindSpeedMin,RelativeHumidityMax,RelativeHumidityMin,RelativehumidityMean,ConvectivePrecipitation,PrecipitationHours,HumidityGreater90Hours,SoilTemperatureMax,SoilTemperatureMin,SoilTemperatureMean,SoilMoistureMax,SoilMoistureMin,SoilMoistureMean,SkinTemperatureMax,SkinTemperatureMin,SkinTemperatureMean,Evapotranspiration,LeafWetnessIndex,PotentialEvapotranspiration,DewPointTemperatureMax,DewPointTemperatureMin,DewPointTemperatureMean,ReferenceEvapotranspirationFao,SensibleHeatFlux,LastModificationDate,BasicJson,BasicUrl,AgroJson,AgroUrl")] MeteoblueWeatherData meteoblueWeatherData)
        {
            if (ModelState.IsValid)
            {
                meteoblueWeatherData.LastModificationDate = DateTime.Now;
                db.Entry(meteoblueWeatherData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meteoblueWeatherData);
        }

        // GET: MeteoblueWeatherDatas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeteoblueWeatherData meteoblueWeatherData = db.MeteoblueWeatherDatas.Find(id);
            if (meteoblueWeatherData == null)
            {
                return HttpNotFound();
            }
            return View(meteoblueWeatherData);
        }

        // POST: MeteoblueWeatherDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            MeteoblueWeatherData meteoblueWeatherData = db.MeteoblueWeatherDatas.Find(id);
            db.MeteoblueWeatherDatas.Remove(meteoblueWeatherData);
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
    }
}
