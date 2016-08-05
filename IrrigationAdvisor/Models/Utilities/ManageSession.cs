using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor
{
    public class ManageSession
    {

        public static String GetUserName()
        {
            String lReturn = null;

            if (HttpContext.Current.Session["UserName"] != null)
            {
                lReturn = (String)HttpContext.Current.Session["UserName"];
            }

            return lReturn;

        }

        public static void SetUserName(String pUserName)
        {
            HttpContext.Current.Session["UserName"] = pUserName;
        }

        public static String GetUserPassword()
        {

            String lReturn = null;

            if (HttpContext.Current.Session["UserPassword"] != null)
            {
                lReturn = (String)HttpContext.Current.Session["UserPassword"];
            }

            return lReturn;

        }

        public static void SetUserPassword(String pPassword)
        {
            HttpContext.Current.Session["UserPassword"] = pPassword;
        }

        public static HomeViewModel GetHomeViewModel()
        {
            HomeViewModel result = null;

            if (HttpContext.Current.Session["HomeViewModelModel"] != null)
            {
                result = (HomeViewModel)HttpContext.Current.Session["HomeViewModelModel"];
            }

            return result;
        }

        public static void SetHomeViewModel(HomeViewModel pHomeViewModel)
        {
            HttpContext.Current.Session["HomeViewModelModel"] = pHomeViewModel;
        }

        public static void SetDateOfReference(DateTime pDateOfReference)
        {
            HttpContext.Current.Session["DateOfReference"] = pDateOfReference;
        }


        public static DateTime GetDateOfReference()
        {
            DateTime lResult = Utils.MAX_DATETIME;

            if (HttpContext.Current.Session["DateOfReference"] != null)
            {
                lResult = (DateTime)HttpContext.Current.Session["DateOfReference"];
            }

            return lResult;
        }

        public static LoginViewModel GetLoginViewModel()
        {
            LoginViewModel result = null;

            if (HttpContext.Current.Session["LoginViewModel"] != null)
                result = (LoginViewModel)HttpContext.Current.Session["LoginViewModel"];

            return result;
        }

        public static void SetLoginViewModel(LoginViewModel pLoginViewModel)
        {
            HttpContext.Current.Session["LoginViewModel"] = pLoginViewModel;
        }

        public static void SetFromDateTime(DateTime pFromDate)
        {
            HttpContext.Current.Session["FromDate"] = pFromDate;
        }

        public DateTime? GetFromDateTime()
        {
            DateTime? result = null;

            if (HttpContext.Current.Session["FromDate"] != null)
                result = (DateTime?)HttpContext.Current.Session["FromDate"];

            return result;
        }

        public static void CleanSession()
        {
            HttpContext.Current.Session.Clear();
            
        }

    }
}
