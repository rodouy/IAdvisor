using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConfigurationManager.DataAccess;

namespace ConfigurationManager.Controllers
{
    public class DecimalValuesController : Controller
    {
        private ConfigurationManagerEntities db = new ConfigurationManagerEntities();

        // GET: DecimalValues
        public ActionResult Index()
        {
            return View(db.DecimalValues.ToList());
        }

        // GET: DecimalValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DecimalValues decimalValues = db.DecimalValues.Find(id);
            if (decimalValues == null)
            {
                return HttpNotFound();
            }
            return View(decimalValues);
        }

        // GET: DecimalValues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DecimalValues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DecimalValuesId,Name,Value,CreationDate,LastModificationBy")] DecimalValues decimalValues)
        {
            if (ModelState.IsValid)
            {
                MeController meController = new MeController();

                decimalValues.CreationDate = DateTime.Now;
                decimalValues.LastModificationBy = meController.Get().UserName;
                db.DecimalValues.Add(decimalValues);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(decimalValues);
        }

        // GET: DecimalValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DecimalValues decimalValues = db.DecimalValues.Find(id);
            if (decimalValues == null)
            {
                return HttpNotFound();
            }
            return View(decimalValues);
        }

        // POST: DecimalValues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DecimalValuesId,Name,Value,CreationDate,LastModificationBy")] DecimalValues decimalValues)
        {
            if (ModelState.IsValid)
            {
                db.Entry(decimalValues).State = EntityState.Modified;

                MeController meController = new MeController();

                decimalValues.CreationDate = DateTime.Now;
                decimalValues.LastModificationBy = meController.Get().UserName;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(decimalValues);
        }

        // GET: DecimalValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DecimalValues decimalValues = db.DecimalValues.Find(id);
            if (decimalValues == null)
            {
                return HttpNotFound();
            }
            return View(decimalValues);
        }

        // POST: DecimalValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DecimalValues decimalValues = db.DecimalValues.Find(id);
            db.DecimalValues.Remove(decimalValues);
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
