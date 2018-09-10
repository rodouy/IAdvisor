using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Agriculture;

namespace IrrigationAdvisor.DBContext.Agriculture
{
    public class CropCoefficientConfiguration
        : EntityTypeConfiguration<CropCoefficient>
    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();
        public CropCoefficientConfiguration()
        {
            ToTable("CropCoefficient");
            HasKey(c => c.CropCoefficientId);
            Property(c => c.CropCoefficientId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            
            #region Relationship

            #endregion
        }

        /// <summary>
        /// Get List of CropCoefficient by Specie
        /// </summary>
        /// <param name="pRegion"></param>
        /// <returns></returns>
        public List<CropCoefficient> GetCropCoefficientListBy(Specie pSpecie)
        {
            List<CropCoefficient> lReturn = null;
            Specie lSpecie = null;

            if (pSpecie != null)
            {
                lReturn = db.CropCoefficients.Where (f => f.SpecieId == pSpecie.SpecieId).ToList();
            }

            return lReturn;
        }

    
    }
}