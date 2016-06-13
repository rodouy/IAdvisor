using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.DBContext.Weather
{
    public class TemperatureDataConfiguration
        : EntityTypeConfiguration<TemperatureData>
    {

        public TemperatureDataConfiguration()
        {
            ToTable("TemperatureData");
            HasKey(w => w.TemperatureDataId);
            Property(w => w.TemperatureDataId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #region Relationship

            #endregion
        }

    }
}