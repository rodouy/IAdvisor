using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class DryMassRemainderConfiguration:
        EntityTypeConfiguration<DryMassRemainder>
    {
        public DryMassRemainderConfiguration()
        {
            ToTable("DryMassRemainder");
            HasKey(dmr => dmr.DryMassRemainderId);
            Property(dmr => dmr.DryMassRemainderId)
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
            Property(dmr => dmr.InitialDryMass)
                .IsRequired();
            Property(dmr => dmr.Height)
                .IsRequired();

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
}