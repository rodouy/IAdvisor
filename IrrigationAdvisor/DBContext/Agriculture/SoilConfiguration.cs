using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class SoilConfiguration:
        EntityTypeConfiguration<Soil>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public SoilConfiguration()
        {
            ToTable("Soil");
            HasKey(s => s.SoilId);
            Property(s => s.SoilId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.DepthLimit)
                .IsRequired();

        }
        /// <summary>
        /// Get all soils
        /// </summary>
        /// <returns></returns>
        public List<Soil> GetAllSoils()
        {
            return db.Soils.ToList();
        }
    }
}