using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Globalization;
using System.Net.Mail;
using System.Net;
using System.Data.Entity;
using NLog;

namespace GetWeatherInfoService
{
    public partial class GetWeatherInfoService : ServiceBase
    {
        IrrigationAdvisorEntities context = new IrrigationAdvisorEntities();
       

        private const string CELSIUS = "C";
        private const string OUTSIDE_TEMP = "Outside Temp";
        private const string OUTSIDE_HUMIDITY = "Outside Humidity";
        private const string BAROMETER = "Barometer";
        private const string DEW_POINT = "Dew Point";
        private const string RAIN = "Rain";
        private const string SOLAR_RADIATION = "Solar Radiation";
        private const string ET = "ET";
        private const string UV_RADIATION = "UV Radiation";
        private const string WIND_SPEED = "Wind Speed";
        private const string MILIMETERS = "mm";
        private const string PERCENTAGE = "%";
        private const string MB = "mb";
        private const string WM2 = "W/m2";
        private const string KMH = "km/h";
        private const string INDEX = "Index";

        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static List<string> errorUrls = new List<string>();

        public GetWeatherInfoService()
        {
            InitializeComponent();
        }

        private string LogFormat(string key, object value)
        {
            string message = string.Format("{0} : {1}. \n",
                                            key,
                                            value.ToString());

            return message;
        }

        private void AddUrls(string url)
        {
            if(!errorUrls.Any(e => e == url))
            {
                errorUrls.Add(url);
            }
        }

        private void MailLines(WeatherDataDTO weatherDataDTO, List<string> pEmailLog)
        {
            pEmailLog.Add(LogFormat("Temperature", weatherDataDTO.Temperature));
            pEmailLog.Add(LogFormat("TemperatureMax", weatherDataDTO.MaxTemperature));
            pEmailLog.Add(LogFormat("TemperatureMin", weatherDataDTO.MinTemperature));

            pEmailLog.Add(LogFormat("EvapotranspirationDay", weatherDataDTO.EvapotranspirationDay));
            pEmailLog.Add(LogFormat("EvapotranspirationMonth", weatherDataDTO.EvapotranspirationMonth));
            pEmailLog.Add(LogFormat("EvapotranspirationYear", weatherDataDTO.EvapotranspirationYear));

            pEmailLog.Add(LogFormat("MaxHumidity", weatherDataDTO.MaxHumidity));
            pEmailLog.Add(LogFormat("MinHumidity", weatherDataDTO.MinHumidity));
            pEmailLog.Add(LogFormat("MinHumidity", weatherDataDTO.MinHumidity));
            pEmailLog.Add(LogFormat("MaxBarometer", weatherDataDTO.MaxBarometer));
            pEmailLog.Add(LogFormat("MinBarometer", weatherDataDTO.MinBarometer));
            pEmailLog.Add(LogFormat("MaxDewTemperature", weatherDataDTO.MaxDewTemperature));
            pEmailLog.Add(LogFormat("MinDewTemperature", weatherDataDTO.MinDewTemperature));
            pEmailLog.Add(LogFormat("RainDay", weatherDataDTO.RainDay));
            pEmailLog.Add(LogFormat("RainStorm", weatherDataDTO.RainStorm));
            pEmailLog.Add(LogFormat("RainMonth", weatherDataDTO.RainMonth));
            pEmailLog.Add(LogFormat("RainYear", weatherDataDTO.RainYear));
            pEmailLog.Add(LogFormat("SolarRadiation", weatherDataDTO.SolarRadiation));
            pEmailLog.Add(LogFormat("UvRadiation", weatherDataDTO.UvRadiation));
            pEmailLog.Add(LogFormat("WindSpeed", weatherDataDTO.WindSpeed));
            pEmailLog.Add(LogFormat("Last-Update:", weatherDataDTO.Observations));
            pEmailLog.Add("════════════Fin═══════════════\n\n");
        }

