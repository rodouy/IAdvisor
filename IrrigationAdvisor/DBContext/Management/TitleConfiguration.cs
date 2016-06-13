using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.DBContext.Management
{
    public class TitleConfiguration:
        EntityTypeConfiguration<Title>
    {

        public TitleConfiguration()
        {
            ToTable("Title");
            HasKey(m => m.TitleId);
            Property(m => m.CropIrrigationWeatherId)
                .IsRequired();
            Property(m => m.Daily)
                .IsRequired();
        }
    }
}