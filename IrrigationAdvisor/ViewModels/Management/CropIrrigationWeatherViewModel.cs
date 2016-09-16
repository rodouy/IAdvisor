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
    public class CropIrrigationWeatherViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long CropIrrigationWeatherId { get; set; }

        public String CropIrrigationWeatherName { get; set; }

        public long CropId { get; set; }

        public long SoilId { get; set; }

        public long PhenologicalStageId { get; set; }

        public long IrrigationUnitId { get; set; }

        #region Weather
        public long MainWeatherStationId { get; set; }

        public long AlternativeWeatherStationId { get; set; }
        #endregion

        public long PositionId { get; set; }

        #region Dates of Crop
        public DateTime SowingDate { get; set; }

        public DateTime HarvestDate { get; set; }

        public DateTime CropDate { get; set; }

        public DateTime StartAdvisorDate { get; set; }
        #endregion

        #region Crop State
        public Double HydricBalance { get; set; }

        public Double SoilHydricVolume { get; set; }

        public List<PhenologicalStageAdjustment> PhenologicalStageAdjustmentList { get; set; }

        public int DayAfterSowing { get; set; }

        public int DayAfterSowingModified { get; set; }

        public Double GrowingDegreeDaysAccumulated { get; set; }

        public Double GrowingDegreeDaysModified { get; set; }

        public Double PredeterminatedIrrigationQuantity { get; set; }
        #endregion

        #region Water
        public List<Rain> RainList { get; set; }

        public List<Models.Water.Irrigation> IrrigationList { get; set; }

        public List<EvapotranspirationCrop> EvapotranspirationCropList { get; set; }
        #endregion

        public List<DailyRecord> DailyRecordList { get; set; }

        #region Totals
        public Double TotalEvapotranspirationCrop { get; set; }

        public Double TotalEffectiveRain { get; set; }

        public Double TotalRealRain { get; set; }

        public Double TotalIrrigation { get; set; }

        public Double TotalIrrigationInHydricBalance { get; set; }

        public Double TotalExtraIrrigation { get; set; }

        public Double TotalExtraIrrigationInHydricBalance { get; set; }
        #endregion

        #endregion

        #region Construction

        public CropIrrigationWeatherViewModel(CropIrrigationWeather pCropIrrigationWeather)
        {
            this.CropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId;
            this.CropIrrigationWeatherName = pCropIrrigationWeather.CropIrrigationWeatherName;
            this.CropId = pCropIrrigationWeather.CropId;
            this.SoilId = pCropIrrigationWeather.SoilId;
            this.PhenologicalStageId = pCropIrrigationWeather.PhenologicalStageId;
            this.IrrigationUnitId = pCropIrrigationWeather.IrrigationUnitId;
            #region Weather
            this.MainWeatherStationId = pCropIrrigationWeather.MainWeatherStationId;
            this.AlternativeWeatherStationId = pCropIrrigationWeather.AlternativeWeatherStationId;
            #endregion
            this.PositionId = pCropIrrigationWeather.PositionId;
            #region Dates of Crop
            this.SowingDate = pCropIrrigationWeather.SowingDate;
            this.HarvestDate = pCropIrrigationWeather.HarvestDate;
            this.CropDate = pCropIrrigationWeather.CropDate;
            this.StartAdvisorDate = pCropIrrigationWeather.StartAdvisorDate;
            #endregion
            #region Crop State
            this.HydricBalance = pCropIrrigationWeather.HydricBalance;
            this.SoilHydricVolume = pCropIrrigationWeather.SoilHydricVolume;
            this.PhenologicalStageAdjustmentList = pCropIrrigationWeather.PhenologicalStageAdjustmentList;
            this.DayAfterSowing = pCropIrrigationWeather.DaysAfterSowing;
            this.DayAfterSowingModified = pCropIrrigationWeather.DaysAfterSowingModified;
            this.GrowingDegreeDaysAccumulated = pCropIrrigationWeather.GrowingDegreeDaysAccumulated;
            this.GrowingDegreeDaysModified = pCropIrrigationWeather.GrowingDegreeDaysModified;
            this.PredeterminatedIrrigationQuantity = pCropIrrigationWeather.PredeterminatedIrrigationQuantity;
            #endregion
            #region Water
            this.RainList = pCropIrrigationWeather.RainList;
            this.IrrigationList = pCropIrrigationWeather.IrrigationList;
            this.EvapotranspirationCropList = pCropIrrigationWeather.EvapotranspirationCropList;
            #endregion
            this.DailyRecordList = pCropIrrigationWeather.DailyRecordList;
            #region Totals
            this.TotalEvapotranspirationCrop = pCropIrrigationWeather.TotalEvapotranspirationCrop;
            this.TotalEffectiveRain = pCropIrrigationWeather.TotalEffectiveRain;
            this.TotalRealRain = pCropIrrigationWeather.TotalRealRain;
            this.TotalIrrigation = pCropIrrigationWeather.TotalIrrigation;
            this.TotalIrrigationInHydricBalance = pCropIrrigationWeather.TotalIrrigationInHydricBalance;
            this.TotalExtraIrrigation = pCropIrrigationWeather.TotalExtraIrrigation;
            this.TotalExtraIrrigationInHydricBalance = pCropIrrigationWeather.TotalExtraIrrigationInHydricBalance;
            #endregion
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