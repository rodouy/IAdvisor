using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.DBContext.Weather
{
    public class MeteoblueWeatherDataConfiguration : EntityTypeConfiguration<MeteoblueWeatherData>
    {
        public MeteoblueWeatherDataConfiguration()
        {
            ToTable("MeteoblueWeatherData");
            HasKey(w => w.MeteoblueWeatherDataId);

            Property(w => w.WeatherStationId)
                .IsRequired();

            Property(w => w.WeatherDate).IsRequired();

            Property(w => w.TemperatureMax).HasColumnType("decimal").HasPrecision(9,2);
            Property(w => w.TemperatureMin).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.TemperatureMean).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.FeltTemperatureMax).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.FeltTemperatureMin).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.PrecipitationProbability).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.Precipitation).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SnowFraction).HasColumnType("decimal").HasPrecision(9,2);

            Property(w => w.WindSpeedMax).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.WindSpeedMean).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.WindSpeedMin).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.ConvectivePrecipitation).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.PrecipitationHours).HasColumnType("decimal").HasPrecision(9, 2);

            Property(w => w.HumidityGreater90Hours).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SoilTemperatureMax).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SoilTemperatureMin).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SoilTemperatureMean).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SkinTemperatureMax).HasColumnType("decimal").HasPrecision(9, 2);

            Property(w => w.SkinTemperatureMin).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SkinTemperatureMean).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.Evapotranspiration).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.LeafWetnessIndex).HasColumnType("decimal").HasPrecision(9, 2);

            Property(w => w.PotentialEvapotranspiration).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.DewPointTemperatureMax).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.DewPointTemperatureMin).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.DewPointTemperatureMean).HasColumnType("decimal").HasPrecision(9, 2);

            Property(w => w.ReferenceEvapotranspirationFao).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.SensibleHeatFlux).HasColumnType("decimal").HasPrecision(9, 2);
            Property(w => w.DewPointTemperatureMean).HasColumnType("decimal").HasPrecision(9, 2);

            Property(w => w.Rainspot).HasColumnType("varchar").HasMaxLength(50);
            Property(w => w.BasicUrl).HasColumnType("varchar").HasMaxLength(200);

            Property(w => w.AgroUrl).HasColumnType("varchar").HasMaxLength(200);

            Property(w => w.AgroJson).HasColumnType("varchar(max)");
            Property(w => w.BasicJson).HasColumnType("varchar(max)");
        }
    }
}