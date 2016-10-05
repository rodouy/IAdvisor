using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using NLog;

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

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Model
        {
            get { return model; }
            set { model = value; }
        }

        public Utils.WeatherStationType StationType
        {
            get { return stationType; }
            set { stationType = value; }
        }
        
        public DateTime DateOfInstallation
        {
            get { return dateOfInstallation; }
            set { dateOfInstallation = value; }
        }

        public DateTime DateOfService
        {
            get { return dateOfService; }
            set { dateOfService = value; }
        }
        
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }

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

        public Utils.WeatherDataType WeatherDataType
        {
            get { return weatherDataType; }
            set { weatherDataType = value; }
        }

        public String WebAddress
        {
            get { return webAddress; }
            set { webAddress = value; }
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

            if(pDateHour != null)
            {
                foreach (WeatherData lWeatherDataItem in this.WeatherDataList)
                {
                    if(Utils.IsTheSameDayAndHour(pDateHour, lWeatherDataItem.Date))
                    {
                        lWeatherData = lWeatherDataItem;
                        break;
                    }
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
                                        Double pTemperature, Double pSolarRadiation,
                                        Double pTemperatureMax, Double pTemperatureMin, 
                                        Double pEvapotranspiration)
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
                                            pSolarRadiation, pEvapotranspiration, lWeatherDataType);

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
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in WeatherStation.AddWeatherData " + ex.Message);
                throw ;
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
                                        Double pTemperature, Double pSolarRadiation,
                                        Double pTemperatureMax, Double pTemperatureMin, 
                                        Double pEvapotranspiration)
        {
            WeatherData lReturn;
            WeatherData lWeatherData = null;
            Utils.WeatherDataType lWeatherDataType;

            try
            {
                lWeatherDataType = this.WeatherDataType;
                lWeatherData = new WeatherData(this.GetNewWeatherDataListId(), this.WeatherStationId, 
                                                pDateTime, pTemperature,
                                                pTemperatureMax, pTemperatureMin, pSolarRadiation,
                                                pEvapotranspiration, lWeatherDataType);

                lReturn = ExistWeatherData(lWeatherData);
                if(lReturn != null)
                {
                    lReturn.WeatherStationId = this.WeatherStationId;
                    lReturn.Date = pDateTime;
                    lReturn.Temperature = pTemperature;
                    lReturn.SolarRadiation = pSolarRadiation;
                    lReturn.TemperatureMax = pTemperatureMax;
                    lReturn.TemperatureMin = pTemperatureMin;
                    lReturn.Evapotranspiration = pEvapotranspiration;
                    lWeatherDataType = SetWeatherDataTypeByWeatherInformation(lReturn);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in WeatherStation.UpdateWeatherData " + ex.Message);
                throw ;
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
        public void AddWeatherDataToList(DateTime pDateTime,
                                        Double pTemperature, Double pSolarRadiation, Double pTemMax,
                                        Double pTemMin, Double pEvapotranspiration)
        {

            try
            {
                WeatherData lWeatherData;

                lWeatherData = this.AddWeatherData(pDateTime, pTemperature, pSolarRadiation, 
                                                    pTemMax, pTemMin, pEvapotranspiration);

                if (lWeatherData == null)
                {
                    this.UpdateWeatherData(pDateTime, pTemperature, pSolarRadiation,
                                            pTemMax, pTemMin, pEvapotranspiration);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in WeatherStation.AddWeatherDataToList " + ex.Message);
                throw ;
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

            double lTemperature;
            double lSolarRadiation;
            double lTemperatureMax;
            double lTemperatureMin;
            double lEvapotranspiration;
            double lEvapotranspirationLast3;
            double lEvapotranspirationLast3Weight;
            double lEvapotranspirationLast2;
            double lEvapotranspirationLast2Weight;
            double lEvapotranspirationLast1;
            double lEvapotranspirationLast1Weight;

            //Last data record
            lLastDay = this.WeatherDataList[this.WeatherDataList.Count - 1].Date;
            lEvapotranspirationLast3Weight = 0.2;
            lEvapotranspirationLast2Weight = 0.3;
            lEvapotranspirationLast1Weight = 0.5;

            for (int i = 0; i < InitialTables.DAYS_FOR_PREDICTION; i++)
            {
                lWeatherData = this.FindWeatherData(lLastDay);
                lNextDay = lLastDay.AddDays(1);
                lTemperature = lWeatherData.Temperature;
                lSolarRadiation = lWeatherData.SolarRadiation;
                lTemperatureMax = lWeatherData.TemperatureMax;
                lTemperatureMin = lWeatherData.TemperatureMin;

                lEvapotranspirationLast1 = lWeatherData.Evapotranspiration;
                lWeatherData = this.FindWeatherData(lLastDay.AddDays(-1));
                lEvapotranspirationLast2 = lWeatherData.Evapotranspiration;
                lWeatherData = this.FindWeatherData(lLastDay.AddDays(-2));
                lEvapotranspirationLast3 = lWeatherData.Evapotranspiration;

                lEvapotranspiration = Math.Round(
                    lEvapotranspirationLast3 * lEvapotranspirationLast3Weight
                    + lEvapotranspirationLast2 * lEvapotranspirationLast2Weight
                    + lEvapotranspirationLast1 * lEvapotranspirationLast1Weight, 2);

                //Add WeatherData to WeatherStation WeatherDataList
                this.AddWeatherDataToList(lNextDay,
                                        lTemperature, lSolarRadiation,
                                        lTemperatureMax, lTemperatureMin,
                                        lEvapotranspiration);
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
                    && this.Model.Equals(lWeatherStation.Model);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}