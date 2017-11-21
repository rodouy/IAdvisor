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
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <returns></returns>
        public List<DailyRecord> GetDailyRecordsListDataBy(long pCropIrrigationWeatherId)
        {
            List<DailyRecord> lReturn = null;
            List<DailyRecord> lDailyRecordList = null;
            try
            {
                if (pCropIrrigationWeatherId > 0)
                {                   
                    lDailyRecordList = db.DailyRecords
                                .Include(d => d.Rain)
                                .Include(d => d.Irrigation)
                                .Where (d => d.CropIrrigationWeatherId == pCropIrrigationWeatherId).ToList();

                    lReturn = lDailyRecordList;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in DailyRecord.GetDailyRecordsListDataBy " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }
        
        /// <summary>
        /// Get DailyRecords List with Rains and Irrigation To 
        /// </summary>
        /// <param name="pCropIrrigationWeatherId"></param>
        /// <param name="pDateOfReference"></param>
        /// <returns></returns>
        public List<DailyRecord> GetDailyRecordsListDataUntilDateBy(long cropIrrigationWeatherId, DateTime pDateOfReference)
        {
            List<DailyRecord> lReturn = null;
            List<DailyRecord> lDailyRecordList = null;
            DateTime ldt = pDateOfReference.AddMonths(-1);
            try
            {
                if (cropIrrigationWeatherId > 0)
                {
                    lDailyRecordList = db.DailyRecords
                                .Include(d => d.Rain)
                                .Include(d => d.Irrigation)
                                .Where(d => d.CropIrrigationWeatherId == cropIrrigationWeatherId &&
                                        d.DailyRecordDateTime <= pDateOfReference).ToList();

                    lReturn = lDailyRecordList;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in DailyRecord.GetDailyRecordsListDataBy " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lReturn;
        }

    }
}