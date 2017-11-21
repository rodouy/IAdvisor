using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Data;
using NLog;
using IrrigationAdvisor.Models.Weather;

namespace IrrigationAdvisor.DBContext.Management
{
    public class CropIrrigationWeatherConfiguration:
        EntityTypeConfiguration<CropIrrigationWeather>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public CropIrrigationWeatherConfiguration()
        {
            ToTable("CropIrrigationWeather");
            HasKey(c => c.CropIrrigationWeatherId);
            Property(c => c.CropIrrigationWeatherId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #region Agriculture
            Property(m => m.SowingDate)
                .IsRequired();
            Property(m => m.HarvestDate)
                .IsRequired();
            Property(m => m.HydricBalance)
                .IsRequired();
            Property(m => m.SoilHydricVolume)
                .IsRequired();
            #endregion

            #region Calculus
            Property(m => m.DaysAfterSowing)
                .IsRequired();
            Property(m => m.GrowingDegreeDaysAccumulated)
                .IsRequired();
            #endregion

            #region Water Properties
            Property(m => m.LastWaterInputDate)
                .IsRequired();
            Property(m => m.LastBigWaterInputDate)
                .IsRequired();
            Property(m => m.LastPartialWaterInputDate)
                .IsRequired();
            Property(m => m.LastPartialWaterInput)
                .IsRequired();
            #endregion
                       
            #region Totals Properties
            Property(m => m.TotalEvapotranspirationCrop)
                .IsRequired();
            Property(m => m.TotalEffectiveRain)
                .IsRequired();
            Property(m => m.TotalRealRain)
                .IsRequired();
            Property(m => m.TotalIrrigation)
                .IsRequired();
            Property(m => m.TotalIrrigationInHydricBalance)
                .IsRequired();
            Property(m => m.TotalExtraIrrigation)
                .IsRequired();
            Property(m => m.TotalExtraIrrigationInHydricBalance)
                .IsRequired();
            #endregion

            #region Relationship
            #if false
            HasRequired(m => m.Crop)
                .WithRequiredDependent();
            HasRequired(m => m.Soil)
                .WithRequiredDependent();
            HasRequired(m => m.PhenologicalStage)
                .WithRequiredDependent();
            HasRequired(m => m.IrrigationUnit)
                .WithRequiredDependent();
            HasRequired(m => m.MainWeatherStation)
                .WithRequiredDependent();
            HasRequired(m => m.AlternativeWeatherStation)
                .WithRequiredDependent();


            HasMany(m => m.EffectiveRainList)
                .WithOptional();
            HasMany(m => m.RainList)
                .WithOptional();
            HasMany(m => m.IrrigationList)
               .WithOptional();
            HasMany(m => m.EvapotranspirationCropList)
               .WithOptional();
            HasMany(m => m.DailyRecordList)
               .WithOptional();
            #endif
            #endregion

            #region Extra Print Data
            Ignore(m => m.Titles);
            Ignore(m => m.Messages);
            Ignore(m => m.TitlesDaily);
            Ignore(m => m.MessagesDaily);
            #endregion

        }

        /// <summary>
        /// Get MAX irrigation list id (next IrrigationList Id)
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public long GetMaxIrrigationListId(DateTime pDateOfReference)
        {
            long lReturn = 0;

            lReturn = db.Irrigations.Max(table => table.WaterInputId);

            return lReturn;
        }

        /// <summary>
        /// Get a MAX date of reference in CropIrrigationWeather list 
        /// Where CropIrrigationWeather is the IrrigationUnit instance
        ///     And DailyRecord Date equals Date of Reference plus DAYS_FOR_PREDICTION
        /// Include: 
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public DateTime GetMaxDateOfReferenceBy(IrrigationUnit pIrrigationUnit,
                                                      DateTime pDateOfReference)
        {
            DateTime lReturn = Utils.MIN_DATETIME;
            DateTime lMAXDate = Utils.MAX_DATETIME;
            List<DailyRecord> lNewDailyRecordList = new List<DailyRecord>();
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();
            DateTime lSowingDate;
            DateTime lHarvestDate;
            DateTime lDateLastDailyRecord;


            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeaterList = db.CropIrrigationWeathers
                    .Include(ciw => ciw.DailyRecordList)
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
                            && ciw.SowingDate <= pDateOfReference
                            && ciw.HarvestDate >= pDateOfReference).ToList();
                foreach (CropIrrigationWeather item in lCropIrrigationWeaterList)
                {
                    lSowingDate = item.SowingDate;
                    lHarvestDate = item.HarvestDate;

                    //TODO: Could be more than one CropIrrigationWeather, when the IrrigationUnit is used for more than one Crop
                    if ((lSowingDate <= pDateOfReference)
                        && (lHarvestDate >= pDateOfReference))
                    {
                        lCropIrrigationWeather = item;
                        lDateLastDailyRecord = lCropIrrigationWeather.DailyRecordList
                            .OrderByDescending(dr => dr.DailyRecordDateTime).FirstOrDefault().DailyRecordDateTime;
                        lMAXDate = Utils.MinDateTimeBetween(lDateLastDailyRecord, lMAXDate);
                    }
                }
                
                lReturn = lMAXDate;
            }

