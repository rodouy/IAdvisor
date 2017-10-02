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
    /// Create: 2017-09-26
    /// Author: rodouy
    /// Description: 
    ///     Dry Mass Remainder by Season, Crop and Cutoff
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
    public class DryMassRemainder
    {
        #region Consts
        #endregion

        #region Fields
        private long dryMassRemainderId;
        private String name;
        private long specieId;
        private int ageOfCrop;
        private long seasonId;
        private Double height;
        private Double initialDryMass;

        #endregion

        #region Properties

        public long DryMassRemainderId
        {
            get { return dryMassRemainderId; }
            set { dryMassRemainderId = value; }
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

        public Double Height
        {
            get { return height; }
            set { height = value; }
        }

        public Double InitialDryMass
        {
            get { return initialDryMass; }
            set { initialDryMass = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
         public DryMassRemainder()
        {
            this.Name = "noname";
            this.SpecieId = 0;
            this.AgeOfCrop = 0;
            this.SeasonId = 0;
            this.Height = 0;
            this.InitialDryMass = 0;
        }
        
        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pSeason"></param>
        /// <param name="pHeight"></param>
        /// <param name="pInitialDryMass"></param>
         public DryMassRemainder(String pName, Specie pSpecie, 
                        int pAgeOfCrop, Season pSeason,
                        Double pHeight, Double pInitialDryMass)
        {
            this.Name = pName;
            this.SpecieId = pSpecie.SpecieId;
            this.Specie = pSpecie;
            this.AgeOfCrop = pAgeOfCrop;
            this.SeasonId = pSeason.SeasonId;
            this.Season = pSeason;
            this.Height = pHeight;
            this.InitialDryMass = pInitialDryMass;
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

            DryMassRemainder lDryMassRemainder = obj as DryMassRemainder;
            lReturn = this.Specie.Equals(lDryMassRemainder.Specie)
                && this.Season.Equals(lDryMassRemainder.Season)
                && this.AgeOfCrop.Equals(lDryMassRemainder.AgeOfCrop)
                && this.Height.Equals(lDryMassRemainder.Height);

            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Specie.GetHashCode();
        }
        #endregion

    }
}