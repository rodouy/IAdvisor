using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 

namespace IrrigationAdvisor.Models.Reports
{

    public class GridDailyRecordIrrigationResume 
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// Fields of Class:
        ///      
        ///
        /// </summary>
        private String dailyRecordDate;
        private String effectiveInputWater;
        private String effectiveRain;


        #endregion

        #region Properties

        public String DailyRecordDate
        {
            get { return dailyRecordDate; }
            set
            {
                dailyRecordDate = value;
            }
        }

        public String EffectiveInputWater
        {
            get { return effectiveInputWater; }
            set { effectiveInputWater = value; }
        }

        public String EffectiveRain
        {
            get { return effectiveRain; }
            set { effectiveRain = value; }
        }


        #endregion


        public GridDailyRecordIrrigationResume(String pDailyRecordDate, String pEffectiveInputWater, String pEffectiveRain)
        {
            this.dailyRecordDate = pDailyRecordDate;
            this.effectiveInputWater = pEffectiveInputWater;
            this.effectiveRain = pEffectiveRain;
          
        }


    }
}