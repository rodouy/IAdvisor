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
using IrrigationAdvisor.DBContext.Irrigation;

namespace IrrigationAdvisor.Controllers.Irrigation
{
    public class SprinklersController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Sprinklers
        public ActionResult Index()
        {
            return View(db.Sprinklers.ToList());
        }

        // GET: Sprinklers/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler irrigationUnit = db.Sprinklers.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }

            SprinklerViewModel vm = new SprinklerViewModel();
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

            return View("~/Views/Irrigation/Sprinklers/Details.cshtml", vm);
 
        }

        // GET: Sprinklers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sprinklers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude,Longitude, Show, Width,Length")] SprinklerViewModel sprinklerViewModel)
        {
            if (ModelState.IsValid)
            {
                Sprinkler irrigationUnit = new Sprinkler();

                Farm farm = db.Farms.Find(sprinklerViewModel.FarmId);

                long positionId = GetPositionId(sprinklerViewModel.Latitude, sprinklerViewModel.Longitude);
                Position positionIU = new Position();
                //Not exist position
                if (positionId == 0)
                {
                    positionIU.Latitude = sprinklerViewModel.Latitude;
                    positionIU.Longitude = sprinklerViewModel.Longitude;
                    positionIU.Name = sprinklerViewModel.Name + " - Unidad de riego";
                    irrigationUnit.Position = positionIU;
                }
                else
                {
                    irrigationUnit.PositionId = positionId;
                }

                irrigationUnit.ShortName = sprinklerViewModel.ShortName;
                irrigationUnit.Name = farm.Name + " - " + sprinklerViewModel.ShortName;
                irrigationUnit.BombId = sprinklerViewModel.BombId;
                irrigationUnit.FarmId = sprinklerViewModel.FarmId;
                irrigationUnit.IrrigationEfficiency = sprinklerViewModel.IrrigationEfficiency;
                irrigationUnit.PredeterminatedIrrigationQuantity = sprinklerViewModel.PredeterminatedIrrigationQuantity;
                irrigationUnit.Surface = sprinklerViewModel.Surface;
                irrigationUnit.Show = sprinklerViewModel.Show;
                irrigationUnit.Width = sprinklerViewModel.Width;
                irrigationUnit.Length = sprinklerViewModel.Length;
                irrigationUnit.IrrigationType = Utils.IrrigationUnitType.Sprinkler;
                db.Sprinklers.Add(irrigationUnit);
                db.SaveChanges();

            }
            return Redirect("/IrrigationUnit");
            //var lList = db.IrrigationUnits.Include(f => f.Farm);
            //return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }

        // GET: Sprinklers/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Sprinkler irrigationUnit = db.Sprinklers.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }
            SprinklerViewModel vm = new SprinklerViewModel();

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
            return View("~/Views/Irrigation/Sprinklers/Edit.cshtml", vm);


        }

 
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IrrigationUnitId,ShortName,IrrigationType,IrrigationEfficiency,PredeterminatedIrrigationQuantity, Surface,FarmId, BombId, Latitude, Longitude, Show, Width,Length")] SprinklerViewModel sprinkleViewModel)
        {
            if (ModelState.IsValid)
            {
                Sprinkler lSprinkler = db.Sprinklers.Find(sprinkleViewModel.IrrigationUnitId);

                long positionId = GetPositionId(sprinkleViewModel.Latitude, sprinkleViewModel.Longitude);
                Position lPosition = new Position();
                //Not exist position
                if (positionId == 0)
                {
                    lPosition.Latitude = sprinkleViewModel.Latitude;
                    lPosition.Longitude = sprinkleViewModel.Longitude;
                    lPosition.Name = sprinkleViewModel.Farm.Name + " - " + sprinkleViewModel.Name + " - Unidad de riego";
                    lSprinkler.Position = lPosition;
                }
                else
                {
                    lSprinkler.PositionId = positionId;
                }
                lSprinkler.ShortName = sprinkleViewModel.ShortName;
                lSprinkler.BombId = sprinkleViewModel.BombId;
                lSprinkler.FarmId = sprinkleViewModel.FarmId;
                lSprinkler.IrrigationEfficiency = sprinkleViewModel.IrrigationEfficiency;
                lSprinkler.PredeterminatedIrrigationQuantity = sprinkleViewModel.PredeterminatedIrrigationQuantity;
                lSprinkler.Surface = sprinkleViewModel.Surface;
                lSprinkler.Show = sprinkleViewModel.Show;
                lSprinkler.Width = sprinkleViewModel.Width;
                lSprinkler.Length = sprinkleViewModel.Length;
                // lSprinkler.IrrigationType = Utils.IrrigationUnitType.Sprinkler;
                db.Entry(lSprinkler).State = EntityState.Modified;
                db.SaveChanges();
            }
            return Redirect("/IrrigationUnit");
            //var lList = db.IrrigationUnits.Include(f => f.Farm);
            //return View("~/Views/Irrigation/IrrigationUnit/Index.cshtml", lList.ToList());
        }
        // GET: Sprinklers/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sprinkler irrigationUnit = db.Sprinklers.Find(id);
            if (irrigationUnit == null)
            {
                return HttpNotFound();
            }

            SprinklerViewModel vm = new SprinklerViewModel();
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

            return View("~/Views/Irrigation/Sprinklers/Delete.cshtml", vm);
        }

        // POST: Sprinklers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            //Sprinkler lSprinkler = db.Sprinklers.Find(id);
            //lSprinkler.Show = false;
            //db.Entry(lSprinkler).State = EntityState.Modified;
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
