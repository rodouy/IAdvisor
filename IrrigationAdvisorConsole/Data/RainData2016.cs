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

namespace IrrigationAdvisorConsole.Data
{
    public class RainData2016
    {

        #region RainData

        #region Santa Lucia

        #endregion

        #region DCA El Paraiso

        #region 2016

        public static void AddRainDataDCAElParaisoPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region contect
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

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotDCAElParaiso5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotDCAElParaiso6
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotDCAElParaiso7
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 102 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 102;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion
        #region DCA La Perdiz

        #region 2016

        public static void AddRainDataDCALaPerdizPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz3
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotDCALaPerdiz5
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot10a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot10b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 76 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 76;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 125 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 125;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/03 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 03);
                lRainQuantity = 04;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 87 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 87;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion
        #region DCA San Jose

        #region 2016

        public static void AddRainDataDCASanJosePivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 97 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 97;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/22 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 22);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 97 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 97;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/22 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 22);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieSoyaSouthShort
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 97 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 97;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/22 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 22);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 24 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 24;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 46 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 46;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 97 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 97;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/22 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 22);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/22 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 22);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #endregion
        #region Del Lago - El Mirador

        #region 2016

        public static void AddRainDataDelLagoElMiradorPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/07 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/16 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/19 - 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot11_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot12_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot13_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot14_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/25 - 1 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot15_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivotChaja1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivotChaja2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/07 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/08 - 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 08);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/23 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 23);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 110 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 110;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion
        #region 2016b

        public static void AddRainDataDelLagoElMiradorPivot1_2016b(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador1b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/19 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 19);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/26 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 26);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/08 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/14 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 14);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/19 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 19);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/20 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 20);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/25 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 25);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/28 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 28);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot2_2016b(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador2b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/19 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 19);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/26 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 26);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/08 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/14 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 14);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/19 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 19);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/20 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 20);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/25 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 25);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/28 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 28);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot3_2016b(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador3b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/19 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 19);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/26 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 26);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/08 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/14 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 14);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/19 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 19);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/20 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 20);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/25 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 25);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/28 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 28);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDelLagoElMiradorPivot4_2016b(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthMedium
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotDelLagoElMirador4b
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2017/02/04 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/10 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 10);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 11);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/23 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 23);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/19 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 19);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/04/26 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 04, 26);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/08 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 08);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/14 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 14);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/19 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 19);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/20 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 20);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/25 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 25);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/05/28 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 05, 28);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2016

        public static void AddRainDataGMOLaPalmaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieAlfalfaSouthShort
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

            #region Rain 2016/10/07 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 63 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 63;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/27 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 27);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthShort
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

            #region Rain 2016/10/07 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 63 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 63;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/27 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 27);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot3_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthShort
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

            #region Rain 2016/10/07 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 63 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 63;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/27 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 27);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOLaPalmaPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                     where crop.Name == Utils.NameSpecieCornSouthShort
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

            #region Rain 2016/10/07 - 6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 7);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 23 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 23;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 7 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/26 - 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 10, 26);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 63 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 63;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/27 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 27);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 09;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 29 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 29;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion
        #region GMO - El Tacuru

        #region 2016

        public static void AddRainDataGMOElTacuruPivot1a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/17 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1.5
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/27 - 3.3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 27);
                lRainQuantity = 3.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot1b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot2a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/17 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1.5
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/27 - 3.3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 27);
                lRainQuantity = 3.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot2b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot3a_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/17 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1.5
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/27 - 3.3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 27);
                lRainQuantity = 3.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot3b_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot4_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotGMOElTacuru4
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/10/05 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 5);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/12 - 14
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 12);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/15 - 74
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 15);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/16 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 16);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/17 - 15
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 17);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/18 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 18);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/19 - 25
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 19);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/25 - 1.5
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 25);
                lRainQuantity = 1.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/10/27 - 3.3
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2016, 10, 27);
                lRainQuantity = 3.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot5_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot6_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot7_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot8_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
                               where iu.Name == Utils.NamePivotGMOElTacuru8
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/01 100 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 100;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot9_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataGMOElTacuruPivot10_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2016/11/26 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 13);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/28 61 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 28);
                lRainQuantity = 61;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 17 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 17;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/13 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 13);
                lRainQuantity = 01;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 02;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/10 37 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 10);
                lRainQuantity = 37;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 54 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 54;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/16 20.3 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 16);
                lRainQuantity = 20.3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 103 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 103;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/20 3.6 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 20);
                lRainQuantity = 3.6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region TM - Tres Marias

        #region 2016

        public static void AddRainDataTresMariasPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmTresMarias
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotTresMarias1
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/12/18 39 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 39;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/16 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 16);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/24 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 24);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/01 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 01);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 34 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 34;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 06;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataTresMariasPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

            lFarm = (from farm in context.Farms
                     where farm.Name == Utils.NameFarmTresMarias
                     select farm).FirstOrDefault();
            lCrop = (from crop in context.Crops
                     where crop.Name == Utils.NameSpecieCornSouthShort
                     select crop).FirstOrDefault();
            lIrrigationUnit = (from iu in context.Pivots
                               where iu.Name == Utils.NamePivotTresMarias2
                               select iu).FirstOrDefault();
            lCropIrrigationWeatherList = (from ciw in context.CropIrrigationWeathers
                                          where ciw.CropId == lCrop.CropId
                                              && ciw.IrrigationUnitId == lIrrigationUnit.IrrigationUnitId
                                              && ciw.SowingDate <= pDateOfReference
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/12/18 39 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 39;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/09 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 09);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 14);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/16 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 16);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/24 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 24);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/01 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 01);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/05 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 05);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 34 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 34;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/18 14 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 18);
                lRainQuantity = 14;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 07;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/09 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 09);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/03/15 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 03, 15);
                lRainQuantity = 06;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region LR - La Rinconada

        #region 2016

        public static void AddRainDataLaRinconadaPivot1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

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
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/01 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/17 5.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 17);
                lRainQuantity = 5.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 95 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 95;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/12 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 12);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 86 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 86;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 69 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 69;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataLaRinconadaPivot2_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

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
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/01 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/17 5.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 17);
                lRainQuantity = 5.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 95 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 95;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/12 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 12);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 86 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 86;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 69 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 69;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataLaRinconadaPivot3_1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

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
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/01 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/17 5.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 17);
                lRainQuantity = 5.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 95 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 95;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/12 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 12);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 86 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 86;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 69 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 69;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataLaRinconadaPivot13_1_2016(IrrigationAdvisorContext context, DateTime pDateOfReference)
        {
            #region context
            List<CropIrrigationWeather> lCropIrrigationWeatherList = new List<CropIrrigationWeather>();
            Farm lFarm;
            Crop lCrop = null;
            IrrigationUnit lIrrigationUnit;
            DateTime lRainDate;
            double lRainQuantity = 0;

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
                                              && ciw.HarvestDate.Year >= pDateOfReference.Year
                                          select ciw).ToList<CropIrrigationWeather>();
            #endregion

            #region Rain 2016/11/01 33 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 01);
                lRainQuantity = 33;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/07 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 07);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/16 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 16);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/17 5.5 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 17);
                lRainQuantity = 5.5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/11/26 95 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 11, 26);
                lRainQuantity = 95;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/02 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 02);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/12 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 12);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/18 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 18);
                lRainQuantity = 03;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/22 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 22);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/25 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 25);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2016/12/26 86 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2016, 12, 26);
                lRainQuantity = 86;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/03 69 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 03);
                lRainQuantity = 69;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/04 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 04);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/08 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 08);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/15 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 15);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/01/31 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 01, 31);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/04 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 04);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/12 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 12);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/13 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 13);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/14 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 14);
                lRainQuantity = 08;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/19 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 19);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2017/02/21 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2017, 02, 21);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region ER - El Rincon

        #endregion

        #region ED - El Desafio

        #endregion

        #region LN - Los Naranjales

        #endregion

        #region SE - Santa Emilia

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
