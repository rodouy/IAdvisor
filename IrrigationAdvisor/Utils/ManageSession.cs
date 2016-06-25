using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor
{
    public class ManageSession
    {

        public static string GetUserName()
        {
            string result = null;

            if (HttpContext.Current.Session["UserName"] != null)
                result = (string)HttpContext.Current.Session["UserName"];

            return result;

        }

        public static void SetUserName(string userName)
        {
            HttpContext.Current.Session["UserName"] = userName;
        }

        public static string GetUserPassword()
        {

            string result = null;

            if (HttpContext.Current.Session["UserPassword"] != null)
                result = (string)HttpContext.Current.Session["UserPassword"];

            return result;

        }

        public static void SetUserPassword(string password)
        {
            HttpContext.Current.Session["UserPassword"] = password;
        }

    }
}