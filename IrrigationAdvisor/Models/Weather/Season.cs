using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NLog;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.Models.Weather
{
    /// <summary>
    /// Create: 2016-11-04
    /// Author: rodouy
    /// Description: 
    ///     Season of the year
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
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - Season()      -- constructor
    ///     - Season(name, year, weatherSeason, fromDate, toDate)  -- consturctor with parameters
    /// 
    /// </summary>
    public class Season
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        ///  Fields of Class:
        ///     - seasonId long
        ///     - name String
        ///     - year int
        ///     - weatherSeason WeatherSeason
        ///     - fromDate DateTime
        ///     - toDate Datetime
        /// </summary>
        private long seasonId;
        private String name;
        private int year;
        private Utils.WeatherSeason weatherSeason;
        private long regionId;
        private DateTime fromDate;
        private DateTime toDate;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        public long SeasonId
        {
            get { return seasonId; }
            set { seasonId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public Utils.WeatherSeason WeatherSeason
        {
            get { return weatherSeason; }
            set { weatherSeason = value; }
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
        
        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Season
        /// </summary>
        public Season()
        {
            this.Name = "No Name";
            this.Year = Utils.MIN_DATETIME.Year;
            this.WeatherSeason = Utils.WeatherSeason.Spring;
            this.RegionId = 0;
            this.FromDate = Utils.MIN_DATETIME;
            this.ToDate = Utils.MIN_DATETIME.AddDays(90);
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pSeasonId"></param>
        /// <param name="pName"></param>
        /// <param name="pYear"></param>
        /// <param name="pWeatherSeason"></param>
        /// <param name="pRegion"></param>
        /// <param name="pFromDate"></param>
        /// <param name="pToDate"></param>
        public Season(long pSeasonId, String pName, int pYear,
                        Utils.WeatherSeason pWeatherSeason, 
                        Region pRegion,
                        DateTime pFromDate, DateTime pToDate)
        {
            this.SeasonId = pSeasonId;
            this.Name = pName;
            this.Year = pYear;
            this.WeatherSeason = pWeatherSeason;
            this.RegionId = pRegion.RegionId;
            this.Region = pRegion;
            this.FromDate = pFromDate;
            this.ToDate = pToDate;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// From a date of the year, return the season of the year
        /// By Default it will return Spring
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public Utils.WeatherSeason DefaultWeatherSeasonBy(DateTime pDate)
        {
            Utils.WeatherSeason lReturn;
            DateTime lDateOne;
            DateTime lDateTwo;

            //Default Value
            lReturn = Utils.WeatherSeason.Spring;

            if (pDate != null)
            {
                //Utils.Season.Spring
                //From 21-Sep to 20-Dec
                lDateOne = new DateTime(pDate.Year, 9, 21);
                lDateTwo = new DateTime(pDate.Year, 12, 20);
                if(lDateOne <= pDate.Date &&  lDateTwo >= pDate.Date)
                {
                    lReturn = Utils.WeatherSeason.Spring;
                }
                //Utils.Season.Summer
                //From 21-Dec to 20-Mar
                lDateOne = new DateTime(pDate.Year, 12, 21);
                lDateTwo = new DateTime(pDate.Year, 3, 20);
                if (lDateOne <= pDate.Date && lDateTwo >= pDate.Date)
                {
                    lReturn = Utils.WeatherSeason.Summer;
                }
                //Utils.Season.Fall
                //From 21-Mar to 21-Jun
                lDateOne = new DateTime(pDate.Year, 3, 21);
                lDateTwo = new DateTime(pDate.Year, 6, 20);
                if (lDateOne <= pDate.Date && lDateTwo >= pDate.Date)
                {
                    lReturn = Utils.WeatherSeason.Fall;
                }
                //Utils.Season.Winter
                //From 21-Jun to 21-Sep
                lDateOne = new DateTime(pDate.Year, 6, 21);
                lDateTwo = new DateTime(pDate.Year, 9, 20);
                if (lDateOne <= pDate.Date && lDateTwo >= pDate.Date)
                {
                    lReturn = Utils.WeatherSeason.Winter;
                }
            }

            return lReturn;
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
            Season lSeason = obj as Season;
            lReturn = this.Name.Equals(lSeason.Name);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}