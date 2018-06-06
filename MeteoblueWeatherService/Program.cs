using MeteoblueWeatherService.Model;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Linq;
using System.Net;

namespace MeteoblueWeatherService
{
    public class Program
    {
        static void Main(string[] args)
        {
            const string basicData = "basic-day";
            const string agroData = "agro-day";
            /*string text = System.IO.File.ReadAllText(@"C:\Users\Lenovo\Documents\RodoUY\MeteoblueWeatherService\Examples\BasicData.txt");

            BasicData m = JsonConvert.DeserializeObject<BasicData>(text);

            Console.Write(m.data_day.felttemperature_max);
            Console.ReadLine();

            text = System.IO.File.ReadAllText(@"C:\Users\Lenovo\Documents\RodoUY\MeteoblueWeatherService\Examples\AgroData.txt");

            AgroData b = JsonConvert.DeserializeObject<AgroData>(text);

            Console.Write(b.data_day.dewpointtemperature_max);
            Console.ReadLine();*/

            WebClient client = new WebClient();

            try
            {
                string[] ids = ConfigurationManager.AppSettings["WeatherStations"].Split(',');

                using (Entities context = new Entities())
                {
                    foreach (string item in ids)
                    {
                        long identifier = Convert.ToInt64(item);

                        var weatherStation = context.WeatherStations
                                            .Single(n => n.WeatherStationId == identifier);

                        var position = context.Positions
                                       .Single(n => n.PositionId == weatherStation.PositionId);

                        string url = string.Format(ConfigurationManager.AppSettings["Url"], basicData, position.Latitude, position.Longitude);

                        string result = client.DownloadString(url);

                        BasicData basicDataValues = JsonConvert.DeserializeObject<BasicData>(result);

                        url = string.Format(ConfigurationManager.AppSettings["Url"], agroData, position.Latitude, position.Longitude);

                        result = client.DownloadString(url);

                        AgroData agroDataValues = JsonConvert.DeserializeObject<AgroData>(result);

                        for (int i = 0; i < basicDataValues.data_day.time.Count - 1; i++)
                        {
                            MeteoblueWeatherData meteoblueWeatherData = new MeteoblueWeatherData()
                            {
                                WeatherStationId = identifier,
                                WeatherDate = Convert.ToDateTime(basicDataValues.data_day.time.ElementAt(i)),
                                ConvectivePrecipitation = basicDataValues.data_day.convective_precipitation.ElementAt(i),
                                DewPointTemperatureMax = agroDataValues.data_day.dewpointtemperature_max.ElementAt(i),
                                DewPointTemperatureMean = agroDataValues.data_day.dewpointtemperature_mean.ElementAt(i),
                                DewPointTemperatureMin = agroDataValues.data_day.dewpointtemperature_min.ElementAt(i),
                                Evapotranspiration = agroDataValues.data_day.evapotranspiration.ElementAt(i),
                                FeltTemperatureMax = basicDataValues.data_day.felttemperature_max.ElementAt(i),
                                FeltTemperatureMin = basicDataValues.data_day.felttemperature_min.ElementAt(i),
                                HumidityGreater90Hours = basicDataValues.data_day.humiditygreater90_hours.ElementAt(i),
                                LeafWetnessIndex = agroDataValues.data_day.leafwetnessindex.ElementAt(i),
                                PotentialEvapotranspiration = agroDataValues.data_day.potentialevapotranspiration.ElementAt(i),
                                Precipitation = basicDataValues.data_day.precipitation.ElementAt(i),
                                PrecipitationHours = basicDataValues.data_day.precipitation_hours.ElementAt(i),
                                PrecipitationProbability = basicDataValues.data_day.precipitation_probability.ElementAt(i),
                                Predictability = basicDataValues.data_day.predictability.ElementAt(i),
                                PredictabilityClass = basicDataValues.data_day.predictability_class.ElementAt(i),
                                Rainspot = basicDataValues.data_day.rainspot.ElementAt(i),
                                ReferenceEvapotranspirationFao = agroDataValues.data_day.referenceevapotranspiration_fao.ElementAt(i),
                                RelativeHumidityMax = basicDataValues.data_day.relativehumidity_max.ElementAt(i),
                                RelativehumidityMean = basicDataValues.data_day.relativehumidity_mean.ElementAt(i),
                                RelativeHumidityMin = basicDataValues.data_day.relativehumidity_min.ElementAt(i),
                                SealevelPressureMax = basicDataValues.data_day.sealevelpressure_max.ElementAt(i),
                                SealevelPressureMean = basicDataValues.data_day.sealevelpressure_mean.ElementAt(i),
                                SealevelPressureMin = basicDataValues.data_day.sealevelpressure_min.ElementAt(i),
                                SensibleHeatFlux = agroDataValues.data_day.sensibleheatflux.ElementAt(i),
                                SkinTemperatureMax = agroDataValues.data_day.skintemperature_max.ElementAt(i),
                                SkinTemperatureMean = agroDataValues.data_day.skintemperature_mean.ElementAt(i),
                                SkinTemperatureMin = agroDataValues.data_day.skintemperature_min.ElementAt(i),
                                SnowFraction = basicDataValues.data_day.snowfraction.ElementAt(i),
                                SoilMoistureMax = agroDataValues.data_day.soilmoisture_0to10cm_max.ElementAt(i),
                                SoilMoistureMean = agroDataValues.data_day.soilmoisture_0to10cm_mean.ElementAt(i),
                                SoilMoistureMin = agroDataValues.data_day.soilmoisture_0to10cm_min.ElementAt(i),
                                SoilTemperatureMax = agroDataValues.data_day.soiltemperature_0to10cm_max.ElementAt(i),
                                SoilTemperatureMean = agroDataValues.data_day.soiltemperature_0to10cm_mean.ElementAt(i),
                                SoilTemperatureMin = agroDataValues.data_day.soiltemperature_0to10cm_min.ElementAt(i),
                                TemperatureMax = basicDataValues.data_day.temperature_max.ElementAt(i),
                                TemperatureMean = basicDataValues.data_day.temperature_mean.ElementAt(i),
                                TemperatureMin = basicDataValues.data_day.temperature_min.ElementAt(i),
                                UvIndex = basicDataValues.data_day.uvindex.ElementAt(i),
                                WindDirection = basicDataValues.data_day.winddirection.ElementAt(i),
                                WindSpeedMax = basicDataValues.data_day.windspeed_max.ElementAt(i),
                                WindSpeedMean = basicDataValues.data_day.windspeed_mean.ElementAt(i),
                                WindSpeedMin = basicDataValues.data_day.windspeed_min.ElementAt(i),
                            };

                            context.MeteoblueWeatherDatas.Add(meteoblueWeatherData);
                        }
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }           
        }
    }
}
