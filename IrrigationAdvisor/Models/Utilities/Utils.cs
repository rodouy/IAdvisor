using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Drawing;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using IrrigationAdvisor.DBContext.Data;
using System.Linq.Expressions;
using System.Collections;

namespace IrrigationAdvisor.Models.Utilities
{
    public static class Utils
    {

        #region Regions in all Solution

        #region Agriculture
        #endregion
        #region Data
        #endregion
        #region Irrigation
        #endregion
        #region Language
        #endregion
        #region Localization
        #endregion
        #region Management
        #endregion
        #region Security
        #endregion
        #region Utilities
        #endregion
        #region Water
        #endregion
        #region Weather
        #endregion

        #endregion

        #region Consts

        /// <summary>
        /// Default Language
        /// </summary>
        public static String LANGUAGE = "English";

        /// <summary>
        /// Default Region
        /// </summary>
        public static String REGION = "Uruguay-Sur";

        /// <summary>
        /// Default Country
        /// </summary>
        public static String COUNTRY = "Uruguay";

        /// <summary>
        /// Earth radius in KM
        /// </summary>
        public static int EARTH_RADIUS_IN_KM = 6371;

        /// <summary>
        /// Max Date used in the system
        /// </summary>
        public static DateTime MAX_DATETIME = new DateTime(2100, 12, 31);

        /// <summary>
        /// Min Date used in the system
        /// </summary>
        public static DateTime MIN_DATETIME = new DateTime(1950, 01, 01);

        #endregion

        #region Enums

        /// <summary>
        /// Roles Types.
        /// </summary>
        public enum UserRoles
        {

            /// <summary>
            /// The highest role.
            /// </summary>
            Administrator = 1,
            /// <summary>
            /// The medium role.
            /// </summary>
            Intermediate = 2,
            /// <summary>
            /// The lowest role.
            /// </summary>
            Standard = 3

        }

        /// <summary>
        /// Notification Types
        /// Silent, Inform, Ask
        /// </summary>
        public enum NotificationType
        {
            /// <summary>
            /// Users will not be notified, 
            ///     exceptions will be automatically logged
            /// </summary>
            Silent,
            /// <summary>
            /// Users will be notified if an exception has occurred,
            ///     and exceptions will be automatically logged
            /// </summary>
            Inform,
            /// <summary>
            /// Users will be notified if an exception has occurred
            ///     and will be asked if they want the exception logged.
            /// </summary>
            Ask
        }

        /// <summary>
        /// Specie Types
        /// Default, Pastures
        /// </summary>
        public enum SpecieType
        {
            /// <summary>
            /// Default Specie Type
            /// </summary>
            Default,

            /// <summary>
            /// Grains Specie Type
            /// </summary>
            Grains,

            /// <summary>
            /// Pastures Specie Type
            /// </summary>
            Pastures,

        }

        /// <summary>
        /// Types of Irrigation Units
        /// Pivot, Sprinkler, Drip
        /// </summary>
        public enum IrrigationUnitType
        {
            /// <summary>
            /// Irrigation type Pivot
            /// </summary>
            Pivot,
            /// <summary>
            /// Irrigation type Sprinkler
            /// </summary>
            Sprinkler,
            /// <summary>
            /// Irrigation type Drip
            /// </summary>
            Drip
        }

        /// <summary>
        /// Types of Water Input
        /// Rain, Irrigation, IrrigationByETCAccumulated, IrrigationByHydricBalance
        /// </summary>
        public enum WaterInputType
        {
            /// <summary>
            /// Rain
            /// </summary>
            Rain,
            /// <summary>
            /// Irrigation
            /// </summary>
            Irrigation,
            /// <summary>
            /// Irrigation when ETc is bigger than x degrees
            /// </summary>
            IrrigationByETCAcumulated,
            /// <summary>
            /// Irrigation when HB is lower than x%
            /// </summary>
            IrrigationByHydricBalance,
        }

        /// <summary>
        /// Types of Water Output
        /// Evapotranspiration
        /// </summary>
        public enum WaterOutputType
        {
            /// <summary>
            /// Evapotranspiration
            /// </summary>
            Evapotranspiration
        }

        /// <summary>
        /// Calculus of how to know the Phenological Stage
        /// By Days After Sowing, By Growing Degree Days
        /// </summary>
        public enum CalculusOfPhenologicalStage
        {
            /// <summary>
            /// Use Days After Sowing for the calculus of Phenological Stage
            /// Phenological Stage, Deep of Root and Crop Coefficient depend on this calculus
            /// </summary>
            ByDaysAfterSowing,
            /// <summary>
            /// Use Growing Degree Days for the calculus of Phenological Stage
            /// Phenological Stage, Deep of Root and Crop Coefficient depend on this calculus
            /// </summary>
            ByGrowingDegreeDays,
        }

        /// <summary>
        /// Type of Weather Station
        /// NOWebInformation, INIA, WeatherLink
        /// </summary>
        public enum WeatherStationType
        {
            /// <summary>
            /// Stations 
            /// </summary>
            NOWebInformation,
            /// <summary>
            /// Stations of INIA
            /// </summary>
            INIA,
            /// <summary>
            /// Stations using WeatherLink
            /// </summary>
            WeatherLink,
            
        }

        /// <summary>
        /// Type of information of the Weather Data
        /// All Data, NoData, Evapotranspiration, Temperature, Rain
        /// </summary>
        public enum WeatherDataType
        {
            /// <summary>
            /// Temperature and Evapotranspiration
            /// </summary>
            AllData,
            /// <summary>
            /// Invalid Data
            /// </summary>
            NoData,
            /// <summary>
            /// Only Evapotranspiration data
            /// </summary>
            Evapotranspiraton,
            /// <summary>
            /// Only Temperature data
            /// </summary>
            Temperature,
            /// <summary>
            /// Only Rain Data
            /// </summary>
            Rain,
        }

        /// <summary>
        /// To colour the cell with Irrigation Status
        /// </summary>
        public enum IrrigationStatus
        {
            /// <summary>
            /// Rain data
            /// </summary>
            Rain, 
            /// <summary>
            ///  Irrigation data, not rain
            /// </summary>
            Irrigated,
            /// <summary>
            ///   Next irrigation
            /// </summary>
            NextIrrigation,
            /// <summary>
            ///  Default, no irrigation nor rain
            /// </summary>
            Default,
            /// <summary>
            ///  Error
            /// </summary>
            Error,
        }
        
        /// <summary>
        /// The days of the week in Spanish
        /// </summary>
        public enum DayOfWeekSpanish
        {
            /// <summary>
            /// Sunday
            /// </summary>
            Domingo,
            /// <summary>
            /// Monday
            /// </summary>
            Lunes,
            /// <summary>
            /// Tuesday
            /// </summary>
            Martes,
            /// <summary>
            /// Wednesday
            /// </summary>
            Miércoles,
            /// <summary>
            /// Thursday
            /// </summary>
            Jueves,
            /// <summary>
            /// Friday
            /// </summary>
            Viernes,
            /// <summary>
            /// Saturday
            /// </summary>
            Sábado
        }

        /// <summary>
        /// Irrigation Advisor Web Status
        /// </summary>
        public enum IrrigationAdvisorWebStatus
        {
            /// <summary>
            /// With no data About Web Status
            /// </summary>
            WithNoData,

            /// <summary>
            /// Web is Online
            /// </summary>
            Online,

            /// <summary>
            /// Web is Offline, 
            /// Example: when calculation is in process
            /// </summary>
            Offline,

            /// <summary>
            /// Web is in maintenance
            /// </summary>
            Maintenance,
        }

        //For Processing
        /// <summary>
        /// Process the farm listed
        /// </summary>
        public enum IrrigationAdvisorProcessFarm
        {
            /// <summary>
            /// Demo Farm
            /// DCA Data (Del Carmen ACISA SA; La Perdiz Farm)
            /// </summary>
            Demo,
            
            /// <summary>
            /// Santa Lucia Farm
            /// Campo de Sol SA
            /// </summary>
            SantaLucia,

