using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

using IrrigationAdvisor.DBContext;

using System.Data.Entity;

namespace IrrigationAdvisorConsole
{
    public static class DataEntry
    {

        #region Config Data Crops 2016

        #region Specie
        public static double BaseTemperature_CornSouth_2016 = 10;
        public static double StressTemperature_CornSouth_2016 = 32;
        public static double BaseTemperature_CornNorth_2016 = 8;
        public static double StressTemperature_CornNorth_2016 = 32;

        public static double BaseTemperature_SoyaSouth_2016 = 8;
        public static double StressTemperature_SoyaSouth_2016 = 34;
        public static double BaseTemperature_SoyaNorth_2016 = 8;
        public static double StressTemperature_SoyaNorth_2016 = 34;

        public static double BaseTemperature_SorghumForageSouth_2016 = 8;
        public static double StressTemperature_SorghumForageSouth_2016 = 35;
        public static double BaseTemperature_SorghumForageNorth_2016 = 8;
        public static double StressTemperature_SorghumForageNorth_2016 = 35;

        public static double BaseTemperature_SorghumGrainSouth_2016 = 8;
        public static double StressTemperature_SorghumGrainSouth_2016 = 35;
        public static double BaseTemperature_SorghumGrainNorth_2016 = 8;
        public static double StressTemperature_SorghumGrainNorth_2016 = 35;

        public static double BaseTemperature_AlfalfaSouth_2016 = 8;
        public static double StressTemperature_AlfalfaSouth_2016 = 35;
        public static double BaseTemperature_AlfalfaNorth_2016 = 8;
        public static double StressTemperature_AlfalfaNorth_2016 = 35;

        public static double BaseTemperature_RedCloverForageSouth_2016 = 8;
        public static double StressTemperature_RedCloverForageSouth_2016 = 35;
        public static double BaseTemperature_RedCloverForageNorth_2016 = 8;
        public static double StressTemperature_RedCloverForageNorth_2016 = 35;

        public static double BaseTemperature_RedCloverSeedSouth_2016 = 8;
        public static double StressTemperature_RedCloverSeedSouth_2016 = 35;
        public static double BaseTemperature_RedCloverSeedNorth_2016 = 8;
        public static double StressTemperature_RedCloverSeedNorth_2016 = 35;

        public static double BaseTemperature_FescueForageSouth_2016 = 8;
        public static double StressTemperature_FescueForageSouth_2016 = 33;
        public static double BaseTemperature_FescueForageNorth_2016 = 8;
        public static double StressTemperature_FescueForageNorth_2016 = 33;

        public static double BaseTemperature_FescueSeedSouth_2016 = 8;
        public static double StressTemperature_FescueSeedSouth_2016 = 33;
        public static double BaseTemperature_FescueSeedNorth_2016 = 8;
        public static double StressTemperature_FescueSeedNorth_2016 = 33;

        #endregion

        #region CropIrrigationWeather

        #region Santa Lucia
        //public static DateTime SowingDate_CornSouth_SantaLuciaPivot1_2016 = new DateTime(2016, 10, 01);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2016 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot2_2016 = new DateOfData(2016, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot2_2016 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot3_2016 = new DateOfData(2016, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot3_2016 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot5_2016 = new DateOfData(2016, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot5_2016 = 15;
        #endregion

