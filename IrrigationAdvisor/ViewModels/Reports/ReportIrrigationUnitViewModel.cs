using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Helpers;

namespace IrrigationAdvisor.ViewModels.Reports
{
    public class ReportIrrigationUnitViewModel
    {
 
        [Required]
        public String Title { get; set; }

        [Required]
        public long CropIrrigationWeatherId { get; set; }

    }

}