using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2017-09-25
    /// Author: rodouy
    /// Description: 
    ///     Dry Mass Rate by Day, Crop and Season
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     Season, Specie
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class DryMassRate
    {

        #region Consts
        #endregion

        #region Fields
        private long dryMassRateId;
        private String name;
        private long specieId;
        private int ageOfCrop;
        private long seasonId;
        private int durationInDays;
        private Double ratePerHectareByDay;
        private Double exponent;
        private Double multiplier;
        private Double maxCoefficient;
        private Double rootDepth;
        private int order;
        private bool isUsed;

        #endregion

        #region Properties

        public long DryMassRateId
        {
            get { return dryMassRateId; }
            set { dryMassRateId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public long SpecieId
        {
            get { return specieId; }
            set { specieId = value; }
        }

        public virtual Specie Specie
        {
            get;
            set;
        }

        public int AgeOfCrop
        {
            get { return ageOfCrop; }
            set { ageOfCrop = value; }
        }

        public long SeasonId
        {
            get { return seasonId; }
            set { seasonId = value; }
        }

        public virtual Season Season
        {
            get;
            set;
        }

        public int DurationInDays
        {
            get { return durationInDays; }
            set { durationInDays = value; }
        }

        public Double RatePerHectareByDay
        {
            get { return ratePerHectareByDay; }
            set { ratePerHectareByDay = value; }
        }

        public Double Exponent
        {
            get { return exponent; }
            set { exponent = value; }
        }

        public Double Multiplier
        {
            get { return multiplier; }
            set { multiplier = value; }
        }

        public Double MaxCoefficient
        {
            get { return maxCoefficient; }
            set { maxCoefficient = value; }
        }

        public Double RootDepth
        {
            get { return rootDepth; }
            set { rootDepth = value; }
        }

        public int Order
        {
            get { return order; }
            set { order = value; }
        }

        public bool IsUsed
        {
            get { return isUsed; }
            set { isUsed = value; }
        }


        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
         public DryMassRate()
        {
            this.Name = "noname";
            this.SpecieId = 0;
            this.AgeOfCrop = 0;
            this.SeasonId = 0;
            this.DurationInDays = 0;
            this.RatePerHectareByDay = 0;
            this.Exponent = 0;
            this.Multiplier = 0;
            this.MaxCoefficient = 0;
            this.RootDepth = 0;
            this.Order = 0;
            this.IsUsed = false;
        }

        /// <summary>
         /// Constructor with all parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pSeason"></param>
        /// <param name="pDurationInDays"></param>
        /// <param name="pRatePerHectareByDay"></param>
        /// <param name="pExponent"></param>
        /// <param name="pMultiplier"></param>
        /// <param name="pMaxCoefficient"></param>
        /// <param name="pRootDepth"></param>
        /// <param name="pOrder"></param>
        /// <param name="pIsUsed"></param>
        public DryMassRate(String pName, Specie pSpecie, int pAgeOfCrop, Season pSeason,
                        int pDurationInDays, Double pRatePerHectareByDay, Double pExponent,
                        Double pMultiplier, Double pMaxCoefficient, Double pRootDepth,
                        int pOrder, bool pIsUsed)
        {
            this.Name = pName;
            this.SpecieId = pSpecie.SpecieId;
            this.Specie = pSpecie;
            this.AgeOfCrop = pAgeOfCrop;
            this.SeasonId = pSeason.SeasonId;
            this.Season = pSeason;
            this.DurationInDays = pDurationInDays;
            this.RatePerHectareByDay = pRatePerHectareByDay;
            this.Exponent = pExponent;
            this.Multiplier = pMultiplier;
            this.MaxCoefficient = pMaxCoefficient;
            this.RootDepth = pRootDepth;
            this.Order = pOrder;
            this.IsUsed = pIsUsed;
        }


        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods


        /// <summary>
        /// Return the Weather Season
        /// </summary>
        /// <returns></returns>
        public Utils.WeatherSeason GetWeatherSeason()
        {
            Utils.WeatherSeason lReturn;
            lReturn = this.Season.WeatherSeason;
            return lReturn;
        }


        #endregion

        #region Overrides

        /// <summary>
        /// Overrides equals
        /// Crop, Season, AgeOfCrop, Day
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            DryMassRate lDryMassRate = obj as DryMassRate;
            lReturn = this.Specie.Equals(lDryMassRate.Specie)
                && this.Season.Equals(lDryMassRate.Season)
                && this.AgeOfCrop.Equals(lDryMassRate.AgeOfCrop)
                && this.Order.Equals(lDryMassRate.Order);

            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Specie.GetHashCode();
        }

        #endregion

    }
}