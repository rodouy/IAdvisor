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
    
    public partial class Irrigation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Irrigation()
        {
            this.DailyRecords = new HashSet<DailyRecord>();
        }
    
        public long WaterInputId { get; set; }
        public Nullable<long> CropIrrigationWeather_CropIrrigationWeatherId { get; set; }
        public int Type { get; set; }
        public string Observations { get; set; }
        public int Reason { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DailyRecord> DailyRecords { get; set; }
        public virtual WaterInput WaterInput { get; set; }
        public virtual CropIrrigationWeather CropIrrigationWeather { get; set; }
    }
}
