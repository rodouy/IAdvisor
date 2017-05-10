using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Wizard;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Weather;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models;



namespace IrrigationAdvisor.Controllers.Wizard
{
    public class WizardFarmBombController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        // GET: Users/Create
        public ActionResult Index()
        {
            WizardFarmBombViewModel vm = new WizardFarmBombViewModel();

            vm.WizardFarmViewModel.City = this.LoadCities();
            vm.WizardFarmViewModel.WeatherStation = this.LoadWeatherStations();

            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml",vm);
        }


        // POST: Users/Create;
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name,Company, Address,Phone, Latitude, Longitude, Has, WeatherStationId, CityId")] WizardFarmBombViewModel vm)
        {


            if (ModelState.IsValid)
            {
               

                // for each de las bombas, creando nuevas bombas...
                //luego farmMapped.AddBomb() (agrego las bombas a la lista de las farms )
                // todo el savechange junto
                PositionConfiguration pc;
                pc = new PositionConfiguration();
                long lPositionId; 
                lPositionId = pc.GetPositionIdByLatitudLongitud(99,99);
                
                var farmMapped = new Farm
                {
                    Name = vm.WizardFarmViewModel.Name,
                    Company = vm.WizardFarmViewModel.Company,
                    Address = vm.WizardFarmViewModel.Address,
                    Phone = vm.WizardFarmViewModel.Phone,
                    PositionId = lPositionId,
                    Has = vm.WizardFarmViewModel.Has,
                    WeatherStationId = vm.WizardFarmViewModel.WeatherStationId,
                    CityId = vm.WizardFarmViewModel.CityId,
                    
                };
          
                db.SaveChanges();

                //return RedirectToAction("Index");
            }

            return View("~/Views/Wizard/FarmBomb/Wizard.cshtml",vm);
        }

        #region private aux
        private List<System.Web.Mvc.SelectListItem> LoadCities(long? cityId = null, City city = null)
        {

            CityConfiguration cc = new CityConfiguration();

            List<City> cities = cc.GetAllCities();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in cities)
            {

                bool isSelected = false;
                if (city != null && cityId.HasValue)
                {
                    isSelected = (city.CityId == cityId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.CityId.ToString(),
                    Text = item.Name,
                    Selected = isSelected
                };

                result.Add(sl);
            }

            return result;
        }

        private List<System.Web.Mvc.SelectListItem> LoadWeatherStations(long? weatherStationId = null, WeatherStation weatherStation = null)
        {
            WeatherStationConfiguration wsc = new WeatherStationConfiguration();

            List<WeatherStation> weatherStations = wsc.GetAllWeatherStations();
            List<System.Web.Mvc.SelectListItem> result = new List<SelectListItem>();

            foreach (var item in weatherStations)
            {

                bool isSelected = false;
                if (weatherStation != null && weatherStationId.HasValue)
                {
                    isSelected = (weatherStation.WeatherStationId == weatherStationId);
                }

                SelectListItem sl = new SelectListItem()
                {
                    Value = item.WeatherStationId.ToString(),
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
