using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Security
{
    public class UserAccess
    {
        /// <summary>
        /// Create: 2017-03-27
        /// Author: cristiang
        /// Description: 
        ///     Log the user login and logout in the site
        /// 
        /// References:
        ///     Utilities
        ///     User
        /// Dependencies:
        /// 
        /// 
        /// TODO:
        ///     UnitTest
        /// 
        /// -----------------------------------------------------------------
        /// Fields of User:
        ///     - userAccessId long
        ///     - user User
        ///     - logInDate DateTime
        ///     - logOutDate DateTime
        /// 
        /// Methods:
        ///     - User()
        ///     - User(name, surname, email, password)
        ///   
        /// </summary>


        #region Consts
        #endregion

        #region Fields

        private long userAccessId;
        private long userId;
        private DateTime logInDate;
        private DateTime logOutDate;

        #endregion

        #region Properties
        
        [Key]
        public long UserAccessId
        {
            get { return userAccessId; }
            set { userAccessId = value; }
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

        public DateTime LogInDate
        {
            get { return logInDate; }
            set { logInDate = value; }
        }

        public DateTime? LogOutDate
        {
            get { return logOutDate; }
            set
            {
                if (value == null)
                {
                    logOutDate = Utils.MIN_DATETIME;
                }
                else
                {
                    logOutDate = (DateTime)value;
                }
            }
        }

        #endregion

        #region Construction
        /// <summary>
        /// Constructor of UserAccess
        /// </summary>
        public UserAccess()
        {
            this.LogInDate = Utils.MIN_DATETIME;
            this.LogOutDate = Utils.MAX_DATETIME;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pUserAccessId"></param>
        /// <param name="pUser"></param>
        /// <param name="pLogInDate"></param>
        /// <param name="pLogOutDate"></param>
        public UserAccess(long pUserAccessId, User pUser,
                        DateTime pLogInDate, DateTime pLogOutDate)
        {
            this.UserAccessId = pUserAccessId;
            this.UserId = pUser.UserId;
            this.User = pUser;
            this.LogInDate = pLogInDate;
            this.LogOutDate = pLogOutDate;
        }

        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods
        #endregion

        #region Overrides

        /// <summary>
        /// override object.Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            UserAccess lUserAccess = obj as UserAccess;
            return this.UserAccessId.Equals(lUserAccess.UserAccessId);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            return this.UserAccessId.GetHashCode();
        }
        #endregion

    }
}