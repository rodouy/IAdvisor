using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Localization;

using NLog;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author: monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Describes a Crop in a Region of a Specie
    ///     
    /// References:
    ///     Region
    ///     Specie
    ///     CropCoefficient
    ///     Stage
    ///     PhenologicalStage
    ///     
    ///     
    /// Dependencies:
    ///     CropIrrigationWeather
    ///     EquipmentService
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropId long
    ///     - name String   
    ///     - region Region           
    ///     - specie Specie 
    ///     - 
    ///     - phenologicalStageList List<PhenologicalStage>
    ///     - cropCoefficient CropCoefficient
    ///     - density double
    ///     - maxEvapotranspirationToIrrigate double
    ///     
    /// 
    /// Methods:
    ///     - Crop()      -- constructor
    ///     - Crop(name, Specie, density, maxEvapotranspirationToIrrigate)  -- consturctor with parameters
    ///     - GetRegion(): Region
    ///     - GetSpecie(): Specie
    ///     - GetBaseTemperature(): Double
    ///     
    /// 
    /// </summary>
    public class Crop
    {
        #region Consts
        #endregion

        #region Fields

        public long cropId;
        private String name;
        private String shortName;
        private long regionId;
        private long specieId;
        private long cropCoefficientId;
        private List<Stage> stageList;
        private List<PhenologicalStage> phenologicalStageList;
        private List<DryMass> dryMassList;

        private long minStageToConsiderETinHBCalculationId;

        private Double maxEvapotranspirationToIrrigate;
        private Double minEvapotranspirationToIrrigate;

        private long stopIrrigationStageId;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties

        public long CropId
        {
            get { return cropId; }
            set { cropId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String ShortName
        {
            get { return shortName; }
            set { shortName = value; }
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

        public long CropCoefficientId
        {
            get { return cropCoefficientId; }
            set { cropCoefficientId = value; }
        }

        public virtual CropCoefficient CropCoefficient
        {
            get;
            set;
        }

        public List<Stage> StageList
        {
            get { return stageList; }
            set { stageList = value; }
        }

        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }

        public List<DryMass> DryMassList
        {
            get { return dryMassList; }
            set { dryMassList = value; }
        }

        public long MinStageToConsiderETinHBCalculationId
        {
            get { return minStageToConsiderETinHBCalculationId; }
            set { minStageToConsiderETinHBCalculationId = value; }
        }
        
        public virtual Stage MinStageToConsiderETinHBCalculation
        {
            get;
            set;
        }

        public Double MaxEvapotranspirationToIrrigate
        {
            get { return maxEvapotranspirationToIrrigate; }
            set { maxEvapotranspirationToIrrigate = value; }
        }

        public Double MinEvapotranspirationToIrrigate
        {
            get { return minEvapotranspirationToIrrigate; }
            set { minEvapotranspirationToIrrigate = value; }
        }

        public long StopIrrigationStageId
        {
            get { return stopIrrigationStageId; }
            set { stopIrrigationStageId = value; }
        }

        public virtual Stage StopIrrigationStage
        {
            get;
            set;
        }

        public int StopIrrigationStageOrder
        {
            get { return this.FindStageOrder(this.StopIrrigationStageId); }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Crop
        /// </summary>
        public Crop()
        {
            this.CropId = 0;
            this.Name = "noName";
            this.ShortName = "";
            this.RegionId = 0;
            this.SpecieId = 0;
            this.CropCoefficientId = 0;
            this.StageList = new List<Stage>();
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.DryMassList = new List<DryMass>();
            this.MinStageToConsiderETinHBCalculationId = 0;
            this.MaxEvapotranspirationToIrrigate = 0;
            this.MinEvapotranspirationToIrrigate = 0;
            this.StopIrrigationStageId = 0;
        }

        /// <summary>
        /// Constructor of Crop with minimun parameters
        /// </summary>
        /// <param name="pCropId"></param>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pRegionId"></param>
        /// <param name="pSpecieId"></param>
        /// <param name="pCropCoefficientId"></param>
        /// <param name="pMinStageToConsiderETinHBCalculationId"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <param name="pStopIrrigationStageId"></param>
        public Crop(long pCropId, String pName, String pShortName,
                    long pRegionId, long pSpecieId, long pCropCoefficientId,
                    long pMinStageToConsiderETinHBCalculationId,
                    Double pMaxEvapotranspirationToIrrigate, 
                    Double pMinEvapotranspirationToIrrigate, long pStopIrrigationStageId)
        {
            this.CropId = pCropId;
            this.Name = pName;
            this.ShortName = pShortName;
            this.RegionId = pRegionId;
            this.SpecieId = pSpecieId;
            this.CropCoefficientId = pCropCoefficientId;
            this.StageList = new List<Stage>();
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.DryMassList = new List<DryMass>();
            this.MinStageToConsiderETinHBCalculationId = pMinStageToConsiderETinHBCalculationId;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
            this.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
            this.StopIrrigationStageId = pStopIrrigationStageId;
        }

        /// <summary>
        /// Constructor of Crop with all parameters
        /// </summary>
        /// <param name="pCropId"></param>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pRegionId"></param>
        /// <param name="pSpecieId"></param>
        /// <param name="pCropCoefficientId"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pMinPhenologicalStageIdToConsiderETinHBCalculation"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <param name="pStopIrrigationStageId"></param>
        public Crop(long pCropId, String pName, String pShortName,
                    long pRegionId, long pSpecieId, long pCropCoefficientId,
                    List<PhenologicalStage> pPhenologicalStageList,
                    long pMinStageToConsiderETinHBCalculationId,       
                    Double pMaxEvapotranspirationToIrrigate,
                    Double pMinEvapotranspirationToIrrigate, long pStopIrrigationStageId)
        {
            
            this.CropId = pCropId;
            this.Name = pName;
            this.ShortName = pShortName;
            this.RegionId = pRegionId;
            this.SpecieId = pSpecieId;
            this.CropCoefficientId = pCropCoefficientId;
            this.StageList = this.getStageList(pPhenologicalStageList);
            this.PhenologicalStageList = pPhenologicalStageList;
            this.MinStageToConsiderETinHBCalculationId = pMinStageToConsiderETinHBCalculationId;
            this.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
            this.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
            this.StopIrrigationStageId = pStopIrrigationStageId;
        }

        #endregion

        #region Private Helpers

        /// <summary>
        /// Return the list of Stages from a list of Phenological Stages
        /// </summary>
        /// <param name="pPhenologicalStageList"></param>
        /// <returns></returns>
        private List<Stage> getStageList (List<PhenologicalStage> pPhenologicalStageList)
        {
            List<Stage> lReturn = null;
            if(pPhenologicalStageList != null)
            {
                lReturn = new List<Stage>();
                foreach (var item in pPhenologicalStageList)
                {
                    lReturn.Add(item.Stage);
                }
            }
            
            return lReturn;
        }

        #endregion

        #region Public Methods

        #region Temperature

        /// <summary>
        /// Return the Base Temperature for the Specie of the Crop
        /// </summary>
        /// <returns></returns>
        public double GetBaseTemperature()
        {
            Double lBaseTemperature = 0;

            lBaseTemperature = this.Specie.BaseTemperature;

            return lBaseTemperature;
        }

        /// <summary>
        /// Return the Stress Temperature for the Specie of the Crop
        /// </summary>
        /// <returns></returns>
        public double GetStressTemperature()
        {
            Double lStressTemperature = 0;

            lStressTemperature = this.Specie.StressTemperature;

            return lStressTemperature;
        }

        #endregion

        #region Stage

        /// <summary>
        /// New ID for StageList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewStageListId()
        {
            long lReturn = 1;

            if (this.StageList != null && this.StageList.Count > 0)
            {
                lReturn += this.StageList.Max(st => st.StageId);
            }

            return lReturn;
        }

        /// <summary>
        /// Get the initial Stage for the Crop
        /// </summary>
        /// <returns></returns>
        public Stage GetInitialStage()
        {
            Stage lReturn = null;

            if(this.StageList.Count() > 0)
            {
                lReturn = this.StageList[0];
            }

            return lReturn;
        }

        /// <summary>
        /// Find Stage by Name (Equals compare Property)
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Stage FindStage(String pName)
        {
            Stage lReturn = null;
            if (!String.IsNullOrEmpty(pName))
            {
                foreach (Stage item in this.StageList)
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
        /// If Stage exist in List return the Stage, 
        /// else return null
        /// </summary>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public Stage ExistStage(Stage pStage)
        {
            Stage lReturn = null;

            if (pStage != null)
            {
                foreach (Stage item in this.StageList)
                {
                    if (item.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Add a new Stage and return it, if exists returns null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <returns></returns>
        public Stage AddStage(String pName, String pShortName, String pDescription,
                                int pOrder)
        {
            Stage lReturn = null;

            long lStageId = this.GetNewStageListId();
            Stage lStage = new Stage(lStageId, pName, pShortName, pDescription, pOrder);

            if (ExistStage(lStage) == null)
            {
                this.StageList.Add(lStage);
                lReturn = lStage;
            }

            return lReturn;
        }

        /// <summary>
        /// Update an existing Stage, if not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDescription"></param>
        /// <returns></returns>
        public Stage UpdateStage(String pName, String pShortName, String pDescription,
                                int pOrder)
        {
            Stage lReturn = null;
            Stage lStage = new Stage(0, pName, pShortName, pDescription, pOrder);
            PhenologicalStage lPhenologicalStage;

            lReturn = ExistStage(lStage);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.ShortName = pShortName;
                lReturn.Description = pDescription;
                
                lPhenologicalStage = this.FindPhenologicalStage(lStage);
                if (lPhenologicalStage != null)
                {
                    lPhenologicalStage.UpdateStage(pName, pShortName, pDescription, pOrder);
                }
                else
                {
                    //TODO throw error "There is a Stage that not have the Phenological Stage!!. Error of Data."
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Set Stage and StageId to Stop Irrigation Advise by Name
        /// </summary>
        /// <param name="pName"></param>
        /// <returns></returns>
        public Stage SetStopIrrigationStage(String pName)
        {
            Stage lReturn = null;
            Stage lStage = this.FindStage(pName);
            if (lStage != null) 
            {
                this.StopIrrigationStageId = lStage.StageId;
                this.StopIrrigationStage = lStage;
                lReturn = lStage;
            }

            return lReturn;
        }

        #endregion

        #region PhenologicalStage
        /// <summary>
        /// New ID for PhenologicalStageList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewPhenologicalStageListId()
        {
            long lReturn = 1;

            if (this.PhenologicalStageList != null && this.PhenologicalStageList.Count > 0)
            {
                lReturn += this.PhenologicalStageList.Max(ps => ps.PhenologicalStageId);
            }

            return lReturn;
        }

        /// <summary>
        /// Get the initial Phenological Stage
        /// </summary>
        /// <returns></returns>
        public PhenologicalStage GetInitialPhenologicalStage()
        {
            PhenologicalStage lReturn = null;

            if(this.PhenologicalStageList.Count() > 0)
            {
                lReturn = this.PhenologicalStageList[0];
            }

            return lReturn;
        }

        /// <summary>
        /// Find A PhenologicalStage by Stage
        /// </summary>
        /// <param name="pStage"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(Stage pStage)
        {
            PhenologicalStage lReturn = null;

            if(pStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if (item.Stage.Equals(pStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Find A PhenologicalStage by StageId
        /// </summary>
        /// <param name="pStageId"></param>
        /// <returns></returns>
        public PhenologicalStage FindPhenologicalStage(long pStageId)
        {
            PhenologicalStage lReturn = null;

            foreach (PhenologicalStage item in this.PhenologicalStageList)
            {
                if (item.Stage.StageId == pStageId)
                {
                    lReturn = item;
                    break;
                }
            }
            
            return lReturn;
        }


        /// <summary>
        /// Find A Stage Order by StageId
        /// </summary>
        /// <param name="pStageId"></param>
        /// <returns></returns>
        public int FindStageOrder(long pStageId)
        {
            int lReturn = 0;

            PhenologicalStage lPhenologicalStage = this.FindPhenologicalStage(pStageId);
            
            if (lPhenologicalStage != null)
            {
                lReturn = lPhenologicalStage.Stage.Order;
            }
            return lReturn;
        }

        /// <summary>
        /// If PhenologicalStage exist in List, return the PhenologicalStage, 
        /// else return null
        /// </summary>
        /// <param name="pInitialPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage ExistPhenologicalStage(PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;

            if (pPhenologicalStage != null)
            {
                foreach (PhenologicalStage item in this.PhenologicalStageList)
                {
                    if (item.Equals(pPhenologicalStage))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Add a new PhenologicalStage, if exists, return null
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pCoefficient"></param>
        /// <param name="pRootDepth"></param>
        /// <param name="pHydricBalanceDepth"></param>
        /// <returns></returns>
        public PhenologicalStage AddPhenologicalStage(Specie pSpecie, Stage pStage,
                                        Double pMinDegree, Double pMaxDegree, Double pCoefficient,
                                        Double pRootDepth, Double pHydricBalanceDepth)
        {
            //Refactroing 2017/09/14 Changes in Phenological Table Modificable
            ///TODO ver si es mejor ingresar datos externos o calcular "lDegreesDaysInterval"
            bool lPhenologicalStageIsUsed = true;
            Double lDegreesDaysInterval = pMaxDegree - pMinDegree;


            PhenologicalStage lReturn = null;
            long lPhenologicalStageId = this.GetNewPhenologicalStageListId();
            PhenologicalStage lPhenologicalStage = new PhenologicalStage(lPhenologicalStageId,
                                                    pSpecie, pStage, pMinDegree, pMaxDegree,
                                                    pCoefficient, pRootDepth, pHydricBalanceDepth,
                                                    lPhenologicalStageIsUsed, lDegreesDaysInterval);

            lReturn = ExistPhenologicalStage(lPhenologicalStage);
            if (lReturn == null)
            {
                this.StageList.Add(pStage);
                this.PhenologicalStageList.Add(lPhenologicalStage);
                lReturn = lPhenologicalStage;
            }
            else
            {
                lReturn = null;
            }

            return lReturn;
        }

        /// <summary>
        /// Update all the information about an existing PhenologicalStage,
        /// if not exist, return null
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pCoefficient"></param>
        /// <param name="pRootDepth"></param>
        /// <param name="pHydricBalanceDepth"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(Specie pSpecie, Stage pStage,
                                        Double pMinDegree, Double pMaxDegree, Double pCoefficient,
                                        Double pRootDepth, Double pHydricBalanceDepth)
        {
            //Refactroing 2017/09/14 Changes in Phenological Table Modificable
            ///TODO ver si es mejor ingresar datos externos o calcular "lDegreesDaysInterval"
            bool lPhenologicalStageIsUsed = true;
            Double lDegreesDaysInterval = pMaxDegree - pMinDegree;

            PhenologicalStage lReturn = null;
            Stage lStage = null;

            try
            {
                PhenologicalStage lPhenologicalStage = new PhenologicalStage(0, pSpecie, pStage,
                                                                pMinDegree, pMaxDegree, pCoefficient,
                                                                pRootDepth, pHydricBalanceDepth,
                                                                lPhenologicalStageIsUsed,lDegreesDaysInterval);
                lReturn = ExistPhenologicalStage(lPhenologicalStage);
                if (lReturn != null)
                {
                    lStage = this.FindStage(pStage.Name);
                    if (lStage != null)
                    {
                        lStage.Name = pStage.Name;
                        lStage.ShortName = pStage.ShortName;
                        lStage.Description = pStage.Description;
                    }
                    else
                    {
                        //TODO throw exception "There is a Phenological Stage without Stage in StageList!! Error of data."
                        logger.Error("Phenological Stage", "UpdatePhenologicalStage" + "\n" 
                            + "There is a Phenological Stage without Stage in StageList!! Error of data.");
                    }
                    lReturn.SpecieId = pSpecie.SpecieId;
                    lReturn.UpdateStage(pStage.Name, pStage.ShortName, pStage.Description, pStage.Order);
                    lReturn.MinDegree = pMinDegree;
                    lReturn.MaxDegree = pMaxDegree;
                    lReturn.Coefficient = pCoefficient;
                    lReturn.RootDepth = pRootDepth;
                    lReturn.HydricBalanceDepth = pHydricBalanceDepth;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.UpdatePhenologicalStage " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        /// <summary>
        /// Update PhenologicalStage
        /// </summary>
        /// <param name="pPhenologicalStage"></param>
        /// <returns></returns>
        public PhenologicalStage UpdatePhenologicalStage(PhenologicalStage pPhenologicalStage)
        {
            PhenologicalStage lReturn = null;
            Stage lStage = null;
            lReturn = ExistPhenologicalStage(pPhenologicalStage);
            if (lReturn != null)
            {
                lStage = this.FindStage(pPhenologicalStage.Stage.Name);
                if (lStage != null)
                {
                    lStage.Name = pPhenologicalStage.Stage.Name;
                    lStage.ShortName = pPhenologicalStage.Stage.ShortName;
                    lStage.Description = pPhenologicalStage.Stage.Description;
                    lStage.Order = pPhenologicalStage.Stage.Order;
                }
                else
                {
                    //TODO throw exception "There is a Phenological Stage without Stage in StageList!! Error of data."
                }
                lReturn.UpdateStage(pPhenologicalStage.Stage.Name, pPhenologicalStage.Stage.ShortName, 
                                    pPhenologicalStage.Stage.Description, pPhenologicalStage.Stage.Order);
                lReturn.MinDegree = pPhenologicalStage.MinDegree;
                lReturn.MaxDegree = pPhenologicalStage.MaxDegree;
                lReturn.Coefficient = pPhenologicalStage.Coefficient;
                lReturn.RootDepth = pPhenologicalStage.RootDepth;
                lReturn.HydricBalanceDepth = pPhenologicalStage.HydricBalanceDepth;
            }
            return lReturn;
        }
        

        /// <summary>
        /// Update PhenologicalStage List and Stage List
        /// </summary>
        /// <param name="pPhenologicalStageList"></param>
        /// <returns></returns>
        public List<PhenologicalStage> UpdatePhenologicalStageList(List<PhenologicalStage> pPhenologicalStageList)
        {
            List<PhenologicalStage> lReturn = null;
            if(pPhenologicalStageList != null)
            {
                this.stageList = this.getStageList(pPhenologicalStageList);
                this.phenologicalStageList = pPhenologicalStageList;
            }
            return lReturn;
        }

        #endregion

        #region DryMass

        /// <summary>
        ///  New ID for DryMassList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewDryMassListId()
        {
            long lReturn = 1;

            if (this.DryMassList != null && this.DryMassList.Count > 0)
            {
                lReturn += this.DryMassList.Max(dm => dm.DryMassId);
            }

            return lReturn;
        }

        /// <summary>
        ///  Get the initial DryMass item
        /// </summary>
        /// <returns></returns>
        public DryMass GetInitialDryMass()
        {
            DryMass lReturn = null;

            if (this.DryMassList.Count() > 0)
            {
                lReturn = this.DryMassList[0];
            }

            return lReturn;
        }

        /// <summary>
        /// Get DryMass list by Age of Crop
        /// </summary>
        /// <param name="pAgeOfCrop"></param>
        /// <returns></returns>
        public List<DryMass> GetDryMassList(int pAgeOfCrop)
        {
            List<DryMass> lReturn = null;

            lReturn = this.DryMassList.Where(dm => dm.AgeOfCrop == pAgeOfCrop).ToList();

            return lReturn;
        }

        /// <summary>
        /// Get DryMass list by Weather Season
        /// </summary>
        /// <param name="pWeatherSeason"></param>
        /// <returns></returns>
        public List<DryMass> GetDryMassList(Utils.WeatherSeason pWeatherSeason)
        {
            List<DryMass> lReturn = null;

            lReturn = this.DryMassList.Where(dm => dm.GetWeatherSeason() == pWeatherSeason).ToList();

            return lReturn;
        }

        /// <summary>
        /// Find A DryMass by Age of Crop, Weather Season, and Day
        /// </summary>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pWeatherSeason"></param>
        /// <param name="pDay"></param>
        /// <returns></returns>
        public DryMass FindDryMass(int pAgeOfCrop, Utils.WeatherSeason pWeatherSeason, int pDay)
        {
            DryMass lReturn = null;

            foreach (DryMass item in this.DryMassList.Where(dm => dm.AgeOfCrop == pAgeOfCrop)
                                                     .Where(dm => dm.GetWeatherSeason() == pWeatherSeason))
            {
                if (item.Day.Equals(pDay))
                {
                    lReturn = item;
                    break;
                }
            }
            
            return lReturn;
        }

        /// <summary>
        /// If DryMass exist in List, return the DryMass item, 
        /// else return null
        /// </summary>
        /// <param name="pDrayMass"></param>
        /// <returns></returns>
        public DryMass ExistDryMass(DryMass pDrayMass)
        {
            DryMass lReturn = null;

            if (pDrayMass != null)
            {
                foreach (DryMass item in this.DryMassList)
                {
                    if (item.Equals(pDrayMass))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Add a new DryMass, if exists, return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pSeason"></param>
        /// <param name="pDay"></param>
        /// <param name="pWeightPerHectareInKG"></param>
        /// <param name="pExponent"></param>
        /// <param name="pMultiplier"></param>
        /// <param name="pCoefficient"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public DryMass AddDryMass(String pName, Specie pSpecie, int pAgeOfCrop, Season pSeason,
                    int pDay, Double pWeightPerHectareInKG, Double pExponent, Double pMultiplier,
                    Double pCoefficient, Double pRootDepth)
        {
            DryMass lReturn = null;

            DryMass lDryMass = new DryMass(pName, pSpecie, pAgeOfCrop, pSeason, pDay,
                                            pWeightPerHectareInKG, pExponent, pMultiplier,
                                            pCoefficient, pRootDepth);

            lReturn = ExistDryMass(lDryMass);
            if (lReturn == null)
            {
                this.DryMassList.Add(lDryMass);
                lReturn = lDryMass;
            }
            else
            {
                lReturn = null;
            }

            return lReturn;
        }

        /// <summary>
        /// Update DryMass
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pAgeOfCrop"></param>
        /// <param name="pSeason"></param>
        /// <param name="pDay"></param>
        /// <param name="pWeightPerHectareInKG"></param>
        /// <param name="pExponent"></param>
        /// <param name="pMultiplier"></param>
        /// <param name="pCoefficient"></param>
        /// <param name="pRootDepth"></param>
        /// <returns></returns>
        public DryMass UpdateDryMass(String pName, Specie pSpecie, int pAgeOfCrop, Season pSeason,
                    int pDay, Double pWeightPerHectareInKG, Double pExponent, Double pMultiplier,
                    Double pCoefficient, Double pRootDepth)
        {
            DryMass lReturn = null;

            try
            {
                DryMass lDryMass = new DryMass(pName, pSpecie, pAgeOfCrop, pSeason, pDay,
                                            pWeightPerHectareInKG, pExponent, pMultiplier,
                                            pCoefficient, pRootDepth);
                lReturn = ExistDryMass(lDryMass);
                if (lReturn != null)
                {
                    lReturn.Name = pName;
                    lReturn.SpecieId = pSpecie.SpecieId;
                    lReturn.AgeOfCrop = pAgeOfCrop;
                    lReturn.Season = pSeason;
                    lReturn.SeasonId = pSeason.SeasonId;
                    lReturn.Day = pDay;
                    lReturn.WeightPerHectareInKG = pWeightPerHectareInKG;
                    lReturn.Exponent = pExponent;
                    lReturn.Multiplier = pMultiplier;
                    lReturn.Coefficient = pCoefficient;
                    lReturn.RootDepth = pRootDepth;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeather.UpdateDryMass " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }



        #endregion

        #region CropCoefficient

        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing.
        /// </summary>
        /// <param name="pDaysAfterSowingModified"></param>
        /// <returns></returns>
        public double GetCropCoefficient(int pDaysAfterSowing)
        {
            double lReturn = 0;
            lReturn = this.CropCoefficient.GetCropCoefficient(pDaysAfterSowing);

            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// name, specie
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Crop lCrop = obj as Crop;
            lReturn = this.Region.Equals(lCrop.Region)
                && this.Specie.Equals(lCrop.Specie);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Specie.GetHashCode();
        }
        
        #endregion


    }
}