using IrrigationAdvisor.Models.Agriculture;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class HidricBalanceAdjustmentConfiguration : EntityTypeConfiguration<HidricBalanceAdjustment>
    {
        public HidricBalanceAdjustmentConfiguration()
        {
            ToTable("HydricBalanceAdjustment");
            HasKey(w => w.HydricBalanceAdjustmentId);

            Property(w => w.HydricBalanceAdjustmentId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
        }
    }
}