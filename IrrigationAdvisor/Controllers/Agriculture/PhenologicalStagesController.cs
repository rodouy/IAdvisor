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
    public class PhenologicalStagesController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: PhenologicalStages
        public ActionResult Index()
        {
            var lPhenologicalStages = db.PhenologicalStages
                            .Include(s => s.Specie)
                            .Include(s => s.Stage)
                            .Where(s => s.PhenologicalStageIsUsed == true);
            return View("~/Views/Agriculture/PhenologicalStages/Index.cshtml", lPhenologicalStages.ToList());
        }

        // GET: PhenologicalStages/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            PhenologicalStageViewModel vm = new PhenologicalStageViewModel();
            vm.PhenologicalStageId = phenologicalStage.PhenologicalStageId;
            vm.SpecieId = phenologicalStage.SpecieId;
            vm.StageId = phenologicalStage.StageId;
            vm.MinDegree = phenologicalStage.MinDegree;
            vm.MaxDegree = phenologicalStage.MaxDegree;
            vm.RootDepth = phenologicalStage.RootDepth;
            vm.HydricBalanceDepth = phenologicalStage.HydricBalanceDepth;
            vm.Coefficient = phenologicalStage.Coefficient;
            vm.DegreesDaysInterval = phenologicalStage.DegreesDaysInterval;
            vm.StageName = phenologicalStage.Stage.Name;
            vm.SpecieName = phenologicalStage.Specie.Name;
            return View("~/Views/Agriculture/PhenologicalStages/Details.cshtml", vm);
        }

        // GET: PhenologicalStages/Create
        public ActionResult Create()
        {
            PhenologicalStageViewModel vm = new PhenologicalStageViewModel();
            
            vm.Stages = this.LoadStages();
            vm.Species = this.LoadSpecies();
            return View("~/Views/Agriculture/PhenologicalStages/Create.cshtml", vm);
        }

        // POST: PhenologicalStages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PhenologicalStageId,StageId,SpecieId,MinDegree,MaxDegree,RootDepth,HydricBalanceDepth,Coefficient,DegreesDaysInterval")] PhenologicalStageViewModel phenologicalStageViewModel)
        {
            if (ModelState.IsValid)
            {
                PhenologicalStage phenologicalStage = new PhenologicalStage();
                phenologicalStage.SpecieId = phenologicalStageViewModel.SpecieId;
                phenologicalStage.StageId = phenologicalStageViewModel.StageId;
                phenologicalStage.MinDegree = phenologicalStageViewModel.MinDegree;
                phenologicalStage.MaxDegree = phenologicalStageViewModel.MaxDegree;
                phenologicalStage.RootDepth = phenologicalStageViewModel.RootDepth;
                phenologicalStage.HydricBalanceDepth = phenologicalStageViewModel.HydricBalanceDepth;
                phenologicalStage.Coefficient = phenologicalStageViewModel.Coefficient;
                phenologicalStage.DegreesDaysInterval = phenologicalStageViewModel.DegreesDaysInterval;

                db.PhenologicalStages.Add(phenologicalStage);
                db.SaveChanges();

            }

            return Redirect("/PhenologicalStages");
        }

        // GET: PhenologicalStages/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            PhenologicalStageViewModel vm = new PhenologicalStageViewModel();
            vm.PhenologicalStageId = phenologicalStage.PhenologicalStageId;
            vm.SpecieId = phenologicalStage.SpecieId;
            vm.StageId = phenologicalStage.StageId;
            vm.MinDegree = phenologicalStage.MinDegree;
            vm.MaxDegree = phenologicalStage.MaxDegree;
            vm.RootDepth = phenologicalStage.RootDepth;
            vm.HydricBalanceDepth = phenologicalStage.HydricBalanceDepth;
            vm.Coefficient = phenologicalStage.Coefficient;
            vm.DegreesDaysInterval = phenologicalStage.DegreesDaysInterval;
            vm.Stages = this.LoadStages(phenologicalStage.StageId, phenologicalStage);
            vm.Species = this.LoadSpecies(phenologicalStage.SpecieId, phenologicalStage);
            return View("~/Views/Agriculture/PhenologicalStages/Edit.cshtml", vm);
        }

        // POST: PhenologicalStages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PhenologicalStageId,SpecieId, StageId, MinDegree,MaxDegree,RootDepth,HydricBalanceDepth,Coefficient,DegreesDaysInterval")] PhenologicalStageViewModel phenologicalStageViewModel)
        {
            if (ModelState.IsValid)
            {
                PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(phenologicalStageViewModel.PhenologicalStageId);
                if (phenologicalStage == null)
                {
                    return HttpNotFound();
                }

                phenologicalStage.SpecieId = phenologicalStageViewModel.SpecieId;
                phenologicalStage.StageId = phenologicalStageViewModel.StageId;
                phenologicalStage.MinDegree = phenologicalStageViewModel.MinDegree;
                phenologicalStage.MaxDegree = phenologicalStageViewModel.MaxDegree;
                phenologicalStage.RootDepth = phenologicalStageViewModel.RootDepth;
                phenologicalStage.HydricBalanceDepth = phenologicalStageViewModel.HydricBalanceDepth;
                phenologicalStage.Coefficient = phenologicalStageViewModel.Coefficient;
                phenologicalStage.DegreesDaysInterval = phenologicalStageViewModel.DegreesDaysInterval;

                db.Entry(phenologicalStage).State = EntityState.Modified;
                db.SaveChanges();
               
            }
            return Redirect("/PhenologicalStages");
        }

        // GET: PhenologicalStages/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            PhenologicalStageViewModel vm = new PhenologicalStageViewModel();
            vm.SpecieId = phenologicalStage.SpecieId;
            vm.StageId = phenologicalStage.StageId;
            vm.MinDegree = phenologicalStage.MinDegree;
            vm.MaxDegree = phenologicalStage.MaxDegree;
            vm.RootDepth = phenologicalStage.RootDepth;
            vm.HydricBalanceDepth = phenologicalStage.HydricBalanceDepth;
            vm.Coefficient = phenologicalStage.Coefficient;
            vm.DegreesDaysInterval = phenologicalStage.DegreesDaysInterval;
            vm.StageName = phenologicalStage.Stage.Name;
            vm.SpecieName = phenologicalStage.Specie.Name;
            return View("~/Views/Agriculture/PhenologicalStages/Delete.cshtml", vm);
        }

        // POST: PhenologicalStages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            PhenologicalStage phenologicalStage = db.PhenologicalStages.Find(id);
            if (phenologicalStage == null)
            {
                return HttpNotFound();
            }
            phenologicalStage.PhenologicalStageIsUsed = false;

            db.Entry(phenologicalStage).State = EntityState.Modified;
            db.SaveChanges();

            return Redirect("/PhenologicalStages");
        }

        private List<System.Web.Mvc.SelectListItem> LoadSpecies(long? specieId = null, PhenologicalStage phenologicalState = null)
        {
            SpecieConfiguration sc = new SpecieConfiguration();

            List<Specie> specie = sc.GetAllSpecie();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in specie)
            {

                bool isSelected = false;
                if (phenologicalState != null && specieId.HasValue)
                {
                    isSelected = (phenologicalState.SpecieId == specieId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.SpecieId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }
        private List<System.Web.Mvc.SelectListItem> LoadStages(long? stageId = null, PhenologicalStage phenologicalState = null)
        {
            StageConfiguration sc = new StageConfiguration();

            List<Stage> stage = sc.GetAllStage();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in stage)
            {

                bool isSelected = false;
                if (phenologicalState != null && stageId.HasValue)
                {
                    isSelected = (phenologicalState.StageId == stageId);
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
    }
}
