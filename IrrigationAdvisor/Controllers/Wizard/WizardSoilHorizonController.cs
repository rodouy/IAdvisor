using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Wizard;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Agriculture;

using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Weather;
using IrrigationAdvisor.Models;

//using IrrigationAdvisor.Models.Irrigation;
using Newtonsoft.Json;
//using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Security;



namespace IrrigationAdvisor.Controllers.Wizard
{
    public class WizardSoilHorizonController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        // GET: Users/Create
        public ActionResult Index()
        {
            WizardSoilHorizonViewModel vm = new WizardSoilHorizonViewModel();
            vm.Farm = this.LoadFarms();
            return View("~/Views/Wizard/SoilHorizon/Wizard.cshtml", vm);
        }


        // POST: Users/Create;
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

                    soilMapped.AddHorizon(lhorizonName, lorder, lhorizonLayer, lhorizonLayerDepth, lsand, llimo, lclay, lorganicMatter, lnitrogenAnalysis, lbulkDensitySoil );
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

            var lSoilList = db.Soils.Include(b => b.Farm);
            return View("~/Views/Agriculture/Soils/Index.cshtml", lSoilList.ToList());

        }

        #region private methondaux

        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud(pLatitude, pLongitude);
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


        #endregion


    }
}
