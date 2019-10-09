using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using NLog;
using IrrigationAdvisor.DBContext;
using System.ComponentModel;

namespace IrrigationAdvisor.Models.Weather
{
    /// <summary>
    /// Create: 2014-10-14
    /// Author: rodouy
    /// Description: 
    ///     this class describes a Weather Station
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - long int
    ///     - name String
    ///     - model String
    ///     - dateOfInstallation Date
    ///     - dateOfService Datetime
    ///     - updateTime Time
    ///     - wirelessTransmission int
    ///     - location Location
    ///     - giveET bool
    /// 
    /// Methods:
    ///     - WeatherStation()      -- constructor
    ///     - WeatherStation(name)  -- consturctor with parameters
    ///     - SetService(DateTime)  -- method to set the name field
    /// 
    /// </summary>
    //[Serializable()]
    public class WeatherStation //: System.ComponentModel.INotifyPropertyChanged
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        ///  Fields of Class:
        ///     - weatherStationId long
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        ///     - enabled bool
        /// </summary>
        private long weatherStationId;
        private String name;
        private String model;
        private Utils.WeatherStationType stationType;
        private DateTime dateOfInstallation;
        private DateTime dateOfService;
        private DateTime updateTime;
        private int wirelessTransmission;
        private long positionId;
        private bool giveET;
        private List<WeatherData> weatherDataList;
        private Utils.WeatherDataType weatherDataType;
        private String webAddress;
        private bool enabled;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties
        /// <summary>
        /// Properties of Class:
        ///     - weatherStationId long
        ///     - name String
        ///     - model String
        ///     - dateOfInstallation Date
        ///     - dateOfService Datetime
        ///     - updateTime Time
        ///     - wirelessTransmission int
        ///     - location Location
        ///     - giveET bool
        /// </summary>


        public long WeatherStationId
        {
            get { return weatherStationId; }
            set { weatherStationId = value; }
        }

        [Display(Name = "Nombre")]
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        [Display(Name = "Modelo")]
        public String Model
        {
            get { return model; }
            set { model = value; }
        }
        [Display(Name = "Tipo")]
        public Utils.WeatherStationType StationType
        {
            get { return stationType; }
            set { stationType = value; }
        }
        
