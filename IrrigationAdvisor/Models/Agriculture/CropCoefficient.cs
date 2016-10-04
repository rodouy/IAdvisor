using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using IrrigationAdvisor.Models.Localization;
using NLog;

namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2014-10-26
    /// Author: monicarle
    /// Modified: 2015-01-08
    /// Author: rodouy
    /// Description: 
    ///     Returns the CropCoefficient for a Specie in a Region 
    ///     It depends on the days after sowing
    ///     
    /// References:
    ///     KC
    ///     
    /// Dependencies:
    ///     Crop
    ///     CropInformationByDate
    ///     IrrigationUnit
    /// 
    /// TODO: 
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - cropCoefficientId long
    ///     - kcList List<double>
    ///     
    /// 
    /// Methods:
    ///     - CropCoefficient()      -- constructor
    ///     - CropCoefficient(cropCoefficientId, kcList)  -- consturctor with parameters
    ///     - GetCropCoefficient(days)     -- method to get the name KC
    /// 
    /// </summary>
    
    public class CropCoefficient
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - cropCoefficientId long
        ///     - kcList List<double>
        ///     
        /// </summary>
        private long cropCoefficientId;
        private String name;
        private long specieId;
        private List<KC> kcList;

        private static Logger logger = LogManager.GetCurrentClassLogger();


        #endregion

        #region Properties


        public long CropCoefficientId
        {
            get { return cropCoefficientId; }
            set { cropCoefficientId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public long SpecieId
        {
            get { return specieId; }
            set { specieId = value; }
        }

        public virtual Specie Specie
        {
            get;
            set;
        }

        public List<KC> KCList
        {
            get { return kcList; }
            set { kcList = value; }
        }
        
        
        #endregion

        #region Construction

        /// <summary>
        /// Constructor of CropCoefficient
        /// UsingTable: field used to return the cropCroefficient. 
        /// - False: return the cropCoefficient from the list (day by day). 
        /// - True: return the cropCoefficient from the table (with 4 fixed points) 
        /// </summary>
        public CropCoefficient()
        {
            this.CropCoefficientId = 0;
            this.Name = "NoName";
            this.SpecieId = 0;
            this.KCList = new List<KC>();
        }

        /// <summary>
        /// Constructor of CropCoefficient with Id and KC List as parameters
        /// </summary>
        /// <param name="pCropCoefficientId"></param>
        /// <param name="pKCList"></param>
        public CropCoefficient(long pCropCoefficientId, List<KC> pKCList)
                                
        {
            this.CropCoefficientId = pCropCoefficientId;
            this.Name = "";
            this.SpecieId = 0;
            this.KCList = pKCList;            
        }

        /// <summary>
        /// Constructor of CropCoefficient with all paramenters
        /// </summary>
        /// <param name="pCropCoefficientId"></param>
        /// <param name="pName"></param>
        /// <param name="pSpecieId"></param>
        /// <param name="pKCList"></param>
        public CropCoefficient(long pCropCoefficientId, String pName,
                               long pSpecieId, List<KC> pKCList)
        {
            this.CropCoefficientId = pCropCoefficientId;
            this.Name = pName;
            this.SpecieId = pSpecieId;
            this.KCList = pKCList;
        }

        #endregion

        #region Private Helpers

        
        /// <summary>
        /// Returns the Coefficient using KC List 
        /// witch Day After Sowing is passed by parameters
        /// </summary>
        /// <param name="pDays"></param>
        /// <returns></returns>
        private Double getKCFromList(int pDays)
        {
            Double lReturn = 0;
            KC lKC = null;
            try
            {
                if(pDays >= this.KCList.Count)
                {
                    return -1;
                }
                foreach (KC item in this.KCList)
                {
                    if(item.DayAfterSowing == pDays)
                    {
                        lKC = item;
                        break;
                    }
                }
                lReturn = lKC.Coefficient;
            }
            catch(Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in CropCoefficient.getKCFromList" + ex.Message);
                lReturn = -1;
            }
            return lReturn;
        }

        /// <summary>
        /// Returns the Coefficient using KC List 
        /// witch Day After Sowing and Name are passed by parameters
        /// </summary>
        /// <param name="pName"></param>
        /// <param name="pDays"></param>
        /// <returns></returns>
        private Double getKCFromList(long pSpecieId, int pDays)
        {
            Double lReturn = 0;
            KC lKC = null;
            try
            {
                foreach (KC item in this.KCList
                    .Where(kc => kc.SpecieId == pSpecieId))
                {
                    if (item.DayAfterSowing == pDays)
                    {
                        lKC = item;
                        break;
                    }
                }
                lReturn = lKC.Coefficient;
            }
            catch (Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in CropCoefficient.getKCFromList" + ex.Message);
                lReturn = -1;
            }
            return lReturn;
        }
        
        #endregion

        #region Public Methods

        /// <summary>
        /// Add or Update a value to the list of KC
        /// Index 0 value == 0;
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <param name="pCoefficient"></param>
        /// <returns></returns>
        public bool AddOrUpdateKCforDayAfterSowing(long pSpecieId, int pDayAfterSowing, double pCoefficient)
        {
            bool lReturn = false;
            KC lKC = null;
            try
            {
                foreach (KC item in this.KCList)
                {
                    if(item.DayAfterSowing == pDayAfterSowing)
                    {
                        item.SpecieId = pSpecieId;
                        item.Coefficient = pCoefficient;
                        lKC = item;
                        lReturn = true;
                        break;
                    }
                }
                if(!lReturn)
                {
                    lKC = new KC(this.KCList.Count, pSpecieId, 
                                pDayAfterSowing, pCoefficient);
                    this.KCList.Add(lKC);
                    lReturn = true;
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex, ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Exception in CropCoefficient.addDayToList" + ex.Message);
            }
            return lReturn;
        }
      
        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing.
        /// </summary>
        /// <param name="pDays">Days after sowing of the Crop</param>
        /// <returns></returns>
        public double GetCropCoefficient(int pDays)
        {
            double lReturn = 0;
            lReturn = this.getKCFromList(pDays);
            
            return lReturn;
        }

        /// <summary>
        /// Returns the KC for a Crop giving the days after sowing filtered by Specie.
        /// </summary>
        /// <param name="pSpecieId"></param>
        /// <param name="pDays"></param>
        /// <returns></returns>
        public Double GetCropCoefficient(long pSpecieId, int pDays)
        {
            Double lReturn = 0;
            lReturn = this.getKCFromList(pSpecieId, pDays);

            return lReturn;
        }
        
        #endregion

        #region Overrides
        // Different region for each class override

        /// <summary>
        /// Overrides equals
        /// name, region, specie
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool lReturn = false;
            if (obj == null || obj.GetType() != this.GetType())
            {
                return false;
            }
            CropCoefficient lCropCoefficient = obj as CropCoefficient;
            lReturn = this.CropCoefficientId.Equals(lCropCoefficient.CropCoefficientId);
            return lReturn;
        }

        public override int GetHashCode()
        {
            return this.CropCoefficientId.GetHashCode();
        }
        
        #endregion

    }
}