            /// <summary>
            /// La Perdiz Farm
            /// Del Carmen ACISA SA
            /// </summary>
            LaPerdiz,

            /// <summary>
            /// Del Lago - San Pedro Farm
            /// Del Lago - El Mirador Farm
            /// Estancias del Lago S.R.L.
            /// </summary>
            DelLago,

            /// <summary>
            /// Del Lago - San Pedro Farm
            /// Estancias del Lago S.R.L.
            /// </summary>
            DelLagoSanPedro,

            /// <summary>
            /// Del Lago - El Mirador Farm
            /// Estancias del Lago S.R.L.
            /// </summary>
            DelLagoElMirador,

            /// <summary>
            /// GMO - LaPalma Farm
            /// GMO - ElTacuru Farm
            /// GMO - Menafra
            /// </summary>
            GMO,

            /// <summary>
            /// GMO - LaPalma Farm
            /// GMO - Menafra
            /// </summary>
            GMOLaPalma,

            /// <summary>
            /// GMO - ElTacuru Farm
            /// GMO - Menafra
            /// </summary>
            GMOElTacuru,

            /// <summary>
            /// Print all Farms
            /// </summary>
            All,

            /// <summary>
            /// Print all Farms in Production
            /// </summary>
            Production,

            /// <summary>
            /// None
            /// </summary>
            NONE,
        }


        //For Printing
        /// <summary>
        /// Print the farm listed
        /// </summary>
        public enum IrrigationAdvisorOutputFiles
        {
            /// <summary>
            /// Demo Farm
            /// DCA Data (Del Carmen ACISA SA; La Perdiz Farm)
            /// </summary>
            Demo,

            /// <summary>
            /// Santa Lucia Farm
            /// Campo de Sol SA
            /// </summary>
            SantaLucia,

            /// <summary>
            /// La Perdiz Farm
            /// Del Carmen ACISA SA
            /// </summary>
            LaPerdiz,

            /// <summary>
            /// Del Lago - San Pedro Farm
            /// Estancias del Lago S.R.L.
            /// </summary>
            DelLagoSanPedro,

            /// <summary>
            /// Del Lago - El Mirador Farm
            /// Estancias del Lago S.R.L.
            /// </summary>
            DelLagoElMirador,

            /// <summary>
            /// GMO - LaPalma Farm
            /// GMO - ElTacuru Farm
            /// GMO - Menafra
            /// </summary>
            GMO,

            /// <summary>
            /// GMO - LaPalma Farm
            /// GMO - Menafra
            /// </summary>
            GMOLaPalma,

            /// <summary>
            /// GMO - ElTacuru Farm
            /// GMO - Menafra
            /// </summary>
            GMOElTacuru,

            /// <summary>
            /// Print all Farms
            /// </summary>
            All,

            /// <summary>
            /// Print all Farms in Production
            /// </summary>
            Production,

            /// <summary>
            /// None
            /// </summary>
            NONE,
        }


        #endregion

        #region Fields

        #region Names

        public static String NameBase = "Base";
        #region Language
        public static String NameLanguageSpanish = "Español";
        public static String NameLanguageEnglish = "English";
        #endregion
        #region Countries
        public static String NameCountryUruguay = "Uruguay";
        #endregion
        #region Regions
        public static String NameRegionSouth = "Sur";
        public static String NameRegionNorth = "Norte";
        #endregion
        #region Cities
        public static String NameCityMontevideo = "Montevideo";
        public static String NameCityMinas = "Minas";
        public static String NameCityMercedes = "Mercedes";
        public static String NameCityPalmar = "Palmar";
        public static String NameCityDurazno = "Durazno";
        public static String NameCityYoung = "Young";
        public static String NameCitySalto = "Salto";
        public static String NameCityTacuarembo = "Tacuarembo";
        public static String NameCity = "";
        #endregion
        #region Farms
        public static String NameFarmDemo1 = "Perdiz (Demo)";
        public static String NameFarmDemo2 = "Sta Lucia (Demo)";
        public static String NameFarmDemo3 = "Palma (Demo)";
        public static String NameFarmSantaLucia = "Santa Lucia";
        public static String NameFarmLaPerdiz = "La Perdiz";
        public static String NameFarmDelLagoSanPedro = "Estancias Del Lago - San Pedro";
        public static String NameFarmDelLagoElMirador = "Estancias Del Lago - El Mirador";
        public static String NameFarmGMOLaPalma = "GMO - La Palma";
        public static String NameFarmGMOElTacuru = "GMO - El Tacuru";
        public static String NameFarm = "";
        #endregion
        #region Weather
        public static String NameWeatherStationLasBrujas = "Las Brujas";
        public static String NameWeatherStationSantaLucia = "Santa Lucia";
        public static String NameWeatherStationLaEstanzuela = "La Estanzuela";
        public static String NameWeatherStationSaltoGrande = "Salto Grande";
        public static String NameWeatherStationTacuarembo = "Tacuarembo";
        
