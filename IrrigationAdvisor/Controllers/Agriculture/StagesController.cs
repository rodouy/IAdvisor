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
    public class StagesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Stages
        public ActionResult Index()
        {
            var lSTages = db.Stages;
            return View("~/Views/Agriculture/Stages/Index.cshtml", lSTages.ToList());
        }

        // GET: Stages/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Agriculture/Stages/Details.cshtml", stage);
        }

        // GET: Stages/Create
        public ActionResult Create()
        {
            Stage vm = new Stage();
        
            return View("~/Views/Agriculture/Stages/Create.cshtml", vm);
        }

        // POST: Stages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StageId,Name,ShortName, Description, Order")] Stage stage)
        {
            if (ModelState.IsValid)
            {
                db.Stages.Add(stage);
                db.SaveChanges();
            }
            return Redirect("/Stages");
        }

        // GET: Stages/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Agriculture/Stages/Edit.cshtml", stage);
        }

        // POST: Stages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StageId,Name,ShortName,Description,Order")] Stage stage)
        {
            if (ModelState.IsValid)
            {
                Stage updatedstage = db.Stages.Find(stage.StageId);
                if (updatedstage == null)
                {
                    return HttpNotFound();
                }
                updatedstage.Name = stage.Name;
                updatedstage.ShortName = stage.ShortName;
                updatedstage.Description = stage.Description;

                updatedstage.Order = stage.Order;

                db.Entry(updatedstage).State = EntityState.Modified;
                db.SaveChanges();

            }
            return Redirect("/Stages");
        }

        // GET: Stages/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stage stage = db.Stages.Find(id);
            if (stage == null)
            {
                return HttpNotFound();
            }
            return View(stage);
        }

        // POST: Stages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Stage stage = db.Stages.Find(id);
            db.Stages.Remove(stage);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
