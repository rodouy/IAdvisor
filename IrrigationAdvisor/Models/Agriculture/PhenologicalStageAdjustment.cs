using IrrigationAdvisor.Models.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2015-12-24
    /// Author: rodouy 
    /// Description: 
    ///     Phenological Stage Adjustment by observation of the crop
    ///     
    /// References:
    ///     PhenologicalStage
    ///     
    /// Dependencies:
    ///     CropIrrigationWeather
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - PhenologicalStageAdjustment()      -- constructor
    ///     - PhenologicalStageAdjustment(name, crop id, date of change
    ///                             stage id, phenological stage id,
    ///                             observation)  -- consturctor with parameters
    ///     
    /// </summary>
    public class PhenologicalStageAdjustment
    {
        
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>

        private long phenologicalStageAdjustmentId;
        private string name;
        private long cropId;
        private DateTime dateOfChange;
        private long stageId;
        private long phenologicalStageId;
        private String observation;
        private long cropIrrigationWeatherId;
        
        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>

        public long PhenologicalStageAdjustmentId
        {
            get { return phenologicalStageAdjustmentId; }
            set { phenologicalStageAdjustmentId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
        }

        public long CropId
        {
            get { return cropId; }
            set { cropId = value; }
        }

        public virtual Crop Crop { get; set; }

        public DateTime DateOfChange
        {
            get { return dateOfChange; }
            set { dateOfChange = value; }
        }

        public long StageId
        {
            get { return stageId; }
            set { stageId = value; }
        }

        public virtual Stage Stage { get; set; }

        public long PhenologicalStageId
        {
            get { return phenologicalStageId; }
            set { phenologicalStageId = value; }
        }

        public virtual PhenologicalStage PhenologicalStage { get; set; }
        
        public String Observation
        {
            get { return observation; }
            set { observation = value; }
        }

        public virtual CropIrrigationWeather CropIrrigationWeather
        {
            get; set;
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of PhenologicalStageAdjustment
        /// </summary>
        public PhenologicalStageAdjustment()
        {
            this.PhenologicalStageAdjustmentId = 0;
            this.Name = "noname";
            this.CropId = 0;
            this.DateOfChange = DateTime.Now;
            this.StageId = 0;
            this.PhenologicalStageId = 0;
            this.Observation = "";
        }

        /// <summary>
        /// Constructor of PhenologicalStageAdjustment with parameters
        /// </summary>
        /// <param name="pName"></param>
        public PhenologicalStageAdjustment(String pNewName, long pCropId, 
                        DateTime pDateOfChange, long pStageId, long pPhenologicalStageId,
                        String pObservation)
        {
            this.Name = pNewName;
            this.CropId = pCropId;
            this.DateOfChange = pDateOfChange;
            this.StageId = pStageId;
            this.PhenologicalStageId = pPhenologicalStageId;
            this.Observation = pObservation;
        }

        #endregion

        #region Private Helpers
        
        #endregion

        #region Public Methods
        
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
            PhenologicalStageAdjustment lPhenologicalStageAdjustment = obj as PhenologicalStageAdjustment;
            return this.Name.Equals(lPhenologicalStageAdjustment.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}