        public static String NameWeatherStationLaTribu = "La Tribu";
        public static String NameWeatherStationElCure = "El Cure";
        public static String NameWeatherStationJCServicios = "JC Servicios";
        public static String NameWeatherStationMariaElena = "Maria Elena";
        public static String NameWeatherStationElRetiro = "El Retiro";
        public static String NameWeatherStationZanjaHonda = "Zanja Honda";
        public static String NameWeatherStationEstacionVieja = "Estación Vieja";
        public static String NameWeatherStationSanFernando = "San Fernando";
        public static String NameWeatherStationLosOlivos = "Los Olivos";
        public static String NameWeatherStationViveroSanFrancisco = "Vivero San Francisco";
        public static String NameWeatherStation = "";
        #endregion
        #region Agriculture
        #region SpecieCycles
        public static String NameSpecieCycleSouthShort = NameRegionSouth + " Corto";
        public static String NameSpecieCycleSouthMedium = NameRegionSouth + " Medio";
        public static String NameSpecieCycleSouthLong = NameRegionSouth + " Largo";
        public static String NameSpecieCycleNorthShort = NameRegionNorth + " Corto";
        public static String NameSpecieCycleNorthMedium = NameRegionNorth + " Medio";
        public static String NameSpecieCycleNorthLong = NameRegionNorth + " Largo";
        public static String NameSpecieCycle = "";
        #endregion
        #region Species
        #region Corn
        public static String NameSpecieCornSouthShort = "Maiz " + NameSpecieCycleSouthShort;
        public static String NameSpecieCornSouthMedium = "Maiz " + NameSpecieCycleSouthMedium;
        public static String NameSpecieCornSouthLong = "Maiz " + NameSpecieCycleSouthLong;
        public static String NameSpecieCornNorthShort = "Maiz " + NameSpecieCycleNorthShort;
        public static String NameSpecieCornNorthMedium = "Maiz " + NameSpecieCycleNorthMedium;
        public static String NameSpecieCornNorthLong = "Maiz " + NameSpecieCycleNorthLong;
        #endregion
        #region Soya
        public static String NameSpecieSoyaSouthShort = "Soja " + NameSpecieCycleSouthShort;
        public static String NameSpecieSoyaSouthMedium = "Soja " + NameSpecieCycleSouthMedium;
        public static String NameSpecieSoyaSouthLong = "Soja " + NameSpecieCycleSouthLong;
        public static String NameSpecieSoyaNorthShort = "Soja " + NameSpecieCycleNorthShort;
        public static String NameSpecieSoyaNorthMedium = "Soja " + NameSpecieCycleNorthMedium;
        public static String NameSpecieSoyaNorthLong = "Soja " + NameSpecieCycleNorthLong;
        #endregion
        #region Sorghum Forage
        public static String NameSpecieSorghumForageSouthShort = "Sorgo Forraje " + NameSpecieCycleSouthShort;
        public static String NameSpecieSorghumForageSouthMedium = "Sorgo Forraje " + NameSpecieCycleSouthMedium;
        public static String NameSpecieSorghumForageNorthShort = "Sorgo Forraje " + NameSpecieCycleNorthShort;
        public static String NameSpecieSorghumForageNorthMedium = "Sorgo Forraje " + NameSpecieCycleNorthMedium;
        #endregion
        #region Sorghum Grain
        public static String NameSpecieSorghumGrainSouthShort = "Sorgo Granifero" + NameSpecieCycleSouthShort;
        public static String NameSpecieSorghumGrainSouthMedium = "Sorgo Granifero" + NameSpecieCycleSouthMedium;
        public static String NameSpecieSorghumGrainNorthShort = "Sorgo Granifero" + NameSpecieCycleNorthShort;
        public static String NameSpecieSorghumGrainNorthMedium = "Sorgo Granifero" + NameSpecieCycleNorthMedium;
        #endregion
        #region Alfalfa
        public static String NameSpecieAlfalfaSouthShort = "Alfalfa " + NameSpecieCycleSouthShort;
        public static String NameSpecieAlfalfaSouthMedium = "Alfalfa " + NameSpecieCycleSouthMedium;
        public static String NameSpecieAlfalfaNorthShort = "Alfalfa " + NameSpecieCycleNorthShort;
        public static String NameSpecieAlfalfaNorthMedium = "Alfalfa " + NameSpecieCycleNorthShort;
        #endregion
        #region RedClover Forage
        public static String NameSpecieRedCloverForageSouthShort = "Trebol Rojo Forraje " + NameSpecieCycleSouthShort;
        public static String NameSpecieRedCloverForageSouthMedium = "Trebol Rojo Forraje " + NameSpecieCycleSouthMedium;
        public static String NameSpecieRedCloverForageNorthShort = "Trebol Rojo Forraje " + NameSpecieCycleNorthShort;
        public static String NameSpecieRedCloverForageNorthMedium = "Trebol Rojo Forraje " + NameSpecieCycleNorthMedium;
        #endregion
        #region RedClover Seed
        public static String NameSpecieRedCloverSeedSouthShort = "Trebol Rojo Semilla " + NameSpecieCycleSouthShort;
        public static String NameSpecieRedCloverSeedSouthMedium = "Trebol Rojo Semilla " + NameSpecieCycleSouthMedium;
        public static String NameSpecieRedCloverSeedNorthShort = "Trebol Rojo Semilla " + NameSpecieCycleNorthShort;
        public static String NameSpecieRedCloverSeedNorthMedium = "Trebol Rojo Semilla " + NameSpecieCycleNorthMedium;
        #endregion
        #region Fescue Forage
        public static String NameSpecieFescueForageSouthShort = "Festuca Forraje" + NameSpecieCycleSouthShort;
        public static String NameSpecieFescueForageSouthMedium = "Festuca Forraje" + NameSpecieCycleSouthMedium;
        public static String NameSpecieFescueForageNorthShort = "Festuca Forraje" + NameSpecieCycleNorthShort;
        public static String NameSpecieFescueForageNorthMedium = "Festuca Forraje" + NameSpecieCycleNorthMedium;
        #endregion
        #region Fescue Seed
        public static String NameSpecieFescueSeedSouthShort = "Festuca Semilla" + NameSpecieCycleSouthShort;
        public static String NameSpecieFescueSeedSouthMedium = "Festuca Semilla" + NameSpecieCycleSouthMedium;
        public static String NameSpecieFescueSeedNorthShort = "Festuca Semilla" + NameSpecieCycleNorthShort;
        public static String NameSpecieFescueSeedNorthMedium = "Festuca Semilla" + NameSpecieCycleNorthMedium;
        #endregion

        public static String NameSpecie = "";
        #endregion
        #region Stages
        public static String NameStagesCorn = "Maiz";
        public static String NameStagesSoya = "Soja";
        public static String NameStagesSorghumForage = "Sorgo Forrajero";
        public static String NameStagesSorghumGrain = "Sorgo Granifero";
        public static String NameStagesAlfalfa = "Alfalfa";
        public static String NameStagesRedCloverForage = "Trebol Rojo Forraje";
        public static String NameStagesRedCloverSeed = "Trebol Rojo Semilla";
        public static String NameStagesFescueForage = "Festuca Forraje";
        public static String NameStagesFescueSeed = "Festuca Semilla";
        #endregion
        #region Soils
        #region Demo
        public static String NameSoilDemo11 = NameFarmDemo1 + " Pivot 1";
        public static String NameSoilDemo12 = NameFarmDemo1 + " Pivot 2";
        public static String NameSoilDemo13 = NameFarmDemo1 + " Pivot 3";
        public static String NameSoilDemo15 = NameFarmDemo1 + " Pivot 5";
        public static String NameSoilDemo21 = NameFarmDemo2 + " Pivot 1";
        public static String NameSoilDemo22 = NameFarmDemo2 + " Pivot 2";
        public static String NameSoilDemo23 = NameFarmDemo2 + " Pivot 3";
        public static String NameSoilDemo24 = NameFarmDemo2 + " Pivot 4";
        public static String NameSoilDemo25 = NameFarmDemo2 + " Pivot 5";
        public static String NameSoilDemo31 = NameFarmDemo3 + " Pivot 1";
        public static String NameSoilDemo32A = NameFarmDemo3 + " Pivot 2A";
        public static String NameSoilDemo33 = NameFarmDemo3 + " Pivot 3";
        public static String NameSoilDemo34 = NameFarmDemo3 + " Pivot 4";
        public static String NameSoilDemo35 = NameFarmDemo3 + " Pivot 5";
        #endregion
        public static String NameSoilSantaLucia1 = NameFarmSantaLucia + " Pivot 1";
        public static String NameSoilSantaLucia2 = NameFarmSantaLucia + " Pivot 2";
        public static String NameSoilSantaLucia3 = NameFarmSantaLucia + " Pivot 3";
        public static String NameSoilSantaLucia4 = NameFarmSantaLucia + " Pivot 4";
        public static String NameSoilSantaLucia5 = NameFarmSantaLucia + " Pivot 5";
        public static String NameSoilLaPerdiz1 = NameFarmLaPerdiz + " Pivot 1";
        public static String NameSoilLaPerdiz2 = NameFarmLaPerdiz + " Pivot 2";
        public static String NameSoilLaPerdiz3 = NameFarmLaPerdiz + " Pivot 3";
        public static String NameSoilLaPerdiz5 = NameFarmLaPerdiz + " Pivot 5";
        public static String NameSoilLaPerdiz14 = NameFarmLaPerdiz + " Pivot 14";
        #region Del Lago
        public static String NameSoilDelLagoSanPedro5 = NameFarmDelLagoSanPedro + " Pivot 5";
        public static String NameSoilDelLagoSanPedro6 = NameFarmDelLagoSanPedro + " Pivot 6";
        public static String NameSoilDelLagoSanPedro7 = NameFarmDelLagoSanPedro + " Pivot 7";
        public static String NameSoilDelLagoSanPedro8 = NameFarmDelLagoSanPedro + " Pivot 8";
        public static String NameSoilDelLagoElMirador1 = NameFarmDelLagoElMirador + " Pivot 01";
        public static String NameSoilDelLagoElMirador2 = NameFarmDelLagoElMirador + " Pivot 02";
        public static String NameSoilDelLagoElMirador3 = NameFarmDelLagoElMirador + " Pivot 03";
        public static String NameSoilDelLagoElMirador4 = NameFarmDelLagoElMirador + " Pivot 04";
        public static String NameSoilDelLagoElMirador5 = NameFarmDelLagoElMirador + " Pivot 05";
        public static String NameSoilDelLagoElMirador6 = NameFarmDelLagoElMirador + " Pivot 06";
        public static String NameSoilDelLagoElMirador7 = NameFarmDelLagoElMirador + " Pivot 07";
        public static String NameSoilDelLagoElMirador8 = NameFarmDelLagoElMirador + " Pivot 08";
        public static String NameSoilDelLagoElMirador9 = NameFarmDelLagoElMirador + " Pivot 09";
        public static String NameSoilDelLagoElMirador10 = NameFarmDelLagoElMirador + " Pivot 10";
        public static String NameSoilDelLagoElMirador11 = NameFarmDelLagoElMirador + " Pivot 11";
        public static String NameSoilDelLagoElMirador12 = NameFarmDelLagoElMirador + " Pivot 12";
        public static String NameSoilDelLagoElMirador13 = NameFarmDelLagoElMirador + " Pivot 13";
        public static String NameSoilDelLagoElMirador14 = NameFarmDelLagoElMirador + " Pivot 14";
        public static String NameSoilDelLagoElMirador15 = NameFarmDelLagoElMirador + " Pivot 15";
        public static String NameSoilDelLagoElMiradorChaja1 = NameFarmDelLagoElMirador + " Pivot Chaja 01";
        public static String NameSoilDelLagoElMiradorChaja2 = NameFarmDelLagoElMirador + " Pivot Chaja 02";
        #endregion
        #region GMO
        public static String NameSoilGMOLaPalma1 = NameFarmGMOLaPalma + " Pivot 1";
        public static String NameSoilGMOLaPalma2 = NameFarmGMOLaPalma + " Pivot 2";
        public static String NameSoilGMOLaPalma3 = NameFarmGMOLaPalma + " Pivot 3";
        public static String NameSoilGMOLaPalma4 = NameFarmGMOLaPalma + " Pivot 4";
        public static String NameSoilGMOLaPalma5 = NameFarmGMOLaPalma + " Pivot 5";
        public static String NameSoilGMOElTacuru1 = NameFarmGMOElTacuru + " Pivot 01";
        public static String NameSoilGMOElTacuru2 = NameFarmGMOElTacuru + " Pivot 02";
        public static String NameSoilGMOElTacuru3 = NameFarmGMOElTacuru + " Pivot 03";
        public static String NameSoilGMOElTacuru4 = NameFarmGMOElTacuru + " Pivot 04";
        public static String NameSoilGMOElTacuru5 = NameFarmGMOElTacuru + " Pivot 05";
        public static String NameSoilGMOElTacuru6 = NameFarmGMOElTacuru + " Pivot 06";
        public static String NameSoilGMOElTacuru7 = NameFarmGMOElTacuru + " Pivot 07";
        public static String NameSoilGMOElTacuru8 = NameFarmGMOElTacuru + " Pivot 08";
        public static String NameSoilGMOElTacuru9 = NameFarmGMOElTacuru + " Pivot 09";
        public static String NameSoilGMOElTacuru10 = NameFarmGMOElTacuru + " Pivot 10";
        #endregion
        #endregion
        #endregion
        #region Data
        #endregion
        #region Irrigation
        #region Bombs
        public static String NameBombDemo1 = NameFarmDemo1 + " Bomba";
        public static String NameBombDemo2 = NameFarmDemo2 + " Bomba";
        public static String NameBombDemo3 = NameFarmDemo3 + " Bomba";

