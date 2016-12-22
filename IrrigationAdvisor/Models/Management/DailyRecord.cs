using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Utilities;


namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-10-27
    /// Author:  monicarle
    /// Description: 
    ///     Describes the daily changes on a CropIrrigationWeather
    ///     
    /// References:
    ///     CropIrrigationWeather
    ///     WeatherData
    ///     WaterOutput
    ///     WaterInput
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropIrrigationWeather: CropIrrigationWeather - PK
    ///     - mainWeatherData: WeatherData
    ///     - alternativeWeatherData: WeatherData
    ///     - date: DateTime                               - PK
    ///     - growingDegreeDays: double
    ///     - totalGrowingDegree: double
    ///     - evapotranspirationCrop: WaterOutput
    ///     - lRainItem: WaterInput
    ///     - lIrrigationItem: WaterInput 
    ///     - observations: String
    /// 
    /// Methods:
    ///     - DailyRecord()      -- constructor
    ///     - DailyRecord(name)  -- consturctor with parameters
    ///     - GetDaysAfterSowing(): int
    ///     - GetRegion(): Region
    ///     - GetBaseTemperature(): double
    ///     - getDailyAverageTemperature(): double
    ///     - GetEvapotranspiration(): double
    ///     - getCropCoefficient(): double
    ///     - GetEffectiveRain(Region, lRainItem:double, Date): double
    ///     - setObservations(String): bool
    ///      
    /// </summary>
    public class DailyRecord
    {
        #region Consts
        #endregion

        #region Fields

        private long dailyRecordId;
        private DateTime dailyRecordDateTime;

        private long cropIrrigationWeatherId;

        #region Weather Data

        private long mainWeatherDataId;
        private long alternativeWeatherDataId;

        #endregion

        #region Calculus of Phenological Adjustment

        private int daysAfterSowing;
        private int daysAfterSowingModified;

        private Double growingDegreeDays;
        private Double growingDegreeDaysAccumulated;
        private Double growingDegreeDaysModified;
        private DateTime lastDayOfGrowingDegreeDays;
        #endregion

        #region Water Data

        private long rainId;
        private long irrigationId;
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;       
        private DateTime lastPartialWaterInputDate;
        private Double lastPartialWaterInput;
        private DateTime lastBigGapWaterInputDate;

        private Double totalEffectiveInputWater;
        private Double percentageOfHydricBalance;
        private Double gapPercentageOfHydricBalance;
        
        private long evapotranspirationCropId;

        #endregion

        #region Crop State

        private long phenologicalStageId;
        private Double hydricBalance;
        private Double soilHydricVolume;
        private Double totalEvapotranspirationCropFromLastWaterInput;
        private Double cropCoefficient;
        private String observations;

        #endregion

        #region Totals

        private double totalEvapotranspirationCrop;
        private double totalEffectiveRain;
        private double totalRealRain;
        private double totalIrrigation;
        private double totalIrrigationInHydricBalance;
        private double totalExtraIrrigation;
        private double totalExtraIrrigationInHydricBalance;

        #endregion

        #endregion

        #region Properties

        
        public long DailyRecordId
        {
            get { return dailyRecordId; }
            set { dailyRecordId = value; }
        }
        
        public DateTime DailyRecordDateTime
        {
            get { return dailyRecordDateTime; }
            set { dailyRecordDateTime = value; }
        }

        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
        }

        public virtual CropIrrigationWeather CropIrrigationWeather
        {        
            get;
            set;
        }

        #region WeatherData

        public long MainWeatherDataId
        {
            get { return mainWeatherDataId; }
            set { mainWeatherDataId = value; }
        }

        public virtual WeatherData MainWeatherData
        {
            get;
            set;
        }

        public long AlternativeWeatherDataId
        {
            get { return alternativeWeatherDataId; }
            set { alternativeWeatherDataId = value; }
        }

        public virtual WeatherData AlternativeWeatherData
        {
            get;
            set;
        }

        #endregion

        #region CalculusByDaysAfterSowing

        public int DaysAfterSowing
        {
            get { return daysAfterSowing; }
            set { daysAfterSowing = value; }
        }

        public int DaysAfterSowingModified
        {
            get { return daysAfterSowingModified; }
            set { daysAfterSowingModified = value; }
        }

        #endregion

        #region CalculusByGrowingDegreeDays
        
        public Double GrowingDegreeDays
        {
            get { return growingDegreeDays; }
            set { growingDegreeDays = value; }
        }

        public Double GrowingDegreeDaysAccumulated
        {
            get { return growingDegreeDaysAccumulated; }
            set { growingDegreeDaysAccumulated = value; }
        }

        public Double GrowingDegreeDaysModified
        {
            get { return growingDegreeDaysModified; }
            set { growingDegreeDaysModified = value; }
        }

        public DateTime LastDayOfGrowingDegreeDays
        {
            get { return lastDayOfGrowingDegreeDays; }
            set { lastDayOfGrowingDegreeDays = value; }
        }

        #endregion

        #region Water Data

        #region InputWaterData

        public long RainId
        {
            get { return rainId; }
            set { rainId = value; }
        }

        public virtual Rain Rain
        {
            get;
            set;
        }
        
        public long IrrigationId
        {
            get { return irrigationId; }
            set { irrigationId = value; }
        }

        public Water.Irrigation Irrigation
        {
            get;
            set;
        }

        public DateTime LastWaterInputDate
        {
            get { return lastWaterInputDate; }
            set { lastWaterInputDate = value; }
        }

        public DateTime LastBigWaterInputDate
        {
            get { return lastBigWaterInputDate; }
            set { lastBigWaterInputDate = value; }
        }
        
        public DateTime LastPartialWaterInputDate
        {
            get { return lastPartialWaterInputDate; }
            set { lastPartialWaterInputDate = value; }
        }

        public Double LastPartialWaterInput
        {
            get { return lastPartialWaterInput; }
            set { lastPartialWaterInput = value; }
        }

        public DateTime LastBigGapWaterInputDate
        {
            get { return lastBigGapWaterInputDate; }
            set { lastBigGapWaterInputDate = value; }
        } 

        #endregion

        #region OutputWeatherData

        public long EvapotranspirationCropId
        {
            get { return evapotranspirationCropId; }
            set { evapotranspirationCropId = value; }
        }

        public Water.EvapotranspirationCrop EvapotranspirationCrop
        {
            get;
            set;
        }
        
        #endregion

        /// <summary>
        /// The total input water for a day
        /// </summary>
        public Double TotalEffectiveInputWater
        {
            get { return totalEffectiveInputWater; }
            set { totalEffectiveInputWater = value; }
        }

        /// <summary>
        /// Percentage of water (HydricBalance / FieldCapacity * 100)
        /// </summary>
        public Double PercentageOfHydricBalance
        {
            get { return percentageOfHydricBalance; }
            set { percentageOfHydricBalance = value; }
        }
        
        /// <summary>
        /// GAP of percentage of water in Hydric Balance (HydricBalance / FieldCapacity * 100)
        /// </summary>
        public Double GAPPercentageOfHydricBalance
        {
            get { return gapPercentageOfHydricBalance; }
            set { gapPercentageOfHydricBalance = value; }
        }

        #endregion

        #region Crop State

        public long PhenologicalStageId
        {
            get { return phenologicalStageId; }
            set { phenologicalStageId = value; }
        }

        public virtual PhenologicalStage PhenologicalStage
        {
            get;
            set;
        }

        public Double HydricBalance
        {
            get { return hydricBalance; }
            set { hydricBalance = value; }
        }

        public Double SoilHydricVolume
        {
            get { return soilHydricVolume; }
            set { soilHydricVolume = value; }
        }

        public Double TotalEvapotranspirationCropFromLastWaterInput
        {
            get { return totalEvapotranspirationCropFromLastWaterInput; }
            set { totalEvapotranspirationCropFromLastWaterInput = value; }
        }

        public Double CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }

        public String Observations
        {
            get { return observations; }
            set { observations = value; }
        }

        #endregion

        #region Totals

        public Double TotalEvapotranspirationCrop
        {
            get { return totalEvapotranspirationCrop; }
            set { totalEvapotranspirationCrop = value; }
        }

        public Double TotalEffectiveRain
        {
            get { return totalEffectiveRain; }
            set { totalEffectiveRain = value; }
        }

        public Double TotalRealRain
        {
            get { return totalRealRain; }
            set { totalRealRain = value; }
        }

        public Double TotalIrrigation
        {
            get { return totalIrrigation; }
            set { totalIrrigation = value; }
        }

        public Double TotalIrrigationInHydricBalance
        {
            get { return totalIrrigationInHydricBalance; }
            set { totalIrrigationInHydricBalance = value; }
        }

        public Double TotalExtraIrrigation
        {
            get { return totalExtraIrrigation; }
            set { totalExtraIrrigation = value; }
        }

        public Double TotalExtraIrrigationInHydricBalance
        {
            get { return totalExtraIrrigationInHydricBalance; }
            set { totalExtraIrrigationInHydricBalance = value; }
        }

        #endregion

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public DailyRecord() 
        {
            this.DailyRecordId = 0;
            this.DailyRecordDateTime = Utils.MIN_DATETIME;

            this.CropIrrigationWeatherId = 0;

            this.MainWeatherDataId = 0;
            this.AlternativeWeatherDataId = 0;

            this.DaysAfterSowing = 0;
            this.DaysAfterSowingModified = 0;

            this.GrowingDegreeDays = 0;
            this.GrowingDegreeDaysAccumulated = 0;
            this.GrowingDegreeDaysModified = 0;
            this.LastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;

            this.RainId = 0;
            this.IrrigationId = 0;
            this.LastWaterInputDate = Utils.MIN_DATETIME;
            this.LastBigWaterInputDate = Utils.MIN_DATETIME;
            this.LastPartialWaterInputDate = Utils.MIN_DATETIME;
            this.LastPartialWaterInput = 0;
            this.LastBigGapWaterInputDate = Utils.MIN_DATETIME;

            this.EvapotranspirationCropId = 0;

            this.PhenologicalStageId = 0;
            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;
            this.CropCoefficient = 0;
            this.Observations= "";

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.TotalIrrigationInHydricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHydricBalance = 0;

        }


        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pDailyRecordDateTime"></param>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pMainWeatherDataId"></param>
        /// <param name="pAlternativeWeatherDataId"></param>
        /// <param name="pDaysAfterSowing"></param>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <param name="pGrowingDegreeDays"></param>
        /// <param name="pGrowingDegreeDaysAccumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <param name="pRainId"></param>
        /// <param name="pIrrigationId"></param>
        /// <param name="pLastWaterInputDate"></param>
        /// <param name="pLastBigWaterInputDate"></param>
        /// <param name="pLastPartialWaterInputDate"></param>
        /// <param name="pLastPartialWaterInput"></param>
        /// <param name="pLastBigGapWaterInputDate"></param>
        /// <param name="pEvapotranspirationCrop"></param>
        /// <param name="pPhenologicalStageId"></param>
        /// <param name="pHydricBalance"></param>
        /// <param name="pSoilHydricVolume"></param>
        /// <param name="pTotalEvapotranspirationFromLastWaterInput"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pObservations"></param>
        public DailyRecord(DateTime pDailyRecordDateTime, long pCropIrrigationWeatherId,
                            long pMainWeatherDataId, long pAlternativeWeatherDataId,
                            int pDaysAfterSowing, int pDaysAfterSowingModified,
                            Double pGrowingDegreeDays, Double pGrowingDegreeDaysAccumulated, Double pGrowingDegreeDaysModified, 
                            DateTime pLastDayOfGrowingDegreeDays,
                            long pRainId, long pIrrigationId,
                            DateTime pLastWaterInputDate, DateTime pLastBigWaterInputDate,
                            DateTime pLastPartialWaterInputDate, Double pLastPartialWaterInput, 
                            DateTime pLastBigGapWaterInputDate,
                            EvapotranspirationCrop pEvapotranspirationCrop, long pPhenologicalStageId,
                            Double pHydricBalance, Double pSoilHydricVolume, Double pTotalEvapotranspirationFromLastWaterInput,
                            Double pCropCoefficient, String pObservations) 
        {
            this.DailyRecordDateTime = pDailyRecordDateTime;

            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;

            this.MainWeatherDataId = pMainWeatherDataId;
            this.AlternativeWeatherDataId = pAlternativeWeatherDataId;

            this.DaysAfterSowing = pDaysAfterSowing;
            this.DaysAfterSowingModified = pDaysAfterSowingModified;

            this.GrowingDegreeDays = pGrowingDegreeDays;
            this.GrowingDegreeDaysAccumulated = pGrowingDegreeDaysAccumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;
            this.LastDayOfGrowingDegreeDays = pLastDayOfGrowingDegreeDays;

            this.RainId = pRainId;
            this.IrrigationId = pIrrigationId;
            this.LastWaterInputDate = pLastWaterInputDate;
            this.LastBigWaterInputDate = pLastBigWaterInputDate;
            this.LastPartialWaterInputDate = pLastPartialWaterInputDate;
            this.LastPartialWaterInput = pLastPartialWaterInput;
            this.LastBigGapWaterInputDate = pLastBigGapWaterInputDate;

            this.EvapotranspirationCropId = pEvapotranspirationCrop.WaterOutputId;
            this.EvapotranspirationCrop = pEvapotranspirationCrop;

            this.PhenologicalStageId = pPhenologicalStageId;
            this.HydricBalance = pHydricBalance;
            this.SoilHydricVolume = pSoilHydricVolume;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationFromLastWaterInput;
            this.CropCoefficient = pCropCoefficient;
            this.Observations = pObservations;

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.TotalIrrigationInHydricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHydricBalance = 0;

        }
        
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        //TODO DailyRecord - public methods
        ///     - GetBaseTemperature(): double
        ///     - getDailyAverageTemperature(): double
        ///     - GetEvapotranspiration(): double
        ///     - getCropCoefficient(): double
        ///     - GetEffectiveRain(Region, lRainItem:double, Date): double
        #endregion

        #region Overrides


        public override string ToString()
        {
            string lEvapotranspirationCrop = "       ";
            
            if (this.EvapotranspirationCrop != null)
            {
                lEvapotranspirationCrop = this.EvapotranspirationCrop.GetTotalOutput().ToString() + "          ";
            }
            string lRain = "       ";
            string lIrrigation = "       ";
            int index = 5;
            if (this.Rain != null)
            {
                lRain = this.Rain.GetTotalInput().ToString() + "           ";

            } 
            if (this.Irrigation != null)
            {
                lIrrigation = this.Irrigation.GetTotalInput().ToString() + "           ";

            }
            string lReturn = 
                "Fecha: " + this.DailyRecordDateTime.ToString() + "\t\t" +
                "G.Dia: " + this.GrowingDegreeDays + "\t\t" +
                "ETc:" + lEvapotranspirationCrop.Substring(0,index) + "\t\t" +
                "Lluvia: " + lRain.Substring(0, index) + "\t\t" +
                "Riego:" + lIrrigation.Substring(0, index) + "\t\t" +
                "KC:" + this.CropCoefficient + "\t\t" +
                "Obs:  " + this.Observations + "\t\t";
            return lReturn;

        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            DailyRecord lDailyRecord = obj as DailyRecord;
            return this.DailyRecordDateTime.Date.Equals(lDailyRecord.DailyRecordDateTime.Date);
        }

        public override int GetHashCode()
        {
            return this.Observations.GetHashCode();
        }

        #endregion


    }
}