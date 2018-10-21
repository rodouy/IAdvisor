using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data.Entity;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.ComplementedUtils;

using IrrigationAdvisor.DBContext;

using NLog;
using IrrigationAdvisorConsole.Data;

using IrrigationAdvisorConsole.Insert._01_Data;
using IrrigationAdvisorConsole.Insert._02_Language;
using IrrigationAdvisorConsole.Insert._03_Security;
using IrrigationAdvisorConsole.Insert._04_Localization;
using IrrigationAdvisorConsole.Insert._05_Weather;
using IrrigationAdvisorConsole.Insert._06_Agriculture;
using IrrigationAdvisorConsole.Insert._07_Irrigation;
using IrrigationAdvisorConsole.Insert._08_Water;
using IrrigationAdvisorConsole.Insert._09_Management;
using IrrigationAdvisorConsole.Print;

namespace IrrigationAdvisorConsole
{
    public class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public static Utils.IrrigationAdvisorProcessFarm ProcessFarm = Utils.IrrigationAdvisorProcessFarm.Production;
        
        public static Utils.IrrigationAdvisorOutputFiles PrintFarm = Utils.IrrigationAdvisorOutputFiles.NONE;

        public static DateTime DateOfReference = System.DateTime.Now; //.AddMonths(-9);

        public static bool AddWeatherInformation = true;

        public static bool StopOnDebug = true;
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Database Initializer.");
                //IASystem IASystem = new IrrigationAdvisorConsole.IASystem();

