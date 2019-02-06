using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.DBContext.Water
{
    public class CalculationByCropIrrigationWeatherConfiguration : EntityTypeConfiguration<CalculationByCropIrrigationWeather>
    {
        public CalculationByCropIrrigationWeatherConfiguration()
        {
            ToTable("CalculationByCropIrrigationWeather");
        }

    }
}