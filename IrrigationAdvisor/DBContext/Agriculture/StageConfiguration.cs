using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class StageConfiguration:
        EntityTypeConfiguration<Stage>
    {

        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        public StageConfiguration()
        {
            ToTable("Stage");
            HasKey(s => s.StageId);
            Property(s => s.StageId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired().HasMaxLength(50);
            
        }

        /// <summary>
        /// Returns stages order
        /// </summary>
        /// <param name="pSpecieId"></param>
        /// <param name="pStageOrder"></param>
        /// <returns></returns>
        public List<Stage> GetStageBy(long pSpecieId, int pStageOrder)
        {
            List<Stage> lResult = new List<Stage>();
            List<PhenologicalStage> lPhenologicalStage = db.PhenologicalStages.Where(p => p.SpecieId == pSpecieId).ToList();

            int lMaxOrder = pStageOrder + InitialTables.MAX_SELECTABLE_STAGE_TO_CHANGE_PHENOLOGICAL_STAGE;
            int lMinOrder = pStageOrder - InitialTables.MIN_SELECTABLE_STAGE_TO_CHANGE_PHENOLOGICAL_STAGE;

            foreach (PhenologicalStage phenologicalStageItem in lPhenologicalStage)
            {
                if(phenologicalStageItem.Stage.Order >= lMinOrder && phenologicalStageItem.Stage.Order <= lMaxOrder)
                {
                    lResult.Add(phenologicalStageItem.Stage);
                }
                
            }

            return lResult.OrderBy(s => s.Order).ToList();

        }
    }
}