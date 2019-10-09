using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;

namespace IrrigationAdvisor.DBContext.Localization
{
    public class RegionConfiguration:
        EntityTypeConfiguration<Region>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        public RegionConfiguration()
        {
            ToTable("Region");
            HasKey(l => l.RegionId);
            Property(l => l.RegionId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(l => l.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }
        public List<Region> GetAllRegions()
        {
            return db.Regions.ToList();
        }
    }
}