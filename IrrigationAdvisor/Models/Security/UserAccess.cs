using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    public class UserAccess
    {
        [Key]
        public long UserAccessId { get; set; }
        public User User { get; set; }
        public DateTime LogInDate { get; set; }
        public DateTime? LogOutDate { get; set; }
        
    }
}