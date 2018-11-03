﻿using IrrigationAdvisor.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using IrrigationAdvisor.Models.Management;

namespace IrrigationAdvisor.Models.GridHome
{

    public class GridPivotDetailHome
    {
        #region Consts
        public CultureInfo culture = new System.Globalization.CultureInfo("Es-Es");
        #endregion

        #region Fields

        /// <summary>
        /// Fields of Class:
        ///     -  string Day
        ///     -  string pivotDate
        ///     -  IrrigationAdvisor.Models.Utilities.Utils.WeatherGrid irrigationQuantity

        /// </summary>

        private Double irrigationQuantity; // Riego
        private Double rainQuantity; // Lluvia
        private Double forecastIrrigationQuantity;
        private DateTime dateOfData;
        private bool isToday;
        private Utils.IrrigationStatus irrigationStatus;
        private String phenology;
        private DailyRecord dailyRecord;

        #endregion

        #region Properties

        public Double IrrigationQuantity
        {
            get { return irrigationQuantity; }
            set { irrigationQuantity = value; }
        }

        public Double RainQuantity
        {
            get { return rainQuantity; }
            set { rainQuantity = value; }
        }

        public Double ForecastIrrigationQuantity
        {
            get { return forecastIrrigationQuantity; }
            set { forecastIrrigationQuantity = value; }
        }

        public DateTime DateOfData
        {
            get { return dateOfData; }
            set { dateOfData = value; }
        }

        public String Day
        {
            get
            {
                return Utils.DayOfWeekInSpanish(DateOfData.DayOfWeek);
            }
        }

        public bool IsToday
        {
            get { return isToday; }
            set { isToday = value; }
        }

        public Utils.IrrigationStatus IrrigationStatus
        {
            get { return irrigationStatus; }
            set { irrigationStatus = value; }
        }


        public String Phenology
        {
            get
            {
                return phenology;
            }
            set { phenology = value; }
        }

        public DailyRecord DailyRecord
        {
            get
            {
                return dailyRecord;
            }
            set { dailyRecord = value; }
        }

        public bool IsIrrigationConfirmed
        {
            get; set;
        }

        #endregion

        public GridPivotDetailHome(Double pIrrigationQuantity, Double pRainQuantity,
                                    Double pForecastIrrigationQuantity, DateTime pDateOfData, 
                                    bool pIsToday, Utils.IrrigationStatus pIrrigationStatus,
                                    String pPhenology,
                                    bool pIsIrrigationConfirmed,
                                    DailyRecord pDailyRecord = null)
        {
            this.IrrigationQuantity = pIrrigationQuantity;
            this.RainQuantity = pRainQuantity;
            this.ForecastIrrigationQuantity = pForecastIrrigationQuantity;
            this.DateOfData = pDateOfData;
            this.IsToday = pIsToday;
            this.IrrigationStatus = pIrrigationStatus;
            this.Phenology = pPhenology;
            this.DailyRecord = pDailyRecord;
            this.IsIrrigationConfirmed = pIsIrrigationConfirmed;
        }
    }
}