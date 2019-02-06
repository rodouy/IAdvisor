using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class PhenologicalStageViewModel
    {

        #region Consts
        #endregion

        #region Properties
        public long PhenologicalStageId { get; set; }

        [Required]
        [Display(Name = "Grados mínimos")]
        public double MinDegree { get; set; }

        [Display(Name = "Grados máximos")]
        public double MaxDegree { get; set; }


        [Display(Name = "Profuendida de raíz")]
        public double RootDepth { get; set; }
        [Display(Name = "Bal. hídrico")]
        public double HydricBalanceDepth { get; set; }

        [Display(Name = "Coefeiciente")]
        public double Coefficient { get; set; }
        public bool PhenologicalStageIsUsed { get; set; }

        [Display(Name = "Grados acum. diarios")]
        public double DegreesDaysInterval { get; set; }
        
        [Display(Name = "Estadio")]
        public long StageId { get; set; }
         [Display(Name = "Especie")]
        public long SpecieId { get; set; }
        public List<System.Web.Mvc.SelectListItem> Stages { get; set; }
        public List<System.Web.Mvc.SelectListItem> Species { get; set; }
        [Display(Name = "Estadio")]
        public string StageName { get; set; }
        [Display(Name = "Especie")]
        public string SpecieName { get; set; }



        #endregion

        #region Construction
        public PhenologicalStageViewModel() 
        { 
        }
        public PhenologicalStageViewModel(PhenologicalStage phenologicalStage)
        {
            PhenologicalStageId = phenologicalStage.PhenologicalStageId;
            SpecieId = phenologicalStage.SpecieId;
            StageId = phenologicalStage.StageId;
            MinDegree = phenologicalStage.MinDegree;
            MaxDegree = phenologicalStage.MaxDegree;
            RootDepth = phenologicalStage.RootDepth;
            HydricBalanceDepth = phenologicalStage.HydricBalanceDepth;
            Coefficient = phenologicalStage.Coefficient;
            DegreesDaysInterval = phenologicalStage.DegreesDaysInterval;
            SpecieName = phenologicalStage.Specie.Name;
            StageName = phenologicalStage.Stage.Name;

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