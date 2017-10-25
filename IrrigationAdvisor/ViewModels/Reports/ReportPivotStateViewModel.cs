using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;

namespace IrrigationAdvisor.ViewModels.Reports
{
    public class ReportPivotStateViewModel
    {
        [Required]
        public Chart Chart { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Required]
        public double TotalEffectiveInputWater { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public double TotalEffectiveRain { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Required]
        public double TotalEvapotranspirationCrop { get; set; }

        public bool IsUserAdministrator { get; set; }

        [Required]
        public String Title { get; set; }
    }

}