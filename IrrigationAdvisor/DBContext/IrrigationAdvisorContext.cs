﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using IrrigationAdvisor.Models.Agriculture;
using IrrigationAdvisor.Models.Data;
using IrrigationAdvisor.Models.Irrigation;
using IrrigationAdvisor.Models.Language;
using IrrigationAdvisor.Models.Localization;
using IrrigationAdvisor.Models.Management;
using IrrigationAdvisor.Models.Security;
using IrrigationAdvisor.Models.Utilities;
using IrrigationAdvisor.Models.Water;
using IrrigationAdvisor.Models.Weather;
using System.Data.Entity.ModelConfiguration.Conventions;
using IrrigationAdvisor.DBContext.Agriculture;
using IrrigationAdvisor.DBContext.Data;
using IrrigationAdvisor.DBContext.Irrigation;
using IrrigationAdvisor.DBContext.Language;
using IrrigationAdvisor.DBContext.Localization;
using IrrigationAdvisor.DBContext.Management;
using IrrigationAdvisor.DBContext.Security;
using IrrigationAdvisor.DBContext.Water;
using IrrigationAdvisor.DBContext.Weather;
using System.Data.Entity.Infrastructure;


namespace IrrigationAdvisor.DBContext
{
    
    public partial class IrrigationAdvisorContext
        : DbContext
    {
        private static IrrigationAdvisorContext _instance;

        /// <summary>
        /// New instance if needed
        /// </summary>
        /// <returns></returns>
        public static IrrigationAdvisorContext Instance()
        {
            if (_instance == null)
            {
                _instance = new IrrigationAdvisorContext();
            }

            return _instance;
        }

        /// <summary>
        /// New instance, so new context to refresh from database.
        /// </summary>
        /// <returns></returns>
        public static IrrigationAdvisorContext Refresh()
        {
            return _instance = new IrrigationAdvisorContext();
        }

        public IrrigationAdvisorContext()
            :base("name=IrrigationAdvisorContext")
        {
            this.Database.CommandTimeout = 250;
        }

        public IrrigationAdvisorContext(string databaseName)
            : base(databaseName)
        {
            this.Database.CommandTimeout = 250;
        }

        #region Agriculture
        #if true

        public virtual DbSet<Crop> Crops { get; set; }

        public virtual DbSet<CropCoefficient> CropCoefficients { get; set; }

        public virtual DbSet<CropInformationByDate> CropInformationByDates { get; set; }

        public virtual DbSet<Horizon> Horizons { get; set; }

        public virtual DbSet<PhenologicalStage> PhenologicalStages { get; set; }

        public virtual DbSet<PhenologicalStageAdjustment> PhenologicalStageAdjustments { get; set; }

        public virtual DbSet<Soil> Soils { get; set; }

        public virtual DbSet<Specie> Species { get; set; }

        public virtual DbSet<SpecieCycle> SpecieCycles { get; set; }

        public virtual DbSet<Stage> Stages { get; set; }

        #endif
        #endregion

        #region Data
        #if true

        public virtual DbSet<Status> Status { get; set; }

        #endif
        #endregion

        #region Irrigation
        #if true

        public virtual DbSet<Bomb> Bombs { get; set; }

        public virtual DbSet<Drip> Drips { get; set; }

        public virtual DbSet<IrrigationUnit> IrrigationUnits { get; set; }

        public virtual DbSet<Pivot> Pivots { get; set; }

        public virtual DbSet<Sprinkler> Sprinklers { get; set; }

        #endif      
        #endregion
        
        #region Language
        #if true

        public virtual DbSet<Models.Language.Language> Languages { get; set; }

        #endif
        #endregion
        
        #region Localization
        #if true

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Country> Countries { get; set; }

        public virtual DbSet<Farm> Farms { get; set; }

        public virtual DbSet<Location> Locations { get; set; }

        public virtual DbSet<Position> Positions { get; set; }

        public virtual DbSet<Region> Regions { get; set; }

        #endif
        #endregion

        #region Management
        #if true

        public virtual DbSet<CropIrrigationWeather> CropIrrigationWeathers { get; set; }

        public virtual DbSet<DailyRecord> DailyRecords { get; set; }

        public virtual DbSet<Title> Titles { get; set; }

        public virtual DbSet<Message> Messages { get; set; }

        #endif
        #endregion

        #region Security
        #if true

        public virtual DbSet<Access> Accesses { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<SiteItem> SiteItems { get; set; }

        public virtual DbSet<Models.Security.SiteMap> SiteMaps { get; set; }

        public virtual DbSet<UserFarm> UserFarms { get; set; }

        public virtual DbSet<UserAccess> UserAccesses { get; set; }

        #endif
        #endregion

        #region Utilities
        #if false

        #endif
        #endregion

        #region Water
        #if true

        public virtual DbSet<EffectiveRain> EffectiveRains { get; set; }

        public virtual DbSet<EvapotranspirationCrop> EvapotranspirationCrops { get; set; }

        public virtual DbSet<Models.Water.Irrigation> Irrigations { get; set; }

        public virtual DbSet<Rain> Rains { get; set; }

        public virtual DbSet<WaterInput> WaterInputs { get; set; }

        public virtual DbSet<WaterOutput> WaterOutputs { get; set; }

        #endif
        #endregion

        #region Weather
        #if true

        public virtual DbSet<TemperatureData> TemperatureDatas { get; set; }

        public virtual DbSet<WeatherData> WeatherDatas { get; set; }

        public virtual DbSet<WeatherInformation> WeatherInformations { get; set; }

        public virtual DbSet<WeatherStation> WeatherStations { get; set; }
        public virtual DbSet<MeteoblueWeatherData> MeteoblueWeatherDatas { get; set; }

        #endif
        #endregion



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            #region Agriculture
            #if true

            modelBuilder.Configurations.Add(new CropConfiguration());
            modelBuilder.Configurations.Add(new CropCoefficientConfiguration());
            modelBuilder.Configurations.Add(new CropInformationByDateConfiguration());
            modelBuilder.Configurations.Add(new HorizonConfiguration());
            modelBuilder.Configurations.Add(new KCConfiguration());
            modelBuilder.Configurations.Add(new PhenologicalStageConfiguration());
            modelBuilder.Configurations.Add(new PhenologicalStageAdjustmentConfiguration());
            modelBuilder.Configurations.Add(new SoilConfiguration());
            modelBuilder.Configurations.Add(new SpecieConfiguration());
            modelBuilder.Configurations.Add(new SpecieCycleConfiguration());
            modelBuilder.Configurations.Add(new StageConfiguration());

            #endif
            #endregion

            #region Data
            #if true

            modelBuilder.Configurations.Add(new StatusConfiguration());

            #endif
            #endregion
        
            #region Irrigation
            #if true

            modelBuilder.Configurations.Add(new BombConfiguration());
            modelBuilder.Configurations.Add(new DripConfiguration());
            modelBuilder.Configurations.Add(new IrrigationUnitConfiguration());
            modelBuilder.Configurations.Add(new PivotConfiguration());
            modelBuilder.Configurations.Add(new SprinklerConfiguration());

            #endif
            #endregion
        
            #region Language
            #if true

            modelBuilder.Configurations.Add(new LanguageConfiguration());

            #endif
            #endregion
        
            #region Localization
            #if true

            modelBuilder.Configurations.Add(new CityConfiguration());
            modelBuilder.Configurations.Add(new CountryConfiguration());
            modelBuilder.Configurations.Add(new FarmConfiguration());
            modelBuilder.Configurations.Add(new LocationConfiguration());
            modelBuilder.Configurations.Add(new PositionConfiguration());
            modelBuilder.Configurations.Add(new RegionConfiguration());

            #endif
            #endregion

            #region Management
            #if true

            modelBuilder.Configurations.Add(new CropIrrigationWeatherConfiguration());
            modelBuilder.Configurations.Add(new DailyRecordConfiguration());
            modelBuilder.Configurations.Add(new TitleConfiguration());
            modelBuilder.Configurations.Add(new MessageConfiguration());

            #endif
            #endregion

            #region Security
            #if true

            modelBuilder.Configurations.Add(new AccessConfiguration());
            modelBuilder.Configurations.Add(new MenuConfiguration());
            modelBuilder.Configurations.Add(new RoleConfiguration());
            modelBuilder.Configurations.Add(new SiteItemConfiguration());
            modelBuilder.Configurations.Add(new SiteMapConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new UserFarmConfiguration());
            #endif
            #endregion

            #region Utilities
            #if false

            #endif
            #endregion

            #region Water
            #if true

            modelBuilder.Configurations.Add(new WaterInputConfiguration());
            modelBuilder.Configurations.Add(new WaterOutputConfiguration());
            modelBuilder.Configurations.Add(new EffectiveRainConfiguration());
            modelBuilder.Configurations.Add(new EvapotranspirationCropConfiguration());
            modelBuilder.Configurations.Add(new IrrigationConfiguration());
            modelBuilder.Configurations.Add(new RainConfiguration());

            #endif
            #endregion

            #region Weather
            #if true

            modelBuilder.Configurations.Add(new TemperatureDataConfiguration());
            modelBuilder.Configurations.Add(new WeatherDataConfiguration());
            modelBuilder.Configurations.Add(new WeatherInformationConfiguration());
            modelBuilder.Configurations.Add(new WeatherStationConfiguration());
            modelBuilder.Configurations.Add(new MeteoblueWeatherDataConfiguration());

            #endif
            #endregion

 	        base.OnModelCreating(modelBuilder);
        }

    }
}