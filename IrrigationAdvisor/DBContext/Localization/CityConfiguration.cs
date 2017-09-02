using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class CityConfiguration:
        EntityTypeConfiguration<City>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public CityConfiguration()
        {
            ToTable("City");
            HasKey(l => l.CityId);
            Property(l => l.CityId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
           
        }


        /// <summary>
        /// Get Latitude by Position Id
        /// </summary>
        /// <param name="pPositionId"></param>
        /// <returns></returns>
        public Double GetLatitudeBy(long pPositionId)
        {
            Double lReturn = 0;

            lReturn = db.Positions.Where(p => p.PositionId == pPositionId).FirstOrDefault().Latitude;

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

            lReturn = db.Positions.Where(p => p.PositionId == pPositionId).FirstOrDefault().Longitude;

            return lReturn;
        }

        /// <summary>
        /// Get all cities
        /// </summary>
        /// <returns></returns>
        public List<City> GetAllCities()
        {
            return db.Cities.ToList();
        }
    }
}