using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Agriculture;
using System.Data.Entity.ModelConfiguration;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class HydricBalanceAdjustmentConfiguration : EntityTypeConfiguration<HydricBalanceAdjustment>
    {
        public HydricBalanceAdjustmentConfiguration()
        {
            ToTable("HydricBalanceAdjustment");
            HasKey(w => w.HydricBalanceAdjustmentId);

            Property(w => w.HydricBalanceAdjustmentId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}