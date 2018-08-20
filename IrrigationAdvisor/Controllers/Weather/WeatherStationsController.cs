using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ViewModels.Weather;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.DBContext.Weather;

namespace IrrigationAdvisor.Controllers.Weather
{
    public class WeatherStationsController : Controller
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        // GET: WeatherStations
        public ActionResult Index()
        {
            return View("~/Views/Weather/WeatherStations/Index.cshtml", db.WeatherStations.ToList());
        }

        // GET: WeatherStations/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherStation ws = db.WeatherStations.Find(id);
            if (ws == null)
            {
                return HttpNotFound();
            }

            WeatherStationViewModel vm = new WeatherStationViewModel();
            vm.WeatherStationId = ws.WeatherStationId;
            vm.Farms = this.GetFarmListBy(ws);
            vm.FarmsNotRelated = this.GetFarmNotRelatedListBy(ws);
            vm.DateOfInstallation = ws.DateOfInstallation;
            vm.DateOfService = ws.DateOfService;
            vm.Enabled = ws.Enabled;
            vm.GiveET = ws.GiveET;
            vm.Model = ws.Model;
            vm.Name = ws.Name;
            vm.Latitude = ws.Position.Latitude;
            vm.Longitude = ws.Position.Longitude;
            vm.StationType = ws.StationType;
            vm.UpdateTime = ws.UpdateTime;
            vm.WeatherDataType = ws.WeatherDataType;
            vm.WebAddress = ws.WebAddress;
            vm.WirelessTransmission = ws.WirelessTransmission;

