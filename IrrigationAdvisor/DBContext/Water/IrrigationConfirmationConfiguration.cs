using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.DBContext.Water
{
    public class IrrigationConfirmationConfiguration : EntityTypeConfiguration<IrrigationConfirmation>
    {
        public IrrigationConfirmationConfiguration()
        {
            ToTable("IrrigationConfirmation");

            HasKey(l => l.IrrigationConfirmationId);

            Property(l => l.IrrigationConfirmationId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}