        public static String NameBombSantaLucia = NameFarmSantaLucia + " Bomba";
        public static String NameBombLaPerdiz = NameFarmLaPerdiz + " Bomba";
        public static String NameBombDelLagoSanPedro = NameFarmDelLagoSanPedro + " Bomba";
        public static String NameBombDelLagoElMirador = NameFarmDelLagoElMirador + " Bomba";
        public static String NameBombGMOLaPalma = NameFarmGMOLaPalma + " Bomba";
        public static String NameBombGMOElTacuru = NameFarmGMOElTacuru + " Bomba";
        #endregion
        #region Pivots
        #region Demo
        public static String NamePivotDemo11 = NameFarmDemo1 + " Pivot 1";
        public static String NamePivotDemo12 = NameFarmDemo1 + " Pivot 2";
        public static String NamePivotDemo13 = NameFarmDemo1 + " Pivot 3";
        public static String NamePivotDemo15 = NameFarmDemo1 + " Pivot 5";
        public static String NamePivotDemo21 = NameFarmDemo2 + " Pivot 1";
        public static String NamePivotDemo22 = NameFarmDemo2 + " Pivot 2";
        public static String NamePivotDemo23 = NameFarmDemo2 + " Pivot 3";
        public static String NamePivotDemo24 = NameFarmDemo2 + " Pivot 4";
        public static String NamePivotDemo25 = NameFarmDemo2 + " Pivot 5";
        public static String NamePivotDemo31 = NameFarmDemo3 + " Pivot 1";
        public static String NamePivotDemo32A = NameFarmDemo3 + " Pivot 2A";
        public static String NamePivotDemo33 = NameFarmDemo3 + " Pivot 3";
        public static String NamePivotDemo34 = NameFarmDemo3 + " Pivot 4";
        public static String NamePivotDemo35 = NameFarmDemo3 + " Pivot 5";
        #endregion
        public static String NamePivotSantaLucia1 = NameFarmSantaLucia + " Pivot 1";
        public static String NamePivotSantaLucia2 = NameFarmSantaLucia + " Pivot 2";
        public static String NamePivotSantaLucia3 = NameFarmSantaLucia + " Pivot 3";
        public static String NamePivotSantaLucia4 = NameFarmSantaLucia + " Pivot 4";
        public static String NamePivotSantaLucia5 = NameFarmSantaLucia + " Pivot 5";
        public static String NamePivotLaPerdiz1 = NameFarmLaPerdiz + " Pivot 1";
        public static String NamePivotLaPerdiz2 = NameFarmLaPerdiz + " Pivot 2";
        public static String NamePivotLaPerdiz3 = NameFarmLaPerdiz + " Pivot 3";
        public static String NamePivotLaPerdiz5 = NameFarmLaPerdiz + " Pivot 5";
        public static String NamePivotLaPerdiz14 = NameFarmLaPerdiz + " Pivot 14";
        #region Del Lago
        #region San Pedro - Pivots
        public static String NamePivotDelLagoSanPedro5 = NameFarmDelLagoSanPedro + " Pivot 5";
        public static String NamePivotDelLagoSanPedro6 = NameFarmDelLagoSanPedro + " Pivot 6";
        public static String NamePivotDelLagoSanPedro7 = NameFarmDelLagoSanPedro + " Pivot 7";
        public static String NamePivotDelLagoSanPedro8 = NameFarmDelLagoSanPedro + " Pivot 8";
        #endregion
        #region El Mirador - Pivots
        public static String NamePivotDelLagoElMirador1 = NameFarmDelLagoElMirador + " Pivot 01";
        public static String NamePivotDelLagoElMirador2 = NameFarmDelLagoElMirador + " Pivot 02";
        public static String NamePivotDelLagoElMirador3 = NameFarmDelLagoElMirador + " Pivot 03";
        public static String NamePivotDelLagoElMirador4 = NameFarmDelLagoElMirador + " Pivot 04";
        public static String NamePivotDelLagoElMirador5 = NameFarmDelLagoElMirador + " Pivot 05";
        public static String NamePivotDelLagoElMirador6 = NameFarmDelLagoElMirador + " Pivot 06";
        public static String NamePivotDelLagoElMirador7 = NameFarmDelLagoElMirador + " Pivot 07";
        public static String NamePivotDelLagoElMirador8 = NameFarmDelLagoElMirador + " Pivot 08";
        public static String NamePivotDelLagoElMirador9 = NameFarmDelLagoElMirador + " Pivot 09";
        public static String NamePivotDelLagoElMirador10 = NameFarmDelLagoElMirador + " Pivot 10";
        public static String NamePivotDelLagoElMirador11 = NameFarmDelLagoElMirador + " Pivot 11";
        public static String NamePivotDelLagoElMirador12 = NameFarmDelLagoElMirador + " Pivot 12";
        public static String NamePivotDelLagoElMirador13 = NameFarmDelLagoElMirador + " Pivot 13";
        public static String NamePivotDelLagoElMirador14 = NameFarmDelLagoElMirador + " Pivot 14";
        public static String NamePivotDelLagoElMirador15 = NameFarmDelLagoElMirador + " Pivot 15";
        public static String NamePivotDelLagoElMiradorChaja1 = NameFarmDelLagoElMirador + " Pivot Chaja 01";
        public static String NamePivotDelLagoElMiradorChaja2 = NameFarmDelLagoElMirador + " Pivot Chaja 02";
        #endregion
        #endregion
        #region GMO
        public static String NamePivotGMOLaPalma1 = NameFarmGMOLaPalma + " Pivot 01";
        public static String NamePivotGMOLaPalma2 = NameFarmGMOLaPalma + " Pivot 02";
        public static String NamePivotGMOLaPalma3 = NameFarmGMOLaPalma + " Pivot 03";
        public static String NamePivotGMOLaPalma4 = NameFarmGMOLaPalma + " Pivot 04";
        public static String NamePivotGMOLaPalma5 = NameFarmGMOLaPalma + " Pivot 05";
        public static String NamePivotGMOElTacuru1 = NameFarmGMOElTacuru + " Pivot 01";
        public static String NamePivotGMOElTacuru2 = NameFarmGMOElTacuru + " Pivot 02";
        public static String NamePivotGMOElTacuru3 = NameFarmGMOElTacuru + " Pivot 03";
        public static String NamePivotGMOElTacuru4 = NameFarmGMOElTacuru + " Pivot 04";
        public static String NamePivotGMOElTacuru5 = NameFarmGMOElTacuru + " Pivot 05";
        public static String NamePivotGMOElTacuru6 = NameFarmGMOElTacuru + " Pivot 06";
        public static String NamePivotGMOElTacuru7 = NameFarmGMOElTacuru + " Pivot 07";
        public static String NamePivotGMOElTacuru8 = NameFarmGMOElTacuru + " Pivot 08";
        public static String NamePivotGMOElTacuru9 = NameFarmGMOElTacuru + " Pivot 09";
        public static String NamePivotGMOElTacuru10 = NameFarmGMOElTacuru + " Pivot 10";
        #endregion
        public static String NamePivot = "";
        #endregion
        #endregion
        #region Management
        #region Demo
        public static String NameCropIrrigationWeatherDemo1Pivot11 = NamePivotDemo11 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo1Pivot12 = NamePivotDemo12 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo1Pivot13 = NamePivotDemo13 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo1Pivot15 = NamePivotDemo15 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo2Pivot21 = NamePivotDemo21 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo2Pivot22 = NamePivotDemo22 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo2Pivot23 = NamePivotDemo23 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo2Pivot24 = NamePivotDemo23 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo2Pivot25 = NamePivotDemo25 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo3Pivot31 = NamePivotDemo31 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo3Pivot32A = NamePivotDemo32A + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo3Pivot33 = NamePivotDemo33 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo3Pivot34 = NamePivotDemo34 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDemo3Pivot342 = NamePivotDemo34 + " " + NameSpecieSoyaSouthShort;
        public static String NameCropIrrigationWeatherDemo3Pivot35 = NamePivotDemo35 + " " + NameSpecieCornSouthShort;
        #endregion
        public static String NameCropIrrigationWeatherSantaLuciaPivot1 = NamePivotSantaLucia1 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherSantaLuciaPivot2 = NamePivotSantaLucia2 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherSantaLuciaPivot3 = NamePivotSantaLucia3 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherSantaLuciaPivot4 = NamePivotSantaLucia4 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherSantaLuciaPivot5 = NamePivotSantaLucia5 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherLaPerdizPivot1 = NamePivotLaPerdiz1 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherLaPerdizPivot2 = NamePivotLaPerdiz2 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherLaPerdizPivot3 = NamePivotLaPerdiz3 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherLaPerdizPivot5 = NamePivotLaPerdiz5 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherLaPerdizPivot14 = NamePivotLaPerdiz14 + " " + NameSpecieCornSouthShort;
        #region Del Lago
        public static String NameCropIrrigationWeatherDelLagoSanPedroPivot5 = NamePivotDelLagoSanPedro5 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoSanPedroPivot6 = NamePivotDelLagoSanPedro6 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoSanPedroPivot7 = NamePivotDelLagoSanPedro7 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoSanPedroPivot8 = NamePivotDelLagoSanPedro8 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot1 = NamePivotDelLagoElMirador1 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot2 = NamePivotDelLagoElMirador2 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot3 = NamePivotDelLagoElMirador3 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot4 = NamePivotDelLagoElMirador4 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot5 = NamePivotDelLagoElMirador5 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot6 = NamePivotDelLagoElMirador6 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot7 = NamePivotDelLagoElMirador7 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot8 = NamePivotDelLagoElMirador8 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot9 = NamePivotDelLagoElMirador9 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot10 = NamePivotDelLagoElMirador10 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot11 = NamePivotDelLagoElMirador11 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot12 = NamePivotDelLagoElMirador12 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot13 = NamePivotDelLagoElMirador13 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot14 = NamePivotDelLagoElMirador14 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivot15 = NamePivotDelLagoElMirador15 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivotChaja1 = NamePivotDelLagoElMiradorChaja1 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherDelLagoElMiradorPivotChaja2 = NamePivotDelLagoElMiradorChaja2 + " " + NameSpecieCornSouthShort;
        #endregion
        #region GMO
        public static String NameCropIrrigationWeatherGMOLaPalmaPivot1 = NamePivotGMOLaPalma1 + " " + NameSpecieAlfalfaNorthShort;
        public static String NameCropIrrigationWeatherGMOLaPalmaPivot2 = NamePivotGMOLaPalma2 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOLaPalmaPivot3 = NamePivotGMOLaPalma3 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOLaPalmaPivot4 = NamePivotGMOLaPalma4 + " " + NameSpecieCornSouthShort;
        //public static String NameCropIrrigationWeatherGMOLaPalmaPivot5 = NamePivotGMOLaPalma5 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot1 = NamePivotGMOElTacuru1 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot2 = NamePivotGMOElTacuru2 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot3 = NamePivotGMOElTacuru3 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot4 = NamePivotGMOElTacuru4 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot5 = NamePivotGMOElTacuru5 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot6 = NamePivotGMOElTacuru6 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot7 = NamePivotGMOElTacuru7 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot8 = NamePivotGMOElTacuru8 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot9 = NamePivotGMOElTacuru9 + " " + NameSpecieCornSouthShort;
        public static String NameCropIrrigationWeatherGMOElTacuruPivot10 = NamePivotGMOElTacuru10 + " " + NameSpecieCornSouthShort;
        #endregion
        #endregion
        #region Security
        public static String NameUserDemo = "Demo";
        public static String NameUserTestAdm = "TestAdm";
        public static String NameUserAdmin = "Admin";
        public static String NameUserSeba = "scasanova";
        public static String NameUserGonza = "gmoreno";
        public static String NameUserDelCarmen = "LaPerdiz";
        public static String NameUserSantaLucia = "SantaLucia";
        public static String NameUserDelLago1 = "girrazabal";
        public static String NameUserDelLago2 = "jhemala";
        public static String NameUserGMO1 = "ptarigo";
        public static String NameUserGMO2 = "danselmi";
        public static String NameUserGMO3 = "mrios";
        #endregion
        #region Utilities
        #endregion
        #region Water
        #endregion
        #region Localization
        #region Positions
        public static String NamePositionUruguay = NameCountryUruguay;
        public static String NamePositionRegionSouth = NameRegionSouth;
        public static String NamePositionRegionNorth = NameRegionNorth;
        #region PositionsCities
        public static String NamePositionCityMontevideo = NameCityMontevideo;
        public static String NamePositionCityMinas = NameCityMinas;
        public static String NamePositionCityMercedes = NameCityMercedes;
        public static String NamePositionCityPalmar = NameCityPalmar;
        public static String NamePositionCityDurazno = NameCityDurazno;
        public static String NamePositionCityYoung = NameCityYoung;
        public static String NamePositionCity = NameCity;
        #endregion
        #region PositionsFarms
        public static String NamePositionFarmDemo1 = NameFarmDemo1;
        public static String NamePositionFarmDemo2 = NameFarmDemo2;
        public static String NamePositionFarmDemo3 = NameFarmDemo3;
        public static String NamePositionFarmSantaLucia = NameFarmSantaLucia;
        public static String NamePositionFarmLaPerdiz = NameFarmLaPerdiz;
        public static String NamePositionFarmDelLagoSanPedro = NameFarmDelLagoSanPedro;
        public static String NamePositionFarmDelLagoElMirador = NameFarmDelLagoElMirador;
        public static String NamePositionFarmGMOLaPalma = NameFarmGMOLaPalma;
        public static String NamePositionFarmGMOElTacuru = NameFarmGMOElTacuru;
        public static String NamePositionFarm = NameFarm;
        #endregion
        #region PositionsWeatherStations
        public static String NamePositionWeatherStationLasBrujas = NameWeatherStationLasBrujas;
        public static String NamePositionWeatherStationSantaLucia = NameWeatherStationSantaLucia;
        public static String NamePositionWeatherStationLaEstanzuela = NameWeatherStationLaEstanzuela;
        public static String NamePositionWeatherStationSaltoGrande = NameWeatherStationSaltoGrande;
        public static String NamePositionWeatherStationTacuarembo = NameWeatherStationTacuarembo;