            return View("~/Views/Weather/WeatherStations/Details.cshtml", vm);
        }

        // GET: WeatherStations/Create
        public ActionResult Create()
        {
            WeatherStationViewModel vm = new WeatherStationViewModel();
            vm.Farms = this.LoadFarms();
            return View("~/Views/Weather/WeatherStations/Create.cshtml", vm);
        }

        // POST: WeatherStations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "WeatherStationId,Name,Model,DateOfInstallation,DateOfService,UpdateTime,WirelessTransmission,GiveET,WeatherDataType, Enabled, Latitude, Longitude, FarmIdSelected")] WeatherStationViewModel wsm)
        {
            var a = wsm.FarmId;
            if (ModelState.IsValid)
            {
                WeatherStation ws = new WeatherStation();

                long lPositionId = GetPositionId(wsm.Latitude, wsm.Longitude);
                                //Not exist position to farm
                if (lPositionId == 0)
                {
                    Position lPosition = new Position();
                    lPosition.Latitude = wsm.Latitude;
                    lPosition.Longitude = wsm.Longitude;
                    lPosition.Name = wsm.Name + " - Estación meteorológica";
                    ws.Position = lPosition;
                }
                else
                {
                    ws.PositionId = lPositionId;
                }
                ws.DateOfInstallation = wsm.DateOfInstallation;
                ws.DateOfService = wsm.DateOfService;
                ws.Enabled = wsm.Enabled;
                ws.GiveET = wsm.GiveET;
                ws.Model = wsm.Model;
                ws.Name = wsm.Name;
                ws.StationType = wsm.StationType;
                ws.UpdateTime = wsm.UpdateTime;
                ws.WeatherDataType = wsm.WeatherDataType;
                ws.WebAddress = wsm.WebAddress;
                ws.WirelessTransmission = wsm.WirelessTransmission;
                
                db.WeatherStations.Add(ws);
                db.SaveChanges();

                WeatherStationConfiguration wsc = new WeatherStationConfiguration();
                long lastWeatherStationId=wsc.GetMaxWeatherStationId();

                //Save Relation whit Farm
                string[] farmIds = wsm.FarmIdSelected.Split('|');
                foreach (var farmId in farmIds)
                {
                    Farm lFarm = db.Farms.Find(int.Parse(farmId));
                    lFarm.WeatherStationId = lastWeatherStationId;
                    db.Entry(lFarm).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
            return Redirect("/WeatherStations");
           // return View("~/Views/Weather/WeatherStations/Index.cshtml", db.WeatherStations.ToList());
        }

        // GET: WeatherStations/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherStation ws = db.WeatherStations.Find(id);
            if (ws == null)
            {
                return HttpNotFound();
            }

            WeatherStationViewModel vm = new WeatherStationViewModel();
            vm.WeatherStationId = ws.WeatherStationId;
            vm.Farms = this.GetFarmListBy(ws);
            vm.FarmsNotRelated = this.GetFarmNotRelatedListBy(ws);
            vm.DateOfInstallation = ws.DateOfInstallation;
            vm.DateOfService = ws.DateOfService;
            vm.Enabled = ws.Enabled;
            vm.GiveET = ws.GiveET;
            vm.Model = ws.Model;
            vm.Name = ws.Name;
            vm.Latitude = ws.Position.Latitude;
            vm.Longitude = ws.Position.Longitude;
            vm.StationType = ws.StationType;
            vm.UpdateTime =  ws.UpdateTime;
            vm.WeatherDataType = ws.WeatherDataType;
            vm.WebAddress = ws.WebAddress;
            vm.WirelessTransmission = ws.WirelessTransmission;
            
            return View("~/Views/Weather/WeatherStations/Edit.cshtml", vm);
        }

        // POST: WeatherStations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "WeatherStationId,Name,Model,DateOfInstallation,DateOfService,UpdateTime,WirelessTransmission,GiveET,WeatherDataType, Enabled, Latitude, Longitude, FarmIdSelected")] WeatherStationViewModel wsm)
        {
            if (ModelState.IsValid)
            {
                WeatherStation ws = db.WeatherStations.Find(wsm.WeatherStationId);
                if (ws == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }

                long lPositionId = GetPositionId(wsm.Latitude, wsm.Longitude);
                //Not exist position to farm
                if (lPositionId == 0)
                {
                    Position lPosition = new Position();
                    lPosition.Latitude = wsm.Latitude;
                    lPosition.Longitude = wsm.Longitude;
                    lPosition.Name = wsm.Name + " - Estación meteorológica";
                    ws.Position = lPosition;
                }
                else
                {
                    ws.PositionId = lPositionId;
                }
                ws.DateOfInstallation = wsm.DateOfInstallation;
                ws.DateOfService = wsm.DateOfService;
                ws.Enabled = wsm.Enabled;
                ws.GiveET = wsm.GiveET;
                ws.Model = wsm.Model;
                ws.Name = wsm.Name;
                ws.StationType = wsm.StationType;
                ws.UpdateTime = wsm.UpdateTime;
                ws.WeatherDataType = wsm.WeatherDataType;
                ws.WebAddress = wsm.WebAddress;
                ws.WirelessTransmission = wsm.WirelessTransmission;

                db.Entry(ws).State = EntityState.Modified;
                db.SaveChanges();
            
                //Save Relation whit Farm
                string[] farmIds = wsm.FarmIdSelected.Split('|');
                foreach (var farmId in farmIds)
                {
                    Farm lFarm = db.Farms.Find(int.Parse(farmId));
                    lFarm.WeatherStationId = wsm.WeatherStationId;
                    db.Entry(lFarm).State = EntityState.Modified;
                    db.SaveChanges();
                }


            }
            return Redirect("/WeatherStations");
            //return View("~/Views/Weather/WeatherStations/Index.cshtml", db.WeatherStations.ToList());
        }

        // GET: WeatherStations/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WeatherStation ws = db.WeatherStations.Find(id);
            if (ws == null)
            {
                return HttpNotFound();
            }

            WeatherStationViewModel vm = new WeatherStationViewModel();
            vm.WeatherStationId = ws.WeatherStationId;
            vm.Farms = this.GetFarmListBy(ws);
            vm.FarmsNotRelated = this.GetFarmNotRelatedListBy(ws);
            vm.DateOfInstallation = ws.DateOfInstallation;
            vm.DateOfService = ws.DateOfService;
            vm.Enabled = ws.Enabled;
            vm.GiveET = ws.GiveET;
            vm.Model = ws.Model;
            vm.Name = ws.Name;
            vm.Latitude = ws.Position.Latitude;
            vm.Longitude = ws.Position.Longitude;
            vm.StationType = ws.StationType;
            vm.UpdateTime = ws.UpdateTime;
            vm.WeatherDataType = ws.WeatherDataType;
            vm.WebAddress = ws.WebAddress;
            vm.WirelessTransmission = ws.WirelessTransmission;

            return View("~/Views/Weather/WeatherStations/Delete.cshtml", vm);
        }

        // POST: WeatherStations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            WeatherStation ws = db.WeatherStations.Find(id);
            ws.Enabled = false;
            db.Entry(ws).State = EntityState.Modified;
            db.SaveChanges();
            return Redirect("/WeatherStations");
           // return View("~/Views/Weather/WeatherStations/Index.cshtml", db.WeatherStations.ToList());
        }

        private List<System.Web.Mvc.SelectListItem> LoadFarms(long? farmId = null, User user = null)
        {
            FarmConfiguration fc = new FarmConfiguration();

            List<Farm> farms = fc.GetAllFarms();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in farms)
            {
                bool isSelected = false;
                if (user != null && farmId.HasValue)
                {
                    isSelected = (user.RoleId == farmId);
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

        private List<System.Web.Mvc.SelectListItem> GetFarmNotRelatedListBy(WeatherStation pWeatherStation)
        {
            FarmConfiguration fc = new FarmConfiguration();
            List<Farm> farms = fc.GetFarmNotRelatedListBy(pWeatherStation);

            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in farms)
            {
                SelectListItem sl = new SelectListItem()
                {
                    Value = item.FarmId.ToString(),
                    Text = item.Name,
                };
                result.Add(sl);
            }
            return result;
        }

        private List<System.Web.Mvc.SelectListItem> GetFarmListBy(WeatherStation pWeatherStation)
        {
            FarmConfiguration fc = new FarmConfiguration();
            List<Farm> farms = fc.GetFarmListBy(pWeatherStation);

            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in farms)
            {

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.FarmId.ToString(),
                    Disabled = true,
                    Text = item.Name,
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