        private void UpdateAllWeatherDataRecord(WeatherData pPredicatedWeatherData, 
                                                WeatherDataDTO pWeatherDataDTO,
                                                DateTime pCurrentConditionsAsDate,
                                                long pWeatherStationId,
                                                List<string> pEmailLog)
        {
            if (Validations(pCurrentConditionsAsDate))
            {
                pPredicatedWeatherData.Date = DateTime.Now;
                pPredicatedWeatherData.Temperature = pWeatherDataDTO.Temperature;
                pPredicatedWeatherData.Barometer = (pWeatherDataDTO.MaxBarometer + pWeatherDataDTO.MinBarometer) / 2;
                pPredicatedWeatherData.BarometerMax = pWeatherDataDTO.MaxBarometer;
                pPredicatedWeatherData.BarometerMin = pWeatherDataDTO.MinBarometer;
                pPredicatedWeatherData.Evapotranspiration = pWeatherDataDTO.EvapotranspirationDay;
                pPredicatedWeatherData.EvapotranspirationMonth = pWeatherDataDTO.EvapotranspirationMonth;
                pPredicatedWeatherData.EvapotranspirationYear = pWeatherDataDTO.EvapotranspirationYear;
                pPredicatedWeatherData.Humidity = (pWeatherDataDTO.MinHumidity + pWeatherDataDTO.MaxHumidity) / 2;
                pPredicatedWeatherData.HumidityMax = pWeatherDataDTO.MaxHumidity;
                pPredicatedWeatherData.HumidityMin = pWeatherDataDTO.MinHumidity;
                pPredicatedWeatherData.RainDay = pWeatherDataDTO.RainDay;
                pPredicatedWeatherData.RainMonth = pWeatherDataDTO.RainMonth;
                pPredicatedWeatherData.RainStorm = pWeatherDataDTO.RainStorm;
                pPredicatedWeatherData.RainYear = pWeatherDataDTO.RainYear;
                pPredicatedWeatherData.SolarRadiation = pWeatherDataDTO.SolarRadiation;
                pPredicatedWeatherData.TemperatureDewPoint = (pWeatherDataDTO.MaxDewTemperature + pWeatherDataDTO.MinDewTemperature) / 2;
                pPredicatedWeatherData.TemperatureMax = pWeatherDataDTO.MaxTemperature;
                pPredicatedWeatherData.TemperatureMin = pWeatherDataDTO.MinTemperature;
                pPredicatedWeatherData.UVRadiation = pWeatherDataDTO.UvRadiation;
                pPredicatedWeatherData.WeatherDataType = 0;
                pPredicatedWeatherData.WeatherDataInputType = (int)Enums.WeatherDataInputType.GetWeatherInfoService;
                pPredicatedWeatherData.WeatherStationId = pWeatherStationId;
                pPredicatedWeatherData.Observations = pWeatherDataDTO.Observations;
            }

            MailLines(pWeatherDataDTO, pEmailLog);
        }

