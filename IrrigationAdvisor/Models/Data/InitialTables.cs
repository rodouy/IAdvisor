using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using IrrigationAdvisor.Models.Utilities;
using NLog;

namespace IrrigationAdvisor.Models.Data
{

    /// <summary>
    /// Create: 2015-01-05
    /// Author: rodouy
    /// Description: 
    ///     These class will contain all the data that initialize the system.
    ///     
    /// References:
    ///     - Specie
    ///     - Region
    ///     - IrrigationSystem
    ///     - CropCoefficient
    ///     - EffectiveRainList
    ///     - PhenologicalStage
    ///     
    /// Dependencies:
    ///     - IrrigationAdvisor
    ///     - IrrigationCalculous
    ///     - Horizon
    ///     - cropIrrigationWeatherRecord
    ///     - IrrigationSystem
    /// 
    /// TODO: OK
    ///     UnitTest
    ///     
    /// -----------------------------------------------------------------
    /// Fields of Class:
    ///     
    /// 
    /// Methods:
    ///     - CreateUpdateCropCoefficient_CornSouthShort(Specie pSpecieCycle, Region pRegionList) 
    ///     - CreateUpdateCropCoefficient_SoyaSouthShort(Specie pSpecieCycle, Region pRegionList)
    ///     - AddEffectiveRainListToSystem(Region lRegion)
    ///     - CreatePhenologicalStageList(IrrigationSystem.IrrigationSystem pIrrigationSystem,
    ///                    Specie pSpecieCycle,  Specie pSpecieSoja)
    /// 
    /// </summary>
    public static class InitialTables
    {

        #region Constants

        #region IrrigationCalculous
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public const double PERCENTAGE_OF_AVAILABE_WATER_TO_IRRIGATE = 60;
        public const int DAYS_FOR_PREDICTION = 9;
        public const int DAYS_FOR_WEATHER_PREDICTION = DAYS_FOR_PREDICTION + 2;
        public const int DAYS_TO_STOP_CROP_GROWS = 145;
        public const int DAYS_PREVIOUS_TO_CHANGE_PHENOLOGICAL_STAGE = 7;
        public const int MAX_SELECTABLE_STAGE_TO_CHANGE_PHENOLOGICAL_STAGE = 2;
        public const int MIN_SELECTABLE_STAGE_TO_CHANGE_PHENOLOGICAL_STAGE = 2;
        public const double PERCENTAGE_OF_MAX_EVAPOTRANSPIRATION_TO_IRRIGATE = 70;

        #endregion

        #region Horizon
        public const double HORIZON_A_FIELD_CAPACITY_GENERAL_ADJ_COEF = 21.977;
        public const double HORIZON_A_FIELD_CAPACITY_SAND_ADJ_COEF = 0.168;
        public const double HORIZON_A_FIELD_CAPACITY_CLAY_ADJ_COEF = 0.127;
        public const double HORIZON_A_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 2.601;

        public const double HORIZON_A_PERM_WILTING_POINT_GENERAL_ADJ_COEF = 58.1313;
        public const double HORIZON_A_PERM_WILTING_POINT_SAND_ADJ_COEF = 0.5683;
        public const double HORIZON_A_PERM_WILTING_POINT_LIMO_ADJ_COEF = 0.6414;
        public const double HORIZON_A_PERM_WILTING_POINT_CLAY_ADJ_COEF = 0.9755;
        public const double HORIZON_A_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.3718;

        public const double HORIZON_B_FIELD_CAPACITY_GENERAL_ADJ_COEF = 18.448;
        public const double HORIZON_B_FIELD_CAPACITY_SAND_ADJ_COEF = 0.125;
        public const double HORIZON_B_FIELD_CAPACITY_CLAY_ADJ_COEF = 0.295;
        public const double HORIZON_B_FIELD_CAPACITY_ORGANIC_MATTER_ADJ_COEF = 1.923;
         
        public const double HORIZON_B_PERM_WILTING_POINT_GENERAL_ADJ_COEF = 5;
        public const double HORIZON_B_PERM_WILTING_POINT_ORGANIC_MATTER_ADJ_COEF = 0.74;
        #endregion

        #region Weather

        public const double INITIAL_ROOT_DEPTH = 7;

        //2016-02-18 CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED Change from 10 to 5
        public const double CONSIDER_WATER_TO_INITIALIZE_ETC_ACUMULATED = 5;

        //2015-02-12 DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT Change from 2 to 5 
        public const double DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_BIG_WATER_INPUT = 5;

        //2016-10-19 MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT
        public const double MIN_RAIN_TO_CONSIDER_BIG_WATER_INPUT = 3;

        public const double DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_SOWING = 5;

        public const double PERCENTAGE_LIMIT_OF_AVAILABLE_WATER_CAPACITY = 0.10;

        public const double DAYS_BETWEEN_TWO_PARTIAL_BIG_WATER_INPUT = 3;

        //2016-04-17 HYDRIC_BALANCE_PERCENTAGE_TO_CONSIDER_INCREASE
        public const double HYDRIC_BALANCE_PERCENTAGE_TO_CONSIDER_INCREASE = 60;

        //2016-04-17 CONSIDER_PERCENTAGE_IN_HYDRIC_BALANCE_INCREASE
        public const double CONSIDER_PERCENTAGE_IN_HYDRIC_BALANCE_INCREASE = 20;

        //2016-04-17 DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_LARGE_INCREASE
        public const double DAYS_HYDRIC_BALANCE_UNCHANGABLE_AFTER_LARGE_INCREASE = 2;

        //2016-04-17 DAYS_TO_CHECK_HYDRIC_BALANCE_AFTER_LARGE_INCREASE
        public const double DAYS_TO_CHECK_HYDRIC_BALANCE_AFTER_LARGE_INCREASE = 3;

        #endregion

        #region PhenologicalStage

        /// <summary>
        /// Constant for precision for min and max degree ranges calculus.
        /// </summary>
        public const Double ACCURANCY_RANGE_MIN_MAX_DEGREE = 0.005;

        public const String STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_CORN = "V7";
        public const String STAGE_TO_CALCULATE_IRRIGATION_ADVICE_BY_HB_USING_ET_FOR_SOYA = "V7";

        public const String STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_CORN = "R5";
        public const String STAGE_TO_STOP_IRRIGATION_ADVICE_FOR_SOYA = "R7";

        #endregion

        #region CropInformationByDate

        public const String SOWINGDATE_COLUMN_NAME = "SowingDate";
        public const int MAX_DAY_AFTER_SOWING_TO_IRRIGATE = 300;
        public const int DEGREE_DAYS_PER_DAY = 5;

        #endregion

        #region View

        public const int MIN_DAY_SHOW_IN_GRID_BEFORE_TODAY = 2;
        public const int MAX_DAY_SHOW_IN_GRID_AFTER_TODAY = 4;

        #endregion

        #endregion

        #region Private Helpers

        /// <summary>
        /// TODO: to explain
        /// </summary>
        /// <param name="pTableName"></param>
        /// <param name="pStageList"></param>
        /// <returns></returns>
        private static DataTable CreateTableForPhenologyInformation(String pTableName, List<Stage> pStageList)
        {
            DataTable lPhenology;
            DataSet dataSetOfPhenology;

            lPhenology = new DataTable(pTableName);//"Soja_Phenology_Information");
            DataColumn column;

            // Create new DataColumn, set DataType,  
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "SowingDate";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            lPhenology.Columns.Add(column);

            // Make the "SowingDate" column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = lPhenology.Columns["SowingDate"];
            lPhenology.PrimaryKey = PrimaryKeyColumns;
            foreach (Stage lStage in pStageList)
            {
                column = new DataColumn();
                column.ColumnName = lStage.Name;
                column.Caption = lStage.Name;
                column.ReadOnly = false;
                column.Unique = false;
                // Add the column to the table.
                lPhenology.Columns.Add(column);
            }
            
            // Instantiate the DataSet variable.
            dataSetOfPhenology = new DataSet();
            // Add the new DataTable to the DataSet.
            dataSetOfPhenology.Tables.Add(lPhenology);

            return lPhenology;

        }

