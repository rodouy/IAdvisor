//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IrrigationAdvisor.ConfirmIrrigationAdvices
{
    using System;
    using System.Collections.Generic;
    
    public partial class FarmContact
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