using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;
using NLog;

namespace IrrigationAdvisor.Models.Irrigation
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: monicarle
    /// Description: 
    ///     Describes an Irrigation Unit
    ///     
    /// References:
    ///     Bomb
    ///     Position
    ///     
    /// Dependencies:
    ///     CropIrrigationWeather
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String
    /// 
    /// Methods:
    ///     - IrrigationUnit()      -- constructor
    ///     - IrrigationUnit(name)  -- consturctor with parameters
    /// 
    /// </summary>
    public class IrrigationUnit
    {
        #region Consts
        #endregion

        #region Fields

        private long irrigationUnitId;
        private String name;
        private String shortName;
        private Utils.IrrigationUnitType irrigationType;
        private Double irrigationEfficiency;
        private List<Pair<DateTime, Double>> irrigationList;
        private Double surface;
        private long bombId;
        private long positionId;
        private Double predeterminatedIrrigationQuantity;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties


        public long IrrigationUnitId
        {
            get { return irrigationUnitId; }
            set { irrigationUnitId = value; }
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
        
        public Utils.IrrigationUnitType IrrigationType
        {
            get { return irrigationType; }
            set { irrigationType = value; }
        }
        
        public Double IrrigationEfficiency
        {
            get { return irrigationEfficiency; }
            set { irrigationEfficiency = value; }
        }
        
        public List<Pair<DateTime, double>> IrrigationList
        {
            get { return irrigationList; }
            set { irrigationList = value; }
        }
        
        public Double Surface
        {
            get { return surface; }
            set { surface = value; }
        }
        
        public long BombId
        {
            get { return bombId; }
            set { bombId = value; }
        }

        public virtual Bomb Bomb
        {
            get;
            set;
        }
        
        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public Double PredeterminatedIrrigationQuantity
        {
            get { return predeterminatedIrrigationQuantity; }
            set { predeterminatedIrrigationQuantity = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public IrrigationUnit()
        {
            this.IrrigationUnitId = 0;
            this.Name = "noname";
            this.ShortName = "";
            this.IrrigationType = 0;
            this.IrrigationEfficiency = 0;
            this.IrrigationList = new List<Pair<DateTime, double>>();
            this.Surface = 0;
            this.BombId = 0;
            this.PositionId = 0;
            this.PredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
        }
        
        /// <summary>
        /// Contructor with parameters
        /// </summary>
        /// <param name="pIrrigationUnitId"></param>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pIrrigationType"></param>
        /// <param name="pIrrigationEfficiency"></param>
        /// <param name="pIrrigationList"></param>
        /// <param name="pSurface"></param>
        /// <param name="pBombId"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pPredeterminatedIrrigationQuantity"></param>
        public IrrigationUnit(long pIrrigationUnitId, String pName, 
            String pShortName, Utils.IrrigationUnitType pIrrigationType,
            Double pIrrigationEfficiency, List<Pair<DateTime, Double>> pIrrigationList,
            Double pSurface, long pBombId, long pPositionId, Double pPredeterminatedIrrigationQuantity)
        {
            this.IrrigationUnitId = pIrrigationUnitId;
            this.Name = pName;
            this.ShortName = pShortName;
            this.IrrigationType = pIrrigationType;
            this.IrrigationEfficiency = pIrrigationEfficiency;
            this.IrrigationList = pIrrigationList;
            this.Surface = pSurface;
            this.BombId = pBombId;
            this.PositionId = pPositionId;
            this.PredeterminatedIrrigationQuantity = pPredeterminatedIrrigationQuantity;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Add pair Date & Value of Irrigation in Irrigation List
        /// </summary>
        /// <param name="pCurrentDateTime"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        public bool AddIrrigation(DateTime pDateTime, double pValue)
        {
            bool lReturn = false;
            try
            {
                Pair<DateTime,double> lPair = new Pair<DateTime,double>(pDateTime, pValue);
                this.IrrigationList.Add(lPair);
                lReturn = true;
            }
            catch(Exception e)
            {
                logger.Error(e, e.Message);
                lReturn = false;
                Console.WriteLine("Error in IrrigationUnit.addIrrigation " + e.Message);
            }
            return lReturn;
        }

#if false
        #region Crop

        /// <summary>
        /// Return a Crop with the same Name & Specie from Parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycle"></param>
        /// <returns></returns>
        public Crop FindCrop(String pName, Specie pSpecie)
        {
            Crop lReturn = null;
            if (!String.IsNullOrEmpty(pName) && pSpecie != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if (item.Name.Equals(pName) && item.Specie.Equals(pSpecie))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return a Crop equals from Parameters,
        /// If do not exists return null
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop ExistCrop(Crop pCrop)
        {
            Crop lReturn = null;
            if(pCrop != null)
            {
                foreach (Crop item in this.CropList)
                {
                    if(item.Equals(pCrop))
                    {
                        lReturn = item;
                        break;
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Add a new Crop and return it, if exists returns null
        /// </summary>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public Crop AddCrop(Crop pCrop)
        {
            Crop lReturn = null;
            try
            {
                lReturn = ExistCrop(pCrop);
                if (lReturn == null)
                {
                    this.CropList.Add(pCrop);
                    lReturn = pCrop;
                }
            }
            catch(Exception e)
            {
                logger.Error(e, e.Message);
                Console.WriteLine("Error in IrrigationUnit.addCrop " + e.Message);
            }
            return lReturn;
        }

        /// <summary>
        /// Update an existing Crop, if not exists return null
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pSpecieCycle"></param>
        /// <param name="pRegion"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pStageList"></param>
        /// <param name="pPhenologicalStageList"></param>
        /// <param name="pDensity"></param>
        /// <param name="pMaxEvapotranspirationToIrrigate"></param>
        /// <param name="pMinEvapotranspirationToIrrigate"></param>
        /// <returns></returns>
        public Crop UpdateCrop(String pName, Specie pSpecie, Region pRegion,
                        CropCoefficient pCropCoefficient,
                        List<PhenologicalStage> pPhenologicalStageList,
                        Double pDensity, Double pMaxEvapotranspirationToIrrigate, 
                        Double pMinEvapotranspirationToIrrigate)
        {
            Crop lReturn = null;
            Crop lCrop = new Crop(0,
                                    pName, 
                                    pRegion.RegionId, 
                                    pSpecie.SpecieId,
                                    pCropCoefficient.CropCoefficientId, 
                                    pPhenologicalStageList, 
                                    pDensity,
                                    pMaxEvapotranspirationToIrrigate, 
                                    pMinEvapotranspirationToIrrigate);
            lReturn = this.ExistCrop(lCrop);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.RegionId = pRegion.RegionId;
                lReturn.SpecieId = pSpecie.SpecieId;
                lReturn.CropCoefficientId = pCropCoefficient.CropCoefficientId;
                lReturn.UpdatePhenologicalStageList(pPhenologicalStageList);
                lReturn.Density = pDensity;
                lReturn.MaxEvapotranspirationToIrrigate = pMaxEvapotranspirationToIrrigate;
                lReturn.MinEvapotranspirationToIrrigate = pMinEvapotranspirationToIrrigate;
            }
            return lReturn;
        }


        #endregion
#endif

        /// <summary>
        /// Get Total Irrigation in List
        /// </summary>
        /// <returns></returns>
        public double GetTotalIrrigation() 
        {
            double lReturn = 0;
            foreach(Pair<DateTime,double> lIrrigation in IrrigationList)
            {
                lReturn += lIrrigation.Second;
            }
            return lReturn;
        }
        
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
            IrrigationUnit lIrrigationUnit = obj as IrrigationUnit;
            return this.Name.Equals(lIrrigationUnit.Name)
                && this.PositionId.Equals(lIrrigationUnit.PositionId)
                && this.IrrigationType.Equals(lIrrigationUnit.IrrigationType);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}