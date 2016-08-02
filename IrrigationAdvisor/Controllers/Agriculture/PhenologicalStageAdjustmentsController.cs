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
    public class PhenologicalStageAdjustmentsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        
        // GET: PhenologicalStageAdjustments
        public ActionResult Index()
        {
            var phenologicalStageAdjustments = db.PhenologicalStageAdjustments.Include(p => p.Crop).Include(p => p.PhenologicalStage).Include(p => p.Stage);
            return View(phenologicalStageAdjustments.ToList());
        }

        // GET: PhenologicalStageAdjustments/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStageAdjustment phenologicalStageAdjustment = db.PhenologicalStageAdjustments.Find(id);
            if (phenologicalStageAdjustment == null)
            {
                return HttpNotFound();
            }
            return View(phenologicalStageAdjustment);
        }

        // GET: PhenologicalStageAdjustments/Create
        public ActionResult Create()
        {
            ViewBag.CropId = new SelectList(db.Crops, "CropId", "Name");
            ViewBag.PhenologicalStageId = new SelectList(db.PhenologicalStages, "PhenologicalStageId", "PhenologicalStageId");
            ViewBag.StageId = new SelectList(db.Stages, "StageId", "Name");
            return View();
        }

        // POST: PhenologicalStageAdjustments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhenologicalStageAdjustmentId,Name,CropId,DateOfChange,StageId,PhenologicalStageId,Observation")] PhenologicalStageAdjustment phenologicalStageAdjustment)
        {
            if (ModelState.IsValid)
            {
                db.PhenologicalStageAdjustments.Add(phenologicalStageAdjustment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CropId = new SelectList(db.Crops, "CropId", "Name", phenologicalStageAdjustment.CropId);
            ViewBag.PhenologicalStageId = new SelectList(db.PhenologicalStages, "PhenologicalStageId", "PhenologicalStageId", phenologicalStageAdjustment.PhenologicalStageId);
            ViewBag.StageId = new SelectList(db.Stages, "StageId", "Name", phenologicalStageAdjustment.StageId);
            return View(phenologicalStageAdjustment);
        }

        // GET: PhenologicalStageAdjustments/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStageAdjustment phenologicalStageAdjustment = db.PhenologicalStageAdjustments.Find(id);
            if (phenologicalStageAdjustment == null)
            {
                return HttpNotFound();
            }
            ViewBag.CropId = new SelectList(db.Crops, "CropId", "Name", phenologicalStageAdjustment.CropId);
            ViewBag.PhenologicalStageId = new SelectList(db.PhenologicalStages, "PhenologicalStageId", "PhenologicalStageId", phenologicalStageAdjustment.PhenologicalStageId);
            ViewBag.StageId = new SelectList(db.Stages, "StageId", "Name", phenologicalStageAdjustment.StageId);
            return View(phenologicalStageAdjustment);
        }

        // POST: PhenologicalStageAdjustments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhenologicalStageAdjustmentId,Name,CropId,DateOfChange,StageId,PhenologicalStageId,Observation")] PhenologicalStageAdjustment phenologicalStageAdjustment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phenologicalStageAdjustment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CropId = new SelectList(db.Crops, "CropId", "Name", phenologicalStageAdjustment.CropId);
            ViewBag.PhenologicalStageId = new SelectList(db.PhenologicalStages, "PhenologicalStageId", "PhenologicalStageId", phenologicalStageAdjustment.PhenologicalStageId);
            ViewBag.StageId = new SelectList(db.Stages, "StageId", "Name", phenologicalStageAdjustment.StageId);
            return View(phenologicalStageAdjustment);
        }

        // GET: PhenologicalStageAdjustments/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStageAdjustment phenologicalStageAdjustment = db.PhenologicalStageAdjustments.Find(id);
            if (phenologicalStageAdjustment == null)
            {
                return HttpNotFound();
            }
            return View(phenologicalStageAdjustment);
        }

        // POST: PhenologicalStageAdjustments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PhenologicalStageAdjustment phenologicalStageAdjustment = db.PhenologicalStageAdjustments.Find(id);
            db.PhenologicalStageAdjustments.Remove(phenologicalStageAdjustment);
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
