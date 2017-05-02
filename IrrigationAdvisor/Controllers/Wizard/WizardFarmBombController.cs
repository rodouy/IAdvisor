using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext;
using IrrigationAdvisor.ViewModels.Wizard;
//using IrrigationAdvisor.Models.Irrigation;


using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Weather;
using IrrigationAdvisor.Models.Weather;
//using IrrigationAdvisor.Models.Utilities;



namespace IrrigationAdvisor.Controllers.Wizard
{
    public class WizardFarmController : Controller
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        //public ActionResult Index()
        //{
        //    //return View("~/Views/Wizard/FarmBomb/Index.cshtml");

        //}

        // GET: Users/Create
        public ActionResult Index()
        {
            WizardFarmBombViewModel vm = new WizardFarmBombViewModel();

            vm.wizardFarmViewModel.City = this.LoadCities();
            vm.wizardFarmViewModel.WeatherStation = this.LoadWeatherStations();

            return View("~/Views/Wizard/FarmBomb/Index.cshtml");
        }


        private List<System.Web.Mvc.SelectListItem> LoadCities(long? cityId = null, City city = null)
        {

            CityConfiguration cc  = new CityConfiguration();
            
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
            WeatherStationConfiguration  wsc = new WeatherStationConfiguration();

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


        public IEnumerable<object> weatherStations { get; set; }
    }
}
