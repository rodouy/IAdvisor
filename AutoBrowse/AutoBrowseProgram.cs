using NLog;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

                NameValueCollection values = new NameValueCollection()
                {
                    { "pUserName" , "Admin"},
                    { "pPassword" , "Irrigation4dvis0r" }
                };

                byte[] raw = wc.UploadValues(url, values);
                //Get the html text from the web.
                string webData = Encoding.UTF8.GetString(raw);

                logger.Info("Se ha ejecutado correctamente AutoBrowse");
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
            }
            
        }
    }
}
