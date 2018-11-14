using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Agriculture
{
    public class HorizonViewModel
    {

        public long HorizonId { get; set; }

        [Display(Name = "Nombre")]
        public String Name { get; set; }

        [Display(Name = "Orden")]
        public int Order { get; set; }

        [Display(Name = "Capa")]
        public string HorizonLayer { get; set; }

        [Display(Name = "Profundidad de capa")]
        public double HorizonLayerDepth { get; set; }

        [Display(Name = "Arena")]
        public double Sand { get; set; }

        [Display(Name = "Barro (limo)")]
        public double Limo { get; set; }

        [Display(Name = "Arcilla")]
        public double Clay { get; set; }

        [Display(Name = "Análisis de nitrógeno")]
        public double NitrogenAnalysis { get; set; }

        [Display(Name = "Densidad")]
        public double BulkDensitySoil { get; set; }

        [Display(Name = "Materia orgánica")]
        public double OrganicMatter { get; set; }

        [Display(Name = "Suelo")]
        public long SoilId { get; set; }

        [Display(Name = "Suelo")]
        public Soil Soil { get; set; }

        public List<System.Web.Mvc.SelectListItem> Soils { get; set; }
        public HorizonViewModel()
        {
        }

        public HorizonViewModel(Horizon horizon)
        {
            this.HorizonId = horizon.HorizonId;
            this.Name = horizon.Name;
            this.BulkDensitySoil = horizon.BulkDensitySoil;
            this.Clay = horizon.Clay;
            this.HorizonLayer = horizon.HorizonLayer;
            this.HorizonLayerDepth = horizon.HorizonLayerDepth;
            this.Limo = horizon.Limo;
            this.NitrogenAnalysis = horizon.NitrogenAnalysis;
            this.Order = horizon.Order;
            this.OrganicMatter = horizon.OrganicMatter;
            this.Sand = horizon.Sand;
            this.SoilId = horizon.SoilId;
            this.Soil = horizon.Soil;
            this.Soils = new List<System.Web.Mvc.SelectListItem>();

        }
    }


}