using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Security
{
    public class CreateUserViewModel : CRUDUserViewModel
    {
        
        [UserNameExists(ErrorMessage = "El usuario ya existe.")]
        public String UserName { get; set; }

        
        [DataType(DataType.Password)]
        public String Password { get; set; }

        [UserEmailExists(ErrorMessage = "El email ya existe")]
        public String Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [CompareAttribute("Password", ErrorMessage = "El password y la confirmación no coinciden.")]
        public String ConfirmPassword { get; set; }



    }
}