﻿using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class WaterOutputViewModel
    {
        
        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long WaterOutputId { get; set; }

        public DateTime Date { get; set; }

        public Double Output { get; set; }

        public DateTime ExtraDate { get; set; }

        public Double ExtraOutput { get; set; }

        public long CropIrrigationWeatherId { get; set; }

        #endregion
        
        #region Construction

        public WaterOutputViewModel(WaterOutput pWaterOutput)
        {
            this.WaterOutputId = pWaterOutput.WaterOutputId;
            this.Date = pWaterOutput.Date;
            this.Output = pWaterOutput.Output;
            this.ExtraDate = pWaterOutput.ExtraDate;
            this.ExtraOutput = pWaterOutput.ExtraOutput;
            this.CropIrrigationWeatherId = pWaterOutput.CropIrrigationWeatherId;
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