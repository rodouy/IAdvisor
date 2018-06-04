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

                }              
            }           
        }
    }
}
