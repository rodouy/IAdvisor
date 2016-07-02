using IrrigationAdvisor.ComplementedUtils;
using IrrigationAdvisor.DBContext.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;

namespace IrrigationAdvisor.Authorize
{
    public class Authentication
    {

        public Authentication()
        {

        }

        public Authentication(  string userName,
                                string password)
        {
            this.UserName = userName;
            this.Password = password;
        }


        public bool IsAuthenticated()
        {

            if (string.IsNullOrEmpty(this.UserName) || string.IsNullOrEmpty(this.Password))
                return false;

            string userName = this.UserName;

            string userPassword = this.Password;

            UserConfiguration uc = new UserConfiguration();

            string dbPassword = uc.GetPasswordFor(userName);

            MD5 md5Hash = MD5.Create();

            string passwordHash = CryptoUtils.GetMd5Hash(md5Hash, userPassword);

            if (!String.IsNullOrEmpty(dbPassword) && CryptoUtils.VerifyMd5Hash(md5Hash, userPassword, passwordHash))
                return true;

            return false;
        }


        public string UserName { get; set; }

        public string Password { get; set; }

    }
}