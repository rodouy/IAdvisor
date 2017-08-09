using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.WebApi.Models
{
    public class AuthViewModel
    {
        public AuthViewModel()
        {
            Farms = new List<FarmViewModel>();
        }

        public string Token { get; set; }
        public List<FarmViewModel> Farms { get; set; }
    }
}