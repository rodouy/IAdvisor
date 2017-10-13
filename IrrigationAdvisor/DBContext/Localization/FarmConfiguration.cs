using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;
using System.Data.Entity;
using IrrigationAdvisor.Models.Utilities;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class FarmConfiguration:
        EntityTypeConfiguration<Farm>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

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
            UserFarm lUserFarm = null;

            if (pUser != null)
            {
                lFarmList = db.Farms
                    .Include(f => f.IrrigationUnitList)
                    .Include(f => f.City)
                    .Include(f => f.UserFarmList).ToList();
                foreach (Farm item in lFarmList)
                {
                    lUserFarm = item.UserFarmList.Where(uf => uf.UserId == pUser.UserId).FirstOrDefault();
                    if (lUserFarm != null)
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
            
            if(pUser != null)
            {
                lReturn = (from ul in db.UserFarms
                           join f in db.Farms
                           on ul.FarmId equals f.FarmId
                           where ul.UserId == pUser.UserId
                           select f).Include(f => f.BombList)
                                        .Include(f => f.IrrigationUnitList)
                                        .Include(f => f.WeatherStation)
                                        .Include(f => f.City).ToList();
            }
            
            return lReturn;
        }

        public List<Farm> GetFarmWithActiveCropIrrigationWeathersListBy(User pUser)
        {
            List<Farm> lReturn = null;

            DateTime lDate = Utils.GetDateOfReference().Value;
            if (pUser != null)
            {
                lReturn = (from ul in db.UserFarms
                           join f in db.Farms
                           on ul.FarmId equals f.FarmId
                           join i in db.IrrigationUnits
                           on f.FarmId equals i.FarmId
                           join ciw in db.CropIrrigationWeathers
                           on i.IrrigationUnitId equals ciw.IrrigationUnitId
                           where ul.UserId == pUser.UserId && 
                           ciw.SowingDate <= lDate && 
                           ciw.HarvestDate >= lDate
                           select f).Include(f => f.BombList)
                                        .Include(f => f.IrrigationUnitList)
                                        .Include(f => f.WeatherStation)
                                        .Include(f => f.City).Distinct().ToList();
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

        /// <summary>
        /// Get all Farms
        /// </summary>
        /// <returns></returns>
        public List<Farm> GetAllFarms()
        {
            return db.Farms.ToList();
        }
    }
}