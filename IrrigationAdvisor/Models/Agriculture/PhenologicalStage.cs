using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-25
    /// Author:  monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Modified: 2015-06-14
    /// Author: rodouy
    /// Description: 
    ///     Describes a phenological stage
    ///     
    /// References:
    ///     Specie
    ///     Stage
    ///     
    /// Dependencies:
    ///     Crop
    /// 
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - specie:  Specie   - PK
    ///     - stage:  Stage     - PK
    ///     - minDegree: double
    ///     - maxDegree: double
    ///     - rootDepth: double
    /// 
    /// Methods:
    ///     - PhenologicalStage()      -- constructor
    ///     - PhenologicalStage(stage, minDegree, maxDegree, rootDepth)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    ///     + GetAverageDegree(): double
    /// 
    /// </summary>
    public class PhenologicalStage
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - specie:  Specie
        ///     - stage:  Stage
        ///     - minDegree: double
        ///     - maxDegree: double
        ///     - rootDepth: double
        ///     - hydricBalanceDepth : double
        ///     
        /// </summary>
        private long phenologicalStageId;
        private long specieId;
        private long stageId;
        private double minDegree;
        private double maxDegree;
        private Double coefficient;
        private double rootDepth;
        private double hydricBalanceDepth;

        //Refactroing 2017/09/14 Changes in Phenological Table: Add phenologicalStageIsUsed, degreesDaysInterval
        private bool phenologicalStageIsUsed;
        private Double degreesDaysInterval;


        #endregion

        #region Properties


        public long PhenologicalStageId
        {
            get { return phenologicalStageId; }
            set { phenologicalStageId = value; }
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

        public long StageId
        {
            get { return stageId; }
            set { stageId = value; }
        }

        public virtual Stage Stage
        {
            get;
            set;
        }
        
        public double MinDegree
        {
            get { return minDegree; }
            set { minDegree = value; }
        }
        
        public double MaxDegree
        {
            get { return maxDegree; }
            set { maxDegree = value; }
        }

        public Double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }
        
        public double RootDepth
        {
            get { return rootDepth; }
            set { rootDepth = value; }
        }

        public double HydricBalanceDepth
        {
            get { return hydricBalanceDepth; }
            set { hydricBalanceDepth = value; }
        }

        public bool PhenologicalStageIsUsed
        {
            get { return phenologicalStageIsUsed; }
            set { phenologicalStageIsUsed = value; }
        }

        public double DegreesDaysInterval
        {
            get { return degreesDaysInterval; }
            set { degreesDaysInterval = value; }
        }


        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public PhenologicalStage() 
        {
            this.phenologicalStageId = 0;
            this.specieId = 0;
            this.stageId = 0;
            this.MinDegree = 0;
            this.MaxDegree = 0;
            this.Coefficient = 0;
            this.RootDepth = 0;
            this.HydricBalanceDepth = 0;
            this.PhenologicalStageIsUsed = true;
            this.DegreesDaysInterval = 0;
        }

        /// <summary>
        /// Build an instance of a phenological stage for a specie. 
        /// It is used for a range between the max and min degree.
        /// </summary>
        /// <param name="pPhenologicalStageId"></param>
        /// <param name="pSpecie"></param>
        /// <param name="pStage"></param>
        /// <param name="pMinDegree"></param>
        /// <param name="pMaxDegree"></param>
        /// <param name="pCoefficient"></param>
        /// <param name="pRootDepth"></param>
        /// <param name="pHydricBalanceDepth"></param>
        public PhenologicalStage(long pPhenologicalStageId, 
                                Specie pSpecie, Stage pStage, 
                                Double pMinDegree, Double pMaxDegree, 
                                Double pCoefficient,
                                Double pRootDepth, Double pHydricBalanceDepth,
                                bool pPhenologicalStageIsUsed, Double pDegreesDaysInterval)
        {
            this.phenologicalStageId = pPhenologicalStageId;
            this.SpecieId = pSpecie.SpecieId;
            this.StageId = pStage.StageId;
            this.MinDegree = pMinDegree;
            this.MaxDegree = pMaxDegree;
            this.Coefficient = pCoefficient;
            this.RootDepth = pRootDepth;
            this.HydricBalanceDepth = pHydricBalanceDepth;
            this.PhenologicalStageIsUsed = pPhenologicalStageIsUsed;
            this.DegreesDaysInterval = pDegreesDaysInterval;
        }
        
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        /// <summary>
        /// Return the Average Degree between MinDegree and MaxDegree
        /// </summary>
        /// <returns></returns>
        public double GetAverageDegree()
        {
            double lReturn;
            lReturn= (this.MinDegree + this.MaxDegree) / 2;
            return lReturn;
        }

        /// <summary>
        /// Return the Root Depth
        /// </summary>
        /// <returns></returns>
        public double GetRootDepth()
        {
            double lRootDepth;
            lRootDepth = this.rootDepth;
            return lRootDepth;
        }

        public Stage UpdateStage(String pName, String pShortName, String pDescripcion,
                                int pOrder)
        {
            Stage lReturn = null;
            if (!String.IsNullOrEmpty(pName) && !String.IsNullOrEmpty(pShortName) && !String.IsNullOrEmpty(pDescripcion))
            {
                this.Stage.Name = pName;
                this.Stage.ShortName = pShortName;
                this.Stage.Description = pDescripcion;
                this.Stage.Order = pOrder;
                lReturn = this.Stage;
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
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            PhenologicalStage lPhenologicalStage = obj as PhenologicalStage;
            lReturn = this.Stage.Equals(lPhenologicalStage.Stage);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.Stage.GetHashCode();
        }

        #endregion

    }
}