            return lReturn;
        }

        /// <summary>
        /// Get a MIN date of reference in CropIrrigationWeather list 
        /// Where CropIrrigationWeather is the IrrigationUnit instance
        ///     And DailyRecord Date equals Date of Reference plus DAYS_FOR_PREDICTION
        /// Include: 
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public DateTime GetMinDateOfReferenceBy(IrrigationUnit pIrrigationUnit,
                                                      DateTime pDateOfReference)
        {
            DateTime lReturn = Utils.MAX_DATETIME;
            DateTime lMINDate = Utils.MIN_DATETIME;
            List<DailyRecord> lNewDailyRecordList = new List<DailyRecord>();
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();
            DateTime lSowingDate;
            DateTime lHarvestDate;
            DateTime lDateFirstDailyRecord;


            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeaterList = db.CropIrrigationWeathers
                    .Include(ciw => ciw.DailyRecordList)
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
                            && ciw.SowingDate <= pDateOfReference
                            && ciw.HarvestDate >= pDateOfReference).ToList();
                foreach (CropIrrigationWeather lCIW in lCropIrrigationWeaterList)
                {
                    lSowingDate = lCIW.SowingDate;
                    lHarvestDate = lCIW.HarvestDate;

                    //TODO: Could be more than one CropIrrigationWeather, when the IrrigationUnit is used for more than one Crop
                    if ((lSowingDate <= pDateOfReference)
                        && (lHarvestDate >= pDateOfReference))
                    {
                        lCropIrrigationWeather = lCIW;
                        lDateFirstDailyRecord = lCropIrrigationWeather.DailyRecordList.OrderBy(dr => dr.DailyRecordDateTime).FirstOrDefault().DailyRecordDateTime;
                        lMINDate = Utils.MaxDateTimeBetween(lDateFirstDailyRecord, lMINDate);
                    }
                }

                lReturn = lMINDate;
            }

            return lReturn;
        }

        /// <summary>
        /// Get Last Day with WeatherData in all Weather Station used in a specific Date
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public DateTime GetLastDateWeatherDataBy(DateTime pDateOfReference)
        {
            DateTime lReturn = Utils.MIN_DATETIME;
            DateTime lLastDate = Utils.MIN_DATETIME;
            DateTime lWeatherDataLastDate = Utils.MIN_DATETIME;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();
            List<WeatherStation> lWeatherStationList = new List<WeatherStation>();

            if (pDateOfReference != null)
            {
                lLastDate = pDateOfReference;

                //Get all active CIW by Date of Reference with weather data included
                lCropIrrigationWeaterList = GetCropIrrigationWeatherListWithWeatherDataBy(pDateOfReference);
                foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeaterList)
                {

                    //Find last date by Main Weather Station
                    if (lCropIrrigationWeather.MainWeatherStation != null
                        && lCropIrrigationWeather.MainWeatherStation.WeatherDataList.Any())
                    {
                        if (!lWeatherStationList.Contains(lCropIrrigationWeather.MainWeatherStation))
                        {
                            lWeatherStationList.Add(lCropIrrigationWeather.MainWeatherStation);
                        }

                    }
                    //Find last date by Alternative Weather Station
                    if (lCropIrrigationWeather.AlternativeWeatherStation != null
                             && lCropIrrigationWeather.AlternativeWeatherStation.WeatherDataList.Any())
                    {
                        if (!lWeatherStationList.Contains(lCropIrrigationWeather.AlternativeWeatherStation))
                        {
                            lWeatherStationList.Add(lCropIrrigationWeather.AlternativeWeatherStation);
                        }
                    }
                }

                foreach (WeatherStation lWeatherStation in lWeatherStationList)
                {
                    //Last date the Weather Station has Weather Data
                    lWeatherDataLastDate = lWeatherStation.WeatherDataList.OrderByDescending(wd => wd.Date).FirstOrDefault().Date;
                    lLastDate = Utils.MinDateTimeBetween(lLastDate, lWeatherDataLastDate);
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Get Last Day with WeatherData in all Weather Station used by Farm in a specific Date
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <param name="pFarmId"></param>
        /// <returns></returns>
        public DateTime GetLastDateWeatherDataBy(DateTime pDateOfReference, long pFarmId)
        {
            DateTime lReturn = Utils.MIN_DATETIME;
            DateTime lLastDate = Utils.MIN_DATETIME;
            DateTime lWeatherDataLastDate = Utils.MIN_DATETIME;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();
            List<WeatherStation> lWeatherStationList = new List<WeatherStation>();

            if (pDateOfReference != null)
            {
                lLastDate = pDateOfReference;

                //Get all active CIW by Date of Reference with weather data included
                lCropIrrigationWeaterList = GetCropIrrigationWeatherListWithWeatherDataBy(pFarmId, pDateOfReference);
                foreach (CropIrrigationWeather lCropIrrigationWeather in lCropIrrigationWeaterList)
                {
                    
                    //Find last date by Main Weather Station
                    if (lCropIrrigationWeather.MainWeatherStation != null
                        && lCropIrrigationWeather.MainWeatherStation.WeatherDataList.Any())
                    {
                        if (!lWeatherStationList.Contains(lCropIrrigationWeather.MainWeatherStation))
                        {
                            lWeatherStationList.Add(lCropIrrigationWeather.MainWeatherStation);
                        }
                        
                    }
                    //Find last date by Alternative Weather Station
                    if (lCropIrrigationWeather.AlternativeWeatherStation != null
                             && lCropIrrigationWeather.AlternativeWeatherStation.WeatherDataList.Any())
                    {
                        if (!lWeatherStationList.Contains(lCropIrrigationWeather.AlternativeWeatherStation))
                        {
                            lWeatherStationList.Add(lCropIrrigationWeather.AlternativeWeatherStation);
                        }
                    }
                }

                foreach (WeatherStation lWeatherStation in lWeatherStationList)
                {
                    //Last date the Weather Station has Weather Data
                    lWeatherDataLastDate = lWeatherStation.WeatherDataList.OrderByDescending(wd => wd.Date).FirstOrDefault().Date;
                    lLastDate = Utils.MinDateTimeBetween(lLastDate, lWeatherDataLastDate);
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Get a DailyRecord in CropIrrigationWeather list 
        /// Where CropIrrigationWeather is the IrrigationUnit instance
        ///     And DailyRecord Date equals Date of Reference plus DAYS_FOR_PREDICTION
        /// Include: 
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<DailyRecord> GetDailyRecordListBy(IrrigationUnit pIrrigationUnit,
                                                      DateTime pDateOfReference)
        {
            List<DailyRecord> lReturn = null;
            List<DailyRecord> lNewDailyRecordList = new List<DailyRecord>();
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeaterList = db.CropIrrigationWeathers
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.Crop.Region)
                    .Include(ciw => ciw.Crop.Region.EffectiveRainList)
                    .Include(ciw => ciw.Crop.Region.TemperatureDataList)
                    .Include(ciw => ciw.Crop.PhenologicalStageList)
                    .Include(ciw => ciw.Crop.CropCoefficient)
                    .Include(ciw => ciw.Crop.CropCoefficient.KCList)
                    .Include(ciw => ciw.Soil)
                    .Include(ciw => ciw.Soil.HorizonList)
                    .Include(ciw => ciw.CropInformationByDate)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.MainWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.AlternativeWeatherStation)
                    .Include(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.RainList)
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.EvapotranspirationCropList)
                    .Include(ciw => ciw.DailyRecordList)
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
                            && ciw.SowingDate <= pDateOfReference
                            && ciw.HarvestDate >= pDateOfReference).ToList();
                foreach (CropIrrigationWeather item in lCropIrrigationWeaterList)
                {
                    lCropIrrigationWeather = item;
                    foreach (var record in lCropIrrigationWeather.DailyRecordList)
                    {
                        if (record.DailyRecordDateTime <= pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION))
                        {
                            lNewDailyRecordList.Add(record);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                
                lReturn = lNewDailyRecordList.ToList();
            }

            return lReturn;
        }


        /// <summary>
        /// Get a DailyRecord in CropIrrigationWeather list 
        /// Where CropIrrigationWeather is the IrrigationUnit instance
        ///     And DailyRecord Date equals Date of Reference plus DAYS_FOR_PREDICTION
        /// Include: DailyRecordList;
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <param name="pCrop"></param>
        /// <returns></returns>
        public List<DailyRecord> GetDailyRecordListIncludeDailyRecordListBy(IrrigationUnit pIrrigationUnit,
                                                      DateTime pDateOfReference, Crop pCrop)
        {
            List<DailyRecord> lReturn = null;
            List<DailyRecord> lNewDailyRecordList = new List<DailyRecord>();
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeather = db.CropIrrigationWeathers
                    .Include(ciw => ciw.DailyRecordList)
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
                            && ciw.CropId == pCrop.CropId
                            && ciw.SowingDate <= pDateOfReference
                            && ciw.HarvestDate >= pDateOfReference).FirstOrDefault();
                //TODO: Get from 10 days before DateOfReference 
                foreach (var record in lCropIrrigationWeather.DailyRecordList)
                {
                    if (record.DailyRecordDateTime <= pDateOfReference.AddDays(InitialTables.DAYS_FOR_PREDICTION))
                    {
                        //Only the days between (Date of Reference - DAYS_FOR_PREDICTION) and (Date of Reference + DAYS_FOR_PREDICTION)
                        if(record.DailyRecordDateTime >= pDateOfReference.AddDays(-InitialTables.DAYS_FOR_PREDICTION))
                        {
                            lNewDailyRecordList.Add(record);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                
                lReturn = lNewDailyRecordList.ToList();
            }

            return lReturn;
        }

        /// <summary>
        /// Get a DailyRecord in CropIrrigationWeather list 
        /// Where CropIrrigationWeather is the IrrigationUnit instance
        ///     And DailyRecord Date equals Date of Reference
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public DailyRecord GetDailyRecordBy(IrrigationUnit pIrrigationUnit,
                                            DateTime pDateOfReference, Crop pCrop)
        {
            DailyRecord lReturn = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeather = db.CropIrrigationWeathers
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.AlternativeWeatherStation)
                    .Include(ciw => ciw.PhenologicalStageAdjustmentList)
                    .Include(ciw => ciw.Soil)
                    .Include(ciw => ciw.DailyRecordList)
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
                            && ciw.CropId == pCrop.CropId
                            && ciw.SowingDate <= pDateOfReference
                            && ciw.HarvestDate >= pDateOfReference).FirstOrDefault();
                
                lReturn = lCropIrrigationWeather.DailyRecordList
                    .Where(ciw => ciw.DailyRecordDateTime.Date == pDateOfReference.Date).FirstOrDefault();
            }

            return lReturn;
        }

        /// <summary>
        /// Get List of CropIrrigationWeather with all related data to Calculate Irrigation
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetActiveCropIrrigationWeatherListBy(DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn = null;
            if (pDateOfReference != null)
            {
                lReturn = db.CropIrrigationWeathers
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.Crop.Specie)
                    .Include(ciw => ciw.Crop.Region)
                    .Include(ciw => ciw.Crop.Region.EffectiveRainList)
                    .Include(ciw => ciw.Crop.Region.TemperatureDataList)
                    .Include(ciw => ciw.Crop.PhenologicalStageList)
                    .Include(ciw => ciw.Crop.CropCoefficient)
                    .Include(ciw => ciw.Crop.CropCoefficient.KCList)
                    .Include(ciw => ciw.Soil)
                    .Include(ciw => ciw.Soil.HorizonList)
                    .Include(ciw => ciw.CropInformationByDate)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.MainWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.AlternativeWeatherStation)
                    .Include(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.RainList)
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.EvapotranspirationCropList)
                    .Include(ciw => ciw.DailyRecordList)
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .Where(ciw => ciw.SowingDate <= pDateOfReference
                               && ciw.HarvestDate >= pDateOfReference)
                    .ToList();
            }

            return lReturn;
        }


        /// <summary>
        /// Get a CropIrrigationWeather list 
        /// Where Date of Reference between SowingDate and HarvestDate
        /// </summary>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherListWithWeatherDataBy(DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            try
            {
                if (pDateOfReference != null)
                {
                    lCropIrrigationWeaterList = db.CropIrrigationWeathers
                        .Include(ciw => ciw.MainWeatherStation)
                        .Include(ciw => ciw.MainWeatherStation.WeatherDataList)
                        .Include(ciw => ciw.AlternativeWeatherStation)
                        .Include(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                        .Where(ciw => ciw.SowingDate <= pDateOfReference
                                        && ciw.HarvestDate >= pDateOfReference).ToList();
                    lReturn = lCropIrrigationWeaterList;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeatherConfiguration.GetCropIrrigationWeatherListWithWeatherDataBy " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }


        /// <summary>
        /// Get a CropIrrigationWeather list 
        /// Where Date of Reference between SowingDate and HarvestDate
        ///     And FarmId
        /// </summary>
        /// <param name="farmId"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherListWithWeatherDataBy(long farmId, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            try
            {
                if (pDateOfReference != null)
                {
                    lCropIrrigationWeaterList = (from ciw in db.CropIrrigationWeathers
                                                 join iu in db.IrrigationUnits
                                                    on ciw.IrrigationUnitId equals iu.IrrigationUnitId
                                                 join f in db.Farms
                                                    on iu.FarmId equals f.FarmId
                                                 where f.FarmId == farmId &&
                                                    ciw.SowingDate <= pDateOfReference &&
                                                    ciw.HarvestDate >= pDateOfReference
                                                 select ciw)
                                                .Include(ciw => ciw.MainWeatherStation)
                                                .Include(ciw => ciw.MainWeatherStation.WeatherDataList)
                                                .Include(ciw => ciw.AlternativeWeatherStation)
                                                .Include(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                                                .ToList();
                    lReturn = lCropIrrigationWeaterList;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeatherConfiguration.GetCropIrrigationWeatherListWithWeatherDataBy " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }


        /// <summary>
        /// Get Crop by CropId
        /// Include: CropCoefficient; PhenologicalStageList; StageList;
        ///         Specie; Region;
        /// </summary>
        /// <param name="pCropId"></param>
        /// <returns></returns>
        public Crop GetCropBy(long pCropId)
        {
            Crop lReturn = null;

            if (pCropId > 0)
            {
                lReturn = db.Crops
                    .Include(c => c.CropCoefficient)
                    .Include(c => c.PhenologicalStageList)
                    .Include(c => c.StageList)
                    .Include(c => c.Specie)
                    .Include(c => c.Region)
                    .Where(c => c.CropId == pCropId).FirstOrDefault();
            }

            return lReturn;
        }

        /// <summary>
        /// Get Soil by SoilId
        /// Include: HorizonList;
        /// </summary>
        /// <param name="pSoilId"></param>
        /// <returns></returns>
        public Soil GetSoilBy(long pSoilId)
        {
            Soil lReturn = null;

            if(pSoilId > 0)
            {
                lReturn = db.Soils
                    .Include(s => s.HorizonList)
                    .Where(s => s.SoilId == pSoilId).FirstOrDefault();
            }

            return lReturn;
        }

        /// <summary>
        /// Get a CropIrrigationWeather list 
        /// Where Date of Reference between SowingDate and HarvestDate
        ///     And FarmId
        /// </summary>
        /// <param name="farmId"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherByFarm(long farmId, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn;

            lReturn = (from ciw in db.CropIrrigationWeathers
                     join iu in db.IrrigationUnits
                     on ciw.IrrigationUnitId equals iu.IrrigationUnitId
                     join f in db.Farms
                     on iu.FarmId equals f.FarmId
                     where f.FarmId == farmId &&
                     ciw.SowingDate <= pDateOfReference &&
                     ciw.HarvestDate >= pDateOfReference
                     select ciw)
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.Crop.Specie)
                    .Include(ciw => ciw.Crop.Region)
                    .Include(ciw => ciw.Crop.Region.EffectiveRainList)
                    .Include(ciw => ciw.Crop.Region.TemperatureDataList)
                    .Include(ciw => ciw.Crop.PhenologicalStageList)
                    .Include(ciw => ciw.Crop.CropCoefficient)
                    .Include(ciw => ciw.Crop.CropCoefficient.KCList)
                    .Include(ciw => ciw.Soil)
                    .Include(ciw => ciw.Soil.HorizonList)
                    .Include(ciw => ciw.CropInformationByDate)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.MainWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.AlternativeWeatherStation)
                    .Include(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.RainList)
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.EvapotranspirationCropList)
                    .Include(ciw => ciw.DailyRecordList)
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .ToList();

            return lReturn;
        }

        /// <summary>
        /// Return al cr
        /// </summary>
        /// <param name="pCropIrrigationWeatherIds"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherByIds(List<long> pCropIrrigationWeatherIds, DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn;

            lReturn = db.CropIrrigationWeathers
                   .Where(ciw => pCropIrrigationWeatherIds.Contains(ciw.CropIrrigationWeatherId) &&
                                ciw.SowingDate <= pDateOfReference &&
                                ciw.HarvestDate >= pDateOfReference)
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.Crop.Specie)
                    .Include(ciw => ciw.Crop.Region)
                    .Include(ciw => ciw.Crop.Region.EffectiveRainList)
                    .Include(ciw => ciw.Crop.Region.TemperatureDataList)
                    .Include(ciw => ciw.Crop.PhenologicalStageList)
                    .Include(ciw => ciw.Crop.CropCoefficient)
                    .Include(ciw => ciw.Crop.CropCoefficient.KCList)
                    .Include(ciw => ciw.Soil)
                    .Include(ciw => ciw.Soil.HorizonList)
                    .Include(ciw => ciw.CropInformationByDate)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.MainWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.AlternativeWeatherStation)
                    .Include(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                    .Include(ciw => ciw.RainList)
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.EvapotranspirationCropList)
                    .Include(ciw => ciw.DailyRecordList)
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .ToList();

            return lReturn;
        }

        public String GetOutputByCropIrrigationWeatherId(long pCropIrrigationWeatherId)
        {
            String lReturn = "";
            CropIrrigationWeather lCIW;
            try
            {

                if (pCropIrrigationWeatherId > 0)
                {
                    lCIW = db.CropIrrigationWeathers
                       .Where(ciw => ciw.CropIrrigationWeatherId == pCropIrrigationWeatherId)
                       .FirstOrDefault();
                    if (lCIW != null)
                    {
                        lReturn = lCIW.OutPut;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeatherConfiguration.GetOutputByCropIrrigationWeatherId " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }

        public String GetNameByCropIrrigationWeatherId(long pCropIrrigationWeatherId)
        {
            String lReturn = "";
            CropIrrigationWeather lCIW;
            try
            {

                if (pCropIrrigationWeatherId > 0)
                {
                    lCIW = db.CropIrrigationWeathers
                       .Where(ciw => ciw.CropIrrigationWeatherId == pCropIrrigationWeatherId)
                       .FirstOrDefault();
                    if (lCIW != null)
                    {
                        lReturn = lCIW.CropIrrigationWeatherName;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in CropIrrigationWeatherConfiguration.GetNameByCropIrrigationWeatherId " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }
    }
}