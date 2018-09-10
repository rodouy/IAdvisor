using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class CropViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties
        public long CropId { get; set; }
        [Display(Name = "Nombre")]
        public String Name { get; set; }
        
        [Display(Name = "Nombre")]
        public String ShortName { get; set; }
        
        [Display(Name = "Región")]
        public long RegionId { get; set; }
        
        [Display(Name = "Especie")]
        public long SpecieId { get; set; }
        [Display(Name = "Coeficiente del cultivo")]
        
        public long CropCoefficientId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Stages;
        public List<System.Web.Mvc.SelectListItem> PhenologicalStages;

        public List<System.Web.Mvc.SelectListItem> CropCoefficients;
        public List<System.Web.Mvc.SelectListItem> Regions;
        public List<System.Web.Mvc.SelectListItem> Species;
        
        [Display(Name = "Estadio min. ET")]
        public long MinStageToConsiderETinHBCalculationId { get; set; }
        
        public Region Region { get; set; }
        
        public Specie Specie { get; set; }
        
        [Display(Name = "Coeficiente del cultivo")]
        public CropCoefficient CropCoefficient { get; set; }
        
        [Display(Name = "Max. ETC riego")]
        public Double MaxEvapotranspirationToIrrigate { get; set; }
        
        [Display(Name = "Min. ETC riego")]
        public Double MinEvapotranspirationToIrrigate { get; set; }
        
        [Display(Name = "Estadio stop riego")]
        public long StopIrrigationStageId  { get; set; }
        #endregion
        
        public Stage MinStageToConsiderETinHBCalculation { get; set; }
        public Stage StopIrrigationStage { get; set; }

        #region Construction
        public CropViewModel()
        {
        }
        public CropViewModel(Crop pCrop)
        {
            CropId = pCrop.CropId;
            Name = pCrop.Name;
            ShortName = pCrop.ShortName;
            SpecieId = pCrop.SpecieId;
            CropCoefficientId = pCrop.CropCoefficientId;
            RegionId = pCrop.RegionId;
            Region = pCrop.Region;
            Specie = pCrop.Specie;
            CropCoefficient = pCrop.CropCoefficient;
            MaxEvapotranspirationToIrrigate = pCrop.MaxEvapotranspirationToIrrigate;
            MinEvapotranspirationToIrrigate = pCrop.MinEvapotranspirationToIrrigate;
            MinStageToConsiderETinHBCalculationId = pCrop.MinStageToConsiderETinHBCalculationId;
            StopIrrigationStageId = pCrop.StopIrrigationStageId;
            MinStageToConsiderETinHBCalculation = pCrop.MinStageToConsiderETinHBCalculation;
            StopIrrigationStage = pCrop.StopIrrigationStage;
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