using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using System.Data.Entity;
using IrrigationAdvisor.Models.Management;
using Z.EntityFramework.Plus;

namespace IrrigationAdvisor.DBContext.Irrigation
{
    public class IrrigationUnitConfiguration:
        EntityTypeConfiguration<IrrigationUnit>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public IrrigationUnitConfiguration()
        {
            ToTable("IrrigationUnit");
            HasKey(c => c.IrrigationUnitId);
            Property(c => c.IrrigationUnitId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired();

        }


        /// <summary>
        /// Get List of CropIrrigationWeather with all related data
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <returns></returns>
        public CropIrrigationWeather GetCropIrrigationWeatherListBy(
                                            long pCropIrrigationWeatherId)
        {
            CropIrrigationWeather lReturn = null;
            long lCropIrrigationWeatherId;
            if (pCropIrrigationWeatherId > 0)
            {
                lCropIrrigationWeatherId = pCropIrrigationWeatherId;
                lReturn = db.CropIrrigationWeathers
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
                    .Where(ciw => ciw.CropIrrigationWeatherId == lCropIrrigationWeatherId).FirstOrDefault();
            }

            return lReturn;
        }
        
        /// <summary>
        /// Get List of CropIrrigationWeather with all related data
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherListBy(
                                            IrrigationUnit pIrrigationUnit,
                                            DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn = null;
            long lIrrigationUnitId;
            if(pIrrigationUnit != null)
            {
                lIrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
                lReturn = db.CropIrrigationWeathers
                    .IncludeOptimized(ciw => ciw.Crop)
                    .IncludeOptimized(ciw => ciw.Crop.Region)
                    .IncludeOptimized(ciw => ciw.Crop.Region.EffectiveRainList)
                    .IncludeOptimized(ciw => ciw.Crop.Region.TemperatureDataList)
                    .IncludeOptimized(ciw => ciw.Crop.PhenologicalStageList)
                    .IncludeOptimized(ciw => ciw.Crop.CropCoefficient)
                    .IncludeOptimized(ciw => ciw.Crop.CropCoefficient.KCList)
                    .IncludeOptimized(ciw => ciw.Soil)
                    .IncludeOptimized(ciw => ciw.Soil.HorizonList)
                    .IncludeOptimized(ciw => ciw.CropInformationByDate)
                    .IncludeOptimized(ciw => ciw.MainWeatherStation)
                    .IncludeOptimized(ciw => ciw.MainWeatherStation.WeatherDataList)
                    .IncludeOptimized(ciw => ciw.AlternativeWeatherStation)
                    .IncludeOptimized(ciw => ciw.AlternativeWeatherStation.WeatherDataList)
                    .IncludeOptimized(ciw => ciw.RainList)
                    .IncludeOptimized(ciw => ciw.IrrigationList)
                    .IncludeOptimized(ciw => ciw.EvapotranspirationCropList)
                    .IncludeOptimized(ciw => ciw.DailyRecordList)
                    .IncludeOptimized(ciw => ciw.DailyRecordList.Select(dr => dr.MainWeatherData))
                    .IncludeOptimized(ciw => ciw.DailyRecordList.Select(dr => dr.AlternativeWeatherData))
                    .IncludeOptimized(ciw => ciw.DailyRecordList.Select(dr => dr.PhenologicalStage))
                    .IncludeOptimized(ciw => ciw.DailyRecordList.Select(dr => dr.Rain))
                    .IncludeOptimized(ciw => ciw.DailyRecordList.Select(dr => dr.Irrigation))
                    .IncludeOptimized(ciw => ciw.DailyRecordList.Select(dr => dr.EvapotranspirationCrop))
                    .Where(ciw => ciw.IrrigationUnitId == lIrrigationUnitId
                        && ciw.SowingDate <= pDateOfReference
                        && ciw.HarvestDate >= pDateOfReference).ToList();
            }

            return lReturn;
        }

        /// <summary>
        /// Get List of CropIrrigationWeather with all related data
        /// Include: Crop; MainWeatherStation; RainList; IrrigationList;
        ///         DailyRecordList;
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherListIncludeCropMainWeatherStationRainListIrrigationListBy(
                                            IrrigationUnit pIrrigationUnit,
                                            DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn = null;
            long lIrrigationUnitId;
            if (pIrrigationUnit != null)
            {
                lIrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
                lReturn = db.CropIrrigationWeathers
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.MainWeatherStation)
                    .Include(ciw => ciw.RainList)
                    .Include(ciw => ciw.IrrigationList)
                    .Where(ciw => ciw.IrrigationUnitId == lIrrigationUnitId
                        && ciw.SowingDate <= pDateOfReference
                        && ciw.HarvestDate >= pDateOfReference).ToList();
            }

            return lReturn;
        }

