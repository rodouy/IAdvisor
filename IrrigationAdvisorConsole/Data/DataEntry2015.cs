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

namespace IrrigationAdvisorConsole.Data
{

    public static class DataEntry2015
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

        public static double BaseTemperature_SorghumForageSouth_2015 = 8;
        public static double StressTemperature_SorghumForageSouth_2015 = 35;
        public static double BaseTemperature_SorghumForageNorth_2015 = 8;
        public static double StressTemperature_SorghumForageNorth_2015 = 35;

        public static double BaseTemperature_SorghumGrainSouth_2015 = 8;
        public static double StressTemperature_SorghumGrainSouth_2015 = 35;
        public static double BaseTemperature_SorghumGrainNorth_2015 = 8;
        public static double StressTemperature_SorghumGrainNorth_2015 = 35;

        public static double BaseTemperature_AlfalfaSouth_2015 = 8;
        public static double StressTemperature_AlfalfaSouth_2015 = 35;
        public static double BaseTemperature_AlfalfaNorth_2015 = 8;
        public static double StressTemperature_AlfalfaNorth_2015 = 35;

        public static double BaseTemperature_RedCloverForageSouth_2015 = 8;
        public static double StressTemperature_RedCloverForageSouth_2015 = 35;
        public static double BaseTemperature_RedCloverForageNorth_2015 = 8;
        public static double StressTemperature_RedCloverForageNorth_2015 = 35;

        public static double BaseTemperature_RedCloverSeedSouth_2015 = 8;
        public static double StressTemperature_RedCloverSeedSouth_2015 = 35;
        public static double BaseTemperature_RedCloverSeedNorth_2015 = 8;
        public static double StressTemperature_RedCloverSeedNorth_2015 = 35;

        public static double BaseTemperature_FescueForageSouth_2015 = 8;
        public static double StressTemperature_FescueForageSouth_2015 = 35;
        public static double BaseTemperature_FescueForageNorth_2015 = 8;
        public static double StressTemperature_FescueForageNorth_2015 = 35;

        public static double BaseTemperature_FescueSeedSouth_2015 = 8;
        public static double StressTemperature_FescueSeedSouth_2015 = 35;
        public static double BaseTemperature_FescueSeedNorth_2015 = 8;
        public static double StressTemperature_FescueSeedNorth_2015 = 35;

        #endregion

        #region CropIrrigationWeather

        #region Demo1 - La Perdiz
        public static DateTime SowingDate_CornSouth_Demo1Pivot11_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo1Pivot11_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo1Pivot12_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo1Pivot12_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo1Pivot13_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo1Pivot13_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo1Pivot15_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo1Pivot15_2015 = 15;
        #endregion

        #region Demo2 - Santa Lucia
        public static DateTime SowingDate_CornSouth_Demo2Pivot21_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo2Pivot21_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo2Pivot22_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo2Pivot22_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo2Pivot23_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo2Pivot23_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo2Pivot24_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo2Pivot24_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo2Pivot25_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo2Pivot25_2015 = 15;
        #endregion

        #region Demo3 - La Palma
        public static DateTime SowingDate_CornSouth_Demo3Pivot31_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo3Pivot31_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo3Pivot32A_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo3Pivot32A_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo3Pivot33_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo3Pivot33_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo3Pivot34_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo3Pivot34_2015 = 15;
        public static DateTime SowingDate_CornSouth_Demo3Pivot35_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_Demo3Pivot35_2015 = 15;
        #endregion

