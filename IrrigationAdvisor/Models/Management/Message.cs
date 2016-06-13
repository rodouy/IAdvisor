using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Management
{
    /// <summary>
    /// Create: 2016-02-04
    /// Author: rodouy 
    /// Description: 
    ///     Template of a new class summary
    ///     
    /// References:
    ///     list of classes this class use
    ///     
    /// Dependencies:
    ///     list of classes is referenced by this class
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - name String - PK (Primary Key)
    /// 
    /// Methods:
    ///     - Message()      -- constructor
    ///     - Message(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Message
    {
        #region Consts
        #endregion

        #region Fields

        private long messageId;
        private long titleId;
        private long lineId;
        private long cropIrrigationWeatherId;
        private bool daily;
        private String data;

        #endregion

        #region Properties

        public long MessageId
        {
            get { return messageId; }
            set { messageId = value; }
        }

        public long TitleId
        {
            get { return titleId; }
            set { titleId = value; }
        }

        public virtual Title Title
        {
            get;
            set;
        }

        public long LineId
        {
            get { return lineId; }
            set { lineId = value; }
        }

        public long CropIrrigationWeatherId
        {
            get { return cropIrrigationWeatherId; }
            set { cropIrrigationWeatherId = value; }
        }

        public virtual CropIrrigationWeather CropIrrigationWeather
        {
            get;
            set;
        }

        public bool Daily
        {
            get { return daily; }
            set { daily = value; }
        }

        public String Data
        {
            get { return data; }
            set { data = value; }
        }
 
        #endregion

        #region Construction

        /// <summary>
        /// Cponstructor of Message
        /// </summary>
        public Message()
        {
            this.MessageId = 0;
            this.TitleId = 0;
            this.LineId = 0;
            this.CropIrrigationWeatherId = 0;
            this.Daily = false;
            this.Data = "";
        }

        /// <summary>
        /// Constructor with Parameters
        /// </summary>
        /// <param name="pMessageId"></param>
        /// <param name="pTitleId"></param>
        /// <param name="pLineId"></param>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pDaily"></param>
        /// <param name="pData"></param>
        public Message(long pMessageId, long pTitleId, long pLineId,
                        long pCropIrrigationWeatherId,
                        bool pDaily, String pData)
        {
            this.MessageId = pMessageId;
            this.TitleId = pTitleId;
            this.LineId = pLineId;
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
            this.Daily = pDaily;
            this.Data = pData;
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
            Message lMessage = obj as Message;
            return this.TitleId == lMessage.TitleId 
                && this.LineId == lMessage.LineId
                && this.CropIrrigationWeatherId == lMessage.CropIrrigationWeatherId
                && this.Daily == lMessage.Daily;
        }

        public override int GetHashCode()
        {
            return this.CropIrrigationWeatherId.GetHashCode();
        }

        #endregion

    }
}