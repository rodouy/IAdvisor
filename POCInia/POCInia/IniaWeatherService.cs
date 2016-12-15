using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Threading;
using NLog;
using System.Globalization;
using System.Net.Mail;
using System.Net;

namespace POCInia
{
    class IniaWeatherService
    {
        private const int Date = 0;
        private const int ET = 1;
        private const int Radiation = 2;
        private const int RainDay = 3;
        private const int AvgTemperature = 4;
        private const int MaxTemperature = 5;
        private const int MinTemperature = 6;
        private const int WindSpeed = 7;
        private const int AvgHumedity = 8;
        private const int MaxHumedity = 9;
        private const int MinHumedity = 10;

        private const int RowIndex = 12;

        private static List<string> emailLines = new List<string>();

        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                using (IWebDriver driver = new FirefoxDriver())
                {

                    List<string> weatherStationsId = LoadIniaWeatherStations();

                    List<string> dataIds = LoadIniaDataIds();

                    var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                    foreach (var station in weatherStationsId)
                    {

                        driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);

                        wait.Until(d => d.FindElement(By.Id("selectEstacion")));

                        IWebElement select = driver.FindElement(By.Id("selectEstacion"));

                        var selectElement = new SelectElement(select);

                        // select by text
                        selectElement.SelectByValue(station);

                        IWebElement variables = driver.FindElement(By.Id("variables"));

                        var variablesElement = new SelectElement(variables);

                        foreach (var data in dataIds)
                        {
                            variablesElement.SelectByValue(data);
                        }

                        wait.Until(d => d.FindElement(By.Name("Button")));


                        IWebElement buttom = driver.FindElement(By.Name("Button"));

                        buttom.Click();

                        //Thread.Sleep(5000);
                        // Parse logic        
                        ProcessIniaData(driver, station);
                        
                    }

                    // Carga correcta de Weather Data
                    SendEmails("Carga correcta de INIA Weather Data", emailLines);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);

                List<string> errors = new List<string>()
                {
                    ex.Message,
                    ex.StackTrace
                };

