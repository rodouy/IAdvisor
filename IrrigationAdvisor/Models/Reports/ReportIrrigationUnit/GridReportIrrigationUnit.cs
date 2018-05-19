using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace IrrigationAdvisor.Models.Reports.ReportIrrigationUnit
{

    public class GridReportIrrigationUnit
    {
        #region Consts
        #endregion

        #region Fields
        /// <summary>
        /// Fields of Class:
        ///      
        ///
        /// </summary>
        private String day;
        private String dailyRecordDate;
        private String effectiveInputWater;
        private String effectiveRain;
        private String temperature;
        private String evapotranspiration;
        private String availableWater;
        private String phenology;
        private String cropCoefficient;
        private bool showAdministratorColumn;
        private bool showTemperatureColumn;
        private bool showEvapotranspirationColumn;
        private bool showAvailableWaterColumn;
        #endregion

        #region Properties

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

        public String Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        public String Evapotranspiration
        {
            get { return evapotranspiration; }
            set { evapotranspiration = value; }
        }

        public String AvailableWater
        {
            get { return availableWater; }
            set { availableWater = value; }
        }

        public String Phenology
        {
            get { return phenology; }
            set { phenology = value; }
        }

        public String CropCoefficient
        {
            get { return cropCoefficient; }
            set { cropCoefficient = value; }
        }

        public bool ShowEvapotranspirationColumn
        {
            get { return showEvapotranspirationColumn; }
            set { showEvapotranspirationColumn = value; }
        }

        public bool ShowTemperatureColumn
        {
            get { return showTemperatureColumn; }
            set { showTemperatureColumn = value; }
        }

        public bool ShowAvailableWaterColumn
        {
            get { return showAvailableWaterColumn; }
            set { showAvailableWaterColumn = value; }
        }
        public bool ShowAdministratorColumn
        {
            get { return showAdministratorColumn; }
            set { showAdministratorColumn = value; }
        }

        #endregion


        public GridReportIrrigationUnit(String pDay, String pDailyRecordDate, String pEffectiveInputWater, String pEffectiveRain,
                                String pTemperature, String pEvapotranspiration, String pAvailableWater, String pPhenology, String pCropCoefficient,
                                bool pShowEvapotranspirationColumn, bool pShowTemperatureColumn, bool pShowAvailableWaterColumn, bool pShowAdministratorColumn)
        {
            this.Day = pDay;
            this.DailyRecordDate = pDailyRecordDate;
            this.EffectiveInputWater = pEffectiveInputWater;
            this.EffectiveRain = pEffectiveRain;
            this.Temperature = pTemperature;
            this.Evapotranspiration = pEvapotranspiration;
            this.AvailableWater = pAvailableWater;
            this.Phenology = pPhenology;
            this.CropCoefficient = pCropCoefficient;
            this.ShowAvailableWaterColumn = pShowEvapotranspirationColumn;
            this.ShowEvapotranspirationColumn = pShowEvapotranspirationColumn;
            this.ShowTemperatureColumn = pShowTemperatureColumn;
            this.ShowAdministratorColumn = pShowAdministratorColumn;
        }


    }
}