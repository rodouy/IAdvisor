using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ConfigurationManager.DataAccess;
using Microsoft.AspNet.Identity;
using System.Web.Security;
using Microsoft.AspNet.Identity;
using ConfigurationManager.Models;

namespace ConfigurationManager.Controllers
{
    public class StringValuesController : Controller
    {
        private ConfigurationManagerEntities db = new ConfigurationManagerEntities();

        // GET: StringValues
        public ActionResult Index()
        {
            return View(db.StringValues.ToList());
        }

        // GET: StringValues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StringValues stringValues = db.StringValues.Find(id);
            if (stringValues == null)
            {
                return HttpNotFound();
            }
            return View(stringValues);
        }

        // GET: StringValues/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StringValues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StringValuesId,Name,Value,CreationDate,LastModificationBy")] StringValues stringValues)
        {
            if (ModelState.IsValid)
            {
                MeController meController = new MeController();

                stringValues.CreationDate = DateTime.Now;
                stringValues.LastModificationBy = meController.Get().UserName;
                db.StringValues.Add(stringValues);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stringValues);
        }

        // GET: StringValues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StringValues stringValues = db.StringValues.Find(id);
            if (stringValues == null)
            {
                return HttpNotFound();
            }
            return View(stringValues);
        }

        // POST: StringValues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StringValuesId,Name,Value,CreationDate,LastModificationBy")] StringValues stringValues)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stringValues).State = EntityState.Modified;
                MeController meController = new MeController();

                stringValues.CreationDate = DateTime.Now;
                stringValues.LastModificationBy = meController.Get().UserName;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stringValues);
        }

        // GET: StringValues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StringValues stringValues = db.StringValues.Find(id);
            if (stringValues == null)
            {
                return HttpNotFound();
            }
            return View(stringValues);
        }

        // POST: StringValues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StringValues stringValues = db.StringValues.Find(id);
            db.StringValues.Remove(stringValues);
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
