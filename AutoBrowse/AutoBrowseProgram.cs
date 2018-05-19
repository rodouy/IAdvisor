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

                string lUser = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["pUserName"]);
                string lPassword = Convert.ToString(System.Configuration.ConfigurationManager.AppSettings["pPassword"]);

                string url = args[0];
                MyWebClient wc = new MyWebClient();
                
                NameValueCollection values = new NameValueCollection()
                {
                    { "pUserName" , lUser },
                    { "pPassword" , lPassword }
                };

                byte[] raw = wc.UploadValues(url, values);
                //Get the html text from the web.
                string webData = Encoding.UTF8.GetString(raw);

                logger.Info("Resultado: " + webData);
                logger.Info("Se ha ejecutado correctamente AutoBrowse");
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
            }
            
        }
    }
}
