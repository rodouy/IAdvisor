using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Agriculture;

using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class DryMassesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: DryMasses
        public ActionResult Index()
        {
            var dryMasses = db.DryMasses.Include(d => d.Season).Include(d => d.Specie);
            return View(dryMasses.ToList());
        }

        // GET: DryMasses/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DryMass dryMass = db.DryMasses.Find(id);
            if (dryMass == null)
            {
                return HttpNotFound();
            }
            return View(dryMass);
        }

        // GET: DryMasses/Create
        public ActionResult Create()
        {
            ViewBag.SeasonId = new SelectList(db.Seasons, "SeasonId", "Name");
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name");
            return View();
        }

        // POST: DryMasses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DryMassId,Name,SpecieId,AgeOfCrop,SeasonId,Day,WeightPerHectareInKG,Exponent,Multiplier,Coefficient,RootDepth")] DryMass dryMass)
        {
            if (ModelState.IsValid)
            {
                db.DryMasses.Add(dryMass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SeasonId = new SelectList(db.Seasons, "SeasonId", "Name", dryMass.SeasonId);
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", dryMass.SpecieId);
            return View(dryMass);
        }

        // GET: DryMasses/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DryMass dryMass = db.DryMasses.Find(id);
            if (dryMass == null)
            {
                return HttpNotFound();
            }
            ViewBag.SeasonId = new SelectList(db.Seasons, "SeasonId", "Name", dryMass.SeasonId);
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", dryMass.SpecieId);
            return View(dryMass);
        }

        // POST: DryMasses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DryMassId,Name,SpecieId,AgeOfCrop,SeasonId,Day,RatePerHectareByDay,InitialWeightPerHectareInKG,WeightPerHectareInKG,Exponent,Multiplier,MaxCoefficient,Coefficient,RootDepth")] DryMassRemainder dryMass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dryMass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SeasonId = new SelectList(db.Seasons, "SeasonId", "Name", dryMass.SeasonId);
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", dryMass.SpecieId);
            return View(dryMass);
        }

        // GET: DryMasses/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DryMass dryMass = db.DryMasses.Find(id);
            if (dryMass == null)
            {
                return HttpNotFound();
            }
            return View(dryMass);
        }

        // POST: DryMasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            DryMass dryMass = db.DryMasses.Find(id);
            db.DryMasses.Remove(dryMass);
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
