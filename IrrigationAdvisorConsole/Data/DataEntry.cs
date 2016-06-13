﻿using System;
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

        #region Config Data Crops 2015

        #region Specie
        public static double BaseTemperature_CornSouth_2015 = 8;
        public static double StressTemperature_CornSouth_2015 = 35;
        public static double BaseTemperature_CornNorth_2015 = 8;
        public static double StressTemperature_CornNorth_2015 = 35;

        public static double BaseTemperature_SoyaSouth_2015 = 8;
        public static double StressTemperature_SoyaSouth_2015 = 40;
        public static double BaseTemperature_SoyaNorth_2015 = 8;
        public static double StressTemperature_SoyaNorth_2015 = 40;

        public static double BaseTemperature_ForageSorghumSouth_2015 = 8;
        public static double StressTemperature_ForageSorghumSouth_2015 = 35;
        public static double BaseTemperature_ForageSorghumNorth_2015 = 8;
        public static double StressTemperature_ForageSorghumNorth_2015 = 35;

        public static double BaseTemperature_GrainSorghumSouth_2015 = 8;
        public static double StressTemperature_GrainSorghumSouth_2015 = 35;
        public static double BaseTemperature_GrainSorghumNorth_2015 = 8;
        public static double StressTemperature_GrainSorghumNorth_2015 = 35;

        public static double BaseTemperature_AlfalfaSouth_2015 = 8;
        public static double StressTemperature_AlfalfaSouth_2015 = 35;
        public static double BaseTemperature_AlfalfaNorth_2015 = 8;
        public static double StressTemperature_AlfalfaNorth_2015 = 35;

        public static double BaseTemperature_RedCloverSouth_2015 = 8;
        public static double StressTemperature_RedCloverSouth_2015 = 35;
        public static double BaseTemperature_RedCloverNorth_2015 = 8;
        public static double StressTemperature_RedCloverNorth_2015 = 35;

        public static double BaseTemperature_FescueSouth_2015 = 8;
        public static double StressTemperature_FescueSouth_2015 = 35;
        public static double BaseTemperature_FescueNorth_2015 = 8;
        public static double StressTemperature_FescueNorth_2015 = 35;

        #endregion

        #region CropIrrigationWeather

        #region La Perdiz
        public static DateTime SowingDate_CornSouth_LaPerdizPivot2_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_LaPerdizPivot2_2015 = 15;
        public static DateTime SowingDate_CornSouth_LaPerdizPivot3_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_LaPerdizPivot3_2015 = 15;
        public static DateTime SowingDate_CornSouth_LaPerdizPivot5_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_LaPerdizPivot5_2015 = 15;
        #endregion

        #region Del Lago - San Pedro
        public static DateTime SowingDate_CornSouth_DelLagoSanPedroPivot5_2015 = new DateTime(2015, 10, 8);
        public static Double PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2015 = 15;
        public static DateTime SowingDate_CornSouth_DelLagoSanPedroPivot6_2015 = new DateTime(2015, 10, 19);
        public static Double PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2015 = 15;
        public static DateTime SowingDate_CornSouth_DelLagoSanPedroPivot7_2015 = new DateTime(2015, 10, 13);
        public static Double PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2015 = 15;
        public static DateTime SowingDate_CornSouth_DelLagoSanPedroPivot8_2015 = new DateTime(2015, 10, 3);
        public static Double PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2015 = 15;
        #endregion

        #region Del Lago - El Mirador
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot6_2015 = new DateTime(2015, 10, 18);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2015 = 15;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot7_2015 = new DateTime(2015, 10, 27);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2015 = 15;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot8_2015 = new DateTime(2015, 10, 27);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2015 = 15;
        public static DateTime SowingDate_CornSouth_DelLagoElMiradorPivot9_2015 = new DateTime(2015, 10, 14);
        public static Double PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2015 = 15;
        #endregion

        #region La Palma
        public static DateTime SowingDate_CornSouth_LaPalmaPivot2A_2015 = new DateTime(2015, 10, 15);
        public static Double PredeterminatedIrrigationQuantity_LaPalmaPivot2A_2015 = 15;
        public static DateTime SowingDate_CornSouth_LaPalmaPivot3_2015 = new DateTime(2015, 10, 15);
        public static Double PredeterminatedIrrigationQuantity_LaPalmaPivot3_2015 = 15;
        public static DateTime SowingDate_CornSouth_LaPalmaPivot4_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_LaPalmaPivot4_2015 = 15;
        #endregion

        #endregion

        #endregion

        #region DataTemperatures_2015

        public static void DataTemperatures_South_2014(IrrigationAdvisorContext context, Region pRegion)
        {
            Region lRegion = pRegion;

            #region South

            #region 2014 new TemperatureData
            var lTD_South_20140901 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140901", Date = new DateTime(2014, 09, 01), RegionId = lRegion.RegionId, Min = 7.8, Max = 20, Average = 13.9, ETC = 1.9, Rain = 0, };
            var lTD_South_20140902 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140902", Date = new DateTime(2014, 09, 02), RegionId = lRegion.RegionId, Min = 11.7, Max = 19, Average = 15.4, ETC = 1.7, Rain = 1.8, };
            var lTD_South_20140903 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140903", Date = new DateTime(2014, 09, 03), RegionId = lRegion.RegionId, Min = 13.7, Max = 20.7, Average = 17.2, ETC = 2.6, Rain = 0, };
            var lTD_South_20140904 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140904", Date = new DateTime(2014, 09, 04), RegionId = lRegion.RegionId, Min = 13.3, Max = 20.4, Average = 16.9, ETC = 3.5, Rain = 0.3, };
            var lTD_South_20140905 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140905", Date = new DateTime(2014, 09, 05), RegionId = lRegion.RegionId, Min = 14.3, Max = 21.2, Average = 17.8, ETC = 2.4, Rain = 31.9, };
            var lTD_South_20140906 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140906", Date = new DateTime(2014, 09, 06), RegionId = lRegion.RegionId, Min = 9.4, Max = 19.4, Average = 14.4, ETC = 1.9, Rain = 3.1, };
            var lTD_South_20140907 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140907", Date = new DateTime(2014, 09, 07), RegionId = lRegion.RegionId, Min = 8.5, Max = 21, Average = 14.8, ETC = 2.6, Rain = 0, };
            var lTD_South_20140908 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140908", Date = new DateTime(2014, 09, 08), RegionId = lRegion.RegionId, Min = 8.3, Max = 23.8, Average = 16.1, ETC = 3.3, Rain = 21.3, };
            var lTD_South_20140909 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140909", Date = new DateTime(2014, 09, 09), RegionId = lRegion.RegionId, Min = 9.6, Max = 22.4, Average = 16, ETC = 1.6, Rain = 18.3, };
            var lTD_South_20140910 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140910", Date = new DateTime(2014, 09, 10), RegionId = lRegion.RegionId, Min = 8.6, Max = 16.1, Average = 12.4, ETC = 2.5, Rain = 0, };
            var lTD_South_20140911 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140911", Date = new DateTime(2014, 09, 11), RegionId = lRegion.RegionId, Min = 5.6, Max = 18.3, Average = 12, ETC = 2.5, Rain = 0, };
            var lTD_South_20140912 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140912", Date = new DateTime(2014, 09, 12), RegionId = lRegion.RegionId, Min = 4.5, Max = 20, Average = 12.3, ETC = 2.6, Rain = 0, };
            var lTD_South_20140913 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140913", Date = new DateTime(2014, 09, 13), RegionId = lRegion.RegionId, Min = 9.1, Max = 17.8, Average = 13.5, ETC = 1.8, Rain = 24.5, };
            var lTD_South_20140914 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140914", Date = new DateTime(2014, 09, 14), RegionId = lRegion.RegionId, Min = 13.8, Max = 15.8, Average = 14.8, ETC = 1.3, Rain = 27.7, };
            var lTD_South_20140915 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140915", Date = new DateTime(2014, 09, 15), RegionId = lRegion.RegionId, Min = 8, Max = 16.7, Average = 12.4, ETC = 2.2, Rain = 0, };
            var lTD_South_20140916 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140916", Date = new DateTime(2014, 09, 16), RegionId = lRegion.RegionId, Min = 4.8, Max = 20.4, Average = 12.6, ETC = 2.3, Rain = 0, };
            var lTD_South_20140917 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140917", Date = new DateTime(2014, 09, 17), RegionId = lRegion.RegionId, Min = 7.6, Max = 19, Average = 13.3, ETC = 2.3, Rain = 0, };
            var lTD_South_20140918 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140918", Date = new DateTime(2014, 09, 18), RegionId = lRegion.RegionId, Min = 8.3, Max = 21.6, Average = 15, ETC = 2.7, Rain = 0, };
            var lTD_South_20140919 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140919", Date = new DateTime(2014, 09, 19), RegionId = lRegion.RegionId, Min = 11.1, Max = 21.4, Average = 16.3, ETC = 2.5, Rain = 0, };
            var lTD_South_20140920 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140920", Date = new DateTime(2014, 09, 20), RegionId = lRegion.RegionId, Min = 10.4, Max = 16.9, Average = 13.7, ETC = 2.7, Rain = 0.1, };
            var lTD_South_20140921 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140921", Date = new DateTime(2014, 09, 21), RegionId = lRegion.RegionId, Min = 11.4, Max = 19.4, Average = 15.4, ETC = 3.1, Rain = 0, };
            var lTD_South_20140922 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140922", Date = new DateTime(2014, 09, 22), RegionId = lRegion.RegionId, Min = 9.3, Max = 21.4, Average = 15.4, ETC = 3.2, Rain = 0, };
            var lTD_South_20140923 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140923", Date = new DateTime(2014, 09, 23), RegionId = lRegion.RegionId, Min = 11.1, Max = 21.3, Average = 16.2, ETC = 2.4, Rain = 3.8, };
            var lTD_South_20140924 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140924", Date = new DateTime(2014, 09, 24), RegionId = lRegion.RegionId, Min = 9.1, Max = 22.9, Average = 16, ETC = 3.7, Rain = 0, };
            var lTD_South_20140925 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140925", Date = new DateTime(2014, 09, 25), RegionId = lRegion.RegionId, Min = 8.6, Max = 24.8, Average = 16.7, ETC = 3.4, Rain = 15.7, };
            var lTD_South_20140926 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140926", Date = new DateTime(2014, 09, 26), RegionId = lRegion.RegionId, Min = 7.6, Max = 16.1, Average = 11.9, ETC = 3.4, Rain = 0, };
            var lTD_South_20140927 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140927", Date = new DateTime(2014, 09, 27), RegionId = lRegion.RegionId, Min = 3.9, Max = 19.1, Average = 11.5, ETC = 3.7, Rain = 0, };
            var lTD_South_20140928 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140928", Date = new DateTime(2014, 09, 28), RegionId = lRegion.RegionId, Min = 10.5, Max = 21.1, Average = 15.8, ETC = 2.3, Rain = 18.4, };
            var lTD_South_20140929 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140929", Date = new DateTime(2014, 09, 29), RegionId = lRegion.RegionId, Min = 11.8, Max = 20.9, Average = 16.4, ETC = 3.2, Rain = 0, };
            var lTD_South_20140930 = new TemperatureData { Name = Utils.NameRegionSouth + "-20140930", Date = new DateTime(2014, 09, 30), RegionId = lRegion.RegionId, Min = 9.3, Max = 23.5, Average = 16.4, ETC = 3.2, Rain = 0, };
            var lTD_South_20141001 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141001", Date = new DateTime(2014, 10, 01), RegionId = lRegion.RegionId, Min = 7.6, Max = 15.3, Average = 11.5, ETC = 2.4, Rain = 0, };
            var lTD_South_20141002 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141002", Date = new DateTime(2014, 10, 02), RegionId = lRegion.RegionId, Min = 4.2, Max = 17.1, Average = 10.7, ETC = 3.1, Rain = 0, };
            var lTD_South_20141003 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141003", Date = new DateTime(2014, 10, 03), RegionId = lRegion.RegionId, Min = 10.4, Max = 17.7, Average = 14.1, ETC = 3.6, Rain = 0, };
            var lTD_South_20141004 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141004", Date = new DateTime(2014, 10, 04), RegionId = lRegion.RegionId, Min = 13.5, Max = 19.3, Average = 16.4, ETC = 3.8, Rain = 6.1, };
            var lTD_South_20141005 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141005", Date = new DateTime(2014, 10, 05), RegionId = lRegion.RegionId, Min = 14.1, Max = 20.3, Average = 17.2, ETC = 2.6, Rain = 24.2, };
            var lTD_South_20141006 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141006", Date = new DateTime(2014, 10, 06), RegionId = lRegion.RegionId, Min = 13.4, Max = 21.5, Average = 17.5, ETC = 3.2, Rain = 0, };
            var lTD_South_20141007 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141007", Date = new DateTime(2014, 10, 07), RegionId = lRegion.RegionId, Min = 11.7, Max = 22.9, Average = 17.3, ETC = 3.6, Rain = 0, };
            var lTD_South_20141008 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141008", Date = new DateTime(2014, 10, 08), RegionId = lRegion.RegionId, Min = 12.9, Max = 26.8, Average = 19.9, ETC = 4.1, Rain = 21.5, };
            var lTD_South_20141009 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141009", Date = new DateTime(2014, 10, 09), RegionId = lRegion.RegionId, Min = 15.2, Max = 23.2, Average = 19.2, ETC = 2.5, Rain = 11.5, };
            var lTD_South_20141010 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141010", Date = new DateTime(2014, 10, 10), RegionId = lRegion.RegionId, Min = 10.1, Max = 15.6, Average = 12.9, ETC = 3.4, Rain = 0, };
            var lTD_South_20141011 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141011", Date = new DateTime(2014, 10, 11), RegionId = lRegion.RegionId, Min = 9.2, Max = 19.8, Average = 14.5, ETC = 3.2, Rain = 0, };
            var lTD_South_20141012 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141012", Date = new DateTime(2014, 10, 12), RegionId = lRegion.RegionId, Min = 9.8, Max = 20.5, Average = 15.1, ETC = 2.8, Rain = 0, };
            var lTD_South_20141013 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141013", Date = new DateTime(2014, 10, 13), RegionId = lRegion.RegionId, Min = 10, Max = 22.9, Average = 16.5, ETC = 2.6, Rain = 0, };
            var lTD_South_20141014 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141014", Date = new DateTime(2014, 10, 14), RegionId = lRegion.RegionId, Min = 10.8, Max = 25.4, Average = 18.1, ETC = 4.3, Rain = 0, };
            var lTD_South_20141015 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141015", Date = new DateTime(2014, 10, 15), RegionId = lRegion.RegionId, Min = 12.1, Max = 27, Average = 19.6, ETC = 5, Rain = 0.3, };
            var lTD_South_20141016 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141016", Date = new DateTime(2014, 10, 16), RegionId = lRegion.RegionId, Min = 15.4, Max = 25.3, Average = 20.4, ETC = 3.6, Rain = 0, };
            var lTD_South_20141017 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141017", Date = new DateTime(2014, 10, 17), RegionId = lRegion.RegionId, Min = 9.8, Max = 25.5, Average = 17.7, ETC = 4.6, Rain = 0, };
            var lTD_South_20141018 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141018", Date = new DateTime(2014, 10, 18), RegionId = lRegion.RegionId, Min = 15.9, Max = 23.2, Average = 19.6, ETC = 2.4, Rain = 0.9, };
            var lTD_South_20141019 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141019", Date = new DateTime(2014, 10, 19), RegionId = lRegion.RegionId, Min = 14.3, Max = 22.2, Average = 18.3, ETC = 4.8, Rain = 0, };
            var lTD_South_20141020 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141020", Date = new DateTime(2014, 10, 20), RegionId = lRegion.RegionId, Min = 10.9, Max = 20.9, Average = 15.9, ETC = 4.2, Rain = 0, };
            var lTD_South_20141021 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141021", Date = new DateTime(2014, 10, 21), RegionId = lRegion.RegionId, Min = 11.3, Max = 27.1, Average = 19.2, ETC = 4.8, Rain = 0, };
            var lTD_South_20141022 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141022", Date = new DateTime(2014, 10, 22), RegionId = lRegion.RegionId, Min = 13.3, Max = 30.2, Average = 21.8, ETC = 5.5, Rain = 0, };
            var lTD_South_20141023 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141023", Date = new DateTime(2014, 10, 23), RegionId = lRegion.RegionId, Min = 13.7, Max = 30.2, Average = 22, ETC = 5, Rain = 0, };
            var lTD_South_20141024 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141024", Date = new DateTime(2014, 10, 24), RegionId = lRegion.RegionId, Min = 16.8, Max = 28.6, Average = 22.7, ETC = 4.6, Rain = 0, };
            var lTD_South_20141025 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141025", Date = new DateTime(2014, 10, 25), RegionId = lRegion.RegionId, Min = 16.8, Max = 29.1, Average = 23, ETC = 5, Rain = 0, };
            var lTD_South_20141026 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141026", Date = new DateTime(2014, 10, 26), RegionId = lRegion.RegionId, Min = 17.3, Max = 30.7, Average = 24, ETC = 5.6, Rain = 0, };
            var lTD_South_20141027 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141027", Date = new DateTime(2014, 10, 27), RegionId = lRegion.RegionId, Min = 18.1, Max = 33.3, Average = 25.7, ETC = 6.5, Rain = 0, };
            var lTD_South_20141028 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141028", Date = new DateTime(2014, 10, 28), RegionId = lRegion.RegionId, Min = 18.2, Max = 26.5, Average = 22.4, ETC = 5.5, Rain = 42, };
            var lTD_South_20141029 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141029", Date = new DateTime(2014, 10, 29), RegionId = lRegion.RegionId, Min = 15.1, Max = 19.2, Average = 17.2, ETC = 1.9, Rain = 21.7, };
            var lTD_South_20141030 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141030", Date = new DateTime(2014, 10, 30), RegionId = lRegion.RegionId, Min = 12.9, Max = 23.4, Average = 18.2, ETC = 4.5, Rain = 0, };
            var lTD_South_20141031 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141031", Date = new DateTime(2014, 10, 31), RegionId = lRegion.RegionId, Min = 12.3, Max = 21.4, Average = 16.9, ETC = 3.3, Rain = 0.5, };
            var lTD_South_20141101 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141101", Date = new DateTime(2014, 11, 01), RegionId = lRegion.RegionId, Min = 13.5, Max = 17.4, Average = 15.5, ETC = 3.3, Rain = 1.2, };
            var lTD_South_20141102 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141102", Date = new DateTime(2014, 11, 02), RegionId = lRegion.RegionId, Min = 12.4, Max = 16.8, Average = 14.6, ETC = 2.9, Rain = 39.9, };
            var lTD_South_20141103 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141103", Date = new DateTime(2014, 11, 03), RegionId = lRegion.RegionId, Min = 14, Max = 18.2, Average = 16.1, ETC = 2.1, Rain = 8.9, };
            var lTD_South_20141104 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141104", Date = new DateTime(2014, 11, 04), RegionId = lRegion.RegionId, Min = 12.1, Max = 18.4, Average = 15.3, ETC = 4.8, Rain = 0, };
            var lTD_South_20141105 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141105", Date = new DateTime(2014, 11, 05), RegionId = lRegion.RegionId, Min = 9.2, Max = 23.8, Average = 16.5, ETC = 4.9, Rain = 0, };
            var lTD_South_20141106 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141106", Date = new DateTime(2014, 11, 06), RegionId = lRegion.RegionId, Min = 10.5, Max = 24.8, Average = 17.7, ETC = 4.8, Rain = 0, };
            var lTD_South_20141107 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141107", Date = new DateTime(2014, 11, 07), RegionId = lRegion.RegionId, Min = 14.6, Max = 26.6, Average = 20.6, ETC = 4.6, Rain = 0, };
            var lTD_South_20141108 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141108", Date = new DateTime(2014, 11, 08), RegionId = lRegion.RegionId, Min = 10.4, Max = 27.6, Average = 19, ETC = 5.5, Rain = 0, };
            var lTD_South_20141109 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141109", Date = new DateTime(2014, 11, 09), RegionId = lRegion.RegionId, Min = 10.9, Max = 27.4, Average = 19.2, ETC = 5.3, Rain = 0, };
            var lTD_South_20141110 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141110", Date = new DateTime(2014, 11, 10), RegionId = lRegion.RegionId, Min = 13.8, Max = 29, Average = 21.4, ETC = 4.5, Rain = 6.3, };
            var lTD_South_20141111 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141111", Date = new DateTime(2014, 11, 11), RegionId = lRegion.RegionId, Min = 16, Max = 26.8, Average = 21.4, ETC = 4.9, Rain = 0, };
            var lTD_South_20141112 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141112", Date = new DateTime(2014, 11, 12), RegionId = lRegion.RegionId, Min = 12.2, Max = 22.9, Average = 17.6, ETC = 5, Rain = 0, };
            var lTD_South_20141113 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141113", Date = new DateTime(2014, 11, 13), RegionId = lRegion.RegionId, Min = 8.8, Max = 20.1, Average = 14.5, ETC = 4.7, Rain = 0, };
            var lTD_South_20141114 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141114", Date = new DateTime(2014, 11, 14), RegionId = lRegion.RegionId, Min = 8.7, Max = 26.5, Average = 17.6, ETC = 5.6, Rain = 0, };
            var lTD_South_20141115 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141115", Date = new DateTime(2014, 11, 15), RegionId = lRegion.RegionId, Min = 14.2, Max = 31.4, Average = 22.8, ETC = 6.5, Rain = 0, };
            var lTD_South_20141116 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141116", Date = new DateTime(2014, 11, 16), RegionId = lRegion.RegionId, Min = 15.5, Max = 25.8, Average = 20.7, ETC = 5.8, Rain = 0, };
            var lTD_South_20141117 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141117", Date = new DateTime(2014, 11, 17), RegionId = lRegion.RegionId, Min = 12.1, Max = 28.9, Average = 20.5, ETC = 6.5, Rain = 0, };
            var lTD_South_20141118 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141118", Date = new DateTime(2014, 11, 18), RegionId = lRegion.RegionId, Min = 14.5, Max = 30.4, Average = 22.5, ETC = 6.5, Rain = 0, };
            var lTD_South_20141119 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141119", Date = new DateTime(2014, 11, 19), RegionId = lRegion.RegionId, Min = 16.5, Max = 28.9, Average = 22.7, ETC = 3.7, Rain = 0.3, };
            var lTD_South_20141120 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141120", Date = new DateTime(2014, 11, 20), RegionId = lRegion.RegionId, Min = 12.4, Max = 23.2, Average = 17.8, ETC = 3.2, Rain = 0, };
            var lTD_South_20141121 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141121", Date = new DateTime(2014, 11, 21), RegionId = lRegion.RegionId, Min = 14.2, Max = 19.9, Average = 17.1, ETC = 2.6, Rain = 15.9, };
            var lTD_South_20141122 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141122", Date = new DateTime(2014, 11, 22), RegionId = lRegion.RegionId, Min = 13.8, Max = 20.7, Average = 17.3, ETC = 4.4, Rain = 0, };
            var lTD_South_20141123 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141123", Date = new DateTime(2014, 11, 23), RegionId = lRegion.RegionId, Min = 11.4, Max = 27.8, Average = 19.6, ETC = 6.2, Rain = 0.4, };
            var lTD_South_20141124 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141124", Date = new DateTime(2014, 11, 24), RegionId = lRegion.RegionId, Min = 13.8, Max = 20.8, Average = 17.3, ETC = 2.4, Rain = 8.3, };
            var lTD_South_20141125 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141125", Date = new DateTime(2014, 11, 25), RegionId = lRegion.RegionId, Min = 12.1, Max = 22.2, Average = 17.2, ETC = 5.1, Rain = 0, };
            var lTD_South_20141126 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141126", Date = new DateTime(2014, 11, 26), RegionId = lRegion.RegionId, Min = 9, Max = 22.3, Average = 15.7, ETC = 3.9, Rain = 0, };
            var lTD_South_20141127 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141127", Date = new DateTime(2014, 11, 27), RegionId = lRegion.RegionId, Min = 8.7, Max = 27, Average = 17.9, ETC = 5.4, Rain = 0, };
            var lTD_South_20141128 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141128", Date = new DateTime(2014, 11, 28), RegionId = lRegion.RegionId, Min = 12.5, Max = 28.9, Average = 20.7, ETC = 7.1, Rain = 0, };
            var lTD_South_20141129 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141129", Date = new DateTime(2014, 11, 29), RegionId = lRegion.RegionId, Min = 15.7, Max = 32.4, Average = 24.1, ETC = 6.3, Rain = 43.1, };
            var lTD_South_20141130 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141130", Date = new DateTime(2014, 11, 30), RegionId = lRegion.RegionId, Min = 16.9, Max = 22, Average = 19.5, ETC = 2.2, Rain = 14.2, };
            var lTD_South_20141201 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141201", Date = new DateTime(2014, 12, 01), RegionId = lRegion.RegionId, Min = 16.2, Max = 19.9, Average = 18.1, ETC = 2.7, Rain = 0.5, };
            var lTD_South_20141202 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141202", Date = new DateTime(2014, 12, 02), RegionId = lRegion.RegionId, Min = 16.3, Max = 19.6, Average = 18, ETC = 2.3, Rain = 1, };
            var lTD_South_20141203 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141203", Date = new DateTime(2014, 12, 03), RegionId = lRegion.RegionId, Min = 15.1, Max = 25.3, Average = 20.2, ETC = 5.9, Rain = 0, };
            var lTD_South_20141204 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141204", Date = new DateTime(2014, 12, 04), RegionId = lRegion.RegionId, Min = 13.5, Max = 30, Average = 21.8, ETC = 6.4, Rain = 0, };
            var lTD_South_20141205 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141205", Date = new DateTime(2014, 12, 05), RegionId = lRegion.RegionId, Min = 14.3, Max = 31.1, Average = 22.7, ETC = 7.6, Rain = 0, };
            var lTD_South_20141206 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141206", Date = new DateTime(2014, 12, 06), RegionId = lRegion.RegionId, Min = 16.5, Max = 32.9, Average = 24.7, ETC = 7.4, Rain = 0, };
            var lTD_South_20141207 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141207", Date = new DateTime(2014, 12, 07), RegionId = lRegion.RegionId, Min = 18.1, Max = 27.3, Average = 22.7, ETC = 3.6, Rain = 4.8, };
            var lTD_South_20141208 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141208", Date = new DateTime(2014, 12, 08), RegionId = lRegion.RegionId, Min = 15.7, Max = 26.2, Average = 21, ETC = 2.5, Rain = 0, };
            var lTD_South_20141209 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141209", Date = new DateTime(2014, 12, 09), RegionId = lRegion.RegionId, Min = 18.8, Max = 29.7, Average = 24.3, ETC = 5.2, Rain = 6.3, };
            var lTD_South_20141210 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141210", Date = new DateTime(2014, 12, 10), RegionId = lRegion.RegionId, Min = 14.7, Max = 23, Average = 18.8, ETC = 4.9, Rain = 0, };
            var lTD_South_20141211 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141211", Date = new DateTime(2014, 12, 11), RegionId = lRegion.RegionId, Min = 12.4, Max = 22.8, Average = 17.6, ETC = 5.5, Rain = 0, };
            var lTD_South_20141212 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141212", Date = new DateTime(2014, 12, 12), RegionId = lRegion.RegionId, Min = 13.7, Max = 26.7, Average = 20.2, ETC = 5.2, Rain = 0, };
            var lTD_South_20141213 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141213", Date = new DateTime(2014, 12, 13), RegionId = lRegion.RegionId, Min = 14.9, Max = 27, Average = 21, ETC = 5.5, Rain = 0, };
            var lTD_South_20141214 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141214", Date = new DateTime(2014, 12, 14), RegionId = lRegion.RegionId, Min = 12, Max = 23, Average = 17.5, ETC = 5.8, Rain = 0, };
            var lTD_South_20141215 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141215", Date = new DateTime(2014, 12, 15), RegionId = lRegion.RegionId, Min = 10.5, Max = 27.2, Average = 18.9, ETC = 6.2, Rain = 0.1, };
            var lTD_South_20141216 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141216", Date = new DateTime(2014, 12, 16), RegionId = lRegion.RegionId, Min = 18.7, Max = 26.7, Average = 22.7, ETC = 3.7, Rain = 0, };
            var lTD_South_20141217 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141217", Date = new DateTime(2014, 12, 17), RegionId = lRegion.RegionId, Min = 17.1, Max = 26.8, Average = 22, ETC = 6, Rain = 0, };
            var lTD_South_20141218 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141218", Date = new DateTime(2014, 12, 18), RegionId = lRegion.RegionId, Min = 15.8, Max = 30.5, Average = 23.2, ETC = 6.9, Rain = 0, };
            var lTD_South_20141219 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141219", Date = new DateTime(2014, 12, 19), RegionId = lRegion.RegionId, Min = 18.7, Max = 33.9, Average = 26.3, ETC = 8.6, Rain = 0, };
            var lTD_South_20141220 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141220", Date = new DateTime(2014, 12, 20), RegionId = lRegion.RegionId, Min = 18.7, Max = 26.5, Average = 22.6, ETC = 4.5, Rain = 9, };
            var lTD_South_20141221 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141221", Date = new DateTime(2014, 12, 21), RegionId = lRegion.RegionId, Min = 12.2, Max = 20.5, Average = 16.4, ETC = 3.6, Rain = 9.3, };
            var lTD_South_20141222 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141222", Date = new DateTime(2014, 12, 22), RegionId = lRegion.RegionId, Min = 11.6, Max = 20.8, Average = 16.2, ETC = 5.4, Rain = 0, };
            var lTD_South_20141223 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141223", Date = new DateTime(2014, 12, 23), RegionId = lRegion.RegionId, Min = 10.2, Max = 23.8, Average = 17, ETC = 6.1, Rain = 0, };
            var lTD_South_20141224 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141224", Date = new DateTime(2014, 12, 24), RegionId = lRegion.RegionId, Min = 10.4, Max = 28.3, Average = 19.4, ETC = 6.9, Rain = 0, };
            var lTD_South_20141225 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141225", Date = new DateTime(2014, 12, 25), RegionId = lRegion.RegionId, Min = 16.2, Max = 32.3, Average = 24.3, ETC = 7, Rain = 0, };
            var lTD_South_20141226 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141226", Date = new DateTime(2014, 12, 26), RegionId = lRegion.RegionId, Min = 18.7, Max = 31.5, Average = 25.1, ETC = 3.9, Rain = 27.1, };
            var lTD_South_20141227 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141227", Date = new DateTime(2014, 12, 27), RegionId = lRegion.RegionId, Min = 18, Max = 28.5, Average = 23.3, ETC = 5.3, Rain = 0, };
            var lTD_South_20141228 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141228", Date = new DateTime(2014, 12, 28), RegionId = lRegion.RegionId, Min = 19.9, Max = 29.2, Average = 24.6, ETC = 5.8, Rain = 0, };
            var lTD_South_20141229 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141229", Date = new DateTime(2014, 12, 29), RegionId = lRegion.RegionId, Min = 18.9, Max = 32, Average = 25.5, ETC = 6.9, Rain = 0, };
            var lTD_South_20141230 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141230", Date = new DateTime(2014, 12, 30), RegionId = lRegion.RegionId, Min = 22, Max = 31.4, Average = 26.7, ETC = 7.3, Rain = 0, };
            var lTD_South_20141231 = new TemperatureData { Name = Utils.NameRegionSouth + "-20141231", Date = new DateTime(2014, 12, 31), RegionId = lRegion.RegionId, Min = 19, Max = 30.1, Average = 24.6, ETC = 4.6, Rain = 5.2, };
            #endregion

            #region 2014 context Add
            context.TemperatureDatas.Add(lTD_South_20140901);
            context.TemperatureDatas.Add(lTD_South_20140902);
            context.TemperatureDatas.Add(lTD_South_20140903);
            context.TemperatureDatas.Add(lTD_South_20140904);
            context.TemperatureDatas.Add(lTD_South_20140905);
            context.TemperatureDatas.Add(lTD_South_20140906);
            context.TemperatureDatas.Add(lTD_South_20140907);
            context.TemperatureDatas.Add(lTD_South_20140908);
            context.TemperatureDatas.Add(lTD_South_20140909);
            context.TemperatureDatas.Add(lTD_South_20140910);
            context.TemperatureDatas.Add(lTD_South_20140911);
            context.TemperatureDatas.Add(lTD_South_20140912);
            context.TemperatureDatas.Add(lTD_South_20140913);
            context.TemperatureDatas.Add(lTD_South_20140914);
            context.TemperatureDatas.Add(lTD_South_20140915);
            context.TemperatureDatas.Add(lTD_South_20140916);
            context.TemperatureDatas.Add(lTD_South_20140917);
            context.TemperatureDatas.Add(lTD_South_20140918);
            context.TemperatureDatas.Add(lTD_South_20140919);
            context.TemperatureDatas.Add(lTD_South_20140920);
            context.TemperatureDatas.Add(lTD_South_20140921);
            context.TemperatureDatas.Add(lTD_South_20140922);
            context.TemperatureDatas.Add(lTD_South_20140923);
            context.TemperatureDatas.Add(lTD_South_20140924);
            context.TemperatureDatas.Add(lTD_South_20140925);
            context.TemperatureDatas.Add(lTD_South_20140926);
            context.TemperatureDatas.Add(lTD_South_20140927);
            context.TemperatureDatas.Add(lTD_South_20140928);
            context.TemperatureDatas.Add(lTD_South_20140929);
            context.TemperatureDatas.Add(lTD_South_20140930);
            context.TemperatureDatas.Add(lTD_South_20141001);
            context.TemperatureDatas.Add(lTD_South_20141002);
            context.TemperatureDatas.Add(lTD_South_20141003);
            context.TemperatureDatas.Add(lTD_South_20141004);
            context.TemperatureDatas.Add(lTD_South_20141005);
            context.TemperatureDatas.Add(lTD_South_20141006);
            context.TemperatureDatas.Add(lTD_South_20141007);
            context.TemperatureDatas.Add(lTD_South_20141008);
            context.TemperatureDatas.Add(lTD_South_20141009);
            context.TemperatureDatas.Add(lTD_South_20141010);
            context.TemperatureDatas.Add(lTD_South_20141011);
            context.TemperatureDatas.Add(lTD_South_20141012);
            context.TemperatureDatas.Add(lTD_South_20141013);
            context.TemperatureDatas.Add(lTD_South_20141014);
            context.TemperatureDatas.Add(lTD_South_20141015);
            context.TemperatureDatas.Add(lTD_South_20141016);
            context.TemperatureDatas.Add(lTD_South_20141017);
            context.TemperatureDatas.Add(lTD_South_20141018);
            context.TemperatureDatas.Add(lTD_South_20141019);
            context.TemperatureDatas.Add(lTD_South_20141020);
            context.TemperatureDatas.Add(lTD_South_20141021);
            context.TemperatureDatas.Add(lTD_South_20141022);
            context.TemperatureDatas.Add(lTD_South_20141023);
            context.TemperatureDatas.Add(lTD_South_20141024);
            context.TemperatureDatas.Add(lTD_South_20141025);
            context.TemperatureDatas.Add(lTD_South_20141026);
            context.TemperatureDatas.Add(lTD_South_20141027);
            context.TemperatureDatas.Add(lTD_South_20141028);
            context.TemperatureDatas.Add(lTD_South_20141029);
            context.TemperatureDatas.Add(lTD_South_20141030);
            context.TemperatureDatas.Add(lTD_South_20141031);
            context.TemperatureDatas.Add(lTD_South_20141101);
            context.TemperatureDatas.Add(lTD_South_20141102);
            context.TemperatureDatas.Add(lTD_South_20141103);
            context.TemperatureDatas.Add(lTD_South_20141104);
            context.TemperatureDatas.Add(lTD_South_20141105);
            context.TemperatureDatas.Add(lTD_South_20141106);
            context.TemperatureDatas.Add(lTD_South_20141107);
            context.TemperatureDatas.Add(lTD_South_20141108);
            context.TemperatureDatas.Add(lTD_South_20141109);
            context.TemperatureDatas.Add(lTD_South_20141110);
            context.TemperatureDatas.Add(lTD_South_20141111);
            context.TemperatureDatas.Add(lTD_South_20141112);
            context.TemperatureDatas.Add(lTD_South_20141113);
            context.TemperatureDatas.Add(lTD_South_20141114);
            context.TemperatureDatas.Add(lTD_South_20141115);
            context.TemperatureDatas.Add(lTD_South_20141116);
            context.TemperatureDatas.Add(lTD_South_20141117);
            context.TemperatureDatas.Add(lTD_South_20141118);
            context.TemperatureDatas.Add(lTD_South_20141119);
            context.TemperatureDatas.Add(lTD_South_20141120);
            context.TemperatureDatas.Add(lTD_South_20141121);
            context.TemperatureDatas.Add(lTD_South_20141122);
            context.TemperatureDatas.Add(lTD_South_20141123);
            context.TemperatureDatas.Add(lTD_South_20141124);
            context.TemperatureDatas.Add(lTD_South_20141125);
            context.TemperatureDatas.Add(lTD_South_20141126);
            context.TemperatureDatas.Add(lTD_South_20141127);
            context.TemperatureDatas.Add(lTD_South_20141128);
            context.TemperatureDatas.Add(lTD_South_20141129);
            context.TemperatureDatas.Add(lTD_South_20141130);
            context.TemperatureDatas.Add(lTD_South_20141201);
            context.TemperatureDatas.Add(lTD_South_20141202);
            context.TemperatureDatas.Add(lTD_South_20141203);
            context.TemperatureDatas.Add(lTD_South_20141204);
            context.TemperatureDatas.Add(lTD_South_20141205);
            context.TemperatureDatas.Add(lTD_South_20141206);
            context.TemperatureDatas.Add(lTD_South_20141207);
            context.TemperatureDatas.Add(lTD_South_20141208);
            context.TemperatureDatas.Add(lTD_South_20141209);
            context.TemperatureDatas.Add(lTD_South_20141210);
            context.TemperatureDatas.Add(lTD_South_20141211);
            context.TemperatureDatas.Add(lTD_South_20141212);
            context.TemperatureDatas.Add(lTD_South_20141213);
            context.TemperatureDatas.Add(lTD_South_20141214);
            context.TemperatureDatas.Add(lTD_South_20141215);
            context.TemperatureDatas.Add(lTD_South_20141216);
            context.TemperatureDatas.Add(lTD_South_20141217);
            context.TemperatureDatas.Add(lTD_South_20141218);
            context.TemperatureDatas.Add(lTD_South_20141219);
            context.TemperatureDatas.Add(lTD_South_20141220);
            context.TemperatureDatas.Add(lTD_South_20141221);
            context.TemperatureDatas.Add(lTD_South_20141222);
            context.TemperatureDatas.Add(lTD_South_20141223);
            context.TemperatureDatas.Add(lTD_South_20141224);
            context.TemperatureDatas.Add(lTD_South_20141225);
            context.TemperatureDatas.Add(lTD_South_20141226);
            context.TemperatureDatas.Add(lTD_South_20141227);
            context.TemperatureDatas.Add(lTD_South_20141228);
            context.TemperatureDatas.Add(lTD_South_20141229);
            context.TemperatureDatas.Add(lTD_South_20141230);
            context.TemperatureDatas.Add(lTD_South_20141231);
            #endregion

            #endregion

        }

        public static void DataTemperatures_South_2015(IrrigationAdvisorContext context, Region pRegion)
        {
            Region lRegion = pRegion;

            #region South

            #region 2015 - new TemperatureData
            var lTD_South_20150101 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150101", Date = new DateTime(2015, 01, 01), RegionId = lRegion.RegionId, Min = 17.3, Max = 25.3, Average = 21.3, ETC = 4.9, Rain = 0, };
            var lTD_South_20150102 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150102", Date = new DateTime(2015, 01, 02), RegionId = lRegion.RegionId, Min = 15.5, Max = 22.6, Average = 19, ETC = 6.4, Rain = 0, };
            var lTD_South_20150103 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150103", Date = new DateTime(2015, 01, 03), RegionId = lRegion.RegionId, Min = 11.4, Max = 29.8, Average = 20.6, ETC = 6.2, Rain = 0, };
            var lTD_South_20150104 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150104", Date = new DateTime(2015, 01, 04), RegionId = lRegion.RegionId, Min = 15.1, Max = 23.2, Average = 19.2, ETC = 5.7, Rain = 0, };
            var lTD_South_20150105 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150105", Date = new DateTime(2015, 01, 05), RegionId = lRegion.RegionId, Min = 12.9, Max = 33.1, Average = 23, ETC = 7.1, Rain = 12.2, };
            var lTD_South_20150106 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150106", Date = new DateTime(2015, 01, 06), RegionId = lRegion.RegionId, Min = 19.6, Max = 24.9, Average = 22.3, ETC = 2.8, Rain = 4.5, };
            var lTD_South_20150107 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150107", Date = new DateTime(2015, 01, 07), RegionId = lRegion.RegionId, Min = 19.2, Max = 30.7, Average = 25, ETC = 4.6, Rain = 0, };
            var lTD_South_20150108 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150108", Date = new DateTime(2015, 01, 08), RegionId = lRegion.RegionId, Min = 18.8, Max = 31.4, Average = 25.1, ETC = 6.5, Rain = 1, };
            var lTD_South_20150109 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150109", Date = new DateTime(2015, 01, 09), RegionId = lRegion.RegionId, Min = 20, Max = 29.4, Average = 24.7, ETC = 4.9, Rain = 16.2, };
            var lTD_South_20150110 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150110", Date = new DateTime(2015, 01, 10), RegionId = lRegion.RegionId, Min = 20.7, Max = 30.1, Average = 25.4, ETC = 5.5, Rain = 0, };
            var lTD_South_20150111 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150111", Date = new DateTime(2015, 01, 11), RegionId = lRegion.RegionId, Min = 21.5, Max = 30.7, Average = 26.1, ETC = 5, Rain = 0, };
            var lTD_South_20150112 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150112", Date = new DateTime(2015, 01, 12), RegionId = lRegion.RegionId, Min = 21.2, Max = 32.7, Average = 27, ETC = 7.5, Rain = 0, };
            var lTD_South_20150113 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150113", Date = new DateTime(2015, 01, 13), RegionId = lRegion.RegionId, Min = 19.4, Max = 23.1, Average = 21.3, ETC = 2.6, Rain = 15.2, };
            var lTD_South_20150114 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150114", Date = new DateTime(2015, 01, 14), RegionId = lRegion.RegionId, Min = 19.9, Max = 25.7, Average = 22.8, ETC = 5.1, Rain = 0, };
            var lTD_South_20150115 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150115", Date = new DateTime(2015, 01, 15), RegionId = lRegion.RegionId, Min = 18, Max = 27.1, Average = 22.6, ETC = 5.2, Rain = 0, };
            var lTD_South_20150116 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150116", Date = new DateTime(2015, 01, 16), RegionId = lRegion.RegionId, Min = 17.5, Max = 31.4, Average = 24.5, ETC = 6.1, Rain = 5.3, };
            var lTD_South_20150117 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150117", Date = new DateTime(2015, 01, 17), RegionId = lRegion.RegionId, Min = 17.2, Max = 24.5, Average = 20.9, ETC = 4.7, Rain = 0, };
            var lTD_South_20150118 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150118", Date = new DateTime(2015, 01, 18), RegionId = lRegion.RegionId, Min = 14.5, Max = 28.5, Average = 21.5, ETC = 4.6, Rain = 1.6, };
            var lTD_South_20150119 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150119", Date = new DateTime(2015, 01, 19), RegionId = lRegion.RegionId, Min = 16.7, Max = 24.4, Average = 20.6, ETC = 2.9, Rain = 1.9, };
            var lTD_South_20150120 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150120", Date = new DateTime(2015, 01, 20), RegionId = lRegion.RegionId, Min = 14.5, Max = 23.7, Average = 19.1, ETC = 4.6, Rain = 0, };
            var lTD_South_20150121 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150121", Date = new DateTime(2015, 01, 21), RegionId = lRegion.RegionId, Min = 11.1, Max = 25.6, Average = 18.4, ETC = 5.6, Rain = 0, };
            var lTD_South_20150122 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150122", Date = new DateTime(2015, 01, 22), RegionId = lRegion.RegionId, Min = 13.2, Max = 28.3, Average = 20.8, ETC = 6.4, Rain = 0, };
            var lTD_South_20150123 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150123", Date = new DateTime(2015, 01, 23), RegionId = lRegion.RegionId, Min = 16.7, Max = 29.3, Average = 23, ETC = 6.2, Rain = 0, };
            var lTD_South_20150124 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150124", Date = new DateTime(2015, 01, 24), RegionId = lRegion.RegionId, Min = 18.3, Max = 29.5, Average = 23.9, ETC = 5.6, Rain = 0, };
            var lTD_South_20150125 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150125", Date = new DateTime(2015, 01, 25), RegionId = lRegion.RegionId, Min = 18.6, Max = 31.4, Average = 25, ETC = 6, Rain = 0, };
            var lTD_South_20150126 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150126", Date = new DateTime(2015, 01, 26), RegionId = lRegion.RegionId, Min = 19.1, Max = 33.3, Average = 26.2, ETC = 5.6, Rain = 0, };
            var lTD_South_20150127 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150127", Date = new DateTime(2015, 01, 27), RegionId = lRegion.RegionId, Min = 21.9, Max = 34.1, Average = 28, ETC = 5.3, Rain = 22.9, };
            var lTD_South_20150128 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150128", Date = new DateTime(2015, 01, 28), RegionId = lRegion.RegionId, Min = 17.7, Max = 23.7, Average = 20.7, ETC = 2.3, Rain = 19.3, };
            var lTD_South_20150129 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150129", Date = new DateTime(2015, 01, 29), RegionId = lRegion.RegionId, Min = 13, Max = 22.3, Average = 17.7, ETC = 5.5, Rain = 0, };
            var lTD_South_20150130 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150130", Date = new DateTime(2015, 01, 30), RegionId = lRegion.RegionId, Min = 11, Max = 24.6, Average = 17.8, ETC = 5.2, Rain = 0, };
            var lTD_South_20150131 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150131", Date = new DateTime(2015, 01, 31), RegionId = lRegion.RegionId, Min = 12.8, Max = 27.9, Average = 20.4, ETC = 5.9, Rain = 0, };
            var lTD_South_20150201 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150201", Date = new DateTime(2015, 02, 01), RegionId = lRegion.RegionId, Min = 16.7, Max = 29.5, Average = 23.1, ETC = 6.1, Rain = 0, };
            var lTD_South_20150202 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150202", Date = new DateTime(2015, 02, 02), RegionId = lRegion.RegionId, Min = 18, Max = 29.5, Average = 23.8, ETC = 6.1, Rain = 0, };
            var lTD_South_20150203 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150203", Date = new DateTime(2015, 02, 03), RegionId = lRegion.RegionId, Min = 17.9, Max = 28.8, Average = 23.4, ETC = 5.8, Rain = 0, };
            var lTD_South_20150204 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150204", Date = new DateTime(2015, 02, 04), RegionId = lRegion.RegionId, Min = 20.5, Max = 31.9, Average = 26.2, ETC = 6.8, Rain = 0, };
            var lTD_South_20150205 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150205", Date = new DateTime(2015, 02, 05), RegionId = lRegion.RegionId, Min = 18.7, Max = 31.4, Average = 25.1, ETC = 6.3, Rain = 0, };
            var lTD_South_20150206 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150206", Date = new DateTime(2015, 02, 06), RegionId = lRegion.RegionId, Min = 18.6, Max = 30.8, Average = 24.7, ETC = 6, Rain = 0, };
            var lTD_South_20150207 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150207", Date = new DateTime(2015, 02, 07), RegionId = lRegion.RegionId, Min = 17.1, Max = 29.6, Average = 23.4, ETC = 5.8, Rain = 0, };
            var lTD_South_20150208 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150208", Date = new DateTime(2015, 02, 08), RegionId = lRegion.RegionId, Min = 16.2, Max = 32.1, Average = 24.2, ETC = 5.5, Rain = 0.2, };
            var lTD_South_20150209 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150209", Date = new DateTime(2015, 02, 09), RegionId = lRegion.RegionId, Min = 20.6, Max = 31.7, Average = 26.2, ETC = 5.8, Rain = 0.6, };
            var lTD_South_20150210 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150210", Date = new DateTime(2015, 02, 10), RegionId = lRegion.RegionId, Min = 17.2, Max = 27.4, Average = 22.3, ETC = 4.1, Rain = 0, };
            var lTD_South_20150211 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150211", Date = new DateTime(2015, 02, 11), RegionId = lRegion.RegionId, Min = 15, Max = 29.2, Average = 22.1, ETC = 6, Rain = 0, };
            var lTD_South_20150212 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150212", Date = new DateTime(2015, 02, 12), RegionId = lRegion.RegionId, Min = 16.2, Max = 32.7, Average = 24.5, ETC = 6.2, Rain = 0.7, };
            var lTD_South_20150213 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150213", Date = new DateTime(2015, 02, 13), RegionId = lRegion.RegionId, Min = 13.8, Max = 23.9, Average = 18.9, ETC = 5.7, Rain = 0, };
            var lTD_South_20150214 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150214", Date = new DateTime(2015, 02, 14), RegionId = lRegion.RegionId, Min = 15.1, Max = 24.4, Average = 19.7, ETC = 5.2, Rain = 0, };
            var lTD_South_20150215 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150215", Date = new DateTime(2015, 02, 15), RegionId = lRegion.RegionId, Min = 15.7, Max = 27.7, Average = 21.7, ETC = 6.1, Rain = 0, };
            var lTD_South_20150216 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150216", Date = new DateTime(2015, 02, 16), RegionId = lRegion.RegionId, Min = 16.7, Max = 29.7, Average = 23.2, ETC = 6.1, Rain = 0, };
            var lTD_South_20150217 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150217", Date = new DateTime(2015, 02, 17), RegionId = lRegion.RegionId, Min = 16.8, Max = 31.2, Average = 24, ETC = 6.2, Rain = 0, };
            var lTD_South_20150218 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150218", Date = new DateTime(2015, 02, 18), RegionId = lRegion.RegionId, Min = 17.1, Max = 31.3, Average = 24.2, ETC = 5.1, Rain = 14.9, };
            var lTD_South_20150219 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150219", Date = new DateTime(2015, 02, 19), RegionId = lRegion.RegionId, Min = 15.5, Max = 21.6, Average = 18.6, ETC = 2.6, Rain = 0.2, };
            var lTD_South_20150220 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150220", Date = new DateTime(2015, 02, 20), RegionId = lRegion.RegionId, Min = 15.5, Max = 23.9, Average = 19.7, ETC = 4.2, Rain = 0, };
            var lTD_South_20150221 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150221", Date = new DateTime(2015, 02, 21), RegionId = lRegion.RegionId, Min = 17.4, Max = 28, Average = 22.7, ETC = 4.2, Rain = 10.5, };
            var lTD_South_20150222 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150222", Date = new DateTime(2015, 02, 22), RegionId = lRegion.RegionId, Min = 16.7, Max = 30.9, Average = 23.8, ETC = 5.2, Rain = 0, };
            var lTD_South_20150223 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150223", Date = new DateTime(2015, 02, 23), RegionId = lRegion.RegionId, Min = 18.8, Max = 31.1, Average = 25, ETC = 5.3, Rain = 0, };
            var lTD_South_20150224 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150224", Date = new DateTime(2015, 02, 24), RegionId = lRegion.RegionId, Min = 20, Max = 34.3, Average = 27.2, ETC = 5.2, Rain = 0, };
            var lTD_South_20150225 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150225", Date = new DateTime(2015, 02, 25), RegionId = lRegion.RegionId, Min = 19.3, Max = 27.7, Average = 23.5, ETC = 3.6, Rain = 0, };
            var lTD_South_20150226 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150226", Date = new DateTime(2015, 02, 26), RegionId = lRegion.RegionId, Min = 19.9, Max = 28.8, Average = 24.4, ETC = 4.4, Rain = 0.1, };
            var lTD_South_20150227 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150227", Date = new DateTime(2015, 02, 27), RegionId = lRegion.RegionId, Min = 13.3, Max = 25.7, Average = 19.5, ETC = 4.3, Rain = 0, };
            var lTD_South_20150228 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150228", Date = new DateTime(2015, 02, 28), RegionId = lRegion.RegionId, Min = 10.3, Max = 26.7, Average = 18.5, ETC = 4.7, Rain = 0, };
            var lTD_South_20150301 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150301", Date = new DateTime(2015, 03, 01), RegionId = lRegion.RegionId, Min = 17.1, Max = 29.3, Average = 23.2, ETC = 4.5, Rain = 0, };
            var lTD_South_20150302 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150302", Date = new DateTime(2015, 03, 02), RegionId = lRegion.RegionId, Min = 17.8, Max = 31, Average = 24.4, ETC = 4.9, Rain = 0, };
            var lTD_South_20150303 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150303", Date = new DateTime(2015, 03, 03), RegionId = lRegion.RegionId, Min = 18.1, Max = 29.7, Average = 23.9, ETC = 2.4, Rain = 46.9, };
            var lTD_South_20150304 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150304", Date = new DateTime(2015, 03, 04), RegionId = lRegion.RegionId, Min = 20.1, Max = 26, Average = 23.1, ETC = 2.7, Rain = 0, };
            var lTD_South_20150305 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150305", Date = new DateTime(2015, 03, 05), RegionId = lRegion.RegionId, Min = 17.6, Max = 27.7, Average = 22.7, ETC = 4.3, Rain = 0, };
            var lTD_South_20150306 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150306", Date = new DateTime(2015, 03, 06), RegionId = lRegion.RegionId, Min = 14.5, Max = 29.3, Average = 21.9, ETC = 4.2, Rain = 0, };
            var lTD_South_20150307 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150307", Date = new DateTime(2015, 03, 07), RegionId = lRegion.RegionId, Min = 15.7, Max = 30.2, Average = 23, ETC = 4.6, Rain = 0, };
            var lTD_South_20150308 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150308", Date = new DateTime(2015, 03, 08), RegionId = lRegion.RegionId, Min = 16.3, Max = 30.9, Average = 23.6, ETC = 4.7, Rain = 0, };
            var lTD_South_20150309 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150309", Date = new DateTime(2015, 03, 09), RegionId = lRegion.RegionId, Min = 19.1, Max = 29.8, Average = 24.5, ETC = 4.6, Rain = 0, };
            var lTD_South_20150310 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150310", Date = new DateTime(2015, 03, 10), RegionId = lRegion.RegionId, Min = 20, Max = 31.6, Average = 25.8, ETC = 4.8, Rain = 0, };
            var lTD_South_20150311 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150311", Date = new DateTime(2015, 03, 11), RegionId = lRegion.RegionId, Min = 17.4, Max = 29.6, Average = 23.5, ETC = 4.5, Rain = 0, };
            var lTD_South_20150312 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150312", Date = new DateTime(2015, 03, 12), RegionId = lRegion.RegionId, Min = 16.2, Max = 31.6, Average = 23.9, ETC = 4.4, Rain = 0, };
            var lTD_South_20150313 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150313", Date = new DateTime(2015, 03, 13), RegionId = lRegion.RegionId, Min = 15.8, Max = 32.7, Average = 24.3, ETC = 4.8, Rain = 0, };
            var lTD_South_20150314 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150314", Date = new DateTime(2015, 03, 14), RegionId = lRegion.RegionId, Min = 17.5, Max = 30.8, Average = 24.2, ETC = 3.6, Rain = 0, };
            var lTD_South_20150315 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150315", Date = new DateTime(2015, 03, 15), RegionId = lRegion.RegionId, Min = 18.2, Max = 26.3, Average = 22.2, ETC = 3.9, Rain = 0, };
            var lTD_South_20150316 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150316", Date = new DateTime(2015, 03, 16), RegionId = lRegion.RegionId, Min = 13.9, Max = 29.5, Average = 21.7, ETC = 4.2, Rain = 0, };
            var lTD_South_20150317 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150317", Date = new DateTime(2015, 03, 17), RegionId = lRegion.RegionId, Min = 16.5, Max = 31.9, Average = 24.2, ETC = 4.6, Rain = 0, };
            var lTD_South_20150318 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150318", Date = new DateTime(2015, 03, 18), RegionId = lRegion.RegionId, Min = 15.9, Max = 31, Average = 23.5, ETC = 4.5, Rain = 0, };
            var lTD_South_20150319 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150319", Date = new DateTime(2015, 03, 19), RegionId = lRegion.RegionId, Min = 16, Max = 30.7, Average = 23.4, ETC = 4.7, Rain = 0, };
            var lTD_South_20150320 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150320", Date = new DateTime(2015, 03, 20), RegionId = lRegion.RegionId, Min = 17.6, Max = 31.1, Average = 24.4, ETC = 4.8, Rain = 0, };
            var lTD_South_20150321 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150321", Date = new DateTime(2015, 03, 21), RegionId = lRegion.RegionId, Min = 15.9, Max = 20.9, Average = 18.4, ETC = 4.2, Rain = 0.8, };
            var lTD_South_20150322 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150322", Date = new DateTime(2015, 03, 22), RegionId = lRegion.RegionId, Min = 13.7, Max = 20.3, Average = 17, ETC = 3.1, Rain = 0, };
            var lTD_South_20150323 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150323", Date = new DateTime(2015, 03, 23), RegionId = lRegion.RegionId, Min = 10.4, Max = 21.5, Average = 16, ETC = 2.6, Rain = 0, };
            var lTD_South_20150324 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150324", Date = new DateTime(2015, 03, 24), RegionId = lRegion.RegionId, Min = 7.9, Max = 22.3, Average = 15.1, ETC = 2.4, Rain = 1.1, };
            var lTD_South_20150325 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150325", Date = new DateTime(2015, 03, 25), RegionId = lRegion.RegionId, Min = 14.3, Max = 17.8, Average = 16.1, ETC = 1.4, Rain = 7.5, };
            var lTD_South_20150326 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150326", Date = new DateTime(2015, 03, 26), RegionId = lRegion.RegionId, Min = 13.2, Max = 21, Average = 17.1, ETC = 3.1, Rain = 0.4, };
            var lTD_South_20150327 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150327", Date = new DateTime(2015, 03, 27), RegionId = lRegion.RegionId, Min = 11.2, Max = 22.1, Average = 16.7, ETC = 2.7, Rain = 0, };
            var lTD_South_20150328 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150328", Date = new DateTime(2015, 03, 28), RegionId = lRegion.RegionId, Min = 7.6, Max = 25.1, Average = 16.4, ETC = 3, Rain = 0, };
            var lTD_South_20150329 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150329", Date = new DateTime(2015, 03, 29), RegionId = lRegion.RegionId, Min = 13.2, Max = 28.2, Average = 20.7, ETC = 3.6, Rain = 0, };
            var lTD_South_20150330 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150330", Date = new DateTime(2015, 03, 30), RegionId = lRegion.RegionId, Min = 15.3, Max = 27, Average = 21.2, ETC = 3.3, Rain = 0, };
            var lTD_South_20150331 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150331", Date = new DateTime(2015, 03, 31), RegionId = lRegion.RegionId, Min = 14.1, Max = 22.6, Average = 18.4, ETC = 2.7, Rain = 0, };
            var lTD_South_20150401 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150401", Date = new DateTime(2015, 04, 01), RegionId = lRegion.RegionId, Min = 9.6, Max = 26.6, Average = 18.1, ETC = 3.2, Rain = 0, };
            var lTD_South_20150402 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150402", Date = new DateTime(2015, 04, 02), RegionId = lRegion.RegionId, Min = 10.9, Max = 30.9, Average = 20.9, ETC = 4.4, Rain = 0, };
            var lTD_South_20150403 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150403", Date = new DateTime(2015, 04, 03), RegionId = lRegion.RegionId, Min = 12.1, Max = 31.6, Average = 21.9, ETC = 3.9, Rain = 0, };
            var lTD_South_20150404 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150404", Date = new DateTime(2015, 04, 04), RegionId = lRegion.RegionId, Min = 15.6, Max = 25.7, Average = 20.7, ETC = 2.2, Rain = 1, };
            var lTD_South_20150405 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150405", Date = new DateTime(2015, 04, 05), RegionId = lRegion.RegionId, Min = 14.3, Max = 24.1, Average = 19.2, ETC = 3.4, Rain = 0, };
            var lTD_South_20150406 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150406", Date = new DateTime(2015, 04, 06), RegionId = lRegion.RegionId, Min = 10.2, Max = 21.23, Average = 15.7, ETC = 2.5, Rain = 0, };
            var lTD_South_20150407 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150407", Date = new DateTime(2015, 04, 07), RegionId = lRegion.RegionId, Min = 8.7, Max = 22.99, Average = 15.8, ETC = 2.7, Rain = 0, };
            var lTD_South_20150408 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150408", Date = new DateTime(2015, 04, 08), RegionId = lRegion.RegionId, Min = 11.2, Max = 26, Average = 18.6, ETC = 3.1, Rain = 0, };
            var lTD_South_20150409 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150409", Date = new DateTime(2015, 04, 09), RegionId = lRegion.RegionId, Min = 13.2, Max = 28.9, Average = 21, ETC = 3.2, Rain = 0, };
            var lTD_South_20150410 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150410", Date = new DateTime(2015, 04, 10), RegionId = lRegion.RegionId, Min = 13.7, Max = 29.96, Average = 21.8, ETC = 3.4, Rain = 3.5, };
            var lTD_South_20150411 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150411", Date = new DateTime(2015, 04, 11), RegionId = lRegion.RegionId, Min = 13.6, Max = 23.6, Average = 18.6, ETC = 2.9, Rain = 0, };
            var lTD_South_20150412 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150412", Date = new DateTime(2015, 04, 12), RegionId = lRegion.RegionId, Min = 9.3, Max = 25.6, Average = 17.5, ETC = 3.1, Rain = 0, };
            var lTD_South_20150413 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150413", Date = new DateTime(2015, 04, 13), RegionId = lRegion.RegionId, Min = 12.9, Max = 30.2, Average = 21.6, ETC = 3.6, Rain = 0, };
            var lTD_South_20150414 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150414", Date = new DateTime(2015, 04, 14), RegionId = lRegion.RegionId, Min = 14.4, Max = 29.3, Average = 21.9, ETC = 2.8, Rain = 0, };
            var lTD_South_20150415 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150415", Date = new DateTime(2015, 04, 15), RegionId = lRegion.RegionId, Min = 16.4, Max = 25.1, Average = 20.8, ETC = 3.2, Rain = 0, };
            var lTD_South_20150416 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150416", Date = new DateTime(2015, 04, 16), RegionId = lRegion.RegionId, Min = 16, Max = 26.4, Average = 21.2, ETC = 4, Rain = 18.2, };
            var lTD_South_20150417 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150417", Date = new DateTime(2015, 04, 17), RegionId = lRegion.RegionId, Min = 14.4, Max = 21.5, Average = 18, ETC = 2.2, Rain = 0.3, };
            var lTD_South_20150418 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150418", Date = new DateTime(2015, 04, 18), RegionId = lRegion.RegionId, Min = 11.7, Max = 22.6, Average = 17.2, ETC = 3, Rain = 0, };
            var lTD_South_20150419 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150419", Date = new DateTime(2015, 04, 19), RegionId = lRegion.RegionId, Min = 10.1, Max = 25.9, Average = 18, ETC = 2.7, Rain = 0, };
            var lTD_South_20150420 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150420", Date = new DateTime(2015, 04, 20), RegionId = lRegion.RegionId, Min = 11.3, Max = 22.5, Average = 16.9, ETC = 2.3, Rain = 0, };
            var lTD_South_20150421 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150421", Date = new DateTime(2015, 04, 21), RegionId = lRegion.RegionId, Min = 7.5, Max = 23.7, Average = 15.6, ETC = 2, Rain = 0, };
            var lTD_South_20150422 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150422", Date = new DateTime(2015, 04, 22), RegionId = lRegion.RegionId, Min = 7.6, Max = 23.2, Average = 15.4, ETC = 2, Rain = 0, };
            var lTD_South_20150423 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150423", Date = new DateTime(2015, 04, 23), RegionId = lRegion.RegionId, Min = 8.5, Max = 25, Average = 16.8, ETC = 2.4, Rain = 0, };
            var lTD_South_20150424 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150424", Date = new DateTime(2015, 04, 24), RegionId = lRegion.RegionId, Min = 8.3, Max = 25.5, Average = 16.9, ETC = 2.4, Rain = 0, };
            var lTD_South_20150425 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150425", Date = new DateTime(2015, 04, 25), RegionId = lRegion.RegionId, Min = 11.3, Max = 27.8, Average = 19.6, ETC = 2.5, Rain = 0, };
            var lTD_South_20150426 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150426", Date = new DateTime(2015, 04, 26), RegionId = lRegion.RegionId, Min = 11, Max = 27.9, Average = 19.5, ETC = 2.5, Rain = 0, };
            var lTD_South_20150427 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150427", Date = new DateTime(2015, 04, 27), RegionId = lRegion.RegionId, Min = 12, Max = 28, Average = 20, ETC = 2.8, Rain = 0, };
            var lTD_South_20150428 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150428", Date = new DateTime(2015, 04, 28), RegionId = lRegion.RegionId, Min = 14, Max = 22.5, Average = 18.3, ETC = 2.8, Rain = 0, };
            var lTD_South_20150429 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150429", Date = new DateTime(2015, 04, 29), RegionId = lRegion.RegionId, Min = 12.6, Max = 20.1, Average = 16.4, ETC = 2.2, Rain = 5.6, };
            var lTD_South_20150430 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150430", Date = new DateTime(2015, 04, 30), RegionId = lRegion.RegionId, Min = 13.6, Max = 20, Average = 16.8, ETC = 1.6, Rain = 0.5, };
            var lTD_South_20150501 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150501", Date = new DateTime(2015, 05, 01), RegionId = lRegion.RegionId, Min = 12.5, Max = 23.7, Average = 18.1, ETC = 2.5, Rain = 1.2, };
            var lTD_South_20150502 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150502", Date = new DateTime(2015, 05, 02), RegionId = lRegion.RegionId, Min = 13.5, Max = 19.6, Average = 16.6, ETC = 1.6, Rain = 13.5, };
            var lTD_South_20150503 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150503", Date = new DateTime(2015, 05, 03), RegionId = lRegion.RegionId, Min = 7.6, Max = 15, Average = 11.3, ETC = 2.6, Rain = 0, };
            var lTD_South_20150504 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150504", Date = new DateTime(2015, 05, 04), RegionId = lRegion.RegionId, Min = 3.1, Max = 17.9, Average = 10.5, ETC = 1.9, Rain = 0, };
            var lTD_South_20150505 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150505", Date = new DateTime(2015, 05, 05), RegionId = lRegion.RegionId, Min = 6.9, Max = 21, Average = 14, ETC = 1.7, Rain = 0, };
            var lTD_South_20150506 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150506", Date = new DateTime(2015, 05, 06), RegionId = lRegion.RegionId, Min = 8.5, Max = 15.9, Average = 12.2, ETC = 1.7, Rain = 0, };
            var lTD_South_20150507 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150507", Date = new DateTime(2015, 05, 07), RegionId = lRegion.RegionId, Min = 4.7, Max = 17.4, Average = 11, ETC = 1.5, Rain = 0, };
            var lTD_South_20150508 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150508", Date = new DateTime(2015, 05, 08), RegionId = lRegion.RegionId, Min = 5.6, Max = 20.8, Average = 13.2, ETC = 1.5, Rain = 0, };
            var lTD_South_20150509 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150509", Date = new DateTime(2015, 05, 09), RegionId = lRegion.RegionId, Min = 5.4, Max = 20.9, Average = 13.2, ETC = 1.3, Rain = 0, };
            var lTD_South_20150510 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150510", Date = new DateTime(2015, 05, 10), RegionId = lRegion.RegionId, Min = 9.9, Max = 18.6, Average = 14.3, ETC = 0.9, Rain = 0.2, };
            var lTD_South_20150511 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150511", Date = new DateTime(2015, 05, 11), RegionId = lRegion.RegionId, Min = 10.29, Max = 21, Average = 15.6, ETC = 1.4, Rain = 0, };
            var lTD_South_20150512 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150512", Date = new DateTime(2015, 05, 12), RegionId = lRegion.RegionId, Min = 10.9, Max = 21.9, Average = 16.4, ETC = 1.8, Rain = 0, };
            var lTD_South_20150513 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150513", Date = new DateTime(2015, 05, 13), RegionId = lRegion.RegionId, Min = 11, Max = 21.4, Average = 16.2, ETC = 1.7, Rain = 0, };
            var lTD_South_20150514 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150514", Date = new DateTime(2015, 05, 14), RegionId = lRegion.RegionId, Min = 11.3, Max = 24.7, Average = 18, ETC = 1.4, Rain = 0, };
            var lTD_South_20150515 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150515", Date = new DateTime(2015, 05, 15), RegionId = lRegion.RegionId, Min = 13.2, Max = 25.9, Average = 19.5, ETC = 1.8, Rain = 0, };
            var lTD_South_20150516 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150516", Date = new DateTime(2015, 05, 16), RegionId = lRegion.RegionId, Min = 13.4, Max = 27.3, Average = 20.4, ETC = 1.9, Rain = 0, };
            var lTD_South_20150517 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150517", Date = new DateTime(2015, 05, 17), RegionId = lRegion.RegionId, Min = 14.8, Max = 26.9, Average = 20.9, ETC = 1.9, Rain = 0, };
            var lTD_South_20150518 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150518", Date = new DateTime(2015, 05, 18), RegionId = lRegion.RegionId, Min = 14.8, Max = 27.8, Average = 21.3, ETC = 1.9, Rain = 0, };
            var lTD_South_20150519 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150519", Date = new DateTime(2015, 05, 19), RegionId = lRegion.RegionId, Min = 14.2, Max = 24.7, Average = 19.5, ETC = 1.5, Rain = 0, };
            var lTD_South_20150520 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150520", Date = new DateTime(2015, 05, 20), RegionId = lRegion.RegionId, Min = 14.3, Max = 26.4, Average = 20.4, ETC = 1.8, Rain = 0, };
            var lTD_South_20150521 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150521", Date = new DateTime(2015, 05, 21), RegionId = lRegion.RegionId, Min = 15.6, Max = 27.9, Average = 21.8, ETC = 2, Rain = 0, };
            var lTD_South_20150522 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150522", Date = new DateTime(2015, 05, 22), RegionId = lRegion.RegionId, Min = 17.3, Max = 28.5, Average = 22.9, ETC = 1.8, Rain = 0, };
            var lTD_South_20150523 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150523", Date = new DateTime(2015, 05, 23), RegionId = lRegion.RegionId, Min = 13.8, Max = 20.7, Average = 17.3, ETC = 1.2, Rain = 5, };
            var lTD_South_20150524 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150524", Date = new DateTime(2015, 05, 24), RegionId = lRegion.RegionId, Min = 6, Max = 16.8, Average = 11.4, ETC = 1.4, Rain = 0, };
            var lTD_South_20150525 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150525", Date = new DateTime(2015, 05, 25), RegionId = lRegion.RegionId, Min = 3.8, Max = 17.8, Average = 10.8, ETC = 1, Rain = 0, };
            var lTD_South_20150526 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150526", Date = new DateTime(2015, 05, 26), RegionId = lRegion.RegionId, Min = 6.3, Max = 16.7, Average = 11.5, ETC = 1, Rain = 0.8, };
            var lTD_South_20150527 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150527", Date = new DateTime(2015, 05, 27), RegionId = lRegion.RegionId, Min = 11, Max = 18.5, Average = 14.8, ETC = 1.2, Rain = 0, };
            var lTD_South_20150528 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150528", Date = new DateTime(2015, 05, 28), RegionId = lRegion.RegionId, Min = 5.93, Max = 18.9, Average = 12.4, ETC = 0.7, Rain = 0, };
            var lTD_South_20150529 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150529", Date = new DateTime(2015, 05, 29), RegionId = lRegion.RegionId, Min = 3, Max = 19.2, Average = 11.1, ETC = 0.6, Rain = 0, };
            var lTD_South_20150530 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150530", Date = new DateTime(2015, 05, 30), RegionId = lRegion.RegionId, Min = 5.2, Max = 17.11, Average = 11.2, ETC = 0.8, Rain = 0, };
            var lTD_South_20150531 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150531", Date = new DateTime(2015, 05, 31), RegionId = lRegion.RegionId, Min = 6.1, Max = 18.9, Average = 12.5, ETC = 0.7, Rain = 0, };
            var lTD_South_20150601 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150601", Date = new DateTime(2015, 06, 01), RegionId = lRegion.RegionId, Min = 8.6, Max = 21.7, Average = 15.2, ETC = 1, Rain = 0, };
            var lTD_South_20150602 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150602", Date = new DateTime(2015, 06, 02), RegionId = lRegion.RegionId, Min = 7.3, Max = 22, Average = 14.7, ETC = 1.4, Rain = 0, };
            var lTD_South_20150603 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150603", Date = new DateTime(2015, 06, 03), RegionId = lRegion.RegionId, Min = 10.4, Max = 21.6, Average = 16, ETC = 1.3, Rain = 0, };
            var lTD_South_20150604 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150604", Date = new DateTime(2015, 06, 04), RegionId = lRegion.RegionId, Min = 4.7, Max = 21.4, Average = 13.1, ETC = 1.3, Rain = 0, };
            var lTD_South_20150605 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150605", Date = new DateTime(2015, 06, 05), RegionId = lRegion.RegionId, Min = 12.8, Max = 26.1, Average = 19.5, ETC = 1.5, Rain = 7.2, };
            var lTD_South_20150606 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150606", Date = new DateTime(2015, 06, 06), RegionId = lRegion.RegionId, Min = 13.4, Max = 24.7, Average = 19.1, ETC = 1.1, Rain = 0, };
            var lTD_South_20150607 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150607", Date = new DateTime(2015, 06, 07), RegionId = lRegion.RegionId, Min = 8.3, Max = 19.1, Average = 13.7, ETC = 1, Rain = 0, };
            var lTD_South_20150608 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150608", Date = new DateTime(2015, 06, 08), RegionId = lRegion.RegionId, Min = 3.6, Max = 18.8, Average = 11.2, ETC = 1, Rain = 0, };
            var lTD_South_20150609 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150609", Date = new DateTime(2015, 06, 09), RegionId = lRegion.RegionId, Min = 9.1, Max = 14.9, Average = 12, ETC = 0.9, Rain = 0.5, };
            var lTD_South_20150610 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150610", Date = new DateTime(2015, 06, 10), RegionId = lRegion.RegionId, Min = 5.2, Max = 15.6, Average = 10.4, ETC = 1.2, Rain = 0, };
            var lTD_South_20150611 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150611", Date = new DateTime(2015, 06, 11), RegionId = lRegion.RegionId, Min = 4.2, Max = 13.7, Average = 9, ETC = 1.7, Rain = 0, };
            var lTD_South_20150612 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150612", Date = new DateTime(2015, 06, 12), RegionId = lRegion.RegionId, Min = -0.3, Max = 16.9, Average = 8.3, ETC = 1.2, Rain = 0, };
            var lTD_South_20150613 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150613", Date = new DateTime(2015, 06, 13), RegionId = lRegion.RegionId, Min = 1.3, Max = 16.7, Average = 9, ETC = 1.1, Rain = 0.7, };
            var lTD_South_20150614 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150614", Date = new DateTime(2015, 06, 14), RegionId = lRegion.RegionId, Min = 4.8, Max = 15.3, Average = 10.1, ETC = 1.7, Rain = 0, };
            var lTD_South_20150615 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150615", Date = new DateTime(2015, 06, 15), RegionId = lRegion.RegionId, Min = 2.3, Max = 15.1, Average = 8.7, ETC = 1.9, Rain = 0, };
            var lTD_South_20150616 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150616", Date = new DateTime(2015, 06, 16), RegionId = lRegion.RegionId, Min = 4.5, Max = 21, Average = 12.8, ETC = 2.2, Rain = 0, };
            var lTD_South_20150617 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150617", Date = new DateTime(2015, 06, 17), RegionId = lRegion.RegionId, Min = 4.1, Max = 15.3, Average = 9.7, ETC = 1.5, Rain = 0, };
            var lTD_South_20150618 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150618", Date = new DateTime(2015, 06, 18), RegionId = lRegion.RegionId, Min = 1.2, Max = 10.8, Average = 6, ETC = 1.1, Rain = 0, };
            var lTD_South_20150619 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150619", Date = new DateTime(2015, 06, 19), RegionId = lRegion.RegionId, Min = -2.8, Max = 12.3, Average = 4.8, ETC = 1, Rain = 0, };
            var lTD_South_20150620 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150620", Date = new DateTime(2015, 06, 20), RegionId = lRegion.RegionId, Min = -1.5, Max = 14.4, Average = 6.5, ETC = 1, Rain = 0, };
            var lTD_South_20150621 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150621", Date = new DateTime(2015, 06, 21), RegionId = lRegion.RegionId, Min = 1.5, Max = 17.7, Average = 9.6, ETC = 0.5, Rain = 0, };
            var lTD_South_20150622 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150622", Date = new DateTime(2015, 06, 22), RegionId = lRegion.RegionId, Min = 2.8, Max = 12, Average = 7.4, ETC = 1.3, Rain = 0, };
            var lTD_South_20150623 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150623", Date = new DateTime(2015, 06, 23), RegionId = lRegion.RegionId, Min = 0.7, Max = 12.1, Average = 6.4, ETC = 0.7, Rain = 0, };
            var lTD_South_20150624 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150624", Date = new DateTime(2015, 06, 24), RegionId = lRegion.RegionId, Min = 0.1, Max = 16.8, Average = 8.5, ETC = 0.9, Rain = 0, };
            var lTD_South_20150625 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150625", Date = new DateTime(2015, 06, 25), RegionId = lRegion.RegionId, Min = 7.8, Max = 21.7, Average = 14.8, ETC = 1.9, Rain = 0, };
            var lTD_South_20150626 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150626", Date = new DateTime(2015, 06, 26), RegionId = lRegion.RegionId, Min = 11.2, Max = 23.1, Average = 17.2, ETC = 1.1, Rain = 0, };
            var lTD_South_20150627 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150627", Date = new DateTime(2015, 06, 27), RegionId = lRegion.RegionId, Min = 11.4, Max = 24.1, Average = 17.8, ETC = 1, Rain = 0.2, };
            var lTD_South_20150628 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150628", Date = new DateTime(2015, 06, 28), RegionId = lRegion.RegionId, Min = 15.4, Max = 18.4, Average = 16.9, ETC = 1, Rain = 6.5, };
            var lTD_South_20150629 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150629", Date = new DateTime(2015, 06, 29), RegionId = lRegion.RegionId, Min = 13.7, Max = 17, Average = 15.4, ETC = 0.7, Rain = 2.9, };
            var lTD_South_20150630 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150630", Date = new DateTime(2015, 06, 30), RegionId = lRegion.RegionId, Min = 8.3, Max = 15, Average = 11.7, ETC = 0.5, Rain = 0.2, };
            var lTD_South_20150701 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150701", Date = new DateTime(2015, 07, 01), RegionId = lRegion.RegionId, Min = 4.55, Max = 14.5, Average = 9.5, ETC = 0.7, Rain = 0, };
            var lTD_South_20150702 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150702", Date = new DateTime(2015, 07, 02), RegionId = lRegion.RegionId, Min = 5.7, Max = 16.3, Average = 11, ETC = 1.2, Rain = 0, };
            var lTD_South_20150703 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150703", Date = new DateTime(2015, 07, 03), RegionId = lRegion.RegionId, Min = 4.1, Max = 12.16, Average = 8.1, ETC = 1.2, Rain = 6.9, };
            var lTD_South_20150704 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150704", Date = new DateTime(2015, 07, 04), RegionId = lRegion.RegionId, Min = 2.3, Max = 11.9, Average = 7.1, ETC = 0.7, Rain = 0, };
            var lTD_South_20150705 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150705", Date = new DateTime(2015, 07, 05), RegionId = lRegion.RegionId, Min = -1, Max = 14.3, Average = 6.7, ETC = 0.7, Rain = 0, };
            var lTD_South_20150706 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150706", Date = new DateTime(2015, 07, 06), RegionId = lRegion.RegionId, Min = 2.3, Max = 15.5, Average = 8.9, ETC = 0.6, Rain = 0, };
            var lTD_South_20150707 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150707", Date = new DateTime(2015, 07, 07), RegionId = lRegion.RegionId, Min = 0.2, Max = 17.5, Average = 8.9, ETC = 0.5, Rain = 0, };
            var lTD_South_20150708 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150708", Date = new DateTime(2015, 07, 08), RegionId = lRegion.RegionId, Min = 0.8, Max = 19.4, Average = 10.1, ETC = 0.8, Rain = 0, };
            var lTD_South_20150709 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150709", Date = new DateTime(2015, 07, 09), RegionId = lRegion.RegionId, Min = 3.2, Max = 17.01, Average = 10.1, ETC = 0.5, Rain = 0, };
            var lTD_South_20150710 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150710", Date = new DateTime(2015, 07, 10), RegionId = lRegion.RegionId, Min = 7.1, Max = 16.9, Average = 12, ETC = 0.7, Rain = 0.3, };
            var lTD_South_20150711 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150711", Date = new DateTime(2015, 07, 11), RegionId = lRegion.RegionId, Min = 9.7, Max = 15, Average = 12.4, ETC = 0.9, Rain = 0, };
            var lTD_South_20150712 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150712", Date = new DateTime(2015, 07, 12), RegionId = lRegion.RegionId, Min = 9.4, Max = 20.4, Average = 14.9, ETC = 1.2, Rain = 1.9, };
            var lTD_South_20150713 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150713", Date = new DateTime(2015, 07, 13), RegionId = lRegion.RegionId, Min = 6.9, Max = 17.1, Average = 12, ETC = 0.8, Rain = 0, };
            var lTD_South_20150714 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150714", Date = new DateTime(2015, 07, 14), RegionId = lRegion.RegionId, Min = 4.7, Max = 12.8, Average = 8.8, ETC = 0.9, Rain = 0, };
            var lTD_South_20150715 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150715", Date = new DateTime(2015, 07, 15), RegionId = lRegion.RegionId, Min = -0.2, Max = 13.9, Average = 6.9, ETC = 0.8, Rain = 0, };
            var lTD_South_20150716 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150716", Date = new DateTime(2015, 07, 16), RegionId = lRegion.RegionId, Min = 0.2, Max = 14.9, Average = 7.6, ETC = 1.2, Rain = 0, };
            var lTD_South_20150717 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150717", Date = new DateTime(2015, 07, 17), RegionId = lRegion.RegionId, Min = 0.3, Max = 19.4, Average = 9.9, ETC = 1.1, Rain = 0, };
            var lTD_South_20150718 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150718", Date = new DateTime(2015, 07, 18), RegionId = lRegion.RegionId, Min = 7.9, Max = 19.1, Average = 13.5, ETC = 1, Rain = 0, };
            var lTD_South_20150719 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150719", Date = new DateTime(2015, 07, 19), RegionId = lRegion.RegionId, Min = 7.4, Max = 16.7, Average = 12.1, ETC = 1.1, Rain = 0, };
            var lTD_South_20150720 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150720", Date = new DateTime(2015, 07, 20), RegionId = lRegion.RegionId, Min = 4.7, Max = 12.3, Average = 8.5, ETC = 1.1, Rain = 0, };
            var lTD_South_20150721 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150721", Date = new DateTime(2015, 07, 21), RegionId = lRegion.RegionId, Min = -0.5, Max = 12.7, Average = 6.1, ETC = 0.7, Rain = 0, };
            var lTD_South_20150722 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150722", Date = new DateTime(2015, 07, 22), RegionId = lRegion.RegionId, Min = -0.7, Max = 16.1, Average = 7.7, ETC = 0.9, Rain = 0, };
            var lTD_South_20150723 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150723", Date = new DateTime(2015, 07, 23), RegionId = lRegion.RegionId, Min = 2.3, Max = 17.7, Average = 10, ETC = 1, Rain = 0, };
            var lTD_South_20150724 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150724", Date = new DateTime(2015, 07, 24), RegionId = lRegion.RegionId, Min = 1.6, Max = 19.2, Average = 10.4, ETC = 0.9, Rain = 0, };
            var lTD_South_20150725 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150725", Date = new DateTime(2015, 07, 25), RegionId = lRegion.RegionId, Min = 9.6, Max = 22.1, Average = 15.9, ETC = 1.7, Rain = 0, };
            var lTD_South_20150726 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150726", Date = new DateTime(2015, 07, 26), RegionId = lRegion.RegionId, Min = 8, Max = 20.8, Average = 14.4, ETC = 1.8, Rain = 0, };
            var lTD_South_20150727 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150727", Date = new DateTime(2015, 07, 27), RegionId = lRegion.RegionId, Min = 8.9, Max = 20.3, Average = 14.6, ETC = 1.5, Rain = 0, };
            var lTD_South_20150728 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150728", Date = new DateTime(2015, 07, 28), RegionId = lRegion.RegionId, Min = 10.7, Max = 26.9, Average = 18.8, ETC = 1.8, Rain = 0, };
            var lTD_South_20150729 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150729", Date = new DateTime(2015, 07, 29), RegionId = lRegion.RegionId, Min = 12.5, Max = 18.5, Average = 15.5, ETC = 1.3, Rain = 0, };
            var lTD_South_20150730 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150730", Date = new DateTime(2015, 07, 30), RegionId = lRegion.RegionId, Min = 12, Max = 20.5, Average = 16.3, ETC = 1.5, Rain = 12.7, };
            var lTD_South_20150731 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150731", Date = new DateTime(2015, 07, 31), RegionId = lRegion.RegionId, Min = 12, Max = 20, Average = 16, ETC = 1.6, Rain = 9.5, };
            var lTD_South_20150801 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150801", Date = new DateTime(2015, 08, 01), RegionId = lRegion.RegionId, Min = 5.37, Max = 17.7, Average = 11.5, ETC = 1.5, Rain = 41, };
            var lTD_South_20150802 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150802", Date = new DateTime(2015, 08, 02), RegionId = lRegion.RegionId, Min = 12, Max = 18.7, Average = 15.4, ETC = 1.1, Rain = 0.1, };
            var lTD_South_20150803 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150803", Date = new DateTime(2015, 08, 03), RegionId = lRegion.RegionId, Min = 8.3, Max = 19.6, Average = 14, ETC = 1.1, Rain = 0, };
            var lTD_South_20150804 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150804", Date = new DateTime(2015, 08, 04), RegionId = lRegion.RegionId, Min = 6.1, Max = 16.6, Average = 11.4, ETC = 1.7, Rain = 0, };
            var lTD_South_20150805 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150805", Date = new DateTime(2015, 08, 05), RegionId = lRegion.RegionId, Min = 8.2, Max = 19.48, Average = 13.8, ETC = 2.2, Rain = 37.3, };
            var lTD_South_20150806 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150806", Date = new DateTime(2015, 08, 06), RegionId = lRegion.RegionId, Min = 15.7, Max = 20.5, Average = 18.1, ETC = 1.3, Rain = 16.3, };
            var lTD_South_20150807 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150807", Date = new DateTime(2015, 08, 07), RegionId = lRegion.RegionId, Min = 13.5, Max = 20.31, Average = 16.9, ETC = 1.1, Rain = 13, };
            var lTD_South_20150808 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150808", Date = new DateTime(2015, 08, 08), RegionId = lRegion.RegionId, Min = 13.6, Max = 25.4, Average = 19.5, ETC = 1.8, Rain = 0, };
            var lTD_South_20150809 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150809", Date = new DateTime(2015, 08, 09), RegionId = lRegion.RegionId, Min = 16.7, Max = 31.2, Average = 24, ETC = 3, Rain = 0, };
            var lTD_South_20150810 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150810", Date = new DateTime(2015, 08, 10), RegionId = lRegion.RegionId, Min = 7, Max = 16.9, Average = 12, ETC = 1, Rain = 0.5, };
            var lTD_South_20150811 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150811", Date = new DateTime(2015, 08, 11), RegionId = lRegion.RegionId, Min = 8.02, Max = 14.7, Average = 11.4, ETC = 1.2, Rain = 4.8, };
            var lTD_South_20150812 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150812", Date = new DateTime(2015, 08, 12), RegionId = lRegion.RegionId, Min = 11.6, Max = 13.9, Average = 12.8, ETC = 1.2, Rain = 39.2, };
            var lTD_South_20150813 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150813", Date = new DateTime(2015, 08, 13), RegionId = lRegion.RegionId, Min = 13.2, Max = 15.4, Average = 14.3, ETC = 1, Rain = 2.1, };
            var lTD_South_20150814 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150814", Date = new DateTime(2015, 08, 14), RegionId = lRegion.RegionId, Min = 11.3, Max = 13.4, Average = 12.4, ETC = 0.8, Rain = 10.6, };
            var lTD_South_20150815 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150815", Date = new DateTime(2015, 08, 15), RegionId = lRegion.RegionId, Min = 7.2, Max = 14.4, Average = 10.8, ETC = 1.2, Rain = 0.7, };
            var lTD_South_20150816 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150816", Date = new DateTime(2015, 08, 16), RegionId = lRegion.RegionId, Min = 5.3, Max = 17.6, Average = 11.5, ETC = 1.4, Rain = 0, };
            var lTD_South_20150817 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150817", Date = new DateTime(2015, 08, 17), RegionId = lRegion.RegionId, Min = 11, Max = 18.6, Average = 14.8, ETC = 1.2, Rain = 0.3, };
            var lTD_South_20150818 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150818", Date = new DateTime(2015, 08, 18), RegionId = lRegion.RegionId, Min = 10.4, Max = 18.3, Average = 14.4, ETC = 1.7, Rain = 0, };
            var lTD_South_20150819 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150819", Date = new DateTime(2015, 08, 19), RegionId = lRegion.RegionId, Min = 9.7, Max = 13.7, Average = 11.7, ETC = 1, Rain = 0.5, };
            var lTD_South_20150820 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150820", Date = new DateTime(2015, 08, 20), RegionId = lRegion.RegionId, Min = 9.1, Max = 17.28, Average = 13.2, ETC = 1.7, Rain = 0, };
            var lTD_South_20150821 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150821", Date = new DateTime(2015, 08, 21), RegionId = lRegion.RegionId, Min = 9.8, Max = 21.1, Average = 15.5, ETC = 2.1, Rain = 0, };
            var lTD_South_20150822 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150822", Date = new DateTime(2015, 08, 22), RegionId = lRegion.RegionId, Min = 12, Max = 21.3, Average = 16.7, ETC = 2.1, Rain = 0, };
            var lTD_South_20150823 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150823", Date = new DateTime(2015, 08, 23), RegionId = lRegion.RegionId, Min = 8, Max = 13.9, Average = 11, ETC = 2.4, Rain = 0, };
            var lTD_South_20150824 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150824", Date = new DateTime(2015, 08, 24), RegionId = lRegion.RegionId, Min = 6.5, Max = 15.7, Average = 11.1, ETC = 1.8, Rain = 0, };
            var lTD_South_20150825 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150825", Date = new DateTime(2015, 08, 25), RegionId = lRegion.RegionId, Min = 4.5, Max = 20.7, Average = 12.6, ETC = 2.4, Rain = 7.6, };
            var lTD_South_20150826 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150826", Date = new DateTime(2015, 08, 26), RegionId = lRegion.RegionId, Min = 10.7, Max = 15.7, Average = 13.2, ETC = 1.2, Rain = 22.3, };
            var lTD_South_20150827 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150827", Date = new DateTime(2015, 08, 27), RegionId = lRegion.RegionId, Min = 10, Max = 17, Average = 13.5, ETC = 2.3, Rain = 0, };
            var lTD_South_20150828 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150828", Date = new DateTime(2015, 08, 28), RegionId = lRegion.RegionId, Min = 6.7, Max = 22.6, Average = 14.7, ETC = 3, Rain = 0, };
            var lTD_South_20150829 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150829", Date = new DateTime(2015, 08, 29), RegionId = lRegion.RegionId, Min = 13.1, Max = 24.9, Average = 19, ETC = 2.7, Rain = 0, };
            var lTD_South_20150830 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150830", Date = new DateTime(2015, 08, 30), RegionId = lRegion.RegionId, Min = 13.6, Max = 25.7, Average = 19.7, ETC = 3.4, Rain = 0, };
            var lTD_South_20150831 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150831", Date = new DateTime(2015, 08, 31), RegionId = lRegion.RegionId, Min = 8.8, Max = 22.8, Average = 15.8, ETC = 3.1, Rain = 0, };
            var lTD_South_20150901 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150901", Date = new DateTime(2015, 09, 01), RegionId = lRegion.RegionId, Min = 6.2, Max = 12.9, Average = 9.6, ETC = 2.4, Rain = 0, };
            var lTD_South_20150902 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150902", Date = new DateTime(2015, 09, 02), RegionId = lRegion.RegionId, Min = 5.8, Max = 16.4, Average = 11.1, ETC = 1.7, Rain = 0, };
            var lTD_South_20150903 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150903", Date = new DateTime(2015, 09, 03), RegionId = lRegion.RegionId, Min = 5.8, Max = 15.9, Average = 10.9, ETC = 1.7, Rain = 0.1, };
            var lTD_South_20150904 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150904", Date = new DateTime(2015, 09, 04), RegionId = lRegion.RegionId, Min = 1, Max = 17.7, Average = 9.4, ETC = 1.9, Rain = 0, };
            var lTD_South_20150905 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150905", Date = new DateTime(2015, 09, 05), RegionId = lRegion.RegionId, Min = 5.3, Max = 19, Average = 12.2, ETC = 2.3, Rain = 0, };
            var lTD_South_20150906 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150906", Date = new DateTime(2015, 09, 06), RegionId = lRegion.RegionId, Min = 4.6, Max = 20, Average = 12.3, ETC = 2.4, Rain = 0, };
            var lTD_South_20150907 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150907", Date = new DateTime(2015, 09, 07), RegionId = lRegion.RegionId, Min = 9.1, Max = 20.6, Average = 14.9, ETC = 1.8, Rain = 0, };
            var lTD_South_20150908 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150908", Date = new DateTime(2015, 09, 08), RegionId = lRegion.RegionId, Min = 12.3, Max = 19.7, Average = 16, ETC = 2.4, Rain = 0, };
            var lTD_South_20150909 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150909", Date = new DateTime(2015, 09, 09), RegionId = lRegion.RegionId, Min = 6.6, Max = 15.5, Average = 11.1, ETC = 1.8, Rain = 10.5, };
            var lTD_South_20150910 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150910", Date = new DateTime(2015, 09, 10), RegionId = lRegion.RegionId, Min = 6.36, Max = 13.2, Average = 9.8, ETC = 2.8, Rain = 0, };
            var lTD_South_20150911 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150911", Date = new DateTime(2015, 09, 11), RegionId = lRegion.RegionId, Min = 1.8, Max = 9.8, Average = 5.8, ETC = 2.7, Rain = 0, };
            var lTD_South_20150912 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150912", Date = new DateTime(2015, 09, 12), RegionId = lRegion.RegionId, Min = 1.3, Max = 14.3, Average = 7.8, ETC = 2.7, Rain = 0, };
            var lTD_South_20150913 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150913", Date = new DateTime(2015, 09, 13), RegionId = lRegion.RegionId, Min = 3.9, Max = 20.5, Average = 12.2, ETC = 3.2, Rain = 0, };
            var lTD_South_20150914 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150914", Date = new DateTime(2015, 09, 14), RegionId = lRegion.RegionId, Min = 5.7, Max = 25.6, Average = 15.7, ETC = 3.9, Rain = 0, };
            var lTD_South_20150915 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150915", Date = new DateTime(2015, 09, 15), RegionId = lRegion.RegionId, Min = 13.9, Max = 25.4, Average = 19.7, ETC = 4.6, Rain = 0, };
            var lTD_South_20150916 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150916", Date = new DateTime(2015, 09, 16), RegionId = lRegion.RegionId, Min = 6, Max = 15.5, Average = 10.8, ETC = 2.8, Rain = 0, };
            var lTD_South_20150917 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150917", Date = new DateTime(2015, 09, 17), RegionId = lRegion.RegionId, Min = 3.9, Max = 18.5, Average = 11.2, ETC = 2.6, Rain = 0, };
            var lTD_South_20150918 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150918", Date = new DateTime(2015, 09, 18), RegionId = lRegion.RegionId, Min = 1.9, Max = 18.5, Average = 10.2, ETC = 2.6, Rain = 0, };
            var lTD_South_20150919 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150919", Date = new DateTime(2015, 09, 19), RegionId = lRegion.RegionId, Min = 6.9, Max = 21.6, Average = 14.3, ETC = 2.9, Rain = 0, };
            var lTD_South_20150920 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150920", Date = new DateTime(2015, 09, 20), RegionId = lRegion.RegionId, Min = 6.8, Max = 21.2, Average = 14, ETC = 3.5, Rain = 0, };
            var lTD_South_20150921 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150921", Date = new DateTime(2015, 09, 21), RegionId = lRegion.RegionId, Min = 12.8, Max = 17.2, Average = 15, ETC = 2.7, Rain = 4.7, };
            var lTD_South_20150922 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150922", Date = new DateTime(2015, 09, 22), RegionId = lRegion.RegionId, Min = 11.4, Max = 13.4, Average = 12.4, ETC = 1.9, Rain = 0, };
            var lTD_South_20150923 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150923", Date = new DateTime(2015, 09, 23), RegionId = lRegion.RegionId, Min = 13, Max = 15.9, Average = 14.5, ETC = 1.8, Rain = 2.5, };
            var lTD_South_20150924 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150924", Date = new DateTime(2015, 09, 24), RegionId = lRegion.RegionId, Min = 13, Max = 15.8, Average = 14.4, ETC = 1.7, Rain = 0.9, };
            var lTD_South_20150925 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150925", Date = new DateTime(2015, 09, 25), RegionId = lRegion.RegionId, Min = 9.2, Max = 15.7, Average = 12.5, ETC = 1.6, Rain = 0.3, };
            var lTD_South_20150926 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150926", Date = new DateTime(2015, 09, 26), RegionId = lRegion.RegionId, Min = 6.5, Max = 17.8, Average = 12.2, ETC = 1.8, Rain = 0, };
            var lTD_South_20150927 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150927", Date = new DateTime(2015, 09, 27), RegionId = lRegion.RegionId, Min = 7.05, Max = 20.4, Average = 13.7, ETC = 3.2, Rain = 0, };
            var lTD_South_20150928 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150928", Date = new DateTime(2015, 09, 28), RegionId = lRegion.RegionId, Min = 8.2, Max = 21.1, Average = 14.7, ETC = 2.5, Rain = 0, };
            var lTD_South_20150929 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150929", Date = new DateTime(2015, 09, 29), RegionId = lRegion.RegionId, Min = 7.2, Max = 17.5, Average = 12.4, ETC = 3.7, Rain = 0, };
            var lTD_South_20150930 = new TemperatureData { Name = Utils.NameRegionSouth + "-20150930", Date = new DateTime(2015, 09, 30), RegionId = lRegion.RegionId, Min = 6.2, Max = 15.5, Average = 10.9, ETC = 3.4, Rain = 0, };
            var lTD_South_20151001 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151001", Date = new DateTime(2015, 10, 01), RegionId = lRegion.RegionId, Min = 5.4, Max = 22.8, Average = 14.1, ETC = 3.4, Rain = 30.4, };
            var lTD_South_20151002 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151002", Date = new DateTime(2015, 10, 02), RegionId = lRegion.RegionId, Min = 8.5, Max = 15.4, Average = 12, ETC = 2.2, Rain = 2, };
            var lTD_South_20151003 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151003", Date = new DateTime(2015, 10, 03), RegionId = lRegion.RegionId, Min = 6.3, Max = 12.8, Average = 9.6, ETC = 3.2, Rain = 0.4, };
            var lTD_South_20151004 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151004", Date = new DateTime(2015, 10, 04), RegionId = lRegion.RegionId, Min = 8.3, Max = 16, Average = 12.2, ETC = 3.2, Rain = 0, };
            var lTD_South_20151005 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151005", Date = new DateTime(2015, 10, 05), RegionId = lRegion.RegionId, Min = 7.9, Max = 21.1, Average = 14.5, ETC = 3.6, Rain = 0, };
            var lTD_South_20151006 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151006", Date = new DateTime(2015, 10, 06), RegionId = lRegion.RegionId, Min = 13.6, Max = 20.6, Average = 17.1, ETC = 3.2, Rain = 0, };
            var lTD_South_20151007 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151007", Date = new DateTime(2015, 10, 07), RegionId = lRegion.RegionId, Min = 13.2, Max = 16.8, Average = 15, ETC = 2.6, Rain = 0, };
            var lTD_South_20151008 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151008", Date = new DateTime(2015, 10, 08), RegionId = lRegion.RegionId, Min = 11.5, Max = 19, Average = 15.3, ETC = 4.3, Rain = 0, };
            var lTD_South_20151009 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151009", Date = new DateTime(2015, 10, 09), RegionId = lRegion.RegionId, Min = 10.5, Max = 15.9, Average = 13.2, ETC = 3.4, Rain = 0, };
            var lTD_South_20151010 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151010", Date = new DateTime(2015, 10, 10), RegionId = lRegion.RegionId, Min = 10.3, Max = 15.6, Average = 13, ETC = 3.1, Rain = 0, };
            var lTD_South_20151011 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151011", Date = new DateTime(2015, 10, 11), RegionId = lRegion.RegionId, Min = 9.8, Max = 15.9, Average = 12.9, ETC = 2.1, Rain = 0.9, };
            var lTD_South_20151012 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151012", Date = new DateTime(2015, 10, 12), RegionId = lRegion.RegionId, Min = 7.4, Max = 16.5, Average = 12, ETC = 2.7, Rain = 0, };
            var lTD_South_20151013 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151013", Date = new DateTime(2015, 10, 13), RegionId = lRegion.RegionId, Min = 4.3, Max = 21.2, Average = 12.8, ETC = 3.7, Rain = 0, };
            var lTD_South_20151014 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151014", Date = new DateTime(2015, 10, 14), RegionId = lRegion.RegionId, Min = 11.4, Max = 23.6, Average = 17.5, ETC = 3.5, Rain = 7, };
            var lTD_South_20151015 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151015", Date = new DateTime(2015, 10, 15), RegionId = lRegion.RegionId, Min = 12.1, Max = 18.6, Average = 15.4, ETC = 4.2, Rain = 0, };
            var lTD_South_20151016 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151016", Date = new DateTime(2015, 10, 16), RegionId = lRegion.RegionId, Min = 9.5, Max = 13.64, Average = 11.6, ETC = 3.9, Rain = 0, };
            var lTD_South_20151017 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151017", Date = new DateTime(2015, 10, 17), RegionId = lRegion.RegionId, Min = 5.9, Max = 14.1, Average = 10, ETC = 3.7, Rain = 0, };
            var lTD_South_20151018 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151018", Date = new DateTime(2015, 10, 18), RegionId = lRegion.RegionId, Min = 3.3, Max = 20.1, Average = 11.7, ETC = 3.9, Rain = 0, };
            var lTD_South_20151019 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151019", Date = new DateTime(2015, 10, 19), RegionId = lRegion.RegionId, Min = 10.5, Max = 19.4, Average = 15, ETC = 2.3, Rain = 15.7, };
            var lTD_South_20151020 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151020", Date = new DateTime(2015, 10, 20), RegionId = lRegion.RegionId, Min = 11.8, Max = 17.6, Average = 14.7, ETC = 2.2, Rain = 0.2, };
            var lTD_South_20151021 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151021", Date = new DateTime(2015, 10, 21), RegionId = lRegion.RegionId, Min = 8.8, Max = 23.2, Average = 16, ETC = 3.8, Rain = 0, };
            var lTD_South_20151022 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151022", Date = new DateTime(2015, 10, 22), RegionId = lRegion.RegionId, Min = 10.3, Max = 22.79, Average = 16.5, ETC = 3.4, Rain = 0, };
            var lTD_South_20151023 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151023", Date = new DateTime(2015, 10, 23), RegionId = lRegion.RegionId, Min = 8.5, Max = 14.1, Average = 11.3, ETC = 3.9, Rain = 0, };
            var lTD_South_20151024 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151024", Date = new DateTime(2015, 10, 24), RegionId = lRegion.RegionId, Min = 8, Max = 15.3, Average = 11.7, ETC = 3.3, Rain = 0, };
            var lTD_South_20151025 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151025", Date = new DateTime(2015, 10, 25), RegionId = lRegion.RegionId, Min = 10.6, Max = 21.1, Average = 15.9, ETC = 3.1, Rain = 0, };
            var lTD_South_20151026 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151026", Date = new DateTime(2015, 10, 26), RegionId = lRegion.RegionId, Min = 13.9, Max = 22.6, Average = 18.3, ETC = 2.9, Rain = 0.6, };
            var lTD_South_20151027 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151027", Date = new DateTime(2015, 10, 27), RegionId = lRegion.RegionId, Min = 15, Max = 25.3, Average = 20.2, ETC = 4.4, Rain = 0, };
            var lTD_South_20151028 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151028", Date = new DateTime(2015, 10, 28), RegionId = lRegion.RegionId, Min = 14.2, Max = 26.9, Average = 20.6, ETC = 4.6, Rain = 0, };
            var lTD_South_20151029 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151029", Date = new DateTime(2015, 10, 29), RegionId = lRegion.RegionId, Min = 17, Max = 23.8, Average = 20.4, ETC = 2.5, Rain = 2.1, };
            var lTD_South_20151030 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151030", Date = new DateTime(2015, 10, 30), RegionId = lRegion.RegionId, Min = 9.6, Max = 17.8, Average = 13.7, ETC = 2, Rain = 0, };
            var lTD_South_20151031 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151031", Date = new DateTime(2015, 10, 31), RegionId = lRegion.RegionId, Min = 8.2, Max = 18, Average = 13.1, ETC = 4.4, Rain = 0, };
            var lTD_South_20151101 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151101", Date = new DateTime(2015, 11, 01), RegionId = lRegion.RegionId, Min = 8.9, Max = 20.6, Average = 14.8, ETC = 4.7, Rain = 0, };
            var lTD_South_20151102 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151102", Date = new DateTime(2015, 11, 02), RegionId = lRegion.RegionId, Min = 7.3, Max = 21.16, Average = 14.2, ETC = 4.1, Rain = 0, };
            var lTD_South_20151103 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151103", Date = new DateTime(2015, 11, 03), RegionId = lRegion.RegionId, Min = 12.4, Max = 22, Average = 17.2, ETC = 3.9, Rain = 0, };
            var lTD_South_20151104 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151104", Date = new DateTime(2015, 11, 04), RegionId = lRegion.RegionId, Min = 9.8, Max = 19.5, Average = 14.7, ETC = 3.8, Rain = 0, };
            var lTD_South_20151105 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151105", Date = new DateTime(2015, 11, 05), RegionId = lRegion.RegionId, Min = 6.8, Max = 23.1, Average = 15, ETC = 4.1, Rain = 0, };
            var lTD_South_20151106 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151106", Date = new DateTime(2015, 11, 06), RegionId = lRegion.RegionId, Min = 8.1, Max = 24.4, Average = 16.3, ETC = 4.9, Rain = 0, };
            var lTD_South_20151107 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151107", Date = new DateTime(2015, 11, 07), RegionId = lRegion.RegionId, Min = 9.7, Max = 26.4, Average = 18.1, ETC = 5.4, Rain = 0, };
            var lTD_South_20151108 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151108", Date = new DateTime(2015, 11, 08), RegionId = lRegion.RegionId, Min = 12.3, Max = 27.4, Average = 19.9, ETC = 5.7, Rain = 0, };
            var lTD_South_20151109 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151109", Date = new DateTime(2015, 11, 09), RegionId = lRegion.RegionId, Min = 16.6, Max = 29.9, Average = 23.3, ETC = 4.8, Rain = 0, };
            var lTD_South_20151110 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151110", Date = new DateTime(2015, 11, 10), RegionId = lRegion.RegionId, Min = 17.6, Max = 28.15, Average = 22.9, ETC = 3.6, Rain = 0, };
            var lTD_South_20151111 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151111", Date = new DateTime(2015, 11, 11), RegionId = lRegion.RegionId, Min = 13.17, Max = 26.8, Average = 20, ETC = 5.3, Rain = 0, };
            var lTD_South_20151112 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151112", Date = new DateTime(2015, 11, 12), RegionId = lRegion.RegionId, Min = 9, Max = 26.8, Average = 17.9, ETC = 4.4, Rain = 23.1, };
            var lTD_South_20151113 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151113", Date = new DateTime(2015, 11, 13), RegionId = lRegion.RegionId, Min = 15.8, Max = 21, Average = 18.4, ETC = 2.6, Rain = 1.2, };
            var lTD_South_20151114 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151114", Date = new DateTime(2015, 11, 14), RegionId = lRegion.RegionId, Min = 13.9, Max = 25.4, Average = 19.7, ETC = 5.3, Rain = 0, };
            var lTD_South_20151115 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151115", Date = new DateTime(2015, 11, 15), RegionId = lRegion.RegionId, Min = 14.1, Max = 28.7, Average = 21.4, ETC = 6.1, Rain = 0, };
            var lTD_South_20151116 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151116", Date = new DateTime(2015, 11, 16), RegionId = lRegion.RegionId, Min = 14.7, Max = 26.1, Average = 20.4, ETC = 5.6, Rain = 0, };
            var lTD_South_20151117 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151117", Date = new DateTime(2015, 11, 17), RegionId = lRegion.RegionId, Min = 17.4, Max = 21.4, Average = 19.4, ETC = 2.4, Rain = 5, };
            var lTD_South_20151118 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151118", Date = new DateTime(2015, 11, 18), RegionId = lRegion.RegionId, Min = 14.9, Max = 20.8, Average = 17.9, ETC = 2.1, Rain = 0, };
            var lTD_South_20151119 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151119", Date = new DateTime(2015, 11, 19), RegionId = lRegion.RegionId, Min = 12.3, Max = 19.9, Average = 16.1, ETC = 2.3, Rain = 6.1, };
            var lTD_South_20151120 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151120", Date = new DateTime(2015, 11, 20), RegionId = lRegion.RegionId, Min = 8.6, Max = 18.1, Average = 13.4, ETC = 5.4, Rain = 0, };
            var lTD_South_20151121 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151121", Date = new DateTime(2015, 11, 21), RegionId = lRegion.RegionId, Min = 6.9, Max = 24, Average = 15.5, ETC = 5.5, Rain = 0, };
            var lTD_South_20151122 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151122", Date = new DateTime(2015, 11, 22), RegionId = lRegion.RegionId, Min = 10.2, Max = 24.8, Average = 17.5, ETC = 5.6, Rain = 0, };
            var lTD_South_20151123 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151123", Date = new DateTime(2015, 11, 23), RegionId = lRegion.RegionId, Min = 10.8, Max = 23.8, Average = 17.3, ETC = 5, Rain = 0, };
            var lTD_South_20151124 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151124", Date = new DateTime(2015, 11, 24), RegionId = lRegion.RegionId, Min = 9.3, Max = 24.7, Average = 17, ETC = 6.1, Rain = 0, };
            var lTD_South_20151125 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151125", Date = new DateTime(2015, 11, 25), RegionId = lRegion.RegionId, Min = 12.6, Max = 25.8, Average = 19.2, ETC = 6.3, Rain = 0, };
            var lTD_South_20151126 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151126", Date = new DateTime(2015, 11, 26), RegionId = lRegion.RegionId, Min = 15, Max = 25.8, Average = 20.4, ETC = 5.1, Rain = 17.5, };
            var lTD_South_20151127 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151127", Date = new DateTime(2015, 11, 27), RegionId = lRegion.RegionId, Min = 17, Max = 24.7, Average = 20.9, ETC = 2.7, Rain = 17.7, };
            var lTD_South_20151128 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151128", Date = new DateTime(2015, 11, 28), RegionId = lRegion.RegionId, Min = 15.6, Max = 22.5, Average = 19.1, ETC = 6, Rain = 0, };
            var lTD_South_20151129 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151129", Date = new DateTime(2015, 11, 29), RegionId = lRegion.RegionId, Min = 14, Max = 22.6, Average = 18.3, ETC = 5.4, Rain = 0, };
            var lTD_South_20151130 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151130", Date = new DateTime(2015, 11, 30), RegionId = lRegion.RegionId, Min = 11.1, Max = 27.5, Average = 19.3, ETC = 6.2, Rain = 0, };
            var lTD_South_20151201 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151201", Date = new DateTime(2015, 12, 01), RegionId = lRegion.RegionId, Min = 13.9, Max = 29.4, Average = 21.7, ETC = 6.2, Rain = 0, };
            var lTD_South_20151202 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151202", Date = new DateTime(2015, 12, 02), RegionId = lRegion.RegionId, Min = 14.5, Max = 27, Average = 20.8, ETC = 6.4, Rain = 0, };
            var lTD_South_20151203 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151203", Date = new DateTime(2015, 12, 03), RegionId = lRegion.RegionId, Min = 13.5, Max = 28.2, Average = 20.9, ETC = 5.5, Rain = 2.2, };
            var lTD_South_20151204 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151204", Date = new DateTime(2015, 12, 04), RegionId = lRegion.RegionId, Min = 17.2, Max = 25.3, Average = 21.3, ETC = 4.1, Rain = 0, };
            var lTD_South_20151205 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151205", Date = new DateTime(2015, 12, 05), RegionId = lRegion.RegionId, Min = 13.7, Max = 23.7, Average = 18.7, ETC = 5.5, Rain = 0, };
            var lTD_South_20151206 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151206", Date = new DateTime(2015, 12, 06), RegionId = lRegion.RegionId, Min = 11.65, Max = 18.2, Average = 14.9, ETC = 5, Rain = 0, };
            var lTD_South_20151207 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151207", Date = new DateTime(2015, 12, 07), RegionId = lRegion.RegionId, Min = 8.5, Max = 26.1, Average = 17.3, ETC = 5.3, Rain = 0, };
            var lTD_South_20151208 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151208", Date = new DateTime(2015, 12, 08), RegionId = lRegion.RegionId, Min = 13.7, Max = 30.5, Average = 22.1, ETC = 6.3, Rain = 0, };
            var lTD_South_20151209 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151209", Date = new DateTime(2015, 12, 09), RegionId = lRegion.RegionId, Min = 14.8, Max = 25.3, Average = 20.1, ETC = 5.1, Rain = 0, };
            var lTD_South_20151210 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151210", Date = new DateTime(2015, 12, 10), RegionId = lRegion.RegionId, Min = 12.7, Max = 30.8, Average = 21.8, ETC = 6.9, Rain = 0, };
            var lTD_South_20151211 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151211", Date = new DateTime(2015, 12, 11), RegionId = lRegion.RegionId, Min = 17.4, Max = 34.8, Average = 26.1, ETC = 7.9, Rain = 0, };
            var lTD_South_20151212 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151212", Date = new DateTime(2015, 12, 12), RegionId = lRegion.RegionId, Min = 19.9, Max = 33.6, Average = 26.8, ETC = 6.6, Rain = 5, };
            var lTD_South_20151213 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151213", Date = new DateTime(2015, 12, 13), RegionId = lRegion.RegionId, Min = 19.3, Max = 30, Average = 24.7, ETC = 5.6, Rain = 12.8, };
            var lTD_South_20151214 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151214", Date = new DateTime(2015, 12, 14), RegionId = lRegion.RegionId, Min = 17.3, Max = 26, Average = 21.7, ETC = 3.6, Rain = 20.8, };
            var lTD_South_20151215 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151215", Date = new DateTime(2015, 12, 15), RegionId = lRegion.RegionId, Min = 16.1, Max = 24.8, Average = 20.5, ETC = 5.9, Rain = 0, };
            var lTD_South_20151216 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151216", Date = new DateTime(2015, 12, 16), RegionId = lRegion.RegionId, Min = 11.6, Max = 29.6, Average = 20.6, ETC = 6.7, Rain = 2.2, };
            var lTD_South_20151217 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151217", Date = new DateTime(2015, 12, 17), RegionId = lRegion.RegionId, Min = 16.9, Max = 24.7, Average = 20.8, ETC = 3, Rain = 16.4, };
            var lTD_South_20151218 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151218", Date = new DateTime(2015, 12, 18), RegionId = lRegion.RegionId, Min = 17.5, Max = 23.8, Average = 20.7, ETC = 5.8, Rain = 0, };
            var lTD_South_20151219 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151219", Date = new DateTime(2015, 12, 19), RegionId = lRegion.RegionId, Min = 13.5, Max = 21.5, Average = 17.5, ETC = 5.9, Rain = 0, };
            var lTD_South_20151220 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151220", Date = new DateTime(2015, 12, 20), RegionId = lRegion.RegionId, Min = 10, Max = 27, Average = 18.5, ETC = 5.9, Rain = 0, };
            var lTD_South_20151221 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151221", Date = new DateTime(2015, 12, 21), RegionId = lRegion.RegionId, Min = 15.7, Max = 29.6, Average = 22.7, ETC = 5.5, Rain = 27.4, };
            var lTD_South_20151222 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151222", Date = new DateTime(2015, 12, 22), RegionId = lRegion.RegionId, Min = 19.2, Max = 22.7, Average = 21, ETC = 2.3, Rain = 20.1, };
            var lTD_South_20151223 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151223", Date = new DateTime(2015, 12, 23), RegionId = lRegion.RegionId, Min = 18.5, Max = 28.3, Average = 23.4, ETC = 4.5, Rain = 0, };
            var lTD_South_20151224 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151224", Date = new DateTime(2015, 12, 24), RegionId = lRegion.RegionId, Min = 17.2, Max = 28.8, Average = 23, ETC = 6.4, Rain = 0, };
            var lTD_South_20151225 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151225", Date = new DateTime(2015, 12, 25), RegionId = lRegion.RegionId, Min = 13.5, Max = 31.1, Average = 22.3, ETC = 6.8, Rain = 0, };
            var lTD_South_20151226 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151226", Date = new DateTime(2015, 12, 26), RegionId = lRegion.RegionId, Min = 15.2, Max = 30.5, Average = 22.9, ETC = 6.4, Rain = 0, };
            var lTD_South_20151227 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151227", Date = new DateTime(2015, 12, 27), RegionId = lRegion.RegionId, Min = 16.3, Max = 32.8, Average = 24.6, ETC = 6.2, Rain = 0, };
            var lTD_South_20151228 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151228", Date = new DateTime(2015, 12, 28), RegionId = lRegion.RegionId, Min = 18.9, Max = 34.3, Average = 26.6, ETC = 6.8, Rain = 0, };
            var lTD_South_20151229 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151229", Date = new DateTime(2015, 12, 29), RegionId = lRegion.RegionId, Min = 18.2, Max = 30.7, Average = 24.5, ETC = 4.3, Rain = 12.1, };
            var lTD_South_20151230 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151230", Date = new DateTime(2015, 12, 30), RegionId = lRegion.RegionId, Min = 19.9, Max = 26.3, Average = 23.1, ETC = 2.9, Rain = 0.6, };
            var lTD_South_20151231 = new TemperatureData { Name = Utils.NameRegionSouth + "-20151231", Date = new DateTime(2015, 12, 31), RegionId = lRegion.RegionId, Min = 18.5, Max = 28.2, Average = 23.4, ETC = 6.2, Rain = 0, };
            #endregion

            #region 2015 - Add to Context
            context.TemperatureDatas.Add(lTD_South_20150101);
            context.TemperatureDatas.Add(lTD_South_20150102);
            context.TemperatureDatas.Add(lTD_South_20150103);
            context.TemperatureDatas.Add(lTD_South_20150104);
            context.TemperatureDatas.Add(lTD_South_20150105);
            context.TemperatureDatas.Add(lTD_South_20150106);
            context.TemperatureDatas.Add(lTD_South_20150107);
            context.TemperatureDatas.Add(lTD_South_20150108);
            context.TemperatureDatas.Add(lTD_South_20150109);
            context.TemperatureDatas.Add(lTD_South_20150110);
            context.TemperatureDatas.Add(lTD_South_20150111);
            context.TemperatureDatas.Add(lTD_South_20150112);
            context.TemperatureDatas.Add(lTD_South_20150113);
            context.TemperatureDatas.Add(lTD_South_20150114);
            context.TemperatureDatas.Add(lTD_South_20150115);
            context.TemperatureDatas.Add(lTD_South_20150116);
            context.TemperatureDatas.Add(lTD_South_20150117);
            context.TemperatureDatas.Add(lTD_South_20150118);
            context.TemperatureDatas.Add(lTD_South_20150119);
            context.TemperatureDatas.Add(lTD_South_20150120);
            context.TemperatureDatas.Add(lTD_South_20150121);
            context.TemperatureDatas.Add(lTD_South_20150122);
            context.TemperatureDatas.Add(lTD_South_20150123);
            context.TemperatureDatas.Add(lTD_South_20150124);
            context.TemperatureDatas.Add(lTD_South_20150125);
            context.TemperatureDatas.Add(lTD_South_20150126);
            context.TemperatureDatas.Add(lTD_South_20150127);
            context.TemperatureDatas.Add(lTD_South_20150128);
            context.TemperatureDatas.Add(lTD_South_20150129);
            context.TemperatureDatas.Add(lTD_South_20150130);
            context.TemperatureDatas.Add(lTD_South_20150131);
            context.TemperatureDatas.Add(lTD_South_20150201);
            context.TemperatureDatas.Add(lTD_South_20150202);
            context.TemperatureDatas.Add(lTD_South_20150203);
            context.TemperatureDatas.Add(lTD_South_20150204);
            context.TemperatureDatas.Add(lTD_South_20150205);
            context.TemperatureDatas.Add(lTD_South_20150206);
            context.TemperatureDatas.Add(lTD_South_20150207);
            context.TemperatureDatas.Add(lTD_South_20150208);
            context.TemperatureDatas.Add(lTD_South_20150209);
            context.TemperatureDatas.Add(lTD_South_20150210);
            context.TemperatureDatas.Add(lTD_South_20150211);
            context.TemperatureDatas.Add(lTD_South_20150212);
            context.TemperatureDatas.Add(lTD_South_20150213);
            context.TemperatureDatas.Add(lTD_South_20150214);
            context.TemperatureDatas.Add(lTD_South_20150215);
            context.TemperatureDatas.Add(lTD_South_20150216);
            context.TemperatureDatas.Add(lTD_South_20150217);
            context.TemperatureDatas.Add(lTD_South_20150218);
            context.TemperatureDatas.Add(lTD_South_20150219);
            context.TemperatureDatas.Add(lTD_South_20150220);
            context.TemperatureDatas.Add(lTD_South_20150221);
            context.TemperatureDatas.Add(lTD_South_20150222);
            context.TemperatureDatas.Add(lTD_South_20150223);
            context.TemperatureDatas.Add(lTD_South_20150224);
            context.TemperatureDatas.Add(lTD_South_20150225);
            context.TemperatureDatas.Add(lTD_South_20150226);
            context.TemperatureDatas.Add(lTD_South_20150227);
            context.TemperatureDatas.Add(lTD_South_20150228);
            context.TemperatureDatas.Add(lTD_South_20150301);
            context.TemperatureDatas.Add(lTD_South_20150302);
            context.TemperatureDatas.Add(lTD_South_20150303);
            context.TemperatureDatas.Add(lTD_South_20150304);
            context.TemperatureDatas.Add(lTD_South_20150305);
            context.TemperatureDatas.Add(lTD_South_20150306);
            context.TemperatureDatas.Add(lTD_South_20150307);
            context.TemperatureDatas.Add(lTD_South_20150308);
            context.TemperatureDatas.Add(lTD_South_20150309);
            context.TemperatureDatas.Add(lTD_South_20150310);
            context.TemperatureDatas.Add(lTD_South_20150311);
            context.TemperatureDatas.Add(lTD_South_20150312);
            context.TemperatureDatas.Add(lTD_South_20150313);
            context.TemperatureDatas.Add(lTD_South_20150314);
            context.TemperatureDatas.Add(lTD_South_20150315);
            context.TemperatureDatas.Add(lTD_South_20150316);
            context.TemperatureDatas.Add(lTD_South_20150317);
            context.TemperatureDatas.Add(lTD_South_20150318);
            context.TemperatureDatas.Add(lTD_South_20150319);
            context.TemperatureDatas.Add(lTD_South_20150320);
            context.TemperatureDatas.Add(lTD_South_20150321);
            context.TemperatureDatas.Add(lTD_South_20150322);
            context.TemperatureDatas.Add(lTD_South_20150323);
            context.TemperatureDatas.Add(lTD_South_20150324);
            context.TemperatureDatas.Add(lTD_South_20150325);
            context.TemperatureDatas.Add(lTD_South_20150326);
            context.TemperatureDatas.Add(lTD_South_20150327);
            context.TemperatureDatas.Add(lTD_South_20150328);
            context.TemperatureDatas.Add(lTD_South_20150329);
            context.TemperatureDatas.Add(lTD_South_20150330);
            context.TemperatureDatas.Add(lTD_South_20150331);
            context.TemperatureDatas.Add(lTD_South_20150401);
            context.TemperatureDatas.Add(lTD_South_20150402);
            context.TemperatureDatas.Add(lTD_South_20150403);
            context.TemperatureDatas.Add(lTD_South_20150404);
            context.TemperatureDatas.Add(lTD_South_20150405);
            context.TemperatureDatas.Add(lTD_South_20150406);
            context.TemperatureDatas.Add(lTD_South_20150407);
            context.TemperatureDatas.Add(lTD_South_20150408);
            context.TemperatureDatas.Add(lTD_South_20150409);
            context.TemperatureDatas.Add(lTD_South_20150410);
            context.TemperatureDatas.Add(lTD_South_20150411);
            context.TemperatureDatas.Add(lTD_South_20150412);
            context.TemperatureDatas.Add(lTD_South_20150413);
            context.TemperatureDatas.Add(lTD_South_20150414);
            context.TemperatureDatas.Add(lTD_South_20150415);
            context.TemperatureDatas.Add(lTD_South_20150416);
            context.TemperatureDatas.Add(lTD_South_20150417);
            context.TemperatureDatas.Add(lTD_South_20150418);
            context.TemperatureDatas.Add(lTD_South_20150419);
            context.TemperatureDatas.Add(lTD_South_20150420);
            context.TemperatureDatas.Add(lTD_South_20150421);
            context.TemperatureDatas.Add(lTD_South_20150422);
            context.TemperatureDatas.Add(lTD_South_20150423);
            context.TemperatureDatas.Add(lTD_South_20150424);
            context.TemperatureDatas.Add(lTD_South_20150425);
            context.TemperatureDatas.Add(lTD_South_20150426);
            context.TemperatureDatas.Add(lTD_South_20150427);
            context.TemperatureDatas.Add(lTD_South_20150428);
            context.TemperatureDatas.Add(lTD_South_20150429);
            context.TemperatureDatas.Add(lTD_South_20150430);
            context.TemperatureDatas.Add(lTD_South_20150501);
            context.TemperatureDatas.Add(lTD_South_20150502);
            context.TemperatureDatas.Add(lTD_South_20150503);
            context.TemperatureDatas.Add(lTD_South_20150504);
            context.TemperatureDatas.Add(lTD_South_20150505);
            context.TemperatureDatas.Add(lTD_South_20150506);
            context.TemperatureDatas.Add(lTD_South_20150507);
            context.TemperatureDatas.Add(lTD_South_20150508);
            context.TemperatureDatas.Add(lTD_South_20150509);
            context.TemperatureDatas.Add(lTD_South_20150510);
            context.TemperatureDatas.Add(lTD_South_20150511);
            context.TemperatureDatas.Add(lTD_South_20150512);
            context.TemperatureDatas.Add(lTD_South_20150513);
            context.TemperatureDatas.Add(lTD_South_20150514);
            context.TemperatureDatas.Add(lTD_South_20150515);
            context.TemperatureDatas.Add(lTD_South_20150516);
            context.TemperatureDatas.Add(lTD_South_20150517);
            context.TemperatureDatas.Add(lTD_South_20150518);
            context.TemperatureDatas.Add(lTD_South_20150519);
            context.TemperatureDatas.Add(lTD_South_20150520);
            context.TemperatureDatas.Add(lTD_South_20150521);
            context.TemperatureDatas.Add(lTD_South_20150522);
            context.TemperatureDatas.Add(lTD_South_20150523);
            context.TemperatureDatas.Add(lTD_South_20150524);
            context.TemperatureDatas.Add(lTD_South_20150525);
            context.TemperatureDatas.Add(lTD_South_20150526);
            context.TemperatureDatas.Add(lTD_South_20150527);
            context.TemperatureDatas.Add(lTD_South_20150528);
            context.TemperatureDatas.Add(lTD_South_20150529);
            context.TemperatureDatas.Add(lTD_South_20150530);
            context.TemperatureDatas.Add(lTD_South_20150531);
            context.TemperatureDatas.Add(lTD_South_20150601);
            context.TemperatureDatas.Add(lTD_South_20150602);
            context.TemperatureDatas.Add(lTD_South_20150603);
            context.TemperatureDatas.Add(lTD_South_20150604);
            context.TemperatureDatas.Add(lTD_South_20150605);
            context.TemperatureDatas.Add(lTD_South_20150606);
            context.TemperatureDatas.Add(lTD_South_20150607);
            context.TemperatureDatas.Add(lTD_South_20150608);
            context.TemperatureDatas.Add(lTD_South_20150609);
            context.TemperatureDatas.Add(lTD_South_20150610);
            context.TemperatureDatas.Add(lTD_South_20150611);
            context.TemperatureDatas.Add(lTD_South_20150612);
            context.TemperatureDatas.Add(lTD_South_20150613);
            context.TemperatureDatas.Add(lTD_South_20150614);
            context.TemperatureDatas.Add(lTD_South_20150615);
            context.TemperatureDatas.Add(lTD_South_20150616);
            context.TemperatureDatas.Add(lTD_South_20150617);
            context.TemperatureDatas.Add(lTD_South_20150618);
            context.TemperatureDatas.Add(lTD_South_20150619);
            context.TemperatureDatas.Add(lTD_South_20150620);
            context.TemperatureDatas.Add(lTD_South_20150621);
            context.TemperatureDatas.Add(lTD_South_20150622);
            context.TemperatureDatas.Add(lTD_South_20150623);
            context.TemperatureDatas.Add(lTD_South_20150624);
            context.TemperatureDatas.Add(lTD_South_20150625);
            context.TemperatureDatas.Add(lTD_South_20150626);
            context.TemperatureDatas.Add(lTD_South_20150627);
            context.TemperatureDatas.Add(lTD_South_20150628);
            context.TemperatureDatas.Add(lTD_South_20150629);
            context.TemperatureDatas.Add(lTD_South_20150630);
            context.TemperatureDatas.Add(lTD_South_20150701);
            context.TemperatureDatas.Add(lTD_South_20150702);
            context.TemperatureDatas.Add(lTD_South_20150703);
            context.TemperatureDatas.Add(lTD_South_20150704);
            context.TemperatureDatas.Add(lTD_South_20150705);
            context.TemperatureDatas.Add(lTD_South_20150706);
            context.TemperatureDatas.Add(lTD_South_20150707);
            context.TemperatureDatas.Add(lTD_South_20150708);
            context.TemperatureDatas.Add(lTD_South_20150709);
            context.TemperatureDatas.Add(lTD_South_20150710);
            context.TemperatureDatas.Add(lTD_South_20150711);
            context.TemperatureDatas.Add(lTD_South_20150712);
            context.TemperatureDatas.Add(lTD_South_20150713);
            context.TemperatureDatas.Add(lTD_South_20150714);
            context.TemperatureDatas.Add(lTD_South_20150715);
            context.TemperatureDatas.Add(lTD_South_20150716);
            context.TemperatureDatas.Add(lTD_South_20150717);
            context.TemperatureDatas.Add(lTD_South_20150718);
            context.TemperatureDatas.Add(lTD_South_20150719);
            context.TemperatureDatas.Add(lTD_South_20150720);
            context.TemperatureDatas.Add(lTD_South_20150721);
            context.TemperatureDatas.Add(lTD_South_20150722);
            context.TemperatureDatas.Add(lTD_South_20150723);
            context.TemperatureDatas.Add(lTD_South_20150724);
            context.TemperatureDatas.Add(lTD_South_20150725);
            context.TemperatureDatas.Add(lTD_South_20150726);
            context.TemperatureDatas.Add(lTD_South_20150727);
            context.TemperatureDatas.Add(lTD_South_20150728);
            context.TemperatureDatas.Add(lTD_South_20150729);
            context.TemperatureDatas.Add(lTD_South_20150730);
            context.TemperatureDatas.Add(lTD_South_20150731);
            context.TemperatureDatas.Add(lTD_South_20150801);
            context.TemperatureDatas.Add(lTD_South_20150802);
            context.TemperatureDatas.Add(lTD_South_20150803);
            context.TemperatureDatas.Add(lTD_South_20150804);
            context.TemperatureDatas.Add(lTD_South_20150805);
            context.TemperatureDatas.Add(lTD_South_20150806);
            context.TemperatureDatas.Add(lTD_South_20150807);
            context.TemperatureDatas.Add(lTD_South_20150808);
            context.TemperatureDatas.Add(lTD_South_20150809);
            context.TemperatureDatas.Add(lTD_South_20150810);
            context.TemperatureDatas.Add(lTD_South_20150811);
            context.TemperatureDatas.Add(lTD_South_20150812);
            context.TemperatureDatas.Add(lTD_South_20150813);
            context.TemperatureDatas.Add(lTD_South_20150814);
            context.TemperatureDatas.Add(lTD_South_20150815);
            context.TemperatureDatas.Add(lTD_South_20150816);
            context.TemperatureDatas.Add(lTD_South_20150817);
            context.TemperatureDatas.Add(lTD_South_20150818);
            context.TemperatureDatas.Add(lTD_South_20150819);
            context.TemperatureDatas.Add(lTD_South_20150820);
            context.TemperatureDatas.Add(lTD_South_20150821);
            context.TemperatureDatas.Add(lTD_South_20150822);
            context.TemperatureDatas.Add(lTD_South_20150823);
            context.TemperatureDatas.Add(lTD_South_20150824);
            context.TemperatureDatas.Add(lTD_South_20150825);
            context.TemperatureDatas.Add(lTD_South_20150826);
            context.TemperatureDatas.Add(lTD_South_20150827);
            context.TemperatureDatas.Add(lTD_South_20150828);
            context.TemperatureDatas.Add(lTD_South_20150829);
            context.TemperatureDatas.Add(lTD_South_20150830);
            context.TemperatureDatas.Add(lTD_South_20150831);
            context.TemperatureDatas.Add(lTD_South_20150901);
            context.TemperatureDatas.Add(lTD_South_20150902);
            context.TemperatureDatas.Add(lTD_South_20150903);
            context.TemperatureDatas.Add(lTD_South_20150904);
            context.TemperatureDatas.Add(lTD_South_20150905);
            context.TemperatureDatas.Add(lTD_South_20150906);
            context.TemperatureDatas.Add(lTD_South_20150907);
            context.TemperatureDatas.Add(lTD_South_20150908);
            context.TemperatureDatas.Add(lTD_South_20150909);
            context.TemperatureDatas.Add(lTD_South_20150910);
            context.TemperatureDatas.Add(lTD_South_20150911);
            context.TemperatureDatas.Add(lTD_South_20150912);
            context.TemperatureDatas.Add(lTD_South_20150913);
            context.TemperatureDatas.Add(lTD_South_20150914);
            context.TemperatureDatas.Add(lTD_South_20150915);
            context.TemperatureDatas.Add(lTD_South_20150916);
            context.TemperatureDatas.Add(lTD_South_20150917);
            context.TemperatureDatas.Add(lTD_South_20150918);
            context.TemperatureDatas.Add(lTD_South_20150919);
            context.TemperatureDatas.Add(lTD_South_20150920);
            context.TemperatureDatas.Add(lTD_South_20150921);
            context.TemperatureDatas.Add(lTD_South_20150922);
            context.TemperatureDatas.Add(lTD_South_20150923);
            context.TemperatureDatas.Add(lTD_South_20150924);
            context.TemperatureDatas.Add(lTD_South_20150925);
            context.TemperatureDatas.Add(lTD_South_20150926);
            context.TemperatureDatas.Add(lTD_South_20150927);
            context.TemperatureDatas.Add(lTD_South_20150928);
            context.TemperatureDatas.Add(lTD_South_20150929);
            context.TemperatureDatas.Add(lTD_South_20150930);
            context.TemperatureDatas.Add(lTD_South_20151001);
            context.TemperatureDatas.Add(lTD_South_20151002);
            context.TemperatureDatas.Add(lTD_South_20151003);
            context.TemperatureDatas.Add(lTD_South_20151004);
            context.TemperatureDatas.Add(lTD_South_20151005);
            context.TemperatureDatas.Add(lTD_South_20151006);
            context.TemperatureDatas.Add(lTD_South_20151007);
            context.TemperatureDatas.Add(lTD_South_20151008);
            context.TemperatureDatas.Add(lTD_South_20151009);
            context.TemperatureDatas.Add(lTD_South_20151010);
            context.TemperatureDatas.Add(lTD_South_20151011);
            context.TemperatureDatas.Add(lTD_South_20151012);
            context.TemperatureDatas.Add(lTD_South_20151013);
            context.TemperatureDatas.Add(lTD_South_20151014);
            context.TemperatureDatas.Add(lTD_South_20151015);
            context.TemperatureDatas.Add(lTD_South_20151016);
            context.TemperatureDatas.Add(lTD_South_20151017);
            context.TemperatureDatas.Add(lTD_South_20151018);
            context.TemperatureDatas.Add(lTD_South_20151019);
            context.TemperatureDatas.Add(lTD_South_20151020);
            context.TemperatureDatas.Add(lTD_South_20151021);
            context.TemperatureDatas.Add(lTD_South_20151022);
            context.TemperatureDatas.Add(lTD_South_20151023);
            context.TemperatureDatas.Add(lTD_South_20151024);
            context.TemperatureDatas.Add(lTD_South_20151025);
            context.TemperatureDatas.Add(lTD_South_20151026);
            context.TemperatureDatas.Add(lTD_South_20151027);
            context.TemperatureDatas.Add(lTD_South_20151028);
            context.TemperatureDatas.Add(lTD_South_20151029);
            context.TemperatureDatas.Add(lTD_South_20151030);
            context.TemperatureDatas.Add(lTD_South_20151031);
            context.TemperatureDatas.Add(lTD_South_20151101);
            context.TemperatureDatas.Add(lTD_South_20151102);
            context.TemperatureDatas.Add(lTD_South_20151103);
            context.TemperatureDatas.Add(lTD_South_20151104);
            context.TemperatureDatas.Add(lTD_South_20151105);
            context.TemperatureDatas.Add(lTD_South_20151106);
            context.TemperatureDatas.Add(lTD_South_20151107);
            context.TemperatureDatas.Add(lTD_South_20151108);
            context.TemperatureDatas.Add(lTD_South_20151109);
            context.TemperatureDatas.Add(lTD_South_20151110);
            context.TemperatureDatas.Add(lTD_South_20151111);
            context.TemperatureDatas.Add(lTD_South_20151112);
            context.TemperatureDatas.Add(lTD_South_20151113);
            context.TemperatureDatas.Add(lTD_South_20151114);
            context.TemperatureDatas.Add(lTD_South_20151115);
            context.TemperatureDatas.Add(lTD_South_20151116);
            context.TemperatureDatas.Add(lTD_South_20151117);
            context.TemperatureDatas.Add(lTD_South_20151118);
            context.TemperatureDatas.Add(lTD_South_20151119);
            context.TemperatureDatas.Add(lTD_South_20151120);
            context.TemperatureDatas.Add(lTD_South_20151121);
            context.TemperatureDatas.Add(lTD_South_20151122);
            context.TemperatureDatas.Add(lTD_South_20151123);
            context.TemperatureDatas.Add(lTD_South_20151124);
            context.TemperatureDatas.Add(lTD_South_20151125);
            context.TemperatureDatas.Add(lTD_South_20151126);
            context.TemperatureDatas.Add(lTD_South_20151127);
            context.TemperatureDatas.Add(lTD_South_20151128);
            context.TemperatureDatas.Add(lTD_South_20151129);
            context.TemperatureDatas.Add(lTD_South_20151130);
            context.TemperatureDatas.Add(lTD_South_20151201);
            context.TemperatureDatas.Add(lTD_South_20151202);
            context.TemperatureDatas.Add(lTD_South_20151203);
            context.TemperatureDatas.Add(lTD_South_20151204);
            context.TemperatureDatas.Add(lTD_South_20151205);
            context.TemperatureDatas.Add(lTD_South_20151206);
            context.TemperatureDatas.Add(lTD_South_20151207);
            context.TemperatureDatas.Add(lTD_South_20151208);
            context.TemperatureDatas.Add(lTD_South_20151209);
            context.TemperatureDatas.Add(lTD_South_20151210);
            context.TemperatureDatas.Add(lTD_South_20151211);
            context.TemperatureDatas.Add(lTD_South_20151212);
            context.TemperatureDatas.Add(lTD_South_20151213);
            context.TemperatureDatas.Add(lTD_South_20151214);
            context.TemperatureDatas.Add(lTD_South_20151215);
            context.TemperatureDatas.Add(lTD_South_20151216);
            context.TemperatureDatas.Add(lTD_South_20151217);
            context.TemperatureDatas.Add(lTD_South_20151218);
            context.TemperatureDatas.Add(lTD_South_20151219);
            context.TemperatureDatas.Add(lTD_South_20151220);
            context.TemperatureDatas.Add(lTD_South_20151221);
            context.TemperatureDatas.Add(lTD_South_20151222);
            context.TemperatureDatas.Add(lTD_South_20151223);
            context.TemperatureDatas.Add(lTD_South_20151224);
            context.TemperatureDatas.Add(lTD_South_20151225);
            context.TemperatureDatas.Add(lTD_South_20151226);
            context.TemperatureDatas.Add(lTD_South_20151227);
            context.TemperatureDatas.Add(lTD_South_20151228);
            context.TemperatureDatas.Add(lTD_South_20151229);
            context.TemperatureDatas.Add(lTD_South_20151230);
            context.TemperatureDatas.Add(lTD_South_20151231);
            #endregion

            #endregion

        }

        public static void DataTemperatures_South_2016(IrrigationAdvisorContext context, Region pRegion)
        {
            Region lRegion = pRegion;

            #region South

            #region 2016 - new TemperatureData

            var lTD_South_20160101 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160101", Date = new DateTime(2016, 01, 01), RegionId = lRegion.RegionId, Min = 21.1, Max = 30.5, Average = 25.8, ETC = 6.2, Rain = 0, };
            var lTD_South_20160102 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160102", Date = new DateTime(2016, 01, 02), RegionId = lRegion.RegionId, Min = 19.5, Max = 30.2, Average = 24.9, ETC = 5.3, Rain = 2.5, };
            var lTD_South_20160103 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160103", Date = new DateTime(2016, 01, 03), RegionId = lRegion.RegionId, Min = 21.2, Max = 29.6, Average = 25.4, ETC = 6.1, Rain = 0, };
            var lTD_South_20160104 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160104", Date = new DateTime(2016, 01, 04), RegionId = lRegion.RegionId, Min = 21.5, Max = 33.7, Average = 27.6, ETC = 6.5, Rain = 0, };
            var lTD_South_20160105 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160105", Date = new DateTime(2016, 01, 05), RegionId = lRegion.RegionId, Min = 21.7, Max = 31, Average = 26.4, ETC = 5.2, Rain = 0, };
            var lTD_South_20160106 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160106", Date = new DateTime(2016, 01, 06), RegionId = lRegion.RegionId, Min = 15.8, Max = 24.9, Average = 20.4, ETC = 5.5, Rain = 0, };
            var lTD_South_20160107 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160107", Date = new DateTime(2016, 01, 07), RegionId = lRegion.RegionId, Min = 13.2, Max = 25.2, Average = 19.2, ETC = 5.7, Rain = 0, };
            var lTD_South_20160108 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160108", Date = new DateTime(2016, 01, 08), RegionId = lRegion.RegionId, Min = 14.4, Max = 29.1, Average = 21.8, ETC = 4.5, Rain = 0.7, };
            var lTD_South_20160109 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160109", Date = new DateTime(2016, 01, 09), RegionId = lRegion.RegionId, Min = 15.8, Max = 26.9, Average = 21.4, ETC = 5.7, Rain = 0, };
            var lTD_South_20160110 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160110", Date = new DateTime(2016, 01, 10), RegionId = lRegion.RegionId, Min = 17.2, Max = 29.6, Average = 23.4, ETC = 4.2, Rain = 1.8, };
            var lTD_South_20160111 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160111", Date = new DateTime(2016, 01, 11), RegionId = lRegion.RegionId, Min = 17.07, Max = 30.4, Average = 23.7, ETC = 6.3, Rain = 0, };
            var lTD_South_20160112 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160112", Date = new DateTime(2016, 01, 12), RegionId = lRegion.RegionId, Min = 18.8, Max = 32.8, Average = 25.8, ETC = 5.3, Rain = 0, };
            var lTD_South_20160113 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160113", Date = new DateTime(2016, 01, 13), RegionId = lRegion.RegionId, Min = 17.5, Max = 28.5, Average = 23, ETC = 7.2, Rain = 0, };
            var lTD_South_20160114 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160114", Date = new DateTime(2016, 01, 14), RegionId = lRegion.RegionId, Min = 14.8, Max = 32.7, Average = 23.8, ETC = 6.9, Rain = 0, };
            var lTD_South_20160115 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160115", Date = new DateTime(2016, 01, 15), RegionId = lRegion.RegionId, Min = 15.6, Max = 30.5, Average = 23.1, ETC = 6.7, Rain = 0, };
            var lTD_South_20160116 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160116", Date = new DateTime(2016, 01, 16), RegionId = lRegion.RegionId, Min = 12.2, Max = 32.05, Average = 22.1, ETC = 5.8, Rain = 0, };
            var lTD_South_20160117 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160117", Date = new DateTime(2016, 01, 17), RegionId = lRegion.RegionId, Min = 19.7, Max = 35.3, Average = 27.5, ETC = 6.6, Rain = 0, };
            var lTD_South_20160118 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160118", Date = new DateTime(2016, 01, 18), RegionId = lRegion.RegionId, Min = 17.62, Max = 27.5, Average = 22.6, ETC = 6.3, Rain = 0, };
            var lTD_South_20160119 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160119", Date = new DateTime(2016, 01, 19), RegionId = lRegion.RegionId, Min = 14, Max = 30.16, Average = 22.1, ETC = 6.4, Rain = 1.2, };
            var lTD_South_20160120 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160120", Date = new DateTime(2016, 01, 20), RegionId = lRegion.RegionId, Min = 17.6, Max = 24, Average = 20.8, ETC = 2.6, Rain = 4.3, };
            var lTD_South_20160121 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160121", Date = new DateTime(2016, 01, 21), RegionId = lRegion.RegionId, Min = 18.5, Max = 31.3, Average = 24.9, ETC = 6.8, Rain = 0, };
            var lTD_South_20160122 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160122", Date = new DateTime(2016, 01, 22), RegionId = lRegion.RegionId, Min = 20.1, Max = 35, Average = 27.6, ETC = 7.6, Rain = 0.5, };
            var lTD_South_20160123 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160123", Date = new DateTime(2016, 01, 23), RegionId = lRegion.RegionId, Min = 18.8, Max = 26.96, Average = 22.9, ETC = 6.6, Rain = 0, };
            var lTD_South_20160124 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160124", Date = new DateTime(2016, 01, 24), RegionId = lRegion.RegionId, Min = 16.4, Max = 38, Average = 27.2, ETC = 8, Rain = 0, };
            var lTD_South_20160125 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160125", Date = new DateTime(2016, 01, 25), RegionId = lRegion.RegionId, Min = 20.4, Max = 29.9, Average = 25.2, ETC = 6.8, Rain = 0, };
            var lTD_South_20160126 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160126", Date = new DateTime(2016, 01, 26), RegionId = lRegion.RegionId, Min = 15, Max = 25.8, Average = 20.4, ETC = 5.6, Rain = 0, };
            var lTD_South_20160127 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160127", Date = new DateTime(2016, 01, 27), RegionId = lRegion.RegionId, Min = 10.5, Max = 27.4, Average = 19, ETC = 5.8, Rain = 0, };
            var lTD_South_20160128 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160128", Date = new DateTime(2016, 01, 28), RegionId = lRegion.RegionId, Min = 14.5, Max = 31, Average = 22.8, ETC = 5.9, Rain = 0, };
            var lTD_South_20160129 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160129", Date = new DateTime(2016, 01, 29), RegionId = lRegion.RegionId, Min = 20.2, Max = 30.1, Average = 25.2, ETC = 3.9, Rain = 0, };
            var lTD_South_20160130 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160130", Date = new DateTime(2016, 01, 30), RegionId = lRegion.RegionId, Min = 19.2, Max = 28.2, Average = 23.7, ETC = 5.2, Rain = 0, };
            var lTD_South_20160131 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160131", Date = new DateTime(2016, 01, 31), RegionId = lRegion.RegionId, Min = 14.5, Max = 25.9, Average = 20.2, ETC = 5, Rain = 0, };
            var lTD_South_20160201 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160201", Date = new DateTime(2016, 02, 01), RegionId = lRegion.RegionId, Min = 12.3, Max = 25.6, Average = 19, ETC = 5.4, Rain = 0, };
            var lTD_South_20160202 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160202", Date = new DateTime(2016, 02, 02), RegionId = lRegion.RegionId, Min = 14.5, Max = 29, Average = 21.8, ETC = 6.1, Rain = 0, };
            var lTD_South_20160203 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160203", Date = new DateTime(2016, 02, 03), RegionId = lRegion.RegionId, Min = 18.1, Max = 30.7, Average = 24.4, ETC = 5, Rain = 0, };
            var lTD_South_20160204 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160204", Date = new DateTime(2016, 02, 04), RegionId = lRegion.RegionId, Min = 18.9, Max = 31, Average = 25, ETC = 6.1, Rain = 0, };
            var lTD_South_20160205 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160205", Date = new DateTime(2016, 02, 05), RegionId = lRegion.RegionId, Min = 18.8, Max = 33.3, Average = 26.1, ETC = 6.7, Rain = 0.7, };
            var lTD_South_20160206 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160206", Date = new DateTime(2016, 02, 06), RegionId = lRegion.RegionId, Min = 20, Max = 33.1, Average = 26.6, ETC = 6.2, Rain = 0, };
            var lTD_South_20160207 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160207", Date = new DateTime(2016, 02, 07), RegionId = lRegion.RegionId, Min = 19.3, Max = 33.2, Average = 26.3, ETC = 5.8, Rain = 0, };
            var lTD_South_20160208 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160208", Date = new DateTime(2016, 02, 08), RegionId = lRegion.RegionId, Min = 22.2, Max = 30.1, Average = 26.2, ETC = 3.3, Rain = 7, };
            var lTD_South_20160209 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160209", Date = new DateTime(2016, 02, 09), RegionId = lRegion.RegionId, Min = 19.9, Max = 31.6, Average = 25.8, ETC = 6, Rain = 0, };
            var lTD_South_20160210 = new TemperatureData { Name = Utils.NameRegionSouth + "-20160210", Date = new DateTime(2016, 02, 10), RegionId = lRegion.RegionId, Min = 18.9, Max = 30.3, Average = 24.6, ETC = 6.4, Rain = 0, };

            #endregion


            #region 2016 - Add to Context

            context.TemperatureDatas.Add(lTD_South_20160101);
            context.TemperatureDatas.Add(lTD_South_20160102);
            context.TemperatureDatas.Add(lTD_South_20160103);
            context.TemperatureDatas.Add(lTD_South_20160104);
            context.TemperatureDatas.Add(lTD_South_20160105);
            context.TemperatureDatas.Add(lTD_South_20160106);
            context.TemperatureDatas.Add(lTD_South_20160107);
            context.TemperatureDatas.Add(lTD_South_20160108);
            context.TemperatureDatas.Add(lTD_South_20160109);
            context.TemperatureDatas.Add(lTD_South_20160110);
            context.TemperatureDatas.Add(lTD_South_20160111);
            context.TemperatureDatas.Add(lTD_South_20160112);
            context.TemperatureDatas.Add(lTD_South_20160113);
            context.TemperatureDatas.Add(lTD_South_20160114);
            context.TemperatureDatas.Add(lTD_South_20160115);
            context.TemperatureDatas.Add(lTD_South_20160116);
            context.TemperatureDatas.Add(lTD_South_20160117);
            context.TemperatureDatas.Add(lTD_South_20160118);
            context.TemperatureDatas.Add(lTD_South_20160119);
            context.TemperatureDatas.Add(lTD_South_20160120);
            context.TemperatureDatas.Add(lTD_South_20160121);
            context.TemperatureDatas.Add(lTD_South_20160122);
            context.TemperatureDatas.Add(lTD_South_20160123);
            context.TemperatureDatas.Add(lTD_South_20160124);
            context.TemperatureDatas.Add(lTD_South_20160125);
            context.TemperatureDatas.Add(lTD_South_20160126);
            context.TemperatureDatas.Add(lTD_South_20160127);
            context.TemperatureDatas.Add(lTD_South_20160128);
            context.TemperatureDatas.Add(lTD_South_20160129);
            context.TemperatureDatas.Add(lTD_South_20160130);
            context.TemperatureDatas.Add(lTD_South_20160131);
            context.TemperatureDatas.Add(lTD_South_20160201);
            context.TemperatureDatas.Add(lTD_South_20160202);
            context.TemperatureDatas.Add(lTD_South_20160203);
            context.TemperatureDatas.Add(lTD_South_20160204);
            context.TemperatureDatas.Add(lTD_South_20160205);
            context.TemperatureDatas.Add(lTD_South_20160206);
            context.TemperatureDatas.Add(lTD_South_20160207);
            context.TemperatureDatas.Add(lTD_South_20160208);
            context.TemperatureDatas.Add(lTD_South_20160209);
            context.TemperatureDatas.Add(lTD_South_20160210);

#if false
            
            context.TemperatureDatas.Add(lTD_South_20160211);
            context.TemperatureDatas.Add(lTD_South_20160212);
            context.TemperatureDatas.Add(lTD_South_20160213);
            context.TemperatureDatas.Add(lTD_South_20160214);
            context.TemperatureDatas.Add(lTD_South_20160215);
            context.TemperatureDatas.Add(lTD_South_20160216);
            context.TemperatureDatas.Add(lTD_South_20160217);
            context.TemperatureDatas.Add(lTD_South_20160218);
            context.TemperatureDatas.Add(lTD_South_20160219);
            context.TemperatureDatas.Add(lTD_South_20160220);
            context.TemperatureDatas.Add(lTD_South_20160221);
            context.TemperatureDatas.Add(lTD_South_20160222);
            context.TemperatureDatas.Add(lTD_South_20160223);
            context.TemperatureDatas.Add(lTD_South_20160224);
            context.TemperatureDatas.Add(lTD_South_20160225);
            context.TemperatureDatas.Add(lTD_South_20160226);
            context.TemperatureDatas.Add(lTD_South_20160227);
            context.TemperatureDatas.Add(lTD_South_20160228);
            context.TemperatureDatas.Add(lTD_South_20160229);
            context.TemperatureDatas.Add(lTD_South_20160301);
            context.TemperatureDatas.Add(lTD_South_20160302);
            context.TemperatureDatas.Add(lTD_South_20160303);
            context.TemperatureDatas.Add(lTD_South_20160304);
            context.TemperatureDatas.Add(lTD_South_20160305);
            context.TemperatureDatas.Add(lTD_South_20160306);
            context.TemperatureDatas.Add(lTD_South_20160307);
            context.TemperatureDatas.Add(lTD_South_20160308);
            context.TemperatureDatas.Add(lTD_South_20160309);
            context.TemperatureDatas.Add(lTD_South_20160310);
            context.TemperatureDatas.Add(lTD_South_20160311);
            context.TemperatureDatas.Add(lTD_South_20160312);
            context.TemperatureDatas.Add(lTD_South_20160313);
            context.TemperatureDatas.Add(lTD_South_20160314);
            context.TemperatureDatas.Add(lTD_South_20160315);
            context.TemperatureDatas.Add(lTD_South_20160316);
            context.TemperatureDatas.Add(lTD_South_20160317);
            context.TemperatureDatas.Add(lTD_South_20160318);
            context.TemperatureDatas.Add(lTD_South_20160319);
            context.TemperatureDatas.Add(lTD_South_20160320);
            context.TemperatureDatas.Add(lTD_South_20160321);
            context.TemperatureDatas.Add(lTD_South_20160322);
            context.TemperatureDatas.Add(lTD_South_20160323);
            context.TemperatureDatas.Add(lTD_South_20160324);
            context.TemperatureDatas.Add(lTD_South_20160325);
            context.TemperatureDatas.Add(lTD_South_20160326);
            context.TemperatureDatas.Add(lTD_South_20160327);
            context.TemperatureDatas.Add(lTD_South_20160328);
            context.TemperatureDatas.Add(lTD_South_20160329);
            context.TemperatureDatas.Add(lTD_South_20160330);
            context.TemperatureDatas.Add(lTD_South_20160331);
            context.TemperatureDatas.Add(lTD_South_20160401);
            context.TemperatureDatas.Add(lTD_South_20160402);
            context.TemperatureDatas.Add(lTD_South_20160403);
            context.TemperatureDatas.Add(lTD_South_20160404);
            context.TemperatureDatas.Add(lTD_South_20160405);
            context.TemperatureDatas.Add(lTD_South_20160406);
            context.TemperatureDatas.Add(lTD_South_20160407);
            context.TemperatureDatas.Add(lTD_South_20160408);
            context.TemperatureDatas.Add(lTD_South_20160409);
            context.TemperatureDatas.Add(lTD_South_20160410);
            context.TemperatureDatas.Add(lTD_South_20160411);
            context.TemperatureDatas.Add(lTD_South_20160412);
            context.TemperatureDatas.Add(lTD_South_20160413);
            context.TemperatureDatas.Add(lTD_South_20160414);
            context.TemperatureDatas.Add(lTD_South_20160415);
            context.TemperatureDatas.Add(lTD_South_20160416);
            context.TemperatureDatas.Add(lTD_South_20160417);
            context.TemperatureDatas.Add(lTD_South_20160418);
            context.TemperatureDatas.Add(lTD_South_20160419);
            context.TemperatureDatas.Add(lTD_South_20160420);
            context.TemperatureDatas.Add(lTD_South_20160421);
            context.TemperatureDatas.Add(lTD_South_20160422);
            context.TemperatureDatas.Add(lTD_South_20160423);
            context.TemperatureDatas.Add(lTD_South_20160424);
            context.TemperatureDatas.Add(lTD_South_20160425);
            context.TemperatureDatas.Add(lTD_South_20160426);
            context.TemperatureDatas.Add(lTD_South_20160427);
            context.TemperatureDatas.Add(lTD_South_20160428);
            context.TemperatureDatas.Add(lTD_South_20160429);
            context.TemperatureDatas.Add(lTD_South_20160430);
            context.TemperatureDatas.Add(lTD_South_20160501);
#endif

            #endregion


            #endregion

        }

        public static void DataTemperatures_North_2014(IrrigationAdvisorContext context, Region pRegion)
        {
            Region lRegion = pRegion;

            #region North

            #region 2014 new TemperatureData
            var lTD_North_20140901 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140901", Date = new DateTime(2014, 09, 01), RegionId = lRegion.RegionId, Min = 8.2, Max = 25.4, Average = 16.8, ETC = 3.2, Rain = 0.9, };
            var lTD_North_20140902 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140902", Date = new DateTime(2014, 09, 02), RegionId = lRegion.RegionId, Min = 12.6, Max = 20.1, Average = 16.4, ETC = 1.9, Rain = 0.7, };
            var lTD_North_20140903 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140903", Date = new DateTime(2014, 09, 03), RegionId = lRegion.RegionId, Min = 10.5, Max = 24.9, Average = 17.7, ETC = 3, Rain = 0, };
            var lTD_North_20140904 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140904", Date = new DateTime(2014, 09, 04), RegionId = lRegion.RegionId, Min = 14.3, Max = 20.9, Average = 17.6, ETC = 2.3, Rain = 2.9, };
            var lTD_North_20140905 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140905", Date = new DateTime(2014, 09, 05), RegionId = lRegion.RegionId, Min = 17.1, Max = 22, Average = 19.6, ETC = 1.9, Rain = 22.8, };
            var lTD_North_20140906 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140906", Date = new DateTime(2014, 09, 06), RegionId = lRegion.RegionId, Min = 10.5, Max = 20, Average = 15.3, ETC = 1.6, Rain = 0.7, };
            var lTD_North_20140907 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140907", Date = new DateTime(2014, 09, 07), RegionId = lRegion.RegionId, Min = 7.5, Max = 22.3, Average = 14.9, ETC = 2.6, Rain = 0, };
            var lTD_North_20140908 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140908", Date = new DateTime(2014, 09, 08), RegionId = lRegion.RegionId, Min = 10.5, Max = 27.5, Average = 19, ETC = 2.8, Rain = 0, };
            var lTD_North_20140909 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140909", Date = new DateTime(2014, 09, 09), RegionId = lRegion.RegionId, Min = 10.6, Max = 29.8, Average = 20.2, ETC = 3.1, Rain = 18.9, };
            var lTD_North_20140910 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140910", Date = new DateTime(2014, 09, 10), RegionId = lRegion.RegionId, Min = 8, Max = 16.6, Average = 12.3, ETC = 1.7, Rain = 0.2, };
            var lTD_North_20140911 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140911", Date = new DateTime(2014, 09, 11), RegionId = lRegion.RegionId, Min = 5, Max = 19.8, Average = 12.4, ETC = 3, Rain = 0, };
            var lTD_North_20140912 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140912", Date = new DateTime(2014, 09, 12), RegionId = lRegion.RegionId, Min = 11.4, Max = 14.2, Average = 12.8, ETC = 1.6, Rain = 0.5, };
            var lTD_North_20140913 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140913", Date = new DateTime(2014, 09, 13), RegionId = lRegion.RegionId, Min = 12, Max = 17.9, Average = 15, ETC = 1.2, Rain = 6.7, };
            var lTD_North_20140914 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140914", Date = new DateTime(2014, 09, 14), RegionId = lRegion.RegionId, Min = 15.9, Max = 18.5, Average = 17.2, ETC = 1.2, Rain = 15.7, };
            var lTD_North_20140915 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140915", Date = new DateTime(2014, 09, 15), RegionId = lRegion.RegionId, Min = 11.8, Max = 22.4, Average = 17.1, ETC = 3, Rain = 0, };
            var lTD_North_20140916 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140916", Date = new DateTime(2014, 09, 16), RegionId = lRegion.RegionId, Min = 6.5, Max = 21.7, Average = 14.1, ETC = 2.6, Rain = 0, };
            var lTD_North_20140917 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140917", Date = new DateTime(2014, 09, 17), RegionId = lRegion.RegionId, Min = 11, Max = 22.3, Average = 16.7, ETC = 2.6, Rain = 0, };
            var lTD_North_20140918 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140918", Date = new DateTime(2014, 09, 18), RegionId = lRegion.RegionId, Min = 11.2, Max = 20.4, Average = 15.8, ETC = 1.6, Rain = 0, };
            var lTD_North_20140919 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140919", Date = new DateTime(2014, 09, 19), RegionId = lRegion.RegionId, Min = 12.7, Max = 22.9, Average = 17.8, ETC = 2.6, Rain = 0, };
            var lTD_North_20140920 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140920", Date = new DateTime(2014, 09, 20), RegionId = lRegion.RegionId, Min = 11.6, Max = 24, Average = 17.8, ETC = 3.4, Rain = 0, };
            var lTD_North_20140921 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140921", Date = new DateTime(2014, 09, 21), RegionId = lRegion.RegionId, Min = 8, Max = 22.3, Average = 15.2, ETC = 3.3, Rain = 0, };
            var lTD_North_20140922 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140922", Date = new DateTime(2014, 09, 22), RegionId = lRegion.RegionId, Min = 9.5, Max = 24.8, Average = 17.2, ETC = 3.4, Rain = 0, };
            var lTD_North_20140923 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140923", Date = new DateTime(2014, 09, 23), RegionId = lRegion.RegionId, Min = 10.9, Max = 27.5, Average = 19.2, ETC = 3.5, Rain = 1.3, };
            var lTD_North_20140924 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140924", Date = new DateTime(2014, 09, 24), RegionId = lRegion.RegionId, Min = 10.8, Max = 22.8, Average = 16.8, ETC = 3.9, Rain = 0, };
            var lTD_North_20140925 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140925", Date = new DateTime(2014, 09, 25), RegionId = lRegion.RegionId, Min = 14.6, Max = 26.9, Average = 20.8, ETC = 3.2, Rain = 1.2, };
            var lTD_North_20140926 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140926", Date = new DateTime(2014, 09, 26), RegionId = lRegion.RegionId, Min = 10.9, Max = 19.3, Average = 15.1, ETC = 3.6, Rain = 0, };
            var lTD_North_20140927 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140927", Date = new DateTime(2014, 09, 27), RegionId = lRegion.RegionId, Min = 9.7, Max = 23.4, Average = 16.6, ETC = 4.7, Rain = 0, };
            var lTD_North_20140928 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140928", Date = new DateTime(2014, 09, 28), RegionId = lRegion.RegionId, Min = 13, Max = 22.6, Average = 17.8, ETC = 1.9, Rain = 3.2, };
            var lTD_North_20140929 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140929", Date = new DateTime(2014, 09, 29), RegionId = lRegion.RegionId, Min = 15.8, Max = 25.3, Average = 20.6, ETC = 4, Rain = 0, };
            var lTD_North_20140930 = new TemperatureData { Name = Utils.NameRegionNorth + "-20140930", Date = new DateTime(2014, 09, 30), RegionId = lRegion.RegionId, Min = 13.5, Max = 20.3, Average = 16.9, ETC = 2.4, Rain = 0, };
            var lTD_North_20141001 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141001", Date = new DateTime(2014, 10, 01), RegionId = lRegion.RegionId, Min = 10.7, Max = 23.8, Average = 17.3, ETC = 4.4, Rain = 0, };
            var lTD_North_20141002 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141002", Date = new DateTime(2014, 10, 02), RegionId = lRegion.RegionId, Min = 11.1, Max = 22.6, Average = 16.9, ETC = 4.9, Rain = 0, };
            var lTD_North_20141003 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141003", Date = new DateTime(2014, 10, 03), RegionId = lRegion.RegionId, Min = 13.5, Max = 21, Average = 17.3, ETC = 3.6, Rain = 0, };
            var lTD_North_20141004 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141004", Date = new DateTime(2014, 10, 04), RegionId = lRegion.RegionId, Min = 16, Max = 22.6, Average = 19.3, ETC = 4.5, Rain = 15.9, };
            var lTD_North_20141005 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141005", Date = new DateTime(2014, 10, 05), RegionId = lRegion.RegionId, Min = 16, Max = 19.1, Average = 17.6, ETC = 1.6, Rain = 29.1, };
            var lTD_North_20141006 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141006", Date = new DateTime(2014, 10, 06), RegionId = lRegion.RegionId, Min = 15.2, Max = 26.5, Average = 20.9, ETC = 3.6, Rain = 0.7, };
            var lTD_North_20141007 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141007", Date = new DateTime(2014, 10, 07), RegionId = lRegion.RegionId, Min = 13.9, Max = 24.5, Average = 19.2, ETC = 3, Rain = 0, };
            var lTD_North_20141008 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141008", Date = new DateTime(2014, 10, 08), RegionId = lRegion.RegionId, Min = 14.7, Max = 29.1, Average = 21.9, ETC = 4.6, Rain = 11.6, };
            var lTD_North_20141009 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141009", Date = new DateTime(2014, 10, 09), RegionId = lRegion.RegionId, Min = 18.6, Max = 30.4, Average = 24.5, ETC = 4.4, Rain = 40.5, };
            var lTD_North_20141010 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141010", Date = new DateTime(2014, 10, 10), RegionId = lRegion.RegionId, Min = 10.4, Max = 16.6, Average = 13.5, ETC = 2.2, Rain = 2, };
            var lTD_North_20141011 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141011", Date = new DateTime(2014, 10, 11), RegionId = lRegion.RegionId, Min = 10, Max = 20.1, Average = 15.1, ETC = 3.2, Rain = 0, };
            var lTD_North_20141012 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141012", Date = new DateTime(2014, 10, 12), RegionId = lRegion.RegionId, Min = 14.9, Max = 22.4, Average = 18.7, ETC = 2.4, Rain = 0, };
            var lTD_North_20141013 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141013", Date = new DateTime(2014, 10, 13), RegionId = lRegion.RegionId, Min = 10.7, Max = 24.6, Average = 17.7, ETC = 4.1, Rain = 0, };
            var lTD_North_20141014 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141014", Date = new DateTime(2014, 10, 14), RegionId = lRegion.RegionId, Min = 12, Max = 26.6, Average = 19.3, ETC = 4.7, Rain = 0, };
            var lTD_North_20141015 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141015", Date = new DateTime(2014, 10, 15), RegionId = lRegion.RegionId, Min = 15, Max = 26.5, Average = 20.8, ETC = 3.8, Rain = 0, };
            var lTD_North_20141016 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141016", Date = new DateTime(2014, 10, 16), RegionId = lRegion.RegionId, Min = 21.8, Max = 30.2, Average = 26, ETC = 5.2, Rain = 0, };
            var lTD_North_20141017 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141017", Date = new DateTime(2014, 10, 17), RegionId = lRegion.RegionId, Min = 20.4, Max = 28.6, Average = 24.5, ETC = 4, Rain = 0, };
            var lTD_North_20141018 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141018", Date = new DateTime(2014, 10, 18), RegionId = lRegion.RegionId, Min = 19, Max = 24.9, Average = 22, ETC = 2.2, Rain = 14, };
            var lTD_North_20141019 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141019", Date = new DateTime(2014, 10, 19), RegionId = lRegion.RegionId, Min = 14.8, Max = 24.4, Average = 19.6, ETC = 3.3, Rain = 0, };
            var lTD_North_20141020 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141020", Date = new DateTime(2014, 10, 20), RegionId = lRegion.RegionId, Min = 10.5, Max = 25.4, Average = 18, ETC = 4.5, Rain = 0, };
            var lTD_North_20141021 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141021", Date = new DateTime(2014, 10, 21), RegionId = lRegion.RegionId, Min = 12.3, Max = 27.7, Average = 20, ETC = 5.1, Rain = 0, };
            var lTD_North_20141022 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141022", Date = new DateTime(2014, 10, 22), RegionId = lRegion.RegionId, Min = 14, Max = 30.1, Average = 22.1, ETC = 5.3, Rain = 0, };
            var lTD_North_20141023 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141023", Date = new DateTime(2014, 10, 23), RegionId = lRegion.RegionId, Min = 14.5, Max = 31.2, Average = 22.9, ETC = 4.4, Rain = 0, };
            var lTD_North_20141024 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141024", Date = new DateTime(2014, 10, 24), RegionId = lRegion.RegionId, Min = 16, Max = 29.7, Average = 22.9, ETC = 4.9, Rain = 0, };
            var lTD_North_20141025 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141025", Date = new DateTime(2014, 10, 25), RegionId = lRegion.RegionId, Min = 15.2, Max = 31, Average = 23.1, ETC = 5.2, Rain = 0, };
            var lTD_North_20141026 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141026", Date = new DateTime(2014, 10, 26), RegionId = lRegion.RegionId, Min = 18.2, Max = 32.7, Average = 25.5, ETC = 6, Rain = 0, };
            var lTD_North_20141027 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141027", Date = new DateTime(2014, 10, 27), RegionId = lRegion.RegionId, Min = 18.1, Max = 34.5, Average = 26.3, ETC = 6.3, Rain = 0, };
            var lTD_North_20141028 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141028", Date = new DateTime(2014, 10, 28), RegionId = lRegion.RegionId, Min = 23.3, Max = 36.4, Average = 29.9, ETC = 6.7, Rain = 0.4, };
            var lTD_North_20141029 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141029", Date = new DateTime(2014, 10, 29), RegionId = lRegion.RegionId, Min = 19.8, Max = 32.9, Average = 26.4, ETC = 3.4, Rain = 23, };
            var lTD_North_20141030 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141030", Date = new DateTime(2014, 10, 30), RegionId = lRegion.RegionId, Min = 18.4, Max = 26.8, Average = 22.6, ETC = 3.4, Rain = 1.6, };
            var lTD_North_20141031 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141031", Date = new DateTime(2014, 10, 31), RegionId = lRegion.RegionId, Min = 18.3, Max = 22.3, Average = 20.3, ETC = 2.1, Rain = 0, };
            var lTD_North_20141101 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141101", Date = new DateTime(2014, 11, 01), RegionId = lRegion.RegionId, Min = 16.4, Max = 21, Average = 18.7, ETC = 2.8, Rain = 2.5, };
            var lTD_North_20141102 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141102", Date = new DateTime(2014, 11, 02), RegionId = lRegion.RegionId, Min = 16.8, Max = 21.8, Average = 19.3, ETC = 2.4, Rain = 8, };
            var lTD_North_20141103 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141103", Date = new DateTime(2014, 11, 03), RegionId = lRegion.RegionId, Min = 16.5, Max = 22.9, Average = 19.7, ETC = 2, Rain = 14.8, };
            var lTD_North_20141104 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141104", Date = new DateTime(2014, 11, 04), RegionId = lRegion.RegionId, Min = 11.8, Max = 22.8, Average = 17.3, ETC = 4.6, Rain = 0, };
            var lTD_North_20141105 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141105", Date = new DateTime(2014, 11, 05), RegionId = lRegion.RegionId, Min = 9.7, Max = 24.9, Average = 17.3, ETC = 5.2, Rain = 0, };
            var lTD_North_20141106 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141106", Date = new DateTime(2014, 11, 06), RegionId = lRegion.RegionId, Min = 13, Max = 28.7, Average = 20.9, ETC = 4.8, Rain = 0, };
            var lTD_North_20141107 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141107", Date = new DateTime(2014, 11, 07), RegionId = lRegion.RegionId, Min = 17.9, Max = 30.6, Average = 24.3, ETC = 5.4, Rain = 0, };
            var lTD_North_20141108 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141108", Date = new DateTime(2014, 11, 08), RegionId = lRegion.RegionId, Min = 16.5, Max = 31.2, Average = 23.9, ETC = 5.5, Rain = 0, };
            var lTD_North_20141109 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141109", Date = new DateTime(2014, 11, 09), RegionId = lRegion.RegionId, Min = 17.3, Max = 33.1, Average = 25.2, ETC = 5.9, Rain = 0, };
            var lTD_North_20141110 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141110", Date = new DateTime(2014, 11, 10), RegionId = lRegion.RegionId, Min = 20.8, Max = 32.9, Average = 26.9, ETC = 6.1, Rain = 0, };
            var lTD_North_20141111 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141111", Date = new DateTime(2014, 11, 11), RegionId = lRegion.RegionId, Min = 20, Max = 30, Average = 25, ETC = 4.2, Rain = 5.7, };
            var lTD_North_20141112 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141112", Date = new DateTime(2014, 11, 12), RegionId = lRegion.RegionId, Min = 17.1, Max = 26.8, Average = 22, ETC = 4.8, Rain = 0, };
            var lTD_North_20141113 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141113", Date = new DateTime(2014, 11, 13), RegionId = lRegion.RegionId, Min = 10, Max = 23, Average = 16.5, ETC = 4.5, Rain = 0, };
            var lTD_North_20141114 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141114", Date = new DateTime(2014, 11, 14), RegionId = lRegion.RegionId, Min = 9.8, Max = 25.9, Average = 17.9, ETC = 4.8, Rain = 0, };
            var lTD_North_20141115 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141115", Date = new DateTime(2014, 11, 15), RegionId = lRegion.RegionId, Min = 14.2, Max = 29.7, Average = 22, ETC = 5.4, Rain = 0, };
            var lTD_North_20141116 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141116", Date = new DateTime(2014, 11, 16), RegionId = lRegion.RegionId, Min = 14, Max = 32.2, Average = 23.1, ETC = 5.7, Rain = 0, };
            var lTD_North_20141117 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141117", Date = new DateTime(2014, 11, 17), RegionId = lRegion.RegionId, Min = 17.7, Max = 31.9, Average = 24.8, ETC = 6.8, Rain = 0, };
            var lTD_North_20141118 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141118", Date = new DateTime(2014, 11, 18), RegionId = lRegion.RegionId, Min = 18.7, Max = 32.9, Average = 25.8, ETC = 6.5, Rain = 0, };
            var lTD_North_20141119 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141119", Date = new DateTime(2014, 11, 19), RegionId = lRegion.RegionId, Min = 19.8, Max = 28, Average = 23.9, ETC = 4.2, Rain = 1.5, };
            var lTD_North_20141120 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141120", Date = new DateTime(2014, 11, 20), RegionId = lRegion.RegionId, Min = 16.9, Max = 26.3, Average = 21.6, ETC = 3.6, Rain = 20.6, };
            var lTD_North_20141121 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141121", Date = new DateTime(2014, 11, 21), RegionId = lRegion.RegionId, Min = 17.1, Max = 20.6, Average = 18.9, ETC = 2, Rain = 25, };
            var lTD_North_20141122 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141122", Date = new DateTime(2014, 11, 22), RegionId = lRegion.RegionId, Min = 14.6, Max = 24.6, Average = 19.6, ETC = 4.5, Rain = 0, };
            var lTD_North_20141123 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141123", Date = new DateTime(2014, 11, 23), RegionId = lRegion.RegionId, Min = 13.2, Max = 27.7, Average = 20.5, ETC = 5.7, Rain = 0, };
            var lTD_North_20141124 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141124", Date = new DateTime(2014, 11, 24), RegionId = lRegion.RegionId, Min = 16.1, Max = 30.9, Average = 23.5, ETC = 4.8, Rain = 11.8, };
            var lTD_North_20141125 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141125", Date = new DateTime(2014, 11, 25), RegionId = lRegion.RegionId, Min = 18.6, Max = 26.1, Average = 22.4, ETC = 3.7, Rain = 0, };
            var lTD_North_20141126 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141126", Date = new DateTime(2014, 11, 26), RegionId = lRegion.RegionId, Min = 15.8, Max = 26.8, Average = 21.3, ETC = 4.5, Rain = 0, };
            var lTD_North_20141127 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141127", Date = new DateTime(2014, 11, 27), RegionId = lRegion.RegionId, Min = 13.5, Max = 28.1, Average = 20.8, ETC = 6, Rain = 0, };
            var lTD_North_20141128 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141128", Date = new DateTime(2014, 11, 28), RegionId = lRegion.RegionId, Min = 17.6, Max = 30, Average = 23.8, ETC = 6.4, Rain = 0, };
            var lTD_North_20141129 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141129", Date = new DateTime(2014, 11, 29), RegionId = lRegion.RegionId, Min = 20, Max = 35, Average = 27.5, ETC = 7.3, Rain = 29.5, };
            var lTD_North_20141130 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141130", Date = new DateTime(2014, 11, 30), RegionId = lRegion.RegionId, Min = 18.4, Max = 29.4, Average = 23.9, ETC = 2, Rain = 30.3, };
            var lTD_North_20141201 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141201", Date = new DateTime(2014, 12, 01), RegionId = lRegion.RegionId, Min = 17, Max = 20.3, Average = 18.7, ETC = 1.8, Rain = 12.5, };
            var lTD_North_20141202 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141202", Date = new DateTime(2014, 12, 02), RegionId = lRegion.RegionId, Min = 16.8, Max = 22.5, Average = 19.7, ETC = 2.4, Rain = 0, };
            var lTD_North_20141203 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141203", Date = new DateTime(2014, 12, 03), RegionId = lRegion.RegionId, Min = 12.5, Max = 29.1, Average = 20.8, ETC = 5.4, Rain = 0, };
            var lTD_North_20141204 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141204", Date = new DateTime(2014, 12, 04), RegionId = lRegion.RegionId, Min = 14.2, Max = 30.9, Average = 22.6, ETC = 6.5, Rain = 0, };
            var lTD_North_20141205 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141205", Date = new DateTime(2014, 12, 05), RegionId = lRegion.RegionId, Min = 17.1, Max = 32.1, Average = 24.6, ETC = 6.8, Rain = 0, };
            var lTD_North_20141206 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141206", Date = new DateTime(2014, 12, 06), RegionId = lRegion.RegionId, Min = 19.5, Max = 33.1, Average = 26.3, ETC = 7.1, Rain = 0, };
            var lTD_North_20141207 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141207", Date = new DateTime(2014, 12, 07), RegionId = lRegion.RegionId, Min = 22.3, Max = 33.8, Average = 28.1, ETC = 5.3, Rain = 5.8, };
            var lTD_North_20141208 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141208", Date = new DateTime(2014, 12, 08), RegionId = lRegion.RegionId, Min = 20, Max = 29, Average = 24.5, ETC = 3.3, Rain = 12.5, };
            var lTD_North_20141209 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141209", Date = new DateTime(2014, 12, 09), RegionId = lRegion.RegionId, Min = 22.8, Max = 33.2, Average = 28, ETC = 6.8, Rain = 19.3, };
            var lTD_North_20141210 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141210", Date = new DateTime(2014, 12, 10), RegionId = lRegion.RegionId, Min = 17.9, Max = 28, Average = 23, ETC = 4, Rain = 0, };
            var lTD_North_20141211 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141211", Date = new DateTime(2014, 12, 11), RegionId = lRegion.RegionId, Min = 15.9, Max = 27.3, Average = 21.6, ETC = 5.6, Rain = 0, };
            var lTD_North_20141212 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141212", Date = new DateTime(2014, 12, 12), RegionId = lRegion.RegionId, Min = 17.6, Max = 26.5, Average = 22.1, ETC = 3.1, Rain = 0, };
            var lTD_North_20141213 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141213", Date = new DateTime(2014, 12, 13), RegionId = lRegion.RegionId, Min = 17, Max = 29.7, Average = 23.4, ETC = 6.1, Rain = 0, };
            var lTD_North_20141214 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141214", Date = new DateTime(2014, 12, 14), RegionId = lRegion.RegionId, Min = 17.6, Max = 29.1, Average = 23.4, ETC = 5.9, Rain = 0, };
            var lTD_North_20141215 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141215", Date = new DateTime(2014, 12, 15), RegionId = lRegion.RegionId, Min = 16.6, Max = 28.4, Average = 22.5, ETC = 4.8, Rain = 5.9, };
            var lTD_North_20141216 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141216", Date = new DateTime(2014, 12, 16), RegionId = lRegion.RegionId, Min = 18.5, Max = 22.5, Average = 20.5, ETC = 2.2, Rain = 11.8, };
            var lTD_North_20141217 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141217", Date = new DateTime(2014, 12, 17), RegionId = lRegion.RegionId, Min = 19, Max = 30.1, Average = 24.6, ETC = 5.3, Rain = 0, };
            var lTD_North_20141218 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141218", Date = new DateTime(2014, 12, 18), RegionId = lRegion.RegionId, Min = 17.7, Max = 31.6, Average = 24.7, ETC = 5.9, Rain = 0, };
            var lTD_North_20141219 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141219", Date = new DateTime(2014, 12, 19), RegionId = lRegion.RegionId, Min = 17.5, Max = 31.4, Average = 24.5, ETC = 6.9, Rain = 0, };
            var lTD_North_20141220 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141220", Date = new DateTime(2014, 12, 20), RegionId = lRegion.RegionId, Min = 19.3, Max = 29.5, Average = 24.4, ETC = 3.1, Rain = 49.9, };
            var lTD_North_20141221 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141221", Date = new DateTime(2014, 12, 21), RegionId = lRegion.RegionId, Min = 15.8, Max = 22.5, Average = 19.2, ETC = 3.2, Rain = 0, };
            var lTD_North_20141222 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141222", Date = new DateTime(2014, 12, 22), RegionId = lRegion.RegionId, Min = 15.2, Max = 25.2, Average = 20.2, ETC = 5.9, Rain = 0, };
            var lTD_North_20141223 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141223", Date = new DateTime(2014, 12, 23), RegionId = lRegion.RegionId, Min = 10.3, Max = 25.1, Average = 17.7, ETC = 5.6, Rain = 0, };
            var lTD_North_20141224 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141224", Date = new DateTime(2014, 12, 24), RegionId = lRegion.RegionId, Min = 14.2, Max = 28.2, Average = 21.2, ETC = 5.6, Rain = 0, };
            var lTD_North_20141225 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141225", Date = new DateTime(2014, 12, 25), RegionId = lRegion.RegionId, Min = 18.1, Max = 29.2, Average = 23.7, ETC = 4.3, Rain = 2.1, };
            var lTD_North_20141226 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141226", Date = new DateTime(2014, 12, 26), RegionId = lRegion.RegionId, Min = 21.8, Max = 29.9, Average = 25.9, ETC = 3, Rain = 44.6, };
            var lTD_North_20141227 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141227", Date = new DateTime(2014, 12, 27), RegionId = lRegion.RegionId, Min = 20.6, Max = 28.8, Average = 24.7, ETC = 3.8, Rain = 0, };
            var lTD_North_20141228 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141228", Date = new DateTime(2014, 12, 28), RegionId = lRegion.RegionId, Min = 22.4, Max = 28.4, Average = 25.4, ETC = 2.8, Rain = 0, };
            var lTD_North_20141229 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141229", Date = new DateTime(2014, 12, 29), RegionId = lRegion.RegionId, Min = 21.7, Max = 31.3, Average = 26.5, ETC = 6.1, Rain = 0, };
            var lTD_North_20141230 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141230", Date = new DateTime(2014, 12, 30), RegionId = lRegion.RegionId, Min = 22.6, Max = 29.8, Average = 26.2, ETC = 3.4, Rain = 0, };
            var lTD_North_20141231 = new TemperatureData { Name = Utils.NameRegionNorth + "-20141231", Date = new DateTime(2014, 12, 31), RegionId = lRegion.RegionId, Min = 22.2, Max = 32.7, Average = 27.5, ETC = 6.4, Rain = 0, };
            #endregion

            #region 2014 context Add
            context.TemperatureDatas.Add(lTD_North_20140901);
            context.TemperatureDatas.Add(lTD_North_20140902);
            context.TemperatureDatas.Add(lTD_North_20140903);
            context.TemperatureDatas.Add(lTD_North_20140904);
            context.TemperatureDatas.Add(lTD_North_20140905);
            context.TemperatureDatas.Add(lTD_North_20140906);
            context.TemperatureDatas.Add(lTD_North_20140907);
            context.TemperatureDatas.Add(lTD_North_20140908);
            context.TemperatureDatas.Add(lTD_North_20140909);
            context.TemperatureDatas.Add(lTD_North_20140910);
            context.TemperatureDatas.Add(lTD_North_20140911);
            context.TemperatureDatas.Add(lTD_North_20140912);
            context.TemperatureDatas.Add(lTD_North_20140913);
            context.TemperatureDatas.Add(lTD_North_20140914);
            context.TemperatureDatas.Add(lTD_North_20140915);
            context.TemperatureDatas.Add(lTD_North_20140916);
            context.TemperatureDatas.Add(lTD_North_20140917);
            context.TemperatureDatas.Add(lTD_North_20140918);
            context.TemperatureDatas.Add(lTD_North_20140919);
            context.TemperatureDatas.Add(lTD_North_20140920);
            context.TemperatureDatas.Add(lTD_North_20140921);
            context.TemperatureDatas.Add(lTD_North_20140922);
            context.TemperatureDatas.Add(lTD_North_20140923);
            context.TemperatureDatas.Add(lTD_North_20140924);
            context.TemperatureDatas.Add(lTD_North_20140925);
            context.TemperatureDatas.Add(lTD_North_20140926);
            context.TemperatureDatas.Add(lTD_North_20140927);
            context.TemperatureDatas.Add(lTD_North_20140928);
            context.TemperatureDatas.Add(lTD_North_20140929);
            context.TemperatureDatas.Add(lTD_North_20140930);
            context.TemperatureDatas.Add(lTD_North_20141001);
            context.TemperatureDatas.Add(lTD_North_20141002);
            context.TemperatureDatas.Add(lTD_North_20141003);
            context.TemperatureDatas.Add(lTD_North_20141004);
            context.TemperatureDatas.Add(lTD_North_20141005);
            context.TemperatureDatas.Add(lTD_North_20141006);
            context.TemperatureDatas.Add(lTD_North_20141007);
            context.TemperatureDatas.Add(lTD_North_20141008);
            context.TemperatureDatas.Add(lTD_North_20141009);
            context.TemperatureDatas.Add(lTD_North_20141010);
            context.TemperatureDatas.Add(lTD_North_20141011);
            context.TemperatureDatas.Add(lTD_North_20141012);
            context.TemperatureDatas.Add(lTD_North_20141013);
            context.TemperatureDatas.Add(lTD_North_20141014);
            context.TemperatureDatas.Add(lTD_North_20141015);
            context.TemperatureDatas.Add(lTD_North_20141016);
            context.TemperatureDatas.Add(lTD_North_20141017);
            context.TemperatureDatas.Add(lTD_North_20141018);
            context.TemperatureDatas.Add(lTD_North_20141019);
            context.TemperatureDatas.Add(lTD_North_20141020);
            context.TemperatureDatas.Add(lTD_North_20141021);
            context.TemperatureDatas.Add(lTD_North_20141022);
            context.TemperatureDatas.Add(lTD_North_20141023);
            context.TemperatureDatas.Add(lTD_North_20141024);
            context.TemperatureDatas.Add(lTD_North_20141025);
            context.TemperatureDatas.Add(lTD_North_20141026);
            context.TemperatureDatas.Add(lTD_North_20141027);
            context.TemperatureDatas.Add(lTD_North_20141028);
            context.TemperatureDatas.Add(lTD_North_20141029);
            context.TemperatureDatas.Add(lTD_North_20141030);
            context.TemperatureDatas.Add(lTD_North_20141031);
            context.TemperatureDatas.Add(lTD_North_20141101);
            context.TemperatureDatas.Add(lTD_North_20141102);
            context.TemperatureDatas.Add(lTD_North_20141103);
            context.TemperatureDatas.Add(lTD_North_20141104);
            context.TemperatureDatas.Add(lTD_North_20141105);
            context.TemperatureDatas.Add(lTD_North_20141106);
            context.TemperatureDatas.Add(lTD_North_20141107);
            context.TemperatureDatas.Add(lTD_North_20141108);
            context.TemperatureDatas.Add(lTD_North_20141109);
            context.TemperatureDatas.Add(lTD_North_20141110);
            context.TemperatureDatas.Add(lTD_North_20141111);
            context.TemperatureDatas.Add(lTD_North_20141112);
            context.TemperatureDatas.Add(lTD_North_20141113);
            context.TemperatureDatas.Add(lTD_North_20141114);
            context.TemperatureDatas.Add(lTD_North_20141115);
            context.TemperatureDatas.Add(lTD_North_20141116);
            context.TemperatureDatas.Add(lTD_North_20141117);
            context.TemperatureDatas.Add(lTD_North_20141118);
            context.TemperatureDatas.Add(lTD_North_20141119);
            context.TemperatureDatas.Add(lTD_North_20141120);
            context.TemperatureDatas.Add(lTD_North_20141121);
            context.TemperatureDatas.Add(lTD_North_20141122);
            context.TemperatureDatas.Add(lTD_North_20141123);
            context.TemperatureDatas.Add(lTD_North_20141124);
            context.TemperatureDatas.Add(lTD_North_20141125);
            context.TemperatureDatas.Add(lTD_North_20141126);
            context.TemperatureDatas.Add(lTD_North_20141127);
            context.TemperatureDatas.Add(lTD_North_20141128);
            context.TemperatureDatas.Add(lTD_North_20141129);
            context.TemperatureDatas.Add(lTD_North_20141130);
            context.TemperatureDatas.Add(lTD_North_20141201);
            context.TemperatureDatas.Add(lTD_North_20141202);
            context.TemperatureDatas.Add(lTD_North_20141203);
            context.TemperatureDatas.Add(lTD_North_20141204);
            context.TemperatureDatas.Add(lTD_North_20141205);
            context.TemperatureDatas.Add(lTD_North_20141206);
            context.TemperatureDatas.Add(lTD_North_20141207);
            context.TemperatureDatas.Add(lTD_North_20141208);
            context.TemperatureDatas.Add(lTD_North_20141209);
            context.TemperatureDatas.Add(lTD_North_20141210);
            context.TemperatureDatas.Add(lTD_North_20141211);
            context.TemperatureDatas.Add(lTD_North_20141212);
            context.TemperatureDatas.Add(lTD_North_20141213);
            context.TemperatureDatas.Add(lTD_North_20141214);
            context.TemperatureDatas.Add(lTD_North_20141215);
            context.TemperatureDatas.Add(lTD_North_20141216);
            context.TemperatureDatas.Add(lTD_North_20141217);
            context.TemperatureDatas.Add(lTD_North_20141218);
            context.TemperatureDatas.Add(lTD_North_20141219);
            context.TemperatureDatas.Add(lTD_North_20141220);
            context.TemperatureDatas.Add(lTD_North_20141221);
            context.TemperatureDatas.Add(lTD_North_20141222);
            context.TemperatureDatas.Add(lTD_North_20141223);
            context.TemperatureDatas.Add(lTD_North_20141224);
            context.TemperatureDatas.Add(lTD_North_20141225);
            context.TemperatureDatas.Add(lTD_North_20141226);
            context.TemperatureDatas.Add(lTD_North_20141227);
            context.TemperatureDatas.Add(lTD_North_20141228);
            context.TemperatureDatas.Add(lTD_North_20141229);
            context.TemperatureDatas.Add(lTD_North_20141230);
            context.TemperatureDatas.Add(lTD_North_20141231);
            #endregion

            #endregion

        }

        public static void DataTemperatures_North_2015(IrrigationAdvisorContext context, Region pRegion)
        {
            Region lRegion = pRegion;

            #region North

            #region 2015 new TemperatureData
            var lTD_North_20150101 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150101", Date = new DateTime(2015, 01, 01), RegionId = lRegion.RegionId, Min = 15.1, Max = 29.8, Average = 22.5, ETC = 3.9, Rain = 1.1, };
            var lTD_North_20150102 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150102", Date = new DateTime(2015, 01, 02), RegionId = lRegion.RegionId, Min = 13.7, Max = 26, Average = 19.9, ETC = 5.5, Rain = 0, };
            var lTD_North_20150103 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150103", Date = new DateTime(2015, 01, 03), RegionId = lRegion.RegionId, Min = 13.2, Max = 28.7, Average = 21, ETC = 5.6, Rain = 0, };
            var lTD_North_20150104 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150104", Date = new DateTime(2015, 01, 04), RegionId = lRegion.RegionId, Min = 14, Max = 31.8, Average = 22.9, ETC = 5.9, Rain = 0, };
            var lTD_North_20150105 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150105", Date = new DateTime(2015, 01, 05), RegionId = lRegion.RegionId, Min = 18.1, Max = 33.2, Average = 25.7, ETC = 7, Rain = 0, };
            var lTD_North_20150106 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150106", Date = new DateTime(2015, 01, 06), RegionId = lRegion.RegionId, Min = 20, Max = 34.9, Average = 27.5, ETC = 5.6, Rain = 33, };
            var lTD_North_20150107 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150107", Date = new DateTime(2015, 01, 07), RegionId = lRegion.RegionId, Min = 19.7, Max = 26.9, Average = 23.3, ETC = 2.4, Rain = 0.1, };
            var lTD_North_20150108 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150108", Date = new DateTime(2015, 01, 08), RegionId = lRegion.RegionId, Min = 20.2, Max = 30.3, Average = 25.3, ETC = 4.1, Rain = 0, };
            var lTD_North_20150109 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150109", Date = new DateTime(2015, 01, 09), RegionId = lRegion.RegionId, Min = 24, Max = 31, Average = 27.5, ETC = 3.1, Rain = 22.9, };
            var lTD_North_20150110 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150110", Date = new DateTime(2015, 01, 10), RegionId = lRegion.RegionId, Min = 23.2, Max = 32.2, Average = 27.7, ETC = 6.3, Rain = 34.5, };
            var lTD_North_20150111 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150111", Date = new DateTime(2015, 01, 11), RegionId = lRegion.RegionId, Min = 21, Max = 28, Average = 24.5, ETC = 2.7, Rain = 1, };
            var lTD_North_20150112 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150112", Date = new DateTime(2015, 01, 12), RegionId = lRegion.RegionId, Min = 21.7, Max = 32.3, Average = 27, ETC = 6.6, Rain = 0, };
            var lTD_North_20150113 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150113", Date = new DateTime(2015, 01, 13), RegionId = lRegion.RegionId, Min = 21.2, Max = 29.2, Average = 25.2, ETC = 2.8, Rain = 26.4, };
            var lTD_North_20150114 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150114", Date = new DateTime(2015, 01, 14), RegionId = lRegion.RegionId, Min = 22.1, Max = 29.6, Average = 25.9, ETC = 3.5, Rain = 0.1, };
            var lTD_North_20150115 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150115", Date = new DateTime(2015, 01, 15), RegionId = lRegion.RegionId, Min = 21.2, Max = 28.6, Average = 24.9, ETC = 3.9, Rain = 0, };
            var lTD_North_20150116 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150116", Date = new DateTime(2015, 01, 16), RegionId = lRegion.RegionId, Min = 21.5, Max = 30, Average = 25.8, ETC = 5.8, Rain = 0, };
            var lTD_North_20150117 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150117", Date = new DateTime(2015, 01, 17), RegionId = lRegion.RegionId, Min = 21.4, Max = 32.6, Average = 27, ETC = 6.5, Rain = 0, };
            var lTD_North_20150118 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150118", Date = new DateTime(2015, 01, 18), RegionId = lRegion.RegionId, Min = 20.6, Max = 33, Average = 26.8, ETC = 5.5, Rain = 23.8, };
            var lTD_North_20150119 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150119", Date = new DateTime(2015, 01, 19), RegionId = lRegion.RegionId, Min = 20, Max = 32.3, Average = 26.2, ETC = 4.5, Rain = 27.8, };
            var lTD_North_20150120 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150120", Date = new DateTime(2015, 01, 20), RegionId = lRegion.RegionId, Min = 20.8, Max = 25.9, Average = 23.4, ETC = 2.9, Rain = 0, };
            var lTD_North_20150121 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150121", Date = new DateTime(2015, 01, 21), RegionId = lRegion.RegionId, Min = 17.9, Max = 28.1, Average = 23, ETC = 6.1, Rain = 0, };
            var lTD_North_20150122 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150122", Date = new DateTime(2015, 01, 22), RegionId = lRegion.RegionId, Min = 17.8, Max = 28.6, Average = 23.2, ETC = 6.3, Rain = 0, };
            var lTD_North_20150123 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150123", Date = new DateTime(2015, 01, 23), RegionId = lRegion.RegionId, Min = 18.2, Max = 32.2, Average = 25.2, ETC = 5.7, Rain = 0, };
            var lTD_North_20150124 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150124", Date = new DateTime(2015, 01, 24), RegionId = lRegion.RegionId, Min = 22.1, Max = 32.6, Average = 27.4, ETC = 5.8, Rain = 0, };
            var lTD_North_20150125 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150125", Date = new DateTime(2015, 01, 25), RegionId = lRegion.RegionId, Min = 25.8, Max = 33.3, Average = 29.6, ETC = 5.6, Rain = 0, };
            var lTD_North_20150126 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150126", Date = new DateTime(2015, 01, 26), RegionId = lRegion.RegionId, Min = 23.1, Max = 34.2, Average = 28.7, ETC = 6.4, Rain = 0, };
            var lTD_North_20150127 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150127", Date = new DateTime(2015, 01, 27), RegionId = lRegion.RegionId, Min = 24.9, Max = 35.1, Average = 30, ETC = 6.8, Rain = 0, };
            var lTD_North_20150128 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150128", Date = new DateTime(2015, 01, 28), RegionId = lRegion.RegionId, Min = 19.9, Max = 29.4, Average = 24.7, ETC = 3.1, Rain = 28.1, };
            var lTD_North_20150129 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150129", Date = new DateTime(2015, 01, 29), RegionId = lRegion.RegionId, Min = 18.5, Max = 28.1, Average = 23.3, ETC = 5.9, Rain = 0, };
            var lTD_North_20150130 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150130", Date = new DateTime(2015, 01, 30), RegionId = lRegion.RegionId, Min = 12.8, Max = 27.2, Average = 20, ETC = 5.6, Rain = 0, };
            var lTD_North_20150131 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150131", Date = new DateTime(2015, 01, 31), RegionId = lRegion.RegionId, Min = 15, Max = 29.6, Average = 22.3, ETC = 6.2, Rain = 0, };
            var lTD_North_20150201 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150201", Date = new DateTime(2015, 02, 01), RegionId = lRegion.RegionId, Min = 19, Max = 30.7, Average = 24.9, ETC = 6, Rain = 0, };
            var lTD_North_20150202 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150202", Date = new DateTime(2015, 02, 02), RegionId = lRegion.RegionId, Min = 18.9, Max = 32.5, Average = 25.7, ETC = 6.1, Rain = 0, };
            var lTD_North_20150203 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150203", Date = new DateTime(2015, 02, 03), RegionId = lRegion.RegionId, Min = 22.5, Max = 31.3, Average = 26.9, ETC = 3.7, Rain = 0, };
            var lTD_North_20150204 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150204", Date = new DateTime(2015, 02, 04), RegionId = lRegion.RegionId, Min = 22.5, Max = 31.5, Average = 27, ETC = 5.6, Rain = 0, };
            var lTD_North_20150205 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150205", Date = new DateTime(2015, 02, 05), RegionId = lRegion.RegionId, Min = 21.8, Max = 33.5, Average = 27.7, ETC = 5.5, Rain = 6.3, };
            var lTD_North_20150206 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150206", Date = new DateTime(2015, 02, 06), RegionId = lRegion.RegionId, Min = 21.5, Max = 32, Average = 26.8, ETC = 5.7, Rain = 0, };
            var lTD_North_20150207 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150207", Date = new DateTime(2015, 02, 07), RegionId = lRegion.RegionId, Min = 19, Max = 32.7, Average = 25.9, ETC = 5.9, Rain = 0, };
            var lTD_North_20150208 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150208", Date = new DateTime(2015, 02, 08), RegionId = lRegion.RegionId, Min = 19.8, Max = 33.2, Average = 26.5, ETC = 5.3, Rain = 0, };
            var lTD_North_20150209 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150209", Date = new DateTime(2015, 02, 09), RegionId = lRegion.RegionId, Min = 20.2, Max = 33.3, Average = 26.8, ETC = 6, Rain = 0, };
            var lTD_North_20150210 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150210", Date = new DateTime(2015, 02, 10), RegionId = lRegion.RegionId, Min = 19.3, Max = 26.1, Average = 22.7, ETC = 2.7, Rain = 2.9, };
            var lTD_North_20150211 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150211", Date = new DateTime(2015, 02, 11), RegionId = lRegion.RegionId, Min = 18.9, Max = 30.8, Average = 24.9, ETC = 5.8, Rain = 0, };
            var lTD_North_20150212 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150212", Date = new DateTime(2015, 02, 12), RegionId = lRegion.RegionId, Min = 19, Max = 32.4, Average = 25.7, ETC = 5.7, Rain = 0, };
            var lTD_North_20150213 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150213", Date = new DateTime(2015, 02, 13), RegionId = lRegion.RegionId, Min = 18.9, Max = 30.6, Average = 24.8, ETC = 6.3, Rain = 0, };
            var lTD_North_20150214 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150214", Date = new DateTime(2015, 02, 14), RegionId = lRegion.RegionId, Min = 17.5, Max = 31.6, Average = 24.6, ETC = 6.2, Rain = 0, };
            var lTD_North_20150215 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150215", Date = new DateTime(2015, 02, 15), RegionId = lRegion.RegionId, Min = 17.7, Max = 31.5, Average = 24.6, ETC = 6.6, Rain = 0, };
            var lTD_North_20150216 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150216", Date = new DateTime(2015, 02, 16), RegionId = lRegion.RegionId, Min = 20, Max = 32.3, Average = 26.2, ETC = 6.1, Rain = 0, };
            var lTD_North_20150217 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150217", Date = new DateTime(2015, 02, 17), RegionId = lRegion.RegionId, Min = 19, Max = 32.2, Average = 25.6, ETC = 6, Rain = 0, };
            var lTD_North_20150218 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150218", Date = new DateTime(2015, 02, 18), RegionId = lRegion.RegionId, Min = 20.3, Max = 32.4, Average = 26.4, ETC = 4, Rain = 4.1, };
            var lTD_North_20150219 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150219", Date = new DateTime(2015, 02, 19), RegionId = lRegion.RegionId, Min = 19.9, Max = 25.3, Average = 22.6, ETC = 3.1, Rain = 0.4, };
            var lTD_North_20150220 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150220", Date = new DateTime(2015, 02, 20), RegionId = lRegion.RegionId, Min = 16.3, Max = 26.8, Average = 21.6, ETC = 5, Rain = 0, };
            var lTD_North_20150221 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150221", Date = new DateTime(2015, 02, 21), RegionId = lRegion.RegionId, Min = 14, Max = 29, Average = 21.5, ETC = 4, Rain = 0, };
            var lTD_North_20150222 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150222", Date = new DateTime(2015, 02, 22), RegionId = lRegion.RegionId, Min = 21.3, Max = 32.2, Average = 26.8, ETC = 5.4, Rain = 0, };
            var lTD_North_20150223 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150223", Date = new DateTime(2015, 02, 23), RegionId = lRegion.RegionId, Min = 19.8, Max = 33.1, Average = 26.5, ETC = 5.5, Rain = 0.1, };
            var lTD_North_20150224 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150224", Date = new DateTime(2015, 02, 24), RegionId = lRegion.RegionId, Min = 21.8, Max = 34.2, Average = 28, ETC = 5.4, Rain = 4.1, };
            var lTD_North_20150225 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150225", Date = new DateTime(2015, 02, 25), RegionId = lRegion.RegionId, Min = 21, Max = 24.5, Average = 22.8, ETC = 1.7, Rain = 33.1, };
            var lTD_North_20150226 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150226", Date = new DateTime(2015, 02, 26), RegionId = lRegion.RegionId, Min = 20.3, Max = 29.6, Average = 25, ETC = 3, Rain = 8.1, };
            var lTD_North_20150227 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150227", Date = new DateTime(2015, 02, 27), RegionId = lRegion.RegionId, Min = 21.5, Max = 31, Average = 26.3, ETC = 5.3, Rain = 0, };
            var lTD_North_20150228 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150228", Date = new DateTime(2015, 02, 28), RegionId = lRegion.RegionId, Min = 16.2, Max = 30.4, Average = 23.3, ETC = 5.4, Rain = 0, };
            var lTD_North_20150301 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150301", Date = new DateTime(2015, 03, 01), RegionId = lRegion.RegionId, Min = 18.7, Max = 31.1, Average = 24.9, ETC = 4.4, Rain = 6.8, };
            var lTD_North_20150302 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150302", Date = new DateTime(2015, 03, 02), RegionId = lRegion.RegionId, Min = 19.9, Max = 31.3, Average = 25.6, ETC = 4.5, Rain = 0, };
            var lTD_North_20150303 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150303", Date = new DateTime(2015, 03, 03), RegionId = lRegion.RegionId, Min = 23, Max = 30.5, Average = 26.8, ETC = 2.1, Rain = 10.2, };
            var lTD_North_20150304 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150304", Date = new DateTime(2015, 03, 04), RegionId = lRegion.RegionId, Min = 21.1, Max = 29.9, Average = 25.5, ETC = 3.9, Rain = 0, };
            var lTD_North_20150305 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150305", Date = new DateTime(2015, 03, 05), RegionId = lRegion.RegionId, Min = 20.2, Max = 31.9, Average = 26.1, ETC = 5.3, Rain = 0, };
            var lTD_North_20150306 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150306", Date = new DateTime(2015, 03, 06), RegionId = lRegion.RegionId, Min = 20.7, Max = 31.2, Average = 26, ETC = 5.7, Rain = 0, };
            var lTD_North_20150307 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150307", Date = new DateTime(2015, 03, 07), RegionId = lRegion.RegionId, Min = 19.2, Max = 31.6, Average = 25.4, ETC = 5, Rain = 0, };
            var lTD_North_20150308 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150308", Date = new DateTime(2015, 03, 08), RegionId = lRegion.RegionId, Min = 18, Max = 31.5, Average = 24.8, ETC = 4.9, Rain = 0, };
            var lTD_North_20150309 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150309", Date = new DateTime(2015, 03, 09), RegionId = lRegion.RegionId, Min = 16.7, Max = 32.6, Average = 24.7, ETC = 4.9, Rain = 0, };
            var lTD_North_20150310 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150310", Date = new DateTime(2015, 03, 10), RegionId = lRegion.RegionId, Min = 21.2, Max = 31.7, Average = 26.5, ETC = 4.8, Rain = 0, };
            var lTD_North_20150311 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150311", Date = new DateTime(2015, 03, 11), RegionId = lRegion.RegionId, Min = 19, Max = 31.4, Average = 25.2, ETC = 4.8, Rain = 0, };
            var lTD_North_20150312 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150312", Date = new DateTime(2015, 03, 12), RegionId = lRegion.RegionId, Min = 17, Max = 31.1, Average = 24.1, ETC = 4.7, Rain = 0, };
            var lTD_North_20150313 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150313", Date = new DateTime(2015, 03, 13), RegionId = lRegion.RegionId, Min = 16.5, Max = 31.3, Average = 23.9, ETC = 4.6, Rain = 0, };
            var lTD_North_20150314 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150314", Date = new DateTime(2015, 03, 14), RegionId = lRegion.RegionId, Min = 16.4, Max = 32.8, Average = 24.6, ETC = 4.2, Rain = 0, };
            var lTD_North_20150315 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150315", Date = new DateTime(2015, 03, 15), RegionId = lRegion.RegionId, Min = 20.4, Max = 32.4, Average = 26.4, ETC = 4.9, Rain = 0, };
            var lTD_North_20150316 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150316", Date = new DateTime(2015, 03, 16), RegionId = lRegion.RegionId, Min = 19.2, Max = 33.7, Average = 26.5, ETC = 5, Rain = 0, };
            var lTD_North_20150317 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150317", Date = new DateTime(2015, 03, 17), RegionId = lRegion.RegionId, Min = 20.6, Max = 33.5, Average = 27.1, ETC = 4.9, Rain = 0, };
            var lTD_North_20150318 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150318", Date = new DateTime(2015, 03, 18), RegionId = lRegion.RegionId, Min = 16.6, Max = 31.9, Average = 24.3, ETC = 4.9, Rain = 0, };
            var lTD_North_20150319 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150319", Date = new DateTime(2015, 03, 19), RegionId = lRegion.RegionId, Min = 18.1, Max = 33.3, Average = 25.7, ETC = 4, Rain = 0, };
            var lTD_North_20150320 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150320", Date = new DateTime(2015, 03, 20), RegionId = lRegion.RegionId, Min = 20.2, Max = 31, Average = 25.6, ETC = 3.3, Rain = 0, };
            var lTD_North_20150321 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150321", Date = new DateTime(2015, 03, 21), RegionId = lRegion.RegionId, Min = 14, Max = 24, Average = 19, ETC = 4.5, Rain = 0, };
            var lTD_North_20150322 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150322", Date = new DateTime(2015, 03, 22), RegionId = lRegion.RegionId, Min = 9.8, Max = 23.2, Average = 16.5, ETC = 3.1, Rain = 0, };
            var lTD_North_20150323 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150323", Date = new DateTime(2015, 03, 23), RegionId = lRegion.RegionId, Min = 8.6, Max = 25.5, Average = 17.1, ETC = 3.3, Rain = 0, };
            var lTD_North_20150324 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150324", Date = new DateTime(2015, 03, 24), RegionId = lRegion.RegionId, Min = 11.5, Max = 25.5, Average = 18.5, ETC = 2.7, Rain = 0, };
            var lTD_North_20150325 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150325", Date = new DateTime(2015, 03, 25), RegionId = lRegion.RegionId, Min = 16.2, Max = 23.8, Average = 20, ETC = 2.3, Rain = 3.5, };
            var lTD_North_20150326 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150326", Date = new DateTime(2015, 03, 26), RegionId = lRegion.RegionId, Min = 13.3, Max = 22.3, Average = 17.8, ETC = 2.4, Rain = 0, };
            var lTD_North_20150327 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150327", Date = new DateTime(2015, 03, 27), RegionId = lRegion.RegionId, Min = 10.3, Max = 25.6, Average = 18, ETC = 3.4, Rain = 0, };
            var lTD_North_20150328 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150328", Date = new DateTime(2015, 03, 28), RegionId = lRegion.RegionId, Min = 9, Max = 28.5, Average = 18.8, ETC = 3.1, Rain = 0, };
            var lTD_North_20150329 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150329", Date = new DateTime(2015, 03, 29), RegionId = lRegion.RegionId, Min = 15.4, Max = 24.8, Average = 20.1, ETC = 2, Rain = 0, };
            var lTD_North_20150330 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150330", Date = new DateTime(2015, 03, 30), RegionId = lRegion.RegionId, Min = 14.2, Max = 30.3, Average = 22.3, ETC = 3.6, Rain = 0, };
            var lTD_North_20150331 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150331", Date = new DateTime(2015, 03, 31), RegionId = lRegion.RegionId, Min = 15.2, Max = 28.5, Average = 21.9, ETC = 3.2, Rain = 0, };
            var lTD_North_20150401 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150401", Date = new DateTime(2015, 04, 01), RegionId = lRegion.RegionId, Min = 9.2, Max = 27.6, Average = 18.4, ETC = 3.1, Rain = 0, };
            var lTD_North_20150402 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150402", Date = new DateTime(2015, 04, 02), RegionId = lRegion.RegionId, Min = 11.3, Max = 30, Average = 20.7, ETC = 3.4, Rain = 0, };
            var lTD_North_20150403 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150403", Date = new DateTime(2015, 04, 03), RegionId = lRegion.RegionId, Min = 14, Max = 31.6, Average = 22.8, ETC = 3.6, Rain = 0, };
            var lTD_North_20150404 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150404", Date = new DateTime(2015, 04, 04), RegionId = lRegion.RegionId, Min = 17.8, Max = 32.6, Average = 25.2, ETC = 3.9, Rain = 0, };
            var lTD_North_20150405 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150405", Date = new DateTime(2015, 04, 05), RegionId = lRegion.RegionId, Min = 13.6, Max = 30.4, Average = 22, ETC = 4.6, Rain = 0, };
            var lTD_North_20150406 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150406", Date = new DateTime(2015, 04, 06), RegionId = lRegion.RegionId, Min = 10.8, Max = 27.2, Average = 19, ETC = 3.2, Rain = 0, };
            var lTD_North_20150407 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150407", Date = new DateTime(2015, 04, 07), RegionId = lRegion.RegionId, Min = 8.6, Max = 26.2, Average = 17.4, ETC = 3.5, Rain = 0, };
            var lTD_North_20150408 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150408", Date = new DateTime(2015, 04, 08), RegionId = lRegion.RegionId, Min = 9.3, Max = 28.3, Average = 18.8, ETC = 2.9, Rain = 0, };
            var lTD_North_20150409 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150409", Date = new DateTime(2015, 04, 09), RegionId = lRegion.RegionId, Min = 10.8, Max = 31.3, Average = 21.1, ETC = 3.1, Rain = 0, };
            var lTD_North_20150410 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150410", Date = new DateTime(2015, 04, 10), RegionId = lRegion.RegionId, Min = 15.8, Max = 31.8, Average = 23.8, ETC = 3.1, Rain = 0, };
            var lTD_North_20150411 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150411", Date = new DateTime(2015, 04, 11), RegionId = lRegion.RegionId, Min = 16.1, Max = 32.8, Average = 24.5, ETC = 3.6, Rain = 0, };
            var lTD_North_20150412 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150412", Date = new DateTime(2015, 04, 12), RegionId = lRegion.RegionId, Min = 15.7, Max = 31.6, Average = 23.7, ETC = 3.2, Rain = 0, };
            var lTD_North_20150413 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150413", Date = new DateTime(2015, 04, 13), RegionId = lRegion.RegionId, Min = 15.8, Max = 32, Average = 23.9, ETC = 3.4, Rain = 0, };
            var lTD_North_20150414 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150414", Date = new DateTime(2015, 04, 14), RegionId = lRegion.RegionId, Min = 14.2, Max = 30.9, Average = 22.6, ETC = 2.5, Rain = 0, };
            var lTD_North_20150415 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150415", Date = new DateTime(2015, 04, 15), RegionId = lRegion.RegionId, Min = 12.7, Max = 30.9, Average = 21.8, ETC = 3.9, Rain = 0, };
            var lTD_North_20150416 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150416", Date = new DateTime(2015, 04, 16), RegionId = lRegion.RegionId, Min = 16.2, Max = 30.4, Average = 23.3, ETC = 3.9, Rain = 19.2, };
            var lTD_North_20150417 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150417", Date = new DateTime(2015, 04, 17), RegionId = lRegion.RegionId, Min = 15.3, Max = 21.7, Average = 18.5, ETC = 1.4, Rain = 4.7, };
            var lTD_North_20150418 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150418", Date = new DateTime(2015, 04, 18), RegionId = lRegion.RegionId, Min = 11.2, Max = 26, Average = 18.6, ETC = 2.6, Rain = 0, };
            var lTD_North_20150419 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150419", Date = new DateTime(2015, 04, 19), RegionId = lRegion.RegionId, Min = 12.1, Max = 27.3, Average = 19.7, ETC = 2.3, Rain = 0, };
            var lTD_North_20150420 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150420", Date = new DateTime(2015, 04, 20), RegionId = lRegion.RegionId, Min = 17.6, Max = 28.7, Average = 23.2, ETC = 3.4, Rain = 0, };
            var lTD_North_20150421 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150421", Date = new DateTime(2015, 04, 21), RegionId = lRegion.RegionId, Min = 10.6, Max = 26.6, Average = 18.6, ETC = 2.6, Rain = 0, };
            var lTD_North_20150422 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150422", Date = new DateTime(2015, 04, 22), RegionId = lRegion.RegionId, Min = 8.3, Max = 24.6, Average = 16.5, ETC = 2.2, Rain = 0, };
            var lTD_North_20150423 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150423", Date = new DateTime(2015, 04, 23), RegionId = lRegion.RegionId, Min = 10.4, Max = 25.6, Average = 18, ETC = 2.2, Rain = 0, };
            var lTD_North_20150424 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150424", Date = new DateTime(2015, 04, 24), RegionId = lRegion.RegionId, Min = 8.3, Max = 27.5, Average = 17.9, ETC = 2.3, Rain = 0, };
            var lTD_North_20150425 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150425", Date = new DateTime(2015, 04, 25), RegionId = lRegion.RegionId, Min = 10.7, Max = 26.8, Average = 18.8, ETC = 2.5, Rain = 0, };
            var lTD_North_20150426 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150426", Date = new DateTime(2015, 04, 26), RegionId = lRegion.RegionId, Min = 8.8, Max = 27.8, Average = 18.3, ETC = 2.3, Rain = 0, };
            var lTD_North_20150427 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150427", Date = new DateTime(2015, 04, 27), RegionId = lRegion.RegionId, Min = 12.1, Max = 29.8, Average = 21, ETC = 3, Rain = 0, };
            var lTD_North_20150428 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150428", Date = new DateTime(2015, 04, 28), RegionId = lRegion.RegionId, Min = 12.4, Max = 29.1, Average = 20.8, ETC = 3.4, Rain = 0, };
            var lTD_North_20150429 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150429", Date = new DateTime(2015, 04, 29), RegionId = lRegion.RegionId, Min = 16, Max = 23.8, Average = 19.9, ETC = 2.1, Rain = 0, };
            var lTD_North_20150430 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150430", Date = new DateTime(2015, 04, 30), RegionId = lRegion.RegionId, Min = 13.4, Max = 26.3, Average = 19.9, ETC = 2.4, Rain = 0, };
            var lTD_North_20150501 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150501", Date = new DateTime(2015, 05, 01), RegionId = lRegion.RegionId, Min = 13.1, Max = 28, Average = 20.6, ETC = 3.1, Rain = 21.8, };
            var lTD_North_20150502 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150502", Date = new DateTime(2015, 05, 02), RegionId = lRegion.RegionId, Min = 17, Max = 20.3, Average = 18.7, ETC = 1.1, Rain = 30.3, };
            var lTD_North_20150503 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150503", Date = new DateTime(2015, 05, 03), RegionId = lRegion.RegionId, Min = 8.7, Max = 18.2, Average = 13.5, ETC = 1.8, Rain = 0, };
            var lTD_North_20150504 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150504", Date = new DateTime(2015, 05, 04), RegionId = lRegion.RegionId, Min = 5.1, Max = 20.3, Average = 12.7, ETC = 1.6, Rain = 0, };
            var lTD_North_20150505 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150505", Date = new DateTime(2015, 05, 05), RegionId = lRegion.RegionId, Min = 5.5, Max = 20.9, Average = 13.2, ETC = 1.2, Rain = 0, };
            var lTD_North_20150506 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150506", Date = new DateTime(2015, 05, 06), RegionId = lRegion.RegionId, Min = 6.7, Max = 21.9, Average = 14.3, ETC = 1.9, Rain = 0, };
            var lTD_North_20150507 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150507", Date = new DateTime(2015, 05, 07), RegionId = lRegion.RegionId, Min = 4.6, Max = 18.2, Average = 11.4, ETC = 1.6, Rain = 0, };
            var lTD_North_20150508 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150508", Date = new DateTime(2015, 05, 08), RegionId = lRegion.RegionId, Min = 9.4, Max = 21.5, Average = 15.5, ETC = 1.3, Rain = 0, };
            var lTD_North_20150509 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150509", Date = new DateTime(2015, 05, 09), RegionId = lRegion.RegionId, Min = 9.2, Max = 23.2, Average = 16.2, ETC = 1.1, Rain = 1.1, };
            var lTD_North_20150510 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150510", Date = new DateTime(2015, 05, 10), RegionId = lRegion.RegionId, Min = 13.8, Max = 21.5, Average = 17.7, ETC = 1.4, Rain = 6.1, };
            var lTD_North_20150511 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150511", Date = new DateTime(2015, 05, 11), RegionId = lRegion.RegionId, Min = 11.2, Max = 22.3, Average = 16.8, ETC = 1.3, Rain = 0, };
            var lTD_North_20150512 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150512", Date = new DateTime(2015, 05, 12), RegionId = lRegion.RegionId, Min = 10.8, Max = 22.7, Average = 16.8, ETC = 1.7, Rain = 0, };
            var lTD_North_20150513 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150513", Date = new DateTime(2015, 05, 13), RegionId = lRegion.RegionId, Min = 11.3, Max = 24.3, Average = 17.8, ETC = 1.5, Rain = 0, };
            var lTD_North_20150514 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150514", Date = new DateTime(2015, 05, 14), RegionId = lRegion.RegionId, Min = 13.3, Max = 25.9, Average = 19.6, ETC = 1.8, Rain = 0, };
            var lTD_North_20150515 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150515", Date = new DateTime(2015, 05, 15), RegionId = lRegion.RegionId, Min = 14.6, Max = 25, Average = 19.8, ETC = 1.5, Rain = 0, };
            var lTD_North_20150516 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150516", Date = new DateTime(2015, 05, 16), RegionId = lRegion.RegionId, Min = 15, Max = 26, Average = 20.5, ETC = 1.9, Rain = 0, };
            var lTD_North_20150517 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150517", Date = new DateTime(2015, 05, 17), RegionId = lRegion.RegionId, Min = 17.2, Max = 26.3, Average = 21.8, ETC = 1.6, Rain = 0, };
            var lTD_North_20150518 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150518", Date = new DateTime(2015, 05, 18), RegionId = lRegion.RegionId, Min = 17.9, Max = 28.6, Average = 23.3, ETC = 1.5, Rain = 0.1, };
            var lTD_North_20150519 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150519", Date = new DateTime(2015, 05, 19), RegionId = lRegion.RegionId, Min = 15.8, Max = 28, Average = 21.9, ETC = 1.5, Rain = 0, };
            var lTD_North_20150520 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150520", Date = new DateTime(2015, 05, 20), RegionId = lRegion.RegionId, Min = 13.9, Max = 26.7, Average = 20.3, ETC = 1.5, Rain = 0, };
            var lTD_North_20150521 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150521", Date = new DateTime(2015, 05, 21), RegionId = lRegion.RegionId, Min = 15.3, Max = 27.9, Average = 21.6, ETC = 1.7, Rain = 0, };
            var lTD_North_20150522 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150522", Date = new DateTime(2015, 05, 22), RegionId = lRegion.RegionId, Min = 17.6, Max = 27.5, Average = 22.6, ETC = 1.6, Rain = 33.1, };
            var lTD_North_20150523 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150523", Date = new DateTime(2015, 05, 23), RegionId = lRegion.RegionId, Min = 19.3, Max = 25, Average = 22.2, ETC = 1, Rain = 0.6, };
            var lTD_North_20150524 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150524", Date = new DateTime(2015, 05, 24), RegionId = lRegion.RegionId, Min = 13.5, Max = 21.2, Average = 17.4, ETC = 1.7, Rain = 0, };
            var lTD_North_20150525 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150525", Date = new DateTime(2015, 05, 25), RegionId = lRegion.RegionId, Min = 10.6, Max = 21.2, Average = 15.9, ETC = 1.1, Rain = 0, };
            var lTD_North_20150526 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150526", Date = new DateTime(2015, 05, 26), RegionId = lRegion.RegionId, Min = 12.5, Max = 19.5, Average = 16, ETC = 1.5, Rain = 0, };
            var lTD_North_20150527 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150527", Date = new DateTime(2015, 05, 27), RegionId = lRegion.RegionId, Min = 11.3, Max = 19.4, Average = 15.4, ETC = 1.2, Rain = 0, };
            var lTD_North_20150528 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150528", Date = new DateTime(2015, 05, 28), RegionId = lRegion.RegionId, Min = 8.4, Max = 20.2, Average = 14.3, ETC = 0.9, Rain = 0, };
            var lTD_North_20150529 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150529", Date = new DateTime(2015, 05, 29), RegionId = lRegion.RegionId, Min = 5.6, Max = 19, Average = 12.3, ETC = 0.7, Rain = 0, };
            var lTD_North_20150530 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150530", Date = new DateTime(2015, 05, 30), RegionId = lRegion.RegionId, Min = 6.4, Max = 20.6, Average = 13.5, ETC = 0.9, Rain = 0, };
            var lTD_North_20150531 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150531", Date = new DateTime(2015, 05, 31), RegionId = lRegion.RegionId, Min = 7.8, Max = 21.3, Average = 14.6, ETC = 0.5, Rain = 0, };
            var lTD_North_20150601 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150601", Date = new DateTime(2015, 06, 01), RegionId = lRegion.RegionId, Min = 8.3, Max = 20.9, Average = 14.6, ETC = 1.1, Rain = 0, };
            var lTD_North_20150602 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150602", Date = new DateTime(2015, 06, 02), RegionId = lRegion.RegionId, Min = 9.2, Max = 22.3, Average = 15.8, ETC = 1.1, Rain = 0, };
            var lTD_North_20150603 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150603", Date = new DateTime(2015, 06, 03), RegionId = lRegion.RegionId, Min = 15, Max = 21.2, Average = 18.1, ETC = 0.9, Rain = 0.1, };
            var lTD_North_20150604 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150604", Date = new DateTime(2015, 06, 04), RegionId = lRegion.RegionId, Min = 15, Max = 24.4, Average = 19.7, ETC = 1.5, Rain = 0, };
            var lTD_North_20150605 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150605", Date = new DateTime(2015, 06, 05), RegionId = lRegion.RegionId, Min = 20.1, Max = 28.5, Average = 24.3, ETC = 1.7, Rain = 0, };
            var lTD_North_20150606 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150606", Date = new DateTime(2015, 06, 06), RegionId = lRegion.RegionId, Min = 21.7, Max = 29.5, Average = 25.6, ETC = 2.5, Rain = 0, };
            var lTD_North_20150607 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150607", Date = new DateTime(2015, 06, 07), RegionId = lRegion.RegionId, Min = 16.2, Max = 23.1, Average = 19.7, ETC = 2.6, Rain = 8.2, };
            var lTD_North_20150608 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150608", Date = new DateTime(2015, 06, 08), RegionId = lRegion.RegionId, Min = 12.9, Max = 18.5, Average = 15.7, ETC = 1.2, Rain = 0.1, };
            var lTD_North_20150609 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150609", Date = new DateTime(2015, 06, 09), RegionId = lRegion.RegionId, Min = 14, Max = 19.8, Average = 16.9, ETC = 0.7, Rain = 4.5, };
            var lTD_North_20150610 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150610", Date = new DateTime(2015, 06, 10), RegionId = lRegion.RegionId, Min = 10.9, Max = 20, Average = 15.5, ETC = 1, Rain = 0, };
            var lTD_North_20150611 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150611", Date = new DateTime(2015, 06, 11), RegionId = lRegion.RegionId, Min = 4.8, Max = 17.6, Average = 11.2, ETC = 1.2, Rain = 0, };
            var lTD_North_20150612 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150612", Date = new DateTime(2015, 06, 12), RegionId = lRegion.RegionId, Min = -0.3, Max = 15.9, Average = 7.8, ETC = 0.5, Rain = 0, };
            var lTD_North_20150613 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150613", Date = new DateTime(2015, 06, 13), RegionId = lRegion.RegionId, Min = 6.4, Max = 16, Average = 11.2, ETC = 1, Rain = 0, };
            var lTD_North_20150614 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150614", Date = new DateTime(2015, 06, 14), RegionId = lRegion.RegionId, Min = 4.2, Max = 18.6, Average = 11.4, ETC = 1, Rain = 0, };
            var lTD_North_20150615 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150615", Date = new DateTime(2015, 06, 15), RegionId = lRegion.RegionId, Min = 3.1, Max = 18, Average = 10.6, ETC = 1.3, Rain = 0, };
            var lTD_North_20150616 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150616", Date = new DateTime(2015, 06, 16), RegionId = lRegion.RegionId, Min = 10.3, Max = 20.3, Average = 15.3, ETC = 1.3, Rain = 0, };
            var lTD_North_20150617 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150617", Date = new DateTime(2015, 06, 17), RegionId = lRegion.RegionId, Min = 2.5, Max = 18.2, Average = 10.4, ETC = 1.4, Rain = 0, };
            var lTD_North_20150618 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150618", Date = new DateTime(2015, 06, 18), RegionId = lRegion.RegionId, Min = 0.4, Max = 11.9, Average = 6.2, ETC = 0.9, Rain = 0, };
            var lTD_North_20150619 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150619", Date = new DateTime(2015, 06, 19), RegionId = lRegion.RegionId, Min = -3.3, Max = 13.7, Average = 5.2, ETC = 0.7, Rain = 0, };
            var lTD_North_20150620 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150620", Date = new DateTime(2015, 06, 20), RegionId = lRegion.RegionId, Min = 2.4, Max = 17.6, Average = 10, ETC = 0.5, Rain = 0, };
            var lTD_North_20150621 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150621", Date = new DateTime(2015, 06, 21), RegionId = lRegion.RegionId, Min = 4.6, Max = 20.6, Average = 12.6, ETC = 0.5, Rain = 0, };
            var lTD_North_20150622 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150622", Date = new DateTime(2015, 06, 22), RegionId = lRegion.RegionId, Min = 6.7, Max = 15, Average = 10.9, ETC = 0.7, Rain = 1.8, };
            var lTD_North_20150623 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150623", Date = new DateTime(2015, 06, 23), RegionId = lRegion.RegionId, Min = 1.8, Max = 14, Average = 7.9, ETC = 1.3, Rain = 0, };
            var lTD_North_20150624 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150624", Date = new DateTime(2015, 06, 24), RegionId = lRegion.RegionId, Min = 6.9, Max = 14.5, Average = 10.7, ETC = 1.6, Rain = 0, };
            var lTD_North_20150625 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150625", Date = new DateTime(2015, 06, 25), RegionId = lRegion.RegionId, Min = 10, Max = 24.1, Average = 17.1, ETC = 1, Rain = 0, };
            var lTD_North_20150626 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150626", Date = new DateTime(2015, 06, 26), RegionId = lRegion.RegionId, Min = 12, Max = 24, Average = 18, ETC = 1, Rain = 0, };
            var lTD_North_20150627 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150627", Date = new DateTime(2015, 06, 27), RegionId = lRegion.RegionId, Min = 15, Max = 25, Average = 20, ETC = 1.1, Rain = 0, };
            var lTD_North_20150628 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150628", Date = new DateTime(2015, 06, 28), RegionId = lRegion.RegionId, Min = 15, Max = 25, Average = 20, ETC = 1.1, Rain = 10.3, };
            var lTD_North_20150629 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150629", Date = new DateTime(2015, 06, 29), RegionId = lRegion.RegionId, Min = 14.5, Max = 19, Average = 16.8, ETC = 0.6, Rain = 26.7, };
            var lTD_North_20150630 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150630", Date = new DateTime(2015, 06, 30), RegionId = lRegion.RegionId, Min = 10.6, Max = 22.3, Average = 16.5, ETC = 0.9, Rain = 0, };
            var lTD_North_20150701 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150701", Date = new DateTime(2015, 07, 01), RegionId = lRegion.RegionId, Min = 6, Max = 18.5, Average = 12.3, ETC = 0.9, Rain = 0, };
            var lTD_North_20150702 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150702", Date = new DateTime(2015, 07, 02), RegionId = lRegion.RegionId, Min = 9, Max = 15.4, Average = 12.2, ETC = 0.8, Rain = 0, };
            var lTD_North_20150703 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150703", Date = new DateTime(2015, 07, 03), RegionId = lRegion.RegionId, Min = 7.9, Max = 13.6, Average = 10.8, ETC = 1, Rain = 0, };
            var lTD_North_20150704 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150704", Date = new DateTime(2015, 07, 04), RegionId = lRegion.RegionId, Min = 3, Max = 11.3, Average = 7.2, ETC = 0.7, Rain = 0, };
            var lTD_North_20150705 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150705", Date = new DateTime(2015, 07, 05), RegionId = lRegion.RegionId, Min = 3.9, Max = 15.7, Average = 9.8, ETC = 1, Rain = 0, };
            var lTD_North_20150706 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150706", Date = new DateTime(2015, 07, 06), RegionId = lRegion.RegionId, Min = 9.6, Max = 17.9, Average = 13.8, ETC = 1.1, Rain = 0, };
            var lTD_North_20150707 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150707", Date = new DateTime(2015, 07, 07), RegionId = lRegion.RegionId, Min = 7, Max = 18, Average = 12.5, ETC = 1.5, Rain = 0, };
            var lTD_North_20150708 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150708", Date = new DateTime(2015, 07, 08), RegionId = lRegion.RegionId, Min = 2.6, Max = 19.7, Average = 11.2, ETC = 0.8, Rain = 0, };
            var lTD_North_20150709 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150709", Date = new DateTime(2015, 07, 09), RegionId = lRegion.RegionId, Min = 9.5, Max = 16.5, Average = 13, ETC = 0.8, Rain = 0, };
            var lTD_North_20150710 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150710", Date = new DateTime(2015, 07, 10), RegionId = lRegion.RegionId, Min = 12.5, Max = 20.7, Average = 16.6, ETC = 1.1, Rain = 0, };
            var lTD_North_20150711 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150711", Date = new DateTime(2015, 07, 11), RegionId = lRegion.RegionId, Min = 9.5, Max = 22.3, Average = 15.9, ETC = 1.1, Rain = 0, };
            var lTD_North_20150712 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150712", Date = new DateTime(2015, 07, 12), RegionId = lRegion.RegionId, Min = 14.3, Max = 21.1, Average = 17.7, ETC = 0.9, Rain = 0, };
            var lTD_North_20150713 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150713", Date = new DateTime(2015, 07, 13), RegionId = lRegion.RegionId, Min = 12.2, Max = 16.7, Average = 14.5, ETC = 1.2, Rain = 0.1, };
            var lTD_North_20150714 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150714", Date = new DateTime(2015, 07, 14), RegionId = lRegion.RegionId, Min = 4.6, Max = 16, Average = 10.3, ETC = 1.2, Rain = 0, };
            var lTD_North_20150715 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150715", Date = new DateTime(2015, 07, 15), RegionId = lRegion.RegionId, Min = -0.5, Max = 15.6, Average = 7.6, ETC = 0.9, Rain = 0, };
            var lTD_North_20150716 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150716", Date = new DateTime(2015, 07, 16), RegionId = lRegion.RegionId, Min = -0.3, Max = 17.4, Average = 8.6, ETC = 1, Rain = 0, };
            var lTD_North_20150717 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150717", Date = new DateTime(2015, 07, 17), RegionId = lRegion.RegionId, Min = 7.2, Max = 18.4, Average = 12.8, ETC = 0.9, Rain = 0, };
            var lTD_North_20150718 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150718", Date = new DateTime(2015, 07, 18), RegionId = lRegion.RegionId, Min = 8, Max = 19.7, Average = 13.9, ETC = 0.9, Rain = 0, };
            var lTD_North_20150719 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150719", Date = new DateTime(2015, 07, 19), RegionId = lRegion.RegionId, Min = 15.8, Max = 21.2, Average = 18.5, ETC = 1.2, Rain = 1.6, };
            var lTD_North_20150720 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150720", Date = new DateTime(2015, 07, 20), RegionId = lRegion.RegionId, Min = 6.1, Max = 15.6, Average = 10.9, ETC = 1.4, Rain = 0, };
            var lTD_North_20150721 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150721", Date = new DateTime(2015, 07, 21), RegionId = lRegion.RegionId, Min = 0.9, Max = 13.6, Average = 7.3, ETC = 0.4, Rain = 0, };
            var lTD_North_20150722 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150722", Date = new DateTime(2015, 07, 22), RegionId = lRegion.RegionId, Min = 1.3, Max = 16.1, Average = 8.7, ETC = 0.5, Rain = 0, };
            var lTD_North_20150723 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150723", Date = new DateTime(2015, 07, 23), RegionId = lRegion.RegionId, Min = 3.8, Max = 18.7, Average = 11.3, ETC = 0.9, Rain = 0, };
            var lTD_North_20150724 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150724", Date = new DateTime(2015, 07, 24), RegionId = lRegion.RegionId, Min = 5, Max = 18, Average = 11.5, ETC = 0.8, Rain = 0, };
            var lTD_North_20150725 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150725", Date = new DateTime(2015, 07, 25), RegionId = lRegion.RegionId, Min = 7.7, Max = 19.5, Average = 13.6, ETC = 1, Rain = 0, };
            var lTD_North_20150726 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150726", Date = new DateTime(2015, 07, 26), RegionId = lRegion.RegionId, Min = 8, Max = 21.2, Average = 14.6, ETC = 1.5, Rain = 0, };
            var lTD_North_20150727 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150727", Date = new DateTime(2015, 07, 27), RegionId = lRegion.RegionId, Min = 10.6, Max = 24, Average = 17.3, ETC = 1.9, Rain = 0, };
            var lTD_North_20150728 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150728", Date = new DateTime(2015, 07, 28), RegionId = lRegion.RegionId, Min = 15.5, Max = 25.6, Average = 20.6, ETC = 1.9, Rain = 0, };
            var lTD_North_20150729 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150729", Date = new DateTime(2015, 07, 29), RegionId = lRegion.RegionId, Min = 17.2, Max = 27.3, Average = 22.3, ETC = 1.6, Rain = 0, };
            var lTD_North_20150730 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150730", Date = new DateTime(2015, 07, 30), RegionId = lRegion.RegionId, Min = 17.2, Max = 29.5, Average = 23.4, ETC = 2.3, Rain = 0, };
            var lTD_North_20150731 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150731", Date = new DateTime(2015, 07, 31), RegionId = lRegion.RegionId, Min = 12.7, Max = 24, Average = 18.4, ETC = 1.4, Rain = 8.5, };
            var lTD_North_20150801 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150801", Date = new DateTime(2015, 08, 01), RegionId = lRegion.RegionId, Min = 10.3, Max = 24.4, Average = 17.4, ETC = 1.7, Rain = 0, };
            var lTD_North_20150802 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150802", Date = new DateTime(2015, 08, 02), RegionId = lRegion.RegionId, Min = 19, Max = 28.1, Average = 23.6, ETC = 2.4, Rain = 0, };
            var lTD_North_20150803 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150803", Date = new DateTime(2015, 08, 03), RegionId = lRegion.RegionId, Min = 14.6, Max = 21.2, Average = 17.9, ETC = 2.1, Rain = 0, };
            var lTD_North_20150804 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150804", Date = new DateTime(2015, 08, 04), RegionId = lRegion.RegionId, Min = 13.6, Max = 21.5, Average = 17.6, ETC = 2, Rain = 26.8, };
            var lTD_North_20150805 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150805", Date = new DateTime(2015, 08, 05), RegionId = lRegion.RegionId, Min = 14.5, Max = 25.8, Average = 20.2, ETC = 2.2, Rain = 0, };
            var lTD_North_20150806 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150806", Date = new DateTime(2015, 08, 06), RegionId = lRegion.RegionId, Min = 20.6, Max = 30.5, Average = 25.6, ETC = 3, Rain = 0.2, };
            var lTD_North_20150807 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150807", Date = new DateTime(2015, 08, 07), RegionId = lRegion.RegionId, Min = 18.9, Max = 26.7, Average = 22.8, ETC = 1.9, Rain = 0, };
            var lTD_North_20150808 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150808", Date = new DateTime(2015, 08, 08), RegionId = lRegion.RegionId, Min = 17.6, Max = 30.3, Average = 24, ETC = 2.4, Rain = 0, };
            var lTD_North_20150809 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150809", Date = new DateTime(2015, 08, 09), RegionId = lRegion.RegionId, Min = 23.9, Max = 31.9, Average = 27.9, ETC = 4.8, Rain = 1.8, };
            var lTD_North_20150810 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150810", Date = new DateTime(2015, 08, 10), RegionId = lRegion.RegionId, Min = 12, Max = 20.6, Average = 16.3, ETC = 1.2, Rain = 1.6, };
            var lTD_North_20150811 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150811", Date = new DateTime(2015, 08, 11), RegionId = lRegion.RegionId, Min = 9.7, Max = 15.4, Average = 12.6, ETC = 0.8, Rain = 27.3, };
            var lTD_North_20150812 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150812", Date = new DateTime(2015, 08, 12), RegionId = lRegion.RegionId, Min = 12.7, Max = 16.3, Average = 14.5, ETC = 0.7, Rain = 34.9, };
            var lTD_North_20150813 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150813", Date = new DateTime(2015, 08, 13), RegionId = lRegion.RegionId, Min = 14.4, Max = 18, Average = 16.2, ETC = 1, Rain = 5.8, };
            var lTD_North_20150814 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150814", Date = new DateTime(2015, 08, 14), RegionId = lRegion.RegionId, Min = 12.5, Max = 14.6, Average = 13.6, ETC = 0.8, Rain = 21.1, };
            var lTD_North_20150815 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150815", Date = new DateTime(2015, 08, 15), RegionId = lRegion.RegionId, Min = 8.8, Max = 15, Average = 11.9, ETC = 1.3, Rain = 0, };
            var lTD_North_20150816 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150816", Date = new DateTime(2015, 08, 16), RegionId = lRegion.RegionId, Min = 6.4, Max = 19.4, Average = 12.9, ETC = 1.8, Rain = 35.5, };
            var lTD_North_20150817 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150817", Date = new DateTime(2015, 08, 17), RegionId = lRegion.RegionId, Min = 14.6, Max = 17.1, Average = 15.9, ETC = 0.9, Rain = 27.7, };
            var lTD_North_20150818 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150818", Date = new DateTime(2015, 08, 18), RegionId = lRegion.RegionId, Min = 11.4, Max = 17.1, Average = 14.3, ETC = 1, Rain = 1, };
            var lTD_North_20150819 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150819", Date = new DateTime(2015, 08, 19), RegionId = lRegion.RegionId, Min = 7.9, Max = 14.8, Average = 11.4, ETC = 1.3, Rain = 0, };
            var lTD_North_20150820 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150820", Date = new DateTime(2015, 08, 20), RegionId = lRegion.RegionId, Min = 8.1, Max = 18.1, Average = 13.1, ETC = 1.2, Rain = 0, };
            var lTD_North_20150821 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150821", Date = new DateTime(2015, 08, 21), RegionId = lRegion.RegionId, Min = 10.5, Max = 22, Average = 16.3, ETC = 2, Rain = 0, };
            var lTD_North_20150822 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150822", Date = new DateTime(2015, 08, 22), RegionId = lRegion.RegionId, Min = 13, Max = 25.2, Average = 19.1, ETC = 1.7, Rain = 0, };
            var lTD_North_20150823 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150823", Date = new DateTime(2015, 08, 23), RegionId = lRegion.RegionId, Min = 7.6, Max = 18.3, Average = 13, ETC = 2, Rain = 0, };
            var lTD_North_20150824 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150824", Date = new DateTime(2015, 08, 24), RegionId = lRegion.RegionId, Min = 3.7, Max = 17.4, Average = 10.6, ETC = 2, Rain = 0, };
            var lTD_North_20150825 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150825", Date = new DateTime(2015, 08, 25), RegionId = lRegion.RegionId, Min = 7.2, Max = 22.5, Average = 14.9, ETC = 2.3, Rain = 2.6, };
            var lTD_North_20150826 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150826", Date = new DateTime(2015, 08, 26), RegionId = lRegion.RegionId, Min = 14.4, Max = 21.9, Average = 18.2, ETC = 1.5, Rain = 0.4, };
            var lTD_North_20150827 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150827", Date = new DateTime(2015, 08, 27), RegionId = lRegion.RegionId, Min = 9.4, Max = 22.6, Average = 16, ETC = 2.2, Rain = 0, };
            var lTD_North_20150828 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150828", Date = new DateTime(2015, 08, 28), RegionId = lRegion.RegionId, Min = 8.5, Max = 25.4, Average = 17, ETC = 3.1, Rain = 0, };
            var lTD_North_20150829 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150829", Date = new DateTime(2015, 08, 29), RegionId = lRegion.RegionId, Min = 15.5, Max = 27.6, Average = 21.6, ETC = 2.4, Rain = 0, };
            var lTD_North_20150830 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150830", Date = new DateTime(2015, 08, 30), RegionId = lRegion.RegionId, Min = 16.6, Max = 31.4, Average = 24, ETC = 3.3, Rain = 0, };
            var lTD_North_20150831 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150831", Date = new DateTime(2015, 08, 31), RegionId = lRegion.RegionId, Min = 16.3, Max = 31.5, Average = 23.9, ETC = 4.7, Rain = 0, };
            var lTD_North_20150901 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150901", Date = new DateTime(2015, 09, 01), RegionId = lRegion.RegionId, Min = 8.8, Max = 18.5, Average = 13.7, ETC = 3.1, Rain = 0, };
            var lTD_North_20150902 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150902", Date = new DateTime(2015, 09, 02), RegionId = lRegion.RegionId, Min = 9.5, Max = 21.7, Average = 15.6, ETC = 2.5, Rain = 0, };
            var lTD_North_20150903 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150903", Date = new DateTime(2015, 09, 03), RegionId = lRegion.RegionId, Min = 8.6, Max = 19, Average = 13.8, ETC = 2.5, Rain = 0, };
            var lTD_North_20150904 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150904", Date = new DateTime(2015, 09, 04), RegionId = lRegion.RegionId, Min = 6, Max = 19.2, Average = 12.6, ETC = 2.2, Rain = 0, };
            var lTD_North_20150905 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150905", Date = new DateTime(2015, 09, 05), RegionId = lRegion.RegionId, Min = 5.3, Max = 21, Average = 13.2, ETC = 2.5, Rain = 0, };
            var lTD_North_20150906 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150906", Date = new DateTime(2015, 09, 06), RegionId = lRegion.RegionId, Min = 5.5, Max = 21.4, Average = 13.5, ETC = 2.9, Rain = 0, };
            var lTD_North_20150907 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150907", Date = new DateTime(2015, 09, 07), RegionId = lRegion.RegionId, Min = 7.9, Max = 23, Average = 15.5, ETC = 2.4, Rain = 0, };
            var lTD_North_20150908 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150908", Date = new DateTime(2015, 09, 08), RegionId = lRegion.RegionId, Min = 9.7, Max = 24.5, Average = 17.1, ETC = 2.8, Rain = 0, };
            var lTD_North_20150909 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150909", Date = new DateTime(2015, 09, 09), RegionId = lRegion.RegionId, Min = 8.2, Max = 24.4, Average = 16.3, ETC = 3.5, Rain = 15, };
            var lTD_North_20150910 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150910", Date = new DateTime(2015, 09, 10), RegionId = lRegion.RegionId, Min = 8.1, Max = 14.9, Average = 11.5, ETC = 2, Rain = 0, };
            var lTD_North_20150911 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150911", Date = new DateTime(2015, 09, 11), RegionId = lRegion.RegionId, Min = 3.5, Max = 13.9, Average = 8.7, ETC = 2.5, Rain = 0, };
            var lTD_North_20150912 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150912", Date = new DateTime(2015, 09, 12), RegionId = lRegion.RegionId, Min = 2.8, Max = 21, Average = 11.9, ETC = 2.5, Rain = 0, };
            var lTD_North_20150913 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150913", Date = new DateTime(2015, 09, 13), RegionId = lRegion.RegionId, Min = 5.9, Max = 24.4, Average = 15.2, ETC = 2.8, Rain = 0, };
            var lTD_North_20150914 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150914", Date = new DateTime(2015, 09, 14), RegionId = lRegion.RegionId, Min = 11.3, Max = 25.3, Average = 18.3, ETC = 4.2, Rain = 0, };
            var lTD_North_20150915 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150915", Date = new DateTime(2015, 09, 15), RegionId = lRegion.RegionId, Min = 14.4, Max = 31.1, Average = 22.8, ETC = 4.8, Rain = 4.7, };
            var lTD_North_20150916 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150916", Date = new DateTime(2015, 09, 16), RegionId = lRegion.RegionId, Min = 12.9, Max = 20, Average = 16.5, ETC = 3.7, Rain = 0.1, };
            var lTD_North_20150917 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150917", Date = new DateTime(2015, 09, 17), RegionId = lRegion.RegionId, Min = 9, Max = 20.9, Average = 15, ETC = 3.6, Rain = 0, };
            var lTD_North_20150918 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150918", Date = new DateTime(2015, 09, 18), RegionId = lRegion.RegionId, Min = 10.4, Max = 23.6, Average = 17, ETC = 4.2, Rain = 0, };
            var lTD_North_20150919 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150919", Date = new DateTime(2015, 09, 19), RegionId = lRegion.RegionId, Min = 12.2, Max = 22.2, Average = 17.2, ETC = 2.7, Rain = 0, };
            var lTD_North_20150920 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150920", Date = new DateTime(2015, 09, 20), RegionId = lRegion.RegionId, Min = 14.9, Max = 21.6, Average = 18.3, ETC = 2.2, Rain = 22.5, };
            var lTD_North_20150921 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150921", Date = new DateTime(2015, 09, 21), RegionId = lRegion.RegionId, Min = 16.7, Max = 23, Average = 19.9, ETC = 1.7, Rain = 2, };
            var lTD_North_20150922 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150922", Date = new DateTime(2015, 09, 22), RegionId = lRegion.RegionId, Min = 16.1, Max = 20.3, Average = 18.2, ETC = 1.7, Rain = 26.5, };
            var lTD_North_20150923 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150923", Date = new DateTime(2015, 09, 23), RegionId = lRegion.RegionId, Min = 16.8, Max = 22.5, Average = 19.7, ETC = 1.3, Rain = 17.1, };
            var lTD_North_20150924 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150924", Date = new DateTime(2015, 09, 24), RegionId = lRegion.RegionId, Min = 15, Max = 17.7, Average = 16.4, ETC = 1.3, Rain = 3.9, };
            var lTD_North_20150925 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150925", Date = new DateTime(2015, 09, 25), RegionId = lRegion.RegionId, Min = 14, Max = 19.6, Average = 16.8, ETC = 2.2, Rain = 0, };
            var lTD_North_20150926 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150926", Date = new DateTime(2015, 09, 26), RegionId = lRegion.RegionId, Min = 12.5, Max = 21.4, Average = 17, ETC = 2.9, Rain = 0, };
            var lTD_North_20150927 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150927", Date = new DateTime(2015, 09, 27), RegionId = lRegion.RegionId, Min = 11.6, Max = 22.2, Average = 16.9, ETC = 3.1, Rain = 0, };
            var lTD_North_20150928 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150928", Date = new DateTime(2015, 09, 28), RegionId = lRegion.RegionId, Min = 9.7, Max = 24.5, Average = 17.1, ETC = 3.1, Rain = 7, };
            var lTD_North_20150929 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150929", Date = new DateTime(2015, 09, 29), RegionId = lRegion.RegionId, Min = 11.6, Max = 20.3, Average = 16, ETC = 1.5, Rain = 0.4, };
            var lTD_North_20150930 = new TemperatureData { Name = Utils.NameRegionNorth + "-20150930", Date = new DateTime(2015, 09, 30), RegionId = lRegion.RegionId, Min = 7.9, Max = 21.5, Average = 14.7, ETC = 3.6, Rain = 0, };
            var lTD_North_20151001 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151001", Date = new DateTime(2015, 10, 01), RegionId = lRegion.RegionId, Min = 12.1, Max = 27.5, Average = 19.8, ETC = 3.8, Rain = 18.8, };
            var lTD_North_20151002 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151002", Date = new DateTime(2015, 10, 02), RegionId = lRegion.RegionId, Min = 12.3, Max = 21.6, Average = 17, ETC = 1.8, Rain = 0, };
            var lTD_North_20151003 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151003", Date = new DateTime(2015, 10, 03), RegionId = lRegion.RegionId, Min = 6.2, Max = 15.6, Average = 10.9, ETC = 2.9, Rain = 0, };
            var lTD_North_20151004 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151004", Date = new DateTime(2015, 10, 04), RegionId = lRegion.RegionId, Min = 5.2, Max = 19.6, Average = 12.4, ETC = 3.3, Rain = 0, };
            var lTD_North_20151005 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151005", Date = new DateTime(2015, 10, 05), RegionId = lRegion.RegionId, Min = 14.2, Max = 25.6, Average = 19.9, ETC = 3.9, Rain = 0, };
            var lTD_North_20151006 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151006", Date = new DateTime(2015, 10, 06), RegionId = lRegion.RegionId, Min = 15.2, Max = 30.4, Average = 22.8, ETC = 4.2, Rain = 20.5, };
            var lTD_North_20151007 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151007", Date = new DateTime(2015, 10, 07), RegionId = lRegion.RegionId, Min = 15.5, Max = 21, Average = 18.3, ETC = 1.6, Rain = 0.6, };
            var lTD_North_20151008 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151008", Date = new DateTime(2015, 10, 08), RegionId = lRegion.RegionId, Min = 14.7, Max = 16.5, Average = 15.6, ETC = 2.1, Rain = 0.1, };
            var lTD_North_20151009 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151009", Date = new DateTime(2015, 10, 09), RegionId = lRegion.RegionId, Min = 12.1, Max = 15, Average = 13.6, ETC = 3, Rain = 1.1, };
            var lTD_North_20151010 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151010", Date = new DateTime(2015, 10, 10), RegionId = lRegion.RegionId, Min = 11, Max = 13.1, Average = 12.1, ETC = 1.9, Rain = 5.8, };
            var lTD_North_20151011 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151011", Date = new DateTime(2015, 10, 11), RegionId = lRegion.RegionId, Min = 12.1, Max = 16.8, Average = 14.5, ETC = 1.8, Rain = 1.5, };
            var lTD_North_20151012 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151012", Date = new DateTime(2015, 10, 12), RegionId = lRegion.RegionId, Min = 11.2, Max = 20.1, Average = 15.7, ETC = 2.6, Rain = 0, };
            var lTD_North_20151013 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151013", Date = new DateTime(2015, 10, 13), RegionId = lRegion.RegionId, Min = 7.5, Max = 22.9, Average = 15.2, ETC = 4.1, Rain = 0, };
            var lTD_North_20151014 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151014", Date = new DateTime(2015, 10, 14), RegionId = lRegion.RegionId, Min = 14.2, Max = 25.4, Average = 19.8, ETC = 3.2, Rain = 0.7, };
            var lTD_North_20151015 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151015", Date = new DateTime(2015, 10, 15), RegionId = lRegion.RegionId, Min = 13.8, Max = 24.4, Average = 19.1, ETC = 4.5, Rain = 0, };
            var lTD_North_20151016 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151016", Date = new DateTime(2015, 10, 16), RegionId = lRegion.RegionId, Min = 10.3, Max = 20.8, Average = 15.6, ETC = 4.5, Rain = 0, };
            var lTD_North_20151017 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151017", Date = new DateTime(2015, 10, 17), RegionId = lRegion.RegionId, Min = 8.2, Max = 19.9, Average = 14.1, ETC = 4.3, Rain = 0, };
            var lTD_North_20151018 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151018", Date = new DateTime(2015, 10, 18), RegionId = lRegion.RegionId, Min = 6.9, Max = 22.2, Average = 14.6, ETC = 4, Rain = 3.4, };
            var lTD_North_20151019 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151019", Date = new DateTime(2015, 10, 19), RegionId = lRegion.RegionId, Min = 14.4, Max = 20.5, Average = 17.5, ETC = 1.8, Rain = 46, };
            var lTD_North_20151020 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151020", Date = new DateTime(2015, 10, 20), RegionId = lRegion.RegionId, Min = 15.5, Max = 24.4, Average = 20, ETC = 3.7, Rain = 0, };
            var lTD_North_20151021 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151021", Date = new DateTime(2015, 10, 21), RegionId = lRegion.RegionId, Min = 14.1, Max = 24.9, Average = 19.5, ETC = 4.7, Rain = 0, };
            var lTD_North_20151022 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151022", Date = new DateTime(2015, 10, 22), RegionId = lRegion.RegionId, Min = 14.5, Max = 25.1, Average = 19.8, ETC = 5.1, Rain = 0, };
            var lTD_North_20151023 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151023", Date = new DateTime(2015, 10, 23), RegionId = lRegion.RegionId, Min = 11.8, Max = 20.6, Average = 16.2, ETC = 3.2, Rain = 0, };
            var lTD_North_20151024 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151024", Date = new DateTime(2015, 10, 24), RegionId = lRegion.RegionId, Min = 10.2, Max = 18.9, Average = 14.6, ETC = 3.4, Rain = 8.5, };
            var lTD_North_20151025 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151025", Date = new DateTime(2015, 10, 25), RegionId = lRegion.RegionId, Min = 12.2, Max = 18.3, Average = 15.3, ETC = 1.8, Rain = 5.4, };
            var lTD_North_20151026 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151026", Date = new DateTime(2015, 10, 26), RegionId = lRegion.RegionId, Min = 16.1, Max = 25.8, Average = 21, ETC = 2.3, Rain = 0, };
            var lTD_North_20151027 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151027", Date = new DateTime(2015, 10, 27), RegionId = lRegion.RegionId, Min = 17.5, Max = 28.2, Average = 22.9, ETC = 5.1, Rain = 0, };
            var lTD_North_20151028 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151028", Date = new DateTime(2015, 10, 28), RegionId = lRegion.RegionId, Min = 15.7, Max = 27.8, Average = 21.8, ETC = 5, Rain = 0, };
            var lTD_North_20151029 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151029", Date = new DateTime(2015, 10, 29), RegionId = lRegion.RegionId, Min = 18.2, Max = 30.5, Average = 24.4, ETC = 4.7, Rain = 9.6, };
            var lTD_North_20151030 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151030", Date = new DateTime(2015, 10, 30), RegionId = lRegion.RegionId, Min = 18.4, Max = 26, Average = 22.2, ETC = 3.2, Rain = 0, };
            var lTD_North_20151031 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151031", Date = new DateTime(2015, 10, 31), RegionId = lRegion.RegionId, Min = 16, Max = 22, Average = 19, ETC = 3.7, Rain = 0, };
            var lTD_North_20151101 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151101", Date = new DateTime(2015, 11, 01), RegionId = lRegion.RegionId, Min = 11.8, Max = 23, Average = 17.4, ETC = 5.5, Rain = 0, };
            var lTD_North_20151102 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151102", Date = new DateTime(2015, 11, 02), RegionId = lRegion.RegionId, Min = 12.7, Max = 21.6, Average = 17.2, ETC = 3.3, Rain = 0, };
            var lTD_North_20151103 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151103", Date = new DateTime(2015, 11, 03), RegionId = lRegion.RegionId, Min = 16.7, Max = 24.4, Average = 20.6, ETC = 3.2, Rain = 0, };
            var lTD_North_20151104 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151104", Date = new DateTime(2015, 11, 04), RegionId = lRegion.RegionId, Min = 15.4, Max = 19.7, Average = 17.6, ETC = 2.4, Rain = 23.7, };
            var lTD_North_20151105 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151105", Date = new DateTime(2015, 11, 05), RegionId = lRegion.RegionId, Min = 12.3, Max = 20.4, Average = 16.4, ETC = 2.2, Rain = 0, };
            var lTD_North_20151106 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151106", Date = new DateTime(2015, 11, 06), RegionId = lRegion.RegionId, Min = 9.6, Max = 24.4, Average = 17, ETC = 4.7, Rain = 0, };
            var lTD_North_20151107 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151107", Date = new DateTime(2015, 11, 07), RegionId = lRegion.RegionId, Min = 11.3, Max = 26.7, Average = 19, ETC = 5.6, Rain = 0, };
            var lTD_North_20151108 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151108", Date = new DateTime(2015, 11, 08), RegionId = lRegion.RegionId, Min = 15.4, Max = 27.9, Average = 21.7, ETC = 4.9, Rain = 0, };
            var lTD_North_20151109 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151109", Date = new DateTime(2015, 11, 09), RegionId = lRegion.RegionId, Min = 15.9, Max = 31.2, Average = 23.6, ETC = 6.2, Rain = 29.6, };
            var lTD_North_20151110 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151110", Date = new DateTime(2015, 11, 10), RegionId = lRegion.RegionId, Min = 18.9, Max = 28.1, Average = 23.5, ETC = 4.3, Rain = 0, };
            var lTD_North_20151111 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151111", Date = new DateTime(2015, 11, 11), RegionId = lRegion.RegionId, Min = 18.2, Max = 28.5, Average = 23.4, ETC = 5.2, Rain = 0, };
            var lTD_North_20151112 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151112", Date = new DateTime(2015, 11, 12), RegionId = lRegion.RegionId, Min = 20.7, Max = 28.3, Average = 24.5, ETC = 4.1, Rain = 34.8, };
            var lTD_North_20151113 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151113", Date = new DateTime(2015, 11, 13), RegionId = lRegion.RegionId, Min = 16.6, Max = 22.2, Average = 19.4, ETC = 2.7, Rain = 0, };
            var lTD_North_20151114 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151114", Date = new DateTime(2015, 11, 14), RegionId = lRegion.RegionId, Min = 13.7, Max = 27, Average = 20.4, ETC = 5.2, Rain = 0, };
            var lTD_North_20151115 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151115", Date = new DateTime(2015, 11, 15), RegionId = lRegion.RegionId, Min = 14.8, Max = 28.9, Average = 21.9, ETC = 6.2, Rain = 0, };
            var lTD_North_20151116 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151116", Date = new DateTime(2015, 11, 16), RegionId = lRegion.RegionId, Min = 17.9, Max = 24.5, Average = 21.2, ETC = 3, Rain = 0, };
            var lTD_North_20151117 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151117", Date = new DateTime(2015, 11, 17), RegionId = lRegion.RegionId, Min = 17.2, Max = 28.3, Average = 22.8, ETC = 3.1, Rain = 18.2, };
            var lTD_North_20151118 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151118", Date = new DateTime(2015, 11, 18), RegionId = lRegion.RegionId, Min = 19.3, Max = 27.3, Average = 23.3, ETC = 3.7, Rain = 14.9, };
            var lTD_North_20151119 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151119", Date = new DateTime(2015, 11, 19), RegionId = lRegion.RegionId, Min = 15.1, Max = 23.2, Average = 19.2, ETC = 3.1, Rain = 3.8, };
            var lTD_North_20151120 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151120", Date = new DateTime(2015, 11, 20), RegionId = lRegion.RegionId, Min = 9.4, Max = 22.1, Average = 15.8, ETC = 4.9, Rain = 0, };
            var lTD_North_20151121 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151121", Date = new DateTime(2015, 11, 21), RegionId = lRegion.RegionId, Min = 11.1, Max = 24.6, Average = 17.9, ETC = 5.2, Rain = 0, };
            var lTD_North_20151122 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151122", Date = new DateTime(2015, 11, 22), RegionId = lRegion.RegionId, Min = 13.9, Max = 27.1, Average = 20.5, ETC = 5.8, Rain = 0, };
            var lTD_North_20151123 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151123", Date = new DateTime(2015, 11, 23), RegionId = lRegion.RegionId, Min = 14, Max = 27.9, Average = 21, ETC = 7.3, Rain = 0, };
            var lTD_North_20151124 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151124", Date = new DateTime(2015, 11, 24), RegionId = lRegion.RegionId, Min = 14.2, Max = 25, Average = 19.6, ETC = 6, Rain = 0, };
            var lTD_North_20151125 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151125", Date = new DateTime(2015, 11, 25), RegionId = lRegion.RegionId, Min = 15.7, Max = 28.3, Average = 22, ETC = 7.3, Rain = 7.9, };
            var lTD_North_20151126 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151126", Date = new DateTime(2015, 11, 26), RegionId = lRegion.RegionId, Min = 17.9, Max = 24.3, Average = 21.1, ETC = 3.4, Rain = 8.6, };
            var lTD_North_20151127 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151127", Date = new DateTime(2015, 11, 27), RegionId = lRegion.RegionId, Min = 20.9, Max = 26, Average = 23.5, ETC = 2.8, Rain = 19.3, };
            var lTD_North_20151128 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151128", Date = new DateTime(2015, 11, 28), RegionId = lRegion.RegionId, Min = 17, Max = 26.6, Average = 21.8, ETC = 6, Rain = 0, };
            var lTD_North_20151129 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151129", Date = new DateTime(2015, 11, 29), RegionId = lRegion.RegionId, Min = 14.3, Max = 27, Average = 20.7, ETC = 6.3, Rain = 0, };
            var lTD_North_20151130 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151130", Date = new DateTime(2015, 11, 30), RegionId = lRegion.RegionId, Min = 14.1, Max = 28.2, Average = 21.2, ETC = 6.8, Rain = 0, };
            var lTD_North_20151201 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151201", Date = new DateTime(2015, 12, 01), RegionId = lRegion.RegionId, Min = 17, Max = 27.8, Average = 22.4, ETC = 5.3, Rain = 0, };
            var lTD_North_20151202 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151202", Date = new DateTime(2015, 12, 02), RegionId = lRegion.RegionId, Min = 16, Max = 27.4, Average = 21.7, ETC = 5.3, Rain = 0, };
            var lTD_North_20151203 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151203", Date = new DateTime(2015, 12, 03), RegionId = lRegion.RegionId, Min = 21.1, Max = 27.1, Average = 24.1, ETC = 2.8, Rain = 0, };
            var lTD_North_20151204 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151204", Date = new DateTime(2015, 12, 04), RegionId = lRegion.RegionId, Min = 18.1, Max = 32.2, Average = 25.2, ETC = 4.9, Rain = 0, };
            var lTD_North_20151205 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151205", Date = new DateTime(2015, 12, 05), RegionId = lRegion.RegionId, Min = 18.8, Max = 28.8, Average = 23.8, ETC = 5.4, Rain = 0, };
            var lTD_North_20151206 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151206", Date = new DateTime(2015, 12, 06), RegionId = lRegion.RegionId, Min = 15.7, Max = 26.6, Average = 21.2, ETC = 5.7, Rain = 0, };
            var lTD_North_20151207 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151207", Date = new DateTime(2015, 12, 07), RegionId = lRegion.RegionId, Min = 12, Max = 28.5, Average = 20.3, ETC = 5.9, Rain = 0, };
            var lTD_North_20151208 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151208", Date = new DateTime(2015, 12, 08), RegionId = lRegion.RegionId, Min = 14.6, Max = 30.8, Average = 22.7, ETC = 6.3, Rain = 4, };
            var lTD_North_20151209 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151209", Date = new DateTime(2015, 12, 09), RegionId = lRegion.RegionId, Min = 18.2, Max = 24.8, Average = 21.5, ETC = 2.5, Rain = 2.9, };
            var lTD_North_20151210 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151210", Date = new DateTime(2015, 12, 10), RegionId = lRegion.RegionId, Min = 17.4, Max = 31.3, Average = 24.4, ETC = 5.8, Rain = 0, };
            var lTD_North_20151211 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151211", Date = new DateTime(2015, 12, 11), RegionId = lRegion.RegionId, Min = 19.3, Max = 31.4, Average = 25.4, ETC = 6.5, Rain = 0, };
            var lTD_North_20151212 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151212", Date = new DateTime(2015, 12, 12), RegionId = lRegion.RegionId, Min = 20.3, Max = 34.2, Average = 27.3, ETC = 5.7, Rain = 36.6, };
            var lTD_North_20151213 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151213", Date = new DateTime(2015, 12, 13), RegionId = lRegion.RegionId, Min = 21.2, Max = 29.5, Average = 25.4, ETC = 6.2, Rain = 0, };
            var lTD_North_20151214 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151214", Date = new DateTime(2015, 12, 14), RegionId = lRegion.RegionId, Min = 20.9, Max = 26.9, Average = 23.9, ETC = 2.7, Rain = 24.3, };
            var lTD_North_20151215 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151215", Date = new DateTime(2015, 12, 15), RegionId = lRegion.RegionId, Min = 18.2, Max = 30.3, Average = 24.3, ETC = 6.5, Rain = 0, };
            var lTD_North_20151216 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151216", Date = new DateTime(2015, 12, 16), RegionId = lRegion.RegionId, Min = 18.9, Max = 30.9, Average = 24.9, ETC = 7.6, Rain = 0, };
            var lTD_North_20151217 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151217", Date = new DateTime(2015, 12, 17), RegionId = lRegion.RegionId, Min = 21.5, Max = 26.3, Average = 23.9, ETC = 2.4, Rain = 47.7, };
            var lTD_North_20151218 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151218", Date = new DateTime(2015, 12, 18), RegionId = lRegion.RegionId, Min = 20, Max = 25.5, Average = 22.8, ETC = 3.7, Rain = 1.7, };
            var lTD_North_20151219 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151219", Date = new DateTime(2015, 12, 19), RegionId = lRegion.RegionId, Min = 15.9, Max = 25.9, Average = 20.9, ETC = 6.7, Rain = 0, };
            var lTD_North_20151220 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151220", Date = new DateTime(2015, 12, 20), RegionId = lRegion.RegionId, Min = 15.3, Max = 28.9, Average = 22.1, ETC = 6.1, Rain = 0, };
            var lTD_North_20151221 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151221", Date = new DateTime(2015, 12, 21), RegionId = lRegion.RegionId, Min = 20.2, Max = 29.4, Average = 24.8, ETC = 3.5, Rain = 34.6, };
            var lTD_North_20151222 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151222", Date = new DateTime(2015, 12, 22), RegionId = lRegion.RegionId, Min = 21.6, Max = 23.2, Average = 22.4, ETC = 1.9, Rain = 43.8, };
            var lTD_North_20151223 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151223", Date = new DateTime(2015, 12, 23), RegionId = lRegion.RegionId, Min = 19.7, Max = 25.2, Average = 22.5, ETC = 2.4, Rain = 21.2, };
            var lTD_North_20151224 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151224", Date = new DateTime(2015, 12, 24), RegionId = lRegion.RegionId, Min = 20.9, Max = 29.4, Average = 25.2, ETC = 3.6, Rain = 0, };
            var lTD_North_20151225 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151225", Date = new DateTime(2015, 12, 25), RegionId = lRegion.RegionId, Min = 18.6, Max = 30, Average = 24.3, ETC = 5.8, Rain = 0, };
            var lTD_North_20151226 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151226", Date = new DateTime(2015, 12, 26), RegionId = lRegion.RegionId, Min = 20.4, Max = 30, Average = 25.2, ETC = 5.7, Rain = 0, };
            var lTD_North_20151227 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151227", Date = new DateTime(2015, 12, 27), RegionId = lRegion.RegionId, Min = 21.4, Max = 32.9, Average = 27.2, ETC = 6.4, Rain = 0, };
            var lTD_North_20151228 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151228", Date = new DateTime(2015, 12, 28), RegionId = lRegion.RegionId, Min = 22.4, Max = 33.2, Average = 27.8, ETC = 4.3, Rain = 3.7, };
            var lTD_North_20151229 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151229", Date = new DateTime(2015, 12, 29), RegionId = lRegion.RegionId, Min = 24.8, Max = 28.2, Average = 26.5, ETC = 2.4, Rain = 6.4, };
            var lTD_North_20151230 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151230", Date = new DateTime(2015, 12, 30), RegionId = lRegion.RegionId, Min = 23.6, Max = 30.8, Average = 27.2, ETC = 4.9, Rain = 1.5, };
            var lTD_North_20151231 = new TemperatureData { Name = Utils.NameRegionNorth + "-20151231", Date = new DateTime(2015, 12, 31), RegionId = lRegion.RegionId, Min = 21, Max = 30, Average = 25.5, ETC = 4, Rain = 0, };
            #endregion

            #region 2015 context Add
            context.TemperatureDatas.Add(lTD_North_20150101);
            context.TemperatureDatas.Add(lTD_North_20150102);
            context.TemperatureDatas.Add(lTD_North_20150103);
            context.TemperatureDatas.Add(lTD_North_20150104);
            context.TemperatureDatas.Add(lTD_North_20150105);
            context.TemperatureDatas.Add(lTD_North_20150106);
            context.TemperatureDatas.Add(lTD_North_20150107);
            context.TemperatureDatas.Add(lTD_North_20150108);
            context.TemperatureDatas.Add(lTD_North_20150109);
            context.TemperatureDatas.Add(lTD_North_20150110);
            context.TemperatureDatas.Add(lTD_North_20150111);
            context.TemperatureDatas.Add(lTD_North_20150112);
            context.TemperatureDatas.Add(lTD_North_20150113);
            context.TemperatureDatas.Add(lTD_North_20150114);
            context.TemperatureDatas.Add(lTD_North_20150115);
            context.TemperatureDatas.Add(lTD_North_20150116);
            context.TemperatureDatas.Add(lTD_North_20150117);
            context.TemperatureDatas.Add(lTD_North_20150118);
            context.TemperatureDatas.Add(lTD_North_20150119);
            context.TemperatureDatas.Add(lTD_North_20150120);
            context.TemperatureDatas.Add(lTD_North_20150121);
            context.TemperatureDatas.Add(lTD_North_20150122);
            context.TemperatureDatas.Add(lTD_North_20150123);
            context.TemperatureDatas.Add(lTD_North_20150124);
            context.TemperatureDatas.Add(lTD_North_20150125);
            context.TemperatureDatas.Add(lTD_North_20150126);
            context.TemperatureDatas.Add(lTD_North_20150127);
            context.TemperatureDatas.Add(lTD_North_20150128);
            context.TemperatureDatas.Add(lTD_North_20150129);
            context.TemperatureDatas.Add(lTD_North_20150130);
            context.TemperatureDatas.Add(lTD_North_20150131);
            context.TemperatureDatas.Add(lTD_North_20150201);
            context.TemperatureDatas.Add(lTD_North_20150202);
            context.TemperatureDatas.Add(lTD_North_20150203);
            context.TemperatureDatas.Add(lTD_North_20150204);
            context.TemperatureDatas.Add(lTD_North_20150205);
            context.TemperatureDatas.Add(lTD_North_20150206);
            context.TemperatureDatas.Add(lTD_North_20150207);
            context.TemperatureDatas.Add(lTD_North_20150208);
            context.TemperatureDatas.Add(lTD_North_20150209);
            context.TemperatureDatas.Add(lTD_North_20150210);
            context.TemperatureDatas.Add(lTD_North_20150211);
            context.TemperatureDatas.Add(lTD_North_20150212);
            context.TemperatureDatas.Add(lTD_North_20150213);
            context.TemperatureDatas.Add(lTD_North_20150214);
            context.TemperatureDatas.Add(lTD_North_20150215);
            context.TemperatureDatas.Add(lTD_North_20150216);
            context.TemperatureDatas.Add(lTD_North_20150217);
            context.TemperatureDatas.Add(lTD_North_20150218);
            context.TemperatureDatas.Add(lTD_North_20150219);
            context.TemperatureDatas.Add(lTD_North_20150220);
            context.TemperatureDatas.Add(lTD_North_20150221);
            context.TemperatureDatas.Add(lTD_North_20150222);
            context.TemperatureDatas.Add(lTD_North_20150223);
            context.TemperatureDatas.Add(lTD_North_20150224);
            context.TemperatureDatas.Add(lTD_North_20150225);
            context.TemperatureDatas.Add(lTD_North_20150226);
            context.TemperatureDatas.Add(lTD_North_20150227);
            context.TemperatureDatas.Add(lTD_North_20150228);
            context.TemperatureDatas.Add(lTD_North_20150301);
            context.TemperatureDatas.Add(lTD_North_20150302);
            context.TemperatureDatas.Add(lTD_North_20150303);
            context.TemperatureDatas.Add(lTD_North_20150304);
            context.TemperatureDatas.Add(lTD_North_20150305);
            context.TemperatureDatas.Add(lTD_North_20150306);
            context.TemperatureDatas.Add(lTD_North_20150307);
            context.TemperatureDatas.Add(lTD_North_20150308);
            context.TemperatureDatas.Add(lTD_North_20150309);
            context.TemperatureDatas.Add(lTD_North_20150310);
            context.TemperatureDatas.Add(lTD_North_20150311);
            context.TemperatureDatas.Add(lTD_North_20150312);
            context.TemperatureDatas.Add(lTD_North_20150313);
            context.TemperatureDatas.Add(lTD_North_20150314);
            context.TemperatureDatas.Add(lTD_North_20150315);
            context.TemperatureDatas.Add(lTD_North_20150316);
            context.TemperatureDatas.Add(lTD_North_20150317);
            context.TemperatureDatas.Add(lTD_North_20150318);
            context.TemperatureDatas.Add(lTD_North_20150319);
            context.TemperatureDatas.Add(lTD_North_20150320);
            context.TemperatureDatas.Add(lTD_North_20150321);
            context.TemperatureDatas.Add(lTD_North_20150322);
            context.TemperatureDatas.Add(lTD_North_20150323);
            context.TemperatureDatas.Add(lTD_North_20150324);
            context.TemperatureDatas.Add(lTD_North_20150325);
            context.TemperatureDatas.Add(lTD_North_20150326);
            context.TemperatureDatas.Add(lTD_North_20150327);
            context.TemperatureDatas.Add(lTD_North_20150328);
            context.TemperatureDatas.Add(lTD_North_20150329);
            context.TemperatureDatas.Add(lTD_North_20150330);
            context.TemperatureDatas.Add(lTD_North_20150331);
            context.TemperatureDatas.Add(lTD_North_20150401);
            context.TemperatureDatas.Add(lTD_North_20150402);
            context.TemperatureDatas.Add(lTD_North_20150403);
            context.TemperatureDatas.Add(lTD_North_20150404);
            context.TemperatureDatas.Add(lTD_North_20150405);
            context.TemperatureDatas.Add(lTD_North_20150406);
            context.TemperatureDatas.Add(lTD_North_20150407);
            context.TemperatureDatas.Add(lTD_North_20150408);
            context.TemperatureDatas.Add(lTD_North_20150409);
            context.TemperatureDatas.Add(lTD_North_20150410);
            context.TemperatureDatas.Add(lTD_North_20150411);
            context.TemperatureDatas.Add(lTD_North_20150412);
            context.TemperatureDatas.Add(lTD_North_20150413);
            context.TemperatureDatas.Add(lTD_North_20150414);
            context.TemperatureDatas.Add(lTD_North_20150415);
            context.TemperatureDatas.Add(lTD_North_20150416);
            context.TemperatureDatas.Add(lTD_North_20150417);
            context.TemperatureDatas.Add(lTD_North_20150418);
            context.TemperatureDatas.Add(lTD_North_20150419);
            context.TemperatureDatas.Add(lTD_North_20150420);
            context.TemperatureDatas.Add(lTD_North_20150421);
            context.TemperatureDatas.Add(lTD_North_20150422);
            context.TemperatureDatas.Add(lTD_North_20150423);
            context.TemperatureDatas.Add(lTD_North_20150424);
            context.TemperatureDatas.Add(lTD_North_20150425);
            context.TemperatureDatas.Add(lTD_North_20150426);
            context.TemperatureDatas.Add(lTD_North_20150427);
            context.TemperatureDatas.Add(lTD_North_20150428);
            context.TemperatureDatas.Add(lTD_North_20150429);
            context.TemperatureDatas.Add(lTD_North_20150430);
            context.TemperatureDatas.Add(lTD_North_20150501);
            context.TemperatureDatas.Add(lTD_North_20150502);
            context.TemperatureDatas.Add(lTD_North_20150503);
            context.TemperatureDatas.Add(lTD_North_20150504);
            context.TemperatureDatas.Add(lTD_North_20150505);
            context.TemperatureDatas.Add(lTD_North_20150506);
            context.TemperatureDatas.Add(lTD_North_20150507);
            context.TemperatureDatas.Add(lTD_North_20150508);
            context.TemperatureDatas.Add(lTD_North_20150509);
            context.TemperatureDatas.Add(lTD_North_20150510);
            context.TemperatureDatas.Add(lTD_North_20150511);
            context.TemperatureDatas.Add(lTD_North_20150512);
            context.TemperatureDatas.Add(lTD_North_20150513);
            context.TemperatureDatas.Add(lTD_North_20150514);
            context.TemperatureDatas.Add(lTD_North_20150515);
            context.TemperatureDatas.Add(lTD_North_20150516);
            context.TemperatureDatas.Add(lTD_North_20150517);
            context.TemperatureDatas.Add(lTD_North_20150518);
            context.TemperatureDatas.Add(lTD_North_20150519);
            context.TemperatureDatas.Add(lTD_North_20150520);
            context.TemperatureDatas.Add(lTD_North_20150521);
            context.TemperatureDatas.Add(lTD_North_20150522);
            context.TemperatureDatas.Add(lTD_North_20150523);
            context.TemperatureDatas.Add(lTD_North_20150524);
            context.TemperatureDatas.Add(lTD_North_20150525);
            context.TemperatureDatas.Add(lTD_North_20150526);
            context.TemperatureDatas.Add(lTD_North_20150527);
            context.TemperatureDatas.Add(lTD_North_20150528);
            context.TemperatureDatas.Add(lTD_North_20150529);
            context.TemperatureDatas.Add(lTD_North_20150530);
            context.TemperatureDatas.Add(lTD_North_20150531);
            context.TemperatureDatas.Add(lTD_North_20150601);
            context.TemperatureDatas.Add(lTD_North_20150602);
            context.TemperatureDatas.Add(lTD_North_20150603);
            context.TemperatureDatas.Add(lTD_North_20150604);
            context.TemperatureDatas.Add(lTD_North_20150605);
            context.TemperatureDatas.Add(lTD_North_20150606);
            context.TemperatureDatas.Add(lTD_North_20150607);
            context.TemperatureDatas.Add(lTD_North_20150608);
            context.TemperatureDatas.Add(lTD_North_20150609);
            context.TemperatureDatas.Add(lTD_North_20150610);
            context.TemperatureDatas.Add(lTD_North_20150611);
            context.TemperatureDatas.Add(lTD_North_20150612);
            context.TemperatureDatas.Add(lTD_North_20150613);
            context.TemperatureDatas.Add(lTD_North_20150614);
            context.TemperatureDatas.Add(lTD_North_20150615);
            context.TemperatureDatas.Add(lTD_North_20150616);
            context.TemperatureDatas.Add(lTD_North_20150617);
            context.TemperatureDatas.Add(lTD_North_20150618);
            context.TemperatureDatas.Add(lTD_North_20150619);
            context.TemperatureDatas.Add(lTD_North_20150620);
            context.TemperatureDatas.Add(lTD_North_20150621);
            context.TemperatureDatas.Add(lTD_North_20150622);
            context.TemperatureDatas.Add(lTD_North_20150623);
            context.TemperatureDatas.Add(lTD_North_20150624);
            context.TemperatureDatas.Add(lTD_North_20150625);
            context.TemperatureDatas.Add(lTD_North_20150626);
            context.TemperatureDatas.Add(lTD_North_20150627);
            context.TemperatureDatas.Add(lTD_North_20150628);
            context.TemperatureDatas.Add(lTD_North_20150629);
            context.TemperatureDatas.Add(lTD_North_20150630);
            context.TemperatureDatas.Add(lTD_North_20150701);
            context.TemperatureDatas.Add(lTD_North_20150702);
            context.TemperatureDatas.Add(lTD_North_20150703);
            context.TemperatureDatas.Add(lTD_North_20150704);
            context.TemperatureDatas.Add(lTD_North_20150705);
            context.TemperatureDatas.Add(lTD_North_20150706);
            context.TemperatureDatas.Add(lTD_North_20150707);
            context.TemperatureDatas.Add(lTD_North_20150708);
            context.TemperatureDatas.Add(lTD_North_20150709);
            context.TemperatureDatas.Add(lTD_North_20150710);
            context.TemperatureDatas.Add(lTD_North_20150711);
            context.TemperatureDatas.Add(lTD_North_20150712);
            context.TemperatureDatas.Add(lTD_North_20150713);
            context.TemperatureDatas.Add(lTD_North_20150714);
            context.TemperatureDatas.Add(lTD_North_20150715);
            context.TemperatureDatas.Add(lTD_North_20150716);
            context.TemperatureDatas.Add(lTD_North_20150717);
            context.TemperatureDatas.Add(lTD_North_20150718);
            context.TemperatureDatas.Add(lTD_North_20150719);
            context.TemperatureDatas.Add(lTD_North_20150720);
            context.TemperatureDatas.Add(lTD_North_20150721);
            context.TemperatureDatas.Add(lTD_North_20150722);
            context.TemperatureDatas.Add(lTD_North_20150723);
            context.TemperatureDatas.Add(lTD_North_20150724);
            context.TemperatureDatas.Add(lTD_North_20150725);
            context.TemperatureDatas.Add(lTD_North_20150726);
            context.TemperatureDatas.Add(lTD_North_20150727);
            context.TemperatureDatas.Add(lTD_North_20150728);
            context.TemperatureDatas.Add(lTD_North_20150729);
            context.TemperatureDatas.Add(lTD_North_20150730);
            context.TemperatureDatas.Add(lTD_North_20150731);
            context.TemperatureDatas.Add(lTD_North_20150801);
            context.TemperatureDatas.Add(lTD_North_20150802);
            context.TemperatureDatas.Add(lTD_North_20150803);
            context.TemperatureDatas.Add(lTD_North_20150804);
            context.TemperatureDatas.Add(lTD_North_20150805);
            context.TemperatureDatas.Add(lTD_North_20150806);
            context.TemperatureDatas.Add(lTD_North_20150807);
            context.TemperatureDatas.Add(lTD_North_20150808);
            context.TemperatureDatas.Add(lTD_North_20150809);
            context.TemperatureDatas.Add(lTD_North_20150810);
            context.TemperatureDatas.Add(lTD_North_20150811);
            context.TemperatureDatas.Add(lTD_North_20150812);
            context.TemperatureDatas.Add(lTD_North_20150813);
            context.TemperatureDatas.Add(lTD_North_20150814);
            context.TemperatureDatas.Add(lTD_North_20150815);
            context.TemperatureDatas.Add(lTD_North_20150816);
            context.TemperatureDatas.Add(lTD_North_20150817);
            context.TemperatureDatas.Add(lTD_North_20150818);
            context.TemperatureDatas.Add(lTD_North_20150819);
            context.TemperatureDatas.Add(lTD_North_20150820);
            context.TemperatureDatas.Add(lTD_North_20150821);
            context.TemperatureDatas.Add(lTD_North_20150822);
            context.TemperatureDatas.Add(lTD_North_20150823);
            context.TemperatureDatas.Add(lTD_North_20150824);
            context.TemperatureDatas.Add(lTD_North_20150825);
            context.TemperatureDatas.Add(lTD_North_20150826);
            context.TemperatureDatas.Add(lTD_North_20150827);
            context.TemperatureDatas.Add(lTD_North_20150828);
            context.TemperatureDatas.Add(lTD_North_20150829);
            context.TemperatureDatas.Add(lTD_North_20150830);
            context.TemperatureDatas.Add(lTD_North_20150831);
            context.TemperatureDatas.Add(lTD_North_20150901);
            context.TemperatureDatas.Add(lTD_North_20150902);
            context.TemperatureDatas.Add(lTD_North_20150903);
            context.TemperatureDatas.Add(lTD_North_20150904);
            context.TemperatureDatas.Add(lTD_North_20150905);
            context.TemperatureDatas.Add(lTD_North_20150906);
            context.TemperatureDatas.Add(lTD_North_20150907);
            context.TemperatureDatas.Add(lTD_North_20150908);
            context.TemperatureDatas.Add(lTD_North_20150909);
            context.TemperatureDatas.Add(lTD_North_20150910);
            context.TemperatureDatas.Add(lTD_North_20150911);
            context.TemperatureDatas.Add(lTD_North_20150912);
            context.TemperatureDatas.Add(lTD_North_20150913);
            context.TemperatureDatas.Add(lTD_North_20150914);
            context.TemperatureDatas.Add(lTD_North_20150915);
            context.TemperatureDatas.Add(lTD_North_20150916);
            context.TemperatureDatas.Add(lTD_North_20150917);
            context.TemperatureDatas.Add(lTD_North_20150918);
            context.TemperatureDatas.Add(lTD_North_20150919);
            context.TemperatureDatas.Add(lTD_North_20150920);
            context.TemperatureDatas.Add(lTD_North_20150921);
            context.TemperatureDatas.Add(lTD_North_20150922);
            context.TemperatureDatas.Add(lTD_North_20150923);
            context.TemperatureDatas.Add(lTD_North_20150924);
            context.TemperatureDatas.Add(lTD_North_20150925);
            context.TemperatureDatas.Add(lTD_North_20150926);
            context.TemperatureDatas.Add(lTD_North_20150927);
            context.TemperatureDatas.Add(lTD_North_20150928);
            context.TemperatureDatas.Add(lTD_North_20150929);
            context.TemperatureDatas.Add(lTD_North_20150930);
            context.TemperatureDatas.Add(lTD_North_20151001);
            context.TemperatureDatas.Add(lTD_North_20151002);
            context.TemperatureDatas.Add(lTD_North_20151003);
            context.TemperatureDatas.Add(lTD_North_20151004);
            context.TemperatureDatas.Add(lTD_North_20151005);
            context.TemperatureDatas.Add(lTD_North_20151006);
            context.TemperatureDatas.Add(lTD_North_20151007);
            context.TemperatureDatas.Add(lTD_North_20151008);
            context.TemperatureDatas.Add(lTD_North_20151009);
            context.TemperatureDatas.Add(lTD_North_20151010);
            context.TemperatureDatas.Add(lTD_North_20151011);
            context.TemperatureDatas.Add(lTD_North_20151012);
            context.TemperatureDatas.Add(lTD_North_20151013);
            context.TemperatureDatas.Add(lTD_North_20151014);
            context.TemperatureDatas.Add(lTD_North_20151015);
            context.TemperatureDatas.Add(lTD_North_20151016);
            context.TemperatureDatas.Add(lTD_North_20151017);
            context.TemperatureDatas.Add(lTD_North_20151018);
            context.TemperatureDatas.Add(lTD_North_20151019);
            context.TemperatureDatas.Add(lTD_North_20151020);
            context.TemperatureDatas.Add(lTD_North_20151021);
            context.TemperatureDatas.Add(lTD_North_20151022);
            context.TemperatureDatas.Add(lTD_North_20151023);
            context.TemperatureDatas.Add(lTD_North_20151024);
            context.TemperatureDatas.Add(lTD_North_20151025);
            context.TemperatureDatas.Add(lTD_North_20151026);
            context.TemperatureDatas.Add(lTD_North_20151027);
            context.TemperatureDatas.Add(lTD_North_20151028);
            context.TemperatureDatas.Add(lTD_North_20151029);
            context.TemperatureDatas.Add(lTD_North_20151030);
            context.TemperatureDatas.Add(lTD_North_20151031);
            context.TemperatureDatas.Add(lTD_North_20151101);
            context.TemperatureDatas.Add(lTD_North_20151102);
            context.TemperatureDatas.Add(lTD_North_20151103);
            context.TemperatureDatas.Add(lTD_North_20151104);
            context.TemperatureDatas.Add(lTD_North_20151105);
            context.TemperatureDatas.Add(lTD_North_20151106);
            context.TemperatureDatas.Add(lTD_North_20151107);
            context.TemperatureDatas.Add(lTD_North_20151108);
            context.TemperatureDatas.Add(lTD_North_20151109);
            context.TemperatureDatas.Add(lTD_North_20151110);
            context.TemperatureDatas.Add(lTD_North_20151111);
            context.TemperatureDatas.Add(lTD_North_20151112);
            context.TemperatureDatas.Add(lTD_North_20151113);
            context.TemperatureDatas.Add(lTD_North_20151114);
            context.TemperatureDatas.Add(lTD_North_20151115);
            context.TemperatureDatas.Add(lTD_North_20151116);
            context.TemperatureDatas.Add(lTD_North_20151117);
            context.TemperatureDatas.Add(lTD_North_20151118);
            context.TemperatureDatas.Add(lTD_North_20151119);
            context.TemperatureDatas.Add(lTD_North_20151120);
            context.TemperatureDatas.Add(lTD_North_20151121);
            context.TemperatureDatas.Add(lTD_North_20151122);
            context.TemperatureDatas.Add(lTD_North_20151123);
            context.TemperatureDatas.Add(lTD_North_20151124);
            context.TemperatureDatas.Add(lTD_North_20151125);
            context.TemperatureDatas.Add(lTD_North_20151126);
            context.TemperatureDatas.Add(lTD_North_20151127);
            context.TemperatureDatas.Add(lTD_North_20151128);
            context.TemperatureDatas.Add(lTD_North_20151129);
            context.TemperatureDatas.Add(lTD_North_20151130);
            context.TemperatureDatas.Add(lTD_North_20151201);
            context.TemperatureDatas.Add(lTD_North_20151202);
            context.TemperatureDatas.Add(lTD_North_20151203);
            context.TemperatureDatas.Add(lTD_North_20151204);
            context.TemperatureDatas.Add(lTD_North_20151205);
            context.TemperatureDatas.Add(lTD_North_20151206);
            context.TemperatureDatas.Add(lTD_North_20151207);
            context.TemperatureDatas.Add(lTD_North_20151208);
            context.TemperatureDatas.Add(lTD_North_20151209);
            context.TemperatureDatas.Add(lTD_North_20151210);
            context.TemperatureDatas.Add(lTD_North_20151211);
            context.TemperatureDatas.Add(lTD_North_20151212);
            context.TemperatureDatas.Add(lTD_North_20151213);
            context.TemperatureDatas.Add(lTD_North_20151214);
            context.TemperatureDatas.Add(lTD_North_20151215);
            context.TemperatureDatas.Add(lTD_North_20151216);
            context.TemperatureDatas.Add(lTD_North_20151217);
            context.TemperatureDatas.Add(lTD_North_20151218);
            context.TemperatureDatas.Add(lTD_North_20151219);
            context.TemperatureDatas.Add(lTD_North_20151220);
            context.TemperatureDatas.Add(lTD_North_20151221);
            context.TemperatureDatas.Add(lTD_North_20151222);
            context.TemperatureDatas.Add(lTD_North_20151223);
            context.TemperatureDatas.Add(lTD_North_20151224);
            context.TemperatureDatas.Add(lTD_North_20151225);
            context.TemperatureDatas.Add(lTD_North_20151226);
            context.TemperatureDatas.Add(lTD_North_20151227);
            context.TemperatureDatas.Add(lTD_North_20151228);
            context.TemperatureDatas.Add(lTD_North_20151229);
            context.TemperatureDatas.Add(lTD_North_20151230);
            context.TemperatureDatas.Add(lTD_North_20151231);
            #endregion

            #endregion

        }


        public static void DataTemperatures_North_2016(IrrigationAdvisorContext context, Region pRegion)
        {
            Region lRegion = pRegion;

            #region North

            #region 2016 new TemperatureData
            var lTD_North_20160101 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160101", Date = new DateTime(2016, 01, 01), RegionId = lRegion.RegionId, Min = 21.2, Max = 30.8, Average = 26, ETC = 5.3, Rain = 0, };
            var lTD_North_20160102 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160102", Date = new DateTime(2016, 01, 02), RegionId = lRegion.RegionId, Min = 20.7, Max = 31.9, Average = 26.3, ETC = 6.6, Rain = 0, };
            var lTD_North_20160103 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160103", Date = new DateTime(2016, 01, 03), RegionId = lRegion.RegionId, Min = 21.6, Max = 33.8, Average = 27.7, ETC = 6.1, Rain = 0, };
            var lTD_North_20160104 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160104", Date = new DateTime(2016, 01, 04), RegionId = lRegion.RegionId, Min = 22.1, Max = 29.2, Average = 25.7, ETC = 2.9, Rain = 10.8, };
            var lTD_North_20160105 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160105", Date = new DateTime(2016, 01, 05), RegionId = lRegion.RegionId, Min = 21.3, Max = 30.8, Average = 26.1, ETC = 4.6, Rain = 0.2, };
            var lTD_North_20160106 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160106", Date = new DateTime(2016, 01, 06), RegionId = lRegion.RegionId, Min = 22.2, Max = 27.2, Average = 24.7, ETC = 3.4, Rain = 0, };
            var lTD_North_20160107 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160107", Date = new DateTime(2016, 01, 07), RegionId = lRegion.RegionId, Min = 17.3, Max = 28.7, Average = 23, ETC = 5.5, Rain = 0, };
            var lTD_North_20160108 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160108", Date = new DateTime(2016, 01, 08), RegionId = lRegion.RegionId, Min = 17.4, Max = 30.4, Average = 23.9, ETC = 4.7, Rain = 0, };
            var lTD_North_20160109 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160109", Date = new DateTime(2016, 01, 09), RegionId = lRegion.RegionId, Min = 18.9, Max = 32, Average = 25.5, ETC = 7.1, Rain = 0, };
            var lTD_North_20160110 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160110", Date = new DateTime(2016, 01, 10), RegionId = lRegion.RegionId, Min = 21, Max = 32.2, Average = 26.6, ETC = 4.1, Rain = 0, };
            var lTD_North_20160111 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160111", Date = new DateTime(2016, 01, 11), RegionId = lRegion.RegionId, Min = 22.1, Max = 32.7, Average = 27.4, ETC = 5.5, Rain = 0, };
            var lTD_North_20160112 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160112", Date = new DateTime(2016, 01, 12), RegionId = lRegion.RegionId, Min = 20.2, Max = 34.9, Average = 27.6, ETC = 5.5, Rain = 6.4, };
            var lTD_North_20160113 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160113", Date = new DateTime(2016, 01, 13), RegionId = lRegion.RegionId, Min = 18.7, Max = 31.2, Average = 25, ETC = 5.5, Rain = 0, };
            var lTD_North_20160114 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160114", Date = new DateTime(2016, 01, 14), RegionId = lRegion.RegionId, Min = 17.6, Max = 32.1, Average = 24.9, ETC = 6.6, Rain = 0, };
            var lTD_North_20160115 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160115", Date = new DateTime(2016, 01, 15), RegionId = lRegion.RegionId, Min = 17.2, Max = 34, Average = 25.6, ETC = 6.4, Rain = 0, };
            var lTD_North_20160116 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160116", Date = new DateTime(2016, 01, 16), RegionId = lRegion.RegionId, Min = 20.5, Max = 34.6, Average = 27.6, ETC = 6.8, Rain = 0, };
            var lTD_North_20160117 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160117", Date = new DateTime(2016, 01, 17), RegionId = lRegion.RegionId, Min = 22.4, Max = 36.1, Average = 29.3, ETC = 6.5, Rain = 0, };
            var lTD_North_20160118 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160118", Date = new DateTime(2016, 01, 18), RegionId = lRegion.RegionId, Min = 20.2, Max = 36.8, Average = 28.5, ETC = 7.1, Rain = 0, };
            var lTD_North_20160119 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160119", Date = new DateTime(2016, 01, 19), RegionId = lRegion.RegionId, Min = 22.1, Max = 35.8, Average = 29, ETC = 7.2, Rain = 0, };
            var lTD_North_20160120 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160120", Date = new DateTime(2016, 01, 20), RegionId = lRegion.RegionId, Min = 23.2, Max = 35.9, Average = 29.6, ETC = 6.7, Rain = 0, };
            var lTD_North_20160121 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160121", Date = new DateTime(2016, 01, 21), RegionId = lRegion.RegionId, Min = 21.8, Max = 35.5, Average = 28.7, ETC = 7.3, Rain = 0, };
            var lTD_North_20160122 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160122", Date = new DateTime(2016, 01, 22), RegionId = lRegion.RegionId, Min = 23.3, Max = 35.8, Average = 29.6, ETC = 7.3, Rain = 0, };
            var lTD_North_20160123 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160123", Date = new DateTime(2016, 01, 23), RegionId = lRegion.RegionId, Min = 24.1, Max = 38.2, Average = 31.2, ETC = 7.3, Rain = 0, };
            var lTD_North_20160124 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160124", Date = new DateTime(2016, 01, 24), RegionId = lRegion.RegionId, Min = 24.9, Max = 37.2, Average = 31.1, ETC = 8.3, Rain = 2.3, };
            var lTD_North_20160125 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160125", Date = new DateTime(2016, 01, 25), RegionId = lRegion.RegionId, Min = 19.8, Max = 29.7, Average = 24.8, ETC = 4.8, Rain = 5.4, };
            var lTD_North_20160126 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160126", Date = new DateTime(2016, 01, 26), RegionId = lRegion.RegionId, Min = 19.9, Max = 31.2, Average = 25.6, ETC = 5.6, Rain = 0, };
            var lTD_North_20160127 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160127", Date = new DateTime(2016, 01, 27), RegionId = lRegion.RegionId, Min = 17.1, Max = 30.5, Average = 23.8, ETC = 6.4, Rain = 0, };
            var lTD_North_20160128 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160128", Date = new DateTime(2016, 01, 28), RegionId = lRegion.RegionId, Min = 19.7, Max = 33.6, Average = 26.7, ETC = 6.9, Rain = 0, };
            var lTD_North_20160129 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160129", Date = new DateTime(2016, 01, 29), RegionId = lRegion.RegionId, Min = 22.5, Max = 31.2, Average = 26.9, ETC = 3.1, Rain = 0, };
            var lTD_North_20160130 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160130", Date = new DateTime(2016, 01, 30), RegionId = lRegion.RegionId, Min = 23.6, Max = 33, Average = 28.3, ETC = 4.9, Rain = 0, };
            var lTD_North_20160131 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160131", Date = new DateTime(2016, 01, 31), RegionId = lRegion.RegionId, Min = 21, Max = 33.3, Average = 27.2, ETC = 7.8, Rain = 0, };
            var lTD_North_20160201 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160201", Date = new DateTime(2016, 02, 01), RegionId = lRegion.RegionId, Min = 18.3, Max = 30.7, Average = 24.5, ETC = 6.1, Rain = 0, };
            var lTD_North_20160202 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160202", Date = new DateTime(2016, 02, 02), RegionId = lRegion.RegionId, Min = 14.1, Max = 31.8, Average = 23, ETC = 5.8, Rain = 0, };
            var lTD_North_20160203 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160203", Date = new DateTime(2016, 02, 03), RegionId = lRegion.RegionId, Min = 18.1, Max = 31.9, Average = 25, ETC = 5.3, Rain = 0, };
            var lTD_North_20160204 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160204", Date = new DateTime(2016, 02, 04), RegionId = lRegion.RegionId, Min = 20, Max = 34.4, Average = 27.2, ETC = 6, Rain = 0, };
            var lTD_North_20160205 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160205", Date = new DateTime(2016, 02, 05), RegionId = lRegion.RegionId, Min = 19.4, Max = 36.4, Average = 27.9, ETC = 6.6, Rain = 0, };
            var lTD_North_20160206 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160206", Date = new DateTime(2016, 02, 06), RegionId = lRegion.RegionId, Min = 24.2, Max = 37.1, Average = 30.7, ETC = 6.9, Rain = 0, };
            var lTD_North_20160207 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160207", Date = new DateTime(2016, 02, 07), RegionId = lRegion.RegionId, Min = 21.2, Max = 35.5, Average = 28.4, ETC = 7.1, Rain = 10.3, };
            var lTD_North_20160208 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160208", Date = new DateTime(2016, 02, 08), RegionId = lRegion.RegionId, Min = 23.5, Max = 29.7, Average = 26.6, ETC = 2, Rain = 23.7, };
            var lTD_North_20160209 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160209", Date = new DateTime(2016, 02, 09), RegionId = lRegion.RegionId, Min = 23, Max = 32.4, Average = 27.7, ETC = 3.8, Rain = 0, };
            var lTD_North_20160210 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160210", Date = new DateTime(2016, 02, 10), RegionId = lRegion.RegionId, Min = 22.9, Max = 36.2, Average = 29.6, ETC = 6.9, Rain = 0, };
            var lTD_North_20160211 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160211", Date = new DateTime(2016, 02, 11), RegionId = lRegion.RegionId, Min = 22.3, Max = 35.9, Average = 29.1, ETC = 6.8, Rain = 0, };
            var lTD_North_20160212 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160212", Date = new DateTime(2016, 02, 12), RegionId = lRegion.RegionId, Min = 22.3, Max = 35.8, Average = 29.1, ETC = 6.7, Rain = 0, };
            var lTD_North_20160213 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160213", Date = new DateTime(2016, 02, 13), RegionId = lRegion.RegionId, Min = 22.1, Max = 29.5, Average = 25.8, ETC = 2.2, Rain = 47.2, };
            var lTD_North_20160214 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160214", Date = new DateTime(2016, 02, 14), RegionId = lRegion.RegionId, Min = 21.4, Max = 33.2, Average = 27.3, ETC = 5.6, Rain = 0, };
            var lTD_North_20160215 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160215", Date = new DateTime(2016, 02, 15), RegionId = lRegion.RegionId, Min = 22.7, Max = 33, Average = 27.9, ETC = 4.7, Rain = 0.3, };
            var lTD_North_20160216 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160216", Date = new DateTime(2016, 02, 16), RegionId = lRegion.RegionId, Min = 21.4, Max = 32.5, Average = 27, ETC = 6, Rain = 18.8, };
            var lTD_North_20160217 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160217", Date = new DateTime(2016, 02, 17), RegionId = lRegion.RegionId, Min = 20.7, Max = 27.8, Average = 24.3, ETC = 1.8, Rain = 12, };
            var lTD_North_20160218 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160218", Date = new DateTime(2016, 02, 18), RegionId = lRegion.RegionId, Min = 19.4, Max = 33.1, Average = 26.3, ETC = 5.1, Rain = 2.7, };
            var lTD_North_20160219 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160219", Date = new DateTime(2016, 02, 19), RegionId = lRegion.RegionId, Min = 17.9, Max = 25.4, Average = 21.7, ETC = 3.4, Rain = 36, };
            var lTD_North_20160220 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160220", Date = new DateTime(2016, 02, 20), RegionId = lRegion.RegionId, Min = 19.6, Max = 30.9, Average = 25.3, ETC = 5.6, Rain = 0, };
            var lTD_North_20160221 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160221", Date = new DateTime(2016, 02, 21), RegionId = lRegion.RegionId, Min = 22.1, Max = 32.6, Average = 27.4, ETC = 5.8, Rain = 0, };
            var lTD_North_20160222 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160222", Date = new DateTime(2016, 02, 22), RegionId = lRegion.RegionId, Min = 22.1, Max = 32.9, Average = 27.5, ETC = 5.6, Rain = 0, };
            var lTD_North_20160223 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160223", Date = new DateTime(2016, 02, 23), RegionId = lRegion.RegionId, Min = 20.2, Max = 33.8, Average = 27, ETC = 5.4, Rain = 0, };
            var lTD_North_20160224 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160224", Date = new DateTime(2016, 02, 24), RegionId = lRegion.RegionId, Min = 23, Max = 33.9, Average = 28.5, ETC = 5.6, Rain = 0, };
            var lTD_North_20160225 = new TemperatureData { Name = Utils.NameRegionNorth + "-20160225", Date = new DateTime(2016, 02, 25), RegionId = lRegion.RegionId, Min = 22.9, Max = 32.6, Average = 27.8, ETC = 4.4, Rain = 1.5, };
            #endregion

            #region 2016 context Add
            context.TemperatureDatas.Add(lTD_North_20160101);
            context.TemperatureDatas.Add(lTD_North_20160102);
            context.TemperatureDatas.Add(lTD_North_20160103);
            context.TemperatureDatas.Add(lTD_North_20160104);
            context.TemperatureDatas.Add(lTD_North_20160105);
            context.TemperatureDatas.Add(lTD_North_20160106);
            context.TemperatureDatas.Add(lTD_North_20160107);
            context.TemperatureDatas.Add(lTD_North_20160108);
            context.TemperatureDatas.Add(lTD_North_20160109);
            context.TemperatureDatas.Add(lTD_North_20160110);
            context.TemperatureDatas.Add(lTD_North_20160111);
            context.TemperatureDatas.Add(lTD_North_20160112);
            context.TemperatureDatas.Add(lTD_North_20160113);
            context.TemperatureDatas.Add(lTD_North_20160114);
            context.TemperatureDatas.Add(lTD_North_20160115);
            context.TemperatureDatas.Add(lTD_North_20160116);
            context.TemperatureDatas.Add(lTD_North_20160117);
            context.TemperatureDatas.Add(lTD_North_20160118);
            context.TemperatureDatas.Add(lTD_North_20160119);
            context.TemperatureDatas.Add(lTD_North_20160120);
            context.TemperatureDatas.Add(lTD_North_20160121);
            context.TemperatureDatas.Add(lTD_North_20160122);
            context.TemperatureDatas.Add(lTD_North_20160123);
            context.TemperatureDatas.Add(lTD_North_20160124);
            context.TemperatureDatas.Add(lTD_North_20160125);
            context.TemperatureDatas.Add(lTD_North_20160126);
            context.TemperatureDatas.Add(lTD_North_20160127);
            context.TemperatureDatas.Add(lTD_North_20160128);
            context.TemperatureDatas.Add(lTD_North_20160129);
            context.TemperatureDatas.Add(lTD_North_20160130);
            context.TemperatureDatas.Add(lTD_North_20160131);
            context.TemperatureDatas.Add(lTD_North_20160201);
            context.TemperatureDatas.Add(lTD_North_20160202);
            context.TemperatureDatas.Add(lTD_North_20160203);
            context.TemperatureDatas.Add(lTD_North_20160204);
            context.TemperatureDatas.Add(lTD_North_20160205);
            context.TemperatureDatas.Add(lTD_North_20160206);
            context.TemperatureDatas.Add(lTD_North_20160207);
            context.TemperatureDatas.Add(lTD_North_20160208);
            context.TemperatureDatas.Add(lTD_North_20160209);
            context.TemperatureDatas.Add(lTD_North_20160210);
            context.TemperatureDatas.Add(lTD_North_20160211);
            context.TemperatureDatas.Add(lTD_North_20160212);
            context.TemperatureDatas.Add(lTD_North_20160213);
            context.TemperatureDatas.Add(lTD_North_20160214);
            context.TemperatureDatas.Add(lTD_North_20160215);
            context.TemperatureDatas.Add(lTD_North_20160216);
            context.TemperatureDatas.Add(lTD_North_20160217);
            context.TemperatureDatas.Add(lTD_North_20160218);
            context.TemperatureDatas.Add(lTD_North_20160219);
            context.TemperatureDatas.Add(lTD_North_20160220);
            context.TemperatureDatas.Add(lTD_North_20160221);
            context.TemperatureDatas.Add(lTD_North_20160222);
            context.TemperatureDatas.Add(lTD_North_20160223);
            context.TemperatureDatas.Add(lTD_North_20160224);
            context.TemperatureDatas.Add(lTD_North_20160225);
            #endregion

            #endregion

        }

        #endregion

        #region WeatherData

        #region Las Brujas

        public static void WeatherDataLasBrujas_2007(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2007, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault();
            #region WeatherData 2007
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 28.6, 762.7, 35.6, 21.6, 7.8);  // Month - 2007-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 25.3, 431.5, 27.8, 22.7, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 25.3, 427.5, 29.8, 20.7, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 25.6, 508.1, 29.8, 21.3, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 21.1, 596.5, 24.5, 17.6, 5.1);  // Month - 2007-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 20.0, 624.4, 25.6, 14.4, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 20.7, 628.1, 26.4, 15.0, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 22.0, 761.2, 30.8, 13.2, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 24.9, 664.4, 32.4, 17.4, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 25.7, 390.0, 29.9, 21.5, 4.0);  // Month - 2007-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 25.1, 474.7, 28.9, 21.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 24.9, 708.5, 29.5, 20.2, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 24.7, 757.0, 31.6, 17.8, 7.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 16.4, 646.4, 21.2, 11.5, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 16.5, 753.5, 24.3, 08.6, 5.6);  // Month - 2007-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 19.9, 740.4, 29.6, 10.1, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 22.5, 687.5, 31.8, 13.2, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 23.2, 690.5, 28.1, 18.2, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 20.0, 637.1, 26.1, 13.9, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 21.5, 639.9, 27.8, 15.2, 5.7);  // Month - 2007-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 20.7, 702.9, 29.2, 12.2, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 22.0, 745.5, 31.0, 13.0, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 25.0, 453.0, 31.0, 19.0, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 25.4, 579.7, 31.4, 19.4, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 23.9, 208.5, 29.1, 18.6, 3.1);  // Month - 2007-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 25.1, 347.0, 28.4, 21.7, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 23.5, 457.3, 26.6, 20.3, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 21.1, 682.6, 26.2, 16.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 18.4, 697.4, 26.5, 10.3, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 21.8, 601.4, 28.2, 15.3, 4.8);  // Month - 2007-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 22.7, 715.5, 29.8, 15.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 23.0, 714.8, 31.9, 14.1, 6.3);  // Month - 2007-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 26.3, 709.8, 35.1, 17.4, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 27.9, 673.2, 35.9, 19.9, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 27.6, 344.4, 34.8, 20.3, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 24.6, 421.7, 29.3, 19.8, 3.8);  // Month - 2007-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 25.0, 475.1, 31.1, 18.8, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 22.4, 669.0, 30.0, 14.7, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 23.1, 573.1, 27.1, 19.0, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 24.7, 345.3, 31.4, 18.0, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 23.4, 635.0, 28.7, 18.1, 5.4);  // Month - 2007-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 20.9, 640.5, 26.4, 15.3, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 20.1, 596.1, 27.0, 13.1, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 23.0, 647.9, 29.7, 16.3, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 25.6, 645.6, 32.8, 18.3, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 26.7, 390.6, 32.9, 20.4, 4.5);  // Month - 2007-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 25.1, 316.5, 29.7, 20.4, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 21.6, 265.7, 26.3, 16.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 19.1, 629.4, 24.4, 13.8, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 19.4, 627.8, 27.4, 11.4, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 21.0, 622.1, 29.0, 12.9, 5.5);  // Month - 2007-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 24.1, 593.6, 30.4, 17.7, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 24.4, 557.5, 29.0, 19.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 24.1, 386.4, 30.0, 18.1, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 23.3, 568.2, 29.4, 17.1, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 26.9, 603.7, 34.9, 18.9, 5.1);  // Month - 2007-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 26.1, 329.6, 31.8, 20.4, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 21.5, 179.6, 23.4, 19.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 22.3, 285.6, 26.4, 18.1, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 23.0, 228.9, 27.7, 18.2, 2.4);  // Month - 2007-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 18.8, 582.8, 23.2, 14.3, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 16.1, 430.5, 22.2, 10.0, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 17.6, 174.0, 19.8, 15.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 21.9, 448.2, 28.0, 15.8, 3.3);  // Month - 2007-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 23.4, 561.4, 30.7, 16.0, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 23.4, 170.7, 26.3, 20.4, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 20.8, 169.6, 22.8, 18.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 20.6, 529.0, 24.9, 16.3, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 18.3, 441.3, 22.4, 14.2, 3.2);  // Month - 2007-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 20.1, 552.6, 27.6, 12.5, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 23.2, 549.9, 31.0, 15.4, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 22.9, 501.7, 28.7, 17.0, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 22.0, 198.0, 26.3, 17.7, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 22.3, 493.1, 25.9, 18.6, 3.7);  // Month - 2007-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 20.3, 330.8, 23.7, 16.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 19.7, 329.1, 23.7, 15.7, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 20.0, 513.5, 25.6, 14.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 19.9, 476.7, 27.2, 12.6, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 21.5, 487.8, 28.6, 14.3, 3.5);  // Month - 2007-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 22.2, 512.7, 28.7, 15.6, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 23.5, 449.1, 30.4, 16.5, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 19.0, 260.8, 22.8, 15.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 18.0, 494.1, 24.9, 11.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 20.5, 437.8, 28.2, 12.8, 3.4);  // Month - 2007-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 22.9, 428.3, 28.2, 17.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 19.8, 148.0, 20.5, 19.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 20.8, 146.8, 22.4, 19.1, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 22.2, 145.6, 24.1, 20.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 20.7, 144.4, 21.7, 19.7, 1.6);  // Month - 2007-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 20.0, 165.8, 22.9, 17.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 22.5, 401.5, 27.4, 17.5, 2.7);  // Month - 2007-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 22.5, 349.4, 27.4, 17.5, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 20.4, 423.7, 24.2, 16.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 18.7, 465.4, 26.0, 11.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 18.0, 462.4, 24.1, 11.8, 2.4);  // Month - 2007-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 19.6, 377.5, 25.1, 14.1, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 20.7, 203.2, 25.2, 16.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 17.3, 322.6, 21.3, 13.3, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 17.2, 394.1, 22.9, 11.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 17.9, 247.3, 23.4, 12.3, 1.9);  // Month - 2007-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 19.3, 232.9, 25.5, 13.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 15.6, 426.7, 20.9, 10.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 15.4, 426.4, 23.1, 07.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 17.8, 218.3, 24.5, 11.1, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 19.8, 163.4, 21.9, 17.7, 1.7);  // Month - 2007-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 20.6, 153.4, 23.8, 17.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 22.7, 251.5, 27.8, 17.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 25.4, 351.5, 30.4, 20.4, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 25.6, 386.9, 31.3, 19.8, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 19.1, 119.7, 22.6, 15.5, 1.7);  // Month - 2007-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 15.4, 118.6, 17.4, 13.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 18.3, 117.5, 22.7, 13.8, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 16.7, 130.5, 18.1, 15.3, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 16.8, 247.1, 21.6, 11.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 14.6, 223.3, 18.3, 10.9, 1.6);  // Month - 2007-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 14.5, 385.4, 17.3, 11.7, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 12.6, 349.4, 19.2, 06.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 14.1, 371.4, 21.8, 06.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 14.1, 368.5, 21.8, 06.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 16.0, 365.9, 23.6, 08.4, 1.8);  // Month - 2007-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 18.2, 145.5, 23.7, 12.6, 1.4);  // Month - 2007-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 17.9, 341.2, 22.0, 13.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 17.5, 309.3, 24.0, 10.9, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 17.9, 115.1, 19.9, 15.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 17.8, 134.8, 20.1, 15.5, 1.5);  // Month - 2007-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 14.4, 198.0, 17.0, 11.8, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 11.5, 334.3, 13.1, 09.8, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 11.3, 273.9, 13.3, 09.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 10.4, 206.5, 14.7, 06.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 09.7, 298.7, 17.2, 02.1, 1.1);  // Month - 2007-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 12.8, 319.6, 19.2, 06.3, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 11.0, 277.8, 15.3, 06.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 10.4, 176.6, 16.5, 04.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 11.2, 244.8, 18.2, 04.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 13.0, 218.6, 19.3, 06.7, 1.1);  // Month - 2007-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 11.9, 315.2, 16.5, 07.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 09.0, 315.6, 16.0, 02.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 10.8, 301.5, 18.4, 03.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 12.6, 309.3, 20.3, 04.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 12.3, 307.3, 19.6, 05.0, 1.0);  // Month - 2007-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 13.3, 224.3, 19.6, 07.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 11.0, 229.9, 14.2, 07.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 10.7, 272.9, 12.9, 08.5, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 09.1, 254.7, 14.7, 03.5, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 09.2, 297.0, 15.5, 02.8, 0.9);  // Month - 2007-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 09.6, 290.3, 16.1, 03.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 08.0, 251.6, 13.1, 02.9, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 06.2, 129.2, 07.3, 05.0, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 08.0, 196.0, 11.1, 04.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 08.0, 154.0, 12.9, 03.0, 0.7);  // Month - 2007-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 06.8, 84.2, 11.4, 02.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 09.8, 251.6, 14.1, 05.4, 0.7);  // Month - 2007-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 10.3, 278.0, 17.7, 02.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 13.3, 284.2, 18.4, 08.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 12.5, 274.8, 20.5, 04.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 13.1, 274.1, 21.6, 04.5, 1.0);  // Month - 2007-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 11.1, 253.4, 18.4, 03.7, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 06.5, 113.3, 09.9, 03.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 08.0, 110.8, 14.7, 01.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 12.8, 194.2, 17.6, 07.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 10.1, 248.6, 16.5, 03.7, 0.6);  // Month - 2007-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 09.7, 226.1, 15.7, 03.6, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 10.9, 116.0, 17.2, 04.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 13.2, 80.7, 14.7, 11.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 10.8, 126.2, 12.8, 08.8, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 08.2, 158.4, 10.1, 06.2, 1.0);  // Month - 2007-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 07.2, 222.9, 11.3, 03.0, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 07.4, 241.8, 13.7, 01.0, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 06.0, 241.0, 11.9, 00.0, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 08.5, 79.1, 14.6, 02.4, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 12.9, 78.9, 15.0, 10.8, 0.9);  // Month - 2007-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 11.8, 238.6, 15.9, 07.6, 0.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 13.9, 78.3, 16.9, 10.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 09.4, 266.6, 12.8, 05.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 06.1, 259.0, 09.6, 02.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 07.4, 249.2, 14.6, 00.2, 0.6);  // Month - 2007-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 08.7, 252.2, 14.0, 03.3, 0.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 07.7, 218.5, 15.2, 00.1, 0.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 09.0, 244.9, 16.3, 01.6, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 09.9, 265.1, 16.5, 03.2, 0.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 06.7, 252.9, 12.0, 01.3, 0.1);  // Month - 2007-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 06.5, 243.5, 13.2, -00.3, 0.1);  // Month - 2007-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 06.1, 254.4, 13.9, -01.7, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 06.7, 94.1, 11.7, 01.7, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 12.2, 246.9, 19.5, 04.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 17.4, 114.1, 22.3, 12.5, 1.2);  // Month - 2007-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 09.1, 233.0, 13.8, 04.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 07.2, 81.8, 12.3, 02.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 05.7, 130.9, 10.3, 01.1, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 05.3, 86.7, 09.7, 00.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 02.9, 115.8, 06.7, -01.0, 0.9);  // Month - 2007-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 04.5, 265.1, 10.4, -01.4, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 04.6, 278.9, 12.0, -02.9, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 06.6, 210.0, 13.9, -00.8, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 08.1, 99.2, 09.9, 06.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 07.0, 264.3, 12.4, 01.6, 0.6);  // Month - 2007-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 09.5, 273.7, 17.0, 02.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 11.1, 150.0, 17.0, 05.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 09.5, 160.1, 16.5, 02.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 13.6, 225.0, 20.4, 06.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 11.4, 288.5, 16.0, 06.7, 1.7);  // Month - 2007-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 09.1, 87.5, 13.9, 04.2, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 07.9, 88.2, 10.9, 04.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 06.3, 296.4, 11.0, 01.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 04.5, 101.3, 07.5, 01.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 03.7, 143.1, 08.2, -00.9, 0.4);  // Month - 2007-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 09.6, 301.9, 18.5, 00.7, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 05.0, 298.8, 09.0, 00.9, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 04.3, 307.8, 09.7, -01.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 04.9, 263.8, 13.0, -03.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 06.9, 300.6, 16.1, -02.3, 0.5);  // Month - 2007-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 08.9, 259.3, 16.8, 00.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 07.2, 97.5, 10.6, 03.8, 1.0);  // Month - 2007-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 07.2, 98.2, 08.5, 05.8, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 08.2, 96.4, 08.6, 07.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 06.5, 97.1, 07.9, 05.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 06.9, 97.8, 08.3, 05.5, 0.9);  // Month - 2007-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 07.9, 98.4, 08.8, 07.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 09.8, 336.2, 16.7, 02.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 11.5, 327.7, 19.4, 03.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 11.3, 231.8, 17.5, 05.0, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 06.6, 101.5, 09.3, 03.8, 1.2);  // Month - 2007-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 07.4, 343.6, 14.4, 00.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 06.6, 169.7, 12.4, 00.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 14.9, 219.1, 19.5, 10.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 19.1, 315.2, 27.3, 10.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 11.0, 217.5, 14.2, 07.8, 1.2);  // Month - 2007-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 08.3, 317.6, 11.3, 05.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 05.5, 116.9, 08.8, 02.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 08.9, 233.7, 11.3, 06.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 08.5, 111.0, 10.9, 06.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 05.7, 341.1, 10.3, 01.0, 1.1);  // Month - 2007-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 07.4, 351.7, 16.3, -01.5, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 08.0, 243.9, 13.9, 02.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 09.7, 287.5, 16.0, 03.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 10.2, 329.0, 13.4, 07.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 12.0, 311.8, 16.5, 07.5, 1.8);  // Month - 2007-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 10.4, 124.1, 13.2, 07.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 10.0, 385.3, 15.5, 04.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 11.4, 361.9, 17.0, 05.7, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 07.0, 393.1, 12.5, 01.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 10.3, 401.6, 17.0, 03.5, 1.9);  // Month - 2007-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 12.6, 269.7, 17.4, 07.8, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 14.4, 168.7, 18.6, 10.1, 1.5);  // Month - 2007-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 15.0, 158.4, 20.6, 09.4, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 18.5, 228.2, 21.9, 15.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 21.2, 128.3, 27.9, 14.5, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 12.2, 129.5, 15.0, 09.4, 1.5);  // Month - 2007-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 18.7, 406.1, 24.9, 12.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 22.2, 299.4, 28.4, 15.9, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 24.0, 353.6, 29.5, 18.5, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 24.6, 371.5, 30.6, 18.5, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 24.8, 315.1, 30.3, 19.3, 3.2);  // Month - 2007-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 17.4, 136.6, 19.9, 14.9, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 14.5, 137.8, 15.6, 13.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 17.3, 139.0, 19.4, 15.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 19.1, 140.2, 22.4, 15.7, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 14.6, 141.4, 16.5, 12.6, 1.8);  // Month - 2007-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 12.9, 171.4, 15.4, 10.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 13.6, 301.5, 18.1, 09.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 13.8, 145.0, 15.7, 11.9, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 13.1, 181.9, 14.8, 11.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 11.1, 366.4, 16.7, 05.4, 2.0);  // Month - 2007-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 11.7, 345.8, 16.5, 06.8, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 11.3, 453.6, 17.7, 04.8, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 11.8, 370.1, 15.6, 07.9, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 08.4, 432.6, 13.2, 03.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 09.2, 475.1, 15.5, 02.8, 2.3);  // Month - 2007-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 11.2, 501.2, 19.1, 03.2, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 15.8, 388.9, 20.3, 11.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 16.0, 526.8, 23.4, 08.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 17.6, 505.8, 25.8, 09.3, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 17.9, 535.8, 26.3, 09.5, 4.9);  // Month - 2007-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 15.5, 160.2, 18.9, 12.1, 1.9);  // Month - 2007-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 19.0, 202.8, 21.9, 16.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 20.3, 304.8, 25.6, 14.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 21.6, 467.3, 27.1, 16.1, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 20.2, 164.8, 21.4, 18.9, 2.0);  // Month - 2007-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 15.7, 352.6, 19.2, 12.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 12.9, 566.6, 17.5, 08.2, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 13.9, 455.9, 20.8, 06.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 15.1, 187.2, 17.7, 12.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 14.6, 213.5, 17.9, 11.3, 1.9);  // Month - 2007-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 12.6, 196.8, 15.6, 09.5, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 13.2, 208.8, 14.3, 12.0, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 13.3, 397.6, 17.7, 08.8, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 13.4, 537.3, 20.4, 06.3, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 15.2, 467.3, 20.4, 10.0, 3.1);  // Month - 2007-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 16.0, 535.4, 19.8, 12.1, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 19.0, 545.1, 27.0, 11.0, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 18.5, 583.9, 23.7, 13.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 19.5, 578.7, 27.6, 11.3, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 20.0, 492.1, 25.2, 14.8, 4.0);  // Month - 2007-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 17.0, 604.9, 24.0, 10.0, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 18.4, 616.4, 26.0, 10.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 20.6, 612.7, 27.5, 13.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 19.5, 614.9, 26.5, 12.5, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 21.9, 500.9, 30.5, 13.2, 3.9);  // Month - 2007-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 19.4, 573.9, 27.5, 11.3, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 16.6, 627.1, 22.2, 11.0, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 17.1, 627.1, 25.1, 09.1, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 19.0, 633.1, 27.0, 11.0, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 20.1, 551.7, 27.0, 13.2, 4.5);  // Month - 2007-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 20.2, 321.3, 25.0, 15.4, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 15.9, 658.3, 21.0, 10.8, 5.1);  // Month - 2007-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 16.6, 649.1, 23.2, 09.9, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 19.7, 528.5, 28.0, 11.3, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 11.5, 623.0, 15.4, 07.6, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 15.0, 659.5, 24.5, 05.5, 5.2);  // Month - 2007-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 19.2, 669.4, 26.8, 11.5, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 21.2, 529.7, 28.4, 13.9, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 18.7, 351.0, 23.6, 13.8, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 17.9, 200.5, 20.0, 15.7, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 13.2, 439.1, 16.3, 10.1, 3.8);  // Month - 2007-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 11.0, 562.1, 14.9, 07.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 14.5, 699.0, 23.7, 05.3, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 13.6, 223.4, 16.1, 11.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 11.7, 603.4, 14.3, 09.0, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 12.1, 672.6, 17.2, 06.9, 3.9);  // Month - 2007-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 16.2, 707.9, 25.8, 06.5, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 21.4, 469.4, 27.7, 15.1, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 17.8, 544.0, 22.6, 12.9, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 19.9, 687.5, 29.5, 10.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 17.8, 692.5, 23.8, 11.8, 5.1);  // Month - 2007-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 17.8, 701.9, 25.2, 10.3, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 20.5, 718.9, 30.7, 10.2, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 17.5, 225.5, 21.9, 13.0, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 10.6, 527.6, 14.3, 06.9, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 13.6, 731.4, 21.8, 05.3, 4.9);  // Month - 2007-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 16.5, 709.1, 22.4, 10.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 16.3, 730.5, 25.8, 06.7, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 19.5, 732.0, 28.1, 10.9, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 22.2, 741.5, 29.9, 14.4, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 22.5, 690.6, 30.8, 14.2, 6.1);  // Month - 2007-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 21.6, 740.2, 29.9, 13.3, 6.4);  // Month - 2007-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 22.3, 732.6, 28.1, 16.5, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 24.9, 701.0, 32.5, 17.3, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 23.4, 412.4, 29.3, 17.4, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 15.4, 753.9, 21.0, 09.7, 5.5);  // Month - 2007-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 17.2, 745.9, 27.0, 07.4, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 21.5, 669.5, 28.1, 14.9, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 22.4, 706.4, 31.0, 13.7, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 19.6, 730.9, 29.1, 10.0, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 20.5, 506.4, 25.4, 15.5, 4.7);  // Month - 2007-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 15.8, 756.0, 21.6, 10.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 19.3, 756.5, 30.2, 08.4, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 23.0, 761.0, 33.0, 12.9, 7.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 24.4, 451.6, 31.4, 17.3, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 16.7, 737.5, 22.1, 11.3, 5.8);  // Month - 2007-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 14.4, 681.9, 20.8, 07.9, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 18.2, 739.2, 27.8, 08.6, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 21.8, 719.8, 29.0, 14.5, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 17.6, 700.4, 23.2, 12.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 22.5, 761.9, 31.9, 13.1, 6.6);  // Month - 2007-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 24.7, 645.3, 33.9, 15.5, 7.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 17.8, 706.5, 22.1, 13.5, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 19.4, 293.4, 26.4, 12.3, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 22.2, 293.1, 26.3, 18.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 21.2, 305.0, 24.0, 18.3, 3.1);  // Month - 2007-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 20.8, 470.5, 23.8, 17.8, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 21.4, 264.0, 24.9, 17.9, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 23.7, 518.5, 28.7, 18.7, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 24.2, 562.7, 29.4, 19.0, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 25.3, 736.1, 32.9, 17.7, 6.9);  // Month - 2007-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 27.4, 743.5, 35.3, 19.5, 8.0);  


            #endregion

        }

        public static void WeatherDataLasBrujas_2008(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2008, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                                where ws.Name == Utils.NameWeatherStationLasBrujas
                                select ws).FirstOrDefault(); 
            
            #region WeatherData 2008
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 24.3, 468.3, 29.8, 18.8, 5.0);  // Month - 2008-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 27.2, 681.1, 36.2, 18.2, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 25.7, 512.2, 31.7, 19.6, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 19.3, 629.0, 22.9, 15.7, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 20.4, 745.6, 26.7, 14.1, 6.0);  // Month - 2008-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 22.8, 692.9, 31.7, 13.9, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 26.9, 640.2, 34.6, 19.1, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 28.5, 720.8, 35.2, 21.8, 7.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 26.0, 559.6, 32.0, 19.9, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 22.9, 256.9, 26.6, 19.1, 3.4);  // Month - 2008-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 19.6, 632.1, 24.1, 15.0, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 19.4, 744.9, 27.6, 11.2, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 22.1, 712.6, 29.4, 14.7, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 24.8, 751.2, 31.6, 18.0, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 27.8, 717.3, 35.4, 20.2, 7.2);  // Month - 2008-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 20.2, 652.0, 25.7, 14.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 18.7, 731.7, 26.7, 10.7, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 20.5, 606.2, 27.0, 14.0, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 17.4, 733.3, 22.7, 12.1, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 18.9, 471.8, 27.8, 10.0, 4.8);  // Month - 2008-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 22.1, 642.9, 29.6, 14.5, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 21.0, 693.6, 27.4, 14.6, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 23.1, 540.7, 29.6, 16.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 24.3, 639.4, 29.8, 18.7, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 24.8, 606.3, 31.1, 18.5, 6.6);  // Month - 2008-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 23.8, 553.7, 29.3, 18.2, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 24.1, 306.5, 29.3, 18.8, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 25.9, 595.3, 31.5, 20.3, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 24.9, 534.9, 29.9, 19.9, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 23.8, 522.2, 28.1, 19.5, 4.1);  // Month - 2008-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 23.7, 703.6, 29.3, 18.1, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 23.2, 655.5, 28.9, 17.5, 5.5);  // Month - 2008-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 23.1, 524.0, 29.7, 16.4, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 18.6, 700.9, 23.5, 13.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 22.4, 687.7, 31.9, 12.8, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 24.2, 657.8, 30.8, 17.5, 6.0);  // Month - 2008-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 26.4, 663.4, 36.2, 16.5, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 26.2, 434.2, 31.3, 21.0, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 22.7, 198.4, 25.4, 19.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 22.4, 473.8, 27.0, 17.8, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 19.3, 328.4, 23.4, 15.1, 3.2);  // Month - 2008-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 19.0, 582.5, 23.2, 14.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 22.0, 654.0, 26.4, 17.5, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 22.4, 578.6, 29.0, 15.7, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 23.7, 637.9, 31.3, 16.0, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 25.5, 566.7, 31.7, 19.2, 5.1);  // Month - 2008-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 24.4, 610.5, 29.0, 19.7, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 24.8, 627.3, 31.1, 18.4, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 23.5, 553.4, 29.6, 17.4, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 24.1, 487.4, 29.3, 18.9, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 24.3, 610.7, 30.1, 18.5, 5.3);  // Month - 2008-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 25.0, 578.5, 32.3, 17.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 23.4, 269.4, 29.1, 17.7, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 22.9, 240.0, 26.3, 19.4, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 23.2, 603.8, 28.6, 17.7, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 23.0, 499.1, 28.3, 17.7, 4.5);  // Month - 2008-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 24.9, 534.4, 29.7, 20.0, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 24.9, 302.0, 28.0, 21.7, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 21.8, 178.5, 23.1, 20.5, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 21.3, 177.3, 23.2, 19.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 23.5, 432.7, 27.7, 19.2, 3.6);  // Month - 2008-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 22.7, 222.6, 26.1, 19.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 22.6, 246.7, 24.7, 20.4, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 22.4, 317.8, 24.5, 20.3, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 20.1, 352.2, 21.4, 18.8, 3.0);  // Month - 2008-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 20.9, 170.7, 22.1, 19.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 20.8, 187.5, 22.5, 19.1, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 23.2, 525.4, 29.7, 16.7, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 23.1, 533.7, 28.0, 18.2, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 18.3, 467.6, 22.3, 14.3, 3.6);  // Month - 2008-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 17.2, 528.7, 22.4, 11.9, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 17.0, 543.9, 23.5, 10.4, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 17.7, 523.7, 24.2, 11.1, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 19.9, 521.0, 25.3, 14.4, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 18.9, 518.3, 26.6, 11.2, 4.0);  // Month - 2008-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 21.8, 533.2, 28.9, 14.6, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 24.6, 427.3, 31.1, 18.1, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 22.4, 500.7, 27.7, 17.1, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 24.3, 525.4, 29.9, 18.6, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 21.8, 495.6, 26.6, 16.9, 3.4);  // Month - 2008-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 22.5, 493.2, 31.1, 13.8, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 16.9, 348.5, 21.0, 12.7, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 17.8, 487.4, 24.6, 11.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 19.2, 494.6, 26.3, 12.0, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 20.3, 481.5, 27.6, 12.9, 3.6);  // Month - 2008-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 22.2, 396.0, 28.4, 16.0, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 20.3, 304.7, 25.5, 15.1, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 19.6, 178.3, 22.7, 16.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 19.7, 476.3, 24.3, 15.0, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 17.9, 443.5, 25.7, 10.0, 3.2);  // Month - 2008-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 19.7, 263.7, 24.7, 14.6, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 19.5, 275.5, 22.7, 16.2, 2.2);  // Month - 2008-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 16.6, 465.2, 20.8, 12.3, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 15.0, 436.8, 21.3, 08.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 18.5, 449.8, 25.3, 11.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 21.0, 449.7, 27.3, 14.6, 3.2);  // Month - 2008-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 21.7, 449.6, 29.8, 13.6, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 21.3, 434.3, 27.8, 14.7, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 19.3, 424.9, 25.7, 12.8, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 19.2, 345.2, 29.1, 09.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 21.6, 414.8, 28.1, 15.0, 2.7);  // Month - 2008-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 20.3, 339.4, 26.2, 14.4, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 12.5, 309.8, 17.5, 07.5, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 11.6, 256.9, 18.0, 05.1, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 10.5, 414.7, 15.6, 05.4, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 10.7, 412.1, 18.2, 03.1, 2.0);  // Month - 2008-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 13.3, 403.5, 22.5, 04.1, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 16.8, 401.0, 25.5, 08.1, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 18.9, 372.4, 28.2, 09.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 19.0, 320.9, 27.0, 11.0, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 20.4, 390.0, 29.8, 11.0, 3.3);  // Month - 2008-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 20.3, 381.5, 27.1, 13.4, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 20.4, 333.6, 26.4, 14.3, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 19.2, 336.7, 26.4, 12.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 18.9, 307.2, 26.1, 11.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 15.7, 379.9, 22.2, 09.1, 2.0);  // Month - 2008-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 14.4, 316.3, 20.8, 07.9, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 16.0, 256.3, 23.8, 08.1, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 16.4, 224.3, 20.4, 12.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 11.6, 330.7, 13.9, 09.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 10.5, 360.3, 15.9, 05.0, 1.5);  // Month - 2008-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 10.4, 240.0, 17.7, 03.1, 1.2);  // Month - 2008-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 11.5, 327.9, 18.3, 04.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 14.4, 332.8, 19.5, 09.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 12.7, 280.4, 20.3, 05.1, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 11.0, 290.9, 17.9, 04.0, 0.7);  // Month - 2008-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 14.0, 334.3, 23.1, 04.8, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 13.4, 319.8, 18.4, 08.3, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 10.7, 290.2, 16.7, 04.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 11.0, 308.8, 19.1, 02.9, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 10.9, 312.1, 19.9, 01.8, 1.2);  // Month - 2008-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 12.2, 307.9, 20.5, 03.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 13.9, 291.0, 21.7, 06.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 14.4, 284.4, 22.4, 06.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 15.4, 314.6, 23.4, 07.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 18.0, 295.6, 26.2, 09.7, 2.0);  // Month - 2008-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 14.6, 118.4, 18.7, 10.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 19.5, 245.8, 25.4, 13.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 20.9, 99.8, 26.0, 15.7, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 22.7, 230.7, 28.2, 17.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 19.5, 91.1, 22.6, 16.3, 1.5);  // Month - 2008-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 18.7, 128.2, 22.0, 15.3, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 17.2, 268.2, 20.6, 13.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 18.2, 142.6, 21.6, 14.7, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 14.3, 88.2, 16.1, 12.4, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 16.0, 177.3, 19.5, 12.5, 1.0);  // Month - 2008-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 13.8, 134.8, 16.9, 10.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 13.8, 129.2, 17.7, 09.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 11.0, 85.2, 13.5, 08.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 08.0, 246.0, 09.8, 06.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 07.3, 276.7, 11.5, 03.0, 0.8);  // Month - 2008-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 07.1, 269.5, 14.2, 00.0, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 07.0, 266.8, 14.1, -00.2, 0.5);  // Month - 2008-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 08.4, 248.5, 15.0, 01.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 09.1, 225.7, 17.4, 00.8, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 11.5, 85.1, 16.6, 06.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 14.4, 142.5, 17.8, 11.0, 1.0);  // Month - 2008-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 10.6, 277.1, 15.3, 05.8, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 10.5, 234.5, 18.8, 02.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 11.0, 236.1, 18.9, 03.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 09.9, 81.5, 12.9, 06.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 09.4, 250.2, 12.4, 06.3, 1.0);  // Month - 2008-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 11.6, 273.6, 18.2, 05.0, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 09.1, 266.4, 15.0, 03.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 11.2, 270.0, 19.6, 02.7, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 10.5, 225.7, 13.1, 07.9, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 08.2, 222.9, 11.5, 04.8, 1.4);  // Month - 2008-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 08.1, 246.1, 14.7, 01.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 10.0, 264.7, 18.4, 01.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 07.4, 244.5, 14.2, 00.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 11.0, 81.0, 13.3, 08.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 11.2, 78.6, 11.7, 10.6, 1.6);  // Month - 2008-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 10.8, 186.7, 12.9, 08.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 08.9, 143.7, 11.3, 06.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 09.1, 118.7, 13.5, 04.6, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 08.4, 170.3, 14.5, 02.2, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 10.8, 243.6, 18.4, 03.1, 0.9);  // Month - 2008-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 12.7, 79.1, 14.1, 11.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 11.7, 204.1, 16.8, 06.6, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 10.3, 181.0, 17.8, 02.8, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 11.4, 211.8, 18.5, 04.2, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 14.1, 80.2, 17.3, 10.9, 1.1);  // Month - 2008-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 10.6, 80.5, 13.2, 08.0, 0.9);  // Month - 2008-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 09.7, 80.7, 13.6, 05.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 10.2, 268.8, 15.5, 04.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 09.4, 206.1, 15.3, 03.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 20.3, 263.7, 26.2, 14.4, 1.9);  // Month - 2008-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 16.8, 147.8, 19.9, 13.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 16.0, 117.4, 19.2, 12.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 13.1, 212.7, 18.9, 07.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 13.2, 235.2, 19.7, 06.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 13.9, 102.8, 18.9, 08.9, 1.1);  // Month - 2008-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 17.2, 163.0, 21.7, 12.7, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 18.9, 274.5, 24.1, 13.6, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 14.8, 203.8, 20.7, 08.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 14.0, 259.9, 22.4, 05.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 22.5, 262.6, 27.8, 17.1, 2.2);  // Month - 2008-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 19.2, 275.7, 25.1, 13.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 19.2, 207.5, 25.8, 12.5, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 10.5, 279.6, 16.0, 05.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 09.1, 254.1, 14.8, 03.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 08.0, 278.8, 13.6, 02.4, 1.5);  // Month - 2008-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 10.2, 88.2, 12.5, 07.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 10.5, 119.2, 13.1, 07.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 10.6, 117.7, 13.4, 07.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 10.2, 144.5, 12.2, 08.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 09.2, 256.9, 14.1, 04.2, 0.8);  // Month - 2008-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 09.3, 203.6, 15.0, 03.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 12.0, 104.3, 15.8, 08.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 14.5, 237.3, 18.4, 10.5, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 14.8, 224.1, 18.6, 11.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 13.6, 232.6, 16.4, 10.7, 1.1);  // Month - 2008-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 10.5, 95.0, 13.0, 07.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 10.5, 115.3, 14.2, 06.8, 1.0);  // Month - 2008-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 10.9, 167.7, 14.9, 06.9, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 07.3, 304.5, 10.1, 04.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 09.8, 112.6, 12.7, 06.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 08.8, 328.0, 14.1, 03.5, 1.3);  // Month - 2008-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 09.3, 329.6, 17.7, 00.8, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 08.5, 318.6, 17.2, -00.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 06.9, 335.3, 13.7, 00.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 08.1, 312.7, 16.0, 00.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 13.9, 305.1, 22.0, 05.8, 2.3);  // Month - 2008-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 16.4, 199.2, 21.3, 11.4, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 07.6, 333.4, 11.5, 03.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 08.2, 328.3, 15.7, 00.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 11.1, 172.7, 19.1, 03.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 15.4, 174.2, 19.4, 11.4, 0.8);  // Month - 2008-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 17.7, 226.6, 23.2, 12.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 09.1, 360.1, 13.6, 04.5, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 07.9, 360.2, 15.4, 00.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 11.7, 262.0, 16.4, 06.9, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 14.3, 113.1, 16.6, 12.0, 1.5);  // Month - 2008-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 09.6, 249.4, 12.8, 06.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 09.5, 373.6, 16.3, 02.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 10.2, 382.1, 18.3, 02.1, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 11.7, 289.3, 16.2, 07.1, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 13.2, 337.0, 19.4, 06.9, 1.7);  // Month - 2008-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 13.3, 373.9, 21.8, 04.8, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 16.9, 224.0, 21.1, 12.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 11.3, 121.5, 12.7, 09.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 10.5, 360.9, 15.3, 05.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 12.4, 404.0, 19.8, 04.9, 2.7);  // Month - 2008-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 14.9, 341.9, 22.0, 07.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 16.0, 261.8, 23.6, 08.3, 2.6);  // Month - 2008-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 17.6, 130.1, 24.6, 10.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 10.3, 406.4, 12.9, 07.7, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 08.5, 385.3, 11.3, 05.6, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 06.6, 130.7, 09.2, 04.0, 1.5);  // Month - 2008-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 08.0, 131.9, 10.9, 05.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 11.4, 145.3, 13.9, 08.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 10.6, 389.9, 17.1, 04.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 12.3, 401.8, 18.8, 05.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 13.1, 289.3, 18.3, 07.9, 2.0);  // Month - 2008-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 13.5, 137.8, 15.6, 11.3, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 09.3, 406.7, 12.7, 05.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 08.3, 412.7, 13.0, 03.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 10.5, 150.9, 12.0, 09.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 10.0, 338.0, 14.4, 05.5, 1.8);  // Month - 2008-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 11.7, 253.2, 17.3, 06.1, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 11.7, 478.2, 18.7, 04.7, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 13.6, 373.9, 20.2, 07.0, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 14.3, 317.3, 20.4, 08.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 12.2, 181.4, 14.6, 09.7, 2.1);  // Month - 2008-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 13.2, 196.0, 15.9, 10.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 15.5, 423.2, 19.4, 11.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 13.2, 462.6, 21.0, 05.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 14.4, 455.0, 21.1, 07.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 16.0, 450.7, 21.4, 10.5, 3.2);  // Month - 2008-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 17.9, 466.6, 23.4, 12.3, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 18.3, 499.6, 23.7, 12.9, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 18.3, 185.2, 22.5, 14.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 17.2, 159.0, 20.5, 13.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 13.6, 160.2, 14.7, 12.4, 1.6);  // Month - 2008-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 16.5, 261.5, 21.2, 11.8, 2.2);  // Month - 2008-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 16.6, 405.5, 20.2, 12.9, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 15.9, 366.0, 22.8, 08.9, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 12.1, 392.7, 17.7, 06.5, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 11.5, 553.4, 18.8, 04.2, 3.5);  // Month - 2008-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 16.3, 534.8, 25.0, 07.5, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 09.5, 537.6, 13.7, 05.2, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 09.4, 547.5, 18.1, 00.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 14.1, 557.5, 22.1, 06.0, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 18.0, 469.6, 24.9, 11.0, 4.0);  // Month - 2008-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 21.3, 460.8, 28.9, 13.7, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 18.2, 210.0, 21.0, 15.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 17.6, 254.8, 20.3, 14.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 15.9, 249.0, 18.1, 13.6, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 14.0, 203.0, 17.1, 10.9, 2.0);  // Month - 2008-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 13.2, 545.1, 20.1, 06.3, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 12.5, 543.5, 20.3, 04.7, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 15.4, 552.9, 23.5, 07.3, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 17.1, 588.2, 25.1, 09.1, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 21.6, 601.2, 28.8, 14.3, 5.2);  // Month - 2008-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 19.7, 242.8, 24.2, 15.1, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 15.5, 568.0, 21.2, 09.8, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 16.4, 600.0, 25.0, 07.7, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 20.1, 538.4, 29.1, 11.1, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 19.0, 431.2, 23.4, 14.5, 3.8);  // Month - 2008-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 18.4, 459.2, 22.9, 13.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 14.9, 630.9, 19.1, 10.7, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 17.0, 629.3, 24.8, 09.1, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 17.4, 559.3, 21.7, 13.1, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 14.5, 640.9, 18.9, 10.1, 4.2);  // Month - 2008-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 17.6, 658.3, 24.9, 10.2, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 19.9, 629.9, 27.0, 12.7, 5.3);  // Month - 2008-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 18.3, 647.4, 22.9, 13.7, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 20.6, 542.2, 28.6, 12.5, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 23.4, 624.8, 31.6, 15.2, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 26.7, 549.5, 33.6, 19.7, 6.0);  // Month - 2008-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 21.7, 656.1, 27.5, 15.8, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 21.6, 650.1, 30.0, 13.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 23.5, 473.3, 30.4, 16.5, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 22.7, 665.4, 29.4, 16.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 20.7, 635.3, 27.1, 14.2, 5.4);  // Month - 2008-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 23.1, 554.3, 29.2, 16.9, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 22.1, 672.7, 30.3, 13.9, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 21.7, 693.5, 30.3, 13.0, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 22.4, 714.3, 30.4, 14.3, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 16.3, 393.7, 19.8, 12.8, 5.0);  // Month - 2008-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 15.3, 716.2, 19.8, 10.7, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 16.9, 681.4, 25.7, 08.0, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 17.9, 679.6, 23.6, 12.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 17.1, 688.6, 25.3, 08.9, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 19.3, 713.8, 26.5, 12.0, 6.3);  // Month - 2008-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 20.6, 651.7, 28.6, 12.6, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 23.7, 716.5, 30.7, 16.6, 7.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 25.3, 714.0, 32.8, 17.8, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 26.3, 727.4, 34.4, 18.1, 7.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 28.1, 645.4, 34.9, 21.3, 7.0);  // Month - 2008-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 26.3, 630.8, 33.7, 18.8, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 28.4, 296.8, 35.5, 21.3, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 27.1, 237.6, 32.8, 21.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 28.4, 298.3, 35.5, 21.3, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 27.1, 238.9, 32.8, 21.4, 4.1);  // Month - 2008-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 23.1, 243.2, 25.6, 20.6, 2.8);  // Month - 2008-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 22.0, 331.8, 24.6, 19.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 18.3, 340.1, 21.4, 15.2, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 16.4, 653.4, 22.2, 10.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 18.1, 621.5, 26.2, 10.0, 5.5);  // Month - 2008-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 21.8, 685.5, 29.9, 13.7, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 25.3, 738.5, 33.5, 17.1, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 27.3, 570.3, 36.2, 18.3, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 26.4, 309.5, 32.3, 20.4, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 22.5, 526.9, 25.4, 19.5, 5.1);  // Month - 2008-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 20.2, 647.9, 24.8, 15.6, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 20.8, 684.6, 27.9, 13.7, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 21.7, 709.2, 29.4, 14.0, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 22.1, 729.4, 28.7, 15.4, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 22.2, 702.1, 29.3, 15.1, 6.8);  // Month - 2008-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 24.8, 763.4, 32.5, 17.1, 7.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 24.1, 723.9, 31.1, 17.0, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 23.8, 753.0, 30.6, 16.9, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 24.1, 697.2, 31.4, 16.7, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 26.8, 742.5, 34.6, 18.9, 8.5);  // Month - 2008-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 24.3, 390.4, 29.1, 19.4, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 21.1, 687.0, 24.6, 17.6, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 22.5, 382.3, 26.4, 18.5, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 23.6, 702.0, 30.2, 16.9, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 22.4, 486.7, 28.6, 16.2, 5.1);  // Month - 2008-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 20.8, 704.7, 29.5, 12.0, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 26.0, 599.3, 34.2, 17.8, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 25.8, 542.5, 32.2, 19.3, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 16.6, 732.1, 21.8, 11.4, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 19.0, 751.6, 28.7, 09.2, 5.9);  // Month - 2008-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(365), 19.7, 412.1, 25.1, 14.3, 4.7);  


            #endregion
                
        }

        public static void WeatherDataLasBrujas_2009(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2009, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                                where ws.Name == Utils.NameWeatherStationLasBrujas
                                select ws).FirstOrDefault(); 
            
            #region WeatherData 2009
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 18.5, 593.3, 22.5, 14.5, 5.0);  // Month - 2009-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 19.6, 677.1, 24.7, 14.4, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 19.9, 685.5, 26.9, 12.8, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 21.4, 750.0, 30.7, 12.1, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 26.4, 757.7, 34.9, 17.8, 8.4);  // Month - 2009-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 26.2, 721.1, 34.8, 17.5, 8.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 23.3, 672.5, 28.0, 18.5, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 23.3, 692.6, 31.9, 14.7, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 24.5, 724.9, 32.8, 16.2, 7.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 23.8, 720.9, 30.8, 16.8, 7.8);  // Month - 2009-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 23.0, 741.1, 28.4, 17.5, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 22.7, 692.4, 28.1, 17.3, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 23.6, 260.3, 28.6, 18.5, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 23.2, 614.2, 28.0, 18.4, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 23.5, 713.2, 31.4, 15.6, 6.6);  // Month - 2009-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 25.8, 720.3, 33.9, 17.6, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 28.7, 550.9, 37.1, 20.3, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 18.9, 469.8, 22.3, 15.5, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 17.4, 741.3, 23.2, 11.6, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 22.0, 723.9, 31.1, 12.8, 6.9);  // Month - 2009-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 25.2, 734.9, 33.8, 16.5, 8.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 26.0, 693.6, 35.4, 16.6, 8.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 27.1, 724.1, 35.6, 18.6, 8.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 27.5, 707.2, 35.9, 19.1, 8.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 25.9, 415.4, 31.2, 20.6, 5.3);  // Month - 2009-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 23.2, 506.0, 26.6, 19.8, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 23.2, 643.9, 28.8, 17.6, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 23.7, 210.7, 26.9, 20.5, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 20.8, 206.1, 22.2, 19.4, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 20.7, 205.5, 22.0, 19.3, 2.8);  // Month - 2009-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 21.5, 569.0, 25.5, 17.4, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 18.6, 679.2, 22.5, 14.7, 5.7);  // Month - 2009-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 21.5, 678.2, 31.9, 11.1, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 23.2, 479.6, 27.6, 18.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 23.0, 577.2, 29.7, 16.3, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 23.0, 307.6, 28.4, 17.6, 4.5);  // Month - 2009-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 22.2, 675.2, 26.9, 17.5, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 19.8, 586.8, 23.3, 16.2, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 21.6, 647.2, 29.9, 13.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 23.9, 652.8, 29.9, 17.9, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 26.8, 429.3, 34.8, 18.7, 5.4);  // Month - 2009-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 19.2, 574.7, 23.9, 14.5, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 19.9, 638.6, 26.0, 13.7, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 23.2, 647.9, 31.1, 15.3, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 24.7, 641.8, 32.1, 17.2, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 24.6, 620.3, 30.7, 18.5, 6.5);  // Month - 2009-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 24.3, 385.2, 30.2, 18.4, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 23.7, 596.8, 30.2, 17.2, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 25.9, 576.2, 32.7, 19.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 27.8, 597.5, 34.0, 21.5, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 26.7, 353.2, 32.1, 21.2, 3.7);  // Month - 2009-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 22.7, 416.1, 25.2, 20.1, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 18.8, 184.6, 21.1, 16.5, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 19.0, 592.9, 23.0, 14.9, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 19.9, 553.3, 27.4, 12.3, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 21.3, 517.8, 27.7, 14.8, 4.4);  // Month - 2009-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 21.3, 515.7, 27.1, 15.4, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 22.5, 535.6, 27.4, 17.5, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 22.2, 547.9, 28.1, 16.3, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 25.9, 490.2, 32.6, 19.1, 4.3);  // Month - 2009-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 23.0, 524.2, 27.4, 18.5, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 21.5, 237.2, 25.2, 17.8, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 20.5, 174.0, 22.3, 18.7, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 22.1, 477.2, 26.0, 18.2, 3.2);  // Month - 2009-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 21.5, 532.6, 27.7, 15.2, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 21.5, 296.6, 26.1, 16.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 20.9, 538.7, 25.4, 16.3, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 21.3, 525.4, 26.8, 15.8, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 23.1, 533.7, 27.6, 18.5, 4.7);  // Month - 2009-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 21.3, 244.3, 23.6, 19.0, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 21.5, 235.8, 23.6, 19.3, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 21.0, 515.8, 23.7, 18.3, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 25.6, 453.6, 32.5, 18.6, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 16.7, 536.7, 20.0, 13.3, 4.8);  // Month - 2009-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 16.6, 396.8, 22.6, 10.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 18.6, 531.4, 23.2, 13.9, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 20.0, 513.5, 27.8, 12.2, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 20.1, 511.0, 27.0, 13.1, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 22.0, 446.8, 27.8, 16.1, 3.4);  // Month - 2009-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 22.9, 436.1, 29.2, 16.6, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 23.5, 450.8, 29.3, 17.7, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 23.2, 422.7, 28.2, 18.2, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 22.5, 363.2, 27.7, 17.3, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 20.7, 459.5, 26.7, 14.7, 3.3);  // Month - 2009-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 22.0, 348.6, 27.3, 16.6, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 21.5, 379.5, 26.7, 16.2, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 22.8, 467.6, 31.0, 14.5, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 25.1, 482.5, 33.0, 17.2, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 22.3, 469.8, 26.6, 17.9, 3.8);  // Month - 2009-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 17.7, 361.2, 22.8, 12.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 15.6, 454.4, 19.9, 11.2, 3.1);  // Month - 2009-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 14.7, 245.0, 20.9, 08.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 20.1, 372.6, 26.3, 13.8, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 16.5, 170.0, 21.2, 11.7, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 17.4, 367.7, 24.7, 10.1, 2.9);  // Month - 2009-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 18.7, 441.9, 28.0, 09.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 19.5, 446.5, 27.2, 11.7, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 15.2, 412.5, 20.7, 09.7, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 14.5, 418.7, 20.9, 08.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 17.0, 437.1, 25.0, 08.9, 3.1);  // Month - 2009-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 19.9, 411.8, 27.4, 12.4, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 21.7, 408.6, 28.6, 14.7, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 22.0, 375.6, 29.2, 14.7, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 12.9, 393.7, 18.5, 07.3, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 13.0, 399.9, 21.1, 04.8, 2.2);  // Month - 2009-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 17.5, 397.4, 25.9, 09.1, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 19.9, 400.6, 27.4, 12.3, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 16.8, 243.9, 21.5, 12.1, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 13.8, 369.5, 18.1, 09.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 14.8, 335.3, 19.7, 09.9, 2.1);  // Month - 2009-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 15.4, 295.7, 22.2, 08.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 19.7, 353.1, 24.2, 15.2, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 19.5, 277.2, 25.6, 13.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 16.2, 347.9, 21.5, 10.9, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 17.0, 343.6, 24.8, 09.2, 1.7);  // Month - 2009-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 15.1, 318.8, 21.1, 09.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 16.4, 357.7, 26.4, 06.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 20.7, 368.7, 27.4, 13.9, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 19.0, 365.8, 24.9, 13.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 15.8, 349.7, 21.4, 10.2, 1.9);  // Month - 2009-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 14.5, 352.3, 22.3, 06.6, 1.7);  // Month - 2009-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 15.9, 341.2, 24.6, 07.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 16.1, 319.9, 24.4, 07.8, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 18.8, 296.1, 25.3, 12.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 13.3, 153.0, 16.9, 09.6, 0.8);  // Month - 2009-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 13.6, 327.0, 19.8, 07.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 14.3, 342.0, 22.7, 05.8, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 15.6, 324.9, 25.0, 06.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 16.4, 295.2, 25.4, 07.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 18.1, 263.3, 27.2, 09.0, 1.5);  // Month - 2009-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 17.5, 123.6, 21.1, 13.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 14.3, 110.2, 15.7, 12.9, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 14.2, 99.5, 16.1, 12.3, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 12.6, 121.0, 14.7, 10.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 09.2, 309.7, 14.7, 03.7, 1.2);  // Month - 2009-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 09.9, 258.9, 16.6, 03.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 13.0, 96.5, 17.3, 08.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 12.4, 207.1, 18.2, 06.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 09.3, 227.5, 16.8, 01.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 16.2, 144.5, 23.6, 08.8, 1.4);  // Month - 2009-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 22.5, 145.8, 25.7, 19.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 23.0, 293.7, 27.9, 18.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 22.5, 287.0, 28.2, 16.8, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 21.4, 210.3, 26.9, 15.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 19.4, 160.1, 23.7, 15.1, 1.3);  // Month - 2009-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 11.1, 285.7, 15.5, 06.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 09.4, 251.6, 14.2, 04.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 10.2, 279.4, 14.9, 05.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 09.3, 175.6, 16.2, 02.4, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 08.2, 84.5, 10.6, 05.7, 0.8);  // Month - 2009-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 11.6, 196.1, 14.0, 09.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 10.9, 164.4, 12.2, 09.5, 1.8);  // Month - 2009-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 09.0, 181.9, 12.0, 05.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 07.4, 219.5, 13.8, 00.9, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 12.6, 196.8, 16.9, 08.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 11.1, 278.5, 14.6, 07.5, 1.1);  // Month - 2009-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 10.5, 82.6, 11.7, 09.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 10.1, 159.8, 13.6, 06.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 08.2, 161.6, 13.6, 02.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 05.1, 81.8, 08.9, 01.3, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 09.5, 220.1, 16.2, 02.7, 0.6);  // Month - 2009-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 06.8, 261.2, 13.2, 00.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 06.0, 168.6, 13.1, -01.1, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 09.6, 242.3, 17.0, 02.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 13.4, 252.6, 19.5, 07.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 13.0, 188.8, 19.4, 06.5, 0.8);  // Month - 2009-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 08.1, 242.4, 15.4, 00.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 09.3, 222.3, 17.8, 00.7, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 11.0, 94.5, 15.9, 06.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 15.3, 223.0, 21.1, 09.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 15.3, 78.9, 18.5, 12.1, 1.4);  // Month - 2009-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 09.8, 78.6, 12.1, 07.5, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 08.0, 150.6, 13.6, 02.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 07.0, 205.2, 12.4, 01.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 06.2, 259.0, 11.1, 01.2, 0.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 06.5, 259.9, 13.6, -00.7, 0.5);  // Month - 2009-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 06.6, 237.2, 13.6, -00.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 07.9, 233.6, 13.6, 02.2, 0.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 08.8, 90.1, 14.3, 03.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 12.4, 79.7, 14.4, 10.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 10.4, 110.2, 11.6, 09.1, 1.2);  // Month - 2009-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 11.2, 164.7, 17.0, 05.3, 0.8);  // Month - 2009-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 09.3, 234.8, 15.4, 03.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 10.4, 268.1, 17.1, 03.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 11.1, 268.8, 18.0, 04.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 14.7, 177.6, 20.0, 09.4, 1.9);  // Month - 2009-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 13.9, 81.8, 15.3, 12.4, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 15.3, 180.9, 21.2, 09.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 06.8, 190.2, 11.0, 02.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 06.2, 254.7, 12.5, -00.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 06.0, 129.0, 12.3, -00.3, 0.9);  // Month - 2009-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 06.5, 275.8, 10.1, 02.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 09.6, 276.2, 16.2, 03.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 08.2, 256.7, 13.1, 03.2, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 06.5, 255.0, 12.5, 00.5, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 06.0, 83.9, 11.7, 00.2, 0.8);  // Month - 2009-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 09.0, 84.1, 10.7, 07.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 11.6, 215.1, 13.9, 09.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 12.0, 99.1, 13.8, 10.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 14.4, 116.6, 16.8, 11.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 12.6, 283.9, 17.0, 08.1, 1.4);  // Month - 2009-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 13.2, 87.5, 15.4, 11.0, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 07.6, 164.7, 11.0, 04.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 05.4, 231.1, 07.2, 03.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 06.3, 227.9, 09.6, 03.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 06.7, 245.9, 13.0, 00.4, 1.3);  // Month - 2009-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 06.4, 228.4, 10.8, 02.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 09.0, 286.3, 16.3, 01.7, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 05.7, 183.3, 12.1, -00.8, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 05.3, 278.2, 12.7, -02.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 04.0, 274.8, 09.3, -01.4, 0.8);  // Month - 2009-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 03.1, 147.7, 10.3, -04.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 07.5, 224.0, 13.4, 01.5, 1.1);  // Month - 2009-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 11.1, 220.4, 13.9, 08.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 10.0, 220.6, 16.7, 03.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 13.4, 220.6, 19.3, 07.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 12.6, 296.4, 18.3, 06.9, 1.3);  // Month - 2009-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 08.9, 280.6, 12.9, 04.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 08.3, 152.6, 12.8, 03.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 07.3, 273.3, 13.1, 01.4, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 07.0, 252.0, 13.7, 00.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 10.1, 238.5, 19.3, 00.8, 1.2);  // Month - 2009-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 12.6, 312.8, 20.0, 05.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 14.3, 310.3, 22.4, 06.2, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 14.8, 169.7, 18.8, 10.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 19.0, 252.4, 27.8, 10.1, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 24.7, 204.4, 29.9, 19.5, 4.0);  // Month - 2009-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 14.3, 107.8, 21.4, 07.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 10.2, 333.5, 16.4, 03.9, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 10.3, 247.1, 17.0, 03.6, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 10.0, 111.0, 12.0, 08.0, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 08.8, 292.0, 12.8, 04.7, 1.2);  // Month - 2009-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 07.8, 305.1, 14.7, 00.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 12.3, 301.4, 17.9, 06.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 11.6, 331.8, 17.6, 05.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 13.1, 303.8, 20.4, 05.7, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 17.0, 385.1, 24.1, 09.9, 2.4);  // Month - 2009-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 19.7, 356.9, 26.3, 13.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 20.9, 333.9, 27.5, 14.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 20.2, 336.0, 27.8, 12.5, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 22.5, 404.6, 29.6, 15.4, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 23.3, 366.7, 30.1, 16.5, 3.8);  // Month - 2009-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 15.4, 142.3, 17.6, 13.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 13.7, 124.7, 14.1, 13.2, 1.8);  // Month - 2009-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 13.5, 127.1, 14.3, 12.7, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 14.0, 127.1, 15.9, 12.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 12.3, 143.2, 14.6, 10.0, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 11.6, 289.0, 18.1, 05.1, 1.7);  // Month - 2009-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 15.2, 229.1, 20.6, 09.8, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 13.6, 192.8, 15.5, 11.6, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 09.7, 163.7, 11.7, 07.7, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 07.2, 346.1, 10.9, 03.4, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 07.7, 336.8, 14.5, 00.9, 1.9);  // Month - 2009-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 09.2, 404.7, 17.3, 01.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 11.3, 469.9, 17.5, 05.1, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 12.3, 416.2, 19.6, 04.9, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 15.2, 412.7, 21.0, 09.3, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 15.9, 421.6, 21.6, 10.2, 2.3);  // Month - 2009-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 14.1, 334.8, 19.2, 08.9, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 12.0, 145.0, 15.2, 08.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 14.3, 145.0, 17.4, 11.2, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 12.0, 242.2, 14.2, 09.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 12.6, 460.8, 17.9, 07.3, 2.5);  // Month - 2009-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 14.6, 503.6, 21.8, 07.3, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 14.3, 281.8, 19.3, 09.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 09.8, 436.5, 14.0, 05.5, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 10.1, 418.1, 17.7, 02.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 12.0, 437.2, 19.0, 04.9, 2.3);  // Month - 2009-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 15.8, 454.1, 22.1, 09.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 12.2, 158.9, 14.5, 09.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 08.9, 496.2, 11.6, 06.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 09.3, 511.8, 13.7, 04.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 09.8, 443.3, 15.9, 03.6, 2.7);  // Month - 2009-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 10.4, 161.3, 13.1, 07.7, 0.9);  // Month - 2009-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 12.5, 472.3, 18.9, 06.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 14.7, 509.6, 22.6, 06.7, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 16.9, 484.7, 23.7, 10.1, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 17.5, 284.0, 21.3, 13.6, 2.3);  // Month - 2009-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 13.6, 535.8, 17.4, 09.7, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 10.2, 551.8, 13.8, 06.6, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 10.3, 505.6, 16.3, 04.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 12.4, 554.6, 20.4, 04.3, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 17.4, 435.6, 24.1, 10.7, 4.3);  // Month - 2009-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 13.3, 262.8, 16.3, 10.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 12.4, 547.2, 16.3, 08.4, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 16.5, 534.7, 25.6, 07.4, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 09.4, 182.3, 13.0, 05.7, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 08.3, 485.5, 15.2, 01.4, 3.1);  // Month - 2009-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 12.1, 553.7, 19.7, 04.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 14.7, 559.7, 20.7, 08.6, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 14.7, 572.9, 22.0, 07.4, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 17.8, 409.1, 23.4, 12.2, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 17.0, 466.2, 24.6, 09.3, 3.7);  // Month - 2009-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 13.6, 182.4, 16.2, 11.0, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 16.3, 562.5, 22.4, 10.1, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 20.8, 560.6, 29.0, 12.6, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 13.3, 512.2, 17.9, 08.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 14.4, 568.4, 22.2, 06.6, 4.3);  // Month - 2009-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 11.6, 640.0, 16.1, 07.1, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 13.6, 613.6, 23.0, 04.1, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 19.2, 458.9, 25.6, 12.7, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 23.2, 591.4, 32.7, 13.6, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 21.9, 236.5, 27.8, 16.0, 3.3);  // Month - 2009-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 17.9, 191.9, 21.2, 14.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 19.9, 193.8, 22.5, 17.2, 1.5);  // Month - 2009-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 19.1, 193.8, 21.1, 17.1, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 15.9, 494.0, 20.0, 11.8, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 16.0, 426.7, 19.8, 12.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 19.1, 566.9, 24.7, 13.4, 4.5);  // Month - 2009-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 20.7, 236.3, 25.8, 15.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 12.9, 415.7, 17.8, 07.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 15.4, 669.5, 24.0, 06.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 16.5, 629.2, 23.5, 09.5, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 15.6, 634.2, 22.6, 08.6, 5.1);  // Month - 2009-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 18.6, 701.7, 26.6, 10.5, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 20.6, 687.2, 29.2, 11.9, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 23.6, 465.3, 29.7, 17.4, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 19.2, 505.4, 24.3, 14.1, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 19.4, 529.9, 26.2, 12.6, 4.4);  // Month - 2009-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 20.9, 692.2, 27.7, 14.0, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 19.8, 221.4, 22.5, 17.1, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 19.0, 229.9, 21.7, 16.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 18.7, 510.3, 22.7, 14.7, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 18.7, 629.5, 26.0, 11.3, 5.5);  // Month - 2009-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 18.9, 236.0, 21.5, 16.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 20.2, 244.6, 23.3, 17.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 22.0, 435.3, 27.2, 16.7, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 24.0, 468.1, 28.7, 19.3, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 24.3, 544.7, 29.9, 18.6, 5.0);  // Month - 2009-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 20.9, 701.1, 25.5, 16.3, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 17.0, 324.7, 21.0, 12.9, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 19.9, 377.6, 25.5, 14.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 21.7, 241.6, 26.2, 17.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 19.4, 626.6, 24.6, 14.2, 5.1);  // Month - 2009-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 19.4, 531.7, 26.3, 12.4, 5.0);  // Month - 2009-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 21.3, 495.9, 25.2, 17.4, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 14.5, 725.1, 19.0, 10.0, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 14.4, 396.3, 20.8, 08.0, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 14.1, 645.4, 18.9, 09.3, 4.3);  // Month - 2009-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 16.0, 677.7, 21.6, 10.3, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 14.2, 637.4, 20.8, 07.6, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 18.5, 666.7, 25.8, 11.1, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 21.0, 651.1, 27.2, 14.8, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 22.7, 707.3, 29.8, 15.6, 6.0);  // Month - 2009-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 21.2, 217.4, 24.0, 18.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 17.4, 640.3, 21.6, 13.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 17.7, 624.7, 25.3, 10.1, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 20.9, 524.0, 26.9, 14.9, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 21.3, 653.7, 26.1, 16.4, 4.6);  // Month - 2009-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 19.1, 267.0, 21.9, 16.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 20.9, 755.3, 28.2, 13.5, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 23.4, 756.2, 30.6, 16.2, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 26.5, 502.3, 33.2, 19.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 21.8, 260.1, 25.2, 18.4, 2.9);  // Month - 2009-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 20.1, 710.1, 26.6, 13.5, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 22.3, 455.2, 29.5, 15.1, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 24.4, 334.0, 27.9, 20.9, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 21.9, 240.4, 24.3, 19.4, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 21.1, 414.4, 25.5, 16.6, 3.8);  // Month - 2009-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 23.1, 341.1, 26.1, 20.0, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 24.1, 555.1, 28.3, 19.9, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 23.3, 255.7, 27.3, 19.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 23.3, 421.2, 29.4, 17.2, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 20.9, 720.0, 26.2, 15.5, 6.6);  // Month - 2009-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 19.5, 662.8, 26.0, 12.9, 5.9);  


            #endregion

                            
        }

        public static void WeatherDataLasBrujas_2010(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2010, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2010
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 19.3, 734.5, 27.4, 11.2, 5.2);  // Month - 2010-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 24.3, 584.5, 31.8, 16.7, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 25.0, 673.4, 31.9, 18.0, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 24.9, 431.4, 29.3, 20.4, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 25.2, 640.8, 31.0, 19.3, 5.4);  // Month - 2010-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 18.2, 555.9, 23.1, 13.3, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 18.0, 632.2, 26.1, 09.9, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 20.9, 741.0, 29.4, 12.4, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 25.1, 660.4, 32.1, 18.0, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 26.8, 466.7, 31.7, 21.8, 4.2);  // Month - 2010-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 25.0, 660.4, 31.5, 18.5, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 21.4, 498.7, 24.6, 18.2, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 21.4, 712.6, 28.1, 14.7, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 22.5, 727.0, 29.9, 15.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 23.9, 657.0, 31.7, 16.0, 6.1);  // Month - 2010-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 21.4, 318.5, 25.7, 17.0, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 24.8, 683.5, 33.7, 15.8, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 27.0, 501.9, 33.9, 20.1, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 22.3, 228.3, 25.3, 19.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 21.4, 723.9, 26.6, 16.1, 5.4);  // Month - 2010-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 23.7, 726.9, 31.7, 15.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 24.9, 721.5, 31.5, 18.2, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 24.3, 632.4, 29.7, 18.9, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 24.2, 679.3, 30.8, 17.5, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 25.9, 689.9, 31.8, 19.9, 5.8);  // Month - 2010-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 24.5, 684.9, 30.6, 18.3, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 24.9, 707.4, 31.0, 18.8, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 25.7, 686.5, 31.9, 19.5, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 26.6, 693.4, 33.2, 20.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 26.6, 447.0, 30.6, 22.5, 4.0);  // Month - 2010-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 25.7, 268.2, 29.0, 22.3, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 26.7, 627.8, 32.4, 21.0, 5.3);  // Month - 2010-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 25.4, 243.2, 28.0, 22.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 25.8, 333.4, 31.3, 20.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 23.5, 273.4, 27.2, 19.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 23.2, 201.4, 26.0, 20.3, 1.7);  // Month - 2010-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 23.6, 282.8, 26.7, 20.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 21.9, 246.4, 24.5, 19.2, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 23.7, 604.3, 28.8, 18.6, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 24.1, 656.7, 32.1, 16.0, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 24.2, 615.6, 30.6, 17.8, 4.9);  // Month - 2010-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 26.7, 632.8, 32.0, 21.3, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 26.8, 603.8, 32.2, 21.3, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 28.1, 374.5, 34.1, 22.0, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 21.3, 553.5, 24.1, 18.4, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 22.6, 417.4, 28.3, 16.8, 3.4);  // Month - 2010-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 20.6, 263.1, 23.3, 17.9, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 20.4, 627.3, 26.0, 14.7, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 22.6, 618.0, 29.1, 16.0, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 26.0, 358.4, 30.8, 21.1, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 25.5, 186.6, 28.8, 22.2, 1.7);  // Month - 2010-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 23.0, 200.7, 24.6, 21.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 24.4, 312.7, 28.8, 20.0, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 18.1, 446.5, 23.1, 13.0, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 16.8, 575.7, 21.1, 12.4, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 15.7, 532.7, 20.3, 11.1, 3.4);  // Month - 2010-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 17.6, 575.3, 26.0, 09.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 19.8, 491.1, 25.9, 13.7, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 19.8, 477.7, 25.8, 13.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 21.1, 523.3, 28.0, 14.2, 3.5);  // Month - 2010-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 24.8, 524.2, 30.5, 19.1, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 25.0, 204.3, 28.9, 21.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 24.9, 373.9, 29.2, 20.6, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 22.8, 564.1, 26.9, 18.6, 3.9);  // Month - 2010-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 21.5, 543.4, 25.7, 17.2, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 20.7, 479.9, 26.5, 14.8, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 21.9, 427.6, 27.0, 16.8, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 24.4, 450.4, 28.9, 19.9, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 23.7, 363.0, 29.4, 17.9, 2.7);  // Month - 2010-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 20.2, 432.1, 23.2, 17.1, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 18.5, 514.6, 23.5, 13.5, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 20.3, 290.7, 28.4, 12.1, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 20.1, 401.1, 23.0, 17.1, 9.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 16.9, 541.9, 21.2, 12.5, 6.1);  // Month - 2010-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 17.4, 535.6, 24.8, 10.0, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 21.2, 415.6, 29.0, 13.3, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 22.0, 244.7, 25.7, 18.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 23.2, 421.8, 29.3, 17.1, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 21.0, 443.4, 24.6, 17.4, 3.7);  // Month - 2010-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 20.2, 162.0, 24.0, 16.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 20.6, 510.2, 25.4, 15.8, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 19.7, 486.8, 27.6, 11.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 18.1, 504.1, 24.6, 11.5, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 16.8, 484.6, 24.7, 08.9, 3.4);  // Month - 2010-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 19.8, 498.1, 26.6, 12.9, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 23.3, 432.3, 28.8, 17.8, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 21.1, 469.2, 26.6, 15.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 21.3, 404.0, 27.6, 14.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 20.7, 333.1, 26.8, 14.6, 2.1);  // Month - 2010-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 24.8, 450.0, 31.0, 18.5, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 21.4, 436.8, 27.8, 15.0, 2.6);  // Month - 2010-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 17.9, 227.4, 24.5, 11.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 17.8, 270.4, 21.0, 14.6, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 15.4, 335.2, 18.9, 11.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 14.9, 443.5, 20.4, 09.3, 2.0);  // Month - 2010-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 14.6, 437.2, 22.4, 06.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 15.0, 418.5, 23.0, 06.9, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 16.5, 310.2, 23.9, 09.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 16.9, 424.9, 24.4, 09.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 18.7, 424.8, 25.9, 11.5, 2.3);  // Month - 2010-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 20.0, 387.5, 27.4, 12.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 21.3, 402.6, 28.8, 13.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 21.1, 178.2, 26.0, 16.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 15.6, 126.1, 16.9, 14.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 12.9, 125.0, 15.2, 10.6, 0.7);  // Month - 2010-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 15.3, 415.1, 20.4, 10.2, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 14.9, 184.3, 21.6, 08.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 23.1, 299.2, 29.1, 17.1, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 18.7, 343.5, 23.4, 13.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 15.9, 223.1, 20.9, 10.8, 1.0);  // Month - 2010-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 16.1, 350.0, 21.6, 10.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 13.4, 336.1, 19.2, 07.5, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 11.0, 378.7, 16.4, 05.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 10.3, 219.0, 18.4, 02.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 16.0, 117.1, 19.4, 12.6, 0.8);  // Month - 2010-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 13.9, 377.1, 19.0, 08.7, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 13.9, 335.6, 21.0, 06.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 14.7, 379.6, 22.1, 07.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 14.5, 363.1, 20.4, 08.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 15.5, 349.7, 24.3, 06.7, 1.9);  // Month - 2010-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 19.8, 371.1, 26.5, 13.0, 1.9);  // Month - 2010-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 19.5, 224.0, 26.6, 12.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 16.6, 158.6, 22.6, 10.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 15.7, 256.8, 20.8, 10.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 14.6, 251.8, 21.5, 07.7, 0.9);  // Month - 2010-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 14.5, 130.9, 18.4, 10.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 10.4, 285.7, 16.0, 04.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 09.8, 327.4, 17.2, 02.4, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 10.7, 320.6, 19.2, 02.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 11.9, 321.4, 20.1, 03.6, 0.8);  // Month - 2010-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 12.1, 276.9, 20.3, 03.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 14.2, 312.9, 22.4, 06.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 14.4, 231.3, 20.9, 07.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 16.1, 296.8, 22.9, 09.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 15.6, 152.1, 18.8, 12.4, 1.5);  // Month - 2010-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 10.6, 222.2, 14.0, 07.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 11.1, 164.7, 17.4, 04.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 15.8, 199.8, 20.6, 10.9, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 17.9, 119.1, 20.6, 15.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 18.3, 101.4, 20.0, 16.5, 0.8);  // Month - 2010-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 18.3, 93.5, 20.7, 15.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 18.5, 137.7, 21.9, 15.1, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 19.9, 139.0, 22.9, 16.9, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 16.9, 88.9, 18.6, 15.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 13.4, 218.1, 17.6, 09.1, 1.2);  // Month - 2010-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 12.5, 260.3, 18.9, 06.1, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 14.3, 178.3, 20.0, 08.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 17.0, 140.6, 20.6, 13.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 14.8, 85.2, 15.7, 13.9, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 13.9, 167.5, 15.3, 12.4, 1.7);  // Month - 2010-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 10.0, 200.6, 14.0, 06.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 08.7, 265.0, 15.3, 02.1, 0.6);  // Month - 2010-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 11.2, 260.1, 18.7, 03.6, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 14.7, 239.6, 21.2, 08.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 11.8, 125.5, 15.4, 08.1, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 12.5, 234.0, 18.8, 06.1, 0.8);  // Month - 2010-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 15.1, 277.8, 21.3, 08.9, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 11.7, 255.0, 16.8, 06.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 08.2, 254.3, 14.2, 02.2, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 06.9, 200.8, 12.6, 01.1, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 09.7, 253.0, 15.3, 04.1, 0.6);  // Month - 2010-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 12.6, 250.2, 18.5, 06.6, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 12.7, 81.0, 13.6, 11.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 14.8, 91.7, 16.9, 12.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 16.8, 97.9, 18.9, 14.7, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 13.5, 186.6, 19.0, 08.0, 0.6);  // Month - 2010-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 12.2, 164.4, 16.8, 07.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 10.7, 263.4, 16.1, 05.2, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 11.5, 105.3, 15.5, 07.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 10.2, 216.6, 13.6, 06.7, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 10.5, 258.6, 14.9, 06.1, 1.1);  // Month - 2010-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 06.2, 174.6, 09.8, 02.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 09.8, 237.8, 17.5, 02.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 13.7, 251.8, 21.3, 06.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 11.1, 203.7, 17.4, 04.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 09.0, 244.9, 16.9, 01.0, 0.6);  // Month - 2010-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 09.4, 106.7, 15.4, 03.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 11.3, 79.1, 13.2, 09.3, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 10.2, 253.5, 15.4, 04.9, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 09.6, 241.4, 16.1, 03.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 13.2, 190.2, 17.6, 08.8, 0.9);  // Month - 2010-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 14.7, 84.5, 18.6, 10.8, 0.7);  // Month - 2010-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 16.9, 156.5, 21.5, 12.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 18.6, 141.7, 23.1, 14.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 22.0, 238.2, 27.3, 16.6, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 17.0, 87.8, 20.1, 13.9, 1.4);  // Month - 2010-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 15.7, 114.4, 18.1, 13.3, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 10.2, 86.2, 14.2, 06.2, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 10.4, 236.6, 16.8, 04.0, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 09.3, 270.2, 14.6, 03.9, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 06.5, 182.1, 13.0, -00.1, 0.5);  // Month - 2010-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 11.0, 105.3, 14.6, 07.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 08.4, 185.2, 11.0, 05.7, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 05.2, 127.8, 09.0, 01.4, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 06.3, 163.7, 08.7, 03.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 04.5, 273.2, 08.6, 00.4, 0.6);  // Month - 2010-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 05.1, 260.3, 09.7, 00.5, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 03.9, 176.9, 10.6, -02.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 10.1, 85.5, 13.3, 06.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 09.7, 86.2, 13.7, 05.7, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 09.7, 279.3, 14.3, 05.1, 0.8);  // Month - 2010-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 08.0, 274.2, 14.5, 01.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 07.5, 206.4, 14.0, 01.0, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 07.6, 291.7, 14.4, 00.8, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 08.3, 185.7, 14.0, 02.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 10.3, 90.3, 11.6, 09.0, 0.7);  // Month - 2010-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 09.6, 240.3, 14.6, 04.5, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 11.1, 306.0, 18.4, 03.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 11.6, 255.1, 17.7, 05.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 09.1, 203.6, 16.0, 02.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 12.1, 93.7, 13.9, 10.3, 0.8);  // Month - 2010-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 08.9, 315.1, 11.9, 05.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 06.4, 306.8, 08.4, 04.3, 1.2);  // Month - 2010-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 05.4, 306.0, 09.1, 01.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 05.9, 285.6, 09.7, 02.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 05.6, 252.7, 10.8, 00.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 08.9, 187.1, 12.3, 05.5, 0.9);  // Month - 2010-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 09.3, 274.5, 15.7, 02.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 08.9, 260.8, 15.0, 02.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 07.7, 230.6, 12.4, 03.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 09.8, 322.7, 17.5, 02.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 09.2, 333.3, 18.2, 00.1, 1.2);  // Month - 2010-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 09.3, 243.1, 17.1, 01.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 11.2, 104.7, 13.5, 08.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 08.4, 145.0, 10.4, 06.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 08.4, 228.8, 10.8, 05.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 07.7, 315.1, 12.2, 03.1, 1.1);  // Month - 2010-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 11.6, 253.3, 18.3, 04.8, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 14.8, 325.5, 21.3, 08.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 16.5, 120.7, 21.8, 11.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 11.8, 362.9, 16.7, 06.8, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 11.0, 376.5, 18.0, 03.9, 1.7);  // Month - 2010-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 15.2, 379.1, 24.5, 05.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 18.4, 229.1, 23.4, 13.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 18.4, 205.8, 24.0, 12.7, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 09.6, 404.5, 16.1, 03.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 09.4, 314.3, 18.8, 00.0, 1.3);  // Month - 2010-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 13.4, 268.1, 19.0, 07.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 14.7, 282.4, 20.0, 09.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 15.1, 120.5, 19.0, 11.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 10.0, 312.2, 15.2, 04.8, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 09.9, 291.1, 17.0, 02.8, 2.4);  // Month - 2010-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 14.9, 123.7, 16.7, 13.1, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 12.3, 124.7, 15.5, 09.1, 1.2);  // Month - 2010-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 10.8, 125.9, 12.1, 09.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 13.8, 127.1, 17.6, 09.9, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 10.0, 176.1, 12.8, 07.1, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 11.8, 433.5, 16.2, 07.3, 2.4);  // Month - 2010-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 14.9, 448.5, 23.7, 06.1, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 15.6, 448.6, 21.6, 09.6, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 15.9, 424.1, 23.1, 08.6, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 16.4, 433.1, 23.6, 09.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 19.9, 373.9, 25.9, 13.8, 3.1);  // Month - 2010-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 11.8, 186.5, 15.5, 08.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 10.0, 222.4, 15.0, 05.0, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 11.3, 145.3, 15.1, 07.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 11.9, 241.6, 14.8, 08.9, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 13.9, 421.6, 20.1, 07.6, 2.7);  // Month - 2010-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 13.7, 250.0, 19.2, 08.2, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 08.8, 443.2, 13.0, 04.6, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 10.1, 478.0, 19.1, 01.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 15.4, 478.0, 22.3, 08.5, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 17.8, 418.7, 25.3, 10.2, 3.1);  // Month - 2010-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 16.3, 234.0, 20.2, 12.3, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 17.7, 410.6, 24.7, 10.7, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 11.8, 509.4, 17.3, 06.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 11.6, 439.2, 19.3, 03.8, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 16.3, 478.5, 21.6, 11.0, 2.9);  // Month - 2010-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 16.7, 487.7, 23.3, 10.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 15.5, 490.3, 23.1, 07.9, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 14.8, 156.7, 17.3, 12.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 14.8, 181.7, 17.2, 12.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 13.0, 176.1, 14.9, 11.1, 2.5);  // Month - 2010-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 11.8, 339.1, 14.5, 09.1, 2.6);  // Month - 2010-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 12.5, 541.4, 17.7, 07.2, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 13.8, 551.3, 22.5, 05.0, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 15.2, 532.9, 23.3, 07.1, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 16.1, 539.9, 24.1, 08.0, 3.9);  // Month - 2010-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 17.6, 387.8, 24.7, 10.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 16.5, 365.0, 19.3, 13.6, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 14.9, 452.3, 19.5, 10.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 14.8, 444.0, 19.2, 10.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 14.5, 536.0, 21.5, 07.4, 3.1);  // Month - 2010-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 15.1, 545.0, 22.5, 07.6, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 16.1, 550.8, 24.7, 07.5, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 19.4, 556.3, 27.2, 11.5, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 16.8, 175.1, 18.5, 15.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 15.9, 176.2, 17.0, 14.7, 1.6);  // Month - 2010-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 14.1, 403.9, 17.5, 10.6, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 12.9, 471.8, 15.7, 10.1, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 14.6, 484.6, 17.9, 11.2, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 17.1, 575.0, 25.6, 08.6, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 19.0, 601.2, 27.2, 10.8, 4.7);  // Month - 2010-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 20.1, 571.6, 26.9, 13.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 12.8, 354.3, 17.8, 07.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 10.5, 594.1, 16.4, 04.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 13.3, 257.4, 18.0, 08.6, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 13.6, 583.4, 19.9, 07.3, 3.4);  // Month - 2010-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 12.9, 596.4, 18.5, 07.3, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 13.5, 515.7, 21.0, 06.0, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 16.5, 419.4, 21.4, 11.6, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 16.3, 394.5, 22.0, 10.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 15.3, 631.4, 18.3, 12.2, 5.8);  // Month - 2010-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 16.1, 465.9, 18.8, 13.3, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 14.5, 620.2, 18.2, 10.8, 3.8);  // Month - 2010-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 15.7, 645.3, 22.7, 08.6, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 20.4, 643.6, 31.2, 09.5, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 18.0, 212.1, 22.1, 13.9, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 17.9, 647.9, 24.0, 11.7, 4.4);  // Month - 2010-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 17.9, 551.4, 26.2, 09.6, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 22.7, 673.4, 32.9, 12.5, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 16.9, 340.8, 23.1, 10.6, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 12.0, 376.7, 16.1, 07.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 11.3, 704.4, 15.1, 07.5, 4.3);  // Month - 2010-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 12.0, 701.7, 17.6, 06.3, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 14.1, 683.3, 22.9, 05.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 15.8, 700.1, 23.7, 07.9, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 16.9, 599.5, 23.5, 10.2, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 17.2, 570.4, 22.6, 11.7, 4.6);  // Month - 2010-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 17.5, 402.1, 21.5, 13.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 17.7, 468.8, 21.0, 14.4, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 18.4, 708.8, 23.2, 13.6, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 19.6, 621.6, 27.6, 11.5, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 22.7, 515.2, 28.8, 16.5, 5.0);  // Month - 2010-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 20.5, 638.8, 27.3, 13.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 19.8, 375.0, 22.8, 16.7, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 19.8, 460.2, 24.0, 15.6, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 19.4, 725.9, 26.6, 12.2, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 21.3, 711.5, 28.9, 13.6, 6.0);  // Month - 2010-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 23.3, 689.2, 31.5, 15.1, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 22.3, 280.0, 27.5, 17.0, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 14.6, 644.1, 20.2, 09.0, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 14.8, 713.5, 22.7, 06.9, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 19.2, 704.1, 28.1, 10.3, 6.0);  // Month - 2010-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 24.1, 748.2, 33.6, 14.5, 7.7);  // Month - 2010-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 23.1, 636.4, 29.7, 16.4, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 19.9, 761.2, 25.2, 14.6, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 19.6, 569.0, 28.3, 10.9, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 19.8, 757.8, 25.0, 14.6, 7.3);  // Month - 2010-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 20.7, 766.0, 31.6, 09.7, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 24.6, 637.4, 34.0, 15.1, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 18.5, 751.0, 23.6, 13.3, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 19.2, 598.4, 27.8, 10.6, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 22.1, 446.1, 31.4, 12.8, 5.1);  // Month - 2010-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 23.0, 595.6, 30.3, 15.6, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 13.5, 286.0, 18.7, 08.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 16.4, 769.1, 24.8, 08.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 21.9, 769.6, 31.0, 12.7, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 23.8, 773.7, 32.4, 15.2, 8.1);  // Month - 2010-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 24.0, 766.5, 31.8, 16.1, 8.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 26.1, 626.2, 32.6, 19.6, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 18.8, 219.1, 21.6, 16.0, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 20.8, 538.7, 26.4, 15.1, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 24.3, 749.8, 31.9, 16.7, 6.9);  // Month - 2010-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 26.8, 770.9, 34.8, 18.7, 7.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 26.9, 779.5, 35.5, 18.3, 8.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 25.9, 752.0, 35.3, 16.5, 8.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 24.0, 690.5, 28.7, 19.3, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 26.3, 774.9, 34.8, 17.8, 7.8);  // Month - 2010-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 25.9, 741.5, 31.8, 19.9, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 27.3, 777.5, 36.9, 17.7, 8.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 24.7, 765.1, 32.1, 17.3, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 22.9, 534.4, 29.6, 16.2, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 23.7, 768.5, 29.8, 17.5, 7.1);  // Month - 2010-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 23.9, 678.9, 30.7, 17.1, 6.6);  
  


            #endregion
                            
        }

        public static void WeatherDataLasBrujas_2011(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2011, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2011
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 22.9, 617.5, 28.2, 17.5, 5.8);  // Month - 2011-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 23.9, 592.5, 29.4, 18.4, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 24.8, 612.9, 29.6, 19.9, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 23.6, 306.4, 28.2, 18.9, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 25.0, 427.2, 30.3, 19.6, 4.0);  // Month - 2011-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 26.1, 757.4, 33.5, 18.7, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 24.5, 696.6, 30.9, 18.0, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 24.8, 523.3, 29.5, 20.1, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 24.3, 737.0, 30.2, 18.3, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 23.2, 700.7, 29.7, 16.6, 6.6);  // Month - 2011-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 24.5, 486.8, 29.6, 19.3, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 23.0, 688.3, 28.1, 17.8, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 22.7, 736.8, 31.3, 14.0, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 25.0, 682.7, 31.9, 18.1, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 25.3, 737.4, 31.8, 18.7, 7.4);  // Month - 2011-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 28.3, 575.7, 37.2, 19.3, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 22.7, 695.5, 27.5, 17.8, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 21.8, 734.7, 32.0, 11.5, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 23.7, 364.5, 29.3, 18.0, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 21.7, 743.9, 27.2, 16.1, 6.9);  // Month - 2011-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 20.6, 722.9, 30.5, 10.6, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 23.7, 733.5, 32.2, 15.2, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 27.4, 724.1, 35.1, 19.7, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 27.2, 723.1, 35.3, 19.0, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 28.9, 618.3, 37.5, 20.3, 6.9);  // Month - 2011-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 27.3, 283.4, 30.3, 24.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 24.9, 647.8, 28.5, 21.3, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 25.0, 690.5, 32.0, 17.9, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 23.4, 717.2, 29.4, 17.4, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 25.7, 700.3, 35.3, 16.1, 7.6);  // Month - 2011-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 26.0, 383.0, 29.8, 22.1, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 19.8, 699.0, 24.2, 15.3, 6.1);  // Month - 2011-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 21.5, 705.9, 32.1, 10.8, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 26.2, 689.0, 35.2, 17.1, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 22.6, 675.8, 27.7, 17.5, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 24.6, 650.0, 33.7, 15.4, 6.1);  // Month - 2011-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 19.9, 667.4, 25.4, 14.4, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 21.9, 340.3, 28.1, 15.7, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 20.7, 218.0, 22.8, 18.5, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 22.1, 244.2, 24.7, 19.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 21.2, 654.4, 26.1, 16.3, 5.2);  // Month - 2011-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 20.2, 617.3, 27.0, 13.3, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 21.6, 611.6, 29.6, 13.6, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 21.7, 547.8, 27.4, 16.0, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 21.8, 641.8, 28.2, 15.4, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 22.2, 635.6, 32.7, 11.7, 6.6);  // Month - 2011-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 24.0, 621.9, 33.4, 14.5, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 27.5, 608.2, 34.9, 20.0, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 25.8, 374.8, 29.8, 21.7, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 23.9, 236.9, 26.7, 21.1, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 23.5, 610.7, 27.3, 19.6, 5.5);  // Month - 2011-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 23.5, 620.1, 28.1, 18.8, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 23.8, 595.2, 29.1, 18.5, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 21.8, 183.6, 25.2, 18.4, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 20.7, 265.0, 23.4, 17.9, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 21.0, 402.0, 24.8, 17.1, 3.4);  // Month - 2011-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 20.1, 590.2, 26.1, 14.0, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 21.9, 602.4, 29.9, 13.9, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 22.0, 581.2, 27.8, 16.2, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 21.0, 574.8, 28.1, 13.8, 4.9);  // Month - 2011-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 22.5, 582.8, 29.7, 15.3, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 23.4, 576.5, 30.4, 16.4, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 24.5, 562.9, 30.2, 18.7, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 22.9, 564.1, 28.3, 17.4, 5.0);  // Month - 2011-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 23.6, 565.1, 30.7, 16.5, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 25.3, 418.8, 31.7, 18.8, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 25.2, 373.9, 29.6, 20.8, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 26.1, 425.5, 33.1, 19.1, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 25.7, 551.5, 31.4, 20.0, 5.1);  // Month - 2011-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 26.7, 485.3, 33.3, 20.0, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 26.4, 422.8, 33.5, 19.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 17.8, 533.4, 21.0, 14.5, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 15.8, 537.7, 20.7, 10.9, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 15.9, 531.4, 24.9, 06.9, 3.6);  // Month - 2011-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 21.3, 431.5, 26.8, 15.8, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 20.7, 201.2, 23.9, 17.5, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 19.2, 503.1, 24.7, 13.6, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 18.3, 511.0, 25.9, 10.7, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 20.1, 518.5, 30.0, 10.1, 4.4);  // Month - 2011-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 23.4, 519.5, 31.9, 14.9, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 25.8, 455.9, 33.3, 18.2, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 20.1, 152.9, 23.3, 16.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 19.1, 500.8, 22.7, 15.5, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 18.0, 150.5, 21.7, 14.3, 2.6);  // Month - 2011-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 20.0, 358.5, 25.1, 14.8, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 17.1, 505.1, 21.4, 12.8, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 15.5, 482.4, 22.8, 08.2, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 17.3, 492.3, 25.4, 09.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 18.1, 482.8, 26.5, 09.7, 3.6);  // Month - 2011-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 22.2, 472.6, 29.3, 15.1, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 21.9, 462.4, 27.3, 16.5, 3.2);  // Month - 2011-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 20.5, 452.1, 26.2, 14.7, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 20.3, 273.6, 26.2, 14.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 16.7, 370.1, 20.1, 13.2, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 16.4, 449.8, 22.5, 10.2, 2.9);  // Month - 2011-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 17.4, 443.5, 22.4, 12.4, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 18.8, 384.1, 26.9, 10.7, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 17.4, 381.5, 21.9, 12.8, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 17.2, 418.7, 24.0, 10.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 17.7, 317.7, 25.2, 10.2, 2.1);  // Month - 2011-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 21.0, 405.7, 27.5, 14.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 21.9, 345.4, 28.5, 15.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 22.5, 423.4, 28.9, 16.1, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 17.4, 230.1, 21.1, 13.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 15.0, 175.3, 17.9, 12.0, 1.3);  // Month - 2011-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 15.5, 421.0, 21.3, 09.6, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 17.9, 315.8, 22.4, 13.4, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 13.8, 421.3, 20.2, 07.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 15.5, 418.7, 23.7, 07.3, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 14.2, 119.7, 16.3, 12.1, 1.2);  // Month - 2011-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 17.1, 158.6, 19.1, 15.0, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 20.3, 321.9, 26.8, 13.7, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 13.8, 367.4, 18.3, 09.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 14.6, 392.8, 23.6, 05.6, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 16.0, 368.8, 22.8, 09.1, 1.9);  // Month - 2011-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 16.0, 388.2, 24.7, 07.2, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 18.3, 379.8, 25.2, 11.3, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 19.4, 313.9, 26.4, 12.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 20.0, 303.2, 25.4, 14.5, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 19.5, 200.9, 22.8, 16.1, 1.5);  // Month - 2011-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 14.6, 107.9, 17.0, 12.2, 1.5);  // Month - 2011-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 10.8, 362.5, 15.4, 06.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 10.7, 359.6, 18.2, 03.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 13.5, 246.3, 19.6, 07.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 13.5, 345.4, 19.3, 07.6, 1.4);  // Month - 2011-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 11.8, 334.8, 18.2, 05.3, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 14.3, 311.3, 22.0, 06.5, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 11.2, 317.2, 16.6, 05.7, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 09.8, 325.7, 17.9, 01.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 13.7, 275.9, 21.5, 05.8, 1.3);  // Month - 2011-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 15.2, 299.5, 23.3, 07.1, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 15.2, 295.3, 21.3, 09.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 14.1, 141.8, 18.1, 10.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 14.9, 160.6, 18.4, 11.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 13.9, 309.7, 18.7, 09.1, 1.2);  // Month - 2011-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 11.8, 276.0, 18.4, 05.1, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 12.6, 298.6, 19.3, 05.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 14.0, 311.2, 20.9, 07.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 13.6, 294.9, 20.8, 06.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 17.4, 197.2, 23.8, 10.9, 1.5);  // Month - 2011-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 17.0, 298.1, 23.8, 10.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 16.2, 166.0, 21.9, 10.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 08.9, 275.3, 13.7, 04.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 10.2, 175.3, 16.8, 03.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 12.4, 99.8, 14.7, 10.1, 1.0);  // Month - 2011-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 11.7, 87.4, 14.1, 09.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 12.4, 171.4, 16.3, 08.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 12.0, 286.2, 17.2, 06.7, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 09.3, 168.9, 13.8, 04.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 10.9, 84.5, 15.5, 06.3, 1.2);  // Month - 2011-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 12.0, 240.9, 17.1, 06.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 10.2, 193.5, 17.1, 03.3, 0.5);  // Month - 2011-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 10.7, 186.4, 17.4, 03.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 11.1, 250.7, 13.0, 09.1, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 06.5, 143.3, 11.7, 01.3, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 06.3, 247.4, 12.9, -00.4, 0.6);  // Month - 2011-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 06.8, 82.6, 08.8, 04.8, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 10.5, 137.7, 13.7, 07.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 10.1, 205.7, 15.2, 05.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 12.0, 218.4, 16.7, 07.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 11.2, 182.7, 16.6, 05.7, 1.1);  // Month - 2011-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 14.7, 245.8, 20.4, 09.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 11.9, 148.9, 16.6, 07.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 08.3, 253.3, 12.7, 03.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 07.9, 213.4, 15.9, -00.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 14.7, 99.8, 18.0, 11.4, 1.2);  // Month - 2011-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 15.6, 88.6, 17.7, 13.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 14.0, 81.8, 16.9, 11.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 14.4, 113.9, 17.6, 11.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 17.6, 130.7, 20.4, 14.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 11.5, 89.6, 15.0, 07.9, 0.8);  // Month - 2011-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 10.4, 200.2, 14.4, 06.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 10.4, 188.9, 15.0, 05.7, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 11.5, 82.3, 13.6, 09.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 09.9, 252.6, 15.1, 04.6, 0.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 09.8, 189.5, 13.1, 06.5, 1.2);  // Month - 2011-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 08.0, 100.3, 09.6, 06.4, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 08.7, 263.6, 11.9, 05.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 08.6, 253.5, 13.7, 03.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 08.3, 263.0, 14.8, 01.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 08.5, 257.2, 13.8, 03.1, 1.2);  // Month - 2011-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 04.6, 245.7, 10.5, -01.3, 0.7);  // Month - 2011-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 03.7, 269.6, 09.5, -02.1, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 04.6, 239.8, 07.9, 01.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 06.4, 238.2, 10.4, 02.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 06.1, 260.9, 10.3, 01.9, 0.6);  // Month - 2011-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 06.4, 275.6, 10.6, 02.2, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 07.0, 269.0, 14.1, -00.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 10.0, 234.8, 17.7, 02.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 11.5, 197.2, 19.3, 03.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 12.5, 115.8, 17.4, 07.5, 1.2);  // Month - 2011-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 13.3, 220.3, 19.7, 06.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 15.1, 267.4, 21.0, 09.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 10.1, 261.2, 17.5, 02.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 10.9, 188.2, 17.5, 04.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 14.4, 84.1, 17.5, 11.2, 1.0);  // Month - 2011-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 09.0, 231.3, 14.1, 03.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 07.3, 217.3, 14.2, 00.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 11.4, 123.9, 13.8, 08.9, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 10.4, 136.2, 13.3, 07.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 09.3, 89.2, 10.7, 07.8, 0.8);  // Month - 2011-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 07.9, 126.7, 11.5, 04.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 09.3, 294.5, 16.1, 02.4, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 10.3, 298.7, 16.5, 04.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 11.6, 302.4, 19.1, 04.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 18.0, 267.1, 24.7, 11.3, 2.2);  // Month - 2011-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 11.6, 299.6, 16.4, 06.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 09.9, 182.1, 15.0, 04.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 11.3, 94.7, 13.8, 08.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 09.9, 227.7, 13.1, 06.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 07.1, 214.5, 09.5, 04.7, 1.2);  // Month - 2011-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 05.7, 249.6, 10.2, 01.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 04.7, 114.5, 09.7, -00.4, 1.0);  // Month - 2011-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 09.3, 284.0, 12.3, 06.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 08.7, 143.1, 11.1, 06.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 06.7, 301.3, 10.5, 02.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 09.9, 321.2, 17.1, 02.6, 1.5);  // Month - 2011-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 12.1, 333.0, 19.9, 04.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 13.7, 246.9, 19.0, 08.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 14.5, 185.3, 18.1, 10.9, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 14.6, 125.7, 17.6, 11.5, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 16.8, 246.6, 21.1, 12.5, 2.2);  // Month - 2011-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 16.7, 343.6, 23.7, 09.7, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 14.8, 108.8, 18.6, 11.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 10.1, 268.4, 15.5, 04.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 08.1, 317.7, 15.6, 00.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 10.8, 222.0, 15.9, 05.7, 1.3);  // Month - 2011-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 12.4, 108.9, 13.1, 11.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 11.7, 112.6, 14.1, 09.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 12.4, 189.5, 15.6, 09.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 08.9, 159.8, 12.2, 05.6, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 07.3, 368.4, 09.7, 04.8, 2.5);  // Month - 2011-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 05.4, 343.5, 09.4, 01.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 06.2, 252.2, 10.8, 01.5, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 07.2, 376.4, 14.1, 00.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 11.3, 216.0, 16.5, 06.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 09.5, 201.9, 14.6, 04.3, 1.4);  // Month - 2011-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 07.6, 331.3, 14.8, 00.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 10.3, 119.4, 13.2, 07.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 10.9, 295.8, 14.0, 07.7, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 11.0, 396.0, 17.2, 04.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 11.0, 328.9, 16.2, 05.7, 2.4);  // Month - 2011-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 07.5, 395.3, 11.5, 03.5, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 06.7, 424.1, 13.5, -00.1, 1.7);  // Month - 2011-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 10.0, 391.9, 17.3, 02.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 14.4, 158.2, 18.6, 10.2, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 11.1, 132.5, 15.1, 07.0, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 10.5, 442.5, 17.1, 03.9, 2.6);  // Month - 2011-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 12.1, 427.3, 19.6, 04.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 13.3, 448.7, 21.7, 04.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 14.3, 454.8, 23.0, 05.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 15.1, 430.0, 22.8, 07.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 13.8, 308.9, 18.7, 08.9, 3.2);  // Month - 2011-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 10.1, 463.9, 16.9, 03.3, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 15.0, 453.9, 22.1, 07.9, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 10.6, 479.1, 16.1, 05.0, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 10.2, 479.2, 18.6, 01.7, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 13.7, 475.8, 22.5, 04.8, 3.4);  // Month - 2011-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 19.7, 245.1, 26.4, 13.0, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 14.7, 143.8, 17.9, 11.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 11.8, 154.7, 13.8, 09.7, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 11.5, 455.2, 16.4, 06.5, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 12.1, 480.8, 19.6, 04.5, 2.9);  // Month - 2011-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 15.0, 500.3, 24.0, 05.9, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 11.9, 156.3, 13.2, 10.5, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 12.0, 463.1, 15.3, 08.7, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 12.5, 499.3, 19.7, 05.3, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 16.1, 502.0, 23.3, 08.8, 3.4);  // Month - 2011-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 19.0, 481.0, 25.0, 13.0, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 16.4, 503.8, 23.0, 09.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 17.9, 516.6, 25.6, 10.1, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 15.5, 188.6, 19.2, 11.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 15.8, 272.0, 20.6, 11.0, 2.8);  // Month - 2011-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 15.4, 497.4, 21.1, 09.7, 3.4);  // Month - 2011-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 16.1, 479.2, 21.2, 11.0, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 11.1, 165.9, 13.3, 08.8, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 12.9, 205.5, 18.9, 06.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 15.1, 466.3, 20.7, 09.4, 2.9);  // Month - 2011-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 17.5, 486.4, 26.4, 08.5, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 15.3, 167.1, 17.0, 13.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 17.6, 221.5, 20.9, 14.2, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 16.1, 237.1, 18.7, 13.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 14.3, 421.3, 17.5, 11.0, 2.6);  // Month - 2011-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 14.7, 505.5, 19.5, 09.9, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 17.0, 392.4, 22.8, 11.1, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 18.3, 192.0, 21.7, 14.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 14.2, 450.4, 18.1, 10.3, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 16.5, 587.3, 24.3, 08.7, 4.1);  // Month - 2011-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 17.1, 316.2, 22.7, 11.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 12.8, 581.7, 17.6, 08.0, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 13.4, 587.6, 21.1, 05.6, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 17.7, 423.8, 21.9, 13.5, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 18.1, 595.6, 24.2, 11.9, 4.7);  // Month - 2011-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 18.8, 608.6, 25.4, 12.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 17.9, 558.8, 22.1, 13.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 15.8, 188.0, 17.4, 14.2, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 16.7, 215.1, 18.5, 14.8, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 16.3, 264.9, 19.1, 13.4, 2.7);  // Month - 2011-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 13.9, 525.1, 17.1, 10.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 14.6, 557.1, 18.8, 10.3, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 15.9, 619.5, 24.4, 07.3, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 15.7, 428.6, 20.7, 10.6, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 12.2, 642.8, 17.3, 07.0, 3.9);  // Month - 2011-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 11.3, 648.5, 18.8, 03.7, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 14.8, 650.7, 22.9, 06.6, 5.1);  // Month - 2011-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 18.1, 614.6, 25.3, 10.8, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 19.8, 651.3, 26.7, 12.9, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 20.7, 353.5, 27.0, 14.3, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 20.1, 555.3, 25.2, 15.0, 4.5);  // Month - 2011-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 18.0, 572.7, 23.2, 12.7, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 17.0, 555.3, 26.0, 07.9, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 19.1, 389.9, 25.8, 12.3, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 21.4, 305.7, 26.3, 16.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 15.8, 696.6, 20.4, 11.2, 5.2);  // Month - 2011-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 16.1, 709.5, 23.8, 08.4, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 18.3, 706.8, 26.8, 09.8, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 19.3, 704.1, 26.4, 12.1, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 18.7, 693.5, 25.3, 12.1, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 16.9, 686.8, 24.8, 08.9, 4.8);  // Month - 2011-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 19.6, 711.9, 26.4, 12.8, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 20.0, 688.8, 26.0, 13.9, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 21.0, 701.0, 29.2, 12.8, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 23.7, 675.6, 31.5, 15.8, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 23.4, 444.2, 28.3, 18.5, 4.1);  // Month - 2011-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 19.4, 263.6, 22.4, 16.4, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 18.5, 695.2, 23.2, 13.8, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 19.1, 641.2, 26.9, 11.2, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 22.4, 733.8, 30.2, 14.5, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 23.8, 719.5, 31.1, 16.4, 6.2);  // Month - 2011-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 24.0, 709.1, 29.7, 18.3, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 24.2, 662.7, 32.8, 15.5, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 25.8, 636.2, 30.9, 20.7, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 25.1, 561.5, 30.3, 19.8, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 16.0, 538.5, 20.4, 11.6, 5.5);  // Month - 2011-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 15.7, 760.2, 19.4, 12.0, 5.2);  // Month - 2011-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 17.1, 756.7, 23.9, 10.2, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 18.4, 737.1, 25.4, 11.3, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 19.9, 757.7, 26.5, 13.3, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 22.6, 713.8, 28.9, 16.3, 5.9);  // Month - 2011-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 21.2, 693.7, 26.7, 15.6, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 18.8, 690.3, 25.2, 12.3, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 20.0, 730.9, 26.4, 13.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 20.7, 747.0, 26.2, 15.1, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 22.8, 760.0, 29.3, 16.3, 6.6);  // Month - 2011-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 23.3, 418.4, 29.8, 16.8, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 19.3, 676.1, 22.3, 16.2, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 19.4, 620.2, 22.9, 15.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 19.1, 648.8, 24.2, 14.0, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 19.4, 475.9, 21.9, 16.8, 4.2);  // Month - 2011-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 19.5, 460.3, 21.9, 17.0, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 18.6, 251.1, 20.5, 16.6, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 18.2, 449.3, 21.6, 14.8, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 21.8, 647.9, 28.7, 14.9, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 24.5, 745.7, 33.3, 15.6, 6.6);  // Month - 2011-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 27.1, 629.1, 37.1, 17.0, 7.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 24.3, 580.9, 29.1, 19.5, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 16.3, 269.1, 20.9, 11.6, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 15.0, 743.2, 20.8, 09.2, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 16.9, 774.9, 24.8, 09.0, 5.8);  // Month - 2011-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 19.7, 769.8, 27.1, 12.2, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 21.5, 769.4, 27.4, 15.6, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 21.5, 761.0, 28.5, 14.4, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 22.3, 712.2, 29.5, 15.0, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 21.5, 602.8, 28.2, 14.8, 5.8);  // Month - 2011-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 22.9, 755.0, 28.4, 17.3, 6.8);  
 

            #endregion
                            
        }

        public static void WeatherDataLasBrujas_2012(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2012, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2012
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 22.4, 758.7, 28.7, 16.1, 6.5);  // Month - 2012-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 23.0, 717.3, 31.4, 14.5, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 19.6, 741.9, 24.1, 15.0, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 20.0, 725.8, 28.1, 11.8, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 23.7, 753.7, 33.2, 14.2, 6.9);  // Month - 2012-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 25.2, 737.3, 32.9, 17.5, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 22.2, 712.8, 27.6, 16.7, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 23.5, 741.0, 33.1, 13.9, 7.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 29.7, 733.0, 37.9, 21.5, 9.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 31.2, 716.9, 39.0, 23.3, 8.8);  // Month - 2012-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 26.0, 434.3, 30.2, 21.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 19.5, 700.5, 24.1, 14.8, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 18.0, 736.8, 24.2, 11.8, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 19.5, 755.2, 25.8, 13.1, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 20.8, 745.4, 29.6, 12.0, 6.1);  // Month - 2012-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 22.6, 756.4, 31.6, 13.5, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 23.1, 735.7, 31.4, 14.8, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 24.7, 734.7, 32.9, 16.4, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 26.4, 677.2, 34.4, 18.4, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 27.8, 691.9, 35.8, 19.8, 7.6);  // Month - 2012-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 27.7, 650.9, 35.1, 20.2, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 23.9, 469.9, 28.4, 19.4, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 23.8, 708.2, 28.9, 18.7, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 22.2, 480.1, 26.6, 17.7, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 19.2, 729.7, 23.3, 15.0, 5.6);  // Month - 2012-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 20.0, 684.9, 25.5, 14.5, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 20.9, 727.2, 28.5, 13.3, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 22.7, 722.2, 29.5, 15.8, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 26.0, 721.2, 34.2, 17.8, 7.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 26.5, 589.5, 33.0, 19.9, 6.5);  // Month - 2012-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 26.2, 379.0, 30.5, 21.9, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 27.8, 493.2, 33.9, 21.7, 5.0);  // Month - 2012-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 25.0, 559.6, 30.3, 19.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 25.4, 566.5, 29.8, 20.9, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 26.9, 573.2, 34.1, 19.6, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 24.2, 303.7, 27.7, 20.7, 3.0);  // Month - 2012-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 26.3, 451.5, 32.7, 19.8, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 28.9, 602.5, 34.8, 22.9, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 26.5, 354.5, 30.2, 22.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 21.5, 598.3, 25.8, 17.2, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 20.2, 654.4, 25.2, 15.1, 5.2);  // Month - 2012-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 19.5, 648.3, 26.5, 12.5, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 22.5, 654.0, 31.5, 13.4, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 24.7, 647.9, 33.0, 16.4, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 26.2, 630.2, 33.5, 18.8, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 27.5, 628.0, 35.1, 19.9, 6.5);  // Month - 2012-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 29.2, 457.8, 37.3, 21.1, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 22.7, 197.2, 24.1, 21.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 29.0, 576.2, 36.1, 21.9, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 25.9, 422.9, 30.0, 21.8, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 22.0, 190.4, 23.5, 20.5, 2.1);  // Month - 2012-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 20.9, 450.1, 25.1, 16.6, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 21.1, 565.0, 27.5, 14.6, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 19.2, 585.4, 22.7, 15.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 19.6, 467.1, 25.2, 13.9, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 22.7, 607.4, 29.5, 15.8, 5.3);  // Month - 2012-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 19.7, 601.4, 23.9, 15.4, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 21.0, 598.7, 29.0, 13.0, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 20.3, 222.8, 23.4, 17.1, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 21.1, 295.1, 24.9, 17.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 20.6, 421.7, 25.5, 15.7, 3.2);  // Month - 2012-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 20.1, 565.5, 26.0, 14.1, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 22.6, 584.7, 29.6, 15.5, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 25.1, 575.0, 32.3, 17.9, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 26.6, 503.7, 33.7, 19.5, 4.8);  // Month - 2012-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 22.5, 213.9, 24.9, 20.1, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 25.5, 449.1, 30.3, 20.6, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 23.3, 546.8, 27.6, 18.9, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 23.1, 558.6, 28.2, 18.0, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 26.4, 449.9, 32.0, 20.8, 4.1);  // Month - 2012-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 25.0, 504.0, 29.2, 20.7, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 22.5, 171.1, 25.5, 19.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 20.7, 296.0, 24.8, 16.5, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 18.9, 524.5, 22.1, 15.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 18.2, 535.6, 22.9, 13.4, 3.5);  // Month - 2012-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 18.9, 526.2, 26.0, 11.7, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 20.6, 516.9, 27.7, 13.4, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 23.6, 521.3, 30.5, 16.6, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 25.3, 412.6, 32.1, 18.5, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 22.0, 216.5, 25.7, 18.3, 2.1);  // Month - 2012-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 21.2, 472.9, 26.2, 16.1, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 18.3, 466.5, 22.1, 14.5, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 16.3, 490.7, 21.7, 10.8, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 16.9, 501.3, 24.7, 09.0, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 17.3, 388.4, 24.3, 10.3, 2.6);  // Month - 2012-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 16.5, 379.5, 21.5, 11.5, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 14.3, 400.1, 16.4, 12.2, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 15.6, 479.2, 21.6, 09.6, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 16.6, 482.8, 23.1, 10.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 17.2, 469.3, 25.6, 08.8, 3.1);  // Month - 2012-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 19.6, 475.2, 27.0, 12.1, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 21.0, 474.6, 28.4, 13.5, 3.3);  // Month - 2012-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 21.2, 401.3, 27.6, 14.7, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 21.4, 344.7, 28.8, 14.0, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 20.1, 288.7, 23.2, 16.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 15.3, 393.2, 20.2, 10.4, 2.8);  // Month - 2012-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 15.3, 440.3, 22.4, 08.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 19.0, 437.4, 27.6, 10.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 16.8, 443.4, 22.0, 11.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 17.5, 427.9, 24.8, 10.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 18.8, 166.1, 23.9, 13.7, 1.8);  // Month - 2012-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 20.3, 300.2, 24.6, 16.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 20.1, 402.5, 24.5, 15.7, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 18.7, 340.2, 25.0, 12.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 19.6, 198.9, 23.9, 15.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 17.7, 406.3, 23.2, 12.2, 2.2);  // Month - 2012-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 17.9, 403.5, 25.0, 10.7, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 19.6, 287.6, 24.9, 14.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 19.0, 384.0, 27.5, 10.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 21.4, 372.6, 28.4, 14.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 19.7, 367.1, 27.7, 11.7, 2.5);  // Month - 2012-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 14.1, 387.2, 18.4, 09.7, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 11.9, 390.0, 16.5, 07.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 10.9, 359.1, 16.0, 05.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 10.0, 379.9, 15.0, 04.9, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 09.7, 266.0, 16.6, 02.8, 1.4);  // Month - 2012-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 12.6, 230.8, 14.4, 10.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 13.0, 341.3, 17.1, 08.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 10.6, 110.0, 13.6, 07.5, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 09.8, 233.4, 13.7, 05.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 10.7, 344.2, 15.5, 05.9, 1.3);  // Month - 2012-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 11.6, 349.2, 18.5, 04.7, 1.6);  // Month - 2012-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 15.2, 349.0, 23.2, 07.2, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 17.6, 348.6, 25.3, 09.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 17.3, 283.0, 25.3, 09.3, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 16.9, 327.0, 23.7, 10.1, 1.7);  // Month - 2012-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 17.9, 316.4, 22.7, 13.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 19.8, 220.4, 24.5, 15.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 20.0, 295.2, 26.7, 13.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 18.9, 177.5, 23.0, 14.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 15.0, 106.0, 16.8, 13.2, 0.9);  // Month - 2012-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 15.3, 222.8, 20.2, 10.4, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 11.4, 271.1, 14.2, 08.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 11.4, 314.1, 17.6, 05.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 13.3, 304.7, 21.7, 04.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 14.7, 307.9, 21.9, 07.5, 1.5);  // Month - 2012-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 16.5, 305.9, 22.7, 10.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 17.6, 308.7, 22.8, 12.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 17.3, 253.9, 22.2, 12.4, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 17.4, 211.5, 21.4, 13.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 18.1, 212.5, 23.8, 12.4, 1.2);  // Month - 2012-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 18.4, 92.7, 20.8, 15.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 18.0, 101.4, 20.0, 15.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 17.0, 100.6, 18.5, 15.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 16.3, 136.9, 18.9, 13.7, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 16.8, 103.6, 19.9, 13.6, 1.0);  // Month - 2012-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 16.5, 137.1, 19.6, 13.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 17.2, 111.0, 20.9, 13.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 19.4, 157.5, 22.9, 15.9, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 19.0, 257.2, 22.4, 15.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 12.6, 252.1, 16.0, 09.2, 1.1);  // Month - 2012-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 10.8, 222.6, 16.1, 05.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 09.3, 217.7, 15.9, 02.7, 1.2);  // Month - 2012-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 16.4, 219.5, 20.8, 12.0, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 09.1, 245.8, 12.5, 05.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 08.3, 160.7, 11.7, 04.9, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 08.1, 260.1, 13.5, 02.7, 0.7);  // Month - 2012-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 05.8, 100.0, 07.3, 04.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 05.9, 234.5, 09.9, 01.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 06.1, 271.3, 11.8, 00.3, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 06.1, 268.4, 14.3, -02.1, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 09.0, 182.2, 17.0, 00.9, 1.1);  // Month - 2012-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 09.5, 238.6, 17.6, 01.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 13.7, 233.6, 21.3, 06.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 18.1, 89.2, 22.9, 13.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 14.8, 80.2, 18.9, 10.7, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 11.8, 79.9, 14.1, 09.4, 0.9);  // Month - 2012-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 07.1, 226.7, 10.5, 03.7, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 06.9, 79.4, 11.0, 02.7, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 11.2, 115.6, 13.1, 09.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 10.0, 192.3, 13.3, 06.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 11.1, 166.1, 14.6, 07.5, 0.7);  // Month - 2012-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 11.9, 171.9, 17.3, 06.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 12.0, 258.1, 17.5, 06.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 11.5, 222.9, 17.2, 05.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 12.8, 257.7, 18.5, 07.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 08.4, 254.3, 14.5, 02.3, 0.6);  // Month - 2012-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 09.8, 261.4, 18.5, 01.1, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 16.0, 257.8, 23.3, 08.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 17.4, 122.8, 23.0, 11.8, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 13.0, 84.3, 15.2, 10.7, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 14.2, 86.7, 17.9, 10.5, 1.0);  // Month - 2012-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 19.8, 128.3, 24.4, 15.1, 1.2);  // Month - 2012-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 11.9, 80.7, 15.2, 08.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 07.5, 81.0, 10.9, 04.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 06.6, 81.2, 10.1, 03.0, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 05.5, 265.9, 11.0, -00.1, 0.6);  // Month - 2012-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 05.1, 258.0, 11.0, -00.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 05.5, 256.4, 12.0, -01.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 07.6, 263.5, 13.6, 01.5, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 06.7, 275.1, 13.6, -00.2, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 07.6, 153.8, 11.9, 03.2, 0.8);  // Month - 2012-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 04.4, 185.2, 10.0, -01.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 06.8, 256.7, 10.3, 03.3, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 09.2, 239.4, 14.5, 03.9, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 06.9, 279.9, 09.1, 04.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 06.1, 213.5, 09.5, 02.6, 0.9);  // Month - 2012-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 05.9, 269.0, 12.6, -00.8, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 05.3, 270.8, 12.6, -02.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 07.8, 268.2, 15.2, 00.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 11.5, 290.8, 19.4, 03.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 11.8, 232.7, 16.5, 07.0, 1.1);  // Month - 2012-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 11.7, 169.4, 15.6, 07.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 06.9, 270.7, 13.2, 00.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 09.5, 230.3, 16.4, 02.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 06.7, 241.2, 11.3, 02.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 05.9, 290.1, 12.5, -00.8, 1.0);  // Month - 2012-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 07.2, 258.3, 12.9, 01.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 04.4, 303.0, 11.1, -02.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 09.2, 292.6, 18.6, -00.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 05.7, 291.8, 10.4, 00.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 04.8, 307.9, 12.9, -03.3, 1.1);  // Month - 2012-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 09.4, 107.2, 15.7, 03.0, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 13.8, 144.6, 17.5, 10.1, 0.8);  // Month - 2012-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 11.2, 128.3, 15.9, 06.5, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 13.0, 97.1, 15.5, 10.4, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 09.0, 97.8, 10.8, 07.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 09.4, 148.3, 13.5, 05.3, 0.7);  // Month - 2012-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 10.5, 249.4, 19.1, 01.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 16.7, 253.2, 22.3, 11.1, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 14.0, 209.1, 17.5, 10.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 13.3, 152.4, 16.1, 10.4, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 15.8, 294.9, 22.1, 09.4, 1.5);  // Month - 2012-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 15.9, 103.6, 19.6, 12.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 12.6, 135.9, 18.7, 06.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 10.3, 357.1, 18.3, 02.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 13.2, 106.8, 19.0, 07.4, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 16.6, 150.3, 20.1, 13.1, 1.2);  // Month - 2012-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 17.1, 197.1, 21.7, 12.4, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 17.4, 110.0, 19.8, 15.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 18.0, 151.6, 20.6, 15.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 16.2, 376.5, 20.3, 12.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 13.3, 113.1, 15.4, 11.2, 1.1);  // Month - 2012-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 12.1, 116.9, 14.7, 09.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 16.9, 365.3, 26.1, 07.7, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 24.6, 370.9, 29.2, 19.9, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 15.2, 117.3, 21.4, 09.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 08.2, 390.9, 11.1, 05.2, 1.9);  // Month - 2012-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 08.0, 213.8, 11.3, 04.6, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 09.4, 382.0, 13.1, 05.6, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 09.8, 410.4, 15.8, 03.7, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 11.9, 302.8, 18.0, 05.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 14.5, 310.6, 20.0, 08.9, 1.7);  // Month - 2012-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 14.5, 388.9, 22.5, 06.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 16.7, 391.9, 24.3, 09.1, 2.1);  // Month - 2012-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 15.9, 424.4, 23.8, 08.0, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 11.8, 343.6, 18.6, 04.9, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 15.8, 171.6, 19.7, 11.8, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 12.7, 130.7, 15.4, 10.0, 1.6);  // Month - 2012-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 14.0, 183.7, 18.4, 09.5, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 17.7, 148.4, 20.8, 14.5, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 12.9, 202.0, 17.0, 08.7, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 11.3, 423.5, 15.8, 06.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 12.4, 463.9, 19.3, 05.5, 2.2);  // Month - 2012-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 14.0, 441.7, 21.3, 06.6, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 14.8, 428.8, 21.4, 08.2, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 17.6, 463.4, 25.3, 09.9, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 17.0, 482.1, 24.2, 09.7, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 20.3, 315.6, 26.6, 14.0, 2.7);  // Month - 2012-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 17.3, 269.3, 20.4, 14.1, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 15.0, 222.6, 17.3, 12.6, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 13.6, 149.4, 14.9, 12.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 11.1, 147.4, 13.2, 09.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 12.2, 391.8, 18.0, 06.3, 2.9);  // Month - 2012-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 12.2, 493.2, 16.9, 07.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 12.1, 519.5, 17.6, 06.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 13.1, 432.6, 20.8, 05.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 12.3, 304.1, 16.8, 07.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 09.2, 447.3, 11.4, 07.0, 3.4);  // Month - 2012-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 09.0, 527.5, 13.2, 04.7, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 10.9, 523.4, 19.3, 02.4, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 17.0, 202.2, 22.8, 11.1, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 15.0, 457.0, 18.1, 11.9, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 17.5, 487.1, 24.7, 10.3, 3.2);  // Month - 2012-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 17.6, 385.9, 22.4, 12.8, 2.6);  // Month - 2012-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 14.6, 162.5, 16.7, 12.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 14.1, 163.6, 16.1, 12.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 14.5, 406.7, 20.5, 08.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 18.4, 313.8, 24.1, 12.7, 2.9);  // Month - 2012-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 17.8, 167.1, 19.9, 15.6, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 15.4, 168.2, 16.9, 13.9, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 18.5, 169.4, 21.5, 15.5, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 15.1, 184.8, 17.7, 12.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 12.5, 408.6, 15.1, 09.9, 3.0);  // Month - 2012-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 13.7, 540.0, 18.9, 08.5, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 14.7, 588.8, 21.7, 07.6, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 16.8, 602.5, 23.5, 10.1, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 19.0, 561.8, 26.2, 11.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 20.4, 466.0, 27.2, 13.5, 4.3);  // Month - 2012-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 17.1, 251.9, 19.5, 14.6, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 16.7, 348.6, 19.1, 14.2, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 15.6, 538.1, 19.9, 11.2, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 14.7, 248.0, 19.7, 09.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 17.0, 364.0, 23.9, 10.1, 2.6);  // Month - 2012-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 18.8, 510.5, 25.9, 11.6, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 16.6, 247.6, 18.9, 14.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 15.3, 267.4, 17.4, 13.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 16.5, 643.3, 22.2, 10.7, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 17.5, 645.2, 24.1, 10.8, 4.8);  // Month - 2012-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 19.4, 647.5, 26.9, 11.8, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 21.6, 532.7, 27.9, 15.3, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 22.0, 606.5, 28.1, 15.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 20.0, 194.8, 21.6, 18.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 16.7, 408.8, 19.8, 13.5, 3.3);  // Month - 2012-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 16.5, 643.1, 22.4, 10.5, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 19.3, 637.6, 25.6, 12.9, 4.5);  // Month - 2012-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 20.3, 674.3, 26.6, 14.0, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 21.7, 657.6, 29.1, 14.3, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 20.7, 601.6, 26.8, 14.5, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 21.8, 688.7, 30.1, 13.5, 5.7);  // Month - 2012-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 24.5, 694.8, 31.6, 17.3, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 26.9, 692.8, 34.5, 19.3, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 25.6, 699.3, 33.4, 17.8, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 22.5, 244.1, 29.7, 15.3, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 16.2, 201.8, 17.6, 14.7, 2.9);  // Month - 2012-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 16.9, 468.3, 19.3, 14.5, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 15.5, 524.0, 20.0, 10.9, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 16.1, 709.2, 21.4, 10.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 18.0, 635.8, 23.7, 12.2, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 17.8, 704.0, 24.5, 11.1, 5.1);  // Month - 2012-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 20.5, 547.4, 26.6, 14.4, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 21.3, 626.4, 27.3, 15.3, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 22.4, 577.2, 29.1, 15.6, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 21.6, 680.7, 26.4, 16.7, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 22.1, 690.1, 28.5, 15.6, 5.6);  // Month - 2012-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 23.3, 707.0, 30.3, 16.2, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 20.7, 245.3, 23.8, 17.5, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 18.1, 388.8, 22.6, 13.6, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 18.5, 699.6, 25.5, 11.4, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 15.3, 713.0, 22.7, 07.9, 5.4);  // Month - 2012-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 16.5, 407.6, 22.4, 10.6, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 20.8, 744.0, 30.5, 11.0, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 19.7, 477.5, 25.5, 13.9, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 18.5, 702.6, 24.2, 12.8, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 20.5, 331.2, 24.8, 16.1, 3.2);  // Month - 2012-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 21.2, 736.6, 27.7, 14.6, 6.6);  // Month - 2012-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 23.5, 753.2, 32.3, 14.7, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 26.2, 452.5, 31.9, 20.5, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 25.2, 300.2, 29.3, 21.1, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 25.5, 725.8, 31.1, 19.8, 6.7);  // Month - 2012-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 23.4, 216.4, 26.1, 20.7, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 21.6, 710.4, 24.5, 18.7, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 21.0, 771.1, 28.4, 13.6, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 22.7, 767.6, 30.6, 14.7, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 24.5, 498.8, 32.3, 16.6, 5.1);  // Month - 2012-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 21.6, 720.3, 26.9, 16.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 23.5, 761.0, 31.7, 15.3, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 22.0, 745.4, 27.3, 16.7, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 22.0, 612.7, 29.9, 14.0, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 24.5, 686.0, 30.2, 18.8, 6.3);  // Month - 2012-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 21.9, 218.9, 26.0, 17.8, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 21.1, 659.2, 24.9, 17.3, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 19.8, 288.1, 23.7, 15.8, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 21.5, 393.6, 27.4, 15.5, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 19.8, 349.5, 24.4, 15.1, 3.3);  // Month - 2012-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 20.4, 730.8, 27.4, 13.3, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 21.7, 776.3, 29.5, 13.8, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 23.6, 775.6, 32.1, 15.0, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 29.5, 697.9, 36.0, 23.0, 8.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 24.3, 381.5, 29.2, 19.4, 4.3);  // Month - 2012-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 18.3, 664.3, 21.8, 14.8, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 18.4, 708.5, 22.9, 13.9, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 19.1, 764.7, 26.4, 11.7, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 22.4, 623.0, 29.0, 15.7, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 26.0, 767.8, 33.1, 18.9, 7.5);  // Month - 2012-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(365), 26.7, 553.3, 33.6, 19.7, 6.5);  



            #endregion
                            
        }
        
        public static void WeatherDataLasBrujas_2013(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2013, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2013
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 17.8, 706.2, 20.9, 14.6, 6.4);  // Month - 2013-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 15.7, 765.6, 20.1, 11.3, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 17.7, 754.0, 25.7, 09.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 23.7, 653.2, 30.9, 16.4, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 25.5, 636.8, 31.8, 19.2, 5.9);  // Month - 2013-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 24.2, 692.9, 28.9, 19.5, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 25.0, 648.3, 31.1, 18.9, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 23.6, 567.7, 28.8, 18.4, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 22.7, 761.2, 29.2, 16.1, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 23.3, 761.3, 32.5, 14.1, 6.8);  // Month - 2013-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 23.8, 773.4, 31.6, 15.9, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 22.8, 676.2, 29.8, 15.7, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 23.9, 757.0, 30.4, 17.4, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 22.9, 690.8, 29.8, 16.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 23.8, 745.4, 30.8, 16.7, 6.8);  // Month - 2013-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 24.2, 635.9, 30.9, 17.4, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 24.5, 510.7, 28.8, 20.2, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 23.2, 666.5, 28.8, 17.5, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 21.1, 456.7, 24.7, 17.4, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 20.7, 735.9, 26.1, 15.3, 6.2);  // Month - 2013-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 21.2, 670.9, 27.0, 15.3, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 23.6, 717.5, 30.7, 16.5, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 25.1, 628.4, 31.6, 18.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 25.3, 663.3, 34.0, 16.5, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 18.0, 729.7, 20.7, 15.3, 6.3);  // Month - 2013-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 18.4, 724.6, 25.8, 11.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 21.8, 695.5, 30.4, 13.2, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 25.7, 714.3, 33.9, 17.5, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 26.7, 618.2, 34.2, 19.2, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 25.7, 716.2, 32.5, 18.8, 6.4);  // Month - 2013-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 25.9, 660.1, 32.7, 19.1, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 27.5, 687.1, 34.7, 20.2, 7.2);  // Month - 2013-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 23.5, 524.0, 27.8, 19.1, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 16.9, 708.8, 22.3, 11.5, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 18.0, 687.7, 26.8, 09.1, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 21.3, 712.9, 29.5, 13.0, 6.0);  // Month - 2013-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 22.3, 702.7, 29.6, 14.9, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 22.4, 684.7, 30.8, 14.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 23.6, 678.4, 31.2, 16.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 25.0, 683.9, 32.2, 17.8, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 26.5, 351.7, 32.0, 20.9, 3.7);  // Month - 2013-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 24.7, 489.6, 29.2, 20.2, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 25.8, 619.3, 32.3, 19.3, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 24.7, 316.7, 29.3, 20.0, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 24.6, 518.9, 30.2, 19.0, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 24.7, 643.3, 32.1, 17.2, 5.9);  // Month - 2013-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 26.9, 633.4, 33.7, 20.1, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 25.6, 341.8, 30.5, 20.7, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 19.7, 409.0, 23.3, 16.0, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 17.7, 225.5, 23.4, 12.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 20.2, 205.5, 24.3, 16.1, 3.1);  // Month - 2013-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 20.1, 374.5, 23.7, 16.5, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 20.6, 629.1, 27.4, 13.8, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 22.2, 626.7, 29.1, 15.3, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 22.7, 317.4, 25.6, 19.8, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 19.1, 566.3, 21.1, 17.1, 5.7);  // Month - 2013-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 16.6, 590.2, 20.8, 12.3, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 16.6, 606.1, 22.5, 10.7, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 16.9, 610.7, 23.6, 10.2, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 20.9, 563.8, 28.3, 13.4, 5.6);  // Month - 2013-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 21.3, 319.1, 25.0, 17.5, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 18.7, 459.7, 21.1, 16.3, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 16.6, 588.3, 20.5, 12.7, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 16.9, 571.4, 22.8, 10.9, 4.0);  // Month - 2013-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 19.3, 586.7, 27.4, 11.2, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 21.8, 555.5, 28.8, 14.7, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 23.9, 528.0, 30.4, 17.4, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 24.5, 439.7, 30.3, 18.6, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 18.3, 523.1, 23.1, 13.4, 4.5);  // Month - 2013-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 18.4, 478.2, 24.9, 11.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 15.9, 436.9, 21.0, 10.8, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 14.5, 417.3, 20.9, 08.1, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 13.9, 411.6, 18.4, 09.4, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 14.4, 322.2, 19.8, 08.9, 2.5);  // Month - 2013-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 13.7, 518.3, 19.0, 08.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 15.0, 533.2, 19.4, 10.5, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 16.9, 348.1, 22.6, 11.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 19.6, 342.8, 24.7, 14.5, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 18.8, 156.3, 20.5, 17.1, 2.0);  // Month - 2013-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 19.7, 352.7, 22.1, 17.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 15.3, 517.0, 21.4, 09.2, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 16.2, 314.8, 22.2, 10.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 18.9, 477.3, 26.1, 11.7, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 19.0, 340.9, 24.4, 13.6, 2.7);  // Month - 2013-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 17.0, 481.5, 23.1, 10.9, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 15.4, 435.7, 23.3, 07.4, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 17.1, 482.4, 26.0, 08.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 19.2, 485.8, 28.0, 10.3, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 21.0, 479.6, 28.2, 13.7, 3.4);  // Month - 2013-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 23.3, 378.9, 29.6, 17.0, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 22.8, 299.0, 26.6, 18.9, 3.5);  // Month - 2013-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 20.9, 179.2, 23.7, 18.0, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 20.9, 251.3, 25.2, 16.5, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 19.3, 205.0, 22.9, 15.7, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 19.1, 402.4, 23.1, 15.0, 3.1);  // Month - 2013-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 17.0, 349.3, 20.7, 13.3, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 13.4, 455.9, 19.4, 07.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 14.3, 465.3, 21.7, 06.8, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 15.5, 428.0, 23.1, 07.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 17.0, 351.4, 23.6, 10.3, 3.1);  // Month - 2013-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 18.5, 129.8, 20.6, 16.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 15.7, 381.5, 18.7, 12.7, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 12.4, 429.4, 16.2, 08.5, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 14.8, 429.3, 22.1, 07.5, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 15.7, 423.5, 19.3, 12.1, 2.5);  // Month - 2013-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 14.2, 235.7, 18.5, 09.9, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 13.4, 406.4, 21.6, 05.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 17.4, 412.6, 25.9, 08.9, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 18.2, 415.8, 26.4, 10.0, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 19.3, 398.5, 28.3, 10.3, 2.4);  // Month - 2013-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 18.7, 398.5, 26.8, 10.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 18.2, 293.5, 24.3, 12.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 20.8, 353.3, 27.8, 13.7, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 18.5, 291.9, 24.4, 12.5, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 19.2, 357.6, 26.7, 11.7, 2.0);  // Month - 2013-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 19.5, 374.3, 27.1, 11.9, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 19.9, 294.2, 25.9, 13.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 17.7, 130.3, 21.1, 14.3, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 15.8, 213.4, 19.2, 12.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 15.9, 363.2, 20.7, 11.1, 1.7);  // Month - 2013-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 15.7, 201.9, 20.4, 10.9, 1.5);  // Month - 2013-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 18.6, 138.8, 21.5, 15.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 15.8, 111.0, 17.7, 13.9, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 13.8, 335.4, 17.6, 09.9, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 12.8, 337.6, 17.5, 08.0, 1.7);  // Month - 2013-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 15.3, 288.3, 23.6, 06.9, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 11.6, 311.3, 15.7, 07.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 14.4, 327.4, 22.3, 06.5, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 17.2, 328.2, 23.8, 10.6, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 16.6, 275.9, 24.3, 08.9, 2.0);  // Month - 2013-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 17.3, 229.2, 21.9, 12.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 16.0, 245.3, 21.5, 10.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 12.7, 97.0, 16.0, 09.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 15.4, 202.7, 18.7, 12.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 10.7, 235.8, 14.0, 07.4, 2.9);  // Month - 2013-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 08.0, 303.0, 12.5, 03.5, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 08.9, 313.2, 16.1, 01.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 08.8, 163.5, 14.8, 02.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 11.5, 95.0, 16.2, 06.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 12.3, 91.8, 13.1, 11.4, 1.0);  // Month - 2013-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 12.8, 91.1, 14.5, 11.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 15.4, 114.0, 17.9, 12.8, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 14.1, 155.4, 19.0, 09.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 12.8, 245.4, 17.3, 08.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 10.9, 278.4, 17.3, 04.4, 0.8);  // Month - 2013-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 13.4, 258.0, 20.1, 06.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 13.5, 269.9, 20.8, 06.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 14.7, 113.3, 19.2, 10.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 12.1, 107.8, 14.6, 09.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 12.6, 268.4, 17.8, 07.3, 1.8);  // Month - 2013-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 14.3, 111.1, 19.8, 08.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 14.9, 274.0, 21.9, 07.8, 1.4);  // Month - 2013-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 11.7, 206.5, 15.8, 07.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 12.7, 244.0, 19.2, 06.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 13.9, 228.0, 18.4, 09.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 13.6, 89.5, 19.8, 07.4, 2.4);  // Month - 2013-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 08.8, 213.5, 13.4, 04.1, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 10.9, 270.5, 18.2, 03.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 09.2, 261.0, 15.4, 02.9, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 09.0, 88.4, 13.0, 04.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 12.5, 206.9, 18.9, 06.0, 0.6);  // Month - 2013-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 14.5, 234.8, 22.6, 06.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 17.4, 262.7, 24.0, 10.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 18.8, 246.7, 23.5, 14.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 09.5, 215.6, 16.5, 02.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 08.0, 262.6, 15.4, 00.6, 0.8);  // Month - 2013-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 10.4, 110.3, 13.5, 07.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 10.2, 231.0, 14.8, 05.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 09.5, 176.4, 15.8, 03.1, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 05.3, 259.5, 10.6, 00.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 05.3, 245.8, 13.0, -02.5, 0.4);  // Month - 2013-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 07.2, 146.9, 15.1, -00.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 08.5, 216.5, 12.2, 04.7, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 07.2, 143.8, 13.2, 01.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 07.4, 195.2, 13.4, 01.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 09.3, 129.8, 14.3, 04.3, 0.7);  // Month - 2013-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 09.3, 153.8, 13.8, 04.8, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 12.0, 248.6, 18.9, 05.1, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 12.2, 88.0, 16.8, 07.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 11.0, 250.0, 16.0, 06.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 08.5, 194.5, 14.3, 02.7, 0.7);  // Month - 2013-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 08.8, 264.4, 15.5, 02.0, 0.8);  // Month - 2013-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 12.7, 252.2, 19.6, 05.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 15.3, 266.6, 22.2, 08.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 13.0, 81.0, 15.3, 10.6, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 14.5, 81.2, 16.3, 12.7, 0.7);  // Month - 2013-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 13.4, 129.8, 16.8, 09.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 07.6, 82.0, 10.5, 04.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 07.2, 274.1, 12.4, 01.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 09.2, 182.1, 15.7, 02.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 13.4, 87.3, 15.4, 11.4, 0.8);  // Month - 2013-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 16.4, 87.3, 20.6, 12.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 10.4, 83.1, 12.4, 08.3, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 10.7, 85.6, 13.9, 07.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 08.3, 190.4, 12.6, 03.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 07.9, 282.7, 14.3, 01.4, 0.9);  // Month - 2013-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 13.4, 284.7, 20.5, 06.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 15.4, 284.4, 21.9, 08.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 11.5, 172.7, 16.3, 06.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 05.3, 277.0, 09.3, 01.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 04.7, 152.1, 09.5, -00.1, 0.9);  // Month - 2013-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 04.5, 141.5, 06.9, 02.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 05.7, 88.9, 07.4, 03.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 05.7, 242.0, 09.1, 02.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 06.1, 278.9, 10.7, 01.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 07.5, 304.3, 14.7, 00.3, 1.2);  // Month - 2013-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 08.8, 209.5, 15.7, 01.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 13.0, 300.6, 19.7, 06.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 10.1, 299.8, 17.0, 03.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 11.7, 299.8, 21.2, 02.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 13.0, 151.6, 18.9, 07.1, 1.5);  // Month - 2013-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 17.0, 207.0, 23.2, 10.7, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 10.7, 95.7, 12.0, 09.3, 0.9);  // Month - 2013-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 09.0, 96.4, 10.5, 07.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 08.2, 146.5, 11.2, 05.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 10.2, 313.7, 15.9, 04.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 12.4, 316.2, 19.0, 05.8, 1.7);  // Month - 2013-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 10.8, 308.0, 18.5, 03.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 13.1, 159.2, 17.9, 08.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 08.9, 200.4, 13.2, 04.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 06.8, 330.3, 12.0, 01.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 06.6, 317.8, 13.7, -00.5, 1.3);  // Month - 2013-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 09.1, 269.2, 15.8, 02.3, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 11.3, 305.1, 16.8, 05.7, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 06.5, 193.1, 09.3, 03.7, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 05.8, 354.5, 12.1, -00.5, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 06.9, 367.8, 14.4, -00.7, 2.0);  // Month - 2013-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 08.6, 360.1, 14.2, 02.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 06.5, 349.6, 15.0, -02.1, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 11.7, 370.9, 20.9, 02.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 16.7, 365.6, 23.6, 09.7, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 17.9, 368.4, 25.3, 10.4, 2.5);  // Month - 2013-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 16.3, 258.5, 20.5, 12.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 09.7, 348.8, 13.6, 05.7, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 05.2, 379.1, 08.1, 02.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 05.8, 309.0, 11.2, 00.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 05.9, 365.4, 10.1, 01.7, 1.6);  // Month - 2013-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 06.4, 356.7, 10.3, 02.5, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 06.7, 387.8, 13.9, -00.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 14.4, 410.4, 21.8, 06.9, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 15.5, 416.2, 24.1, 06.9, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 17.0, 430.6, 25.2, 08.8, 3.2);  // Month - 2013-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 17.1, 421.6, 26.0, 08.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 16.7, 374.2, 25.4, 08.0, 2.6);  // Month - 2013-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 13.0, 380.1, 18.7, 07.3, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 08.3, 409.5, 12.0, 04.6, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 07.8, 421.3, 14.8, 00.8, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 12.0, 174.6, 17.5, 06.4, 1.8);  // Month - 2013-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 17.5, 354.7, 24.7, 10.3, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 16.6, 131.9, 18.1, 15.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 15.3, 405.7, 20.3, 10.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 18.3, 411.1, 26.8, 09.8, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 26.9, 432.8, 31.8, 21.9, 5.0);  // Month - 2013-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 27.0, 451.1, 32.9, 21.0, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 21.6, 382.2, 29.2, 13.9, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 11.4, 139.0, 14.1, 08.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 10.3, 140.2, 11.6, 09.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 10.9, 142.6, 12.2, 09.6, 1.5);  // Month - 2013-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 09.8, 142.6, 11.8, 07.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 07.7, 193.5, 09.2, 06.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 09.4, 497.5, 15.8, 03.0, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 12.1, 506.9, 20.2, 03.9, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 12.2, 352.4, 19.2, 05.2, 2.2);  // Month - 2013-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 11.4, 404.9, 18.3, 04.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 10.4, 177.5, 12.3, 08.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 08.8, 499.3, 12.7, 04.8, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 09.3, 455.0, 13.3, 05.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 09.4, 491.1, 17.4, 01.3, 2.6);  // Month - 2013-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 11.1, 491.1, 19.5, 02.6, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 14.3, 472.4, 20.3, 08.3, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 16.5, 202.2, 20.6, 12.4, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 12.2, 159.0, 14.8, 09.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 10.3, 428.6, 14.7, 05.9, 2.7);  // Month - 2013-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 10.7, 517.2, 16.3, 05.1, 2.7);  // Month - 2013-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 14.0, 368.6, 18.1, 09.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 14.1, 331.1, 18.8, 09.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 14.0, 449.8, 17.1, 10.8, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 13.7, 473.3, 18.6, 08.7, 2.7);  // Month - 2013-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 13.6, 546.3, 22.9, 04.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 15.3, 584.3, 23.4, 07.1, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 17.4, 572.5, 24.9, 09.8, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 19.9, 536.0, 27.2, 12.6, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 19.0, 571.8, 25.2, 12.8, 4.3);  // Month - 2013-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 15.6, 358.3, 19.0, 12.2, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 17.5, 513.0, 22.0, 13.0, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 16.8, 327.2, 20.5, 13.0, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 18.2, 485.5, 23.6, 12.8, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 19.3, 601.9, 26.5, 12.0, 4.5);  // Month - 2013-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 19.6, 531.7, 27.5, 11.6, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 20.4, 447.9, 27.3, 13.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 15.2, 309.5, 19.5, 10.9, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 17.8, 541.8, 26.8, 08.8, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 17.5, 207.3, 20.9, 14.0, 2.2);  // Month - 2013-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 11.3, 516.0, 16.5, 06.0, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 12.9, 558.8, 21.8, 03.9, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 19.2, 556.8, 25.4, 13.0, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 11.9, 635.8, 16.1, 07.7, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 12.0, 528.8, 21.8, 02.1, 3.8);  // Month - 2013-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 16.5, 402.7, 20.6, 12.3, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 13.0, 653.5, 19.3, 06.6, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 13.0, 580.0, 22.5, 03.4, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 17.6, 506.1, 25.3, 09.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 18.7, 553.4, 26.7, 10.6, 5.4);  // Month - 2013-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 19.9, 191.9, 23.8, 15.9, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 19.1, 192.9, 20.4, 17.8, 2.1);  // Month - 2013-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 16.7, 193.8, 19.4, 14.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 15.3, 457.5, 18.9, 11.7, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 15.1, 561.4, 19.4, 10.7, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 15.9, 688.7, 23.9, 07.9, 5.1);  // Month - 2013-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 19.5, 694.8, 26.7, 12.2, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 20.5, 504.9, 26.8, 14.2, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 18.9, 204.4, 21.1, 16.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 19.3, 509.3, 24.0, 14.6, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 20.6, 407.9, 24.7, 16.5, 3.5);  // Month - 2013-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 17.6, 201.8, 19.5, 15.6, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 20.5, 688.4, 27.3, 13.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 18.5, 591.6, 25.9, 11.0, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 22.5, 714.3, 32.2, 12.8, 7.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 19.7, 448.7, 24.3, 15.1, 5.5);  // Month - 2013-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 15.2, 716.2, 19.5, 10.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 17.8, 724.6, 26.1, 09.4, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 20.5, 659.9, 27.8, 13.2, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 18.7, 207.7, 20.4, 17.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 19.1, 212.3, 20.9, 17.3, 2.4);  // Month - 2013-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 17.2, 450.1, 21.3, 13.1, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 19.1, 716.5, 27.0, 11.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 21.2, 714.0, 28.1, 14.3, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 23.6, 675.8, 31.1, 16.0, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 22.5, 319.1, 26.8, 18.2, 3.6);  // Month - 2013-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 18.3, 211.6, 20.3, 16.3, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 17.6, 236.2, 21.2, 13.9, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 18.3, 759.9, 25.4, 11.2, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 18.2, 746.7, 22.7, 13.6, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 19.9, 724.1, 29.0, 10.8, 6.3);  // Month - 2013-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 22.6, 744.7, 29.3, 15.9, 6.3);  // Month - 2013-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 25.9, 709.0, 33.1, 18.7, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 14.9, 757.7, 19.6, 10.2, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 20.3, 737.7, 31.3, 09.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 16.9, 762.0, 21.8, 12.0, 5.6);  // Month - 2013-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 16.0, 753.7, 21.3, 10.6, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 20.4, 754.5, 31.2, 09.6, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 25.7, 610.4, 34.5, 16.9, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 20.0, 313.5, 23.3, 16.6, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 18.3, 635.4, 22.4, 14.2, 4.9);  // Month - 2013-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 18.8, 752.5, 27.4, 10.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 21.0, 692.6, 29.4, 12.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 23.0, 761.5, 30.4, 15.5, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 24.9, 709.3, 32.4, 17.4, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 26.3, 710.1, 34.1, 18.4, 6.9);  // Month - 2013-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 26.3, 686.7, 33.0, 19.6, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 27.0, 731.9, 35.4, 18.6, 7.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 26.4, 704.5, 34.1, 18.7, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 24.2, 753.8, 29.9, 18.4, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 24.1, 710.1, 29.5, 18.6, 6.5);  // Month - 2013-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 24.8, 759.2, 31.9, 17.6, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 25.9, 759.2, 33.3, 18.4, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 26.8, 780.4, 34.3, 19.2, 7.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 27.0, 775.6, 35.4, 18.6, 7.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 28.8, 766.8, 37.3, 20.2, 8.2);  // Month - 2013-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 30.8, 640.3, 38.9, 22.6, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 27.4, 644.1, 32.7, 22.0, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 27.3, 676.1, 36.4, 18.1, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 29.0, 530.3, 34.5, 23.4, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 29.3, 743.5, 35.8, 22.7, 8.5);  // Month - 2013-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 24.8, 420.2, 29.5, 20.0, 5.4);  


            #endregion
                            
        }

        public static void WeatherDataLasBrujas_2014(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2014, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            
            #region WeatherData 2014
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 21.3, 363.5, 25.3, 17.3, 4.9);  // Month - 2014-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 24.6, 529.6, 30.1, 19.0, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 26.7, 748.3, 31.4, 22.0, 7.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 25.4, 740.5, 32.0, 18.9, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 24.6, 700.1, 29.2, 19.9, 5.8);  // Month - 2014-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 23.3, 636.0, 28.5, 18.0, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 25.1, 417.9, 31.5, 18.7, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 24.3, 754.6, 32.3, 16.2, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 19.4, 759.4, 28.3, 10.4, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 17.0, 784.4, 23.8, 10.2, 6.1);  // Month - 2014-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 16.2, 718.7, 20.8, 11.6, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 16.4, 398.1, 20.5, 12.2, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 22.6, 357.2, 26.5, 18.7, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 26.3, 774.1, 33.9, 18.7, 8.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 23.2, 757.0, 30.5, 15.8, 6.9);  // Month - 2014-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 22.0, 748.1, 26.8, 17.1, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 22.7, 355.6, 26.7, 18.7, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 18.9, 709.3, 27.2, 10.5, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 17.5, 753.5, 23.0, 12.0, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 21.0, 656.4, 27.0, 14.9, 5.5);  // Month - 2014-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 20.2, 651.9, 26.7, 13.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 17.6, 719.8, 22.8, 12.4, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 18.8, 570.7, 23.0, 14.7, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 24.3, 546.2, 29.7, 18.8, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 21.0, 232.9, 26.2, 15.7, 2.5);  // Month - 2014-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 22.7, 389.2, 27.3, 18.1, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 24.7, 766.0, 32.9, 16.5, 7.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 22.7, 770.0, 31.1, 14.3, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 21.8, 765.7, 30.0, 13.5, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 20.2, 753.7, 25.3, 15.1, 5.9);  // Month - 2014-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 18.0, 215.4, 19.6, 16.3, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 18.1, 243.2, 19.9, 16.2, 2.7);  // Month - 2014-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 19.5, 214.9, 22.0, 16.9, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 24.1, 593.5, 32.4, 15.7, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 20.7, 720.0, 28.9, 12.5, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 17.9, 738.4, 27.0, 08.7, 5.4);  // Month - 2014-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 15.7, 543.1, 22.3, 09.0, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 17.2, 739.3, 22.2, 12.1, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 17.3, 269.8, 20.8, 13.8, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 19.6, 745.7, 27.8, 11.4, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 17.3, 546.2, 20.7, 13.8, 4.4);  // Month - 2014-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 17.1, 256.4, 19.9, 14.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 17.8, 325.9, 23.2, 12.4, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 22.7, 369.3, 28.9, 16.5, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 22.5, 719.0, 30.4, 14.5, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 20.5, 724.6, 28.9, 12.1, 6.5);  // Month - 2014-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 20.7, 715.8, 25.8, 15.5, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 22.8, 714.3, 31.4, 14.2, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 17.6, 717.0, 26.5, 08.7, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 14.5, 713.1, 20.1, 08.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 17.6, 590.6, 22.9, 12.2, 5.0);  // Month - 2014-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 21.4, 631.4, 26.8, 16.0, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 21.4, 462.5, 29.0, 13.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 19.2, 692.7, 27.4, 10.9, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 19.0, 695.4, 27.6, 10.4, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 20.6, 594.0, 26.6, 14.6, 4.6);  // Month - 2014-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 17.7, 691.0, 24.8, 10.5, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 16.5, 684.8, 23.8, 09.2, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 15.3, 686.5, 18.4, 12.1, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 16.1, 195.7, 18.2, 14.0, 2.1);  // Month - 2014-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 14.6, 194.8, 16.8, 12.4, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 15.5, 193.8, 17.4, 13.5, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 16.9, 321.3, 21.4, 12.3, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 18.2, 595.2, 23.4, 12.9, 4.5);  // Month - 2014-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 17.2, 191.0, 19.2, 15.1, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 22.4, 496.7, 26.5, 18.2, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 25.7, 600.7, 33.3, 18.1, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 24.0, 596.4, 30.7, 17.3, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 23.0, 605.9, 29.1, 16.8, 5.1);  // Month - 2014-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 22.7, 534.7, 28.6, 16.8, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 22.0, 635.1, 30.2, 13.7, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 21.8, 638.8, 30.2, 13.3, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 19.2, 622.0, 27.1, 11.3, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 15.9, 617.8, 20.9, 10.9, 4.2);  // Month - 2014-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 18.3, 623.0, 22.2, 14.3, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 19.6, 202.6, 23.2, 15.9, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 17.7, 554.5, 25.5, 09.8, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 20.4, 480.6, 25.3, 15.4, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 19.6, 525.5, 27.0, 12.1, 5.0);  // Month - 2014-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 18.1, 587.3, 25.4, 10.8, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 16.5, 307.4, 22.9, 10.0, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 15.1, 428.4, 20.5, 09.8, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 14.5, 519.9, 19.8, 09.2, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 12.9, 518.0, 15.6, 10.1, 3.4);  // Month - 2014-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 19.2, 195.6, 23.2, 15.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 19.9, 509.1, 26.8, 12.9, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 17.3, 559.5, 22.9, 11.7, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 17.5, 475.9, 21.5, 13.4, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 17.2, 164.8, 20.3, 14.1, 2.6);  // Month - 2014-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 16.4, 175.3, 19.3, 13.5, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 14.1, 273.5, 17.7, 10.4, 3.6);  // Month - 2014-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 10.7, 479.2, 17.1, 04.2, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 11.5, 375.5, 15.3, 07.6, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 16.4, 474.1, 23.5, 09.3, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 16.4, 511.8, 20.9, 11.8, 3.2);  // Month - 2014-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 15.8, 302.7, 21.1, 10.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 11.5, 534.2, 19.1, 03.9, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 11.9, 497.8, 16.1, 07.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 16.7, 383.4, 24.8, 08.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 16.0, 515.4, 22.9, 09.1, 3.7);  // Month - 2014-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 16.2, 366.8, 21.3, 11.1, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 15.4, 489.6, 21.4, 09.3, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 15.4, 457.5, 19.4, 11.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 13.7, 391.8, 16.9, 10.4, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 16.3, 435.7, 21.4, 11.1, 2.5);  // Month - 2014-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 15.0, 478.0, 21.6, 08.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 13.3, 436.7, 19.0, 07.6, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 12.6, 488.2, 20.4, 04.8, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 12.4, 424.8, 16.7, 08.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 14.8, 140.2, 15.8, 13.8, 1.3);  // Month - 2014-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 13.5, 167.4, 17.8, 09.1, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 12.3, 441.4, 20.0, 04.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 12.0, 426.1, 18.3, 05.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 12.4, 432.8, 16.1, 08.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 16.0, 135.4, 22.4, 09.6, 1.6);  // Month - 2014-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 16.1, 393.5, 23.8, 08.3, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 14.8, 427.2, 21.0, 08.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 14.4, 241.5, 19.4, 09.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 17.8, 162.6, 21.2, 14.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 16.9, 259.8, 20.4, 13.3, 3.5);  // Month - 2014-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 17.2, 241.9, 20.7, 13.7, 2.6);  // Month - 2014-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 15.4, 190.9, 19.0, 11.7, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 13.9, 241.2, 20.0, 07.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 13.3, 398.2, 18.2, 08.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 13.0, 263.8, 19.7, 06.3, 1.6);  // Month - 2014-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 10.9, 401.6, 18.2, 03.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 08.0, 387.3, 13.6, 02.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 08.1, 221.1, 09.9, 06.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 09.2, 136.6, 10.8, 07.6, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 09.7, 118.4, 11.4, 07.9, 2.7);  // Month - 2014-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 16.1, 159.6, 21.8, 10.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 20.2, 337.5, 26.6, 13.7, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 21.0, 370.9, 26.6, 15.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 21.7, 370.9, 29.9, 13.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 17.7, 387.3, 25.0, 10.4, 2.3);  // Month - 2014-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 16.0, 373.7, 23.9, 08.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 17.1, 370.9, 24.8, 09.3, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 14.4, 352.1, 23.1, 05.6, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 12.5, 288.1, 19.6, 05.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 10.3, 357.3, 18.8, 01.8, 2.1);  // Month - 2014-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 09.8, 351.8, 18.1, 01.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 08.7, 362.3, 13.9, 03.5, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 08.8, 346.4, 14.2, 03.3, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 08.0, 205.1, 13.3, 02.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 11.4, 104.1, 15.3, 07.4, 1.0);  // Month - 2014-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 10.4, 337.8, 17.6, 03.1, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 09.4, 336.2, 15.9, 02.9, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 10.4, 341.3, 15.2, 05.6, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 11.3, 120.9, 16.5, 06.1, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 09.9, 330.5, 16.8, 03.0, 1.7);  // Month - 2014-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 10.1, 331.1, 14.9, 05.3, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 17.3, 193.4, 21.2, 13.3, 1.7);  // Month - 2014-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 18.7, 162.7, 25.4, 11.9, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 16.9, 188.6, 20.6, 13.1, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 15.4, 170.5, 22.0, 08.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 13.7, 291.8, 18.7, 08.7, 1.4);  // Month - 2014-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 14.3, 153.1, 19.3, 09.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 08.2, 170.0, 14.7, 01.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 05.0, 294.1, 11.2, -01.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 04.5, 301.9, 07.8, 01.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 07.1, 280.6, 13.4, 00.7, 1.5);  // Month - 2014-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 07.9, 293.5, 12.4, 03.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 11.0, 143.5, 13.1, 08.8, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 12.9, 92.9, 14.1, 11.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 13.9, 292.2, 21.2, 06.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 14.3, 288.5, 20.7, 07.9, 1.3);  // Month - 2014-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 12.3, 288.7, 19.3, 05.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 10.1, 203.0, 14.0, 06.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 11.9, 123.0, 15.0, 08.7, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 12.9, 222.4, 15.9, 09.8, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 15.8, 83.9, 19.1, 12.4, 1.0);  // Month - 2014-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 16.1, 183.8, 22.5, 09.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 14.9, 205.6, 20.3, 09.5, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 14.9, 185.6, 18.8, 11.0, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 12.5, 275.8, 18.1, 06.9, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 10.7, 178.2, 14.3, 07.1, 0.8);  // Month - 2014-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 09.7, 254.7, 15.1, 04.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 10.2, 267.5, 14.1, 06.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 09.8, 273.4, 14.4, 05.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 07.9, 193.5, 10.3, 05.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 13.2, 81.5, 17.0, 09.3, 0.9);  // Month - 2014-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 09.8, 162.3, 15.6, 04.0, 0.8);  // Month - 2014-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 10.6, 259.4, 17.6, 03.6, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 08.0, 252.8, 14.0, 01.9, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 08.9, 89.2, 11.4, 06.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 10.6, 188.0, 13.3, 07.9, 0.6);  // Month - 2014-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 09.2, 183.2, 15.0, 03.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 07.5, 180.4, 13.4, 01.6, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 09.9, 233.6, 15.9, 03.8, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 08.9, 247.9, 15.8, 01.9, 0.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 08.1, 217.2, 13.9, 02.3, 0.3);  // Month - 2014-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 09.5, 167.6, 14.9, 04.1, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 13.3, 78.1, 14.8, 11.7, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 13.1, 97.5, 18.0, 08.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 10.0, 259.9, 16.9, 03.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 08.4, 262.9, 15.5, 01.3, 0.8);  // Month - 2014-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 06.9, 261.6, 12.6, 01.1, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 08.4, 258.2, 11.2, 05.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 07.8, 202.9, 13.0, 02.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 09.7, 168.8, 13.8, 05.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 10.0, 221.4, 17.9, 02.0, 0.8);  // Month - 2014-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 07.3, 250.4, 14.1, 00.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 08.8, 242.3, 13.2, 04.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 18.1, 85.4, 23.7, 12.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 13.5, 81.3, 17.0, 10.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 11.9, 261.8, 20.0, 03.8, 1.5);  // Month - 2014-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 12.0, 269.1, 17.1, 06.9, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 10.5, 265.4, 16.1, 04.8, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 09.9, 91.2, 15.6, 04.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 08.4, 217.9, 15.5, 01.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 11.5, 238.5, 16.2, 06.8, 0.8);  // Month - 2014-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 12.0, 145.5, 16.9, 07.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 11.9, 266.3, 19.4, 04.3, 1.3);  // Month - 2014-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 12.2, 273.5, 18.7, 05.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 12.6, 265.0, 15.8, 09.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 14.1, 84.2, 16.3, 11.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 12.8, 84.5, 15.4, 10.1, 0.9);  // Month - 2014-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 12.7, 272.8, 18.7, 06.7, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 08.9, 186.1, 16.3, 01.4, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 08.6, 256.2, 15.9, 01.3, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 11.0, 211.9, 16.8, 05.2, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 09.8, 292.4, 16.4, 03.2, 0.8);  // Month - 2014-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 09.1, 294.4, 14.7, 03.5, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 08.2, 155.4, 11.9, 04.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 12.4, 166.0, 13.9, 10.9, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 12.3, 91.1, 14.0, 10.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 10.9, 168.4, 16.5, 05.2, 0.9);  // Month - 2014-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 11.7, 184.1, 16.6, 06.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 12.0, 279.7, 15.2, 08.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 11.9, 271.8, 15.9, 07.9, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 11.3, 310.3, 16.5, 06.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 14.6, 154.6, 19.4, 09.8, 1.2);  // Month - 2014-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 15.6, 237.4, 21.3, 09.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 15.6, 186.5, 19.8, 11.4, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 16.4, 97.7, 17.9, 14.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 15.9, 116.1, 19.8, 12.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 14.4, 323.9, 20.7, 08.0, 1.7);  // Month - 2014-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 15.2, 150.7, 18.5, 11.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 14.7, 121.1, 17.2, 12.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 15.0, 137.3, 18.7, 11.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 17.1, 231.6, 21.0, 13.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 16.9, 225.8, 21.8, 12.0, 1.2);  // Month - 2014-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 18.2, 201.7, 22.8, 13.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 15.6, 118.9, 19.8, 11.3, 1.3);  // Month - 2014-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 16.1, 359.9, 22.7, 09.4, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 14.8, 145.5, 17.8, 11.7, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 18.7, 173.8, 21.6, 15.8, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 17.9, 112.7, 21.3, 14.4, 1.2);  // Month - 2014-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 18.2, 270.0, 22.8, 13.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 16.7, 354.9, 22.5, 10.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 13.6, 385.4, 21.0, 06.1, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 12.0, 388.3, 17.9, 06.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 14.3, 387.2, 20.5, 08.0, 1.5);  // Month - 2014-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 13.0, 387.2, 20.6, 05.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 13.4, 381.5, 19.0, 07.7, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 16.1, 324.3, 21.1, 11.1, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 15.0, 309.4, 21.4, 08.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 13.3, 395.5, 20.1, 06.4, 1.7);  // Month - 2014-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 14.5, 395.1, 20.4, 08.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 17.5, 350.9, 25.0, 10.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 16.6, 432.7, 24.2, 09.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 14.6, 426.5, 21.3, 07.8, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 13.4, 325.3, 17.3, 09.4, 1.8);  // Month - 2014-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 14.2, 261.9, 17.3, 11.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 14.3, 324.3, 17.9, 10.7, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 16.9, 293.5, 21.5, 12.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 17.0, 308.5, 23.7, 10.3, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 17.9, 384.9, 21.8, 14.0, 2.8);  // Month - 2014-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 19.6, 210.9, 23.6, 15.5, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 22.0, 134.6, 23.8, 20.2, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 23.7, 179.8, 26.7, 20.6, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 22.8, 137.1, 24.6, 21.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 23.8, 325.7, 28.5, 19.0, 2.9);  // Month - 2014-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 22.4, 433.3, 27.7, 17.0, 3.8);  // Month - 2014-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 21.0, 410.4, 25.6, 16.3, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 17.7, 472.0, 23.8, 11.6, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 17.0, 488.7, 21.4, 12.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 20.5, 150.9, 23.6, 17.4, 2.1);  // Month - 2014-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 23.4, 475.9, 30.3, 16.5, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 22.3, 449.5, 26.5, 18.1, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 23.1, 273.7, 28.6, 17.6, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 21.9, 312.0, 26.9, 16.9, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 18.0, 487.9, 24.3, 11.6, 3.4);  // Month - 2014-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 17.6, 510.9, 26.0, 09.1, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 15.2, 517.1, 23.9, 06.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 13.6, 527.1, 17.9, 09.2, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 16.0, 328.8, 19.1, 12.9, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 17.8, 378.4, 22.3, 13.3, 2.9);  // Month - 2014-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 16.4, 195.2, 20.7, 12.1, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 16.5, 437.6, 20.1, 12.9, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 20.3, 502.0, 23.9, 16.7, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 21.2, 459.3, 27.5, 14.8, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 20.3, 437.3, 23.8, 16.8, 3.7);  // Month - 2014-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 23.2, 320.6, 28.7, 17.6, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 20.5, 551.0, 28.1, 12.9, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 20.8, 564.0, 28.8, 12.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 18.8, 552.6, 25.6, 12.0, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 17.8, 430.6, 22.3, 13.3, 3.2);  // Month - 2014-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 19.8, 468.3, 27.2, 12.4, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 18.5, 567.4, 27.2, 09.8, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 17.6, 569.8, 22.3, 12.9, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 19.3, 446.0, 24.2, 14.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 20.8, 441.0, 24.9, 16.6, 3.4);  // Month - 2014-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 22.7, 428.4, 27.3, 18.0, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 19.5, 313.8, 24.3, 14.6, 3.6);  // Month - 2014-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 18.1, 326.4, 23.7, 12.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 18.4, 530.7, 24.1, 12.7, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 18.9, 307.8, 24.0, 13.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 18.1, 357.6, 22.5, 13.7, 2.9);  // Month - 2014-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 18.6, 437.6, 22.9, 14.3, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 19.4, 379.6, 22.1, 16.6, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 21.3, 624.4, 26.2, 16.4, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 21.0, 442.7, 26.5, 15.5, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 22.2, 534.9, 26.1, 18.2, 4.3);  // Month - 2014-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 22.4, 601.2, 27.6, 17.2, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 23.2, 402.4, 26.4, 20.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 24.1, 225.5, 27.5, 20.7, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 24.6, 595.2, 30.3, 18.8, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 23.8, 615.9, 29.9, 17.6, 5.8);  // Month - 2014-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 22.4, 610.5, 28.3, 16.5, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 19.0, 474.8, 23.8, 14.1, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 19.1, 645.6, 22.8, 15.3, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 21.3, 582.4, 25.1, 17.5, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 23.5, 600.0, 27.7, 19.2, 5.1);  // Month - 2014-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 25.5, 435.4, 30.7, 20.2, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 22.4, 382.7, 27.0, 17.7, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 23.3, 372.6, 27.3, 19.3, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 27.4, 526.2, 34.2, 20.6, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 21.2, 207.3, 23.9, 18.5, 2.0);  // Month - 2014-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 19.2, 200.4, 22.0, 16.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 28.5, 571.3, 36.0, 20.9, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 22.9, 529.8, 28.9, 16.9, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 19.8, 234.6, 21.4, 18.1, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 21.6, 255.0, 24.0, 19.2, 2.6);  // Month - 2014-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 22.3, 239.9, 24.7, 19.9, 2.4);  // Month - 2014-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 26.3, 632.4, 32.8, 19.8, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 24.2, 363.8, 27.5, 20.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 24.0, 225.9, 27.0, 21.0, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 22.7, 210.7, 24.7, 20.7, 2.1);  // Month - 2014-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 22.8, 326.4, 27.4, 18.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 19.6, 688.9, 26.9, 12.3, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 16.3, 713.7, 20.4, 12.1, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 19.2, 221.1, 21.6, 16.7, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 28.2, 457.0, 35.6, 20.8, 5.7);  // Month - 2014-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 26.6, 601.7, 33.1, 20.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 24.0, 287.0, 27.3, 20.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 25.8, 451.8, 31.4, 20.1, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 24.4, 677.2, 28.0, 20.8, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 29.1, 762.8, 36.6, 21.6, 8.1);  // Month - 2014-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 28.3, 671.4, 35.5, 21.0, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 26.4, 744.4, 33.3, 19.5, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 24.3, 733.4, 31.0, 17.5, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 22.5, 727.0, 28.3, 16.7, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 21.0, 672.2, 27.8, 14.1, 6.2);  // Month - 2014-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 17.1, 607.6, 23.3, 10.8, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 18.6, 567.5, 22.4, 14.8, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 24.2, 509.1, 30.1, 18.2, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 23.6, 587.8, 31.9, 15.3, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 21.9, 708.8, 26.4, 17.4, 6.0);  // Month - 2014-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 22.6, 217.1, 26.4, 18.7, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 26.8, 741.3, 35.4, 18.1, 8.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 24.6, 741.6, 31.5, 17.7, 7.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 20.8, 750.0, 29.8, 11.8, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 18.5, 745.9, 22.0, 14.9, 6.5);  // Month - 2014-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 22.6, 246.3, 26.0, 19.1, 2.9);  
  


            #endregion
                            
        }

        public static void WeatherDataLasBrujas_2015(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2015, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2015
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 21.3, 363.5, 25.3, 17.3, 4.9);  // Month - 2015-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 19.0, 757.6, 22.6, 15.5, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 20.6, 669.3, 29.8, 11.4, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 19.2, 681.4, 23.2, 15.1, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 23.0, 765.8, 33.1, 12.9, 7.1);  // Month - 2015-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 22.3, 237.5, 24.9, 19.6, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 25.0, 507.3, 30.7, 19.2, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 25.1, 716.8, 31.4, 18.8, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 24.7, 519.2, 29.4, 20.0, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 25.4, 640.2, 30.1, 20.7, 5.5);  // Month - 2015-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 26.1, 474.7, 30.7, 21.5, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 27.0, 752.9, 32.7, 21.2, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 21.3, 236.1, 23.1, 19.4, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 22.8, 590.0, 25.7, 19.9, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 22.6, 560.5, 27.1, 18.0, 5.2);  // Month - 2015-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 24.5, 696.2, 31.4, 17.5, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 20.9, 550.9, 24.5, 17.2, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 21.5, 562.1, 28.5, 14.5, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 20.6, 248.3, 24.4, 16.7, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 19.1, 499.8, 23.7, 14.5, 4.6);  // Month - 2015-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 18.4, 714.9, 25.6, 11.1, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 20.8, 733.5, 28.3, 13.2, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 23.0, 652.4, 29.3, 16.7, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 23.9, 603.6, 29.5, 18.3, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 25.0, 685.9, 31.4, 18.6, 6.0);  // Month - 2015-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 26.2, 525.9, 33.3, 19.1, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 28.0, 493.1, 34.1, 21.9, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 20.7, 206.7, 23.7, 17.7, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 17.7, 721.2, 22.3, 13.0, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 17.8, 716.2, 24.6, 11.0, 5.2);  // Month - 2015-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 20.4, 703.6, 27.9, 12.8, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 23.1, 710.9, 29.5, 16.7, 6.1);  // Month - 2015-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 23.8, 698.0, 29.5, 18.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 23.4, 645.6, 28.8, 17.9, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 26.2, 695.5, 31.9, 20.5, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 25.1, 642.1, 31.4, 18.7, 6.3);  // Month - 2015-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 24.7, 694.8, 30.8, 18.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 23.4, 684.7, 29.6, 17.1, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 24.2, 604.3, 32.1, 16.2, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 26.2, 625.5, 31.7, 20.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 22.3, 355.6, 27.4, 17.2, 4.1);  // Month - 2015-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 22.1, 667.6, 29.2, 15.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 24.5, 627.0, 32.7, 16.2, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 18.9, 663.3, 23.9, 13.8, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 19.7, 538.1, 24.4, 15.1, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 21.7, 620.3, 27.7, 15.7, 6.1);  // Month - 2015-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 23.2, 652.5, 29.7, 16.7, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 24.0, 638.7, 31.2, 16.8, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 24.2, 534.4, 31.3, 17.1, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 18.6, 191.4, 21.6, 15.5, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 19.7, 444.1, 23.9, 15.5, 4.2);  // Month - 2015-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 22.7, 461.4, 28.0, 17.4, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 23.8, 629.1, 30.9, 16.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 25.0, 596.7, 31.1, 18.8, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 27.2, 557.0, 34.3, 20.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 23.5, 316.1, 27.7, 19.3, 3.6);  // Month - 2015-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 24.4, 519.5, 28.8, 19.9, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 19.5, 580.1, 25.7, 13.3, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 18.5, 581.2, 26.7, 10.3, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 23.2, 442.3, 29.3, 17.1, 4.5);  // Month - 2015-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 24.4, 593.8, 31.0, 17.8, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 23.9, 193.4, 29.7, 18.1, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 23.1, 275.8, 26.0, 20.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 22.7, 560.5, 27.7, 17.6, 4.3);  // Month - 2015-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 21.9, 525.4, 29.3, 14.5, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 23.0, 559.1, 30.2, 15.7, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 23.6, 560.2, 30.9, 16.3, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 24.5, 532.5, 29.8, 19.1, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 25.8, 548.0, 31.6, 20.0, 4.8);  // Month - 2015-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 23.5, 552.6, 29.6, 17.4, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 23.9, 546.4, 31.6, 16.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 24.3, 547.4, 32.7, 15.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 24.2, 380.1, 30.8, 17.5, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 22.2, 503.5, 26.3, 18.2, 3.9);  // Month - 2015-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 21.7, 532.2, 29.5, 13.9, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 24.2, 533.2, 31.9, 16.5, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 23.5, 527.2, 31.0, 15.9, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 23.4, 521.3, 30.7, 16.0, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 24.4, 368.2, 31.1, 17.6, 4.8);  // Month - 2015-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 18.4, 454.8, 20.9, 15.9, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 17.0, 435.6, 20.3, 13.7, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 16.0, 355.3, 21.5, 10.4, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 15.1, 275.9, 22.3, 07.9, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 16.1, 150.5, 17.8, 14.3, 1.4);  // Month - 2015-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 17.1, 474.8, 21.0, 13.2, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 16.7, 392.7, 22.1, 11.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 16.4, 472.5, 25.1, 07.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 20.7, 485.8, 28.2, 13.2, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 21.2, 453.5, 27.0, 15.3, 3.3);  // Month - 2015-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 18.4, 375.7, 22.6, 14.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 18.1, 478.4, 26.6, 09.6, 3.2);  // Month - 2015-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 20.9, 484.2, 30.9, 10.9, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 21.9, 474.8, 31.6, 12.1, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 20.7, 243.1, 25.7, 15.6, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 19.2, 453.0, 24.1, 14.3, 3.4);  // Month - 2015-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 15.7, 408.9, 21.2, 10.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 15.8, 409.1, 23.0, 08.7, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 18.6, 406.3, 26.0, 11.2, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 21.0, 443.4, 28.9, 13.2, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 21.8, 418.7, 30.0, 13.7, 3.4);  // Month - 2015-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 18.6, 384.5, 23.6, 13.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 17.5, 444.8, 25.6, 09.3, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 21.6, 435.4, 30.2, 12.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 21.9, 328.3, 29.3, 14.4, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 20.8, 382.2, 25.1, 16.4, 3.2);  // Month - 2015-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 21.2, 338.6, 26.4, 16.0, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 18.0, 219.3, 21.5, 14.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 17.2, 424.2, 22.6, 11.7, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 18.0, 415.8, 25.9, 10.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 16.9, 392.8, 22.5, 11.3, 2.3);  // Month - 2015-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 15.6, 392.8, 23.7, 07.5, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 15.4, 390.0, 23.2, 07.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 16.8, 395.6, 25.0, 08.5, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 16.9, 328.3, 25.5, 08.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 19.6, 379.9, 27.8, 11.3, 2.5);  // Month - 2015-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 19.5, 379.9, 27.9, 11.0, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 20.0, 352.2, 28.0, 12.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 18.3, 352.2, 22.5, 14.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 16.4, 137.2, 20.1, 12.6, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 16.8, 157.6, 20.0, 13.6, 1.6);  // Month - 2015-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 18.1, 255.6, 23.7, 12.5, 2.5);  // Month - 2015-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 16.6, 106.8, 19.6, 13.5, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 11.3, 359.6, 15.0, 07.6, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 10.5, 345.9, 17.9, 03.1, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 14.0, 335.0, 21.0, 06.9, 1.7);  // Month - 2015-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 12.2, 247.0, 15.9, 08.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 11.0, 331.7, 17.4, 04.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 13.2, 299.4, 20.8, 05.6, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 13.2, 254.6, 20.9, 05.4, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 14.3, 111.8, 18.6, 09.9, 0.9);  // Month - 2015-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 15.6, 151.2, 21.0, 10.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 16.4, 317.9, 21.9, 10.9, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 16.2, 186.5, 21.4, 11.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 18.0, 212.6, 24.7, 11.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 19.5, 307.2, 25.9, 13.2, 1.8);  // Month - 2015-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 20.4, 312.8, 27.3, 13.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 20.9, 298.6, 26.9, 14.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 21.3, 308.7, 27.8, 14.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 19.5, 172.1, 24.7, 14.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 20.4, 288.1, 26.4, 14.3, 1.8);  // Month - 2015-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 21.8, 281.5, 27.9, 15.6, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 22.9, 265.4, 28.5, 17.3, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 17.3, 117.8, 20.7, 13.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 11.4, 158.9, 16.8, 06.0, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 10.8, 285.4, 17.8, 03.8, 1.0);  // Month - 2015-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 11.5, 103.6, 16.7, 06.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 14.8, 123.3, 18.5, 11.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 12.4, 277.1, 18.9, 05.9, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 11.1, 229.9, 19.2, 03.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 11.2, 174.2, 17.1, 05.2, 0.8);  // Month - 2015-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 12.5, 176.0, 18.9, 06.1, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 15.2, 267.3, 21.7, 08.6, 1.0);  // Month - 2015-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 14.7, 251.2, 22.0, 07.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 16.0, 116.9, 21.6, 10.4, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 13.1, 212.4, 21.4, 04.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 19.5, 129.6, 26.1, 12.8, 1.5);  // Month - 2015-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 19.1, 89.3, 24.7, 13.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 13.7, 173.1, 19.1, 08.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 11.2, 258.7, 18.8, 03.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 12.0, 81.8, 14.9, 09.1, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 10.4, 193.7, 15.6, 05.2, 1.2);  // Month - 2015-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 09.0, 267.7, 13.7, 04.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 08.3, 267.0, 16.9, -00.3, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 09.0, 172.5, 16.7, 01.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 10.1, 243.9, 15.3, 04.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 08.7, 267.0, 15.1, 02.3, 1.9);  // Month - 2015-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 12.8, 264.1, 21.0, 04.5, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 09.7, 246.1, 15.3, 04.1, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 06.0, 262.5, 10.8, 01.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 04.8, 240.2, 12.3, -02.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 06.5, 200.9, 14.4, -01.5, 1.0);  // Month - 2015-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 09.6, 251.4, 17.7, 01.5, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 07.4, 78.3, 12.0, 02.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 06.4, 251.8, 12.1, 00.7, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 08.5, 256.9, 16.8, 00.1, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 14.8, 168.2, 21.7, 07.8, 1.9);  // Month - 2015-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 17.2, 250.0, 23.1, 11.2, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 17.8, 188.5, 24.1, 11.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 16.9, 81.6, 18.4, 15.4, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 15.4, 79.7, 17.0, 13.7, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 11.7, 235.6, 15.0, 08.3, 0.5);  // Month - 2015-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 09.5, 234.8, 14.5, 04.6, 0.7);  // Month - 2015-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 11.0, 198.4, 16.3, 05.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 08.1, 115.9, 12.2, 04.1, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 07.1, 239.0, 11.9, 02.3, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 06.7, 259.3, 14.3, -01.0, 0.7);  // Month - 2015-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 08.9, 180.9, 15.5, 02.3, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 08.9, 159.3, 17.5, 00.2, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 10.1, 270.2, 19.4, 00.8, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 10.1, 241.9, 17.0, 03.2, 0.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 12.0, 113.9, 16.9, 07.1, 0.7);  // Month - 2015-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 12.4, 112.0, 15.0, 09.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 14.9, 150.0, 20.4, 09.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 12.0, 83.6, 17.1, 06.9, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 08.8, 277.7, 12.8, 04.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 06.9, 282.7, 13.9, -00.2, 0.8);  // Month - 2015-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 07.6, 194.9, 14.9, 00.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 09.9, 279.8, 19.4, 00.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 13.5, 190.9, 19.1, 07.9, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 12.1, 139.6, 16.7, 07.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 08.5, 260.4, 12.3, 04.7, 1.1);  // Month - 2015-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 06.1, 292.2, 12.7, -00.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 07.7, 289.4, 16.1, -00.7, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 10.0, 162.3, 17.7, 02.3, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 10.4, 297.7, 19.2, 01.6, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 15.9, 273.5, 22.1, 09.6, 1.7);  // Month - 2015-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 14.4, 294.1, 20.8, 08.0, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 14.6, 283.9, 20.3, 08.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 18.8, 227.7, 26.9, 10.7, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 15.5, 96.1, 18.5, 12.5, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 16.3, 138.0, 20.5, 12.0, 1.5);  // Month - 2015-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 16.0, 177.8, 20.0, 12.0, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 11.5, 266.8, 17.7, 05.4, 1.5);  // Month - 2015-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 15.4, 121.0, 18.7, 12.0, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 14.0, 274.9, 19.6, 08.3, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 11.4, 259.1, 16.6, 06.1, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 13.8, 168.3, 19.5, 08.2, 2.2);  // Month - 2015-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 18.1, 134.2, 20.5, 15.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 16.9, 99.8, 20.3, 13.5, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 19.5, 125.7, 25.4, 13.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 24.0, 223.7, 31.2, 16.7, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 12.0, 123.1, 16.9, 07.0, 1.0);  // Month - 2015-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 11.4, 147.5, 14.7, 08.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 12.8, 104.7, 13.9, 11.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 14.3, 105.7, 15.4, 13.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 12.4, 106.8, 13.4, 11.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 10.8, 259.2, 14.4, 07.2, 1.2);  // Month - 2015-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 11.5, 317.5, 17.6, 05.3, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 14.8, 110.0, 18.6, 11.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 14.4, 241.0, 18.3, 10.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 11.7, 117.5, 13.7, 09.7, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 13.2, 313.3, 17.3, 09.1, 1.7);  // Month - 2015-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 15.5, 290.8, 21.1, 09.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 16.7, 220.8, 21.3, 12.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 11.0, 124.7, 13.9, 08.0, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 11.1, 385.1, 15.7, 06.5, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 12.6, 348.3, 20.7, 04.5, 2.4);  // Month - 2015-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 13.2, 119.4, 15.7, 10.7, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 13.5, 390.6, 17.0, 10.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 14.7, 329.5, 22.6, 06.7, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 19.0, 384.1, 24.9, 13.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 19.7, 354.4, 25.7, 13.6, 3.4);  // Month - 2015-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 15.8, 341.9, 22.8, 08.8, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 09.6, 430.3, 12.9, 06.2, 2.4);  // Month - 2015-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 11.1, 213.3, 16.4, 05.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 10.9, 352.5, 15.9, 05.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 09.4, 430.5, 17.7, 01.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 12.2, 442.5, 19.0, 05.3, 2.3);  // Month - 2015-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 12.3, 442.6, 20.0, 04.6, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 14.9, 228.0, 20.6, 09.1, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 16.0, 420.7, 19.7, 12.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 11.1, 172.6, 15.5, 06.6, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 09.8, 414.0, 13.2, 06.4, 2.8);  // Month - 2015-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 05.8, 466.8, 09.8, 01.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 07.8, 476.0, 14.3, 01.3, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 12.2, 476.0, 20.5, 03.9, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 15.7, 443.9, 25.6, 05.7, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 19.7, 434.1, 25.4, 13.9, 4.6);  // Month - 2015-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 10.8, 369.1, 15.5, 06.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 11.2, 471.7, 18.5, 03.9, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 10.2, 478.0, 18.5, 01.9, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 14.3, 451.4, 21.6, 06.9, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 14.0, 401.7, 21.2, 06.8, 3.5);  // Month - 2015-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 15.0, 149.7, 17.2, 12.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 12.4, 150.9, 13.4, 11.4, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 14.5, 152.1, 15.9, 13.0, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 14.4, 153.3, 15.8, 13.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 12.5, 188.1, 15.7, 09.2, 1.6);  // Month - 2015-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 12.2, 267.1, 17.8, 06.5, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 13.7, 520.0, 20.4, 07.1, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 14.7, 232.9, 21.1, 08.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 12.4, 511.8, 17.5, 07.2, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 10.9, 542.2, 15.5, 06.2, 3.4);  // Month - 2015-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 14.1, 461.9, 22.8, 05.4, 3.4);  // Month - 2015-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 12.0, 197.2, 15.4, 08.5, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 09.6, 435.9, 12.8, 06.3, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 12.2, 532.9, 16.0, 08.3, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 14.5, 458.3, 21.1, 07.9, 3.6);  // Month - 2015-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 17.1, 354.4, 20.6, 13.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 15.0, 210.8, 16.8, 13.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 15.3, 494.0, 19.0, 11.5, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 13.2, 331.7, 15.9, 10.5, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 13.0, 390.6, 15.6, 10.3, 3.1);  // Month - 2015-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 12.9, 194.4, 15.9, 09.8, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 12.0, 462.5, 16.5, 07.4, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 12.8, 555.5, 21.2, 04.3, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 17.5, 376.3, 23.6, 11.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 15.4, 425.8, 18.6, 12.1, 4.2);  // Month - 2015-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 11.6, 512.1, 13.6, 09.5, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 10.0, 609.6, 14.1, 05.9, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 11.7, 608.2, 20.1, 03.3, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 15.0, 211.0, 19.4, 10.5, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 14.7, 289.9, 17.6, 11.8, 2.2);  // Month - 2015-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 16.0, 610.8, 23.2, 08.8, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 16.5, 463.7, 22.8, 10.3, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 11.3, 626.1, 14.1, 08.5, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 11.7, 399.8, 15.3, 08.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 15.9, 307.3, 21.1, 10.6, 3.1);  // Month - 2015-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 18.3, 301.1, 22.6, 13.9, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 20.2, 612.0, 25.3, 15.0, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 20.6, 523.2, 26.9, 14.2, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 20.4, 206.1, 23.8, 17.0, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 13.7, 191.9, 17.8, 09.6, 2.0);  // Month - 2015-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 13.1, 646.9, 18.0, 08.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 14.8, 576.4, 20.6, 08.9, 4.7);  // Month - 2015-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 14.2, 570.7, 21.2, 07.3, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 17.2, 445.9, 22.0, 12.4, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 14.7, 520.6, 19.5, 09.8, 3.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 15.0, 599.8, 23.1, 06.8, 4.1);  // Month - 2015-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 16.3, 687.1, 24.4, 08.1, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 18.1, 673.4, 26.4, 09.7, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 19.9, 683.7, 27.4, 12.3, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 23.3, 509.3, 29.9, 16.6, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 22.9, 381.5, 28.2, 17.6, 3.6);  // Month - 2015-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 20.0, 699.0, 26.8, 13.2, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 17.9, 453.6, 26.8, 09.0, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 18.4, 219.4, 21.0, 15.8, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 19.7, 706.4, 25.4, 13.9, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 21.4, 715.8, 28.7, 14.1, 6.1);  // Month - 2015-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 20.4, 519.9, 26.1, 14.7, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 19.4, 218.2, 21.4, 17.4, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 17.9, 207.0, 20.8, 14.9, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 16.1, 207.7, 19.9, 12.3, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 13.4, 709.8, 18.1, 08.6, 5.4);  // Month - 2015-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 15.5, 718.9, 24.0, 06.9, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 17.5, 704.6, 24.8, 10.2, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 17.3, 551.4, 23.8, 10.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 17.0, 727.4, 24.7, 09.3, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 19.2, 736.9, 25.8, 12.6, 6.3);  // Month - 2015-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 20.4, 527.2, 25.8, 15.0, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 20.9, 228.9, 24.7, 17.0, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 19.1, 705.5, 22.5, 15.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 18.3, 710.6, 22.6, 14.0, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 19.3, 752.2, 27.5, 11.1, 6.2);  // Month - 2015-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 21.7, 756.7, 29.4, 13.9, 6.2);  // Month - 2015-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 20.8, 753.2, 27.0, 14.5, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 20.9, 625.2, 28.2, 13.5, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 21.3, 484.8, 25.3, 17.2, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 18.7, 649.6, 23.7, 13.7, 5.5);  // Month - 2015-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 14.9, 733.6, 18.2, 11.7, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 17.3, 706.4, 26.1, 08.5, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 22.1, 726.9, 30.5, 13.7, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 20.1, 558.6, 25.3, 14.8, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 21.8, 760.0, 30.8, 12.7, 6.9);  // Month - 2015-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 26.1, 756.5, 34.8, 17.4, 7.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 26.8, 636.3, 33.6, 19.9, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 24.7, 584.4, 30.0, 19.3, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 21.7, 323.0, 26.0, 17.3, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 20.5, 742.4, 24.8, 16.1, 5.9);  // Month - 2015-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 20.6, 739.2, 29.6, 11.6, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 20.8, 291.8, 24.7, 16.9, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 20.7, 571.1, 23.8, 17.5, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 17.5, 766.0, 21.5, 13.5, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 18.5, 742.5, 27.0, 10.0, 5.9);  // Month - 2015-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 22.7, 601.1, 29.6, 15.7, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 21.0, 220.4, 22.7, 19.2, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 23.4, 499.9, 28.3, 18.5, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 23.0, 665.5, 28.8, 17.2, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 22.3, 773.8, 31.1, 13.5, 6.8);  // Month - 2015-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 22.9, 749.2, 30.5, 15.2, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 24.6, 712.5, 32.8, 16.3, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 26.6, 716.2, 34.3, 18.9, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 24.5, 437.1, 30.7, 18.2, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 23.1, 267.2, 26.3, 19.9, 2.9);  // Month - 2015-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 23.4, 738.8, 28.2, 18.5, 6.2);  
 

            #endregion
                            
        }
        
        public static void WeatherDataLasBrujas_2016(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2016, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLasBrujas
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2016
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 25.8, 686.1, 30.5, 21.1, 6.2);  // Month - 2016-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 24.9, 483.8, 30.2, 19.5, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 25.4, 580.7, 29.6, 21.2, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 27.6, 721.8, 33.7, 21.5, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 26.4, 415.1, 31.0, 21.7, 5.2);  // Month - 2016-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 20.4, 648.6, 24.9, 15.8, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 19.2, 736.9, 25.2, 13.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 21.8, 523.3, 29.1, 14.4, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 21.4, 696.7, 26.9, 15.8, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 23.4, 446.5, 29.6, 17.2, 4.2);  // Month - 2016-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 23.7, 741.1, 30.4, 17.1, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 25.8, 478.5, 32.8, 18.8, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 23.0, 748.9, 28.5, 17.5, 7.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 23.8, 755.2, 32.7, 14.8, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 23.1, 757.5, 30.5, 15.6, 6.7);  // Month - 2016-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 22.1, 644.0, 32.1, 12.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 27.5, 595.1, 35.3, 19.7, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 22.6, 742.7, 27.5, 17.6, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 22.1, 725.3, 30.2, 14.0, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 20.8, 219.6, 24.0, 17.6, 2.6);  // Month - 2016-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 24.9, 706.9, 31.3, 18.5, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 27.6, 677.6, 35.0, 20.1, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 22.9, 708.2, 27.0, 18.8, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 27.2, 699.2, 38.0, 16.4, 8.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 25.2, 674.0, 29.9, 20.4, 6.8);  // Month - 2016-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 20.4, 661.1, 25.8, 15.0, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 19.0, 707.4, 27.4, 10.5, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 22.8, 623.1, 31.0, 14.5, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 25.2, 376.5, 30.1, 20.2, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 23.7, 609.3, 28.2, 19.2, 5.2);  // Month - 2016-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 20.2, 640.3, 25.9, 14.5, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 19.0, 695.0, 25.6, 12.3, 5.4);  // Month - 2016-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 21.8, 698.0, 29.0, 14.5, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 24.4, 436.1, 30.7, 18.1, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 25.0, 664.0, 31.0, 18.9, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 26.1, 681.4, 33.3, 18.8, 6.7);  // Month - 2016-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 26.6, 526.1, 33.1, 20.0, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 26.3, 477.3, 33.2, 19.3, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 26.2, 210.1, 30.1, 22.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 25.8, 660.6, 31.6, 19.9, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 24.6, 685.4, 30.3, 18.9, 6.4);  // Month - 2016-2-10
            
            #endregion
            
        }
        
        #endregion

        #region La Estanzuela

        public static void WeatherDataLaEstanzuela_2015(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2015, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLaEstanzuela
                               select ws).FirstOrDefault(); 
            

            #region WeatherData 2015

            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 20.8, 354.1, 23.3, 18.2, 4.9);  // Month - 2015-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 17.8, 741.6, 23.0, 12.6, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 20.0, 677.0, 28.0, 12.0, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 19.0, 612.4, 22.6, 15.4, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 23.9, 741.6, 32.7, 15.2, 7.5);  // Month - 2015-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 23.2, 241.6, 26.3, 20.0, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 24.1, 523.9, 28.6, 19.5, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 24.8, 729.7, 30.3, 19.4, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 26.7, 583.7, 30.5, 23.0, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 25.5, 672.2, 29.1, 21.8, 5.9);  // Month - 2015-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 26.7, 576.6, 30.1, 23.2, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 28.0, 696.2, 34.3, 21.6, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 21.2, 215.3, 22.4, 20.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 23.2, 648.3, 26.4, 20.0, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 22.9, 708.1, 27.4, 18.4, 6.1);  // Month - 2015-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 25.0, 672.2, 30.6, 19.4, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 20.6, 390.0, 23.5, 17.7, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 21.0, 404.3, 26.0, 15.9, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 20.8, 210.5, 22.6, 19.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 19.8, 674.6, 23.6, 15.9, 5.2);  // Month - 2015-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 19.2, 715.3, 24.1, 14.2, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 21.7, 724.9, 27.6, 15.8, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 22.9, 660.3, 28.4, 17.4, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 23.4, 610.0, 28.0, 18.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 25.7, 693.8, 31.2, 20.2, 5.9);  // Month - 2015-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 26.9, 454.5, 32.7, 21.0, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 27.9, 516.7, 33.1, 22.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 21.1, 514.4, 23.4, 18.7, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 18.1, 705.7, 22.1, 14.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 18.0, 712.9, 24.4, 11.6, 5.2);  // Month - 2015-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 21.3, 617.4, 28.0, 14.6, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 23.7, 703.3, 29.4, 18.0, 5.8);  // Month - 2015-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 23.8, 665.1, 28.4, 19.2, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 23.8, 507.2, 27.8, 19.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 26.1, 504.8, 31.2, 21.0, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 25.0, 456.9, 29.0, 21.0, 4.5);  // Month - 2015-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 25.2, 667.5, 30.8, 19.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 24.9, 691.4, 29.8, 20.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 24.9, 583.7, 30.6, 19.2, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 25.4, 557.4, 31.2, 19.6, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 22.3, 370.8, 26.6, 18.0, 3.8);  // Month - 2015-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 22.7, 679.4, 29.4, 16.0, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 23.7, 629.2, 31.4, 15.9, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 19.6, 669.9, 24.0, 15.1, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 20.3, 622.0, 26.4, 14.2, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 22.4, 600.5, 29.0, 15.8, 5.6);  // Month - 2015-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 23.4, 574.2, 28.8, 18.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 24.8, 650.7, 31.0, 18.6, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 21.4, 358.9, 24.5, 18.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 19.5, 251.2, 21.8, 17.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 17.6, 595.7, 22.6, 12.6, 4.1);  // Month - 2015-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 23.2, 490.4, 30.2, 16.2, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 23.6, 645.6, 30.2, 17.0, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 25.0, 634.0, 30.3, 19.6, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 26.8, 593.3, 32.6, 21.0, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 23.2, 191.4, 24.8, 21.6, 2.5);  // Month - 2015-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 24.2, 380.4, 27.8, 20.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 19.2, 526.3, 25.1, 13.2, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 19.1, 578.9, 26.4, 11.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 21.7, 315.8, 26.8, 16.6, 3.5);  // Month - 2015-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 23.9, 540.7, 30.6, 17.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 22.0, 174.6, 23.8, 20.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 23.3, 413.9, 26.6, 20.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 23.1, 523.9, 27.0, 19.2, 4.1);  // Month - 2015-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 23.3, 578.9, 30.0, 16.6, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 24.7, 586.1, 30.8, 18.6, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 24.4, 576.6, 31.2, 17.6, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 25.1, 564.6, 30.6, 19.5, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 26.1, 521.5, 31.4, 20.8, 4.6);  // Month - 2015-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 24.4, 567.0, 30.0, 18.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 25.1, 559.8, 32.0, 18.2, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 24.4, 564.6, 32.0, 16.8, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 24.2, 294.3, 29.3, 19.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 22.1, 471.3, 25.6, 18.6, 3.8);  // Month - 2015-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 23.4, 538.3, 30.2, 16.6, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 25.7, 545.5, 32.0, 19.4, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 24.6, 540.7, 32.0, 17.2, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 24.9, 540.7, 31.2, 18.6, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 23.0, 380.4, 30.0, 16.0, 4.6);  // Month - 2015-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 11.9, 495.2, 20.0, 03.8, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 16.3, 471.3, 20.4, 12.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 15.1, 471.3, 20.6, 09.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 15.3, 267.9, 20.7, 09.8, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 15.8, 150.7, 18.0, 13.6, 1.4);  // Month - 2015-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 16.6, 476.1, 20.6, 12.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 15.7, 488.0, 20.8, 10.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 17.8, 497.6, 25.0, 10.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 20.4, 478.5, 27.9, 12.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 21.6, 401.9, 28.4, 14.8, 3.5);  // Month - 2015-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 18.5, 325.4, 23.8, 13.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 19.2, 485.6, 27.2, 11.2, 3.5);  // Month - 2015-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 22.6, 492.8, 30.6, 14.6, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 24.2, 483.3, 30.8, 17.6, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 22.2, 258.4, 24.1, 20.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 19.4, 430.6, 22.7, 16.1, 3.4);  // Month - 2015-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 16.7, 425.8, 21.4, 12.0, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 18.1, 413.9, 25.0, 11.2, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 19.0, 390.0, 26.1, 12.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 21.2, 464.1, 28.4, 13.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 22.9, 378.0, 30.0, 15.8, 4.1);  // Month - 2015-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 18.9, 277.5, 23.0, 14.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 19.4, 437.8, 27.2, 11.5, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 24.3, 387.6, 30.9, 17.7, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 23.6, 291.9, 29.7, 17.6, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 21.0, 289.5, 24.8, 17.2, 2.6);  // Month - 2015-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 20.9, 291.9, 25.7, 16.2, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 17.3, 267.9, 20.6, 14.0, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 16.5, 430.6, 22.6, 10.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 19.5, 425.8, 26.2, 12.9, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 17.2, 418.7, 21.2, 13.3, 2.4);  // Month - 2015-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 16.8, 404.3, 23.0, 10.7, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 16.2, 406.7, 22.0, 10.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 17.8, 409.1, 25.2, 10.4, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 18.5, 404.3, 25.4, 11.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 20.7, 378.0, 27.7, 13.6, 3.1);  // Month - 2015-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 19.6, 390.0, 26.4, 12.8, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 21.4, 320.6, 27.7, 15.2, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 19.1, 296.7, 23.3, 14.9, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 15.6, 110.0, 16.8, 14.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 17.8, 167.5, 21.5, 14.0, 1.8);  // Month - 2015-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 17.9, 138.8, 22.2, 13.6, 2.5);  // Month - 2015-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 14.7, 107.7, 19.8, 09.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 10.6, 344.5, 15.1, 06.0, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 11.8, 361.2, 18.4, 05.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 15.6, 346.9, 21.3, 09.9, 2.1);  // Month - 2015-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 12.1, 232.1, 15.1, 09.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 10.7, 325.4, 16.9, 04.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 14.0, 332.5, 20.7, 07.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 14.2, 227.3, 20.0, 08.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 15.4, 201.0, 18.2, 12.6, 0.8);  // Month - 2015-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 15.0, 189.0, 20.0, 10.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 16.3, 311.0, 19.9, 12.7, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 16.9, 236.8, 21.7, 12.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 18.7, 303.8, 24.7, 12.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 18.6, 265.6, 23.2, 14.0, 1.2);  // Month - 2015-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 20.8, 315.8, 26.6, 15.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 21.0, 315.8, 26.7, 15.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 22.9, 227.3, 27.7, 18.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 21.8, 143.5, 26.4, 17.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 21.3, 289.5, 26.2, 16.4, 2.2);  // Month - 2015-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 22.4, 282.3, 26.9, 17.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 23.0, 265.6, 27.9, 18.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 18.5, 88.5, 21.0, 16.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 13.8, 212.9, 18.5, 09.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 12.5, 279.9, 18.3, 06.6, 1.2);  // Month - 2015-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 13.5, 88.5, 15.9, 11.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 15.9, 172.2, 19.1, 12.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 13.6, 282.3, 19.2, 08.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 12.9, 177.0, 18.2, 07.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 10.4, 86.1, 14.7, 06.0, 0.6);  // Month - 2015-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 13.4, 229.7, 19.6, 07.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 15.4, 267.9, 20.8, 10.0, 1.5);  // Month - 2015-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 15.3, 258.4, 21.6, 09.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 17.2, 251.2, 21.7, 12.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 15.9, 229.7, 22.5, 09.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 20.6, 112.4, 26.7, 14.4, 1.4);  // Month - 2015-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 18.0, 107.7, 24.3, 11.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 15.0, 179.4, 19.8, 10.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 14.0, 284.7, 18.9, 09.0, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 13.2, 81.3, 15.9, 10.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 11.0, 193.8, 14.6, 07.4, 0.8);  // Month - 2015-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 09.8, 279.9, 14.8, 04.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 08.3, 284.7, 16.3, 00.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 08.8, 119.6, 14.7, 02.8, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 10.0, 256.0, 15.3, 04.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 08.3, 275.1, 15.2, 01.4, 2.2);  // Month - 2015-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 12.5, 275.1, 20.2, 04.7, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 12.1, 260.8, 16.4, 07.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 04.7, 275.1, 09.6, -00.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 05.9, 265.6, 12.5, -00.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 08.0, 244.0, 14.8, 01.2, 1.2);  // Month - 2015-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 09.8, 256.0, 17.5, 02.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 07.7, 78.9, 11.6, 03.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 06.5, 256.0, 10.3, 02.6, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 07.5, 267.9, 13.7, 01.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 18.4, 160.3, 23.5, 13.2, 2.3);  // Month - 2015-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 16.6, 234.4, 20.6, 12.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 17.7, 86.1, 20.5, 14.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 16.8, 81.3, 17.5, 16.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 16.8, 86.1, 19.0, 14.6, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 13.5, 256.0, 16.9, 10.0, 0.7);  // Month - 2015-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 10.6, 186.6, 13.8, 07.4, 0.8);  // Month - 2015-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 11.8, 212.9, 16.5, 07.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 07.6, 81.3, 11.0, 04.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 07.3, 270.3, 11.0, 03.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 07.5, 272.7, 13.9, 01.0, 1.1);  // Month - 2015-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 11.4, 191.4, 15.8, 07.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 11.0, 224.9, 16.9, 05.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 11.4, 272.7, 19.1, 03.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 11.7, 167.5, 17.2, 06.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 13.0, 88.5, 16.1, 09.8, 0.8);  // Month - 2015-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 13.1, 88.5, 15.1, 11.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 15.3, 122.0, 19.4, 11.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 11.4, 83.7, 15.5, 07.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 08.8, 294.3, 13.3, 04.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 07.6, 294.3, 14.3, 00.8, 1.1);  // Month - 2015-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 08.6, 181.8, 14.6, 02.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 09.8, 287.1, 18.0, 01.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 14.2, 239.2, 18.7, 09.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 12.6, 138.8, 16.6, 08.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 06.3, 244.0, 11.1, 01.4, 0.9);  // Month - 2015-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 05.8, 279.9, 12.1, -00.6, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 09.0, 311.0, 15.5, 02.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 10.5, 167.5, 17.4, 03.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 09.6, 308.6, 16.7, 02.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 12.6, 217.7, 18.6, 06.5, 1.1);  // Month - 2015-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 16.0, 308.6, 20.7, 11.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 15.9, 299.0, 21.6, 10.2, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 20.7, 241.6, 27.3, 14.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 15.6, 95.7, 18.9, 12.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 15.6, 95.7, 19.4, 11.8, 1.3);  // Month - 2015-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 13.8, 248.8, 19.1, 08.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 12.3, 205.7, 17.9, 06.6, 1.6);  // Month - 2015-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 15.9, 189.0, 18.8, 12.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 14.7, 287.1, 18.2, 11.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 12.8, 282.3, 17.2, 08.4, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 14.6, 117.2, 20.2, 09.0, 2.2);  // Month - 2015-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 17.3, 155.5, 20.5, 14.1, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 17.4, 100.5, 21.4, 13.4, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 20.0, 138.8, 26.6, 13.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 20.9, 124.4, 26.6, 15.2, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 12.0, 157.9, 15.9, 08.0, 0.9);  // Month - 2015-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 11.5, 177.0, 15.4, 07.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 13.0, 105.3, 14.0, 12.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 13.6, 107.7, 14.6, 12.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 11.9, 107.7, 12.6, 11.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 14.4, 346.9, 19.2, 09.6, 1.7);  // Month - 2015-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 13.0, 239.2, 16.6, 09.4, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 14.1, 110.0, 19.0, 09.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 15.1, 236.8, 19.0, 11.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 12.0, 174.6, 13.8, 10.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 12.9, 241.6, 17.0, 08.8, 1.6);  // Month - 2015-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 14.9, 392.3, 20.4, 09.4, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 16.0, 241.6, 20.6, 11.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 09.6, 241.6, 12.0, 07.1, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 10.9, 404.3, 15.6, 06.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 12.6, 272.7, 18.6, 06.5, 2.4);  // Month - 2015-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 15.4, 234.4, 17.4, 13.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 13.3, 390.0, 18.2, 08.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 15.1, 301.4, 22.4, 07.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 19.4, 370.8, 24.6, 14.2, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 18.4, 380.4, 23.2, 13.5, 2.1);  // Month - 2015-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 14.8, 401.9, 19.4, 10.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 10.3, 406.7, 12.6, 08.0, 2.8);  // Month - 2015-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 09.9, 179.4, 15.4, 04.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 10.8, 401.9, 15.2, 06.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 11.4, 437.8, 18.4, 04.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 13.5, 454.5, 19.8, 07.2, 2.6);  // Month - 2015-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 13.4, 466.5, 20.4, 06.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 12.2, 167.5, 16.8, 07.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 15.4, 445.0, 20.2, 10.5, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 10.6, 136.4, 13.9, 07.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 09.2, 416.3, 13.4, 05.0, 3.1);  // Month - 2015-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 06.8, 480.9, 10.2, 03.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 10.3, 417.9, 15.4, 05.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 12.4, 488.0, 20.2, 04.6, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 16.2, 461.7, 24.2, 08.1, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 18.7, 454.5, 24.2, 13.2, 4.7);  // Month - 2015-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 11.0, 416.3, 15.4, 06.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 12.1, 464.1, 17.7, 06.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 11.5, 502.4, 17.0, 06.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 13.8, 421.1, 21.4, 06.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 14.6, 339.7, 20.0, 09.2, 3.1);  // Month - 2015-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 14.5, 150.7, 16.2, 12.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 12.9, 150.7, 13.6, 12.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 13.7, 153.1, 14.6, 12.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 13.8, 153.1, 14.4, 13.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 12.8, 224.9, 15.4, 10.2, 1.6);  // Month - 2015-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 13.1, 277.5, 16.2, 10.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 14.5, 512.0, 21.4, 07.5, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 12.7, 157.9, 15.8, 09.6, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 14.0, 526.3, 18.8, 09.2, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 11.7, 543.1, 17.2, 06.2, 3.2);  // Month - 2015-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 15.4, 411.5, 23.4, 07.4, 3.3);  // Month - 2015-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 09.9, 162.7, 13.4, 06.4, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 08.4, 502.4, 12.0, 04.7, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 11.8, 502.4, 16.4, 07.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 14.3, 390.0, 20.6, 07.9, 3.2);  // Month - 2015-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 16.0, 356.5, 18.6, 13.4, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 14.6, 311.0, 16.4, 12.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 14.5, 535.9, 17.4, 11.6, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 13.6, 354.1, 15.8, 11.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 12.8, 380.9, 15.2, 10.4, 2.9);  // Month - 2015-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 14.0, 494.3, 16.2, 11.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 13.3, 518.0, 17.0, 09.6, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 14.6, 578.7, 21.4, 07.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 17.3, 253.6, 22.8, 11.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 14.7, 485.6, 17.2, 12.2, 3.7);  // Month - 2015-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 10.2, 600.5, 15.0, 05.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 10.6, 614.8, 15.0, 06.1, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 12.3, 535.9, 20.8, 03.8, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 14.7, 203.3, 18.2, 11.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 16.9, 520.8, 19.6, 14.2, 3.6);  // Month - 2015-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 16.7, 634.0, 22.8, 10.6, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 18.4, 591.9, 24.6, 12.2, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 11.2, 634.0, 14.2, 08.2, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 11.9, 320.6, 15.2, 08.6, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 16.5, 344.5, 22.4, 10.5, 3.0);  // Month - 2015-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 18.7, 279.9, 22.2, 15.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 18.0, 514.4, 21.4, 14.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 21.0, 581.3, 26.8, 15.2, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 18.8, 191.4, 20.8, 16.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 14.7, 191.4, 17.8, 11.6, 1.3);  // Month - 2015-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 14.5, 583.7, 17.6, 11.4, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 13.0, 390.0, 18.8, 07.2, 3.6);  // Month - 2015-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 14.4, 583.7, 21.4, 07.4, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 15.8, 423.4, 20.3, 11.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 14.7, 535.9, 19.0, 10.3, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 14.2, 567.0, 19.8, 08.5, 4.0);  // Month - 2015-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 18.3, 665.1, 26.0, 10.6, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 19.1, 679.4, 26.0, 12.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 20.6, 653.1, 27.2, 14.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 22.3, 454.5, 29.2, 15.4, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 21.8, 315.8, 25.4, 18.2, 2.9);  // Month - 2015-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 20.5, 703.3, 25.6, 15.4, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 18.3, 328.7, 24.2, 12.4, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 17.0, 210.5, 20.6, 13.3, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 17.6, 691.4, 23.4, 11.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 23.1, 705.7, 28.8, 17.3, 6.8);  // Month - 2015-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 21.2, 607.7, 26.6, 15.8, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 20.6, 291.9, 23.6, 17.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 18.8, 282.3, 21.0, 16.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 17.3, 208.1, 20.6, 14.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 15.0, 672.2, 19.2, 10.7, 5.1);  // Month - 2015-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 16.2, 703.3, 24.0, 08.4, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 18.6, 638.8, 24.4, 12.8, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 16.7, 296.7, 21.4, 12.0, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 17.8, 703.3, 24.4, 11.2, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 19.2, 724.9, 25.5, 12.8, 6.2);  // Month - 2015-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 19.8, 368.4, 24.8, 14.8, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 20.3, 320.6, 23.5, 17.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 18.1, 734.4, 23.2, 13.0, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 17.3, 744.0, 24.2, 10.4, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 19.1, 744.0, 25.0, 13.2, 6.6);  // Month - 2015-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 22.3, 741.6, 29.0, 15.6, 6.7);  // Month - 2015-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 21.3, 736.8, 26.6, 16.0, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 21.7, 612.4, 28.4, 15.0, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 20.9, 545.5, 24.4, 17.4, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 20.1, 622.0, 23.8, 16.4, 5.0);  // Month - 2015-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 15.3, 705.7, 19.8, 10.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 18.1, 693.8, 27.0, 09.2, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 22.3, 710.5, 29.4, 15.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 21.2, 550.2, 26.8, 15.6, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 23.5, 740.8, 31.6, 15.4, 7.9);  // Month - 2015-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 26.7, 728.8, 33.8, 19.6, 9.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 26.1, 536.0, 31.0, 21.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 25.5, 677.4, 31.0, 20.0, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 22.4, 500.5, 25.4, 19.4, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 21.7, 727.0, 25.9, 17.4, 6.1);  // Month - 2015-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 22.9, 756.1, 31.3, 14.4, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 21.7, 392.9, 25.8, 17.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 21.4, 652.5, 25.0, 17.8, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 17.7, 762.3, 23.2, 12.2, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 19.5, 767.2, 27.4, 11.6, 6.9);  // Month - 2015-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 23.9, 589.5, 30.4, 17.4, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 21.0, 220.2, 22.6, 19.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 22.8, 378.0, 27.4, 18.2, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 23.7, 767.9, 28.4, 19.0, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 23.7, 765.6, 31.2, 16.2, 6.6);  // Month - 2015-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 24.7, 713.5, 31.2, 18.2, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 25.7, 765.9, 32.6, 18.8, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 27.7, 765.2, 34.8, 20.6, 7.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 25.3, 332.1, 30.8, 19.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 24.8, 533.5, 28.4, 21.2, 4.8);  // Month - 2015-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 24.1, 645.9, 29.4, 18.7, 5.9);    

            #endregion
            
        }

        public static void WeatherDataLaEstanzuela_2016(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2016, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationLaEstanzuela
                               select ws).FirstOrDefault();


            #region WeatherData 2016
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 24.5, 528.7, 28.4, 20.6, 4.9);  // Month - 2016-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 27.2, 722.5, 34.6, 19.8, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 24.4, 382.8, 28.8, 20.0, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 23.2, 299.0, 28.3, 18.0, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 24.6, 665.1, 27.4, 21.8, 6.2);  // Month - 2016-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 21.6, 748.8, 24.6, 18.6, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 19.4, 705.5, 25.0, 13.8, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 22.6, 515.7, 28.8, 16.4, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 20.7, 717.7, 24.6, 16.8, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 22.3, 446.8, 27.2, 17.4, 3.8);  // Month - 2016-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 22.9, 713.4, 29.5, 16.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 25.4, 280.8, 31.0, 19.8, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 23.5, 672.7, 28.4, 18.6, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 24.9, 751.8, 32.4, 17.4, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 27.9, 685.7, 38.5, 17.2, 7.1);  // Month - 2016-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 23.6, 677.0, 33.5, 13.6, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 27.8, 499.1, 34.4, 21.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 23.1, 727.4, 27.2, 19.0, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 23.1, 701.9, 31.0, 15.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 24.7, 372.0, 30.4, 19.0, 4.5);  // Month - 2016-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 23.9, 431.3, 28.9, 18.8, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 28.6, 714.3, 35.4, 21.8, 8.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 22.6, 689.0, 26.6, 18.5, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 28.0, 672.1, 37.6, 18.4, 8.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 24.9, 583.1, 29.2, 20.6, 6.3);  // Month - 2016-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 21.0, 697.4, 26.2, 15.8, 5.9);  

            #endregion

        }
        
        #endregion

        #region Salto Grande

        public static void WeatherDataSaltoGrande_2015(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2015, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationSaltoGrande
                               select ws).FirstOrDefault();


            #region WeatherData 2015

            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 20.8, 354.1, 23.3, 18.2, 4.9);  // Month - 2015-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 17.8, 741.6, 23.0, 12.6, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 20.0, 677.0, 28.0, 12.0, 6.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 19.0, 612.4, 22.6, 15.4, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 23.9, 741.6, 32.7, 15.2, 7.5);  // Month - 2015-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 23.2, 241.6, 26.3, 20.0, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 24.1, 523.9, 28.6, 19.5, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 24.8, 729.7, 30.3, 19.4, 6.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 26.7, 583.7, 30.5, 23.0, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 25.5, 672.2, 29.1, 21.8, 5.9);  // Month - 2015-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 26.7, 576.6, 30.1, 23.2, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 28.0, 696.2, 34.3, 21.6, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 21.2, 215.3, 22.4, 20.0, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 23.2, 648.3, 26.4, 20.0, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 22.9, 708.1, 27.4, 18.4, 6.1);  // Month - 2015-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 25.0, 672.2, 30.6, 19.4, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 20.6, 390.0, 23.5, 17.7, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 21.0, 404.3, 26.0, 15.9, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 20.8, 210.5, 22.6, 19.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 19.8, 674.6, 23.6, 15.9, 5.2);  // Month - 2015-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 19.2, 715.3, 24.1, 14.2, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 21.7, 724.9, 27.6, 15.8, 6.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 22.9, 660.3, 28.4, 17.4, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 23.4, 610.0, 28.0, 18.7, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 25.7, 693.8, 31.2, 20.2, 5.9);  // Month - 2015-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 26.9, 454.5, 32.7, 21.0, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(026), 27.9, 516.7, 33.1, 22.6, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(027), 21.1, 514.4, 23.4, 18.7, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(028), 18.1, 705.7, 22.1, 14.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(029), 18.0, 712.9, 24.4, 11.6, 5.2);  // Month - 2015-1-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(030), 21.3, 617.4, 28.0, 14.6, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(031), 23.7, 703.3, 29.4, 18.0, 5.8);  // Month - 2015-2-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(032), 23.8, 665.1, 28.4, 19.2, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(033), 23.8, 507.2, 27.8, 19.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(034), 26.1, 504.8, 31.2, 21.0, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(035), 25.0, 456.9, 29.0, 21.0, 4.5);  // Month - 2015-2-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(036), 25.2, 667.5, 30.8, 19.6, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(037), 24.9, 691.4, 29.8, 20.0, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(038), 24.9, 583.7, 30.6, 19.2, 5.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(039), 25.4, 557.4, 31.2, 19.6, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(040), 22.3, 370.8, 26.6, 18.0, 3.8);  // Month - 2015-2-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(041), 22.7, 679.4, 29.4, 16.0, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(042), 23.7, 629.2, 31.4, 15.9, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(043), 19.6, 669.9, 24.0, 15.1, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(044), 20.3, 622.0, 26.4, 14.2, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(045), 22.4, 600.5, 29.0, 15.8, 5.6);  // Month - 2015-2-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(046), 23.4, 574.2, 28.8, 18.0, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(047), 24.8, 650.7, 31.0, 18.6, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(048), 21.4, 358.9, 24.5, 18.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(049), 19.5, 251.2, 21.8, 17.2, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(050), 17.6, 595.7, 22.6, 12.6, 4.1);  // Month - 2015-2-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(051), 23.2, 490.4, 30.2, 16.2, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(052), 23.6, 645.6, 30.2, 17.0, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(053), 25.0, 634.0, 30.3, 19.6, 5.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(054), 26.8, 593.3, 32.6, 21.0, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(055), 23.2, 191.4, 24.8, 21.6, 2.5);  // Month - 2015-2-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(056), 24.2, 380.4, 27.8, 20.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(057), 19.2, 526.3, 25.1, 13.2, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(058), 19.1, 578.9, 26.4, 11.8, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(059), 21.7, 315.8, 26.8, 16.6, 3.5);  // Month - 2015-3-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(060), 23.9, 540.7, 30.6, 17.2, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(061), 22.0, 174.6, 23.8, 20.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(062), 23.3, 413.9, 26.6, 20.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(063), 23.1, 523.9, 27.0, 19.2, 4.1);  // Month - 2015-3-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(064), 23.3, 578.9, 30.0, 16.6, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(065), 24.7, 586.1, 30.8, 18.6, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(066), 24.4, 576.6, 31.2, 17.6, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(067), 25.1, 564.6, 30.6, 19.5, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(068), 26.1, 521.5, 31.4, 20.8, 4.6);  // Month - 2015-3-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(069), 24.4, 567.0, 30.0, 18.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(070), 25.1, 559.8, 32.0, 18.2, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(071), 24.4, 564.6, 32.0, 16.8, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(072), 24.2, 294.3, 29.3, 19.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(073), 22.1, 471.3, 25.6, 18.6, 3.8);  // Month - 2015-3-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(074), 23.4, 538.3, 30.2, 16.6, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(075), 25.7, 545.5, 32.0, 19.4, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(076), 24.6, 540.7, 32.0, 17.2, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(077), 24.9, 540.7, 31.2, 18.6, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(078), 23.0, 380.4, 30.0, 16.0, 4.6);  // Month - 2015-3-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(079), 11.9, 495.2, 20.0, 03.8, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(080), 16.3, 471.3, 20.4, 12.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(081), 15.1, 471.3, 20.6, 09.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(082), 15.3, 267.9, 20.7, 09.8, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(083), 15.8, 150.7, 18.0, 13.6, 1.4);  // Month - 2015-3-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(084), 16.6, 476.1, 20.6, 12.5, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(085), 15.7, 488.0, 20.8, 10.6, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(086), 17.8, 497.6, 25.0, 10.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(087), 20.4, 478.5, 27.9, 12.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(088), 21.6, 401.9, 28.4, 14.8, 3.5);  // Month - 2015-3-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(089), 18.5, 325.4, 23.8, 13.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(090), 19.2, 485.6, 27.2, 11.2, 3.5);  // Month - 2015-4-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(091), 22.6, 492.8, 30.6, 14.6, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(092), 24.2, 483.3, 30.8, 17.6, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(093), 22.2, 258.4, 24.1, 20.4, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(094), 19.4, 430.6, 22.7, 16.1, 3.4);  // Month - 2015-4-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(095), 16.7, 425.8, 21.4, 12.0, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(096), 18.1, 413.9, 25.0, 11.2, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(097), 19.0, 390.0, 26.1, 12.0, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(098), 21.2, 464.1, 28.4, 13.9, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(099), 22.9, 378.0, 30.0, 15.8, 4.1);  // Month - 2015-4-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(100), 18.9, 277.5, 23.0, 14.9, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(101), 19.4, 437.8, 27.2, 11.5, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(102), 24.3, 387.6, 30.9, 17.7, 4.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(103), 23.6, 291.9, 29.7, 17.6, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(104), 21.0, 289.5, 24.8, 17.2, 2.6);  // Month - 2015-4-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(105), 20.9, 291.9, 25.7, 16.2, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(106), 17.3, 267.9, 20.6, 14.0, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(107), 16.5, 430.6, 22.6, 10.4, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(108), 19.5, 425.8, 26.2, 12.9, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(109), 17.2, 418.7, 21.2, 13.3, 2.4);  // Month - 2015-4-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(110), 16.8, 404.3, 23.0, 10.7, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(111), 16.2, 406.7, 22.0, 10.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(112), 17.8, 409.1, 25.2, 10.4, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(113), 18.5, 404.3, 25.4, 11.6, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(114), 20.7, 378.0, 27.7, 13.6, 3.1);  // Month - 2015-4-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(115), 19.6, 390.0, 26.4, 12.8, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(116), 21.4, 320.6, 27.7, 15.2, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(117), 19.1, 296.7, 23.3, 14.9, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(118), 15.6, 110.0, 16.8, 14.4, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(119), 17.8, 167.5, 21.5, 14.0, 1.8);  // Month - 2015-4-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(120), 17.9, 138.8, 22.2, 13.6, 2.5);  // Month - 2015-5-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(121), 14.7, 107.7, 19.8, 09.5, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(122), 10.6, 344.5, 15.1, 06.0, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(123), 11.8, 361.2, 18.4, 05.3, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(124), 15.6, 346.9, 21.3, 09.9, 2.1);  // Month - 2015-5-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(125), 12.1, 232.1, 15.1, 09.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(126), 10.7, 325.4, 16.9, 04.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(127), 14.0, 332.5, 20.7, 07.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(128), 14.2, 227.3, 20.0, 08.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(129), 15.4, 201.0, 18.2, 12.6, 0.8);  // Month - 2015-5-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(130), 15.0, 189.0, 20.0, 10.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(131), 16.3, 311.0, 19.9, 12.7, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(132), 16.9, 236.8, 21.7, 12.2, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(133), 18.7, 303.8, 24.7, 12.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(134), 18.6, 265.6, 23.2, 14.0, 1.2);  // Month - 2015-5-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(135), 20.8, 315.8, 26.6, 15.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(136), 21.0, 315.8, 26.7, 15.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(137), 22.9, 227.3, 27.7, 18.0, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(138), 21.8, 143.5, 26.4, 17.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(139), 21.3, 289.5, 26.2, 16.4, 2.2);  // Month - 2015-5-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(140), 22.4, 282.3, 26.9, 17.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(141), 23.0, 265.6, 27.9, 18.0, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(142), 18.5, 88.5, 21.0, 16.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(143), 13.8, 212.9, 18.5, 09.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(144), 12.5, 279.9, 18.3, 06.6, 1.2);  // Month - 2015-5-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(145), 13.5, 88.5, 15.9, 11.1, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(146), 15.9, 172.2, 19.1, 12.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(147), 13.6, 282.3, 19.2, 08.0, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(148), 12.9, 177.0, 18.2, 07.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(149), 10.4, 86.1, 14.7, 06.0, 0.6);  // Month - 2015-5-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(150), 13.4, 229.7, 19.6, 07.2, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(151), 15.4, 267.9, 20.8, 10.0, 1.5);  // Month - 2015-6-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(152), 15.3, 258.4, 21.6, 09.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(153), 17.2, 251.2, 21.7, 12.7, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(154), 15.9, 229.7, 22.5, 09.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(155), 20.6, 112.4, 26.7, 14.4, 1.4);  // Month - 2015-6-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(156), 18.0, 107.7, 24.3, 11.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(157), 15.0, 179.4, 19.8, 10.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(158), 14.0, 284.7, 18.9, 09.0, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(159), 13.2, 81.3, 15.9, 10.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(160), 11.0, 193.8, 14.6, 07.4, 0.8);  // Month - 2015-6-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(161), 09.8, 279.9, 14.8, 04.8, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(162), 08.3, 284.7, 16.3, 00.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(163), 08.8, 119.6, 14.7, 02.8, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(164), 10.0, 256.0, 15.3, 04.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(165), 08.3, 275.1, 15.2, 01.4, 2.2);  // Month - 2015-6-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(166), 12.5, 275.1, 20.2, 04.7, 3.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(167), 12.1, 260.8, 16.4, 07.8, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(168), 04.7, 275.1, 09.6, -00.2, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(169), 05.9, 265.6, 12.5, -00.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(170), 08.0, 244.0, 14.8, 01.2, 1.2);  // Month - 2015-6-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(171), 09.8, 256.0, 17.5, 02.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(172), 07.7, 78.9, 11.6, 03.7, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(173), 06.5, 256.0, 10.3, 02.6, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(174), 07.5, 267.9, 13.7, 01.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(175), 18.4, 160.3, 23.5, 13.2, 2.3);  // Month - 2015-6-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(176), 16.6, 234.4, 20.6, 12.6, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(177), 17.7, 86.1, 20.5, 14.8, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(178), 16.8, 81.3, 17.5, 16.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(179), 16.8, 86.1, 19.0, 14.6, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(180), 13.5, 256.0, 16.9, 10.0, 0.7);  // Month - 2015-6-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(181), 10.6, 186.6, 13.8, 07.4, 0.8);  // Month - 2015-7-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(182), 11.8, 212.9, 16.5, 07.0, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(183), 07.6, 81.3, 11.0, 04.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(184), 07.3, 270.3, 11.0, 03.5, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(185), 07.5, 272.7, 13.9, 01.0, 1.1);  // Month - 2015-7-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(186), 11.4, 191.4, 15.8, 07.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(187), 11.0, 224.9, 16.9, 05.0, 0.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(188), 11.4, 272.7, 19.1, 03.6, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(189), 11.7, 167.5, 17.2, 06.2, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(190), 13.0, 88.5, 16.1, 09.8, 0.8);  // Month - 2015-7-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(191), 13.1, 88.5, 15.1, 11.0, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(192), 15.3, 122.0, 19.4, 11.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(193), 11.4, 83.7, 15.5, 07.3, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(194), 08.8, 294.3, 13.3, 04.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(195), 07.6, 294.3, 14.3, 00.8, 1.1);  // Month - 2015-7-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(196), 08.6, 181.8, 14.6, 02.6, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(197), 09.8, 287.1, 18.0, 01.6, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(198), 14.2, 239.2, 18.7, 09.7, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(199), 12.6, 138.8, 16.6, 08.5, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(200), 06.3, 244.0, 11.1, 01.4, 0.9);  // Month - 2015-7-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(201), 05.8, 279.9, 12.1, -00.6, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(202), 09.0, 311.0, 15.5, 02.4, 1.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(203), 10.5, 167.5, 17.4, 03.5, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(204), 09.6, 308.6, 16.7, 02.4, 0.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(205), 12.6, 217.7, 18.6, 06.5, 1.1);  // Month - 2015-7-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(206), 16.0, 308.6, 20.7, 11.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(207), 15.9, 299.0, 21.6, 10.2, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(208), 20.7, 241.6, 27.3, 14.0, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(209), 15.6, 95.7, 18.9, 12.3, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(210), 15.6, 95.7, 19.4, 11.8, 1.3);  // Month - 2015-7-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(211), 13.8, 248.8, 19.1, 08.4, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(212), 12.3, 205.7, 17.9, 06.6, 1.6);  // Month - 2015-8-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(213), 15.9, 189.0, 18.8, 12.9, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(214), 14.7, 287.1, 18.2, 11.2, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(215), 12.8, 282.3, 17.2, 08.4, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(216), 14.6, 117.2, 20.2, 09.0, 2.2);  // Month - 2015-8-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(217), 17.3, 155.5, 20.5, 14.1, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(218), 17.4, 100.5, 21.4, 13.4, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(219), 20.0, 138.8, 26.6, 13.4, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(220), 20.9, 124.4, 26.6, 15.2, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(221), 12.0, 157.9, 15.9, 08.0, 0.9);  // Month - 2015-8-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(222), 11.5, 177.0, 15.4, 07.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(223), 13.0, 105.3, 14.0, 12.0, 1.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(224), 13.6, 107.7, 14.6, 12.6, 0.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(225), 11.9, 107.7, 12.6, 11.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(226), 14.4, 346.9, 19.2, 09.6, 1.7);  // Month - 2015-8-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(227), 13.0, 239.2, 16.6, 09.4, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(228), 14.1, 110.0, 19.0, 09.2, 0.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(229), 15.1, 236.8, 19.0, 11.2, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(230), 12.0, 174.6, 13.8, 10.2, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(231), 12.9, 241.6, 17.0, 08.8, 1.6);  // Month - 2015-8-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(232), 14.9, 392.3, 20.4, 09.4, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(233), 16.0, 241.6, 20.6, 11.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(234), 09.6, 241.6, 12.0, 07.1, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(235), 10.9, 404.3, 15.6, 06.2, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(236), 12.6, 272.7, 18.6, 06.5, 2.4);  // Month - 2015-8-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(237), 15.4, 234.4, 17.4, 13.4, 1.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(238), 13.3, 390.0, 18.2, 08.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(239), 15.1, 301.4, 22.4, 07.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(240), 19.4, 370.8, 24.6, 14.2, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(241), 18.4, 380.4, 23.2, 13.5, 2.1);  // Month - 2015-8-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(242), 14.8, 401.9, 19.4, 10.1, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(243), 10.3, 406.7, 12.6, 08.0, 2.8);  // Month - 2015-9-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(244), 09.9, 179.4, 15.4, 04.3, 1.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(245), 10.8, 401.9, 15.2, 06.4, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(246), 11.4, 437.8, 18.4, 04.4, 2.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(247), 13.5, 454.5, 19.8, 07.2, 2.6);  // Month - 2015-9-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(248), 13.4, 466.5, 20.4, 06.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(249), 12.2, 167.5, 16.8, 07.6, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(250), 15.4, 445.0, 20.2, 10.5, 2.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(251), 10.6, 136.4, 13.9, 07.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(252), 09.2, 416.3, 13.4, 05.0, 3.1);  // Month - 2015-9-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(253), 06.8, 480.9, 10.2, 03.4, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(254), 10.3, 417.9, 15.4, 05.1, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(255), 12.4, 488.0, 20.2, 04.6, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(256), 16.2, 461.7, 24.2, 08.1, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(257), 18.7, 454.5, 24.2, 13.2, 4.7);  // Month - 2015-9-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(258), 11.0, 416.3, 15.4, 06.6, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(259), 12.1, 464.1, 17.7, 06.5, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(260), 11.5, 502.4, 17.0, 06.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(261), 13.8, 421.1, 21.4, 06.2, 2.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(262), 14.6, 339.7, 20.0, 09.2, 3.1);  // Month - 2015-9-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(263), 14.5, 150.7, 16.2, 12.8, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(264), 12.9, 150.7, 13.6, 12.2, 1.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(265), 13.7, 153.1, 14.6, 12.8, 1.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(266), 13.8, 153.1, 14.4, 13.2, 1.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(267), 12.8, 224.9, 15.4, 10.2, 1.6);  // Month - 2015-9-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(268), 13.1, 277.5, 16.2, 10.0, 1.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(269), 14.5, 512.0, 21.4, 07.5, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(270), 12.7, 157.9, 15.8, 09.6, 2.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(271), 14.0, 526.3, 18.8, 09.2, 3.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(272), 11.7, 543.1, 17.2, 06.2, 3.2);  // Month - 2015-9-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(273), 15.4, 411.5, 23.4, 07.4, 3.3);  // Month - 2015-10-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(274), 09.9, 162.7, 13.4, 06.4, 1.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(275), 08.4, 502.4, 12.0, 04.7, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(276), 11.8, 502.4, 16.4, 07.2, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(277), 14.3, 390.0, 20.6, 07.9, 3.2);  // Month - 2015-10-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(278), 16.0, 356.5, 18.6, 13.4, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(279), 14.6, 311.0, 16.4, 12.8, 2.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(280), 14.5, 535.9, 17.4, 11.6, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(281), 13.6, 354.1, 15.8, 11.4, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(282), 12.8, 380.9, 15.2, 10.4, 2.9);  // Month - 2015-10-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(283), 14.0, 494.3, 16.2, 11.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(284), 13.3, 518.0, 17.0, 09.6, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(285), 14.6, 578.7, 21.4, 07.8, 4.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(286), 17.3, 253.6, 22.8, 11.8, 3.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(287), 14.7, 485.6, 17.2, 12.2, 3.7);  // Month - 2015-10-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(288), 10.2, 600.5, 15.0, 05.4, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(289), 10.6, 614.8, 15.0, 06.1, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(290), 12.3, 535.9, 20.8, 03.8, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(291), 14.7, 203.3, 18.2, 11.2, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(292), 16.9, 520.8, 19.6, 14.2, 3.6);  // Month - 2015-10-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(293), 16.7, 634.0, 22.8, 10.6, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(294), 18.4, 591.9, 24.6, 12.2, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(295), 11.2, 634.0, 14.2, 08.2, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(296), 11.9, 320.6, 15.2, 08.6, 3.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(297), 16.5, 344.5, 22.4, 10.5, 3.0);  // Month - 2015-10-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(298), 18.7, 279.9, 22.2, 15.2, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(299), 18.0, 514.4, 21.4, 14.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(300), 21.0, 581.3, 26.8, 15.2, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(301), 18.8, 191.4, 20.8, 16.8, 1.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(302), 14.7, 191.4, 17.8, 11.6, 1.3);  // Month - 2015-10-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(303), 14.5, 583.7, 17.6, 11.4, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(304), 13.0, 390.0, 18.8, 07.2, 3.6);  // Month - 2015-11-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(305), 14.4, 583.7, 21.4, 07.4, 4.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(306), 15.8, 423.4, 20.3, 11.2, 3.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(307), 14.7, 535.9, 19.0, 10.3, 4.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(308), 14.2, 567.0, 19.8, 08.5, 4.0);  // Month - 2015-11-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(309), 18.3, 665.1, 26.0, 10.6, 5.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(310), 19.1, 679.4, 26.0, 12.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(311), 20.6, 653.1, 27.2, 14.0, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(312), 22.3, 454.5, 29.2, 15.4, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(313), 21.8, 315.8, 25.4, 18.2, 2.9);  // Month - 2015-11-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(314), 20.5, 703.3, 25.6, 15.4, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(315), 18.3, 328.7, 24.2, 12.4, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(316), 17.0, 210.5, 20.6, 13.3, 2.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(317), 17.6, 691.4, 23.4, 11.8, 4.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(318), 23.1, 705.7, 28.8, 17.3, 6.8);  // Month - 2015-11-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(319), 21.2, 607.7, 26.6, 15.8, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(320), 20.6, 291.9, 23.6, 17.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(321), 18.8, 282.3, 21.0, 16.6, 2.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(322), 17.3, 208.1, 20.6, 14.0, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(323), 15.0, 672.2, 19.2, 10.7, 5.1);  // Month - 2015-11-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(324), 16.2, 703.3, 24.0, 08.4, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(325), 18.6, 638.8, 24.4, 12.8, 5.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(326), 16.7, 296.7, 21.4, 12.0, 3.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(327), 17.8, 703.3, 24.4, 11.2, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(328), 19.2, 724.9, 25.5, 12.8, 6.2);  // Month - 2015-11-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(329), 19.8, 368.4, 24.8, 14.8, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(330), 20.3, 320.6, 23.5, 17.0, 2.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(331), 18.1, 734.4, 23.2, 13.0, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(332), 17.3, 744.0, 24.2, 10.4, 6.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(333), 19.1, 744.0, 25.0, 13.2, 6.6);  // Month - 2015-11-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(334), 22.3, 741.6, 29.0, 15.6, 6.7);  // Month - 2015-12-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(335), 21.3, 736.8, 26.6, 16.0, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(336), 21.7, 612.4, 28.4, 15.0, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(337), 20.9, 545.5, 24.4, 17.4, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(338), 20.1, 622.0, 23.8, 16.4, 5.0);  // Month - 2015-12-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(339), 15.3, 705.7, 19.8, 10.8, 5.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(340), 18.1, 693.8, 27.0, 09.2, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(341), 22.3, 710.5, 29.4, 15.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(342), 21.2, 550.2, 26.8, 15.6, 5.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(343), 23.5, 740.8, 31.6, 15.4, 7.9);  // Month - 2015-12-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(344), 26.7, 728.8, 33.8, 19.6, 9.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(345), 26.1, 536.0, 31.0, 21.2, 5.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(346), 25.5, 677.4, 31.0, 20.0, 6.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(347), 22.4, 500.5, 25.4, 19.4, 4.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(348), 21.7, 727.0, 25.9, 17.4, 6.1);  // Month - 2015-12-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(349), 22.9, 756.1, 31.3, 14.4, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(350), 21.7, 392.9, 25.8, 17.6, 3.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(351), 21.4, 652.5, 25.0, 17.8, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(352), 17.7, 762.3, 23.2, 12.2, 5.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(353), 19.5, 767.2, 27.4, 11.6, 6.9);  // Month - 2015-12-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(354), 23.9, 589.5, 30.4, 17.4, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(355), 21.0, 220.2, 22.6, 19.3, 2.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(356), 22.8, 378.0, 27.4, 18.2, 3.7);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(357), 23.7, 767.9, 28.4, 19.0, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(358), 23.7, 765.6, 31.2, 16.2, 6.6);  // Month - 2015-12-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(359), 24.7, 713.5, 31.2, 18.2, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(360), 25.7, 765.9, 32.6, 18.8, 7.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(361), 27.7, 765.2, 34.8, 20.6, 7.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(362), 25.3, 332.1, 30.8, 19.8, 3.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(363), 24.8, 533.5, 28.4, 21.2, 4.8);  // Month - 2015-12-30
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(364), 24.1, 645.9, 29.4, 18.7, 5.9);

            #endregion

        }

        public static void WeatherDataSaltoGrande_2016(IrrigationAdvisorContext context)
        {
            WeatherStation lWeatherStation = null;
            DateTime lFirstDay = new DateTime(2016, 1, 1);

            lWeatherStation = (from ws in context.WeatherStations
                               where ws.Name == Utils.NameWeatherStationSaltoGrande
                               select ws).FirstOrDefault();


            #region WeatherData 2016
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(000), 24.5, 528.7, 28.4, 20.6, 4.9);  // Month - 2016-1-1
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(001), 27.2, 722.5, 34.6, 19.8, 7.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(002), 24.4, 382.8, 28.8, 20.0, 4.3);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(003), 23.2, 299.0, 28.3, 18.0, 2.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(004), 24.6, 665.1, 27.4, 21.8, 6.2);  // Month - 2016-1-5
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(005), 21.6, 748.8, 24.6, 18.6, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(006), 19.4, 705.5, 25.0, 13.8, 5.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(007), 22.6, 515.7, 28.8, 16.4, 4.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(008), 20.7, 717.7, 24.6, 16.8, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(009), 22.3, 446.8, 27.2, 17.4, 3.8);  // Month - 2016-1-10
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(010), 22.9, 713.4, 29.5, 16.2, 5.8);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(011), 25.4, 280.8, 31.0, 19.8, 4.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(012), 23.5, 672.7, 28.4, 18.6, 6.4);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(013), 24.9, 751.8, 32.4, 17.4, 7.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(014), 27.9, 685.7, 38.5, 17.2, 7.1);  // Month - 2016-1-15
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(015), 23.6, 677.0, 33.5, 13.6, 6.2);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(016), 27.8, 499.1, 34.4, 21.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(017), 23.1, 727.4, 27.2, 19.0, 6.5);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(018), 23.1, 701.9, 31.0, 15.2, 6.6);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(019), 24.7, 372.0, 30.4, 19.0, 4.5);  // Month - 2016-1-20
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(020), 23.9, 431.3, 28.9, 18.8, 4.9);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(021), 28.6, 714.3, 35.4, 21.8, 8.0);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(022), 22.6, 689.0, 26.6, 18.5, 6.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(023), 28.0, 672.1, 37.6, 18.4, 8.1);
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(024), 24.9, 583.1, 29.2, 20.6, 6.3);  // Month - 2016-1-25
            lWeatherStation.AddWeatherDataToList(lFirstDay.AddDays(025), 21.0, 697.4, 26.2, 15.8, 5.9);

            #endregion

        }

        #endregion

        
        #endregion

        #region CropIrrigationWeather

        #endregion

        #region RainData

        #region Santa Lucia

        #endregion

        #region La Perdiz
        /// <summary>
        /// Add rain data to Farm La Perdiz in Pivot 2 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataLaPerdizPivot2_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 01), 31);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 20), 30);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 52);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 20), 6.5);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 4.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 04), 4.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 65);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 10);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 40);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 60);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 05), 7.0);

        }

        /// <summary>
        /// Add rain data to Farm La Perdiz in Pivot 3 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataLaPerdizPivot3_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                        where farm.Name == Utils.NameFarmLaPerdiz
                        select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                        where crop.Name == Utils.NameSpecieCornSouthShort
                        select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                        where iu.Name == Utils.NamePivotLaPerdiz3
                        select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                where ws.Name == Utils.NameWeatherStationLasBrujas
                                select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 01), 31);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 20), 30);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 52);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 20), 6.5);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 4.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 04), 4.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 65);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 10);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 40);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 60);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 05), 7.0);

        }

        /// <summary>
        /// Add rain data to Farm La Perdiz in Pivot 5 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataLaPerdizPivot5_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();



            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 01), 31);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 20), 30);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 52);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 20), 6.5);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 4.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 04), 4.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 65);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 10);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 40);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 60);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 05), 7.0);

        }

        #endregion

        #region Del Lago - San Pedro

        public static void AddRainDataDelLagoSanPedroPivot5_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 11), 5.6); 
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 12), 6.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 14), 5.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        public static void AddRainDataDelLagoSanPedroPivot6_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        public static void AddRainDataDelLagoSanPedroPivot7_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro7
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 14), 5.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        public static void AddRainDataDelLagoSanPedroPivot8_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro8
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 7), 4.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 11), 5.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 12), 6.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 14), 5.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        #endregion

        #region Del Lago - El Mirador

        public static void AddRainDataDelLagoElMiradorPivot6_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4); 
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        public static void AddRainDataDelLagoElMiradorPivot7_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            //lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            //lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        public static void AddRainDataDelLagoElMiradorPivot8_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            //lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            //lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        public static void AddRainDataDelLagoElMiradorPivot9_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 14), 5.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 18), 19.2);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 26), 15.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 12), 25.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 17), 8.4);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 6.8);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 5), 22.6);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 41);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 36);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 43);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 39);

        }

        #endregion

        #region La Palma

        public static void AddRainDataLaPalmaPivot2A_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPalma2A
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 20), 30);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 29), 6.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 17);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 14), 8.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 87);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 13);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 35);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 23), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 29), 60);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 15);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 04), 6.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 05), 12);

        }

        public static void AddRainDataLaPalmaPivot3_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPalma3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 20), 30);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 29), 6.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 17);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 14), 8.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 87);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 13);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 35);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 23), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 29), 60);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 15);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 04), 6.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 05), 12);
        }

        public static void AddRainDataLaPalmaPivot4_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPalma4
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 09, 22), 17);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 09, 23), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 09, 24), 15);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 02), 35);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 07), 8.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 11), 5.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 20), 30);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 10, 29), 6.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 19), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 27), 17);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 17), 87);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 21), 13);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 22), 35);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 23), 20);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 29), 60);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 12, 30), 15);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 04), 6.0);
            lCropIrrigationWeather.AddRainDataToList(new DateTime(2016, 01, 05), 12);

        }

        #endregion

        public static void AddRainData(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 1), 10 );

        }

        #endregion

        #region IrrigationData

        /// <summary>
        /// Add Irrigation Data to La Perdiz Pivot 2 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaPerdizPivot2_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz2
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lIsExtraIrrigation = true;

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

        }

        /// <summary>
        /// Add Irrigation Data to La Perdiz Pivot 3 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaPerdizPivot3_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz3
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();
            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lIsExtraIrrigation = true;
            
            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            
            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            
            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            
            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, 
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            
        }

        /// <summary>
        /// Add Irrigation Data to La Perdiz Pivot 5 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaPerdizPivot5_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz5
                               select iu).FirstOrDefault();
            lWeatherStationMain = (from ws in context.WeatherStations
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lIsExtraIrrigation = true;

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6.2, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

            lIrrigationDate = new DateTime(2015, 11, 24);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6.2, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);

            lIrrigationDate = new DateTime(2015, 12, 2);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            
        }

        #endregion

        #region PhenologicalStage

        public static void AddPhenologicalStageAdjustementsLaPerdizPivot2_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz2
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
            lObservation = "Real Stage is "  + lStageToChange.Name 
                + ", " + lStageToChange.Description + "." ;
            lName = "Adjustement " + lStageToChange.Name + " "
                                                + lDateTimeToChange.ToString();
            
            lCropIrrigationWeather.AddPhenologicalStageAdjustmentToList(lName, lCrop, lDateTimeToChange, 
                                                            lStageToChange, lPhenologicalStage, lObservation);

        }

        public static void AddPhenologicalStageAdjustementsLaPerdizPivot3_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz3
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
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz5
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

        #region Information To IrrigationUnits

        #region La Perdiz

        /// <summary>
        /// Add Information To IrrigationUnits - LaPerdiz Pivot 2 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPerdizPivot2_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                        where farm.Name == Utils.NameFarmLaPerdiz
                        select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                        where crop.Name == Utils.NameSpecieCornSouthShort
                        select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                                where iu.Name == Utils.NamePivotLaPerdiz2
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
                     where soil.Name == Utils.NameSoilLaPerdiz2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz2)
                            select horizon).ToList<Horizon>();
            
            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
                        break;
                    }
                }
                //Stop when arrives to final Stage
                if(lCropIrrigationWeather.PhenologicalStage.Stage.StageId == lCrop.StopIrrigationStageId)
                {
                    break;
                }
            }
            context.SaveChanges();
            #region Print - Messages
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - LaPerdiz Pivot 3 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPerdizPivot3_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz3
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
                     where soil.Name == Utils.NameSoilLaPerdiz3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz3)
                            select horizon)
                            .ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - LaPerdiz Pivot 5 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPerdizPivot5_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPerdiz5
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
                     where soil.Name == Utils.NameSoilLaPerdiz5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaPerdiz5)
                            select horizon)
                            .ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation);

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPerdiz)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId);
                }
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

        #region Del Lago - San Pedro

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 5 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot5_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro5
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
                     where soil.Name == Utils.NameSoilDelLagoSanPedro5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro5)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 6 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot6_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro6
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
                     where soil.Name == Utils.NameSoilDelLagoSanPedro6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro6)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 6 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot7_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro7
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
                     where soil.Name == Utils.NameSoilDelLagoSanPedro7
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro7)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 8 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot8_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro8
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
                     where soil.Name == Utils.NameSoilDelLagoSanPedro8
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro8)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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

        #region Del Lago - El Mirador

        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 6 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
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
                     where soil.Name == Utils.NameSoilDelLagoElMirador6
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 7 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
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
                     where soil.Name == Utils.NameSoilDelLagoElMirador7
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 8 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
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
                     where soil.Name == Utils.NameSoilDelLagoElMirador8
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 9 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
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
                     where soil.Name == Utils.NameSoilDelLagoElMirador9
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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

        #region La Palma

        /// <summary>
        /// Add Information To IrrigationUnits - LaPalma Pivot 2A 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPalmaPivot2A_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPalma2A
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
                     where soil.Name == Utils.NameSoilLaPalma2A
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaPalma2A)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - LaPalma Pivot 3 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPalmaPivot3_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPalma3
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
                     where soil.Name == Utils.NameSoilLaPalma3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaPalma3)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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
        /// Add Information To IrrigationUnits - LaPalma Pivot 4 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPalmaPivot4_2015(IrrigationAdvisorContext context)
        {
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPalma4
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
                     where soil.Name == Utils.NameSoilLaPalma4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotLaPalma4)
                            select horizon).ToList<Horizon>();

            //The start day is one day after sowing 
            //because the first day is created when the testCrop is created
            lFromDate = lSowingDate.AddDays(1);
            if (lHarvestDate > DateTime.Now)
            {
                lToDate = DateTime.Now.AddDays(7);
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

                //Adjustment of Phenological Stage
                foreach (PhenologicalStageAdjustment item in lCropIrrigationWeather.PhenologicalStageAdjustmentList)
                {
                    if (item.DateOfChange.Equals(lDateOfRecord))
                    {
                        lCropIrrigationWeather.AdjustmentPhenology(item.Stage, item.DateOfChange);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.LaPalma)
            {
                long lFirstTitleId = (from title in context.Titles
                                      where title.Name == "DDS"
                                          && title.Daily == false
                                          && title.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                      select title.TitleId).FirstOrDefault();
                long lTotalTitles = lCropIrrigationWeather.Titles.Count();
                long lTitleId = lFirstTitleId;
                long lMessageId = 0;
                if (context.Messages.Count() > 0)
                {
                    lMessageId = context.Messages.Max(m => m.MessageId) + 1;
                }
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

    }
}
