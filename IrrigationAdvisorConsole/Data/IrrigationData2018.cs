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
    public static class IrrigationData2018
    {

        #region IrrigationData

        #region DCA El Paraiso

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 1 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/05 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 05);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. Riego el 07-Dic-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 2 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCAElParaiso
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
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

            #region Irrigation 2018/11/14 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 14);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 3 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/14 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 14);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 4 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/04 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 04);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        #endregion

        #endregion
        #region DCA La Perdiz

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 1 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 2 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/12/06 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 06);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/12 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 12);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 3 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/12/06 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 06);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 5 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/12/06 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 06);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 6 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 7 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Irrigation 2018/11/11 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 11);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. No Irrigation until 18-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 10a for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot10a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz10a
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/11/08 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 08);
                lIrrigationQuantity = 06;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 10b for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot10b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz10b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 14 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot14_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmDCALaPerdiz
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Irrigation 2018/11/11 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 11);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. First Irrigation 14-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 15 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot15_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz15
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        #endregion

        #endregion
        #region DCA San Jose

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 1 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/05 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 05);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. Riego el 07-Dic-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 2 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/14 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 14);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 3 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/14 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 14);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 4 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/04 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 04);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 1 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 2 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 3 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 4 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 5 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 6 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/09 7.2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 09);
                lIrrigationQuantity = 7.2;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 7 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/08 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 08);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. Riego el 09-Nov-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 8 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 9 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 10 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot10_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 11 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 12 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 13 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 14 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot14_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 15 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot15_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 16 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot16_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago San Pedro Pivot 17 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoSanPedroPivot17_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/10 7.3 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 10);
                lIrrigationQuantity = 7.3;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        #endregion

        #endregion
        #region Del Lago - El Mirador

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 1 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 11);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 2 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 11);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 3 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 11);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 4 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/12 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 12);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 5 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/12 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 12);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 6 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/12 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 12);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 7 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 15);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 8 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 14);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 9 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 14);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 10 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot10_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/22 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 22);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. Riego el 24-Nov-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 11 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 13);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 12 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/22 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 22);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. Riego el 30-Nov-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 13 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 14);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 14 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot14_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/12/02 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 02);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 15 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot15_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 13);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot Chaja 1 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivotChaja1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/09 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 09);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot Chaja 2 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivotChaja2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 13);
                lIrrigationQuantity = 7;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 11);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 3 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/12 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 12);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 4 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/10/12 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 12);
                lIrrigationQuantity = 13;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 1.1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot1_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/11 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 11);
                lIrrigationQuantity = 09;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 2.1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot2_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/19 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 19);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 3.1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot3_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/29 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 29);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 01-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 4.1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot4_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/29 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 29);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        #endregion

        #endregion
        #region GMO - El Tacuru

        #region 2018
        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 1a for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot1a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaNorthShort
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

            #region Irrigation 2018/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 1b for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot1b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 17);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 2a for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot2a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/12 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 12);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.MoveIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 2b for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot2b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/12 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 12);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3a for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot3a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/11 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 11);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3b for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot3b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/19 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 19);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/16 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. No hubo riego del 17-Nov-17 al 30-Nov-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 5 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 13);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 8 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/01 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 01);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 9 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/18 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 18);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 10 for 2018-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot10_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;

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

            #region Irrigation 2018/11/19 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 19);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
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

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to El Rincon Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElRinconPivot1a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to El Rincon Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElRinconPivot1b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/25 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 25);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to El Rincon Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElRinconPivot2a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to El Rincon Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElRinconPivot2b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/25 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 25);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        #endregion

        #endregion

        #region ED - El Desafio

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to El Desafio Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElDesafioPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to El Desafio Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElDesafioPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/30 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 30);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        #endregion

        #endregion

        #region LN - Los Naranjales

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to Los Naranjales Pivot 6aT3 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLosNaranjalesPivot6aT3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/06 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 06);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to Los Naranjales Pivot 6bT3 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLosNaranjalesPivot6bT3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/06 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 06);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/08 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 08);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to Los Naranjales Pivot 5aT5 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLosNaranjalesPivot5aT5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/15 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 15);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/19 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 19);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to Los Naranjales Pivot 5bT5 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLosNaranjalesPivot5bT5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/15 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 15);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/17 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 17);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        #endregion

        #endregion

        #region SE - SantaEmilia

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to Santa Emilia Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataSantaEmiliaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to Santa Emilia Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataSantaEmiliaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmSantaEmilia
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotSantaEmilia2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2018/11/27 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 27);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to Santa Emilia Pivot 5 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataSantaEmiliaPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to Santa Emilia Pivot 7 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataSantaEmiliaPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 13);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 15);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        #endregion

        #endregion

        #region GM - GranMolino

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2019/01/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2019, 01, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/10 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 10);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 3 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/16 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 16);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate. Se mueve el riego para el 27-Dic-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 4 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/14 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 14);
                lIrrigationQuantity = 20;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion




        }

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 5 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/12/02 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 02);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/10 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 10);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion







        }

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 2b for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot2b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2019/03/13 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2019, 03, 13);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        /// <summary>
        /// Add IrrigationQuantity Data to Gran Molino Pivot 5b for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGranMolinoPivot5b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2019/03/13 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2019, 03, 13);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.CropDontNeedIrrigation;
                lObservations = "Cant Irrigate.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        #endregion

        #endregion

        #region LP - La Portuguesa

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to La Portuguesa Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaPortuguesaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/16 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/23 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. ";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/24 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 24);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. ";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Portuguesa Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaPortuguesaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/30 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 30);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/01 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 01);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/02 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 02);
                lIrrigationQuantity = 23;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/05 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 05);
                lIrrigationQuantity = 23;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/20 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 20);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2019/01/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2019, 01, 02);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2019/01/11 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2019, 01, 11);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Add Irrigation OK.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        #endregion

        #endregion

        #region CLP - Cassarino - La Perdiz

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to Cassarino - La Perdiz Pivot 1.1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataCassarinoLaPerdizPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/16 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/23 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. ";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/24 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 24);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. ";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to Cassarino - La Perdiz Pivot 1.2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataCassarinoLaPerdizPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/30 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 30);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/01 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 01);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/12/02 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 12, 02);
                lIrrigationQuantity = 23;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to Cassarino - La Perdiz Pivot 1.3 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataCassarinoLaPerdizPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/16 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/23 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. ";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/24 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 24);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. ";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion

        }

        #endregion

        #endregion

        #region SD - Santo Domingo

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to Santo Domingo Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataSantoDomingoPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/16 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to Santo Domingo Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataSantoDomingoPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/30 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 30);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        #endregion

        #endregion

        #region CE - Cecchini

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to Cecchini Pivot 1 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataCecchiniPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmCecchini
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/16 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to Cecchini Pivot 2 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataCecchiniPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/30 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 30);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        #endregion

        #endregion

        #region EA - El Alba

        #region 2018

        /// <summary>
        /// Add IrrigationQuantity Data to El Alba Pivot 32 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElAlbaPivot32_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/10/28 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 10, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion
            #region Irrigation 2018/11/16 10 mm - Calculated
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 16);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.Other;
                lObservations = "Calculated Irrigation.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.IrrigationByETCAcumulated);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion





        }

        /// <summary>
        /// Add IrrigationQuantity Data to El Alba Pivot 33 for 2018-2019
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataElAlbaPivot33_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lToday = pDateOfReference;
            Pair<double, Utils.WaterInputType> lQuantityOfWaterToIrrigateAndTypeOfIrrigation;
            bool lIsExtraIrrigation;
            DateTime lIrrigationDate;
            double lIrrigationQuantity = 0;
            List<Irrigation> lIrrigationList;
            List<Rain> lRainList;
            Utils.NoIrrigationReason lReason;
            String lObservations;


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

            #region Irrigation 2018/11/30 00 mm - Can't Irrigate
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2018, 11, 30);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                lReason = Utils.NoIrrigationReason.IrrigationSystemFail;
                lObservations = "Cant Irrigate. Se riega el 02-Dec-17.";
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.CantIrrigate);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation, lReason, lObservations);
            }
            #endregion



        }

        #endregion

        #endregion

        #endregion

    }
}