        #region DCA - El Paraiso
        public static DateTime SowingDate_FestucaSouth_DCAElParaisoPivot1_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot1_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot1_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_DCAElParaisoPivot2_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot2_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot2_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_DCAElParaisoPivot3_2016 = new DateTime(2012, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot3_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot3_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot4_2016 = new DateTime(2012, 9, 16);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot4_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot4_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot5_2016 = new DateTime(2016, 5, 24);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot5_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot5_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot6_2016 = new DateTime(2016, 5, 24);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot6_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot6_2016 = 12;
        public static DateTime SowingDate_FestucaSouth_LDCAElParaisoPivot7_2016 = new DateTime(2016, 5, 24);
        public static DateTime HarvestDate_FestucaSouth_DCAElParaisoPivot7_2016 = new DateTime(2017, 4, 5);
        public static Double PredeterminatedIrrigationQuantity_DCAElParaisoPivot7_2016 = 12;
        #endregion

        #region DCA - San Jose
        public static DateTime SowingDate_CornSouth_DCASanJosePivot1_2016 = new DateTime(2016, 9, 19);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot1_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCASanJosePivot2_2016 = new DateTime(2016, 9, 19);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot2_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCASanJosePivot3_2016 = new DateTime(2016, 9, 19);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot3_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCASanJosePivot4_2016 = new DateTime(2016, 9, 19);
        public static DateTime HarvestDate_CornSouth_DCASanJosePivot4_2016 = new DateTime(2017, 2, 20);
        public static Double PredeterminatedIrrigationQuantity_DCASanJosePivot4_2016 = 14;
        #endregion

        #region DCA - La Perdiz
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot1_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot1_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot2_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot2_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot3_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot3_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot4_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot4_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot4_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot5_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot5_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot5_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot6_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot6_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot6_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot7_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot7_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot7_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot8_2016 = new DateTime(2016, 8, 20);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot8_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot8_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot9_2016 = new DateTime(2016, 8, 20);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot9_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot9_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot10a_2016 = new DateTime(2016, 8, 20);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot10a_2016 = new DateTime(2017, 04, 5);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot10a_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot10b_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot10b_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot10b_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot11_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot11_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot11_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot12_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot12_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot12_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot13_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot13_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot13_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot14_2016 = new DateTime(2016, 9, 16);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot14_2016 = new DateTime(2017, 04, 05);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot14_2016 = 14;
        public static DateTime SowingDate_CornSouth_DCALaPerdizPivot15_2016 = new DateTime(2016, 9, 23);
        public static DateTime HarvestDate_CornSouth_DCALaPerdizPivot15_2016 = new DateTime(2017, 04, 05);
        public static Double PredeterminatedIrrigationQuantity_DCALaPerdizPivot15_2016 = 14;
        #endregion

        #region Del Lago - San Pedro

        #endregion

        #region Del Lago - El Mirador
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot1_2016 = new DateTime(2016, 09, 20); //1
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot1_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot2_2016 = new DateTime(2016, 09, 20); //2
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot2_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot3_2016 = new DateTime(2016, 09, 20); //3
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot3_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot4_2016 = new DateTime(2016, 09, 20); //4
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot4_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot4_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot5_2016 = new DateTime(2016, 10, 23); //5
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot5_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot5_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot6_2016 = new DateTime(2016, 10, 18); //6
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot6_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot7_2016 = new DateTime(2016, 10, 15); //7
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot7_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot8_2016 = new DateTime(2016, 10, 18); //8
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot8_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot9_2016 = new DateTime(2016, 10, 16); //9
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot9_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot10_2016 = new DateTime(2016, 11, 14); //10
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot10_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot10_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot11_2016 = new DateTime(2016, 11, 11); //11
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot11_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot11_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot12_2016 = new DateTime(2016, 10, 23); //12
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot12_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot12_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot13_2016 = new DateTime(2016, 11, 09); //13
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot13_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot13_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot14_2016 = new DateTime(2016, 10, 24); //14
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot14_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot14_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot15_2016 = new DateTime(2016, 11, 09); //15
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivot15_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot15_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivotChaja1_2016 = new DateTime(2016, 10, 03); //Chaja 1
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivotChaja1_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja1_2016 = 14;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivotChaja2_2016 = new DateTime(2016, 11, 07); //Chaja 2
        public static DateTime HarvestDate_CornSouth_DelLagoElMiradorPivotChaja2_2016 = new DateTime(2017, 02, 10);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja2_2016 = 14;
        #endregion

        #region GMO - La Palma
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot1_2016 = new DateTime(2015, 06, 30);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot1_2016 = new DateTime(2017, 04, 30);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot1_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot2_2016 = new DateTime(2016, 09, 26);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot2_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot2_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot3_2016 = new DateTime(2016, 09, 25);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot3_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot3_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot4_2016 = new DateTime(2016, 09, 24);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot4_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot4_2016 = 14;
        public static DateTime SowingDate_CornSouth_GMOLaPalmaPivot5_2016 = new DateTime(2016, 09, 24);
        public static DateTime HarvestDate_CornSouth_GMOLaPalmaPivot5_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOLaPalmaPivot5_2016 = 14;
        #endregion

        #region GMO - El Tacuru
        public static DateTime SowingDate_AlfalfaNorth_GMOElTacuruPivot1a_2016 = new DateTime(2016, 06, 23);
        public static DateTime HarvestDate_AlfalfaNorth_GMOElTacuruPivot1a_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot1a_2016 = 12;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot1b_2016 = new DateTime(2016, 10, 29);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot1b_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot1b_2016 = 12;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot2a_2016 = new DateTime(2016, 09, 21);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot2a_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot2a_2016 = 12;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot2b_2016 = new DateTime(2016, 11, 07);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot2b_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot2b_2016 = 12;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot3a_2016 = new DateTime(2016, 09, 19);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot3a_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot3a_2016 = 12;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot3b_2016 = new DateTime(2016, 11, 11);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot3b_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot3b_2016 = 12;
        public static DateTime SowingDate_CornNorth_GMOElTacuruPivot4_2016 = new DateTime(2016, 09, 17);
        public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot4_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot4_2016 = 12;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot5_2016 = new DateTime(2016, 10, 28);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot5_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot5_2016 = 10;
        //public static DateTime SowingDate_CornNorth_GMOElTacuruPivot6_2016 = new DateTime(2016, 10, 15);
        //public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot6_2016 = new DateTime(2017, 02, 20);
        //public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot6_2016 = 10;
        //public static DateTime SowingDate_CornNorth_GMOElTacuruPivot7_2016 = new DateTime(2016, 10, 15);
        //public static DateTime HarvestDate_CornNorth_GMOElTacuruPivot7_2016 = new DateTime(2017, 02, 20);
        //public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot7_2016 = 10;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot8_2016 = new DateTime(2016, 10, 31);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot8_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot8_2016 = 10;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot9_2016 = new DateTime(2016, 11, 06);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot9_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot9_2016 = 10;
        public static DateTime SowingDate_SoyaNorth_GMOElTacuruPivot10_2016 = new DateTime(2016, 11, 11);
        public static DateTime HarvestDate_SoyaNorth_GMOElTacuruPivot10_2016 = new DateTime(2017, 02, 20);
        public static Double PredeterminatedIrrigationQuantity_GMOElTacuruPivot10_2016 = 10;
        #endregion

        #region LR - La Rinconada
        public static DateTime SowingDate_SoyaNorth_LaRinconadaPivot1_2016 = new DateTime(2016, 10, 29);
        public static DateTime HarvestDate_SoyaNorth_LaRinconadaPivot1_2016 = new DateTime(2017, 02, 28);
        public static Double PredeterminatedIrrigationQuantity_LaRinconadaPivot1_2016 = 14;
        public static DateTime SowingDate_SoyaNorth_LaRinconadaPivot2_2016 = new DateTime(2016, 11, 25);
        public static DateTime HarvestDate_SoyaNorth_LaRinconadaPivot2_2016 = new DateTime(2017, 02, 28);
        public static Double PredeterminatedIrrigationQuantity_LaRinconadaPivot2_2016 = 14;
        public static DateTime SowingDate_SoyaNorth_LaRinconadaPivot3_1_2016 = new DateTime(2016, 10, 29);
        public static DateTime HarvestDate_SoyaNorth_LaRinconadaPivot3_1_2016 = new DateTime(2017, 02, 28);
        public static Double PredeterminatedIrrigationQuantity_LaRinconadaPivot3_1_2016 = 14;
        public static DateTime SowingDate_SoyaNorth_LaRinconadaPivot13_1_2016 = new DateTime(2016, 11, 15);
        public static DateTime HarvestDate_SoyaNorth_LaRinconadaPivot13_1_2016 = new DateTime(2017, 02, 28);
        public static Double PredeterminatedIrrigationQuantity_LaRinconadaPivot13_1_2016 = 14;

        #endregion

        #endregion

        #endregion

        #region PhenologicalStage

        #region DCA La Perdiz

        #region 2016
        public static void AddPhenologicalStageAdjustementsLaPerdizPivot2_2015(IrrigationAdvisorContext context)
        {
            #region context
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            String lName = "";
            DateTime lDateTimeToChange;
            PhenologicalStage lPhenologicalStage;
            Stage lStageToChange;
            String lObservation = "";

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            #endregion

            //First Change
            lStageToChange = (from stage in context.Stages
                              where stage.Name.Contains(Utils.NameStagesCorn + " V4")
                              select stage).FirstOrDefault();
            lPhenologicalStage = (from phenologicalstage in context.PhenologicalStages
                                  where phenologicalstage.SpecieId.Equals(lCrop.SpecieId)
                                  && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                  select phenologicalstage).FirstOrDefault();
            lDateTimeToChange = new DateTime(2015, 11, 20);
            lObservation = "Real Stage is " + lStageToChange.Name
                + ", " + lStageToChange.Description + ".";
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();

            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange,
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }

        public static void AddPhenologicalStageAdjustementsLaPerdizPivot3_2015(IrrigationAdvisorContext context)
        {
            #region context
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            String lName = "";
            DateTime lDateTimeToChange;
            PhenologicalStage lPhenologicalStage;
            Stage lStageToChange;
            String lObservation = "";

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            #endregion

            //First Change
            lStageToChange = (from stage in context.Stages
                              where stage.Name.Contains(Utils.NameStagesCorn + " V4")
                              select stage).FirstOrDefault();
            lPhenologicalStage = (from phenologicalstage in context.PhenologicalStages
                                  where phenologicalstage.SpecieId.Equals(lCrop.SpecieId)
                                  && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                  select phenologicalstage).FirstOrDefault();
            lDateTimeToChange = new DateTime(2015, 11, 20);
            lObservation = "Real Stage is " + lStageToChange.Name
                + ", " + lStageToChange.Description + ".";
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();

            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange,
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }

        public static void AddPhenologicalStageAdjustementsLaPerdizPivot5_2015(IrrigationAdvisorContext context)
        {
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            String lName = "";
            DateTime lDateTimeToChange;
            PhenologicalStage lPhenologicalStage;
            Stage lStageToChange;
            String lObservation = "";

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();


            //First Change
            lStageToChange = (from stage in context.Stages
                              where stage.Name.Contains(Utils.NameStagesCorn + " V4")
                              select stage).FirstOrDefault();
            lPhenologicalStage = (from phenologicalstage in context.PhenologicalStages
                                  where phenologicalstage.SpecieId.Equals(lCrop.SpecieId)
                                  && phenologicalstage.StageId.Equals(lStageToChange.StageId)
                                  select phenologicalstage).FirstOrDefault();
            lDateTimeToChange = new DateTime(2015, 11, 20);
            lObservation = "Real Stage is " + lStageToChange.Name
                + ", " + lStageToChange.Description + ".";
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();

            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange,
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }
        #endregion

        #endregion

        #endregion

        #region Information To IrrigationUnits

        #region Demo1 - La Perdiz

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 11 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot11_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo11
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo11
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo11)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 128)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    context.SaveChanges();
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 12 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot12_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo12
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo12
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo12)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 13 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot13_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo13
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo13
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo13)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo1 - La Perdiz Pivot 15 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo1Pivot15_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo15
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList)
                                 .FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo15
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo15)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #region Demo2 - Santa Lucia

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 21 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot21_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo21
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo21
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo21)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 128)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    context.SaveChanges();
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 22 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot22_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo22
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo22
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo22)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 23 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot23_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo23
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo23
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo23)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 24 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot24_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo24
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo24
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo24)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo2 - Santa Lucia Pivot 25 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo2Pivot25_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo2
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo25
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList)
                                 .FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo25
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo25)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #region Demo3 - La Palma

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 31 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot31_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo31
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo31
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo31)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 128)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    context.SaveChanges();
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 32A 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot32A_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo32A
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo32A
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo32A)
                            select horizon).ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 33 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot33_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo33
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo33
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo33)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 34 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot34_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo34
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo34
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo34)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 342 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot342_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo34
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo34
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo34)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Demo3 - La Palma Pivot 35 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDemo3Pivot35_2015(IrrigationAdvisorContext context)
        {
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;

            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo3
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo35
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList)
                                 .FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDemo35
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDemo35)
                            select horizon)
                            .ToList<Horizon>();

            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();

            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #region DCA El Paraiso

        #region 2016
        #endregion

        #endregion

        #region DCA San Jose

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - San Jose Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCASanJosePivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCASanJose1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCASanJose1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCASanJose)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - San Jose Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCASanJosePivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCASanJose4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCASanJose4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCASanJose)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region DCA La Perdiz

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 6 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz6)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 10a 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot10a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieFescueForageSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesFescueForage)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieFescueForageSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz10a
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieFescueForageSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieFescueForageSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieFescueForageSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz10a
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz10a)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 10b 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot10b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz10b
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz10b
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz10b)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - DCA - La Perdiz Pivot 15 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDCALaPerdizPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz15
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDCALaPerdiz15
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz15)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCA
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DCALaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #region 2016

        #endregion

        #endregion

        #region Del Lago - El Mirador

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 3 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador3)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 5 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador5)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 6 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 7 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador7
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 8 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador8
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 9 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador9
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 10 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador10
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador10
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador10)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 11 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador11
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador11
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador11)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 12 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador12
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador12
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador12)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 13 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador13
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador13
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador13)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 14 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador14
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador14
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador14)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 15 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador15
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMirador15
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador15)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot Chaja 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivotChaja1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Local Variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMiradorChaja1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot Chaja 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivotChaja2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLaTribu
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilDelLagoElMiradorChaja2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLago
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieAlfalfaSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesAlfalfa)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 3 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate &&
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year &&
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - La Palma Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOLaPalmaPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornSouthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornSouthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate &&
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year &&
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornSouthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornSouthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOLaPalma4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOLaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region GMO - El Tacuru

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 1a 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot1a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieAlfalfaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesAlfalfa)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1a
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                            && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                            && ciw.SowingDate <= pDateOfReference
                                            && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieAlfalfaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru1a
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru1a)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 1b 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot1b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1b
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                            && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                            && ciw.SowingDate <= pDateOfReference
                                            && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru1b
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru1b)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 2a 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot2a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2a
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                            && ciw.SowingDate <= pDateOfReference
                                            && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru2a
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru2a)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 2b 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot2b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2b
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                            && ciw.SowingDate <= pDateOfReference
                                            && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru2b
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru2b)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 3a 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot3a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3a
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru3a
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru3a)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 63 || i == 73)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 3b 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot3b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3b
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru3b
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru3b)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 4 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru4)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 5 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru5)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 6 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru6)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 7 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieCornNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesCorn)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru7
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieCornNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieCornNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieCornNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru7
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru7)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 8 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru8
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru8
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru8)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 9 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru9
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru9
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru9)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - GMO - El Tacuru Pivot 10 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsGMOElTacuruPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru10
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationViveroSanFrancisco
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilGMOElTacuru10
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru10)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMOElTacuru)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #region La Rinconada

        #region 2016

        /// <summary>
        /// Add Information To IrrigationUnits - La Rinconada Pivot 1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaRinconadaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationElRetiro
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilLaRinconada1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaRinconada1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaRinconada)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - La Rinconada Pivot 2 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaRinconadaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationElRetiro
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.SowingDate <= pDateOfReference
                                          && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate ||
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year ||
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilLaRinconada2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaRinconada2)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaRinconada)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - La Rinconada Pivot 3.1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaRinconadaPivot3_1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada3_1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationElRetiro
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate &&
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year &&
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilLaRinconada3_1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaRinconada3_1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaRinconada)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - La Rinconada Pivot 13.1 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaRinconadaPivot13_1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region local variables
            Specie lSpecie = null;
            List<Stage> lStages = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            Farm lFarm = null;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit = null;
            CropIrrigationWeather lCropIrrigationWeather = null;

            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            Double lDiffDays = 0;
            DateTime lFromDate;
            DateTime lToDate;
            DateTime lDateOfRecord;
            String lObservation;
            #endregion
            #region Crop
            lSpecie = (from sp in context.Species
                       where sp.Name == Utils.NameSpecieSoyaNorthShort
                       select sp).FirstOrDefault();
            lStages = (from st in context.Stages
                       where st.Name.Contains(Utils.NameStagesSoya)
                       select st).ToList<Stage>();
            lPhenologicalStages = (from ps in context.PhenologicalStages
                                   where ps.SpecieId == lSpecie.SpecieId
                                   select ps).ToList<PhenologicalStage>();
            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            #endregion
            #region Weather
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada13_1
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationElRetiro
                                   select ws).FirstOrDefault();
            lWeatherStationAlternative = (from ws in context.WeatherStations
                                          where ws.Name == Utils.NameWeatherStationSaltoGrande
                                          select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                      select ciw).FirstOrDefault();
            lCropInformationByDate = (from cid in context.CropInformationByDates
                                      where cid.Name == Utils.NameSpecieSoyaNorthShort
                                      select cid).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();
            #endregion
            #region Data to Calculate
            lSowingDate = lCropIrrigationWeather.SowingDate;
            lHarvestDate = lCropIrrigationWeather.HarvestDate;
            lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                                    join weatherstation in context.WeatherStations
                                    on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                    where (weatherdata.Date >= lSowingDate &&
                                            weatherdata.Date <= lHarvestDate) &&
                                            weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                                    select weatherdata).ToList<WeatherData>();
            lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                                           join weatherstation in context.WeatherStations
                                           on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                                           where (weatherdata.Date.Year >= lSowingDate.Year &&
                                                weatherdata.Date.Year <= lHarvestDate.Year) &&
                                                weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                           select weatherdata).ToList<WeatherData>();
            lCropCoefficient = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaNorthShort
                                select cc).FirstOrDefault();
            lKCList = (from cc in context.CropCoefficients
                       where cc.Name == Utils.NameSpecieSoyaNorthShort
                       select cc.KCList).FirstOrDefault();
            lSoil = (from soil in context.Soils
                     where soil.Name == Utils.NameSoilLaRinconada13_1
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaRinconada13_1)
                            select horizon).ToList<Horizon>();
            #endregion
            #region Calculate for each day
            //The start Day is one Day after sowing 
            //because the first Day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > pDateOfReference)
            {
                lToDate = pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION);
            }
            else
            {
                lToDate = lHarvestDate;
            }
            lDiffDays = lToDate.Subtract(lFromDate).TotalDays;

            for (int i = 0; i < lDiffDays; i++)
            {
                #region Erase - only for debug - do nothing
                //TODO: Erase To debug
                if (i == 15)
                {
                    //System.Diagnostics.Debugger.Break();
                }
                #endregion

                lObservation = "Dia " + (i + 1);
                lDateOfRecord = lFromDate.AddDays(i);

                lCropIrrigationWeather.HasAdviseOfIrrigation = false;
                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);
                context.SaveChanges();

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        context.SaveChanges();
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if (lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #endregion
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Production
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaRinconada)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = lCropIrrigationWeather.GetNewMessagesId();
                long lLineId = 0;
                foreach (var item in lCropIrrigationWeather.Messages)
                {
                    if ((lTitleId - lFirstTitleId) % (lTotalTitles) == 0)
                    {
                        lTitleId = lFirstTitleId;
                        lLineId += 1;
                        context.SaveChanges();
                    }
                    item.MessageId = lMessageId;
                    item.LineId = lLineId;
                    item.CropIrrigationWeatherId = lCropIrrigationWeather.CropIrrigationWeatherId;
                    item.TitleId = lTitleId;
                    context.Messages.Add(item);
                    lTitleId += 1;
                    lMessageId += 1;
                }
                context.SaveChanges();
                lObservation = "";
            }
            #endregion
        }

        #endregion

        #endregion

        #endregion

    }

}