        public void ProcessWeathers()
        {
            try
            {
                List<string> emailLog = new List<string>();
                errorUrls.Clear();
                emailLog.Clear();
                emailLog.Add(LogFormat("Comienzo: ", DateTime.Now));

                var weatherStations = context.WeatherStations.Where(w => w.WebAddress.Length > 0 && w.StationType == (int)Enums.StationType.WeatherLink).ToList();

                foreach (var weatherStation in weatherStations)
                {
                    emailLog.Add("\n");
                    
                    try
                    {
                        string weatherStationDescription = string.Format(" {0} {1} \n", weatherStation.Name, weatherStation.WebAddress);
                        emailLog.Add(LogFormat("WeatherStation:", weatherStationDescription));

                        WeatherDataDTO weatherDataDTO = new WeatherDataDTO();

                        try
                        {

                            List<string> temperatureValues = GetWeatherLinkValues(weatherStation.WebAddress, OUTSIDE_TEMP);

                            weatherDataDTO.MaxTemperature = GetDoubleValue(temperatureValues.ElementAt(2), CELSIUS);
                            weatherDataDTO.MinTemperature = GetDoubleValue(temperatureValues.ElementAt(4), CELSIUS);
                            
                        }
                        catch (Exception ex)
                        {

                            logger.Info("Falló al levantar Temperatura ver abajo detalle del error.");
                            logger.Info(ex, ex.Message);
                            emailLog.Add(LogFormat("Temperature, TemperatureMax, TemperatureMin: ", ex.Message));
                            // Silent catch
                            throw;
                        }
                        
                        string etExceptionMessage = string.Empty;
                        // Try to parse et
                        try
                        {
                            List<string> etValues = GetWeatherLinkValues(weatherStation.WebAddress, ET);
                            
                            if (etValues.Count > 0)
                            {
                                weatherDataDTO.EvapotranspirationDay = GetDoubleValue(etValues.ElementAt(2), MILIMETERS);

                                weatherDataDTO.EvapotranspirationMonth = GetDoubleValue(etValues.ElementAt(4), MILIMETERS);

                                weatherDataDTO.EvapotranspirationYear = GetDoubleValue(etValues.ElementAt(5), MILIMETERS);

                            }

                        }
                        catch (Exception ex)
                        {
                            logger.Info("Falló al levantar ET ver abajo detalle del error.");
                            etExceptionMessage = ex.Message;
                            logger.Info(ex, ex.Message);
                            emailLog.Add(LogFormat("EvapotranspirationDay, EvapotranspirationMonth, EvapotranspirationYear: ", etExceptionMessage));
                            // Silent catch
                            throw;
                        }

                        try
                        {
                            List<string> humidityValues = GetWeatherLinkValues(weatherStation.WebAddress, OUTSIDE_HUMIDITY);

                            if (humidityValues.Any())
                            {
                                weatherDataDTO.MaxHumidity = GetDoubleValue(humidityValues.ElementAt(2), PERCENTAGE);
                                weatherDataDTO.MinHumidity = GetDoubleValue(humidityValues.ElementAt(4), PERCENTAGE);
                            }

                            List<string> barometerValues = GetWeatherLinkValues(weatherStation.WebAddress, BAROMETER);

                            if (barometerValues.Any())
                            {
                                weatherDataDTO.MaxBarometer = GetDoubleValue(barometerValues.ElementAt(2), MB);
                                weatherDataDTO.MinBarometer = GetDoubleValue(barometerValues.ElementAt(4), MB);
                            }

                            List<string> dewValues = GetWeatherLinkValues(weatherStation.WebAddress, DEW_POINT);

                            if (dewValues.Any())
                            {
                                weatherDataDTO.MaxDewTemperature = GetDoubleValue(dewValues.ElementAt(2), CELSIUS);
                                weatherDataDTO.MinDewTemperature = GetDoubleValue(dewValues.ElementAt(4), CELSIUS);
                            }

                            List<string> rainValues = GetWeatherLinkValues(weatherStation.WebAddress, RAIN);

                            if (rainValues.Any())
                            {
                                weatherDataDTO.RainDay = GetDoubleValue(rainValues.ElementAt(2), MILIMETERS);
                                weatherDataDTO.RainStorm = GetDoubleValue(rainValues.ElementAt(3), MILIMETERS);
                                weatherDataDTO.RainMonth = GetDoubleValue(rainValues.ElementAt(4), MILIMETERS);
                                weatherDataDTO.RainYear = GetDoubleValue(rainValues.ElementAt(5), MILIMETERS);
                            }

                            List<string> solarRadiationValues = GetWeatherLinkValues(weatherStation.WebAddress, SOLAR_RADIATION);

                            if (solarRadiationValues.Any())
                            {
                                weatherDataDTO.SolarRadiation = GetDoubleValue(solarRadiationValues.ElementAt(2).Replace("W/m<span class=\"threequarter\"><sup>2</sup></span>", ""), string.Empty);
                            }

                            List<string> uvRadiationValues = GetWeatherLinkValues(weatherStation.WebAddress, UV_RADIATION);

                            if (uvRadiationValues.Any())
                            {
                                weatherDataDTO.UvRadiation = GetDoubleValue(uvRadiationValues.ElementAt(2), INDEX);
                            }

                            List<string> windSpeedValues = GetWeatherLinkValues(weatherStation.WebAddress, WIND_SPEED);

                            if (windSpeedValues.Any())
                            {
                                weatherDataDTO.WindSpeed = GetDoubleValue(windSpeedValues.ElementAt(2), KMH);
                            }
                        }
                        catch (Exception ex)
                        {
                            logger.Warn(ex, "Falló al levantar levantar valores opcionales. Pero se guardó el registro.");
                            //silent catch
                        }
                        
                        // Search if the station exists
                        WeatherData existingWeatherData = context.WeatherDatas.Where(w => w.WeatherStationId == weatherStation.WeatherStationId &&
                                                                                     w.Date.Year == DateTime.Now.Year
                                                                                     && w.Date.Month == DateTime.Now.Month
                                                                                     && w.Date.Day == DateTime.Now.Day).FirstOrDefault();

                        weatherDataDTO.Observations = GetCurrentCoditions(weatherStation.WebAddress);

                        DateTime currentConditionsAsDate = ConvertCurrentConditionsToDateTime(weatherDataDTO.Observations);
                        // If there is not a record for the day . It create a new record.
                        if (existingWeatherData == null)
                        {
                            WeatherData newWeatherData = new WeatherData()
                            {
                                Date = DateTime.Now,
                                Temperature = weatherDataDTO.Temperature,
                                Barometer = (weatherDataDTO.MaxBarometer + weatherDataDTO.MinBarometer) / 2,
                                BarometerMax = weatherDataDTO.MaxBarometer,
                                BarometerMin = weatherDataDTO.MinBarometer,
                                Evapotranspiration = weatherDataDTO.EvapotranspirationDay,
                                EvapotranspirationMonth = weatherDataDTO.EvapotranspirationMonth,
                                EvapotranspirationYear = weatherDataDTO.EvapotranspirationYear,
                                Humidity = (weatherDataDTO.MinHumidity + weatherDataDTO.MaxHumidity) / 2,
                                HumidityMax = weatherDataDTO.MaxHumidity,
                                HumidityMin = weatherDataDTO.MinHumidity,
                                RainDay = weatherDataDTO.RainDay,
                                RainMonth = weatherDataDTO.RainMonth,
                                RainStorm = weatherDataDTO.RainStorm,
                                RainYear = weatherDataDTO.RainYear,
                                SolarRadiation = weatherDataDTO.SolarRadiation,
                                TemperatureDewPoint = (weatherDataDTO.MaxDewTemperature + weatherDataDTO.MinDewTemperature) / 2,
                                TemperatureMax = weatherDataDTO.MaxTemperature,
                                TemperatureMin = weatherDataDTO.MinTemperature,
                                UVRadiation = weatherDataDTO.UvRadiation,
                                WeatherDataType = 0,
                                WeatherStationId = weatherStation.WeatherStationId,
                                Observations = weatherDataDTO.Observations,
                                WeatherDataInputType = (int)Enums.WeatherDataInputType.GetWeatherInfoService,
                                WindSpeed = weatherDataDTO.WindSpeed
                            };

                            // Check if pass the validations.
                            if (Validations(currentConditionsAsDate))
                            {
                                context.WeatherDatas.Add(newWeatherData);
                            }

                            MailLines(weatherDataDTO, emailLog);
        
                        }
                        else if (existingWeatherData != null && existingWeatherData.WeatherDataInputType == (int)Enums.WeatherDataInputType.Prediction)
                        {
                            logger.Info("Existe un record de WeatherData como pronosticado. Se va a reemplazar por el valor de Weather Link. WeatherSatationId: {0}", weatherStation.WeatherStationId);

                            UpdateAllWeatherDataRecord(existingWeatherData, weatherDataDTO, currentConditionsAsDate, weatherStation.WeatherStationId, emailLog);
                        }
                        else if (existingWeatherData != null && existingWeatherData.Date < currentConditionsAsDate && Validations(currentConditionsAsDate))
                        {
                            
                            existingWeatherData.Date = DateTime.Now;
                            
                            if (existingWeatherData.TemperatureMax < weatherDataDTO.MaxTemperature && weatherDataDTO.MaxTemperature != 0)
                            {
                                existingWeatherData.TemperatureMax = weatherDataDTO.MaxTemperature;
                                emailLog.Add(LogFormat("TemperatureMax", existingWeatherData.TemperatureMax));
                            }
                            
                            if (existingWeatherData.TemperatureMin > weatherDataDTO.MinTemperature && weatherDataDTO.MinTemperature != 0)
                            {
                                existingWeatherData.TemperatureMin = weatherDataDTO.MinTemperature;
                                emailLog.Add(LogFormat("TemperatureMin", existingWeatherData.TemperatureMin));
                            }

                            existingWeatherData.Temperature = (existingWeatherData.TemperatureMax + existingWeatherData.TemperatureMin) / 2;

                            if (existingWeatherData.Evapotranspiration < weatherDataDTO.EvapotranspirationDay && weatherDataDTO.EvapotranspirationDay != 0)
                            {
                                existingWeatherData.Evapotranspiration = weatherDataDTO.EvapotranspirationDay;
                                existingWeatherData.EvapotranspirationMonth = weatherDataDTO.EvapotranspirationMonth;
                                existingWeatherData.EvapotranspirationYear = weatherDataDTO.EvapotranspirationYear;
                                emailLog.Add(LogFormat("Evapotranspiration", existingWeatherData.Evapotranspiration));
                                emailLog.Add(LogFormat("EvapotranspirationMonth", existingWeatherData.EvapotranspirationMonth));
                                emailLog.Add(LogFormat("EvapotranspirationYear", existingWeatherData.EvapotranspirationYear));
                            }

                            if (existingWeatherData.UVRadiation > weatherDataDTO.UvRadiation && weatherDataDTO.UvRadiation != 0)
                            {
                                existingWeatherData.UVRadiation = weatherDataDTO.UvRadiation;
                                emailLog.Add(LogFormat("UVRadiation", existingWeatherData.UVRadiation));
                            }
                            
                            if (existingWeatherData.SolarRadiation > weatherDataDTO.SolarRadiation && weatherDataDTO.SolarRadiation != 0)
                            {
                                existingWeatherData.SolarRadiation = weatherDataDTO.SolarRadiation;
                                emailLog.Add(LogFormat("SolarRadiation", existingWeatherData.SolarRadiation));
                            }
                            
                            if (existingWeatherData.HumidityMax < weatherDataDTO.MaxHumidity && weatherDataDTO.MaxHumidity != 0)
                            {
                                existingWeatherData.HumidityMax = weatherDataDTO.MaxHumidity;
                                emailLog.Add(LogFormat("HumidityMax", existingWeatherData.HumidityMax));
                            }
                            
                            if (existingWeatherData.HumidityMin > weatherDataDTO.MinHumidity && weatherDataDTO.MinHumidity != 0)
                            {
                                existingWeatherData.HumidityMin = weatherDataDTO.MinHumidity;
                                emailLog.Add(LogFormat("HumidityMin", existingWeatherData.HumidityMin));
                            }
                            
                            existingWeatherData.Humidity = (weatherDataDTO.MaxHumidity + weatherDataDTO.MinHumidity) / 2;

                            if (existingWeatherData.BarometerMax < weatherDataDTO.MaxBarometer && weatherDataDTO.MaxBarometer != 0)
                            {
                                existingWeatherData.BarometerMax = weatherDataDTO.MaxBarometer;
                                emailLog.Add(LogFormat("BarometerMax", existingWeatherData.BarometerMax));
                            }

                            if (existingWeatherData.BarometerMin > weatherDataDTO.MinBarometer && weatherDataDTO.MinBarometer != 0)
                            {
                                existingWeatherData.BarometerMin = weatherDataDTO.MinBarometer;
                                emailLog.Add(LogFormat("BarometerMin", existingWeatherData.BarometerMin));
                            }

                            existingWeatherData.Barometer = (existingWeatherData.BarometerMax + existingWeatherData.BarometerMin) / 2;

                            if (existingWeatherData.RainDay < weatherDataDTO.RainDay && weatherDataDTO.RainDay != 0)
                            {
                                existingWeatherData.RainDay = weatherDataDTO.RainDay;
                                emailLog.Add(LogFormat("RainDay", existingWeatherData.RainDay));
                                existingWeatherData.RainMonth = weatherDataDTO.RainMonth;
                                emailLog.Add(LogFormat("RainMonth", existingWeatherData.RainMonth));
                                existingWeatherData.RainYear = weatherDataDTO.RainYear;
                                emailLog.Add(LogFormat("RainYear", existingWeatherData.RainYear));
                            }

                            if(existingWeatherData.WindSpeed < weatherDataDTO.WindSpeed && weatherDataDTO.WindSpeed != 0)
                            {
                                existingWeatherData.WindSpeed = weatherDataDTO.WindSpeed;
                                emailLog.Add(LogFormat("WindSpeed", existingWeatherData.WindSpeed));
                            }

                            existingWeatherData.Observations = weatherDataDTO.Observations;
                            emailLog.Add(LogFormat("Last-Update:", weatherDataDTO.Observations));
                            emailLog.Add("════════════Fin═══════════════\n\n");
                        }
                        //else
                        //{
                        //    logger.Info("Existe un record de WeatherData de un Tipo de input distinto a GetWeather Service. Se va a reemplazar por el valor de Weather Link. WeatherSatationId: {0}", weatherStation.WeatherStationId);

                        //    UpdateAllWeatherDataRecord(predicatedWeatherData, weatherDataDTO, currentConditionsAsDate, weatherStation.WeatherStationId, emailLog);
                        //}
                            
                        CheckAndUpdateUpdateTimeFromWeatherStations(weatherStation, weatherDataDTO.Observations);
                    }
                    catch (FormatException ex)
                    {
                        logger.Warn(ex, ex.Message);
                        emailLog.Add("\n");
                        AddUrls(weatherStation.WebAddress);
                        emailLog.Add("Error en la carga \n");
                        emailLog.Add(ex.Message + "\n");
                        continue;
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                        emailLog.Add("\n");
                        AddUrls(weatherStation.WebAddress);
                        emailLog.Add("Error en la carga \n");
                        emailLog.Add(ex.Message + "\n");
                        continue;
                    }

                    context.SaveChanges();
                }
                
                string endMessage = string.Empty;

                foreach (string item in emailLog)
                {
                    endMessage = endMessage + item ;
                }

                SendEmails("Carga correcta de Weather Data",
                                endMessage);

                Stop();
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                SendEmails("Error en el carga de Weather Data",
                            ex.Message + " | " + ex.StackTrace);
                Stop();
            }
        }

