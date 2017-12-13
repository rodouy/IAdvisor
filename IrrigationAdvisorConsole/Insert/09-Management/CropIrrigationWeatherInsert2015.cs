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
    public static class CropIrrigationWeatherInsert2015
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
        public static void InsertCropIrrigationWeather2015()
        {
            #region Local Variables
            Farm lFarm = null;
            Crop lCrop = null;
            Specie lSpecie = null;
            List<PhenologicalStage> lPhenologicalStages = null;
            IrrigationUnit lIrrigationUnit = null;
            WeatherStation lWeatherStationMain = null;
            List<WeatherData> lMainWeatherDataList = null;
            WeatherStation lWeatherStationAlternative = null;
            List<WeatherData> lAlternativeWeatherDataList = null;

            Specie lSpecie2 = null;
            Crop lCrop2 = null;
            CropCoefficient lCropCoefficient2 = null;
            List<PhenologicalStage> lPhenologicalStages2 = null;
            List<KC> lKCList2 = null;
            CropInformationByDate lCropInformationByDate2 = null;

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

                SowingDate = DateTime.Now.AddMonths(-1),
                HarvestDate = DateTime.Now.AddMonths(4),
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
                PredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart,

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

                #region Demo1 - La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {

                    #region Demo1 - La Perdiz Pivot 11 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo11
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo11
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo11)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo1Pivot11_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot11_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot11_2015;
                    }
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
                    var lCIWDemo1Pivot11_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot11,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo1Pivot11_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot11_2015.HydricBalance = lCIWDemo1Pivot11_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot11_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot11_2015);
                    context.SaveChanges();

                    #region Print
                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot11_2015.Titles)
                    {
                        var lTitlesDemo1Pivot11_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot11_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot11_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot11_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot11_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo1Pivot11_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot11_2015 = lCIWDemo1Pivot11_2015.Titles.Count();
                    long lTitleIdDemo1Pivot11_2015 = lFirstTitleIdDemo1Pivot11_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot11_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot11_2015;
                        lTitleIdDemo1Pivot11_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot11_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot11_2015 - lFirstTitleIdDemo1Pivot11_2015) % (lTotalTitlesDemo1Pivot11_2015) == 0)
                        {
                            lTitleIdDemo1Pivot11_2015 = lFirstTitleIdDemo1Pivot11_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo1 - La Perdiz Pivot 12 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo12
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo12
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo12)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo1Pivot12_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot12_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot12_2015;
                    }
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
                    var lCIWDemo1Pivot12_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot12,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo1Pivot12_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot12_2015.HydricBalance = lCIWDemo1Pivot12_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot12_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot12_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot12_2015.Titles)
                    {
                        var lTitlesDemo1Pivot12_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot12_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot12_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot12_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot12_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo1Pivot12_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot12_2015 = lCIWDemo1Pivot12_2015.Titles.Count();
                    long lTitleIdDemo1Pivot12_2015 = lFirstTitleIdDemo1Pivot12_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot12_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot12_2015;
                        lTitleIdDemo1Pivot12_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot12_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot12_2015 - lFirstTitleIdDemo1Pivot12_2015) % (lTotalTitlesDemo1Pivot12_2015) == 0)
                        {
                            lTitleIdDemo1Pivot12_2015 = lFirstTitleIdDemo1Pivot12_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Demo1 - La Perdiz Pivot 3 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo13
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo13
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo13)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo1Pivot13_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot13_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot13_2015;
                    }
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
                    var lCIWDemo1Pivot13_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot13,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo1Pivot13_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot13_2015.HydricBalance = lCIWDemo1Pivot13_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot13_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot13_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot13_2015.Titles)
                    {
                        var lTitlesDemo1Pivot13_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot13_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot13_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot13_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot13_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo1Pivot13_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot13_2015 = lCIWDemo1Pivot13_2015.Titles.Count();
                    long lTitleIdDemo1Pivot13_2015 = lFirstTitleIdDemo1Pivot13_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot13_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot13_2015;
                        lTitleIdDemo1Pivot13_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot13_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot13_2015 - lFirstTitleIdDemo1Pivot13_2015) % (lTotalTitlesDemo1Pivot13_2015) == 0)
                        {
                            lTitleIdDemo1Pivot13_2015 = lFirstTitleIdDemo1Pivot13_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo1 - La Perdiz Pivot 5 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo1
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo15
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo15
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo15)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo1Pivot15_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot15_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo1Pivot15_2015;
                    }
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
                    var lCIWDemo1Pivot15_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo1Pivot15,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo1Pivot15_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo1Pivot15_2015.HydricBalance = lCIWDemo1Pivot15_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo1Pivot15_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo1Pivot15_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo1Pivot15_2015.Titles)
                    {
                        var lTitlesDemo1Pivot15_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo1Pivot15_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo1Pivot15_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo1Pivot15_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo1Pivot15_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo1Pivot15_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo1Pivot15_2015 = lCIWDemo1Pivot15_2015.Titles.Count();
                    long lTitleIdDemo1Pivot15_2015 = lFirstTitleIdDemo1Pivot15_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo1Pivot15_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo1Pivot15_2015;
                        lTitleIdDemo1Pivot15_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo1Pivot15_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo1Pivot15_2015 - lFirstTitleIdDemo1Pivot15_2015) % (lTotalTitlesDemo1Pivot15_2015) == 0)
                        {
                            lTitleIdDemo1Pivot15_2015 = lFirstTitleIdDemo1Pivot15_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                }
                #endregion

                #region Demo2 - Santa Lucia
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {

                    #region Demo2 - Santa Lucia Pivot 21 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo21
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo21
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo21)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo2Pivot21_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot21_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot21_2015;
                    }
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
                    var lCIWDemo2Pivot21_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot21,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo2Pivot21_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot21_2015.HydricBalance = lCIWDemo2Pivot21_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot21_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot21_2015);
                    context.SaveChanges();

                    #region Print
                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot21_2015.Titles)
                    {
                        var lTitlesDemo2Pivot21_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot21_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot21_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot21_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot21_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo2Pivot21_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot21_2015 = lCIWDemo2Pivot21_2015.Titles.Count();
                    long lTitleIdDemo2Pivot21_2015 = lFirstTitleIdDemo2Pivot21_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot21_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot21_2015;
                        lTitleIdDemo2Pivot21_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot21_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot21_2015 - lFirstTitleIdDemo2Pivot21_2015) % (lTotalTitlesDemo2Pivot21_2015) == 0)
                        {
                            lTitleIdDemo2Pivot21_2015 = lFirstTitleIdDemo2Pivot21_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo2 - Santa Lucia Pivot 22 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo22
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo22
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo22)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo2Pivot22_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot22_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot22_2015;
                    }
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
                    var lCIWDemo2Pivot22_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot22,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo2Pivot22_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot22_2015.HydricBalance = lCIWDemo2Pivot22_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot22_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot22_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot22_2015.Titles)
                    {
                        var lTitlesDemo2Pivot22_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot22_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot22_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot22_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot22_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo2Pivot22_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot22_2015 = lCIWDemo2Pivot22_2015.Titles.Count();
                    long lTitleIdDemo2Pivot22_2015 = lFirstTitleIdDemo2Pivot22_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot22_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot22_2015;
                        lTitleIdDemo2Pivot22_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot22_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot22_2015 - lFirstTitleIdDemo2Pivot22_2015) % (lTotalTitlesDemo2Pivot22_2015) == 0)
                        {
                            lTitleIdDemo2Pivot22_2015 = lFirstTitleIdDemo2Pivot22_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Demo2 - Santa Lucia Pivot 23 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo23
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo23
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo23)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo2Pivot23_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot23_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot23_2015;
                    }
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
                    var lCIWDemo2Pivot23_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot23,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo2Pivot23_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot23_2015.HydricBalance = lCIWDemo2Pivot23_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot23_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot23_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot23_2015.Titles)
                    {
                        var lTitlesDemo2Pivot23_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot23_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot23_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot23_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot23_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo2Pivot23_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot23_2015 = lCIWDemo2Pivot23_2015.Titles.Count();
                    long lTitleIdDemo2Pivot23_2015 = lFirstTitleIdDemo2Pivot23_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot23_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot23_2015;
                        lTitleIdDemo2Pivot23_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot23_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot23_2015 - lFirstTitleIdDemo2Pivot23_2015) % (lTotalTitlesDemo2Pivot23_2015) == 0)
                        {
                            lTitleIdDemo2Pivot23_2015 = lFirstTitleIdDemo2Pivot23_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo2 - Santa Lucia Pivot 24 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo24
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo24
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo24)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo2Pivot24_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot24_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot24_2015;
                    }
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
                    var lCIWDemo2Pivot24_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot24,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo2Pivot24_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot24_2015.HydricBalance = lCIWDemo2Pivot24_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot24_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot24_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot24_2015.Titles)
                    {
                        var lTitlesDemo2Pivot24_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot24_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot24_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot24_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot24_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo2Pivot24_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot24_2015 = lCIWDemo2Pivot24_2015.Titles.Count();
                    long lTitleIdDemo2Pivot24_2015 = lFirstTitleIdDemo2Pivot24_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot24_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot24_2015;
                        lTitleIdDemo2Pivot24_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot24_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot24_2015 - lFirstTitleIdDemo2Pivot24_2015) % (lTotalTitlesDemo2Pivot24_2015) == 0)
                        {
                            lTitleIdDemo2Pivot24_2015 = lFirstTitleIdDemo2Pivot24_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo2 - Santa Lucia Pivot 25 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo2
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo25
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo25
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo25)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo2Pivot25_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot25_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo2Pivot25_2015;
                    }
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
                    var lCIWDemo2Pivot25_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo2Pivot25,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo2Pivot25_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo2Pivot25_2015.HydricBalance = lCIWDemo2Pivot25_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo2Pivot25_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo2Pivot25_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo2Pivot25_2015.Titles)
                    {
                        var lTitlesDemo2Pivot25_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo2Pivot25_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo2Pivot25_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo2Pivot25_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo2Pivot25_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo2Pivot25_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo2Pivot25_2015 = lCIWDemo2Pivot25_2015.Titles.Count();
                    long lTitleIdDemo2Pivot25_2015 = lFirstTitleIdDemo2Pivot25_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo2Pivot25_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo2Pivot25_2015;
                        lTitleIdDemo2Pivot25_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo2Pivot25_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo2Pivot25_2015 - lFirstTitleIdDemo2Pivot25_2015) % (lTotalTitlesDemo2Pivot25_2015) == 0)
                        {
                            lTitleIdDemo2Pivot25_2015 = lFirstTitleIdDemo2Pivot25_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                }
                #endregion

                #region Demo3 - La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
                {

                    #region Demo3 - La Palma Pivot 31 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo31
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo31
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo31)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo3Pivot31_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot31_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot31_2015;
                    }
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
                    var lCIWDemo3Pivot31_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot31,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo3Pivot31_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot31_2015.HydricBalance = lCIWDemo3Pivot31_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot31_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot31_2015);
                    context.SaveChanges();

                    #region Print
                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot31_2015.Titles)
                    {
                        var lTitlesDemo3Pivot31_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot31_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot31_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot31_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot31_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo3Pivot31_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot31_2015 = lCIWDemo3Pivot31_2015.Titles.Count();
                    long lTitleIdDemo3Pivot31_2015 = lFirstTitleIdDemo3Pivot31_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot31_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot31_2015;
                        lTitleIdDemo3Pivot31_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot31_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot31_2015 - lFirstTitleIdDemo3Pivot31_2015) % (lTotalTitlesDemo3Pivot31_2015) == 0)
                        {
                            lTitleIdDemo3Pivot31_2015 = lFirstTitleIdDemo3Pivot31_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo3 - La Palma Pivot 32A 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo32A
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo32A
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo32A)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo3Pivot32A_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot32A_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot32A_2015;
                    }
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
                    var lCIWDemo3Pivot32A_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot32A,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo3Pivot32A_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot32A_2015.HydricBalance = lCIWDemo3Pivot32A_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot32A_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot32A_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot32A_2015.Titles)
                    {
                        var lTitlesDemo3Pivot32A_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot32A_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot32A_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot32A_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot32A_2015 = (from title in context.Titles
                                                            where title.Name == "DDS"
                                                               && title.Daily == false
                                                               && title.CropIrrigationWeatherId == lCIWDemo3Pivot32A_2015.CropIrrigationWeatherId
                                                            select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot32A_2015 = lCIWDemo3Pivot32A_2015.Titles.Count();
                    long lTitleIdDemo3Pivot32A_2015 = lFirstTitleIdDemo3Pivot32A_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot32A_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot32A_2015;
                        lTitleIdDemo3Pivot32A_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot32A_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot32A_2015 - lFirstTitleIdDemo3Pivot32A_2015) % (lTotalTitlesDemo3Pivot32A_2015) == 0)
                        {
                            lTitleIdDemo3Pivot32A_2015 = lFirstTitleIdDemo3Pivot32A_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Demo3 - La Palma Pivot 33 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo33
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo33
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo33)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo3Pivot33_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot33_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot33_2015;
                    }
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
                    var lCIWDemo3Pivot33_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot33,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo3Pivot33_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot33_2015.HydricBalance = lCIWDemo3Pivot33_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot33_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot33_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot33_2015.Titles)
                    {
                        var lTitlesDemo3Pivot33_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot33_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot33_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot33_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot33_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo3Pivot33_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot33_2015 = lCIWDemo3Pivot33_2015.Titles.Count();
                    long lTitleIdDemo3Pivot33_2015 = lFirstTitleIdDemo3Pivot33_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot33_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot33_2015;
                        lTitleIdDemo3Pivot33_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot33_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot33_2015 - lFirstTitleIdDemo3Pivot33_2015) % (lTotalTitlesDemo3Pivot33_2015) == 0)
                        {
                            lTitleIdDemo3Pivot33_2015 = lFirstTitleIdDemo3Pivot33_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region Demo3 - La Palma Pivot 34 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    #region Soya
                    lSpecie2 = (from sp in context.Species
                                where sp.Name == Utils.NameSpecieSoyaSouthShort
                                select sp).FirstOrDefault();
                    lCrop2 = (from crop in context.Crops
                              where crop.Name == Utils.NameSpecieSoyaSouthShort
                              select crop).FirstOrDefault();
                    lCropCoefficient2 = (from cc in context.CropCoefficients
                                         where cc.Name == Utils.NameSpecieSoyaSouthShort
                                         select cc).FirstOrDefault();
                    lPhenologicalStages2 = (from ps in context.PhenologicalStages
                                            where ps.SpecieId == lSpecie2.SpecieId
                                            select ps).ToList<PhenologicalStage>();
                    lKCList2 = (from cc in context.CropCoefficients
                                where cc.Name == Utils.NameSpecieSoyaSouthShort
                                select cc.KCList)
                                         .FirstOrDefault();
                    lCropInformationByDate2 = (from cid in context.CropInformationByDates
                                               where cid.Name == Utils.NameSpecieSoyaSouthShort
                                               select cid).FirstOrDefault();
                    #endregion

                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo34
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo34
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo34)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo3Pivot34_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot34_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot34_2015;
                    }
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

                    #region CropIrrigation #1
                    var lCIWDemo3Pivot34_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot34,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo3Pivot34_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot34_2015.HydricBalance = lCIWDemo3Pivot34_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot34_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot34_2015);
                    context.SaveChanges();
                    #endregion

                    #region CropIrrigation #2
                    var lCIWDemo3Pivot342_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot342,
                        CropId = lCrop2.CropId,
                        Crop = lCrop2,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop2.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop2.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate2.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate2,

                    };
                    context.SaveChanges();

                    //Set Calculus Method for Phenological Adjustment
                    lCIWDemo3Pivot342_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot342_2015.HydricBalance = lCIWDemo3Pivot342_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot342_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot342_2015);
                    context.SaveChanges();
                    #endregion

                    #region Titles #1
                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot34_2015.Titles)
                    {
                        var lTitlesDemo3Pivot34_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot34_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot34_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };

                        context.Titles.Add(lTitlesDemo3Pivot34_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot34_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo3Pivot34_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot34_2015 = lCIWDemo3Pivot34_2015.Titles.Count();
                    long lTitleIdDemo3Pivot34_2015 = lFirstTitleIdDemo3Pivot34_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot34_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot34_2015;
                        lTitleIdDemo3Pivot34_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot34_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot34_2015 - lFirstTitleIdDemo3Pivot34_2015) % (lTotalTitlesDemo3Pivot34_2015) == 0)
                        {
                            lTitleIdDemo3Pivot34_2015 = lFirstTitleIdDemo3Pivot34_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Titles #2
                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot342_2015.Titles)
                    {
                        var lTitlesDemo3Pivot342_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot342_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot342_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot342_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot342_2015 = (from title in context.Titles
                                                            where title.Name == "DDS"
                                                               && title.Daily == false
                                                               && title.CropIrrigationWeatherId == lCIWDemo3Pivot342_2015.CropIrrigationWeatherId
                                                            select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot342_2015 = lCIWDemo3Pivot342_2015.Titles.Count();
                    long lTitleIdDemo3Pivot342_2015 = lFirstTitleIdDemo3Pivot342_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot342_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot342_2015;
                        lTitleIdDemo3Pivot342_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot342_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot342_2015 - lFirstTitleIdDemo3Pivot342_2015) % (lTotalTitlesDemo3Pivot342_2015) == 0)
                        {
                            lTitleIdDemo3Pivot342_2015 = lFirstTitleIdDemo3Pivot342_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #endregion

                    #region Demo3 - La Palma Pivot 35 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDemo3
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDemo35
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDemo35
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDemo35)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_Demo3Pivot35_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot35_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_Demo3Pivot35_2015;
                    }
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
                    var lCIWDemo3Pivot35_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDemo3Pivot35,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDemo3Pivot35_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDemo3Pivot35_2015.HydricBalance = lCIWDemo3Pivot35_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDemo3Pivot35_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDemo3Pivot35_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDemo3Pivot35_2015.Titles)
                    {
                        var lTitlesDemo3Pivot35_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDemo3Pivot35_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDemo3Pivot35_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDemo3Pivot35_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDemo3Pivot35_2015 = (from title in context.Titles
                                                           where title.Name == "DDS"
                                                              && title.Daily == false
                                                              && title.CropIrrigationWeatherId == lCIWDemo3Pivot35_2015.CropIrrigationWeatherId
                                                           select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDemo3Pivot35_2015 = lCIWDemo3Pivot35_2015.Titles.Count();
                    long lTitleIdDemo3Pivot35_2015 = lFirstTitleIdDemo3Pivot35_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDemo3Pivot35_2015.Messages)
                    {
                        item.TitleId = lTitleIdDemo3Pivot35_2015;
                        lTitleIdDemo3Pivot35_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDemo3Pivot35_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDemo3Pivot35_2015 - lFirstTitleIdDemo3Pivot35_2015) % (lTotalTitlesDemo3Pivot35_2015) == 0)
                        {
                            lTitleIdDemo3Pivot35_2015 = lFirstTitleIdDemo3Pivot35_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                }
                #endregion

                #region Santa Lucia

                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
                {
                    #region Santa Lucia Pivot 1 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmSantaLucia
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationSantaLucia
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                               select cc.KCList).FirstOrDefault();
                    lCropInformationByDate = (from cid in context.CropInformationByDates
                                              where cid.Name == Utils.NameSpecieCornSouthShort
                                              select cid).FirstOrDefault();
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotSantaLucia1
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilSantaLucia1
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotSantaLucia1)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_SantaLuciaPivot1_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_SantaLuciaPivot1_2015;
                    }
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
                    var lCIWSantaLuciaPivot1_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherSantaLuciaPivot1,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
                        PredeterminatedIrrigationQuantity = lPredeterminatedIrrigationQuantity,

                        //Set the initial Phenological Stage for the Crop
                        PhenologicalStageId = lCrop.PhenologicalStageList[0].PhenologicalStageId,
                        PhenologicalStage = lCrop.PhenologicalStageList[0],

                        SowingDate = lSowingDate,
                        HarvestDate = lHarvestDate,
                        CropDate = lCropDate,
                        DaysForHydricBalanceUnchangableAfterSowing = 0,

                        //Get Effective Rain List from Region
                        HydricBalance = 0,

                        CropInformationByDateId = lCropInformationByDate.CropInformationByDateId,
                        CropInformationByDate = lCropInformationByDate,

                    };
                    context.SaveChanges();

                    lCIWSantaLuciaPivot1_2015.Soil.HorizonList = lHorizonList;

                    //Set Calculus Method for Phenological Adjustment
                    lCIWSantaLuciaPivot1_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWSantaLuciaPivot1_2015.HydricBalance = lCIWSantaLuciaPivot1_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWSantaLuciaPivot1_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWSantaLuciaPivot1_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWSantaLuciaPivot1_2015.Titles)
                    {
                        var lTitlesSantaLuciaPivot1_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWSantaLuciaPivot1_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWSantaLuciaPivot1_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesSantaLuciaPivot1_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdSantaLuciaPivot1_2015 = (from title in context.Titles
                                                               where title.Name == "DDS"
                                                                  && title.Daily == false
                                                                  && title.CropIrrigationWeatherId == lCIWSantaLuciaPivot1_2015.CropIrrigationWeatherId
                                                               select title.TitleId).FirstOrDefault();
                    long lTotalTitlesSantaLuciaPivot1_2015 = lCIWSantaLuciaPivot1_2015.Titles.Count();
                    long lTitleIdSantaLuciaPivot1_2015 = lFirstTitleIdSantaLuciaPivot1_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWSantaLuciaPivot1_2015.Messages)
                    {
                        item.TitleId = lTitleIdSantaLuciaPivot1_2015;
                        lTitleIdSantaLuciaPivot1_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWSantaLuciaPivot1_2015.CropIrrigationWeatherId;
                        if (lTotalTitlesSantaLuciaPivot1_2015 == lTitleIdSantaLuciaPivot1_2015 - lFirstTitleIdSantaLuciaPivot1_2015)
                        {
                            lTitleIdSantaLuciaPivot1_2015 = lFirstTitleIdSantaLuciaPivot1_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Santa Lucia Pivot 2 2015

                    #endregion

                    #region Santa Lucia Pivot 3 2015

                    #endregion

                    #region Santa Lucia Pivot 4 2015

                    #endregion

                    #region Santa Lucia Pivot 5 2015

                    #endregion
                }
                #endregion

                #region La Perdiz
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
                {
                    #region La Perdiz Pivot 2 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_LaPerdizPivot2_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_LaPerdizPivot2_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_LaPerdizPivot2_2015;
                    }
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
                    var lCIWLaPerdizPivot2_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWLaPerdizPivot2_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPerdizPivot2_2015.HydricBalance = lCIWLaPerdizPivot2_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPerdizPivot2_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWLaPerdizPivot2_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPerdizPivot2_2015.Titles)
                    {
                        var lTitlesLaPerdizPivot2_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPerdizPivot2_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPerdizPivot2_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPerdizPivot2_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPerdizPivot2_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPerdizPivot2_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPerdizPivot2_2015 = lCIWLaPerdizPivot2_2015.Titles.Count();
                    long lTitleIdLaPerdizPivot2_2015 = lFirstTitleIdLaPerdizPivot2_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPerdizPivot2_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPerdizPivot2_2015;
                        lTitleIdLaPerdizPivot2_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPerdizPivot2_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPerdizPivot2_2015 - lFirstTitleIdLaPerdizPivot2_2015) % (lTotalTitlesLaPerdizPivot2_2015) == 0)
                        {
                            lTitleIdLaPerdizPivot2_2015 = lFirstTitleIdLaPerdizPivot2_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region La Perdiz Pivot 3 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_LaPerdizPivot3_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_LaPerdizPivot3_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_LaPerdizPivot3_2015;
                    }
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
                    var lCIWLaPerdizPivot3_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWLaPerdizPivot3_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPerdizPivot3_2015.HydricBalance = lCIWLaPerdizPivot3_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPerdizPivot3_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWLaPerdizPivot3_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPerdizPivot3_2015.Titles)
                    {
                        var lTitlesLaPerdizPivot3_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPerdizPivot3_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPerdizPivot3_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPerdizPivot3_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPerdizPivot3_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPerdizPivot3_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPerdizPivot3_2015 = lCIWLaPerdizPivot3_2015.Titles.Count();
                    long lTitleIdLaPerdizPivot3_2015 = lFirstTitleIdLaPerdizPivot3_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPerdizPivot3_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPerdizPivot3_2015;
                        lTitleIdLaPerdizPivot3_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPerdizPivot3_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPerdizPivot3_2015 - lFirstTitleIdLaPerdizPivot3_2015) % (lTotalTitlesLaPerdizPivot3_2015) == 0)
                        {
                            lTitleIdLaPerdizPivot3_2015 = lFirstTitleIdLaPerdizPivot3_2015;
                        }
                    }

                    context.SaveChanges();
                    #endregion

                    #region La Perdiz Pivot 5 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDCALaPerdiz
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_LaPerdizPivot5_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_LaPerdizPivot5_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_LaPerdizPivot5_2015;
                    }
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
                    var lCIWLaPerdizPivot5_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDCALaPerdizPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWLaPerdizPivot5_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPerdizPivot5_2015.HydricBalance = lCIWLaPerdizPivot5_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPerdizPivot5_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWLaPerdizPivot5_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPerdizPivot5_2015.Titles)
                    {
                        var lTitlesLaPerdizPivot5_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPerdizPivot5_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPerdizPivot5_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPerdizPivot5_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPerdizPivot5_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPerdizPivot5_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPerdizPivot5_2015 = lCIWLaPerdizPivot5_2015.Titles.Count();
                    long lTitleIdLaPerdizPivot5_2015 = lFirstTitleIdLaPerdizPivot5_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPerdizPivot5_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPerdizPivot5_2015;
                        lTitleIdLaPerdizPivot5_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPerdizPivot5_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPerdizPivot5_2015 - lFirstTitleIdLaPerdizPivot5_2015) % (lTotalTitlesLaPerdizPivot5_2015) == 0)
                        {
                            lTitleIdLaPerdizPivot5_2015 = lFirstTitleIdLaPerdizPivot5_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region Del Lago - San Pedro
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
                {
                    #region Del Lago - San Pedro Pivot 5 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro5
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro5
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro5)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoSanPedroPivot5_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot5_2015;
                    }
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
                    var lCIWDelLagoSanPedroPivot5_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot5,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoSanPedroPivot5_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot5_2015.HydricBalance = lCIWDelLagoSanPedroPivot5_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot5_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot5_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot5_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot5_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot5_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot5_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot5_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot5_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot5_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot5_2015 = lCIWDelLagoSanPedroPivot5_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot5_2015 = lFirstTitleIdDelLagoSanPedroPivot5_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot5_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot5_2015;
                        lTitleIdDelLagoSanPedroPivot5_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot5_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot5_2015 - lFirstTitleIdDelLagoSanPedroPivot5_2015) % (lTotalTitlesDelLagoSanPedroPivot5_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot5_2015 = lFirstTitleIdDelLagoSanPedroPivot5_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - San Pedro Pivot 6 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro6
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro6
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro6)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoSanPedroPivot6_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot6_2015;
                    }
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
                    var lCIWDelLagoSanPedroPivot6_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot6,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoSanPedroPivot6_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot6_2015.HydricBalance = lCIWDelLagoSanPedroPivot6_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot6_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot6_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot6_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot6_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot6_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot6_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot6_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot6_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot6_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot6_2015 = lCIWDelLagoSanPedroPivot6_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot6_2015 = lFirstTitleIdDelLagoSanPedroPivot6_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot6_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot6_2015;
                        lTitleIdDelLagoSanPedroPivot6_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot6_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot6_2015 - lFirstTitleIdDelLagoSanPedroPivot6_2015) % (lTotalTitlesDelLagoSanPedroPivot6_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot6_2015 = lFirstTitleIdDelLagoSanPedroPivot6_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - San Pedro Pivot 7 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro7
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro7
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro7)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoSanPedroPivot7_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot7_2015;
                    }
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
                    var lCIWDelLagoSanPedroPivot7_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot7,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoSanPedroPivot7_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot7_2015.HydricBalance = lCIWDelLagoSanPedroPivot7_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot7_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot7_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot7_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot7_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot7_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot7_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot7_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot7_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot7_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot7_2015 = lCIWDelLagoSanPedroPivot7_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot7_2015 = lFirstTitleIdDelLagoSanPedroPivot7_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot7_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot7_2015;
                        lTitleIdDelLagoSanPedroPivot7_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot7_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot7_2015 - lFirstTitleIdDelLagoSanPedroPivot7_2015) % (lTotalTitlesDelLagoSanPedroPivot7_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot7_2015 = lFirstTitleIdDelLagoSanPedroPivot7_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - San Pedro Pivot 8 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoSanPedro
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotDelLagoSanPedro8
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilDelLagoSanPedro8
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotDelLagoSanPedro8)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoSanPedroPivot8_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoSanPedroPivot8_2015;
                    }
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
                    var lCIWDelLagoSanPedroPivot8_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoSanPedroPivot8,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoSanPedroPivot8_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoSanPedroPivot8_2015.HydricBalance = lCIWDelLagoSanPedroPivot8_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoSanPedroPivot8_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoSanPedroPivot8_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoSanPedroPivot8_2015.Titles)
                    {
                        var lTitlesDelLagoSanPedroPivot8_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot8_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoSanPedroPivot8_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoSanPedroPivot8_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoSanPedroPivot8_2015 = (from title in context.Titles
                                                                    where title.Name == "DDS"
                                                                       && title.Daily == false
                                                                       && title.CropIrrigationWeatherId == lCIWDelLagoSanPedroPivot8_2015.CropIrrigationWeatherId
                                                                    select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoSanPedroPivot8_2015 = lCIWDelLagoSanPedroPivot8_2015.Titles.Count();
                    long lTitleIdDelLagoSanPedroPivot8_2015 = lFirstTitleIdDelLagoSanPedroPivot8_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoSanPedroPivot8_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoSanPedroPivot8_2015;
                        lTitleIdDelLagoSanPedroPivot8_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoSanPedroPivot8_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoSanPedroPivot8_2015 - lFirstTitleIdDelLagoSanPedroPivot8_2015) % (lTotalTitlesDelLagoSanPedroPivot8_2015) == 0)
                        {
                            lTitleIdDelLagoSanPedroPivot8_2015 = lFirstTitleIdDelLagoSanPedroPivot8_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region Del Lago - El Mirador
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
                {

                    #region Del Lago - El Mirador Pivot 6 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoElMiradorPivot6_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot6_2015;
                    }
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
                    var lCIWDelLagoElMiradorPivot6_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot6,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoElMiradorPivot6_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot6_2015.HydricBalance = lCIWDelLagoElMiradorPivot6_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot6_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot6_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot6_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot6_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot6_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot6_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot6_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot6_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot6_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot6_2015 = lCIWDelLagoElMiradorPivot6_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot6_2015 = lFirstTitleIdDelLagoElMiradorPivot6_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot6_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot6_2015;
                        lTitleIdDelLagoElMiradorPivot6_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot6_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot6_2015 - lFirstTitleIdDelLagoElMiradorPivot6_2015) % (lTotalTitlesDelLagoElMiradorPivot6_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot6_2015 = lFirstTitleIdDelLagoElMiradorPivot6_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - El Mirador Pivot 7 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoElMiradorPivot7_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot7_2015;
                    }
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
                    var lCIWDelLagoElMiradorPivot7_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot7,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoElMiradorPivot7_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot7_2015.HydricBalance = lCIWDelLagoElMiradorPivot7_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot7_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot7_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot7_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot7_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot7_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot7_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot7_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot7_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot7_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot7_2015 = lCIWDelLagoElMiradorPivot7_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot7_2015 = lFirstTitleIdDelLagoElMiradorPivot7_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot7_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot7_2015;
                        lTitleIdDelLagoElMiradorPivot7_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot7_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot7_2015 - lFirstTitleIdDelLagoElMiradorPivot7_2015) % (lTotalTitlesDelLagoElMiradorPivot7_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot7_2015 = lFirstTitleIdDelLagoElMiradorPivot7_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - El Mirador Pivot 8 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoElMiradorPivot8_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot8_2015;
                    }
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
                    var lCIWDelLagoElMiradorPivot8_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot8,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoElMiradorPivot8_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot8_2015.HydricBalance = lCIWDelLagoElMiradorPivot8_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot8_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot8_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot8_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot8_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot8_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot8_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot8_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot8_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot8_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot8_2015 = lCIWDelLagoElMiradorPivot8_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot8_2015 = lFirstTitleIdDelLagoElMiradorPivot8_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot8_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot8_2015;
                        lTitleIdDelLagoElMiradorPivot8_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot8_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot8_2015 - lFirstTitleIdDelLagoElMiradorPivot8_2015) % (lTotalTitlesDelLagoElMiradorPivot8_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot8_2015 = lFirstTitleIdDelLagoElMiradorPivot8_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region Del Lago - El Mirador Pivot 9 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmDelLagoElMirador
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth)
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
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
                    //////////////////////////////////////////////////////////////////////
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
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_DelLagoElMiradorPivot9_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_DelLagoElMiradorPivot9_2015;
                    }
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
                    var lCIWDelLagoElMiradorPivot9_2015 = new CropIrrigationWeather
                    {
                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherDelLagoElMiradorPivot9,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWDelLagoElMiradorPivot9_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWDelLagoElMiradorPivot9_2015.HydricBalance = lCIWDelLagoElMiradorPivot9_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWDelLagoElMiradorPivot9_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWDelLagoElMiradorPivot9_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWDelLagoElMiradorPivot9_2015.Titles)
                    {
                        var lTitlesDelLagoElMiradorPivot9_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot9_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWDelLagoElMiradorPivot9_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesDelLagoElMiradorPivot9_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdDelLagoElMiradorPivot9_2015 = (from title in context.Titles
                                                                     where title.Name == "DDS"
                                                                        && title.Daily == false
                                                                        && title.CropIrrigationWeatherId == lCIWDelLagoElMiradorPivot9_2015.CropIrrigationWeatherId
                                                                     select title.TitleId).FirstOrDefault();
                    long lTotalTitlesDelLagoElMiradorPivot9_2015 = lCIWDelLagoElMiradorPivot9_2015.Titles.Count();
                    long lTitleIdDelLagoElMiradorPivot9_2015 = lFirstTitleIdDelLagoElMiradorPivot9_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWDelLagoElMiradorPivot9_2015.Messages)
                    {
                        item.TitleId = lTitleIdDelLagoElMiradorPivot9_2015;
                        lTitleIdDelLagoElMiradorPivot9_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWDelLagoElMiradorPivot9_2015.CropIrrigationWeatherId;
                        if ((lTitleIdDelLagoElMiradorPivot9_2015 - lFirstTitleIdDelLagoElMiradorPivot9_2015) % (lTotalTitlesDelLagoElMiradorPivot9_2015) == 0)
                        {
                            lTitleIdDelLagoElMiradorPivot9_2015 = lFirstTitleIdDelLagoElMiradorPivot9_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region La Palma
                if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                    || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
                {
                    #region La Palma Pivot 2A 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth) //TODO: Verify Region of La Palma
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort   //TODO: Verify Specie of La Palma
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma2
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOLaPalma2
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma2)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_LaPalmaPivot2A_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_LaPalmaPivot2A_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_LaPalmaPivot2A_2015;
                    }
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
                    var lCIWLaPalmaPivot2A_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot2,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWLaPalmaPivot2A_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPalmaPivot2A_2015.HydricBalance = lCIWLaPalmaPivot2A_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPalmaPivot2A_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWLaPalmaPivot2A_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPalmaPivot2A_2015.Titles)
                    {
                        var lTitlesLaPalmaPivot2A_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPalmaPivot2A_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPalmaPivot2A_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPalmaPivot2A_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPalmaPivot2A_2015 = (from title in context.Titles
                                                             where title.Name == "DDS"
                                                                && title.Daily == false
                                                                && title.CropIrrigationWeatherId == lCIWLaPalmaPivot2A_2015.CropIrrigationWeatherId
                                                             select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPalmaPivot2A_2015 = lCIWLaPalmaPivot2A_2015.Titles.Count();
                    long lTitleIdLaPalmaPivot2A_2015 = lFirstTitleIdLaPalmaPivot2A_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPalmaPivot2A_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPalmaPivot2A_2015;
                        lTitleIdLaPalmaPivot2A_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPalmaPivot2A_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPalmaPivot2A_2015 - lFirstTitleIdLaPalmaPivot2A_2015) % (lTotalTitlesLaPalmaPivot2A_2015) == 0)
                        {
                            lTitleIdLaPalmaPivot2A_2015 = lFirstTitleIdLaPalmaPivot2A_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region La Palma Pivot 3 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth) //TODO: Verify Region of La Palma
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort   //TODO: Verify Specie of La Palma
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma3
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOLaPalma3
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma3)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_LaPalmaPivot3_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_LaPalmaPivot3_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_LaPalmaPivot3_2015;
                    }
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
                    var lCIWLaPalmaPivot3_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot3,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWLaPalmaPivot3_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPalmaPivot3_2015.HydricBalance = lCIWLaPalmaPivot3_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPalmaPivot3_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWLaPalmaPivot3_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPalmaPivot3_2015.Titles)
                    {
                        var lTitlesLaPalmaPivot3_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPalmaPivot3_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPalmaPivot3_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPalmaPivot3_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPalmaPivot3_2015 = (from title in context.Titles
                                                            where title.Name == "DDS"
                                                               && title.Daily == false
                                                               && title.CropIrrigationWeatherId == lCIWLaPalmaPivot3_2015.CropIrrigationWeatherId
                                                            select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPalmaPivot3_2015 = lCIWLaPalmaPivot3_2015.Titles.Count();
                    long lTitleIdLaPalmaPivot3_2015 = lFirstTitleIdLaPalmaPivot3_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPalmaPivot3_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPalmaPivot3_2015;
                        lTitleIdLaPalmaPivot3_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPalmaPivot3_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPalmaPivot3_2015 - lFirstTitleIdLaPalmaPivot3_2015) % (lTotalTitlesLaPalmaPivot3_2015) == 0)
                        {
                            lTitleIdLaPalmaPivot3_2015 = lFirstTitleIdLaPalmaPivot3_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion

                    #region La Palma Pivot 4 2015
                    //////////////////////////////////////////////////////////////////////
                    lFarm = (from farm in context.Farms
                             where farm.Name == Utils.NameFarmGMOLaPalma
                             select farm).FirstOrDefault();
                    lWeatherStationMain = (from ws in context.WeatherStations
                                           where ws.Name == Utils.NameWeatherStationLasBrujas
                                           select ws).FirstOrDefault();
                    lWeatherStationAlternative = (from ws in context.WeatherStations
                                                  where ws.Name == Utils.NameWeatherStationLaEstanzuela
                                                  select ws).FirstOrDefault();
                    lEffectiveRainList = (from effectiverain in context.EffectiveRains
                                          where effectiverain.Name.StartsWith(Utils.NameRegionSouth) //TODO: Verify Region of La Palma, region north
                                          select effectiverain)
                                         .ToList<EffectiveRain>();
                    //////////////////////////////////////////////////////////////////////
                    lSpecie = (from sp in context.Species
                               where sp.Name == Utils.NameSpecieCornSouthShort
                               select sp).FirstOrDefault();
                    lCrop = (from crop in context.Crops
                             where crop.Name == Utils.NameSpecieCornSouthShort   //TODO: Verify Specie of La Palma, region north
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
                    //////////////////////////////////////////////////////////////////////
                    lIrrigationUnit = (from iu in context.Pivots
                                       where iu.Name == Utils.NamePivotGMOLaPalma4
                                       select iu).FirstOrDefault();
                    lSoil = (from soil in context.Soils
                             where soil.Name == Utils.NameSoilGMOLaPalma4
                             select soil).FirstOrDefault();
                    lHorizonList = (from horizon in context.Horizons
                                    where horizon.Name.StartsWith(Utils.NamePivotGMOLaPalma4)
                                    select horizon)
                                    .ToList<Horizon>();
                    lSowingDate = DataEntry2015.SowingDate_CornSouth_LaPalmaPivot4_2015;
                    lHarvestDate = lSowingDate.AddDays(InitialTables.DAYS_TO_STOP_CROP_GROWS);
                    lCropDate = DateTime.Now;
                    if (DataEntry2015.PredeterminatedIrrigationQuantity_LaPalmaPivot4_2015 == 0)
                    {
                        lPredeterminatedIrrigationQuantity = Utils.PredeterminatedIrrigationQuantity_SecondPart;
                    }
                    else
                    {
                        lPredeterminatedIrrigationQuantity = DataEntry2015.PredeterminatedIrrigationQuantity_LaPalmaPivot4_2015;
                    }
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
                    var lCIWLaPalmaPivot4_2015 = new CropIrrigationWeather
                    {

                        CropIrrigationWeatherName = Utils.NameCropIrrigationWeatherGMOLaPalmaPivot4,
                        CropId = lCrop.CropId,
                        Crop = lCrop,
                        IrrigationUnitId = lIrrigationUnit.IrrigationUnitId,
                        IrrigationUnit = lIrrigationUnit,
                        MainWeatherStationId = lWeatherStationMain.WeatherStationId,
                        MainWeatherStation = lWeatherStationMain,

                        AlternativeWeatherStationId = lWeatherStationAlternative.WeatherStationId,
                        AlternativeWeatherStation = lWeatherStationAlternative,
                        PositionId = lFarm.PositionId,
                        SoilId = lSoil.SoilId,
                        Soil = lSoil,

                        MaxIrrigationQuantity = Math.Max(Utils.PredeterminatedIrrigationQuantity_FirstPart,
                                                 Math.Max(Utils.PredeterminatedIrrigationQuantity_SecondPart,
                                                          Utils.PredeterminatedIrrigationQuantity_ThirdPart)),
                        AdjustableIrrigationQuantity = true,
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
                    lCIWLaPalmaPivot4_2015.SetCalculusMethodForPhenologicalAdjustment(Utils.CalculusOfPhenologicalStage.ByGrowingDegreeDays);
                    //Get Initial Hydric Balance
                    lCIWLaPalmaPivot4_2015.HydricBalance = lCIWLaPalmaPivot4_2015.GetInitialHydricBalance();
                    //Create the initial registry
                    lCIWLaPalmaPivot4_2015.AddDailyRecordToList(lSowingDate, "Initial registry", lSowingDate);

                    context.CropIrrigationWeathers.Add(lCIWLaPalmaPivot4_2015);
                    context.SaveChanges();

                    //Save Titles for print
                    foreach (var item in lCIWLaPalmaPivot4_2015.Titles)
                    {
                        var lTitlesLaPalmaPivot4_2015 = new Title
                        {
                            CropIrrigationWeatherId = lCIWLaPalmaPivot4_2015.CropIrrigationWeatherId,
                            CropIrrigationWeather = lCIWLaPalmaPivot4_2015,
                            Daily = false,
                            Name = item.Name,
                            Abbreviation = item.Abbreviation,
                            Description = item.Description,
                        };
                        context.Titles.Add(lTitlesLaPalmaPivot4_2015);
                    }
                    context.SaveChanges();
                    long lFirstTitleIdLaPalmaPivot4_2015 = (from title in context.Titles
                                                            where title.Name == "DDS"
                                                               && title.Daily == false
                                                               && title.CropIrrigationWeatherId == lCIWLaPalmaPivot4_2015.CropIrrigationWeatherId
                                                            select title.TitleId).FirstOrDefault();
                    long lTotalTitlesLaPalmaPivot4_2015 = lCIWLaPalmaPivot4_2015.Titles.Count();
                    long lTitleIdLaPalmaPivot4_2015 = lFirstTitleIdLaPalmaPivot4_2015;
                    //Update Messages Ids
                    foreach (var item in lCIWLaPalmaPivot4_2015.Messages)
                    {
                        item.TitleId = lTitleIdLaPalmaPivot4_2015;
                        lTitleIdLaPalmaPivot4_2015 += 1;
                        item.CropIrrigationWeatherId = lCIWLaPalmaPivot4_2015.CropIrrigationWeatherId;
                        if ((lTitleIdLaPalmaPivot4_2015 - lFirstTitleIdLaPalmaPivot4_2015) % (lTotalTitlesLaPalmaPivot4_2015) == 0)
                        {
                            lTitleIdLaPalmaPivot4_2015 = lFirstTitleIdLaPalmaPivot4_2015;
                        }
                    }
                    context.SaveChanges();
                    #endregion
                }
                #endregion

                #region New Farm

                #region Farm Pivot # 2015

                #endregion

                #endregion

            }
        }

        /// <summary>
        /// Add PhenologicalStage Adjustments:
        ///     - DataEntry2015 Add PhenologicalStage Adjustements Farm Pivot Year
        /// </summary>
        public static void AddPhenologicalStageAdjustements2015()
        {
            #region South

            #region Demo - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry2015.AddPhenologicalStageAdjustementsDemoPivot1_2015(context);
                    DataEntry2015.AddPhenologicalStageAdjustementsDemoPivot2_2015(context);
                    DataEntry2015.AddPhenologicalStageAdjustementsDemoPivot3_2015(context);
                    DataEntry2015.AddPhenologicalStageAdjustementsDemoPivot5_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Santa Lucia
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.SantaLucia)
            {
                using (var context = new IrrigationAdvisorContext())
                {

                    context.SaveChanges();
                }
            }
            #endregion

            #region DCA La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    //DataEntry2015.AddPhenologicalStageAdjustementsLaPerdizPivot2_2015(context);
                    //DataEntry2015.AddPhenologicalStageAdjustementsLaPerdizPivot3_2015(context);
                    //DataEntry2015.AddPhenologicalStageAdjustementsLaPerdizPivot5_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
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
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
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
        ///     - DataEntry2015 Add Information To Irrigation Units Farm Pivot Year
        /// </summary>
        public static void AddInformationToIrrigationUnits2015()
        {
            #region South

            #region Demo - La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Demo)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry2015.AddInformationToIrrigationUnitsDemo1Pivot11_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo1Pivot12_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo1Pivot13_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo1Pivot15_2015(context);
                    context.SaveChanges();
                    DataEntry2015.AddInformationToIrrigationUnitsDemo2Pivot21_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo2Pivot22_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo2Pivot23_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo2Pivot24_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo2Pivot25_2015(context);
                    context.SaveChanges();
                    DataEntry2015.AddInformationToIrrigationUnitsDemo3Pivot31_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo3Pivot32A_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo3Pivot33_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo3Pivot34_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo3Pivot342_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDemo3Pivot35_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region La Perdiz
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCA
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DCALaPerdiz)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry2015.AddInformationToIrrigationUnitsLaPerdizPivot2_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsLaPerdizPivot3_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsLaPerdizPivot5_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - San Pedro
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoSanPedro)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoSanPedroPivot5_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoSanPedroPivot6_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoSanPedroPivot7_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoSanPedroPivot8_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region Del Lago - El Mirador
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLago
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.DelLagoElMirador)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoElMiradorPivot6_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoElMiradorPivot7_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoElMiradorPivot8_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsDelLagoElMiradorPivot9_2015(context);
                    context.SaveChanges();
                }
            }
            #endregion

            #region GMO - La Palma
            if (Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.All
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.Season_2015
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMO
                || Program.ProcessFarm == Utils.IrrigationAdvisorProcessFarm.GMOLaPalma)
            {
                using (var context = new IrrigationAdvisorContext())
                {
                    DataEntry2015.AddInformationToIrrigationUnitsLaPalmaPivot2A_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsLaPalmaPivot3_2015(context);
                    DataEntry2015.AddInformationToIrrigationUnitsLaPalmaPivot4_2015(context);
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

#endif
        #endregion

    }
}
