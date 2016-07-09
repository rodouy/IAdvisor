using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.Models.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Security
{
    public class UserNameExistsAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {

            string userName = value as string;

            if (!string.IsNullOrEmpty(userName))
            {
                List<string> messages = new List<string>();

                UserConfiguration uc = new UserConfiguration();

                User userExists = uc.GetUserByName(userName);

                if (userExists != null)
                    return false;
            }
                

            return true;
        }

    }
}