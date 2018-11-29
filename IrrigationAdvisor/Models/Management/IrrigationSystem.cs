﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Security;
using NLog;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2014-11-01
    /// Author: monicarle
    /// Description: 
    ///     Manage all the information of the system
    ///     s
    /// References:
    ///     almost all
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropIrrigationWeatherList List<CropIrrigationWeather>
    /// 
    /// Methods:
    ///     - IrrigationSystem()      -- constructor
    ///     
    /// </summary>
    public class IrrigationSystem
    {

        #region Index

        #region Agriculture
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Localization
        #endregion

        #region Management
        #endregion

        #region Security
        #endregion

        #region Utitilities
        #endregion

        #region Water
        #endregion

        #region Weather
        #endregion

        #endregion

        #region Consts

        #region Agriculture
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion

        #region Localization
        #endregion

        #region Management
        #endregion

        #region Security
        #endregion

        #region Utilities
        #endregion

        #region Water
        #endregion

        #region Weather
        #endregion

        #endregion

        #region Fields

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #region Agriculture 

        private List<Crop> cropList;
        private List<Soil> soilList;
        
        #endregion

        #region Irrigation
        
        private List<Bomb> bombList;
        private List<IrrigationUnit> irrigationUnitList;

        #endregion

        #region Language

        private List<Language.Language> languageList;
        
        #endregion

        #region Location

        private List<Position> positionList;
        private List<Country> countryList;
        private List<City> cityList;
        private List<Region> regionList;
        private List<Location> locationList;
        private List<Farm> farmList;
        
        #endregion

        #region Management

        private DateTime dateOfReference;
        private List<CropIrrigationWeather> cropIrrigationWeatherList;
        private IrrigationCalculus irrigationCalculus;

        #endregion

        #region Security 

        private List<User> userList;

        #endregion

        #region Utitilities
        #endregion

        #region Water

        
        #endregion

        #region Weather

        private List<WeatherStation> weatherStationList;             
        
        #endregion

        #endregion

        #region Properties

        #region Agriculture
        
        public List<Crop> CropList
        {
            get { return cropList; }
            set { cropList = value; }
        }

        public List<Soil> SoilList
        {
            get { return soilList; }
            set { soilList = value; }
        }

        #endregion

        #region Irrigation

        public List<Bomb> BombList
        {
            get { return bombList; }
            set { bombList = value; }
        }

        public List<IrrigationUnit> IrrigationUnitList
        {
            get { return irrigationUnitList; }
            set { irrigationUnitList = value; }
        }

        #endregion

        #region Language

        public List<Language.Language> LanguageList
        {
            get { return languageList; }
            set { languageList = value; }
        }

        #endregion

        #region Localization
        
        public List<Position> PositionList
        {
          get { return positionList; }
          set { positionList = value; }
        }

        public List<Country> CountryList
        {
            get { return countryList; }
            set { countryList = value; }
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

        public List<Location> LocationList
        {
            get { return locationList; }
            set { locationList = value; }
        }

        public List<Farm> FarmList
        {
            get { return farmList; }
            set { farmList = value; }
        }

        #endregion

        #region Management

        public DateTime DateOfReference
        {
            get { return dateOfReference; }
        }
        
        public List<CropIrrigationWeather> CropIrrigationWeatherList
        {
            get { return cropIrrigationWeatherList; }
            set { cropIrrigationWeatherList = value; }
        }

        public IrrigationCalculus IrrigationCalculus
        {
            get { return irrigationCalculus; }
            set { irrigationCalculus = value; }
        }

        #endregion

        #region Security

        public List<User> UserList
        {
            get { return userList; }
            set { userList = value; }
        }

        #endregion

        #region Utitilities
        #endregion

        #region Water
        
        #endregion

        #region Weather


        public List<WeatherStation> WeatherStationList
        {
            get { return weatherStationList; }
            set { weatherStationList = value; }
        }
        
        #endregion
        
        #endregion

        #region Construction

        /// <summary>
        /// IrrigationSystem instance
        /// </summary>
        private static IrrigationSystem instance;

        /// <summary>
        /// Constructor of IrrigationSystem
        /// </summary>
        private IrrigationSystem()
        {

            #region Agriculture
            
            this.CropList = new List<Crop>();
            this.SoilList = new List<Soil>();
            
            #endregion

            #region Irrigation

            this.BombList = new List<Bomb>();
            this.IrrigationUnitList = new List<IrrigationUnit>();

            #endregion

            #region Language

            this.LanguageList = new List<Language.Language>();

            #endregion

            #region Localization

            this.PositionList = new List<Position>();
            this.CountryList = new List<Country>();
            this.CityList = new List<City>();
            this.RegionList = new List<Region>();
            this.LocationList = new List<Location>();
            this.FarmList = new List<Farm>();

            #endregion
            
            #region Management

            this.dateOfReference = DateTime.Now;
            this.CropIrrigationWeatherList = new List<CropIrrigationWeather>();
            this.IrrigationCalculus = new IrrigationCalculus();
            
            #endregion
            
            #region Security 

            this.UserList = new List<User>();

            #endregion

            #region Utitilities
            #endregion

            #region Water

            #endregion
            
            #region Weather
            
            this.WeatherStationList = new List<WeatherStation>();
            
            #endregion

        }

        /// <summary>
        /// Return the instance of IrrigationSystem
        /// </summary>
        public static IrrigationSystem Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new IrrigationSystem();
                }
                return instance;
            }
        }

        #endregion

        #region Private Helpers

        #region Agriculture
        #endregion

        #region Irrigation
        #endregion

        #region Language
        #endregion
        
        #region Location
        #endregion

        #region Management

        

        #endregion

        #region Security
        #endregion

        #region Utitilities
        #endregion

        #region Water
        
        #endregion

        #region Weather

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        private List<EffectiveRain> getEffectiveRainList(Region pRegion)
        {
            List <EffectiveRain> lReturnEffectiveRain = new List<EffectiveRain>();
            foreach(Region lRegion in this.RegionList)
            {
                if (lRegion.Equals(pRegion))
                {
                    lReturnEffectiveRain = lRegion.EffectiveRainList.ToList();
                    return lReturnEffectiveRain;
                }
            }
            return lReturnEffectiveRain;
        }

        /// <summary>
        /// TODO description calculateDegreeStageDifference
        /// </summary>
        /// <param name="oldStage"></param>
        /// <param name="newStage"></param>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        private double calculateDegreeStageDifference(Stage oldStage, Stage newStage, Crop pCrop)
        {
            double oldDegree = 0;
            double newDegree = 0;
            double lReturn = 0;
            List<PhenologicalStage> lPhenologicalStageList;

            try
            {
                lPhenologicalStageList = pCrop.PhenologicalStageList;
                foreach (PhenologicalStage lPhenologicalStage in lPhenologicalStageList)
                {
                    if (lPhenologicalStage.Stage.Equals(oldStage))
                    {
                        oldDegree = lPhenologicalStage.GetAverageDegree();
                    }
                    if (lPhenologicalStage.Stage.Equals(newStage))
                    {
                        newDegree = lPhenologicalStage.GetAverageDegree();
                    }
                    if (newDegree != 0 && oldDegree != 0)
                    {
                        lReturn = newDegree - oldDegree;
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in IrrigationSystem.calculateDegreeStageDifference " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Public Methods

        #region Agriculture

        #region Crop

        /// <summary>
        /// Return the list of Crops for a Region
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public List<Crop> FindCrop(Region pRegion)
        {
            List<Crop> lReturn = null;
            if(pRegion != null)
            {
                lReturn = new List<Crop>();
                foreach (Crop item in this.CropList)
                {
                    if(item.Region.Equals(pRegion))
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
        /// Return the list of Crops for a Specie
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public List<Crop> FindCrop(Specie pSpecie)
        {
            List<Crop> lReturn = null;
            if (pSpecie != null)
            {
                lReturn = new List<Crop>();
                foreach (Crop item in this.CropList)
                {
                    if (item.Specie.Equals(pSpecie))
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
        /// Find Crop by Name and Specie
        /// Name and Specie are the argument for Crop Equals
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public Crop FindCrop(Region pRegion, Specie pSpecie)
        {
            Crop lReturn = null;
            if (pRegion != null && pSpecie != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if (item.Region.Equals(pRegion) && item.Specie.Equals(pSpecie))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// IF Crop Exists in CropList return the Crop, else null
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop ExistCrop(Crop pCrop)
        {
            Crop lReturn = null;
            if (pCrop != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if (item.Equals(pCrop))
                    {
                        lReturn = item;
                        break;
                    }
                } 
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Crop if added because do not exist, 
        ///     if exist in the list, return the crop from the list.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pStageList"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pMinStageToConsiderETinHBCalculationId"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <param name="pStopIrrigationStageId"></param>
        /// <returns></returns>
        public Crop AddCrop(String pName, String pShortName, Region pRegion, Specie pSpecie, 
                        CropCoefficient pCropCoefficient, List<Stage> pStageList,
                        List<PhenologicalStage> pPhenologicalStageList, 
                        long pMinStageToConsiderETinHBCalculationId,
                        Double pMaxEvapotranspirationToIrrigate,
                        Double pMinEvapotranspirationToIrrigate, long pStopIrrigationStageId)
        {
            Crop lReturn = null;
            int lCropId = this.CropList.Count();
            Crop lCrop = new Crop(lCropId, pName, pShortName, pRegion.RegionId, pSpecie.SpecieId, 
                                pCropCoefficient.CropCoefficientId, pPhenologicalStageList,
                                pMinStageToConsiderETinHBCalculationId,
                                pMaxEvapotranspirationToIrrigate, pMinEvapotranspirationToIrrigate,
                                pStopIrrigationStageId);
            lReturn = ExistCrop(lCrop);
            if (lReturn == null)
            {
                this.CropList.Add(lCrop);
                lReturn = lCrop;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Crop if added because do not exist, 
        ///     if exist in the list, return the crop from the list.
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop AddCrop(Crop pCrop)
        {
            Crop lReturn = null;
            int lCropId = this.CropList.Count();
            lReturn = ExistCrop(pCrop);
            if (lReturn == null)
            {
                pCrop.CropId = lCropId;
                this.CropList.Add(pCrop);
                lReturn = pCrop;
            }
            return lReturn;
        }

        
        /// <summary>
        /// Update the crop if exists in CropList, else return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pRegion"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pMinStageToConsiderETinHBCalculationId"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <param name="pStopIrrigationStageId"></param>
        /// <returns></returns>
        public Crop UpdateCrop(String pName, String pShortName, Region pRegion, Specie pSpecie,
                        CropCoefficient pCropCoefficient, List<PhenologicalStage> pPhenologicalStageList, 
                        long pMinStageToConsiderETinHBCalculationId,
                        Double pMaxEvapotranspirationToIrrigate, Double pMinEvapotranspirationToIrrigate,
                        long pStopIrrigationStageId)
        {
            Crop lReturn = null;
            Crop lCrop = new Crop(0, pName, pShortName, pRegion.RegionId, pSpecie.SpecieId, 
                            pCropCoefficient.CropCoefficientId, pPhenologicalStageList,
                            pMinStageToConsiderETinHBCalculationId,
                            pMaxEvapotranspirationToIrrigate, pMinEvapotranspirationToIrrigate,
                            pStopIrrigationStageId);
            lReturn = ExistCrop(lCrop);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Region = pRegion;
                lReturn.Specie = pSpecie;
                lReturn.CropCoefficient = pCropCoefficient;
                lReturn.UpdatePhenologicalStageList(pPhenologicalStageList);
                lReturn.MinStageToConsiderETinHBCalculationId = pMinStageToConsiderETinHBCalculationId;
                lReturn.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
                lReturn.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
                lReturn.StopIrrigationStageId = pStopIrrigationStageId;
            }
            return lReturn;
        }

        /// <summary>
        /// Add Phenological Stage to Crop, if exist it return it.
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pInitialPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage AddPhenologicalStageToCrop(Crop pCrop, PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;
            if(pPhenologicalStage != null && pCrop != null)
            {
                lReturn = pCrop.ExistPhenologicalStage(pPhenologicalStage);
                if (lReturn == null)
                {
                    pCrop.PhenologicalStageList.Add(pPhenologicalStage);
                    lReturn = pPhenologicalStage;
                }
            }
            return lReturn;
        }

        #endregion

        #region Soil

        /// <summary>
        /// Find a Soil by Name and Location
        /// Name and Location are the argument for Soil Equals
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public Soil FindSoil(String pName, long pPositionId)
        {
            Soil lReturn = null;
            if (!String.IsNullOrEmpty(pName) && pPositionId != 0)
            {
                foreach (Soil item in this.SoilList)
                {
                    if (item.Name.Equals(pName) && item.PositionId.Equals(pPositionId))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Soil Exist in SoilList return the Soil, else null
        /// </summary>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public Soil ExistSoil(Soil pSoil)
        {
            Soil lReturn = null;
            if (pSoil != null)
            {
                foreach (Soil item in this.SoilList)
                {
                    if (item.Equals(pSoil))
                    {
                        lReturn = item;
                        break;
                    }
                } 
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Soil if added because do not exist,
        ///     if exist in the list, return the soil from the list.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <param name="pFarmId"></param>
        /// <returns></returns>
        public Soil AddSoil(String pName, String pShortName, String pDescription,
                        long pPositionId, DateTime pTestDate,
                        double pDepthLimit, long pFarmId)
        {
            Soil lReturn = null;
            int lIdSoil = this.SoilList.Count();
            Soil lSoil = new Soil(lIdSoil, pName, pShortName, pDescription,
                                pPositionId, pTestDate, pDepthLimit, pFarmId);
            if (ExistSoil(lSoil) == null)
            {
                this.SoilList.Add(lSoil);
                lReturn = lSoil;
            }
            return lReturn;
        }

        /// <summary>
        /// If the Soil exist in the list Update all the data of the Soil, 
        ///     if do not exist return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pLocation"></param>
        /// <param name="pTestDate"></param>
        /// <param name="pDepthLimit"></param>
        /// <param name="pFarmId"></param>
        /// <returns></returns>
        public Soil UpdateSoil(String pName, String pShortName, String pDescription,
                        long pPositionId, DateTime pTestDate,
                        double pDepthLimit, long pFarmId)
        {
            Soil lReturn = null;
            Soil lSoil = new Soil(0, pName, pShortName, pDescription,
                                pPositionId, pTestDate, pDepthLimit, pFarmId);
            lReturn = ExistSoil(lSoil);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Description = pDescription;
                lReturn.PositionId = pPositionId;
                lReturn.TestDate = pTestDate;
                lReturn.DepthLimit = pDepthLimit;
            }
            return lReturn;
        }

        #endregion

        #region Phenological Stage

        /// <summary>
        /// Find A Phenological Stage by Region, Specie and Stage
        /// </summary>
        /// <param name="pSpecieCycle"></param>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Region pRegion, 
                                            Specie pSpecie, Stage pStage)
        {
            PhenologicalStage lReturn = null;
            if (pRegion != null && pSpecie != null && pStage != null)
            {
                foreach (Crop lCropItem in this.CropList)
                {
                    if(lCropItem.Region.Equals(pRegion) && lCropItem.Specie.Equals(pSpecie))
                    {
                        foreach (PhenologicalStage item in lCropItem.PhenologicalStageList)
                        {
                            if (item.Stage.Equals(pStage))
                            {
                                lReturn = item;
                                break;
                            }
                        }
                    }
                }
            }
            return lReturn;
        }

        
        /// <summary>
        /// Adjustment of Phenology, calculating the degree stage difference
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pNewStage"></param>
        /// <param name="pCurrentDateTime"></param>
        public void AdjustmentPhenology(CropIrrigationWeather pCropIrrigationWeather, 
                                    Stage pNewStage, DateTime pDateTime)
        {
            foreach (CropIrrigationWeather lCropIrrigationWeather in this.CropIrrigationWeatherList)
            {
                if (lCropIrrigationWeather.Equals(pCropIrrigationWeather))
                {
                    pCropIrrigationWeather.AdjustmentPhenology(pNewStage, pDateTime);
                }
            }
        }

        #endregion

        #endregion

        #region Irrigation

        #region Bomb

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <returns></returns>
        public Bomb FindBomb(String pName, int pSerialNumber)
        {
            Bomb lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pSerialNumber != 0)
            {
                foreach (Bomb item in this.BombList)
                {
                    if(item.Name.Equals(pName) && item.SerialNumber.Equals(pSerialNumber))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pBomb"></param>
        /// <returns></returns>
        public Bomb ExistBomb(Bomb pBomb)
        {
            Bomb lResult = null;
            if(pBomb != null)
            {
                foreach (Bomb item in this.BombList)
                {
                    if(item.Equals(pBomb))
                    {
                        lResult = item;
                        break;
                    }
                }
            }
            return lResult;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pSerialNumber"></param>
        /// <param name="pServiceDate"></param>
        /// <param name="pPurchaseDate"></param>
        /// <param name="pPosition"></param>
        /// <param name="pFarmId"></param>
        /// <returns></returns>
        public Bomb AddBomb(String pName, String pShortName, String pSerialNumber, DateTime pServiceDate,
                            DateTime pPurchaseDate, long pPositionId, long pFarmId)
        {
            Bomb lReturn = null;
            long lIdBomb = this.BombList.Count();
            Bomb lBomb = new Bomb(lIdBomb, pName, pShortName, pSerialNumber, pServiceDate,
                            pPurchaseDate, pPositionId, pFarmId);
            lReturn = ExistBomb(lBomb);
            if (lReturn == null)
            {
                this.BombList.Add(lBomb);
                lReturn = lBomb;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pSerialNumber"></param>
        /// <param name="pServiceDate"></param>
        /// <param name="pPurchaseDate"></param>
        /// <param name="pLocation"></param>
        /// <param name="pFarmId"></param>
        /// <returns></returns>
        public Bomb UpdateBomb(String pName, String pShortName, String pSerialNumber, DateTime pServiceDate,
                            DateTime pPurchaseDate, long pPositionId, long pFarmId)
        {
            Bomb lReturn = null;
            Bomb lBomb = new Bomb(0, pName, pShortName, pSerialNumber, pServiceDate,
                            pPurchaseDate, pPositionId, pFarmId);
            lReturn = ExistBomb(lBomb);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.ShortName = pShortName;
                lReturn.SerialNumber = pSerialNumber;
                lReturn.ServiceDate = pServiceDate;
                lReturn.PurchaseDate = pPurchaseDate;
                lReturn.PositionId = pPositionId;
                lReturn.FarmId = pFarmId;
            }
            return lReturn;
        }


        #endregion

        #region IrrigationUnit

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pLocation"></param>
        /// <param name="pIrrigationType"></param>
        /// <returns></returns>
        public IrrigationUnit FindIrrigationUnit(String pName, long pPositionId,
                                                String pIrrigationType)
        {
            IrrigationUnit lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pPositionId != 0 
                                    && !String.IsNullOrEmpty(pIrrigationType))
            {
                foreach (IrrigationUnit  item in this.IrrigationUnitList)
                {
                    if (item.Name.Equals(pName) && item.PositionId.Equals(pPositionId)
                        && item.IrrigationType.Equals(pIrrigationType))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <returns></returns>
        public IrrigationUnit ExistIrrigationUnit(IrrigationUnit pIrrigationUnit)
        {
            IrrigationUnit lReturn = null;
            if(pIrrigationUnit != null)
            {
                foreach (IrrigationUnit item in this.IrrigationUnitList)
	            {
                    if(item.Equals(pIrrigationUnit))
                    {
                        lReturn = item;
                        break;
                    }
	            }
            }
            return lReturn;
        }

        /// <summary>
        /// Add IrrigationUnit
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pBombId"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <returns></returns>
        public IrrigationUnit AddIrrigationUnit(String pName, String pShortName, 
                                                Utils.IrrigationUnitType pIrrigationType,
                                                Double pIrrigationEfficiency, 
                                                List<Pair<DateTime, double>>  pIrrigationList, 
                                                Double pSurface, long pBombId, long pPositionId,
                                                Double pPredeterminatedIrrigationQuantity)
        {
            IrrigationUnit lReturn = null;
            long lIrrigationUnitId = this.irrigationUnitList.Count();
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(lIrrigationUnitId, pName, pShortName, 
                                                pIrrigationType, pIrrigationEfficiency, pIrrigationList, 
                                                pSurface, pBombId, pPositionId, pPredeterminatedIrrigationQuantity);
            lReturn = ExistIrrigationUnit(lIrrigationUnit);
            if(lReturn == null)
            {
                this.IrrigationUnitList.Add(lIrrigationUnit);
                lReturn = lIrrigationUnit;
            }
            return lReturn;
        }

        /// <summary>
        /// Update Irrigation Unit if Exists
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pBombId"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <returns></returns>
        public IrrigationUnit UpdateIrrrigationUnit(String pName, String pShortName, 
                                                Utils.IrrigationUnitType pIrrigationType,
                                                Double pIrrigationEfficiency,
                                                List<Pair<DateTime, double>> pIrrigationList,
                                                Double pSurface, long pBombId, long pPositionId,
                                                Double pPredeterminatedIrrigationQuantity)
        {
            IrrigationUnit lReturn = null;
            IrrigationUnit lIrrigationUnit = new IrrigationUnit(0, pName, pShortName, pIrrigationType,
                                                pIrrigationEfficiency, pIrrigationList, 
                                                pSurface, pBombId, pPositionId,
                                                pPredeterminatedIrrigationQuantity);
            lReturn = ExistIrrigationUnit(lIrrigationUnit);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.ShortName = pShortName;
                lReturn.IrrigationType = pIrrigationType;
                lReturn.IrrigationEfficiency = pIrrigationEfficiency;
                lReturn.IrrigationList = pIrrigationList;
                lReturn.Surface = pSurface;
                lReturn.BombId = pBombId;
                lReturn.PositionId = pPositionId;
                lReturn.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            }
            return lReturn;
        }

        #endregion

        #endregion

        #region Language


        /// <summary>
        /// Find Language by Id, if not exists, return null
        /// </summary>
        /// <param name="pPositionId"></param>
        /// <returns></returns>
        public Language.Language FindLanguage(long pLanguageId)
        {
            Language.Language lReturn = null;
            if (pLanguageId < this.LanguageList.Count())
            {
                foreach (Language.Language item in this.LanguageList)
                {
                    if (item.LanguageId == pLanguageId)
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Language exist in List return the Language, 
        /// else return null
        /// </summary>
        /// <param name="pLanguage"></param>
        /// <returns></returns>
        public Language.Language ExistLanguage(Language.Language pLanguage)
        {
            Language.Language lReturn = null;
            if (pLanguage != null)
            {
                foreach (Language.Language item in this.LanguageList)
                {
                    if (item.Equals(pLanguage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Language and return it, 
        /// if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Language.Language AddLanguage(String pName)
        {
            Language.Language lReturn = null;
            long lLanguageId = this.LanguageList.Count();
            Language.Language lLanguage = new Language.Language(lLanguageId, pName);
            lReturn = ExistLanguage(lLanguage);
            if(lReturn == null)
            {
                this.LanguageList.Add(lLanguage);
                lReturn = lLanguage;
            }
            return lReturn;
        }

        #endregion

        #region Localization

        #region Position

        /// <summary>
        /// Find Position by Name, if not exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Position FindPosition(String pName)
        {
            Position lReturn = null;
            
            if(!String.IsNullOrEmpty(pName))
            {
                foreach (Position item in this.PositionList)
                {
                    if(item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Find Position by Id, if not exists, return null
        /// </summary>
        /// <param name="pPositionId"></param>
        /// <returns></returns>
        public Position FindPosition(long pPositionId)
        {
            Position lReturn = null;
            if(pPositionId < this.PositionList.Count())
            {
                foreach (Position item in this.PositionList)
                {
                    if(item.PositionId == pPositionId)
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Position exist in List return the Position, 
        /// else return null
        /// </summary>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public Position ExistPosition(Position pPosition)
        {
            Position lReturn = null;
            foreach (Position item in this.PositionList)
            {
                if(item.Equals(pPosition))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a Position and return it, 
        /// if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public Position AddPosition (String pName, Double pLatitude, Double pLongitude)
        {
            Position lReturn = null;
            long lPositionId = this.PositionList.Count();
            Position lPosition = new Position(lPositionId, pName, pLatitude, pLongitude);

            if (ExistPosition(lPosition) == null)
            {
                this.PositionList.Add(lPosition);
                lReturn = lPosition;
            }
            return lReturn;
        }

        /// <summary>
        /// Update Position Name, Latitude and Longitude,
        /// if not exists return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public Position UpdatePosition(String pName, Double pLatitude, Double pLongitude)
        {
            Position lReturn = null;
            Position lPosition = null;

            lPosition = new Position(0, pName, pLatitude, pLongitude);
            lReturn = this.ExistPosition(lPosition);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Latitude = pLatitude;
                lReturn.Longitude = pLongitude;
            }
            return lReturn;
        }

        #endregion

        #region City

        /// <summary>
        /// Find City by Name and Position, if not exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City FindCity(String pName, Position pPosition)
        {
            City lReturn = null;
            if(!String.IsNullOrEmpty(pName) && pPosition != null)
            {
                foreach (City item in this.CityList)
                {
                    if(item.Name.Equals(pName) && item.Position.Equals(pPosition))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Find City by Id, if not exists, return null
        /// </summary>
        /// <param name="pCityId"></param>
        /// <returns></returns>
        public City FindCity(long pCityId)
        {
            City lReturn = null;
            if (pCityId < this.CityList.Count())
            {
                foreach (City item in this.CityList)
                {
                    if (item.CityId == pCityId)
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If City exist in List return the City, 
        /// else return null
        /// </summary>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City ExistCity (City pCity)
        {
            City lReturn = null;
            foreach (City item in this.CityList)
            {
                if(item.Equals(pCity))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a City and return it, 
        /// if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City AddCity(String pName, Position pPosition,
                            Country pCountry)
        {
            City lReturn = null;
            long lCityId = this.CityList.Count();
            City lCity = new City(lCityId, pName, pPosition, pCountry);
            
            if (ExistCity(lCity) == null 
                && pPosition != null)
            {
                this.CityList.Add(lCity);
                lReturn = lCity;
            }
            return lReturn;
        }

        /// <summary>
        /// Add a City to Country and return it, 
        /// if do not exists returns null,
        /// if exists in Country, do not add it again.
        /// </summary>
        /// <param name="pCountry"></param>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public City AddCityToCountry(Country pCountry, City pCity)
        {
            City lReturn = null;
            if(pCountry != null)
            {
                lReturn = this.ExistCity(pCity);
                if (lReturn != null)
                {
                    if(pCountry.ExistCity(pCity) == null)
                    {
                        pCountry.AddCity(pCity);
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update City Name and Position Id, 
        /// if not exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPosition"></param>
        /// <returns></returns>
        public City UpdateCity(String pName, Position pPosition,
                                Country pCountry)
        {
            City lReturn = null;
            City lCity = null;
            
            lCity = new City(0, pName, pPosition, pCountry);
            lReturn = ExistCity(lCity);
            if(lReturn != null)
            {
                lReturn.Name= pName;
                lReturn.PositionId = pPosition.PositionId;
                lReturn.Position = pPosition;
                lReturn.CountryId = pCountry.CountryId;
                lReturn.Country = pCountry;
            }
            return lReturn;
        }

        #endregion

        #region Country

        /// <summary>
        /// Find Country by Name, if not exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Country FindCountry(String pName)
        {
            Country lReturn = null;
            if(!String.IsNullOrEmpty(pName))
            {
                foreach (Country item in this.CountryList)
                {
                    if(item.Name.Equals(pName))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// If Country exist in List return the Country, 
        /// else return null
        /// </summary>
        /// <param name="pCountry"></param>
        /// <returns></returns>
        public Country ExistCountry(Country pCountry)
        {
            Country lReturn = null;
            if (pCountry != null)
            {
                foreach (Country item in this.CountryList)
                {
                    if (item.Equals(pCountry))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Country and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCapitalId"></param>
        /// <param name="pLanguageId"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Country AddCountry(String pName, long pCapitalId, 
                                long pLanguageId,
                                List<City> pCityList, List<Region> pRegionList)
        {
            Country lReturn = null;
            long lIdCountry = this.CountryList.Count();
            Country lCountry = null;
            City lCity = null;
            Language.Language lLanguage = null;

            lCity = this.FindCity(pCapitalId);
            lLanguage = this.FindLanguage(pLanguageId);
            if (!String.IsNullOrEmpty(pName) 
                && lCity != null && lLanguage != null)
            {
                if (pCityList == null || pRegionList == null)
                {
                    lCountry = new Country(lIdCountry, pName, lLanguage, lCity);
                }
                else
                {
                    lCountry = new Country(lIdCountry, pName, pLanguageId, pCapitalId,
                                            pCityList, pRegionList);
                }
                //Add Capital city to the list in Country, if exists will not repeat
                lCountry.AddCity(lCity);
                if (ExistCountry(lCountry) == null)
                {
                    this.CountryList.Add(lCountry);
                    lReturn = lCountry;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update Country Name, Language, Capital City, CityList, RegionList
        /// if not exist in list, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCapital"></param>
        /// <param name="pLanguage"></param>
        /// <param name="pCityList"></param>
        /// <param name="pRegionList"></param>
        /// <returns></returns>
        public Country UpdateCountry(String pName, long pCapitalId, long pLanguageId, 
                                List<City> pCityList, List<Region> pRegionList)
        {
            Country lReturn = null;
            Country lCountry = new Country(0, pName, pLanguageId, pCapitalId, pCityList, pRegionList);
            lReturn = ExistCountry(lCountry);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.LanguageId = pLanguageId;
                lReturn.CapitalId = pCapitalId;
                lReturn.CityList = pCityList;
                lReturn.RegionList = pRegionList;
            }
            return lReturn;
        }

        #endregion

        #region Farm

        /// <summary>
        /// If Farm exist in List return the Farm, 
        /// else return null
        /// </summary>
        /// <param name="pFarm"></param>
        /// <returns></returns>
        public Farm ExistFarm(Farm pFarm)
        {
            Farm lReturn = null;
            foreach (Farm item in this.FarmList)
            {
                if(item.Equals(pFarm))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Farm and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pAddress"></param>
        /// <param name="pCompany"></param>
        /// <param name="pPhone"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pHas"></param>
        /// <param name="pWeatherStation"></param>
        /// <param name="pSoilList"></param>
        /// <param name="pBombList"></param>
        /// <param name="pIrrigationUnitList"></param>
        /// <param name="pCityId"></param>
        /// <param name="pUserList"></param>
        /// <returns></returns>
        public Farm AddFarm(String pName, String pAddress, String pCompany, 
                        String pPhone, long pPositionId, int pHas, 
                        WeatherStation pWeatherStation, List<Soil> pSoilList,
                        List<Bomb> pBombList, List<IrrigationUnit> pIrrigationUnitList, 
                        long pCityId, List<UserFarm> pUserFarmList)
        {
            Farm lReturn = null;
            long lFarmId = this.FarmList.Count();
            Farm lFarm = new Farm(lFarmId, pName, pCompany, pAddress, pPhone,
                            pPositionId, pHas, pWeatherStation.WeatherStationId,
                            pSoilList, pBombList, pIrrigationUnitList,
                            pCityId, pUserFarmList);
            if(ExistFarm(lFarm) == null)
            {
                this.FarmList.Add(lFarm);
                lReturn = lFarm;
            }
            return lReturn;
        }

        /// <summary>
        /// Update Farm, if not exists return null.
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pCompany"></param>
        /// <param name="pAddress"></param>
        /// <param name="pPhone"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pHas"></param>
        /// <param name="pWeatherStation"></param>
        /// <param name="pSoilList"></param>
        /// <param name="pBombList"></param>
        /// <param name="pIrrigationUnitList"></param>
        /// <param name="pCityId"></param>
        /// <param name="pUserFarmList"></param>
        /// <returns></returns>
        public Farm UpdateFarm(String pName, String pCompany, String pAddress, 
                        String pPhone, long pPositionId, int pHas, 
                        WeatherStation pWeatherStation, List<Soil> pSoilList, 
                        List<Bomb> pBombList, List<IrrigationUnit> pIrrigationUnitList,
                        long pCityId, List<UserFarm> pUserFarmList)
        {
            Farm lReturn = null;
            Farm lFarm = new Farm(0, pName, pCompany, pAddress, pPhone,
                            pPositionId, pHas, pWeatherStation.WeatherStationId,
                            pSoilList, pBombList, pIrrigationUnitList, 
                            pCityId, pUserFarmList);
            lReturn = ExistFarm(lFarm);
            if(lReturn != null)
            {
                lReturn.Name= pName;
                lReturn.Company = pCompany;
                lReturn.Address = pAddress;
                lReturn.Phone = pPhone;
                lReturn.PositionId = pPositionId;
                lReturn.Has = pHas;
                lReturn.WeatherStation = pWeatherStation;
                lReturn.SoilList = pSoilList;
                lReturn.BombList = pBombList;
                lReturn.IrrigationUnitList = pIrrigationUnitList;
                lReturn.CityId = pCityId;
                lReturn.UserFarmList = pUserFarmList;
            }
            return lReturn;
        }

        #endregion

        #region Location

        /// <summary>
        /// If Location exist in List return the Location, 
        /// else return null
        /// </summary>
        /// <param name="pLocation"></param>
        /// <returns></returns>
        public Location ExistLocation(Location pLocation)
        {
            Location lReturn = null;
            if(pLocation != null)
            {
                foreach (Location item in this.LocationList)
                {
                    if(item.Equals(pLocation))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Location and return it, if exists returns null.
        /// Position, Country, Region and City has to be not null.
        /// </summary>
        /// <param name="pPosition"></param>
        /// <param name="pCountry"></param>
        /// <param name="pRegion"></param>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public Location AddLocation(Position pPosition, Country pCountry, 
                            Region pRegion, City pCity)
        {
            Location lReturn = null;
            long lIdLocation = this.LocationList.Count();
            if (pPosition != null && pCountry != null && pRegion != null
                            && pCity != null)
            {
                Location lLocation = new Location(lIdLocation, pPosition, pCountry,
                                                  pRegion, pCity);
                if (ExistLocation(lLocation) == null)
                {
                    this.LocationList.Add(lLocation);
                    lReturn = lLocation;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Update Location Position, Country, Region and City.
        /// If do not exists, return null.
        /// Position, Country, Region and City has to be not null.
        /// </summary>
        /// <param name="pPosition"></param>
        /// <param name="pCountry"></param>
        /// <param name="pRegion"></param>
        /// <param name="pCity"></param>
        /// <returns></returns>
        public Location UpdateLocation(Position pPosition, Country pCountry,
                            Region pRegion, City pCity)
        {
            Location lReturn = null;
            if (pPosition != null && pCountry != null && pRegion != null
                && pCity != null)
            {
                Location lLocation = new Location(0, pPosition, pCountry,
                                              pRegion, pCity);
                lReturn = ExistLocation(lLocation);
                if (lReturn != null)
                {
                    lReturn.Position = pPosition;
                    lReturn.Country = pCountry;
                    lReturn.Region = pRegion;
                    lReturn.City = pCity;
                }
            }
            return lReturn;
        }

        #endregion

        #region Region

        /// <summary>
        /// If Region Exists in List return the Region, else null
        /// </summary>
        /// <param name="pRegionList"></param>
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
        /// Add a Region to List if not exists,
        /// if exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pSpecieList"></param>
        /// <param name="pSpecieCycleList"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pTemperatureDataList"></param>
        /// <returns></returns>
        public Region AddRegion(String pName, long pPositionId, List<Specie> pSpecieList,
                                List<SpecieCycle> pSpecieCycleList, 
                                List<EffectiveRain> pEffectiveRainList,
                                List<TemperatureData> pTemperatureDataList)
        {
            Region lReturn = null;
            long lRegionId = this.RegionList.Count();
            Region lRegion = null;

            if (pEffectiveRainList == null || pSpecieList == null)
            {
                lRegion = new Region(lRegionId, pName, pPositionId);
            }
            else
            {
                lRegion = new Region(pName, pPositionId, pSpecieList,
                                     pSpecieCycleList, pEffectiveRainList, 
                                     pTemperatureDataList);
            }

            if (ExistRegion(lRegion) == null)
            {
                this.RegionList.Add(lRegion);
                lReturn = lRegion;
            }
            return lReturn;
        }

        /// <summary>
        /// Update the region if exists in List, else return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pSpecieList"></param>
        /// <param name="pSpecieCycleList"></param>
        /// <param name="pEffectiveRainList"></param>
        /// <param name="pTemperatureDataList"></param>
        /// <returns></returns>
        public Region UpdateRegion(String pName, long pPositionId, List<Specie> pSpecieList,
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

        #region Management

        #region Date of Reference

        /// <summary>
        /// Set date of reference
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public DateTime SetDateOfReference (DateTime pDateOfReference)
        {
            DateTime lReturn;
            
            if (pDateOfReference != null)
            {
                this.dateOfReference = pDateOfReference;
            }

            lReturn = pDateOfReference;
            return lReturn;
        }

        /// <summary>
        /// Add days to Date of Reference
        /// </summary>
        /// <param name="pDays"></param>
        /// <returns></returns>
        public DateTime AddDayToDateOfReference(int pDays)
        {
            DateTime lReturn;

            this.dateOfReference = this.DateOfReference.AddDays(pDays);

            lReturn = this.DateOfReference;
            return lReturn;
        }

        /// <summary>
        /// Add hours to Date of Reference
        /// </summary>
        /// <param name="pHour"></param>
        /// <returns></returns>
        public DateTime AddHourToDateOfReference(int pHour)
        {
            DateTime lReturn;

            this.dateOfReference = this.DateOfReference.AddHours(pHour);

            lReturn = this.DateOfReference;
            return lReturn;
        }

        #endregion

        #region CropIrrigationWeather

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public CropIrrigationWeather ExistCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather)
        {
            CropIrrigationWeather lReturn = null;
            if(pCropIrrigationWeather != null)
            {
                foreach (CropIrrigationWeather item in this.CropIrrigationWeatherList)
                {
                    if(item.Equals(pCropIrrigationWeather))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add Crop Irrigation Weather to System list
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public CropIrrigationWeather AddCropIrrigationWeather(IrrigationUnit pIrrigationUnit, Crop pCrop,
                                                    WeatherStation pMainWeatherStation, 
                                                    WeatherStation pAlternativeWeatherStation,
                                                    Double pPredeterminatedIrrigationQuantity, 
                                                    Position pPosition, Soil pSoil)
        {
            CropIrrigationWeather lReturn = null;
            long lCropIrrigationWeatherId = 0;
            CropIrrigationWeather lCropIrrigationWeather = null;
            CropInformationByDate lCropInformationByDate = null;
            
            lCropIrrigationWeatherId = this.CropIrrigationWeatherList.Count();
            lCropIrrigationWeather = new CropIrrigationWeather();
            lCropIrrigationWeather.CropIrrigationWeatherId = lCropIrrigationWeatherId;
            lCropIrrigationWeather.IrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
            lCropIrrigationWeather.CropId = pCrop.CropId;
                
            if (pCrop != null)
            {
                lCropInformationByDate = new CropInformationByDate();
                lCropInformationByDate.CropCoefficientId = pCrop.CropCoefficient.CropCoefficientId;
                lCropInformationByDate.PhenologicalStageList = pCrop.PhenologicalStageList;
                lCropInformationByDate.SpecieId = pCrop.Specie.SpecieId;
                lCropIrrigationWeather.CropInformationByDate = lCropInformationByDate;
                
            }
            lCropIrrigationWeather.MainWeatherStationId = pMainWeatherStation.WeatherStationId;
            lCropIrrigationWeather.AlternativeWeatherStationId = pAlternativeWeatherStation.WeatherStationId;
            lCropIrrigationWeather.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            lCropIrrigationWeather.PositionId = pPosition.PositionId;
            lCropIrrigationWeather.SoilId = pSoil.SoilId;
            
            lReturn = ExistCropIrrigationWeather(lCropIrrigationWeather);
            if(lReturn == null)
            {
                this.CropIrrigationWeatherList.Add(lCropIrrigationWeather);
                lReturn = lCropIrrigationWeather;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pCrop"></param>
        /// <param name="pMainWeatherStation"></param>
        /// <param name="pAlternativeWeatherStation"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        /// <param name="pInitialPhenologicalStage"></param>
        /// <param name="pLocation"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pHarvestDate"></param>
        /// <param name="pSoil"></param>
        /// <returns></returns>
        public CropIrrigationWeather UpdateCropIrrigationWeather(IrrigationUnit pIrrigationUnit, Crop pCrop,
                                                    WeatherStation pMainWeatherStation, WeatherStation pAlternativeWeatherStation,
                                                    Double pPredeterminatedIrrigationQuantity, 
                                                    Position pPosition, Soil pSoil)
        {
            CropIrrigationWeather lReturn = null;
            CropIrrigationWeather lCropIrrigationWeather = new CropIrrigationWeather();
            lCropIrrigationWeather.IrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
            lCropIrrigationWeather.CropId = pCrop.CropId;
            lCropIrrigationWeather.MainWeatherStationId = pMainWeatherStation.WeatherStationId;
            lCropIrrigationWeather.AlternativeWeatherStationId = pAlternativeWeatherStation.WeatherStationId;
            lCropIrrigationWeather.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
            lCropIrrigationWeather.PositionId= pPosition.PositionId;
            lCropIrrigationWeather.SoilId = pSoil.SoilId;
                                                    
            lReturn = ExistCropIrrigationWeather(lCropIrrigationWeather);
            if(lReturn != null)
            {
                lReturn.IrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
                lReturn.CropId = pCrop.CropId;
                lReturn.MainWeatherStationId = pMainWeatherStation.WeatherStationId;
                lReturn.AlternativeWeatherStationId = pAlternativeWeatherStation.WeatherStationId;
                lReturn.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
                lReturn.PositionId = pPosition.PositionId;
                lReturn.SoilId = pSoil.SoilId;

            }
            return lReturn;
        }

        /// <summary>
        /// Add to the system a new CropIrrigationWeather
        /// Inicialize CropIrrigationWeather
        /// and add the first DailyRecord
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public CropIrrigationWeather InicializeCropIrrigationWeather(CropIrrigationWeather pCropIrrigationWeather,
                                                                    PhenologicalStage pInitialPhenologicalStage, 
                                                                    DateTime pSowingDate, DateTime pHarvestDate,
                                                                    Utils.CalculusOfPhenologicalStage pCalculusOfPhenologicalStage) 
        {
            CropIrrigationWeather lReturn = null;
            List<EffectiveRain> lEffectiveRain;
            double lHydricBalance;
            try
            {

                pCropIrrigationWeather.PhenologicalStageId = pInitialPhenologicalStage.PhenologicalStageId;
                pCropIrrigationWeather.SowingDate = pSowingDate;
                pCropIrrigationWeather.CropInformationByDate.SowingDate = pSowingDate;
                pCropIrrigationWeather.HarvestDate = pHarvestDate;

                //Get Effective Rain List from Region
                lEffectiveRain = this.getEffectiveRainList(pCropIrrigationWeather.Crop.Region);
                
                //Get Initial Hydric Balance
                lHydricBalance = pCropIrrigationWeather.GetInitialHydricBalance();
                pCropIrrigationWeather.HydricBalance = lHydricBalance;

                //Set Calculus Method for Phenological Adjustment
                pCropIrrigationWeather.SetCalculusMethodForPhenologicalAdjustment(pCalculusOfPhenologicalStage);
                
                //Create the initial registry
                this.AddDailyRecordToList(pCropIrrigationWeather, pSowingDate, "Initial registry", pSowingDate);
                
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in IrrigationSystem.InicializeCropIrrigationWeather " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Colect the weather data, lIrrigationItem data and lRainItem data and derive the cretion of a new daily record
        /// This method verify the need of lIrrigationItem, and then recreate the daily record
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pObservations"></param>
        /// <returns></returns>
        public bool AddDailyRecordToList(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime, String pObservations,
                                        DateTime pDateOfReference)
        {
            bool lReturn = false;
            WeatherData lWeatherData = null;
            

            try
            {
                //Controlo que la CropIrrigationWeather exista y la fecha no sean null
                if (this.CropIrrigationWeatherList.Contains(pCropIrrigationWeather) && pDateTime != null)
                {
                    //Get Data Weather for the available Weather Station (Main or Alternative)
                    lWeatherData = pCropIrrigationWeather.GetWeatherDataFromAvailableWeatherStation(pDateTime);

                    // Si hay datos de estacion meteorologica puedo seguir
                    if (lWeatherData != null)
                    {
                        if(pCropIrrigationWeather.CalculusMethodForPhenologicalAdjustment.Equals(
                                            Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays))
                        {
                            pCropIrrigationWeather.AddDailyRecordAccordingGrowinDegreeDays(pDateTime, pObservations, lWeatherData, pDateOfReference);
                        }

                        if (pCropIrrigationWeather.CalculusMethodForPhenologicalAdjustment.Equals(
                                            Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing))
                        {
                            pCropIrrigationWeather.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservations, lWeatherData, pDateOfReference);
                        }

                        //Luego de que agrego un registro verifico si hay que regar.
                        //Si es asi se agrega el riego a la lista y se reingresa el registro diario. 
                        this.verifyNeedForIrrigation(pCropIrrigationWeather, pDateTime, pDateOfReference);
                    }
                    else 
                    {
                        
                        pCropIrrigationWeather.AddDailyRecordAccordingDaysAfterSowing(pDateTime, pObservations, lWeatherData, pDateOfReference);
                        
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in IrrigationSystem.addDailyRecordToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;

        }

        /// <summary>
        /// Verify the need for irrigantion by the need of water
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pCurrentDateTime"></param>
        public void verifyNeedForIrrigation(CropIrrigationWeather pCropIrrigationWeather, DateTime pDateTime,
                                            DateTime pDateOfReference)
        {
            Pair<double, Utils.WaterInputType> lNeedForIrrigationPair;
            double lQuantityOfWaterToIrrigate;
            Utils.WaterInputType lTypeOfIrrigation;

            lNeedForIrrigationPair = this.IrrigationCalculus.HowMuchToIrrigate(pCropIrrigationWeather);
            lQuantityOfWaterToIrrigate = lNeedForIrrigationPair.First;
            lTypeOfIrrigation = lNeedForIrrigationPair.Second;

            if (lQuantityOfWaterToIrrigate > 0)
            {
                this.AddOrUpdateIrrigationDataToList(pCropIrrigationWeather, pDateTime, lNeedForIrrigationPair, false);
                this.AddDailyRecordToList(pCropIrrigationWeather, pDateTime, pDateTime.ToShortDateString(), pDateOfReference);
            }
        }

        

        #endregion

        #region Security 
        #endregion

        #region Utitilities

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <returns></returns>
        public String printDailyRecordsList(CropIrrigationWeather pCropIrrigationWeather)
        {
            String lReturn = Environment.NewLine + "DAILY RECORDS" + Environment.NewLine ;
            lReturn += Environment.NewLine +Environment.NewLine;

            foreach (DailyRecord lDailyrecord in pCropIrrigationWeather.DailyRecordList)
            {
                lReturn += lDailyrecord.ToString() + Environment.NewLine;
            }
            //Add all the messages and titles to print the daily records
            pCropIrrigationWeather.AddToPrintDailyRecords(pCropIrrigationWeather.CropIrrigationWeatherId );
            return lReturn;
        }

        
        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <returns></returns>
        public String printWeatherDataList(WeatherStation pWeatherStation)
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherData lWeatherData in pWeatherStation.WeatherDataList)
            {
                lReturn += lWeatherData.ToString() + Environment.NewLine;
            }
            return lReturn;
        }

        #endregion

        #region Water
        #endregion

        #region Weather

        #region WeatherData

        /// <summary>
        /// Return the WeatherData from WeatherStation and Date (depends on the hour)
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <param name="pCurrentDateTime"></param>
        /// <returns></returns>
        public WeatherData GetWeatherDataByWeatherStationAndDate(WeatherStation pWeatherStation, DateTime pDateTime)
        {
            WeatherData lReturn = null;

            lReturn = pWeatherStation.FindWeatherData(pDateTime);

            return lReturn;
        }

        /// <summary>
        /// TODO explain method
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pSolarRadiation"></param>
        /// <param name="pTemMax"></param>
        /// <param name="pTemMin"></param>
        /// <param name="pEvapotranspiration"></param>
        /// <returns></returns>
        public void AddWeatherDataToList(WeatherStation pWeatherStation, DateTime pDateTime,
                                        Double pTemperature, Double pSolarRadiation, Double pTemMax,
                                        Double pTemMin, Double pEvapotranspiration, Double pWindSpeed,
                                        String pObservations, Utils.WeatherDataInputType pWeatherDataInputType)
        {
            
            try
            {
                WeatherData lWeatherData;
                
                lWeatherData = pWeatherStation.AddWeatherData(pDateTime, pTemperature, pTemMax, pTemMin, 
                                                        pSolarRadiation, pEvapotranspiration, pWindSpeed,
                                                        pObservations, pWeatherDataInputType);

                if(lWeatherData == null)
                {
                    pWeatherStation.UpdateWeatherData(pDateTime, pTemperature, pTemMax, pTemMin, 
                                                        pSolarRadiation, pEvapotranspiration, pWindSpeed,
                                                        pObservations, Utils.WeatherDataInputType.CodeInsert);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in IrrigationSystem.AddWeatherDataToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            
        }

        #endregion

        #region WeatherStation

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <returns></returns>
        public WeatherStation ExistWeatherStation (WeatherStation pWeatherStation)
        {
            WeatherStation lReturn = null;
            if(pWeatherStation != null)
            {
                foreach (WeatherStation item in this.WeatherStationList)
                {
                    if (item.Equals(pWeatherStation))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Create a new Weather Station from parameters,
        /// If exist return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pModel"></param>
        /// <param name="pStationType"></param>
        /// <param name="pDateOfInstallation"></param>
        /// <param name="pDateOfService"></param>
        /// <param name="pUpdateTime"></param>
        /// <param name="pWirelessTransmission"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pGiveET"></param>
        /// <param name="pWeatherDataType"></param>
        /// <param name="pWebAddress"></param>
        /// <returns></returns>
        public WeatherStation AddWeatherStation (String pName, String pModel, Utils.WeatherStationType pStationType,
                                DateTime pDateOfInstallation, DateTime pDateOfService, DateTime pUpdateTime, 
                                int pWirelessTransmission, long pPositionId, bool pGiveET, 
                                Utils.WeatherDataType pWeatherDataType, String pWebAddress)
        {
            WeatherStation lReturn = null;
            WeatherStation lWeatherStation = null;
            long lWeatherStationId = 0;
            List<WeatherData> lWeatherDataList = null;

            lWeatherStationId = this.WeatherStationList.Count();
            lWeatherDataList = new List<WeatherData>();
            lWeatherStation = new WeatherStation(lWeatherStationId, pName, pModel, 
                                pStationType, pDateOfInstallation, pDateOfService,
                                pUpdateTime, pWirelessTransmission, pPositionId, pGiveET,
                                lWeatherDataList, pWeatherDataType, pWebAddress);

            if(ExistWeatherStation(lWeatherStation) == null)
            {
                this.WeatherStationList.Add(lWeatherStation);
                lReturn = lWeatherStation;
            }

            return lReturn;
        }

        /// <summary>
        /// Update the weather station,
        /// if not exist, return null.
        /// </summary>
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
        /// <returns></returns>
        public WeatherStation UpdateWeatherStation(String pName, String pModel, Utils.WeatherStationType pStationType,
                                DateTime pDateOfInstallation, DateTime pDateOfService, DateTime pUpdateTime, 
                                int pWirelessTransmission, long pPositionId, bool pGiveET, 
                                List<WeatherData> pWeatherDataList, Utils.WeatherDataType pWeatherDataType, String pWebAddress)
        {
            WeatherStation lReturn = null;

            WeatherStation lWeatherStation = new WeatherStation(0, pName, pModel, pStationType, 
                                pDateOfInstallation, pDateOfService, pUpdateTime, pWirelessTransmission, 
                                pPositionId, pGiveET, pWeatherDataList, pWeatherDataType, pWebAddress);
            lReturn = ExistWeatherStation(lWeatherStation);
            if(lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Model = pModel;
                lReturn.StationType = pStationType;
                lReturn.DateOfInstallation = pDateOfInstallation;
                lReturn.DateOfService = pDateOfService;
                lReturn.UpdateTime = pUpdateTime;
                lReturn.WirelessTransmission = pWirelessTransmission;
                lReturn.PositionId = pPositionId;
                lReturn.GiveET = pGiveET;
                lReturn.WeatherDataList = pWeatherDataList;
                lReturn.WeatherDataType = pWeatherDataType;
                lReturn.WebAddress = pWebAddress;
            }

            return lReturn;
        }

        #endregion

        /// <summary>
        /// Add Irrigation Data. If there is a record of Irrigation, 
        /// it is updated adding the new rain as ExtraInput
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pIrrigationDate"></param>
        /// <param name="pQuantityOfWaterToIrrigateAndTypeOfIrrigation"></param>
        /// <param name="pIsExtraIrrigation"></param>
        /// <returns></returns>
        public void AddOrUpdateIrrigationDataToList(CropIrrigationWeather pCropIrrigationWeather,
                                                    DateTime pIrrigationDate, 
                                                    Pair<double, Utils.WaterInputType> pQuantityOfWaterToIrrigateAndTypeOfIrrigation, 
                                                    bool pIsExtraIrrigation)
        {
            Water.Irrigation lNewIrrigation = null;
            
            try
            {
                lNewIrrigation = pCropIrrigationWeather.GetIrrigationByDay(pIrrigationDate);
                //If there is not a registry then it is created 
                //If there is an Irrigation Registry it is updated 
                if (lNewIrrigation == null)
                {
                    lNewIrrigation = new Water.Irrigation();
                    lNewIrrigation.Date = pIrrigationDate;
                    if (pIsExtraIrrigation)
                    {
                        lNewIrrigation.ExtraInput = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                        lNewIrrigation.ExtraDate = pIrrigationDate;
                    }
                    else
                    {
                        lNewIrrigation.Input = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                        
                    }
                    // Set the type of lIrrigationItem. 
                    lNewIrrigation.Type = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.Second;
                    lNewIrrigation.CropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId;
                    pCropIrrigationWeather.IrrigationList.Add(lNewIrrigation);
                }
                else
                {
                    if (pIsExtraIrrigation)
                    {
                        lNewIrrigation.ExtraInput += pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                        lNewIrrigation.ExtraDate = pIrrigationDate;
                    }
                    else
                    {
                        lNewIrrigation.Input += pQuantityOfWaterToIrrigateAndTypeOfIrrigation.First;
                    }
                    // Override the type of lIrrigationItem. 
                    lNewIrrigation.Type = pQuantityOfWaterToIrrigateAndTypeOfIrrigation.Second;
                    lNewIrrigation.CropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in IrrigationSystem.AddOrUpdateIrrigationDataToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }

        }


        /// <summary>
        /// Add Rain Data. If there is a record of Rain, 
        /// it is updated adding the new rain as ExtraInput
        /// </summary>
        /// <param name="pCropIrrigationWeather"></param>
        /// <param name="pDate"></param>
        /// <param name="pOutput"></param>
        /// <returns></returns>
        public Rain  AddRainDataToList(CropIrrigationWeather pCropIrrigationWeather,
                                        DateTime pDate, double pInput)
        {
            Rain lNewRain = null;
            try
            {
                lNewRain = pCropIrrigationWeather.GetRain(pDate);
                if (lNewRain == null)
                {
                    lNewRain = new Rain();
                    lNewRain.Date = pDate;
                    lNewRain.Input = pInput;
                    lNewRain.CropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId;
                    pCropIrrigationWeather.RainList.Add(lNewRain);
                }
                else // If there is a Raub actualize the registry
                {
                    lNewRain.ExtraInput += pInput;
                    lNewRain.ExtraDate = pDate;
                    lNewRain.CropIrrigationWeatherId = pCropIrrigationWeather.CropIrrigationWeatherId;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in IrrigationSystem.AddRainDataToList " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }

            return lNewRain;

        }
        
        #endregion

        #endregion

        #region Overrides
        #endregion

    }
}