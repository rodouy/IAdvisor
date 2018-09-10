using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class SpecieConfiguration:
        EntityTypeConfiguration<Specie>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        public SpecieConfiguration()
        {
            ToTable("Specie");
            HasKey(s => s.SpecieId);
            Property(s => s.SpecieId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name).IsRequired().HasMaxLength(50);
            Property(l => l.RegionId).IsOptional();
        }
        public List<Specie> GetAllSpecie()
        {
            return db.Species.OrderBy(m => m.Name).ToList();
        }
        /// <summary>
        /// Get List of Specie by Region
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public List<Specie> GetSpecieListBy(Region pRegion)
        {
            List<Specie> lReturn = null;

            if (pRegion != null)
            {
                lReturn = db.Species
                    //.Include(f => f.SpecieList)
                    .Where(f => f.RegionId == pRegion.RegionId).ToList();

            }

            return lReturn;
        }

    }

}