        public static String NamePositionWeatherStationLaTribu = NameWeatherStationLaTribu;
        public static String NamePositionWeatherStationElCure = NameWeatherStationElCure;
        public static String NamePositionWeatherStationJCServicios = NameWeatherStationJCServicios;
        public static String NamePositionWeatherStationMariaElena = NameWeatherStationMariaElena;
        public static String NamePositionWeatherStationElRetiro = NameWeatherStationElRetiro;
        public static String NamePositionWeatherStationZanjaHonda = NameWeatherStationZanjaHonda;
        public static String NamePositionWeatherStationEstacionVieja = NameWeatherStationEstacionVieja;
        public static String NamePositionWeatherStationSanFernando = NameWeatherStationSanFernando;
        public static String NamePositionWeatherStationLosOlivos = NameWeatherStationLosOlivos;
        public static String NamePositionWeatherStationViveroSanFrancisco = NameWeatherStationViveroSanFrancisco;
        public static String NamePositionWeatherStation = NameWeatherStation;
        #endregion
        #region PositionsPivots
        #region Demo
        public static String NamePositionPivotDemo11 = NamePivotDemo11;
        public static String NamePositionPivotDemo12 = NamePivotDemo12;
        public static String NamePositionPivotDemo13 = NamePivotDemo13;
        public static String NamePositionPivotDemo15 = NamePivotDemo15;
        public static String NamePositionPivotDemo21 = NamePivotDemo21;
        public static String NamePositionPivotDemo22 = NamePivotDemo22;
        public static String NamePositionPivotDemo23 = NamePivotDemo23;
        public static String NamePositionPivotDemo24 = NamePivotDemo24;
        public static String NamePositionPivotDemo25 = NamePivotDemo25;
        public static String NamePositionPivotDemo31 = NamePivotDemo31;
        public static String NamePositionPivotDemo32A = NamePivotDemo32A;
        public static String NamePositionPivotDemo33 = NamePivotDemo33;
        public static String NamePositionPivotDemo34 = NamePivotDemo34;
        public static String NamePositionPivotDemo35 = NamePivotDemo35;
        #endregion
        public static String NamePositionPivotSantaLucia1 = NamePivotSantaLucia1;
        public static String NamePositionPivotSantaLucia2 = NamePivotSantaLucia2;
        public static String NamePositionPivotSantaLucia3 = NamePivotSantaLucia3;
        public static String NamePositionPivotSantaLucia4 = NamePivotSantaLucia4;
        public static String NamePositionPivotSantaLucia5 = NamePivotSantaLucia5;
        public static String NamePositionPivotLaPerdiz1 = NamePivotLaPerdiz1;
        public static String NamePositionPivotLaPerdiz2 = NamePivotLaPerdiz2;
        public static String NamePositionPivotLaPerdiz3 = NamePivotLaPerdiz3;
        public static String NamePositionPivotLaPerdiz5 = NamePivotLaPerdiz5;
        public static String NamePositionPivotLaPerdiz14 = NamePivotLaPerdiz14;
        #region Del Lago - Pivots
        public static String NamePositionPivotDelLagoSanPedro5 = NamePivotDelLagoSanPedro5;
        public static String NamePositionPivotDelLagoSanPedro6 = NamePivotDelLagoSanPedro6;
        public static String NamePositionPivotDelLagoSanPedro7 = NamePivotDelLagoSanPedro7;
        public static String NamePositionPivotDelLagoSanPedro8 = NamePivotDelLagoSanPedro8;
       
