using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2015-11-02
    /// Author: rodouy
    /// Description: 
    ///     KC for List in Crop Coefficient
    ///     
    /// References:
    ///     
    ///     
    /// Dependencies:
    ///     CropCoefficient
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - KC()      -- constructor
    ///     - KC(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class KC
    {
        

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>

        private long kcId;
        private long specieId;
        private int dayAfterSowing;
        private Double coefficient;

        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>
        
        public long KCId
        {
            get { return kcId; }
            set { kcId = value; }
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

        public int DayAfterSowing
        {
          get { return dayAfterSowing; }
          set { dayAfterSowing = value; }
        }

        public Double Coefficient
        {
            get { return coefficient; }
            set { coefficient = value; }
        }
        
        #endregion

        #region Construction
        /// <summary>
        /// Constructor of KC
        /// </summary>
        public KC()
        {
            this.KCId = 0;
            this.SpecieId = 0;
            this.DayAfterSowing = 0;
            this.Coefficient = 1;
        }

        /// <summary>
        /// Constructor of KC with parameters
        /// </summary>
        /// <param name="pKCId"></param>
        /// <param name="pSpecieId"></param>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pCoefficient"></param>
        public KC(long pKCId, long pSpecieId, 
                    int pDayAfterSowing, Double pCoefficient)
        {
            this.KCId = pKCId;
            this.SpecieId = pSpecieId;
            this.DayAfterSowing = pDayAfterSowing;
            this.Coefficient = pCoefficient;
        }

        #endregion

        #region Private Helpers
        // private methods used only to support external API Methods
        
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
            KC lKC = obj as KC;
            return this.SpecieId == lKC.SpecieId
                && this.DayAfterSowing == lKC.DayAfterSowing;
        }

        public override int GetHashCode()
        {
            return this.DayAfterSowing.GetHashCode();
        }

        #endregion

    }
}