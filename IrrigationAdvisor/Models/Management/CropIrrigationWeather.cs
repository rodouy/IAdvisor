using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.DBContext;
using System.Data.Entity;
using NLog;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-10-27
    /// Author:  monicarle
    /// Modified: 2015-01-08
    /// Author:  monicarle
    /// Modified: 2015-11-08
    /// Author:  rodouy
    /// Description: 
    ///     Is the fusion of: a WheatherStation, a Crop and an IrrigationUnit
    ///     
    /// References:
    ///     IrrigationUnit
    ///     Crop
    ///     WheatherStation
    ///     PhenologicalStage
    ///     Soil
    ///     
    /// 
    /// Dependencies:
    ///     DailyRecord
    ///     IrrigationRecords
    ///     IrrigationCalculus
    ///     IrrigationForecast
    /// 
    /// TODO:
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - irrigationUnit IrrigationUnit - PK
    ///     - crop Crop                     - PK
    ///     - mainWeatherStation WeatherStation
    ///     - alternativeWeatherStation WeatherStation
    ///     - CropIrrigationWeatherRecordList  List<CropIrrigationWeatherRecord> 
    ///     - phenologicalStage PhenologicalStage
    ///     - sowingDate DateTime
    ///     - harvestDate DateTime
    ///     - soil Soil
    /// 
    /// Methods:
    ///     - CropIrrigationWeather()      -- constructor
    ///     - CropIrrigationWeather(irrigationUnit, crop, mainWeatherStation, alternativeWeatherStation,
    ///     )  -- consturctor with parameters
    ///     - GetRegion(): Region
    ///     - GetDaysAfterSowing(): int
    ///     - GetBaseTemperature(): double
    ///     - GetMaxEvapotranspirationToIrrigate(): double
    ///     - GetRootDepth(): double
    ///     - GetSoilPermanentWiltingPoint(): double
    ///     - GetSoilAvailableWaterCapacity(): double
    ///     - GetSoilFieldCapacity(): double
    ///     - GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint(): double
    ///     
    /// 
    /// </summary>
    public class CropIrrigationWeather
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - cropId: long
        ///     - soilId: long
        ///     - sowingDate: DateTime
        ///     - harvestDate: DateTime
        ///     - cropDate: DateTime
        ///     - phenologicalStageId: long
        ///     - hydricBalance: Double
        ///     - soilHydricVolume: Double
        ///     - totalEvapotranspirationCropFromLastWaterInput: Double
        ///     - calculusMethodForPhenologicalAdjustment: Utils.CalculusOfPhenologicalStage 
        ///     - cropInformationByDateId: long
        ///     - dayAfterSowing: int
        ///     - dayAfterSowingModified: int
        ///     - growingDegreeDaysAccumulated: Double
        ///     - growingDegreeDaysModified: Double
        ///     
        ///     - irrigationUnitId: long
        ///     - predeterminatedIrrigationQuantity: Double
        ///     - positionId: long
        ///     
        ///     - mainWeatherStation: WeatherStation
        ///     - alternativeWeatherStation: WeatherStation
        /// </summary>

        private long cropIrrigationWeatherId;
        private String cropIrrigationWeatherName;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #region Agriculture

        private long cropId;
        private long soilId;
        
        #region Data of Crop

        private Double density;
        private DateTime sowingDate;
        private DateTime harvestDate;
        private DateTime cropDate;
        private DateTime startAdvisorDate;
        //2016-10-19
        //DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING
        private int daysForHydricBalanceUnchangableAfterSowing;

        #endregion

        #region Crop State

        private long phenologicalStageId;
        private Double hydricBalance;
        private Double soilHydricVolume;
        private Double totalEvapotranspirationCropFromLastWaterInput;
        private List<PhenologicalStageAdjustment> phenologicalStageAdjustmentList;

        #endregion

        #region Calculus of Phenological Adjustment

        private Utils.CalculusOfPhenologicalStage calculusMethodForPhenologicalAdjustment;
        private long cropInformationByDateId;
        private int dayAfterSowing;
        private int dayAfterSowingModified;
        private Double growingDegreeDaysAccumulated;
        private Double growingDegreeDaysModified;
        //Refactroing 2017/09/14 Changes in Phenological Table: Add GrowingDegreeDaysExtraGap
        private Double growingDegreeDaysExtraGap;
        private DateTime lastDayOfGrowingDegreeDays;

        #endregion

        #endregion

        #region Irrigation

        private long irrigationUnitId;
        private Double maxIrrigationQuantity;
        private bool adjustableIrrigationQuantity;
        private Double predeterminatedIrrigationQuantity;
        private bool hasAdviseOfIrrigation;

        #endregion

        #region Localization

        private long positionId;

        #endregion

        #region Water

        private List<Rain> rainList;
        private List<Water.Irrigation> irrigationList;
        private List<EvapotranspirationCrop> evapotranspirationCropList;
        
        #endregion

        #region Output Water Data
        private DateTime lastWaterInputDate;
        private DateTime lastBigWaterInputDate;
        private DateTime lastPartialWaterInputDate;
        private Double lastPartialWaterInput;
        private DateTime lastBigGapWaterInputDate;

        #endregion

        #region Weather

        private long mainWeatherStationId;
        private long alternativeWeatherStationId;
        private bool usingMainWeatherStation;
        private Utils.WeatherEventType weatherEventType;

        #endregion
        
        #region Daily Data

        private List<DailyRecord> dailyRecordList;

        #endregion

        #region Totals
        
        private Double totalEvapotranspirationCrop;
        private Double totalEffectiveRain;
        private Double totalRealRain;
        private Double totalIrrigation;
        private Double totalIrrigationInHydricBalance;
        private Double totalExtraIrrigation;
        private Double totalExtraIrrigationInHydricBalance;

        #endregion

        #region Extra Print Data

        private String outPut;

        private List<Title> titles;
        private List<Message> messages;
        private long totalMessageLines;
        private List<Title> titlesDaily;
        private List<Message> messagesDaily;
        private long totalMessageDailyLines;
        
        private String textLog;
        
        #endregion

        #endregion

        #region Properties

        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
        }

        public String CropIrrigationWeatherName
        {
            get { return cropIrrigationWeatherName; }
            set { cropIrrigationWeatherName = value; }
        }

        #region Agriculture

        public long CropId
        {
            get { return cropId; }
            set { cropId = value; }
        }

        public virtual Crop Crop
        {
            get;
            set;
        }

        public long SoilId
        {
            get { return soilId; }
            set { soilId = value; }
        }

        public virtual Soil Soil
        {
            get;
            set;
        }

        #region Data of Crop

        public Double Density
        {
            get { return density; }
            set { density = value; }
        }

        public DateTime SowingDate
        {
            get { return sowingDate; }
            set { sowingDate = value; }
        }

        public DateTime HarvestDate
        {
            get { return harvestDate; }
            set { harvestDate = value; }
        }

        public DateTime CropDate
        {
            get { return cropDate; }
            set { cropDate = value; }
        }
        
        public DateTime StartAdvisorDate
        {
          get { return startAdvisorDate; }
          set { startAdvisorDate = value; }
        }

        public int DaysForHydricBalanceUnchangableAfterSowing
        {
            get { return daysForHydricBalanceUnchangableAfterSowing; }
            set { daysForHydricBalanceUnchangableAfterSowing = value; }
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

        public List<PhenologicalStageAdjustment> PhenologicalStageAdjustmentList
        {
            get { return phenologicalStageAdjustmentList; }
            set { phenologicalStageAdjustmentList = value; }
        }

        #endregion

        #region Calculus of Phenological Adjustment

        public Utils.CalculusOfPhenologicalStage CalculusMethodForPhenologicalAdjustment
        {
            get { return calculusMethodForPhenologicalAdjustment; }
            set { calculusMethodForPhenologicalAdjustment = value; }
        }

        public long CropInformationByDateId
        {
            get { return cropInformationByDateId; }
            set { cropInformationByDateId = value; }
        }

        public virtual CropInformationByDate CropInformationByDate
        {
            get;
            set;
        }

        public int DaysAfterSowing
        {
            get { return dayAfterSowing; }
            set { dayAfterSowing = value; }
        }

        public int DaysAfterSowingModified
        {
            get { return dayAfterSowingModified; }
            set { dayAfterSowingModified = value; }
        }

        public double GrowingDegreeDaysAccumulated
        {
            get { return growingDegreeDaysAccumulated; }
            set { growingDegreeDaysAccumulated = value; }
        }

        public double GrowingDegreeDaysModified
        {
            get { return growingDegreeDaysModified; }
            set { growingDegreeDaysModified = value; }
        }

        public double GrowingDegreeDaysExtraGap
        {
            get { return growingDegreeDaysExtraGap; }
            set { growingDegreeDaysExtraGap = value; }
        }
        

        public DateTime LastDayOfGrowingDegreeDays
        {
            get { return lastDayOfGrowingDegreeDays; }
            set { lastDayOfGrowingDegreeDays = value; }
        }
        
        #endregion
        
        #endregion

        #region Irrigation

        public long IrrigationUnitId
        {
            get { return irrigationUnitId; }
            set { irrigationUnitId = value; }
        }

        public virtual IrrigationUnit IrrigationUnit
        {
            get;
            set;
        }

        public Double MaxIrrigationQuantity
        {
            get { return maxIrrigationQuantity; }
            set { maxIrrigationQuantity = value; }
        }

        public bool AdjustableIrrigationQuantity
        {
            get { return adjustableIrrigationQuantity; }
            set { adjustableIrrigationQuantity = value; }
        }

        public Double PredeterminatedIrrigationQuantity
        {
            get { return predeterminatedIrrigationQuantity; }
            set { predeterminatedIrrigationQuantity = value; }
        }

        public bool HasAdviseOfIrrigation
        {
            get { return hasAdviseOfIrrigation; }
            set { hasAdviseOfIrrigation = value; }
        }
        
        #endregion

        #region Localization

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public virtual Position Position
        {
            get;
            set;
        }
        
        #endregion

        #region Water
        
        public List<Rain> RainList
        {
            get { return rainList; }
            set { rainList = value; }
        }

        public List<Water.Irrigation> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }

        public List<EvapotranspirationCrop> EvapotranspirationCropList
        {
            get { return evapotranspirationCropList; }
            set { evapotranspirationCropList = value; }
        }

        #region Output Water Data

        /// <summary>
        /// Date of Rain bigger than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
        /// </summary>
        public DateTime LastWaterInputDate
        {
            get { return lastWaterInputDate; }
            set { lastWaterInputDate = value; }
        }

        /// <summary>
        /// Date of Rain that make the Hydric Balance bigger than Field Capacity
        /// </summary>
        public DateTime LastBigWaterInputDate
        {
            get { return lastBigWaterInputDate; }
            set { lastBigWaterInputDate = value; }
        }

        /// <summary>
        /// Date of Rain smaller than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
        /// </summary>
        public DateTime LastPartialWaterInputDate
        {
            get { return lastPartialWaterInputDate; }
            set { lastPartialWaterInputDate = value; }
        }

        /// <summary>
        /// Rain smaller than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
        /// </summary>
        public Double LastPartialWaterInput
        {
            get { return lastPartialWaterInput; }
            set { lastPartialWaterInput = value; }
        }

        /// <summary>
        /// Date of last big Gap of Hydric Balance between two days
        /// </summary>
        public DateTime LastBigGapWaterInputDate
        {
            get { return lastBigGapWaterInputDate; }
            set { lastBigGapWaterInputDate = value; }
        }

        
        #endregion

        #endregion

        #region Weather

        public long MainWeatherStationId
        {
            get { return mainWeatherStationId; }
            set { mainWeatherStationId = value; }
        }

        public virtual WeatherStation MainWeatherStation
        {
            get;
            set;
        }

        public long AlternativeWeatherStationId
        {
            get { return alternativeWeatherStationId; }
            set { alternativeWeatherStationId = value; }
        }

        public WeatherStation AlternativeWeatherStation
        {
            get;
            set;
        }

        public bool UsingMainWeatherStation
        {
            get { return usingMainWeatherStation; }
            set { usingMainWeatherStation = value; }
        }

        public Utils.WeatherEventType WeatherEventType
        {
            get { return weatherEventType; }
            set { weatherEventType = value; }
        }

        #endregion

        #region Daily Data

        public List<DailyRecord> DailyRecordList
        {
            get { return dailyRecordList; }
            set { dailyRecordList = value; }
        }

        #endregion

        #region Totals

        /// <summary>
        /// Total Evapotranspiration of Crop
        /// </summary>
        public Double TotalEvapotranspirationCrop
        {
            get { return totalEvapotranspirationCrop; }
            set { totalEvapotranspirationCrop = value; }
        }

        /// <summary>
        /// Total Effective Rain
        /// </summary>
        public Double TotalEffectiveRain
        {
            get { return totalEffectiveRain; }
            set { totalEffectiveRain = value; }
        }

        /// <summary>
        /// Total Real Rain
        /// </summary>
        public Double TotalRealRain
        {
            get { return totalRealRain; }
            set { totalRealRain = value; }
        }

        /// <summary>
        /// Total Irrigation
        /// </summary>
        public Double TotalIrrigation
        {
            get { return totalIrrigation; }
            set { totalIrrigation = value; }
        }

        /// <summary>
        /// Total Irrigation in Hydric Balance
        /// </summary>
        public Double TotalIrrigationInHydricBalance
        {
            get { return totalIrrigationInHydricBalance; }
            set { totalIrrigationInHydricBalance = value; }
        }

        /// <summary>
        /// Total Extra Irrigation
        /// </summary>
        public Double TotalExtraIrrigation
        {
            get { return totalExtraIrrigation; }
            set { totalExtraIrrigation = value; }
        }

        /// <summary>
        /// Total Extra Irrigation in Hydric Balance
        /// </summary>
        public Double TotalExtraIrrigationInHydricBalance
        {
            get { return totalExtraIrrigationInHydricBalance; }
            set { totalExtraIrrigationInHydricBalance = value; }
        }

        #endregion

        #region Extra Print Data

        public String OutPut
        {
            get { return outPut; }
            set { outPut = value; }
        }

        public List<Title> Titles
        {
            get { return titles; }
            set { titles = value; }
        }

        public List<Message> Messages
        {
            get { return messages; }
            set { messages = value; }
        }

        public long TotalMessageLines
        {
            get { return totalMessageLines; }
            set { totalMessageLines = value; }
        }

        public List<Title> TitlesDaily
        {
            get { return titlesDaily; }
            set { titlesDaily = value; }
        }

        public List<Message> MessagesDaily
        {
            get { return messagesDaily; }
            set { messagesDaily = value; }
        }

        public long TotalMessageDailyLines
        {
            get { return totalMessageDailyLines; }
            set { totalMessageDailyLines = value; }
        }

        public String TextLog
        {
            get { return textLog; }
            set { textLog = value; }
        }

        #endregion

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// PredeterminatedIrrigationQuantity = 20
        /// </summary>
        public CropIrrigationWeather() 
        {
            this.CropIrrigationWeatherId = 0;
            this.CropIrrigationWeatherName = "";
            
            #region Crop Information
            this.CropId = 0;
            this.SoilId = 0;

            this.Density = 0;
            this.SowingDate = Utils.MIN_DATETIME;
            this.HarvestDate = Utils.MIN_DATETIME;
            this.CropDate = Utils.MIN_DATETIME;
            this.StartAdvisorDate = Utils.MIN_DATETIME;

            this.DaysForHydricBalanceUnchangableAfterSowing = 0;
            #endregion

            #region Crop State
            this.PhenologicalStageId = 0;
            this.HydricBalance = 0;
            this.SoilHydricVolume = 0;
            this.TotalEvapotranspirationCropFromLastWaterInput = 0;
            this.PhenologicalStageAdjustmentList = new List<PhenologicalStageAdjustment>();
            #endregion

            #region Calculus of Phenological Adjustment
            this.calculusMethodForPhenologicalAdjustment = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing;
            this.CropInformationByDateId = 0;
            this.DaysAfterSowing = 1;
            this.DaysAfterSowingModified = 1;
            this.GrowingDegreeDaysAccumulated = 0;
            this.GrowingDegreeDaysModified = 0;
            this.GrowingDegreeDaysExtraGap = 0;
            this.LastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;
            #endregion

            #region Irrigation
            this.IrrigationUnitId = 0;
            this.MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart, 
                                         Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                  Utils.PredeterminatedIrrigationQuantity_ThirdPart));
            this.AdjustableIrrigationQuantity = true;
            this.PredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_FirstPart;
            this.HasAdviseOfIrrigation = false;
            #endregion

            #region Localization
            this.PositionId = 0;
            #endregion

            #region Water
            this.RainList = new List<Rain>();
            this.IrrigationList = new List<Water.Irrigation>();
            this.EvapotranspirationCropList = new List<EvapotranspirationCrop>();
            #endregion

            #region Output Water Data
            this.LastWaterInputDate = Utils.MIN_DATETIME;
            this.LastBigWaterInputDate = Utils.MIN_DATETIME;
            this.LastPartialWaterInputDate = Utils.MIN_DATETIME;
            this.LastPartialWaterInput = 0;
            this.LastBigGapWaterInputDate = Utils.MIN_DATETIME;
            #endregion

            #region Weather
            this.MainWeatherStationId = 0;
            this.AlternativeWeatherStationId = 0;
            this.UsingMainWeatherStation = true;
            this.WeatherEventType = Utils.WeatherEventType.None;
            #endregion

            #region Daily Data
            this.DailyRecordList = new List<DailyRecord>();
            #endregion

            #region Totals

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.totalIrrigationInHydricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHydricBalance = 0;
            
            #endregion


            #region Extra Print Data
            this.Titles = new List<Title>();
            this.Messages = new List<Message>();
            this.TotalMessageLines = 0;
            this.TitlesDaily = new List<Title>();
            this.MessagesDaily = new List<Message>();
            this.TotalMessageDailyLines = 0;

            this.outPut = printHeader();
            #endregion

        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pCropIrrigationWeatherName"></param>
        /// <param name="pCropId"></param>
        /// <param name="pSoilId"></param>
        /// <param name="pDensity"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pCropDate"></param>
        /// <param name="pStartAdvisorDate"></param>
        /// <param name="pPhenologicalStageId"></param>
        /// <param name="pHydricBalance"></param>
        /// <param name="pSoilHydricVolume"></param>
        /// <param name="pTotalEvapotranspirationCropFromLastWaterInput"></param>
        /// <param name="pPhenologicalStageAdjustmentList"></param>
        /// <param name="pCalculusMethodForPhenologicalAdjustment"></param>
        /// <param name="pCropInformationByDateId"></param>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pDayAfterSowingModified"></param>
        /// <param name="pGrowingDegreeDaysAcumulated"></param>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <param name="pGrowingDegreeDaysExtraGap"></param>
        /// <param name="pIrrigationUnitId"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pRainList"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pEvapotranspirationCropList"></param>
        /// <param name="pLastWaterInputDate"></param>
        /// <param name="pLastBigWaterInputDate"></param>
        /// <param name="pLastPartialWaterInputDate"></param>
        /// <param name="pLastPartialWaterInput"></param>
        /// <param name="pLastBigGapWaterInputDate"></param>
        /// <param name="pMainWeatherStationId"></param>
        /// <param name="pAlternativeWeatherStationId"></param>
        /// <param name="pUsingMainWeatherStation"></param>
        /// <param name="pWeatherEventType"></param>
        /// <param name="pDailyRecords"></param>
        public CropIrrigationWeather(long pCropIrrigationWeatherId, String pCropIrrigationWeatherName, long pCropId, long pSoilId, 
                                Double pDensity, DateTime pSowingDate, DateTime pHarvestDate, DateTime pCropDate, DateTime pStartAdvisorDate,
                                int pDaysForHydricBalanceUnchangableAfterSowing,
                                long pPhenologicalStageId, Double pHydricBalance, Double pSoilHydricVolume,
                                Double pTotalEvapotranspirationCropFromLastWaterInput,
                                List<PhenologicalStageAdjustment> pPhenologicalStageAdjustmentList,
                                Utils.CalculusOfPhenologicalStage pCalculusMethodForPhenologicalAdjustment,
                                long pCropInformationByDateId, int pDayAfterSowing, int pDayAfterSowingModified, 
                                Double pGrowingDegreeDaysAcumulated, Double pGrowingDegreeDaysModified, 
                                Double pGrowingDegreeDaysExtraGap, DateTime pLastDayOfGrowingDegreeDays,
                                long pIrrigationUnitId, Double pPredeterminatedIrrigationQuantity, long pPositionId,
                                List<Rain> pRainList, List<Water.Irrigation> pIrrigationList, 
                                List<EvapotranspirationCrop> pEvapotranspirationCropList,
                                DateTime pLastWaterInputDate, DateTime pLastBigWaterInputDate, 
                                DateTime pLastPartialWaterInputDate, Double pLastPartialWaterInput, DateTime pLastBigGapWaterInputDate,
                                long pMainWeatherStationId, long pAlternativeWeatherStationId, bool pUsingMainWeatherStation, 
                                Utils.WeatherEventType pWeatherEventType, List<DailyRecord> pDailyRecords)
        {
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
            this.CropIrrigationWeatherName = pCropIrrigationWeatherName;

            this.CropId = pCropId;
            this.SoilId = pSoilId;

            this.Density = pDensity;
            this.SowingDate = pSowingDate;
            this.HarvestDate = pHarvestDate;
            this.CropDate = pCropDate;
            this.StartAdvisorDate = pStartAdvisorDate;
            this.DaysForHydricBalanceUnchangableAfterSowing = pDaysForHydricBalanceUnchangableAfterSowing;

            this.PhenologicalStageId = pPhenologicalStageId;
            this.HydricBalance = pHydricBalance;
            this.SoilHydricVolume = pSoilHydricVolume;
            this.TotalEvapotranspirationCropFromLastWaterInput = pTotalEvapotranspirationCropFromLastWaterInput;
            this.PhenologicalStageAdjustmentList = pPhenologicalStageAdjustmentList;

            this.calculusMethodForPhenologicalAdjustment = pCalculusMethodForPhenologicalAdjustment;
            if(pCalculusMethodForPhenologicalAdjustment == Utilities.Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing)
            {
                this.CropInformationByDateId = pCropInformationByDateId;
            }
            if(pCalculusMethodForPhenologicalAdjustment == Utilities.Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays)
            {
                this.CropInformationByDateId = 0;
            }
            this.DaysAfterSowing = pDayAfterSowing;
            this.DaysAfterSowingModified = pDayAfterSowingModified;
            this.GrowingDegreeDaysAccumulated = pGrowingDegreeDaysAcumulated;
            this.GrowingDegreeDaysModified = pGrowingDegreeDaysModified;
            this.GrowingDegreeDaysExtraGap = pGrowingDegreeDaysExtraGap;
            this.LastDayOfGrowingDegreeDays = pLastDayOfGrowingDegreeDays;

            this.IrrigationUnitId = pIrrigationUnitId;
            this.MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                         Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                  Utils.PredeterminatedIrrigationQuantity_ThirdPart));
            this.AdjustableIrrigationQuantity = true;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            this.HasAdviseOfIrrigation = false;

            this.PositionId = pPositionId;
            
            this.RainList = pRainList;
            this.IrrigationList = pIrrigationList;
            this.EvapotranspirationCropList = pEvapotranspirationCropList;

            this.LastWaterInputDate = pLastWaterInputDate;
            this.LastBigWaterInputDate = pLastBigWaterInputDate;
            this.LastPartialWaterInputDate = pLastPartialWaterInputDate;
            this.LastPartialWaterInput = pLastPartialWaterInput;
            this.LastBigGapWaterInputDate = pLastBigGapWaterInputDate;

            this.MainWeatherStationId = pMainWeatherStationId;
            this.AlternativeWeatherStationId = pAlternativeWeatherStationId;
            this.UsingMainWeatherStation = pUsingMainWeatherStation;
            this.WeatherEventType = pWeatherEventType;

            this.DailyRecordList = pDailyRecords;

            this.TotalEvapotranspirationCrop = 0;
            this.TotalEffectiveRain = 0;
            this.TotalRealRain = 0;
            this.TotalIrrigation = 0;
            this.TotalIrrigationInHydricBalance = 0;
            this.TotalExtraIrrigation = 0;
            this.TotalExtraIrrigationInHydricBalance = 0;
            
            this.Titles = new List<Title>();
            this.Messages = new List<Message>();
            this.TotalMessageLines = 0;
            this.TitlesDaily = new List<Title>();
            this.MessagesDaily = new List<Message>();
            this.TotalMessageDailyLines = 0;
            this.outPut = "";

        }
        
        #endregion

        #region Private Helpers

        #region Water
        /// <summary>
        /// Return the effectiveness of a Rain depending on:
        ///  the amount of rain, 
        ///  the month of the year.
        /// This information is stored as a percentage in a field called EffectiveRainList that is a List of EffectiveRain
        /// </summary>
        /// <param name="pRain"></param>
        /// <returns></returns>
        private Double getEffectiveRainValue(WaterInput pRain)
        {
            Double lReturn = 0;
            IEnumerable<EffectiveRain> lEffectiveRainListOrderByMonth = null;
            Double lRainTotalInput = 0;

            if (pRain != null)
            {
                lEffectiveRainListOrderByMonth = this.GetCropRegion().EffectiveRainList.OrderBy(lEffectiveRain => lEffectiveRain.Month);
                foreach (EffectiveRain lEffectiveRain in lEffectiveRainListOrderByMonth)
                {
                    lRainTotalInput = pRain.GetTotalInput();
                    if (lEffectiveRain.Month == pRain.Date.Month 
                        && lEffectiveRain.MinRain <= lRainTotalInput
                        && lEffectiveRain.MaxRain >= lRainTotalInput)
                    {
                        
                        lReturn = lRainTotalInput * lEffectiveRain.Percentage / 100;
                        break;
                    }
                }
            }
            return lReturn; 
        }
        
        /// <summary>
        /// Make the Irrigation adjustment
        /// Return the Effective Irrigation added to Hydric Balance
        /// </summary>
        /// <param name="pDailyRecord"></param>
        /// <param name="pFieldCapacity"></param>
        /// <returns></returns>
        private Double irrigationAdjustment(DailyRecord pDailyRecord, Double pFieldCapacity)
        {
            Double lReturn;
            Double lEffectiveIrrigation = 0;
            Double lEffectiveIrrigationExtra = 0;
            Double lEffectiveIrrigationTotal = 0;
            Double lIrrigationEfficiency = 0;
            Double lAmountOfIrrigationNotUsed = 0;
            int lDaysBetweenIrrigations = 0;
            Double lEffectiveRain = 0;
            Double lEffectiveInputWaterFromLastDays = 0;

            if (pDailyRecord.Rain != null)
            {
                lEffectiveRain = this.getEffectiveRainValue(pDailyRecord.Rain);
                if(lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    lEffectiveRain = 0;
                }
            }

            if (pDailyRecord.Irrigation != null)
            {
                lDaysBetweenIrrigations = Utilities.Utils.GetDaysDifference(this.LastPartialWaterInputDate, pDailyRecord.DailyRecordDateTime);

                // Calculate de effective Irrigation depending on the irrigation efficiency of the Pivot
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;

                //Effective Irrigation
                lEffectiveIrrigation = pDailyRecord.Irrigation.Input * lIrrigationEfficiency;
                lEffectiveIrrigationExtra = pDailyRecord.Irrigation.ExtraInput * lIrrigationEfficiency;
                lEffectiveIrrigationTotal = lEffectiveIrrigation + lEffectiveIrrigationExtra;

                this.TotalIrrigation += lEffectiveIrrigation;
                this.TotalIrrigationInHydricBalance += lEffectiveIrrigation;

                this.TotalExtraIrrigation += lEffectiveIrrigationExtra;
                this.TotalExtraIrrigationInHydricBalance += lEffectiveIrrigationExtra;

                //Add to Hydric Balance the lIrrigationItem calculated (Output) and the extra lIrrigationItem (ExtraOutput) 
                this.HydricBalance += lEffectiveIrrigationTotal;

                //Add the total Effective input of Water to the list
                pDailyRecord.TotalEffectiveInputWater = lEffectiveIrrigationTotal;

                // If the lIrrigationItem is bigger than 5 mm set the last water output
                if (lEffectiveIrrigationTotal > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                    this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water output
                else if (lDaysBetweenIrrigations <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    //for last day to DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT, see if the input water is bigger than CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED
                    for (int lDay = 1; lDay < InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT; lDay++)
                    {
                        lEffectiveInputWaterFromLastDays = this.getEffectiveInputWaterFromLastDays(lDay);
                        if ((lEffectiveIrrigationTotal + lEffectiveInputWaterFromLastDays)
                                                            > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED_BY_DAYS)
                        {
                            this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                            this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                            //This irrigation is the last Partial Water
                            this.LastPartialWaterInput = lEffectiveIrrigationTotal + lEffectiveRain;
                            this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                        }
                        else 
                        {
                            lEffectiveIrrigationTotal += lEffectiveInputWaterFromLastDays;
                        }
                    }
                }
                else //Registry the effective lIrrigationItem and its date as a PartialWaterInput
                {
                    this.LastPartialWaterInput = lEffectiveIrrigationTotal + lEffectiveRain;
                    this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }

                // If HydricBalance is bigger than FieldCapacity set HydricBalance equals to FieldCapacity  
                // And take off the Irrigation not used from TotalIrrigation and/or TotalExtraIrrigation
                if (this.HydricBalance > pFieldCapacity)
                {
                    lAmountOfIrrigationNotUsed = this.HydricBalance - pFieldCapacity;
                    this.HydricBalance = pFieldCapacity;

                    //We can take all off from Effective Irrigatin
                    if (lEffectiveIrrigation >= lAmountOfIrrigationNotUsed)
                    {
                        this.TotalIrrigationInHydricBalance -= lAmountOfIrrigationNotUsed;
                    }
                        //We can take all off from Effective Extra Irrigation
                    else if (lEffectiveIrrigationExtra >= lAmountOfIrrigationNotUsed)
                    {
                        this.TotalExtraIrrigationInHydricBalance -= lAmountOfIrrigationNotUsed;
                    }
                        //We have to take off from Effective Irrigation and from Effective Extra irrigation
                    else
                    {
                        this.TotalIrrigationInHydricBalance -= lEffectiveIrrigation;
                        lAmountOfIrrigationNotUsed -= lEffectiveIrrigation;
                        this.TotalExtraIrrigationInHydricBalance -= lAmountOfIrrigationNotUsed;
                    }
                }

            }

            lReturn = lEffectiveIrrigationTotal - lAmountOfIrrigationNotUsed;
            return lReturn;
        }
        
        /// <summary>
        /// Make the Rain adjustment
        /// Return the Effective Rain added to Hydric Balance
        /// </summary>
        /// <param name="pDailyRecord"></param>
        /// <param name="pFieldCapacity"></param>
        /// <returns></returns>
        private Double rainAdjustment(DailyRecord pDailyRecord, Double pFieldCapacity)
        {
            Double lReturn;
            Double lRealRain = 0;
            Double lTotalEffectiveRain = 0;
            Double lEffectiveRain = 0;
            Double lAmountOfRainNotUsed = 0;
            int lDaysBetweenRains = 0;
            Double lEffectiveIrrigationTotal = 0;
            Double lIrrigationEfficiency = 0;
            Double lEffectiveInputWaterFromLastDays = 0;
            
            if(pDailyRecord.Irrigation != null)
            {
                lIrrigationEfficiency = this.IrrigationUnit.IrrigationEfficiency;
                lEffectiveIrrigationTotal = pDailyRecord.Irrigation.GetTotalInput() * lIrrigationEfficiency;

                if(lEffectiveIrrigationTotal > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    lEffectiveIrrigationTotal = 0;
                }
            }

            if (pDailyRecord.Rain != null)
            {
                lDaysBetweenRains = Utilities.Utils.GetDaysDifference(this.LastPartialWaterInputDate, pDailyRecord.DailyRecordDateTime);

                lRealRain = pDailyRecord.Rain.GetTotalInput();
                //Calculate Rain Effective Value
                lEffectiveRain = this.getEffectiveRainValue(pDailyRecord.Rain);
                this.TotalEffectiveRain += lEffectiveRain;
                this.TotalRealRain += lRealRain;
                this.HydricBalance += lEffectiveRain;

                // If the effective lRainItem is bigger than 5 mm then set the last water output
                if (lEffectiveRain > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                    this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                // If two "partial" water inputs, between 3 days, are bigger than 10 mm then set the last water output
                else if (lDaysBetweenRains <= InitialTables.DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT)
                {
                    if (lEffectiveRain + this.LastPartialWaterInput > InitialTables.CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED_BY_DAYS)
                    {
                        this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                        this.LastWaterInputDate = pDailyRecord.DailyRecordDateTime;
                        //This rain is the last Partial Water
                        this.LastPartialWaterInput = lEffectiveRain;
                        this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                    }
                }
                else //Registry the effective Rain and its date as a PartialWaterInput
                {
                    this.LastPartialWaterInput = lEffectiveRain;
                    this.LastPartialWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                
                // If the HydricBalance is bigger than the FieldCapacity set the HydricBalance as de FieldCapacity and take off the lRainItem not used -> total lRainItem
                if (this.HydricBalance >= pFieldCapacity)
                {
                    //Rains higher than 3 mm do consider as BigWaterInput
                    if (lRealRain > InitialTables.MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT_AFTER_REACH_FIELD_CAPACITY)
                    {
                        //We have to save the date to keep the hydric balance unchangable
                        this.LastBigWaterInputDate = pDailyRecord.DailyRecordDateTime;
                    }

                    //Take off the Rain not used in Total Effective Rain 
                    //because (HydricBalanc + Rain) is bigger than FieldCapacity
                    lAmountOfRainNotUsed = this.HydricBalance - pFieldCapacity;
                    this.HydricBalance = pFieldCapacity;
                    this.TotalEffectiveRain -= lAmountOfRainNotUsed;
                }
                //Rains higher than 50 mm do consider as BigWaterInput
                else if (lRealRain >= InitialTables.MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT)
                {
                    //We have to save the date to keep the hydric balance unchangable
                    this.LastBigWaterInputDate = pDailyRecord.DailyRecordDateTime;
                }
                //If rains between 3 days (DAYS_BETWEEN_TWO_BIG_WATER_INPUT_BY_RAIN) are bigger than MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT 50 mm then set LastBigWaterInputDate
                else if (lDaysBetweenRains <= InitialTables.DAYS_BETWEEN_TWO_BIG_WATER_INPUT_BY_RAIN)
                {
                    lTotalEffectiveRain = lEffectiveRain;
                    //for last day to DAYS_BETWEEN_TWO_BIG_WATER_INPUT_BY_RAIN, see if the input water is bigger than MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT
                    for (int lDay = 1; lDay < InitialTables.DAYS_BETWEEN_TWO_BIG_WATER_INPUT_BY_RAIN; lDay++)
                    {
                        lEffectiveInputWaterFromLastDays = this.getEffectiveRainFromLastDays(lDay);
                        if ((lTotalEffectiveRain + lEffectiveInputWaterFromLastDays)
                                                            >= InitialTables.MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT)
                        {
                            //We have to save the date to keep the hydric balance unchangable
                            this.LastBigWaterInputDate = pDailyRecord.DailyRecordDateTime;
                        }
                        else
                        {
                            lTotalEffectiveRain += lEffectiveInputWaterFromLastDays;
                        }
                    }
                }
            }

            lReturn = lEffectiveRain - lAmountOfRainNotUsed;
            return lReturn;
        }
        
        #endregion

        #region DailyRecord

        /// <summary>
        /// Get the first DailyRecord from the list order by date with the  Growing Degree Days Accumulated
        /// greater or equals than the parameter degrees.
        /// If is it not find, return null.
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByGrowingDegreeDaysAccumulated(Double pGrowingDegreeDays)
        {
            DailyRecord lRetrun = null;
            DailyRecord lDailyRecordByGrowingDegreeDaysAccumulated = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pGrowingDegreeDays >= 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecordItem in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (pGrowingDegreeDays <= lDailyRecordItem.GrowingDegreeDaysAccumulated)
                    {
                        lDailyRecordByGrowingDegreeDaysAccumulated = lDailyRecordItem;
                        break;
                    }
                }
            }

            lRetrun = lDailyRecordByGrowingDegreeDaysAccumulated;
            return lRetrun;
        }

        /// <summary>
        /// Get the first DailyRecord from the list order by date with the Days After Sowing 
        /// greater or equals than the parameter days.
        /// If is it not find, return null.
        /// </summary>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <returns></returns>
        private DailyRecord getDailyRecordByDaysAfterSowingAccumulated(int pDaysAfterSowing)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pDaysAfterSowing >= 0)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecord in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (pDaysAfterSowing <= lDailyRecord.DaysAfterSowing)
                    {
                        lRetrun = lDailyRecord;
                        break;
                    }
                }
            }

            return lRetrun;
        }
        
        /// <summary>
        /// Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
        /// Use the last state (day before) to calculate the new state
        /// Review the dailyRecordList to set the data for: 
        /// - GrowingDegreeDaysAccumulated
        /// - GrowingDegreeDaysModified
        /// - TotalEvapotranspirationCrop
        /// - TotalEffectiveRain
        /// - TotalIrrigation
        /// - TotalEvapotranspirationCropFromLastWaterInput
        /// - LastWaterInput
        /// </summary>
        /// <param name="pDailyRecord"></param>
        private DailyRecord setNewValuesAndReviewSummaryData(DailyRecord pDailyRecord)
        {
            DailyRecord lReturn;
            Double lFieldCapacity;
            int lDayAfterSowing;
            int lDayAfterSowingModified;
            int lDayAfterSowingModifiedDifference;
            PhenologicalStage lNewPhenologicalStage;
            Double lDaysAfterBigInputWater;
            Double lPercentageOfHydricBalance;
            Double lGAPPercentageOfHydricBalance;
            Double lDaysAfterBigGapWaterInput;
            

            lReturn = pDailyRecord;

            lDayAfterSowing = Utils.GetDaysDifference(this.SowingDate, pDailyRecord.DailyRecordDateTime);
            lDayAfterSowingModifiedDifference = this.DaysAfterSowing - this.DaysAfterSowingModified;
            lDayAfterSowingModified = lDayAfterSowing - lDayAfterSowingModifiedDifference;

            this.CropDate = pDailyRecord.DailyRecordDateTime;
            this.DaysAfterSowing = lDayAfterSowing;
            this.DaysAfterSowingModified = lDayAfterSowingModified;

            this.GrowingDegreeDaysAccumulated = pDailyRecord.GrowingDegreeDaysAccumulated;
            this.GrowingDegreeDaysModified = pDailyRecord.GrowingDegreeDaysModified;
            this.LastDayOfGrowingDegreeDays = pDailyRecord.LastDayOfGrowingDegreeDays;

            //Update the Phenological Stage depending in Calculus Method
            lNewPhenologicalStage = setNewPhenologicalStageAccordingCalculusMethod();

            lFieldCapacity = this.GetSoilFieldCapacity();

            #region only for debug - do nothing
            if (pDailyRecord.DailyRecordDateTime.Equals(new DateTime(2016, 10, 09)))
            {
                //System.Diagnostics.Debugger.Break();
            }
            if (pDailyRecord.DailyRecordDateTime.Equals(new DateTime(2016, 10, 10)))
            {
                //System.Diagnostics.Debugger.Break();
            }
            if (pDailyRecord.DailyRecordDateTime.Equals(new DateTime(2015, 11, 12)))
            {
                //System.Diagnostics.Debugger.Break();
            }
            #endregion

            // Evapotraspiration adjustment
            if (pDailyRecord.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCrop += pDailyRecord.EvapotranspirationCrop.GetTotalOutput();
                this.HydricBalance -= pDailyRecord.EvapotranspirationCrop.GetTotalOutput();
                if(this.HydricBalance < 0)
                {
                    this.HydricBalance = 0;
                }
            }

            //Percentage of Water (Hydric Balance / Field Capacity * 100) 
            pDailyRecord.PercentageOfHydricBalance = this.GetPercentageOfHydricBalance();

            //Gap of Percentage of Hydric Balance compares with the last day
            pDailyRecord.GAPPercentageOfHydricBalance = this.GetGAPOfPercentageOfHydricBalanceFromLastDays(1);
                
            // Irrigation adjustment
            irrigationAdjustment(pDailyRecord, lFieldCapacity);

            // Rain adjustment
            rainAdjustment(pDailyRecord, lFieldCapacity);

            lPercentageOfHydricBalance = this.GetPercentageOfHydricBalance();
            lDaysAfterBigGapWaterInput = Utilities.Utils.GetDaysDifference(this.LastBigGapWaterInputDate, pDailyRecord.DailyRecordDateTime);

            if (this.TotalEvapotranspirationCropFromLastWaterInput != 0 
                && lPercentageOfHydricBalance >= InitialTables.HYDRIC_BALANCE_PERCENTAGE_TO_CONSIDER_INCREASE)
            {
                if(this.WeatherEventType == Utils.WeatherEventType.LaNinia && 
                    lDaysAfterBigGapWaterInput <= InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_LARGE_INCREASE_NINIA)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                }
                else if (this.WeatherEventType == Utils.WeatherEventType.ElNinio &&
                    lDaysAfterBigGapWaterInput <= InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_LARGE_INCREASE_NINIO)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                }
                else if (lDaysAfterBigGapWaterInput <= InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_LARGE_INCREASE)
                {
                    this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                }
                //for last day to DAYS_TO_CHECK_HYDRIC_BALANCE_AFTER_LARGE_INCREASE, 
                //see if GAP of Percentage  is bigger than CONSIDER_PERCENTAGE_IN_HYDRIC_BALANCE_INCREASE
                for (int lDay = 2; lDay <= InitialTables.DAYS_TO_CHECK_HYDRIC_BALANCE_AFTER_LARGE_INCREASE; lDay++)
                {
                    lGAPPercentageOfHydricBalance = this.GetGAPOfPercentageOfHydricBalanceFromLastDays(lDay);
                    if (lGAPPercentageOfHydricBalance > InitialTables.CONSIDER_PERCENTAGE_IN_HYDRIC_BALANCE_INCREASE)
                    {
                        this.TotalEvapotranspirationCropFromLastWaterInput = 0;
                        this.LastBigGapWaterInputDate = pDailyRecord.DailyRecordDateTime;
                        break;
                    }
                }
            }

            //Total EvapotranspirationCrop From Last Water Input adjustment 
            //after Irrigation and Rain Adjustment
            if (pDailyRecord.EvapotranspirationCrop != null)
            {
                this.TotalEvapotranspirationCropFromLastWaterInput += pDailyRecord.EvapotranspirationCrop.GetTotalOutput();
            }
            
            //After a big RAIN input, the Hydric Balance keep its value = FieldCapacity for X days
            //LastBigWaterInputDate it will be inicialized after rain Adjunstment
            lDaysAfterBigInputWater = Utilities.Utils.GetDaysDifference(this.LastBigWaterInputDate, pDailyRecord.DailyRecordDateTime);
            if(this.WeatherEventType == Utils.WeatherEventType.LaNinia &&
                lDaysAfterBigInputWater <= InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT_NINIA)
            {
                this.HydricBalance = lFieldCapacity;
            }
            else if (this.WeatherEventType == Utils.WeatherEventType.ElNinio &&
                lDaysAfterBigInputWater <= InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT_NINIO)
            {
                this.HydricBalance = lFieldCapacity;
            }
            else if (lDaysAfterBigInputWater <= InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT)
            {
                this.HydricBalance = lFieldCapacity;
            }

            //The first days after sowing, hydric balance is maintained at field capacity
            //2016-10-20 InitialTables.DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING is not used anymore
            //Now is a property of CropIrrigationUnit
            if (lDayAfterSowing <= this.DaysForHydricBalanceUnchangableAfterSowing)
            {
                this.HydricBalance = lFieldCapacity;
            }

            //Set DailyRecord Total Information
            lReturn.PhenologicalStageId = lNewPhenologicalStage.PhenologicalStageId;
            lReturn.HydricBalance = this.HydricBalance;

            lReturn.DaysAfterSowing = this.DaysAfterSowing;
            lReturn.DaysAfterSowingModified = this.DaysAfterSowingModified;
            lReturn.GrowingDegreeDaysAccumulated = this.GrowingDegreeDaysAccumulated;
            lReturn.GrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
            lReturn.LastDayOfGrowingDegreeDays = this.LastDayOfGrowingDegreeDays;

            lReturn.LastWaterInputDate = this.LastWaterInputDate;
            lReturn.LastBigWaterInputDate = this.LastBigWaterInputDate;
            lReturn.LastPartialWaterInputDate = this.LastPartialWaterInputDate;
            lReturn.LastPartialWaterInput = this.LastPartialWaterInput;
            lReturn.SoilHydricVolume = this.SoilHydricVolume;

            lReturn.TotalEvapotranspirationCropFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput;
            lReturn.TotalEvapotranspirationCrop = this.TotalEvapotranspirationCrop;

            lReturn.TotalEffectiveRain = this.TotalEffectiveRain;
            lReturn.TotalRealRain = this.TotalRealRain;

            lReturn.TotalIrrigation = this.TotalIrrigation;
            lReturn.TotalIrrigationInHydricBalance = this.TotalIrrigationInHydricBalance;
            lReturn.TotalExtraIrrigation = this.TotalExtraIrrigation;
            lReturn.TotalExtraIrrigationInHydricBalance = this.TotalExtraIrrigationInHydricBalance;

            return lReturn;
        }

        #endregion

        #region Calculus

        /// <summary>
        /// Get Predeterminated Irrigation Quantity by Date
        /// Depends if the Irrigation Unit can be Adjustable
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private Double getPredeterminatedIrrigationQuantity(DateTime pDateTime)
        {
            Double lReturn;
            Double lPredeterminatedIrrigationQuantity;

            if (!this.AdjustableIrrigationQuantity)
            {
                lPredeterminatedIrrigationQuantity = this.PredeterminatedIrrigationQuantity;
            }
            else if (pDateTime > Utils.PredeterminatedDateFrom_ThirdPart)
            {
                lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_ThirdPart;
            }
            else if (pDateTime > Utils.PredeterminatedDateFrom_SecondPart)
            {
                lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
            }
            else if (pDateTime > Utils.PredeterminatedDateFrom_FirstPart)
            {
                lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_FirstPart;
            }
            else
            {
                lPredeterminatedIrrigationQuantity = this.PredeterminatedIrrigationQuantity;
            }
            //Take into account the max quantity of irrigation
            lReturn = Math.Min(lPredeterminatedIrrigationQuantity, this.MaxIrrigationQuantity);
            return lReturn;
        }

        /// <summary>
        /// Calculate the GrowingDegreeDays and update the GrowingDegreeDaysAccumulated and GrowingDegreeDaysModified
        /// </summary>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pAverageTemperature"></param>
        /// <returns></returns>
        private Double calculateGrowingDegreeDaysForOneDay(Double pBaseTemperature, Double pAverageTemperature)
        {
            Double lReturn = 0;
            Double lGrowingDegreeDays = 0;

            lGrowingDegreeDays = Math.Max(pAverageTemperature - pBaseTemperature, 0);

            lReturn = lGrowingDegreeDays;
            return lReturn;
        }

        /// <summary>
        /// Calculate the DaysAfterSowing and update the DaysAfterSowing and DaysAfterSowingModified
        /// </summary>
        /// <param name="pSowingDate"></param>
        /// <param name="pDate"></param>
        /// <returns></returns>
        private int calculateDaysAfterSowingForOneDay(DateTime pSowingDate, DateTime pDate)
        {
            int lReturn = 0;
            int lDaysAfterSowing = 0;

            if(pSowingDate != null && pDate != null)
            {
                if(pSowingDate < pDate)
                {
                    lDaysAfterSowing = Utils.GetDaysDifference(pSowingDate, pDate);
                    this.DaysAfterSowing += 1;
                    this.DaysAfterSowingModified = lDaysAfterSowing;
                }
            }

            lReturn = lDaysAfterSowing;
            return lReturn;
        }

        /// <summary>
        /// Calculate Growing Degree Days 
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <param name="pDailyRecordDateTime"></param>
        /// <returns></returns>
        private Double calculateGrowingDegreeDays(
                WeatherData pWeatherData, DateTime pDailyRecordDateTime)
        {
            #region local variables
            Double lReturn;
            WeatherData lWeatherData;
            DateTime lDailyRecordDateTime;
            Double lBaseTemperature = 0;
            Double lStressTemperature = 0;
            Double lAverageTemperature = 0;
            Double lGrowingDegreeDays = 0;
            Double lGrowingDegreeDaysModified = 0;
            DateTime lLastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;
            DailyRecord lDailyRecord = null;
            #endregion

            lWeatherData = pWeatherData;
            lDailyRecordDateTime = pDailyRecordDateTime;

            #region Growing Degree Days Modified
            //Growing Degree Days is average temperature menous Base Temperature 
            lBaseTemperature = this.GetBaseTemperature();
            lStressTemperature = this.GetStressTemperature();
            lLastDayOfGrowingDegreeDays = this.LastDayOfGrowingDegreeDays;
            if (lWeatherData != null)
            {
                #region Growing Degree Days with WeatherData
                //Add DegreeDays ones a day
                if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                {
                    //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                    //is updated by calculateGrowingDegreeDaysForOneDay
                    lAverageTemperature = lWeatherData.GetAverageTemperature(lStressTemperature, -lBaseTemperature);
                    lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(lBaseTemperature, lAverageTemperature);
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                    this.GrowingDegreeDaysModified += lGrowingDegreeDaysModified;
                    this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                }
                //Firt day of AutoBrowse Calculus
                else if (lLastDayOfGrowingDegreeDays.Date > lDailyRecordDateTime.Date)
                {
                    //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                    //is updated by calculateGrowingDegreeDaysForOneDay
                    lAverageTemperature = lWeatherData.GetAverageTemperature(lStressTemperature, -lBaseTemperature);
                    lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(lBaseTemperature, lAverageTemperature);
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    //The state before new data is requiered
                    lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date);
                    if (lDailyRecord != null)
                    {
                        this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated + lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified + lGrowingDegreeDaysModified;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                    else
                    {
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDaysModified;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                }
                #endregion
            }
            else
            {
                #region GrowingDegreeDays without WeatherData
                //Add DegreeDays ones a day
                if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                {
                    lGrowingDegreeDays = this.CropInformationByDate.GetGrowingDegreeDays(lDailyRecordDateTime,
                                                                                    lBaseTemperature, lStressTemperature);
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                    this.GrowingDegreeDaysModified += lGrowingDegreeDaysModified;
                    this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                }
                //Firt day of AutoBrowse Calculus
                else if (lLastDayOfGrowingDegreeDays.Date > lDailyRecordDateTime.Date)
                {
                    //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                    //is updated by CropInformationByDate
                    lGrowingDegreeDays = this.CropInformationByDate.GetGrowingDegreeDays(lDailyRecordDateTime,
                                                                                    lBaseTemperature, lStressTemperature);
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    //The state before new data is requiered
                    lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date);
                    if (lDailyRecord != null)
                    {
                        this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated + lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified + lGrowingDegreeDaysModified;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                    else
                    {
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDaysModified;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                }
                
                #endregion
            }
            #endregion

            lReturn = lGrowingDegreeDays;
            return lReturn;

        }

        /// <summary>
        /// Calculate how much to irrigate in a Date.
        /// Use both ways to calculate: by available water and by acumulated evapotranspirationCrop
        /// The first part is the quantity
        /// the second part is Input Type
        /// the third part is Extra or common irrigation
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        private Triple<Double, Utils.WaterInputType, bool> HowMuchToIrrigate(DateTime pDateTime)
        {
            #region local variables
            Triple<Double, Utils.WaterInputType, bool> lReturn;
            bool lIrrigationByEvapotranspiration;
            bool lIrrigationByHydricBalance;
            Double lPercentageAvailableWater;
            Double lPredeterminatedIrrigationQuantity;

            Water.Irrigation lHaveIrrigation = null;
            Water.Irrigation lHaveIrrigationDayBefore = null;
            Water.Irrigation lIrrigationNextDay = null;

            lReturn = new Triple<Double, Utils.WaterInputType, bool>();
            lReturn.Second = Utils.WaterInputType.IrrigationWasNotDecided;
            lReturn.Third = false;
            #endregion

            #region Debug by Date
            if (pDateTime.Date.Equals(DateTime.Now.Date))
            {
                //System.Diagnostics.Debugger.Break();
            }

            if (pDateTime.Date.Equals(new DateTime(2016, 12, 09)))
            {
                //System.Diagnostics.Debugger.Break();
            }
            if (pDateTime.Date.Equals(new DateTime(2016, 12, 20)))
            {
                //System.Diagnostics.Debugger.Break();
            }
            #endregion

            //Get the irrigation for the day
            lHaveIrrigation = this.GetIrrigationByDay(pDateTime);
            //Get the irrigation of yesterday
            lHaveIrrigationDayBefore = this.GetIrrigationByDay(pDateTime.AddDays(-1));

            //Get Predeterminated Irrigation Quantity by Date
            //Change 2017-12-12 by Rodo
            lPredeterminatedIrrigationQuantity = this.getPredeterminatedIrrigationQuantity(pDateTime);

            // The date refers an explicit Cant irrigation date
            if (lHaveIrrigation != null && lHaveIrrigation.Type == Utils.WaterInputType.CantIrrigate)
            {
                lReturn.First = 0;
                lReturn.Second = Utils.WaterInputType.CantIrrigate;
                lReturn.Third = true;
                return lReturn;
            }
            //We have an extra Irrigation this day
            else if (lHaveIrrigation != null && lHaveIrrigation.ExtraInput > 0)
            {
                lReturn.First = lHaveIrrigation.ExtraInput;
                lReturn.Second = lHaveIrrigation.Type;
                lReturn.Third = true;
                return lReturn;
            }
            //when arrives to final Stage, do not add new irrigation
            else if (this.PhenologicalStage.Stage.Order >= this.Crop.StopIrrigationStageOrder)
            {
                lReturn.First = 0;
                lReturn.Second = Utils.WaterInputType.CantIrrigate;
                lReturn.Third = true;
                return lReturn;
            }
            //We have a Cant Irrigate the day before and an Irrigation tha day
            else if (lHaveIrrigation != null  && lHaveIrrigation.Type != Utils.WaterInputType.IrrigationWasNotDecided
                                              && lHaveIrrigation.Type != Utils.WaterInputType.CantIrrigate
                  && lHaveIrrigationDayBefore!= null && lHaveIrrigationDayBefore.Type == Utils.WaterInputType.CantIrrigate)
            {
                lReturn.First = lHaveIrrigation.Input;
                lReturn.Second = lHaveIrrigation.Type;
                lReturn.Third = false;
                return lReturn;
            }

            //Calculate the irrigation quantity and reason for this
            lIrrigationByEvapotranspiration = this.IrrigateByEvapotranspiration();
            lIrrigationByHydricBalance = this.IrrigateByHydricBalance();
            lPercentageAvailableWater = this.GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint();
            
            //To Calculate a new Irrigation we have this constraint:
            //      - No Irrigation the day before
            //      - If we have Irrigation the day before, it has not to be Irrigation, IrrigationByETCAcumulated nor IrrigationByHydricBalance
            //      - No Irrigation Today
            //      - If we have Irrigation today, do not has to be Extra Irrigation
            if ((lHaveIrrigationDayBefore == null || (lHaveIrrigationDayBefore != null 
                                                    && (lHaveIrrigationDayBefore.Type != Utils.WaterInputType.Irrigation
                                                    && lHaveIrrigationDayBefore.Type != Utils.WaterInputType.IrrigationByETCAcumulated
                                                    && lHaveIrrigationDayBefore.Type != Utils.WaterInputType.IrrigationByHydricBalance))) 
                && (lHaveIrrigation == null || lHaveIrrigation.Type == Utils.WaterInputType.IrrigationWasNotDecided 
                                            || lHaveIrrigation.ExtraInput == 0))
            {
                if (lIrrigationByHydricBalance)
                {
                    lReturn.First = lPredeterminatedIrrigationQuantity;
                    lReturn.Second = Utils.WaterInputType.IrrigationByHydricBalance;
                    lReturn.Third = false;
                }
                else if (lIrrigationByEvapotranspiration)
                {
                    if (this.WeatherEventType == Utils.WeatherEventType.LaNinia)
                    {
                        lReturn.First = lPredeterminatedIrrigationQuantity;
                        lReturn.Second = Utils.WaterInputType.IrrigationByETCAcumulated;
                        lReturn.Third = false;
                    }
                    //If we need to irrigate by Evapotranspiraton, then Available water has to be lower than 60% 
                    else if (this.WeatherEventType == Utils.WeatherEventType.ElNinio)
                    {
                        if (lPercentageAvailableWater < InitialTables.PERCENTAGE_OF_AVAILABE_WATER_TO_IRRIGATE)
                        {
                            lReturn.First = lPredeterminatedIrrigationQuantity;
                            lReturn.Second = Utils.WaterInputType.IrrigationByETCAcumulated;
                            lReturn.Third = false;
                        }
                    }
                    else //By default The same as Ninio
                    {
                        if (lPercentageAvailableWater < InitialTables.PERCENTAGE_OF_AVAILABE_WATER_TO_IRRIGATE)
                        {
                            lReturn.First = lPredeterminatedIrrigationQuantity;
                            lReturn.Second = Utils.WaterInputType.IrrigationByETCAcumulated;
                            lReturn.Third = false;
                        }
                    }
                }
               else if (lHaveIrrigation != null && lHaveIrrigation.Type == Utils.WaterInputType.IrrigationByHydricBalance)
               {
                   lReturn.First = lHaveIrrigation.Input;
                   lReturn.Second = Utils.WaterInputType.IrrigationByHydricBalance;
                   lReturn.Third = false;
               }
               else if (lHaveIrrigation != null && lHaveIrrigation.Type == Utils.WaterInputType.IrrigationByETCAcumulated)
               {
                   lReturn.First = lHaveIrrigation.Input;
                   lReturn.Second = Utils.WaterInputType.IrrigationByETCAcumulated;
                   lReturn.Third = false;
               }
               else  //Always we consider to have a Irrigation Type
                {
                    lReturn.First = 0;
                    lReturn.Second = Utils.WaterInputType.IrrigationWasNotDecided;
                    lReturn.Third = false;
                }
            }

            lIrrigationNextDay = this.GetIrrigationByDay(pDateTime.AddDays(1));

            if (lHaveIrrigation != null && lHaveIrrigation.ExtraInput == 0 
                                        && lHaveIrrigation.Type != Utils.WaterInputType.CantIrrigate
                && lIrrigationNextDay != null && lIrrigationNextDay.ExtraInput > 0 )
            {
                //We have to move the irrigation to tomorrow
                lReturn.First = 0;
                lReturn.Second = Utils.WaterInputType.IrrigationWasNotDecided;
                lReturn.Third = false;
            }

            return lReturn;
        }

        /// <summary>
        /// If the Evapotranspiration Acumulated from last water input, is bigger than MaxEvapotranspirationToIrrigate (Crop Data),
        /// we need to irrigate
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        private bool IrrigateByEvapotranspiration()
        {
            bool lReturn = false;
            Double lMaxEvapotrranspirationToIrrigate;
            Double lEvapotranspirationAcumulated;
            int lStageOrderForPercentageOfMaxET = 0;
            String lShortNameForCrop = "";

            if (this.WeatherEventType == Utils.WeatherEventType.LaNinia)
            {
                //**************************************************************************************
                //2018-01-02 If the stage is bigger than R1 consider Percentage of ET to irrigate
                if(this.Crop != null && this.Crop.Name.Contains(Utils.NameStagesCorn))
                {
                    lShortNameForCrop = InitialTables.STAGE_FOR_PERCENTAGE_OF_MAX_EVAPOTRANSPIRATION_TO_IRRIGATE_FOR_CORN;
                }
                else if (this.Crop != null && this.Crop.Name.Contains(Utils.NameStagesSoya))
                {
                    lShortNameForCrop = InitialTables.STAGE_FOR_PERCENTAGE_OF_MAX_EVAPOTRANSPIRATION_TO_IRRIGATE_FOR_SOYA;
                }
                else
                {
                    lShortNameForCrop = "R1";
                }
                lStageOrderForPercentageOfMaxET = this.getStageOrderByShortName(lShortNameForCrop);
                //**************************************************************************************
                
                if(this.PhenologicalStage.StageId >= this.Crop.MinStageToConsiderETinHBCalculationId)
                {
                    //**************************************************************************************
                    //2018-01-02 If the stage is bigger than R1 consider MinET
                    if (lStageOrderForPercentageOfMaxET > 0 && this.PhenologicalStage.Stage.Order >= lStageOrderForPercentageOfMaxET)
                    {
                        lMaxEvapotrranspirationToIrrigate = Math.Round(this.Crop.MaxEvapotranspirationToIrrigate *
                            InitialTables.PERCENTAGE_OF_MAX_EVAPOTRANSPIRATION_TO_IRRIGATE_AFTER_STAGE / 100, 2);
                    }
                    //**************************************************************************************
                    else
                    {
                        lMaxEvapotrranspirationToIrrigate = Math.Round(this.Crop.MaxEvapotranspirationToIrrigate *
                            InitialTables.PERCENTAGE_OF_MAX_EVAPOTRANSPIRATION_TO_IRRIGATE_BEFORE_STAGE / 100, 2);
                    }
                }
                else
                {
                    lMaxEvapotrranspirationToIrrigate = this.Crop.MaxEvapotranspirationToIrrigate;
                }
            }
            else if (this.WeatherEventType == Utils.WeatherEventType.ElNinio)
            {
                lMaxEvapotrranspirationToIrrigate = this.Crop.MaxEvapotranspirationToIrrigate;
            }
            else //By default The same as Ninio
            {
                lMaxEvapotrranspirationToIrrigate = this.Crop.MaxEvapotranspirationToIrrigate;
            }

            lEvapotranspirationAcumulated = this.GetTotalEvapotranspirationCropFromLastWaterInput();

            //If the evapotranspiration Acumulated from last water output is bigger than max evapotranspiration to irrigatte
            //we need to irrigate
            if (lEvapotranspirationAcumulated >= lMaxEvapotrranspirationToIrrigate)
            {
                lReturn = true;
            }
            return lReturn;
        }

        /// <summary>
        /// If the Hydric Balance is lower than the Water Threhold we need to Irrigate
        /// The water Threhold is the half of the Available Water
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        private bool IrrigateByHydricBalance()
        {
            bool lReturn = false;
            Double lAvailableWater;
            Double lHydricBalance;
            Double lPermanentWiltingPoint;
            Double lThreshold;
            Stage lMinStageToConsiderETinHBCalculation;
            Double lMinEvapotrasnpirationToIrrigate;
            Double lEvapotrAcum;

            lAvailableWater = this.GetSoilAvailableWaterCapacity();
            lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();
            //This is the Threshold to determinate the need of lIrrigationItem
            lThreshold = Math.Round(lAvailableWater 
                        * InitialTables.PERCENTAGE_LIMIT_OF_AVAILABLE_WATER_CAPACITY, 2) 
                        + lPermanentWiltingPoint;

            lMinEvapotrasnpirationToIrrigate = this.Crop.MinEvapotranspirationToIrrigate;

            //**************************************************************************************
            //2016-12-04 If the stage is bigger than MinStageToConsiderETinHBCalculation consider MinET
            lMinStageToConsiderETinHBCalculation = this.Crop.MinStageToConsiderETinHBCalculation;
            if (this.PhenologicalStage.StageId < this.Crop.MinStageToConsiderETinHBCalculationId)
            {
                lMinEvapotrasnpirationToIrrigate = 0;
            }
            //**************************************************************************************

            //**************************************************************************************
            //2016-12-04 This is Disabled
            //2016-10-17 Not to consider ETc for HydricBalance Irrigation
            //lMinEvapotrasnpirationToIrrigate = 0;
            //**************************************************************************************

            //**************************************************************************************
            //2018-01-02 Consider Half ETc for HydricBalance Irrigation
            if (this.WeatherEventType == Utils.WeatherEventType.LaNinia)
            {
                lMinEvapotrasnpirationToIrrigate = Math.Round(lMinEvapotrasnpirationToIrrigate / 2, 2);
            }
            //**************************************************************************************

            lEvapotrAcum = this.GetTotalEvapotranspirationCropFromLastWaterInput();

            lHydricBalance = this.GetHydricBalance();

            if (lHydricBalance <= lThreshold && lEvapotrAcum >= lMinEvapotrasnpirationToIrrigate)
            {
                lReturn = true;
            }

            return lReturn;
        }

        #endregion

        #region PhenologicalStage

        /// <summary>
        /// Get Stage Order by Phennological Stage
        /// </summary>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        private int getStageOrderBy(PhenologicalStage pPhenologicalStage)
        {
            int lReturn = 0;
            Stage lStage = null;

            if(pPhenologicalStage != null)
            {
                lStage = pPhenologicalStage.Stage;
                if(lStage != null)
                {
                    lReturn = lStage.Order;
                }
            }
            
            return lReturn;
        }

        /// <summary>
        /// Get Stage Order by Stage short name
        /// </summary>
        /// <param name="pShortName"></param>
        /// <returns></returns>
        private int getStageOrderByShortName(String pShortName)
        {
            int lReturn = 0;
            Stage lStage = null;

            lStage = this.getStageByShortName(pShortName);
            if(lStage != null)
            {
                lReturn = lStage.Order;
            }
            
            return lReturn;
        }

        /// <summary>
        /// Get Stage by Short Name of Stege
        /// </summary>
        /// <param name="pShortName"></param>
        /// <returns></returns>
        private Stage getStageByShortName(String pShortName)
        {
            Stage lReturn = null;
            PhenologicalStage lPhenologicalStage;

            if(this.Crop != null && this.Crop.PhenologicalStageList.Any())
            {
                lPhenologicalStage = this.Crop.PhenologicalStageList
                                .Where(PhenologicalStage => PhenologicalStage.Stage.ShortName.Contains(pShortName))
                                .FirstOrDefault();
                if(lPhenologicalStage != null)
                {
                    lReturn = lPhenologicalStage.Stage;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Change the PhenologicalStage of the crop depending on:
        ///     the growing degree acumulated plus the adjustment, or
        ///     the days after sowing plus the adjustment
        /// </summary>
        private PhenologicalStage setNewPhenologicalStageAccordingCalculusMethod()
        {
            PhenologicalStage lReturn;
            PhenologicalStage lOldPhenologicalStage = null;
            Double lOldRootDepth = 0;
            PhenologicalStage lNewPhenologicalStage = null;
            Double lNewRootDepth = 0;
            
            Double lGrowingDegreeDaysModified = 0;
            int lDaysAfterSowingModified = 0;
            Double lRootDepthDifference = 0;
            Double lPercentageOfAvailableWater = 0;

            try
            {
                lOldPhenologicalStage = this.PhenologicalStage;
                lOldRootDepth = this.GetDepthTakingIntoAccountSoilDepthLimitBy(this.PhenologicalStage);

                //Get the modified degrees days
                lGrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
                //Get the Days after sowing
                lDaysAfterSowingModified = this.DaysAfterSowingModified;
                
                //Get the percentage of available Water before update the phenology state 
                lPercentageOfAvailableWater = this.GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint();

                if (this.CalculusMethodForPhenologicalAdjustment == Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays)
                {
                    //Get Phenological Stage depending on the GrowingDegreeDaysModified
                    lNewPhenologicalStage = this.GetNewPhenologicalStage(lGrowingDegreeDaysModified);
                }
                if (this.CalculusMethodForPhenologicalAdjustment == Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing)
                {
                    //Get Phenological Stage depending on the Days After Sowing
                    lNewPhenologicalStage = this.GetNewPhenologicalStage(lDaysAfterSowingModified);
                }
                if (this.CalculusMethodForPhenologicalAdjustment == Utils.CalculusOfPhenologicalStage.ByIntervalGrowingDegreeDays)
                {
                    //Get Phenological Stage depending on the Interval Growing Degree Days
                    lNewPhenologicalStage = this.GetNewPhenologicalStageByInterval(lGrowingDegreeDaysModified);
                }

                lNewRootDepth = this.GetDepthTakingIntoAccountSoilDepthLimitBy(lNewPhenologicalStage);
                this.PhenologicalStage = lNewPhenologicalStage;

                //If icrease the Root Depth, we add the new water to the hydric balance,
                //the part of the soil is considered at field capacity
                if (lOldPhenologicalStage != null && lNewPhenologicalStage != null && lOldRootDepth < lNewRootDepth)
                {
                    //TODO get field capacity by horizon of soil (parameters: horizon depth, root depth difference)
                    lRootDepthDifference = lNewRootDepth - lOldRootDepth;
                    this.HydricBalance += this.GetSoilFieldCapacity(lRootDepthDifference);
                }

                //If decrease the Root Depth, we add the new water to the hydric balance,
                //the part of the soil is considered at field capacity
                if (lOldPhenologicalStage != null && lNewPhenologicalStage != null && lOldRootDepth > lNewRootDepth)
                {
                    this.HydricBalance = (this.GetSoilAvailableWaterCapacity() * lPercentageOfAvailableWater / 100)
                                        + this.GetSoilPermanentWiltingPoint();
                }

                lReturn = lNewPhenologicalStage;
                return lReturn;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.setNewPhenologicalStageAccordingCalculusMethod " 
                                    + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            
        }

        /// <summary>
        /// Search the DailyRecord for the date passed by parameter.
        /// If find one change the GrowingDegreeDaysModified for this DailyRecord and change the GrowingDegreeDaysModified field 
        /// adding the value passed by parameter as lModification
        /// </summary>
        /// <param name="pStage"></param>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="lModification"></param>
        private void adjustmentPhenology(Stage pStage, DateTime pDateTime, Double lModification)
        {
            foreach (DailyRecord lDailyRecord in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(pDateTime, lDailyRecord.DailyRecordDateTime))
                {
                    lDailyRecord.GrowingDegreeDaysModified += lModification; // +lDailyRecordToDelete.GrowingDegreeDaysModified;
                    this.GrowingDegreeDaysModified += lModification;
                    this.GrowingDegreeDaysExtraGap += lModification;
                }
            }
        }

        /// <summary>
        /// Calculate Degrees by Differnces in Crop Stages according CalculusMethodForPhenologicalAdjustment
        /// </summary>
        /// <param name="oldStage"></param>
        /// <param name="newStage"></param>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        private Double calculateDegreeStageDifference(Stage oldStage, Stage newStage, Crop pCrop)
        {
            Double lReturn = 0;
            Double oldDegree = 0;
            Double newDegree = 0;
            List<PhenologicalStage> lPhenologicalStageList;

            try
            {
                lPhenologicalStageList = pCrop.PhenologicalStageList;
                if (this.CalculusMethodForPhenologicalAdjustment.Equals(Utils.CalculusOfPhenologicalStage.ByIntervalGrowingDegreeDays))
                {
                    foreach (PhenologicalStage lPhenologicalStage in lPhenologicalStageList)
                    {
                        if (lPhenologicalStage.PhenologicalStageIsUsed && lPhenologicalStage.Stage.Order <= oldStage.Order)
                        {
                            oldDegree += lPhenologicalStage.DegreesDaysInterval;
                        }
                        if (lPhenologicalStage.PhenologicalStageIsUsed && lPhenologicalStage.Stage.Order <= newStage.Order)
                        {
                            newDegree += lPhenologicalStage.DegreesDaysInterval;
                        }

                    }

                    lReturn = newDegree - oldDegree;
                }
                else { 
                    foreach (PhenologicalStage lPhenologicalStage in lPhenologicalStageList)
                    {
                        if (lPhenologicalStage.Stage.Equals(oldStage))
                        {
                            oldDegree = lPhenologicalStage.GetAverageDegree();
                        }
                        if (lPhenologicalStage.Stage.Equals(newStage))
                        {
                            newDegree = lPhenologicalStage.GetAverageDegree();
                        }
                        if (newDegree != 0 && oldDegree != 0)
                        {
                            lReturn = newDegree - oldDegree;
                            break;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.CalculateDegreeStageDifference " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }
        
        #endregion

        #region CropIrrigationWeather

        /// <summary>
        /// Update CropIrrigationWeather Data by Daily Record of one day before Record to Delete
        /// </summary>
        /// <param name="pRecordToDelete"></param>
        private void UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(DailyRecord pRecordToDelete)
        {
            
            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;
            
            DailyRecord lDailyRecordBeforeRecordToDelete;

            //We are in the day before Record to Delete
            lDateOfDayAfterSowing = pRecordToDelete.DailyRecordDateTime.AddDays(-1);
            lDayAfterSowing = Utils.GetDaysDifference(this.SowingDate, lDateOfDayAfterSowing);

            lDailyRecordBeforeRecordToDelete = this.GetDailyRecordByDate(lDateOfDayAfterSowing);

            this.CropDate = lDateOfDayAfterSowing;
            if (lDailyRecordBeforeRecordToDelete != null)
            {
                this.PhenologicalStageId = lDailyRecordBeforeRecordToDelete.PhenologicalStageId;
                this.HydricBalance = lDailyRecordBeforeRecordToDelete.HydricBalance;

                this.DaysAfterSowingModified = lDailyRecordBeforeRecordToDelete.DaysAfterSowingModified;
                this.GrowingDegreeDaysAccumulated = lDailyRecordBeforeRecordToDelete.GrowingDegreeDaysAccumulated;
                this.GrowingDegreeDaysModified = lDailyRecordBeforeRecordToDelete.GrowingDegreeDaysModified;
                this.LastDayOfGrowingDegreeDays = lDailyRecordBeforeRecordToDelete.LastDayOfGrowingDegreeDays;

                this.LastWaterInputDate = lDailyRecordBeforeRecordToDelete.LastWaterInputDate;
                this.LastBigWaterInputDate = lDailyRecordBeforeRecordToDelete.LastBigWaterInputDate;
                this.LastPartialWaterInputDate = lDailyRecordBeforeRecordToDelete.LastPartialWaterInputDate;
                this.LastPartialWaterInput = lDailyRecordBeforeRecordToDelete.LastPartialWaterInput;
                this.SoilHydricVolume = lDailyRecordBeforeRecordToDelete.SoilHydricVolume;

                this.TotalEvapotranspirationCropFromLastWaterInput = lDailyRecordBeforeRecordToDelete.TotalEvapotranspirationCropFromLastWaterInput;
                this.TotalEvapotranspirationCrop = lDailyRecordBeforeRecordToDelete.TotalEvapotranspirationCrop;

                this.TotalEffectiveRain = lDailyRecordBeforeRecordToDelete.TotalEffectiveRain;
                this.TotalRealRain = lDailyRecordBeforeRecordToDelete.TotalRealRain;

                this.TotalIrrigation = lDailyRecordBeforeRecordToDelete.TotalIrrigation;
                this.TotalIrrigationInHydricBalance = lDailyRecordBeforeRecordToDelete.TotalIrrigationInHydricBalance;

                this.TotalExtraIrrigation = lDailyRecordBeforeRecordToDelete.TotalExtraIrrigation;
                this.TotalExtraIrrigationInHydricBalance = lDailyRecordBeforeRecordToDelete.TotalExtraIrrigationInHydricBalance;
            }

            this.DaysAfterSowing = lDayAfterSowing;
        }


        /// <summary>
        /// Update CropIrrigationWeather Data by Daily Record of one day before Record to Delete
        /// </summary>
        /// <param name="pRecordToDelete"></param>
        private void UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(DailyRecord pRecordToDelete,
                                                                            IrrigationAdvisorContext pIrrigationAdvisorContext)
        {

            int lDayAfterSowing;
            DateTime lDateOfDayAfterSowing;

            DailyRecord lDailyRecordBeforeRecordToDelete;
            int lDatabaseChangeResult = 0;

            //We are in the day before Record to Delete
            lDateOfDayAfterSowing = pRecordToDelete.DailyRecordDateTime.AddDays(-1);
            lDayAfterSowing = Utils.GetDaysDifference(this.SowingDate, lDateOfDayAfterSowing);

            lDailyRecordBeforeRecordToDelete = this.GetDailyRecordByDate(lDateOfDayAfterSowing);

            this.CropDate = lDateOfDayAfterSowing;

            if (lDailyRecordBeforeRecordToDelete != null)
            {
                this.PhenologicalStageId = lDailyRecordBeforeRecordToDelete.PhenologicalStageId;
                this.HydricBalance = lDailyRecordBeforeRecordToDelete.HydricBalance;

                this.DaysAfterSowingModified = lDailyRecordBeforeRecordToDelete.DaysAfterSowingModified;
                this.GrowingDegreeDaysAccumulated = lDailyRecordBeforeRecordToDelete.GrowingDegreeDaysAccumulated;
                this.GrowingDegreeDaysModified = lDailyRecordBeforeRecordToDelete.GrowingDegreeDaysModified;
                this.LastDayOfGrowingDegreeDays = lDailyRecordBeforeRecordToDelete.LastDayOfGrowingDegreeDays;

                this.LastWaterInputDate = lDailyRecordBeforeRecordToDelete.LastWaterInputDate;
                this.LastBigWaterInputDate = lDailyRecordBeforeRecordToDelete.LastBigWaterInputDate;
                this.LastPartialWaterInputDate = lDailyRecordBeforeRecordToDelete.LastPartialWaterInputDate;
                this.LastPartialWaterInput = lDailyRecordBeforeRecordToDelete.LastPartialWaterInput;
                this.SoilHydricVolume = lDailyRecordBeforeRecordToDelete.SoilHydricVolume;

                this.TotalEvapotranspirationCropFromLastWaterInput = lDailyRecordBeforeRecordToDelete.TotalEvapotranspirationCropFromLastWaterInput;
                this.TotalEvapotranspirationCrop = lDailyRecordBeforeRecordToDelete.TotalEvapotranspirationCrop;

                this.TotalEffectiveRain = lDailyRecordBeforeRecordToDelete.TotalEffectiveRain;
                this.TotalRealRain = lDailyRecordBeforeRecordToDelete.TotalRealRain;

                this.TotalIrrigation = lDailyRecordBeforeRecordToDelete.TotalIrrigation;
                this.TotalIrrigationInHydricBalance = lDailyRecordBeforeRecordToDelete.TotalIrrigationInHydricBalance;

                this.TotalExtraIrrigation = lDailyRecordBeforeRecordToDelete.TotalExtraIrrigation;
                this.TotalExtraIrrigationInHydricBalance = lDailyRecordBeforeRecordToDelete.TotalExtraIrrigationInHydricBalance;
            }
            
            this.DaysAfterSowing = lDayAfterSowing;
            
            lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
        }


        
        /// <summary>
        /// Return the Effective Input Water from the last DaysToLookFor days.
        /// Is the Total input water to consider if ETc has to be inicialized
        /// </summary>
        /// <param name="pDaysToLookFor"></param>
        /// <returns></returns>
        private Double getEffectiveInputWaterFromLastDays(Double pDaysToLookFor)
        {
            Double lReturn = 0;
            long lDaysToLookFor = (long)Math.Round(pDaysToLookFor);
            long lDays = Math.Min(lDaysToLookFor, this.DailyRecordList.Count());
            if(lDays == 1)
            {
                lReturn = this.DailyRecordList[0].TotalEffectiveInputWater;
            }
            else if (lDays > 1)
            {
                for (int lDay = this.DailyRecordList.Count() - 1; lDay > 0; lDay--)
                {
                    if (lDays > 0)
                    {
                        lReturn += this.DailyRecordList[lDay].TotalEffectiveInputWater;
                        lDays -= 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return lReturn;
        }


        /// <summary>
        /// Return the Effective Rain from the last DaysToLookFor days.
        /// </summary>
        /// <param name="pDaysToLookFor"></param>
        /// <returns></returns>
        private Double getEffectiveRainFromLastDays(Double pDaysToLookFor)
        {
            Double lReturn = 0;
            long lDaysToLookFor = (long)Math.Round(pDaysToLookFor);
            long lDays = Math.Min(lDaysToLookFor, this.DailyRecordList.Count());
            if (lDays == 1)
            {
                lReturn = this.DailyRecordList[0].TotalEffectiveRain;
            }
            else if (lDays > 1)
            {
                for (int lDay = this.DailyRecordList.Count() - 1; lDay > 0; lDay--)
                {
                    if (lDays > 0)
                    {
                        lReturn += this.DailyRecordList[lDay].TotalEffectiveRain;
                        lDays -= 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Average of Percentage of Effective Input Water from the last DaysToLookFor days.
        /// Is the Average of Percentage of input water to consider if ETc has to be inicialized
        /// </summary>
        /// <param name="pDaysToLookFor"></param>
        /// <returns></returns>
        private Double GetAverageOfPercentageOfHydricBalanceFromLastDays(Double pDaysToLookFor)
        {
            Double lReturn = 0;
            long lDaysToLookFor = (long)Math.Round(pDaysToLookFor);
            long lDays = Math.Min(lDaysToLookFor, this.DailyRecordList.Count());
            if (lDays == 1)
            {
                lReturn = this.DailyRecordList[this.DailyRecordList.Count() - 1].PercentageOfHydricBalance;
            }
            else if (lDays > 1)
            {
                long lDaysForAverage = lDays;
                for (int lDay = this.DailyRecordList.Count() - 1; lDay > 0; lDay-- )
                {
                    if (lDays > 0)
                    {
                        lReturn += this.DailyRecordList[lDay].PercentageOfHydricBalance;
                        lDays -= 1;
                    }
                    else
                    {
                        break;
                    }
                }
                lReturn = lReturn / lDaysForAverage;
                this.DailyRecordList.Reverse();
            }
            return lReturn;
        }

        /// <summary>
        /// Return the GAP of Percentage of Hydric Balance from the last DaysToLookFor days.
        /// </summary>
        /// <param name="pDaysToLookFor"></param>
        /// <returns></returns>
        private Double GetGAPOfPercentageOfHydricBalanceFromLastDays(Double pDaysToLookFor)
        {
            Double lReturn = 0;
            long lDaysToLookFor = (long)Math.Round(pDaysToLookFor);
            long lDays = Math.Min(lDaysToLookFor, this.DailyRecordList.Count());
            Double lCurrentPercentage = 0;
            Double lPreviousPercentage = 0;
            //If lDays == 0, lReturn is 0
            if( lDays > 0)
            {
                for (int lDay = DailyRecordList.Count(); lDay > 0; lDay--)
                {
                    if(lDay == DailyRecordList.Count())
                    {
                        lCurrentPercentage = this.GetPercentageOfHydricBalance();
                    }
                    else
                    {
                        lCurrentPercentage = DailyRecordList[lDay].PercentageOfHydricBalance;
                    }
                    lPreviousPercentage = DailyRecordList[lDay - 1].PercentageOfHydricBalance;
                    lReturn += (lCurrentPercentage - lPreviousPercentage);
                    lDays -= 1;
                    if(lDays == 0)
                    {
                        break;
                    }
                }
            }
            return lReturn;
        }

        #endregion

        #region HydricBalanceAdjustments

        /// <summary>
        /// Calculate hydric balance adjustments.
        /// </summary>
        /// <param name="pHydricBalanceAdjustmens"></param>
        /// <param name="pFromDate"></param>
        /// <param name="pToDate"></param>
        public void ApplyHydricBalanceAdjustments(List<HidricBalanceAdjustment> pHydricBalanceAdjustmens, DateTime pFromDate)
        {
            var dailyRecord = this.dailyRecordList.FirstOrDefault(n => pFromDate == n.DailyRecordDateTime);

            var exists = pHydricBalanceAdjustmens.FirstOrDefault(n => n.CropIrrigationWeatherId == this.cropIrrigationWeatherId && n.Date == dailyRecord.DailyRecordDateTime);

            if (exists != null && dailyRecord != null)
            {
                dailyRecord.HydricBalance = exists.HydricBalance;
                dailyRecord.PercentageOfHydricBalance = exists.Percentage;
                this.hydricBalance = exists.HydricBalance;
            }        
        }

        #endregion
        #endregion

        #region Public Methods

        #region Lists MaxIds

        /// <summary>
        /// New ID for EvapotranspirationCropList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewEvapotranspirationCropListId()
        {
            long lReturn = 1;
            long lMaxId = 0;
            long lNewId = 0;

            IrrigationAdvisorContext lContext = IrrigationAdvisorContext.Instance();

            if (this.EvapotranspirationCropList != null && this.EvapotranspirationCropList.Count > 0)
            {
                lReturn += this.EvapotranspirationCropList.Max(ec => ec.WaterOutputId);
            }
            if (!lContext.Irrigations.Any())
            {
                lMaxId = 0;
            }
            else
            {
                lMaxId = lContext.EvapotranspirationCrops.Max(table => table.WaterOutputId);
            }
            lNewId = lMaxId + 1;
            lReturn = Math.Max(lReturn, lNewId);
            return lReturn;
        }

        /// <summary>
        /// New ID for EvapotranspirationCropList, MAX + 1
        /// </summary>
        /// <param name="pIrrigationAdvisorContext"></param>
        /// <returns></returns>
        public long GetNewEvapotranspirationCropListId(IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            long lReturn = 1;
            long lMaxId = 0;
            long lNewId = 0;

            if (this.EvapotranspirationCropList != null && this.EvapotranspirationCropList.Count > 0)
            {
                lReturn += this.EvapotranspirationCropList.Max(ec => ec.WaterOutputId);
            }
            lMaxId = pIrrigationAdvisorContext.EvapotranspirationCrops.Max(table => table.WaterOutputId);
            lNewId = lMaxId + 1;
            lReturn = Math.Max(lReturn, lNewId);
            return lReturn;
        }

        /// <summary>
        /// New ID for IrrigationList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewIrrigationListId()
        {
            long lReturn = 1;
            long lMaxId = 0;
            long lNewId = 0;

            IrrigationAdvisorContext lContext;

            lContext = IrrigationAdvisorContext.Instance();

            if (this.IrrigationList != null && this.IrrigationList.Count > 0)
            {
                lReturn += this.IrrigationList.Max(ir => ir.WaterInputId);
            }
            if(!lContext.Irrigations.Any())
            {
                lMaxId = 0;
            }
            else
            {
                lMaxId = lContext.Irrigations.Max(table => table.WaterInputId);
            }
            lNewId = lMaxId + 1;
            lReturn = Math.Max(lReturn, lNewId);
            return lReturn;
        }

        /// <summary>
        /// New ID for IrrigationList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewIrrigationListId(IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            long lReturn = 1;
            long lMaxId = 0;
            long lNewId = 0;

            if (this.IrrigationList != null && this.IrrigationList.Count > 0)
            {
                lReturn += this.IrrigationList.Max(ir => ir.WaterInputId);
            }
            if (!pIrrigationAdvisorContext.Irrigations.Any())
            {
                lMaxId = 0;
            }
            else
            {
                lMaxId = pIrrigationAdvisorContext.Irrigations.Max(table => table.WaterInputId);
            }
            lNewId = lMaxId + 1;
            lReturn = Math.Max(lReturn, lNewId);
            return lReturn;
        }

        /// <summary>
        /// New ID for RainList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewRainListId()
        {
            long lReturn = 1;
            long lMaxId = 0;
            long lNewId = 0;

            IrrigationAdvisorContext lContext;

            lContext = IrrigationAdvisorContext.Instance();

            if (this.RainList != null && this.RainList.Count > 0)
            {
                lReturn += this.RainList.Max(ir => ir.WaterInputId);
            }
            if (!lContext.Rains.Any())
            {
                lMaxId = 0;
            }
            else
            {
                lMaxId = lContext.Rains.Max(table => table.WaterInputId);
            }
            lNewId = lMaxId + 1;
            lReturn = Math.Max(lReturn, lNewId);
            return lReturn;
        }

        /// <summary>
        /// New ID for RainList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewRainListId(IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            long lReturn = 1;
            long lMaxId = 0;
            long lNewId = 0;

            if (this.RainList != null && this.RainList.Count > 0)
            {
                lReturn += this.RainList.Max(ir => ir.WaterInputId);
            }
            lMaxId = pIrrigationAdvisorContext.EvapotranspirationCrops.Max(table => table.WaterOutputId);
            lNewId = lMaxId + 1;
            lReturn = Math.Max(lReturn, lNewId);
            return lReturn;
        }

        /// <summary>
        /// New ID for PhenologicalStageAdjustmentList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewPhenologicalStageAdjustmentListId()
        {
            long lReturn = 1;
            if (this.PhenologicalStageAdjustmentList != null && this.PhenologicalStageAdjustmentList.Count > 0)
            {
                lReturn += this.PhenologicalStageAdjustmentList.Max(psa => psa.PhenologicalStageAdjustmentId);
            }
            return lReturn;
        }

        /// <summary>
        /// New ID for DailyRecordList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewDailyRecordListId()
        {
            long lReturn = 1;
            if (this.DailyRecordList != null && this.DailyRecordList.Count > 0)
            {
                lReturn += this.DailyRecordList.Max(dr => dr.DailyRecordId);
            }
            return lReturn;
        }

        /// <summary>
        /// New ID for Titles, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewTitlesId()
        {
            long lReturn = 1;
            if (this.Titles != null)
            {
                lReturn += this.Titles.Max(ti => ti.TitleId);
            }
            return lReturn;
        }

        /// <summary>
        /// New ID for Messages, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewMessagesId()
        {
            long lReturn = 1;
            if (this.Messages != null)
            {
                lReturn += this.Messages.Max(me => me.MessageId);
            }
            return lReturn;
        }


        /// <summary>
        /// New ID for TitlesDaily, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewTitlesDailyId()
        {
            long lReturn = 1;
            if (this.TitlesDaily != null)
            {
                lReturn += this.TitlesDaily.Max(td => td.TitleId);
            }
            return lReturn;
        }

        /// <summary>
        /// New ID for MessagesDaily, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewMessagesDailyId()
        {
            long lReturn = 1;
            if (this.MessagesDaily != null)
            {
                lReturn += this.MessagesDaily.Max(md => md.MessageId);
            }
            return lReturn;
        }

        #endregion

        #region Calculus Methods

        /// <summary>
        /// Set the CalculusMethodForPhenologicalAdjustment
        /// Also instanciate CropInformationByDate if the Method is by Days After Sowing, else go null.
        /// </summary>
        /// <param name="pCalculusOfPhenologicalStage"></param>
        /// <returns></returns>
        public CropInformationByDate SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage pCalculusOfPhenologicalStage)
        {
            CropInformationByDate lReturn;
            
            this.calculusMethodForPhenologicalAdjustment = pCalculusOfPhenologicalStage;

            if(pCalculusOfPhenologicalStage == Utilities.Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing)
            {
                this.CropInformationByDate = new CropInformationByDate(this.Crop.Specie, this.SowingDate, 
                                                                    this.Crop.CropCoefficient, this.Crop.Region,
                                                                    this.Crop.PhenologicalStageList);
            }

            if(pCalculusOfPhenologicalStage == Utilities.Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays)
            {
                this.CropInformationByDateId = 0;
            }

            lReturn = this.CropInformationByDate;
            return lReturn;
        }

        /// <summary>
        /// Return the Days After Sowing for Modified Growing Degree
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowingForGrowingDegreeDaysModified()
        {
            int lReturn = 0;
            int lDaysAfterSowing = 0;
            Double lLastGrowingDegreeDaysRegistry = 0;
            DateTime lDate = Utils.MIN_DATETIME;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate;
            
            lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

            foreach (DailyRecord lDailyRecordItem in lDailyRecordOrderByDate)
            {
                if (this.GrowingDegreeDaysModified <= lDailyRecordItem.GrowingDegreeDaysAccumulated 
                    && this.GrowingDegreeDaysModified > lLastGrowingDegreeDaysRegistry)
                {
                    lDate = lDailyRecordItem.DailyRecordDateTime;
                    lDaysAfterSowing = Utils.GetDaysDifference(this.SowingDate, lDate);
                    break;
                }
                lLastGrowingDegreeDaysRegistry = lDailyRecordItem.GrowingDegreeDaysAccumulated;
            }

            lReturn = lDaysAfterSowing;
            return lReturn;
        }

        /// <summary>
        /// Verify the need of water for Irrigation
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        public void VerifyNeedForIrrigation(DateTime pDateTime, DateTime pDateOfReference)
        {
            Triple<Double, Utils.WaterInputType, bool> lNeedForIrrigationTriple;
            Pair<Double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            Double lQuantityOfWaterToIrrigate;
            Utils.WaterInputType lTypeOfIrrigation;
            bool lIsExtraIrrigation;
            Utils.NoIrrigationReason lReason;
            String lObservations;
            Water.Irrigation lHaveIrrigation;

            lNeedForIrrigationTriple = this.HowMuchToIrrigate(pDateTime);
            lQuantityOfWaterToIrrigate = lNeedForIrrigationTriple.First;
            lTypeOfIrrigation = lNeedForIrrigationTriple.Second;
            lIsExtraIrrigation = lNeedForIrrigationTriple.Third;
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lQuantityOfWaterToIrrigate, lTypeOfIrrigation);
            lReason = Utils.NoIrrigationReason.Other;

            //Get the irrigation for the day
            lHaveIrrigation = this.GetIrrigationByDay(pDateTime);

            //Is an extra irrigation
            if (!this.HasAdviseOfIrrigation && lIsExtraIrrigation && lQuantityOfWaterToIrrigate > 0)
            {
                this.HasAdviseOfIrrigation = true;
                lObservations = "Add Irrigation OK.";
                if(lHaveIrrigation == null)
                {
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                }
                //Extra Irrigation always goes.
                else
                {
                    lObservations = "Add Extra Irrigation. Before: " + lHaveIrrigation.Observations;
                    if (lHaveIrrigation.Reason == Utils.NoIrrigationReason.MoveIrrigation)
                    {
                        lReason = lHaveIrrigation.Reason;
                    }
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                }
            }
            //If it has not advise of Irrigation is a new irrigation
            else if (!this.HasAdviseOfIrrigation && lQuantityOfWaterToIrrigate > 0)
            {
                this.HasAdviseOfIrrigation = true;
                lObservations = "Add Irrigation OK.";
                if (lHaveIrrigation == null)
                {
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                    //If we insert more water, we have to recalculate.
                    this.AddDailyRecordToList(pDateTime, pDateTime.ToShortDateString(), pDateOfReference);
                }
                //Irrigation not Decided.
                else if (lHaveIrrigation.Input == 0 && lHaveIrrigation.ExtraDate == Utils.MIN_DATETIME)
                {
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                    //If we insert more water, we have to recalculate.
                    this.AddDailyRecordToList(pDateTime, pDateTime.ToShortDateString(), pDateOfReference);
                }
            }
            //If Quantity is 0 and is an Extra Irrigation
            else if (!this.HasAdviseOfIrrigation && lQuantityOfWaterToIrrigate == 0 && lIsExtraIrrigation)
            {
                this.HasAdviseOfIrrigation = true;
                if (lTypeOfIrrigation == Utils.WaterInputType.CantIrrigate)
                {
                    lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                    lObservations = "Cant Irrigate.";
                }
                else
                {
                    lReason = Utils.NoIrrigationReason.MoveIrrigation;
                    lObservations = "Move Irrigation.";
                }
                this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            //If Quantity is 0 and has Type of Irrigation, it insert an Extra Irrigation in 0.
            else if (!this.HasAdviseOfIrrigation && lQuantityOfWaterToIrrigate == 0 
                && (lTypeOfIrrigation == Utils.WaterInputType.IrrigationByETCAcumulated 
                || lTypeOfIrrigation == Utils.WaterInputType.IrrigationByHydricBalance
                || lTypeOfIrrigation == Utils.WaterInputType.CantIrrigate))
            {
                this.HasAdviseOfIrrigation = true;
                lIsExtraIrrigation = true;
                if (lTypeOfIrrigation == Utils.WaterInputType.CantIrrigate)
                {
                    lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                    lObservations = "Cant Irrigate.";
                }
                else
                {
                    lReason = Utils.NoIrrigationReason.MoveIrrigation;
                    lObservations = "Move Irrigation.";
                }
                if (lHaveIrrigation == null)
                {
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                }
            }
            //We have a calculated irrigation or need of irrigation
            else if (!this.HasAdviseOfIrrigation &&
                    (lHaveIrrigation != null && (lHaveIrrigation.Type == Utils.WaterInputType.IrrigationByETCAcumulated
                                              || lHaveIrrigation.Type == Utils.WaterInputType.IrrigationByHydricBalance
                                              || lHaveIrrigation.Type == Utils.WaterInputType.Irrigation)
                && lTypeOfIrrigation == Utils.WaterInputType.IrrigationWasNotDecided))
            {
                this.HasAdviseOfIrrigation = true;
                //Do Nothing.
            }
            //Only add a new record to Irrigation List
            else if (!this.HasAdviseOfIrrigation && lQuantityOfWaterToIrrigate == 0
                     && lTypeOfIrrigation == Utils.WaterInputType.IrrigationWasNotDecided)
            {
                this.HasAdviseOfIrrigation = true;
                lIsExtraIrrigation = false;
                lReason = Utils.NoIrrigationReason.NotDecided;
                lObservations = "Irrigation not Decided.";
                if (lHaveIrrigation == null)
                {
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                }
            }
            //Exit of recursion
            else
            {
                this.HasAdviseOfIrrigation = true;
                //Do Nothing.
            }
        }

        /// <summary>
        /// Add Information To IrrigationUnits from some Date 
        /// </summary>
        /// <param name="pFromDate"></param>
        /// <param name="pToDate"></param>
        public void AddInformationToIrrigationUnits(DateTime pFromDate, DateTime pToDate)
        {
            DateTime lToDate = Utils.MAX_DATETIME;
            DateTime lFromDate = Utils.MIN_DATETIME;
            Double lCropDays = 0;
            Double lDiffDays = 0;
            DateTime lDateOfRecord;
            DateTime lDateOfReference;
            String lObservation = String.Empty;

            try
            {
                lFromDate = pFromDate.Date;
                if (lFromDate != null && lFromDate >= this.SowingDate)
                {
                    //Start to calculate one day after Sowing or later
                    lFromDate = Utils.MaxDateTimeBetween(lFromDate, this.SowingDate.AddDays(1));
                    lCropDays = lFromDate.Subtract(this.SowingDate).TotalDays;

                    lDateOfReference = Utils.GetDateOfReference().Value;

                    if (pToDate != null && pToDate <= this.HarvestDate && lFromDate <= pToDate)
                    {
                        lToDate = Utils.MinDateTimeBetween(pToDate.AddDays(InitialTables.DAYS_FOR_PREDICTION),
                                                            this.HarvestDate);
                        lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

                        RemoveIrrigationList(lFromDate);

                        for (int i = 0; i < lDiffDays; i++)
                        {
                            lObservation = "Día " + (lCropDays + i);
                            lDateOfRecord = lFromDate.AddDays(i);
                            this.HasAdviseOfIrrigation = false;

                            this.AddDailyRecordToList(lDateOfRecord, lObservation, lDateOfReference);
                            //Adjustment of Phenological Stage
                            foreach (PhenologicalStageAdjustment item in this.PhenologicalStageAdjustmentList)
                            {
                                if (item.DateOfChange.Equals(lDateOfRecord))
                                {
                                    AdjustmentPhenology(item.Stage, item.DateOfChange);
                                    break;
                                }
                            }

                            //when arrives to final Stage, do not add new irrigation
                            if (this.PhenologicalStage.Stage.StageId == this.Crop.StopIrrigationStageId)
                            {
                                //System.Diagnostics.Debugger.Break();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddInformationToIrrigationUnits " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
        }

        #region With Context

        /// <summary>
        /// Verify the need of water for Irrigation. With Context
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        public void VerifyNeedForIrrigation(DateTime pDateTime, DateTime pDateOfReference, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            Triple<Double, Utils.WaterInputType, bool> lNeedForIrrigationTriple;
            Pair<Double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            Double lNewQuantityOfWaterToIrrigate;
            Utils.WaterInputType lNewTypeOfIrrigation;
            bool lIsExtraIrrigation;
            Utils.NoIrrigationReason lReason;
            String lObservations;
            Water.Irrigation lHaveIrrigation;
            int lDatabaseChangeResult = 0;

            try
            {
                lNeedForIrrigationTriple = this.HowMuchToIrrigate(pDateTime);
                lNewQuantityOfWaterToIrrigate = lNeedForIrrigationTriple.First;
                lNewTypeOfIrrigation = lNeedForIrrigationTriple.Second;
                lIsExtraIrrigation = lNeedForIrrigationTriple.Third;
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lNewQuantityOfWaterToIrrigate, lNewTypeOfIrrigation);
                lReason = Utils.NoIrrigationReason.Other;

                //Get the irrigation for the day
                lHaveIrrigation = this.GetIrrigationByDay(pDateTime);

                //Is an extra irrigation
                if (!this.HasAdviseOfIrrigation && lIsExtraIrrigation && lNewQuantityOfWaterToIrrigate > 0)
                {
                    this.HasAdviseOfIrrigation = true;
                    lObservations = "Add Irrigation OK.";
                    if (lHaveIrrigation == null)
                    {
                        this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations); 
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    }
                    //Extra Irrigation always goes.
                    else 
                    {
                        lObservations = "Add Extra Irrigation. Before: " + lHaveIrrigation.Observations;
                        if(lHaveIrrigation.Reason == Utils.NoIrrigationReason.MoveIrrigation)
                        {
                            lReason = lHaveIrrigation.Reason;
                        }
                        this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    }
                }
                //New Irrigation, add a new Daily Record
                else if (!this.HasAdviseOfIrrigation && lNewQuantityOfWaterToIrrigate > 0)
                {
                    this.HasAdviseOfIrrigation = true;
                    lObservations = "Add Irrigation OK.";
                    if (lHaveIrrigation == null)
                    {
                        this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                        //We add a new Daily Record because we add water to the equation
                        this.AddDailyRecordToList(pDateTime, pDateTime.ToShortDateString(), pDateOfReference, pIrrigationAdvisorContext);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    }
                    //Irrigation not Decided.
                    else if(lHaveIrrigation.Input == 0 && lHaveIrrigation.ExtraDate == Utils.MIN_DATETIME)
                    {
                        this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                        //We add a new Daily Record because we add water to the equation
                        this.AddDailyRecordToList(pDateTime, pDateTime.ToShortDateString(), pDateOfReference, pIrrigationAdvisorContext);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    }
                }
                //If Quantity is 0 and is an Extra Irrigation
                else if (!this.HasAdviseOfIrrigation && lNewQuantityOfWaterToIrrigate == 0 && lIsExtraIrrigation)
                {
                    this.HasAdviseOfIrrigation = true;
                    if (lNewTypeOfIrrigation == Utils.WaterInputType.CantIrrigate)
                    {
                        lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                        lObservations = "Cant Irrigate.";
                    }
                    else
                    {
                        lReason = Utils.NoIrrigationReason.MoveIrrigation;
                        lObservations = "Move Irrigation.";
                    }
                    this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                    lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                }
                //Is used when we move an Irrigation or we can not irrigate
                else if (!this.HasAdviseOfIrrigation && lNewQuantityOfWaterToIrrigate == 0
                    && (lNewTypeOfIrrigation == Utils.WaterInputType.IrrigationByETCAcumulated
                    || lNewTypeOfIrrigation == Utils.WaterInputType.IrrigationByHydricBalance
                    || lNewTypeOfIrrigation == Utils.WaterInputType.CantIrrigate))
                {
                    this.HasAdviseOfIrrigation = true;
                    lIsExtraIrrigation = true;
                    if (lNewTypeOfIrrigation == Utils.WaterInputType.CantIrrigate)
                    {
                        lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                        lObservations = "Cant Irrigate.";
                    }
                    else
                    {
                        lReason = Utils.NoIrrigationReason.MoveIrrigation;
                        lObservations = "Move Irrigation.";
                    }
                    if (lHaveIrrigation == null)
                    {
                        this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    }
                }
                //We have a calculated irrigation or need of irrigation
                //Do not add not decided irrigation
                else if (!this.HasAdviseOfIrrigation &&
                        (lHaveIrrigation != null && (lHaveIrrigation.Type == Utils.WaterInputType.IrrigationByETCAcumulated
                                                  || lHaveIrrigation.Type == Utils.WaterInputType.IrrigationByHydricBalance 
                                                  || lHaveIrrigation.Type == Utils.WaterInputType.Irrigation)
                    && lNewTypeOfIrrigation == Utils.WaterInputType.IrrigationWasNotDecided))
                {
                    this.HasAdviseOfIrrigation = true;
                    //Do Nothing.
                }
                //We have the not decided irrigation yet. Only add a new record to Irrigation List
                else if (!this.HasAdviseOfIrrigation && lNewQuantityOfWaterToIrrigate == 0 
                         && lNewTypeOfIrrigation == Utils.WaterInputType.IrrigationWasNotDecided)
                {
                    this.HasAdviseOfIrrigation = true;
                    lIsExtraIrrigation = false;
                    lReason = Utils.NoIrrigationReason.NotDecided;
                    lObservations = "Irrigation not Decided.";
                    if (lHaveIrrigation == null)
                    {
                        this.AddOrUpdateIrrigationDataToList(pDateTime, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
                        lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    }
                }
                //Exit of recursion
                else
                {
                    this.HasAdviseOfIrrigation = true;
                    //Do Nothing
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.VerifyNeedForIrrigation " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }         
        }


        /// <summary>
        /// Add Information To IrrigationUnits from some Date with Context
        /// </summary>
        /// <param name="pFromDate"></param>
        /// <param name="pToDate"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        public void AddInformationToIrrigationUnits(DateTime pFromDate, DateTime pToDate,
                                                    IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            DateTime lToDate = Utils.MAX_DATETIME;
            DateTime lFromDate = Utils.MIN_DATETIME;
            Double lCropDays = 0;
            Double lDiffDays = 0;
            DateTime lDateOfRecord;
            DateTime lDateOfReference;
            String lObservation = String.Empty;
            int lDatabaseChangeResult = 0;

            try
            {
                lFromDate = pFromDate.Date;
                if (lFromDate != null && lFromDate >= this.SowingDate)
                {
                    //Start to calculate one day after Sowing or later
                    lFromDate = Utils.MaxDateTimeBetween(lFromDate, this.SowingDate.AddDays(1));
                    lCropDays = lFromDate.Subtract(this.SowingDate).TotalDays;

                    /* We limit to enter the new future daily record with the next condition 
                    lFromDate <= pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION)
                    */
                    lDateOfReference = Utils.GetDateOfReference().Value;

                    if (pToDate != null && pToDate.Date <= this.HarvestDate.Date 
                        && lFromDate.Date <= pToDate.AddDays(InitialTables.DAYS_FOR_PREDICTION))
                    {
                        lToDate = Utils.MinDateTimeBetween(pToDate.AddDays(InitialTables.DAYS_FOR_PREDICTION),
                                                            this.HarvestDate);
                        lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

                        RemoveIrrigationList(lFromDate.Date, pIrrigationAdvisorContext);

                        for (int i = 0; i < lDiffDays; i++)
                        {
                            lObservation = "Día " + (lCropDays + i);
                            lDateOfRecord = lFromDate.AddDays(i);
                            this.HasAdviseOfIrrigation = false;

                            this.AddDailyRecordToList(lDateOfRecord, lObservation, lDateOfReference, pIrrigationAdvisorContext);

                            //Save Changes to Database
                            lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();

                            //Adjustment of Phenological Stage
                            foreach (PhenologicalStageAdjustment item in this.PhenologicalStageAdjustmentList)
                            {
                                if (item.DateOfChange.Equals(lDateOfRecord))
                                {
                                    AdjustmentPhenology(item.Stage, item.DateOfChange);
                                    break;
                                }
                            }
                            
                            //when arrives to final Stage, do not add new irrigation
                            if (this.PhenologicalStage.Stage.StageId == this.Crop.StopIrrigationStageId)
                            {
                                //System.Diagnostics.Debugger.Break();
                            }

                            var hydricBalancesAdjustments = pIrrigationAdvisorContext
                                                            .HydricBalanceAdjustments
                                                            .Where(n => n.CropIrrigationWeatherId == this.cropIrrigationWeatherId).ToList();

                            ApplyHydricBalanceAdjustments(hydricBalancesAdjustments, lDateOfRecord);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddInformationToIrrigationUnits " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
        }

        #endregion

        #endregion

        #region Evapotranspiration

        /// <summary>
        /// If EvapotranspirationCrop exists in List, return the Evapotranspiration Crop, 
        /// else return null
        /// </summary>
        /// <param name="pEvapotranspirationCrop"></param>
        /// <returns></returns>
        public EvapotranspirationCrop ExistEvapotranspirationCrop(EvapotranspirationCrop pEvapotranspirationCrop)
        {
            EvapotranspirationCrop lReturn = null;
            foreach (EvapotranspirationCrop item in this.EvapotranspirationCropList)
            {
                if(item.Equals(pEvapotranspirationCrop))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a EvapotranspirationCrop to List if not exists,
        /// if exists return null
        /// </summary>
        /// <param name="pDate"></param>
        /// <param name="pOutput"></param>
        /// <returns></returns>
        public EvapotranspirationCrop AddEvapotranspirationCrop (DateTime pDate, Double pOutput)
        {
            EvapotranspirationCrop lReturn = null;
            EvapotranspirationCrop lEvapotranspirationCrop = new EvapotranspirationCrop(pDate, pOutput,
                                                                    this.CropIrrigationWeatherId);

            if(ExistEvapotranspirationCrop(lEvapotranspirationCrop) == null)
            {
                this.EvapotranspirationCropList.Add(lEvapotranspirationCrop);
                lReturn = lEvapotranspirationCrop;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the EvapotranspirationCrop if exists in List, else return null
        /// </summary>
        /// <param name="pDate"></param>
        /// <param name="pOutput"></param>
        /// <returns></returns>
        public EvapotranspirationCrop UpdateEvapotranspirationCrop (DateTime pDate, Double pOutput)
        {
            EvapotranspirationCrop lReturn = null;
            EvapotranspirationCrop lEvapotranspirationCrop = new EvapotranspirationCrop(pDate, pOutput,
                                                                this.CropIrrigationWeatherId);

            lReturn = ExistEvapotranspirationCrop(lEvapotranspirationCrop);
            if(lReturn != null)
            {
                lReturn.Date = pDate;
                lReturn.Output = pOutput;
                lReturn.CropIrrigationWeatherId = this.cropIrrigationWeatherId;
            }
            return lReturn;
        }

        /// <summary>
        /// Gives the evapoTranspiration registered in a specific date including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public double GetEvapotranspirationCropFromDailyRecord(DateTime pDate)
        {
            double lRetrun = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lRetrun = lDailyRec.EvapotranspirationCrop.Output + lDailyRec.EvapotranspirationCrop.ExtraOutput;
                    break;
                }
            }
            return lRetrun;
        }

        /// <summary>
        /// Gives the Evapotranspiration registered in a Date 
        /// and the two days before, including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public Double GetLastThreeDaysOfEvapotranspirationCropFromDailyRecord(DateTime pDate)
        {
            Double lRetrun = 0;
            DateTime oneDayBefore = pDate.AddDays(-1);
            DateTime twoDaysBefore = pDate.AddDays(-2);
            DateTime oneDayAfter = pDate.AddDays(1);
            Double lEvapotranspirationCrop = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, pDate.Date) 
                    || Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, oneDayBefore.Date) 
                    || Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, twoDaysBefore.Date))
                {
                    lEvapotranspirationCrop += lDailyRec.EvapotranspirationCrop.Output + lDailyRec.EvapotranspirationCrop.ExtraOutput;
                }
                else if(Utils.IsTheSameDay(lDailyRec.DailyRecordDateTime.Date, oneDayAfter.Date))
                {
                    break;
                }
            }

            lRetrun = lEvapotranspirationCrop;
            return lRetrun;
        }

        #endregion

        #region CropData

        /// <summary>
        /// Get Region from Crop
        /// </summary>
        /// <returns></returns>
        public Region GetCropRegion()
        {
            Region lReturn;
            Region lRegion = null;

            lRegion = this.Crop.Region;

            lReturn = lRegion;
            return lReturn;
        }

        /// <summary>
        /// Get Days After Sowing According to a DateTime
        /// </summary>
        /// <returns></returns>
        public int GetDaysAfterSowing(DateTime pDate)
        {
            int lReturn = 0;
            int lDaysAfterSowing = 0;
            DateTime lSowingDate;

            lSowingDate = this.SowingDate;
            lDaysAfterSowing = pDate.Subtract(lSowingDate).Days;

            lReturn = lDaysAfterSowing;
            return lReturn;
        }

        /// <summary>
        /// Get Base Temperature from Crop
        /// </summary>
        /// <returns></returns>
        public Double GetBaseTemperature() 
        {
            Double lReturn;
            Double lBaseTemperature = 0;

            lBaseTemperature = this.Crop.GetBaseTemperature();

            lReturn = lBaseTemperature;
            return lReturn;
        }
        
        /// <summary>
        /// Get Stress Temperature from Crop
        /// </summary>
        /// <returns></returns>
        public Double GetStressTemperature() 
        {
            Double lReturn;
            Double lStressTemperature = 0;

            lStressTemperature = this.Crop.GetStressTemperature();

            lReturn = lStressTemperature;
            return lReturn;
        }

        /// <summary>
        /// Get Max Evapotranspiration to Irrigate from Crop
        /// </summary>
        /// <returns></returns>
        public Double GetMaxEvapotranspirationToIrrigate()
        {
            Double lReturn;
            Double lMaxEvapotranspirationToIrrigate = 0;

            lMaxEvapotranspirationToIrrigate = this.Crop.MaxEvapotranspirationToIrrigate;

            lReturn = lMaxEvapotranspirationToIrrigate;
            return lReturn;
        }

        /// <summary>
        /// Get Soil Depth from Crop Phenological Stage (Hydric Balance Depth)
        /// If exceed the DepthLimit of Soil, it will return the DepthLimit
        /// </summary>
        /// <returns></returns>
        public Double GetDepthTakingIntoAccountSoilDepthLimitBy(PhenologicalStage pPhenologicalStage)
        {
            Double lReturn;
            Double lDepth = 0;

            if (pPhenologicalStage != null)
            {
                if(this.WeatherEventType == Utils.WeatherEventType.LaNinia)
                {
                    lDepth = pPhenologicalStage.HydricBalanceDepth;
                }
                else if(this.WeatherEventType == Utils.WeatherEventType.ElNinio)
                {
                    lDepth = pPhenologicalStage.RootDepth;
                }
                else //By default The same as Ninio
                {
                    lDepth = pPhenologicalStage.RootDepth;
                }
                if (lDepth > this.Soil.DepthLimit)
                {
                    lDepth = this.Soil.DepthLimit;
                }
            }
            else
            {
                //TODO See best answer to GetHydricBalanceDepthTakingIntoAccountSoilDepthLimit Method
                lDepth = this.Soil.DepthLimit;
            }

            lReturn = lDepth;
            return lReturn;
        }

        /// <summary>
        /// Get Root Depth from Crop Phenological Stage if not exceed the DepthLimit of the Soil
        /// </summary>
        /// <returns></returns>
        public Double GetRootDepthTakingIntoAccountSoilDepthLimit(PhenologicalStage pPhenologicalStage)
        {
            Double lReturn;
            Double lRootDepth = 0;

            if (pPhenologicalStage != null)
            {
                lRootDepth = pPhenologicalStage.RootDepth;
                if (lRootDepth > this.Soil.DepthLimit)
                {
                    lRootDepth = this.Soil.DepthLimit;
                }
            }
            else
            {
                //TODO See best answer to GetRootDepthTakingIntoAccountSoilDepthLimit Method
                lRootDepth = this.Soil.DepthLimit;
            }
            lReturn = lRootDepth;
            return lReturn;
        }

        #endregion

        #region SoilData

        /// <summary>
        /// Get the Field Capacity by Root Depth from this Soil
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public Double GetSoilFieldCapacity(double pDepth)
        {
            Double lReturn;
            Double lSoilFieldCapacity = 0;

            if(this.Soil != null)
            {
                lSoilFieldCapacity = this.Soil.GetFieldCapacity(pDepth);
            }

            lReturn = lSoilFieldCapacity;
            return lReturn;
        }

        /// <summary>
        /// Get Soil Permanent Wilting Poing
        /// The data is obtained from Soil depending Root Depth
        /// </summary>
        /// <returns></returns>
        public Double GetSoilPermanentWiltingPoint()
        {
            Double lReturn;
            Double lDepth = 0;
            Double lSoilPermanentWiltingPoint = 0;

            if(this.PhenologicalStage != null && this.Soil != null)
            {
                lDepth = this.GetDepthTakingIntoAccountSoilDepthLimitBy(this.PhenologicalStage);
                lSoilPermanentWiltingPoint = this.Soil.GetPermanentWiltingPoint(lDepth);
            }

            lReturn = lSoilPermanentWiltingPoint;
            return lReturn;
        }

        /// <summary>
        /// Get Soil Available Water Capacity 
        /// From Crop Soil by Root Depth 
        /// </summary>
        /// <returns></returns>
        public Double GetSoilAvailableWaterCapacity()
        {
            Double lReturn;
            Double lDepth = 0;
            Double lSoilAvailableWaterCapacity = 0;

            if(this.PhenologicalStage != null && this.Soil != null)
            {
                lDepth = this.GetDepthTakingIntoAccountSoilDepthLimitBy(this.PhenologicalStage);
                lSoilAvailableWaterCapacity = this.Soil.GetAvailableWaterCapacity(lDepth);
            }

            lReturn = lSoilAvailableWaterCapacity;
            return lSoilAvailableWaterCapacity;
        }
                
        /// <summary>
        /// Get Soil Field Capacity
        /// From Crop Soil by Root Depth
        /// </summary>
        /// <returns></returns>
        public Double GetSoilFieldCapacity()
        {
            Double lReturn;
            Double lDepth = 0;
            Double lSoilFieldCapacity = 0;

            if (this.PhenologicalStage != null && this.Soil != null)
            {
                lDepth = this.GetDepthTakingIntoAccountSoilDepthLimitBy(this.PhenologicalStage);
                lSoilFieldCapacity = this.Soil.GetFieldCapacity(lDepth);
            }

            lReturn = lSoilFieldCapacity;
            return lReturn;
        }

        #endregion

        #region CropWaterData

        /// <summary>
        /// Get Percentage of Hydric Balance vs Field Capacity
        /// 100 %  = Field Capacity
        /// </summary>
        /// <returns></returns>
        public Double GetPercentageOfHydricBalance()
        {
            Double lReturn;
            Double lHydricBalance = 0;
            Double lFieldCapacity = 0;
            //Double lPermanentWiltingPoint = 0;
            Double lPercentageOfWater = 0;

            lHydricBalance = this.HydricBalance;
            lFieldCapacity = this.GetSoilFieldCapacity();
            //lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();
            if (lHydricBalance < 0)
            {
                lPercentageOfWater = 0;
            }
            else
            {
                lPercentageOfWater = Math.Round(((lHydricBalance) * 100)
                                               / (lFieldCapacity), 2);
            }

            lReturn = lPercentageOfWater;
            return lReturn;
        }

        /// <summary>
        /// Get Percentage of Available Water from Hydric Balance vs Field Capacity taking off Permanent Wilting Point
        /// </summary>
        /// <returns></returns>
        public Double GetPercentageOfAvailableWaterTakingIntoAccointPermanentWiltingPoint()
        {
            Double lReturn;
            Double lHydricBalance = 0;
            Double lFieldCapacity = 0;
            Double lPermanentWiltingPoint = 0;
            Double lPercentageOfAvailableWater = 0;

            lHydricBalance = this.HydricBalance;
            lFieldCapacity = this.GetSoilFieldCapacity();
            lPermanentWiltingPoint = this.GetSoilPermanentWiltingPoint();
            if (lHydricBalance < 0)
            {
                lPercentageOfAvailableWater = 0;
            }
            else
            {
                lPercentageOfAvailableWater = Math.Round(((lHydricBalance - lPermanentWiltingPoint) * 100)
                                                        / (lFieldCapacity - lPermanentWiltingPoint), 2);
            }

            lReturn = lPercentageOfAvailableWater;
            return lReturn;
        }

        /// <summary>
        /// Get Initial Hydric Balance 
        /// (Fiel Capacity for Initial Root Depth)
        /// </summary>
        /// <returns></returns>
        public Double GetInitialHydricBalance()
        {
            Double lReturn = 0;
            Double lFieldCapacity = 0;
            
            lFieldCapacity = this.GetSoilFieldCapacity(InitialTables.INITIAL_ROOT_DEPTH);

            lReturn = lFieldCapacity;
            return lReturn;
        }

        #endregion

        #region CropIrrigationWeatherData

        /// <summary>
        /// Get Irrigation from irrigation list By Date
        /// </summary>
        /// <param name="pDayOfIrrigation"></param>
        /// <returns></returns>
        public Water.Irrigation GetIrrigationByDay(DateTime pDayOfIrrigation)
        {
            Water.Irrigation lReturn = null;
            Water.Irrigation lCantIrrigate = null;
            Water.Irrigation lIrrigation = null;
            IrrigationAdvisorContext lContext;
            Water.Irrigation lCantIrrigateFromBase = null;
            Water.Irrigation lIrrigationFromBase = null;

            //find if there is an cant irrigate
            lCantIrrigate = this.IrrigationList.Where(irrigation => Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)
                                                && irrigation.Type == Utils.WaterInputType.CantIrrigate).FirstOrDefault();

            if (lCantIrrigate == null)
            {
                lContext = IrrigationAdvisorContext.Instance();
                lCantIrrigateFromBase = lContext.Irrigations.ToList()
                                            .Where(irrigation => irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                                    && Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)
                                                    && irrigation.Type == Utils.WaterInputType.CantIrrigate).FirstOrDefault();
                if (lCantIrrigateFromBase == null)
                {
                    lIrrigation = this.IrrigationList.Where(irrigation => Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)).FirstOrDefault();
                    if(lIrrigation == null)
                    {
                        lIrrigationFromBase = lContext.Irrigations.ToList()
                                            .Where(irrigation => irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                                    && Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)).FirstOrDefault();

                        lReturn = lIrrigationFromBase;
                    }
                    else
                    {
                        lReturn = lIrrigation;
                    }
                }
                else
                {
                    lReturn = lCantIrrigateFromBase;
                }
            }
            else
            {
                lReturn = lCantIrrigate;
            }

            return lReturn;
        }

        /// <summary>
        /// Return an irrigation for a day or create new if don't exists.
        /// </summary>
        /// <param name="pDayOfIrrigation"></param>
        /// <returns></returns>
        public Water.Irrigation GetIrrigationOrCreateNew(DateTime pDayOfIrrigation)
        {
            Water.Irrigation lReturn = null;
            Water.Irrigation lIrrigation = null;
            IrrigationAdvisorContext lContext;
            List<Water.Irrigation> lIrrigationListFromBase;

            /********* BEGIN WORKAROUND ***************/
            // There are cases when in the IrrigationList aren't irrigations.
            // This is because the context is a singleton implementation and doesn't update the new records if this method is called after an operation
            // that update records in the database.

            lIrrigation = this.IrrigationList.Where(irrigation => Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)).FirstOrDefault();

            // If the application doesn't find irrigation then it try to find in the database records.
            if (lIrrigation == null)
            {
                lContext = IrrigationAdvisorContext.Instance();
                // Get the updated records from the database and Filter records by date.
                lIrrigationListFromBase = lContext.Irrigations.ToList().Where(irrigation => irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                                                    && Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)).ToList();

                lIrrigation = lIrrigationListFromBase.Where(irrigation => Utils.IsTheSameDay(irrigation.Date, pDayOfIrrigation)).FirstOrDefault();
            }

            /************ END WORKAROUND *************/

            //If we didnt find an Irrigation, we create a NOT DECIDED Irrigation
            if (lIrrigation == null)
            {
                lIrrigation = new Water.Irrigation();
                lIrrigation.WaterInputId = this.GetNewIrrigationListId();
                lIrrigation.Date = pDayOfIrrigation;
                lIrrigation.Input = 0;
                lIrrigation.Type = Utils.WaterInputType.IrrigationWasNotDecided;
                lIrrigation.CropIrrigationWeatherId = this.cropIrrigationWeatherId;
                lIrrigation.CropIrrigationWeather = this;
                lIrrigation.Reason = Utils.NoIrrigationReason.NotDecided;
                this.IrrigationList.Add(lIrrigation);
            }

            lReturn = lIrrigation;
            return lReturn;
        }

        /// <summary>
        /// Get Rain from Rain List By Date
        /// </summary>
        /// <param name="pDayOfRain"></param>
        /// <returns></returns>
        public Rain GetRain(DateTime pDayOfRain)
        {
            Rain lReturn = null;
            Rain lRain = null;

            foreach (Rain lRainItem in this.RainList)
            {
                if (Utils.IsTheSameDay(lRainItem.Date, pDayOfRain))
                {
                    lRain = lRainItem;
                    break;
                }
            }

            lReturn = lRain;
            return lReturn;
        }

        /// <summary>
        /// Get the Hydric Balance from CropIrrigationWeather
        /// </summary>
        /// <returns></returns>
        public Double GetHydricBalance()
        {
            Double lReturn = 0;
            Double lHydricBalance = 0;

            lHydricBalance = this.HydricBalance;

            lReturn = lHydricBalance;
            return lReturn;
        }

        /// <summary>
        /// Get Total Evapotranspiration Crop from last important water output
        /// </summary>
        /// <returns></returns>
        public Double GetTotalEvapotranspirationCropFromLastWaterInput()
        {
            Double lReturn = 0;
            Double lTotalEvapotranspirationCropFromLastWaterInput = 0;

            lTotalEvapotranspirationCropFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput;

            lReturn = lTotalEvapotranspirationCropFromLastWaterInput;
            return lReturn;
        }

        #endregion

        #region Weather
        
        /// <summary>
        /// Add or Update the Irrigation Data to List
        /// </summary>
        /// <param name="lIrrigationDate"></param>
        /// <param name="pQuantityOfWaterToIrrigateAndTypeOfIrrigation"></param>
        /// <param name="pIsExtraIrrigation"></param>
        /// <param name="lReason"></param>
        /// <param name="lObservations"></param>
        public void AddOrUpdateIrrigationDataToList(DateTime pIrrigationDate,
                                                    Pair<Double, Utils.WaterInputType> pQuantityOfWaterToIrrigateAndTypeOfIrrigation,
                                                    bool pIsExtraIrrigation, Utils.NoIrrigationReason pReason, String pObservations)
        {
            #region Local variables
            Water.Irrigation lNewIrrigation = null;
            Water.Irrigation lOldIrrigation = null;
            Water.Irrigation lOldIrrigationNextDate = null;
            DailyRecord lDailyRecordIrrigationNextDate = null;
            bool lOldIrrigationWasNotDecided = false;
            bool lOldIrrigationNextDateWasNotDecided = false;
            int lIrrigationCount;
            DateTime lIrrigationDate;
            Double lNewQuantityOfWaterToIrrigate;
            Utils.WaterInputType lNewTypeOfIrrigation;
            bool lIsExtraIrrigation;
            Utils.NoIrrigationReason lReason = Utils.NoIrrigationReason.Other;
            String lObservations;
            
            #endregion

            try
            {
                #region init local variables
                lIrrigationDate = pIrrigationDate;
                lNewQuantityOfWaterToIrrigate = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                lNewTypeOfIrrigation = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.Second;
                lIsExtraIrrigation = pIsExtraIrrigation;
                lReason = pReason;
                lObservations = pObservations;

                lOldIrrigation = this.GetIrrigationByDay(lIrrigationDate);
                lOldIrrigationNextDate = this.GetIrrigationByDay(lIrrigationDate.AddDays(1));
                if(lOldIrrigation != null)
                {
                    lOldIrrigationWasNotDecided = lOldIrrigation.Type == Utils.WaterInputType.IrrigationWasNotDecided;
                }
                if (lOldIrrigationNextDate != null)
                {
                    lOldIrrigationNextDateWasNotDecided = lOldIrrigationNextDate.Type == Utils.WaterInputType.IrrigationWasNotDecided;
                }
                
                #endregion

                //Condition1: (No old Irrigation or is NotDecided) and New Quantity Of Water To Irrigate > 0
                #region Condition #1 NEW IRRIGATION: If there is not a registry of irrigation, then it is created 
                if ((lOldIrrigation == null || lOldIrrigationWasNotDecided) && lNewQuantityOfWaterToIrrigate > 0)
                {
                    if (lOldIrrigation == null)
                    {
                        lNewIrrigation = new Water.Irrigation();
                        lNewIrrigation.WaterInputId = this.GetNewIrrigationListId();
                        lNewIrrigation.Date = lIrrigationDate;
                        if (lIsExtraIrrigation)
                        {
                            lNewIrrigation.ExtraInput = lNewQuantityOfWaterToIrrigate;
                            lNewIrrigation.ExtraDate = lIrrigationDate;
                            lNewIrrigation.Input = 0;
                        }
                        else
                        {
                            lNewIrrigation.Input = lNewQuantityOfWaterToIrrigate;
                        }
                        // Set the type of lIrrigationItem. 
                        lNewIrrigation.Type = lNewTypeOfIrrigation;
                        lNewIrrigation.Reason = lReason;
                        lNewIrrigation.Observations = lObservations;
                        lNewIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        //lNewIrrigation.CropIrrigationWeather = this; 

                        this.IrrigationList.Add(lNewIrrigation);
                    }
                    else
                    {
                        lOldIrrigation.Date = lIrrigationDate;
                        lOldIrrigation.ExtraDate = Utilities.Utils.MIN_DATETIME;
                        lOldIrrigation.ExtraInput = 0;
                        if (lIsExtraIrrigation)
                        {
                            lOldIrrigation.ExtraInput = lNewQuantityOfWaterToIrrigate;
                            lOldIrrigation.ExtraDate = lIrrigationDate;
                            lOldIrrigation.Input = 0;
                        }
                        else
                        {
                            lOldIrrigation.Input = lNewQuantityOfWaterToIrrigate;
                        }
                        // Set the type of lIrrigationItem. 
                        lOldIrrigation.Type = lNewTypeOfIrrigation;
                        lOldIrrigation.Reason = lReason;
                        lOldIrrigation.Observations = lObservations;
                        lOldIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        //lOldIrrigation.CropIrrigationWeather = this; 
                    }
                }
                #endregion

                //Condition2: (No old Irrigation or is NotDecided) and (New Quantity == 0 and Extra Irrigation and Type not in (CantIrrigate, IrrigationWasNotDecided)
                #region Condition #2 NEW IRRIGATION NOT TO IRRIGATE: There is not registry then it is created (if they are Extra)
                else if ((lOldIrrigation == null || lOldIrrigationWasNotDecided) &&
                            lNewQuantityOfWaterToIrrigate == 0 && lIsExtraIrrigation &&
                            (lNewTypeOfIrrigation != Utils.WaterInputType.CantIrrigate &&
                            lNewTypeOfIrrigation != Utils.WaterInputType.IrrigationWasNotDecided))
                {
                    if (lOldIrrigation == null)
                    {
                        lNewIrrigation = new Water.Irrigation();
                        lNewIrrigation.WaterInputId = this.GetNewIrrigationListId();
                        lNewIrrigation.Date = lIrrigationDate;
                        lNewIrrigation.ExtraInput = lNewQuantityOfWaterToIrrigate;
                        lNewIrrigation.ExtraDate = lIrrigationDate;

                        // Set the type of lIrrigationItem. 
                        lNewIrrigation.Type = lNewTypeOfIrrigation;
                        lNewIrrigation.Reason = lReason;
                        lNewIrrigation.Observations = lObservations;
                        lNewIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        //lNewIrrigation.CropIrrigationWeather = this;
                        this.IrrigationList.Add(lNewIrrigation);
                    } 
                    else
                    {
                        lOldIrrigation.Input = 0;
                        lOldIrrigation.Date = lIrrigationDate;
                        lOldIrrigation.ExtraInput = lNewQuantityOfWaterToIrrigate;
                        lOldIrrigation.ExtraDate = lIrrigationDate;

                        // Set the type of lIrrigationItem. 
                        lOldIrrigation.Type = lNewTypeOfIrrigation;
                        lOldIrrigation.Reason = lReason;
                        lOldIrrigation.Observations = lObservations;
                        lOldIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        //lOldIrrigation.CropIrrigationWeather = this;
                    }
                }
                #endregion

                //Condition3: (Is an Old Irrigation and Not is NotDecided and New Quantity == 0) and Type not in (CantIrrigate, IrrigationWasNotDecided) 
                #region Condition #3 IRRIGATION TO NEXT DAY: If there is an Irrigation Registry and new Irrigation Input is 0, Input goes for tomorrow
                else if (lOldIrrigation != null && !lOldIrrigationWasNotDecided &&
                            lNewQuantityOfWaterToIrrigate == 0 &&
                            (lNewTypeOfIrrigation != Utils.WaterInputType.CantIrrigate &&
                            lNewTypeOfIrrigation != Utils.WaterInputType.IrrigationWasNotDecided))
                {
                    //If quentity of water is 0, the user want to move the irrigation on day
                    if (lOldIrrigationNextDate != null && !lOldIrrigationNextDateWasNotDecided)
                    {
                        lOldIrrigationNextDate.ExtraInput += lOldIrrigation.Input;
                        lOldIrrigationNextDate.ExtraDate = lIrrigationDate.AddDays(1);
                        lOldIrrigationNextDate.Type = lNewTypeOfIrrigation;
                        lOldIrrigationNextDate.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        lOldIrrigationNextDate.CropIrrigationWeather = this;
                        lOldIrrigationNextDate.Observations += "The irrigation was moved one day.";
                        lOldIrrigationNextDate.Reason = Utils.NoIrrigationReason.Other;
                    }
                    else if (lOldIrrigationNextDate != null && lOldIrrigationNextDateWasNotDecided)
                    {
                        lOldIrrigationNextDate.Input = 0;
                        lOldIrrigationNextDate.ExtraInput = lOldIrrigation.Input;
                        lOldIrrigationNextDate.ExtraDate = lIrrigationDate.AddDays(1);
                        lOldIrrigationNextDate.Type = lNewTypeOfIrrigation;
                        lOldIrrigationNextDate.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        lOldIrrigationNextDate.CropIrrigationWeather = this;
                        lOldIrrigationNextDate.Observations = "The irrigation was moved one day.";
                        lOldIrrigationNextDate.Reason = Utils.NoIrrigationReason.Other;
                    }
                    else if (lOldIrrigationNextDate == null)
                    {
                        //insert the new irrigation in extra irrigation, not to delete the irrigation in the add daily record method.
                        lOldIrrigationNextDate = new Water.Irrigation();
                        lOldIrrigationNextDate.WaterInputId = this.GetNewIrrigationListId();
                        lOldIrrigationNextDate.ExtraDate = lIrrigationDate.AddDays(1);
                        lOldIrrigationNextDate.ExtraInput += lOldIrrigation.Input;
                        lOldIrrigationNextDate.Type = lOldIrrigation.Type;
                        lOldIrrigationNextDate.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        lOldIrrigationNextDate.CropIrrigationWeather = this;
                        lOldIrrigationNextDate.Observations = "The irrigation was moved one day.";
                        lOldIrrigationNextDate.Reason = Utils.NoIrrigationReason.Other;
                        this.IrrigationList.Add(lOldIrrigationNextDate);
                    }
                    //the irrigation update to 0 for today
                    lOldIrrigation.Input = 0;
                    lOldIrrigation.ExtraInput = 0;
                    lOldIrrigation.ExtraDate = lOldIrrigation.Date;
                    lOldIrrigation.Type = Utils.WaterInputType.CantIrrigate;
                    lOldIrrigation.Observations = "The irrigation is moved one day. Before: " + lOldIrrigation.Observations;
                    lOldIrrigation.Reason = Utils.NoIrrigationReason.MoveIrrigation;
                    lDailyRecordIrrigationNextDate = this.DailyRecordList.Find(dr => dr.DailyRecordDateTime.Date == lOldIrrigation.Date.AddDays(1).Date);
                    if (lDailyRecordIrrigationNextDate != null)
                    {
                        lDailyRecordIrrigationNextDate.IrrigationId = lOldIrrigationNextDate.WaterInputId;
                        lDailyRecordIrrigationNextDate.Irrigation = lOldIrrigationNextDate;
                    }
                }
                #endregion

                //Confition4: (Is an Old Irrigation and New Quantity > 0)
                #region Condition #4 UPDATE IRRIGATION: If there is an Irrigation Registry it is updated
                else if (lOldIrrigation != null && lNewQuantityOfWaterToIrrigate > 0)
                {
                    if (lIsExtraIrrigation)
                    {
                        //If there was an Advisor of irrigation, it will be updated to 0.
                        lOldIrrigation.Input = 0;
                        lOldIrrigation.Date = lIrrigationDate;
                        //If there was an Extra irrigation, it will be added the new irrigation.
                        lOldIrrigation.ExtraInput = lNewQuantityOfWaterToIrrigate;
                        lOldIrrigation.ExtraDate = lIrrigationDate;
                        lOldIrrigation.Type = lNewTypeOfIrrigation;
                        lOldIrrigation.Reason = lReason;
                        lOldIrrigation.Observations = lObservations + " Updated Irrigation.";
                    }
                    else
                    {
                        //It is an Advise of Irrigation, so we are updating Advise Irrigation we have.
                        //if the Advise input is 0, we wanted to pass one day the Advise so, we do that.
                        if (lOldIrrigation.Input == 0 && !lOldIrrigationWasNotDecided)
                        {
                            if (lOldIrrigationNextDate != null)
                            {
                                lOldIrrigationNextDate.Input = 0;
                                lOldIrrigationNextDate.ExtraInput = lNewQuantityOfWaterToIrrigate;
                                lOldIrrigationNextDate.ExtraDate = lIrrigationDate.AddDays(1);
                                lOldIrrigationNextDate.Type = lNewTypeOfIrrigation;
                                lOldIrrigationNextDate.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                                lOldIrrigationNextDate.CropIrrigationWeather = this;
                                lOldIrrigationNextDate.Observations = "The irrigation was moved one day. Before: " + lOldIrrigationNextDate.Observations;
                                lOldIrrigationNextDate.Reason = Utils.NoIrrigationReason.Other;
                            }
                            else
                            {
                                //insert the new irrigation in extra irrigation, not to delete the irrigation in the add daily record method.
                                lOldIrrigationNextDate = new Water.Irrigation();
                                lOldIrrigationNextDate.WaterInputId = this.GetNewIrrigationListId();
                                lOldIrrigationNextDate.ExtraInput = lNewQuantityOfWaterToIrrigate;
                                lOldIrrigationNextDate.ExtraDate = lIrrigationDate.AddDays(1);
                                lOldIrrigationNextDate.Type = lNewTypeOfIrrigation;
                                lOldIrrigationNextDate.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                                lOldIrrigationNextDate.CropIrrigationWeather = this;
                                lOldIrrigationNextDate.Observations = "The irrigation was moved one day.";
                                lOldIrrigationNextDate.Reason = Utils.NoIrrigationReason.Other;
                                this.IrrigationList.Add(lOldIrrigationNextDate);
                            }
                            //the irrigation update to 0 for today
                            lOldIrrigation.Input = 0;
                            lDailyRecordIrrigationNextDate = this.DailyRecordList.Find(dr => dr.DailyRecordDateTime.Date == lOldIrrigation.Date.AddDays(1).Date);
                            if (lDailyRecordIrrigationNextDate != null)
                            {
                                lDailyRecordIrrigationNextDate.IrrigationId = lOldIrrigationNextDate.WaterInputId;
                                lDailyRecordIrrigationNextDate.Irrigation = lOldIrrigationNextDate;
                            }
                        }
                        //The irrigation to stay is the new irrigation for Advise Irrigation.
                        else
                        {
                            lOldIrrigation.Input = lNewQuantityOfWaterToIrrigate;
                            lOldIrrigation.Date = lIrrigationDate;
                            lOldIrrigation.Type = lNewTypeOfIrrigation;
                            lOldIrrigation.Reason = lReason;
                            lOldIrrigation.Observations = lObservations;
                        }
                    }
                    // Override the type of lIrrigationItem. 
                    lOldIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                    //lNewIrrigation.CropIrrigationWeather = this;
                }
                #endregion

                //Type is in (CantIrrigate, IrrigationWasNotDecided) 
                #region Condition #5 NO IRRIGATION
                else if (lNewTypeOfIrrigation == Utils.WaterInputType.CantIrrigate ||
                         lNewTypeOfIrrigation == Utils.WaterInputType.IrrigationWasNotDecided)
                {
                    lIrrigationCount = this.IrrigationList.Count;
                    if(lOldIrrigation == null)
                    {
                        lNewIrrigation = new Water.Irrigation();
                        lNewIrrigation.WaterInputId = this.GetNewIrrigationListId();
                        lNewIrrigation.Date = lIrrigationDate;
                        lNewIrrigation.Input = 0;
                        if (lNewTypeOfIrrigation == Utils.WaterInputType.CantIrrigate)
                        {
                            lNewIrrigation.ExtraInput = 0;
                            lNewIrrigation.ExtraDate = lIrrigationDate;
                        }
                        // Set the type of lIrrigationItem. 
                        lNewIrrigation.Type = lNewTypeOfIrrigation;
                        lNewIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                        //lNewIrrigation.CropIrrigationWeather = this;
                        lNewIrrigation.Reason = lReason;
                        lNewIrrigation.Observations = lObservations;
                        this.IrrigationList.Add(lNewIrrigation);
                    }
                    else 
                    { 
                        if (lNewTypeOfIrrigation == Utils.WaterInputType.CantIrrigate)
                        {
                            lOldIrrigation.ExtraInput = 0;
                            lOldIrrigation.ExtraDate = lIrrigationDate;
                        }  
                        if(lOldIrrigation.Reason != Utils.NoIrrigationReason.NotDecided)
                        {
                            //Do nothing, it is an Irrigation
                        }
                        else
                        {
                            // Set the type of lIrrigationItem. 
                            lOldIrrigation.Type = lNewTypeOfIrrigation;
                            lOldIrrigation.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                            lOldIrrigation.Reason = lReason;
                            lOldIrrigation.Observations = lObservations;
                        }
                    }
                }
                #endregion

                #region Condition #6 NOT IRRIGATION FOR TODAY
                else
                {
                    //Do nothing. Because there was no Irrigation and the new Irrigation is 0 
                    //              or the quantity of water is negative.
                    logger.Info("CropIrrigationWeather.AddOrUpdateIrrigationDataToList", "Do Nothig. \n" +
                        "Because there was no Irrigation and the new Irrigation is 0 or the quantity of water is negative.");
                }
                #endregion

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddOrUpdateIrrigationDataToList " + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }

        }


        /// <summary>
        /// Return the WeatherData from the available weather station.
        /// First search in the main station. If there is no data, then search in the alternative wheather station.
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pCurrentDateTime"></param>
        /// <returns></returns>
        public WeatherData GetWeatherDataFromAvailableWeatherStation(DateTime pDateTime)
        {
            WeatherData lReturn = null;
            WeatherData lWeatherDataMain = null;
            WeatherData lWeatherDataAlternative = null;

            if (pDateTime != null)
            {
                if(this.MainWeatherStation != null)
                {
                    lWeatherDataMain = this.MainWeatherStation.FindWeatherData(pDateTime);
                }
                
                if (lWeatherDataMain == null)
                {
                    if (this.AlternativeWeatherStation != null)
                    {
                        lWeatherDataAlternative = this.AlternativeWeatherStation.FindWeatherData(pDateTime);
                        lWeatherDataMain = lWeatherDataAlternative;
                    }
                    else
                    {
                        return null;
                    }
                }
                else if (lWeatherDataMain.WeatherDataType == Utils.WeatherDataType.NoData)
                {
                    lWeatherDataMain = lWeatherDataAlternative;
                }
                else if (lWeatherDataMain.WeatherDataType == Utils.WeatherDataType.Temperature)
                {
                    if(lWeatherDataAlternative != null)
                    {
                        lWeatherDataMain.Evapotranspiration = lWeatherDataAlternative.Evapotranspiration;
                    }
                    if(lWeatherDataMain.Evapotranspiration > 0)
                    {
                        lWeatherDataMain.WeatherDataType = Utils.WeatherDataType.AllData;
                    }
                }
                else if (lWeatherDataMain.WeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                {
                    if (lWeatherDataAlternative != null)
                    {
                        lWeatherDataMain.Temperature = lWeatherDataAlternative.Temperature;
                        lWeatherDataMain.TemperatureMax = lWeatherDataAlternative.TemperatureMax;
                        lWeatherDataMain.TemperatureMin = lWeatherDataAlternative.TemperatureMin;
                    }
                    if (lWeatherDataMain.TemperatureMax != 0 && lWeatherDataMain.TemperatureMin != 0)
                    {
                        lWeatherDataMain.WeatherDataType = Utils.WeatherDataType.AllData;
                    } 
                }
            }

            lReturn = lWeatherDataMain;
            return lReturn;
        }

        /// <summary>
        /// Add Rain Data. If there is a record of Rain, 
        /// it is updated adding the new rain as ExtraInput
        /// </summary>
        /// <param name="pDate"></param>
        /// <param name="pOutput"></param>
        /// <returns></returns>
        public Rain AddRainDataToList(DateTime pDate, Double pInput)
        {
            Rain lNewRain = null;
            long lNewRainId = 0;
            try
            {
                lNewRain = this.GetRain(pDate);
                if (lNewRain == null)
                {
                    lNewRainId = this.GetNewRainListId();
                    lNewRain = new Rain();
                    lNewRain.WaterInputId = lNewRainId;
                    lNewRain.Date = pDate;
                    lNewRain.Input = pInput;
                    lNewRain.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                    lNewRain.CropIrrigationWeather = this;
                    this.RainList.Add(lNewRain);
                }
                else 
                    //If there is a record of Rain, it is updated adding the new rain as ExtraInput
                {
                    lNewRain.ExtraInput += pInput;
                    lNewRain.ExtraDate = pDate;
                    lNewRain.CropIrrigationWeatherId = this.CropIrrigationWeatherId;
                    lNewRain.CropIrrigationWeather = this;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddRainDataToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }

            return lNewRain;

        }

        #endregion

        #region PhenologicalStageAdjustment
        
        /// <summary>
        /// Find PhenologicalStageAdjustment by Id, if not exists, return null
        /// </summary>
        /// <param name="pPhenologicalStageAdjustmentId"></param>
        /// <returns></returns>
        public PhenologicalStageAdjustment FindPhenologicalStageAdjustment(long pPhenologicalStageAdjustmentId)
        {
            PhenologicalStageAdjustment lReturn = null;
            if(pPhenologicalStageAdjustmentId < this.PhenologicalStageAdjustmentList.Count())
            {
                foreach (PhenologicalStageAdjustment item in this.PhenologicalStageAdjustmentList)
                {
                    if(item.PhenologicalStageAdjustmentId == pPhenologicalStageAdjustmentId)
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If PhenologicalStageAdjustment exist in List return the PhenologicalStageAdjustment, 
        /// else return null
        /// </summary>
        /// <param name="pPhenologicalStageAdjustment"></param>
        /// <returns></returns>
        public PhenologicalStageAdjustment ExistPhenologicalStageAdjustment(PhenologicalStageAdjustment pPhenologicalStageAdjustment)
        {
            PhenologicalStageAdjustment lReturn = null;
            foreach (PhenologicalStageAdjustment item in this.PhenologicalStageAdjustmentList)
            {
                if(item.Equals(pPhenologicalStageAdjustment))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a PhenologicalStageAdjustment and return it, 
        /// if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCrop"></param>
        /// <param name="pDateOfChange"></param>
        /// <param name="pStage"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pObservation"></param>
        /// <returns></returns>
        public PhenologicalStageAdjustment AddPhenologicalStageAdjustmentToList(String pName, Crop pCrop, 
                                                                DateTime pDateOfChange, Stage pStage,
                                                                PhenologicalStage pPhenologicalStage,
                                                                String pObservation)
        {
            PhenologicalStageAdjustment lReturn = null;
            long lPhenologicalStageAdjustmentId = this.GetNewPhenologicalStageAdjustmentListId();
            PhenologicalStageAdjustment lPhenologicalStageAdjustment = new PhenologicalStageAdjustment(pName, pCrop.CropId,
                                                                            pDateOfChange, pStage.StageId, pPhenologicalStage.PhenologicalStageId,
                                                                            pObservation);
            lPhenologicalStageAdjustment.PhenologicalStageAdjustmentId = lPhenologicalStageAdjustmentId;
            if(ExistPhenologicalStageAdjustment(lPhenologicalStageAdjustment) == null)
            {
                this.PhenologicalStageAdjustmentList.Add(lPhenologicalStageAdjustment);
                lReturn = lPhenologicalStageAdjustment;
            }
            return lReturn;
        }

        /// <summary>
        /// Update PhenologicalStageAdjustment Name, Crop, Date of Change, Stage,
        ///                                    PhenologicalStage, Observation
        /// if not exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCrop"></param>
        /// <param name="pDateOfChange"></param>
        /// <param name="pStage"></param>
        /// <param name="pPhenologicalStage"></param>
        /// <param name="pObservation"></param>
        /// <returns></returns>
        public PhenologicalStageAdjustment UpdatePhenologicalStageAdjustment(String pName, Crop pCrop,
                                                                DateTime pDateOfChange, Stage pStage,
                                                                PhenologicalStage pPhenologicalStage,
                                                                String pObservation)
        {
            PhenologicalStageAdjustment lReturn = null;
            PhenologicalStageAdjustment lPhenologicalStageAdjustment = new PhenologicalStageAdjustment(pName, pCrop.CropId,
                                                                            pDateOfChange, pStage.StageId, pPhenologicalStage.PhenologicalStageId,
                                                                            pObservation);
            lReturn = ExistPhenologicalStageAdjustment(lPhenologicalStageAdjustment);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.CropId = pCrop.CropId;
                lReturn.Crop = pCrop;
                lReturn.DateOfChange = pDateOfChange;
                lReturn.StageId = pStage.StageId;
                lReturn.Stage = pStage;
                lReturn.PhenologicalStageId = pPhenologicalStage.PhenologicalStageId;
                lReturn.PhenologicalStage = pPhenologicalStage;
                lReturn.Observation = pObservation;
            }
            return lReturn;
        }

        #endregion

        #region PhenologicalStage

        /// <summary>
        /// Find PhenologicalStage by Stage in this Crop, if not exists, return null
        /// </summary>
        /// <param name="pPhenologicalStageId"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Stage pStage)
        {
            PhenologicalStage lReturn = null;

            lReturn = this.Crop.FindPhenologicalStage(pStage);
            
            return lReturn;
        }

        /// <summary>
        /// Adjustment of Phenology Stage
        /// </summary>
        /// <param name="pNewStage"></param>
        /// <param name="pDateTimeToChange"></param>
        public void AdjustmentPhenology(Stage pNewStage, DateTime pDateTimeToChange)
        {
            Stage lActualStage;
            Double lModification;
            
            lActualStage = this.PhenologicalStage.Stage;
            lModification = this.calculateDegreeStageDifference(lActualStage, pNewStage, this.Crop);
            this.adjustmentPhenology(pNewStage, pDateTimeToChange, lModification);
            
        }

        /// <summary>
        /// Retrun Phenological Stage where Growing Degree Days is between Min and Max Degree
        /// </summary>
        /// <param name="pGrowingDegreeDaysModified"></param>
        /// <returns></returns>
        public PhenologicalStage GetNewPhenologicalStage(Double pGrowingDegreeDaysModified)
        {
            PhenologicalStage lReturn;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByMinDegree;
            PhenologicalStage lNewPhenologicalStage = null;
            PhenologicalStage lLastPhenologicalStage = null;
            
            //Order the phenological table
            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByMinDegree = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.MinDegree);


                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByMinDegree)
            {
                if (lPhenologicalStage != null 
                    && (lPhenologicalStage.MinDegree - InitialTables.ACCURANCY_RANGE_MIN_MAX_DEGREE) <= pGrowingDegreeDaysModified
                    && (lPhenologicalStage.MaxDegree + InitialTables.ACCURANCY_RANGE_MIN_MAX_DEGREE) >= pGrowingDegreeDaysModified
                    && lPhenologicalStage.PhenologicalStageIsUsed)
                {
                    lNewPhenologicalStage = lPhenologicalStage;
                    break;
                }
                lLastPhenologicalStage = lPhenologicalStage;
            }

            if (lNewPhenologicalStage == null && pGrowingDegreeDaysModified > lLastPhenologicalStage.MaxDegree)
            {
                lNewPhenologicalStage = lLastPhenologicalStage;
            }
            
            lReturn = lNewPhenologicalStage;
            return lReturn;
        }

        /// <summary>
        /// Return Phenological Stage where Days After Sowing is in the period of the Stage
        /// </summary>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <returns></returns>
        public PhenologicalStage GetNewPhenologicalStage(int pDaysAfterSowingModified)
        {
            PhenologicalStage lReturn;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByStageName;
            PhenologicalStage lNewPhenologicalStage = null;
            Stage lStage = null;
            String lStageName = "";
            
            //Order the phenological table by 
            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByStageName = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Name);

            //Return the strage depending in Days after Sowing
            if(this.CropInformationByDate != null)
            {
                lStage = this.CropInformationByDate.GetStage(pDaysAfterSowingModified);
            }

            if(lStage != null)
            {
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByStageName)
                {
                    if(lPhenologicalStage != null)
                    {
                        lStageName = lPhenologicalStage.Stage.Name.ToUpper();
                        if (lStageName.Equals(lStage.Name.ToUpper()))
                        {
                            lNewPhenologicalStage = lPhenologicalStage;
                            break;
                        }
                    }
                }
            }

            lReturn = lNewPhenologicalStage;
            return lReturn;
        }

        /// <summary>
        /// Return Phenological Stage where Growing Degree Days is the sum of each Stage Degree
        /// Not use  GrowingDegreeDaysModified. Use GrowingDegreeDaysExtraGap
        /// </summary>
        /// <returns></returns>

        public PhenologicalStage GetNewPhenologicalStageByInterval(Double lGrowingDegreeDaysModified)
        {
            PhenologicalStage lReturn;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByStageOrder;
            PhenologicalStage lNewPhenologicalStage = null;
            PhenologicalStage lLastPhenologicalStage = null;
            Double lGrowingDeGreeDaysAccumulatedAdjusded;
            Double lTableGrowingDegreeDays=0;

            lGrowingDeGreeDaysAccumulatedAdjusded = lGrowingDegreeDaysModified;//this.GrowingDegreeDaysAccumulated + this.GrowingDegreeDaysExtraGap;
            //Order the phenological table
            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByStageOrder = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Order);

            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByStageOrder)
            {
                if (lPhenologicalStage != null && lPhenologicalStage.PhenologicalStageIsUsed
                    && lTableGrowingDegreeDays <= lGrowingDeGreeDaysAccumulatedAdjusded)
                {
                    lNewPhenologicalStage = lPhenologicalStage;
                }
                if (lPhenologicalStage.PhenologicalStageIsUsed)
                {
                    lTableGrowingDegreeDays += lPhenologicalStage.DegreesDaysInterval;
                    lLastPhenologicalStage = lPhenologicalStage;
                }
                
                
                if (lTableGrowingDegreeDays > lGrowingDeGreeDaysAccumulatedAdjusded)
                {
                    break;
                }
            }

            if (lNewPhenologicalStage == null && lTableGrowingDegreeDays < lGrowingDeGreeDaysAccumulatedAdjusded)
            {
                lNewPhenologicalStage = lLastPhenologicalStage;
            }

            lReturn = lNewPhenologicalStage;
            return lReturn;
        }

        /// <summary>
        /// Change value of PhenologicalStageIsUsed searching by stageName
        /// </summary>
        /// <param name="pStageName">Value to search the phenological stage</param>
        /// <param name="pEnabled">Value to be apply</param>
        /// <returns>If the change was made</returns>
        public bool EnableOrDisablePhenologicalStageByName(String pStageName, bool pEnabled)
        {
            bool lReturn = false;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByOrder;
            Double lAddNewRange = 0;


            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByOrder = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Order);
            
            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByOrder)
            {
              
                if (lPhenologicalStage.Stage.Name.Equals(pStageName) && lPhenologicalStage.PhenologicalStageIsUsed != pEnabled)
                {
                    lPhenologicalStage.PhenologicalStageIsUsed = pEnabled;
                    lReturn = true;
                    lAddNewRange = lPhenologicalStage.DegreesDaysInterval;
                }
                //For the next stages after the item ingresed: add the new interval
                lPhenologicalStage.MinDegree += lAddNewRange;
                lPhenologicalStage.MaxDegree += lAddNewRange;
            }
            return lReturn;
        }

        /// <summary>
        /// Change value of PhenologicalStageIsUsed searching by stage order
        /// </summary>
        /// <param name="pOrder">Value to search the phenological stage</param>
        /// <param name="pEnabled">Value to be apply</param>
        /// <returns>If the change was made</returns>
        public bool EnableOrDisablePhenologicalStageByOrder(int pOrder, bool pEnabled)
        {
            bool lReturn = false;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByOrder;
            Double lAddNewRange = 0;

            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByOrder = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Order);

            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByOrder)
            {
                if (lPhenologicalStage.Stage.Order == pOrder && lPhenologicalStage.PhenologicalStageIsUsed != pEnabled)
                {
                    lPhenologicalStage.PhenologicalStageIsUsed = pEnabled;
                    lReturn = true;
                    lAddNewRange = lPhenologicalStage.DegreesDaysInterval;
                }
                //For the next stages after the item ingresed: add the new interval
                lPhenologicalStage.MinDegree += lAddNewRange;
                lPhenologicalStage.MaxDegree += lAddNewRange;
            }
            return lReturn;
        }

        /// <summary>
        /// Modify the interval or interval of one Phenological Stage
        /// </summary>
        /// <param name="pOrder">The order of the Phenological Stage will be modified. Must be PhenologicalStageIsUsed = true</param>
        /// <param name="pNewIntervalValue">The new value for the interval</param>
        /// <returns>If the change was made</returns>
        public bool ModifyIntervalOfPhenologicalStage(int pOrder, Double  pNewIntervalValue)
        {
            bool lReturn = false;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByOrder;
            Double lDifferenceOfInterval = 0;


            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByOrder = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Order);

            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByOrder)
            {
                if (lPhenologicalStage.Stage.Order == pOrder && lPhenologicalStage.PhenologicalStageIsUsed)
                {
                    lDifferenceOfInterval = pNewIntervalValue - lPhenologicalStage.DegreesDaysInterval;
                    lPhenologicalStage.DegreesDaysInterval = pNewIntervalValue;
                    lReturn = true;
                }
                //For the next stages after the item ingresed: add the new interval
                lPhenologicalStage.MinDegree += lDifferenceOfInterval;
                lPhenologicalStage.MaxDegree += lDifferenceOfInterval;
            }
            return lReturn;
        }

        /// <summary>
        /// Modify the interval or interval of one Phenological Stage
        /// </summary>
        /// <param name="pStageName">The name of the Phenological Stage will be modified. Must be PhenologicalStageIsUsed = true</param>
        /// <param name="pNewIntervalValue">The new value for the interval</param>
        /// <returns>If the change was made</returns>
        public bool ModifyIntervalOfPhenologicalStage(String pStageName, Double pNewIntervalValue)
        {
            bool lReturn = false;
            List<PhenologicalStage> lPhenologicalStageList;
            IEnumerable<PhenologicalStage> lPhenologicalTableOrderByOrder;
            Double lDifferenceOfInterval = 0;


            lPhenologicalStageList = this.Crop.PhenologicalStageList;
            lPhenologicalTableOrderByOrder = lPhenologicalStageList.OrderBy(lPhenologicalStage => lPhenologicalStage.Stage.Order);

            foreach (PhenologicalStage lPhenologicalStage in lPhenologicalTableOrderByOrder)
            {
                if (lPhenologicalStage.Stage.Name == pStageName && lPhenologicalStage.PhenologicalStageIsUsed)
                {
                    lDifferenceOfInterval = pNewIntervalValue - lPhenologicalStage.DegreesDaysInterval;
                    lPhenologicalStage.DegreesDaysInterval = pNewIntervalValue;
                    lReturn = true;
                }
                //For the next stages after the item ingresed: add the new interval
                lPhenologicalStage.MinDegree += lDifferenceOfInterval;
                lPhenologicalStage.MaxDegree += lDifferenceOfInterval;
            }
            return lReturn;
        }


        #endregion

        #region DailyRecord

        /// <summary>
        /// Get DailyRecord from the list order by date with Date of the record
        /// equals than the parameter date..
        /// If is it not find, return null.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public DailyRecord GetDailyRecordByDate(DateTime pDate)
        {
            DailyRecord lRetrun = null;
            IEnumerable<DailyRecord> lDailyRecordOrderByDate = null;

            if (pDate != null)
            {
                lDailyRecordOrderByDate = this.DailyRecordList.OrderBy(lDailyRecord => lDailyRecord.DailyRecordDateTime);

                foreach (DailyRecord lDailyRecord in lDailyRecordOrderByDate)
                {
                    //Compare Dates, is not important the Time
                    if (Utils.IsTheSameDay(pDate, lDailyRecord.DailyRecordDateTime))
                    {
                        lRetrun = lDailyRecord;
                    }
                }
            }

            return lRetrun;
        }

        /// <summary>
        /// Verify if exist an older Daily Record, and if exists, replece it
        /// </summary>
        /// <param name="pDailyRecordDateTime"></param>
        /// <returns></returns>
        public DailyRecord UpdateDailyRecordListUpToDate(DateTime pDailyRecordDateTime)
        {
            DailyRecord lReturn = null;
            DailyRecord lDailyRecordToDelete = null;
            List<Water.Irrigation> lIrrigationToDelete = null;

            if (pDailyRecordDateTime != null)
            {
                lDailyRecordToDelete = this.DailyRecordList
                                            .Where(dr => dr.DailyRecordDateTime >= pDailyRecordDateTime 
                                                && dr.CropIrrigationWeatherId == this.CropIrrigationWeatherId).FirstOrDefault();
            }
            //We have a unique record by day
            if (lDailyRecordToDelete != null)
            {

                UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(lDailyRecordToDelete);
                /**************************************************************************************/
                /*-- 2018-11-13  Change to Update DailyRecords to initial state without irrigation  --*/
                /*--  TODO: Change Deletion to update of records                                    --*/
                /**************************************************************************************/
                //Delete Database List of DATA
                //Delete DailyRecords from database after date of record to delete.
                this.dailyRecordList.RemoveAll(dr => dr.DailyRecordDateTime >= lDailyRecordToDelete.DailyRecordDateTime
                                                && dr.CropIrrigationWeatherId == this.CropIrrigationWeatherId);

                lIrrigationToDelete = RemoveIrrigationList(lDailyRecordToDelete.DailyRecordDateTime);

                /**************************************************************************************/
                /*--                   New code                                                     --*/
                foreach (DailyRecord lDailyRecord in this.dailyRecordList
                                                                .Where(dr => dr.DailyRecordDateTime >= lDailyRecordToDelete.DailyRecordDateTime 
                                                                    && dr.CropIrrigationWeatherId == this.CropIrrigationWeatherId))
                {
                    lDailyRecord.Irrigation.Type = Utils.WaterInputType.Irrigation;
                }


                /**************************************************************************************/


            }


            lReturn = lDailyRecordToDelete;
            return lReturn;

        }

        /// <summary>
        /// Remove Irrigations from the List from a Date
        /// Note: Extra input or CantIrrigate input, will not be deleted
        /// </summary>
        /// <param name="pDateFrom"></param>
        /// <returns></returns>
        public List<Water.Irrigation> RemoveIrrigationList(DateTime pDateFrom)
        {
            List<Water.Irrigation> lReturn = null;
            List<Water.Irrigation> lIrrigationToDelete = null;

            
            //Find Irrigation to delete
            lIrrigationToDelete = this.irrigationList
                                        .Where(irrigation => irrigation.Date >= pDateFrom.Date
                                            && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                            && irrigation.Type != Utils.WaterInputType.CantIrrigate
                                            && !(irrigation.ExtraInput > 0 || irrigation.ExtraInput == 0 && irrigation.ExtraDate == irrigation.Date))
                                            .ToList();

            if (lIrrigationToDelete != null && lIrrigationToDelete.Any())
            {
                //Delete Irrigations input from database after date of record to delete. 
                //Extra input or CantIrrigate input, will not be deleted
                this.irrigationList.RemoveAll(irrigation => irrigation.Date >= pDateFrom.Date
                                                            && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                                            && irrigation.Type != Utils.WaterInputType.CantIrrigate
                                                            && !(irrigation.ExtraInput > 0 || irrigation.ExtraInput == 0 && irrigation.ExtraDate == irrigation.Date));

                foreach (Water.Irrigation lIrrigation in this.IrrigationList
                                                                .Where(irrigation => irrigation.Date >= pDateFrom.Date
                                                                    && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                                                    && irrigation.Type != Utils.WaterInputType.CantIrrigate))
                {
                    if (lIrrigation.ExtraInput > 0 ||
                        (lIrrigation.ExtraInput == 0 && lIrrigation.ExtraDate == lIrrigation.Date))
                    {
                        lIrrigation.Input = 0;
                        lIrrigation.Date = lIrrigation.ExtraDate;
                    }
                }

            }

            lReturn = lIrrigationToDelete;
            return lReturn;
        }

        /// <summary>
        /// Update IrrigationList with Initial values from a Date
        /// </summary>
        /// <param name="pDateFrom"></param>
        /// <returns></returns>
        public List<Water.Irrigation> UpdateIrrigationListToInitial(DateTime pDateFrom)
        {
            List<Water.Irrigation> lReturn = null;
            List<Water.Irrigation> lIrrigationToUpdate = null;


            //Find Irrigation to delete
            lIrrigationToUpdate = this.irrigationList
                                        .Where(irrigation => irrigation.Date >= pDateFrom.Date
                                            && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                            && irrigation.Type != Utils.WaterInputType.CantIrrigate
                                            && !(irrigation.ExtraInput > 0 || irrigation.ExtraInput == 0 && irrigation.ExtraDate == irrigation.Date))
                                            .ToList();

            if (lIrrigationToUpdate != null && lIrrigationToUpdate.Any())
            {
                //Update Irrigations input from database after date of record. 
                //Extra input or CantIrrigate input, will not be updated
                foreach (Water.Irrigation lIrrigation in this.IrrigationList
                                                                .Where(irrigation => irrigation.Date >= pDateFrom.Date
                                                                    && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                                                    && irrigation.Type != Utils.WaterInputType.CantIrrigate))
                {
                    if (lIrrigation.ExtraInput > 0 ||
                        (lIrrigation.ExtraInput == 0 && lIrrigation.ExtraDate == lIrrigation.Date))
                    {
                        lIrrigation.Input = 0;
                        lIrrigation.Date = lIrrigation.ExtraDate;
                    }
                    else
                    {
                        lIrrigation.Input = 0;
                        lIrrigation.Type = Utils.WaterInputType.IrrigationWasNotDecided;
                        lIrrigation.Reason = Utils.NoIrrigationReason.NotDecided;
                        lIrrigation.ExtraDate = Utils.MIN_DATETIME;
                    }
                }

            }

            lReturn = lIrrigationToUpdate;
            return lReturn;
        }

        /// <summary>
        /// Verify if exist an older Daily Record, and if exists, replece it. With Context
        /// </summary>
        /// <param name="pDailyRecordDateTime"></param>
        /// <returns></returns>
        public DailyRecord UpdateDailyRecordListUpToDate(DateTime pDailyRecordDateTime, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            DailyRecord lReturn = null;
            DailyRecord lDailyRecordToDelete = null;
            List<Water.Irrigation> lIrrigationToDelete = null;
            EntityState lState;
            int lDatabaseChangeResult = 0;

            if (pDailyRecordDateTime != null)
            {
                lDailyRecordToDelete = pIrrigationAdvisorContext.DailyRecords
                                        .Where(dr => dr.DailyRecordDateTime >= pDailyRecordDateTime 
                                            && dr.CropIrrigationWeatherId == this.CropIrrigationWeatherId).FirstOrDefault();
            }
            //We have a unique record by day
            if (lDailyRecordToDelete != null)
            {
                
                UpdateCropIrrigationWeatherByOneDayBeforeDailyRecordData(lDailyRecordToDelete, pIrrigationAdvisorContext);
                lState = pIrrigationAdvisorContext.Entry(this).State;

                //Delete Database List of DATA
                //Delete DailyRecords from database after date of record to delete.
                pIrrigationAdvisorContext.DailyRecords.RemoveRange(pIrrigationAdvisorContext.DailyRecords
                                        .Where(dr => dr.DailyRecordDateTime >= lDailyRecordToDelete.DailyRecordDateTime 
                                            && dr.CropIrrigationWeatherId == this.CropIrrigationWeatherId));

                lIrrigationToDelete = RemoveIrrigationList(lDailyRecordToDelete.DailyRecordDateTime, pIrrigationAdvisorContext);

                lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();

            }

            lReturn = lDailyRecordToDelete;
            return lReturn;

        }

        /// <summary>
        /// Remove Irrigation List
        /// </summary>
        /// <param name="pDateFrom"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        /// <returns></returns>
        public List<Water.Irrigation> RemoveIrrigationList(DateTime pDateFrom, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            List<Water.Irrigation> lReturn = null;
            List<Water.Irrigation> lIrrigationToDelete = null;
            EntityState lState;
            int lDatabaseChangeResult = 0;

            
            lState = pIrrigationAdvisorContext.Entry(this).State;


            this.irrigationList.RemoveAll(irrigation => irrigation.Date >= pDateFrom.Date
                                        && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                        && irrigation.Type != Utils.WaterInputType.CantIrrigate
                                        && !(irrigation.ExtraInput > 0 || irrigation.ExtraInput == 0 && irrigation.ExtraDate == irrigation.Date));

                    
            //Find Irrigation to delete
            lIrrigationToDelete = pIrrigationAdvisorContext.Irrigations
                                        .Where(irrigation => irrigation.Date >= pDateFrom.Date
                                            && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                            && irrigation.Type != Utils.WaterInputType.CantIrrigate
                                            && !(irrigation.ExtraInput > 0 || irrigation.ExtraInput == 0 && irrigation.ExtraDate == irrigation.Date))
                                            .ToList();

            //Delete Irrigations input from database after date of record to delete. 
            //Extra input will not be deleted
            foreach (Water.Irrigation lIrrigation in pIrrigationAdvisorContext.Irrigations
                                    .Where(irrigation => irrigation.Date >= pDateFrom.Date 
                                        && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId 
                                        && irrigation.Type != Utils.WaterInputType.CantIrrigate))
            {
                if(lIrrigation.ExtraInput > 0 || 
                    (lIrrigation.ExtraInput == 0 && lIrrigation.ExtraDate == lIrrigation.Date))
                {
                    lIrrigation.Input = 0;
                    lIrrigation.Date = lIrrigation.ExtraDate;
                }
                else
                {
                    pIrrigationAdvisorContext.Irrigations.Remove(lIrrigation);
                }
            }
            lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();

            lReturn = lIrrigationToDelete;
            return lReturn;
        }

        /// <summary>
        /// Update IrrigationList with Initial values from a Date
        /// </summary>
        /// <param name="pDateFrom"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        /// <returns></returns>
        public List<Water.Irrigation> UpdateIrrigationListToInitial(DateTime pDateFrom, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            List<Water.Irrigation> lReturn = null;
            List<Water.Irrigation> lIrrigationToUpdate = null;
            EntityState lState;
            int lDatabaseChangeResult = 0;


            lState = pIrrigationAdvisorContext.Entry(this).State;

            //Find Irrigation to update
            lIrrigationToUpdate = this.irrigationList.Where(irrigation => irrigation.Date >= pDateFrom.Date
                                        && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                        && irrigation.Type != Utils.WaterInputType.CantIrrigate
                                        && !(irrigation.ExtraInput > 0 || irrigation.ExtraInput == 0 && irrigation.ExtraDate == irrigation.Date)).ToList();

            if(lIrrigationToUpdate != null && lIrrigationToUpdate.Any())
            {
                foreach(Water.Irrigation lIrrigation in lIrrigationToUpdate)
                {
                    lIrrigation.Input = 0;
                    lIrrigation.Type = Utils.WaterInputType.IrrigationWasNotDecided;
                    lIrrigation.Reason = Utils.NoIrrigationReason.NotDecided;
                    lIrrigation.ExtraDate = Utils.MIN_DATETIME;
                }
            }


            //Update Irrigations input from database after date of record to update. 
            //Extra input will not be deleted
            foreach (Water.Irrigation lIrrigation in pIrrigationAdvisorContext.Irrigations
                                    .Where(irrigation => irrigation.Date >= pDateFrom.Date
                                        && irrigation.CropIrrigationWeatherId == this.CropIrrigationWeatherId
                                        && irrigation.Type != Utils.WaterInputType.CantIrrigate))
            {
                if (lIrrigation.ExtraInput > 0 ||
                    (lIrrigation.ExtraInput == 0 && lIrrigation.ExtraDate == lIrrigation.Date))
                {
                    lIrrigation.Input = 0;
                    lIrrigation.Date = lIrrigation.ExtraDate;
                }
                else
                {
                    lIrrigation.Input = 0;
                    lIrrigation.Type = Utils.WaterInputType.IrrigationWasNotDecided;
                    lIrrigation.Reason = Utils.NoIrrigationReason.NotDecided;
                    lIrrigation.ExtraDate = Utils.MIN_DATETIME;
                }
            }
            lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();

            lReturn = lIrrigationToUpdate;
            return lReturn;
        }

        /// <summary>
        /// Gives the growing degree registered in a specific date.
        /// </summary>
        /// <param name="pDate">Date of the required information</param>
        /// <returns></returns>
        public Double GetDailyRecordGrowingDegree(DateTime pDate)
        {
            Double lRetrun;
            Double lGrowingDegreeDays = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lGrowingDegreeDays = lDailyRec.GrowingDegreeDays;
                    break;
                }
            }

            lRetrun = lGrowingDegreeDays;
            return lRetrun;
        }

        /// <summary>
        /// Gives the observation registered in a specific date.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public String GetDailyRecordObservations(DateTime pDate)
        {
            String lRetrun;
            String lObservations = "";

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lObservations = lDailyRec.Observations;
                    break;
                }
            }

            lRetrun = lObservations;
            return lRetrun;
        }

        /// <summary>
        /// Gives the Evapotranspiration registered in a Date 
        /// and the two days before, including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public WaterOutput GetDailyRecordEvapotranspiration(DateTime pDate)
        {
            WaterOutput lReturn;
            WaterOutput lEvapotranspiration = null;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lEvapotranspiration = lDailyRec.EvapotranspirationCrop;
                    break;
                }
            }

            lReturn = lEvapotranspiration;
            return lReturn;
        }

        /// <summary>
        /// Add DailyRecord to List
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pObservation"></param>
        /// <returns></returns>
        public bool AddDailyRecordToList(DateTime pDateTime, String pObservation, DateTime pDateOfReference)
        {
            bool lReturn = false;
            WeatherData lWeatherData = null;

            try
            {
                //The date has to be not null
                if(pDateTime != null)
                {
                    //Get WeatherData for the available Weather Station (Main or Alternative)
                    lWeatherData = this.GetWeatherDataFromAvailableWeatherStation(pDateTime);

                    //If WeatherData is not null, we can continue
                    if(lWeatherData != null)
                    {
                        if(this.CalculusMethodForPhenologicalAdjustment.Equals(
                            Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays) 
                            || this.CalculusMethodForPhenologicalAdjustment.Equals(
                            Utils.CalculusOfPhenologicalStage.ByIntervalGrowingDegreeDays))
                        {
                            this.AddDailyRecordAccordingGrowinDegreeDays(pDateTime, pObservation, lWeatherData, pDateOfReference);
                        }

                        if(this.CalculusMethodForPhenologicalAdjustment.Equals(
                            Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing))
                        {
                            this.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservation, lWeatherData, pDateOfReference);
                        }
  

                        //when arrives to final Stage, do not add new irrigation
                        if (this.PhenologicalStage.Stage.Order < this.Crop.StopIrrigationStageOrder)
                        {
                            //Then that is added the DailyRecord, we must verify if we need to irrigate.
                            //If it is necesary, the irrigation is added to the list and the DailyRecord is readded.
                            this.VerifyNeedForIrrigation(pDateTime, pDateOfReference);
                        }
                        else
                        {
                            //System.Diagnostics.Debugger.Break();
                        }
                    }
                    else
                    {
                        //If WeatherData is null, use DaysAfterSowing
                        this.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservation, lWeatherData, pDateOfReference);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddDailyRecordToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        /// <summary>
        /// Add DailyRecord according Days After Sowing
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pObservations"></param>
        /// <param name="pWeatherData"></param>
        /// <param name="pDateOfReference"></param>
        public void AddDailyRecordAccordingDaysAfterSowing(DateTime pCurrentDateTime, String pObservations, WeatherData pWeatherData,
                                                            DateTime pDateOfReference)
        {
            try
            {
                #region local variables
                WeatherData lWeatherData;
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration = 0;
                Double lBaseTemperature = 0;
                Double lStressTemperature = 0;
                Double lAverageTemperature = 0;
                Double lGrowingDegreeDays = 0;
                Double lGrowingDegreeDaysModified = 0;
                DateTime lLastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;
                DailyRecord lDailyRecord;
                int lDaysAfterSowing = 0;
                int lDaysAfterSowingModified = 0;
                Double lCropCoefficient = 0;
                Double lEvapotranspirationCropInput = 0;
                EvapotranspirationCrop lEvapotranspirationCrop = null;
                DailyRecord lNewDailyRecord = null;
                WeatherData lMainWeatherData = null;
                long lMainWeatherDataWeatherDataId = 0;
                WeatherData lAlternativeWeatherData = null;
                long lAlternativeWeatherDataWeatherDataId = 0;
                Rain lRain = null;
                long lRainWaterInputId = 0;
                Water.Irrigation lIrrigation = null;
                long lIrrigationWaterInputId = 0;
                #endregion

                lWeatherData = pWeatherData;
                
                lDailyRecordDateTime = pCurrentDateTime;

                #region 1.- Evapotranspiration
                if (lWeatherData != null)
                {
                    if (lWeatherData.WeatherDataType == Utils.WeatherDataType.AllData
                        || lWeatherData.WeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                    {
                        lEvapotranspiration = lWeatherData.GetEvapotranspiration();
                    }
                }
                else
                {
                    lEvapotranspiration = this.Crop.Region.GetEvapotranspiration(lDailyRecordDateTime);
                }
                #endregion

                #region 2.- Days After Sowing
                lDaysAfterSowing = this.calculateDaysAfterSowingForOneDay(this.SowingDate, lDailyRecordDateTime);
                #endregion

                #region 3.- Growing Degree Days
                //Growing Degree Days is average temperature menous Base Temperature 
                lBaseTemperature = this.GetBaseTemperature();
                lStressTemperature = this.GetStressTemperature();
                lLastDayOfGrowingDegreeDays = this.LastDayOfGrowingDegreeDays;
                if (lWeatherData != null)
                {
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                        //is updated by calculateGrowingDegreeDaysForOneDay
                        lAverageTemperature = lWeatherData.GetAverageTemperature(lStressTemperature, -lBaseTemperature);
                        lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(lBaseTemperature, lAverageTemperature);
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                }
                else
                {
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        lGrowingDegreeDays = this.CropInformationByDate.GetGrowingDegreeDays(lDailyRecordDateTime,
                                                                                            lBaseTemperature, lStressTemperature);
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                }
                lGrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
                #endregion

                #region 4.- Get Daily Record by Days After Sowing Modified
                lDailyRecord = this.getDailyRecordByDaysAfterSowingAccumulated(this.DaysAfterSowingModified);
                #endregion

                #region 5.- Get the Growing Degree Days Modified according to Days After Sowing Modified
                //If we do not modified DAS, GDD will be 0
                if (lDailyRecord == null)
                {
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lGrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified;
                    lGrowingDegreeDays = lDailyRecord.GrowingDegreeDays;
                    lDaysAfterSowingModified = this.DaysAfterSowingModified;
                }
                #endregion

                #region 6.- Get Crop Coefficient by Days After Sowing Modified
                lCropCoefficient = this.Crop.CropCoefficient.GetCropCoefficient(lDaysAfterSowingModified);
                #endregion

                #region 7.- Calculus of Evapotranspiration Crop
                if (lWeatherData != null)
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lWeatherData.Date, lEvapotranspirationCropInput);
                }
                else
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lDailyRecordDateTime, lEvapotranspirationCropInput);
                }
                
                #endregion

                #region 8.- Weather Data
                lMainWeatherDataWeatherDataId = 0;
                if (this.MainWeatherStation != null)
                {
                    lMainWeatherData = this.MainWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lMainWeatherData != null)
                    {
                        lMainWeatherDataWeatherDataId = lMainWeatherData.WeatherDataId;
                    }
                }

                lAlternativeWeatherDataWeatherDataId = 0;
                if (this.AlternativeWeatherStation != null)
                {
                    lAlternativeWeatherData = this.AlternativeWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lAlternativeWeatherData != null)
                    {
                        lAlternativeWeatherDataWeatherDataId = lAlternativeWeatherData.WeatherDataId;
                    }
                }
                #endregion

                #region 9.- Water Input
                lRain = this.GetRain(lDailyRecordDateTime);
                if (lRain == null)
                {
                    lRainWaterInputId = 0;
                }
                else
                {
                    lRainWaterInputId = lRain.WaterInputId;
                }

                lIrrigation = this.GetIrrigationByDay(lDailyRecordDateTime);
                if (lIrrigation == null)
                {
                    lIrrigationWaterInputId = 0;
                }
                else
                {
                    lIrrigationWaterInputId = lIrrigation.WaterInputId;
                }
                #endregion

                #region 10.- New Daily Record
                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, this.CropIrrigationWeatherId,
                                                lMainWeatherDataWeatherDataId, lAlternativeWeatherDataWeatherDataId,
                                                this.DaysAfterSowing, this.DaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                this.LastDayOfGrowingDegreeDays,
                                                lRainWaterInputId, lIrrigationWaterInputId, this.LastWaterInputDate, 
                                                this.LastBigWaterInputDate,
                                                this.LastPartialWaterInputDate, this.LastPartialWaterInput,
                                                this.LastBigGapWaterInputDate,
                                                lEvapotranspirationCrop, this.PhenologicalStageId, 
                                                this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);
                //Update Rain & Irrigation
                if (lRain != null) lNewDailyRecord.Rain = lRain;
                if (lIrrigation != null) lNewDailyRecord.Irrigation = lIrrigation;
                #endregion

                #region 11.- Update Daily record list, verify unicity
                this.UpdateDailyRecordListUpToDate(lDailyRecordDateTime);
                #endregion

                #region 12.- Get initial Hydric Balance
                //If it's the initial registry set the initial Hydric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }
                #endregion

                #region 13.- New Values to Crop Irrigation Weather and Review Summary Data
                //Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
                // Use the last state (day before) to calculate the new state
                setNewValuesAndReviewSummaryData(lNewDailyRecord);
                #endregion

                this.DailyRecordList.Add(lNewDailyRecord);

                if (lDailyRecordDateTime <= pDateOfReference)
                {
                    this.OutPut += this.PrintState(this.Titles, this.TotalMessageLines, this, false);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddDailyRecordAccordingDaysAfterSowing " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        /// Add DailyRecord According Growing Degree Days
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        /// <param name="pWeatherData"></param>
        /// <param name="pDateOfReference"></param>
        public void AddDailyRecordAccordingGrowinDegreeDays(DateTime pDateTime, String pObservations, WeatherData pWeatherData,
                                                            DateTime pDateOfReference)
        {
            try
            {
                #region local variables
                WeatherData lWeatherData;
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration = 0;
                Double lBaseTemperature = 0;
                Double lStressTemperature = 0;
                Double lAverageTemperature = 0;
                Double lGrowingDegreeDays = 0;
                Double lGrowingDegreeDaysModified = 0;
                DateTime lLastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;
                DailyRecord lDailyRecord;
                int lDaysAfterSowing = 0;
                int lDaysAfterSowingModified = 0;
                Double lCropCoefficient = 0;
                Double lEvapotranspirationCropInput = 0;
                EvapotranspirationCrop lEvapotranspirationCrop = null;
                DailyRecord lNewDailyRecord = null;
                WeatherData lMainWeatherData = null;
                long lMainWeatherDataWeatherDataId = 0;
                WeatherData lAlternativeWeatherData = null;
                long lAlternativeWeatherDataWeatherDataId = 0;
                Rain lRain = null;
                long lRainWaterInputId = 0;
                Water.Irrigation lIrrigation = null;
                long lIrrigationWaterInputId = 0;
                #endregion

                lWeatherData = pWeatherData;
                
                lDailyRecordDateTime = pDateTime;

                #region 1.- Evapotranspiration
                if (lWeatherData != null)
                {
                    if (lWeatherData.WeatherDataType == Utils.WeatherDataType.AllData
                        || lWeatherData.WeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                    {
                        lEvapotranspiration = lWeatherData.GetEvapotranspiration();
                    }
                }
                else
                {
                    lEvapotranspiration = this.Crop.Region.GetEvapotranspiration(lDailyRecordDateTime);
                }
                #endregion

                #region 2.- Days After Sowing
                lDaysAfterSowing = this.calculateDaysAfterSowingForOneDay(this.SowingDate, lDailyRecordDateTime);
                #endregion

                #region 3.- Growing Degree Days
                //Growing Degree Days is average temperature menous Base Temperature 
                lBaseTemperature = this.GetBaseTemperature();
                lStressTemperature = this.GetStressTemperature();
                lLastDayOfGrowingDegreeDays = this.LastDayOfGrowingDegreeDays;
                if (lWeatherData != null)
                {
                    lAverageTemperature = lWeatherData.GetAverageTemperature(lStressTemperature, -lBaseTemperature);
                    lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(lBaseTemperature, lAverageTemperature);
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                        //is updated by calculateGrowingDegreeDaysForOneDay
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                    else if (lLastDayOfGrowingDegreeDays.Date > lDailyRecordDateTime.Date)
                    {
                        //Get Daily Record of the day before.
                        lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date.AddDays(-1));
                        if (lDailyRecord != null)
                        {
                            this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated + lGrowingDegreeDays;
                            this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified + lGrowingDegreeDays;
                            this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                        }
                    }
                }
                else
                {
                    lGrowingDegreeDays = this.CropInformationByDate.GetGrowingDegreeDays(lDailyRecordDateTime,
                                                                                        lBaseTemperature, lStressTemperature);
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                    else if (lLastDayOfGrowingDegreeDays.Date > lDailyRecordDateTime.Date)
                    {
                        //Get Daily Record of the day before.
                        lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date.AddDays(-1));
                        if (lDailyRecord != null)
                        {
                            this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated + lGrowingDegreeDays;
                            this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified + lGrowingDegreeDays;
                            this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                        }
                    }
                }
                lGrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
                #endregion

                #region 4.- Get Daily Record by Growing Degrees Days Modified
                lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date);
                if (lDailyRecord == null)
                {
                    lDailyRecord = this.getDailyRecordByGrowingDegreeDaysAccumulated(this.GrowingDegreeDaysModified);
                }
                else
                {
                    //state before new data is requiered
                    this.DaysAfterSowing = lDailyRecord.DaysAfterSowing;
                    this.LastBigGapWaterInputDate = lDailyRecord.LastBigGapWaterInputDate;
                    this.LastBigWaterInputDate = lDailyRecord.LastBigWaterInputDate;
                    this.LastPartialWaterInput = lDailyRecord.LastPartialWaterInput;
                    this.LastPartialWaterInputDate = lDailyRecord.LastPartialWaterInputDate;
                    this.PhenologicalStageId = lDailyRecord.PhenologicalStageId;
                    this.HydricBalance = lDailyRecord.HydricBalance;
                    this.SoilHydricVolume = lDailyRecord.SoilHydricVolume;
                    this.TotalEvapotranspirationCrop = lDailyRecord.TotalEvapotranspirationCrop;
                    this.TotalEvapotranspirationCropFromLastWaterInput = lDailyRecord.TotalEvapotranspirationCropFromLastWaterInput;
                }
                #endregion

                #region 5.- Get the Days After Sowing Modified according to Growing Degree Days Modified
                //If we do not modified GDD, DAS will be 0
                if (lDailyRecord == null)
                {
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lDaysAfterSowingModified = lDailyRecord.DaysAfterSowing;
                    lGrowingDegreeDays = lDailyRecord.GrowingDegreeDays;
                }
                #endregion

                #region 6.- Get Crop Coefficient by PhenologicalStage
                lCropCoefficient = this.PhenologicalStage.Coefficient;
                #endregion

                #region 7.- Calculus of Evapotranspiration Crop
                if (lWeatherData != null)
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lWeatherData.Date, lEvapotranspirationCropInput);
                }
                else
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lDailyRecordDateTime, lEvapotranspirationCropInput);
                }
                #endregion

                #region 8.- Weather Data
                lMainWeatherDataWeatherDataId = 0;
                if (this.MainWeatherStation != null)
                {
                    lMainWeatherData = this.MainWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lMainWeatherData != null)
                    {
                        lMainWeatherDataWeatherDataId = lMainWeatherData.WeatherDataId;
                    }
                }
                
                lAlternativeWeatherDataWeatherDataId = 0;
                if (this.AlternativeWeatherStation != null)
                {
                    lAlternativeWeatherData = this.AlternativeWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if(lAlternativeWeatherData != null)
                    {
                        lAlternativeWeatherDataWeatherDataId = lAlternativeWeatherData.WeatherDataId;
                    }
                }
                #endregion

                #region 9.- Water Input
                lRain = this.GetRain(lDailyRecordDateTime);
                if(lRain == null)
                {
                    lRainWaterInputId = 0;
                }
                else
                {
                    lRainWaterInputId = lRain.WaterInputId;
                }

                lIrrigation = this.GetIrrigationByDay(lDailyRecordDateTime);
                if(lIrrigation == null)
                {
                    lIrrigationWaterInputId = 0;
                }
                else if (lIrrigation.Type == Utils.WaterInputType.IrrigationWasNotDecided)
                {
                    lIrrigationWaterInputId = lIrrigation.WaterInputId;
                }
                else
                {
                    lIrrigationWaterInputId = lIrrigation.WaterInputId;
                }
                #endregion

                #region 10.- New Daily Record
                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, this.CropIrrigationWeatherId,
                                                lMainWeatherDataWeatherDataId, lAlternativeWeatherDataWeatherDataId,
                                                this.DaysAfterSowing, this.DaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                this.LastDayOfGrowingDegreeDays,
                                                lRainWaterInputId, lIrrigationWaterInputId, this.LastWaterInputDate, 
                                                this.LastBigWaterInputDate,
                                                this.LastPartialWaterInputDate, this.LastPartialWaterInput,
                                                this.LastBigGapWaterInputDate,
                                                lEvapotranspirationCrop, this.PhenologicalStageId,
                                                this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);
                //Update Rain & Irrigation
                if (lRain != null) lNewDailyRecord.Rain = lRain;
                if (lIrrigation != null) lNewDailyRecord.Irrigation = lIrrigation;
                #endregion

                #region 11.- Update Daily record list, verify unicity
                this.UpdateDailyRecordListUpToDate(lDailyRecordDateTime);
                #endregion

                #region 12.- Get initial Hydric Balance
                //If it's the initial registry set the initial Hydric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;
                }
                #endregion

                #region 13.- New Values to Crop Irrigation Weather and Review Summary Data
                //Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
                // Use the last state (day before) to calculate the new state
                setNewValuesAndReviewSummaryData(lNewDailyRecord);
                #endregion

                this.DailyRecordList.Add(lNewDailyRecord);

                if (lDailyRecordDateTime <= pDateOfReference)
                {
                    this.OutPut += this.PrintState(this.Titles, this.TotalMessageLines, this, false);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddDailyRecordAccordingGrowinDegreeDays " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
        }

        
        #region With Context
        /// <summary>
        /// Add DailyRecord to List with Context
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pObservation"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        /// <returns></returns>
        public bool AddDailyRecordToList(DateTime pDateTime, String pObservation, DateTime pDateOfReference, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            bool lReturn = false;
            WeatherData lWeatherData = null;
            EntityState lState;

            try
            {
                //The date has to be not null
                if (pDateTime != null)
                {
                    //Get WeatherData for the available Weather Station (Main or Alternative)
                    lWeatherData = this.GetWeatherDataFromAvailableWeatherStation(pDateTime);

                    //If WeatherData is not null, we can continue
                    if (lWeatherData != null)
                    {
                        if (this.CalculusMethodForPhenologicalAdjustment.Equals(
                            Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays))
                        {
                            this.AddDailyRecordAccordingGrowinDegreeDays(pDateTime, pObservation, lWeatherData, pDateOfReference, pIrrigationAdvisorContext);
                        }

                        if (this.CalculusMethodForPhenologicalAdjustment.Equals(
                            Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing))
                        {
                            this.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservation, lWeatherData, pDateOfReference, pIrrigationAdvisorContext);
                        }
                      
                        //Then that is added the DailyRecord, we must verify if we need to irrigate.
                        //If it is necesary, the irrigation is added to the list and the DailyRecord is readded.
                        this.VerifyNeedForIrrigation(pDateTime, pDateOfReference, pIrrigationAdvisorContext);
                    }
                    else
                    {
                        //If WeatherData is null, use DaysAfterSowing
                        this.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservation, lWeatherData, pDateOfReference, pIrrigationAdvisorContext);
                    }
                    lState = pIrrigationAdvisorContext.Entry(this).State;
                    pIrrigationAdvisorContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddDailyRecordToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        /// <summary>
        /// Add DailyRecord according Days After Sowing. With Context
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pObservations"></param>
        /// <param name="pWeatherData"></param>
        /// <param name="pDateOfReference"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        public void AddDailyRecordAccordingDaysAfterSowing(DateTime pCurrentDateTime, String pObservations, WeatherData pWeatherData,
                                                            DateTime pDateOfReference, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            try
            {
                #region local variables
                WeatherData lWeatherData;
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration = 0;
                Double lBaseTemperature = 0;
                Double lStressTemperature = 0;
                Double lAverageTemperature = 0;
                Double lGrowingDegreeDays = 0;
                Double lGrowingDegreeDaysModified = 0;
                DateTime lLastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;
                DailyRecord lDailyRecord;
                int lDaysAfterSowing = 0;
                int lDaysAfterSowingModified = 0;
                Double lCropCoefficient = 0;
                Double lEvapotranspirationCropInput = 0;
                EvapotranspirationCrop lEvapotranspirationCrop = null;
                DailyRecord lNewDailyRecord = null;
                WeatherData lMainWeatherData = null;
                long lMainWeatherDataWeatherDataId = 0;
                WeatherData lAlternativeWeatherData = null;
                long lAlternativeWeatherDataWeatherDataId = 0;
                Rain lRain = null;
                long lRainWaterInputId = 0;
                Water.Irrigation lIrrigation = null;
                long lIrrigationWaterInputId = 0;
                int lDatabaseChangeResult = 0;
                #endregion

                lWeatherData = pWeatherData;

                lDailyRecordDateTime = pCurrentDateTime;

                #region 1.- Evapotranspiration
                if (lWeatherData != null)
                {
                    if (lWeatherData.WeatherDataType == Utils.WeatherDataType.AllData
                        || lWeatherData.WeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                    {
                        lEvapotranspiration = lWeatherData.GetEvapotranspiration();
                    }
                }
                else
                {
                    lEvapotranspiration = this.Crop.Region.GetEvapotranspiration(lDailyRecordDateTime);
                }
                #endregion

                #region 2.- Days After Sowing
                lDaysAfterSowing = this.calculateDaysAfterSowingForOneDay(this.SowingDate, lDailyRecordDateTime);
                #endregion

                #region 2.2.- Daily Record by Days After Sowing for updating GDD
                lDailyRecord = this.getDailyRecordByDaysAfterSowingAccumulated(lDaysAfterSowing);
                if (lDailyRecord != null)
                {
                    this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated;
                    this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified;
                    this.LastDayOfGrowingDegreeDays = lDailyRecord.LastDayOfGrowingDegreeDays;
                }
                #endregion

                #region 3.- Growing Degree Days
                //Growing Degree Days is average temperature menous Base Temperature 
                lBaseTemperature = this.GetBaseTemperature();
                lStressTemperature = this.GetStressTemperature();
                lLastDayOfGrowingDegreeDays = this.LastDayOfGrowingDegreeDays;
                if (lWeatherData != null)
                {
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                        //is updated by calculateGrowingDegreeDaysForOneDay
                        lAverageTemperature = lWeatherData.GetAverageTemperature(lStressTemperature, -lBaseTemperature);
                        lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(lBaseTemperature, lAverageTemperature);
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                }
                else
                {
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        lGrowingDegreeDays = this.CropInformationByDate.GetGrowingDegreeDays(lDailyRecordDateTime,
                                                                                            lBaseTemperature, lStressTemperature);
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                }
                lGrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
                #endregion

                #region 4.- Get Daily Record by Days After Sowing Modified
                lDailyRecord = this.getDailyRecordByDaysAfterSowingAccumulated(this.DaysAfterSowingModified);
                #endregion

                #region 5.- Get the Growing Degree Days Modified according to Days After Sowing Modified
                //If we do not modified DAS, GDD will be 0
                if (lDailyRecord == null)
                {
                    lGrowingDegreeDaysModified = lGrowingDegreeDays;
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lGrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified;
                    lGrowingDegreeDays = lDailyRecord.GrowingDegreeDays;
                    lDaysAfterSowingModified = this.DaysAfterSowingModified;
                }
                #endregion

                #region 6.- Get Crop Coefficient by Days After Sowing Modified
                lCropCoefficient = this.Crop.CropCoefficient.GetCropCoefficient(lDaysAfterSowingModified);
                #endregion

                #region 7.- Calculus of Evapotranspiration Crop
                if (lWeatherData != null)
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lWeatherData.Date, lEvapotranspirationCropInput);
                }
                else
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lDailyRecordDateTime, lEvapotranspirationCropInput);
                }

                #endregion

                #region 8.- Weather Data
                lMainWeatherDataWeatherDataId = 0;
                if (this.MainWeatherStation != null)
                {
                    lMainWeatherData = this.MainWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lMainWeatherData != null)
                    {
                        lMainWeatherDataWeatherDataId = lMainWeatherData.WeatherDataId;
                    }
                }

                lAlternativeWeatherDataWeatherDataId = 0;
                if (this.AlternativeWeatherStation != null)
                {
                    lAlternativeWeatherData = this.AlternativeWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lAlternativeWeatherData != null)
                    {
                        lAlternativeWeatherDataWeatherDataId = lAlternativeWeatherData.WeatherDataId;
                    }
                }
                #endregion

                #region 9.- Water Input
                lRain = this.GetRain(lDailyRecordDateTime);
                if (lRain == null)
                {
                    lRainWaterInputId = 0;
                }
                else
                {
                    lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    lRainWaterInputId = lRain.WaterInputId;
                }
                lIrrigation = this.GetIrrigationByDay(lDailyRecordDateTime);
                if (lIrrigation == null)
                {
                    lIrrigationWaterInputId = 0;
                }
                else
                {
                    lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    lIrrigationWaterInputId = lIrrigation.WaterInputId;
                }
                #endregion

                #region 10.- New Daily Record
                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput

                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, this.CropIrrigationWeatherId,
                                                lMainWeatherDataWeatherDataId, lAlternativeWeatherDataWeatherDataId,
                                                this.DaysAfterSowing, this.DaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                this.LastDayOfGrowingDegreeDays,
                                                lRainWaterInputId, lIrrigationWaterInputId, this.LastWaterInputDate, 
                                                this.LastBigWaterInputDate,
                                                this.LastPartialWaterInputDate, this.LastPartialWaterInput,
                                                this.LastBigGapWaterInputDate,
                                                lEvapotranspirationCrop, this.PhenologicalStageId,
                                                this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);
                //Update Rain & Irrigation
                if (lRain != null) lNewDailyRecord.Rain = lRain;
                if (lIrrigation != null) lNewDailyRecord.Irrigation = lIrrigation;
                #endregion

                #region 11.- Update Daily record list, verify unicity
                this.UpdateDailyRecordListUpToDate(lDailyRecordDateTime, pIrrigationAdvisorContext);
                lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                #endregion

                #region 12.- Get initial Hydric Balance
                //If it's the initial registry set the initial Hydric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;// new Pair<int, DateTime>(-1, this.CropIrrigationWeatherRecord.SowingDate);
                }
                #endregion

                #region 13.- New Values to Crop Irrigation Weather and Review Summary Data
                //Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
                // Use the last state (day before) to calculate the new state
                setNewValuesAndReviewSummaryData(lNewDailyRecord);
                lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                #endregion

                this.DailyRecordList.Add(lNewDailyRecord);

                if (lDailyRecordDateTime <= pDateOfReference)
                {
                    this.OutPut += this.PrintState(this.Titles, this.TotalMessageLines, this, false);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddDailyRecordAccordingDaysAfterSowing " 
                                    + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
        }

        /// <summary>
        /// Add DailyRecord According Growing Degree Days. With Context
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <param name="pObservations"></param>
        /// <param name="pWeatherData"></param>
        /// <param name="pDateOfReference"></param>
        /// <param name="pIrrigationAdvisorContext"></param>
        public void AddDailyRecordAccordingGrowinDegreeDays(DateTime pDateTime, String pObservations, WeatherData pWeatherData,
                                                            DateTime pDateOfReference, IrrigationAdvisorContext pIrrigationAdvisorContext)
        {
            try
            {
                #region local variables
                WeatherData lWeatherData;
                DateTime lDailyRecordDateTime;
                Double lEvapotranspiration = 0;
                Double lBaseTemperature = 0;
                Double lStressTemperature = 0;
                Double lAverageTemperature = 0;
                Double lGrowingDegreeDays = 0;
                Double lGrowingDegreeDaysModified = 0;
                DateTime lLastDayOfGrowingDegreeDays = Utils.MIN_DATETIME;
                DailyRecord lDailyRecord = null;
                int lDaysAfterSowing = 0;
                int lDaysAfterSowingModified = 0;
                Double lCropCoefficient = 0;
                Double lEvapotranspirationCropInput = 0;
                EvapotranspirationCrop lEvapotranspirationCrop = null;
                DailyRecord lNewDailyRecord = null;
                WeatherData lMainWeatherData = null;
                long lMainWeatherDataWeatherDataId = 0;
                WeatherData lAlternativeWeatherData = null;
                long lAlternativeWeatherDataWeatherDataId = 0;
                Rain lRain = null;
                long lRainWaterInputId = 0;
                Water.Irrigation lIrrigation = null;
                long lIrrigationWaterInputId = 0;
                int lDatabaseChangeResult = 0;
                #endregion

                lWeatherData = pWeatherData;

                lDailyRecordDateTime = pDateTime;

                #region 1.- Evapotranspiration
                if (lWeatherData != null)
                {
                    if (lWeatherData.WeatherDataType == Utils.WeatherDataType.AllData
                        || lWeatherData.WeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                    {
                        lEvapotranspiration = lWeatherData.GetEvapotranspiration();
                    }
                }
                else
                {
                    lEvapotranspiration = this.Crop.Region.GetEvapotranspiration(lDailyRecordDateTime);
                }
                #endregion

                #region 2.- Days After Sowing
                lDaysAfterSowing = this.calculateDaysAfterSowingForOneDay(this.SowingDate, lDailyRecordDateTime);
                #endregion
                
                #region 3.- Growing Degree Days
                //Growing Degree Days is average temperature menous Base Temperature 
                lBaseTemperature = this.GetBaseTemperature();
                lStressTemperature = this.GetStressTemperature();
                lLastDayOfGrowingDegreeDays = this.LastDayOfGrowingDegreeDays;
                if (lWeatherData != null)
                {
                    lAverageTemperature = lWeatherData.GetAverageTemperature(lStressTemperature, -lBaseTemperature);
                    lGrowingDegreeDays = this.calculateGrowingDegreeDaysForOneDay(lBaseTemperature, lAverageTemperature);
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        //GrowingDegreeDaysAccumulated & GrowingDegreeDaysModified 
                        //is updated by calculateGrowingDegreeDaysForOneDay
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                    else if (lLastDayOfGrowingDegreeDays.Date > lDailyRecordDateTime.Date)
                    {
                        //Get Daily Record of the day before.
                        lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date.AddDays(-1));
                        if(lDailyRecord != null)
                        {
                            this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated + lGrowingDegreeDays;
                            this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified + lGrowingDegreeDays;
                            this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                        }
                    }
                }
                else
                {
                    lGrowingDegreeDays = this.CropInformationByDate.GetGrowingDegreeDays(lDailyRecordDateTime,
                                                                                        lBaseTemperature, lStressTemperature);
                    //Add DegreeDays ones a day
                    if (lLastDayOfGrowingDegreeDays.Date < lDailyRecordDateTime.Date)
                    {
                        this.GrowingDegreeDaysAccumulated += lGrowingDegreeDays;
                        this.GrowingDegreeDaysModified += lGrowingDegreeDays;
                        this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                    }
                    else if (lLastDayOfGrowingDegreeDays.Date > lDailyRecordDateTime.Date)
                    {
                        //Get Daily Record of the day before.
                        lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date.AddDays(-1));
                        if (lDailyRecord != null)
                        {
                            this.GrowingDegreeDaysAccumulated = lDailyRecord.GrowingDegreeDaysAccumulated + lGrowingDegreeDays;
                            this.GrowingDegreeDaysModified = lDailyRecord.GrowingDegreeDaysModified + lGrowingDegreeDays;
                            this.LastDayOfGrowingDegreeDays = lDailyRecordDateTime.Date;
                        }
                    }
                }
                lGrowingDegreeDaysModified = this.GrowingDegreeDaysModified;
                #endregion

                #region 4.- Get Daily Record by Growing Degrees Days Modified
                lDailyRecord = this.GetDailyRecordByDate(lDailyRecordDateTime.Date);
                if (lDailyRecord == null)
                {
                    lDailyRecord = this.getDailyRecordByGrowingDegreeDaysAccumulated(this.GrowingDegreeDaysModified);
                }
                else 
                {
                    //state before new data is requiered
                    this.DaysAfterSowing = lDailyRecord.DaysAfterSowing;
                    this.LastBigGapWaterInputDate = lDailyRecord.LastBigGapWaterInputDate;
                    this.LastBigWaterInputDate = lDailyRecord.LastBigWaterInputDate;
                    this.LastPartialWaterInput = lDailyRecord.LastPartialWaterInput;
                    this.LastPartialWaterInputDate = lDailyRecord.LastPartialWaterInputDate;
                    this.PhenologicalStageId = lDailyRecord.PhenologicalStageId;
                    this.HydricBalance = lDailyRecord.HydricBalance;
                    this.SoilHydricVolume = lDailyRecord.SoilHydricVolume;
                    this.TotalEvapotranspirationCrop = lDailyRecord.TotalEvapotranspirationCrop;
                    this.TotalEvapotranspirationCropFromLastWaterInput = lDailyRecord.TotalEvapotranspirationCropFromLastWaterInput;
                }
                #endregion

                #region 5.- Get the Days After Sowing Modified according to Growing Degree Days Modified
                //If we do not modified GDD, DAS will be 0
                if (lDailyRecord == null)
                {
                    lDaysAfterSowingModified = lDaysAfterSowing;
                }
                else
                {
                    lDaysAfterSowingModified = lDailyRecord.DaysAfterSowing;
                    lGrowingDegreeDays = lDailyRecord.GrowingDegreeDays;
                }
                #endregion

                #region 6.- Get Crop Coefficient by PhenologicalStage 
                lCropCoefficient = this.PhenologicalStage.Coefficient;
                #endregion

                #region 7.- Calculus of Evapotranspiration Crop
                if (lWeatherData != null)
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lWeatherData.Date, lEvapotranspirationCropInput);
                }
                else
                {
                    lEvapotranspirationCropInput = lEvapotranspiration * lCropCoefficient;
                    lEvapotranspirationCrop = this.AddEvapotranspirationCrop(lDailyRecordDateTime, lEvapotranspirationCropInput);
                }
                #endregion

                #region 8.- Weather Data
                lMainWeatherDataWeatherDataId = 0;
                if (this.MainWeatherStation != null)
                {
                    lMainWeatherData = this.MainWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lMainWeatherData != null)
                    {
                        lMainWeatherDataWeatherDataId = lMainWeatherData.WeatherDataId;
                    }
                }

                lAlternativeWeatherDataWeatherDataId = 0;
                if (this.AlternativeWeatherStation != null)
                {
                    lAlternativeWeatherData = this.AlternativeWeatherStation.FindWeatherData(lDailyRecordDateTime);
                    if (lAlternativeWeatherData != null)
                    {
                        lAlternativeWeatherDataWeatherDataId = lAlternativeWeatherData.WeatherDataId;
                    }
                }
                #endregion

                #region 9.- Water Input
                lRain = this.GetRain(lDailyRecordDateTime);
                if (lRain == null)
                {
                    lRainWaterInputId = 0;
                }
                else
                {
                    lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    lRainWaterInputId = lRain.WaterInputId;
                }

                lIrrigation = this.GetIrrigationOrCreateNew(lDailyRecordDateTime);
                if(lIrrigation == null)
                {
                    lIrrigationWaterInputId = 0;
                }
                else if (lIrrigation.Type == Utils.WaterInputType.IrrigationWasNotDecided)
                {
                    lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                    lIrrigationWaterInputId = lIrrigation.WaterInputId;
                }
                else
                {
                    lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();      
                    lIrrigationWaterInputId = lIrrigation.WaterInputId;
                }

                #endregion

                #region 10.- New Daily Record
                //We need to update some fields for calculations:
                //  pLastWaterInputDate, pLastBigWaterInputDate, 
                //  pLastPartialWaterInputDate, pLastPartialWaterInput, 
                //  this.HydricBalance, this.SoilHydricVolume,
                //  this.TotalEvapotranspirationCropFromLastWaterInput
                lNewDailyRecord = new DailyRecord(lDailyRecordDateTime, this.CropIrrigationWeatherId,
                                                lMainWeatherDataWeatherDataId, lAlternativeWeatherDataWeatherDataId,
                                                this.DaysAfterSowing, this.DaysAfterSowingModified,
                                                lGrowingDegreeDays, this.GrowingDegreeDaysAccumulated, this.GrowingDegreeDaysModified,
                                                this.LastDayOfGrowingDegreeDays,
                                                lRainWaterInputId, lIrrigationWaterInputId, this.LastWaterInputDate, 
                                                this.LastBigWaterInputDate,
                                                this.LastPartialWaterInputDate, this.LastPartialWaterInput,
                                                this.LastBigGapWaterInputDate,
                                                lEvapotranspirationCrop, this.PhenologicalStageId,
                                                this.HydricBalance, this.SoilHydricVolume,
                                                this.TotalEvapotranspirationCropFromLastWaterInput,
                                                lCropCoefficient, pObservations);
                //Update Rain & Irrigation
                if (lRain != null) lNewDailyRecord.Rain = lRain;
                if (lIrrigation != null) lNewDailyRecord.Irrigation = lIrrigation;
                #endregion

                #region 11.- Update Daily record list, verify unicity
                this.UpdateDailyRecordListUpToDate(lDailyRecordDateTime, pIrrigationAdvisorContext);
                lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                #endregion

                #region 12.- Get initial Hydric Balance
                //If it's the initial registry set the initial Hydric Balance
                if (lDaysAfterSowing == 0)
                {
                    this.HydricBalance = this.GetInitialHydricBalance();
                    this.DaysAfterSowing = 0;
                }
                #endregion

                #region 13.- New Values to Crop Irrigation Weather and Review Summary Data
                //Set the new values (after add a new dailyRecord) for the variables used to resume the state of the crop.
                // Use the last state (day before) to calculate the new state
                setNewValuesAndReviewSummaryData(lNewDailyRecord);
                lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
                #endregion

                this.DailyRecordList.Add(lNewDailyRecord);

                if(lDailyRecordDateTime <= pDateOfReference)
                {
                    this.OutPut += this.PrintState(this.Titles, this.TotalMessageLines, this, false);
                }

                lDatabaseChangeResult = pIrrigationAdvisorContext.SaveChanges();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.AddDailyRecordAccordingGrowinDegreeDays " 
                                        + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
        }

        #endregion

        #endregion

        #region EffectiveRain

        /// <summary>
        /// Gives the effective lRainItem registered in a specific date including the output and extraOutput value.
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public Double GetEffectiveRain(DateTime pDate)
        {
            Double lRetrun = 0;
            Double lEffectiveRain = 0;

            foreach (DailyRecord lDailyRec in this.DailyRecordList)
            {
                if (lDailyRec.DailyRecordDateTime.Date.Equals(pDate.Date))
                {
                    lEffectiveRain = lDailyRec.Rain.Input + lDailyRec.Rain.ExtraInput;
                    break;
                }
            }

            lRetrun = lEffectiveRain;
            return lRetrun;
        }

        #endregion

        #region IrrigationUnit

        
        #endregion

        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            CropIrrigationWeather lCropIrrigationWeather = obj as CropIrrigationWeather;
            lReturn = this.CropId.Equals(lCropIrrigationWeather.CropId) &&
                    this.IrrigationUnitId.Equals(lCropIrrigationWeather.IrrigationUnitId) &&
                    this.MainWeatherStationId.Equals(lCropIrrigationWeather.MainWeatherStationId) &&
                    this.SowingDate.Equals(lCropIrrigationWeather.SowingDate);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.CropId.GetHashCode();
        }

        public override string ToString()
        {
            string lResult = null;
            lResult = cropIrrigationWeatherName;
            return lResult;
        }
        #endregion

        #region Print

        /// <summary>
        /// Return the total Lines searchig in Messages
        /// </summary>
        /// <returns></returns>
        private long GetTotalLines(List<Management.Message> lMessageList)
        {
            long lTotalLines = 0;
            long lLine = 0;
            foreach (var item in lMessageList)
            {
                if (!String.IsNullOrEmpty(item.Data))
                {
                    if (lLine < item.LineId)
                    {
                        lTotalLines += 1;
                    }
                }
            }
            return lTotalLines;
        }

        /// <summary>
        /// Return the Print Headers
        /// </summary>
        /// <returns></returns>
        private string printHeader()
        {
            //string lRetrun = Environment.NewLine +
            string lRetrun = "DDS " +
                " \t Fecha " +
                " \t ETCAc " +
                " \t ETC Llu" +
                " \t G.Dia: " +
                " \t G.D. Mod: " +
                " \t B.Hid: " +
                " \t % A.D.: " +
                " \t A.D.: " +
                " \t CC: " +
                " \t PMP: " +
                " \t Llu Ef: " +
                " \t Lluv Tot: " +
                " \t Fech Ult Llu: " +
                " \t Raiz " +
                " \t Fenol " +
                " \t Tot RiegoCalc: " +
                " \t TipoRiego: " +
                " \t Tot RiegoInBI: " +
                " \t Tot RiegoExtra: " +
                " \t Tot RiegoExtraInBI: " +
                Environment.NewLine;

            //Add all the Title in a List of Strings
            if (this.Titles == null) {
                this.Titles = new List<Title>();
            }

            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "DDS"));              //  1
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "Fecha"));            //  2
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "ETc-Ac"));           //  3
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "ETC Llu"));          //  4
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "GDia"));             //  5
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "GDia-Mod"));         //  6
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "B-Hid"));            //  7
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "% Water"));          //  8
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "Ag-Disp"));          //  9
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "CC"));               // 10
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "PMP"));              // 11
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "LLu-Ef"));           // 12
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "Llu-Tot"));          // 13
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "Fecha-Ult-Llu"));    // 14
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "Raiz"));             // 15
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "Fenol"));            // 16
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "RiegoCalc"));        // 17
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "TipoRiego"));        // 18
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "TotRiegoCalcInBI")); // 19
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "RiegoExtra"));       // 20
            this.Titles.Add(new Title(this.Titles.Count, this.cropIrrigationWeatherId, false, "TotRiegoExtraInBI"));// 21

            return lRetrun;
        }

        /// <summary>
        /// Adds data to print daily records
        /// </summary>
        public void AddToPrintDailyRecords(long pCropIrrigationWeatherId)
        {

            if (this.TitlesDaily == null)
            {
                this.TitlesDaily = new List<Title>();
            }
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "Fecha"));
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "GDia"));
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "ETc"));
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "LLuvia"));
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "Riego"));
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "KC"));
            this.Titles.Add(new Title(this.TitlesDaily.Count, pCropIrrigationWeatherId, true, "Observaciones"));


            if (this.MessagesDaily == null)
            {
                this.MessagesDaily = new List<Message>();
            }

            long lCropIrrigationWeatherId = pCropIrrigationWeatherId;
            bool lDaily = true;
            long lLineId = this.TotalMessageDailyLines;
            foreach (DailyRecord lDR in DailyRecordList)
            {
                this.TotalMessageDailyLines += 1;
                lLineId = this.TotalMessageDailyLines;
                long lTitleId = (from title in this.TitlesDaily where title.Name == "Fecha" select title.TitleId).FirstOrDefault();
                this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.DailyRecordDateTime.ToString()));
                
                lTitleId += 1;
                this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.GrowingDegreeDays.ToString()));
                lTitleId += 1;
                if (lDR.EvapotranspirationCrop == null)
                {
                    this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, "0"));
                }
                else
                {
                    this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.EvapotranspirationCrop.GetTotalOutput().ToString()));
                }
                lTitleId += 1;
                if (lDR.Rain == null)
                {
                    this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, "0"));
                }
                else
                {
                    this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.Rain.GetTotalInput().ToString()));
                }
                lTitleId += 1;
                if (lDR.Irrigation == null)
                {
                    this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, "0"));
                }
                else
                {
                    this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.Irrigation.GetTotalInput().ToString()));
                }
                lTitleId += 1;
                this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.CropCoefficient.ToString()));
                lTitleId += 1;
                this.MessagesDaily.Add(new Message(this.MessagesDaily.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lDR.Observations));
            }
        }

        /// <summary>
        /// Return the state of CropIrrigationWeather
        /// </summary>
        /// <returns></returns>
        public string PrintState(List<Title> pTitles, long pLineId,
                            CropIrrigationWeather pCropIrrigationWeather, bool pDaily)
        {
            string lReturn;
            string lETcAcumulated;
            string lETcFromLastWaterInput;
            string lGrowDegree;
            string lModifiedGrowingDegree;
            string lEffectiveRain;
            string lTotalRain;
            string lHydricBalance;
            string lPercentageOfAvailableWater;
            string lAvailableWater;
            string lFieldCapacity;
            string lPermanentWilingPoint;
            string lIrrigation;
            string lTypeOfIrrigation;
            string lTotIrrInHB;
            string lExtraIrrigation;
            string lTotExtraIrrInHB;
            Water.Irrigation lWaterInput;

            lReturn = "";
            lETcAcumulated = pCropIrrigationWeather.TotalEvapotranspirationCrop + "        ";
            lETcFromLastWaterInput = this.TotalEvapotranspirationCropFromLastWaterInput + "        ";
            lGrowDegree = this.GrowingDegreeDaysAccumulated + "        ";
            lModifiedGrowingDegree = this.GrowingDegreeDaysModified + "        ";
            lEffectiveRain = pCropIrrigationWeather.TotalEffectiveRain + "        ";
            lTotalRain = pCropIrrigationWeather.TotalRealRain + "        ";
            lHydricBalance = this.HydricBalance.ToString() + "        ";
            lPercentageOfAvailableWater = pCropIrrigationWeather.GetPercentageOfHydricBalance() + "        ";
            lAvailableWater = pCropIrrigationWeather.GetSoilAvailableWaterCapacity() + "        ";
            lFieldCapacity = pCropIrrigationWeather.GetSoilFieldCapacity() + "        ";
            lPermanentWilingPoint = pCropIrrigationWeather.GetSoilPermanentWiltingPoint() + "        ";

            lWaterInput = this.GetDailyRecordByDate(this.CropDate).Irrigation;
            if (lWaterInput == null)
            {
                lIrrigation = 0 + "        ";
                lExtraIrrigation = 0 + "        ";
                lTypeOfIrrigation = "                                 ";
            }
            else
            {
                lIrrigation = lWaterInput.Input.ToString() + "        ";
                lExtraIrrigation = lWaterInput.ExtraInput.ToString() + "        ";
                lTypeOfIrrigation = lWaterInput.Type.ToString() + "                                 ";
            }
            lTotIrrInHB = pCropIrrigationWeather.TotalIrrigationInHydricBalance.ToString() + "        ";
            lTotExtraIrrInHB = pCropIrrigationWeather.TotalExtraIrrigationInHydricBalance.ToString() + "        ";


            lReturn = this.DaysAfterSowing.ToString() +
                " \t " + this.CropDate.ToShortDateString() +
                " \t " + lETcAcumulated.Substring(0, 7) +
                " \t " + lETcFromLastWaterInput.Substring(0, 7) +
                " \t " + lGrowDegree.Substring(0, 7) +
                " \t " + lModifiedGrowingDegree.Substring(0, 7) +
                " \t " + lHydricBalance.Substring(0, 7) +
                " \t " + lPercentageOfAvailableWater.Substring(0, 7) +
                " \t " + lAvailableWater.Substring(0, 7) +
                " \t " + lFieldCapacity.Substring(0, 7) +
                " \t " + lPermanentWilingPoint.Substring(0, 7) +
                " \t " + lEffectiveRain.Substring(0, 7) +
                " \t " + lTotalRain.Substring(0, 7) +
                " \t " + this.LastWaterInputDate.ToShortDateString() +
                " \t " + pCropIrrigationWeather.GetRootDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage) +
                " \t " + this.PhenologicalStage.Stage.Name +
                " \t " + lIrrigation.Substring(0, 7) +
                " \t " + lTypeOfIrrigation.Substring(0, 30) +
                " \t " + lTotIrrInHB.Substring(0, 7) +
                " \t " + lExtraIrrigation.Substring(0, 7) +
                " \t " + lTotExtraIrrInHB.Substring(0, 7) +
                Environment.NewLine;

            if (this.Messages == null)
            {
                this.Messages = new List<Message>();
            }
            long lLineId = pLineId;
            long lCropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId;
            bool lDaily = pDaily;
            long lTitleId = (from title in pTitles 
                             where title.Name == "DDS" 
                                && title.Daily == pDaily 
                                && title.CropIrrigationWeatherId == lCropIrrigationWeatherId
                             select title.TitleId).FirstOrDefault();
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, this.DaysAfterSowing.ToString()));              //  1
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, this.CropDate.ToShortDateString()));            //  2
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lETcAcumulated.Substring(0, 7)));               //  3
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lETcFromLastWaterInput.Substring(0, 7)));       //  4
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lGrowDegree.Substring(0, 7)));                  //  5
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lModifiedGrowingDegree.Substring(0, 7)));       //  6
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lHydricBalance.Substring(0, 7)));               //  7
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lPercentageOfAvailableWater.Substring(0, 7)));  //  8
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lAvailableWater.Substring(0, 7)));              //  9
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lFieldCapacity.Substring(0, 7)));               // 10
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lPermanentWilingPoint.Substring(0, 7)));        // 11
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lEffectiveRain.Substring(0, 7)));               // 12
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lTotalRain.Substring(0, 7)));                   // 13
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, this.lastWaterInputDate.ToShortDateString()));  // 14
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, pCropIrrigationWeather.GetRootDepthTakingIntoAccountSoilDepthLimit(this.PhenologicalStage).ToString()));    // 15
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, this.PhenologicalStage.Stage.Name));            // 16
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lIrrigation.Substring(0, 7)));                  // 17
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lTypeOfIrrigation.Substring(0, 30)));           // 18
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lTotIrrInHB.Substring(0, 7)));                  // 19
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lExtraIrrigation.Substring(0, 7)));             // 20
            lTitleId += 1;
            this.Messages.Add(new Message(this.Messages.Count, lTitleId, lLineId, lCropIrrigationWeatherId, lDaily, lTotExtraIrrInHB.Substring(0, 7)));             // 21
            this.TotalMessageLines += 1;

            return lReturn;
        }

        #endregion



    }
}