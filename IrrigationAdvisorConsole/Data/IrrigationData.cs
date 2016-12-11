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
    public static class IrrigationData
    {

        #region IrrigationData

        #region DCA El Paraiso

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - El Paraiso Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/29 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 29);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/09 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - El Paraiso Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCAElParaisoPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/29 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 29);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        #endregion

        #endregion

        #region DCA San Jose

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/26 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 26);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #region Irrigation 2016/09/26 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 26);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #endregion
            #region Irrigation 2016/10/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/03 4.1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 03);
                lIrrigationQuantity = 4.1;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/04 4.1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 04);
                lIrrigationQuantity = 4.1;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 0 mm - forward the irrigation to 2016/11/15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 4.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 4.3;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/21 0 mm - forward the irrigation to 2016/11/15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 21);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 14 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/30 4.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 30);
                lIrrigationQuantity = 4.3;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - San Jose Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCASanJosePivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/26 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 26);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/03 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 03);
                lIrrigationQuantity = 05;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 04);
                lIrrigationQuantity = 05;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 0 mm - forward the irrigation to 2016/11/15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 05;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 05;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/03 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/08 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 08);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        #endregion

        #endregion

        #region DCA La Perdiz

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion


            #region Irrigation 2016/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/07 9 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 07);
                lIrrigationQuantity = 09;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 8.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 8.5;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 9.0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 9.0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/04 9.0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 04);
                lIrrigationQuantity = 9.0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/09 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 09);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/10 14.0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 10);
                lIrrigationQuantity = 14.0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 6 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/05 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 05);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 8.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 8.5;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion                                         
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 10a for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot10a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/08 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 06;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 10b for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot10b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            //se quito el riego del 16/11/8, hubo lluvia de 22 el 11/7 - 2016/11/15
            #region Irrigation 2016/11/08 6 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 11, 08);
            //    lIrrigationQuantity = 06;
            //    lIsExtraIrrigation = true;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
            #region Irrigation 2016/11/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 3.0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 3.0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 6.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 6.5;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/04 6.0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 04);
                lIrrigationQuantity = 6.0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/09 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 09);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/10 14.0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 10);
                lIrrigationQuantity = 14.0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DCA - La Perdiz Pivot 15 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDCALaPerdizPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/30 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 30);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 15;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/06 3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 06);
                lIrrigationQuantity = 03;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/01 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 01);
                lIrrigationQuantity = 03;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/06 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 06);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        #endregion

        #endregion

        #region Del Lago - El Mirador

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 11);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/18 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 18);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 14 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 11);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/12 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/12 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/21 14 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 21);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 11);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/12 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/21 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 21);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 5 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/12 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 12);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 6 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/08 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 08);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 7 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/15 14 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 8 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 9 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/16 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 16);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/17 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/09 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 10 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/10/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/16 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 16);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 14 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 0 mm - Calculated Irrigation - NO se pudo cumplir por fuga
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/06 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 06);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 11 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/12 14 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/15 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 0 mm - Calculated Irrigation - NO se pudo cumplir por fuga
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/06 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 06);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 12 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/12 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 12);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 13 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/10 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 14 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/03 0 mm - Irrigation canceled
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 03);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot 15 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/13 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/18 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 18);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot Chaja 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivotChaja1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/10/?? 0 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to DelLago El Mirador Pivot Chaja 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataDelLagoElMiradorPivotChaja2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/12 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/03 0 mm - Irrigation canceled
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 03);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/29 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 29);
                lIrrigationQuantity = 16;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/05 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 05);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/06 7.55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 06);
                lIrrigationQuantity = 7.55;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 5.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 5.5;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/17 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/06 7.55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 06);
                lIrrigationQuantity = 7.55;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 5.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 5.5;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/17 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO La Palma Pivot 4 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOLaPalmaPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOLaPalma
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOLaPalma4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/03 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 03);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/06 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 06);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/06 7.55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 06);
                lIrrigationQuantity = 7.55;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/13 7.55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 7.55;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/17 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 8;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        #endregion

        #endregion

        #region GMO - El Tacuru

        #region 2016
        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 1a for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot1a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 1b for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot1b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/17 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 2a for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot2a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/27 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 27);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/02 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 02);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/12 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/17 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/11 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 11);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 2b for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot2b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/13 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 13);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3a for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot3a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/26 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 26);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/01 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 01);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/12 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 12);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/18 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 18);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/19 12 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 19);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/12 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 12);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3b for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot3b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/17 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/13 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 13);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion


        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 3 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/09/23 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 23);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/09/28 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 09, 28);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/10/01 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 10, 01);
                lIrrigationQuantity = 07;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/10 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 10);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 14);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/20 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 20);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/21 12 mm 
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 21);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/23 0 mm - Calculated Irrigation pass to next day
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 23);
                lIrrigationQuantity = 0;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/07 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 07);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/10 12 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 10);
                lIrrigationQuantity = 12;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 5 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/17 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/24 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 24);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 8 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmGMOElTacuru
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotGMOElTacuru8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/15 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/22 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 22);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 9 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/15 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/21 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 21);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to GMO El Tacuru Pivot 10 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataGMOElTacuruPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/17 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 17);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/25 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 25);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        #endregion

        #endregion

        #region LR - La Rinconada

        #region 2016

        /// <summary>
        /// Add IrrigationQuantity Data to La Rinconada Pivot 1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaRinconadaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/07 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 07);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/11/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion

        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Rinconada Pivot 2 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaRinconadaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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


            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/15 10 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 15);
                lIrrigationQuantity = 10;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Rinconada Pivot 3.1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaRinconadaPivot3_1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada3_1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/25 14 mm - Calculated Irrigation
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Irrigation
            //    lIrrigationDate = new DateTime(2016, 11, 23);
            //    lIrrigationQuantity = 14;
            //    lIsExtraIrrigation = false;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lIrrigationList = (from ilist in context.Irrigations
            //                       where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                       select ilist).ToList<Irrigation>();
            //    lRainList = (from rlist in context.Rains
            //                 where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
            //                 select rlist).ToList<Rain>();
            //    lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
            //    lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            //}
            #endregion
        }

        /// <summary>
        /// Add IrrigationQuantity Data to La Rinconada Pivot 13.1 for 2016-17
        /// </summary>
        /// <param name="context"></param>
        public static void AddIrrigationDataLaRinconadaPivot13_1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmLaRinconada
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieSoyaNorthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotLaRinconada13_1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate >= pDateOfReference
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Irrigation 2016/11/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 11, 08);
                lIrrigationQuantity = 08;
                lIsExtraIrrigation = true;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/02 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 02);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
            #region Irrigation 2016/12/09 14 mm - Calculated Irrigation
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lIrrigationDate = new DateTime(2016, 12, 09);
                lIrrigationQuantity = 14;
                lIsExtraIrrigation = false;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lIrrigationList = (from ilist in context.Irrigations
                                   where ilist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                                   select ilist).ToList<Irrigation>();
                lRainList = (from rlist in context.Rains
                             where rlist.CropIrrigationWeatherId == lCropIrrigationWeather.CropIrrigationWeatherId
                             select rlist).ToList<Rain>();
                lQuantityOfWaterToIrrigateAndTypeOfIrrigation = new Pair<double, Utils.WaterInputType>(lIrrigationQuantity, Utils.WaterInputType.Irrigation);
                lCropIrrigationWeather.AddOrUpdateIrrigationDataToList(lIrrigationDate, lQuantityOfWaterToIrrigateAndTypeOfIrrigation, lIsExtraIrrigation);
            }
            #endregion
        }

        #endregion

        #endregion

        #endregion

    }
}
