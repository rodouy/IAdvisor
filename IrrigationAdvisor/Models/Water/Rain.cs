using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.Models.Water
{
    /// <summary>
    /// Create: 2014-10-30
    /// Author: monicarle
    /// Description: 
    ///     Describes the Rain over a Crop
    ///     
    /// References:
    ///     WaterInput
    ///     
    /// Dependencies:
    ///     
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - type String
    /// 
    /// Methods:
    ///     - Rain()      -- constructor
    ///     - GetType()
    /// 
    /// </summary>
    public class Rain : WaterInput
    {
        #region Consts

        #endregion

        #region Fields

        private Utils.WaterInputType type;

        #endregion

        #region Properties

        public Utils.WaterInputType Type
        {
            get { return type; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Rain
        /// </summary>
        public Rain(): base()
        {
            this.type = Utils.WaterInputType.Rain;            
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pDate"></param>
        /// <param name="pInput"></param>
        /// <param name="pCropIrrigationWeatherId"></param>
        public Rain(DateTime pDate, double pInput, long pCropIrrigationWeatherId)
        {
            this.type = Utils.WaterInputType.Rain;
            this.Date = pDate;
            this.Input = pInput;
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        
        #endregion

        #region Overrides
        #endregion

    }
}