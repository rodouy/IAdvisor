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

        public List<System.Web.Mvc.SelectListItem> Capital { get; set; }

        [Required]        
        [Display(Name = "Idioma")]
        public long LanguageId { get; set; }

        public List<System.Web.Mvc.SelectListItem> Language { get; set; }


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


            this.Capital = new List<System.Web.Mvc.SelectListItem>();
            this.Language = new List<System.Web.Mvc.SelectListItem>();

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