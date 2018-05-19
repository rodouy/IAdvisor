using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AutoBrowse
{
    public class MyWebClient : WebClient
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {

            int lTimeout = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["timeout"]);

            WebRequest w = base.GetWebRequest(uri);
            w.Timeout = lTimeout * 60 * 1000;
            return w;
        }
    }
}
