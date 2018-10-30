﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Weather;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Weather
{
    public class WeatherDatasController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();
        

        [HttpGet()]
        public ActionResult Index(string pStartDateTime, string pEndDateTime, int pWeatherStationId = 0)
        {
            DateTime from = Convert.ToDateTime(pStartDateTime);
            DateTime end = Convert.ToDateTime(pEndDateTime);
            DateTime now = DateTime.Now;

            if (pStartDateTime == null && pEndDateTime == null && pWeatherStationId == 0)
            {
                return View(db.WeatherDatas.Where(w => w.Date.Year == now.Year && w.Date.Month == now.Month && w.Date.Day == now.Day).ToList());
            }
            else if(pStartDateTime != null && pEndDateTime != null && pWeatherStationId != 0)
            {
                return View(db.WeatherDatas.Where(w => w.Date >= from && w.Date <= end && w.WeatherStationId == pWeatherStationId).ToList());
            }
            else if (pWeatherStationId == 0)
            {
                return View(db.WeatherDatas.Where(w => w.Date >= from && w.Date <= end).ToList());
            }
            else
            {
                return View(db.WeatherDatas.ToList());
            }
        }

        // GET: WeatherDatas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherData weatherData = db.WeatherDatas.Find(id);
            if (weatherData == null)
            {
                return HttpNotFound();
            }
            return View(weatherData);
        }

        // GET: WeatherDatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WeatherDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeatherDataId,WeatherStationId,Date,Temperature,TemperatureMax,TemperatureMin,TemperatureDewPoint,Humidity,HumidityMax,HumidityMin,Barometer,BarometerMax,BarometerMin,SolarRadiation,UVRadiation,RainDay,RainStorm,RainMonth,RainYear,Evapotranspiration,EvapotranspirationMonth,EvapotranspirationYear,WindSpeed,Observations,WeatherDataType,WeatherDataInputType")] WeatherData weatherData)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    if(weatherData.TemperatureMax != null && weatherData.TemperatureMin != null)
                    {
                        weatherData.Temperature = weatherData.TemperatureMax + weatherData.TemperatureMin / 2;
                    }
                    weatherData.WeatherDataInputType = Models.Utilities.Utils.WeatherDataInputType.WebInsert;
                    db.WeatherDatas.Add(weatherData);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }

            return View(weatherData);
        }

        // GET: WeatherDatas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherData weatherData = db.WeatherDatas.Find(id);
            if (weatherData == null)
            {
                return HttpNotFound();
            }
            return View(weatherData);
        }

        // POST: WeatherDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeatherDataId,WeatherStationId,Date,Temperature,TemperatureMax,TemperatureMin,TemperatureDewPoint,Humidity,HumidityMax,HumidityMin,Barometer,BarometerMax,BarometerMin,SolarRadiation,UVRadiation,RainDay,RainStorm,RainMonth,RainYear,Evapotranspiration,EvapotranspirationMonth,EvapotranspirationYear,WindSpeed,Observations,WeatherDataType,WeatherDataInputType")] WeatherData weatherData)
        {
            if (ModelState.IsValid)
            {
                WeatherData updatedWeatherData = db.WeatherDatas.Find(weatherData.WeatherDataId);

                updatedWeatherData.WeatherDataInputType = Models.Utilities.Utils.WeatherDataInputType.WebInsert;
                if (weatherData.TemperatureMax != null && weatherData.TemperatureMin != null)
                {
                    updatedWeatherData.Temperature = weatherData.TemperatureMax + weatherData.TemperatureMin / 2;
                }
                else
                {
                    updatedWeatherData.Temperature = weatherData.Temperature;
                }
                updatedWeatherData.TemperatureMin = weatherData.TemperatureMin;
                updatedWeatherData.TemperatureMax = weatherData.TemperatureMax;
                updatedWeatherData.WeatherStationId = weatherData.WeatherStationId;
                updatedWeatherData.Evapotranspiration = weatherData.Evapotranspiration;
                updatedWeatherData.Date = weatherData.Date;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(weatherData);
        }

        // GET: WeatherDatas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherData weatherData = db.WeatherDatas.Find(id);
            if (weatherData == null)
            {
                return HttpNotFound();
            }
            return View(weatherData);
        }

        // POST: WeatherDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            WeatherData weatherData = db.WeatherDatas.Find(id);
            db.WeatherDatas.Remove(weatherData);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public JsonResult GetAllWeatherStations()
        {
            return Json(db.WeatherStations.ToList(), JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            //if (disposing)
            //{
            //    db.Dispose();
            //}
            //base.Dispose(disposing);
        }
    }
}
