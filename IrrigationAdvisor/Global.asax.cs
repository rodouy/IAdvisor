﻿using IrrigationAdvisor.DBContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace IrrigationAdvisor
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {

            #if true
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new DropCreateDatabaseIfModelChanges<IrrigationAdvisorContext>());
            #endif

            #if false
            Database.SetInitializer<IrrigationAdvisorContext>
                    (new DropCreateDatabaseIfModelChanges<IrrigationAdvisorContext>());
            #endif
            
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        void Application_EndRequest(object sender, System.EventArgs e)
        {
            // If the user is not authorised to see this page or access this function, send them to the error page.
            if (Response.StatusCode == 401)
            {
                Response.ClearContent();
                Response.Redirect("/");
            }
        }
    }
}
