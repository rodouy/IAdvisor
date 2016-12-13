using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Utilities;
using System.Data;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Localization;


namespace IrrigationAdvisor.Models.Agriculture
{
    /// <summary>
    /// Create: 2015-06-06
    /// Author: monicarle
    /// Description: 
    ///     It represents a specific day in the phenology.
    ///     It depends on the sowing date, average temperature registry, 
    ///     crop coefficient
    ///     
    /// References:
    ///     CropIrrigationWeather
    ///     
    /// Dependencies:
    ///     CropCoefficient
    ///     Stage
    ///     PhenologicalStage
    ///     Specie
    /// 
    /// TODO: 
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     - phenologicalStage:            PhenologicalStage  - PK
    ///     - sowingDate:                   DateTime           - PK
    ///     - currentDate:                  DateTime           - PK
    ///     - accumulatedGrowingDegreeDays: double
    ///     - cropCoefficientValue:         double
    ///     
    /// Methods:
    ///     - CropInformationByDate()     -- constructor
    ///     - CropInformationByDate(???)  -- consturctor with parameters
    ///     
    /// </summary>
    public class CropInformationByDate
    {

        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// The fields are:
        ///     - sowingDate:                   DateTime           - PK
        ///     - currentDate:                  DateTime           - PK
        ///     - accumulatedGrowingDegreeDays: double
        ///     - cropCoefficientValue:         double 
        /// CropInformationByDate    
        /// 
        /// modelo un calculo
        /// 
        /// datos: pasar por parametro o consultar e
        /// 
        /// </summary>
        /// 
        
        private long cropInformationByDateId;
        private String name;
        #region Crop Data
        private DateTime sowingDate;
        private int daysAfterSowing;
        private long specieId;
        private long cropCoefficientId;
        private long regionId; 
        private List<PhenologicalStage> phenologicalStageList;
        #endregion

        #region Current Data
        private DateTime currentDate;
        private Double accumulatedGrowingDegreeDays;
        private long stageId;
        private Double cropCoefficientValue;
        private Double rootDepth;
        #endregion
        
        #endregion

        #region Properties

