using IrrigationAdvisor.Models.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Water
{
    public class CalculationByCropIrrigationWeather
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CalculationByCropIrrigationWeatherId { get; set; }
        public long CropIrrigationWeatherId { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsCompleted { get; set; }
        public string Application { get; set; }
        public string Details { get; set; }
        public virtual CropIrrigationWeather CropIrrigationWeather { get; set; }
    }
}