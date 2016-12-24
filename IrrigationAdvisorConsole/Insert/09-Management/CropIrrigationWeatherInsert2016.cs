using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;

using IrrigationAdvisor.DBContext;

using IrrigationAdvisorConsole.Data;

namespace IrrigationAdvisorConsole.Insert._09_Management
{
    public static class CropIrrigationWeatherInsert2016
    {

        #region Management
#if true

        /// <summary>
        /// Insert CropIrrigationWeather:
        ///     - Use: Farm, WeatherStations, EffectiveRainList, Crop, CropCoefficient, 
        ///         KCList, CropInformationByDate, IrrigationUnit, Soil, HorizonList,
        ///         SowingDate, HarvestDate, CropDate, PredeterminatedIrrigationQuantity,
        ///         WeatherDataList.
        ///     - Set the initial Phenological Stage for the Crop
        ///     - Set Calculus Method for Phenological Adjustment
        ///     - Get Initial Hydric Balance
        ///     - Create the initial registry
        /// </summary>
        public static void InsertCropIrrigationWeather2016()
        {
            #region Local Variable
            Farm lFarm = null;
            Crop lCrop = null;
            Specie lSpecie = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            String lWeatherStationMainName = "";
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            String lWeatherStationAlternativeName = "";
            List<WeatherData> lAlternativeWeatherDataList = null;

            //This is used when we have two species in one CropIrrigationWeather
            Soil lSoil = null;
            List<Horizon> lHorizonList = null;
            CropInformationByDate lCropInformationByDate = null;
            List<EffectiveRain> lEffectiveRainList = null;
            CropCoefficient lCropCoefficient = null;
            List<KC> lKCList = null;
            DateTime lSowingDate;
            DateTime lHarvestDate;
            DateTime lCropDate;
            Double lPredeterminatedIrrigationQuantity;
            #endregion

            #region Base
            var lBase = new CropIrrigationWeather
            {
                CropId = 0,
                SoilId = 0,

                SowingDate = Program.DateOfReference.AddMonths(-1),
                HarvestDate = Program.DateOfReference.AddMonths(4),
                CropDate = DateTime.Now,

                PhenologicalStageId = 0,
                HydricBalance = 0,
                SoilHydricVolume = 0,
                TotalEvapotranspirationCropFromLastWaterInput = 0,

                CalculusMethodForPhenologicalAdjustment = Utils.CalculusOfPhenologicalStage.ByDaysAfterSowing,
                CropInformationByDate = lCropInformationByDate,
                DaysAfterSowing = 1,
                DaysAfterSowingModified = 1,
                GrowingDegreeDaysAccumulated = 0,
                GrowingDegreeDaysModified = 0,

                IrrigationUnitId = 0,
                PredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity,

                PositionId = 0,

                RainList = null,
                IrrigationList = null,
                EvapotranspirationCropList = null,

                LastWaterInputDate = Utils.MIN_DATETIME,
                LastBigWaterInputDate = Utils.MIN_DATETIME,
                LastPartialWaterInputDate = Utils.MIN_DATETIME,
                LastPartialWaterInput = 0,

                MainWeatherStationId = 0,
                AlternativeWeatherStationId = 0,
                UsingMainWeatherStation = true,
                WeatherEventType = Utils.WeatherEventType.None,

                //DailyRecordList = null,

                TotalEvapotranspirationCrop = 0,
                TotalEffectiveRain = 0,
                TotalRealRain = 0,
                TotalIrrigation = 0,
                TotalIrrigationInHydricBalance = 0,
                TotalExtraIrrigation = 0,
                TotalExtraIrrigationInHydricBalance = 0,

            };
            #endregion

            using (var context = new IrrigationAdvisorContext())
            {

                #region Santa Lucia

                //if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                //    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
                //{
                //    lWeatherStationMainName = DataEntry.WeatherStationAlternativeName_SantaLucia_2016;
                //    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_SantaLucia_2016;

                //    #region Santa Lucia Pivot 1 2016
                //    //////////////////////////////////////////////////////////////////////
                //    lFarm = (from farm in context.Farms
                //             where farm.Name == Utils.NameFarmSantaLucia
                //             select farm).FirstOrDefault();
                //    lWeatherStationMain = (from ws in context.WeatherStations
                //                           where ws.Name == lWeatherStationMainName
                //                           select ws).FirstOrDefault();
                //    lWeatherStationAlternative = (from ws in context.WeatherStations
                //                                  where ws.Name == lWeatherStationAlternativeName
                //                                  select ws).FirstOrDefault();
                //    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                //                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                //                          select effectiverain)
                //                         .ToList<EffectiveRain>();
                //    //////////////////////////////////////////////////////////////////////
                //    lSpecie = (from sp in context.Species
                //               where sp.Name == Utils.NameSpecieCornSouthShort
                //               select sp).FirstOrDefault();
                //    lCrop = (from crop in context.Crops
                //             where crop.Name == Utils.NameSpecieCornSouthShort
                //             select crop).FirstOrDefault();
                //    lCropCoefficient = (from cc in context.CropCoefficients
                //                        where cc.Name == Utils.NameSpecieCornSouthShort
                //                        select cc).FirstOrDefault();
                //    lPhenologicalStages = (from ps in context.PhenologicalStages
                //                           where ps.SpecieId == lSpecie.SpecieId
                //                           select ps).ToList<PhenologicalStage>();
                //    lKCList = (from cc in context.CropCoefficients
                //               where cc.Name == Utils.NameSpecieCornSouthShort
                //               select cc.KCList).FirstOrDefault();
                //    lCropInformationByDate = (from cid in context.CropInformationByDates
                //                              where cid.Name == Utils.NameSpecieCornSouthShort
                //                              select cid).FirstOrDefault();
                //    //////////////////////////////////////////////////////////////////////
                //    lIrrigationUnit = (from iu in context.Pivots
                //                       where iu.Name == Utils.NamePivotSantaLucia1
                //                       select iu).FirstOrDefault();
                //    lSoil = (from soil in context.Soils
                //             where soil.Name == Utils.NameSoilSantaLucia1
                //             select soil).FirstOrDefault();
                //    lHorizonList = (from horizon in context.Horizons
                //                    where horizon.Name.StartsWith(Utils.NamePivotSantaLucia1)
                //                    select horizon)
                //                    .ToList<Horizon>();
                //    lSowingDate = DataEntry.SowingDate_CornSouth_SantaLuciaPivot1_2016;
                //    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                //    lCropDate = DateTime.Now;
                //    if (DataEntry.PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2016 == 0)
                //    {
                //        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                //    }
                //    else
                //    {
                //        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2016;
                //    }
                //    lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                //                            join weatherstation in context.WeatherStations
                //                            on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                //                            where (weatherdata.Date >= lSowingDate ||
                //                                    weatherdata.Date <= lHarvestDate) &&
                //                                    weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                //                            select weatherdata).ToList<WeatherData>();
                //    lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                //                                   join weatherstation in context.WeatherStations
                //                                   on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                //                                   where (weatherdata.Date >= lSowingDate ||
                //                                        weatherdata.Date <= lHarvestDate) &&
                //                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                //                                   select weatherdata).ToList<WeatherData>();
                //    var lCIWSantaLuciaPivot1_2016 = new CropIrrigationWeather
                //    {
                //        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherSantaLuciaPivot1,
                //        CropId = lCrop.CropId,
                //        Crop = lCrop,
                //        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                //        IrrigationUnit = lIrrigationUnit,
                //        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                //        MainWeatherStation = lWeatherStationMain,

                //        WeatherEventType = Utils.WeatherEventType.LaNinia,

                //        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                //        AlternativeWeatherStation = lWeatherStationAlternative,
                //        PositionId = lFarm.PositionId,
                //        SoilId = lSoil.SoilId,
                //        Soil = lSoil,

                //        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                //        //Set the initial Phenological Stage for the Crop
                //        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                //        PhenologicalStage = lCrop.PhenologicalStageList[0],

                //        SowingDate = lSowingDate,
                //        HarvestDate = lHarvestDate,
                //        CropDate = lCropDate,
                //        DaysForHydricBalanceUnchangableAfterSowing = 0,

                //        //Get Effective Rain List from Region
                //        HydricBalance = 0,

                //        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                //        CropInformationByDate = lCropInformationByDate,

                //    };
                //    context.SaveChanges();

                //    lCIWSantaLuciaPivot1_2016.Soil.HorizonList = lHorizonList;

                //    //Set Calculus Method for Phenological Adjustment
                //    lCIWSantaLuciaPivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                //    //Get Initial Hydric Balance
                //    lCIWSantaLuciaPivot1_2016.HydricBalance = lCIWSantaLuciaPivot1_2016.GetInitialHydricBalance();
                //    //Create the initial registry
                //    lCIWSantaLuciaPivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                //    context.CropIrrigationWeathers.Add(lCIWSantaLuciaPivot1_2016);
                //    context.SaveChanges();

                //    //Save Titles for print
                //    foreach (var item in lCIWSantaLuciaPivot1_2016.Titles)
                //    {
                //        var lTitlesSantaLuciaPivot1_2016 = new Title
                //        {
                //            CropIrrigationWeatherId = lCIWSantaLuciaPivot1_2016.CropIrrigationWeatherId,
                //            CropIrrigationWeather = lCIWSantaLuciaPivot1_2016,
                //            Daily = false,
                //            Name = item.Name,
                //            Abbreviation = item.Abbreviation,
                //            Description = item.Description,
                //        };
                //        context.Titles.Add(lTitlesSantaLuciaPivot1_2016);
                //    }
                //    context.SaveChanges();
                //    long lFirstTitleIdSantaLuciaPivot1_2016 = (from title in context.Titles
                //                                               where title.Name == "DDS"
                //                                                  && title.Daily == false
                //                                                  && title.CropIrrigationWeatherId == lCIWSantaLuciaPivot1_2016.CropIrrigationWeatherId
                //                                               select title.TitleId).FirstOrDefault();
                //    long lTotalTitlesSantaLuciaPivot1_2016 = lCIWSantaLuciaPivot1_2016.Titles.Count();
                //    long lTitleIdSantaLuciaPivot1_2016 = lFirstTitleIdSantaLuciaPivot1_2016;
                //    //Update Messages Ids
                //    foreach (var item in lCIWSantaLuciaPivot1_2016.Messages)
                //    {
                //        item.TitleId = lTitleIdSantaLuciaPivot1_2016;
                //        lTitleIdSantaLuciaPivot1_2016 += 1;
                //        item.CropIrrigationWeatherId = lCIWSantaLuciaPivot1_2016.CropIrrigationWeatherId;
                //        if (lTotalTitlesSantaLuciaPivot1_2016 == lTitleIdSantaLuciaPivot1_2016 - lFirstTitleIdSantaLuciaPivot1_2016)
                //        {
                //            lTitleIdSantaLuciaPivot1_2016 = lFirstTitleIdSantaLuciaPivot1_2016;
                //        }
                //    }
                //    context.SaveChanges();
                //    #endregion

                //    #region Santa Lucia Pivot 2 2016

                //    #endregion

                //    #region Santa Lucia Pivot 3 2016

                //    #endregion

                //    #region Santa Lucia Pivot 4 2016

                //    #endregion

                //    #region Santa Lucia Pivot 5 2016

                //    #endregion
                //}
                #endregion

                #region DCA El Paraiso
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_DCAElParaiso_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_DCAElParaiso_2016;

                    #region DCA - El Paraiso Pivot 1 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCAElParaiso
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCAElParaiso1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCAElParaiso1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCAElParaiso1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCAElParaisoPivot1_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCAElParaisoPivot1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCAElParaisoPivot1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCAElParaisoPivot1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot1 2016
                    var lCIWDCAElParaisoPivot1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCAElParaisoPivot1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCAElParaisoPivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCAElParaisoPivot1_2016.HydricBalance = lCIWDCAElParaisoPivot1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCAElParaisoPivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCAElParaisoPivot1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCAElParaisoPivot1_2016.Titles)
                    {
                        var lTitlesDCAElParaisoPivot1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCAElParaisoPivot1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCAElParaisoPivot1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCAElParaisoPivot1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCAElParaisoPivot1_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCAElParaisoPivot1_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCAElParaisoPivot1_2016 = lCIWDCAElParaisoPivot1_2016.Titles.Count();
                    long lTitleIdDCAElParaisoPivot1_2016 = lFirstTitleIdDCAElParaisoPivot1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCAElParaisoPivot1_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCAElParaisoPivot1_2016;
                        lTitleIdDCAElParaisoPivot1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCAElParaisoPivot1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCAElParaisoPivot1_2016 - lFirstTitleIdDCAElParaisoPivot1_2016) % (lTotalTitlesDCAElParaisoPivot1_2016) == 0)
                        {
                            lTitleIdDCAElParaisoPivot1_2016 = lFirstTitleIdDCAElParaisoPivot1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - El Paraiso Pivot 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCAElParaiso
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCAElParaiso2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCAElParaiso2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCAElParaiso2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCAElParaisoPivot2_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCAElParaisoPivot2_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCAElParaisoPivot2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCAElParaisoPivot2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot2 2016
                    var lCIWDCAElParaisoPivot2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCAElParaisoPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCAElParaisoPivot2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCAElParaisoPivot2_2016.HydricBalance = lCIWDCAElParaisoPivot2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCAElParaisoPivot2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCAElParaisoPivot2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCAElParaisoPivot2_2016.Titles)
                    {
                        var lTitlesDCAElParaisoPivot2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCAElParaisoPivot2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCAElParaisoPivot2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCAElParaisoPivot2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCAElParaisoPivot2_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCAElParaisoPivot2_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCAElParaisoPivot2_2016 = lCIWDCAElParaisoPivot2_2016.Titles.Count();
                    long lTitleIdDCAElParaisoPivot2_2016 = lFirstTitleIdDCAElParaisoPivot2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCAElParaisoPivot2_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCAElParaisoPivot2_2016;
                        lTitleIdDCAElParaisoPivot2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCAElParaisoPivot2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCAElParaisoPivot2_2016 - lFirstTitleIdDCAElParaisoPivot2_2016) % (lTotalTitlesDCAElParaisoPivot2_2016) == 0)
                        {
                            lTitleIdDCAElParaisoPivot2_2016 = lFirstTitleIdDCAElParaisoPivot2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    

                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz10b
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz10b)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DCALaPerdizPivot10b_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DCALaPerdizPivot10b_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot10b_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot10b_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot10b 2016
                    var lCIWDCALaPerdizPivot10b_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot10b,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot10b_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot10b_2016.HydricBalance = lCIWDCALaPerdizPivot10b_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot10b_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot10b_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot10b_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot10b_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot10b_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot10b_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot10b_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot10b_2016 = (from title in context.Titles
                                                                  where title.Name == "DDS"
                                                                     && title.Daily == false
                                                                     && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot10b_2016.CropIrrigationWeatherId
                                                                  select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot10b_2016 = lCIWDCALaPerdizPivot10b_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot10b_2016 = lFirstTitleIdDCALaPerdizPivot10b_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot10b_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot10b_2016;
                        lTitleIdDCALaPerdizPivot10b_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot10b_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot10b_2016 - lFirstTitleIdDCALaPerdizPivot10b_2016) % (lTotalTitlesDCALaPerdizPivot10b_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot10b_2016 = lFirstTitleIdDCALaPerdizPivot10b_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - La Perdiz Pivot 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCALaPerdizPivot2_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCALaPerdizPivot2_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot2 2016
                    var lCIWDCALaPerdizPivot2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot2_2016.HydricBalance = lCIWDCALaPerdizPivot2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot2_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot2_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot2_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot2_2016 = lCIWDCALaPerdizPivot2_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot2_2016 = lFirstTitleIdDCALaPerdizPivot2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot2_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot2_2016;
                        lTitleIdDCALaPerdizPivot2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot2_2016 - lFirstTitleIdDCALaPerdizPivot2_2016) % (lTotalTitlesDCALaPerdizPivot2_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot2_2016 = lFirstTitleIdDCALaPerdizPivot2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - La Perdiz Pivot 3 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCALaPerdizPivot3_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCALaPerdizPivot3_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot3_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot3_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot3 2016
                    var lCIWDCALaPerdizPivot3_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot3_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot3_2016.HydricBalance = lCIWDCALaPerdizPivot3_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot3_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot3_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot3_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot3_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot3_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot3_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot3_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot3_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot3_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot3_2016 = lCIWDCALaPerdizPivot3_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot3_2016 = lFirstTitleIdDCALaPerdizPivot3_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot3_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot3_2016;
                        lTitleIdDCALaPerdizPivot3_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot3_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot3_2016 - lFirstTitleIdDCALaPerdizPivot3_2016) % (lTotalTitlesDCALaPerdizPivot3_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot3_2016 = lFirstTitleIdDCALaPerdizPivot3_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - La Perdiz Pivot 5 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz5
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz5)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCALaPerdizPivot5_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCALaPerdizPivot5_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot5_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot5_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot5 2016
                    var lCIWDCALaPerdizPivot5_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot5_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot5_2016.HydricBalance = lCIWDCALaPerdizPivot5_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot5_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot5_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot5_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot5_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot5_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot5_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot5_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot5_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot5_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot5_2016 = lCIWDCALaPerdizPivot5_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot5_2016 = lFirstTitleIdDCALaPerdizPivot5_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot5_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot5_2016;
                        lTitleIdDCALaPerdizPivot5_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot5_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot5_2016 - lFirstTitleIdDCALaPerdizPivot5_2016) % (lTotalTitlesDCALaPerdizPivot5_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot5_2016 = lFirstTitleIdDCALaPerdizPivot5_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz15
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz15)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DCALaPerdizPivot15_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DCALaPerdizPivot15_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot15_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot15_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot15 2016
                    var lCIWDCALaPerdizPivot15_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot15,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot15_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot15_2016.HydricBalance = lCIWDCALaPerdizPivot15_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot15_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot15_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot15_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot15_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot15_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot15_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot15_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot15_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot15_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot15_2016 = lCIWDCALaPerdizPivot15_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot15_2016 = lFirstTitleIdDCALaPerdizPivot15_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot15_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot15_2016;
                        lTitleIdDCALaPerdizPivot15_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot15_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot15_2016 - lFirstTitleIdDCALaPerdizPivot15_2016) % (lTotalTitlesDCALaPerdizPivot15_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot15_2016 = lFirstTitleIdDCALaPerdizPivot15_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - La Perdiz Pivot 7 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz7
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz7
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz7)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCALaPerdizPivot7_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCALaPerdizPivot7_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot7_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot7_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot7 2016
                    var lCIWDCALaPerdizPivot7_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot7,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot7_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot7_2016.HydricBalance = lCIWDCALaPerdizPivot7_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot7_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot7_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot7_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot7_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot7_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot7_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot7_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot7_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot7_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot7_2016 = lCIWDCALaPerdizPivot7_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot7_2016 = lFirstTitleIdDCALaPerdizPivot7_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot7_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot7_2016;
                        lTitleIdDCALaPerdizPivot7_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot7_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot7_2016 - lFirstTitleIdDCALaPerdizPivot7_2016) % (lTotalTitlesDCALaPerdizPivot7_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot7_2016 = lFirstTitleIdDCALaPerdizPivot7_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DCASanJosePivot1_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DCASanJosePivot1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA SanJose Pivot1 2016
                    var lCIWDCASanJosePivot1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCASanJosePivot1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCASanJosePivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCASanJosePivot1_2016.HydricBalance = lCIWDCASanJosePivot1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCASanJosePivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCASanJosePivot1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCASanJosePivot1_2016.Titles)
                    {
                        var lTitlesDCASanJosePivot1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCASanJosePivot1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCASanJosePivot1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCASanJosePivot1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCASanJosePivot1_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWDCASanJosePivot1_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCASanJosePivot1_2016 = lCIWDCASanJosePivot1_2016.Titles.Count();
                    long lTitleIdDCASanJosePivot1_2016 = lFirstTitleIdDCASanJosePivot1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCASanJosePivot1_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCASanJosePivot1_2016;
                        lTitleIdDCASanJosePivot1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCASanJosePivot1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCASanJosePivot1_2016 - lFirstTitleIdDCASanJosePivot1_2016) % (lTotalTitlesDCASanJosePivot1_2016) == 0)
                        {
                            lTitleIdDCASanJosePivot1_2016 = lFirstTitleIdDCASanJosePivot1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - La Perdiz Pivot 14 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCALaPerdiz14
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCALaPerdiz14
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCALaPerdiz14)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCALaPerdizPivot14_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCALaPerdizPivot14_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot14_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCALaPerdizPivot14_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA LaPerdiz Pivot14 2016
                    var lCIWDCALaPerdizPivot14_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot14,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCALaPerdizPivot14_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCALaPerdizPivot14_2016.HydricBalance = lCIWDCALaPerdizPivot14_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCALaPerdizPivot14_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCALaPerdizPivot14_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCALaPerdizPivot14_2016.Titles)
                    {
                        var lTitlesDCALaPerdizPivot14_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCALaPerdizPivot14_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCALaPerdizPivot14_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCALaPerdizPivot14_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCALaPerdizPivot14_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWDCALaPerdizPivot14_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCALaPerdizPivot14_2016 = lCIWDCALaPerdizPivot14_2016.Titles.Count();
                    long lTitleIdDCALaPerdizPivot14_2016 = lFirstTitleIdDCALaPerdizPivot14_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCALaPerdizPivot14_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCALaPerdizPivot14_2016;
                        lTitleIdDCALaPerdizPivot14_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCALaPerdizPivot14_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCALaPerdizPivot14_2016 - lFirstTitleIdDCALaPerdizPivot14_2016) % (lTotalTitlesDCALaPerdizPivot14_2016) == 0)
                        {
                            lTitleIdDCALaPerdizPivot14_2016 = lFirstTitleIdDCALaPerdizPivot14_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DCASanJosePivot4_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DCASanJosePivot4_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot4_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot4_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA SanJose Pivot4 2016
                    var lCIWDCASanJosePivot4_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCASanJosePivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCASanJosePivot4_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCASanJosePivot4_2016.HydricBalance = lCIWDCASanJosePivot4_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCASanJosePivot4_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCASanJosePivot4_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCASanJosePivot4_2016.Titles)
                    {
                        var lTitlesDCASanJosePivot4_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCASanJosePivot4_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCASanJosePivot4_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCASanJosePivot4_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCASanJosePivot4_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWDCASanJosePivot4_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCASanJosePivot4_2016 = lCIWDCASanJosePivot4_2016.Titles.Count();
                    long lTitleIdDCASanJosePivot4_2016 = lFirstTitleIdDCASanJosePivot4_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCASanJosePivot4_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCASanJosePivot4_2016;
                        lTitleIdDCASanJosePivot4_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCASanJosePivot4_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCASanJosePivot4_2016 - lFirstTitleIdDCASanJosePivot4_2016) % (lTotalTitlesDCASanJosePivot4_2016) == 0)
                        {
                            lTitleIdDCASanJosePivot4_2016 = lFirstTitleIdDCASanJosePivot4_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                }
                #endregion

                #region DCA San Jose
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_DCASanJose_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_DCASanJose_2016;

                    #region DCA - San Jose Pivot 1 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DCASanJosePivot1_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DCASanJosePivot1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA SanJose Pivot1 2016
                    var lCIWDCASanJosePivot1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCASanJosePivot1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCASanJosePivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCASanJosePivot1_2016.HydricBalance = lCIWDCASanJosePivot1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCASanJosePivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCASanJosePivot1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCASanJosePivot1_2016.Titles)
                    {
                        var lTitlesDCASanJosePivot1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCASanJosePivot1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCASanJosePivot1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCASanJosePivot1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCASanJosePivot1_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWDCASanJosePivot1_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCASanJosePivot1_2016 = lCIWDCASanJosePivot1_2016.Titles.Count();
                    long lTitleIdDCASanJosePivot1_2016 = lFirstTitleIdDCASanJosePivot1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCASanJosePivot1_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCASanJosePivot1_2016;
                        lTitleIdDCASanJosePivot1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCASanJosePivot1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCASanJosePivot1_2016 - lFirstTitleIdDCASanJosePivot1_2016) % (lTotalTitlesDCASanJosePivot1_2016) == 0)
                        {
                            lTitleIdDCASanJosePivot1_2016 = lFirstTitleIdDCASanJosePivot1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - San Jose Pivot 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCASanJosePivot2_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCASanJosePivot2_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA SanJose Pivot2 2016
                    var lCIWDCASanJosePivot2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCASanJosePivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCASanJosePivot2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCASanJosePivot2_2016.HydricBalance = lCIWDCASanJosePivot2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCASanJosePivot2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCASanJosePivot2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCASanJosePivot2_2016.Titles)
                    {
                        var lTitlesDCASanJosePivot2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCASanJosePivot2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCASanJosePivot2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCASanJosePivot2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCASanJosePivot2_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWDCASanJosePivot2_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCASanJosePivot2_2016 = lCIWDCASanJosePivot2_2016.Titles.Count();
                    long lTitleIdDCASanJosePivot2_2016 = lFirstTitleIdDCASanJosePivot2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCASanJosePivot2_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCASanJosePivot2_2016;
                        lTitleIdDCASanJosePivot2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCASanJosePivot2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCASanJosePivot2_2016 - lFirstTitleIdDCASanJosePivot2_2016) % (lTotalTitlesDCASanJosePivot2_2016) == 0)
                        {
                            lTitleIdDCASanJosePivot2_2016 = lFirstTitleIdDCASanJosePivot2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - San Jose Pivot 3 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaSouth_DCASanJosePivot3_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaSouth_DCASanJosePivot3_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot3_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot3_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA SanJose Pivot3 2016
                    var lCIWDCASanJosePivot3_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCASanJosePivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCASanJosePivot3_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCASanJosePivot3_2016.HydricBalance = lCIWDCASanJosePivot3_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCASanJosePivot3_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCASanJosePivot3_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCASanJosePivot3_2016.Titles)
                    {
                        var lTitlesDCASanJosePivot3_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCASanJosePivot3_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCASanJosePivot3_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCASanJosePivot3_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCASanJosePivot3_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWDCASanJosePivot3_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCASanJosePivot3_2016 = lCIWDCASanJosePivot3_2016.Titles.Count();
                    long lTitleIdDCASanJosePivot3_2016 = lFirstTitleIdDCASanJosePivot3_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCASanJosePivot3_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCASanJosePivot3_2016;
                        lTitleIdDCASanJosePivot3_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCASanJosePivot3_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCASanJosePivot3_2016 - lFirstTitleIdDCASanJosePivot3_2016) % (lTotalTitlesDCASanJosePivot3_2016) == 0)
                        {
                            lTitleIdDCASanJosePivot3_2016 = lFirstTitleIdDCASanJosePivot3_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                    #region DCA - San Jose Pivot 4 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCASanJose
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDCASanJose4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDCASanJose4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDCASanJose4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DCASanJosePivot4_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DCASanJosePivot4_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot4_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DCASanJosePivot4_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DCA SanJose Pivot4 2016
                    var lCIWDCASanJosePivot4_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCASanJosePivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDCASanJosePivot4_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDCASanJosePivot4_2016.HydricBalance = lCIWDCASanJosePivot4_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDCASanJosePivot4_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDCASanJosePivot4_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDCASanJosePivot4_2016.Titles)
                    {
                        var lTitlesDCASanJosePivot4_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDCASanJosePivot4_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDCASanJosePivot4_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDCASanJosePivot4_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDCASanJosePivot4_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWDCASanJosePivot4_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDCASanJosePivot4_2016 = lCIWDCASanJosePivot4_2016.Titles.Count();
                    long lTitleIdDCASanJosePivot4_2016 = lFirstTitleIdDCASanJosePivot4_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDCASanJosePivot4_2016.Messages)
                    {
                        item.TitleId = lTitleIdDCASanJosePivot4_2016;
                        lTitleIdDCASanJosePivot4_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDCASanJosePivot4_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDCASanJosePivot4_2016 - lFirstTitleIdDCASanJosePivot4_2016) % (lTotalTitlesDCASanJosePivot4_2016) == 0)
                        {
                            lTitleIdDCASanJosePivot4_2016 = lFirstTitleIdDCASanJosePivot4_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_DelLagoSanPedro_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_DelLagoSanPedro_2016;


                    #region Del Lago - San Pedro Pivot 5 2016
                    //#region Farm //////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoSanPedro
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop //////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieCornSouthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture //////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoSanPedro5
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoSanPedro5
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro5)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot5_2016;
                    //lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2016;
                    //}
                    //#endregion
                    //#region Weather Data
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW Del Lago - San Pedro Pivot 5 2016
                    //var lCIWDelLagoSanPedroPivot5_2016 = new CropIrrigationWeather
                    //{
                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot5,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    WeatherEventType = Utils.WeatherEventType.LaNinia,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWDelLagoSanPedroPivot5_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWDelLagoSanPedroPivot5_2016.HydricBalance = lCIWDelLagoSanPedroPivot5_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWDelLagoSanPedroPivot5_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot5_2016);
                    //context.SaveChanges();
                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWDelLagoSanPedroPivot5_2016.Titles)
                    //{
                    //    var lTitlesDelLagoSanPedroPivot5_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot5_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWDelLagoSanPedroPivot5_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesDelLagoSanPedroPivot5_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdDelLagoSanPedroPivot5_2016 = (from title in context.Titles
                    //                                                where title.Name == "DDS"
                    //                                                   && title.Daily == false
                    //                                                   && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot5_2016.CropIrrigationWeatherId
                    //                                                select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesDelLagoSanPedroPivot5_2016 = lCIWDelLagoSanPedroPivot5_2016.Titles.Count();
                    //long lTitleIdDelLagoSanPedroPivot5_2016 = lFirstTitleIdDelLagoSanPedroPivot5_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWDelLagoSanPedroPivot5_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdDelLagoSanPedroPivot5_2016;
                    //    lTitleIdDelLagoSanPedroPivot5_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot5_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdDelLagoSanPedroPivot5_2016 - lFirstTitleIdDelLagoSanPedroPivot5_2016) % (lTotalTitlesDelLagoSanPedroPivot5_2016) == 0)
                    //    {
                    //        lTitleIdDelLagoSanPedroPivot5_2016 = lFirstTitleIdDelLagoSanPedroPivot5_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion
                    #endregion

                    #region Del Lago - San Pedro Pivot 6 2016

                    //#region Farm //////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoSanPedro
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop //////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieCornSouthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture //////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoSanPedro6
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoSanPedro6
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro6)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot6_2016;
                    //lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2016;
                    //}
                    //#endregion
                    //#region Weather Data
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW Del Lago - San Pedro Pivot 6 2016
                    //var lCIWDelLagoSanPedroPivot6_2016 = new CropIrrigationWeather
                    //{
                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot6,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    WeatherEventType = Utils.WeatherEventType.LaNinia,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWDelLagoSanPedroPivot6_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWDelLagoSanPedroPivot6_2016.HydricBalance = lCIWDelLagoSanPedroPivot6_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWDelLagoSanPedroPivot6_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot6_2016);
                    //context.SaveChanges();
                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWDelLagoSanPedroPivot6_2016.Titles)
                    //{
                    //    var lTitlesDelLagoSanPedroPivot6_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot6_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWDelLagoSanPedroPivot6_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesDelLagoSanPedroPivot6_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdDelLagoSanPedroPivot6_2016 = (from title in context.Titles
                    //                                                where title.Name == "DDS"
                    //                                                   && title.Daily == false
                    //                                                   && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot6_2016.CropIrrigationWeatherId
                    //                                                select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesDelLagoSanPedroPivot6_2016 = lCIWDelLagoSanPedroPivot6_2016.Titles.Count();
                    //long lTitleIdDelLagoSanPedroPivot6_2016 = lFirstTitleIdDelLagoSanPedroPivot6_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWDelLagoSanPedroPivot6_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdDelLagoSanPedroPivot6_2016;
                    //    lTitleIdDelLagoSanPedroPivot6_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot6_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdDelLagoSanPedroPivot6_2016 - lFirstTitleIdDelLagoSanPedroPivot6_2016) % (lTotalTitlesDelLagoSanPedroPivot6_2016) == 0)
                    //    {
                    //        lTitleIdDelLagoSanPedroPivot6_2016 = lFirstTitleIdDelLagoSanPedroPivot6_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion

                    #endregion

                    #region Del Lago - San Pedro Pivot 7 2016

                    //#region Farm //////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoSanPedro
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop //////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieCornSouthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture //////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoSanPedro7
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoSanPedro7
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro7)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot7_2016;
                    //lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2016;
                    //}
                    //#endregion
                    //#region Weather Data 
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW Del Lago - San Pedro Pivot 7 2016
                    //var lCIWDelLagoSanPedroPivot7_2016 = new CropIrrigationWeather
                    //{
                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot7,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWDelLagoSanPedroPivot7_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWDelLagoSanPedroPivot7_2016.HydricBalance = lCIWDelLagoSanPedroPivot7_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWDelLagoSanPedroPivot7_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot7_2016);
                    //context.SaveChanges();
                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWDelLagoSanPedroPivot7_2016.Titles)
                    //{
                    //    var lTitlesDelLagoSanPedroPivot7_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot7_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWDelLagoSanPedroPivot7_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesDelLagoSanPedroPivot7_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdDelLagoSanPedroPivot7_2016 = (from title in context.Titles
                    //                                                where title.Name == "DDS"
                    //                                                   && title.Daily == false
                    //                                                   && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot7_2016.CropIrrigationWeatherId
                    //                                                select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesDelLagoSanPedroPivot7_2016 = lCIWDelLagoSanPedroPivot7_2016.Titles.Count();
                    //long lTitleIdDelLagoSanPedroPivot7_2016 = lFirstTitleIdDelLagoSanPedroPivot7_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWDelLagoSanPedroPivot7_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdDelLagoSanPedroPivot7_2016;
                    //    lTitleIdDelLagoSanPedroPivot7_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot7_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdDelLagoSanPedroPivot7_2016 - lFirstTitleIdDelLagoSanPedroPivot7_2016) % (lTotalTitlesDelLagoSanPedroPivot7_2016) == 0)
                    //    {
                    //        lTitleIdDelLagoSanPedroPivot7_2016 = lFirstTitleIdDelLagoSanPedroPivot7_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion

                    #endregion

                    #region Del Lago - San Pedro Pivot 8 2016

                    //#region Farm ////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmDelLagoSanPedro
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop ////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieCornSouthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieCornSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieCornSouthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieCornSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieCornSouthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture ////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotDelLagoSanPedro8
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilDelLagoSanPedro8
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro8)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoSanPedroPivot8_2016;
                    //lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2016;
                    //}
                    //#endregion
                    //#region Weather Data
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW Del Lago - San Pedro Pivot 8 2016
                    //var lCIWDelLagoSanPedroPivot8_2016 = new CropIrrigationWeather
                    //{
                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot8,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWDelLagoSanPedroPivot8_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWDelLagoSanPedroPivot8_2016.HydricBalance = lCIWDelLagoSanPedroPivot8_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWDelLagoSanPedroPivot8_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot8_2016);
                    //context.SaveChanges();
                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWDelLagoSanPedroPivot8_2016.Titles)
                    //{
                    //    var lTitlesDelLagoSanPedroPivot8_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot8_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWDelLagoSanPedroPivot8_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesDelLagoSanPedroPivot8_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdDelLagoSanPedroPivot8_2016 = (from title in context.Titles
                    //                                                where title.Name == "DDS"
                    //                                                   && title.Daily == false
                    //                                                   && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot8_2016.CropIrrigationWeatherId
                    //                                                select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesDelLagoSanPedroPivot8_2016 = lCIWDelLagoSanPedroPivot8_2016.Titles.Count();
                    //long lTitleIdDelLagoSanPedroPivot8_2016 = lFirstTitleIdDelLagoSanPedroPivot8_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWDelLagoSanPedroPivot8_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdDelLagoSanPedroPivot8_2016;
                    //    lTitleIdDelLagoSanPedroPivot8_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot8_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdDelLagoSanPedroPivot8_2016 - lFirstTitleIdDelLagoSanPedroPivot8_2016) % (lTotalTitlesDelLagoSanPedroPivot8_2016) == 0)
                    //    {
                    //        lTitleIdDelLagoSanPedroPivot8_2016 = lFirstTitleIdDelLagoSanPedroPivot8_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion

                    #endregion
                }
                #endregion

                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_DelLagoElMirador_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_DelLagoElMirador_2016;

                    #region Del Lago - El Mirador Pivot 1 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot1_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot1 2016
                    var lCIWDelLagoElMiradorPivot1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot1_2016.HydricBalance = lCIWDelLagoElMiradorPivot1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot1_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot1_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot1_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot1_2016 = lCIWDelLagoElMiradorPivot1_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot1_2016 = lFirstTitleIdDelLagoElMiradorPivot1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot1_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot1_2016;
                        lTitleIdDelLagoElMiradorPivot1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot1_2016 - lFirstTitleIdDelLagoElMiradorPivot1_2016) % (lTotalTitlesDelLagoElMiradorPivot1_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot1_2016 = lFirstTitleIdDelLagoElMiradorPivot1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot2_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot2_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot2 2016
                    var lCIWDelLagoElMiradorPivot2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot2_2016.HydricBalance = lCIWDelLagoElMiradorPivot2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot2_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot2_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot2_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot2_2016 = lCIWDelLagoElMiradorPivot2_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot2_2016 = lFirstTitleIdDelLagoElMiradorPivot2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot2_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot1_2016;
                        lTitleIdDelLagoElMiradorPivot2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot2_2016 - lFirstTitleIdDelLagoElMiradorPivot2_2016) % (lTotalTitlesDelLagoElMiradorPivot2_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot2_2016 = lFirstTitleIdDelLagoElMiradorPivot2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 3 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot3_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot3_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot3_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot3_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot3 2016
                    var lCIWDelLagoElMiradorPivot3_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot3_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot3_2016.HydricBalance = lCIWDelLagoElMiradorPivot3_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot3_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot3_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot3_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot3_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot3_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot3_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot3_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot3_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot3_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot3_2016 = lCIWDelLagoElMiradorPivot3_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot3_2016 = lFirstTitleIdDelLagoElMiradorPivot3_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot3_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot3_2016;
                        lTitleIdDelLagoElMiradorPivot3_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot3_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot3_2016 - lFirstTitleIdDelLagoElMiradorPivot3_2016) % (lTotalTitlesDelLagoElMiradorPivot3_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot3_2016 = lFirstTitleIdDelLagoElMiradorPivot3_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 4 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot4_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot4_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot4_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot4_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot4 2016
                    var lCIWDelLagoElMiradorPivot4_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot4_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot4_2016.HydricBalance = lCIWDelLagoElMiradorPivot4_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot4_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot4_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot4_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot4_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot4_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot4_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot4_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot4_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot4_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot4_2016 = lCIWDelLagoElMiradorPivot4_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot4_2016 = lFirstTitleIdDelLagoElMiradorPivot4_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot4_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot4_2016;
                        lTitleIdDelLagoElMiradorPivot4_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot4_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot4_2016 - lFirstTitleIdDelLagoElMiradorPivot4_2016) % (lTotalTitlesDelLagoElMiradorPivot4_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot4_2016 = lFirstTitleIdDelLagoElMiradorPivot4_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 5 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador5
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador5)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot5_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot5_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot5_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot5_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot5 2016
                    var lCIWDelLagoElMiradorPivot5_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot5_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot5_2016.HydricBalance = lCIWDelLagoElMiradorPivot5_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot5_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot5_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot5_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot5_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot5_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot5_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot5_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot5_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot5_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot5_2016 = lCIWDelLagoElMiradorPivot5_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot5_2016 = lFirstTitleIdDelLagoElMiradorPivot5_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot5_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot5_2016;
                        lTitleIdDelLagoElMiradorPivot5_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot5_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot5_2016 - lFirstTitleIdDelLagoElMiradorPivot5_2016) % (lTotalTitlesDelLagoElMiradorPivot5_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot5_2016 = lFirstTitleIdDelLagoElMiradorPivot5_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 6 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador6
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador6
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador6)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot6_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot6_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot6 2016
                    var lCIWDelLagoElMiradorPivot6_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot6,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot6_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot6_2016.HydricBalance = lCIWDelLagoElMiradorPivot6_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot6_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot6_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot6_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot6_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot6_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot6_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot6_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot6_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot6_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot6_2016 = lCIWDelLagoElMiradorPivot6_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot6_2016 = lFirstTitleIdDelLagoElMiradorPivot6_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot6_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot6_2016;
                        lTitleIdDelLagoElMiradorPivot6_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot6_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot6_2016 - lFirstTitleIdDelLagoElMiradorPivot6_2016) % (lTotalTitlesDelLagoElMiradorPivot6_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot6_2016 = lFirstTitleIdDelLagoElMiradorPivot6_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 7 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador7
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador7
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador7)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot7_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot7_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot7 2016
                    var lCIWDelLagoElMiradorPivot7_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot7,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot7_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot7_2016.HydricBalance = lCIWDelLagoElMiradorPivot7_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot7_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot7_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot7_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot7_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot7_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot7_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot7_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot7_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot7_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot7_2016 = lCIWDelLagoElMiradorPivot7_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot7_2016 = lFirstTitleIdDelLagoElMiradorPivot7_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot7_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot7_2016;
                        lTitleIdDelLagoElMiradorPivot7_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot7_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot7_2016 - lFirstTitleIdDelLagoElMiradorPivot7_2016) % (lTotalTitlesDelLagoElMiradorPivot7_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot7_2016 = lFirstTitleIdDelLagoElMiradorPivot7_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 8 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador8
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador8
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador8)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot8_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot8_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot8 2016
                    var lCIWDelLagoElMiradorPivot8_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot8,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot8_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot8_2016.HydricBalance = lCIWDelLagoElMiradorPivot8_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot8_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot8_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot8_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot8_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot8_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot8_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot8_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot8_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot8_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot8_2016 = lCIWDelLagoElMiradorPivot8_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot8_2016 = lFirstTitleIdDelLagoElMiradorPivot8_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot8_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot8_2016;
                        lTitleIdDelLagoElMiradorPivot8_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot8_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot8_2016 - lFirstTitleIdDelLagoElMiradorPivot8_2016) % (lTotalTitlesDelLagoElMiradorPivot8_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot8_2016 = lFirstTitleIdDelLagoElMiradorPivot8_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 9 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador9
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador9
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador9)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot9_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot9_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot9 2016
                    var lCIWDelLagoElMiradorPivot9_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot9,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot9_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot9_2016.HydricBalance = lCIWDelLagoElMiradorPivot9_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot9_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot9_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot9_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot9_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot9_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot9_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot9_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot9_2016 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot9_2016.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot9_2016 = lCIWDelLagoElMiradorPivot9_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot9_2016 = lFirstTitleIdDelLagoElMiradorPivot9_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot9_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot9_2016;
                        lTitleIdDelLagoElMiradorPivot9_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot9_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot9_2016 - lFirstTitleIdDelLagoElMiradorPivot9_2016) % (lTotalTitlesDelLagoElMiradorPivot9_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot9_2016 = lFirstTitleIdDelLagoElMiradorPivot9_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 10 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador10
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador10
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador10)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot10_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot10_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot10_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot10_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot10 2016
                    var lCIWDelLagoElMiradorPivot10_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot10,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot10_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot10_2016.HydricBalance = lCIWDelLagoElMiradorPivot10_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot10_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot10_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot10_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot10_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot10_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot10_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot10_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot10_2016 = (from title in context.Titles
                                                                      where title.Name == "DDS"
                                                                         && title.Daily == false
                                                                         && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot10_2016.CropIrrigationWeatherId
                                                                      select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot10_2016 = lCIWDelLagoElMiradorPivot10_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot10_2016 = lFirstTitleIdDelLagoElMiradorPivot10_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot10_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot10_2016;
                        lTitleIdDelLagoElMiradorPivot10_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot10_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot10_2016 - lFirstTitleIdDelLagoElMiradorPivot10_2016) % (lTotalTitlesDelLagoElMiradorPivot10_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot10_2016 = lFirstTitleIdDelLagoElMiradorPivot10_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 11 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador11
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador11
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador11)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot11_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot11_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot11_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot11_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot11 2016
                    var lCIWDelLagoElMiradorPivot11_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot11,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot11_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot11_2016.HydricBalance = lCIWDelLagoElMiradorPivot11_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot11_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot11_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot11_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot11_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot11_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot11_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot11_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot11_2016 = (from title in context.Titles
                                                                      where title.Name == "DDS"
                                                                         && title.Daily == false
                                                                         && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot11_2016.CropIrrigationWeatherId
                                                                      select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot11_2016 = lCIWDelLagoElMiradorPivot11_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot11_2016 = lFirstTitleIdDelLagoElMiradorPivot11_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot11_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot11_2016;
                        lTitleIdDelLagoElMiradorPivot11_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot11_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot11_2016 - lFirstTitleIdDelLagoElMiradorPivot11_2016) % (lTotalTitlesDelLagoElMiradorPivot11_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot11_2016 = lFirstTitleIdDelLagoElMiradorPivot11_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 12 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador12
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador12
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador12)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot12_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot12_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot12_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot12_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot12 2016
                    var lCIWDelLagoElMiradorPivot12_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot12,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot12_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot12_2016.HydricBalance = lCIWDelLagoElMiradorPivot12_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot12_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot12_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot12_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot12_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot12_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot12_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot12_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot12_2016 = (from title in context.Titles
                                                                      where title.Name == "DDS"
                                                                         && title.Daily == false
                                                                         && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot12_2016.CropIrrigationWeatherId
                                                                      select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot12_2016 = lCIWDelLagoElMiradorPivot12_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot12_2016 = lFirstTitleIdDelLagoElMiradorPivot12_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot12_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot12_2016;
                        lTitleIdDelLagoElMiradorPivot12_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot12_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot12_2016 - lFirstTitleIdDelLagoElMiradorPivot12_2016) % (lTotalTitlesDelLagoElMiradorPivot12_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot12_2016 = lFirstTitleIdDelLagoElMiradorPivot12_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 13 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador13
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador13
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador13)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot13_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot13_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot13_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot13_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot13 2016
                    var lCIWDelLagoElMiradorPivot13_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot13,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot13_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot13_2016.HydricBalance = lCIWDelLagoElMiradorPivot13_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot13_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot13_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot13_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot13_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot13_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot13_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot13_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot13_2016 = (from title in context.Titles
                                                                      where title.Name == "DDS"
                                                                         && title.Daily == false
                                                                         && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot13_2016.CropIrrigationWeatherId
                                                                      select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot13_2016 = lCIWDelLagoElMiradorPivot13_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot13_2016 = lFirstTitleIdDelLagoElMiradorPivot13_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot13_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot13_2016;
                        lTitleIdDelLagoElMiradorPivot13_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot13_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot13_2016 - lFirstTitleIdDelLagoElMiradorPivot13_2016) % (lTotalTitlesDelLagoElMiradorPivot13_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot13_2016 = lFirstTitleIdDelLagoElMiradorPivot13_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 14 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador14
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador14
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador14)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot14_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot14_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot14_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot14_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot14 2016
                    var lCIWDelLagoElMiradorPivot14_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot14,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot14_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot14_2016.HydricBalance = lCIWDelLagoElMiradorPivot14_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot14_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot14_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot14_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot14_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot14_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot14_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot14_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot14_2016 = (from title in context.Titles
                                                                      where title.Name == "DDS"
                                                                         && title.Daily == false
                                                                         && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot14_2016.CropIrrigationWeatherId
                                                                      select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot14_2016 = lCIWDelLagoElMiradorPivot14_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot14_2016 = lFirstTitleIdDelLagoElMiradorPivot14_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot14_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot14_2016;
                        lTitleIdDelLagoElMiradorPivot14_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot14_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot14_2016 - lFirstTitleIdDelLagoElMiradorPivot14_2016) % (lTotalTitlesDelLagoElMiradorPivot14_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot14_2016 = lFirstTitleIdDelLagoElMiradorPivot14_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot 15 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMirador15
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMirador15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMirador15)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivot15_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivot15_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot15_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot15_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador Pivot15 2016
                    var lCIWDelLagoElMiradorPivot15_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot15,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivot15_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot15_2016.HydricBalance = lCIWDelLagoElMiradorPivot15_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot15_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot15_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot15_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot15_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot15_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot15_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot15_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot15_2016 = (from title in context.Titles
                                                                      where title.Name == "DDS"
                                                                         && title.Daily == false
                                                                         && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot15_2016.CropIrrigationWeatherId
                                                                      select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot15_2016 = lCIWDelLagoElMiradorPivot15_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot15_2016 = lFirstTitleIdDelLagoElMiradorPivot15_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot15_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot15_2016;
                        lTitleIdDelLagoElMiradorPivot15_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot15_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot15_2016 - lFirstTitleIdDelLagoElMiradorPivot15_2016) % (lTotalTitlesDelLagoElMiradorPivot15_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot15_2016 = lFirstTitleIdDelLagoElMiradorPivot15_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot Chaja 1 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMiradorChaja1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMiradorChaja1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivotChaja1_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivotChaja1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador PivotChaja1 2016
                    var lCIWDelLagoElMiradorPivotChaja1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivotChaja1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivotChaja1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivotChaja1_2016.HydricBalance = lCIWDelLagoElMiradorPivotChaja1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivotChaja1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivotChaja1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivotChaja1_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivotChaja1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivotChaja1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivotChaja1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivotChaja1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivotChaja1_2016 = (from title in context.Titles
                                                                          where title.Name == "DDS"
                                                                             && title.Daily == false
                                                                             && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivotChaja1_2016.CropIrrigationWeatherId
                                                                          select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivotChaja1_2016 = lCIWDelLagoElMiradorPivotChaja1_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivotChaja1_2016 = lFirstTitleIdDelLagoElMiradorPivotChaja1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivotChaja1_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivotChaja1_2016;
                        lTitleIdDelLagoElMiradorPivotChaja1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivotChaja1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivotChaja1_2016 - lFirstTitleIdDelLagoElMiradorPivotChaja1_2016) % (lTotalTitlesDelLagoElMiradorPivotChaja1_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivotChaja1_2016 = lFirstTitleIdDelLagoElMiradorPivotChaja1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region Del Lago - El Mirador Pivot Chaja 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoElMiradorChaja2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoElMiradorChaja2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoElMiradorChaja2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_DelLagoElMiradorPivotChaja2_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_DelLagoElMiradorPivotChaja2_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivotChaja2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW DelLago ElMirador PivotChaja2 2016
                    var lCIWDelLagoElMiradorPivotChaja2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivotChaja2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDelLagoElMiradorPivotChaja2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivotChaja2_2016.HydricBalance = lCIWDelLagoElMiradorPivotChaja2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivotChaja2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivotChaja2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivotChaja2_2016.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivotChaja2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivotChaja2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivotChaja2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivotChaja2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivotChaja2_2016 = (from title in context.Titles
                                                                          where title.Name == "DDS"
                                                                             && title.Daily == false
                                                                             && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivotChaja2_2016.CropIrrigationWeatherId
                                                                          select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivotChaja2_2016 = lCIWDelLagoElMiradorPivotChaja2_2016.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivotChaja2_2016 = lFirstTitleIdDelLagoElMiradorPivotChaja2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivotChaja2_2016.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivotChaja2_2016;
                        lTitleIdDelLagoElMiradorPivotChaja2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivotChaja2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivotChaja2_2016 - lFirstTitleIdDelLagoElMiradorPivotChaja2_2016) % (lTotalTitlesDelLagoElMiradorPivotChaja2_2016) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivotChaja2_2016 = lFirstTitleIdDelLagoElMiradorPivotChaja2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                }
                #endregion

                #region GMO - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_GMOLaPalma_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_GMOLaPalma_2016;

                    #region GMO - La Palma Pivot 1 2016
                    //#region Farm //////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmGMOLaPalma
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop //////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieAlfalfaSouthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieAlfalfaSouthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieAlfalfaSouthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieAlfalfaSouthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture //////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotGMOLaPalma1
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilGMOLaPalma1
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma1)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_CornSouth_GMOLaPalmaPivot1_2016;
                    //lHarvestDate = DataEntry.HarvestDate_CornSouth_GMOLaPalmaPivot1_2016;
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot1_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot1_2016;
                    //}
                    //#endregion
                    //#region Weather Data
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW GMO La Palma Pivot1 2016
                    //var lCIWGMOLaPalmaPivot1_2016 = new CropIrrigationWeather
                    //{

                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot1,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    WeatherEventType = Utils.WeatherEventType.LaNinia,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWGMOLaPalmaPivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWGMOLaPalmaPivot1_2016.HydricBalance = lCIWGMOLaPalmaPivot1_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWGMOLaPalmaPivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWGMOLaPalmaPivot1_2016);
                    //context.SaveChanges();

                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWGMOLaPalmaPivot1_2016.Titles)
                    //{
                    //    var lTitlesGMOLaPalmaPivot1_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWGMOLaPalmaPivot1_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWGMOLaPalmaPivot1_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesGMOLaPalmaPivot1_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdGMOLaPalmaPivot1_2016 = (from title in context.Titles
                    //                                           where title.Name == "DDS"
                    //                                              && title.Daily == false
                    //                                              && title.CropIrrigationWeatherId == lCIWGMOLaPalmaPivot1_2016.CropIrrigationWeatherId
                    //                                           select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesGMOLaPalmaPivot1_2016 = lCIWGMOLaPalmaPivot1_2016.Titles.Count();
                    //long lTitleIdGMOLaPalmaPivot1_2016 = lFirstTitleIdGMOLaPalmaPivot1_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWGMOLaPalmaPivot1_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdGMOLaPalmaPivot1_2016;
                    //    lTitleIdGMOLaPalmaPivot1_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWGMOLaPalmaPivot1_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdGMOLaPalmaPivot1_2016 - lFirstTitleIdGMOLaPalmaPivot1_2016) % (lTotalTitlesGMOLaPalmaPivot1_2016) == 0)
                    //    {
                    //        lTitleIdGMOLaPalmaPivot1_2016 = lFirstTitleIdGMOLaPalmaPivot1_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion
                    #endregion
                    #region GMO - La Palma Pivot 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_GMOLaPalmaPivot2_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_GMOLaPalmaPivot2_2016;
                    lCropDate = Program.DateOfReference;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO La Palma Pivot 2 2016
                    var lCIWGMOLaPalmaPivot2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,

                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,

                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOLaPalmaPivot2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOLaPalmaPivot2_2016.HydricBalance = lCIWGMOLaPalmaPivot2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOLaPalmaPivot2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOLaPalmaPivot2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOLaPalmaPivot2_2016.Titles)
                    {
                        var lTitlesGMOLaPalmaPivot2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOLaPalmaPivot2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOLaPalmaPivot2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOLaPalmaPivot2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOLaPalmaPivot2_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWGMOLaPalmaPivot2_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOLaPalmaPivot2_2016 = lCIWGMOLaPalmaPivot2_2016.Titles.Count();
                    long lTitleIdGMOLaPalmaPivot2_2016 = lFirstTitleIdGMOLaPalmaPivot2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOLaPalmaPivot2_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOLaPalmaPivot2_2016;
                        lTitleIdGMOLaPalmaPivot2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOLaPalmaPivot2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOLaPalmaPivot2_2016 - lFirstTitleIdGMOLaPalmaPivot2_2016) % (lTotalTitlesGMOLaPalmaPivot2_2016) == 0)
                        {
                            lTitleIdGMOLaPalmaPivot2_2016 = lFirstTitleIdGMOLaPalmaPivot2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - La Palma Pivot 3 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_GMOLaPalmaPivot3_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_GMOLaPalmaPivot3_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot3_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot3_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO La Palma Pivot 3 2016
                    var lCIWGMOLaPalmaPivot3_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOLaPalmaPivot3_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOLaPalmaPivot3_2016.HydricBalance = lCIWGMOLaPalmaPivot3_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOLaPalmaPivot3_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOLaPalmaPivot3_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOLaPalmaPivot3_2016.Titles)
                    {
                        var lTitlesGMOLaPalmaPivot3_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOLaPalmaPivot3_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOLaPalmaPivot3_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOLaPalmaPivot3_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOLaPalmaPivot3_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWGMOLaPalmaPivot3_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOLaPalmaPivot3_2016 = lCIWGMOLaPalmaPivot3_2016.Titles.Count();
                    long lTitleIdGMOLaPalmaPivot3_2016 = lFirstTitleIdGMOLaPalmaPivot3_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOLaPalmaPivot3_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOLaPalmaPivot3_2016;
                        lTitleIdGMOLaPalmaPivot3_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOLaPalmaPivot3_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOLaPalmaPivot3_2016 - lFirstTitleIdGMOLaPalmaPivot3_2016) % (lTotalTitlesGMOLaPalmaPivot3_2016) == 0)
                        {
                            lTitleIdGMOLaPalmaPivot3_2016 = lFirstTitleIdGMOLaPalmaPivot3_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - La Palma Pivot 4 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornSouthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornSouthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOLaPalma4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornSouth_GMOLaPalmaPivot4_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornSouth_GMOLaPalmaPivot4_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot4_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOLaPalmaPivot4_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO La Palma Pivot 4 2016
                    var lCIWGMOLaPalmaPivot4_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOLaPalmaPivot4_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOLaPalmaPivot4_2016.HydricBalance = lCIWGMOLaPalmaPivot4_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOLaPalmaPivot4_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOLaPalmaPivot4_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOLaPalmaPivot4_2016.Titles)
                    {
                        var lTitlesGMOLaPalmaPivot4_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOLaPalmaPivot4_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOLaPalmaPivot4_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOLaPalmaPivot4_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOLaPalmaPivot4_2016 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWGMOLaPalmaPivot4_2016.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOLaPalmaPivot4_2016 = lCIWGMOLaPalmaPivot4_2016.Titles.Count();
                    long lTitleIdGMOLaPalmaPivot4_2016 = lFirstTitleIdGMOLaPalmaPivot4_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOLaPalmaPivot4_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOLaPalmaPivot4_2016;
                        lTitleIdGMOLaPalmaPivot4_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOLaPalmaPivot4_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOLaPalmaPivot4_2016 - lFirstTitleIdGMOLaPalmaPivot4_2016) % (lTotalTitlesGMOLaPalmaPivot4_2016) == 0)
                        {
                            lTitleIdGMOLaPalmaPivot4_2016 = lFirstTitleIdGMOLaPalmaPivot4_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                }
                #endregion

                #region GMO - El Tacuru

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_GMOElTacuru_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_GMOElTacuru_2016;

                    #region GMO - El Tacuru Pivot 1a 2016
                    //#region Farm //////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmGMOElTacuru
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop //////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieAlfalfaNorthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieAlfalfaNorthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieAlfalfaNorthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieAlfalfaNorthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture //////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotGMOElTacuru1a
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilGMOElTacuru1a
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru1a)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_AlfalfaNorth_GMOElTacuruPivot1a_2016;
                    //lHarvestDate = DataEntry.HarvestDate_AlfalfaNorth_GMOElTacuruPivot1a_2016;
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot1a_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot1a_2016;
                    //}
                    //#endregion
                    //#region Weather Data
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW GMO El Tacuru Pivot1a 2016
                    //var lCIWGMOElTacuruPivot1a_2016 = new CropIrrigationWeather
                    //{

                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot1a,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    WeatherEventType = Utils.WeatherEventType.LaNinia,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWGMOElTacuruPivot1a_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWGMOElTacuruPivot1a_2016.HydricBalance = lCIWGMOElTacuruPivot1a_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWGMOElTacuruPivot1a_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot1a_2016);
                    //context.SaveChanges();

                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWGMOElTacuruPivot1a_2016.Titles)
                    //{
                    //    var lTitlesGMOElTacuruPivot1a_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWGMOElTacuruPivot1a_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWGMOElTacuruPivot1a_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesGMOElTacuruPivot1a_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdGMOElTacuruPivot1a_2016 = (from title in context.Titles
                    //                                            where title.Name == "DDS"
                    //                                               && title.Daily == false
                    //                                               && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot1a_2016.CropIrrigationWeatherId
                    //                                            select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesGMOElTacuruPivot1a_2016 = lCIWGMOElTacuruPivot1a_2016.Titles.Count();
                    //long lTitleIdGMOElTacuruPivot1a_2016 = lFirstTitleIdGMOElTacuruPivot1a_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWGMOElTacuruPivot1a_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdGMOElTacuruPivot1a_2016;
                    //    lTitleIdGMOElTacuruPivot1a_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot1a_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdGMOElTacuruPivot1a_2016 - lFirstTitleIdGMOElTacuruPivot1a_2016) % (lTotalTitlesGMOElTacuruPivot1a_2016) == 0)
                    //    {
                    //        lTitleIdGMOElTacuruPivot1a_2016 = lFirstTitleIdGMOElTacuruPivot1a_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 1b 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru1b
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOElTacuru1b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru1b)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot1b_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot1b_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot1b_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot1b_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot1b 2016
                    var lCIWGMOElTacuruPivot1b_2016 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot1b,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot1b_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot1b_2016.HydricBalance = lCIWGMOElTacuruPivot1b_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot1b_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot1b_2016);
                    context.SaveChanges();

                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot1b_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot1b_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot1b_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot1b_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot1b_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot1b_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot1b_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot1b_2016 = lCIWGMOElTacuruPivot1b_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot1b_2016 = lFirstTitleIdGMOElTacuruPivot1b_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot1b_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot1b_2016;
                        lTitleIdGMOElTacuruPivot1b_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot1b_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot1b_2016 - lFirstTitleIdGMOElTacuruPivot1b_2016) % (lTotalTitlesGMOElTacuruPivot1b_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot1b_2016 = lFirstTitleIdGMOElTacuruPivot1b_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 2a 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru2a
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru2a
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru2a)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornNorth_GMOElTacuruPivot2a_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornNorth_GMOElTacuruPivot2a_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot2a_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot2a_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 2a 2016
                    var lCIWGMOElTacuruPivot2a_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot2a,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot2a_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot2a_2016.HydricBalance = lCIWGMOElTacuruPivot2a_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot2a_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot2a_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot2a_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot2a_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot2a_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot2a_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot2a_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot2a_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot2a_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot2a_2016 = lCIWGMOElTacuruPivot2a_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot2a_2016 = lFirstTitleIdGMOElTacuruPivot2a_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot2a_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot2a_2016;
                        lTitleIdGMOElTacuruPivot2a_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot2a_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot2a_2016 - lFirstTitleIdGMOElTacuruPivot2a_2016) % (lTotalTitlesGMOElTacuruPivot2a_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot2a_2016 = lFirstTitleIdGMOElTacuruPivot2a_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 2b 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru2b
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru2b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru2b)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot2b_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot2b_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot2b_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot2b_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 2b 2016
                    var lCIWGMOElTacuruPivot2b_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot2b,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot2b_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot2b_2016.HydricBalance = lCIWGMOElTacuruPivot2b_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot2b_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot2b_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot2b_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot2b_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot2b_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot2b_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot2b_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot2b_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot2b_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot2b_2016 = lCIWGMOElTacuruPivot2b_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot2b_2016 = lFirstTitleIdGMOElTacuruPivot2b_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot2b_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot2b_2016;
                        lTitleIdGMOElTacuruPivot2b_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot2b_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot2b_2016 - lFirstTitleIdGMOElTacuruPivot2b_2016) % (lTotalTitlesGMOElTacuruPivot2b_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot2b_2016 = lFirstTitleIdGMOElTacuruPivot2b_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 3a 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru3a
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru3a
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru3a)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornNorth_GMOElTacuruPivot3a_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornNorth_GMOElTacuruPivot3a_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot3a_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot3a_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 3a 2016
                    var lCIWGMOElTacuruPivot3a_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot3a,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot3a_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot3a_2016.HydricBalance = lCIWGMOElTacuruPivot3a_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot3a_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot3a_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot3a_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot3a_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot3a_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot3a_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot3a_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot3a_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot3a_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot3a_2016 = lCIWGMOElTacuruPivot3a_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot3a_2016 = lFirstTitleIdGMOElTacuruPivot3a_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot3a_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot3a_2016;
                        lTitleIdGMOElTacuruPivot3a_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot3a_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot3a_2016 - lFirstTitleIdGMOElTacuruPivot3a_2016) % (lTotalTitlesGMOElTacuruPivot3a_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot3a_2016 = lFirstTitleIdGMOElTacuruPivot3a_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 3b 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru3b
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru3b
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru3b)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot3b_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot3b_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot3b_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot3b_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 3b 2016
                    var lCIWGMOElTacuruPivot3b_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot3b,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot3b_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot3b_2016.HydricBalance = lCIWGMOElTacuruPivot3b_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot3b_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot3b_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot3b_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot3b_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot3b_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot3b_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot3b_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot3b_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot3b_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot3b_2016 = lCIWGMOElTacuruPivot3b_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot3b_2016 = lFirstTitleIdGMOElTacuruPivot3b_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot3b_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot3b_2016;
                        lTitleIdGMOElTacuruPivot3b_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot3b_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot3b_2016 - lFirstTitleIdGMOElTacuruPivot3b_2016) % (lTotalTitlesGMOElTacuruPivot3b_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot3b_2016 = lFirstTitleIdGMOElTacuruPivot3b_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 4 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieCornNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieCornNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_CornNorth_GMOElTacuruPivot4_2016;
                    lHarvestDate = DataEntry.HarvestDate_CornNorth_GMOElTacuruPivot4_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot4_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot4_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 4 2016
                    var lCIWGMOElTacuruPivot4_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot4_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot4_2016.HydricBalance = lCIWGMOElTacuruPivot4_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot4_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot4_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot4_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot4_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot4_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot4_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot4_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot4_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot4_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot4_2016 = lCIWGMOElTacuruPivot4_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot4_2016 = lFirstTitleIdGMOElTacuruPivot4_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot4_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot4_2016;
                        lTitleIdGMOElTacuruPivot4_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot4_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot4_2016 - lFirstTitleIdGMOElTacuruPivot4_2016) % (lTotalTitlesGMOElTacuruPivot4_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot4_2016 = lFirstTitleIdGMOElTacuruPivot4_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 5 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru5
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru5)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot5_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot5_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot5_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot5_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 5 2016
                    var lCIWGMOElTacuruPivot5_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot5_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot5_2016.HydricBalance = lCIWGMOElTacuruPivot5_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot5_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot5_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot5_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot5_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot5_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot5_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot5_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot5_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot5_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot5_2016 = lCIWGMOElTacuruPivot5_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot5_2016 = lFirstTitleIdGMOElTacuruPivot5_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot5_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot5_2016;
                        lTitleIdGMOElTacuruPivot5_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot5_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot5_2016 - lFirstTitleIdGMOElTacuruPivot5_2016) % (lTotalTitlesGMOElTacuruPivot5_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot5_2016 = lFirstTitleIdGMOElTacuruPivot5_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 8 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru8
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru8
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru8)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot8_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot8_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot8_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot8_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 8 2016
                    var lCIWGMOElTacuruPivot8_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot8,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot8_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot8_2016.HydricBalance = lCIWGMOElTacuruPivot8_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot8_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot8_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot8_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot8_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot8_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot8_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot8_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot8_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot8_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot8_2016 = lCIWGMOElTacuruPivot8_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot8_2016 = lFirstTitleIdGMOElTacuruPivot8_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot8_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot8_2016;
                        lTitleIdGMOElTacuruPivot8_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot8_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot8_2016 - lFirstTitleIdGMOElTacuruPivot8_2016) % (lTotalTitlesGMOElTacuruPivot8_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot8_2016 = lFirstTitleIdGMOElTacuruPivot8_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 9 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru9
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru9
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru9)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot9_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot9_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot9_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot9_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 9 2016
                    var lCIWGMOElTacuruPivot9_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot9,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot9_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot9_2016.HydricBalance = lCIWGMOElTacuruPivot9_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot9_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot9_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot9_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot9_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot9_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot9_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot9_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot9_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot9_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot9_2016 = lCIWGMOElTacuruPivot9_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot9_2016 = lFirstTitleIdGMOElTacuruPivot9_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot9_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot9_2016;
                        lTitleIdGMOElTacuruPivot9_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot9_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot9_2016 - lFirstTitleIdGMOElTacuruPivot9_2016) % (lTotalTitlesGMOElTacuruPivot9_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot9_2016 = lFirstTitleIdGMOElTacuruPivot9_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region GMO - El Tacuru Pivot 10 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOElTacuru
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOElTacuru10
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotGMOElTacuru10
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOElTacuru10)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_GMOElTacuruPivot10_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_GMOElTacuruPivot10_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot10_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_GMOElTacuruPivot10_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW GMO El Tacuru Pivot 10 2016
                    var lCIWGMOElTacuruPivot10_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOElTacuruPivot10,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWGMOElTacuruPivot10_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWGMOElTacuruPivot10_2016.HydricBalance = lCIWGMOElTacuruPivot10_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWGMOElTacuruPivot10_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWGMOElTacuruPivot10_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWGMOElTacuruPivot10_2016.Titles)
                    {
                        var lTitlesGMOElTacuruPivot10_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWGMOElTacuruPivot10_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWGMOElTacuruPivot10_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesGMOElTacuruPivot10_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdGMOElTacuruPivot10_2016 = (from title in context.Titles
                                                                 where title.Name == "DDS"
                                                                    && title.Daily == false
                                                                    && title.CropIrrigationWeatherId == lCIWGMOElTacuruPivot10_2016.CropIrrigationWeatherId
                                                                 select title.TitleId).FirstOrDefault();
                    long lTotalTitlesGMOElTacuruPivot10_2016 = lCIWGMOElTacuruPivot10_2016.Titles.Count();
                    long lTitleIdGMOElTacuruPivot10_2016 = lFirstTitleIdGMOElTacuruPivot10_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWGMOElTacuruPivot10_2016.Messages)
                    {
                        item.TitleId = lTitleIdGMOElTacuruPivot10_2016;
                        lTitleIdGMOElTacuruPivot10_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWGMOElTacuruPivot10_2016.CropIrrigationWeatherId;
                        if ((lTitleIdGMOElTacuruPivot10_2016 - lFirstTitleIdGMOElTacuruPivot10_2016) % (lTotalTitlesGMOElTacuruPivot10_2016) == 0)
                        {
                            lTitleIdGMOElTacuruPivot10_2016 = lFirstTitleIdGMOElTacuruPivot10_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                }
                #endregion

                #region La Rinconada
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
                {
                    lWeatherStationMainName = DataEntry.WeatherStationMainName_LaRinconada_2016;
                    lWeatherStationAlternativeName = DataEntry.WeatherStationAlternativeName_LaRinconada_2016;

                    #region La Rinconada Pivot 1 2016
                    //#region Farm //////////////////////////////////////////////////////////////////////
                    //lFarm = (from farm in context.Farms
                    //         where farm.Name == Utils.NameFarmLaRinconada
                    //         select farm).FirstOrDefault();
                    //lWeatherStationMain = (from ws in context.WeatherStations
                    //                       where ws.Name == lWeatherStationMainName
                    //                       select ws).FirstOrDefault();
                    //lWeatherStationAlternative = (from ws in context.WeatherStations
                    //                              where ws.Name == lWeatherStationAlternativeName
                    //                              select ws).FirstOrDefault();
                    //lEffectiveRainList = (from effectiverain in context.EffectiveRains
                    //                      where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                    //                      select effectiverain)
                    //                     .ToList<EffectiveRain>();
                    //#endregion
                    //#region Crop //////////////////////////////////////////////////////////////////////
                    //lSpecie = (from sp in context.Species
                    //           where sp.Name == Utils.NameSpecieSoyaNorthShort
                    //           select sp).FirstOrDefault();
                    //lCrop = (from crop in context.Crops
                    //         where crop.Name == Utils.NameSpecieSoyaNorthShort
                    //         select crop).FirstOrDefault();
                    //lCropCoefficient = (from cc in context.CropCoefficients
                    //                    where cc.Name == Utils.NameSpecieSoyaNorthShort
                    //                    select cc).FirstOrDefault();
                    //lPhenologicalStages = (from ps in context.PhenologicalStages
                    //                       where ps.SpecieId == lSpecie.SpecieId
                    //                       select ps).ToList<PhenologicalStage>();
                    //lKCList = (from cc in context.CropCoefficients
                    //           where cc.Name == Utils.NameSpecieSoyaNorthShort
                    //           select cc.KCList)
                    //                     .FirstOrDefault();
                    //lCropInformationByDate = (from cid in context.CropInformationByDates
                    //                          where cid.Name == Utils.NameSpecieSoyaNorthShort
                    //                          select cid).FirstOrDefault();
                    //#endregion
                    //#region Agriculture //////////////////////////////////////////////////////////////////////
                    //lIrrigationUnit = (from iu in context.Pivots
                    //                   where iu.Name == Utils.NamePivotLaRinconada1
                    //                   select iu).FirstOrDefault();
                    //lSoil = (from soil in context.Soils
                    //         where soil.Name == Utils.NameSoilLaRinconada1
                    //         select soil).FirstOrDefault();
                    //lHorizonList = (from horizon in context.Horizons
                    //                where horizon.Name.StartsWith(Utils.NamePivotLaRinconada1)
                    //                select horizon)
                    //                .ToList<Horizon>();
                    //lSowingDate = DataEntry.SowingDate_SoyaNorth_LaRinconadaPivot1_2016;
                    //lHarvestDate = DataEntry.HarvestDate_SoyaNorth_LaRinconadaPivot1_2016;
                    //lCropDate = DateTime.Now;
                    //if (DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot1_2016 == 0)
                    //{
                    //    lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    //}
                    //else
                    //{
                    //    lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot1_2016;
                    //}
                    //#endregion
                    //#region Weather Data
                    //lMainWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                        join weatherstation in context.WeatherStations
                    //                        on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                        where (weatherdata.Date >= lSowingDate ||
                    //                                weatherdata.Date <= lHarvestDate) &&
                    //                                weatherstation.WeatherStationId == lWeatherStationMain.WeatherStationId
                    //                        select weatherdata).ToList<WeatherData>();
                    //lAlternativeWeatherDataList = (from weatherdata in context.WeatherDatas
                    //                               join weatherstation in context.WeatherStations
                    //                               on weatherdata.WeatherStationId equals weatherstation.WeatherStationId
                    //                               where (weatherdata.Date >= lSowingDate ||
                    //                                    weatherdata.Date <= lHarvestDate) &&
                    //                                    weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                    //                               select weatherdata).ToList<WeatherData>();
                    //#endregion
                    //#region New CIW La Rinconada Pivot1 2016
                    //var lCIWLaRinconadaPivot1_2016 = new CropIrrigationWeather
                    //{

                    //    CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaRinconadaPivot1,
                    //    CropId = lCrop.CropId,
                    //    Crop = lCrop,
                    //    IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                    //    IrrigationUnit = lIrrigationUnit,
                    //    MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                    //    MainWeatherStation = lWeatherStationMain,

                    //    WeatherEventType = Utils.WeatherEventType.LaNinia,

                    //    AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                    //    AlternativeWeatherStation = lWeatherStationAlternative,
                    //    PositionId = lFarm.PositionId,
                    //    SoilId = lSoil.SoilId,
                    //    Soil = lSoil,

                    //    PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                    //    //Set the initial Phenological Stage for the Crop
                    //    PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                    //    PhenologicalStage = lCrop.PhenologicalStageList[0],

                    //    SowingDate = lSowingDate,
                    //    HarvestDate = lHarvestDate,
                    //    CropDate = lCropDate,
                    //    DaysForHydricBalanceUnchangableAfterSowing = 0,

                    //    HydricBalance = 0,

                    //    CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                    //    CropInformationByDate = lCropInformationByDate,

                    //};
                    //context.SaveChanges();

                    ////Set Calculus Method for Phenological Adjustment
                    //lCIWLaRinconadaPivot1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    ////Get Initial Hydric Balance
                    //lCIWLaRinconadaPivot1_2016.HydricBalance = lCIWLaRinconadaPivot1_2016.GetInitialHydricBalance();
                    ////Create the initial registry
                    //lCIWLaRinconadaPivot1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    //context.CropIrrigationWeathers.Add(lCIWLaRinconadaPivot1_2016);
                    //context.SaveChanges();

                    //#endregion
                    //#region Save Titles for print
                    //foreach (var item in lCIWLaRinconadaPivot1_2016.Titles)
                    //{
                    //    var lTitlesLaRinconadaPivot1_2016 = new Title
                    //    {
                    //        CropIrrigationWeatherId = lCIWLaRinconadaPivot1_2016.CropIrrigationWeatherId,
                    //        CropIrrigationWeather = lCIWLaRinconadaPivot1_2016,
                    //        Daily = false,
                    //        Name = item.Name,
                    //        Abbreviation = item.Abbreviation,
                    //        Description = item.Description,
                    //    };
                    //    context.Titles.Add(lTitlesLaRinconadaPivot1_2016);
                    //}
                    //context.SaveChanges();
                    //long lFirstTitleIdLaRinconadaPivot1_2016 = (from title in context.Titles
                    //                                            where title.Name == "DDS"
                    //                                               && title.Daily == false
                    //                                               && title.CropIrrigationWeatherId == lCIWLaRinconadaPivot1_2016.CropIrrigationWeatherId
                    //                                            select title.TitleId).FirstOrDefault();
                    //long lTotalTitlesLaRinconadaPivot1_2016 = lCIWLaRinconadaPivot1_2016.Titles.Count();
                    //long lTitleIdLaRinconadaPivot1_2016 = lFirstTitleIdLaRinconadaPivot1_2016;
                    //#endregion
                    //#region Update Messages Ids
                    //foreach (var item in lCIWLaRinconadaPivot1_2016.Messages)
                    //{
                    //    item.TitleId = lTitleIdLaRinconadaPivot1_2016;
                    //    lTitleIdLaRinconadaPivot1_2016 += 1;
                    //    item.CropIrrigationWeatherId = lCIWLaRinconadaPivot1_2016.CropIrrigationWeatherId;
                    //    if ((lTitleIdLaRinconadaPivot1_2016 - lFirstTitleIdLaRinconadaPivot1_2016) % (lTotalTitlesLaRinconadaPivot1_2016) == 0)
                    //    {
                    //        lTitleIdLaRinconadaPivot1_2016 = lFirstTitleIdLaRinconadaPivot1_2016;
                    //    }
                    //}
                    //context.SaveChanges();
                    //#endregion
                    #endregion
                    #region La Rinconada Pivot 2 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaRinconada
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaRinconada2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaRinconada2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_LaRinconadaPivot2_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_LaRinconadaPivot2_2016;
                    lCropDate = Program.DateOfReference;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot2_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot2_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate &&
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW La Rinconada Pivot 2 2016
                    var lCIWLaRinconadaPivot2_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaRinconadaPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,

                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,

                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaRinconadaPivot2_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaRinconadaPivot2_2016.HydricBalance = lCIWLaRinconadaPivot2_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaRinconadaPivot2_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaRinconadaPivot2_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWLaRinconadaPivot2_2016.Titles)
                    {
                        var lTitlesLaRinconadaPivot2_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaRinconadaPivot2_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaRinconadaPivot2_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaRinconadaPivot2_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaRinconadaPivot2_2016 = (from title in context.Titles
                                                                where title.Name == "DDS"
                                                                   && title.Daily == false
                                                                   && title.CropIrrigationWeatherId == lCIWLaRinconadaPivot2_2016.CropIrrigationWeatherId
                                                                select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaRinconadaPivot2_2016 = lCIWLaRinconadaPivot2_2016.Titles.Count();
                    long lTitleIdLaRinconadaPivot2_2016 = lFirstTitleIdLaRinconadaPivot2_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWLaRinconadaPivot2_2016.Messages)
                    {
                        item.TitleId = lTitleIdLaRinconadaPivot2_2016;
                        lTitleIdLaRinconadaPivot2_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWLaRinconadaPivot2_2016.CropIrrigationWeatherId;
                        if ((lTitleIdLaRinconadaPivot2_2016 - lFirstTitleIdLaRinconadaPivot2_2016) % (lTotalTitlesLaRinconadaPivot2_2016) == 0)
                        {
                            lTitleIdLaRinconadaPivot2_2016 = lFirstTitleIdLaRinconadaPivot2_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region La Rinconada Pivot 3.1 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaRinconada
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaRinconada3_1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada3_1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaRinconada3_1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_LaRinconadaPivot3_1_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_LaRinconadaPivot3_1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot3_1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot3_1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW La Rinconada Pivot 3.1 2016
                    var lCIWLaRinconadaPivot3_1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaRinconadaPivot3_1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaRinconadaPivot3_1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaRinconadaPivot3_1_2016.HydricBalance = lCIWLaRinconadaPivot3_1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaRinconadaPivot3_1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaRinconadaPivot3_1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWLaRinconadaPivot3_1_2016.Titles)
                    {
                        var lTitlesLaRinconadaPivot3_1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaRinconadaPivot3_1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaRinconadaPivot3_1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaRinconadaPivot3_1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaRinconadaPivot3_1_2016 = (from title in context.Titles
                                                                  where title.Name == "DDS"
                                                                     && title.Daily == false
                                                                     && title.CropIrrigationWeatherId == lCIWLaRinconadaPivot3_1_2016.CropIrrigationWeatherId
                                                                  select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaRinconadaPivot3_1_2016 = lCIWLaRinconadaPivot3_1_2016.Titles.Count();
                    long lTitleIdLaRinconadaPivot3_1_2016 = lFirstTitleIdLaRinconadaPivot3_1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWLaRinconadaPivot3_1_2016.Messages)
                    {
                        item.TitleId = lTitleIdLaRinconadaPivot3_1_2016;
                        lTitleIdLaRinconadaPivot3_1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWLaRinconadaPivot3_1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdLaRinconadaPivot3_1_2016 - lFirstTitleIdLaRinconadaPivot3_1_2016) % (lTotalTitlesLaRinconadaPivot3_1_2016) == 0)
                        {
                            lTitleIdLaRinconadaPivot3_1_2016 = lFirstTitleIdLaRinconadaPivot3_1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion
                    #region La Rinconada Pivot 13.1 2016
                    #region Farm //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmLaRinconada
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == lWeatherStationMainName
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == lWeatherStationAlternativeName
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionNorth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    #endregion
                    #region Crop //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieSoyaNorthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieSoyaNorthShort
                             select crop).FirstOrDefault();
                    lCropCoefficient = (from cc in context.CropCoefficients
                                        where cc.Name == Utils.NameSpecieSoyaNorthShort
                                        select cc).FirstOrDefault();
                    lPhenologicalStages = (from ps in context.PhenologicalStages
                                           where ps.SpecieId == lSpecie.SpecieId
                                           select ps).ToList<PhenologicalStage>();
                    lKCList = (from cc in context.CropCoefficients
                               where cc.Name == Utils.NameSpecieSoyaNorthShort
                               select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieSoyaNorthShort
                                              select cid).FirstOrDefault();
                    #endregion
                    #region Agriculture //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotLaRinconada13_1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NamePivotLaRinconada13_1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotLaRinconada13_1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry.SowingDate_SoyaNorth_LaRinconadaPivot13_1_2016;
                    lHarvestDate = DataEntry.HarvestDate_SoyaNorth_LaRinconadaPivot13_1_2016;
                    lCropDate = DateTime.Now;
                    if (DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot13_1_2016 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry.PredeterminatedIrrigationQuantity_LaRinconadaPivot13_1_2016;
                    }
                    #endregion
                    #region Weather Data
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
                                                   where (weatherdata.Date >= lSowingDate ||
                                                        weatherdata.Date <= lHarvestDate) &&
                                                        weatherstation.WeatherStationId == lWeatherStationAlternative.WeatherStationId
                                                   select weatherdata).ToList<WeatherData>();
                    #endregion
                    #region New CIW La Rinconada Pivot 13.1 2016
                    var lCIWLaRinconadaPivot13_1_2016 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherLaRinconadaPivot13_1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        WeatherEventType = Utils.WeatherEventType.LaNinia,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWLaRinconadaPivot13_1_2016.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaRinconadaPivot13_1_2016.HydricBalance = lCIWLaRinconadaPivot13_1_2016.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaRinconadaPivot13_1_2016.AddDailyRecordToList(lSowingDate, "Initial registry");

                    context.CropIrrigationWeathers.Add(lCIWLaRinconadaPivot13_1_2016);
                    context.SaveChanges();
                    #endregion
                    #region Save Titles for print
                    foreach (var item in lCIWLaRinconadaPivot13_1_2016.Titles)
                    {
                        var lTitlesLaRinconadaPivot13_1_2016 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaRinconadaPivot13_1_2016.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaRinconadaPivot13_1_2016,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaRinconadaPivot13_1_2016);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaRinconadaPivot13_1_2016 = (from title in context.Titles
                                                                   where title.Name == "DDS"
                                                                      && title.Daily == false
                                                                      && title.CropIrrigationWeatherId == lCIWLaRinconadaPivot13_1_2016.CropIrrigationWeatherId
                                                                   select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaRinconadaPivot13_1_2016 = lCIWLaRinconadaPivot13_1_2016.Titles.Count();
                    long lTitleIdLaRinconadaPivot13_1_2016 = lFirstTitleIdLaRinconadaPivot13_1_2016;
                    #endregion
                    #region Update Messages Ids
                    foreach (var item in lCIWLaRinconadaPivot13_1_2016.Messages)
                    {
                        item.TitleId = lTitleIdLaRinconadaPivot13_1_2016;
                        lTitleIdLaRinconadaPivot13_1_2016 += 1;
                        item.CropIrrigationWeatherId = lCIWLaRinconadaPivot13_1_2016.CropIrrigationWeatherId;
                        if ((lTitleIdLaRinconadaPivot13_1_2016 - lFirstTitleIdLaRinconadaPivot13_1_2016) % (lTotalTitlesLaRinconadaPivot13_1_2016) == 0)
                        {
                            lTitleIdLaRinconadaPivot13_1_2016 = lFirstTitleIdLaRinconadaPivot13_1_2016;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                    #endregion

                }
                #endregion

                #region New Farm

                #region Farm Pivot # 2016

                #endregion

                #endregion

            }
        }

        /// <summary>
        /// Add PhenologicalStage Adjustments:
        ///     - DataEntry Add PhenologicalStage Adjustements Farm Pivot Year
        /// </summary>
        public static void AddPhenologicalStageAdjustements2016()
        {
            #region South

            #region Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #endregion

            #region North
            using (var context = new IrrigationAdvisorContext())
            {
                context.SaveChanges();
            }
            #endregion
        }

        /// <summary>
        /// Add Information to Irrigation Units:
        ///     - DataEntry Add Information To Irrigation Units Farm Pivot Year
        /// </summary>
        public static void AddInformationToIrrigationUnits2016()
        {
            #region South

            #region DCA - El Paraiso
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCAElParaiso)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    DataEntry.AddInformationToIrrigationUnitsDCAElParaisoPivot1_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCAElParaisoPivot2_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("DCA - El Paraiso - Completed.");
                }
            }
            #endregion

            #region DCA - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot1_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot2_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot3_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot5_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot6_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot7_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot10b_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot14_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCALaPerdizPivot15_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("DCA - La Perdiz - Completed.");
                }
            }
            #endregion

            #region DCA - San Jose
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCASanJose)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsDCASanJosePivot1_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCASanJosePivot2_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCASanJosePivot3_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDCASanJosePivot4_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("DCA - San Jose - Completed.");
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot1_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot2_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot3_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot4_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot5_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot10_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot11_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot12_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot13_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot14_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivot15_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivotChaja1_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsDelLagoElMiradorPivotChaja2_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("Del Lago - El Mirador - Completed.");
                }
            }
            #endregion

            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    //DataEntry.AddInformationToIrrigationUnitsGMOLaPalmaPivot1_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOLaPalmaPivot2_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOLaPalmaPivot3_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOLaPalmaPivot4_2016(context, Program.DateOfReference);
                    //DataEntry.AddInformationToIrrigationUnitsGMOLaPalmaPivot5_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("GMO - La Palma - Completed.");
                }
            }
            #endregion

            #endregion

            #region North

            #region GMO - El Tacuru
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOElTacuru)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot1a_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot1b_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot2a_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot2b_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot3a_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot3b_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot4_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot5_2016(context, Program.DateOfReference);
                    //DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot6_2016(context, Program.DateOfReference);
                    //DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot7_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot8_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot9_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsGMOElTacuruPivot10_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("GMO - El Tacuru - Completed.");
                }
            }
            #endregion

            #region La Rinconada
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Production
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.LaRinconada)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    //DataEntry.AddInformationToIrrigationUnitsLaRinconadaPivot1_2016(context, Program.DateOfReference);
                    //DataEntry.AddInformationToIrrigationUnitsLaRinconadaPivot2_2016(context, Program.DateOfReference);
                    DataEntry.AddInformationToIrrigationUnitsLaRinconadaPivot3_1_2016(context, Program.DateOfReference);
                    //DataEntry.AddInformationToIrrigationUnitsLaRinconadaPivot13_1_2016(context, Program.DateOfReference);
                    context.SaveChanges();
                    Console.WriteLine("La Rinconada - Completed.");
                }
            }
            #endregion

            #endregion
        }

#endif
        #endregion

    }
}
