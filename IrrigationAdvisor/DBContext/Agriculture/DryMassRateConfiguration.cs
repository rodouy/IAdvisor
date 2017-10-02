using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class DryMassRateConfiguration:
        EntityTypeConfiguration<DryMassRate>
    {
        public DryMassRateConfiguration()
        {
            ToTable("DryMassRate");
            HasKey(dmr => dmr.DryMassRateId);
            Property(dmr => dmr.DryMassRateId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(dmr => dmr.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(dmr => dmr.SpecieId)
                .IsRequired();
            Property(dmr => dmr.SeasonId)
                .IsRequired();
            Property(dmr => dmr.AgeOfCrop)
                .IsRequired();
            Property(dmr => dmr.DurationInDays)
                .IsRequired();
            Property(dmr => dmr.RatePerHectareByDay)
                .IsRequired();
            Property(dmr => dmr.Exponent)
                .IsRequired();
            Property(dmr => dmr.Multiplier)
                .IsRequired();
            Property(dmr => dmr.MaxCoefficient)
                .IsRequired();
            Property(dmr => dmr.RootDepth)
                .IsRequired();
            Property(dmr => dmr.Order)
                .IsRequired();
            Property(dmr => dmr.IsUsed)
                .IsRequired();
        }

        #region Relationship
#if false
            HasRequired(dm => dm.Specie)
                .WithRequiredDependent();
            HasRequired(dm => dm.Season)
                .WithRequiredDependent();
#endif
        #endregion
    }
}