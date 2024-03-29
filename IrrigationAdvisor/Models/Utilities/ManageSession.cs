﻿using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models;
using IrrigationAdvisor.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.DBContext.Data;

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

        public static void SetNavigationDate(DateTime pDateOfReference)
        {
            HttpContext.Current.Session["DateOfReference"] = pDateOfReference;
        }


        public static DateTime GetNavigationDate()
        {
            DateTime lResult = Utils.MAX_DATETIME;

            if (HttpContext.Current.Session["DateOfReference"] != null)
            {
                lResult = (DateTime)HttpContext.Current.Session["DateOfReference"];
            }

            return lResult;
        }
        
        public static Status GetCurrentStatus()
        {
            Status lResult = null;
            string lStatusName = System.Configuration.ConfigurationManager.AppSettings["Status"].ToString();

            if (HttpContext.Current.Session["DateOfReferenceDB"] != null)
            {
                lResult = (Status)HttpContext.Current.Session["DateOfReferenceDB"];
            }
            else
            {
                StatusConfiguration sc = new StatusConfiguration();
                lResult = sc.GetStatus(lStatusName);
                HttpContext.Current.Session["DateOfReferenceDB"] = lResult;

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

        public static long GetUserAccess()
        {
            long result = 0;

            if (HttpContext.Current.Session["UserAccess"] != null)
                result = Convert.ToInt64(HttpContext.Current.Session["UserAccess"]);

            return result;
        }

        public static void SetUserAccess(long pUserAccessId)
        {
            HttpContext.Current.Session["UserAccess"] = pUserAccessId;
        }

        public static void CleanSession()
        {
            HttpContext.Current.Session.Clear();
            
        }

    }
}
