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

        public static HomeViewModel GetHomeViewModel()
        {
            HomeViewModel result = null;

            if (HttpContext.Current.Session["HomeViewModelModel"] != null)
                result = (HomeViewModel)HttpContext.Current.Session["HomeViewModelModel"];

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


        public static DateTime? GetDateOfReference()
        {
            DateTime? result = null;

            if (HttpContext.Current.Session["DateOfReference"] != null)
                result = (DateTime)HttpContext.Current.Session["DateOfReference"];

            return result;
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
            HttpContext.Current.Session["UserName"] = null;
            HttpContext.Current.Session["UserPassword"] = null;
        }

    }
}
