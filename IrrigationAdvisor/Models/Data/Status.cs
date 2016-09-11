using IrrigationAdvisor.Models.Utilities;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Data
{
    /// <summary>
    /// Create: 2016-09-11
    /// Author: rodouy 
    /// Description: 
    ///     Status of the web
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
    ///     - ClassTemplate()      -- constructor
    ///     - ClassTemplate(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Status
    {

        #region Consts
        private static Logger logger = LogManager.GetCurrentClassLogger();
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - name: the name of the instance
        ///     
        /// </summary>

        private long statusId;
        private String name;
        private DateTime dateOfReference;
        private Utils.IrrigationAdvisorWebStatus webStatus;
        private String description;

        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>

        public long StatusId
        {
            get { return statusId; }
            set { statusId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime DateOfReference
        {
            get { return dateOfReference; }
            set { dateOfReference = value; }
        }

        public Utils.IrrigationAdvisorWebStatus WebStatus
        {
            get { return webStatus; }
            set { webStatus = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public Status()
        {
            this.StatusId = 0;
            this.Name = "noname";
            this.DateOfReference = Utils.MIN_DATETIME;
            this.WebStatus = Utils.IrrigationAdvisorWebStatus.WithNoData;
            this.Description = "";
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pStatusId"></param>
        /// <param name="pName"></param>
        /// <param name="pDateOfReference"></param>
        /// <param name="pWebStatus"></param>
        /// <param name="pDescription"></param>
        public Status(long pStatusId, String pName, DateTime pDateOfReference,
                      Utils.IrrigationAdvisorWebStatus pWebStatus, String pDescription)
        {
            this.StatusId = pStatusId;
            this.Name = pName;
            this.DateOfReference = pDateOfReference;
            this.WebStatus = pWebStatus;
            this.Description = pDescription;
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
            Status lStatus = obj as Status;
            return this.Name.Equals(lStatus.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        #endregion

    }
}