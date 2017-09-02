using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;
using NLog;
using System.Data.Entity;

namespace IrrigationAdvisor.DBContext.Management
{
    public class DailyRecordConfiguration:
        EntityTypeConfiguration<DailyRecord>
    {

        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public DailyRecordConfiguration()
        {
            ToTable("DailyRecord");
            HasKey(m => m.DailyRecordId);
            Property(m => m.DailyRecordId)
                .IsRequired();
            Property(c => c.DailyRecordDateTime)
                .IsRequired();
            Property(c => c.CropIrrigationWeatherId)
                .IsRequired();

            Property(c => c.RainId)
                .IsRequired();

        }

        /// <summary>
        /// Get  DailyRecords List with Rains and Irrigation
        /// </summary>
        /// <param name="cropIrrigationWeatherId"></param>
        /// <returns></returns>
        public List<DailyRecord> GetDailyRecordsListDataBy(long cropIrrigationWeatherId)
        {
            List<DailyRecord> lReturn = null;
           // List<DailyRecord> lDailyRecordList = new List<DailyRecord>();
            List<DailyRecord> lDailyRecordList = null;
            try
            {
                if (cropIrrigationWeatherId > 0)
                {
                    //lDailyRecordList = (from dr in db.DailyRecords
                    //                    join wiR in db.WaterInput on dr.RainId equals wiR.WaterInputId into gj
                    //                    from sub in gj.DefaultIfEmpty()
                    //                    join wiI in db.WaterInput on dr.IrrigationId equals wiI.WaterInputId into gj1
                    //                    from sub1 in gj1.DefaultIfEmpty()
                    //                    where dr.CropIrrigationWeatherId == cropIrrigationWeatherId
                    //                    select dr).ToList();


                    lDailyRecordList = db.DailyRecords
                                    .Include(d => d.Rain)
                                    .Include(d => d.Irrigation)
                                    .Where (d => d.CropIrrigationWeatherId == cropIrrigationWeatherId).ToList();


                    //lDailyRecordList = (from dr in db.DailyRecords                                       
                    //                    where dr.CropIrrigationWeatherId == cropIrrigationWeatherId
                    //                    select dr).ToList();


                    lReturn = lDailyRecordList;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in DailyRecord.GetDailyRecordsListDataBy " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }

        ///// <summary>
        ///// Get a DailyRecord in CropIrrigationWeather list 
        ///// Where CropIrrigationWeather is the IrrigationUnit instance
        /////     And DailyRecord Date equals Date of Reference
        ///// </summary>
        ///// <param name="pIrrigationUnit"></param>
        ///// <param name="pDateOfReference"></param>
        ///// <returns></returns>
        //public DailyRecord GetDailyRecordBy(long cropIrrigationWeatherId)
        //{
        //    DailyRecord lReturn = null;
        //    DailyRecord lCropIrrigationWeather = null;
        //    List<DailyRecord> lCropIrrigationWeaterList = new List<DailyRecord>();

           
        //        lCropIrrigationWeather = db.DailyRecords
        //            .Include(ciw => ciw.IrrigationList)
        //            .Include(ciw => ciw.MainWeatherStation)
        //            .Include(ciw => ciw.AlternativeWeatherStation)
        //            .Include(ciw => ciw.PhenologicalStageAdjustmentList)
        //            .Include(ciw => ciw.Soil)
        //            .Include(ciw => ciw.DailyRecordList)
        //            .Where(ciw => ciw.IrrigationUnitId == pIrrigationUnit.IrrigationUnitId
        //                    && ciw.CropId == pCrop.CropId
        //                    && ciw.SowingDate <= pDateOfReference
        //                    && ciw.HarvestDate >= pDateOfReference).FirstOrDefault();

        //        lReturn = lCropIrrigationWeather.DailyRecordList
        //            .Where(ciw => ciw.DailyRecordDateTime.Date == pDateOfReference.Date).FirstOrDefault();
        //    }

        //    return lReturn;
        //}

    }
}