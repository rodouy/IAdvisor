﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IrrigationAdvisor.Models
{
    public class LanguageContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public LanguageContext() : base("name=LanguageContext")
        {
        }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Language.Language> Languages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.City> Cities { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Country> Countries { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Region> Regions { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Localization.Farm> Farms { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Irrigation.Bomb> Bombs { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Irrigation.Drip> IrrigationUnits { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Crop> Crops { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Specie> Species { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.CropCoefficient> CropCoefficients { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Soil> Soils { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.SpecieCycle> SpecieCycles { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.PhenologicalStage> PhenologicalStages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Horizon> Horizons { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.CropInformationByDate> CropInformationByDates { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.Stage> Stages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Water.EffectiveRain> EffectiveRains { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Weather.WeatherData> WeatherDatas { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Weather.WeatherInformation> WeatherInformations { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Weather.WeatherStation> WeatherStations { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Water.Irrigation> Irrigations { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Water.Rain> Rains { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Water.EvapotranspirationCrop> EvapotranspirationCrops { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Management.CropIrrigationWeather> CropIrrigationWeathers { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Management.DailyRecord> DailyRecords { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.User> Users { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.Menu> Menus { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.Role> Roles { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.Access> Accesses { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.SiteItem> SiteItems { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.SiteMap> SiteMaps { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.KC> KCs { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Weather.TemperatureData> TemperatureDatas { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Agriculture.PhenologicalStageAdjustment> PhenologicalStageAdjustments { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Management.Title> Titles { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Management.Message> Messages { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Security.UserFarm> UserFarms { get; set; }

        public System.Data.Entity.DbSet<IrrigationAdvisor.Models.Data.Status> Status { get; set; }


    }
}