                SendEmails("Error en la carga de INIA Weather Data", errors);
            }
        }

        private static IniaDTO LoadIniaDTO(string[] values)
        {
            // Get ET
            IniaDTO dto = new IniaDTO();

            string[] dateData = values[Date].Split('-');
            int year = Convert.ToInt32(dateData[2]);
            int month = Convert.ToInt32(dateData[1]);
            int day = Convert.ToInt32(dateData[0]);

            dto.Date = new DateTime(year, month, day);

            emailLines.Add("Date : " + dto.Date.ToShortDateString());
            emailLines.Add("\n");
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            dto.ET = Convert.ToDouble(values[ET], provider);
            emailLines.Add("ET : " + dto.ET);
            emailLines.Add("\n");

            // Get temperatures
            dto.AvgTemperature = Convert.ToDouble(values[AvgTemperature], provider);
            emailLines.Add("Average Temperature : " + dto.AvgTemperature);
            emailLines.Add("\n");
            dto.MaxTemperature = Convert.ToDouble(values[MaxTemperature], provider);
            emailLines.Add("Max Temperature : " + dto.MaxTemperature);
            emailLines.Add("\n");
            dto.MinTemperature = Convert.ToDouble(values[MinTemperature], provider);
            emailLines.Add("Min Temperature : " + dto.MinTemperature);
            emailLines.Add("\n");

            try
            {
                dto.AvgHumedity = Convert.ToDouble(values[AvgHumedity], provider);
                emailLines.Add("Average Humedity : " + dto.AvgHumedity);
                emailLines.Add("\n");
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Average Humedity");
            }

            try
            {
                dto.MaxHumedity = Convert.ToDouble(values[MaxHumedity], provider);
                emailLines.Add("Max Humedity : " + dto.MaxHumedity);
                emailLines.Add("\n");
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Max Humedity");
            }

            try
            {
                dto.MinHumedity = Convert.ToDouble(values[MinHumedity], provider);
                emailLines.Add("Min Humedity : " + dto.MinHumedity);
                emailLines.Add("\n");
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Min Humedity");
            }

            try
            {
                dto.RainDay = Convert.ToDouble(values[RainDay], provider);
                emailLines.Add("Rain Day : " + dto.RainDay);
                emailLines.Add("\n");
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Rain Day");
            }

            try
            {
                dto.WindSpeed = Convert.ToDouble(values[WindSpeed], provider);
                emailLines.Add("Wind Speed : " + dto.RainDay);
                emailLines.Add("\n");
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Wind Speed");
            }

            return dto;
        }

        public static void ProcessIniaData(IWebDriver driver, string stationIniaId)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(d => d.FindElement(By.CssSelector("#tabla .Tresumen")));

            var row = driver.FindElements(By.CssSelector("#tabla .Tresumen"));

            int index = 0;

            var filterRow = new List<IWebElement>();

            foreach (var item in row)
            {
                if(index >= RowIndex && index <= row.Count)
                {
                    filterRow.Add(item);    
                }

                index++;
            }
            
            switch (stationIniaId)
            {
                case "1":
                    emailLines.Add("WeatherStation: Inia Las Brujas");
                    break;
                case "2":
                    emailLines.Add("WeatherStation: Inia La Estanzuela");
                    break;
                case "3":
                    emailLines.Add("WeatherStation: Inia Tacuarembó");
                    break;
                case "5":
                    emailLines.Add("WeatherStation: Inia Salto Grande");
                    break;
                default:
                    emailLines.Add("No se reconoce el WeatherStation");
                    break;
            }

            emailLines.Add("\n \n");

            foreach (var item in filterRow)
            {
                string[] values = item.Text.Split(' ');

                IniaDTO dto = LoadIniaDTO(values);

                SaveIniaRecords(dto, stationIniaId);
            }
            
        }

        public static void SendEmails(string subject, List<string> body)
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

                    body.Reverse();

                    foreach (var item in body)
                    {
                        mail.Body = item + mail.Body;
                    }
    
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

        private static int SaveIniaRecords(IniaDTO dto, string stationIniaId)
        {
            int currentWeatherStationId = 0;

            switch (stationIniaId)
            {
                case "1":
                    currentWeatherStationId = (int)Enums.WeatherStations.LasBrujas;
                    break;
                case "2":
                    currentWeatherStationId = (int)Enums.WeatherStations.LaEstanzuela;
                    break;
                case "3":
                    currentWeatherStationId = (int)Enums.WeatherStations.Tacuarembo;
                    break;
                case "5":
                    currentWeatherStationId = (int)Enums.WeatherStations.SaltoGrande;
                    break;
                default:
                    break;
            }

            IrrigationAdvisorEntities context = new IrrigationAdvisorEntities();

            WeatherStation weatherStation = context.WeatherStations.SingleOrDefault(w => w.WeatherStationId == currentWeatherStationId);

            if (weatherStation != null)
            {
                weatherStation.UpdateTime = DateTime.Now;
            }
            else
            {
                logger.Error("No se pudo encontrar la WeatherStation = {0}", currentWeatherStationId);
            }

            WeatherData existingWeatherData = context.WeatherDatas.SingleOrDefault(w => w.Date == dto.Date && w.WeatherStationId == currentWeatherStationId);

            if(existingWeatherData == null)
            {
                WeatherData weatherData = new WeatherData()
                {
                    Date = dto.Date,
                    Evapotranspiration = dto.ET,
                    Humidity = dto.AvgHumedity,
                    HumidityMax = dto.MaxHumedity,
                    HumidityMin = dto.MinHumedity,
                    RainDay = dto.RainDay,
                    SolarRadiation = dto.SolarRadiation,
                    Temperature = dto.AvgTemperature,
                    TemperatureMax = dto.MaxTemperature,
                    TemperatureMin = dto.MinTemperature,
                    WeatherDataInputType = (int)Enums.WeatherDataInputType.IniaWeatherService,
                    WeatherStationId = currentWeatherStationId,
                    WeatherDataType = 0,
                    WindSpeed = dto.WindSpeed
                };

                context.WeatherDatas.Add(weatherData);

                emailLines.Add("Registro nuevo. ");
                emailLines.Add("\n");
            }
            else
            {
                existingWeatherData.Date = dto.Date;
                existingWeatherData.Evapotranspiration = dto.ET;
                existingWeatherData.Humidity = dto.AvgHumedity;
                existingWeatherData.HumidityMax = dto.MaxHumedity;
                existingWeatherData.HumidityMin = dto.MinHumedity;
                existingWeatherData.RainDay = dto.RainDay;
                existingWeatherData.SolarRadiation = dto.SolarRadiation;
                existingWeatherData.Temperature = dto.AvgTemperature;
                existingWeatherData.TemperatureMax = dto.MaxTemperature;
                existingWeatherData.TemperatureMin = dto.MinTemperature;
                existingWeatherData.WeatherDataInputType = (int)Enums.WeatherDataInputType.IniaWeatherService;
                existingWeatherData.WeatherStationId = currentWeatherStationId;
                existingWeatherData.WeatherDataType = 0;
                existingWeatherData.WindSpeed = dto.WindSpeed;

                emailLines.Add("Registro Actualizado");
                emailLines.Add("\n");
            }
            
            return context.SaveChanges();
        }
        
        public static List<string> LoadIniaWeatherStations()
        {
            List<string> result = new List<string>();

            string weatherStationsId = ConfigurationManager.AppSettings["weatherStations"];

            string[] weatherStationSplitted = weatherStationsId.Split(',');

            foreach (string item in weatherStationSplitted)
            {
                result.Add(item);
            }

            return result;
        }

        public static List<string> LoadIniaDataIds()
        {
            List<string> result = new List<string>();

            string weatherStationsId = ConfigurationManager.AppSettings["data"];

            string[] weatherStationSplitted = weatherStationsId.Split(',');

            foreach (string item in weatherStationSplitted)
            {
                result.Add(item);
            }

            return result;
        }
    }
}
