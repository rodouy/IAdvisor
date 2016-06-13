using System;
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
    public class TemperatureDatasController : Controller
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        // GET: TemperatureDatas
        public ActionResult Index()
        {
            var temperatureDatas = db.TemperatureDatas.Include(t => t.Region);
            return View(temperatureDatas.ToList());
        }

        // GET: TemperatureDatas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TemperatureData temperatureData = db.TemperatureDatas.Find(id);
            if (temperatureData == null)
            {
                return HttpNotFound();
            }
            return View(temperatureData);
        }

        // GET: TemperatureDatas/Create
        public ActionResult Create()
        {
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name");
            return View();
        }

        // POST: TemperatureDatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TemperatureDataId,Name,Date,RegionId,Min,Max,Average,ETC,Rain")] TemperatureData temperatureData)
        {
            if (ModelState.IsValid)
            {
                db.TemperatureDatas.Add(temperatureData);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", temperatureData.RegionId);
            return View(temperatureData);
        }

        // GET: TemperatureDatas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TemperatureData temperatureData = db.TemperatureDatas.Find(id);
            if (temperatureData == null)
            {
                return HttpNotFound();
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", temperatureData.RegionId);
            return View(temperatureData);
        }

        // POST: TemperatureDatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TemperatureDataId,Name,Date,RegionId,Min,Max,Average,ETC,Rain")] TemperatureData temperatureData)
        {
            if (ModelState.IsValid)
            {
                db.Entry(temperatureData).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RegionId = new SelectList(db.Regions, "RegionId", "Name", temperatureData.RegionId);
            return View(temperatureData);
        }

        // GET: TemperatureDatas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TemperatureData temperatureData = db.TemperatureDatas.Find(id);
            if (temperatureData == null)
            {
                return HttpNotFound();
            }
            return View(temperatureData);
        }

        // POST: TemperatureDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            TemperatureData temperatureData = db.TemperatureDatas.Find(id);
            db.TemperatureDatas.Remove(temperatureData);
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
