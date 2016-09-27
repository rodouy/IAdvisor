using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AutoBrowse
{
    class AutoBrowseProgram
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                string url = args[0];
                WebClient wc = new WebClient();
                byte[] raw = wc.DownloadData(url);
                //Get the html text from the web.
                string webData = Encoding.UTF8.GetString(raw);

                logger.Info("Se ha ejecutado correctamente AutoBrowse");
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message);
            }
            
        }
    }
}
