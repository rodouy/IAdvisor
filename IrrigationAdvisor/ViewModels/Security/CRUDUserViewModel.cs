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
        public String Name { get; set; }
        [Required]
        public String Surname { get; set; }
        public String Phone { get; set; }

        [Required]
        [Display(Name = "Role")]
        public long RoleId { get; set; }
        public String Address { get; set; }
        
        
        

        public List<string> ErrorMessages { get; set; }

        public List<System.Web.Mvc.SelectListItem> Roles { get; set; }

    }
}