        private bool Validations(DateTime currentConditionsDate)
        {
            bool lResult = false;
            int validHour = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["ValidHour"]);
            //ValidHour
            if (validHour >= 0 && validHour <= 23 && currentConditionsDate.Hour >= validHour)
            {
                lResult = true;
            }
            else
            {
                logger.Info("No se pasaron las validaciones para guardar WeatherData");
                logger.Info("validHour >= 0 && validHour <= 23 && currentConditionsDate.Hour >= {0}", validHour);
                logger.Info(string.Format("validHour: {0}, currentConditionsDate.Hour: {1}",
                    validHour, currentConditionsDate.Hour));
            }

            return lResult;
        }

        private void CheckAndUpdateUpdateTimeFromWeatherStations(WeatherStation weatherStation, string currentStatus)
        {
            IrrigationAdvisorEntities internalContext = new IrrigationAdvisorEntities();

            WeatherStation currentWeatherStation = internalContext.WeatherStations.Where(w => w.WeatherStationId == weatherStation.WeatherStationId).Single();

            DateTime actualCurrentCondition = ConvertCurrentConditionsToDateTime(currentStatus);
            if (currentWeatherStation.UpdateTime < actualCurrentCondition)
            {
                currentWeatherStation.UpdateTime = actualCurrentCondition;
                internalContext.SaveChanges();
            }
        }

