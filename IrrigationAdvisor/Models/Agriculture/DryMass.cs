using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2017-04-06
    /// Author: rodouy
    /// Description: 
    ///     Dry Mass for Pastures
    ///     Have: Rate per hectare per day, KC and Root Depth for Pastures
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
    ///     - DryMass()      -- constructor
    ///     - DryMass(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class DryMass
    {
        #region Consts
        #endregion

        #region Fields

        private long dryMassId;
        private long cropId;
        private int ageOfCrop;
        private long seasonId;
        private int day;
        private Double ratePerHectareByDay;
        private Double weightPerHectareInKG;
        private Double exponent;
        private Double multiplier;
        private Double cropCoefficient;
        private Double rootDepth;


        #endregion

        #region Properties
        
        public long DryMassId
        {
            get { return dryMassId; }
            set { dryMassId = value; }
        }

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

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public Double RatePerHectareByDay
        {
            get { return ratePerHectareByDay; }
            set { ratePerHectareByDay = value; }
        }

        public Double WeightPerHectareInKG
        {
            get { return weightPerHectareInKG; }
            set { weightPerHectareInKG = value; }
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

        public Double CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }

        public Double RootDepth
        {
            get { return rootDepth; }
            set { rootDepth = value; }
        }


        #endregion

        #region Construction

        /// <summary>
        /// Constructor
        /// </summary>
        public DryMass()
        {
            this.CropId = 0;
            this.AgeOfCrop = 0;
            this.SeasonId = 0;
            this.Day = 0;
            this.RatePerHectareByDay = 0;
            this.WeightPerHectareInKG = 0;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pSeason"></param>
        /// <param name="pDay"></param>
        /// <param name="pRatePerHectareByDay"></param>
        /// <param name="pWeightPerHectareInKG"></param>
        public DryMass(Crop pCrop, int pAgeOfCrop, Season pSeason, int pDay, 
                    Double pRatePerHectareByDay, Double pWeightPerHectareInKG)
        {
            this.CropId = pCrop.CropId;
            this.Crop = pCrop;
            this.AgeOfCrop = pAgeOfCrop;
            this.SeasonId = pSeason.SeasonId;
            this.Season = pSeason;
            this.Day = pDay;
            this.RatePerHectareByDay = pRatePerHectareByDay;
            this.WeightPerHectareInKG = pWeightPerHectareInKG;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
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

            DryMass lDryMass = obj as DryMass;
            lReturn = this.Crop.Equals(lDryMass.Crop)
                && this.Season.Equals(lDryMass.Season)
                && this.AgeOfCrop.Equals(lDryMass.AgeOfCrop)
                && this.Day.Equals(lDryMass.Day);

            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Crop.GetHashCode();
        }
        #endregion
    }
}