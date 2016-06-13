using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Weather
{
    /// <summary>
    /// Create: 2015-11-10
    /// Author: rodouy
    /// Description: 
    ///     Data of Temperatures
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
    ///     - Name          String
    ///     
    /// 
    /// Methods:
    ///     - TemperatureData()      -- constructor
    ///     - TemperatureData(id, name, date, regionid, min, max, average, etc, rain)
    /// </summary>
    public class TemperatureData
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///    + temperatureDataId: long
        ///    + name: String
        ///    + date: DateTime
        ///    + regionId: long
        ///    + minTemperature: Double
        ///    + maxTemperature: Double 
        ///    + average: Double
        ///    + etc: Double
        ///    + rain: Double
        /// </summary>
        private long temperatureDataId;
        private String name;
        private DateTime date;
        private long regionId;
        private Double min;
        private Double max;
        private Double average;
        private Double etc;
        private Double rain;

        #endregion

        #region Properties

        public long TemperatureDataId
        {
            get { return temperatureDataId; }
            set { temperatureDataId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public long RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public virtual Region Region
        {
            get;
            set;
        }

        public Double Min
        {
            get { return min; }
            set { 
                min = value;
                average = min + max / 2;
            }
        }

        public Double Max
        {
            get { return max; }
            set { 
                max = value;
                average = min + max / 2;
            }
        }

        public Double Average
        {
            get { return average; }
            set { average = value; }
        }

        public Double ETC
        {
            get { return etc; }
            set { etc = value; }
        }

        public Double Rain
        {
            get { return rain; }
            set { rain = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public TemperatureData()
        {
            this.Name = "noname";
            this.Date = Utils.MIN_DATETIME;
            this.RegionId = 0;
            this.Min = 0;
            this.Max = 0;
            this.Average = 0;
            this.ETC = 0;
            this.Rain = 0;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pTemperatureDataId"></param>
        /// <param name="pName"></param>
        /// <param name="pDate"></param>
        /// <param name="pRegionId"></param>
        /// <param name="pMin"></param>
        /// <param name="pMax"></param>
        /// <param name="pETC"></param>
        /// <param name="pRain"></param>
        public TemperatureData(String pName, DateTime pDate, 
                                long pRegionId,
                                Double pMin, Double pMax,
                                Double pETC, Double pRain)
        {
            this.Name = pName;
            this.Date = pDate;
            this.RegionId = pRegionId;
            this.Min = pMin;
            this.Max = pMax;
            this.Average = pMin + pMax / 2;
            this.ETC = pETC;
            this.Rain = pRain;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Updates All the data
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDate"></param>
        /// <param name="pRegionId"></param>
        /// <param name="pMin"></param>
        /// <param name="pMax"></param>
        /// <param name="pETC"></param>
        /// <param name="pRain"></param>
        /// <returns></returns>
        public TemperatureData UpdateTemperatureData (String pName, DateTime pDate, 
                                                    long pRegionId,
                                                    Double pMin, Double pMax,
                                                    Double pETC, Double pRain)
        {
            this.Name = pName;
            this.Date = pDate;
            this.RegionId = pRegionId;
            this.Min = pMin;
            this.Max = pMax;
            this.Average = pMin + pMax / 2;
            this.ETC = pETC;
            this.Rain = pRain;
            return this;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Overrides equals:
        /// Name
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
            TemperatureData lTemperatureData = obj as TemperatureData;
            lReturn = this.Name.Equals(lTemperatureData.Name);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}