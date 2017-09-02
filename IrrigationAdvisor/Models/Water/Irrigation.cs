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
        ///     Describes an Irrigation over a Crop
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
        public class Irrigation : WaterInput
        {
            #region Consts

            
            #endregion

            #region Fields

            private Utils.WaterInputType type;
            private String observations;
            

            #endregion

            #region Properties

            public Utils.WaterInputType Type
            {
                get { return type; }
                set 
                { 
                    if(value == Utils.WaterInputType.Rain)
                    {
                        value = Utils.WaterInputType.Irrigation;
                    }
                    type = value; 
                }
            }

            public string Observations
            {
                get
                {
                    return observations;
                }

                set
                {
                    observations = value;
                }
            }

            public int? ReasonId { get; set; }

            #endregion

            #region Construction

            /// <summary>
            /// Constructor of Irrigation
            /// </summary>
            public Irrigation(): base()
                    {
                        this.Type = Utils.WaterInputType.Irrigation;
                    }

                    /// <summary>
                    /// Constructor with parameters
                    /// </summary>
                    /// <param name="pDate"></param>
                    /// <param name="pInput"></param>
                    /// <param name="pCropIrrigationWeatherId"></param>
                    public Irrigation(DateTime pDate, double pInput, long pCropIrrigationWeatherId)
                    {
                        this.Type = Utils.WaterInputType.Irrigation;
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