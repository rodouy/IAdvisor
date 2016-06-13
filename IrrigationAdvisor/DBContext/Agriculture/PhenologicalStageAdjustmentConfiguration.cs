using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class PhenologicalStageAdjustmentConfiguration:
        EntityTypeConfiguration<PhenologicalStageAdjustment>
    {

        public PhenologicalStageAdjustmentConfiguration()
        {
            ToTable("PhenologicalStageAdjustment");
            HasKey(a => a.PhenologicalStageAdjustmentId);
            Property(a => a.PhenologicalStageAdjustmentId)
                .IsRequired();

        }
    }
}