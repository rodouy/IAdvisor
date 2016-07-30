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
        /// Included: IrrigationUnitList; User; City;
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public List<Farm> GetFarmListIncludedIrrigationUnitListCityBy(User pUser)
        {
            List<Farm> lReturn = null;
            List<Farm> lFarmList = null;
            User lUser = null;

            if (pUser != null)
            {
                lFarmList = db.Farms
                    .Include(f => f.IrrigationUnitList)
                    .Include(f => f.City)
                    .Include(f => f.UserList).ToList();
                foreach (Farm item in lFarmList)
                {
                    lUser = item.UserList.Where(u => u.UserId == pUser.UserId).FirstOrDefault();
                    if(lUser != null)
                    {
                        if(lReturn == null)
                        {
                            lReturn = new List<Farm>();
                        }
                        lReturn.Add(item);
                    }
                }
            }
            return lReturn;
        }

        /// <summary>
        /// Get List of Farms by User
        /// Included: BombList; IrrigationUnitList; User; 
        ///           WeatherStation; City;
        /// </summary>
        /// <param name="pUser"></param>
        /// <returns></returns>
        public List<Farm> GetFarmListBy(User pUser)
        {
            List<Farm> lReturn = null;
            List<Farm> lFarmList = null;
            User lUser = null;
            
            if(pUser != null)
            {
                lFarmList = db.Farms
                    .Include(f => f.BombList)
                    .Include(f => f.IrrigationUnitList)
                    .Include(f => f.WeatherStation)
                    .Include(f => f.City)
                    .Include(f => f.UserList).ToList();
                foreach (Farm item in lFarmList)
                {
                    lUser = item.UserList.Where(u => u.UserId == pUser.UserId).FirstOrDefault();
                    if(lUser != null)
                    {
                        if(lReturn == null)
                        {
                            lReturn = new List<Farm>();
                        }
                        lReturn.Add(item);
                    }
                }
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