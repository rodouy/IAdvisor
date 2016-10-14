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
            //In prod change true by false
#if false
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new GetWeatherInfoService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
#if true
            GetWeatherInfoService www = new GetWeatherInfoService();
            www.ProcessWeathers();
#endif
        }
    }
}
