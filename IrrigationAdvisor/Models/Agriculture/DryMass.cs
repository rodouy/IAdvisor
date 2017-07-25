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
        /// <summary>
        /// The fields are:
        ///     - id: long
        ///     - crop: Crop
        ///     - ageOfCrop: int
        ///     - season: Season
        ///     - day: int
        ///     - ratePerHectareByDay: Double
        ///     - weightPerHectareInKg: Double
        ///     - exponent: Double
        ///     - multiplier: Double
        ///     - coefficient: Double
        ///     - rootDepth: Double
        ///     
        /// </summary>
        private long dryMassId;
        private String name;
        private long cropId;
        private int ageOfCrop;
        private long seasonId;
        private int day;
        private Double ratePerHectareByDay;
        private Double initialWeightPerHectareInKG;
        private Double weightPerHectareInKG;
        private Double exponent;
        private Double multiplier;
        private Double maxCoefficient;
        private Double coefficient;
        private Double rootDepth;


        #endregion

        #region Properties
        
        public long DryMassId
        {
            get { return dryMassId; }
            set { dryMassId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
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

        public Double InitialWeightPerHectareInKG
        {
            get { return initialWeightPerHectareInKG; }
            set { initialWeightPerHectareInKG = value; }
        }

        /// <summary>
        /// Depends on: InitialWeightPerHectareInKG, Day, RatePerHectareByDay
        /// </summary>
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

        public Double MaxCoefficient
        {
            get { return maxCoefficient; }
            set { maxCoefficient = value; }
        }

        /// <summary>
        /// Depends on WeightPerHectareInKG, Exponent, Multiplier, MaxCoefficient
        /// </summary>
        public Double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }

        /// <summary>
        /// Depends on: WeatherSeason, Day
        /// </summary>
        public Double RootDepth
        {
            get{ return rootDepth;}
            set{ rootDepth = value;}
        }


        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public DryMass()
        {
            this.Name = "noname";
            this.CropId = 0;
            this.AgeOfCrop = 0;
            this.SeasonId = 0;
            this.Day = 0;
            this.RatePerHectareByDay = 0;
            this.InitialWeightPerHectareInKG = 0;
            this.WeightPerHectareInKG = 0;
            this.Exponent = 0;
            this.Multiplier = 0;
            this.MaxCoefficient = 0;
            this.Coefficient = 0;
            this.RootDepth = 0;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCrop"></param>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pSeason"></param>
        /// <param name="pDay"></param>
        /// <param name="pRatePerHectareByDay"></param>
        /// <param name="pInitialWeightPerHectareInKG"></param>
        /// <param name="pExponent"></param>
        /// <param name="pMultiplier"></param>
        /// <param name="pMaxCoefficient"></param>
        public DryMass(String pName, Crop pCrop, int pAgeOfCrop, Season pSeason, 
                    int pDay, Double pRatePerHectareByDay, Double pInitialWeightPerHectareInKG,
                    Double pWeightPerHectareInKG, Double pExponent, Double pMultiplier, 
                    Double pMaxCoefficient, Double pCoefficient, Double pRootDepth)
        {
            this.Name = pName;
            this.CropId = pCrop.CropId;
            this.Crop = pCrop;
            this.AgeOfCrop = pAgeOfCrop;
            this.SeasonId = pSeason.SeasonId;
            this.Season = pSeason;
            this.Day = pDay;
            this.RatePerHectareByDay = pRatePerHectareByDay;
            this.InitialWeightPerHectareInKG = pInitialWeightPerHectareInKG;
            this.WeightPerHectareInKG = pWeightPerHectareInKG;
            this.Exponent = pExponent;
            this.Multiplier = pMultiplier;
            this.MaxCoefficient = pMaxCoefficient;
            this.Coefficient = pCoefficient;
            this.RootDepth = pRootDepth;
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

        /// <summary>
        /// Return Weigth per Hectare in KG
        /// Depends on: InitialWeightPerHectareInKG, Day, RatePerHectareByDay
        /// </summary>
        /// <returns></returns>
        public Double GetWeightPerHectareInKG()
        {
            Double lReturn;
            lReturn = this.WeightPerHectareInKG;
            return lReturn;
        }

        /// <summary>
        /// Return the Coefficient of the Crop
        /// Depends on WeightPerHectareInKG, Exponent, Multiplier, MaxCoefficient
        /// </summary>
        /// <returns></returns>
        public double GetCoefficient()
        {
            double lReturn;
            lReturn = this.Coefficient;
            return lReturn;
        }

        /// <summary>
        /// Return the Root Depth
        /// Depends on: WeatherSeason, Day
        /// </summary>
        /// <returns></returns>
        public double GetRootDepth()
        {
            double lRootDepth;
            lRootDepth = this.rootDepth;
            return lRootDepth;
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