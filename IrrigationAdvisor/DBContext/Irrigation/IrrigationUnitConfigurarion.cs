using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Localization;
using System.Data.Entity;

namespace IrrigationAdvisor.DBContext.Irrigation
{
    public class IrrigationUnitConfigurarion:
        EntityTypeConfiguration<IrrigationUnit>
    {

        private IrrigationAdvisorContext db = new IrrigationAdvisorContext();

        public IrrigationUnitConfigurarion()
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
        /// Get List of IrrigationUnit by Farm
        /// </summary>
        /// <param name="pFarm"></param>
        /// <returns></returns>
        public List<IrrigationUnit> GetIrrigationUnitListBy(Farm pFarm)
        {
            List<IrrigationUnit> lReturn = null;
            Farm lFarm = null;

            if (pFarm != null)
            {
                lFarm = db.Farms
                    .Include(f => f.IrrigationUnitList)
                    .Where(f => f.FarmId == pFarm.FarmId).FirstOrDefault();
                lReturn = lFarm.IrrigationUnitList.ToList();
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