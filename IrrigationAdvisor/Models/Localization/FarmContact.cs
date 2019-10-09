using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Localization
{
    public class FarmContact
    {
        public long FarmContactId { get; set; }
        public long FarmId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool SendEmail { get; set; }
        public virtual Farm Farm { get; set; }
    }
}