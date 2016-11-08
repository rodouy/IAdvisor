using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Utilities;
using NLog;

namespace IrrigationAdvisor.DBContext.Data
{
    public class StatusConfiguration :
        EntityTypeConfiguration<Status>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public StatusConfiguration()
        {
            ToTable("Status");
            HasKey(s => s.StatusId);
            Property(s => s.Name)
                .IsRequired();
            Property(s => s.DateOfReference)
                .IsRequired();
            Property(s => s.WebStatus)
                .IsRequired();

            #region Relationship

            #endregion
        }

        public Status GetStatus(string pName)
        {
            db = new IrrigationAdvisorContext(); // Refresh the context.
            return (from s in db.Status
                    where s.Name.Equals(pName)
                    select s).FirstOrDefault();
        }
        
        public bool SetStatus(DateTime pDateOfReference, string pName)
        {
            bool lResult = false;
            try
            {
                Status status = GetStatus(pName);
                status.DateOfReference = pDateOfReference;
                db.SaveChanges();
                lResult = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in StatusConfiguration.GetDateOfReference " + "\n" + ex.Message + "\n" + ex.StackTrace);
                lResult = false;
            }

            return lResult;
        }

        public bool SetStatus(Utils.IrrigationAdvisorWebStatus pWebStatus, string pName)
        {
            bool lResult = false;

            try
            {
                Status status = GetStatus(pName);
                status.WebStatus = pWebStatus;
                db.SaveChanges();
                lResult = true;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in StatusConfiguration.GetDateOfReference " + "\n" + ex.Message + "\n" + ex.StackTrace);
                lResult = false;
            }

            return lResult;
        }

        public DateTime? GetDateOfReference(string pStatusName)
        {
            DateTime? lResult = null;

            try
            {
                Status status = GetStatus(pStatusName);

                if(status != null)
                {
                    lResult = status.DateOfReference;
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Exception in StatusConfiguration.GetDateOfReference " + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

            return lResult;
        }
    }
}