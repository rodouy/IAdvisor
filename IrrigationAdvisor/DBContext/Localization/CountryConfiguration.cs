using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class CountryConfiguration:
        EntityTypeConfiguration<Country>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public CountryConfiguration()
        {
            ToTable("Country");
            HasKey(l => l.CountryId);
            Property(l => l.CountryId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(l => l.CapitalId).
                IsOptional();
            
        }


        /// <summary>
        /// Get all cities
        /// </summary>
        /// <returns></returns>
        public List<Country> GetAllCountries()
        {
            return db.Countries.ToList();
        }

        public long GetMaxCountryId(){
            return db.Countries.Max(table => table.CountryId);

        }
    }
}