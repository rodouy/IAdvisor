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

namespace POCInia
{
    class IniaWeatherService
    {
        static void Main(string[] args)
        {
            using (IWebDriver driver = new FirefoxDriver())
            {
                
                List<string> weatherStationsId = LoadIniaWeatherStations();

                List<string> dataIds = LoadIniaDataIds();

                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                foreach (var station in weatherStationsId)
                {

                    driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["url"]);

                    //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                    //wait.Until(WaitUntilFrameLoadedAndSwitchToIt(By.Name("frameMain")));
                    
                    //IWebDriver frame = driver.SwitchTo().Frame("frameMain");

                    wait.Until(d => d.FindElement(By.Id("selectEstacion")));

                    IWebElement select = driver.FindElement(By.Id("selectEstacion"));

                    var selectElement = new SelectElement(select);

                    // select by text
                    selectElement.SelectByValue(station); // INIA Las Brujas

                    IWebElement variables = driver.FindElement(By.Id("variables"));

                    var variablesElement = new SelectElement(variables);

                    foreach (var data in dataIds)
                    {
                        variablesElement.SelectByValue(data);
                    }

                    //variablesElement.SelectByValue("14"); // Temperatura media °C (24 hs)
                    //variablesElement.SelectByValue("15"); // Temperatura Máxima ºC
                    //variablesElement.SelectByValue("16"); // Temperatura Mínima °C
                    //variablesElement.SelectByValue("5"); // Evapotranspiración “Penman” mm
                    //variablesElement.SelectByValue("40"); // H. Relativa Máxima %
                    //variablesElement.SelectByValue("39"); // H. Relativa Media %
                    //variablesElement.SelectByValue("41"); // H. Relativa Mínima %
                    //variablesElement.SelectByValue("13"); // Precipitación Día
                    //variablesElement.SelectByValue("6"); // Radiación Solar por Heliofanía cal/cm2/dia

                    wait.Until(d => d.FindElement(By.Name("Button")));

                   
                    IWebElement buttom = driver.FindElement(By.Name("Button"));

                    buttom.Click();

                    //driver.SwitchTo().Window(driver.WindowHandles[0]);

                    Thread.Sleep(5000);
                    // Parse logic                    
                }
                
              
            }
        }

        public static Func<IWebDriver, bool> WaitUntilFrameLoadedAndSwitchToIt(By byToFindFrame)
        {
            return (driver) =>
            {
                try
                {
                   driver.SwitchTo().Frame(driver.FindElement((byToFindFrame)));
                }
                catch (Exception)
                {
                    return false;
                }

                return true;
            };
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
