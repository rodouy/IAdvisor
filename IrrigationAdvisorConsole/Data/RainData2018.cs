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
    public static class RainData2018
    {

        #region RainData

        #region Santa Lucia

        #endregion

        #region DCA El Paraiso

        public static void AddRainDataDCAElParaisoPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 31 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 31;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 34 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 34;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/30 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 30);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/03 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 03);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 31 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 31;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 34 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 34;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/30 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 30);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion     
            #region Rain 2019/04/03 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 03);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCAElParaisoPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 31 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 31;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 34 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 34;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/30 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 30);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion     
            #region Rain 2019/04/03 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 03);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCAElParaisoPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 31 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 31;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 09 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 9;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 36 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 36;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 48 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 48;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 58 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 58;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 44 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 44;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 32 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 32;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 74 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 74;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 34 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 34;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 51 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 51;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/19 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 19);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/30 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 30);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/03 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 03);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion     
            }

        #endregion
        #region DCA La Perdiz

        #region 2018

        public static void AddRainDataDCALaPerdizPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion       
        }

        public static void AddRainDataDCALaPerdizPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCALaPerdizPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDCALaPerdizPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        
        }

        public static void AddRainDataDCALaPerdizPivot10a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot10b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        
        }

        public static void AddRainDataDCALaPerdizPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/07 2 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 7);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot14_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion        
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCALaPerdizPivot15_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/12 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/23 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 23);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/03 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 03);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 66 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 66;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/18 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 18);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 62 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 62;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 42 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 42;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 96 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 96;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/17 04 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 17);
                lRainQuantity = 4;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/04/15 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 15);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/24 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 24);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/05/05 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        #endregion

        #endregion
        #region DCA San Jose

        #region 2018

        public static void AddRainDataDCASanJosePivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/01 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 01);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataDCASanJosePivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/01 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 01);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/01 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 01);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        public static void AddRainDataDCASanJosePivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/26 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 26);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/01 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 01);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/13 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 13);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 80 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 80;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/14 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 14);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 28 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 28;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 105 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 105;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 55 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 55;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/28 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 28);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 22 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 22;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/22 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 22);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 18 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 18;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 02 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 2;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 07 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 7;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/22 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 22);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/04 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 04);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/07 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 07);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/03/11 38 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 11);
                lRainQuantity = 38;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/12 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 12);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/16 01 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 16);
                lRainQuantity = 1;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region Del Lago - San Pedro

        #region 2018
        public static void AddRainDataDelLagoSanPedroPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoSanPedroPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot10_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoSanPedroPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoSanPedroPivot14_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoSanPedroPivot15_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoSanPedroPivot16_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoSanPedroPivot17_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 - 43 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 43;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion
        #region Del Lago - El Mirador

        #region 2018

        public static void AddRainDataDelLagoElMiradorPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoElMiradorPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoElMiradorPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot10_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoElMiradorPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataDelLagoElMiradorPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataDelLagoElMiradorPivot14_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivot15_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataDelLagoElMiradorPivotChaja1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataDelLagoElMiradorPivotChaja2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/01 - 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 1);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region GMO - La Palma

        #region 2018

        public static void AddRainDataGMOLaPalmaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot1_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot2_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/17 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 17);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOLaPalmaPivot3_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOLaPalmaPivot4_1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/08 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 08);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion
        #region GMO - El Tacuru

        #region 2018

        public static void AddRainDataGMOElTacuruPivot1a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot1b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot2a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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
            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot2b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot3a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot3b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGMOElTacuruPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGMOElTacuruPivot6_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGMOElTacuruPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot8_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGMOElTacuruPivot9_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGMOElTacuruPivot10_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/27 - 40
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Irrigation
                lRainDate = new DateTime(2018, 09, 27);
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

        #region 2018

        public static void AddRainDataElRinconPivot1a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/11/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/10 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 10);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 


        }

        public static void AddRainDataElRinconPivot1b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/11/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/10 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 10);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 


      
        }

        public static void AddRainDataElRinconPivot2a_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/11/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/10 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 10);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 


        }

        public static void AddRainDataElRinconPivot2b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/11/02 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 02);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/10 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 10);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/17 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 17);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/23 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 23);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 05;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/10 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 10);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/06 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 06);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/30 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 30);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/02 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 02);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 35 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 35;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 
            #region Rain 2019/02/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion 


        }

        #endregion

        #endregion

        #region ED - El Desafio

        #region 2018

        public static void AddRainDataElDesafioPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        public static void AddRainDataElDesafioPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region LN - Los Naranjales

        #region 2018

        public static void AddRainDataLosNaranjalesPivot6aT3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataLosNaranjalesPivot6bT3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataLosNaranjalesPivot5aT5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataLosNaranjalesPivot5bT5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/17 52 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 52;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region SE - Santa Emilia

        #region 2018

        public static void AddRainDataSantaEmiliaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataSantaEmiliaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataSantaEmiliaPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataSantaEmiliaPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataSantaEmiliaPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataSantaEmiliaPivot7_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataSantaEmiliaPivotZP_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 57 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 57;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/09 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 09);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/12 27 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 12);
                lRainQuantity = 27;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/31 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 31);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/13 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 13);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/28 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 28);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 72 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 72;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/14 130 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 14);
                lRainQuantity = 130;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/16 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 16);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 70 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 70;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 12 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 12;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/01 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 01);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 68 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 68;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/14 90 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 14);
                lRainQuantity = 90;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 65 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 65;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/16 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 16);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion

        }

        #endregion

        #endregion

        #region GM - Gran Molino

        #region 2018

        public static void AddRainDataGranMolinoPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataGranMolinoPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGranMolinoPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGranMolinoPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGranMolinoPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/10/19 11 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 19);
                lRainQuantity = 11;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataGranMolinoPivot2b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2019/03/15 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 15);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataGranMolinoPivot5b_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2019/03/15 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 15);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion





        }

        #endregion

        #endregion

        #region LP - La Portuguesa

        #region 2018

        public static void AddRainDataLaPortuguesaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataLaPortuguesaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region CLP - Cassarino - La Perdiz

        #region 2018

        public static void AddRainDataCassarinoLaPerdizPivot11_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion




        }

        public static void AddRainDataCassarinoLaPerdizPivot12_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataCassarinoLaPerdizPivot13_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region SD - Santo Domingo

        #region 2018

        public static void AddRainDataSantoDomingoPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataSantoDomingoPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region CE - Cecchini

        #region 2018

        public static void AddRainDataCecchiniPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        public static void AddRainDataCecchiniPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/06 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 06);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        #endregion

        #endregion

        #region EA - El Alba

        #region 2018

        public static void AddRainDataElAlbaPivot32_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/24 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 24);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/10 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 10);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 115 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 115;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/16 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 16);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/17 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 17);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/27 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 27);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/01 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 01);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 160 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 160;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 116 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 116;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion



        }

        public static void AddRainDataElAlbaPivot33_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/09/23 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 23);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/29 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 29);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/09/30 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 09, 30);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/20 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 20);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/24 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 24);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/10/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 10, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/10 56 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 10);
                lRainQuantity = 56;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/11 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 11);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/12 115 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 12);
                lRainQuantity = 115;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/16 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 16);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/17 06 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 17);
                lRainQuantity = 6;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/11/27 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 11, 27);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/01 03 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 01);
                lRainQuantity = 3;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/09 08 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 09);
                lRainQuantity = 8;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/13 160 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 160;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/17 116 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 17);
                lRainQuantity = 116;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/20 26 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 20);
                lRainQuantity = 26;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2018/12/30 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 30);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 16 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 16;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 75 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 75;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion


        }

        #endregion

        #endregion

        #region LZ - La Zenaida

        #region 2018

        public static void AddRainDataLaZenaidaPivot1_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/18 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 18);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/07 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 07);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/27 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 27);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        }

        public static void AddRainDataLaZenaidaPivot2_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/18 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 18);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/07 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 07);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/27 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 27);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        
        }

        public static void AddRainDataLaZenaidaPivot3_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/18 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 18);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/07 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 07);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/27 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 27);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        
        }

        public static void AddRainDataLaZenaidaPivot4_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/18 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 18);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/07 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 07);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/27 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 27);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 21;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
        
        }

        public static void AddRainDataLaZenaidaPivot5_2018(IrrigationAdvisorContext context, DateTime pDateOfReference)
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

            #region Rain 2018/12/13 10 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2018, 12, 13);
                lRainQuantity = 10;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/02 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 02);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/07 50 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 07);
                lRainQuantity = 50;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/13 45 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 13);
                lRainQuantity = 45;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/15 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 15);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/18 20 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 18);
                lRainQuantity = 20;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/23 40 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 23);
                lRainQuantity = 40;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/27 25 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 27);
                lRainQuantity = 25;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/01/29 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 01, 29);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/11 30 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 11);
                lRainQuantity = 30;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/14 05 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 14);
                lRainQuantity = 5;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/02/23 85 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 02, 23);
                lRainQuantity = 85;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/03/18 120 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 03, 18);
                lRainQuantity = 120;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/07 15 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 07);
                lRainQuantity = 15;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/04/27 60 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 04, 27);
                lRainQuantity = 60;
                /////////////////////////////////////////////////////////////////////////////////////////////
                lCropIrrigationWeather.AddRainDataToList(lRainDate, lRainQuantity);
            }
            #endregion
            #region Rain 2019/05/05 21 mm
            foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeatherList)
            {
                //Data to change about Rain
                lRainDate = new DateTime(2019, 05, 05);
                lRainQuantity = 21;
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

            lCropIrrigationWeather.AddRainDataToList(new DateTime(2018, 11, 1), 10);

        }

        #endregion

    }
}
