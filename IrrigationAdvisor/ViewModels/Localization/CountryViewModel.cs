using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Localization
{
    public class CountryViewModel
    {

        #region Consts
        #endregion


        [Required]
        public long CountryId { get; set; }
        
        [Required]
        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Capital")]
        public long CapitalId { get; set; }

        public List<System.Web.Mvc.SelectListItem> Capitals { get; set; }

        [Required]        
        [Display(Name = "Idioma")]
        public long LanguageId { get; set; }

        public List<System.Web.Mvc.SelectListItem> Languages { get; set; }

        public City Capital { get; set; }
        public Language Language { get; set; }

        public string CapitalName { get; set; }
        public string CapitalLatitude { get; set; }
        public string CapitalLongitude{ get; set; }


        #region Properties
        #endregion

        #region Construction
        public CountryViewModel() 
        {
        }
        public CountryViewModel(Country country)
        {
            this.Name = country.Name;
            this.CountryId = country.CountryId;
            this.CapitalId = country.CapitalId;
            this.LanguageId = country.LanguageId;
            //ACA this.Capital = country.Capital;
            this.Language = country.Language;

            this.Capitals = new List<System.Web.Mvc.SelectListItem>();
            this.Languages = new List<System.Web.Mvc.SelectListItem>();

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