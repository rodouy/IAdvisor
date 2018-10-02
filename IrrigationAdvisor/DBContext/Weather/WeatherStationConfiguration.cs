﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using IrrigationAdvisor.Models.Weather;
using IrrigationAdvisor.Models.Localization;


namespace IrrigationAdvisor.DBContext.Weather
{
    public class WeatherStationConfiguration:
        EntityTypeConfiguration<WeatherStation>

    {
        private IrrigationAdvisorContext db = IrrigationAdvisorContext.Instance();

        public WeatherStationConfiguration()
        {
            ToTable("WeatherStation");
            HasKey(w => w.WeatherStationId);
            Property(w => w.WeatherStationId)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(w => w.Name)
                .IsRequired();
            
        }

        /// <summary>
        /// Get all Weather Stations
        /// </summary>
        /// <returns></returns>
        public List<WeatherStation> GetAllWeatherStations()
        {
            return db.WeatherStations.ToList();
        }
        /// <summary>
        /// Get max Weather Stations id
        /// </summary>
        /// <returns></returns>
        public long GetMaxWeatherStationId()
        {
            return db.WeatherStations.Max(s => s.WeatherStationId);
        }



    }
}