        public static String NamePositionPivotDelLagoElMirador1 = NamePivotDelLagoElMirador1;
        public static String NamePositionPivotDelLagoElMirador2 = NamePivotDelLagoElMirador2;
        public static String NamePositionPivotDelLagoElMirador3 = NamePivotDelLagoElMirador3;
        public static String NamePositionPivotDelLagoElMirador4 = NamePivotDelLagoElMirador4;
        public static String NamePositionPivotDelLagoElMirador5 = NamePivotDelLagoElMirador5;
        public static String NamePositionPivotDelLagoElMirador6 = NamePivotDelLagoElMirador6;
        public static String NamePositionPivotDelLagoElMirador7 = NamePivotDelLagoElMirador7;
        public static String NamePositionPivotDelLagoElMirador8 = NamePivotDelLagoElMirador8;
        public static String NamePositionPivotDelLagoElMirador9 = NamePivotDelLagoElMirador9;
        public static String NamePositionPivotDelLagoElMirador10 = NamePivotDelLagoElMirador10;
        public static String NamePositionPivotDelLagoElMirador11 = NamePivotDelLagoElMirador11;
        public static String NamePositionPivotDelLagoElMirador12 = NamePivotDelLagoElMirador12;
        public static String NamePositionPivotDelLagoElMirador13 = NamePivotDelLagoElMirador13;
        public static String NamePositionPivotDelLagoElMirador14 = NamePivotDelLagoElMirador14;
        public static String NamePositionPivotDelLagoElMirador15 = NamePivotDelLagoElMirador15;
        public static String NamePositionPivotDelLagoElMiradorChaja1 = NamePivotDelLagoElMiradorChaja1;
        public static String NamePositionPivotDelLagoElMiradorChaja2 = NamePivotDelLagoElMiradorChaja2;
        #endregion
        #region GMO
        public static String NamePositionPivotGMOLaPalma1 = NamePivotGMOLaPalma1;
        public static String NamePositionPivotGMOLaPalma2 = NamePivotGMOLaPalma2;
        public static String NamePositionPivotGMOLaPalma3 = NamePivotGMOLaPalma3;
        public static String NamePositionPivotGMOLaPalma4 = NamePivotGMOLaPalma4;
        public static String NamePositionPivotGMOLaPalma5 = NamePivotGMOLaPalma5;
        public static String NamePositionPivotGMOElTacuru1 = NamePivotGMOElTacuru1;
        public static String NamePositionPivotGMOElTacuru2 = NamePivotGMOElTacuru2;
        public static String NamePositionPivotGMOElTacuru3 = NamePivotGMOElTacuru3;
        public static String NamePositionPivotGMOElTacuru4 = NamePivotGMOElTacuru4;
        public static String NamePositionPivotGMOElTacuru5 = NamePivotGMOElTacuru5;
        public static String NamePositionPivotGMOElTacuru6 = NamePivotGMOElTacuru6;
        public static String NamePositionPivotGMOElTacuru7 = NamePivotGMOElTacuru7;
        public static String NamePositionPivotGMOElTacuru8 = NamePivotGMOElTacuru8;
        public static String NamePositionPivotGMOElTacuru9 = NamePivotGMOElTacuru9;
        public static String NamePositionPivotGMOElTacuru10 = NamePivotGMOElTacuru10;
        #endregion
        public static String NamePositionPivot = "";
        #endregion
        public static String NamePosition = "";
        #endregion
        #endregion
        