        [Display(Name = "Fecha instalación")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfInstallation
        {
            get { return dateOfInstallation; }
            set { dateOfInstallation = value; }
        }
        [Display(Name = "Fecha servicio")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfService
        {
            get { return dateOfService; }
            set { dateOfService = value; }
        }
        [Display(Name = "Fecha actualización")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        [Display(Name = "Trans. wireless")]
        public int WirelessTransmission
        {
            get { return wirelessTransmission; }
            set { wirelessTransmission = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }
        [Display(Name = "Brinda ET")]
        public bool GiveET
        {
            get { return giveET; }
            set { giveET = value; }
        }

        public List<WeatherData> WeatherDataList
        {
            get { return weatherDataList; }
            set { weatherDataList = value; }
        }
        [Display(Name = "Tipo de datos")]
        public Utils.WeatherDataType WeatherDataType
        {
            get { return weatherDataType; }
            set { weatherDataType = value; }
        }
        [Display(Name = "Dirección web")]
        public String WebAddress
        {
            get { return webAddress; }
            set { webAddress = value; }
        }
        public virtual Position Position
        {
            get;
            set;
        }
        [Display(Name = "Habilitada")]

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }
        #endregion

        #region Construction

        /// <summary>
        /// Constructors of WeatherStation
        /// </summary>
        public WeatherStation()
        {
            this.WeatherStationId = 0;
            this.Name = "";
            this.Model = "";
            this.StationType = Utils.WeatherStationType.NOWebInformation;
            this.DateOfInstallation = DateTime.Now;
            this.DateOfService = DateTime.Now;
            this.UpdateTime = Utils.MIN_DATETIME;
            this.WirelessTransmission = 0;
            this.PositionId = 0;
            this.GiveET = false;
            this.WeatherDataList = new List<WeatherData>();
            this.WeatherDataType = Utils.WeatherDataType.AllData;
            this.WebAddress = "";
            this.Enabled = true;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pWeatherStationId"></param>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pStationType"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pGiveET"></param>
        /// <param name="pWeatherDataList"></param>
        /// <param name="pWeatherDataType"></param>
        /// <param name="pWebAddress"></param>
        public WeatherStation(long pWeatherStationId, String pName, String pModel,
            Utils.WeatherStationType pStationType, DateTime pDateOfInstallation, 
            DateTime pDateOfService, DateTime pUpdateTime, int pWirelessTransmission, 
            long pPositionId, bool pGiveET, List<WeatherData> pWeatherDataList,
            Utils.WeatherDataType pWeatherDataType, String pWebAddress)
        {
            this.WeatherStationId = pWeatherStationId;
            this.Name = pName;
            this.Model = pModel;
            this.DateOfInstallation = pDateOfInstallation;
            this.DateOfService = pDateOfService;
            this.UpdateTime = pUpdateTime;
            this.WirelessTransmission = pWirelessTransmission;
            this.PositionId = pPositionId;
            this.GiveET = pGiveET;
            this.WeatherDataList = pWeatherDataList;
            this.WeatherDataType = pWeatherDataType;
            this.WebAddress = pWebAddress;
            this.Enabled = true;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Set Weather Data Type by Weather Information
        /// Depends on WetherDataType of Weather Station, 
        /// and on Temperatures and Evapotranspiration of WeatherData
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <returns></returns>
        private Utils.WeatherDataType SetWeatherDataTypeByWeatherInformation(WeatherData pWeatherData)
        {
            Utils.WeatherDataType lReturn;
            Utils.WeatherDataType lWeatherDataType;

            lWeatherDataType = Utils.WeatherDataType.NoData;
            if (this.ExistWeatherData(pWeatherData) != null)
            {
                lWeatherDataType = this.WeatherDataType;

                //If we only have Evapotranspiraton
                if (lWeatherDataType == Utils.WeatherDataType.Evapotranspiraton)
                {
                    pWeatherData.Temperature = 0;
                    pWeatherData.TemperatureMax = 0;
                    pWeatherData.TemperatureMin = 0;
                    pWeatherData.WeatherDataType = lWeatherDataType;
                }
                //If we only have Temperature
                else if (lWeatherDataType == Utils.WeatherDataType.Temperature)
                {
                    pWeatherData.Evapotranspiration = 0;
                    pWeatherData.WeatherDataType = lWeatherDataType;
                }
                else
                {
                    //Has No Data
                    if (pWeatherData.Evapotranspiration == 0 
                        && pWeatherData.TemperatureMax == 0 && pWeatherData.TemperatureMin == 0)
                    {
                        pWeatherData.WeatherDataType = Utils.WeatherDataType.NoData;
                    }
                    //No Temperature Data
                    else if (pWeatherData.TemperatureMax == 0 && pWeatherData.TemperatureMin == 0)
                    {
                        pWeatherData.WeatherDataType = Utils.WeatherDataType.Evapotranspiraton;
                    }
                    //No Evapotranspiration Data
                    else if (pWeatherData.Evapotranspiration == 0)
                    {
                        pWeatherData.WeatherDataType = Utils.WeatherDataType.Temperature;
                    }
                }
            }

            lReturn = lWeatherDataType;
            return lReturn;
        }

        /// <summary>
        /// Calculate Estimate Measures from WeatherData List
        /// Prediction Weight: day -1 45%, day -2 30%, day -3 15%, day -4 7%, day -5 3%, 
        /// We assume the same data for:
        ///     - Solar Radiation
        ///     - Wind Speed
        /// </summary>
        /// <param name="pLastDay"></param>
        /// <returns></returns>
        private WeatherData CalculateEstimateWeatherData(DateTime pLastDay)
        {
            #region local variables
            WeatherData lReturn = null;

            Double lTemperature;
            Double lSolarRadiation;
            Double lTemperatureMax;
            Double lTemperatureMaxLast5;
            Double lTemperatureMaxLast5Weight;
            Double lTemperatureMaxLast4;
            Double lTemperatureMaxLast4Weight;
            Double lTemperatureMaxLast3;
            Double lTemperatureMaxLast3Weight;
            Double lTemperatureMaxLast2;
            Double lTemperatureMaxLast2Weight;
            Double lTemperatureMaxLast1;
            Double lTemperatureMaxLast1Weight;
            Double lTemperatureMin;
            Double lTemperatureMinLast5;
            Double lTemperatureMinLast5Weight;
            Double lTemperatureMinLast4;
            Double lTemperatureMinLast4Weight;
            Double lTemperatureMinLast3;
            Double lTemperatureMinLast3Weight;
            Double lTemperatureMinLast2;
            Double lTemperatureMinLast2Weight;
            Double lTemperatureMinLast1;
            Double lTemperatureMinLast1Weight;
            Double lEvapotranspiration;
            Double lEvapotranspirationLast5;
            Double lEvapotranspirationLast5Weight;
            Double lEvapotranspirationLast4;
            Double lEvapotranspirationLast4Weight;
            Double lEvapotranspirationLast3;
            Double lEvapotranspirationLast3Weight;
            Double lEvapotranspirationLast2;
            Double lEvapotranspirationLast2Weight;
            Double lEvapotranspirationLast1;
            Double lEvapotranspirationLast1Weight;
            Double lWindSpeed;
            WeatherData lWeatherData = null;
            DateTime lLastDay = pLastDay;
            #endregion

            #region Prediction Weight
            lTemperatureMaxLast1Weight = 0.45;
            lTemperatureMaxLast2Weight = 0.30;
            lTemperatureMaxLast3Weight = 0.15;
            lTemperatureMaxLast4Weight = 0.07;
            lTemperatureMaxLast5Weight = 0.03;

            lTemperatureMinLast1Weight = 0.45;
            lTemperatureMinLast2Weight = 0.30;
            lTemperatureMinLast3Weight = 0.15;
            lTemperatureMinLast4Weight = 0.07;
            lTemperatureMinLast5Weight = 0.03;

            lEvapotranspirationLast1Weight = 0.45;
            lEvapotranspirationLast2Weight = 0.30;
            lEvapotranspirationLast3Weight = 0.15;
            lEvapotranspirationLast4Weight = 0.07;
            lEvapotranspirationLast5Weight = 0.03;
            #endregion

            //Find last WeatherData
            lWeatherData = this.FindWeatherData(lLastDay);
            if (lWeatherData != null)
            {
                lSolarRadiation = lWeatherData.SolarRadiation;
                lWindSpeed = lWeatherData.WindSpeed;

                #region Calculate Estimate Measures
                //Last Day information
                lTemperatureMaxLast1 = lWeatherData.TemperatureMax;
                lTemperatureMinLast1 = lWeatherData.TemperatureMin;
                lEvapotranspirationLast1 = lWeatherData.Evapotranspiration;
                #region 1 Day Before LastDay
                lWeatherData = this.FindWeatherData(pLastDay.AddDays(-1));
                if (lWeatherData == null)
                {
                    lTemperatureMaxLast2 = lTemperatureMaxLast1;
                    lTemperatureMinLast2 = lTemperatureMinLast1;
                    lEvapotranspirationLast2 = lEvapotranspirationLast1;
                }
                else
                {
                    lTemperatureMaxLast2 = lWeatherData.TemperatureMax;
                    lTemperatureMinLast2 = lWeatherData.TemperatureMin;
                    lEvapotranspirationLast2 = lWeatherData.Evapotranspiration;
                }
                #endregion
                #region 2 Day Before LastDay
                lWeatherData = this.FindWeatherData(pLastDay.AddDays(-2));
                if (lWeatherData == null)
                {
                    lTemperatureMaxLast3 = lTemperatureMaxLast2;
                    lTemperatureMinLast3 = lTemperatureMinLast2;
                    lEvapotranspirationLast3 = lEvapotranspirationLast2;
                }
                else
                {
                    lTemperatureMaxLast3 = lWeatherData.TemperatureMax;
                    lTemperatureMinLast3 = lWeatherData.TemperatureMin;
                    lEvapotranspirationLast3 = lWeatherData.Evapotranspiration;
                }
                #endregion
                #region 3 Day Before LastDay
                lWeatherData = this.FindWeatherData(pLastDay.AddDays(-3));
                if (lWeatherData == null)
                {
                    lTemperatureMaxLast4 = lTemperatureMaxLast3;
                    lTemperatureMinLast4 = lTemperatureMinLast3;
                    lEvapotranspirationLast4 = lEvapotranspirationLast3;
                }
                else
                {
                    lTemperatureMaxLast4 = lWeatherData.TemperatureMax;
                    lTemperatureMinLast4 = lWeatherData.TemperatureMin;
                    lEvapotranspirationLast4 = lWeatherData.Evapotranspiration;
                }
                #endregion
                #region 4 Day Before LastDay
                lWeatherData = this.FindWeatherData(pLastDay.AddDays(-4));
                if (lWeatherData == null)
                {
                    lTemperatureMaxLast5 = lTemperatureMaxLast4;
                    lTemperatureMinLast5 = lTemperatureMinLast4;
                    lEvapotranspirationLast5 = lEvapotranspirationLast4;
                }
                else
                {
                    lTemperatureMaxLast5 = lWeatherData.TemperatureMax;
                    lTemperatureMinLast5 = lWeatherData.TemperatureMin;
                    lEvapotranspirationLast5 = lWeatherData.Evapotranspiration;
                }
                #endregion

                lTemperatureMax = Math.Round(
                    lTemperatureMaxLast5 * lTemperatureMaxLast5Weight
                    + lTemperatureMaxLast4 * lTemperatureMaxLast4Weight
                    + lTemperatureMaxLast3 * lTemperatureMaxLast3Weight
                    + lTemperatureMaxLast2 * lTemperatureMaxLast2Weight
                    + lTemperatureMaxLast1 * lTemperatureMaxLast1Weight, 2);

                lTemperatureMin = Math.Round(
                   lTemperatureMinLast5 * lTemperatureMinLast5Weight
                   + lTemperatureMinLast4 * lTemperatureMinLast4Weight
                   + lTemperatureMinLast3 * lTemperatureMinLast3Weight
                   + lTemperatureMinLast2 * lTemperatureMinLast2Weight
                   + lTemperatureMinLast1 * lTemperatureMinLast1Weight, 2);

                lEvapotranspiration = Math.Round(
                    lEvapotranspirationLast5 * lEvapotranspirationLast5Weight
                    + lEvapotranspirationLast4 * lEvapotranspirationLast4Weight
                    + lEvapotranspirationLast3 * lEvapotranspirationLast3Weight
                    + lEvapotranspirationLast2 * lEvapotranspirationLast2Weight
                    + lEvapotranspirationLast1 * lEvapotranspirationLast1Weight, 2);
                #endregion

                lTemperature = Utils.GetAverage(lTemperatureMax, lTemperatureMin);

                lWeatherData.Temperature = lTemperature;
                lWeatherData.TemperatureMax = lTemperatureMax;
                lWeatherData.TemperatureMin = lTemperatureMin;
                lWeatherData.Evapotranspiration = lEvapotranspiration;
                lWeatherData.SolarRadiation = lSolarRadiation;
                lWeatherData.WindSpeed = lWindSpeed;
            }

            lReturn = lWeatherData;
            return lReturn;
        }


        #endregion

        #region Public Methods

        /// <summary>
        /// New ID for WeatherDataList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewWeatherDataListId()
        {
            long lReturn = 1;
            if (this.WeatherDataList != null && this.WeatherDataList.Count > 0)
            {
                lReturn += this.WeatherDataList.Max(wd => wd.WeatherDataId);
            }
            return lReturn;
        }

        /// <summary>
        /// Find a WeatherData with the same Year, Month, Day and Hour as Parameter
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public WeatherData FindWeatherData(DateTime pDateHour)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;

            if (pDateHour != null)
            {
                lWeatherData = this.weatherDataList.FirstOrDefault(wd => wd.Date.Date == pDateHour.Date && wd.WeatherDataInputType == Utils.WeatherDataInputType.Meteoblue);

                if (lWeatherData != null)
                {
                    return lWeatherData;
                }

                //Depending on Station Type (WeatherLink or INIA)
                if (this.StationType == Utils.WeatherStationType.INIA)
                {
                    lWeatherData = this.weatherDataList.FirstOrDefault(wd => wd.Date.Date == pDateHour.Date && wd.WeatherDataInputType == Utils.WeatherDataInputType.IniaWeatherService);
                }
                else if(this.StationType == Utils.WeatherStationType.WeatherLink || this.StationType == Utils.WeatherStationType.NOWebInformation)
                {
                    lWeatherData = this.weatherDataList.FirstOrDefault(wd => wd.Date.Date == pDateHour.Date && wd.WeatherDataInputType == Utils.WeatherDataInputType.GetWeatherInfoService);
                }

                //if WeatherData is still null, we find Code, or WebInsert, or Prediction Data
                if (lWeatherData == null)
                {
                    lWeatherData = this.weatherDataList.FirstOrDefault(wd => wd.Date.Date == pDateHour.Date && wd.WeatherDataInputType == Utils.WeatherDataInputType.CodeInsert);
                }

                if (lWeatherData == null)
                {
                    lWeatherData = this.weatherDataList.FirstOrDefault(wd => wd.Date.Date == pDateHour.Date && wd.WeatherDataInputType == Utils.WeatherDataInputType.WebInsert);
                }

                if (lWeatherData == null)
                {
                    lWeatherData = this.weatherDataList.FirstOrDefault(wd => wd.Date.Date == pDateHour.Date && wd.WeatherDataInputType == Utils.WeatherDataInputType.Prediction);
                }

            }

            lReturn = lWeatherData;
            return lReturn;
        }

        /// <summary>
        /// If WeatherData exist in list, return the WeatherData,
        /// else return null.
        /// </summary>
        /// <param name="pWeatherData"></param>
        /// <returns></returns>
        public WeatherData ExistWeatherData(WeatherData pWeatherData)
        {
            WeatherData lReturn = null;

            if(pWeatherData != null)
            {
                foreach (WeatherData lWeatherDataitem in this.WeatherDataList)
                {
                    if(lWeatherDataitem.Equals(pWeatherData))
                    {
                        lReturn = lWeatherDataitem;
                        break;
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Add a new WeatherData and return it,
        /// if exists returns null.
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <returns></returns>
        public WeatherData AddWeatherData(DateTime pDateTime,
                                        Double pTemperature, Double pTemperatureMax, Double pTemperatureMin,
                                        Double pSolarRadiation, Double pEvapotranspiration, Double pWindSpeed,
                                        String pObservations, Utils.WeatherDataInputType pWeatherDataInputType)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;
            Utils.WeatherDataType lWeatherDataType;
            
            long lWeatherDataId = 0;

            try
            {
                lWeatherDataId = this.GetNewWeatherDataListId();
                lWeatherDataType = this.WeatherDataType;
                
                lWeatherData = new WeatherData(lWeatherDataId, this.WeatherStationId, pDateTime, 
                                            pTemperature, pTemperatureMax, pTemperatureMin, 
                                            pSolarRadiation, pEvapotranspiration, pWindSpeed, 
                                            pObservations, lWeatherDataType, pWeatherDataInputType);

                lWeatherDataType = SetWeatherDataTypeByWeatherInformation(lWeatherData);
                
                if(this.ExistWeatherData(lWeatherData) == null)
                {
                    this.WeatherDataList.Add(lWeatherData);
                }
                else
                {
                    //If Exists return null
                    lWeatherData = null;
                }
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherStation.AddWeatherData " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }

            lReturn = lWeatherData;
            return lReturn;
        }


        /// <summary>
        /// Update an existing WeatherData,
        /// if not exists, return null.
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <returns></returns>
        public WeatherData UpdateWeatherData(DateTime pDateTime,
                                        Double pTemperature, Double pTemperatureMax, Double pTemperatureMin,
                                        Double pSolarRadiation, Double pEvapotranspiration, Double pWindSpeed,
                                        String pObservations, Utils.WeatherDataInputType pWeatherDataInputType)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;
            Utils.WeatherDataType lWeatherDataType;

            try
            {
                lWeatherDataType = this.WeatherDataType;
                lWeatherData = new WeatherData(this.GetNewWeatherDataListId(), this.WeatherStationId, 
                                                pDateTime, pTemperature, pTemperatureMax, pTemperatureMin, 
                                                pSolarRadiation, pEvapotranspiration, pWindSpeed, 
                                                pObservations, lWeatherDataType, pWeatherDataInputType);

                lReturn = ExistWeatherData(lWeatherData);
                //if input type is from Predictin or Web Insert, can be modified.
                if(lReturn != null && (pWeatherDataInputType == lReturn.WeatherDataInputType
                    || lReturn.WeatherDataInputType == Utils.WeatherDataInputType.Prediction
                    || lReturn.WeatherDataInputType == Utils.WeatherDataInputType.WebInsert))
                {
                    lReturn.WeatherStationId = this.WeatherStationId;
                    lReturn.Date = pDateTime;
                    lReturn.Temperature = pTemperature;
                    lReturn.SolarRadiation = pSolarRadiation;
                    lReturn.TemperatureMax = pTemperatureMax;
                    lReturn.TemperatureMin = pTemperatureMin;
                    lReturn.Evapotranspiration = pEvapotranspiration;
                    lReturn.WindSpeed = pWindSpeed;
                    lReturn.Observations = pObservations;
                    lReturn.WeatherDataInputType = pWeatherDataInputType;
                    lWeatherDataType = SetWeatherDataTypeByWeatherInformation(lReturn);
                }
                if (lReturn != null && (lReturn.WeatherDataInputType == Utils.WeatherDataInputType.GetWeatherInfoService
                                     || lReturn.WeatherDataInputType == Utils.WeatherDataInputType.IniaWeatherService))
                {
                    //Do not update data, is real data from weather pages
                    lWeatherDataType = SetWeatherDataTypeByWeatherInformation(lReturn);
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherStation.UpdateWeatherData " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        /// <summary>
        /// Add WeatherData to WeatherDataList
        /// If Exist the record it will update it.
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        public void AddWeatherDataToList(DateTime pDateTime, Double pTemperature, Double pSolarRadiation, Double pTemMax,
                                        Double pTemMin, Double pEvapotranspiration, Double pWindSpeed,
                                        String pObservations, Utils.WeatherDataInputType pWeatherDataInputType)
        {

            try
            {
                WeatherData lWeatherData;

                lWeatherData = this.AddWeatherData(pDateTime, pTemperature, pTemMax, pTemMin, 
                                                    pSolarRadiation, pEvapotranspiration, pWindSpeed,
                                                    pObservations, pWeatherDataInputType);

                if (lWeatherData == null)
                {
                    this.UpdateWeatherData(pDateTime, pTemperature, pTemMax, pTemMin, 
                                            pSolarRadiation, pEvapotranspiration, pWindSpeed,
                                            pObservations, pWeatherDataInputType);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherStation.AddWeatherDataToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }

        }

        /// <summary>
        /// Generate Prediction of Weather Data after the last day
        /// </summary>
        public void GeneratePredictionWeatherData()
        {
            DateTime lLastDay;
            DateTime lNextDay;
            WeatherData lWeatherData;

            Double lTemperature;
            Double lSolarRadiation;
            Double lTemperatureMax;
            Double lTemperatureMin;
            Double lEvapotranspiration;
            Double lWindSpeed;

            //Last data record
            lLastDay = this.WeatherDataList[this.WeatherDataList.Count - 1].Date;
            

            for (int i = 0; i < InitialTables.DAYS_FOR_WEATHER_PREDICTION; i++)
            {
                lWeatherData = this.CalculateEstimateWeatherData(lLastDay);
                lNextDay = lLastDay.AddDays(1);
                lTemperature = lWeatherData.Temperature;
                lSolarRadiation = lWeatherData.SolarRadiation;
                lTemperatureMax = lWeatherData.TemperatureMax;
                lTemperatureMin = lWeatherData.TemperatureMin;
                lEvapotranspiration = lWeatherData.Evapotranspiration;
                lWindSpeed = lWeatherData.WindSpeed;
                

                //Add WeatherData to WeatherStation WeatherDataList
                this.AddWeatherDataToList(lNextDay, lTemperature, lSolarRadiation, lTemperatureMax, lTemperatureMin,
                                        lEvapotranspiration, lWindSpeed, "PREDICTION DAY " + (i + 1), Utils.WeatherDataInputType.Prediction);
                lLastDay = lLastDay.AddDays(1);

            }
        }

        /// <summary>
        /// Generate Prediction of Weather Data after the last day
        /// </summary>
        public void GeneratePredictionWeatherData(DateTime pDateOfReference)
        {
            #region local variables
            DateTime lLastDay;
            DateTime lNextDay;
            DateTime lLastPredictionDay;
            WeatherData lWeatherData;
            int lTotalPredictionDays;

            Double lTemperature;
            Double lSolarRadiation;
            Double lTemperatureMax;
            Double lTemperatureMin;
            Double lEvapotranspiration;
            Double lWindSpeed;
            #endregion

            //Last record order by Date
            lLastDay = this.WeatherDataList
                                .Where(wd => wd.WeatherDataInputType != Utils.WeatherDataInputType.Prediction)
                                .OrderByDescending(wd => wd.Date).FirstOrDefault().Date;
            lLastPredictionDay = lLastDay.AddDays(InitialTables.DAYS_FOR_WEATHER_PREDICTION);
            if (pDateOfReference != null && this.FindWeatherData(pDateOfReference) != null)
            {
                lLastDay = Utils.MinDateTimeBetween(pDateOfReference, lLastDay);
                //if Last Day changes, Last Prediction Day also can change.
                lLastPredictionDay = Utils.MaxDateTimeBetween(pDateOfReference, lLastDay.AddDays(InitialTables.DAYS_FOR_WEATHER_PREDICTION));
            }
            else if(pDateOfReference != null)
            {
                lLastPredictionDay = Utils.MaxDateTimeBetween(pDateOfReference, lLastDay.AddDays(InitialTables.DAYS_FOR_WEATHER_PREDICTION));
            }

            lTotalPredictionDays = (lLastPredictionDay - lLastDay).Days;
            for (int i = 0; i < lTotalPredictionDays; i++)
            {
                //Create a New WeatherData from Last Day with weather data we know we have.
                lWeatherData = this.CalculateEstimateWeatherData(lLastDay);
                lNextDay = lLastDay.AddDays(1);
                lTemperature = lWeatherData.Temperature;
                lSolarRadiation = lWeatherData.SolarRadiation;
                lTemperatureMax = lWeatherData.TemperatureMax;
                lTemperatureMin = lWeatherData.TemperatureMin;
                lEvapotranspiration = lWeatherData.Evapotranspiration;
                lWindSpeed = lWeatherData.WindSpeed;

                //Add WeatherData to WeatherStation WeatherDataList
                this.AddWeatherDataToList(lNextDay, lTemperature, lSolarRadiation, lTemperatureMax, lTemperatureMin,
                                        lEvapotranspiration, lWindSpeed, "PREDICTION DAY " + (i + 1), Utils.WeatherDataInputType.Prediction);
                lLastDay = lLastDay.AddDays(1);

            }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Overrides equals:
        /// name, Location, Model
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return lReturn;
            }
            WeatherStation lWeatherStation = obj as WeatherStation;
            lReturn = this.Name.Equals(lWeatherStation.Name)
                    && this.PositionId.Equals(lWeatherStation.PositionId)
                    && this.StationType.Equals(lWeatherStation.StationType);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}