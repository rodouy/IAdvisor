using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using System.Data.Entity;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class FarmConfiguration:
        EntityTypeConfiguration<Farm>
    {
        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        public FarmConfiguration()
        {
            ToTable("Farm");
            HasKey(l => l.FarmId);
            Property(l => l.FarmId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }

        /// <summary>
        /// Get List of Farms by User
        /// Included: BombList; IrrigationUnitList; User; WeatherStation;
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public List<Farm> GetFarmListBy(User pUser)
        {
            List<Farm> lReturn = null;
            
            if(pUser != null)
            {
                lReturn = db.Farms
                    .Include(f => f.BombList)
                    .Include(f => f.IrrigationUnitList)
                    .Include(f => f.User)
                    .Include(f => f.WeatherStation)
                    .Where(f => f.UserId == pUser.UserId).ToList();
            }

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
                            .Where(p => p.PositionId == pPositionId)
                            .FirstOrDefault().Latitude;

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
                            .Where(p => p.PositionId == pPositionId)
                            .FirstOrDefault().Longitude;

            return lReturn;
        }


    }
}