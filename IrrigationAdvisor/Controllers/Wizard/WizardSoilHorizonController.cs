using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Create([Bind(Include = "Name, Description, Latitude, Longitude, TestDate, DepthLimit, FarmId, HorizonsHidden")] WizardSoilHorizonViewModel vm)    
        {
            if (ModelState.IsValid)
            {
                Soil soilMapped = new Soil();
                long lsoilPositionId = GetPositionId(vm.Latitude, vm.Longitude);
                

                Position positionFarm = new Position();
                //Not exist position to farm
                if (lsoilPositionId == 0)
                {
                    positionFarm.Latitude = vm.Latitude;
                    positionFarm.Longitude = vm.Longitude;
                    positionFarm.Name = "DEFINIR El NOMBRE DE LA POS";
                   // soilMapped.Position = positionFarm;
                }
                else
                {
                    soilMapped.PositionId = lsoilPositionId;
                }

                // working whit bombs
                dynamic items = JsonConvert.DeserializeObject(vm.HorizonsHidden);
                foreach (var item in items.items)
                {
                    Horizon horizon = new Horizon();
                    horizon.Name = item.bombName;
                    //horizon.SerialNumber = item.serialNumber;

                    //horizon.ServiceDate = ((String)item.serviceDate == "") ? Utils.MIN_DATETIME : item.serviceDate;
                    //horizon.PurchaseDate = ((String)item.purchaseDate == "") ? Utils.MIN_DATETIME : item.purchaseDate;                 
                    //soilMapped.AddBomb(horizon);
                }

                soilMapped.Name = vm.Name;
                //soilMapped.Company = vm.Company;
                //soilMapped.Address = vm.Address;
                //soilMapped.Phone = vm.Phone;
                //soilMapped.Has = vm.Has;
                //soilMapped.WeatherStationId = vm.WeatherStationId;
                //soilMapped.CityId = vm.CityId;

                db.Soils.Add(soilMapped);
                db.SaveChanges();

                ////return RedirectToAction("Index");
            }

            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml",vm);
        }

        #region private methondaux

        private long GetPositionId(double pLatitude, double pLongitude)
        {
            PositionConfiguration pc;
            pc = new PositionConfiguration();
            return pc.GetPositionIdByLatitudLongitud( pLatitude, pLongitude);
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
