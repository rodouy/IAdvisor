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
using IrrigationAdvisor.ViewModels.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Controllers.Irrigation
{
    public class DripsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Drips
        public ActionResult Index()
        {
            return View(db.Drips.ToList());
        }

        // GET: Drips/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drip irrigationUnit = db.Drips.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }

            DripViewModel vm = new DripViewModel();
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
            vm.Width = irrigationUnit.Width;
            vm.Length = irrigationUnit.Length;

            return View("~/Views/Irrigation/Drips/Details.cshtml", vm);
 
        }

        // GET: Drips/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Drips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IIrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude,Longitude, Show, Width,Length")] DripViewModel dripViewModel)
        {
            if (ModelState.IsValid)
            {
                Drip irrigationUnit = new Drip();

                Farm farm = db.Farms.Find(dripViewModel.FarmId);

                long positionId = GetPositionId(dripViewModel.Latitude, dripViewModel.Longitude);
                Position positionIU = new Position();
                //Not exist position
                if (positionId == 0)
                {
                    positionIU.Latitude = dripViewModel.Position.Latitude;
                    positionIU.Longitude = dripViewModel.Longitude;
                    positionIU.Name = dripViewModel.Name + " - Unidad de riego";
                    irrigationUnit.Position = positionIU;
                }
                else
                {
                    irrigationUnit.PositionId = positionId;
                }

                irrigationUnit.ShortName = dripViewModel.ShortName;
                irrigationUnit.Name = farm.Name + " - " + dripViewModel.ShortName;
                irrigationUnit.BombId = dripViewModel.BombId;
                irrigationUnit.FarmId = dripViewModel.FarmId;
                irrigationUnit.IrrigationEfficiency = dripViewModel.IrrigationEfficiency;
                irrigationUnit.PredeterminatedIrrigationQuantity = dripViewModel.PredeterminatedIrrigationQuantity;
                irrigationUnit.Surface = dripViewModel.Surface;
                irrigationUnit.Show = dripViewModel.Show;
                irrigationUnit.Width = dripViewModel.Width;
                irrigationUnit.Length = dripViewModel.Width;
                irrigationUnit.IrrigationType = Utils.IrrigationUnitType.Drip;
                db.Drips.Add(irrigationUnit);
                db.SaveChanges();
            }


            var lList = db.IrrigationUnits.Include(f => f.Farm);
            return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }

        // GET: Drips/Edit/5

        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            Drip irrigationUnit = db.Drips.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }
            DripViewModel vm = new DripViewModel();

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
            vm.Width = irrigationUnit.Width;
            vm.Length = irrigationUnit.Length;
            vm.Farms = this.LoadFarm();
            return View("~/Views/Irrigation/Drips/Edit.cshtml", vm);


        }

        // POST: Pivots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude, Longitude, Show, Width,Length")] DripViewModel dripViewModel)
        {
            if (ModelState.IsValid)
            {
                Drip lDrip = db.Drips.Find(dripViewModel.IrrigationUnitId);

                long positionId = GetPositionId(dripViewModel.Latitude, dripViewModel.Longitude);
                Position lPosition = new Position();
                //Not exist position
                if (positionId == 0)
                {
                    lPosition.Latitude = dripViewModel.Latitude;
                    lPosition.Longitude = dripViewModel.Longitude;
                    lPosition.Name = dripViewModel.Farm.Name + " - " + dripViewModel.Name + " - Unidad de riego";
                    lDrip.Position = lPosition;
                }
                else
                {
                    lDrip.PositionId = positionId;
                }
                lDrip.ShortName = dripViewModel.ShortName;
                lDrip.BombId = dripViewModel.BombId;
                lDrip.FarmId = dripViewModel.FarmId;
                lDrip.IrrigationEfficiency = dripViewModel.IrrigationEfficiency;
                lDrip.PredeterminatedIrrigationQuantity = dripViewModel.PredeterminatedIrrigationQuantity;
                lDrip.Show = dripViewModel.Show;
                lDrip.Surface = dripViewModel.Surface;
                lDrip.Width = dripViewModel.Width;
                lDrip.Length = dripViewModel.Length;

                db.Entry(lDrip).State = EntityState.Modified;
                db.SaveChanges();
            }
            var lList = db.IrrigationUnits.Include(f => f.Farm);
            return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }
        // GET: Drips/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Drip irrigationUnit = db.Drips.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }

            DripViewModel vm = new DripViewModel();
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
            vm.Width = irrigationUnit.Width;
            vm.Length = irrigationUnit.Length;

            return View("~/Views/Irrigation/Drips/Delete.cshtml", vm);

        }

        // POST: Drips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Drip lDrip = db.Drips.Find(id);
              
            lDrip.Show = false;
            db.Entry(lDrip).State = EntityState.Modified;
            db.SaveChanges();
            
            var lList = db.IrrigationUnits.Include(f => f.Farm);
            return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
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
