using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class EvapotranspirationCropViewModel
    {
        
        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long WaterOutputId { get; set; }

        public Utils.WaterOutputType Type { get; set; }

        public DateTime Date { get; set; }

        public Double Output { get; set; }

        public DateTime ExtraDate { get; set; }

        public Double ExtraOutput { get; set; }

        public long CropIrrigationWeatherId { get; set; }

        #endregion
        
        #region Construction

        public EvapotranspirationCropViewModel(EvapotranspirationCrop pEvapotranspirationCrop)
        {
            this.WaterOutputId = pEvapotranspirationCrop.WaterOutputId;
            this.Type = pEvapotranspirationCrop.Type;
            this.Date = pEvapotranspirationCrop.Date;
            this.Output = pEvapotranspirationCrop.Output;
            this.ExtraDate = pEvapotranspirationCrop.ExtraDate;
            this.ExtraOutput = pEvapotranspirationCrop.ExtraOutput;
            this.CropIrrigationWeatherId = pEvapotranspirationCrop.CropIrrigationWeatherId;
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