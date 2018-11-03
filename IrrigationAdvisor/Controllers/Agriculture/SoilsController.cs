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
using IrrigationAdvisor.ViewModels.Wizard;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using Newtonsoft.Json;
using IrrigationAdvisor.ViewModels.Agriculture;
using IrrigationAdvisor.DBContext.Agriculture;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class SoilsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Soils
        public ActionResult Index()
        {
            var lSoilList = db.Soils.Include(b => b.Farm);
            return View("~/Views/Agriculture/Soils/Index.cshtml", lSoilList.Where(s => s.Enabled == true).ToList());
        }

        // GET: Soils/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soil soil = db.Soils.Find(id);
            if (soil == null)
            {
                return HttpNotFound();
            }
            HorizonConfiguration hc = new HorizonConfiguration();
            SoilViewModel vm = new SoilViewModel(soil);
            vm.Farms = this.LoadFarms(soil.FarmId, soil.Farm);
            vm.Horizonts = hc.GetHorizonListBy(soil);
            return View("~/Views/Agriculture/Soils/Details.cshtml", vm);
        }

        // GET: Soils/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name, ShortName, Description, Latitude, Longitude, TestDate, DepthLimit, FarmId, HorizonsHidden")] WizardSoilHorizonViewModel vm)
        {

            if (ModelState.IsValid)
            {
                Soil soilMapped = new Soil();
                long lsoilPositionId = GetPositionId(vm.Latitude, vm.Longitude);

                Position positionAux = new Position();
                //Not exist position to Soil
                if (lsoilPositionId == 0)
                {
                    positionAux.Latitude = vm.Latitude;
                    positionAux.Longitude = vm.Longitude;
                    positionAux.Name = vm.Name + " - Suelo";
                    soilMapped.Position = positionAux;
                }
                else
                {
                    soilMapped.PositionId = lsoilPositionId;
                }

                // working whit Horizont
                dynamic items = JsonConvert.DeserializeObject(vm.HorizonsHidden);
                foreach (var item in items.items)
                {
                    //Horizon horizon = new Horizon();
                    string lhorizonName = item.horizonName;
                    int lorder = item.order;
                    string lhorizonLayer = item.horizonLayer;
                    double lhorizonLayerDepth = item.horizonLayerDepth;
                    double lsand = item.sand;
                    double llimo = item.limo;
                    double lclay = item.clay;
                    double lorganicMatter = item.organicMatter;
                    double lnitrogenAnalysis = item.nitrogenAnalysis;
                    double lbulkDensitySoil = item.bulkDensitySoil;


                    soilMapped.AddHorizon(lhorizonName, lorder, lhorizonLayer, lhorizonLayerDepth, lsand, llimo, lclay, lorganicMatter, lnitrogenAnalysis, lbulkDensitySoil);
                }
                soilMapped.ShortName = vm.ShortName;
                soilMapped.Name = vm.Name;
                soilMapped.Description = vm.Description;
                soilMapped.TestDate = vm.TestDate;
                soilMapped.DepthLimit = vm.DepthLimit;
                soilMapped.FarmId = vm.FarmId;
                db.Soils.Add(soilMapped);
                db.SaveChanges();

                ////return RedirectToAction("Index");
            }
            return Redirect("/Soils");

            //var lSoilList = db.Soils.Include(b => b.Farm);
            //return View("~/Views/Agriculture/Soils/Index.cshtml", lSoilList.ToList());
        }

        // GET: Soils/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soil soil = db.Soils.Find(id);
            if (soil == null)
            {
                return HttpNotFound();
            }

            HorizonConfiguration hc = new HorizonConfiguration();
            SoilViewModel vm = new SoilViewModel(soil);
            vm.Farms = this.LoadFarms(soil.FarmId, soil.Farm);
            vm.Horizonts = hc.GetHorizonListBy(soil);

            return View("~/Views/Agriculture/Soils/Edit.cshtml", vm);

        }

        // POST: Soils/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SoilId,ShortName,Description,TestDate,DepthLimit,Latitude,Longitude")] SoilViewModel soilViewModel)
        {
            if (ModelState.IsValid)
            {
                Soil updatedSoil = db.Soils.Find(soilViewModel.SoilId);
                if (updatedSoil == null)
                {
                    return HttpNotFound();
                }

                updatedSoil.ShortName = soilViewModel.ShortName;
                updatedSoil.Description = soilViewModel.Description;
                updatedSoil.TestDate = soilViewModel.TestDate;
                updatedSoil.DepthLimit = soilViewModel.DepthLimit;
                updatedSoil.Position.Latitude = soilViewModel.Latitude;
                updatedSoil.Position.Longitude = soilViewModel.Longitude;
                db.Entry(updatedSoil).State = EntityState.Modified;
                db.SaveChanges();

            }
            return Redirect("/Soils");
            //var lSoilList = db.Soils.Include(b => b.Farm);
            //return View("~/Views/Agriculture/Soils/Index.cshtml", lSoilList.ToList());
        }

        // GET: Soils/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Soil soil = db.Soils.Find(id);
            if (soil == null)
            {
                return HttpNotFound();
            }
            HorizonConfiguration hc = new HorizonConfiguration();
            SoilViewModel vm = new SoilViewModel(soil);
            vm.Farms = this.LoadFarms(soil.FarmId, soil.Farm);
            vm.Horizonts = hc.GetHorizonListBy(soil);

            return View("~/Views/Agriculture/Soils/Delete.cshtml", vm);
        }

        // POST: Soils/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {

            SoilConfiguration sc = new SoilConfiguration();
            Soil soil = db.Soils.Find(id);

            sc.Disable(soil);
            db.SaveChanges();

            return Redirect("/Soils");
        }

        // GET: Users/Wizard
        public ActionResult Wizard()
        {
            WizardSoilHorizonViewModel vm = new WizardSoilHorizonViewModel();
            vm.Farm = this.LoadFarms();
            return View("~/Views/Wizard/SoilHorizon/Wizard.cshtml", vm);
        }

        private List<System.Web.Mvc.SelectListItem> LoadFarms(long? farmId = null, Farm farm = null)
        {
            UserConfiguration uc;
            uc = new UserConfiguration();
            User lLoggedUser;
            lLoggedUser = uc.GetUserByName(ManageSession.GetUserName());
            FarmConfiguration fc = new FarmConfiguration();

            List<Farm> farms = fc.GetFarmListBy(lLoggedUser);
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in farms)
            {

                bool isSelected = false;
                if (farm != null && farmId.HasValue)
                {
                    isSelected = (farm.FarmId == farmId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.FarmId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud(pLatitude, pLongitude);
        }

    }
}
