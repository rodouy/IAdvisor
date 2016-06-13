using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{

    public class KCConfiguration
        : EntityTypeConfiguration<KC>
    {
        public KCConfiguration()
        {
            ToTable("KC");
            HasKey(a => a.KCId);
            Property(a => a.KCId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            #region Relationship

            #endregion
        }

    }
}