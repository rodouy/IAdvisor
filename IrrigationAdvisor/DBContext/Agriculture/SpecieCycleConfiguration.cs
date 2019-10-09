using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class SpecieCycleConfiguration:
        EntityTypeConfiguration<SpecieCycle>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        public SpecieCycleConfiguration()
        {
            ToTable("SpecieCycle");
            HasKey(s => s.SpecieCycleId);
            Property(s => s.SpecieCycleId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired().HasMaxLength(50);
            
        }
        public List<SpecieCycle> GetAllSpecieCycles()
        {
            return db.SpecieCycles.OrderBy(m => m.Name).ToList();
        }
    }
}