        #region Santa Lucia
        public static DateTime SowingDate_CornSouth_SantaLuciaPivot1_2015 = new DateTime(2015, 10, 01);
        public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2015 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot2_2015 = new DateOfData(2015, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot2_2015 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot3_2015 = new DateOfData(2015, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot3_2015 = 15;
        //public static DateOfData SowingDate_CornSouth_SantaLuciaPivot5_2015 = new DateOfData(2015, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_SantaLuciaPivot5_2015 = 15;
        #endregion

        #region DCA - La Perdiz
        //2015 Pivot 1 was not used
        //public static DateOfData SowingDate_CornSouth_LaPerdizPivot1_2015 = new DateOfData(2015, 9, 16);
        //public static Double PredeterminatedIrrigationQuantity_LaPerdizPivot1_2015 = 15;
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

        #region GMO - La Palma
        public static DateTime SowingDate_CornSouth_LaPalmaPivot2A_2015 = new DateTime(2015, 10, 15);
        public static Double PredeterminatedIrrigationQuantity_LaPalmaPivot2A_2015 = 15;
        public static DateTime SowingDate_CornSouth_LaPalmaPivot3_2015 = new DateTime(2015, 10, 15);
        public static Double PredeterminatedIrrigationQuantity_LaPalmaPivot3_2015 = 15;
        public static DateTime SowingDate_CornSouth_LaPalmaPivot4_2015 = new DateTime(2015, 9, 16);
        public static Double PredeterminatedIrrigationQuantity_LaPalmaPivot4_2015 = 15;
        #endregion

        #endregion

        #endregion

        #region RainData

        #region Demo - La Perdiz

        /// <summary>
        /// Add rainQuantity data to Farm Demo - La Perdiz in Pivot 1 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDemoPivot1_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo11
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
        /// Add rainQuantity data to Farm Demo - La Perdiz in Pivot 2 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDemoPivot2_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo12
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
        /// Add rainQuantity data to Farm Demo - La Perdiz in Pivot 3 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDemoPivot3_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

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
        /// Add rainQuantity data to Farm Demo - La Perdiz in Pivot 5 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDemoPivot5_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

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

        #region Santa Lucia

        #endregion

        #region DCA El Paraiso

        #endregion

        #region DCA San Jose

        #endregion

        #region DCA La Perdiz

        #region 2015
        /// <summary>
        /// Add rainQuantity data to Farm La Perdiz in Pivot 2 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDCALaPerdizPivot2_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

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
        /// Add rainQuantity data to Farm La Perdiz in Pivot 3 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDCALaPerdizPivot3_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

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
        /// Add rainQuantity data to Farm La Perdiz in Pivot 5 for 2015
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainDataDCALaPerdizPivot5_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

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

        #endregion

        #region Del Lago - San Pedro

        #region 2015

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

        #endregion

        #region Del Lago - El Mirador

        #region 2015
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

            //lCropIrrigationWeather.AddRainDataToList(new DateOfData(2015, 10, 18), 19.2);
            //lCropIrrigationWeather.AddRainDataToList(new DateOfData(2015, 10, 26), 15.4);
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

            //lCropIrrigationWeather.AddRainDataToList(new DateOfData(2015, 10, 18), 19.2);
            //lCropIrrigationWeather.AddRainDataToList(new DateOfData(2015, 10, 26), 15.4);
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

        #endregion

        #region GMO - La Palma

        #region 2015
        public static void AddRainDataLaPalmaPivot2A_2015(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
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
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
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
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
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

        #endregion

        #region GMO - El Tacuru

        #endregion

        /// <summary>
        /// Example for Add RainQuantity Data
        /// </summary>
        /// <param name="context"></param>
        public static void AddRainData(IrrigationAdvisorContext context)
        {
            CropIrrigationWeather lCropIrrigationWeather;
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            WeatherStation lWeatherStationMain;

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
                                   where ws.Name == DataEntry.WeatherStationMainName_DCALaPerdiz_2016
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 1), 10);

        }

        #endregion

        #region IrrigationData

        #region Demo - La Perdiz

        /// <summary>
        /// Add IrrigationQuantity Data to Demo - La Perdiz Pivot 1 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDemoPivot1_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo11
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
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        /// <summary>
        /// Add IrrigationQuantity Data to Demo - La Perdiz Pivot 2 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDemoPivot2_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo12
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
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Perdiz Pivot 3 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDemoPivot3_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

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
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Perdiz Pivot 5 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDemoPivot5_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

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
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6.2, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 24);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6.2, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 2);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        #endregion

        #region DCA El Paraiso

        #endregion

        #region DCA San Jose

        #endregion

        #region DCA La Perdiz

        #region 2015
        /// <summary>
        /// Add IrrigationQuantity Data to La Perdiz Pivot 2 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot2_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

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
            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lIsExtraIrrigation = true;
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Perdiz Pivot 3 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot3_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lIsExtraIrrigation = true;
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 26);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 3);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Perdiz Pivot 5 for 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot5_2015(IrrigationAdvisorContext context)
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
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            lIrrigationList = (from ilist in context.Irrigations
                               where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                               select ilist).ToList<Irrigation>();
            lRainList = (from rlist in context.Rains
                         where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                         select rlist).ToList<Rain>();

            lIsExtraIrrigation = true;
            lReason = Utils.NoIrrigationReason.Other;
            lObservations = "Add Irrigation OK.";

            lIrrigationDate = new DateTime(2015, 10, 29);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(9, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 17);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6.2, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 11, 24);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(6.2, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

            lIrrigationDate = new DateTime(2015, 12, 2);
            lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(15, Utils.WaterInputType.Irrigation);
            lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate,
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);

        }

        #endregion

        #endregion

        #region Del Lago - El Mirador

        #endregion

        #region GMO - La Palma

        #endregion

        #region GMO - El Tacuru

        #endregion

        #endregion

        #region PhenologicalStage

        #region Demo - La Perdiz
        /// <summary>
        /// Add PhenologicalStage Adjustments to Demo - La Perdiz Pivot 1
        /// </summary>
        /// <param name="context"></param>
        public static void AddPhenologicalStageAdjustementsDemoPivot1_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo11
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

        /// <summary>
        /// Add PhenologicalStage Adjustments to Demo - La Perdiz Pivot 2
        /// </summary>
        /// <param name="context"></param>
        public static void AddPhenologicalStageAdjustementsDemoPivot2_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmDemo1
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDemo12
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

        /// <summary>
        /// Add PhenologicalStage Adjustments to Demo - La Perdiz Pivot 3
        /// </summary>
        /// <param name="context"></param>
        public static void AddPhenologicalStageAdjustementsDemoPivot3_2015(IrrigationAdvisorContext context)
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

        /// <summary>
        /// Add PhenologicalStage Adjustments to Demo - La Perdiz Pivot 5
        /// </summary>
        /// <param name="context"></param>
        public static void AddPhenologicalStageAdjustementsDemoPivot5_2015(IrrigationAdvisorContext context)
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

        #region DCA La Perdiz
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.Demo)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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

        #region 2015
        #endregion

        #endregion

        #region DCA San Jose

        #region 2015

        #endregion

        #endregion

        #region DCA La Perdiz

        #region 2015
        /// <summary>
        /// Add Information To IrrigationUnits - La Perdiz Pivot 2 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPerdizPivot2_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz2
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
                                    where (weatherdata.Date >= lSowingDate &&
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
                     where soil.Name == Utils.NameSoilDCALaPerdiz2
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz2)
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
        /// Add Information To IrrigationUnits - La Perdiz Pivot 3 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPerdizPivot3_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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
                     where soil.Name == Utils.NameSoilDCALaPerdiz3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz3)
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                lObservation = "";
            }
            #endregion
        }

        /// <summary>
        /// Add Information To IrrigationUnits - La Perdiz Pivot 5 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPerdizPivot5_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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
                     where soil.Name == Utils.NameSoilDCALaPerdiz5
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz5)
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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

        #region 2015
        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 5 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot5_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
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
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 6 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot6_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
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
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 6 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot7_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
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
        /// Add Information To IrrigationUnits - Del Lago - San Pedro Pivot 8 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoSanPedroPivot8_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoSanPedro)
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

        #region Del Lago - El Mirador

        #region 2015
        /// <summary>
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 6 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
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
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 7 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
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
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 8 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
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
        /// Add Information To IrrigationUnits - Del Lago - El Mirador Pivot 9 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2015(IrrigationAdvisorContext context)
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
            if (Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.All || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.DelLagoElMirador)
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

        #region 2015
        /// <summary>
        /// Add Information To IrrigationUnits - LaPalma Pivot 2A 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPalmaPivot2A_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
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
                                    where (weatherdata.Date >= lSowingDate &&
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
                || Program.PrintFarm == Utils.IrrigationAdvisorOutputFiles.GMO
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
        /// Add Information To IrrigationUnits - LaPalma Pivot 3 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPalmaPivot3_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
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
                                    where (weatherdata.Date >= lSowingDate &&
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
                     where soil.Name == Utils.NameSoilGMOLaPalma3
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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
        /// Add Information To IrrigationUnits - LaPalma Pivot 4 2015-16
        /// </summary>
        /// <param name="context"></param>
        public static void AddInformationToIrrigationUnitsLaPalmaPivot4_2015(IrrigationAdvisorContext context)
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
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                  where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                  select effectiverain)
                                     .ToList<EffectiveRain>();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
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
                                    where (weatherdata.Date >= lSowingDate &&
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
                     where soil.Name == Utils.NameSoilGMOLaPalma4
                     select soil).FirstOrDefault();
            lHorizonList = (from horizon in context.Horizons
                            where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
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

                lCropIrrigationWeather.AddDailyRecordToList(lDateOfRecord, lObservation, DateTime.Now);
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

        #region 2015

        #endregion

        #endregion

        #region La Rinconada

        #region 2015

        #endregion

        #endregion

        #endregion

    }

}
