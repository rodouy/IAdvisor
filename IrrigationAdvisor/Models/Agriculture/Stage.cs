using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models.Agriculture
{

    /// <summary>
    /// Create: 2014-10-14
    /// Author: monicarle
    /// Modified: 2015-06-14
    /// Author: rodouy
    /// Description: 
    ///     Is like the label of a Phenological Stage
    ///     
    /// References:
    ///     none
    ///     
    /// Dependencies:
    ///     PhenologialStage
    ///     IrrigationRecords
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - stageId long
    ///     - name String           PK
    ///     - definition String
    ///     - order int
    /// 
    /// Methods:
    ///     - Stage()      -- constructor
    ///     - Stage(name, definition)  -- consturctor with parameters
    ///     
    /// </summary>
    public class Stage
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - stageId: identifier of state
        ///     - name: the name of the stage
        ///     - description
        ///     - order
        /// </summary>
        private long stageId;
        private String name;
        private String shortName;
        private String description;
        private int order;

        #endregion

        #region Properties
        /// <summary>
        /// The properties are:
        ///     - Name: the name of the instance
        /// </summary>


        public long StageId
        {
            get { return stageId; }
            set { stageId = value; }
        }


        [Required]
        [Display(Name = "Nombre")]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        [Display(Name = "Nombre corto")]
        public String ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }

        [Display(Name = "Descirpción")]
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [Required]
        [Display(Name = "Orden")]
        public int Order
        {
            get { return order; }
            set { order = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor of ClassTemplate
        /// </summary>
        public Stage()
        {
            this.StageId = 0;
            this.Name = "noname";
            this.ShortName = "";
            this.Description = "";
            this.Order = 0;
        }

        /// <summary>
        /// Constructor of ClassTemplate with parameters
        /// </summary>
        /// <param name="pStageId"></param>
        /// <param name="pName"></param>
        /// <param name="pShortName"></param>
        /// <param name="pDescription"></param>
        /// <param name="pOrder"></param>
        public Stage(long pStageId, String pName, String pShortName,
                    String pDescription, int pOrder)
        {
            this.StageId = pStageId;
            this.Name = pName;
            this.ShortName = pShortName;
            this.Description = pDescription;
            this.Order = pOrder;
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
            Stage lStage = obj as Stage;
            return this.Name.Equals(lStage.Name);
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        #endregion

    }
}
