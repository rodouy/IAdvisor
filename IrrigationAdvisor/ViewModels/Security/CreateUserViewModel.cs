using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Security
{
    public class CreateUserViewModel
    {

        public long UserId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
        public String UserName { get; set; }
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public String ConfirmPassword { get; set; }

       

    }
}