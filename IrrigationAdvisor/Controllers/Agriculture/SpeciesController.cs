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
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.DBContext.Agriculture;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class SpeciesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Species
        public ActionResult Index()
        {
            var lSpecie = db.Species
                            .Include(s => s.SpecieCycle)
                            .Include(s => s.Region);
            return View("~/Views/Agriculture/Species/Index.cshtml", lSpecie.ToList());
        }

        // GET: Species/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specie s = db.Species.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            SpecieViewModel vm = new SpecieViewModel();
            vm.SpecieId = s.SpecieId;
            vm.ShortName = s.ShortName;
            vm.BaseTemperature = s.BaseTemperature;
            vm.StressTemperature = s.StressTemperature;
            vm.SpecieType = s.SpecieType;
            vm.RegionId = s.RegionId;
            vm.SpecieCycleId = s.SpecieCycleId;
            vm.RegionName = s.Region.Name;
            vm.SpecieCycleName = s.SpecieCycle.Name;
            return View("~/Views/Agriculture/Species/Details.cshtml", vm);
        }

        // GET: Species/Create
        public ActionResult Create()
        {

            SpecieViewModel vm = new SpecieViewModel();
            vm.Regions = this.LoadRegion();
            vm.SpecieCycles = this.LoadSpecieCycles();
            return View("~/Views/Agriculture/Species/Create.cshtml", vm);
        }

        // POST: Species/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SpecieId,ShortName,SpecieCycleId,BaseTemperature,StressTemperature,RegionId, SpecieType")] SpecieViewModel svm)
        {
            if (ModelState.IsValid)
            {            
                SpecieCycle specieCycle = db.SpecieCycles.Find(svm.SpecieCycleId);
                Specie specie = new Specie();
                specie.Name = svm.ShortName + " " + specieCycle.Name;
                specie.SpecieCycleId = svm.SpecieCycleId;
                specie.ShortName = svm.ShortName;
                specie.BaseTemperature = svm.BaseTemperature;
                specie.StressTemperature = svm.StressTemperature;
                specie.RegionId = svm.RegionId;
                specie.SpecieType = svm.SpecieType;

                db.Species.Add(specie);
                db.SaveChanges();
            }
            return Redirect("/Species");
        }

        // GET: Species/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specie s = db.Species.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            SpecieViewModel vm = new SpecieViewModel();
            vm.SpecieId = s.SpecieId;
            vm.ShortName = s.ShortName;
            vm.BaseTemperature = s.BaseTemperature;
            vm.StressTemperature = s.StressTemperature;
            vm.SpecieType = s.SpecieType;
            vm.RegionId = s.RegionId;
            vm.SpecieCycleId = s.SpecieCycleId;

            vm.Regions = this.LoadRegion(s.RegionId, s);
            vm.SpecieCycles = this.LoadSpecieCycles(s.SpecieCycleId,s);
            return View("~/Views/Agriculture/Species/Edit.cshtml", vm);

        }

        // POST: Species/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SpecieId,ShortName,SpecieCycleId,BaseTemperature,StressTemperature, RegionId, ")] SpecieViewModel svm)
        {
            if (ModelState.IsValid)
            {
                SpecieCycle specieCycle = db.SpecieCycles.Find(svm.SpecieCycleId);
              
                Specie updatedSpecie = db.Species.Find(svm.SpecieId);
                if (updatedSpecie == null)
                {
                    return HttpNotFound();
                }
                updatedSpecie.Name = svm.ShortName + " " + specieCycle.Name;
                updatedSpecie.ShortName = svm.ShortName;
                updatedSpecie.BaseTemperature = svm.BaseTemperature;
                updatedSpecie.StressTemperature = svm.StressTemperature;
                updatedSpecie.SpecieCycleId = svm.SpecieCycleId;
                updatedSpecie.RegionId = svm.RegionId;
                updatedSpecie.SpecieType = svm.SpecieType;

                db.Entry(updatedSpecie).State = EntityState.Modified;
                db.SaveChanges();

            }
            return Redirect("/Species");

        }

        // GET: Species/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Specie s = db.Species.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            SpecieViewModel vm = new SpecieViewModel();
            vm.SpecieId = s.SpecieId;
            vm.ShortName = s.ShortName;
            vm.BaseTemperature = s.BaseTemperature;
            vm.StressTemperature = s.StressTemperature;
            vm.SpecieType = s.SpecieType;
            vm.RegionId = s.RegionId;
            vm.SpecieCycleId = s.SpecieCycleId;
            vm.RegionName = s.Region.Name;
            vm.SpecieCycleName = s.SpecieCycle.Name;
            return View("~/Views/Agriculture/Species/Delete.cshtml", vm);
        }

        // POST: Species/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Specie specie = db.Species.Find(id);
            if (specie == null)
            {
                return HttpNotFound();
            }
            db.Species.Remove(specie);
            db.SaveChanges();

            return Redirect("/Species");
        }
        private List<System.Web.Mvc.SelectListItem> LoadRegion(long? regionId = null, Specie specie = null)
        {
            RegionConfiguration sc = new RegionConfiguration();

            List<Region> regions = sc.GetAllRegions();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in regions)
            {

                bool isSelected = false;
                if (specie != null && regionId.HasValue)
                {
                    isSelected = (specie.RegionId == regionId);
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

        private List<System.Web.Mvc.SelectListItem> LoadSpecieCycles(long? specieCycleId = null, Specie specie = null)
        {
            SpecieCycleConfiguration sc = new SpecieCycleConfiguration();

            List<SpecieCycle> specieCycle = sc.GetAllSpecieCycles();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in specieCycle)
            {

                bool isSelected = false;
                if (specie != null && specieCycleId.HasValue)
                {
                    isSelected = (specie.SpecieCycleId == specieCycleId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.SpecieCycleId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
    }
}
