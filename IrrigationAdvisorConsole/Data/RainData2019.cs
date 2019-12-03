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

namespace IrrigationAdvisorConsole.Data
{
    public static class RainData2019
    {

        #region RainData

        #region Santa Lucia

        #endregion

        #region DCA El Paraiso

        public static void AddRainDataDCAElParaisoPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataDCAElParaisoPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataDCAElParaisoPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataDCAElParaisoPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCAElParaiso4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        #endregion
        #region DCA La Perdiz

        #region 2019

        public static void AddRainDataDCALaPerdizPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataDCALaPerdizPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataDCALaPerdizPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataDCALaPerdizPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataDCALaPerdizPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion






        }

        public static void AddRainDataDCALaPerdizPivot6_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataDCALaPerdizPivot7_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion






        }

        public static void AddRainDataDCALaPerdizPivot8_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataDCALaPerdizPivot9_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion






        }

        public static void AddRainDataDCALaPerdizPivot10a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz10a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataDCALaPerdizPivot10b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz10b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataDCALaPerdizPivot11_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion







        }

        public static void AddRainDataDCALaPerdizPivot12_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataDCALaPerdizPivot13_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataDCALaPerdizPivot14_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz14
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataDCALaPerdizPivot15_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCALaPerdiz15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        #endregion

        #endregion
        #region DCA San Jose

        #region 2019

        public static void AddRainDataDCASanJosePivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion
            #region Rain 2019/10/01 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/02 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 02);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/09 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 09);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/20 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 20);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/28 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 28);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/21 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 21);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDCASanJosePivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion
            #region Rain 2019/10/01 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/02 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 02);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/09 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 09);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/20 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 20);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/28 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 28);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/21 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 21);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCASanJosePivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion
            #region Rain 2019/10/01 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/02 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 02);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/09 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 09);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/20 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 20);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/28 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 28);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/21 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 21);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCASanJosePivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCASanJose
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDCASanJose4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion
            #region Rain 2019/10/01 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/02 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 02);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/09 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 09);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/20 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 20);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/28 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 28);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/21 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 21);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #region 2019
        public static void AddRainDataDelLagoSanPedroPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot6_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot7_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoSanPedroPivot8_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot9_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot10_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro10
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot11_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot12_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot13_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot14_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro14
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoSanPedroPivot15_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoSanPedroPivot16_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro16
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoSanPedroPivot17_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoSanPedro
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoSanPedro17
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion
        #region Del Lago - El Mirador

        #region 2019

        public static void AddRainDataDelLagoElMiradorPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region Context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoElMiradorPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot6_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot7_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoElMiradorPivot8_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot9_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot10_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador10
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoElMiradorPivot11_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot12_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoElMiradorPivot13_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot14_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador14
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot15_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivotChaja1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoElMiradorPivotChaja2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDelLagoElMirador
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2019

        public static void AddRainDataGMOLaPalmaPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot1_1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1_1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot2_1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2_1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot3_1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3_1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot4_1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4_1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion
        #region GMO - El Tacuru

        #region 2019

        public static void AddRainDataGMOElTacuruPivot1a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaNorthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot1b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru1b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot2a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion
            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot2b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru2b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot3a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot3b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru3b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGMOElTacuruPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGMOElTacuruPivot6_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGMOElTacuruPivot7_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot8_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot9_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru9
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot10_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru10
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2019, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        #endregion

        #endregion

        #region TM - Tres Marias

        #endregion

        #region LR - La Rinconada

        #endregion

        #region ER - El Rincon

        #region 2019

        public static void AddRainDataElRinconPivot1a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElRincon
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElRincon1a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataElRinconPivot1b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElRincon
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElRincon1b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataElRinconPivot2a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElRincon
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElRincon2a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataElRinconPivot2b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElRincon
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElRincon2b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        #endregion

        #endregion

        #region ED - El Desafio

        #region 2019

        public static void AddRainDataElDesafioPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElDesafio
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSudanGrassSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElDesafio1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataElDesafioPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElDesafio
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSudanGrassSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElDesafio2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region LN - Los Naranjales

        #region 2019

        public static void AddRainDataLosNaranjalesPivot6aT3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLosNaranjales
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLosNaranjales6aT3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataLosNaranjalesPivot6bT3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLosNaranjales
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLosNaranjales6bT3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataLosNaranjalesPivot5aT5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLosNaranjales
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieFescueForageSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLosNaranjales5aT5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataLosNaranjalesPivot5bT5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLosNaranjales
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLosNaranjales5bT5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region SE - Santa Emilia

        #region 2019

        public static void AddRainDataSantaEmiliaPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmilia1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataSantaEmiliaPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmilia3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataSantaEmiliaPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmilia4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        public static void AddRainDataSantaEmiliaPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmilia5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataSantaEmiliaPivot7_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmilia7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataSantaEmiliaPivotZP_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmiliaZP
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        #endregion

        #endregion

        #region GM - Gran Molino

        #region 2019

        public static void AddRainDataGranMolinoPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGranMolinoPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGranMolinoPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGranMolinoPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGranMolinoPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGranMolinoPivot2b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieOatSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino2b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2020/03/15 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2020, 03, 15);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGranMolinoPivot5b_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGranMolino
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieOatSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGranMolino5b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2020/03/15 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2020, 03, 15);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        #endregion

        #endregion

        #region LP - La Portuguesa

        #region 2019

        public static void AddRainDataLaPortuguesaPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPortuguesa
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPortuguesa1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion






        }

        public static void AddRainDataLaPortuguesaPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaPortuguesa
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaPortuguesa2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion





        }

        #endregion

        #endregion

        #region CLP - Cassarino - La Perdiz

        #region 2019

        public static void AddRainDataCassarinoLaPerdizPivot11_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmCassarinoLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSudanGrassSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotCassarinoLaPerdiz11
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataCassarinoLaPerdizPivot12_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmCassarinoLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotCassarinoLaPerdiz12
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataCassarinoLaPerdizPivot13_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmCassarinoLaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotCassarinoLaPerdiz13
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region SD - Santo Domingo

        #region 2019

        public static void AddRainDataSantoDomingoPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantoDomingo
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantoDomingo1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataSantoDomingoPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantoDomingo
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantoDomingo2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region CE - Cecchini

        #region 2019

        public static void AddRainDataCecchiniPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmCecchini
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotCecchini1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/11/04 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/22 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 22);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataCecchiniPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmCecchini
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotCecchini2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/11/04 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/22 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 22);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        #endregion

        #endregion

        #region EA - El Alba

        #region 2019

        public static void AddRainDataElAlbaPivot32_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElAlba
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElAlba32
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/10 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 10);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/21 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 21);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/02 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 02);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/18 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 18);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataElAlbaPivot33_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElAlba
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElAlba33
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/10 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 10);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/21 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 21);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/02 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 02);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/18 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 18);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataElAlbaPivot38_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElAlba
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElAlba38
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/10 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 10);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/21 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 21);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/02 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 02);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/18 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 18);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataElAlbaPivot40_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmElAlba
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotElAlba40
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2019/10/01 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 01);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/10 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 10);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/12 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 12);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/13 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 13);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/17 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/10/21 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 10, 21);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/02 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 02);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 04);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/18 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 18);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/11/25 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 11, 25);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region LZ - La Zenaida

        #region 2019

        public static void AddRainDataLaZenaidaPivot1_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieFescueForageSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataLaZenaidaPivot2_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieFescueForageSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataLaZenaidaPivot3_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieFescueForageSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataLaZenaidaPivot4_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSudanGrassSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataLaZenaidaPivot5_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSudanGrassSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion


        }

        public static void AddRainDataLaZenaidaPivot1a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieOatSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida1a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion



        }

        public static void AddRainDataLaZenaidaPivot4a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpeciePastureSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida4a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion




        }

        public static void AddRainDataLaZenaidaPivot5a_2019(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaZenaida
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpeciePastureSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaZenaida5a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion


        }

        #endregion

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
                                   where ws.Name == Utils.NameWeatherStationLasBrujas
                                   select ws).FirstOrDefault();


            lCropIrrigationWeather = (from ciw in context.CropIrrigationWeathers
                                      where ciw.CropId == lCrop.CropId
                                          && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                          && ciw.MainWeatherStationId == lWeatherStationMain.WeatherStationId
                                      select ciw).FirstOrDefault();

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2019, 11, 1), 10);

        }

        #endregion

    }
}
