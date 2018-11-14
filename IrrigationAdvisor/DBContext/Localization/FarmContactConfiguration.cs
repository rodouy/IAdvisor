using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class FarmContactConfiguration : EntityTypeConfiguration<FarmContact>
    {
        public FarmContactConfiguration()
        {
            ToTable("FarmContact");

            HasKey(l => l.FarmContactId);

            Property(l => l.FarmContactId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(l => l.Email).IsRequired();
        }
    }
}