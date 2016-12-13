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
        private const int AvgHumedity = 7;
        private const int MaxHumedity = 8;
        private const int MinHumedity = 9;

        private const int RowIndex = 11;

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

                    Console.ReadLine();
                }
            }
            catch (Exception)
            {
                throw;
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

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            dto.ET = Convert.ToDouble(values[ET], provider);
            emailLines.Add("ET : " + dto.ET);

            // Get temperatures
            dto.AvgTemperature = Convert.ToDouble(values[AvgTemperature], provider);
            emailLines.Add("Average Temperature : " + dto.AvgTemperature);
            dto.MaxTemperature = Convert.ToDouble(values[MaxTemperature], provider);
            emailLines.Add("Max Temperature : " + dto.MaxTemperature);
            dto.MinTemperature = Convert.ToDouble(values[MinTemperature], provider);
            emailLines.Add("Min Temperature : " + dto.MinTemperature);

            try
            {
                dto.AvgHumedity = Convert.ToDouble(values[AvgHumedity], provider);
                emailLines.Add("Average Humedity : " + dto.AvgHumedity);
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Average Humedity");
            }

            try
            {
                dto.MaxHumedity = Convert.ToDouble(values[MaxHumedity], provider);
                emailLines.Add("Max Humedity : " + dto.MaxHumedity);
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Max Humedity");
            }

            try
            {
                dto.MinHumedity = Convert.ToDouble(values[MinHumedity], provider);
                emailLines.Add("Min Humedity : " + dto.MinHumedity);
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Min Humedity");
            }

            try
            {
                dto.RainDay = Convert.ToDouble(values[RainDay], provider);
                emailLines.Add("Rain Day : " + dto.RainDay);
            }
            catch (Exception)
            {
                logger.Warn("Error al cargar Rain Day");
            }

            return dto;
        }

        public static void ProcessIniaData(IWebDriver driver, string stationIniaId)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            wait.Until(d => d.FindElement(By.CssSelector("#tabla .Tresumen")));

            var row = driver.FindElements(By.CssSelector("#tabla .Tresumen"));

            string[] values = row.ElementAt(RowIndex).Text.Split(' ');

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

            IniaDTO dto = LoadIniaDTO(values);

            SaveIniaRecords(dto, stationIniaId);
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
                WeatherDataType = 0
            };

            context.WeatherDatas.Add(weatherData);

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
