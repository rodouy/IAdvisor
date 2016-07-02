using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Security;

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

        public List<Farm> getFarmsBy(User pUser)
        {
            List<Farm> lReturn;
            
            lReturn = db.Farms.Where(f => f.UserId == pUser.UserId).ToList();

            return lReturn;
        }
    }
}