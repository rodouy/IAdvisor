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

namespace IrrigationAdvisor.DBContext.Management
{
    public class CropIrrigationWeatherConfiguration:
        EntityTypeConfiguration<CropIrrigationWeather>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

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
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId).ToList();
                foreach (CropIrrigationWeather item in lCropIrrigationWeaterList)
                {
                    DateTime lSowingDate = item.SowingDate;
                    DateTime lHarvestDate = item.HarvestDate;

                    //TODO: Could be more than one CropIrrigationWeather, when the IrrigationUnit is used for more than one Crop
                    if ((lSowingDate <= pDateOfReference)
                        && (lHarvestDate >= pDateOfReference))
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
                        break;
                    }
                }
                //lReturn = lCropIrrigationWeather.DailyRecordList.ToList();
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
        /// <returns></returns>
        public List<DailyRecord> GetDailyRecordListIncludeDailyRecordListBy(IrrigationUnit pIrrigationUnit,
                                                      DateTime pDateOfReference,
                                                      Crop pCrop)
        {
            List<DailyRecord> lReturn = null;
            List<DailyRecord> lNewDailyRecordList = new List<DailyRecord>();
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeaterList = db.CropIrrigationWeathers
                    .Include(ciw => ciw.DailyRecordList)
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .Include(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
                            && ciw.CropId == pCrop.CropId).ToList();
                foreach (CropIrrigationWeather item in lCropIrrigationWeaterList)
                {
                    DateTime lSowingDate = item.SowingDate;
                    DateTime lHarvestDate = item.HarvestDate;

                    //TODO: Could be more than one CropIrrigationWeather, when the IrrigationUnit is used for more than one Crop
                    if ((lSowingDate <= pDateOfReference)
                        && (lHarvestDate >= pDateOfReference))
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
                        break;
                    }
                }
                //lReturn = lCropIrrigationWeather.DailyRecordList.ToList();
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
                                                      DateTime pDateOfReference)
        {
            DailyRecord lReturn = null;
            CropIrrigationWeather lCropIrrigationWeather = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            if (pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeaterList = db.CropIrrigationWeathers
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.PhenologicalStageAdjustmentList)
                    .Include(ciw => ciw.Soil)
                    .Include(ciw => ciw.DailyRecordList)
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId).ToList();
                foreach (CropIrrigationWeather item in lCropIrrigationWeaterList)
                {
                    //TODO: Could be more than one CropIrrigationWeather, when the IrrigationUnit is used for more than one Crop
                    if ((item.SowingDate >= pDateOfReference) 
                        && (item.HarvestDate <= pDateOfReference))
                    {
                        lCropIrrigationWeather = item;
                        break;
                    }
                }
                lReturn = lCropIrrigationWeather.DailyRecordList
                    .Where(ciw => ciw.DailyRecordDateTime == pDateOfReference).FirstOrDefault();
            }

            return lReturn;
        }


        public CropIrrigationWeather GetCropIrrigationWeatherBy(IrrigationUnit pIrrigationUnit,
                                                                DateTime pDateOfReference)
        {
            CropIrrigationWeather lReturn = null;
            List<CropIrrigationWeather> lCropIrrigationWeaterList = new List<CropIrrigationWeather>();

            if(pIrrigationUnit != null && pDateOfReference != null)
            {
                lCropIrrigationWeaterList = db.CropIrrigationWeathers
                    .Include(crw => crw.IrrigationList)
                    .Include(crw => crw.MainWeatherStation)
                    .Include(crw => crw.PhenologicalStageAdjustmentList)
                    .Include(crw => crw.Soil)
                    .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId).ToList();
                foreach (CropIrrigationWeather item in lCropIrrigationWeaterList)
                {
                    if((item.SowingDate >= pDateOfReference) && (item.HarvestDate <= pDateOfReference))
                    {
                        lReturn = item;
                        break;
                    }                    
                }
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

    }
}