        /// <summary>
        /// TODO: to explain
        /// </summary>
        /// <param name="pMaiz_Phenology_Information"></param>
        /// <param name="pColumnNames"></param>
        /// <returns></returns>
        private static DataTable AddMaizInformation(DataTable pMaiz_Phenology_Information, List<Stage> pColumnNames)
        {
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 1), pColumnNames, new int[] { 17, 6, 5, 7, 7, 6, 7, 6, 7, 5, 4, 5, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 2), pColumnNames, new int[] { 17, 6, 5, 7, 7, 6, 7, 6, 7, 5, 4, 5, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 3), pColumnNames, new int[] { 17, 6, 5, 7, 7, 6, 7, 6, 7, 5, 4, 5, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 4), pColumnNames, new int[] { 17, 6, 5, 7, 7, 6, 7, 6, 7, 5, 4, 5, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 5), pColumnNames, new int[] { 16, 6, 5, 7, 6, 6, 7, 6, 7, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 6), pColumnNames, new int[] { 16, 6, 5, 7, 6, 6, 7, 6, 7, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 7), pColumnNames, new int[] { 16, 6, 5, 7, 6, 6, 7, 6, 7, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 8), pColumnNames, new int[] { 16, 6, 5, 7, 6, 6, 7, 6, 7, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 9), pColumnNames, new int[] { 16, 6, 5, 7, 6, 6, 7, 6, 7, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 10), pColumnNames, new int[] { 15, 5, 5, 7, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 11), pColumnNames, new int[] { 15, 5, 5, 7, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 12), pColumnNames, new int[] { 15, 5, 5, 7, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 13), pColumnNames, new int[] { 15, 5, 5, 7, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 14), pColumnNames, new int[] { 15, 5, 5, 7, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 3, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 15), pColumnNames, new int[] { 13, 5, 5, 6, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 16), pColumnNames, new int[] { 13, 5, 5, 6, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 17), pColumnNames, new int[] { 13, 5, 5, 6, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 18), pColumnNames, new int[] { 13, 5, 5, 6, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 19), pColumnNames, new int[] { 13, 5, 5, 6, 6, 6, 7, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 20), pColumnNames, new int[] { 12, 5, 4, 7, 6, 5, 6, 6, 7, 4, 4, 4, 4, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 21), pColumnNames, new int[] { 12, 5, 4, 7, 6, 5, 6, 6, 7, 4, 4, 4, 4, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 22), pColumnNames, new int[] { 12, 5, 4, 7, 6, 5, 6, 6, 7, 4, 4, 4, 4, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 23), pColumnNames, new int[] { 12, 5, 4, 7, 6, 5, 6, 6, 7, 4, 4, 4, 4, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 24), pColumnNames, new int[] { 12, 5, 4, 7, 6, 5, 6, 6, 7, 4, 4, 4, 4, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 25), pColumnNames, new int[] { 11, 5, 4, 6, 6, 5, 6, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 26), pColumnNames, new int[] { 11, 5, 4, 6, 6, 5, 6, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 27), pColumnNames, new int[] { 11, 5, 4, 6, 6, 5, 6, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 28), pColumnNames, new int[] { 11, 5, 4, 6, 6, 5, 6, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 29), pColumnNames, new int[] { 11, 5, 4, 6, 6, 5, 6, 6, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 9, 30), pColumnNames, new int[] { 10, 5, 4, 6, 5, 5, 6, 5, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 1), pColumnNames, new int[] { 10, 5, 4, 6, 5, 5, 6, 5, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 2), pColumnNames, new int[] { 10, 5, 4, 6, 5, 5, 6, 5, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 3), pColumnNames, new int[] { 10, 5, 4, 6, 5, 5, 6, 5, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 4), pColumnNames, new int[] { 10, 5, 4, 6, 5, 5, 6, 5, 6, 5, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 5), pColumnNames, new int[] { 10, 4, 4, 6, 5, 5, 6, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 6), pColumnNames, new int[] { 10, 4, 4, 6, 5, 5, 6, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 7), pColumnNames, new int[] { 10, 4, 4, 6, 5, 5, 6, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 8), pColumnNames, new int[] { 10, 4, 4, 6, 5, 5, 6, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 9), pColumnNames, new int[] { 10, 4, 4, 6, 5, 5, 6, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 10), pColumnNames, new int[] { 9, 4, 4, 6, 5, 5, 5, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 11), pColumnNames, new int[] { 9, 4, 4, 6, 5, 5, 5, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 12), pColumnNames, new int[] { 9, 4, 4, 6, 5, 5, 5, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 13), pColumnNames, new int[] { 9, 4, 4, 6, 5, 5, 5, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 14), pColumnNames, new int[] { 9, 4, 4, 6, 5, 5, 5, 5, 6, 4, 4, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 15), pColumnNames, new int[] { 9, 4, 4, 5, 5, 5, 5, 5, 6, 4, 4, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 16), pColumnNames, new int[] { 9, 4, 4, 5, 5, 5, 5, 5, 6, 4, 4, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 17), pColumnNames, new int[] { 9, 4, 4, 5, 5, 5, 5, 5, 6, 4, 4, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 18), pColumnNames, new int[] { 9, 4, 4, 5, 5, 5, 5, 5, 6, 4, 4, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 19), pColumnNames, new int[] { 9, 4, 4, 5, 5, 5, 5, 5, 6, 4, 4, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 20), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 5, 5, 6, 4, 3, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 21), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 5, 5, 6, 4, 3, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 22), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 5, 5, 6, 4, 3, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 23), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 5, 5, 6, 4, 3, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 24), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 5, 5, 6, 4, 3, 4, 4, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 25), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 4, 5, 6, 4, 3, 4, 4, 2, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 26), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 4, 5, 6, 4, 3, 4, 4, 2, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 27), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 4, 5, 6, 4, 3, 4, 4, 2, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 28), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 4, 5, 6, 4, 3, 4, 4, 2, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 29), pColumnNames, new int[] { 8, 4, 3, 5, 5, 5, 4, 5, 6, 4, 3, 4, 4, 2, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 30), pColumnNames, new int[] { 8, 4, 3, 5, 4, 5, 4, 5, 6, 4, 3, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 10, 31), pColumnNames, new int[] { 8, 4, 3, 5, 4, 5, 4, 5, 6, 4, 3, 4, 3, 3, 2, 4, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 1), pColumnNames, new int[] { 7, 4, 3, 5, 4, 5, 4, 5, 5, 4, 4, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 2), pColumnNames, new int[] { 7, 4, 3, 5, 4, 5, 4, 5, 5, 4, 4, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 3), pColumnNames, new int[] { 7, 4, 3, 5, 4, 5, 4, 5, 5, 4, 4, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 4), pColumnNames, new int[] { 7, 4, 3, 5, 4, 5, 4, 5, 5, 4, 4, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 5), pColumnNames, new int[] { 7, 4, 3, 4, 4, 5, 5, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 6), pColumnNames, new int[] { 7, 4, 3, 4, 4, 5, 5, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 7), pColumnNames, new int[] { 7, 4, 3, 4, 4, 5, 5, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 8), pColumnNames, new int[] { 7, 4, 3, 4, 4, 5, 5, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 9), pColumnNames, new int[] { 7, 4, 3, 4, 4, 5, 5, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 10), pColumnNames, new int[] { 7, 3, 3, 5, 4, 5, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 11), pColumnNames, new int[] { 7, 3, 3, 5, 4, 5, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 12), pColumnNames, new int[] { 7, 3, 3, 5, 4, 5, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 13), pColumnNames, new int[] { 7, 3, 3, 5, 4, 5, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 14), pColumnNames, new int[] { 7, 3, 3, 5, 4, 5, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 15), pColumnNames, new int[] { 7, 3, 3, 5, 4, 4, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 16), pColumnNames, new int[] { 7, 3, 3, 5, 4, 4, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 17), pColumnNames, new int[] { 7, 3, 3, 5, 4, 4, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 18), pColumnNames, new int[] { 7, 3, 3, 5, 4, 4, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 19), pColumnNames, new int[] { 7, 3, 3, 5, 4, 4, 4, 5, 5, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 20), pColumnNames, new int[] { 6, 3, 3, 4, 4, 5, 4, 5, 4, 4, 4, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 21), pColumnNames, new int[] { 6, 3, 3, 4, 4, 5, 4, 5, 4, 4, 4, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 22), pColumnNames, new int[] { 6, 3, 3, 4, 4, 5, 4, 5, 4, 4, 4, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 23), pColumnNames, new int[] { 6, 3, 3, 4, 4, 5, 4, 5, 4, 4, 4, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 24), pColumnNames, new int[] { 6, 3, 3, 4, 4, 5, 4, 5, 4, 4, 4, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 25), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 5, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 26), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 5, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 27), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 5, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 28), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 5, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 29), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 5, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 11, 30), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 1), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 2), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 3), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 4), pColumnNames, new int[] { 6, 3, 3, 4, 4, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 5), pColumnNames, new int[] { 6, 3, 3, 4, 3, 5, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 6), pColumnNames, new int[] { 6, 3, 3, 4, 3, 5, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 7), pColumnNames, new int[] { 6, 3, 3, 4, 3, 5, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 8), pColumnNames, new int[] { 6, 3, 3, 4, 3, 5, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 9), pColumnNames, new int[] { 6, 3, 3, 4, 3, 5, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 10), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 11), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 12), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 13), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 14), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 2, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 15), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 16), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 17), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 18), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 19), pColumnNames, new int[] { 6, 3, 3, 4, 3, 4, 4, 5, 4, 4, 3, 3, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 20), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 4, 4, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 21), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 4, 4, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 22), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 4, 4, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 23), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 4, 4, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 24), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 4, 4, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 25), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 26), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 27), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 28), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 29), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 30), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 12, 31), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 1), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 2), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 3), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 4), pColumnNames, new int[] { 6, 3, 2, 4, 4, 4, 3, 5, 4, 4, 3, 4, 3, 3, 2, 4, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 5), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 6), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 7), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 8), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 9), pColumnNames, new int[] { 6, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 3, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 10), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 4, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 11), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 4, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 12), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 4, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 13), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 4, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 14), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 3, 4, 4, 3, 2, 5, 4, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 15), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 4, 4, 3, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 16), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 4, 4, 3, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 17), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 4, 4, 3, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 18), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 4, 4, 3, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 19), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 4, 4, 4, 4, 3, 3, 2, 5, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 20), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 5, 4, 3, 4, 4, 3, 2, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 21), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 5, 4, 3, 4, 4, 3, 2, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 22), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 5, 4, 3, 4, 4, 3, 2, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 23), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 5, 4, 3, 4, 4, 3, 2, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 24), pColumnNames, new int[] { 5, 3, 2, 4, 3, 4, 4, 5, 5, 4, 3, 4, 4, 3, 2, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 25), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 26), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 27), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 28), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 29), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 30), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });
            pMaiz_Phenology_Information = AddRowForPhenologicInformation(pMaiz_Phenology_Information, new DateTime(2014, 1, 31), pColumnNames, new int[] { 5, 3, 2, 4, 3, 5, 4, 5, 4, 4, 4, 4, 4, 3, 3, 6, 5, 12, 8, 6, 12, 22, 22 });

            return pMaiz_Phenology_Information;
        }

        /// <summary>
        /// TODO: to explain
        /// </summary>
        /// <param name="pSoja_Phenology_Information"></param>
        /// <param name="pColumnNames"></param>
        /// <returns></returns>
        private static DataTable AddSojaInformation(DataTable pSoja_Phenology_Information, List<Stage> pColumnNames)
        {
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 24), pColumnNames, new int[] { 16, 5, 4, 5, 5, 3, 3, 2, 2, 3, 2, 7, 7, 3, 3, 7, 7, 32, 32, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 25), pColumnNames, new int[] { 16, 5, 4, 5, 5, 3, 3, 2, 2, 3, 2, 7, 7, 3, 3, 7, 7, 32, 32, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 26), pColumnNames, new int[] { 16, 5, 4, 5, 5, 3, 3, 2, 2, 3, 2, 7, 7, 3, 3, 7, 7, 32, 32, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 27), pColumnNames, new int[] { 16, 5, 4, 5, 5, 3, 3, 2, 2, 3, 2, 7, 7, 3, 3, 7, 7, 32, 32, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 28), pColumnNames, new int[] { 16, 5, 4, 5, 5, 3, 3, 2, 2, 3, 2, 7, 7, 3, 3, 7, 7, 32, 32, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 29), pColumnNames, new int[] { 15, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 6, 4, 3, 7, 7, 31, 31, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 9, 30), pColumnNames, new int[] { 15, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 6, 4, 3, 7, 7, 31, 31, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 1), pColumnNames, new int[] { 15, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 6, 4, 3, 7, 7, 31, 31, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 2), pColumnNames, new int[] { 15, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 6, 4, 3, 7, 7, 31, 31, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 3), pColumnNames, new int[] { 15, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 6, 4, 3, 7, 7, 31, 31, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 4), pColumnNames, new int[] { 15, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 6, 4, 3, 7, 7, 31, 31, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 5), pColumnNames, new int[] { 14, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 7, 4, 3, 7, 8, 29, 29, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 6), pColumnNames, new int[] { 14, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 7, 4, 3, 7, 8, 29, 29, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 7), pColumnNames, new int[] { 14, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 7, 4, 3, 7, 8, 29, 29, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 8), pColumnNames, new int[] { 14, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 7, 4, 3, 7, 8, 29, 29, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 9), pColumnNames, new int[] { 14, 5, 4, 5, 4, 4, 3, 3, 2, 2, 3, 7, 7, 4, 3, 7, 8, 29, 29, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 10), pColumnNames, new int[] { 14, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 6, 4, 4, 7, 8, 28, 28, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 11), pColumnNames, new int[] { 14, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 6, 4, 4, 7, 8, 28, 28, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 12), pColumnNames, new int[] { 14, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 6, 4, 4, 7, 8, 28, 28, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 13), pColumnNames, new int[] { 14, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 6, 4, 4, 7, 8, 28, 28, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 14), pColumnNames, new int[] { 14, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 6, 4, 4, 7, 8, 28, 28, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 15), pColumnNames, new int[] { 13, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 7, 4, 3, 8, 8, 27, 27, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 16), pColumnNames, new int[] { 13, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 7, 4, 3, 8, 8, 27, 27, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 17), pColumnNames, new int[] { 13, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 7, 4, 3, 8, 8, 27, 27, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 18), pColumnNames, new int[] { 13, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 7, 4, 3, 8, 8, 27, 27, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 19), pColumnNames, new int[] { 13, 4, 4, 5, 4, 4, 3, 3, 3, 2, 3, 7, 7, 4, 3, 8, 8, 27, 27, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 20), pColumnNames, new int[] { 13, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 7, 6, 4, 4, 8, 8, 25, 26, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 21), pColumnNames, new int[] { 13, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 7, 6, 4, 4, 8, 8, 25, 26, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 22), pColumnNames, new int[] { 13, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 7, 6, 4, 4, 8, 8, 25, 26, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 23), pColumnNames, new int[] { 13, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 7, 6, 4, 4, 8, 8, 25, 26, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 24), pColumnNames, new int[] { 13, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 7, 6, 4, 4, 8, 8, 25, 26, 21, 42 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 25), pColumnNames, new int[] { 12, 4, 3, 5, 4, 4, 4, 3, 3, 2, 3, 7, 6, 4, 4, 8, 8, 25, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 26), pColumnNames, new int[] { 12, 4, 3, 5, 4, 4, 4, 3, 3, 2, 3, 7, 6, 4, 4, 8, 8, 25, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 27), pColumnNames, new int[] { 12, 4, 3, 5, 4, 4, 4, 3, 3, 2, 3, 7, 6, 4, 4, 8, 8, 25, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 28), pColumnNames, new int[] { 12, 4, 3, 5, 4, 4, 4, 3, 3, 2, 3, 7, 6, 4, 4, 8, 8, 25, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 29), pColumnNames, new int[] { 12, 4, 3, 5, 4, 4, 4, 3, 3, 2, 3, 7, 6, 4, 4, 8, 8, 25, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 30), pColumnNames, new int[] { 12, 3, 3, 5, 5, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 10, 31), pColumnNames, new int[] { 12, 3, 3, 5, 5, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 25, 20, 40 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 1), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 4, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 24, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 2), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 4, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 24, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 3), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 4, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 24, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 4), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 4, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 24, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 5), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 23, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 6), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 23, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 7), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 23, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 8), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 23, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 9), pColumnNames, new int[] { 11, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 4, 8, 8, 24, 23, 19, 38 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 10), pColumnNames, new int[] { 11, 3, 3, 5, 4, 4, 3, 4, 3, 2, 3, 7, 6, 4, 3, 8, 8, 23, 23, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 11), pColumnNames, new int[] { 11, 3, 3, 5, 4, 4, 3, 4, 3, 2, 3, 7, 6, 4, 3, 8, 8, 23, 23, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 12), pColumnNames, new int[] { 11, 3, 3, 5, 4, 4, 3, 4, 3, 2, 3, 7, 6, 4, 3, 8, 8, 23, 23, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 13), pColumnNames, new int[] { 11, 3, 3, 5, 4, 4, 3, 4, 3, 2, 3, 7, 6, 4, 3, 8, 8, 23, 23, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 14), pColumnNames, new int[] { 11, 3, 3, 5, 4, 4, 3, 4, 3, 2, 3, 7, 6, 4, 3, 8, 8, 23, 23, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 15), pColumnNames, new int[] { 10, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 23, 22, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 16), pColumnNames, new int[] { 10, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 23, 22, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 17), pColumnNames, new int[] { 10, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 23, 22, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 18), pColumnNames, new int[] { 10, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 23, 22, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 19), pColumnNames, new int[] { 10, 4, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 23, 22, 18, 36 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 20), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 22, 22, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 21), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 22, 22, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 22), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 22, 22, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 23), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 22, 22, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 24), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 3, 3, 6, 6, 4, 3, 8, 7, 22, 22, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 25), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 2, 3, 6, 6, 4, 3, 7, 7, 22, 21, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 26), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 2, 3, 6, 6, 4, 3, 7, 7, 22, 21, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 27), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 2, 3, 6, 6, 4, 3, 7, 7, 22, 21, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 28), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 2, 3, 6, 6, 4, 3, 7, 7, 22, 21, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 29), pColumnNames, new int[] { 10, 3, 3, 5, 4, 4, 3, 3, 3, 2, 3, 6, 6, 4, 3, 7, 7, 22, 21, 17, 34 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 11, 30), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 3, 3, 3, 5, 5, 4, 4, 7, 6, 22, 21, 14, 28 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 1), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 3, 3, 3, 5, 5, 4, 4, 7, 6, 22, 21, 14, 28 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 2), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 3, 3, 3, 5, 5, 4, 4, 7, 6, 22, 21, 14, 28 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 3), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 3, 3, 3, 5, 5, 4, 4, 7, 6, 22, 21, 14, 28 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 4), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 3, 3, 3, 5, 5, 4, 4, 7, 6, 22, 21, 14, 28 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 5), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 2, 3, 3, 6, 5, 4, 3, 6, 6, 21, 21, 15, 30 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 6), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 2, 3, 3, 6, 5, 4, 3, 6, 6, 21, 21, 15, 30 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 7), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 2, 3, 3, 6, 5, 4, 3, 6, 6, 21, 21, 15, 30 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 8), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 2, 3, 3, 6, 5, 4, 3, 6, 6, 21, 21, 15, 30 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 9), pColumnNames, new int[] { 9, 4, 3, 4, 4, 4, 3, 3, 2, 3, 3, 6, 5, 4, 3, 6, 6, 21, 21, 15, 30 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 10), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 3, 3, 2, 5, 5, 4, 3, 6, 6, 21, 21, 12, 24 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 11), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 3, 3, 2, 5, 5, 4, 3, 6, 6, 21, 21, 12, 24 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 12), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 3, 3, 2, 5, 5, 4, 3, 6, 6, 21, 21, 12, 24 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 13), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 3, 3, 2, 5, 5, 4, 3, 6, 6, 21, 21, 12, 24 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 14), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 3, 3, 2, 5, 5, 4, 3, 6, 6, 21, 21, 12, 24 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 15), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 3, 5, 4, 4, 3, 5, 5, 21, 21, 11, 22 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 16), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 3, 5, 4, 4, 3, 5, 5, 21, 21, 11, 22 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 17), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 3, 5, 4, 4, 3, 5, 5, 21, 21, 11, 22 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 18), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 3, 5, 4, 4, 3, 5, 5, 21, 21, 11, 22 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 19), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 3, 5, 4, 4, 3, 5, 5, 21, 21, 11, 22 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 20), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 2, 5, 4, 3, 3, 5, 5, 21, 20, 9, 18 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 21), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 2, 5, 4, 3, 3, 5, 5, 21, 20, 9, 18 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 22), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 2, 5, 4, 3, 3, 5, 5, 21, 20, 9, 18 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 23), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 2, 5, 4, 3, 3, 5, 5, 21, 20, 9, 18 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 24), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 3, 3, 2, 3, 2, 5, 4, 3, 3, 5, 5, 21, 20, 9, 18 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 25), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 3, 2, 3, 2, 5, 4, 3, 3, 4, 4, 21, 20, 8, 16 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 26), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 3, 2, 3, 2, 5, 4, 3, 3, 4, 4, 21, 20, 8, 16 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 27), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 3, 2, 3, 2, 5, 4, 3, 3, 4, 4, 21, 20, 8, 16 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 28), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 3, 2, 3, 2, 5, 4, 3, 3, 4, 4, 21, 20, 8, 16 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 29), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 3, 2, 3, 2, 5, 4, 3, 3, 4, 4, 21, 20, 8, 16 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 30), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 2, 2, 3, 2, 5, 4, 3, 2, 4, 3, 21, 20, 5, 10 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 12, 31), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 2, 2, 3, 2, 5, 4, 3, 2, 4, 3, 21, 20, 5, 10 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 1), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 2, 2, 3, 2, 4, 4, 3, 2, 3, 3, 21, 21, 4, 8 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 2), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 2, 2, 3, 2, 4, 4, 3, 2, 3, 3, 21, 21, 4, 8 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 3), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 2, 2, 3, 2, 4, 4, 3, 2, 3, 3, 21, 21, 4, 8 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 4), pColumnNames, new int[] { 9, 3, 3, 5, 4, 3, 2, 2, 2, 3, 2, 4, 4, 3, 2, 3, 3, 21, 21, 4, 8 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 5), pColumnNames, new int[] { 8, 4, 3, 5, 4, 3, 2, 2, 1, 3, 2, 4, 4, 3, 2, 2, 2, 21, 21, 3, 6 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 6), pColumnNames, new int[] { 8, 4, 3, 5, 4, 3, 2, 2, 1, 3, 2, 4, 4, 3, 2, 2, 2, 21, 21, 3, 6 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 7), pColumnNames, new int[] { 8, 4, 3, 5, 4, 2, 2, 2, 2, 3, 2, 4, 4, 2, 2, 2, 2, 21, 21, 1, 2 });
            pSoja_Phenology_Information = AddRowForPhenologicInformation(pSoja_Phenology_Information, new DateTime(2014, 1, 8), pColumnNames, new int[] { 8, 4, 3, 5, 4, 2, 2, 2, 2, 3, 2, 4, 4, 2, 2, 2, 2, 21, 21, 1, 2 });
            return pSoja_Phenology_Information;
        }
        
        /// <summary>
        /// Add a row to the PhenologicalInformationTable
        /// Requirements: pStageList.Length = pDurations.Length -1
        /// </summary>
        /// <param name="pPhenologicInformation"></param>
        /// <param name="pSowingDate"></param>
        /// <param name="pStageList"></param>
        /// <param name="pDurations"></param>
        /// <returns></returns>
        private static DataTable AddRowForPhenologicInformation(DataTable pPhenologicInformation, DateTime pSowingDate, List<Stage> pColumnNames,  int[] pDurations)
        {
            DataRow row;
            row = pPhenologicInformation.NewRow();
            int index = 0;

            row[SOWINGDATE_COLUMN_NAME] = pSowingDate;
            foreach(Stage lStage in pColumnNames)
            {
                row[lStage.Name] = pDurations[index];
                index++;
            }
            pPhenologicInformation.Rows.Add(row);
            return pPhenologicInformation;
        }
        
        /// <summary>
        /// TODO: to explain
        /// </summary>
        /// <returns></returns>
        public static DataTable AddTemperatureInformation()
        {
            DataTable lTemperatureData;
            DataSet dataSetOfTemperatureData;

            lTemperatureData = new DataTable("TemperatureData");//"Soja_Phenology_Information");
            DataColumn column;

            // Create new DataColumn, set DataType,  
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "Date";//"SowingDate";
            column.ReadOnly = true;
            column.Unique = true;
            // Add the Column to the DataColumnCollection.
            lTemperatureData.Columns.Add(column);

            // Make the "SowingDate" column the primary key column.
            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = lTemperatureData.Columns["Date"];//"SowingDate"];
            lTemperatureData.PrimaryKey = PrimaryKeyColumns;
            
            // Create new column.
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Double");
            column.ColumnName = "Average";
            column.AutoIncrement = false;
            column.Caption = "Average";
            column.ReadOnly = false;
            column.Unique = false;
            // Add the column to the table.
            lTemperatureData.Columns.Add(column);
            

            // Instantiate the DataSet variable.
            dataSetOfTemperatureData = new DataSet();
            // Add the new DataTable to the DataSet.
            dataSetOfTemperatureData.Tables.Add(lTemperatureData);


            //ADD Temperature Information
            DataRow row;

            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 1); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 2); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 3); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 4); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 5); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 6); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 7); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 8); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 9); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 10); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 11); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 12); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 13); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 14); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 15); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 16); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 17); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 18); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 19); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 20); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 21); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 22); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 23); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 24); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 25); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 26); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 27); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 28); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 29); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 9, 30); row["Average"] = 17.9f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 1); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 2); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 3); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 4); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 5); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 6); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 7); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 8); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 9); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 10); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 11); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 12); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 13); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 14); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 15); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 16); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 17); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 18); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 19); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 20); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 21); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 22); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 23); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 24); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 25); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 26); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 27); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 28); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 29); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 30); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 10, 31); row["Average"] = 19.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 1); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 2); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 3); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 4); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 5); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 6); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 7); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 8); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 9); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 10); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 11); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 12); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 13); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 14); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 15); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 16); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 17); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 18); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 19); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 20); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 21); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 22); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 23); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 24); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 25); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 26); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 27); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 28); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 29); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 11, 30); row["Average"] = 21.55f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 1); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 2); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 3); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 4); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 5); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 6); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 7); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 8); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 9); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 10); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 11); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 12); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 13); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 14); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 15); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 16); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 17); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 18); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 19); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 20); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 21); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 22); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 23); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 24); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 25); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 26); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 27); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 28); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 29); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 30); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2014, 12, 31); row["Average"] = 24.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 1); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 2); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 3); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 4); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 5); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 6); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 7); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 8); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 9); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 10); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 11); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 12); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 13); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 14); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 15); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 16); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 17); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 18); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 19); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 20); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 21); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 22); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 23); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 24); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 25); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 26); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 27); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 28); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 29); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 30); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 1, 31); row["Average"] = 25.5f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 1); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 2); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 3); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 4); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 5); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 6); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 7); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 8); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 9); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 10); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 11); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 12); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 13); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 14); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 15); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 16); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 17); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 18); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 19); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 20); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 21); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 22); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 23); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 24); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 25); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 26); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 27); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 2, 28); row["Average"] = 25.35f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 1); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 2); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 3); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 4); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 5); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 6); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 7); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 8); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 9); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 10); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 11); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 12); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 13); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 14); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 15); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 16); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 17); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 18); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 19); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 20); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 21); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 22); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 23); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 24); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 25); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 26); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 27); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 28); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 29); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 30); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 3, 31); row["Average"] = 22.8f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 1); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 2); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 3); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 4); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 5); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 6); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 7); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 8); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 9); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 10); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 11); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 12); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 13); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 14); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 15); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 16); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 17); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 18); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 19); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 20); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 21); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 22); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 23); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 24); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 25); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 26); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 27); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 28); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 29); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            row = lTemperatureData.NewRow();
            row["Date"] = new DateTime(2015, 4, 30); row["Average"] = 18.6f; lTemperatureData.Rows.Add(row);
            

            
            return lTemperatureData;

        }

        #endregion

        #region Static Methods

        #region CropCoefficient

        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_CornSouthShort(CropCoefficient pCropCoefficient, 
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            //KC Para maiz sacado de la carpeta Datos Prueba
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if(pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }
                
                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.49);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.50);///////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.60);////////////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.70);/////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 0.80);//////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 0.88);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 0.9);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 0.63);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 0.61);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.50);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.49);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 161, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 162, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 163, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 164, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 165, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 166, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 167, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 168, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 169, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 170, 0.35);
            }

            #region Version Before correction 11/01/2015
            //Version anterior a la correccion del dia 11/01/2015 segun mail de Sebastian
            /*
            CropCoefficient lCropCoefficient = new CropCoefficient(pSpecieCycle, pRegionList);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(0, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(1, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(2, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(3, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(4, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(5, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(6, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(7, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(8, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(9, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(10, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(11, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(12, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(13, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(14, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(15, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(16, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(17, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(18, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(19, 0.35);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(20, 0.37);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(21, 0.38);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(22, 0.40);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(23, 0.42);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(24, 0.43);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(25, 0.45);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(26, 0.47);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(27, 0.48);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(28, 0.50);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(29, 0.52);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(30, 0.53);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(31, 0.55);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(32, 0.57);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(33, 0.58);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(34, 0.60);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(35, 0.62);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(36, 0.63);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(37, 0.65);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(38, 0.67);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(39, 0.68);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(40, 0.70);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(41, 0.72);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(42, 0.73);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(43, 0.75);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(44, 0.77);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(45, 0.78);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(46, 0.80);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(47, 0.82);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(48, 0.83);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(49, 0.85);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(50, 0.87);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(51, 0.88);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(52, 0.90);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(53, 0.92);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(54, 0.93);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(55, 0.95);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(56, 0.97);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(57, 0.98);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(58, 1);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(59, 1.02);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(60, 1.03);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(61, 1.05);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(62, 1.07);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(63, 1.08);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(64, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(65, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(66, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(67, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(68, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(69, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(70, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(71, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(72, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(73, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(74, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(75, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(76, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(77, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(78, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(79, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(80, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(81, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(82, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(83, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(84, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(85, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(86, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(87, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(88, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(89, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(90, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(91, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(92, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(93, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(94, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(95, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(96, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(97, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(98, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(99, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(100, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(101, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(102, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(103, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(104, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(105, 1.10);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(106, 1.08);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(107, 1.07);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(108, 1.05);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(109, 1.03);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(110, 1.01);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(111, 1.00);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(112, 0.98);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(113, 0.96);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(114, 0.94);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(115, 0.93);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(116, 0.91);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(117, 0.89);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(118, 0.87);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(119, 0.86);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(120, 0.84);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(121, 0.82);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(122, 0.80);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(123, 0.79);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(124, 0.77);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(125, 0.75);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(126, 0.73);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(127, 0.72);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(128, 0.70);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(129, 0.68);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(130, 0.66);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(131, 0.65);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(132, 0.63);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(133, 0.61);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(134, 0.59);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(135, 0.58);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(136, 0.56);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(137, 0.54);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(138, 0.52);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(139, 0.51);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(140, 0.49);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(141, 0.47);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(142, 0.45);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(143, 0.44);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(144, 0.42);
            lCropCoefficient.AddOrUpdateKCforDayAfterSowing(145, 0.40);
            */
            #endregion

            return lCropCoefficient;

        }

        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_CornSouthMedium(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            //KC Para maiz sacado de la carpeta Datos Prueba
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.49);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.50);///////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.60);////////////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.70);/////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 0.80);//////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 0.88);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 0.9);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 0.63);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 0.61);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.50);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.49);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 161, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 162, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 163, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 164, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 165, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 166, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 167, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 168, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 169, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 170, 0.35);
            }

            return lCropCoefficient;

        }

        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_SoyaSouthShort(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            //KC Para soja sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;
            
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.30);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.32);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.33);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.37); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.40); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.43); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.45); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.50); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.52); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.53);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.54); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.55);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.57); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.57);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.59); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.60);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.61); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.63); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.67);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.68); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.69);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 0.75); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 0.78); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 0.81);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 0.83); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 0.88); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 1.13);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 1.11);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.83);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.78); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.69);
            } 
            
            return lCropCoefficient;

        }
        
        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_SoyaSouthMedium(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            //KC Para soja sacado de la carpeta Calculos
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.30); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.32);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.33);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.35); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.35); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.35); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.40); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.43); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.45); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.46); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.50); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.51); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.53);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.54); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.55); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.57); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.60); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.62); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.70); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.80); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.83); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.90); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.93); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 0.97); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 1.00); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 1.00); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 1.02);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 1.02);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 1.04); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 1.04);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 1.05); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 1.06);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 1.06); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 1.06);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 1.10); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 1.11);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 1.11);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 1.12);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.12);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.13);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.13);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.14);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.14);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.15); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.14);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.13);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.12);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.11);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 1.06);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 1.04);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 1.02);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 1.00); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 0.99); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 0.90); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.88);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.83);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.81);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.80); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.78); 
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.70); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.69);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 161, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 162, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 163, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 164, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 165, 0.60); ////
            }

            return lCropCoefficient;

        }


        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_CornNorthShort(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            //KC Para maiz sacado de la carpeta Datos Prueba
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.50);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.53);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.55);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.57);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.60);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.63);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.67);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.78);///////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.83);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.88);////////////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.97);/////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 1.02);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 1.05);//////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 0.63);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 0.61);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.49);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 161, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 162, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 163, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 164, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 165, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 166, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 167, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 168, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 169, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 170, 0.35);
            }

            return lCropCoefficient;

        }

        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_CornNorthMedium(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            //KC Para maiz sacado de la carpeta Datos Prueba
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.50);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.53);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.55);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.57);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.60);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.63);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.67);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.78);///////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.83);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.88);////////////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.97);/////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 1.02);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 1.05);//////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.10);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.08);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 0.63);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 0.61);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.49);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 161, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 162, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 163, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 164, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 165, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 166, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 167, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 168, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 169, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 170, 0.35);
            }

            return lCropCoefficient;

        }


        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_SoyaNorthShort(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.30);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.32);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.33);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.37); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.40); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.43); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.45); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.50); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.52); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.53);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.54); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.55);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.57); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.57);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.59); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.60);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.61); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.63); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.67);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.68); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.69);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 0.75); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 0.78); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 0.81);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 0.83); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 0.88); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 1.13);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 1.11);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.83);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.78); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.69);
            }

            return lCropCoefficient;

        }
        

        /// <summary>
        /// Create or Update CropCoefficient, depends on Specie (not null)
        /// Create when CropCoefficient parameter is null
        /// </summary>
        /// <returns></returns>
        public static CropCoefficient CreateUpdateCropCoefficient_SoyaNorthMedium(CropCoefficient pCropCoefficient,
                                                                    long pCropCoefficientId, Specie pSpecie)
        {
            CropCoefficient lCropCoefficient = null;
            long lSpecieId = 0;

            if (pSpecie != null)
            {
                if (pCropCoefficient == null)
                {
                    lCropCoefficient = new CropCoefficient(pCropCoefficientId, pSpecie.Name, pSpecie.SpecieId, new List<KC>());
                }
                else
                {
                    lCropCoefficient = pCropCoefficient;
                }

                lSpecieId = pSpecie.SpecieId;

                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 0, 0.30);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 1, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 2, 0.31);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 3, 0.32);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 4, 0.33);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 5, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 6, 0.34);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 7, 0.35);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 8, 0.36);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 9, 0.37);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 10, 0.37); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 11, 0.38);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 12, 0.39);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 13, 0.40); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 14, 0.40);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 15, 0.41);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 16, 0.42);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 17, 0.43); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 18, 0.43);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 19, 0.44);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 20, 0.45);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 21, 0.45); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 22, 0.46);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 23, 0.47);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 24, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 25, 0.48);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 26, 0.50); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 27, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 28, 0.51);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 29, 0.52); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 30, 0.52);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 31, 0.53);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 32, 0.54);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 33, 0.54); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 34, 0.55);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 35, 0.56);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 36, 0.57); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 37, 0.57);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 38, 0.58);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 39, 0.59); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 40, 0.59);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 41, 0.60);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 42, 0.61); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 43, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 44, 0.62);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 45, 0.63); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 46, 0.64);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 47, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 48, 0.65);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 49, 0.66);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 50, 0.67);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 51, 0.68); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 52, 0.68);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 53, 0.69);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 54, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 55, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 56, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 57, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 58, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 59, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 60, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 61, 0.75); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 62, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 63, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 64, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 65, 0.78); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 66, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 67, 0.79);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 68, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 69, 0.81);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 70, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 71, 0.82);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 72, 0.83); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 73, 0.84);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 74, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 75, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 76, 0.86);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 77, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 78, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 79, 0.88); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 80, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 81, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 82, 0.90);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 83, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 84, 0.92);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 85, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 86, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 87, 0.94);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 88, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 89, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 90, 0.96);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 91, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 92, 0.98);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 93, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 94, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 95, 1.00);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 96, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 97, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 98, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 99, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 100, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 101, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 102, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 103, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 104, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 105, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 106, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 107, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 108, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 109, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 110, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 111, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 112, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 113, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 114, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 115, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 116, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 117, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 118, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 119, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 120, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 121, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 122, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 123, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 124, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 125, 1.15); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 126, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 127, 1.15);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 128, 1.13);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 129, 1.11);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 130, 1.09);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 131, 1.07);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 132, 1.05);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 133, 1.03);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 134, 1.01);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 135, 0.99);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 136, 0.97);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 137, 0.95);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 138, 0.93);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 139, 0.91);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 140, 0.89);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 141, 0.87);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 142, 0.85);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 143, 0.83);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 144, 0.80);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 145, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 146, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 147, 0.78);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 148, 0.78); ////
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 149, 0.77);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 150, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 151, 0.76);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 152, 0.75);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 153, 0.74);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 154, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 155, 0.73);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 156, 0.72);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 157, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 158, 0.71);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 159, 0.70);
                lCropCoefficient.AddOrUpdateKCforDayAfterSowing(lSpecieId, 160, 0.69);
            }

            return lCropCoefficient;

        }
        
        #endregion

        #region EffectiveRainList

        /// <summary>
        /// TODO Explain AddEffectiveRainListToSystem
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public static List<EffectiveRain> CreateEffectiveRainListToSystem(Region pRegion)
        {
            List<EffectiveRain> lEffectiveRainList = new List<EffectiveRain>();
            lEffectiveRainList.Add(new EffectiveRain("Sur1000", pRegion, 10, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain("Sur1011", pRegion, 10, 11, 20, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur1021", pRegion, 10, 21, 30, 80));
            lEffectiveRainList.Add(new EffectiveRain("Sur1031", pRegion, 10, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur1041", pRegion, 10, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur1051", pRegion, 10, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur1061", pRegion, 10, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain("Sur1071", pRegion, 10, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain("Sur1081", pRegion, 10, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain("Sur1091", pRegion, 10, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain("Sur10101", pRegion, 10, 101, 1000, 50));

            lEffectiveRainList.Add(new EffectiveRain("Sur1100", pRegion, 11, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain("Sur1111", pRegion, 11, 11, 20, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur1121", pRegion, 11, 21, 30, 80));
            lEffectiveRainList.Add(new EffectiveRain("Sur1131", pRegion, 11, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur1141", pRegion, 11, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur1151", pRegion, 11, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur1161", pRegion, 11, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain("Sur1171", pRegion, 11, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain("Sur1181", pRegion, 11, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain("Sur1191", pRegion, 11, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain("Sur11101", pRegion, 11, 101, 1000, 50));

            lEffectiveRainList.Add(new EffectiveRain("Sur1200", pRegion, 12, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain("Sur1211", pRegion, 12, 11, 20, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur1221", pRegion, 12, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur1231", pRegion, 12, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain("Sur1241", pRegion, 12, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur1251", pRegion, 12, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur1261", pRegion, 12, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur1271", pRegion, 12, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur1281", pRegion, 12, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur1291", pRegion, 12, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur12101", pRegion, 12, 101, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain("Sur0100", pRegion, 1, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain("Sur0111", pRegion, 1, 11, 20, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur0121", pRegion, 1, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur0131", pRegion, 1, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain("Sur0141", pRegion, 1, 41, 50, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0151", pRegion, 1, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0161", pRegion, 1, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0171", pRegion, 1, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0181", pRegion, 1, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0191", pRegion, 1, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur01101", pRegion, 1, 101, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain("Sur0200", pRegion, 2, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain("Sur0211", pRegion, 2, 11, 20, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur0221", pRegion, 2, 21, 30, 85));
            lEffectiveRainList.Add(new EffectiveRain("Sur0231", pRegion, 2, 31, 40, 80));
            lEffectiveRainList.Add(new EffectiveRain("Sur0241", pRegion, 2, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0251", pRegion, 2, 51, 60, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0261", pRegion, 2, 61, 70, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0271", pRegion, 2, 71, 80, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0281", pRegion, 2, 81, 90, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0291", pRegion, 2, 91, 100, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur02101", pRegion, 2, 101, 1000, 60));

            lEffectiveRainList.Add(new EffectiveRain("Sur0300", pRegion, 3, 0, 10, 90));
            lEffectiveRainList.Add(new EffectiveRain("Sur0311", pRegion, 3, 11, 20, 80));
            lEffectiveRainList.Add(new EffectiveRain("Sur0321", pRegion, 3, 21, 30, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0331", pRegion, 3, 31, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0341", pRegion, 3, 41, 40, 75));
            lEffectiveRainList.Add(new EffectiveRain("Sur0351", pRegion, 3, 51, 60, 70));
            lEffectiveRainList.Add(new EffectiveRain("Sur0361", pRegion, 3, 61, 70, 65));
            lEffectiveRainList.Add(new EffectiveRain("Sur0371", pRegion, 3, 71, 80, 60));
            lEffectiveRainList.Add(new EffectiveRain("Sur0381", pRegion, 3, 81, 90, 60));
            lEffectiveRainList.Add(new EffectiveRain("Sur0391", pRegion, 3, 91, 100, 55));
            lEffectiveRainList.Add(new EffectiveRain("Sur03101", pRegion, 3, 101, 1000, 50));


            return lEffectiveRainList;
            

        }
        
        #endregion

        #region Stage

        /// <summary>
        /// Create Stage List for Corn
        /// </summary>
        /// <returns></returns>
        public static List<Stage> CreateStageListForMaiz()
        {
            List<Stage> lReturn = null;
            Stage lStage = null;

            List<Stage> lStages= new List<Stage>();

            lStage = new Stage(1, "Maiz v0","v0", "Siembra", 1);
            lStages.Add(lStage);

            lStage = new Stage(2, "Maiz ve", "ve", "Emergencia", 2);
            lStages.Add(lStage);

            lStage = new Stage(3, "Maiz v1", "v1", "1 nudo", 3);
            lStages.Add(lStage);

            lStage = new Stage(4, "Maiz v2", "v2", "2 nudo", 4);
            lStages.Add(lStage);

            lStage = new Stage(5, "Maiz v3", "v3", "3 nudo", 5);
            lStages.Add(lStage);

            lStage = new Stage(6, "Maiz v4", "v4", "4 nudo", 6);
            lStages.Add(lStage);

            lStage = new Stage(7, "Maiz v5", "v5", "5 nudo", 7);
            lStages.Add(lStage);

            lStage = new Stage(8, "Maiz v6", "v6", "6 nudo", 8);
            lStages.Add(lStage);

            lStage = new Stage(9, "Maiz v7", "v7", "7 nudo", 9);
            lStages.Add(lStage);

            lStage = new Stage(10, "Maiz v8", "v8", "8 nudo", 10);
            lStages.Add(lStage);

            lStage = new Stage(11, "Maiz v9", "v9", "9 nudo", 11);
            lStages.Add(lStage);

            lStage = new Stage(12, "Maiz v10", "v10", "10 nudo", 12);
            lStages.Add(lStage);

            lStage = new Stage(13, "Maiz v11", "v11", "11 nudo", 13);
            lStages.Add(lStage);

            lStage = new Stage(14, "Maiz v12", "v12", "12 nudo", 14);
            lStages.Add(lStage);

            lStage = new Stage(15, "Maiz v13", "v13", "13 nudo", 15);
            lStages.Add(lStage);

            lStage = new Stage(16, "Maiz v14", "v14", "14 nudo", 16);
            lStages.Add(lStage);

            lStage = new Stage(17, "Maiz vt", "vt", "Floracion", 17);
            lStages.Add(lStage);

            lStage = new Stage(18, "Maiz R1", "R1", "Estambres 50%", 18);
            lStages.Add(lStage);

            lStage = new Stage(19, "Maiz R2", "R2", "Granos hinchados", 19);
            lStages.Add(lStage);

            lStage = new Stage(20, "Maiz R3", "R3", "Estado lechoso", 20);
            lStages.Add(lStage);

            lStage = new Stage(21, "Maiz R4", "R4", "Estado pastoso", 21);
            lStages.Add(lStage);

            lStage = new Stage(22, "Maiz R5", "R5", "Estado de diente", 22);
            lStages.Add(lStage);

            lStage = new Stage(23, "Maiz R6", "R6", "Madurez fisiologica", 23);
            lStages.Add(lStage);

            return lReturn;
        }

        #endregion

        #region PhenologicalStage


        /// <summary>
        /// TODO explain CreatePhenologicalStageListForCorn
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public static List<PhenologicalStage> CreatePhenologicalStageListForCorn(Crop pCrop, Specie pSpecie)                        
        {
            List<PhenologicalStage> lReturn = null;
            List<PhenologicalStage> lPhenolStageList;
            Double lMinDegree, lMaxDegree, lCoefficient;
            Double lRootDepth, lHydricBalanceDepth;
            Specie lSpecie = null;
            Stage lStage = null;

            try
            {                
                lPhenolStageList = new List<PhenologicalStage>();
                lSpecie = pSpecie;
                lStage = new Stage(1, "Maiz v0", "v0", "Siembra", 1); lMinDegree = 0; lMaxDegree = 59.999; lCoefficient = 0.35; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(2, "Maiz ve", "ve", "Emergencia", 2); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 114; lCoefficient = 0.35; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(3, "Maiz v1", "v1", "1 nudo", 3); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 134; lCoefficient = 0.35; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(4, "Maiz v2", "v2", "2 nudo", 4); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 179; lCoefficient = 0.35; lRootDepth = 10; lHydricBalanceDepth = 20;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(5, "Maiz v3", "v3", "3 nudo", 5); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 229; lCoefficient = 0.38; lRootDepth = 15; lHydricBalanceDepth = 25;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(6, "Maiz v4", "v4", "4 nudo", 6); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 289; lCoefficient = 0.40; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(7, "Maiz v5", "v5", "5 nudo", 7); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 339; lCoefficient = 0.45; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(8, "Maiz v6", "v6", "6 nudo", 8); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 404; lCoefficient = 0.50; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(9, "Maiz v7", "v7", "7 nudo", 9); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 459; lCoefficient = 0.60; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(10, "Maiz v8", "v8", "8 nudo", 10); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 519; lCoefficient = 0.70; lRootDepth = 30; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(11, "Maiz v9", "v9", "9 nudo", 11); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 589; lCoefficient = 0.80; lRootDepth = 32; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(12, "Maiz v10", "v10", "10 nudo", 12); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 649; lCoefficient = 0.90; lRootDepth = 35; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(13, "Maiz v11", "v11", "11 nudo", 13); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 689; lCoefficient = 0.95; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(14, "Maiz v12", "v12", "12 nudo", 14); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 714; lCoefficient = 1.00; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(15, "Maiz v13", "v13", "13 nudo", 15); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 749; lCoefficient = 1.05; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(16, "Maiz v14", "v14", "14 nudo", 16); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 764; lCoefficient = 1.10; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(17, "Maiz vt", "vt", "Floracion", 17); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 954; lCoefficient = 1.15; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(18, "Maiz R1", "R1", "Estambres 50%", 18); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1149; lCoefficient = 1.15; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(19, "Maiz R2", "R2", "Granos hinchados", 19); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1289; lCoefficient = 1.05; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(20, "Maiz R3", "R3", "Estado lechoso", 20); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1359; lCoefficient = 0.90; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(21, "Maiz R4", "R4", "Estado pastoso", 21); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1449; lCoefficient = 0.80; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(22, "Maiz R5", "R5", "Estado de diente", 22); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1649; lCoefficient = 0.70; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(23, "Maiz R6", "R6", "Madurez fisiologica", 23); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 2000; lCoefficient = 0.65; lRootDepth = 45; lHydricBalanceDepth = 50;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);
                
                lReturn = lPhenolStageList;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in InitialTables.CreatePhenologicalStageListForCorn " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        /// <summary>
        /// TODO explain CreatePhenologicalStageListForSoya
        /// </summary>
        /// <param name="pCrop"></param>
        /// <param name="pSpecie"></param>
        /// <returns></returns>
        public static List<PhenologicalStage> CreatePhenologicalStageListForSoya(Crop pCrop, Specie pSpecie)
        {
            List<PhenologicalStage> lReturn = null;
            List<PhenologicalStage> lPhenolStageList;
            Double lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth;
            Stage lStage = null;
            Specie lSpecie = null;

            try
            {
                lPhenolStageList = new List<PhenologicalStage>();
                lSpecie = pSpecie;
                lStage = new Stage(1, "Soja v0", "v0", "Siembra", 1); lMinDegree = 0; lMaxDegree = 114.999; lCoefficient = 0.30; lRootDepth = 7; lHydricBalanceDepth = 17;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient,  lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja ve", "ve", "Emergencia", 2); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 141; lCoefficient = 0.37; lRootDepth = 10; lHydricBalanceDepth = 20;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v1", "v1", "1 nudo", 3); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 191; lCoefficient = 0.40; lRootDepth = 10; lHydricBalanceDepth = 20;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v2", "v2", "2 nudo", 4); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 242; lCoefficient = 0.43; lRootDepth = 12; lHydricBalanceDepth = 22;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v3", "v3", "3 nudo", 5); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 313; lCoefficient = 0.45; lRootDepth = 15; lHydricBalanceDepth = 25;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v4", "v4", "4 nudo", 6); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 348; lCoefficient = 0.50; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v5", "v5", "5 nudo", 7); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 397; lCoefficient = 0.52; lRootDepth = 20; lHydricBalanceDepth = 30;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v6", "v6", "6 nudo", 8); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 445; lCoefficient = 0.54; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v7", "v7", "7 nudo", 9); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 471; lCoefficient = 0.57; lRootDepth = 25; lHydricBalanceDepth = 35;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v8", "v8", "8 nudo", 10); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 515; lCoefficient = 0.59; lRootDepth = 30; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v9", "v9", "9 nudo", 11); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 565; lCoefficient = 0.61; lRootDepth = 32; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v10", "v10", "10 nudo", 12); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 653; lCoefficient = 0.63; lRootDepth = 35; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja v11", "v11", "11 nudo", 13); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 741; lCoefficient = 0.68; lRootDepth = 35; lHydricBalanceDepth = 40;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R1", "R1", "Inicio Floracion", 14); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 843; lCoefficient = 0.72; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R2", "R2", "Floracion Completa", 15); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 911; lCoefficient = 0.75; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R3", "R3", "Inicio Vainas", 16); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 979; lCoefficient = 0.78; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R4", "R4", "Vainas Completas", 17); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1098; lCoefficient = 0.83; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R5", "R5", "Formacion de semillas", 18); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1217; lCoefficient = 0.88; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R6", "R6", "Semillas Completas", 19); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1608; lCoefficient = 1.15; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R7", "R7", "Inicio Maduracion", 20); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 1999; lCoefficient = 1.15; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);

                lStage = new Stage(1, "Soja R8", "R8", "Maduracion Completa", 21); lMinDegree = lMaxDegree + 0.001; lMaxDegree = 4000; lCoefficient = 0.78; lRootDepth = 40; lHydricBalanceDepth = 45;
                lPhenolStageList.Add(pCrop.AddPhenologicalStage(lSpecie, lStage, lMinDegree, lMaxDegree, lCoefficient, lRootDepth, lHydricBalanceDepth));
                //Add Stage to Crop
                pCrop.AddStage(lStage.Name, lStage.ShortName, lStage.Description, lStage.Order);
                
                lReturn = lPhenolStageList;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in InitialTables.CreatePhenologicalStageListForSoya " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }


        #endregion

        #region Crop Information By Date

        /// <summary>
        /// Given a Date for the SowingDate return the duration for each phenological stage.
        /// Information obtained from INIA.
        /// </summary>
        /// <param name="pSowingDate"></param>
        /// <returns></returns>
        public static List<Pair<Stage, int>> GetCropInformationByDateForSoja(DateTime pSowingDate, List<Stage> pStageList)
        {
            //Creo Variable local para guardar informacion a retornar
            List<Pair<Stage, int>> lCropCyclesInformationList = new List<Pair<Stage, int>>();
            int index = 1;

            DataTable lSoja_Phenology_Information = CreateTableForPhenologyInformation("Soja_Phenology_Information", pStageList);
            

            //Agrego informacion de la tabla magica
            lSoja_Phenology_Information = AddSojaInformation(lSoja_Phenology_Information, pStageList);

            //Itero la tabla magica hasta encontrar la fecha de siembra
            foreach (DataRow row in lSoja_Phenology_Information.Rows)
            {
                DateTime lDay = row.Field<DateTime>(0);
                if (Utils.IsTheSameDayWithoutYear(lDay, pSowingDate))
                {
                    //Si encuentro la fecha de siembra itero la fila para guardar informacion de la duracion de cada stage
                    //object[] lDataRow = row.ItemArray;
                    foreach (Stage lStage in pStageList)
                    {
                        string lDurationstring = row.Field<string>(index);
                        int lDuration = Convert.ToInt32(lDurationstring);
                        Pair<Stage, int> lNewStage = new Pair<Stage, int>(lStage, lDuration);
                        lCropCyclesInformationList.Add(lNewStage);
                        index++;
                    }
                    return lCropCyclesInformationList;

                }
            }
            return lCropCyclesInformationList;
        }


        public static List<Pair<Stage, int>> GetCropInformationByDateForMaiz(DateTime pSowingDate, List<Stage> pStageList)
        {
            //Creo Variable local para guardar informacion a retornar
            List<Pair<Stage, int>> lCropCyclesInformationList = new List<Pair<Stage, int>>();
            int index = 1;

            DataTable lMaiz_Phenology_Information = CreateTableForPhenologyInformation("Maiz_Phenology_Information", pStageList);

            //Agrego informacion de la tabla magica
            lMaiz_Phenology_Information = AddMaizInformation(lMaiz_Phenology_Information, pStageList);

            //Itero la tabla magica hasta encontrar la fecha de siembra
            foreach (DataRow row in lMaiz_Phenology_Information.Rows)
            {
                DateTime lDay = row.Field<DateTime>(0);
                if (Utils.IsTheSameDayWithoutYear(lDay, pSowingDate))
                {
                    //Si encuentro la fecha de siembra itero la fila para guardar informacion de la duracion de cada stage
                    //object[] lDataRow = row.ItemArray;
                    foreach(Stage lStage in pStageList)
                    {
                        string lDurationstring = row.Field<string>(index);
                        int lDuration = Convert.ToInt32(lDurationstring);
                        Pair<Stage, int> lNewStage = new Pair<Stage, int>(lStage, lDuration);
                        lCropCyclesInformationList.Add(lNewStage);
                        index++;
                    }
                    return lCropCyclesInformationList;

                }
            }
            return lCropCyclesInformationList;
        }



        #endregion

        #region DryMassList

        public static List<DryMass> CreateDryMassListForFescueForage(Crop pCrop, int pAgeOfCrop, Season pSeason)
        {
            List<DryMass> lReturn =null;
            DryMass lDryMass = null;

            Crop lCrop = pCrop;
            int lAgeOfCrop = pAgeOfCrop;
            Season lSeason = pSeason;
            int lDay;
            Double lRatePerHectareByDay;
            Double lWeightPerHectareInKG;
            Double lExponent;
            Double lMultiplier;
            Double lMaxCoefficient;
            Double lRootDepth;
            try
            {

                List<DryMass> lDryMassList = new List<DryMass>();
                //Initial Data or Data do not change
                lDay = 0; lRatePerHectareByDay = 20; lWeightPerHectareInKG = 400; 
                lExponent = 0.0251; lMultiplier = 0.4896; lMaxCoefficient = 1.2; lRootDepth = 10;

                //Day 0
                lDryMass = new DryMass(Utils.NameFescueForageAutumn, lCrop, lAgeOfCrop, lSeason, 
                                        lDay, lRatePerHectareByDay, lWeightPerHectareInKG, 
                                        lMultiplier, lExponent, lMaxCoefficient, lRootDepth);
                lDryMassList.Add(lDryMass);
                //Day 1
                lDay++; lWeightPerHectareInKG += lRatePerHectareByDay;
                lDryMass = new DryMass(Utils.NameFescueForageAutumn, lCrop, lAgeOfCrop, lSeason,
                                        lDay, lRatePerHectareByDay, lWeightPerHectareInKG,
                                        lMultiplier, lExponent, lMaxCoefficient, lRootDepth);
                lDryMassList.Add(lDryMass);
                //Day 2
                lDay++; lWeightPerHectareInKG += lRatePerHectareByDay;
                lDryMass = new DryMass(Utils.NameFescueForageAutumn, lCrop, lAgeOfCrop, lSeason,
                                        lDay, lRatePerHectareByDay, lWeightPerHectareInKG,
                                        lMultiplier, lExponent, lMaxCoefficient, lRootDepth);
                lDryMassList.Add(lDryMass);
                //Day 3
                lDay++; lWeightPerHectareInKG += lRatePerHectareByDay;
                lDryMass = new DryMass(Utils.NameFescueForageAutumn, lCrop, lAgeOfCrop, lSeason,
                                        lDay, lRatePerHectareByDay, lWeightPerHectareInKG,
                                        lMultiplier, lExponent, lMaxCoefficient, lRootDepth);
                lDryMassList.Add(lDryMass);
                //Day 4
                lDay++; lWeightPerHectareInKG += lRatePerHectareByDay;
                lDryMass = new DryMass(Utils.NameFescueForageAutumn, lCrop, lAgeOfCrop, lSeason,
                                        lDay, lRatePerHectareByDay, lWeightPerHectareInKG,
                                        lMultiplier, lExponent, lMaxCoefficient, lRootDepth);
                lDryMassList.Add(lDryMass);
                lExponent = 0.0251; lMultiplier = 0.4896; lMaxCoefficient = 1.2; lRootDepth = 10;
                lDryMass = new DryMass(Utils.NameFescueForageAutumn, lCrop, lAgeOfCrop, lSeason,
                                        lDay, lRatePerHectareByDay, lWeightPerHectareInKG,
                                        lMultiplier, lExponent, lMaxCoefficient, lRootDepth);
                lDryMassList.Add(lDryMass);


                lReturn = lDryMassList;

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in InitialTables.CreateDryMassListForFestuca " + "\n" + ex.Message + "\n" + ex.StackTrace);
                throw ex;
            }
            return lReturn;
        }

        #endregion

        #endregion


    }
}