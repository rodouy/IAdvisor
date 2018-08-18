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
using IrrigationAdvisor.DBContext.Agriculture;
using IrrigationAdvisor.ViewModels.Agriculture;

namespace IrrigationAdvisor.Controllers.Agriculture
{
    public class HorizonsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: Horizons
        public ActionResult Index()
        {
            var lHorizonList = db.Horizons.Include(s => s.Soil);
            return View("~/Views/Agriculture/Horizons/Index.cshtml", lHorizonList.ToList());

        }

        // GET: Horizons/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horizon horizon = db.Horizons.Find(id);
            if (horizon == null)
            {
                return HttpNotFound();
            }
            HorizonViewModel vm = new HorizonViewModel(horizon);

            return View("~/Views/Agriculture/Horizons/Details.cshtml", vm);

        }

        // GET: Horizons/Create
        public ActionResult Create()
        {
            HorizonViewModel vm = new HorizonViewModel();
            vm.Soils = this.LoadSoils();

            return View("~/Views/Agriculture/Horizons/Create.cshtml", vm);
        }

        // POST: Horizons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HorizonId,Name,Order,HorizonLayer,HorizonLayerDepth,Sand,Limo,Clay,OrganicMatter,NitrogenAnalysis,BulkDensitySoil, SoilId")] HorizonViewModel h)
        {
            if (ModelState.IsValid)
            {
                Horizon lHorizon = new Horizon();
                lHorizon.BulkDensitySoil = h.BulkDensitySoil;
                lHorizon.Clay = h.Clay;
                lHorizon.HorizonLayer = h.HorizonLayer;
                lHorizon.HorizonLayerDepth = h.HorizonLayerDepth;
                lHorizon.Limo = h.Limo;
                lHorizon.Name = h.Name;
                lHorizon.NitrogenAnalysis = h.NitrogenAnalysis;
                lHorizon.Order = h.Order;
                lHorizon.OrganicMatter = h.OrganicMatter;
                lHorizon.Sand = h.Sand;
                lHorizon.SoilId = h.SoilId;
                db.Horizons.Add(lHorizon);
                db.SaveChanges();

            }
            var lHorizonList = db.Horizons.Include(s => s.Soil);
            return View("~/Views/Agriculture/Horizons/Index.cshtml", lHorizonList.ToList());
        }

        // GET: Horizons/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horizon horizon = db.Horizons.Find(id);
            if (horizon == null)
            {
                return HttpNotFound();
            }
            HorizonViewModel vm = new HorizonViewModel(horizon);
            vm.Soils = this.LoadSoils();
            return View("~/Views/Agriculture/Horizons/Edit.cshtml", vm);
        }

        // POST: Horizons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HorizonId,Name,Order,HorizonLayer,HorizonLayerDepth,Sand,Limo,Clay,OrganicMatter,NitrogenAnalysis,BulkDensitySoil, SoilId")] HorizonViewModel horizonViewModel)
        {
            if (ModelState.IsValid)
            {
                Horizon updatedHorizon = db.Horizons.Find(horizonViewModel.HorizonId);
                if (updatedHorizon == null)
                {
                    return HttpNotFound();
                }

                updatedHorizon.BulkDensitySoil = horizonViewModel.BulkDensitySoil;
                updatedHorizon.Clay = horizonViewModel.Clay;
                updatedHorizon.HorizonLayer = horizonViewModel.HorizonLayer;
                updatedHorizon.HorizonLayerDepth = horizonViewModel.HorizonLayerDepth;
                updatedHorizon.Limo = horizonViewModel.Limo;
                updatedHorizon.Name = horizonViewModel.Name;
                updatedHorizon.NitrogenAnalysis = horizonViewModel.NitrogenAnalysis;
                updatedHorizon.Order = horizonViewModel.Order;
                updatedHorizon.OrganicMatter = horizonViewModel.OrganicMatter;
                updatedHorizon.Sand = horizonViewModel.Sand;
                updatedHorizon.SoilId = horizonViewModel.SoilId;
                db.Entry(updatedHorizon).State = EntityState.Modified;
                db.SaveChanges();
            }
            var lHorizonList = db.Horizons.Include(s => s.Soil);
            return View("~/Views/Agriculture/Horizons/Index.cshtml", lHorizonList.ToList());
        }

        // GET: Horizons/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horizon horizon = db.Horizons.Find(id);
            if (horizon == null)
            {
                return HttpNotFound();
            }
            HorizonViewModel vm = new HorizonViewModel(horizon);
            return View("~/Views/Agriculture/Horizons/Delete.cshtml", vm);
        }

        // POST: Horizons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Horizon horizon = db.Horizons.Find(id);
            db.Horizons.Remove(horizon);
            db.SaveChanges();
            var lHorizonList = db.Horizons.Include(s => s.Soil);
            return View("~/Views/Agriculture/Horizons/Index.cshtml", lHorizonList.ToList());
        }

        private List<System.Web.Mvc.SelectListItem> LoadSoils(long? soilId = null, Horizon horizon = null)
        {
            SoilConfiguration sc = new SoilConfiguration();

            List<Soil> soils = sc.GetAllSoils();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in soils)
            {

                bool isSelected = false;
                if (horizon != null && soilId.HasValue)
                {
                    isSelected = (horizon.SoilId == soilId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.SoilId.ToString(),
                    Text = item.ShortName,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
    }

}