        public long CropInformationByDateId
        {
            get { return cropInformationByDateId; }
            set { cropInformationByDateId = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public DateTime SowingDate
        {
            get { return sowingDate; }
            set { sowingDate = value; }
        }

        public DateTime CurrentDate
        {
            get { return currentDate; }
            set { currentDate = value; }
        }

        public int DaysAfterSowing
        {
            get { return daysAfterSowing; }
            set { daysAfterSowing = value; }
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

        public long CropCoefficientId
        {
            get { return cropCoefficientId; }
            set { cropCoefficientId = value; }
        }

        public virtual CropCoefficient CropCoefficient
        {
            get;
            set;
        }

        public long RegionId
        {
            get { return regionId; }
            set { regionId = value; }
        }

        public virtual Region Region
        {
            get;
            set;
        }
        
        public List<PhenologicalStage> PhenologicalStageList
        {
            get { return phenologicalStageList; }
            set { phenologicalStageList = value; }
        }

        public double AccumulatedGrowingDegreeDays
        {
            get { return accumulatedGrowingDegreeDays; }
            set { accumulatedGrowingDegreeDays = value; }
        }

        public long StageId
        {
            get { return stageId; }
            set { stageId = value; }
        }

        public virtual Stage Stage
        {
            get;
            set;
        }

        public double CropCoefficientValue
        {
            get { return cropCoefficientValue; }
            set { cropCoefficientValue = value; }
        }
        
        public double RootDepth
        {
            get { return rootDepth; }
            set { rootDepth = value; }
        }

        #endregion

        #region Construction

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public CropInformationByDate()
        {
            this.Name = "noname";
            this.SowingDate = Utils.MIN_DATETIME;
            this.DaysAfterSowing = 0;
            this.SpecieId = 0;
            this.CropCoefficientId = 0;
            this.RegionId = 0;
            this.PhenologicalStageList = new List<PhenologicalStage>();
            this.AccumulatedGrowingDegreeDays = 0;
            this.StageId = 0;
            this.CropCoefficientValue = 0;
            this.RootDepth = 0;
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pRegion"></param>
        /// <param name="pPhenologicalStageList"></param>
        public CropInformationByDate(Specie pSpecie, DateTime pSowingDate, 
                                    CropCoefficient pCropCoefficient, Region pRegion,
                                    List<PhenologicalStage> pPhenologicalStageList)
        {
            this.Name = pSpecie.Name;
            this.SowingDate = pSowingDate;
            this.DaysAfterSowing = 0;
            this.SpecieId = pSpecie.SpecieId;
            this.CropCoefficientId = pCropCoefficient.CropCoefficientId;
            this.RegionId = pRegion.RegionId;
            this.PhenologicalStageList = pPhenologicalStageList;
            this.AccumulatedGrowingDegreeDays = 0;
            this.StageId = 0;
            this.CropCoefficientValue = 0;
            this.RootDepth = 0;
        }

        /// <summary>
        /// Constructor with all parameters
        /// </summary>
        /// <param name="pSpecie"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pCropCoefficient"></param>
        /// <param name="pRegion"></param>
        /// <param name="pStageId"></param>
        /// <param name="pCropCoefficientValue"></param>
        /// <param name="pRootDepth"></param>
        /// <param name="pPhenologicalStageList"></param>
        public CropInformationByDate(Specie pSpecie, DateTime pSowingDate,
                                    CropCoefficient pCropCoefficient, Region pRegion,
                                    long pStageId, Double pCropCoefficientValue,
                                    Double pRootDepth,
                                    List<PhenologicalStage> pPhenologicalStageList)
        {
            this.Name = pSpecie.Name;
            this.SowingDate = pSowingDate;
            this.DaysAfterSowing = 0;
            this.SpecieId = pSpecie.SpecieId;
            this.CropCoefficientId = pCropCoefficient.CropCoefficientId;
            this.RegionId = pRegion.RegionId;
            this.PhenologicalStageList = pPhenologicalStageList;
            this.AccumulatedGrowingDegreeDays = 0;
            this.StageId = pStageId;
            this.CropCoefficientValue = pCropCoefficientValue;
            this.RootDepth = pRootDepth;
        }


        #endregion

        #region Private Helpers

        #region MagicTable

        /// <summary>
        /// Return AccumulatedGrowingDegreeDays for the days between SowingDate & CurrentDate
        /// </summary>
        /// <param name="pSowingDate"></param>
        /// <param name="pCurrentDate"></param>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pStressTemperature"></param>
        /// <returns></returns>
        public Double GetAccumulatedGrowingDegreeDays(DateTime pSowingDate, DateTime pCurrentDate,
                                                    Double pBaseTemperature, Double pStressTemperature)
        {
            Double lReturn = 0;
            Double lAccumulatedGrowingDegreeDays = 0;

            lAccumulatedGrowingDegreeDays = this.Region.GetAccumulatedGrowingDegreeDays(pSowingDate,
                                                        pCurrentDate, pBaseTemperature,
                                                        pStressTemperature, -pBaseTemperature);
            
            lReturn = lAccumulatedGrowingDegreeDays;

            return lReturn;
        }

        /// <summary>
        /// Return the GrowingDegreeDays
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <param name="pBaseTemperature"></param>
        /// <param name="pStressTemperature"></param>
        /// <returns></returns>
        public Double GetGrowingDegreeDays(DateTime pCurrentDate, Double pBaseTemperature, Double pStressTemperature)
        {
            Double lReturn = 0;
            Double lGrowingDegreeDays = 0;

            lGrowingDegreeDays = this.Region.GetGrowingDegreeDays(pCurrentDate, pBaseTemperature, 
                                                                pStressTemperature, -pBaseTemperature);

            lReturn = lGrowingDegreeDays;
            return lReturn;
        }


        #region OLD using DataTable


        public Double GetAccumulatedGrowingDegreeDaysOld(DateTime pSowingDate, DateTime pCurrentDate,
                                                            Double pBaseTemperature)
        {
            Double lReturn = 0;
            Double lAccumulatedGrowingDegreeDays = 0;
            Double lTemperature;
            Double lGrowingDegreeDays;
            DataTable lTemperature_Information;
            DateTime lDay;

            //TODO: AddTemperatureInformation transform to method by date
            lTemperature_Information = InitialTables.AddTemperatureInformation();

            foreach (DataRow row in lTemperature_Information.Rows)
            {
                lDay = row.Field<DateTime>(0);
                if (Utils.IsBetweenDatesWithoutYear(pSowingDate, pCurrentDate, lDay))
                {
                    lTemperature = row.Field<double>(1);
                    lGrowingDegreeDays = lTemperature - pBaseTemperature;
                    lAccumulatedGrowingDegreeDays += lGrowingDegreeDays;
                }
                //TODO: break when lday > pcurrent date
            }

            lReturn = lAccumulatedGrowingDegreeDays;
            return lReturn;
        }
        

        /// <summary>
        /// Return the GrowingDegreeDays
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <param name="pBaseTemperature"></param>
        /// <returns></returns>
        public double GetGrowingDegreeDaysOld(DateTime pCurrentDate, Double pBaseTemperature)
        {
            Double lReturn;
            Double lTemperature = 0;
            Double lGrowingDegreeDays = 0;
            DataTable lTemperature_Information;
            DateTime lDay;

            lTemperature_Information = InitialTables.AddTemperatureInformation();

            foreach (DataRow row in lTemperature_Information.Rows)
            {
                lDay = row.Field<DateTime>(0);
                if (Utils.IsTheSameDayWithoutYear(lDay, pCurrentDate))
                {
                    lTemperature = row.Field<double>(1);
                    lGrowingDegreeDays = lTemperature - pBaseTemperature;
                    break;
                }
            }

            lReturn = lGrowingDegreeDays;
            return lReturn;
        }

        #endregion

        #endregion

        /// <summary>
        /// Given a Current Date set:
        /// - DaysAfterSowing
        /// - AccumulatedGrowingDegreeDays
        /// - Stage
        /// - CropCoefficient
        /// - RootDepth
        /// </summary>
        /// <param name="pCurrentDate"></param>
        private void setFieldsAccordingCurrentDate(DateTime pCurrentDate)
        {
            List<Pair<Stage, int>> lStageDurationInformation;
            int lDaysAfterSowing = 0;

            //Set DaysAfterSowing
            this.CurrentDate = pCurrentDate;
            this.DaysAfterSowing = Utils.GetDaysDifference(this.SowingDate, this.CurrentDate);

            //Set AccumulatedGrowingDegreeDays
            this.AccumulatedGrowingDegreeDays = GetAccumulatedGrowingDegreeDays(this.SowingDate, 
                                                this.CurrentDate, this.Specie.BaseTemperature, 
                                                this.Specie.StressTemperature);

            //Set Stage
            lStageDurationInformation = getStageDurationInformation();
            foreach (Pair<Stage, int> lPairStage in lStageDurationInformation)
            {
                lDaysAfterSowing += lPairStage.Second;
                if (lDaysAfterSowing >= this.DaysAfterSowing)
                {
                    this.Stage = lPairStage.First;
                    break;
                }
                              
            }

            //Set cropCoefficientValue
            this.CropCoefficientValue = this.CropCoefficient.GetCropCoefficient(this.DaysAfterSowing);

            //Set rootDepth
            this.setPhenologicalStage(this.AccumulatedGrowingDegreeDays);
            
        }

        /// <summary>
        /// Given Growing Degree Days set:
        ///     - set fields according Current Date
        ///     - Days After Sowing 
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        private void setFieldsAccordingGrowingDegreeDays(Double pGrowingDegreeDays)
        {
            DateTime lCurrentDate;
            Double lGrowingDegreeDays;
            int lDaysAfterSowing;
            int lMaxDayAfterSowing;
            int lDegreeDays_PerDay;

            lMaxDayAfterSowing = InitialTables.MAX_DAY_AFTER_SOWING_TO_IRRIGATE;
            lDegreeDays_PerDay = InitialTables.DEGREE_DAYS_PER_DAY;

            lDaysAfterSowing = (int)pGrowingDegreeDays / lDegreeDays_PerDay;

            if (lDaysAfterSowing > 10)
            {
                lDaysAfterSowing = 0;
            }

            for ( ; lDaysAfterSowing < lMaxDayAfterSowing; lDaysAfterSowing++)
            {
                lCurrentDate = this.SowingDate.AddDays(lDaysAfterSowing);
                setFieldsAccordingCurrentDate(lCurrentDate);
                lGrowingDegreeDays = this.AccumulatedGrowingDegreeDays;
                if(lGrowingDegreeDays >= pGrowingDegreeDays)
                {
                    break;
                }
            }

        }

        /// <summary>
        /// Return Phenological Stage by Growing Degree Days
        /// is between Min & Max Degrees
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        private PhenologicalStage setPhenologicalStage(Double pGrowingDegreeDays)
        {
            PhenologicalStage lReturn = null;
            
            foreach (PhenologicalStage lPhenologicalStage in this.PhenologicalStageList)
            {
                if(pGrowingDegreeDays >= lPhenologicalStage.MinDegree && pGrowingDegreeDays <= lPhenologicalStage.MaxDegree)
                {
                    lReturn = lPhenologicalStage;
                    break;
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Return a copy of Stage List from Phenological Stage List
        /// </summary>
        /// <returns></returns>
        private List<Stage> getStageList()
        {
            List<Stage> lReturn = new List<Stage>();
            foreach (PhenologicalStage lPhenologicalStage in this.PhenologicalStageList)
            {
                lReturn.Add(lPhenologicalStage.Stage);
            }
            return lReturn;
        }

        /// <summary>
        /// Get Duration in days by Stage, depends in the Specie
        /// </summary>
        /// <returns></returns>
        private List<Pair<Stage, int>> getStageDurationInformation()
        {
            //TODO Sacar hardcodeo de nombre de especies 
            List<Pair<Stage, int>> lReturn = null;
            List<Pair<Stage, int>> lStageDurationInDays = null;
            List<Stage> lStageList = null;

            lStageList = this.getStageList();
            if (this.Specie.Name.Equals(Utils.NameSpecieCornSouthShort))
            {
                lStageDurationInDays = InitialTables.GetCropInformationByDateForSoja(this.SowingDate, lStageList);
            }
            else if (this.Specie.Name.Equals(Utils.NameSpecieSoyaSouthShort))
            {
                lStageDurationInDays = InitialTables.GetCropInformationByDateForMaiz(this.SowingDate, lStageList);
            }
            else if (this.Specie.Name.ToUpper().Equals("SORGO"))
            {
                //TODO: SORGO magic table
            }

            lReturn = lStageDurationInDays;
            return lReturn;
        }

        #endregion

        #region Public Methods

        #region Information by CURRENT_DATE

        /// <summary>
        /// Return the Stage that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public Stage GetStage(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.Stage;
        }

        /// <summary>
        /// Return the CropCoefficient that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public Double GetCropCoefficient(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.CropCoefficientValue;
        }

        /// <summary>
        /// Return the Acumulated Growing Degree Days that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public double GetAccumulatedGrowingDegreeDays(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.AccumulatedGrowingDegreeDays;
        }

        /// <summary>
        /// Return the Day After Sowing that should be a crop at a CurrentDate parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pCurrentDate"></param>
        /// <returns></returns>
        public int GetDaysAfterSowing(DateTime pCurrentDate)
        {
            this.setFieldsAccordingCurrentDate(pCurrentDate);
            return this.DaysAfterSowing;
        }

        #endregion

        #region Information By DAYS_AFTER_SOWING

        /// <summary>
        /// Return the Stage that should be a crop at a Day After Sowing parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <returns></returns>
        public Stage GetStage(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.Stage;
        }

        /// <summary>
        /// Return the CropCoefficient that should be a crop at a Day After Sowing parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <returns></returns>
        public Double GetCropCoefficient(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.CropCoefficientValue;
        
       }

        /// <summary>
        /// Return the Acumulated Growing Degree Days that should be a crop at Day After Sowing parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <returns></returns>
        public double GetAccumulatedGrowingDegreeDays(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.AccumulatedGrowingDegreeDays;
        }

        /// <summary>
        /// Return the Day After Sowing that should be a crop at Day after Sowing parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pDayAfterSowing"></param>
        /// <returns></returns>
        public int GetDaysAfterSowing(int pDayAfterSowing)
        {
            DateTime lCurrentDate = this.SowingDate.AddDays(pDayAfterSowing);
            this.setFieldsAccordingCurrentDate(lCurrentDate);
            return this.DaysAfterSowing;
        }

        #endregion

        #region Information By GrowingDegreeDays()

        /// <summary>
        /// Return the Stage that should be a crop at a Growing Degree Days parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        public Stage GetStage(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.Stage;
        }

        /// <summary>
        /// Return the CropCoefficient that should be a crop at a Growing Degree days parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        public Double GetCropCoefficient(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.CropCoefficientValue;

        }

        /// <summary>
        /// Return the Acumulated Growing Degree Days that should be a crop at Growing degree days parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        public double GetAccumulatedGrowingDegreeDays(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.AccumulatedGrowingDegreeDays;
        }

        /// <summary>
        /// Return the Day After Sowing that should be a crop at Growing degree days parameter
        /// Using information of INIA
        /// </summary>
        /// <param name="pGrowingDegreeDays"></param>
        /// <returns></returns>
        public int GetDaysAfterSowing(Double pGrowingDegreeDays)
        {
            this.setFieldsAccordingGrowingDegreeDays(pGrowingDegreeDays);
            return this.DaysAfterSowing;
        }

        #endregion
    
        #endregion

        #region Overrides
        #endregion


    }
}