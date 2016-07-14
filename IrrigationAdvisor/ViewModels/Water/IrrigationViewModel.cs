using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Water
{
    public class IrrigationViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long WaterOutputId { get; set; }

        public Utils.WaterInputType Type { get; set; }

        public DateTime Date { get; set; }

        public Double Output { get; set; }

        public DateTime ExtraDate { get; set; }

        public Double ExtraOutput { get; set; }

        public long CropIrrigationWeatherId { get; set; }

        #endregion

        #region Construction

         public IrrigationViewModel(Models.Water.Irrigation pIrrigation)
        {
            this.WaterOutputId = pIrrigation.WaterInputId;
            this.Type = pIrrigation.Type;
            this.Date = pIrrigation.Date;
            this.Output = pIrrigation.Input;
            this.ExtraDate = pIrrigation.ExtraDate;
            this.ExtraOutput = pIrrigation.ExtraInput;
            this.CropIrrigationWeatherId = pIrrigation.CropIrrigationWeatherId;
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