                #if false
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new DropCreateDatabaseIfModelChanges<IrrigationAdvisorContext>());
                #endif

                #if false
                Database.SetInitializer < IrrigationAdvisorContext>
                    (new CreateDatabaseIfNotExists<IrrigationAdvisorContext>());
                #endif
                /*
                 * Changing from DropCreateDatabaseIfModelChanges to DropCreateDatabaseAlways works, 
                 * the latter configuration causes the database to be recreated no matter what, 
                 * bypassing any sort of database versioning that might be causing an error.
                 */
                #if true

                try
                {
                    Database.SetInitializer<IrrigationAdvisorContext>
                                (new DropCreateDatabaseAlways<IrrigationAdvisorContext>());

                }
                catch (Exception ex)
                {
                    logger.Error(ex, "Exception in Program.DropCreateDatabaseAlways " + "\n" + ex.Message + "\n" + ex.StackTrace);
                    logger.Log(LogLevel.Error, "Error in Program: DropCreateDatabaseAlways"
                                                + " Message " + ex.ToString());
                    throw ex;
                }
                #endif

                #region Data
                DataInsert.InsertStatus();
                #endregion

                #region Lenguage
                LanguageInsert.InsertLanguages();
                #endregion

                #region Security
                Console.WriteLine("Add Information of Security.");
                SecurityInsert.InsertRoles();
                SecurityInsert.InsertUsers();
                #endregion

                #region Localization
                #if true
                Console.WriteLine("Add Information of Localization.");

                Console.WriteLine("  - Insert Region-Cities-Countries");
                LocalizationInsert.InsertPositions();
                LocalizationInsert.InsertRegions();
                LocalizationInsert.InsertCapitals();
                LocalizationInsert.InsertCountry();
                LocalizationInsert.InsertCities();
                Console.WriteLine("  - InsertWeatherStations");
                WeatherInsert.InsertWeatherStationsINIA();
                WeatherInsert.InsertWeatherStationsWeatherLink();
                Console.WriteLine("  - InsertFarms");
                LocalizationInsert.InsertFarms();
                SecurityInsert.InsertUserFarms();
                #endif
                #endregion

                #region Agriculture
                #if true
                Console.WriteLine("Add Information of Agriculture.");
                #region Agriculture-Species
                AgricultureInsert.InsertSpecieCycles();
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                {
                    AgricultureInsert.InsertSpecies_2016();
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                {
                    AgricultureInsert.InsertSpecies_2017();
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                {
                    AgricultureInsert.InsertSpecies_2018();
                }
                else
                {
                    AgricultureInsert.InsertSpecies_2018();
                }
                AgricultureInsert.UpdateCountryRegionWithSpeciesSpeciesCycles();
                #endregion
                Console.WriteLine("  - InsertStages");
                #region Agriculture-Stages
                AgricultureInsert.InsertStagesCorn();
                AgricultureInsert.InsertStagesSoya();
                AgricultureInsert.InsertStagesOat();
                AgricultureInsert.InsertStagesSorghumForage();
                AgricultureInsert.InsertStagesSorghumGrain();
                AgricultureInsert.InsertStagesAlfalfa();
                AgricultureInsert.InsertStagesSudanGrass();
                AgricultureInsert.InsertStagesRedCloverForage();
                AgricultureInsert.InsertStagesRedCloverSeed();
                AgricultureInsert.InsertStagesFescueForage();
                AgricultureInsert.InsertStagesFescueSeed();
                #endregion
                Console.WriteLine("  - InsertEffectiveRains");
                WaterInsert.InsertEffectiveRainsSouth();
                WaterInsert.InsertEffectiveRainsNorth();
                WaterInsert.UpdateRegionSetEffectiveRainList();

                Console.WriteLine("  - InsertPhenologicalStages");
                #region Agriculure-PhenologicalStage
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                {
                    #region Agriculure-PhenologicalStage-Demo-Season2015-Season2016_2017
                    AgricultureInsert.InsertPhenologicalStagesCornSouthShort();
                    AgricultureInsert.InsertPhenologicalStagesCornSouthMedium();
                    AgricultureInsert.InsertPhenologicalStagesSoyaSouthShort();
                    AgricultureInsert.InsertPhenologicalStagesSoyaSouthMedium();

                    AgricultureInsert.InsertPhenologicalStagesCornNorthShort();
                    AgricultureInsert.InsertPhenologicalStagesCornNorthMedium();
                    AgricultureInsert.InsertPhenologicalStagesSoyaNorthShort();
                    AgricultureInsert.InsertPhenologicalStagesSoyaNorthMedium();
                    #endregion
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                {
                    #region Agriculure-PhenologicalStage-Season2017_2018
                    AgricultureInsert.InsertPhenologicalStagesCornSouthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesCornSouthMedium();
                    AgricultureInsert.InsertPhenologicalStagesSoyaSouthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesSoyaSouthMedium();

                    AgricultureInsert.InsertPhenologicalStagesCornNorthShort();
                    //AgricultureInsert.InsertPhenologicalStagesCornNorthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesCornNorthMedium();
                    AgricultureInsert.InsertPhenologicalStagesSoyaNorthShort();
                    //AgricultureInsert.InsertPhenologicalStagesSoyaNorthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesSoyaNorthMedium();


                    AgricultureInsert.InsertPhenologicalStagesOatSouthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesOatSouthMedium_2017();
                    AgricultureInsert.InsertPhenologicalStagesOatNorthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesOatNorthMedium_2017();

                    AgricultureInsert.InsertPhenologicalStagesAlfalfaSouthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesAlfalfaSouthMedium_2017();
                    AgricultureInsert.InsertPhenologicalStagesAlfalfaNorthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesAlfalfaNorthMedium_2017();

                    AgricultureInsert.InsertPhenologicalStagesSudanGrassSouthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesSudanGrassSouthMedium_2017();
                    AgricultureInsert.InsertPhenologicalStagesSudanGrassNorthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesSudanGrassNorthMedium_2017();

                    AgricultureInsert.InsertPhenologicalStagesFescueForageSouthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesFescueForageSouthMedium_2017();
                    AgricultureInsert.InsertPhenologicalStagesFescueForageNorthShort_2017();
                    AgricultureInsert.InsertPhenologicalStagesFescueForageNorthMedium_2017();
                    #endregion
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                {
                    #region Agriculure-PhenologicalStage-Production-Season2018_2019
                    AgricultureInsert.InsertPhenologicalStagesCornSouthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesCornSouthMedium_2018();
                    AgricultureInsert.InsertPhenologicalStagesSoyaSouthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesSoyaSouthMedium_2018();

                    AgricultureInsert.InsertPhenologicalStagesCornNorthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesCornNorthMedium_2018();
                    AgricultureInsert.InsertPhenologicalStagesSoyaNorthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesSoyaNorthMedium_2018();


                    AgricultureInsert.InsertPhenologicalStagesOatSouthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesOatSouthMedium_2018();
                    AgricultureInsert.InsertPhenologicalStagesOatNorthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesOatNorthMedium_2018();

                    AgricultureInsert.InsertPhenologicalStagesAlfalfaSouthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesAlfalfaSouthMedium_2018();
                    AgricultureInsert.InsertPhenologicalStagesAlfalfaNorthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesAlfalfaNorthMedium_2018();

                    AgricultureInsert.InsertPhenologicalStagesSudanGrassSouthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesSudanGrassSouthMedium_2018();
                    AgricultureInsert.InsertPhenologicalStagesSudanGrassNorthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesSudanGrassNorthMedium_2018();

                    AgricultureInsert.InsertPhenologicalStagesFescueForageSouthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesFescueForageSouthMedium_2018();
                    AgricultureInsert.InsertPhenologicalStagesFescueForageNorthShort_2018();
                    AgricultureInsert.InsertPhenologicalStagesFescueForageNorthMedium_2018();
                    #endregion
                }
                #endregion
                Console.WriteLine("  - Insert Horizons - Soils - CropCoefficient");
                SoilInsert.InsertHorizons();
                SoilInsert.InsertSoils();
                AgricultureInsert.InsertCropCoefficients();
                Console.WriteLine("Agriculture - Completed.");
                #endif
                #endregion

                #region Irrigation
                #if true
                Console.Write("Add Information of Irrigation.");

                IrrigationInsert.InsertBombs();
                IrrigationInsert.InsertIrrigationUnits();
                IrrigationInsert.UpdateSoilsBombsIrrigationUnitsUsersByFarm();
                IrrigationInsert.InsertCrops();
                IrrigationInsert.InsertCropsInformationByDate();
                Console.WriteLine(" - Completed.");

                #endif
                #endregion

                #region Weather
                #if true
                Console.WriteLine("Add Information of Weather.");
                
                WeatherInsert.InsertTemperatureData();
                Console.WriteLine("  - InsertTemperatureData");
                WeatherInsert.AddTemperatureDataToRegion();
                Console.WriteLine("  - AddTemperatureDataToRegion");
                WeatherInsert.WetherStationsAddInformationOfWeather();
                Console.WriteLine("  - WetherStationsAddInformationOfWeather");
                Console.WriteLine("Weather - Completed.");

                if (AddWeatherInformation 
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                {
                    Console.WriteLine(" ------------------------------------------------ ");
                    Console.WriteLine("Add Information of WeatherLink and press enter.");
                    Console.ReadLine();
                }

                #endif
                #endregion

                #region Management
                #if true
                Console.WriteLine("Add Information of Management.");
                
                if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {
                    #region Management DEMO
                    Console.WriteLine(" Management - InsertCropIrrigationWeather.");
                    CropIrrigationWeatherInsert2015.InsertCropIrrigationWeather2015();
                    Console.WriteLine(" ");
                    Console.WriteLine(" Management - InsertCropIrrigationWeather. - Completed.");
                    Console.Write(" Management - Add/Update Rain, Irrigation & Phenology Information.");
                    WaterInsert.UpdateInformationOfRain2015();
                    WaterInsert.UpdateInformationOfIrrigation2015();
                    CropIrrigationWeatherInsert2015.AddPhenologicalStageAdjustements2015();
                    Console.WriteLine(" - Completed.");
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units.");
                    CropIrrigationWeatherInsert2015.AddInformationToIrrigationUnits2015();
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units. - Completed.");
                    #endregion
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2016_2017)
                {
                    #region Management Season 2016-2017
                    Console.WriteLine(" Management - InsertCropIrrigationWeather.");
                    CropIrrigationWeatherInsert2016.InsertCropIrrigationWeather2016();
                    Console.WriteLine(" ");
                    Console.WriteLine(" Management - InsertCropIrrigationWeather. - Completed.");
                    Console.Write(" Management - Add/Update Rain, Irrigation & Phenology Information.");
                    WaterInsert.UpdateInformationOfRain2016();
                    WaterInsert.UpdateInformationOfIrrigation2016();
                    CropIrrigationWeatherInsert2016.AddPhenologicalStageAdjustements2016();
                    Console.WriteLine(" - Completed.");
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units.");
                    CropIrrigationWeatherInsert2016.AddInformationToIrrigationUnits2016();
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units. - Completed.");
                    #endregion
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2017_2018)
                {
                    #region Management Season 2017-2018
                    Console.WriteLine(" Management - InsertCropIrrigationWeather.");
                    CropIrrigationWeatherInsert2017.InsertCropIrrigationWeather2017();
                    Console.WriteLine(" ");
                    Console.WriteLine(" Management - InsertCropIrrigationWeather. - Completed.");
                    Console.Write(" Management - Add/Update Rain, Irrigation & Phenology Information.");
                    WaterInsert.UpdateInformationOfRain2017();
                    WaterInsert.UpdateInformationOfIrrigation2017();
                    CropIrrigationWeatherInsert2017.AddPhenologicalStageAdjustements2017();
                    Console.WriteLine(" - Completed.");
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units.");
                    CropIrrigationWeatherInsert2017.AddInformationToIrrigationUnits2017();
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units. - Completed.");
                    #endregion
                }
                else if (ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2018_2019)
                {
                    #region Management Season 2018-2019
                    Console.WriteLine(" Management - InsertCropIrrigationWeather.");
                    CropIrrigationWeatherInsert2018.InsertCropIrrigationWeather2018();
                    Console.WriteLine(" ");
                    Console.WriteLine(" Management - InsertCropIrrigationWeather. - Completed.");
                    Console.Write(" Management - Add/Update Rain, Irrigation & Phenology Information.");
                    WaterInsert.UpdateInformationOfRain2018();
                    WaterInsert.UpdateInformationOfIrrigation2018();
                    CropIrrigationWeatherInsert2018.AddPhenologicalStageAdjustements2018();
                    Console.WriteLine(" - Completed.");
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units.");
                    CropIrrigationWeatherInsert2018.AddInformationToIrrigationUnits2018();
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units. - Completed.");
                    #endregion
                }
                //When we select only a Farm or group of farm
                else
                {
                    #region Management Default
                    Console.WriteLine(" Management - InsertCropIrrigationWeather.");
                    CropIrrigationWeatherInsert2018.InsertCropIrrigationWeather2018();
                    Console.WriteLine(" ");
                    Console.WriteLine(" Management - InsertCropIrrigationWeather. - Completed.");
                    Console.Write(" Management - Add/Update Rain, Irrigation & Phenology Information.");
                    WaterInsert.UpdateInformationOfRain2018();
                    WaterInsert.UpdateInformationOfIrrigation2018();
                    CropIrrigationWeatherInsert2018.AddPhenologicalStageAdjustements2018();
                    Console.WriteLine(" - Completed.");
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units.");
                    CropIrrigationWeatherInsert2018.AddInformationToIrrigationUnits2018();
                    Console.WriteLine(" Management - Add/Update Information to Irrigation Units. - Completed.");
                    #endregion
                }
                #endif
                #endregion

                if (PrintFarm != Utils.IrrigationAdvisorOutputFiles.NONE)
                {
                    Console.WriteLine("Start Layout process.");
                }
                
                PrintDailyRecord.LayoutDailyRecords();
                
                //Next to do
                #if false

                CalculateIrrigation();

                #endif

                Console.WriteLine("  ");
                Console.WriteLine("Ended with successful!! Great job :)");
                Console.WriteLine("  ");
                Console.WriteLine(" ------------------**********************-------------------- ");
                
                Console.ReadLine();
            }
                
            catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
            {
                logger.Error(ex, "Exception in Program.DbUpdateException " + "\n" + ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("DB Update Exception ");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch(System.Data.SqlClient.SqlException ex)
            {
                logger.Info(ex, "Exception in Program.SqlException " + "\n" + ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("DB is OPEN, close all connections. OR the model changes (Add or Update Migration) ");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                //IF the Model changes:
                //go to nuget console, select IrrigationAdvisor Project
                //add-migration Description
                //ex add-migration AddColumnToWeatherData

                //PM > Update - Database - TargetMigration AnyMigrationName
                // It updates database to a migration named "AnyMigrationName"
                // This will apply migrations if the target hasn't been applied 
                //   or roll back migrations if it has
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in Program " + "\n" + ex.Message + "\n" + ex.StackTrace);
                Console.WriteLine("Initialization Failed...");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        /////////////////////////////////******************************/////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////
#region Steps for a New Client

        /* 1.- Position
         *   Cities
         *   Farm
         *   Pivots
         *   WeatherStation
         * Position
         *   Cities
         *   Farm
         *   Pivots
         *   WeatherStation
         */

        /* 2.- Names
         * Client
         * Region
         * Cities
         * Farm
         * Bomb
         * Pivots
         * WeatherStation
         * Horizons
         * Soils
         * Crops
         * Soils, Bombs, IrrigationUnits, Farm
         * CropIrrigationWeather
         * 
        */

        /* 3.- Client Data
         * Utils.NameUserCLIENT
         * InsertUsers()
        */
            
        /* 4.- Region Data
         * InsertRegions()
         * 
        */
            
        /* 5.- Farm
         * InsertFarms()
        */
            
        /* 6.- Bomb
         * InsertBombs()
        */

        /* 7.- Pivots
         * InsertIrrigationUnits()
        */

        /* 8.- WeatherStations
         * InsertWeatherStations()
         */

        /* 9.- Horizons
         * InsertHorizons()
         */

        /* 10.- Soils
         * InsertSoils()
         */

        /* 11.- Crops
         * InsertCrops()
         */

        /* 12.- Update Farm Lists: Soils, Bombs, IrrigationUnits
         * UpdateSoilsBombsIrrigationUnitsFarmXXX()
         */

        /* 13.- CropIrrigationWeather
         * InsertCropIrrigationWeather()
         */

#endregion
        /////////////////////////////////******************************/////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////

#region Print

        /// <summary>
        /// Print Weather Data List
        /// </summary>
        /// <param name="pWeatherStation"></param>
        /// <returns></returns>
        private static String printWeatherDataList(WeatherStation pWeatherStation)
        {
            String lReturn = Environment.NewLine + "WEATHER DATA" + Environment.NewLine;
            foreach (WeatherData lWeatherData in pWeatherStation.WeatherDataList)
            {
                lReturn += lWeatherData.ToString() + Environment.NewLine;
            }
            return lReturn;
        }

#endregion

    }

    public class IASystem 
    {
        
        public IrrigationSystem IrrigationAdvSystem { get; set; }
        
        public IASystem()
        {
            IrrigationAdvSystem = IrrigationSystem.Instance;
        }

    }
}
