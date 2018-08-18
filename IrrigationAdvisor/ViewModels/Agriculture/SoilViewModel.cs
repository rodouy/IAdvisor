using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class SoilViewModel
    {

        public long SoilId { get; set; }

        [Display(Name = "Nombre")]
        public String Name { get; set; }
        public String ShortName { get; set; }

        [Display(Name = "Descripción")]
        public String Description { get; set; }

        [Display(Name = "Profundidad")]
        public double DepthLimit { get; set; }
        public long FarmId { get; set; }
        public long PositionId { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] 
        [Display(Name = "Fecha de visita")]
        public DateTime TestDate { get; set; }

        public Farm Farm { get; set; }
        public List<System.Web.Mvc.SelectListItem> Farms { get; set; }
        [Display(Name = "Latitud")]
        public double Latitude { get; set; }

        [Display(Name = "Longitud")]
        public double Longitude { get; set; }

        public Position Position { get; set; }

        public List<Horizon> Horizonts { get; set; }
        public SoilViewModel()
        {
        }

        public SoilViewModel(Soil soil)
        {
            this.SoilId = soil.SoilId;
            this.Name = soil.Name;
            this.ShortName = soil.ShortName;
            this.Description = soil.Description;
            this.DepthLimit = soil.DepthLimit;
            this.FarmId = soil.FarmId;
            this.Farm = soil.Farm;
            this.PositionId = soil.PositionId;
            this.TestDate = soil.TestDate;
            this.Latitude = soil.Position.Latitude;
            this.Longitude = soil.Position.Longitude;
            this.Position = soil.Position;
            this.Horizonts = soil.HorizonList;

        }
    }


}