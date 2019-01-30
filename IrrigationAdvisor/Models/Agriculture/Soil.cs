using IrrigationAdvisor.Models.Localization;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{

    /// <summary>
    /// Create: 2014-10-23
    /// Author:  monicarle
    /// Description: 
    ///     Describes a Soil
    ///     
    /// References:
    ///     Horizon
    ///     
    /// Dependencies:
    ///     Crop
    ///     Farm
    ///     SoilService
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - soilId long
    ///     - name String
    ///     - shortName String 
    ///     - description String
    ///     - positionId PositionId
    ///     - horizonList List<Horizon>
    ///     - testDate DateTime
    ///     - depthLimit double
    ///     - shortName String 
    ///     - farmId ling
    ///      
    /// Methods:
    ///     - Soil()      -- constructor
    ///     - Soil(name, shortname, description, PositionId, testDate, depthLimit,farmid)  -- consturctor with parameters
    ///     - GetSoilFieldCapacity(double: RootDepth)
    ///     - GetPermanentWiltingPoint(double: RootDepth)
    ///     - GetAvailableWaterCapacity(double: RootDepth)
    /// 
    /// </summary>
    public class Soil
    {
        #region Consts
        
     
        
        enum SoilLayer
        {
            AvailableWater,
            FieldCapacity,
            PermanentWiltingPoint,
        }
        

        #endregion

        #region Fields

        private long soilId;
        private String name;
        private String shortName;
        private String description;
        private long positionId;
        private List<Horizon> horizonList;
        private DateTime testDate;
        private double depthLimit;
        private long farmId;
        private bool enabled;

        private static Logger logger = LogManager.GetCurrentClassLogger();

        #endregion

        #region Properties


        public long SoilId
        {
            get { return soilId; }
            set { soilId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
       
        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }
        
        public List<Horizon> HorizonList
        {
            get { return horizonList; }
            set { horizonList = value; }
        }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)] 
        public DateTime TestDate
        {
            get { return testDate; }
            set { testDate = value; }
        }

        public double DepthLimit
        {
            get { return depthLimit; }
            set { depthLimit = value; }
        }

        public virtual Position Position
        {
            get;
            set;
        }

        public String ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }

        public long FarmId
        {
            get { return farmId; }
            set { farmId = value; }
        }


        public virtual Farm Farm
        {
            get;
            set;
        }

        [DefaultValue(true)]
        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        #endregion

        #region Construction
        
        public Soil() 
        {
            this.SoilId = 0;
            this.Name = "noname";
            this.ShortName = "noshortname";
            this.Description = "";
            this.PositionId = 0;
            this.HorizonList = new List<Horizon>();
            this.TestDate = Utilities.Utils.MIN_DATETIME;
            this.DepthLimit = 0;
            this.FarmId = 0;
            this.Enabled = true;
        }

        public Soil(long pIdSoil, String pName, String pShortName, String pDescription,
            long pPositionId, DateTime pTestDate, double pDepthLimit, long pFarmId)
        {
            this.SoilId = pIdSoil;
            this.Name = pName;
            this.ShortName = pShortName;
            this.Description = pDescription;
            this.PositionId = pPositionId;
            this.HorizonList = new List<Horizon>();
            this.TestDate = pTestDate;
            this.DepthLimit = pDepthLimit;
            this.FarmId = pFarmId;
            this.Enabled = true;
        }
        
        #endregion

        #region Private Helpers

        /// <summary>
        ///  Toma un prorrateo: por ejemplo si el horizonte A mide 10 cm y el horizonte B mide 20:
        ///  Si la raiz tiene 15 cm tomo en cuenta 2/3 del horizonte A (10 cm iniciales) y 1/3 del horizonte B (los otros 5 cm de la planta).
        ///  
        ///  Take an average: for example if the A horizon is 10 cm and horizon B is 20 cm depth:
        ///  if the root is 15 cm long the results is 2/3 of horizon A (initial 10 cm) and 1/3 of horixon B (the rest of the root)
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2200:RethrowToPreserveStackDetails")]
        private double getLayerCapacityByProrationOfHorizon(double pDepth, SoilLayer pSoilLayer)
        {
            double lDepthSum = 0;
            double lReturnLayerWaterSum = 0;
            IEnumerable<Horizon> query;
            double lRemainRoot = 0;
            double lLastHorizonLayerCapacity = 0;
            double lLastHorizonLayerDepth = 0;
            double lFieldCapacityDepthCM = 10;

            try
            {
                query = this.horizonList.OrderBy(lHorizon => lHorizon.Order);
                foreach (Horizon lHorizon in query)
                {
                    //To the root substract the passed horizon depth
                    lRemainRoot = pDepth - lDepthSum;
                    lDepthSum += lHorizon.HorizonLayerDepth;
                    switch (pSoilLayer)
                    {
                        case SoilLayer.AvailableWater:
                            lLastHorizonLayerCapacity = lHorizon.GetAvailableWaterCapacity();
                            break;
                        case SoilLayer.FieldCapacity:
                            lLastHorizonLayerCapacity = lHorizon.GetFieldCapacity();
                            break;
                        case SoilLayer.PermanentWiltingPoint:
                            lLastHorizonLayerCapacity = lHorizon.GetPermanentWiltingPoint();
                            break;
                        default:
                            lLastHorizonLayerCapacity = 0;
                            break;
                    }

                    lLastHorizonLayerDepth = lHorizon.HorizonLayerDepth;
                    // La raiz es mas grande que hasta este horizonte, calculo y sigo
                    if (lDepthSum <= pDepth)
                    {
                        lReturnLayerWaterSum += lLastHorizonLayerCapacity * lLastHorizonLayerDepth / lFieldCapacityDepthCM;
                    }
                    // La raiz llega/termina en este horizonte, calculo y termino
                    else if (lHorizon.HorizonLayerDepth > lRemainRoot && lRemainRoot > 0)
                    {
                        lReturnLayerWaterSum += lLastHorizonLayerCapacity * lRemainRoot / lFieldCapacityDepthCM;
                        break;
                    }
                }
                //If the root is bigger than all the horizonList i have defined
                if (lDepthSum < pDepth)
                {
                    lRemainRoot = pDepth - lDepthSum;
                    lReturnLayerWaterSum += lLastHorizonLayerCapacity * lRemainRoot / lFieldCapacityDepthCM;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in Soil.getLayerCapacityByProrationOfHorizon " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
                
            }
            return lReturnLayerWaterSum;
        }

        /// <summary>
        /// Return the tHorizon By Order
        /// </summary>
        /// <param name="pOrder"></param>
        /// <returns></returns>
        private Horizon getHorizonByOrder(int pOrder)
        {
            Horizon pReturn = new Horizon();
            foreach (Horizon lHorizon in this.horizonList)
            {
                if (pOrder == lHorizon.Order)
                {
                    pReturn = lHorizon;
                    return lHorizon;
                }
            }
            return pReturn;
        }

        /// <summary>
        /// Return Horizon Where Finish Root Depth
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        private Horizon getHorizonWhereFinishRootDepth(double pRootDepth)
        {
            /// rehacer ordenando por horizon.order
            Horizon lReturn = null;
            double lRootDepthSum = 0;

            IEnumerable<Horizon> query = this.horizonList.OrderBy(lHorizon => lHorizon.Order);
            foreach (Horizon lHorizon in query)
            {
                lRootDepthSum += lHorizon.HorizonLayerDepth;
                if (lRootDepthSum >= pRootDepth)
                {
                    lReturn = lHorizon;
                    return lReturn;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Return the Available Water of the soil calculating the Available water of each Horizon
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        private double getAvailableWaterCapacityByProration(double pDepth)
        {
            double lReturnAvalilableWaterCapSum = 0;
            double lDepth = pDepth;
            if (pDepth > this.DepthLimit)
            {
                lDepth = this.DepthLimit;
            }
            lReturnAvalilableWaterCapSum = this.getLayerCapacityByProrationOfHorizon(lDepth, SoilLayer.AvailableWater);
            return lReturnAvalilableWaterCapSum;
        }

        #endregion

        #region Public Methods

        #region Horizon

        /// <summary>
        /// New ID for HorizonList, MAX + 1
        /// </summary>
        /// <returns></returns>
        public long GetNewHorizonListId()
        {
            long lReturn = 1;
            if (this.HorizonList != null)
            {
                if (this.HorizonList.Count > 0)
                {
                lReturn += this.HorizonList.Max(ho => ho.HorizonId);
            }

            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pHorizon"></param>
        /// <returns></returns>
        public Horizon ExistHorizon(Horizon pHorizon)
        {
            Horizon lReturn = null;
            foreach (Horizon item in HorizonList)
            {
                if (item.Equals(pHorizon))
                {
                    lReturn = item;
                    break;
                }
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pOrder"></param>
        /// <param name="pHorizonLayer"></param>
        /// <param name="pHorizonLayerDepth"></param>
        /// <param name="pSand"></param>
        /// <param name="pLimo"></param>
        /// <param name="pClay"></param>
        /// <param name="pOrganicMatter"></param>
        /// <param name="pNitrogenAnalysis"></param>
        /// <param name="pBulkDensitySoil"></param>
        /// <returns></returns>
        public Horizon AddHorizon(String pName, int pOrder,
                        String pHorizonLayer, double pHorizonLayerDepth, double pSand,
                        double pLimo, double pClay, double pOrganicMatter, 
                        double pNitrogenAnalysis, double pBulkDensitySoil)
        {
            Horizon lReturn = null;
            long lIdHorizon = this.GetNewHorizonListId();
            Horizon lHorizon = new Horizon(lIdHorizon, pName, pOrder,
                pHorizonLayer, pHorizonLayerDepth, pSand, pLimo,
                pClay, pOrganicMatter, pNitrogenAnalysis, pBulkDensitySoil,this.SoilId);
            if (this.ExistHorizon(lHorizon) == null)
            {
                this.HorizonList.Add(lHorizon);
                lReturn = lHorizon;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO add description
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pOrder"></param>
        /// <param name="pHorizonLayer"></param>
        /// <param name="pHorizonLayerDepth"></param>
        /// <param name="pSand"></param>
        /// <param name="pLimo"></param>
        /// <param name="pClay"></param>
        /// <param name="pOrganicMatter"></param>
        /// <param name="pNitrogenAnalysis"></param>
        /// <param name="pBulkDensitySoil"></param>
        /// <returns></returns>
        public Horizon UpdateHorizon(String pName, int pOrder,
                        String pHorizonLayer, double pHorizonLayerDepth, double pSand,
                        double pLimo, double pClay, double pOrganicMatter,
                        double pNitrogenAnalysis, double pBulkDensitySoil)
        {
            Horizon lReturn = null;
            long lIdHorizon = this.GetNewHorizonListId();
            Horizon lHorizon = new Horizon(lIdHorizon, pName, pOrder,
                pHorizonLayer, pHorizonLayerDepth, pSand, pLimo,
                pClay, pOrganicMatter, pNitrogenAnalysis, pBulkDensitySoil,this.SoilId);
            lReturn = this.ExistHorizon(lHorizon);
            if (lReturn != null)
            {
                lReturn.Name = pName;
                lReturn.Order = pOrder;
                lReturn.HorizonLayer = pHorizonLayer;
                lReturn.HorizonLayerDepth = pHorizonLayerDepth;
                lReturn.Sand = pSand;
                lReturn.Limo = pLimo;
                lReturn.Clay = pClay;
                lReturn.OrganicMatter = pOrganicMatter;
                lReturn.NitrogenAnalysis = pNitrogenAnalysis;
                lReturn.BulkDensitySoil = pBulkDensitySoil;
            }
            return lReturn;
        }

        #endregion

        /// <summary>
        /// Return the Field Capacity, depends on Depth
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public double GetFieldCapacity(double pDepth)
        {
            double lReturnFieldCapacity = 0;
            double lDepth = pDepth;
            if (pDepth > this.DepthLimit)
            {
                lDepth = this.DepthLimit;
            }
            lReturnFieldCapacity = this.getLayerCapacityByProrationOfHorizon(lDepth, SoilLayer.FieldCapacity);
            return lReturnFieldCapacity;
        }

        /// <summary>
        /// Return the Permanent Wilting Point, depends on Root Depth
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
        public double GetPermanentWiltingPoint(double pDepth)
        {
            double lReturnPermanentWiltingPoingSum = 0;
            double lDepth = pDepth;
            if (pDepth > this.DepthLimit)
            {
                lDepth = this.DepthLimit;
            }
            lReturnPermanentWiltingPoingSum = this.getLayerCapacityByProrationOfHorizon(lDepth, SoilLayer.PermanentWiltingPoint);
            return lReturnPermanentWiltingPoingSum;
        }

        /// <summary>
        /// Return the Available Water of the soil as 
        ///     the difference between the Field Capacity and the Permanent WiltingPoint
        /// </summary>
        /// <param name="pDepth"></param>
        /// <returns></returns>
         public double GetAvailableWaterCapacity(double pDepth)
         {
            double lAvailableWaterCapacity;
            double lDepth = pDepth;
            if (pDepth > this.DepthLimit)
            {
                lDepth = this.DepthLimit;
            }
            lAvailableWaterCapacity = this.GetFieldCapacity(lDepth) - this.GetPermanentWiltingPoint(lDepth);
            return lAvailableWaterCapacity;
        }


        #endregion

        #region Overrides
        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            Soil lSoil = obj as Soil;
            return (this.Name.Equals(lSoil.Name) &&
                this.PositionId.Equals(lSoil.PositionId));
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public override string ToString()
        {
            string lReturn = Environment.NewLine + Environment.NewLine + this.Name + Environment.NewLine;
            foreach (Horizon lHorizon in this.HorizonList)
               {
                lReturn += lHorizon.ToString() + Environment.NewLine;
               }
            return lReturn;

        }
        #endregion

    }
}