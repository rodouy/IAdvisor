﻿using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class WaterInputViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long WaterInputId { get; set; }

        public DateTime Date { get; set; }

        public Double Input { get; set; }

        public DateTime ExtraDate { get; set; }

        public Double ExtraInput { get; set; }

        public long CropIrrigationWeatherId { get; set; }
        
        #endregion

        #region Construction
        
        public WaterInputViewModel(WaterInput pWaterInput)
        {
            this.WaterInputId = pWaterInput.WaterInputId;
            this.Date = pWaterInput.Date;
            this.Input = pWaterInput.Input;
            this.ExtraDate = pWaterInput.ExtraDate;
            this.ExtraInput = pWaterInput.ExtraInput;
            this.CropIrrigationWeatherId = pWaterInput.CropIrrigationWeatherId;
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