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
    public class IntegerValuesController : Controller
    {
        private ConfigurationManagerEntities db = new ConfigurationManagerEntities();

        // GET: IntegerValues
        public ActionResult Index()
        {
            return View(db.IntegerValues.ToList());
        }

        // GET: IntegerValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IntegerValues integerValues = db.IntegerValues.Find(id);
            if (integerValues == null)
            {
                return HttpNotFound();
            }
            return View(integerValues);
        }

        // GET: IntegerValues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntegerValues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IntegerValuesId,Name,Value,CreationDate,LastModificationBy")] IntegerValues integerValues)
        {
            if (ModelState.IsValid)
            {
                MeController meController = new MeController();

                integerValues.CreationDate = DateTime.Now;
                integerValues.LastModificationBy = meController.Get().UserName;
                db.IntegerValues.Add(integerValues);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(integerValues);
        }

        // GET: IntegerValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IntegerValues integerValues = db.IntegerValues.Find(id);
            if (integerValues == null)
            {
                return HttpNotFound();
            }
            return View(integerValues);
        }

        // POST: IntegerValues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IntegerValuesId,Name,Value,CreationDate,LastModificationBy")] IntegerValues integerValues)
        {
            if (ModelState.IsValid)
            {
                db.Entry(integerValues).State = EntityState.Modified;

                MeController meController = new MeController();

                integerValues.CreationDate = DateTime.Now;
                integerValues.LastModificationBy = meController.Get().UserName;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(integerValues);
        }

        // GET: IntegerValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IntegerValues integerValues = db.IntegerValues.Find(id);
            if (integerValues == null)
            {
                return HttpNotFound();
            }
            return View(integerValues);
        }

        // POST: IntegerValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IntegerValues integerValues = db.IntegerValues.Find(id);
            db.IntegerValues.Remove(integerValues);
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
