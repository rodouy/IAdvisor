using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Utilities;



namespace IrrigationAdvisor.Models.Localization
{
    /// <summary>
    /// Create: 2014-10-22
    /// Author: monicarle
    /// Description: 
    ///     Describes a region
    ///     
    /// References:
    ///     Location
    ///     
    /// Dependencies:
    ///     Location
    ///     Specie
    ///     Crop
    ///     EffectiveRainList
    ///     CropIrrigationWeather
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - regionId int
    ///     - name String
    ///     - location Location
    ///     - specieList: List<Specie>
    ///     - effectiveRainList LiEffectiveRainListRain>
    /// 
    /// Methods:
    ///     - Region()      -- constructor
    ///     - Region(name)  -- consturctor with parameters
    ///     - SetLocation(Location): bool
    /// 
    /// </summary>
    //[Serializable()]
    public class Region
    {
        #region Consts
        #endregion

        #region Fields

        /// <summary>
        /// The fields are:
        ///     - regionId: identifier
        ///     - name: the name of the region
        ///     - location: the location of the region
        ///     - specieList: list of the species of the region
        ///     - effectiveRainList: effective lRainItem (by month) for the region
        ///     
        /// </summary>
        private long regionId;
        private String name;
        private long positionId;
        private List<Specie> specieList;
        private List<SpecieCycle> specieCycleList;
        private List<EffectiveRain> effectiveRainList;
        #region Temperature Data
        private List<TemperatureData> temperatureDataList;
        #endregion

        #endregion

        #region Properties

        
        public long RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public virtual Position Position
        {
            get ; 
            set ; 
        }

        public List<Specie> SpecieList
        {
            get { return specieList; }
            set { specieList = value; }
        }

        public List<SpecieCycle> SpecieCycleList
        {
            get { return specieCycleList; }
            set { specieCycleList = value; }
        }
        
        public List<EffectiveRain> EffectiveRainList
        {
            get { return effectiveRainList; }
            set { effectiveRainList = value; }
        }

