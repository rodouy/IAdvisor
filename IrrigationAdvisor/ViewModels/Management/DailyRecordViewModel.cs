using IrrigationAdvisor.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.ViewModels.Management
{
    public class DailyRecordViewModel
    {

        #region Consts
        #endregion

        #region Fields
        #endregion

        #region Properties

        public long DailyRecordId { get; set; }

        public DateTime DailyRecordDateTime { get; set; }

        #region Weather Data
        public long MainWeatherDataId { get; set; }
        public long AlternativeWeatherDataId { get; set; }
        #endregion

        #region Calculus of Phenological Adjustment
        public int DaysAfterSowing { get; set; }
        public int DaysAfterSowingModified { get; set; }
        public Double GrowingDegreeDays { get; set; }
        public Double GrowingDegreeDaysAccumulated { get; set; }
        public Double GrowingDegreeDaysModified { get; set; }
        public DateTime LastDayOfGrowingDegreeDays { get; set; }
        #endregion

        #region Water Data
        public long RainId { get; set; }
        public long IrrigationId { get; set; }
        public DateTime LastWaterInputDate { get; set; }
        public DateTime LastBigWaterInputDate { get; set; }
        public DateTime LastPartialWaterInputDate { get; set; }
        public Double LastPartialWaterInput { get; set; }
        public DateTime LastBigGapWaterInputDate { get; set; }

        public Double TotalEffectiveInputWater { get; set; }
        public Double PercentageOfHydricBalance { get; set; }
        public Double GapPercentageOfHydricBalance { get; set; }

        public long EvapotranspirationCropId { get; set; }
        #endregion

        #region Crop State
        public long PhenologicalStageId { get; set; }
        public Double HydricBalance { get; set; }
        public Double SoilHydricVolume { get; set; }
        public Double TotalEvapotranspirationCropFromLastWaterInput { get; set; }
        public Double CropCoefficient { get; set; }
        public String Observations { get; set; }
        #endregion

        #region Totals
        public double TotalEvapotranspirationCrop { get; set; }
        public double TotalEffectiveRain { get; set; }
        public double TotalRealRain { get; set; }
        public double TotalIrrigation { get; set; }
        public double TotalIrrigationInHydricBalance { get; set; }
        public double TotalExtraIrrigation { get; set; }
        public double TotalExtraIrrigationInHydricBalance { get; set; }
        #endregion

        #endregion

        #region Construction

        public DailyRecordViewModel(DailyRecord pDailyRecord)
        {
            this.DailyRecordId = pDailyRecord.DailyRecordId;
            this.DailyRecordDateTime = pDailyRecord.DailyRecordDateTime;
            
            #region Weather Data
            this.MainWeatherDataId = pDailyRecord.MainWeatherDataId;
            this.AlternativeWeatherDataId = pDailyRecord.AlternativeWeatherDataId;
            #endregion

            #region Calculus of Phenological Adjustment
            this.DaysAfterSowing = pDailyRecord.DaysAfterSowing;
            this.DaysAfterSowingModified = pDailyRecord.DaysAfterSowingModified;
            this.GrowingDegreeDays = pDailyRecord.GrowingDegreeDays;
            this.GrowingDegreeDaysAccumulated = pDailyRecord.GrowingDegreeDaysAccumulated;
            this.GrowingDegreeDaysModified = pDailyRecord.GrowingDegreeDaysModified;
            this.LastDayOfGrowingDegreeDays = pDailyRecord.LastDayOfGrowingDegreeDays;
            #endregion

            #region Water Data
            this.RainId = pDailyRecord.RainId;
            this.IrrigationId = pDailyRecord.IrrigationId;
            this.LastWaterInputDate = pDailyRecord.LastWaterInputDate;
            this.LastBigWaterInputDate = pDailyRecord.LastBigWaterInputDate;
            this.LastPartialWaterInputDate = pDailyRecord.LastPartialWaterInputDate;
            this.LastPartialWaterInput = pDailyRecord.LastPartialWaterInput;
            this.LastBigGapWaterInputDate = pDailyRecord.LastBigWaterInputDate;

            this.TotalEffectiveInputWater = pDailyRecord.TotalEffectiveInputWater;
            this.PercentageOfHydricBalance = pDailyRecord.PercentageOfHydricBalance;
            this.GapPercentageOfHydricBalance = pDailyRecord.GAPPercentageOfHydricBalance;

            this.EvapotranspirationCropId = pDailyRecord.EvapotranspirationCropId;
            #endregion

            #region Crop State
            this.PhenologicalStageId = pDailyRecord.PhenologicalStageId;
            this.HydricBalance = pDailyRecord.HydricBalance;
            this.SoilHydricVolume = pDailyRecord.SoilHydricVolume;
            this.TotalEvapotranspirationCropFromLastWaterInput = pDailyRecord.TotalEvapotranspirationCropFromLastWaterInput;
            this.CropCoefficient = pDailyRecord.CropCoefficient;
            this.Observations = pDailyRecord.Observations;
            #endregion

            #region Totals
            this.TotalEvapotranspirationCrop = pDailyRecord.TotalEvapotranspirationCrop;
            this.TotalEffectiveRain = pDailyRecord.TotalEffectiveRain;
            this.TotalRealRain = pDailyRecord.TotalRealRain;
            this.TotalIrrigation = pDailyRecord.TotalIrrigation;
            this.TotalIrrigationInHydricBalance = pDailyRecord.TotalIrrigationInHydricBalance;
            this.TotalExtraIrrigation = pDailyRecord.TotalExtraIrrigation;
            this.TotalExtraIrrigationInHydricBalance = pDailyRecord.TotalExtraIrrigationInHydricBalance;
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