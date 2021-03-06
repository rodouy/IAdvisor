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
    
    public partial class IrrigationUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IrrigationUnit()
        {
            this.CropIrrigationWeathers = new HashSet<CropIrrigationWeather>();
        }
    
        public long IrrigationUnitId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int IrrigationType { get; set; }
        public double IrrigationEfficiency { get; set; }
        public double Surface { get; set; }
        public long BombId { get; set; }
        public long PositionId { get; set; }
        public double PredeterminatedIrrigationQuantity { get; set; }
        public long FarmId { get; set; }
        public bool Show { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CropIrrigationWeather> CropIrrigationWeathers { get; set; }
        public virtual Farm Farm { get; set; }
    }
}