        public List<TemperatureData> TemperatureDataList
        {
            get { return temperatureDataList; }
            set { temperatureDataList = value; }
        }
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Region()
        {
            this.regionId = 0;
            this.Name = "";
            this.PositionId = 0;
            this.Position = new Position();
            this.SpecieList = new List<Specie>();
            this.SpecieCycleList = new List<SpecieCycle>();
            this.EffectiveRainList = new List<EffectiveRain>();
            this.TemperatureDataList = new List<TemperatureData>();
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pRegionId"></param>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        public Region(long pRegionId, String pName, long pPositionId)
        {
            this.regionId = pRegionId;
            this.Name = pName;
            this.PositionId = pPositionId;
            this.SpecieList = new List<Specie>();
            this.SpecieCycleList = new List<SpecieCycle>();
            this.EffectiveRainList = new List<EffectiveRain>();
            this.TemperatureDataList = new List<TemperatureData>();
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pSpecieList"></param>
        /// <param name="pSpecieCycleList"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pTemperatureDataList"></param>
        public Region(String pName, long pPositionId,
                    List<Specie> pSpecieList, 
                    List<SpecieCycle> pSpecieCycleList,
                    List<EffectiveRain> pEffectiveRainList,
                    List<TemperatureData> pTemperatureDataList)
        {
            this.Name = pName;
            this.PositionId = pPositionId;
            this.SpecieList = pSpecieList;
            this.SpecieCycleList = pSpecieCycleList;
            this.EffectiveRainList = pEffectiveRainList;
            this.TemperatureDataList = pTemperatureDataList;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region TemperatureDataList

        /// <summary>
        /// New ID for TemperatureDataList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewTemperatureDataListId()
        {
            long lReturn = 1;
            if (this.TemperatureDataList != null && this.TemperatureDataList.Count > 0)
            {
                lReturn += this.TemperatureDataList.Max(td => td.TemperatureDataId);
            }
            return lReturn;
        }

        /// <summary>
        /// If TemperatureData exists in List, return the Temperature Data, 
        /// else return null
        /// </summary>
        /// <param name="pTemperatureData"></param>
        /// <returns></returns>
        public TemperatureData ExistTemperatureData(TemperatureData pTemperatureData)
        {
            TemperatureData lReturn = null;
            foreach(TemperatureData item in TemperatureDataList)
            {
                if(item.Equals(pTemperatureData))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Temperature Data to List if not exists,
        /// if exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDate"></param>
        /// <param name="pRegionId"></param>
        /// <param name="pMinTemperature"></param>
        /// <param name="pMaxTemperature"></param>
        /// <param name="pETC"></param>
        /// <param name="pRain"></param>
        /// <returns></returns>
        public TemperatureData AddTemperatureData(String pName, DateTime pDate, long pRegionId,
                                                Double pMinTemperature, Double pMaxTemperature,
                                                Double pETC, Double pRain)
        {
            TemperatureData lReturn = null;
            TemperatureData lTemperatureData = new TemperatureData(pName, pDate, pRegionId, 
                                                            pMinTemperature, pMaxTemperature,
                                                            pETC, pRain);
            if(ExistTemperatureData(lTemperatureData) == null)
            {
                this.TemperatureDataList.Add(lTemperatureData);
                lReturn = lTemperatureData;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the temperature data if exists in List, else return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDate"></param>
        /// <param name="pRegionId"></param>
        /// <param name="pMinTemperature"></param>
        /// <param name="pMaxTemperature"></param>
        /// <param name="pETC"></param>
        /// <param name="pRain"></param>
        /// <returns></returns>
        public TemperatureData UpdateTemperatureData(String pName, DateTime pDate, long pRegionId,
                                                Double pMinTemperature, Double pMaxTemperature,
                                                Double pETC, Double pRain)
        {
            TemperatureData lReturn = null;
            TemperatureData lTemperatureData = new TemperatureData(pName, pDate, pRegionId,
                                                            pMinTemperature, pMaxTemperature,
                                                            pETC, pRain);
            lReturn = ExistTemperatureData(lTemperatureData);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.RegionId = pRegionId;
                lReturn.Min = pMinTemperature;
                lReturn.Max = pMaxTemperature;
                lReturn.ETC = pETC;
                lReturn.Rain = pRain;
            }
            return lReturn;
        }

        /// <summary>
        /// Return AccumulatedGrowingDegreeDays for the days between SowingDate & CurrentDate
        /// </summary>
        /// <param name="pSowingDate"></param>
        /// <param name="pCurrentDate"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public Double GetAccumulatedGrowingDegreeDays(DateTime pSowingDate, DateTime pCurrentDate,
                                                            Double pBaseTemperature)
        {
            Double lReturn = 0;
            Double lAccumulatedGrowingDegreeDays = 0;
            Double lTemperature;
            Double lGrowingDegreeDays;
            DateTime lDay;

            foreach (TemperatureData item in this.TemperatureDataList)
            {
                lDay = item.Date;
                if (Utils.IsBetweenDatesWithoutYear(pSowingDate, pCurrentDate, lDay))
                {
                    lTemperature = item.Average;
                    lGrowingDegreeDays = lTemperature - pBaseTemperature;
                    lAccumulatedGrowingDegreeDays += lGrowingDegreeDays;
                }
                if (lDay > pCurrentDate)
                {
                    break;
                }
            }
            lReturn = lAccumulatedGrowingDegreeDays;

            return lReturn;
        }

        /// <summary>
        /// Return the GrowingDegreeDays
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public Double GetGrowingDegreeDays(DateTime pCurrentDate, Double pBaseTemperature)
        {
            Double lReturn = 0;
            Double lTemperature = 0;
            Double lGrowingDegreeDays = 0;
            DateTime lDay;

            foreach (TemperatureData item in this.TemperatureDataList)
            {
                lDay = item.Date;
                if (Utils.IsTheSameDay(lDay, pCurrentDate))
                {
                    lTemperature = item.Average;
                    lGrowingDegreeDays = Math.Max(lTemperature - pBaseTemperature, 0);
                    break;
                }
            }

            lReturn = lGrowingDegreeDays;
            return lReturn;
        }

        /// <summary>
        /// Return the Evapotranspiration for a day
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public Double GetEvapotranspiration(DateTime pCurrentDate)
        {
            Double lReturn = 0;
            Double lEvapotranspiration = 0;
            DateTime lDay;
            foreach (TemperatureData item in this.TemperatureDataList)
            {
                lDay = item.Date;
                if(Utils.IsTheSameDay(lDay, pCurrentDate))
                {
                    lEvapotranspiration = item.ETC;
                    break;
                }
            }

            lReturn = lEvapotranspiration;
            return lReturn;
        }

        #endregion

        #region EffectiveRainList

        /// <summary>
        /// New ID for EffectiveRainList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewEffectiveRainListId()
        {
            long lReturn = 1;
            if (this.EffectiveRainList != null && this.EffectiveRainList.Count > 0)
            {
                lReturn += this.EffectiveRainList.Max(er => er.EffectiveRainId);
            }
            return lReturn;
        }

        /// <summary>
        /// If EffectiveRain exists in List, return the Effective Rain, 
        /// else return null
        /// </summary>
        /// <param name="pEffectiveRain"></param>
        /// <returns></returns>
        public EffectiveRain ExistEffectiveRain(EffectiveRain pEffectiveRain)
        {
            EffectiveRain lReturn = null;
            foreach (EffectiveRain item in EffectiveRainList)
            {
                if(item.Equals(pEffectiveRain))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Effective Rain to List if not exists,
        /// if exists return null
        /// </summary>
        /// <param name="pMonth"></param>
        /// <param name="pMinRain"></param>
        /// <param name="pMaxRain"></param>
        /// <param name="pPercentage"></param>
        /// <returns></returns>
        public EffectiveRain AddEffectiveRain(String pName,
                                            int pMonth, Double pMinRain, 
                                            Double pMaxRain, Double pPercentage)
        {
            EffectiveRain lReturn = null;
            EffectiveRain lEffectiveRain = new EffectiveRain(pName, pMonth, 
                                                            pMinRain, pMaxRain, pPercentage);
            if (ExistEffectiveRain(lEffectiveRain) == null)
            {
                this.EffectiveRainList.Add(lEffectiveRain);
                lReturn = lEffectiveRain;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the effective rain if exists in List, else return null
        /// </summary>
        /// <param name="pMonth"></param>
        /// <param name="pMinRain"></param>
        /// <param name="pMaxRain"></param>
        /// <param name="pPercentage"></param>
        /// <returns></returns>
        public EffectiveRain UpdateEffectiveRain(String pName,
                                            int pMonth, Double pMinRain, 
                                            Double pMaxRain, Double pPercentage)
        {
            EffectiveRain lReturn = null;
            EffectiveRain lEffectiveRain = new EffectiveRain(pName, pMonth, pMinRain, 
                                                            pMaxRain, pPercentage);
            lReturn = ExistEffectiveRain(lEffectiveRain);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Month = pMonth;
                lReturn.MinRain = pMinRain;
                lReturn.MaxRain = pMaxRain;
                lReturn.Percentage = pPercentage;
            }
            return lReturn;
        }


        #endregion

        #region SpecieCycleList
        /// <summary>
        /// New ID for SpecieCycleList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewSpecieCycleListId()
        {
            long lReturn = 1;
            if (this.SpecieCycleList != null && this.SpecieCycleList.Count > 0)
            {
                lReturn += this.SpecieCycleList.Max(sc => sc.SpecieCycleId);
            }
            return lReturn;
        }
        /// <summary>
        /// Return the SpecieCycle that has the same parameters, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public SpecieCycle FindSpecieCycle(String pName)
        {
            SpecieCycle lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                foreach (SpecieCycle item in this.SpecieCycleList)
                {
                    if (item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the SpecieCycle that has the id, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public SpecieCycle FindSpecieCycle(long pSpecieCycleId)
        {
            SpecieCycle lReturn = null;
            foreach (SpecieCycle item in this.SpecieCycleList)
            {
                if (item.SpecieCycleId.Equals(pSpecieCycleId))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If SpecieCycle exists in List return the SpecieCycle, else null
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public SpecieCycle ExistSpecieCycle(SpecieCycle pSpecieCycle)
        {
            SpecieCycle lReturn = null;
            if (pSpecieCycle != null)
            {
                foreach (SpecieCycle item in this.SpecieCycleList)
                {
                    if (item.Equals(pSpecieCycle))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new SpecieCycle and return it, if exists return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public SpecieCycle AddSpecieCycle(String pName)
        {
            SpecieCycle lReturn = null;
            long lSpecieCycleId = this.GetNewSpecieCycleListId();
            SpecieCycle lSpecieCycle = new SpecieCycle(lSpecieCycleId, pName);
            if (ExistSpecieCycle(lSpecieCycle) == null)
            {
                this.SpecieCycleList.Add(lSpecieCycle);
                lReturn = lSpecieCycle;
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new SpecieCycle and return it, if exists return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public SpecieCycle AddSpecieCycle(SpecieCycle pSpecieCycle)
        {
            SpecieCycle lReturn = null;
            if (pSpecieCycle != null)
            {
                if (ExistSpecieCycle(pSpecieCycle) == null)
                {
                    this.SpecieCycleList.Add(pSpecieCycle);
                    lReturn = pSpecieCycle;
                }
            }
            return lReturn;
        }

        #endregion

        #region Specie

        /// <summary>
        /// New ID for SpecieList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewSpecieListId()
        {
            long lReturn = 1;
            if (this.SpecieList != null && this.SpecieCycleList.Count > 0)
            {
                lReturn += this.SpecieList.Max(sp => sp.SpecieId);
            }
            return lReturn;
        }

        /// <summary>
        /// Return list of Species that contains the parameter in his name, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public List<Specie> ContainInSpecie(String pName)
        {
            List<Specie> lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                lReturn = new List<Specie>();
                foreach (Specie item in this.SpecieList)
                {
                    if (item.Name.Contains(pName))
                    {
                        lReturn.Add(item);                        
                    }
                }
                if(lReturn.Count == 0)
                {
                    lReturn = null;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return list of Species with same Specie Cycle, else return null.
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public List<Specie> FindSpecieList(SpecieCycle pSpecieCycle)
        {
            List<Specie> lReturn = null;
            if (pSpecieCycle != null)
            {
                lReturn = new List<Specie>();
                foreach (Specie item in this.SpecieList)
                {
                    if (item.SpecieCycle.Equals(pSpecieCycle))
                    {
                        lReturn.Add(item);
                    }
                }
                if (lReturn.Count == 0)
                {
                    lReturn = null;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Specie that has the same parameters, else return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Specie FindSpecie(String pName)
        {
            Specie lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                foreach (Specie item in this.SpecieList)
                {
                    if (item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Specie exists in List return the Specie, else null
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public Specie ExistSpecie(Specie pSpecie)
        {
            Specie lReturn = null;
            if(pSpecie!= null)
            {
                foreach (Specie item in this.SpecieList)
                {
                    if(item.Equals(pSpecie))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }            
            return lReturn;
        }

        /// <summary>
        /// Return the Specie added to the list.
        /// If already exists, it return the one of the list.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pSpecieCycleName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pStressTemperarute"></param>
        /// <param name="pSpecieType"></param>
        /// <returns></returns>
        public Specie AddSpecie(String pName, String pShortName, String pSpecieCycleName, 
                                Double pBaseTemperature, Double pStressTemperarute,
                                Utils.SpecieType pSpecieType)
        {
            Specie lReturn = null;
            long lSpecieId = this.GetNewSpecieListId();
            SpecieCycle lSpecieCycle = null;
            Specie lSpecie = null;

            lSpecieCycle = this.FindSpecieCycle(pSpecieCycleName);
            if(lSpecieCycle == null)
            {
                lSpecieCycle = this.AddSpecieCycle(pSpecieCycleName);
            }
            lSpecie = new Specie(lSpecieId, pName, pShortName, lSpecieCycle.SpecieCycleId, 
                                        pBaseTemperature, pStressTemperarute, pSpecieType);
            lSpecie.SpecieCycle = lSpecieCycle;
            lReturn = this.ExistSpecie(lSpecie);
            if(lReturn == null)
            {
                this.SpecieList.Add(lSpecie);
                lReturn = lSpecie;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Specie added to the list.
        /// If already exists, it return the one of the list.
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public Specie AddSpecie(Specie pSpecie)
        {
            Specie lReturn = null;
            SpecieCycle lSpecieCycle = null;
            
            if (pSpecie != null)
            {
                lSpecieCycle = this.FindSpecieCycle(pSpecie.SpecieCycleId);
                if (lSpecieCycle != null)
                {
                    if (pSpecie.SpecieCycle == null)
                    {
                        pSpecie.SpecieCycle = lSpecieCycle;
                    }
                }
                lReturn = this.ExistSpecie(pSpecie);
                if (lReturn == null)
                {
                    this.SpecieList.Add(pSpecie);
                    lReturn = pSpecie;
                }
            }
            return lReturn;
        } 

        /// <summary>
        /// Return the Specie updated in the list.
        /// If not exists, it return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycleName"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public Specie UpdateSpecie(String pName, String pShortName, String pSpecieCycleName,
                                    Double pBaseTemperature, Double pStressTemperature,
                                    Utils.SpecieType pSpecieType)
        {
            Specie lReturn = null;
            SpecieCycle lSpecieCycle = null;
            long lSpecieCycleId = this.SpecieCycleList.Count;
            Specie lSpecie = null;
            long lSpecieId = this.SpecieList.Count;

            lSpecieCycle = this.FindSpecieCycle(pSpecieCycleName);
            if (lSpecieCycle == null)
            {
                lSpecieCycle = this.AddSpecieCycle(pSpecieCycleName);
            }
            //If not exists SpecieCycle, its create a new SpecieCycle.
            //In both cases, lSpecieCycle isnt null
            lSpecieCycleId = lSpecieCycle.SpecieCycleId;
            lSpecie = new Specie(lSpecieId, pName, pShortName, lSpecieCycleId,
                                 pBaseTemperature, pStressTemperature, pSpecieType);
            lReturn = ExistSpecie(lSpecie);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.ShortName = pShortName;
                lReturn.SpecieCycleId = lSpecieCycleId;
                lReturn.BaseTemperature = pBaseTemperature;
                lReturn.StressTemperature = pStressTemperature;
                lReturn.SpecieType = pSpecieType;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Region lRegion = obj as Region;
            return this.Name.Equals(lRegion.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion
    }
}