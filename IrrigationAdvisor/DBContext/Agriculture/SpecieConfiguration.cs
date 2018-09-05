using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

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
    }
}