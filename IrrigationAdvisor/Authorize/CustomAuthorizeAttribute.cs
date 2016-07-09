using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.ComplementedUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace IrrigationAdvisor.Authorize
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {

            Authentication authentication = new Authentication(ManageSession.GetUserName(),
                                                                 ManageSession.GetUserPassword());

            return authentication.IsAuthenticated();


        }

       


    }
}