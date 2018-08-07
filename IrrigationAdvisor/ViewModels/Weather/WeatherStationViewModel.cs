using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Weather
{
    public class WeatherStationViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long WeatherStationId { get; set; }

        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Display(Name = "Modelo")]
        public String Model { get; set; }

        [Display(Name = "Tipo")]
        public Utils.WeatherStationType StationType { get; set; }

        [Display(Name = "Fecha instalación")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfInstallation { get; set; }

        [Display(Name = "Fecha servicio")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfService { get; set; }

        [Display(Name = "Fecha actualización")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime UpdateTime { get; set; }

        [Display(Name = "Trans. wireless")]
        public int WirelessTransmission { get; set; }

        public long PositionId { get; set; }

        [Display(Name = "Brinda ET")]
        public bool GiveET { get; set; }

        /*
        public List<WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }
         * */
        [Display(Name = "Tipo de datos")]
        public Utils.WeatherDataType WeatherDataType { get; set; }

        [Display(Name = "Dirección web")]
        public String WebAddress { get; set; }

        public Position Position { get; set; }
        [Display(Name = "Establecimiento")]
        public long  FarmId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Farms { get; set; }
        
        public string  FarmIdSelected { get; set; }

        [Display(Name = "Latitud")]
        public double Latitude { get; set; }       
        [Display(Name = "Longitud")]
        public double Longitude { get; set; }
        public List<System.Web.Mvc.SelectListItem> FarmsNotRelated { get; set; }
        
        [Display(Name = "Habilitada")]
        public bool Enabled { get; set; }
      


        #endregion

        #region Construction
        public WeatherStationViewModel()
        { 
        }
        public WeatherStationViewModel(WeatherStation pWeatherStation)
        {
            this.WeatherStationId = pWeatherStation.WeatherStationId;
            this.Name = pWeatherStation.Name;
            this.Position = pWeatherStation.Position;
            this.DateOfInstallation = pWeatherStation.DateOfInstallation;
            this.DateOfService = pWeatherStation.DateOfService;
            this.GiveET = pWeatherStation.GiveET;
            this.Model = pWeatherStation.Model;
            this.StationType = pWeatherStation.StationType;
            this.UpdateTime = pWeatherStation.UpdateTime;
            this.WebAddress = pWeatherStation.WebAddress;
            this.WirelessTransmission = pWeatherStation.WirelessTransmission;
            this.Latitude = pWeatherStation.Position.Latitude;
            this.Longitude = pWeatherStation.Position.Longitude;
            this.Enabled = pWeatherStation.Enabled;
        }
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

    }
}