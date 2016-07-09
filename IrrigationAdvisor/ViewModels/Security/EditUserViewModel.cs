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

        public String Email { get; set; }
        public String Password { get; set; }
        public String UserName { get; set; }
    }
}