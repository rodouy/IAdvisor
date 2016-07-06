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
        [Required]
        public String Name { get; set; }
        [Required]
        public String Surname { get; set; }
        public String Phone { get; set; }

        [Required]
        [Display(Name = "Role")]
        public int RoleId { get; set; }
        public String Address { get; set; }
        [Required]
        [UserEmailExists(ErrorMessage = "El email ingresado ya existe.")]
        public String Email { get; set; }
        [UserNameExists(ErrorMessage = "El nombre de usuario ya existe, por favor selecciona otro nombre.")]
        public String UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [CompareAttribute("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public String ConfirmPassword { get; set; }
        public List<string> ErrorMessages { get; set; }
        

    }
}