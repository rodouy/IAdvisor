using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Management
{
    public class CropIrrigationWeatherConfiguration:
        EntityTypeConfiguration<CropIrrigationWeather>
    {

        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

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
        /// Get Crop by CropId
        /// Include: CropCoefficient; PhenologicalStageList; StageList;
        ///         Specie; Region;
        /// </summary>
        /// <param name="pSoilId"></param>
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