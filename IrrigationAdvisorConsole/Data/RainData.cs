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
    public static class RainData
    {
        
        #region RainData

        #region Santa Lucia

        #endregion

        #region DCA El Paraiso

        #endregion
        #region DCA La Perdiz

        #region 2017

        public static void AddRainDataDCALaPerdizPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Rain
            //    lRainDate = new DateTime(2017, 10, 7);
            //    lRainQuantity = 2;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            //}
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Rain
            //    lRainDate = new DateTime(2017, 10, 7);
            //    lRainQuantity = 2;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            //}
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot6_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot7_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot8_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot9_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot10a_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot10b_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot11_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot12_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot13_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot14_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            //foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            //{
            //    //Data to change about Rain
            //    lRainDate = new DateTime(2017, 10, 7);
            //    lRainQuantity = 2;
            //    /////////////////////////////////////////////////////////////////////////////////////////////
            //    lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            //}
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot15_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 - 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion
        #region DCA San Jose

        #region 2017

        public static void AddRainDataDCASanJosePivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCASanJosePivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCASanJosePivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #region 2017
        public static void AddRainDataDelLagoSanPedroPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoSanPedroPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion       
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoSanPedroPivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoSanPedroPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }
        
        public static void AddRainDataDelLagoSanPedroPivot5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoSanPedroPivot6_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoSanPedroPivot7_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoSanPedroPivot8_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot9_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot10_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot11_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot12_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot13_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot14_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot15_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot16_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDelLagoSanPedroPivot17_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 - 30.8 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 2);
                lRainQuantity = 30.8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 31);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        #endregion

        #endregion
        #region Del Lago - El Mirador

        #region 2017

        public static void AddRainDataDelLagoElMiradorPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot6_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot7_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot8_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot9_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot10_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoElMiradorPivot11_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot12_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot13_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot14_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot15_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivotChaja1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivotChaja2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 3);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 - 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/23 - 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 - 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 - 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 - 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 - 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 - 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 - 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 - 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/19 - 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 19);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/20 - 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2017

        public static void AddRainDataGMOLaPalmaPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            
        }

        public static void AddRainDataGMOLaPalmaPivot1_1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataGMOLaPalmaPivot2_1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataGMOLaPalmaPivot3_1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot4_1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/19 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/13 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 13);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/16 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 16);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/19 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 19);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        #endregion

        #endregion
        #region GMO - El Tacuru

        #region 2017

        public static void AddRainDataGMOElTacuruPivot1a_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataGMOElTacuruPivot1b_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot2a_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot2b_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot3a_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot3b_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot6_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot7_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot8_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot9_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot10_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 - 46
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/08 - 18
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/10 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 10);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 - 03
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 - 20
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 - 118
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 118;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/20 - 06
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2017, 10, 20);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/24 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 24);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 02);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 03);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/09 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 09);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/28 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 28);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/27 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 27);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 13 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 13;
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

        #region 2017

        public static void AddRainDataElRinconPivot1a_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 07);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/29 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 29);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/06 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 06);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 12.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 12.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/02 6.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 02);
                lRainQuantity = 6.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataElRinconPivot1b_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/07 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 07);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 11);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/29 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 29);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/06 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 06);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 12.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 12.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/02 6.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 02);
                lRainQuantity = 6.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/03/03 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 03, 03);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region ED - El Desafio

        #region 2017

        public static void AddRainDataElDesafioPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataElDesafioPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region LN - Los Naranjales

        #region 2017

        public static void AddRainDataLosNaranjalesPivot6aT3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataLosNaranjalesPivot6bT3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataLosNaranjalesPivot5aT5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataLosNaranjalesPivot5bT5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region SE - Santa Emilia

        #region 2017

        public static void AddRainDataSantaEmiliaPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/26 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/29 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 29);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataSantaEmiliaPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/26 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/29 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 29);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataSantaEmiliaPivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/26 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/29 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 29);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        
        }

        public static void AddRainDataSantaEmiliaPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/26 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/29 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 29);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataSantaEmiliaPivot5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/26 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/29 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 29);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataSantaEmiliaPivot7_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/09/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/26 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 26);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/09/29 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 09, 29);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/01 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 01);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/02 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 02);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/17 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 17);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/18 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 18);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/02 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 02);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 15);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/20 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 20);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/14 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 14);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/05 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 05);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region GM - Gran Molino

        #region 2017

        public static void AddRainDataGranMolinoPivot1_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/21 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 21);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/28 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 28);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/18 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 18);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/07 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 07);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/03 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 03);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/28 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 28);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGranMolinoPivot2_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/21 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 21);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/28 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 28);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/18 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 18);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/07 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 07);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/03 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 03);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/28 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 28);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGranMolinoPivot3_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/21 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 21);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/28 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 28);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/18 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 18);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/07 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 07);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/03 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 03);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/28 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 28);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGranMolinoPivot4_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/21 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 21);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/28 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 28);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/18 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 18);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/07 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 07);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/03 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 03);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/28 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 28);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGranMolinoPivot5_2017(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2017/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/21 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 21);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/22 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 22);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/28 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 28);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/10/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 10, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/03 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 03);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/16 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 16);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/18 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 18);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/11/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 11, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/07 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 07);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/19 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 19);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/12/31 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 12, 31);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/03 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 03);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/12 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 12);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/14 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 14);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/01/28 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 01, 28);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/08 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 08);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/11 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 11);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/02/21 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 02, 21);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
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

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2015, 11, 1), 10);

        }

        #endregion

    }
}
