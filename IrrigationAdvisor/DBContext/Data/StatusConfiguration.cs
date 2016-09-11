using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Data;

namespace IrrigationAdvisor.DBContext.Data
{
    public class StatusConfiguration :
        EntityTypeConfiguration<Status>
    {
        public StatusConfiguration()
        {
            ToTable("Status");
            HasKey(s => s.StatusId);
            Property(s => s.Name)
                .IsRequired();
            Property(s => s.DateOfReference)
                .IsRequired();
            Property(s => s.WebStatus)
                .IsRequired();

            #region Relationship

            #endregion

        }
    }
}