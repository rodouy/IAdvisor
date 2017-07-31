using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.DBContext.Weather
{
    public class SeasonConfiguration:
        EntityTypeConfiguration<Season>
    {
        public SeasonConfiguration()
        {
            ToTable("Season");
            HasKey(s => s.SeasonId);
            Property(s => s.SeasonId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.RegionId)
                .IsRequired();
            Property(s => s.Year)
                .IsRequired();
            Property(s => s.FromDate)
                .IsRequired();
            Property(s => s.ToDate)
                .IsRequired();

            #region Relationship
            #if false
            HasRequired(l => l.Region)
                .WithRequiredDependent();
            #endif
            #endregion
        }

    }
}