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
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class SpecieCyclesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: SpecieCycles
        public ActionResult Index()
        {

            var lSpecieCyclesList = db.SpecieCycles.Include(b => b.Region);
            return View("~/Views/Agriculture/SpecieCycles/Index.cshtml", lSpecieCyclesList.ToList());
        }

        // GET: SpecieCycles/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecieCycle sc = db.SpecieCycles.Find(id);
            if (sc == null)
            {
                return HttpNotFound();
            }
            SpecieCycleViewModel vm = new SpecieCycleViewModel();
            vm.SpecieCycleId = sc.SpecieCycleId;
            vm.Name = sc.Name;
            vm.Duration = sc.Duration;
            vm.RegionId = sc.RegionId;
            vm.RegionName = sc.Region.Name;
            return View("~/Views/Agriculture/SpecieCycles/Details.cshtml", vm);
        }

        // GET: SpecieCycles/Create
        public ActionResult Create()
        {
            SpecieCycleViewModel vm = new SpecieCycleViewModel();
            vm.Regions = this.LoadRegion();

            return View("~/Views/Agriculture/SpecieCycles/Create.cshtml", vm);

        }

        // POST: SpecieCycles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpecieCycleId,Name,Duration,RegionId")] SpecieCycleViewModel svm)
        {
            if (ModelState.IsValid)
            {
                SpecieCycle specieCycle = new SpecieCycle();;
                specieCycle.Name = svm.Name;
                specieCycle.RegionId = svm.RegionId;
                specieCycle.Duration = svm.Duration;

                db.SpecieCycles.Add(specieCycle);
                db.SaveChanges();

            }

            return Redirect("/SpecieCycles");
        }

        // GET: SpecieCycles/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecieCycle sc = db.SpecieCycles.Find(id);
            if (sc == null)
            {
                return HttpNotFound();
            }
            SpecieCycleViewModel vm = new SpecieCycleViewModel();
            vm.SpecieCycleId = sc.SpecieCycleId;
            vm.Name = sc.Name;
            vm.Duration = sc.Duration;
            vm.RegionId = sc.RegionId;
            vm.Regions = this.LoadRegion(sc.RegionId, sc);
            return View("~/Views/Agriculture/SpecieCycles/Edit.cshtml", vm);
        }

        // POST: SpecieCycles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpecieCycleId,Name,Duration,RegionId")] SpecieCycleViewModel scvm)
        {
            if (ModelState.IsValid)
            {
                SpecieCycle updatedSpecieCycle = db.SpecieCycles.Find(scvm.SpecieCycleId);
                if (updatedSpecieCycle == null)
                {
                    return HttpNotFound();
                }

                updatedSpecieCycle.Name = scvm.Name;
                updatedSpecieCycle.Duration = scvm.Duration;
                updatedSpecieCycle.RegionId = scvm.RegionId;

                db.Entry(updatedSpecieCycle).State = EntityState.Modified;
                db.SaveChanges();

            }

            return Redirect("/SpecieCycles");

        }

        // GET: SpecieCycles/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SpecieCycle sc = db.SpecieCycles.Find(id);
            if (sc == null)
            {
                return HttpNotFound();
            }
            SpecieCycleViewModel vm = new SpecieCycleViewModel();
            vm.SpecieCycleId = sc.SpecieCycleId;
            vm.Name = sc.Name;
            vm.Duration = sc.Duration;
            vm.RegionId = sc.RegionId;
            vm.RegionName = sc.Region.Name;
            return View("~/Views/Agriculture/SpecieCycles/Delete.cshtml", vm);
        }

        // POST: SpecieCycles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {

            SpecieCycle specieCycle = db.SpecieCycles.Find(id);
            if (specieCycle == null)
            {
                return HttpNotFound();
            }
            db.SpecieCycles.Remove(specieCycle);
            db.SaveChanges();

            return Redirect("/SpecieCycles");

        }

        private List<System.Web.Mvc.SelectListItem> LoadRegion(long? regionId = null, SpecieCycle specieCycle = null)
        {
            RegionConfiguration sc = new RegionConfiguration();

            List<Region> regions = sc.GetAllRegions();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in regions)
            {

                bool isSelected = false;
                if (specieCycle != null && regionId.HasValue)
                {
                    isSelected = (specieCycle.RegionId == regionId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.RegionId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }

    }
}
