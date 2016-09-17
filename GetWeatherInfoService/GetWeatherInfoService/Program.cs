using System.ServiceProcess;

namespace GetWeatherInfoService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new GetWeatherInfoService()
            //};
            //ServiceBase.Run(ServicesToRun);

            GetWeatherInfoService www = new GetWeatherInfoService();
            www.ProcessWeathers();

        }
    }
}
