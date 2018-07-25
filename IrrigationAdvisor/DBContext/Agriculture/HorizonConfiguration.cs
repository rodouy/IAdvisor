using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;
using System.Data.Entity;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class HorizonConfiguration:
        EntityTypeConfiguration<Horizon>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        public HorizonConfiguration()
        {
            ToTable("Horizon");
            HasKey(h => h.HorizonId);
            Property(h => h.HorizonId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(50);
            
        }

        /// <summary>
        /// Get List of Bomb by Farm
        /// </summary>
        /// <param name="pFarm"></param>
        /// <returns></returns>
        public List<Horizon> GetHorizonListBy(Soil pSoil)
        {
            List<Horizon> lReturn = null;
            Soil lSoil = null;

            if (pSoil != null)
            {
                lSoil = db.Soils
                    .Include(s => s.HorizonList)
                    .Where(s => s.SoilId == pSoil.SoilId).FirstOrDefault();
                lReturn = lSoil.HorizonList.ToList();
            }

            return lReturn;
        }
    }
}

