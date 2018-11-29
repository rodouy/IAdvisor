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
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.DBContext.Irrigation;

namespace IrrigationAdvisor.Controllers.Irrigation
{
    public class PivotsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Pivots
        public ActionResult Index()
        {
            return View(db.Pivots.ToList());
        }

        // GET: Pivots/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pivot irrigationUnit = db.Pivots.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }

            PivotViewModel vm = new PivotViewModel();
            vm.IrrigationUnitId = irrigationUnit.IrrigationUnitId;
            vm.ShortName = irrigationUnit.ShortName;
            vm.Name = irrigationUnit.Name;
            vm.Bomb = new BombViewModel(irrigationUnit.Bomb);
            vm.Farm = irrigationUnit.Farm;
            vm.Position = irrigationUnit.Position;
            vm.Latitude = irrigationUnit.Position.Latitude;
            vm.Longitude = irrigationUnit.Position.Longitude;
            vm.IrrigationEfficiency = irrigationUnit.IrrigationEfficiency;
            vm.IrrigationType = irrigationUnit.IrrigationType;
            vm.PredeterminatedIrrigationQuantity = irrigationUnit.PredeterminatedIrrigationQuantity;
            vm.Surface = irrigationUnit.Surface;
            vm.Show = irrigationUnit.Show;
            vm.Radius = irrigationUnit.Radius;

