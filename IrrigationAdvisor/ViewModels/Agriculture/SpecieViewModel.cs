using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class SpecieViewModel
    {

        #region Consts
        #endregion

        #region Fields
        public long SpecieId { get; set; }


        [Required]
        [Display(Name = "Nombre")]
        public String ShortName { get; set; }

        [Display(Name = "Temperatura base")]
        public double BaseTemperature { get; set; }

        [Display(Name = "Temperatura stress")]
        public double StressTemperature { get; set; }

        [Display(Name = "Tipo de especie")]
        public Utils.SpecieType SpecieType { get; set; }

        [Display(Name = "Región")]
        public long RegionId { get; set; }
         [Display(Name = "Ciclo de la especie")]
        public long SpecieCycleId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Regions { get; set; }
        public List<System.Web.Mvc.SelectListItem> SpecieCycles { get; set; }
        [Display(Name = "Región")]
        public string RegionName { get; set; }
        public string SpecieCycleName { get; set; }
        #endregion

        #region Properties
        #endregion

        #region Construction
        public SpecieViewModel() 
        { 
        }
        public SpecieViewModel(Specie specie)
        {
            SpecieId = specie.SpecieId;
            ShortName = specie.ShortName;
            BaseTemperature = specie.BaseTemperature;
            StressTemperature = specie.StressTemperature;
            SpecieType = specie.SpecieType;
            SpecieCycleId = specie.SpecieCycleId;
            SpecieCycleName = specie.SpecieCycle.Name;
            RegionId = specie.RegionId;
            RegionName = specie.Region.Name;

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