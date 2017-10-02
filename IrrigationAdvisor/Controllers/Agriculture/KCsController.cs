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
    public class KCsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: KCs
        public ActionResult Index()
        {
            var kCs = db.KCs.Include(k => k.Specie);
            return View(kCs.ToList());
        }

        // GET: KCs/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KC kC = db.KCs.Find(id);
            if (kC == null)
            {
                return HttpNotFound();
            }
            return View(kC);
        }

        // GET: KCs/Create
        public ActionResult Create()
        {
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name");
            return View();
        }

        // POST: KCs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "KCId,SpecieId,DayAfterSowing,Coefficient")] KC kC)
        {
            if (ModelState.IsValid)
            {
                db.KCs.Add(kC);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", kC.SpecieId);
            return View(kC);
        }

        // GET: KCs/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KC kC = db.KCs.Find(id);
            if (kC == null)
            {
                return HttpNotFound();
            }
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", kC.SpecieId);
            return View(kC);
        }

        // POST: KCs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "KCId,SpecieId,DayAfterSowing,Coefficient")] KC kC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kC).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SpecieId = new SelectList(db.Species, "SpecieId", "Name", kC.SpecieId);
            return View(kC);
        }

        // GET: KCs/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KC kC = db.KCs.Find(id);
            if (kC == null)
            {
                return HttpNotFound();
            }
            return View(kC);
        }

        // POST: KCs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            KC kC = db.KCs.Find(id);
            db.KCs.Remove(kC);
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