        /// <summary>
        /// Get List of CropIrrigationWeather with all related data
        /// Include: Crop; RainList; IrrigationList;
        /// </summary>
        /// <param name="pIrrigationUnit"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<CropIrrigationWeather> GetCropIrrigationWeatherListIncludeCropRainListIrrigationListBy(
                                            IrrigationUnit pIrrigationUnit,
                                            DateTime pDateOfReference)
        {
            List<CropIrrigationWeather> lReturn = null;
            long lIrrigationUnitId;
            if (pIrrigationUnit != null)
            {
                lIrrigationUnitId = pIrrigationUnit.IrrigationUnitId;
                lReturn = db.CropIrrigationWeathers
                    .Include(ciw => ciw.Crop)
                    .Include(ciw => ciw.RainList)
                    .Include(ciw => ciw.IrrigationList)
                    .Include(ciw => ciw.Soil.HorizonList)
                    .Where(ciw => ciw.IrrigationUnitId == lIrrigationUnitId
                        && ciw.SowingDate <= pDateOfReference
                        && ciw.HarvestDate >= pDateOfReference
                        && ciw.IrrigationUnit.Show == true).ToList();
            }

            return lReturn;
        }

        /// <summary>
        /// Get List of IrrigationUnit by Farm
        /// Include: IrrigationUnitList;
        /// </summary>
        /// <param name="pFarm"></param>
        /// <returns></returns>
        public List<IrrigationUnit> GetIrrigationUnitListBy(Farm pFarm)
        {
            List<IrrigationUnit> lReturn = null;
            List<IrrigationUnit> lIrrigationUnitList = null;
            int lIrrigationUnitToShow = 0;
            Farm lFarm = null;

            if (pFarm != null)
            {
                lFarm = db.Farms
                    .Include(f => f.IrrigationUnitList)
                    .Where(f => f.FarmId == pFarm.FarmId).FirstOrDefault();

                lIrrigationUnitList = lFarm.IrrigationUnitList.ToList();
                if(lIrrigationUnitList != null && lIrrigationUnitList.Count > 0)
                {
                    foreach (IrrigationUnit lIrrigationUnit in lIrrigationUnitList)
                    {
                        if(lIrrigationUnit.Show)
                        {
                            lIrrigationUnitToShow += 1;
                            if(lIrrigationUnitToShow == 1)
                            {
                                lReturn = new List<IrrigationUnit>();
                            }
                            lReturn.Add(lIrrigationUnit);
                        }
                    }
                }
            }

            return lReturn;
        }

        /// <summary>
        /// Get Irrigation Unit by IrrigationUnitId
        /// Include: Bomb, IrrigationList
        /// </summary>
        /// <param name="pIrrigationUnitId"></param>
        /// <returns></returns>
        public IrrigationUnit GetIrrigationUnitBy(long pIrrigationUnitId)
        {
            IrrigationUnit lReturn = null;

            lReturn = db.IrrigationUnits
                .Include(iu => iu.Bomb)
                .Include(iu => iu.IrrigationList)
                .Where(iu => iu.IrrigationUnitId == pIrrigationUnitId).FirstOrDefault();

            return lReturn;
        }
        
        /// <summary>
        /// Get Latitude by Position Id
        /// </summary>
        /// <param name="pPositionId"></param>
        /// <returns></returns>
        public Double GetLatitudeBy(long pPositionId)
        {
            Double lReturn = 0;

            lReturn = db.Positions
                .Where(p => p.PositionId == pPositionId).FirstOrDefault().Latitude;

            return lReturn;
        }

        /// <summary>
        /// Get Longitude by Position Id
        /// </summary>
        /// <param name="pPositionId"></param>
        /// <returns></returns>
        public Double GetLongitudeBy(long pPositionId)
        {
            Double lReturn = 0;

            lReturn = db.Positions
                .Where(p => p.PositionId == pPositionId).FirstOrDefault().Longitude;

            return lReturn;
        }


    }
}