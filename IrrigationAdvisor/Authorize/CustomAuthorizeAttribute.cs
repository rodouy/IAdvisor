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
            string userName = ManageSession.GetUserName();

            string userPassword = ManageSession.GetUserPassword();

            UserConfiguration uc = new UserConfiguration();

            string dbPassword = uc.GetPasswordFor(userName);

            MD5 md5Hash = MD5.Create();

            string passwordHash = CryptoUtils.GetMd5Hash(md5Hash, userPassword);

            if (!String.IsNullOrEmpty(dbPassword) && CryptoUtils.VerifyMd5Hash(md5Hash, userPassword, passwordHash))
                return true;

            return false;
        }


    }
}