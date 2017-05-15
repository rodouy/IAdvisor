using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class PositionConfiguration:
        EntityTypeConfiguration<Position>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public PositionConfiguration()
        {
            ToTable("Position");
            HasKey(l => l.PositionId);
            Property(l => l.PositionId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Latitude)
                .IsRequired();
            Property(l => l.Longitude)
                .IsRequired();
            Ignore(l => l.ThePosition);
        }

        /// <summary>
        /// Get PositionId by Position latitude and longitude
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public long GetPositionIdByLatitudLongitud(double pLatitude, double pLongitude)
        {
            long lReturn = 0;

            if (db.Positions.Where(p => p.Latitude == pLatitude && p.Longitude == pLongitude).Count() > 0)
            {
                lReturn = db.Positions
                                .Where(p => p.Latitude == pLatitude && p.Longitude == pLongitude)
                                .FirstOrDefault().PositionId;
            }

            return lReturn;
        }
    }
}