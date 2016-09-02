using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    /// <summary>
    /// Create: 2016-08-30
    /// Author: rodouy
    /// Description: 
    ///     Integrate User and Farm
    ///     
    /// References:
    ///     User
    ///     Farm
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
    ///     - UserFarm()      -- constructor
    ///     - UserFarm(userId, farmId, name)  -- consturctor with parameters
    ///     
    /// </summary>
    public class UserFarm
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - userFarmId
        ///     - userId
        ///     - farmId
        ///     - name
        ///     - startDate
        /// </summary>
        private long userFarmId;
        private long userId;
        private long farmId;
        private String name;
        private DateTime startDate;

        #endregion

        #region Properties

        public long UserFarmId
        {
            get { return userFarmId; }
            set { userFarmId = value; }
        }

        public long UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public virtual User User 
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

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of UserFarm
        /// </summary>
        public UserFarm()
        {
            this.UserFarmId = 0;
            this.UserId = 0;
            this.FarmId = 0;
            this.Name = "NoName";
            this.StartDate = Utils.MIN_DATETIME;
        }

        /// <summary>
        /// Constructor with all the parameters
        /// </summary>
        /// <param name="pUserFarmId"></param>
        /// <param name="pUserId"></param>
        /// <param name="pFarmId"></param>
        /// <param name="pName"></param>
        /// <param name="pStartDate"></param>
        public UserFarm(long pUserFarmId, long pUserId, long pFarmId, 
                        String pName, DateTime pStartDate)
        {
            this.UserFarmId = pUserFarmId;
            this.UserId = pUserId;
            this.FarmId = pFarmId;
            this.Name = pName;
            this.StartDate = pStartDate;
        }

        /// <summary>
        /// Constructor with all the parameters
        /// </summary>
        /// <param name="pUserFarmId"></param>
        /// <param name="pUserId"></param>
        /// <param name="pFarmId"></param>
        /// <param name="pName"></param>
        /// <param name="pStartDate"></param>
        public UserFarm(long pUserFarmId, User pUser, Farm pFarm,
                        String pName, DateTime pStartDate)
        {
            this.UserFarmId = pUserFarmId;
            this.UserId = pUser.UserId;
            this.FarmId = pFarm.FarmId;
            this.Name = pName;
            this.StartDate = pStartDate;
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
            UserFarm lUserFarm = obj as UserFarm;
            return this.UserId.Equals(lUserFarm.UserId)
                && this.FarmId.Equals(lUserFarm.FarmId);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}