using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Irrigation;

using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Controllers.Irrigation
{
    public class IrrigationUnitController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Sprinklers
        public ActionResult Index()
        {
            var lList = db.IrrigationUnits.Include(f => f.Farm);
            return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
           
        }

        // GET: Sprinklers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            if (sprinkler == null)
            {
                return HttpNotFound();
            }
            return View(sprinkler);
        }

        
        public ActionResult Create()
        {
            IrrigationUnitViewModel vm = new IrrigationUnitViewModel();
            vm.Farms = this.LoadFarm();
            vm.IrrigationTypes = this.LoadIrrigationType();
            return View("~/Views/Irrigation/IrrigationUnit/Create.cshtml", vm);
        }

        // POST: Sprinklers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude,Longitude, Show")] IrrigationUnitViewModel irrigationUnitViewModel)
        {
            if (ModelState.IsValid)
            {
              
                return RedirectToAction("Index");
            }

            var lList = db.IrrigationUnits.Include(f => f.Farm);
            return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }

        // GET: Sprinklers/Edit/5
        public ActionResult Edit(long? id, string modelType)
        {
                 return new HttpStatusCodeResult(HttpStatusCode.BadRequest); 
           

        }

        // POST: Sprinklers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,Name,IrrigationType,IrrigationEfficiency,Surface,Width,Length")] Sprinkler sprinkler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sprinkler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sprinkler);
        }

        // GET: Sprinklers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            if (sprinkler == null)
            {
                return HttpNotFound();
            }
            return View(sprinkler);
        }

        // POST: Sprinklers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Sprinkler sprinkler = db.Sprinklers.Find(id);
            db.Sprinklers.Remove(sprinkler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        private List<System.Web.Mvc.SelectListItem> LoadFarm(long? farmId = null, IrrigationUnit irrigationUnit = null)
        {
            FarmConfiguration rc = new FarmConfiguration();
            List<Farm> farmConfiguration = rc.GetAllFarms();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in farmConfiguration)
            {

                bool isSelected = false;

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
        private List<System.Web.Mvc.SelectListItem> LoadIrrigationType(Utils.IrrigationUnitType? irrigationType = null, IrrigationUnit irrigationUnit = null)
        {
            Array irrigationUnitTypes = System.Enum.GetValues(typeof(Utils.IrrigationUnitType));

            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in irrigationUnitTypes)
            {

                bool isSelected = false;
                if (irrigationUnit != null && irrigationType != null)
                {
                    isSelected = (irrigationUnit.IrrigationType == irrigationType);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.ToString(),
                    Text = item.ToString(),
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetBombsByFarmId(string farmId)
        {

            Farm farm = db.Farms.Find(int.Parse(farmId));
            BombConfiguration bc = new BombConfiguration();
            var phyList = bc.GetBombListBy(farm);

            var phyData = phyList.Select(m => new SelectListItem()
            {
                Text = m.Name,
                Value = m.BombId.ToString(),
            });
            return Json(phyData, JsonRequestBehavior.AllowGet);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public JsonResult GetLatitudByFarmId(string farmId)
        {
            Farm farm = db.Farms.Find(int.Parse(farmId));
            var phyData = farm.Position;
            return Json(phyData, JsonRequestBehavior.AllowGet);
        }

    }
}
