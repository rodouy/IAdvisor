﻿using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Water;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Weather;


namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2014-10-24
    /// Author: monicarle
    /// Description: 
    ///     Describes a country.
    ///     The capital city gives the country position.
    ///     
    /// References:
    ///     City
    ///     Region
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    ///     - cityList List <Location>
    ///     - regionList List <Region>
    ///     - capital City
    ///     
    /// Methods:
    ///     - Country()      -- constructor
    ///     - Country(name)  -- consturctor with parameters
    ///     - SetCapital(City): bool
    ///     - add(City)
    /// 
    /// </summary>
    //[Serializable()]
    public class Country
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - countryId long
        ///     - name: the name of the country
        ///     - language: Language.Language
        ///     - capital City
        ///     - cityList: List<City>
        ///     - regionList: List<Region>
        ///     
        /// </summary>
        private long countryId;
        private String name;
        private long languageId;
        private long capitalId;
        private List<City> cityList;
        private List<Region> regionList;

        #endregion

        #region Properties

        
        public long CountryId
        {
            get { return countryId; }
            set { countryId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long LanguageId
        {
            get { return languageId; }
            set { languageId = value; }
        }
        public virtual Language.Language Language
        {
            get;
            set;
        }

        public long CapitalId
        {
            get { return capitalId; }
            set { capitalId = value; }
        }

        public virtual City Capital
        {
            get;
            set;
        }

        public List<City> CityList
        {
            get { return cityList; }
            set { cityList = value; }
        }

        public List<Region> RegionList
        {
            get { return regionList; }
            set { regionList = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without Parameters
        /// </summary>
        /// <param name="name">Name of the country</param>
        /// <param name="location">Location of the country</param>
        public Country()
        {
            this.CountryId = 0;
            this.Name = "NoName";
            this.LanguageId = 1;
            this.CapitalId = 1;
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
        }

        public Country(long pCountryId, String pName, 
                        long pLanguageId, 
                        long pCapitalId)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.LanguageId = pLanguageId;
            this.CapitalId = pCapitalId;
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pCountryId"></param>
        /// <param name="pName"></param>
        /// <param name="pLanguageId"></param>
        /// <param name="pCapitalId"></param>
        public Country(long pCountryId, String pName, 
                        Language.Language pLanguage, City pCapital)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.LanguageId = pLanguage.LanguageId;
            this.CapitalId = pCapital.CityId;
            this.CityList = new List<City>();
            if(pCapital != null)
            {
                this.CityList.Add(pCapital);
            }
            this.RegionList = new List<Region>();
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pCountryId"></param>
        /// <param name="pName"></param>
        /// <param name="pLanguage"></param>
        /// <param name="pCapital"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        public Country(long pCountryId, String pName, long pLanguageId, long pCapitalId, 
                            List<City> pCityList, List<Region> pRegionList)
        {
            this.CountryId = pCountryId;
            this.Name = pName;
            this.LanguageId = pLanguageId;
            this.CapitalId = pCapitalId;
            this.CityList = pCityList;
            this.RegionList = pRegionList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region Language

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pLanguage"></param>
        /// <returns></returns>
        public bool ChangeLanguage(Language.Language pLanguage)
        {
            bool lResult = false;
            if (pLanguage != null)
            {
                this.LanguageId = pLanguage.LanguageId;
                lResult = true;
            }
            return lResult;
        }

        #endregion

        #region City

        /// <summary>
        /// If City exist in List return the City, 
        /// else return null
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City ExistCity(City pCity)
        {
            City lReturn = null;
            if (pCity != null)
            {
                foreach (City item in this.CityList)
                {
                    if (item.Equals(pCity))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }
        
        /// <summary>
        /// Add a new City and return it, if exists returns null
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City AddCity(City pCity)
        {
            City lReturn = null;
            if (pCity != null)
            {
                if (ExistCity(pCity) == null)
                {
                    this.CityList.Add(pCity);
                    lReturn = pCity;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update City Name and Position, if not exist in list, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City UpdateCity(String pName, Position pPosition,
                                Country pCountry)
        {
            City lReturn = null;
            City lCity = new City(0, pName, pPosition, pCountry);
            lReturn = ExistCity(lCity);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.PositionId = pPosition.PositionId;
                lReturn.Position = pPosition;
                lReturn.CountryId = pCountry.CountryId;
                lReturn.Country = pCountry;
            }
            return lReturn;
        }
        
        #endregion

        #region Region

        /// <summary>
        /// If Region exist in List return the Region, 
        /// else return null
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public Region ExistRegion(Region pRegion)
        {
            Region lReturn = null;
            if (pRegion != null)
            {
                foreach (Region item in this.RegionList)
                {
                    if (item.Equals(pRegion))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Region and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pSpecieList"></param>
        /// <returns></returns>
        public Region AddRegion(Region pRegion)
        {
            Region lReturn = null;
            if (pRegion != null)
            {
                if (ExistRegion(pRegion) == null)
                {
                    this.RegionList.Add(pRegion);
                    lReturn = pRegion;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update Region, if not exists return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pSpecieList"></param>
        /// <param name="pSpecieCycleList"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pTemperatureDataList"></param>
        /// <returns></returns>
        public Region UpdateRegion(String pName, long pPositionId,
            List<Specie> pSpecieList,
            List<SpecieCycle> pSpecieCycleList,
            List<EffectiveRain> pEffectiveRainList,
            List<TemperatureData> pTemperatureDataList)
        {
            Region lReturn = null;
            Region lRegion = new Region(pName, pPositionId, pSpecieList,
                                        pSpecieCycleList, pEffectiveRainList,
                                        pTemperatureDataList);
            lReturn = ExistRegion(lRegion);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.PositionId = pPositionId;
                lReturn.SpecieList = pSpecieList;
                lReturn.SpecieCycleList = pSpecieCycleList;
                lReturn.EffectiveRainList = pEffectiveRainList;
                lReturn.TemperatureDataList = pTemperatureDataList;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Country lCountry = obj as Country;
            return this.Name.Equals(lCountry.Name)
                && this.Capital.Equals(lCountry.Capital);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion

    }
}