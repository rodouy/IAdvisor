using MeteoblueWeatherService.Model;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace MeteoblueWeatherService
{
    public class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            const string basicData = "basic-day";
            const string agroData = "agro-day";
            
            ////if (false)
            ////{
            ////    string text = System.IO.File.ReadAllText(@"C:\Users\Lenovo\Documents\RodoUY\MeteoblueWeatherService\Examples\BasicData.txt");

            ////    BasicData m = JsonConvert.DeserializeObject<BasicData>(text);

            ////    Console.Write(m.data_day.felttemperature_max);
            ////    Console.ReadLine();

            ////    text = System.IO.File.ReadAllText(@"C:\Users\Lenovo\Documents\RodoUY\MeteoblueWeatherService\Examples\AgroData.txt");

            ////    AgroData b = JsonConvert.DeserializeObject<AgroData>(text);

            ////    Console.Write(b.data_day.dewpointtemperature_max);
            ////    Console.ReadLine();
            ////}
            

            WebClient client = new WebClient();

            try
            {
                string[] ids = ConfigurationManager.AppSettings["WeatherStations"].Split(',');

                using (Entities context = new Entities())
                {
                    List<MeteoblueWeatherData> processedData = new List<MeteoblueWeatherData>();

                    foreach (string item in ids)
                    {
                        long identifier = Convert.ToInt64(item);

                        var weatherStation = context.WeatherStations
                                            .Single(n => n.WeatherStationId == identifier);

                        var position = context.Positions
                                       .Single(n => n.PositionId == weatherStation.PositionId);

                        string basicUrl = string.Format(ConfigurationManager.AppSettings["Url"], basicData, position.Latitude, position.Longitude);

                        string result = client.DownloadString(basicUrl);

                        BasicData basicDataValues = JsonConvert.DeserializeObject<BasicData>(result);

                        string agroUrl = string.Format(ConfigurationManager.AppSettings["Url"], agroData, position.Latitude, position.Longitude);

                        string agroResult = client.DownloadString(agroUrl);

                        AgroData agroDataValues = JsonConvert.DeserializeObject<AgroData>(agroResult);

                        var meteoblueWeatherDatas = context.MeteoblueWeatherDatas.Where(n => n.WeatherStationId == identifier).ToList();

                        for (int i = 0; i < basicDataValues.data_day.time.Count - 1; i++)
                        {
                            var dataDate = Convert.ToDateTime(basicDataValues.data_day.time.ElementAt(i));

                            var existRecord = meteoblueWeatherDatas.FirstOrDefault(n => n.WeatherStationId == identifier && n.WeatherDate == dataDate);

                            if (existRecord == null)
                            {
                                MeteoblueWeatherData meteoblueWeatherData = new MeteoblueWeatherData()
                                {
                                    WeatherStationId = identifier,
                                    WeatherDate = dataDate,
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
                                    LastModificationDate = DateTime.Now,
                                    AgroJson = agroResult,
                                    BasicJson = result,
                                    AgroUrl = agroUrl,
                                    BasicUrl = basicUrl
                                };

                                processedData.Add(meteoblueWeatherData);
                                context.MeteoblueWeatherDatas.Add(meteoblueWeatherData);
                            }
                            else
                            {
                                existRecord.ConvectivePrecipitation = basicDataValues.data_day.convective_precipitation.ElementAt(i);
                                existRecord.DewPointTemperatureMax = agroDataValues.data_day.dewpointtemperature_max.ElementAt(i);
                                existRecord.DewPointTemperatureMean = agroDataValues.data_day.dewpointtemperature_mean.ElementAt(i);
                                existRecord.DewPointTemperatureMin = agroDataValues.data_day.dewpointtemperature_min.ElementAt(i);
                                existRecord.Evapotranspiration = agroDataValues.data_day.evapotranspiration.ElementAt(i);
                                existRecord.FeltTemperatureMax = basicDataValues.data_day.felttemperature_max.ElementAt(i);
                                existRecord.FeltTemperatureMin = basicDataValues.data_day.felttemperature_min.ElementAt(i);
                                existRecord.HumidityGreater90Hours = basicDataValues.data_day.humiditygreater90_hours.ElementAt(i);
                                existRecord.LeafWetnessIndex = agroDataValues.data_day.leafwetnessindex.ElementAt(i);
                                existRecord.PotentialEvapotranspiration = agroDataValues.data_day.potentialevapotranspiration.ElementAt(i);
                                existRecord.Precipitation = basicDataValues.data_day.precipitation.ElementAt(i);
                                existRecord.PrecipitationHours = basicDataValues.data_day.precipitation_hours.ElementAt(i);
                                existRecord.PrecipitationProbability = basicDataValues.data_day.precipitation_probability.ElementAt(i);
                                existRecord.Predictability = basicDataValues.data_day.predictability.ElementAt(i);
                                existRecord.PredictabilityClass = basicDataValues.data_day.predictability_class.ElementAt(i);
                                existRecord.Rainspot = basicDataValues.data_day.rainspot.ElementAt(i);
                                existRecord.ReferenceEvapotranspirationFao = agroDataValues.data_day.referenceevapotranspiration_fao.ElementAt(i);
                                existRecord.RelativeHumidityMax = basicDataValues.data_day.relativehumidity_max.ElementAt(i);
                                existRecord.RelativehumidityMean = basicDataValues.data_day.relativehumidity_mean.ElementAt(i);
                                existRecord.RelativeHumidityMin = basicDataValues.data_day.relativehumidity_min.ElementAt(i);
                                existRecord.SealevelPressureMax = basicDataValues.data_day.sealevelpressure_max.ElementAt(i);
                                existRecord.SealevelPressureMean = basicDataValues.data_day.sealevelpressure_mean.ElementAt(i);
                                existRecord.SealevelPressureMin = basicDataValues.data_day.sealevelpressure_min.ElementAt(i);
                                existRecord.SensibleHeatFlux = agroDataValues.data_day.sensibleheatflux.ElementAt(i);
                                existRecord.SkinTemperatureMax = agroDataValues.data_day.skintemperature_max.ElementAt(i);
                                existRecord.SkinTemperatureMean = agroDataValues.data_day.skintemperature_mean.ElementAt(i);
                                existRecord.SkinTemperatureMin = agroDataValues.data_day.skintemperature_min.ElementAt(i);
                                existRecord.SnowFraction = basicDataValues.data_day.snowfraction.ElementAt(i);
                                existRecord.SoilMoistureMax = agroDataValues.data_day.soilmoisture_0to10cm_max.ElementAt(i);
                                existRecord.SoilMoistureMean = agroDataValues.data_day.soilmoisture_0to10cm_mean.ElementAt(i);
                                existRecord.SoilMoistureMin = agroDataValues.data_day.soilmoisture_0to10cm_min.ElementAt(i);
                                existRecord.SoilTemperatureMax = agroDataValues.data_day.soiltemperature_0to10cm_max.ElementAt(i);
                                existRecord.SoilTemperatureMean = agroDataValues.data_day.soiltemperature_0to10cm_mean.ElementAt(i);
                                existRecord.SoilTemperatureMin = agroDataValues.data_day.soiltemperature_0to10cm_min.ElementAt(i);
                                existRecord.TemperatureMax = basicDataValues.data_day.temperature_max.ElementAt(i);
                                existRecord.TemperatureMean = basicDataValues.data_day.temperature_mean.ElementAt(i);
                                existRecord.TemperatureMin = basicDataValues.data_day.temperature_min.ElementAt(i);
                                existRecord.UvIndex = basicDataValues.data_day.uvindex.ElementAt(i);
                                existRecord.WindDirection = basicDataValues.data_day.winddirection.ElementAt(i);
                                existRecord.WindSpeedMax = basicDataValues.data_day.windspeed_max.ElementAt(i);
                                existRecord.WindSpeedMean = basicDataValues.data_day.windspeed_mean.ElementAt(i);
                                existRecord.WindSpeedMin = basicDataValues.data_day.windspeed_min.ElementAt(i);
                                existRecord.LastModificationDate = DateTime.Now;
                                existRecord.AgroJson = agroResult;
                                existRecord.BasicJson = result;
                                existRecord.AgroUrl = agroUrl;
                                existRecord.BasicUrl = basicUrl;
                                processedData.Add(existRecord);
                            }
                        }
                    }
                    context.SaveChanges();

                    //processedData = context.MeteoblueWeatherDatas.Where(n => n.WeatherStationId == 1).ToList();

                    GenerateEmailLines(processedData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }           
        }

        private static void GenerateEmailLines(List<MeteoblueWeatherData> weatherData)
        {
            List<string> lines = new List<string>();

            using (var context = new Entities())
            {
                foreach (var item in weatherData)
                {
                    var weatherStation = context.WeatherStations.First(n => n.WeatherStationId == item.WeatherStationId);

                    lines.Add("Weather station: " + weatherStation.Name);
                    lines.Add("  ");

                    foreach (var prop in item.GetType().GetProperties())
                    {
                        if (prop.Name != "BasicJson" && prop.Name != "AgroJson")
                        {
                            lines.Add(prop.Name + ": " + prop.GetValue(item, null)?.ToString());
                        }                     
                    }

                    lines.Add("___________________________________________________");
                }
            }

            SendEmails("Carga de datos de Meteoblue exitosa", lines);
        }

        private static void SendEmails(string subject, List<string> body)
        {
            try
            {
                string smtpAddress = Convert.ToString(ConfigurationManager.AppSettings["smtpAddress"]);
                int portNumber = Convert.ToInt32(ConfigurationManager.AppSettings["smtpPort"]);
                bool enableSSL = Convert.ToBoolean(ConfigurationManager.AppSettings["ssl"]);
                string emailFrom = Convert.ToString(ConfigurationManager.AppSettings["emailFrom"]);
                string password = Convert.ToString(ConfigurationManager.AppSettings["password"]);
                string emailTo = Convert.ToString(ConfigurationManager.AppSettings["emailTo"]);
                string copyTo = Convert.ToString(ConfigurationManager.AppSettings["copyTo"]);

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);

                    if (!string.IsNullOrEmpty(copyTo))
                    {
                        mail.CC.Add(copyTo);
                    }
                    mail.Subject = subject;

                    // body.Reverse();

                    string message = string.Empty;

                    foreach (var item in body)
                    {
                        message += item + "\n";
                    }

                    mail.Body = message;

                    // mail.Attachments.Add(new Attachment(WriteLogAttachment(body)));

                    mail.IsBodyHtml = false;

                    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                    {
                        smtp.Credentials = new NetworkCredential(emailFrom, password);
                        smtp.EnableSsl = enableSSL;

                        smtp.Send(mail);
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
            }
        }

        private static string WriteLogAttachment(List<string> lines)
        {
            string result = Path.GetTempFileName().Replace(".tmp", ".txt");

            File.WriteAllLines(result, lines);

            return result;
        }
    }
}