        #endregion

        #region Crop
        public static int MaxEvapotranspirationToIrrigate_Corn = 35;
        public static int MinEvapotranspirationToIrrigate_Corn = 30;
        public static int MaxEvapotranspirationToIrrigate_Soya = 30;
        public static int MinEvapotranspirationToIrrigate_Soya = 25;

        public static int CropDensity_Corn = 81000;
        public static int CropDensity_Soya = 350000;
        #endregion

        #region Pivots By Default
        public static Double PivotEfficiencyByDefault = 0.85;
        public static int PivotSurfaceByDefault = 300;
        #endregion

        #region Irrigation Predeterminated Quantity
        /// <summary>
        /// Predeterminated Irrigation Quantity
        /// 
        /// Changes:
        /// 2016:02:18 - From 20 -> 15
        /// </summary>
        public static Double PredeterminatedIrrigationQuantity = 15;
        #endregion

        #endregion

        #region Properties
        #endregion

        #region Construction
        #endregion

        #region Private Helpers
        #endregion

        #region Public Methods

        #region Dates

        /// <summary>
        /// Return the difference in days between two Dates
        /// </summary>
        /// <param name="oldDate"></param>
        /// <param name="newDate"></param>
        /// <returns></returns>
        public static int GetDaysDifference(DateTime oldDate, DateTime newDate)
        {
            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - oldDate;

            // Difference in days.
            return ts.Days;
        }

        /// <summary>
        /// Return if the Date One is Later than Date Two.
        /// NOT Compares Years.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsBetweenDatesWithoutYear(DateTime pDateOne, DateTime pDateTwo, DateTime pDateBetween)
        {
            bool lReturn = false;
            DateTime lNewDateTime;

            if (pDateTwo >= pDateOne)
            {
                lNewDateTime = new DateTime(pDateOne.Year, pDateBetween.Month, pDateBetween.Day);
                if (pDateOne <= lNewDateTime && pDateTwo >= lNewDateTime)
                {
                    lReturn = true;
                }
            }
            else
            {
                lNewDateTime = new DateTime(pDateTwo.Year, pDateBetween.Month, pDateBetween.Day);
                if (pDateOne >= lNewDateTime && pDateTwo <= lNewDateTime)
                {
                    lReturn = true;
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Return if the Dates have the same month and day.
        /// NOT Compares Years.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsTheSameDayWithoutYear(DateTime pDateOne, DateTime pDateTwo)
        {
            bool lReturn = false;
            bool lIsTheSameDay = false;

            if (pDateOne.Month == pDateTwo.Month && pDateOne.Day == pDateTwo.Day)
            {
                lIsTheSameDay = true;
            }

            lReturn = lIsTheSameDay;
            return lReturn;
        }

        /// <summary>
        /// Return if the Dates have the same year, month and day.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsTheSameDay(DateTime pDateOne, DateTime pDateTwo)
        {
            bool lReturn = false;
            if (pDateOne.Year == pDateTwo.Year && pDateOne.Month == pDateTwo.Month && pDateOne.Day == pDateTwo.Day)
            {
                lReturn = true;
            }
            return lReturn;
        }

        /// <summary>
        /// Return if the Dates have the same year, month, day and hour.
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static bool IsTheSameDayAndHour(DateTime dateOne, DateTime dateTwo)
        {
            bool lReturn = false;
            if (dateOne.Year == dateTwo.Year
                && dateOne.Month == dateTwo.Month
                && dateOne.Day == dateTwo.Day
                && dateOne.Hour == dateTwo.Hour)
            {
                lReturn = true;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the day of the week in spanish
        /// </summary>
        /// <param name="pDayOfWeek"></param>
        /// <returns></returns>
        public static String DayOfWeekInSpanish(DayOfWeek pDayOfWeek)
        {
            String lReturn = "";

            switch (pDayOfWeek)
            {
                case DayOfWeek.Sunday:
                    lReturn = "Domingo";
                    break;
                case DayOfWeek.Monday:
                    lReturn = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    lReturn = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    lReturn = "Miércoles";
                    break;
                case DayOfWeek.Thursday:
                    lReturn = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    lReturn = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    lReturn = "Sábado";
                    break;
            }
            return lReturn;
        }
        
        /// <summary>
        /// Return the min date between two dates
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static DateTime MinDateTimeBetween(DateTime pDateOne, DateTime pDateTwo)
        {
            DateTime lReturn = MIN_DATETIME;
            if(pDateOne.Date < pDateTwo.Date)
            {
                lReturn = pDateOne;
            }
            else
            {
                lReturn = pDateTwo;
            }
            return lReturn;
        }

        /// <summary>
        /// Return the max date between two dates
        /// </summary>
        /// <param name="pDateOne"></param>
        /// <param name="pDateTwo"></param>
        /// <returns></returns>
        public static DateTime MaxDateTimeBetween(DateTime pDateOne, DateTime pDateTwo)
        {
            DateTime lReturn = MAX_DATETIME;
            if (pDateOne.Date < pDateTwo.Date)
            {
                lReturn = pDateTwo;
            }
            else
            {
                lReturn = pDateOne;
            }
            return lReturn;
        }

        /// <summary>
        /// Return DateTime for Client Scripts in format YYYY-MM-DD
        /// </summary>
        /// <param name="pDate"></param>
        /// <returns></returns>
        public static String GetDateTimeForClientScripts(DateTime pDate)
        {
            //YYYY-MM-DD
            String lResult = null;

            String lMonth = null;
            String lDay = null;

            if (pDate.Month < 10)
            {
                lMonth = "0" + pDate.Month.ToString();
            }
            else
            {
                lMonth = pDate.Month.ToString();
            }

            if (pDate.Day < 10)
            {
                lDay = "0" + pDate.Day.ToString();
            }
            else
            {
                lDay = pDate.Day.ToString();
            }

            lResult = String.Format("{0}-{1}-{2}",
                                    pDate.Year,
                                    lMonth,
                                    lDay);

            return lResult;

        }

        #endregion

        #region Lists


        /// <summary>
        /// Get Date of reference
        /// </summary>
        /// <returns></returns>
        public static DateTime? GetDateOfReference()
        {
            StatusConfiguration sc = new StatusConfiguration();
            string lStatusName = System.Configuration.ConfigurationManager.AppSettings["Status"];
            DateTime? lDateOfReference = sc.GetDateOfReference(lStatusName);

            return lDateOfReference;
        }

        #endregion

        #region Location

        /// <summary>
        /// Distance between Origin and Destiny,
        /// using Latitude and Longitude in degrees or in radians
        /// </summary>
        /// <param name="pLatitudOrigin"></param>
        /// <param name="pLongitudeOrigin"></param>
        /// <param name="pLatitudDestiny"></param>
        /// <param name="pLongitudeDestiny"></param>
        /// <param name="pInDegrees"></param>
        /// <returns></returns>
        public static Double DistanceFromLatitudeLongitudeInKm(Double pLatitudOrigin, Double pLongitudeOrigin,
                                                Double pLatitudDestiny, Double pLongitudeDestiny,
                                                bool pInDegrees)
        {
            Double lReturn = 0;
            //Radius of the earth in km
            Double lEarthRadius = Utils.EARTH_RADIUS_IN_KM;
            Double lLatitudeOrigin = 0;
            Double lLongitudeOrigin = 0;
            Double lLatitudeDestiny = 0;
            Double lLongitudeDestiny = 0;
            Double lLatitudeDifference = 0;
            Double lLongitudeDifference = 0;
            Double lParcialA = 0;
            Double lParcialB = 0;

            if (pInDegrees)
            {
                lLatitudeOrigin = DegreesToRadians(pLatitudOrigin);
                lLongitudeOrigin = DegreesToRadians(pLongitudeOrigin);
                lLatitudeDestiny = DegreesToRadians(pLatitudDestiny);
                lLongitudeDestiny = DegreesToRadians(pLongitudeDestiny);
                lLatitudeDifference = DegreesToRadians(pLatitudDestiny - pLatitudOrigin);
                lLongitudeDifference = DegreesToRadians(pLongitudeDestiny - pLongitudeOrigin);
            }
            else
            {
                lLatitudeOrigin = pLatitudOrigin;
                lLongitudeOrigin = pLongitudeOrigin;
                lLatitudeDestiny = pLatitudDestiny;
                lLongitudeDestiny = pLongitudeDestiny;
                lLatitudeDifference = pLatitudDestiny - pLatitudOrigin;
                lLongitudeDifference = pLongitudeDestiny - pLongitudeOrigin;
            }

            lParcialA = Math.Sin(lLatitudeDifference / 2) * Math.Sin(lLatitudeDifference/2)
                            + Math.Cos(lLatitudeOrigin) * Math.Cos(lLatitudeDestiny)
                            * Math.Sin(lLongitudeDifference/2) * Math.Sin(lLongitudeDifference/2);
            lParcialB = 2 * Math.Atan2(Math.Sqrt(lParcialA), Math.Sqrt(1 - lParcialA));
            lReturn = lEarthRadius * lParcialB;

            return lReturn;
        }

        /// <summary>
        /// Convert Degrees into Radians
        /// </summary>
        /// <param name="pDegrees"></param>
        /// <returns></returns>
        public static Double DegreesToRadians (Double pDegrees)
        {
            Double lReturn = 0;
            lReturn = pDegrees * (Math.PI / 180);
            return lReturn;
        }

        /// <summary>
        /// Convert Radians into Degrees
        /// </summary>
        /// <param name="pRadians"></param>
        /// <returns></returns>
        public static Double RadiansToDegrees(Double pRadians)
        {
            Double lReturn = 0;
            lReturn = pRadians * (180 / Math.PI);
            return lReturn;
        }

        #endregion

        #endregion

        #region Overrides
        #endregion

    }

    /// <summary>
    /// Abstract class for logging errors to different output devices, 
    /// primarily for use in Windows Forms applications
    /// </summary>
    public abstract class LoggerImplementation
    {
        /// <summary>Logs the specified error.</summary>
        /// <param name="error">The error to log.</param>
        public abstract void LogError(string error);
    }

    /// <summary>
    /// Class to log unhandled exceptions
    /// </summary>
    public class ExceptionLogger
    {
        /// <summary>
        /// Creates a new instance of the ExceptionLogger class
        /// </summary>
        public ExceptionLogger()
        {
            Application.ThreadException +=
                new System.Threading.ThreadExceptionEventHandler(OnThreadException);
            AppDomain.CurrentDomain.UnhandledException +=
                new UnhandledExceptionEventHandler(OnUnhandledException);
            loggers = new List<LoggerImplementation>();
        }

        private List<LoggerImplementation> loggers;
        /// <summary>
        /// Adds a logger implementation to the list of used loggers.
        /// </summary>
        /// <param name="logger">The logger to add.</param>
        public void AddLogger(LoggerImplementation logger)
        {
            loggers.Add(logger);
        }

        private Utils.NotificationType notificationType = Utils.NotificationType.Ask;
        /// <summary>
        /// Gets or sets the type of the notification shown to the end user.
        /// </summary>
        public Utils.NotificationType NotificationType
        {
            get { return notificationType; }
            set { notificationType = value; }
        }

        delegate void LogExceptionDelegate(Exception e);
        private void HandleException(Exception e)
        {
            switch (notificationType)
            {
                case Utils.NotificationType.Ask:
                    if (MessageBox.Show("An unexpected error occurred - " + e.Message +
                     ". Do you wish to log the error?", "Error", MessageBoxButtons.YesNo) == DialogResult.No)
                        return;
                    break;
                case Utils.NotificationType.Inform:
                    MessageBox.Show("An unexpected error occurred - " + e.Message);
                    break;
                case Utils.NotificationType.Silent:
                    break;
            }

            LogExceptionDelegate logDelegate = new LogExceptionDelegate(LogException);
            logDelegate.BeginInvoke(e, new AsyncCallback(LogCallBack), null);
        }

        // Event handler that will be called when an unhandled
        // exception is caught
        private void OnThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // Log the exception to a lFile
            HandleException(e.Exception);
        }

        private void OnUnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            HandleException((Exception)e.ExceptionObject);
        }

        private void LogCallBack(IAsyncResult result)
        {
            AsyncResult asyncResult = (AsyncResult)result;
            LogExceptionDelegate logDelegate = (LogExceptionDelegate)asyncResult.AsyncDelegate;
            if (!asyncResult.EndInvokeCalled)
            {
                logDelegate.EndInvoke(result);
            }
        }

        private string GetExceptionTypeStack(Exception e)
        {
            if (e.InnerException != null)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine(GetExceptionTypeStack(e.InnerException));
                message.AppendLine("   " + e.GetType().ToString());
                return (message.ToString());
            }
            else
            {
                return "   " + e.GetType().ToString();
            }
        }

        private string GetExceptionMessageStack(Exception e)
        {
            if (e.InnerException != null)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine(GetExceptionMessageStack(e.InnerException));
                message.AppendLine("   " + e.Message);
                return (message.ToString());
            }
            else
            {
                return "   " + e.Message;
            }
        }

        private string GetExceptionCallStack(Exception e)
        {
            if (e.InnerException != null)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine(GetExceptionCallStack(e.InnerException));
                message.AppendLine("--- Next Call Stack:");
                message.AppendLine(e.StackTrace);
                return (message.ToString());
            }
            else
            {
                return e.StackTrace;
            }
        }

