using System;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class DryMassConfiguration:
        EntityTypeConfiguration<DryMass>
    {
        public DryMassConfiguration()
        {
            ToTable("DryMass");
            HasKey(dm => dm.DryMassId);
            Property(dm => dm.DryMassId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(dm => dm.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(dm => dm.SpecieId)
                .IsRequired();
            Property(dm => dm.SeasonId)
                .IsRequired();
            Property(dm => dm.AgeOfCrop)
                .IsRequired();
            Property(dm => dm.Day)
                .IsRequired();
            Property(dm => dm.WeightPerHectareInKG)
                .IsRequired();
            Property(dm => dm.Exponent)
                .IsRequired();
            Property(dm => dm.Multiplier)
                .IsRequired();
            Property(dm => dm.Coefficient)
                .IsRequired();
            Property(dm => dm.RootDepth)
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