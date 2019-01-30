using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Security
{
    public class CRUDUserViewModel
    {

        public CRUDUserViewModel()
        {
            this.Roles = new List<System.Web.Mvc.SelectListItem>();
        }


        public long UserId { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public String Name { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public String Surname { get; set; }
        [Display(Name = "Teléfono")]
        public String Phone { get; set; }

        [Required]
        [Display(Name = "Rol")]
        public long RoleId { get; set; }
        [Display(Name = "Dirección")]
        public String Address { get; set; }
        [Display(Name = "Habilitado")]
        public bool Enable { get; set; }        
        public String FarmsHidden { get; set; }

        public List<string> ErrorMessages { get; set; }

        public List<System.Web.Mvc.SelectListItem> Roles { get; set; }
        public List<System.Web.Mvc.SelectListItem> Farms { get; set; }
    }
}