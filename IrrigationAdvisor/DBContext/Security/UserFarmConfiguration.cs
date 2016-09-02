using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Security;

namespace IrrigationAdvisor.DBContext.Security
{
    public class UserFarmConfiguration :
        EntityTypeConfiguration<UserFarm>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();


        private const string ERROR_USERFARM_EXISTS = "User not found in Farms";

        public UserFarmConfiguration()
        {
            ToTable("UserFarm");
            HasKey(uf => uf.UserFarmId);
            Property(s => s.UserFarmId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(s => s.UserId)
                .IsRequired();
            Property(s => s.FarmId)
                .IsRequired();
            Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(50);
            Property(s => s.StartDate)
                .IsRequired();
            
        }

    }
}