        private static TimeSpan GetSystemUpTime()
        {
            PerformanceCounter upTime = new PerformanceCounter("System", "System Up Time");
            upTime.NextValue();
            return TimeSpan.FromSeconds(upTime.NextValue());
        }

        // use to get memory available
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;

            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(MEMORYSTATUSEX));
            }
        }
        
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        /// <summary>writes exception details to the registered loggers</summary>
        /// <param name="exception">The exception to log.</param>
        public void LogException(Exception exception)
        {
            StringBuilder error = new StringBuilder();

            error.AppendLine("Application:       " + Application.ProductName);
            error.AppendLine("Version:           " + Application.ProductVersion);
            error.AppendLine("Date:              " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            error.AppendLine("Computer name:     " + SystemInformation.ComputerName);
            error.AppendLine("User name:         " + SystemInformation.UserName);
            error.AppendLine("OS:                " + Environment.OSVersion.ToString());
            error.AppendLine("Culture:           " + CultureInfo.CurrentCulture.Name);
            error.AppendLine("Resolution:        " + SystemInformation.PrimaryMonitorSize.ToString());
            error.AppendLine("System up time:    " + GetSystemUpTime());
            error.AppendLine("App up time:       " +
              (DateTime.Now - Process.GetCurrentProcess().StartTime).ToString());

            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(memStatus))
            {
                error.AppendLine("Total memory:      " + memStatus.ullTotalPhys / (1024 * 1024) + "Mb");
                error.AppendLine("Available memory:  " + memStatus.ullAvailPhys / (1024 * 1024) + "Mb");
            }
            error.AppendLine("");

            error.AppendLine("Exception classes:   ");
            error.Append(GetExceptionTypeStack(exception));
            error.AppendLine("");
            error.AppendLine("Exception messages: ");
            error.Append(GetExceptionMessageStack(exception));

            error.AppendLine("");
            error.AppendLine("Stack Traces:");
            error.Append(GetExceptionCallStack(exception));
            error.AppendLine("");
            error.AppendLine("Loaded Modules:");
            Process thisProcess = Process.GetCurrentProcess();
            foreach (ProcessModule module in thisProcess.Modules)
            {
                error.AppendLine(module.FileName + " " + module.FileVersionInfo.FileVersion);
            }

            for (int i = 0; i < loggers.Count; i++)
            {
                loggers[i].LogError(error.ToString());
            }
        }

    }

}