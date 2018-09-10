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
using IrrigationAdvisor.DBContext.Agriculture;
using IrrigationAdvisor.ViewModels.Agriculture;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class CropsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Crops
        public ActionResult Index()
        {
            var lcrops = db.Crops
                .Include(c => c.Region)
                .Include(c => c.Specie)
                .Include(c => c.StopIrrigationStage);
            return View("~/Views/Agriculture/Crops/Index.cshtml", lcrops.ToList());

        }

        // GET: Crops/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crop s = db.Crops.Find(id);
            if (s == null)
            {
                return HttpNotFound();
            }
            Stage stopIrrigationStage = db.Stages.Find(s.StopIrrigationStageId);
            Stage minStageToConsiderETinHBCalculation = db.Stages.Find(s.MinStageToConsiderETinHBCalculationId);
            CropViewModel vm = new CropViewModel();
            vm.SpecieId = s.SpecieId;
            vm.ShortName = s.ShortName;
            vm.Name = s.Name;
            vm.CropCoefficient = s.CropCoefficient;
            vm.MaxEvapotranspirationToIrrigate = s.MaxEvapotranspirationToIrrigate;
            vm.MinEvapotranspirationToIrrigate = s.MinEvapotranspirationToIrrigate;
            vm.MinStageToConsiderETinHBCalculation = s.MinStageToConsiderETinHBCalculation;
            vm.Region = s.Region;
            vm.Specie = s.Specie;
            ViewBag.StopIrrigationStageName = stopIrrigationStage.Name;
            ViewBag.MinStageToConsiderETinHBCalculationName = minStageToConsiderETinHBCalculation.Name;
           
            vm.MinStageToConsiderETinHBCalculation = s.MinStageToConsiderETinHBCalculation;
            return View("~/Views/Agriculture/Crops/Details.cshtml", vm);
        }

        // GET: Crops/Create
        public ActionResult Create()
        {
            CropViewModel vm = new CropViewModel();
            vm.Regions = this.LoadRegions();
            vm.Stages = this.LoadStages();
            return View("~/Views/Agriculture/Crops/Create.cshtml", vm);
        }

        // POST: Crops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CropId, ShortNAme, MaxEvapotranspirationToIrrigate, MinEvapotranspirationToIrrigate, StopIrrigationStageId, MinStageToConsiderETinHBCalculationId,RegionId,SpecieId,CropCoefficientId")] CropViewModel cropViewModel)
        {
            if (ModelState.IsValid)
            {
                Specie specie = db.Species.Find(cropViewModel.SpecieId);
                Crop crop = new Crop();
                crop.Name = cropViewModel.ShortName + " " + specie.Name;
                crop.ShortName = cropViewModel.ShortName;
                crop.MaxEvapotranspirationToIrrigate = cropViewModel.MaxEvapotranspirationToIrrigate;
                crop.MinEvapotranspirationToIrrigate = cropViewModel.MinEvapotranspirationToIrrigate;
                crop.StopIrrigationStageId = cropViewModel.StopIrrigationStageId;
                crop.MinStageToConsiderETinHBCalculationId = cropViewModel.MinStageToConsiderETinHBCalculationId;
                crop.RegionId = cropViewModel.RegionId;
                crop.SpecieId = cropViewModel.SpecieId;
                crop.CropCoefficientId = cropViewModel.CropCoefficientId;
                db.Crops.Add(crop);
                db.SaveChanges();
            }
            return Redirect("/Crops");
        }

        // GET: Crops/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crop crop = db.Crops.Find(id);
            if (crop == null)
            {
                return HttpNotFound();
            }
            CropViewModel vm = new CropViewModel(crop);
            vm.Regions = this.LoadRegions();
            vm.Stages = this.LoadStages(crop.StopIrrigationStageId, crop, "StopIrrigationStageId");
            vm.Stages = this.LoadStages(crop.MinStageToConsiderETinHBCalculationId, crop, "MinStageToConsiderETinHBCalculationId");
            return View("~/Views/Agriculture/Crops/Edit.cshtml", vm);
        }

        // POST: Crops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CropId, ShortNAme, MaxEvapotranspirationToIrrigate, MinEvapotranspirationToIrrigate, StopIrrigationStageId, MinStageToConsiderETinHBCalculationId,RegionId,SpecieId,CropCoefficientId")] CropViewModel cropViewModel)
        {
            if (ModelState.IsValid)
            {
                Crop crop = db.Crops.Find(cropViewModel.CropId);
                if (crop == null)
                {
                    return HttpNotFound();
                }
                crop.ShortName = cropViewModel.ShortName;
                crop.MaxEvapotranspirationToIrrigate = cropViewModel.MaxEvapotranspirationToIrrigate;
                crop.MinEvapotranspirationToIrrigate = cropViewModel.MinEvapotranspirationToIrrigate;
                crop.StopIrrigationStageId = cropViewModel.StopIrrigationStageId;
                crop.MinStageToConsiderETinHBCalculationId = cropViewModel.MinStageToConsiderETinHBCalculationId;
                crop.RegionId = cropViewModel.RegionId;
                crop.SpecieId = cropViewModel.SpecieId;
                crop.CropCoefficientId = cropViewModel.CropCoefficientId;

                db.Entry(crop).State = EntityState.Modified;
                db.SaveChanges();

            }
            return Redirect("/Crops");

        }

        // GET: Crops/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Crop crop = db.Crops.Find(id);
            if (crop == null)
            {
                return HttpNotFound();
            }
            return View(crop);
        }

        // POST: Crops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Crop crop = db.Crops.Find(id);
            db.Crops.Remove(crop);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<System.Web.Mvc.SelectListItem> LoadRegions(long? reguionId = null, Crop crop = null)
        {
            RegionConfiguration rc = new RegionConfiguration();
            List<Region> regionConfiguration = rc.GetAllRegions();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in regionConfiguration)
            {

                bool isSelected = false;

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

        private List<System.Web.Mvc.SelectListItem> LoadStages(long? stageId = null, Crop crop = null, string field = null)
        {
            StageConfiguration rc = new StageConfiguration();
            List<Stage> stageConfiguration = rc.GetAllStage();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();
            long stageIdToCompare;

            if (field=="MinStageToConsiderETinHBCalculationId")
                stageIdToCompare = crop.MinStageToConsiderETinHBCalculationId;
            else
                stageIdToCompare = crop.StopIrrigationStageId;

            foreach (var item in stageConfiguration)
            {

                
                bool isSelected = false;
                if (crop != null && stageId.HasValue)
                {
                    isSelected = (stageIdToCompare == stageId);
                }
                SelectListItem sl = new SelectListItem()
                {
                    Value = item.StageId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetSpeciesByRegionId(string regionId)
        {

            Region region = db.Regions.Find(int.Parse(regionId));
            SpecieConfiguration bc = new SpecieConfiguration();
            var phyList = bc.GetSpecieListBy(region);

            var phyData = phyList.Select(m => new SelectListItem()
            {
                Text = m.Name,
                Value = m.SpecieId.ToString(),
            });
            return Json(phyData, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetCropCoefficientsBySpecieId(string specieId)
        {

            Specie specie = db.Species.Find(int.Parse(specieId));
            CropCoefficientConfiguration bc = new CropCoefficientConfiguration();
            var phyList = bc.GetCropCoefficientListBy(specie);

            var phyData = phyList.Select(m => new SelectListItem()
            {
                Text = m.Name,
                Value = m.CropCoefficientId.ToString(),
            });
            return Json(phyData, JsonRequestBehavior.AllowGet);
        }
    }
}
