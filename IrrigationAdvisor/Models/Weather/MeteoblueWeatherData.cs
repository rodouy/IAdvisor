using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Weather
{
    public class MeteoblueWeatherData
    {
        public long MeteoblueWeatherDataId { get; set; }
        public long WeatherStationId { get; set; }
        public System.DateTime WeatherDate { get; set; }
        public Nullable<int> UvIndex { get; set; }
        public Nullable<decimal> TemperatureMax { get; set; }
        public Nullable<decimal> TemperatureMin { get; set; }
        public Nullable<decimal> TemperatureMean { get; set; }
        public Nullable<decimal> FeltTemperatureMax { get; set; }
        public Nullable<decimal> FeltTemperatureMin { get; set; }
        public Nullable<int> WindDirection { get; set; }
        public Nullable<decimal> PrecipitationProbability { get; set; }
        public string Rainspot { get; set; }
        public Nullable<int> PredictabilityClass { get; set; }
        public Nullable<int> Predictability { get; set; }
        public Nullable<decimal> Precipitation { get; set; }
        public Nullable<decimal> SnowFraction { get; set; }
        public Nullable<int> SealevelPressureMax { get; set; }
        public Nullable<int> SealevelPressureMin { get; set; }
        public Nullable<int> SealevelPressureMean { get; set; }
        public Nullable<decimal> WindSpeedMax { get; set; }
        public Nullable<decimal> WindSpeedMean { get; set; }
        public Nullable<decimal> WindSpeedMin { get; set; }
        public Nullable<int> RelativeHumidityMax { get; set; }
        public Nullable<int> RelativeHumidityMin { get; set; }
        public Nullable<int> RelativehumidityMean { get; set; }
        public Nullable<decimal> ConvectivePrecipitation { get; set; }
        public Nullable<decimal> PrecipitationHours { get; set; }
        public Nullable<decimal> HumidityGreater90Hours { get; set; }
        public Nullable<decimal> SoilTemperatureMax { get; set; }
        public Nullable<decimal> SoilTemperatureMin { get; set; }
        public Nullable<decimal> SoilTemperatureMean { get; set; }
        public Nullable<int> SoilMoistureMax { get; set; }
        public Nullable<int> SoilMoistureMin { get; set; }
        public Nullable<int> SoilMoistureMean { get; set; }
        public Nullable<decimal> SkinTemperatureMax { get; set; }
        public Nullable<decimal> SkinTemperatureMin { get; set; }
        public Nullable<decimal> SkinTemperatureMean { get; set; }
        public Nullable<decimal> Evapotranspiration { get; set; }
        public Nullable<decimal> LeafWetnessIndex { get; set; }
        public Nullable<decimal> PotentialEvapotranspiration { get; set; }
        public Nullable<decimal> DewPointTemperatureMax { get; set; }
        public Nullable<decimal> DewPointTemperatureMin { get; set; }
        public Nullable<decimal> DewPointTemperatureMean { get; set; }
        public Nullable<decimal> ReferenceEvapotranspirationFao { get; set; }
        public Nullable<decimal> SensibleHeatFlux { get; set; }
        public System.DateTime LastModificationDate { get; set; }
        public string BasicJson { get; set; }
        public string BasicUrl { get; set; }
        public string AgroJson { get; set; }
        public string AgroUrl { get; set; }
        public virtual WeatherStation WeatherStation { get; set; }
    }
}