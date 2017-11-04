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
            private Utils.NoIrrigationReason reason;

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
            
            public String Observations
            {
                get { return observations; }
                set { observations = value; }
            }

            public Utils.NoIrrigationReason Reason
            {
                get { return reason; }
                set { reason = value; }
            }

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

            /// <summary>
            /// Constructor with all parameters
            /// </summary>
            /// <param name="pType"></param>
            /// <param name="pDate"></param>
            /// <param name="pInput"></param>
            /// <param name="pCropIrrigationWeatherId"></param>
            /// <param name="pObservations"></param>
            /// <param name="pReasonId"></param>
            public Irrigation(Utils.WaterInputType pType, DateTime pDate, double pInput, long pCropIrrigationWeatherId,
                                String pObservations, Utils.NoIrrigationReason pReason)
            {
                this.Type = pType;
                this.Date = pDate;
                this.Input = pInput;
                this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
                this.Observations = pObservations;
                this.Reason = pReason;
            }

            #endregion

            #region Private Helpers
            #endregion

            #region Public Methods


            #endregion

            #region Overrides

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
                Irrigation lIrrigation = obj as Irrigation;
                return this.Date.Equals(lIrrigation.Date)
                    && this.Input.Equals(lIrrigation.Input)
                    && this.CropIrrigationWeatherId.Equals(lIrrigation.CropIrrigationWeatherId);
            }

            public override int GetHashCode()
            {
                return this.Date.GetHashCode();
            }


            #endregion



    }
}