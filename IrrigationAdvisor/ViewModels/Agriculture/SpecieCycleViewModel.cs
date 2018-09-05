using IrrigationAdvisor.Models.Agriculture;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class SpecieCycleViewModel
    {

        #region Consts
        #endregion

        #region Fields

        public long SpecieCycleId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Display(Name = "Duración")]
        public double Duration { get; set; }

        [Display(Name = "Región")]
        public long RegionId { get; set; }

        public List<System.Web.Mvc.SelectListItem> Regions { get; set; }

        [Display(Name = "Región")]
        public string RegionName { get; set; }

        #endregion

        #region Properties
        #endregion

        #region Construction
         public SpecieCycleViewModel() 
        {
        }
         public SpecieCycleViewModel(SpecieCycle sc)
        {
            this.SpecieCycleId = sc.SpecieCycleId; 
            this.Name = sc.Name;
            this.Duration = sc.Duration;
            this.Regions = new List<System.Web.Mvc.SelectListItem>();
            this.RegionName = sc.Region.Name;
           
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