            return View("~/Views/Irrigation/Pivots/Details.cshtml", vm);
        }

        // GET: Pivots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pivots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude,Longitude, Show, Radius")] PivotViewModel pivotViewModel)
        {
            if (ModelState.IsValid)
            {
                Pivot irrigationUnit = new Pivot();

               

                long positionId = GetPositionId(pivotViewModel.Latitude, pivotViewModel.Longitude);
                Position positionIU = new Position();
                //Not exist position
                if (positionId == 0)
                {
                    positionIU.Latitude = pivotViewModel.Position.Latitude;
                    positionIU.Longitude = pivotViewModel.Longitude;
                    positionIU.Name = pivotViewModel.Farm.Name + " - " + pivotViewModel.Name + " - Unidad de riego";
                    irrigationUnit.Position = positionIU;
                }
                else
                {
                    irrigationUnit.PositionId = positionId;
                }

                Farm farm = db.Farms.Find(pivotViewModel.FarmId);
                if (farm == null)
                {
                    return HttpNotFound();
                }

                irrigationUnit.ShortName = pivotViewModel.ShortName;
                irrigationUnit.Name = farm.Name + " - " + pivotViewModel.ShortName;
                irrigationUnit.BombId = pivotViewModel.BombId;
                irrigationUnit.FarmId = pivotViewModel.FarmId;
                irrigationUnit.IrrigationEfficiency = pivotViewModel.IrrigationEfficiency;
                irrigationUnit.IrrigationType = pivotViewModel.IrrigationType;
                irrigationUnit.PredeterminatedIrrigationQuantity = pivotViewModel.PredeterminatedIrrigationQuantity;
                irrigationUnit.Surface = pivotViewModel.Surface;
                irrigationUnit.Show = pivotViewModel.Show;
                irrigationUnit.Radius = pivotViewModel.Radius;
                irrigationUnit.IrrigationType = Utils.IrrigationUnitType.Pivot;
                db.Pivots.Add(irrigationUnit);
                db.SaveChanges();

            }
            return Redirect("/IrrigationUnit");
            //var lList = db.IrrigationUnits.Include(f => f.Farm);
            //return View("~/Views/Irrigation/Pivot/Index.cshtml", lList.ToList());
        }

        // GET: Pivots/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pivot irrigationUnit = db.Pivots.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }
            PivotViewModel vm = new PivotViewModel();
            vm.IrrigationUnitId = irrigationUnit.IrrigationUnitId;
            vm.ShortName = irrigationUnit.ShortName;
            vm.Name = irrigationUnit.Name;
            vm.BombId = irrigationUnit.BombId;
            vm.FarmId = irrigationUnit.FarmId;
            vm.Latitude = irrigationUnit.Position.Latitude;
            vm.Longitude = irrigationUnit.Position.Longitude;
            vm.IrrigationEfficiency = irrigationUnit.IrrigationEfficiency;
            vm.IrrigationType = irrigationUnit.IrrigationType;
            vm.PredeterminatedIrrigationQuantity = irrigationUnit.PredeterminatedIrrigationQuantity;
            vm.Surface = irrigationUnit.Surface;
            vm.Show = irrigationUnit.Show;
            vm.Radius = irrigationUnit.Radius;
          
            vm.Farms = this.LoadFarm();
            return View("~/Views/Irrigation/Pivots/Edit.cshtml", vm);   

  
        }

        // POST: Pivots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude, Longitude, Show, Radius")] PivotViewModel pivotViewModel)
        {
            if (ModelState.IsValid)
            {
                Pivot lPivot = db.Pivots.Find(pivotViewModel.IrrigationUnitId); 
                
                long positionId = GetPositionId(pivotViewModel.Latitude, pivotViewModel.Longitude);
                Position lPosition= new Position();
                //Not exist position
                if (positionId == 0)
                {
                    lPosition.Latitude = pivotViewModel.Latitude;
                    lPosition.Longitude = pivotViewModel.Longitude;
                    lPosition.Name = pivotViewModel.Farm.Name + " - " + pivotViewModel.Name + " - Unidad de riego";
                    lPivot.Position = lPosition;
                }
                else
                {
                    lPivot.PositionId = positionId;
                }
                lPivot.ShortName = pivotViewModel.ShortName;
                lPivot.BombId = pivotViewModel.BombId;
                lPivot.FarmId = pivotViewModel.FarmId;
                lPivot.IrrigationEfficiency = pivotViewModel.IrrigationEfficiency;
                lPivot.PredeterminatedIrrigationQuantity = pivotViewModel.PredeterminatedIrrigationQuantity;
                lPivot.Surface = pivotViewModel.Surface;
                lPivot.Show = pivotViewModel.Show;
                lPivot.Radius = pivotViewModel.Radius;
               // lPivot.IrrigationType = Utils.IrrigationUnitType.Sprinkler;
                db.Entry(lPivot).State = EntityState.Modified;
                db.SaveChanges();
            }

            return Redirect("/IrrigationUnit");
            //var lList = db.IrrigationUnits.Include(f => f.Farm);
            //return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }

        // GET: Pivots/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pivot irrigationUnit = db.Pivots.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }

            PivotViewModel vm = new PivotViewModel();
            vm.IrrigationUnitId = irrigationUnit.IrrigationUnitId;
            vm.ShortName = irrigationUnit.ShortName;
            vm.Name = irrigationUnit.Name;
            vm.Bomb = new BombViewModel(irrigationUnit.Bomb);
            vm.Farm = irrigationUnit.Farm;
            vm.Position = irrigationUnit.Position;
            vm.Latitude = irrigationUnit.Position.Latitude;
            vm.Longitude = irrigationUnit.Position.Longitude;
            vm.IrrigationEfficiency = irrigationUnit.IrrigationEfficiency;
            vm.IrrigationType = irrigationUnit.IrrigationType;
            vm.PredeterminatedIrrigationQuantity = irrigationUnit.PredeterminatedIrrigationQuantity;
            vm.Surface = irrigationUnit.Surface;
            vm.Show = irrigationUnit.Show;
            vm.Radius = irrigationUnit.Radius;

            return View("~/Views/Irrigation/Pivots/Delete.cshtml", vm);
        }

        // POST: Pivots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {

            //Pivot lPivot = db.Pivots.Find(id);
            //lPivot.Show = false;
            //db.Entry(lPivot).State = EntityState.Modified;
            //db.SaveChanges();

            IrrigationUnitConfiguration fc = new IrrigationUnitConfiguration();
            IrrigationUnit irrigationUnit = db.IrrigationUnits.Find(id);
            fc.Disable(irrigationUnit);
            db.SaveChanges();
  
            return Redirect("/IrrigationUnit");
            //var lList = db.IrrigationUnits.Include(f => f.Farm);
            //return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }


        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud(pLatitude, pLongitude);
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

    }
}
