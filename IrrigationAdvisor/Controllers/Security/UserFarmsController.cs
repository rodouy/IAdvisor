using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;

namespace IrrigationAdvisor.Controllers.Security
{
    public class UserFarmsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: UserFarms
        public ActionResult Index()
        {
            var userFarms = db.UserFarms.Include(u => u.Farm).Include(u => u.User);
            return View(userFarms.ToList());
        }

        // GET: UserFarms/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFarm userFarm = db.UserFarms.Find(id);
            if (userFarm == null)
            {
                return HttpNotFound();
            }
            return View(userFarm);
        }

        // GET: UserFarms/Create
        public ActionResult Create()
        {
            ViewBag.FarmId = new SelectList(db.Farms, "FarmId", "Name");
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Name");
            return View();
        }

        // POST: UserFarms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserFarmId,UserId,FarmId,Name,StartDate")] UserFarm userFarm)
        {
            if (ModelState.IsValid)
            {
                db.UserFarms.Add(userFarm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FarmId = new SelectList(db.Farms, "FarmId", "Name", userFarm.FarmId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Name", userFarm.UserId);
            return View(userFarm);
        }

        // GET: UserFarms/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFarm userFarm = db.UserFarms.Find(id);
            if (userFarm == null)
            {
                return HttpNotFound();
            }
            ViewBag.FarmId = new SelectList(db.Farms, "FarmId", "Name", userFarm.FarmId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Name", userFarm.UserId);
            return View(userFarm);
        }

        // POST: UserFarms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserFarmId,UserId,FarmId,Name,StartDate")] UserFarm userFarm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userFarm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FarmId = new SelectList(db.Farms, "FarmId", "Name", userFarm.FarmId);
            ViewBag.UserId = new SelectList(db.Users, "UserId", "Name", userFarm.UserId);
            return View(userFarm);
        }

        // GET: UserFarms/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserFarm userFarm = db.UserFarms.Find(id);
            if (userFarm == null)
            {
                return HttpNotFound();
            }
            return View(userFarm);
        }

        // POST: UserFarms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            UserFarm userFarm = db.UserFarms.Find(id);
            db.UserFarms.Remove(userFarm);
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
