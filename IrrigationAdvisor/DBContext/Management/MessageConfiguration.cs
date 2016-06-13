using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.DBContext.Management
{
    public class MessageConfiguration:
        EntityTypeConfiguration<Message>
    {

        public MessageConfiguration()
        {
            ToTable("Message");
            HasKey(m => m.MessageId);
            Property(m => m.TitleId)
                .IsRequired();
            Property(m => m.LineId)
                .IsRequired();
            Property(m => m.CropIrrigationWeatherId)
                .IsRequired();
            Property(m => m.Daily)
                .IsRequired();

        }
    }
}