        public void SendEmails(string subject, string body)
        {
            try
            {
                string smtpAddress = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["smtpAddress"]);
                int portNumber = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["smtpPort"]);
                bool enableSSL = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ssl"]);
                string emailFrom = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailFrom"]);
                string password = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["password"]);
                string emailTo = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["emailTo"]);
                string copyTo = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["copyTo"]);

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(emailFrom);
                    mail.To.Add(emailTo);

                    if(!string.IsNullOrEmpty(copyTo))
                    {
                        mail.CC.Add(copyTo);
                    }
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = false;

                    foreach (var item in errorUrls)
                    {
                        WebClient wc = new WebClient();
                        byte[] raw = wc.DownloadData(item);

                        //Get the html text from the web.
                        string webData = Encoding.UTF8.GetString(raw);

                        string path = Path.GetTempFileName().Replace(".tmp",".html");
                        using (StreamWriter file = new StreamWriter(path, true))
                        {
                            file.WriteLine(webData);
                        }

                        mail.Attachments.Add(new Attachment(path));
                    }
                        
                    // Can set to false, if you are sending pure text.


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

        protected override void OnStart(string[] args)
        {
            ProcessWeathers();
        }

        private double GetDoubleValue(string value, string toRemovedString)
        {
            string preValue = value;
            if (!string.IsNullOrEmpty(toRemovedString))
            {
                preValue = value.Trim().Replace(toRemovedString, "");
            }
            
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            double doubleValue = Convert.ToDouble(preValue, provider);

            return doubleValue;
        }

        protected override void OnStop()
        {
           
        }

        private static HtmlNodeCollection GetHtmlNodes(string url, string htmlTag, string className)
        {
            WebClient wc = new WebClient();
            byte[] raw = wc.DownloadData(url);

            //Get the html text from the web.
            string webData = Encoding.UTF8.GetString(raw);
            // Search an specific value from the html file
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(webData);
            HtmlNodeCollection htmlNodes = html.DocumentNode.SelectNodes(string.Format("//{0}[@class='{1}']",
                                                                                        htmlTag,
                                                                                        className));

            return htmlNodes;
        }

        private static string GetHtmlCode(string url)
        {
            WebClient wc = new WebClient();
            byte[] raw = wc.DownloadData(url);

            //Get the html text from the web.
            string webData = Encoding.UTF8.GetString(raw);

            return webData;

        }

        private static string GetCurrentCoditions(string url)
        {
            string className = "summary_timestamp";
            string htmlTag = "td";
            //Get the html text from the web.
            string webData = GetHtmlCode(url);
            // Search an specific value from the html file
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(webData);
            HtmlNodeCollection htmlNodes = GetHtmlNodes(url, htmlTag, className);

            if (htmlNodes.Count == 1)
            {
                var item = htmlNodes.First();

                return item.InnerHtml;
            }

            return string.Empty;
        }

        /// <summary>
        /// Get value from the Weather link table
        /// </summary>
        /// <param name="url">Url from the Weather Link page</param>
        /// <param name="keyName">Key Name. Example 'ET'</param>
        /// <param name="valueCount">Count of the consecutive values. For default 6</param>
        private static List<string> GetWeatherLinkValues(
            string url,
            string keyName,
            short valueCount = 6,
            string htmlTag = "td",
            string className = "summary_data")
        {
            List<string> result = new List<string>();
            
            //Get the html text from the web.
            string webData = GetHtmlCode(url);
            // Search an specific value from the html file
            HtmlDocument html = new HtmlDocument();
            html.LoadHtml(webData);
            HtmlNodeCollection htmlNodes = GetHtmlNodes(url, htmlTag, className);
            bool weFound = false;
            short count = 0;
            foreach (var item in htmlNodes)
            {
                if (item.InnerHtml.Equals(keyName) || weFound && count < valueCount)
                {
                    count++;
                    weFound = true;
                    result.Add(item.InnerHtml);
                }
            }

            return result;
        }

        private DateTime ConvertCurrentConditionsToDateTime(string pCurrentConditions)
        {
            string[] lSplit = pCurrentConditions.Split(' ');

            int date = Convert.ToInt32(lSplit[7].Replace(',', '\0'));
            string stringMonth = lSplit[6];
            int year = Convert.ToInt32(lSplit[8]);
            string hour = lSplit[4];

            return ParseWeatherLinkCurrentConditionsText(date, stringMonth, year, hour);
        }

        private DateTime ParseWeatherLinkCurrentConditionsText(int date, string pStringMonth, int year, string hour)
        {

            int month = DateTime.ParseExact(pStringMonth, "MMMM", new CultureInfo("en-US")).Month;

            string[] lHourMinutes = hour.Split(':');
            int lHour = Convert.ToInt32(lHourMinutes[0]);
            int lMinute = Convert.ToInt32(lHourMinutes[1]);

            DateTime lResult = new DateTime(year, month, date, lHour, lMinute, 0);
            return lResult;
        }
    }
}
