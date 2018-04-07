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
    public class EnumValuesController : Controller
    {
        private ConfigurationManagerEntities db = new ConfigurationManagerEntities();

        // GET: EnumValues
        public ActionResult Index()
        {
            return View(db.EnumValues.ToList());
        }

        // GET: EnumValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnumValues enumValues = db.EnumValues.Find(id);
            if (enumValues == null)
            {
                return HttpNotFound();
            }
            return View(enumValues);
        }

        // GET: EnumValues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EnumValues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EnumValuesId,Type,Name,Value,CreationDate,LastModificationBy")] EnumValues enumValues)
        {
            if (ModelState.IsValid)
            {
                MeController meController = new MeController();
                enumValues.CreationDate = DateTime.Now;
                enumValues.LastModificationBy = meController.Get().UserName;

                db.EnumValues.Add(enumValues);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enumValues);
        }

        // GET: EnumValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnumValues enumValues = db.EnumValues.Find(id);
            if (enumValues == null)
            {
                return HttpNotFound();
            }
            return View(enumValues);
        }

        // POST: EnumValues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EnumValuesId,Type,Name,Value,CreationDate,LastModificationBy")] EnumValues enumValues)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enumValues).State = EntityState.Modified;

                MeController meController = new MeController();

                enumValues.CreationDate = DateTime.Now;
                enumValues.LastModificationBy = meController.Get().UserName;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enumValues);
        }

        // GET: EnumValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EnumValues enumValues = db.EnumValues.Find(id);
            if (enumValues == null)
            {
                return HttpNotFound();
            }
            return View(enumValues);
        }

        // POST: EnumValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EnumValues enumValues = db.EnumValues.Find(id);
            db.EnumValues.Remove(enumValues);
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
