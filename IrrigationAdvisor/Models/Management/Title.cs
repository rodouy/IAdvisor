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
    ///     - Title()      -- constructor
    ///     - Title(name)  -- consturctor with parameters
    ///     - SetName(newName)     -- method to set the name field
    /// 
    /// </summary>
    public class Title
    {
        #region Consts
        #endregion

        #region Fields

        private long titleId;
        private long cropIrrigationWeatherId;
        private bool daily;
        private String name;
        private String description;
        private String abbreviation;

        #endregion

        #region Properties

        public long TitleId
        {
            get { return titleId; }
            set { titleId = value; }
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

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Abbreviation
        {
            get { return abbreviation; }
            set { abbreviation = value; }
        }
 
        #endregion

        #region Construction
        /// <summary>
        /// Constructor of Title
        /// </summary>
        public Title()
        {
            this.TitleId = 0;
            this.CropIrrigationWeatherId = 0;
            this.Daily = false;
            this.Name = "";
            this.Description = "";
            this.Abbreviation = "";

        }

        /// <summary>
        /// Contructor of Title with minimum parameters
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pDaily"></param>
        /// <param name="pName"></param>
        public Title(long pTitleId, long pCropIrrigationWeatherId, 
                        bool pDaily, String pName)
        {
            this.TitleId = pTitleId;
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
            this.Daily = pDaily;
            this.Name = pName;
            this.Description = "";
            this.Abbreviation = "";

        }

        /// <summary>
        /// Constructor of Title with parameters
        /// </summary>
        /// <param name="pTitleId"></param>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pTitles"></param>
        public Title(long pTitleId, long pCropIrrigationWeatherId,
                        bool pDaily, String pName,
                        String pDescription, String pAbbreviation)
        {
            this.TitleId = pTitleId;
            this.CropIrrigationWeatherId = pCropIrrigationWeatherId;
            this.Daily = pDaily;
            this.Name = pName;
            this.Description = pDescription;
            this.Abbreviation = pAbbreviation;
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
            Title lTitle = obj as Title;
            return this.CropIrrigationWeatherId == lTitle.CropIrrigationWeatherId
                && this.Name == lTitle.Name
                && this.Daily == lTitle.Daily;
        }

        public override int GetHashCode()
        {
            return this.CropIrrigationWeatherId.GetHashCode();
        }

        #endregion

    }
}