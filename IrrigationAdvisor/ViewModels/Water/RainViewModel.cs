using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class RainViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long WaterInputId { get; set; }

        public Utils.WaterInputType Type { get; set; }

        public DateTime Date { get; set; }

        public Double Input { get; set; }

        public DateTime ExtraDate { get; set; }

        public Double ExtraInput { get; set; }

        public long CropIrrigationWeatherId { get; set; }
        
        #endregion

        #region Construction

        public RainViewModel(Rain pRain)
        {
            this.WaterInputId = pRain.WaterInputId;
            this.Type = pRain.Type;
            this.Date = pRain.Date;
            this.Input = pRain.Input;
            this.ExtraDate = pRain.ExtraDate;
            this.ExtraInput = pRain.ExtraInput;
            this.CropIrrigationWeatherId = pRain.CropIrrigationWeatherId;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides
        #endregion

    }
}