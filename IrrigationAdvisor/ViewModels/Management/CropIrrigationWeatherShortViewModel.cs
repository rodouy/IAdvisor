using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Irrigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.ViewModels.Management
{
    public class CropIrrigationWeatherShortViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long CropIrrigationWeatherId { get; set; }

        public String CropIrrigationWeatherName { get; set; }


        #region Weather
        public long MainWeatherStationId { get; set; }

        public long AlternativeWeatherStationId { get; set; }
        #endregion

        #endregion

        #region Construction

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #endregion

        #region Overrides
        #endregion

    }
}