using IrrigationAdvisor.Models.Localization;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Irrigation
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author:  monicarle
    /// Description: 
    ///     Describes a Bomb used in an Irrigation Unit
    ///     
    /// References:
    ///     Position
    ///     
    /// Dependencies:
    ///     Bomb
    /// 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - bombId long
    ///     - name String
    ///     - shortName String
    ///     - serialNumber int
    ///     - serviceDate DateTime
    ///     - purchaseDate DateTime
    ///     - positionId long
    ///     
    /// 
    /// Methods:
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Bomb
    {
        #region Consts
        #endregion

        #region Fields

        private long bombId;
        private String name;
        private String shortName;
        private String serialNumber;
        private DateTime serviceDate;
        private DateTime purchaseDate;
        private long positionId;
        private long farmId;


        #endregion

        #region Properties

        
        public long BombId
        {
            get { return bombId; }
            set { bombId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }

        public String SerialNumber
        {
            get { return serialNumber; }
            set { serialNumber = value; }
        }

        public DateTime ServiceDate
        {
            get { return serviceDate; }
            set { serviceDate = value; }
        }

        public DateTime PurchaseDate
        {
            get { return purchaseDate; }
            set { purchaseDate = value; }
        }

        public long PositionId
        {
            get { return positionId; }
            set { positionId = value; }
        }

        public virtual Position Position
        {
            get;
            set;
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

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of Bomb
        /// </summary>
        public Bomb()
        {
            this.BombId = 0;
            this.Name = "noname";
            this.ShortName = "noshortname";
            this.SerialNumber = "0";
            this.ServiceDate = DateTime.Now;
            this.PurchaseDate = DateTime.Now;
            this.PositionId = 0;
            this.FarmId = 0;
        }

        /// <summary>
        /// Constructor with all parameters.
        /// </summary>
        /// <param name="pBombId"></param>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pSerialNumber"></param>
        /// <param name="pServiceDate"></param>
        /// <param name="pPurchaseDate"></param>
        /// <param name="pPositionId"></param>
        /// <param name="pFarmId"></param>
        public Bomb(long pBombId, String pName, String pShortName, String pSerialNumber, DateTime pServiceDate,
            DateTime pPurchaseDate, long pPositionId, long pFarmId) 
        {
            this.BombId = pBombId;
            this.Name = pName;
            this.ShortName = pShortName; 
            this.SerialNumber = pSerialNumber;
            this.ServiceDate = pServiceDate;
            this.PurchaseDate = pPurchaseDate;
            this.PositionId = pPositionId;
            this.FarmId = pFarmId;
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
            Bomb lBomb = obj as Bomb;
            return this.Name.Equals(lBomb.Name)
                && this.SerialNumber.Equals(lBomb.SerialNumber);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}