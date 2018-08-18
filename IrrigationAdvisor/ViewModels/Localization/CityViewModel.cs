using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Localization
{
    public class CityViewModel
    {

        #region Consts
        #endregion


        public long CityId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Display(Name = "Latitud")]
        public double Latitude { get; set; }
        
        [Display(Name = "Longitud")]
        public double Longitude { get; set; }

        [Display(Name = "País")]
        public long CountryId { get; set; }

        public List<System.Web.Mvc.SelectListItem> Countries { get; set; }

        public Language Language { get; set; }
        public List<System.Web.Mvc.SelectListItem> Languages { get; set; }

        [Display(Name = "País")]
        public string CountryName { get; set; }
        public long CountryLanguageId { get; set; }
        public long PositionId { get; set; }


        #region Fields
        #endregion

        #region Properties
        #endregion

        #region Construction

        public CityViewModel() 
        {
        }
        public CityViewModel(City city)
        {
            this.CityId = city.CityId; 
            this.Name = city.Name;
            this.CountryId = city.CountryId;
            this.Countries = new List<System.Web.Mvc.SelectListItem>();
            this.Languages = new List<System.Web.Mvc.SelectListItem>();
            this.PositionId = city.PositionId;
            this.Latitude = city.Position.Latitude;
            this.Longitude = city.Position.Longitude;
            this.CountryName = city.Country.Name;
            this.CountryLanguageId = city.Country.LanguageId;
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