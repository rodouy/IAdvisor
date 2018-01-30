using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IrrigationAdvisor.Models.Reports.ReportPivotState
{

    public class GridReportPivotState 
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// Fields of Class:
        ///      
        ///
        /// </summary>
        private String name;
        private String day;
        private String dailyRecordDate;
        private String effectiveInputWater;
        private String effectiveRain;


        #endregion

        #region Properties
        public String Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public String Day
        {
            get { return day; }
            set
            {
                day = value;
            }
        }

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


        public GridReportPivotState(String pName, String pDay, String pDailyRecordDate, String pEffectiveInputWater, String pEffectiveRain)
        {
            this.Name = pName;
            this.day = pDay;
            this.dailyRecordDate = pDailyRecordDate;
            this.effectiveInputWater = pEffectiveInputWater;
            this.effectiveRain = pEffectiveRain;
          
        }


    }
}