using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Utilities;
using NLog;
using System.ComponentModel.DataAnnotations;

namespace IrrigationAdvisor.Models.Weather
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: rodouy
    /// Description: 
    ///     Data of the weather station
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - Datetime          date
    ///     - Double            temperature
    ///     - Double            temperatureMax
    ///     - Double            temperatureMin
    ///     - Double            temperatureDewPoint
    ///     - Double            humidity
    ///     - Double            humidityMax
    ///     - Double            humidityMin
    ///     - Double            barometer
    ///     - Double            barometerMax
    ///     - Double            barometerMin
    ///     - Double            solarRadiation
    ///     - Double            UVRadiation
    ///     - Double            RainDay
    ///     - Double            RainStorm
    ///     - Double            RainMonth
    ///     - Double            RainYear
    ///     - Double            evapotranspiration
    ///     - Double            evapotranspirationMonth
    ///     - Double            evapotranspirationYear
    /// 
    /// Methods:
    ///     - WeatherData()      -- constructor
    ///     - WeatherData(Datetime, 
    ///         TemperatureMax Double, TemperatureMin Double, 
    ///         Evapotranspiration Double)  -- consturctor with parameters
    ///     - GetAverageTemperature(Datetime pDate) Double
    ///     - GetEvapotranspiration(Datetime pDate) Double
    /// 
    /// </summary>
    //[Serializable()]
    public class WeatherData //: System.ComponentModel.INotifyPropertyChanged
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - long              weatherDataId
        ///     - long              weatherStationId
        ///     - Datetime          date
        ///     - Double            temperature
        ///     - Double            temperatureMax
        ///     - Double            temperatureMin
        ///     - Double            temperatureDewPoint
        ///     - Double            humidity
        ///     - Double            humidityMax
        ///     - Double            humidityMin
        ///     - Double            barometer
        ///     - Double            barometerMax
        ///     - Double            barometerMin
        ///     - Double            solarRadiation
        ///     - Double            UVRadiation
        ///     - Double            RainDay
        ///     - Double            RainStorm
        ///     - Double            RainMonth
        ///     - Double            RainYear
        ///     - Double            evapotranspiration
        ///     - Double            evapotranspirationMonth
        ///     - Double            evapotranspirationYear
        /// </summary>

        private long weatherDataId;
        private long weatherStationId;
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        private DateTime date;
        private Double temperature;
        private Double temperatureMax;
        private Double temperatureMin;
        private Double temperatureDewPoint;
        private Double humidity;
        private Double humidityMax;
        private Double humidityMin;
        private Double barometer;
        private Double barometerMax;
        private Double barometerMin;
        private Double solarRadiation;
        private Double uvRadiation;
        private Double rainDay;
        private Double rainStorm;
        private Double rainMonth;
        private Double rainYear;
        private Double evapotranspiration;
        private Double evapotranspirationMonth;
        private Double evapotranspirationYear;
        private Double windSpeed;
        private String observations;
        private Utils.WeatherDataType weatherDataType;
        private Utils.WeatherDataInputType weatherDataInputType;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties


        public long WeatherDataId
        {
            get { return weatherDataId; }
            set { weatherDataId = value; }
        }

        public long WeatherStationId
        {
            get { return weatherStationId; }
            set { weatherStationId = value; }
        }

        public virtual WeatherStation WeatherStation
        {
            get;
            set;
        }
        
        public DateTime Date
        {
            get { return date; }
            set 
            { 
                date = value;
            }
        }

        public Double Temperature
        {
            get { return temperature; }
            set 
            { 
                temperature = value;
            }
        }

        public Double TemperatureMax
        {
            get { return temperatureMax; }
            set 
            { 
                temperatureMax = value;
            }
        }

        public Double TemperatureMin
        {
            get { return temperatureMin; }
            set 
            { 
                temperatureMin = value;
            }
        }

        public Double TemperatureDewPoint
        {
            get { return temperatureDewPoint; }
            set 
            { 
                temperatureDewPoint = value;
            }
        }

        public Double Humidity
        {
            get { return humidity; }
            set { humidity = value; }
        }

        public Double HumidityMax
        {
            get { return humidityMax; }
            set { humidityMax = value; }
        }

        public Double HumidityMin
        {
            get { return humidityMin; }
            set { humidityMin = value; }
        }

        public Double Barometer
        {
            get { return barometer; }
            set { barometer = value; }
        }

        public Double BarometerMax
        {
            get { return barometerMax; }
            set { barometerMax = value; }
        }

        public Double BarometerMin
        {
            get { return barometerMin; }
            set { barometerMin = value; }
        }

        public Double SolarRadiation
        {
            get { return solarRadiation; }
            set { solarRadiation = value; }
        }

        public Double UVRadiation
        {
            get { return uvRadiation; }
            set { uvRadiation = value; }
        }

        public Double RainDay
        {
            get { return rainDay; }
            set { rainDay = value; }
        }

        public Double RainStorm
        {
            get { return rainStorm; }
            set { rainStorm = value; }
        }

        public Double RainMonth
        {
            get { return rainMonth; }
            set { rainMonth = value; }
        }

        public Double RainYear
        {
            get { return rainYear; }
            set { rainYear = value; }
        }

        public Double Evapotranspiration
        {
            get { return evapotranspiration; }
            set { evapotranspiration = value; }
        }

        public Double EvapotranspirationMonth
        {
            get { return evapotranspirationMonth; }
            set { evapotranspirationMonth = value; }
        }

        public Double EvapotranspirationYear
        {
            get { return evapotranspirationYear; }
            set { evapotranspirationYear = value; }
        }

        public Double WindSpeed
        {
            get { return windSpeed; }
            set { windSpeed = value; }
        }
        
        public string Observations
        {
            get { return observations; }
            set { observations = value; }
        }

        public Utils.WeatherDataType WeatherDataType
        {
            get { return weatherDataType; }
            set { weatherDataType = value; }
        }

        public Utils.WeatherDataInputType WeatherDataInputType
        {
            get { return weatherDataInputType; }
            set { weatherDataInputType = value; }
        }


        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public WeatherData()
        {
            this.WeatherDataId = 0;
            this.WeatherStationId = 0;
            this.Date = DateTime.Now;
            this.Temperature = 0;
            this.TemperatureMax = 0;
            this.TemperatureMin = 0;
            this.TemperatureDewPoint = 0;
            this.Humidity = 0;
            this.HumidityMax = 0;
            this.HumidityMin = 0;
            this.Barometer = 0;
            this.BarometerMax = 0;
            this.BarometerMin = 0;
            this.SolarRadiation = 0;
            this.UVRadiation = 0;
            this.RainDay = 0;
            this.RainStorm = 0;
            this.RainMonth = 0;
            this.RainYear = 0;
            this.Evapotranspiration = 0;
            this.EvapotranspirationMonth = 0;
            this.EvapotranspirationYear = 0;
            this.WindSpeed = 0;
            this.Observations = "";
            this.WeatherDataType = Utils.WeatherDataType.AllData;
            this.WeatherDataInputType = Utils.WeatherDataInputType.CodeInsert;
        }

        /// <summary>
        /// Constructor wiht the minimum parameters
        /// </summary>
        /// <param name="pWeatherDataId"></param>
        /// <param name="pWeatherStationId"></param>
        /// <param name="pDate"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pTemperatureMax"></param>
        /// <param name="pTemperatureMin"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <param name="pWindSpeed"></param>
        /// <param name="pObservations"></param>
        /// <param name="pWeatherDataType"></param>
        /// <param name="pWeatherDataInputType"></param>
        public WeatherData (long pWeatherDataId, long pWeatherStationId, DateTime pDate,
                            Double pTemperature, Double pTemperatureMax, Double pTemperatureMin,
                            Double pSolarRadiation, Double pEvapotranspiration, Double pWindSpeed,
                            String pObservations, Utils.WeatherDataType pWeatherDataType,
                            Utils.WeatherDataInputType pWeatherDataInputType)
        {
            this.WeatherDataId = pWeatherDataId;
            this.WeatherStationId = pWeatherStationId;
            this.Date = pDate;
            this.Temperature = pTemperature;
            this.TemperatureMax = pTemperatureMax;
            this.TemperatureMin = pTemperatureMin;
            this.TemperatureDewPoint = 0;
            this.Humidity = 0;
            this.HumidityMax = 0;
            this.HumidityMin = 0;
            this.Barometer = 0;
            this.BarometerMax = 0;
            this.BarometerMin = 0;
            this.SolarRadiation = pSolarRadiation;
            this.UVRadiation = 0;
            this.RainDay = 0;
            this.RainStorm = 0;
            this.RainMonth = 0;
            this.RainYear = 0;
            this.Evapotranspiration = pEvapotranspiration;
            this.EvapotranspirationMonth = 0;
            this.EvapotranspirationYear = 0;
            this.WindSpeed = pWindSpeed;
            this.Observations = pObservations;
            this.WeatherDataType = pWeatherDataType;
            this.WeatherDataInputType = pWeatherDataInputType;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pWeatherDataId"></param>
        /// <param name="pWeatherStationId"></param>
        /// <param name="pDate"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pTemperatureMax"></param>
        /// <param name="pTemperatureMin"></param>
        /// <param name="pTemperatureDewPoint"></param>
        /// <param name="pHumidity"></param>
        /// <param name="pHumidityMax"></param>
        /// <param name="pHumidityMin"></param>
        /// <param name="pBarometer"></param>
        /// <param name="pBarometerMax"></param>
        /// <param name="pBarometerMin"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pUVRadiation"></param>
        /// <param name="pRainDay"></param>
        /// <param name="pRainStorm"></param>
        /// <param name="pRainMonth"></param>
        /// <param name="pRainYear"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <param name="pEvapotranspirationMonth"></param>
        /// <param name="pEvapotranspirationYear"></param>
        /// <param name="pObservations"></param>
        /// <param name="pWeatherDataType"></param>
        /// <param name="pWeatherDataInputType"></param>
        public WeatherData (long pWeatherDataId, long pWeatherStationId, DateTime pDate,
                            Double pTemperature, Double pTemperatureMax, Double pTemperatureMin, Double pTemperatureDewPoint,
                            Double pHumidity, Double pHumidityMax, Double pHumidityMin, Double pBarometer, Double pBarometerMax, Double pBarometerMin,
                            Double pSolarRadiation, Double pUVRadiation, Double pRainDay, Double pRainStorm, Double pRainMonth, Double pRainYear,
                            Double pEvapotranspiration, Double pEvapotranspirationMonth, Double pEvapotranspirationYear, Double pWindSpeed,
                            String pObservations, Utils.WeatherDataType pWeatherDataType, Utils.WeatherDataInputType pWeatherDataInputType)
        {
            this.WeatherDataId = pWeatherDataId;
            this.WeatherStationId = pWeatherStationId;
            this.Date = pDate;
            this.Temperature = pTemperature;
            this.TemperatureMax = pTemperatureMax;
            this.TemperatureMin = pTemperatureMin;
            this.TemperatureDewPoint = pTemperatureDewPoint;
            this.Humidity = pHumidity;
            this.HumidityMax = pHumidityMax;
            this.HumidityMin = pHumidityMin;
            this.Barometer = pBarometer;
            this.BarometerMax = pBarometerMax;
            this.BarometerMin = pBarometerMin;
            this.SolarRadiation = pSolarRadiation;
            this.UVRadiation = pUVRadiation;
            this.RainDay = pRainDay;
            this.RainStorm = pRainStorm;
            this.RainMonth = pRainMonth;
            this.RainYear = pRainYear;
            this.Evapotranspiration = pEvapotranspiration;
            this.EvapotranspirationMonth = pEvapotranspirationMonth;
            this.EvapotranspirationYear = pEvapotranspirationYear;
            this.WindSpeed = pWindSpeed;
            this.Observations = pObservations;
            this.WeatherDataType = pWeatherDataType;
            this.WeatherDataInputType = pWeatherDataInputType;
        }

        #endregion

        #region Private Helpers

        #endregion

        #region Public Methods

        /// <summary>
        /// Get the Average Temperature between Max and Min Temperature
        /// </summary>
        /// <returns></returns>
        public Double GetAverageTemperature(Double pMaxTemperatureLimit, Double pMinTemperatureLimit)
        {
            Double lAverageTemperature = 0;
            Double lTemperatureMax = Utils.GetMin(pMaxTemperatureLimit, this.TemperatureMax);
            Double lTemperatureMin = Utils.GetMax(pMinTemperatureLimit, this.TemperatureMin);
            try
            {
                lAverageTemperature = Utils.GetAverage(lTemperatureMax, lTemperatureMin);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherData.GetAverageTemperature " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lAverageTemperature;
        }

        /// <summary>
        /// Get the Average Temperature between Max and Min Temperature
        /// </summary>
        /// <returns></returns>
        public Double GetAverageTemperature()
        {
            Double lAverageTemperature = 0;
            try
            {
                lAverageTemperature = Utils.GetAverage(this.TemperatureMax, this.TemperatureMin);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherData.GetAverageTemperature " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lAverageTemperature;
        }

        /// <summary>
        /// Get the Average Humidity between Max and Min Humidity
        /// </summary>
        /// <returns></returns>
        public Double GetAverageHumidity()
        {
            Double lAverageHumidity = 0;
            try
            {
                lAverageHumidity = Utils.GetAverage(this.HumidityMax, this.HumidityMin);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherData.GetAverageHumidity " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lAverageHumidity;
        }

        /// <summary>
        /// Get the Average Pressure between Max and Min Pressure mesure
        /// </summary>
        /// <returns></returns>
        public Double GetAverageBarometer()
        {
            Double lAverageBarometer = 0;
            try
            {                
                lAverageBarometer = Utils.GetAverage(this.BarometerMax, this.BarometerMin);
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherData.GetAverageBarometer " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lAverageBarometer;
        }

        /// <summary>
        /// Get Evapotranspiration
        /// </summary>
        /// <returns></returns>
        public Double GetEvapotranspiration()
        {
            Double lEvapotranspiration = 0;
            try
            {
                if (this.Evapotranspiration != 0)
                {
                    lEvapotranspiration = this.Evapotranspiration;
                }
                // TODO: lEvapotranspiration = do calculous for evapotranspiration;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in WeatherData.GetEvapotranspiration " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lEvapotranspiration;
        }

        #endregion

        #region Overrides

        public override string ToString()
        {
            string lReturn = 
                "Date " +
                this.Date.ToString() + ";" +
                "Temperatures (now, max, min) " +
                this.Temperature.ToString() + ";" +
                this.TemperatureMax.ToString() + ";" +
                this.TemperatureMin.ToString() + ";" +
                "Humidity (now, max, min) " +
                this.Humidity.ToString() + ";" +
                this.HumidityMax.ToString() + ";" +
                this.HumidityMin.ToString() + ";" +
                "Barometer (now, max, min) " +
                this.Barometer.ToString() + ";" +
                this.BarometerMax.ToString() + ";" +
                this.BarometerMin.ToString() + ";" +
                "Solar Radiation " +
                this.SolarRadiation.ToString() + ";" +
                "UVRadiation " +
                this.UVRadiation.ToString() + ";" +
                "Rain (day, storm, month, year) " +
                this.RainDay.ToString() + ";" +
                this.RainStorm.ToString() + ";" +
                this.RainMonth.ToString() + ";" +
                this.RainYear.ToString() + ";" +
                "Evapotranspiration (now, month, year) " +
                this.Evapotranspiration.ToString() + ";" +
                this.EvapotranspirationMonth.ToString() + ";" +
                this.EvapotranspirationYear.ToString() + ";";
            return lReturn;
        }

        /// <summary>
        /// Overrides equals:
        /// Year, Month, Day and Hour
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;

            WeatherData lWeatherData = obj as WeatherData;
            if (lWeatherData == null)
            {
                return lReturn;
            }
            lReturn = lWeatherData.WeatherStationId == this.WeatherStationId
                && Utils.IsTheSameDay(lWeatherData.Date, this.Date);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Date.GetHashCode();
        }

        #endregion

    }
}