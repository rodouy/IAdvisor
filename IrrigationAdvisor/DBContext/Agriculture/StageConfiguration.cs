using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

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


        public List<Stage> GetStageBy(int pSpecieId, int pStageOrder)
        {

            List<PhenologicalStage> lPhenologicalStage = db.PhenologicalStages.Where(p => p.SpecieId == pSpecieId).ToList();

            List<Stage> lResult = new List<Stage>();

            foreach (PhenologicalStage phenologicalStageItem in lPhenologicalStage)
            {
                if(phenologicalStageItem.Stage.Order > pStageOrder)
                {
                    lResult.Add(phenologicalStageItem.Stage);
                }
                
            }

            return lResult.OrderBy(s => s.Order).ToList();

        }
    }
}