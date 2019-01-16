using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Security
{
    public class EditUserViewModel : CRUDUserViewModel
    {

        [Display(Name = "E-mail")]
        public String Email { get; set; }
        [Display(Name = "Password")]
        public String Password { get; set; }
        [Display(Name = "Usuario")]
        public String UserName { get; set; }
        [Display(Name = "Rol")]
        public String RolName { get; set; }

        public long FarmId { get; set; }
        public List<System.Web.Mvc.SelectListItem> FarmsNotRelated { get; set; }

        public List<System.Web.Mvc.SelectListItem> Farms { get; set; }
        public string FarmIdSelected { get; set; }   
    }
}