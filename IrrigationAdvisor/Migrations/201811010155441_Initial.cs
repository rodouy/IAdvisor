namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Access",
                c => new
                    {
                        AccessId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.AccessId);

            CreateTable(
                "dbo.Bomb",
                c => new
                    {
                        BombId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        SerialNumber = c.String(),
                        ServiceDate = c.DateTime(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        PositionId = c.Long(nullable: false),
                        ShortName = c.String(),
                        FarmId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.BombId)
                .ForeignKey("dbo.Farm", t => t.FarmId)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .Index(t => t.PositionId)
                .Index(t => t.FarmId);

            CreateTable(
                "dbo.Farm",
                c => new
                    {
                        FarmId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Company = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        PositionId = c.Long(nullable: false),
                        Has = c.Int(nullable: false),
                        WeatherStationId = c.Long(nullable: false),
                        CityId = c.Long(nullable: false),
                        IrrigationUnitReportShowTemperature = c.Boolean(nullable: false),
                        IrrigationUnitReportShowEvapotranspiration = c.Boolean(nullable: false),
                        IrrigationUnitReportShowAvailableWater = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FarmId)
                .ForeignKey("dbo.City", t => t.CityId)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .ForeignKey("dbo.WeatherStation", t => t.WeatherStationId)
                .Index(t => t.PositionId)
                .Index(t => t.WeatherStationId)
                .Index(t => t.CityId);

            CreateTable(
                "dbo.City",
                c => new
                    {
                        CityId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PositionId = c.Long(nullable: false),
                        CountryId = c.Long(nullable: false),
                        Country_CountryId = c.Long(),
                        Country_CountryId1 = c.Long(),
                    })
                .PrimaryKey(t => t.CityId)
                .ForeignKey("dbo.Country", t => t.Country_CountryId)
                .ForeignKey("dbo.Country", t => t.Country_CountryId1)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .Index(t => t.PositionId)
                .Index(t => t.Country_CountryId)
                .Index(t => t.Country_CountryId1);

            CreateTable(
                "dbo.Country",
                c => new
                    {
                        CountryId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        LanguageId = c.Long(nullable: false),
                        CapitalId = c.Long(nullable: false),
                        Capital_CityId = c.Long(),
                    })
                .PrimaryKey(t => t.CountryId)
                .ForeignKey("dbo.City", t => t.Capital_CityId)
                .ForeignKey("dbo.Language", t => t.LanguageId)
                .Index(t => t.LanguageId)
                .Index(t => t.Capital_CityId);

            CreateTable(
                "dbo.Language",
                c => new
                    {
                        LanguageId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.LanguageId);

            CreateTable(
                "dbo.Region",
                c => new
                    {
                        RegionId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        PositionId = c.Long(nullable: false),
                        Country_CountryId = c.Long(),
                    })
                .PrimaryKey(t => t.RegionId)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .ForeignKey("dbo.Country", t => t.Country_CountryId)
                .Index(t => t.PositionId)
                .Index(t => t.Country_CountryId);

            CreateTable(
                "dbo.EffectiveRain",
                c => new
                    {
                        EffectiveRainId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Month = c.Int(nullable: false),
                        MinRain = c.Double(nullable: false),
                        MaxRain = c.Double(nullable: false),
                        Percentage = c.Double(nullable: false),
                        Region_RegionId = c.Long(),
                    })
                .PrimaryKey(t => t.EffectiveRainId)
                .ForeignKey("dbo.Region", t => t.Region_RegionId)
                .Index(t => t.Region_RegionId);

            CreateTable(
                "dbo.Position",
                c => new
                    {
                        PositionId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.PositionId);

            CreateTable(
                "dbo.SpecieCycle",
                c => new
                    {
                        SpecieCycleId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Duration = c.Double(nullable: false),
                        Region_RegionId = c.Long(),
                    })
                .PrimaryKey(t => t.SpecieCycleId)
                .ForeignKey("dbo.Region", t => t.Region_RegionId)
                .Index(t => t.Region_RegionId);

            CreateTable(
                "dbo.Specie",
                c => new
                    {
                        SpecieId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ShortName = c.String(),
                        SpecieCycleId = c.Long(nullable: false),
                        BaseTemperature = c.Double(nullable: false),
                        StressTemperature = c.Double(nullable: false),
                        SpecieType = c.Int(nullable: false),
                        Region_RegionId = c.Long(),
                    })
                .PrimaryKey(t => t.SpecieId)
                .ForeignKey("dbo.SpecieCycle", t => t.SpecieCycleId)
                .ForeignKey("dbo.Region", t => t.Region_RegionId)
                .Index(t => t.SpecieCycleId)
                .Index(t => t.Region_RegionId);

            CreateTable(
                "dbo.TemperatureData",
                c => new
                    {
                        TemperatureDataId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        RegionId = c.Long(nullable: false),
                        Min = c.Double(nullable: false),
                        Max = c.Double(nullable: false),
                        Average = c.Double(nullable: false),
                        ETC = c.Double(nullable: false),
                        Rain = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TemperatureDataId)
                .ForeignKey("dbo.Region", t => t.RegionId)
                .Index(t => t.RegionId);

            CreateTable(
                "dbo.IrrigationUnit",
                c => new
                    {
                        IrrigationUnitId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ShortName = c.String(),
                        IrrigationType = c.Int(nullable: false),
                        IrrigationEfficiency = c.Double(nullable: false),
                        Surface = c.Double(nullable: false),
                        BombId = c.Long(nullable: false),
                        FarmId = c.Long(nullable: false),
                        PositionId = c.Long(nullable: false),
                        PredeterminatedIrrigationQuantity = c.Double(nullable: false),
                        Show = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IrrigationUnitId)
                .ForeignKey("dbo.Bomb", t => t.BombId)
                .ForeignKey("dbo.Farm", t => t.FarmId)
                .Index(t => t.BombId)
                .Index(t => t.FarmId);

            CreateTable(
                "dbo.Soil",
                c => new
                    {
                        SoilId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Description = c.String(),
                        PositionId = c.Long(nullable: false),
                        TestDate = c.DateTime(nullable: false),
                        DepthLimit = c.Double(nullable: false),
                        ShortName = c.String(),
                        FarmId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SoilId)
                .ForeignKey("dbo.Farm", t => t.FarmId)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .Index(t => t.PositionId)
                .Index(t => t.FarmId);

            CreateTable(
                "dbo.Horizon",
                c => new
                    {
                        HorizonId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Order = c.Int(nullable: false),
                        HorizonLayer = c.String(),
                        HorizonLayerDepth = c.Double(nullable: false),
                        Sand = c.Double(nullable: false),
                        Limo = c.Double(nullable: false),
                        Clay = c.Double(nullable: false),
                        OrganicMatter = c.Double(nullable: false),
                        NitrogenAnalysis = c.Double(nullable: false),
                        BulkDensitySoil = c.Double(nullable: false),
                        Soil_SoilId = c.Long(),
                    })
                .PrimaryKey(t => t.HorizonId)
                .ForeignKey("dbo.Soil", t => t.Soil_SoilId)
                .Index(t => t.Soil_SoilId);

            CreateTable(
                "dbo.UserFarm",
                c => new
                    {
                        UserFarmId = c.Long(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        FarmId = c.Long(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserFarmId)
                .ForeignKey("dbo.Farm", t => t.FarmId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.FarmId);

            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Phone = c.String(nullable: false),
                        Address = c.String(),
                        Email = c.String(),
                        RoleId = c.Long(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.RoleId);

            CreateTable(
                "dbo.UserAccess",
                c => new
                    {
                        UserAccessId = c.Long(nullable: false, identity: true),
                        UserId = c.Long(nullable: false),
                        LogInDate = c.DateTime(nullable: false),
                        LogOutDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.UserAccessId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.WeatherStation",
                c => new
                    {
                        WeatherStationId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Model = c.String(),
                        StationType = c.Int(nullable: false),
                        DateOfInstallation = c.DateTime(nullable: false),
                        DateOfService = c.DateTime(nullable: false),
                        UpdateTime = c.DateTime(nullable: false),
                        WirelessTransmission = c.Int(nullable: false),
                        PositionId = c.Long(nullable: false),
                        GiveET = c.Boolean(nullable: false),
                        WeatherDataType = c.Int(nullable: false),
                        WebAddress = c.String(),
                    })
                .PrimaryKey(t => t.WeatherStationId);

            CreateTable(
                "dbo.WeatherData",
                c => new
                    {
                        WeatherDataId = c.Long(nullable: false, identity: true),
                        WeatherStationId = c.Long(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Temperature = c.Double(nullable: false),
                        TemperatureMax = c.Double(nullable: false),
                        TemperatureMin = c.Double(nullable: false),
                        TemperatureDewPoint = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                        HumidityMax = c.Double(nullable: false),
                        HumidityMin = c.Double(nullable: false),
                        Barometer = c.Double(nullable: false),
                        BarometerMax = c.Double(nullable: false),
                        BarometerMin = c.Double(nullable: false),
                        SolarRadiation = c.Double(nullable: false),
                        UVRadiation = c.Double(nullable: false),
                        RainDay = c.Double(nullable: false),
                        RainStorm = c.Double(nullable: false),
                        RainMonth = c.Double(nullable: false),
                        RainYear = c.Double(nullable: false),
                        Evapotranspiration = c.Double(nullable: false),
                        EvapotranspirationMonth = c.Double(nullable: false),
                        EvapotranspirationYear = c.Double(nullable: false),
                        WindSpeed = c.Double(nullable: false),
                        Observations = c.String(),
                        WeatherDataType = c.Int(nullable: false),
                        WeatherDataInputType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WeatherDataId)
                .ForeignKey("dbo.WeatherStation", t => t.WeatherStationId)
                .Index(t => t.WeatherStationId);

            CreateTable(
                "dbo.CropCoefficient",
                c => new
                    {
                        CropCoefficientId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        SpecieId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.CropCoefficientId)
                .ForeignKey("dbo.Specie", t => t.SpecieId)
                .Index(t => t.SpecieId);

            CreateTable(
                "dbo.KC",
                c => new
                    {
                        KCId = c.Long(nullable: false, identity: true),
                        SpecieId = c.Long(nullable: false),
                        DayAfterSowing = c.Int(nullable: false),
                        Coefficient = c.Double(nullable: false),
                        CropCoefficient_CropCoefficientId = c.Long(),
                    })
                .PrimaryKey(t => t.KCId)
                .ForeignKey("dbo.Specie", t => t.SpecieId)
                .ForeignKey("dbo.CropCoefficient", t => t.CropCoefficient_CropCoefficientId)
                .Index(t => t.SpecieId)
                .Index(t => t.CropCoefficient_CropCoefficientId);

            CreateTable(
                "dbo.CropInformationByDate",
                c => new
                    {
                        CropInformationByDateId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        SowingDate = c.DateTime(nullable: false),
                        CurrentDate = c.DateTime(nullable: false),
                        DaysAfterSowing = c.Int(nullable: false),
                        SpecieId = c.Long(nullable: false),
                        CropCoefficientId = c.Long(nullable: false),
                        RegionId = c.Long(nullable: false),
                        AccumulatedGrowingDegreeDays = c.Double(nullable: false),
                        StageId = c.Long(nullable: false),
                        CropCoefficientValue = c.Double(nullable: false),
                        RootDepth = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.CropInformationByDateId)
                .ForeignKey("dbo.CropCoefficient", t => t.CropCoefficientId)
                .ForeignKey("dbo.Region", t => t.RegionId)
                .ForeignKey("dbo.Specie", t => t.SpecieId)
                .ForeignKey("dbo.Stage", t => t.StageId)
                .Index(t => t.SpecieId)
                .Index(t => t.CropCoefficientId)
                .Index(t => t.RegionId)
                .Index(t => t.StageId);

            CreateTable(
                "dbo.PhenologicalStage",
                c => new
                    {
                        PhenologicalStageId = c.Long(nullable: false, identity: true),
                        SpecieId = c.Long(nullable: false),
                        StageId = c.Long(nullable: false),
                        MinDegree = c.Double(nullable: false),
                        MaxDegree = c.Double(nullable: false),
                        Coefficient = c.Double(nullable: false),
                        RootDepth = c.Double(nullable: false),
                        HydricBalanceDepth = c.Double(nullable: false),
                        PhenologicalStageIsUsed = c.Boolean(nullable: false),
                        DegreesDaysInterval = c.Double(nullable: false),
                        CropInformationByDate_CropInformationByDateId = c.Long(),
                        Crop_CropId = c.Long(),
                    })
                .PrimaryKey(t => t.PhenologicalStageId)
                .ForeignKey("dbo.Specie", t => t.SpecieId)
                .ForeignKey("dbo.Stage", t => t.StageId)
                .ForeignKey("dbo.CropInformationByDate", t => t.CropInformationByDate_CropInformationByDateId)
                .ForeignKey("dbo.Crop", t => t.Crop_CropId)
                .Index(t => t.SpecieId)
                .Index(t => t.StageId)
                .Index(t => t.CropInformationByDate_CropInformationByDateId)
                .Index(t => t.Crop_CropId);

            CreateTable(
                "dbo.Stage",
                c => new
                    {
                        StageId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ShortName = c.String(),
                        Description = c.String(),
                        Order = c.Int(nullable: false),
                        Crop_CropId = c.Long(),
                    })
                .PrimaryKey(t => t.StageId)
                .ForeignKey("dbo.Crop", t => t.Crop_CropId)
                .Index(t => t.Crop_CropId);

            CreateTable(
                "dbo.CropIrrigationWeather",
                c => new
                    {
                        CropIrrigationWeatherId = c.Long(nullable: false, identity: true),
                        CropIrrigationWeatherName = c.String(),
                        CropId = c.Long(nullable: false),
                        SoilId = c.Long(nullable: false),
                        Density = c.Double(nullable: false),
                        SowingDate = c.DateTime(nullable: false),
                        HarvestDate = c.DateTime(nullable: false),
                        CropDate = c.DateTime(nullable: false),
                        StartAdvisorDate = c.DateTime(nullable: false),
                        DaysForHydricBalanceUnchangableAfterSowing = c.Int(nullable: false),
                        PhenologicalStageId = c.Long(nullable: false),
                        HydricBalance = c.Double(nullable: false),
                        SoilHydricVolume = c.Double(nullable: false),
                        TotalEvapotranspirationCropFromLastWaterInput = c.Double(nullable: false),
                        CalculusMethodForPhenologicalAdjustment = c.Int(nullable: false),
                        CropInformationByDateId = c.Long(nullable: false),
                        DaysAfterSowing = c.Int(nullable: false),
                        DaysAfterSowingModified = c.Int(nullable: false),
                        GrowingDegreeDaysAccumulated = c.Double(nullable: false),
                        GrowingDegreeDaysModified = c.Double(nullable: false),
                        GrowingDegreeDaysExtraGap = c.Double(nullable: false),
                        LastDayOfGrowingDegreeDays = c.DateTime(nullable: false),
                        IrrigationUnitId = c.Long(nullable: false),
                        MaxIrrigationQuantity = c.Double(nullable: false),
                        AdjustableIrrigationQuantity = c.Boolean(nullable: false),
                        PredeterminatedIrrigationQuantity = c.Double(nullable: false),
                        HasAdviseOfIrrigation = c.Boolean(nullable: false),
                        PositionId = c.Long(nullable: false),
                        LastWaterInputDate = c.DateTime(nullable: false),
                        LastBigWaterInputDate = c.DateTime(nullable: false),
                        LastPartialWaterInputDate = c.DateTime(nullable: false),
                        LastPartialWaterInput = c.Double(nullable: false),
                        LastBigGapWaterInputDate = c.DateTime(nullable: false),
                        MainWeatherStationId = c.Long(nullable: false),
                        AlternativeWeatherStationId = c.Long(nullable: false),
                        UsingMainWeatherStation = c.Boolean(nullable: false),
                        WeatherEventType = c.Int(nullable: false),
                        TotalEvapotranspirationCrop = c.Double(nullable: false),
                        TotalEffectiveRain = c.Double(nullable: false),
                        TotalRealRain = c.Double(nullable: false),
                        TotalIrrigation = c.Double(nullable: false),
                        TotalIrrigationInHydricBalance = c.Double(nullable: false),
                        TotalExtraIrrigation = c.Double(nullable: false),
                        TotalExtraIrrigationInHydricBalance = c.Double(nullable: false),
                        OutPut = c.String(),
                        TotalMessageLines = c.Long(nullable: false),
                        TotalMessageDailyLines = c.Long(nullable: false),
                        TextLog = c.String(),
                        AlternativeWeatherStation_WeatherStationId = c.Long(),
                        MainWeatherStation_WeatherStationId = c.Long(),
                    })
                .PrimaryKey(t => t.CropIrrigationWeatherId)
                .ForeignKey("dbo.WeatherStation", t => t.AlternativeWeatherStation_WeatherStationId)
                .ForeignKey("dbo.Crop", t => t.CropId)
                .ForeignKey("dbo.CropInformationByDate", t => t.CropInformationByDateId)
                .ForeignKey("dbo.IrrigationUnit", t => t.IrrigationUnitId)
                .ForeignKey("dbo.WeatherStation", t => t.MainWeatherStation_WeatherStationId)
                .ForeignKey("dbo.PhenologicalStage", t => t.PhenologicalStageId)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .ForeignKey("dbo.Soil", t => t.SoilId)
                .Index(t => t.CropId)
                .Index(t => t.SoilId)
                .Index(t => t.PhenologicalStageId)
                .Index(t => t.CropInformationByDateId)
                .Index(t => t.IrrigationUnitId)
                .Index(t => t.PositionId)
                .Index(t => t.AlternativeWeatherStation_WeatherStationId)
                .Index(t => t.MainWeatherStation_WeatherStationId);

            CreateTable(
                "dbo.Crop",
                c => new
                    {
                        CropId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        ShortName = c.String(),
                        RegionId = c.Long(nullable: false),
                        SpecieId = c.Long(nullable: false),
                        CropCoefficientId = c.Long(nullable: false),
                        MinStageToConsiderETinHBCalculationId = c.Long(nullable: false),
                        MaxEvapotranspirationToIrrigate = c.Double(nullable: false),
                        MinEvapotranspirationToIrrigate = c.Double(nullable: false),
                        StopIrrigationStageId = c.Long(nullable: false),
                        MinStageToConsiderETinHBCalculation_StageId = c.Long(),
                        StopIrrigationStage_StageId = c.Long(),
                    })
                .PrimaryKey(t => t.CropId)
                .ForeignKey("dbo.CropCoefficient", t => t.CropCoefficientId)
                .ForeignKey("dbo.Stage", t => t.MinStageToConsiderETinHBCalculation_StageId)
                .ForeignKey("dbo.Region", t => t.RegionId)
                .ForeignKey("dbo.Specie", t => t.SpecieId)
                .ForeignKey("dbo.Stage", t => t.StopIrrigationStage_StageId)
                .Index(t => t.RegionId)
                .Index(t => t.SpecieId)
                .Index(t => t.CropCoefficientId)
                .Index(t => t.MinStageToConsiderETinHBCalculation_StageId)
                .Index(t => t.StopIrrigationStage_StageId);

            CreateTable(
                "dbo.DailyRecord",
                c => new
                    {
                        DailyRecordId = c.Long(nullable: false, identity: true),
                        DailyRecordDateTime = c.DateTime(nullable: false),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                        MainWeatherDataId = c.Long(nullable: false),
                        AlternativeWeatherDataId = c.Long(nullable: false),
                        DaysAfterSowing = c.Int(nullable: false),
                        DaysAfterSowingModified = c.Int(nullable: false),
                        GrowingDegreeDays = c.Double(nullable: false),
                        GrowingDegreeDaysAccumulated = c.Double(nullable: false),
                        GrowingDegreeDaysModified = c.Double(nullable: false),
                        LastDayOfGrowingDegreeDays = c.DateTime(nullable: false),
                        RainId = c.Long(nullable: false),
                        IrrigationId = c.Long(nullable: false),
                        LastWaterInputDate = c.DateTime(nullable: false),
                        LastBigWaterInputDate = c.DateTime(nullable: false),
                        LastPartialWaterInputDate = c.DateTime(nullable: false),
                        LastPartialWaterInput = c.Double(nullable: false),
                        LastBigGapWaterInputDate = c.DateTime(nullable: false),
                        EvapotranspirationCropId = c.Long(nullable: false),
                        TotalEffectiveInputWater = c.Double(nullable: false),
                        PercentageOfHydricBalance = c.Double(nullable: false),
                        GAPPercentageOfHydricBalance = c.Double(nullable: false),
                        PhenologicalStageId = c.Long(nullable: false),
                        HydricBalance = c.Double(nullable: false),
                        SoilHydricVolume = c.Double(nullable: false),
                        TotalEvapotranspirationCropFromLastWaterInput = c.Double(nullable: false),
                        CropCoefficient = c.Double(nullable: false),
                        Observations = c.String(),
                        TotalEvapotranspirationCrop = c.Double(nullable: false),
                        TotalEffectiveRain = c.Double(nullable: false),
                        TotalRealRain = c.Double(nullable: false),
                        TotalIrrigation = c.Double(nullable: false),
                        TotalIrrigationInHydricBalance = c.Double(nullable: false),
                        TotalExtraIrrigation = c.Double(nullable: false),
                        TotalExtraIrrigationInHydricBalance = c.Double(nullable: false),
                        AlternativeWeatherData_WeatherDataId = c.Long(),
                        EvapotranspirationCrop_WaterOutputId = c.Long(),
                        Irrigation_WaterInputId = c.Long(),
                        MainWeatherData_WeatherDataId = c.Long(),
                        Rain_WaterInputId = c.Long(),
                    })
                .PrimaryKey(t => t.DailyRecordId)
                .ForeignKey("dbo.WeatherData", t => t.AlternativeWeatherData_WeatherDataId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .ForeignKey("dbo.EvapotranspirationCrop", t => t.EvapotranspirationCrop_WaterOutputId)
                .ForeignKey("dbo.Irrigation", t => t.Irrigation_WaterInputId)
                .ForeignKey("dbo.WeatherData", t => t.MainWeatherData_WeatherDataId)
                .ForeignKey("dbo.PhenologicalStage", t => t.PhenologicalStageId)
                .ForeignKey("dbo.Rain", t => t.Rain_WaterInputId)
                .Index(t => t.CropIrrigationWeatherId)
                .Index(t => t.PhenologicalStageId)
                .Index(t => t.AlternativeWeatherData_WeatherDataId)
                .Index(t => t.EvapotranspirationCrop_WaterOutputId)
                .Index(t => t.Irrigation_WaterInputId)
                .Index(t => t.MainWeatherData_WeatherDataId)
                .Index(t => t.Rain_WaterInputId);

            CreateTable(
                "dbo.WaterOutput",
                c => new
                    {
                        WaterOutputId = c.Long(nullable: false, identity: true),
                        Output = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ExtraOutput = c.Double(nullable: false),
                        ExtraDate = c.DateTime(nullable: false),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.WaterOutputId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .Index(t => t.CropIrrigationWeatherId);

            CreateTable(
                "dbo.WaterInput",
                c => new
                    {
                        WaterInputId = c.Long(nullable: false, identity: true),
                        Input = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ExtraInput = c.Double(nullable: false),
                        ExtraDate = c.DateTime(nullable: false),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.WaterInputId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .Index(t => t.CropIrrigationWeatherId);

            CreateTable(
                "dbo.PhenologicalStageAdjustment",
                c => new
                    {
                        PhenologicalStageAdjustmentId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        CropId = c.Long(nullable: false),
                        DateOfChange = c.DateTime(nullable: false),
                        StageId = c.Long(nullable: false),
                        PhenologicalStageId = c.Long(nullable: false),
                        Observation = c.String(),
                        CropIrrigationWeather_CropIrrigationWeatherId = c.Long(),
                    })
                .PrimaryKey(t => t.PhenologicalStageAdjustmentId)
                .ForeignKey("dbo.Crop", t => t.CropId)
                .ForeignKey("dbo.PhenologicalStage", t => t.PhenologicalStageId)
                .ForeignKey("dbo.Stage", t => t.StageId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeather_CropIrrigationWeatherId)
                .Index(t => t.CropId)
                .Index(t => t.StageId)
                .Index(t => t.PhenologicalStageId)
                .Index(t => t.CropIrrigationWeather_CropIrrigationWeatherId);

            CreateTable(
                "dbo.Location",
                c => new
                    {
                        LocationId = c.Long(nullable: false, identity: true),
                        PositionId = c.Long(nullable: false),
                        CountryId = c.Long(nullable: false),
                        RegionId = c.Long(nullable: false),
                        CityId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.LocationId)
                .ForeignKey("dbo.City", t => t.CityId)
                .ForeignKey("dbo.Country", t => t.CountryId)
                .ForeignKey("dbo.Position", t => t.PositionId)
                .ForeignKey("dbo.Region", t => t.RegionId)
                .Index(t => t.PositionId)
                .Index(t => t.CountryId)
                .Index(t => t.RegionId)
                .Index(t => t.CityId);

            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.MenuId);

            CreateTable(
                "dbo.Message",
                c => new
                    {
                        MessageId = c.Long(nullable: false, identity: true),
                        TitleId = c.Long(nullable: false),
                        LineId = c.Long(nullable: false),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                        Daily = c.Boolean(nullable: false),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .ForeignKey("dbo.Title", t => t.TitleId)
                .Index(t => t.TitleId)
                .Index(t => t.CropIrrigationWeatherId);

            CreateTable(
                "dbo.Title",
                c => new
                    {
                        TitleId = c.Long(nullable: false, identity: true),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                        Daily = c.Boolean(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Abbreviation = c.String(),
                    })
                .PrimaryKey(t => t.TitleId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .Index(t => t.CropIrrigationWeatherId);

            CreateTable(
                "dbo.MeteoblueWeatherData",
                c => new
                    {
                        MeteoblueWeatherDataId = c.Long(nullable: false, identity: true),
                        WeatherStationId = c.Long(nullable: false),
                        WeatherDate = c.DateTime(nullable: false),
                        UvIndex = c.Int(),
                        TemperatureMax = c.Decimal(precision: 9, scale: 2),
                        TemperatureMin = c.Decimal(precision: 9, scale: 2),
                        TemperatureMean = c.Decimal(precision: 9, scale: 2),
                        FeltTemperatureMax = c.Decimal(precision: 9, scale: 2),
                        FeltTemperatureMin = c.Decimal(precision: 9, scale: 2),
                        WindDirection = c.Int(),
                        PrecipitationProbability = c.Decimal(precision: 9, scale: 2),
                        Rainspot = c.String(maxLength: 50, unicode: false),
                        PredictabilityClass = c.Int(),
                        Predictability = c.Int(),
                        Precipitation = c.Decimal(precision: 9, scale: 2),
                        SnowFraction = c.Decimal(precision: 9, scale: 2),
                        SealevelPressureMax = c.Int(),
                        SealevelPressureMin = c.Int(),
                        SealevelPressureMean = c.Int(),
                        WindSpeedMax = c.Decimal(precision: 9, scale: 2),
                        WindSpeedMean = c.Decimal(precision: 9, scale: 2),
                        WindSpeedMin = c.Decimal(precision: 9, scale: 2),
                        RelativeHumidityMax = c.Int(),
                        RelativeHumidityMin = c.Int(),
                        RelativehumidityMean = c.Int(),
                        ConvectivePrecipitation = c.Decimal(precision: 9, scale: 2),
                        PrecipitationHours = c.Decimal(precision: 9, scale: 2),
                        HumidityGreater90Hours = c.Decimal(precision: 9, scale: 2),
                        SoilTemperatureMax = c.Decimal(precision: 9, scale: 2),
                        SoilTemperatureMin = c.Decimal(precision: 9, scale: 2),
                        SoilTemperatureMean = c.Decimal(precision: 9, scale: 2),
                        SoilMoistureMax = c.Int(),
                        SoilMoistureMin = c.Int(),
                        SoilMoistureMean = c.Int(),
                        SkinTemperatureMax = c.Decimal(precision: 9, scale: 2),
                        SkinTemperatureMin = c.Decimal(precision: 9, scale: 2),
                        SkinTemperatureMean = c.Decimal(precision: 9, scale: 2),
                        Evapotranspiration = c.Decimal(precision: 9, scale: 2),
                        LeafWetnessIndex = c.Decimal(precision: 9, scale: 2),
                        PotentialEvapotranspiration = c.Decimal(precision: 9, scale: 2),
                        DewPointTemperatureMax = c.Decimal(precision: 9, scale: 2),
                        DewPointTemperatureMin = c.Decimal(precision: 9, scale: 2),
                        DewPointTemperatureMean = c.Decimal(precision: 9, scale: 2),
                        ReferenceEvapotranspirationFao = c.Decimal(precision: 9, scale: 2),
                        SensibleHeatFlux = c.Decimal(precision: 9, scale: 2),
                        LastModificationDate = c.DateTime(nullable: false),
                        BasicJson = c.String(unicode: false),
                        BasicUrl = c.String(maxLength: 200, unicode: false),
                        AgroJson = c.String(unicode: false),
                        AgroUrl = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.MeteoblueWeatherDataId)
                .ForeignKey("dbo.WeatherStation", t => t.WeatherStationId)
                .Index(t => t.WeatherStationId);

            CreateTable(
                "dbo.Role",
                c => new
                    {
                        RoleId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        SiteId = c.Long(nullable: false),
                        MenuId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.RoleId);

            CreateTable(
                "dbo.SiteItem",
                c => new
                    {
                        SiteItemId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.SiteItemId);

            CreateTable(
                "dbo.SiteMap",
                c => new
                    {
                        SiteMapId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CameFrom_SiteItemId = c.Long(),
                    })
                .PrimaryKey(t => t.SiteMapId)
                .ForeignKey("dbo.SiteItem", t => t.CameFrom_SiteItemId)
                .Index(t => t.CameFrom_SiteItemId);

            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        DateOfReference = c.DateTime(nullable: false),
                        WebStatus = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);

            CreateTable(
                "dbo.WeatherInformation",
                c => new
                    {
                        WeatherInformationId = c.Long(nullable: false, identity: true),
                        WebAddress = c.String(),
                        WebData = c.String(),
                        RequestData = c.String(),
                        ResponseData = c.String(),
                        WeatherDataId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.WeatherInformationId)
                .ForeignKey("dbo.WeatherData", t => t.WeatherDataId)
                .Index(t => t.WeatherDataId);

            CreateTable(
                "dbo.Drip",
                c => new
                    {
                        IrrigationUnitId = c.Long(nullable: false),
                        Width = c.Double(nullable: false),
                        Length = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IrrigationUnitId)
                .ForeignKey("dbo.IrrigationUnit", t => t.IrrigationUnitId)
                .Index(t => t.IrrigationUnitId);

            CreateTable(
                "dbo.EvapotranspirationCrop",
                c => new
                    {
                        WaterOutputId = c.Long(nullable: false),
                        CropIrrigationWeather_CropIrrigationWeatherId = c.Long(),
                    })
                .PrimaryKey(t => t.WaterOutputId)
                .ForeignKey("dbo.WaterOutput", t => t.WaterOutputId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeather_CropIrrigationWeatherId)
                .Index(t => t.WaterOutputId)
                .Index(t => t.CropIrrigationWeather_CropIrrigationWeatherId);

            CreateTable(
                "dbo.Irrigation",
                c => new
                    {
                        WaterInputId = c.Long(nullable: false),
                        CropIrrigationWeather_CropIrrigationWeatherId = c.Long(),
                        Type = c.Int(nullable: false),
                        Observations = c.String(),
                        Reason = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.WaterInputId)
                .ForeignKey("dbo.WaterInput", t => t.WaterInputId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeather_CropIrrigationWeatherId)
                .Index(t => t.WaterInputId)
                .Index(t => t.CropIrrigationWeather_CropIrrigationWeatherId);

            CreateTable(
                "dbo.Pivot",
                c => new
                    {
                        IrrigationUnitId = c.Long(nullable: false),
                        Radius = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IrrigationUnitId)
                .ForeignKey("dbo.IrrigationUnit", t => t.IrrigationUnitId)
                .Index(t => t.IrrigationUnitId);

            CreateTable(
                "dbo.Rain",
                c => new
                    {
                        WaterInputId = c.Long(nullable: false),
                        CropIrrigationWeather_CropIrrigationWeatherId = c.Long(),
                    })
                .PrimaryKey(t => t.WaterInputId)
                .ForeignKey("dbo.WaterInput", t => t.WaterInputId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeather_CropIrrigationWeatherId)
                .Index(t => t.WaterInputId)
                .Index(t => t.CropIrrigationWeather_CropIrrigationWeatherId);

            CreateTable(
                "dbo.Sprinkler",
                c => new
                    {
                        IrrigationUnitId = c.Long(nullable: false),
                        Width = c.Double(nullable: false),
                        Length = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.IrrigationUnitId)
                .ForeignKey("dbo.IrrigationUnit", t => t.IrrigationUnitId)
                .Index(t => t.IrrigationUnitId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Sprinkler", "IrrigationUnitId", "dbo.IrrigationUnit");
            DropForeignKey("dbo.Rain", "CropIrrigationWeather_CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.Rain", "WaterInputId", "dbo.WaterInput");
            DropForeignKey("dbo.Pivot", "IrrigationUnitId", "dbo.IrrigationUnit");
            DropForeignKey("dbo.Irrigation", "CropIrrigationWeather_CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.Irrigation", "WaterInputId", "dbo.WaterInput");
            DropForeignKey("dbo.EvapotranspirationCrop", "CropIrrigationWeather_CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.EvapotranspirationCrop", "WaterOutputId", "dbo.WaterOutput");
            DropForeignKey("dbo.Drip", "IrrigationUnitId", "dbo.IrrigationUnit");
            DropForeignKey("dbo.WeatherInformation", "WeatherDataId", "dbo.WeatherData");
            DropForeignKey("dbo.WaterOutput", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.WaterInput", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.SiteMap", "CameFrom_SiteItemId", "dbo.SiteItem");
            DropForeignKey("dbo.User", "RoleId", "dbo.Role");
            DropForeignKey("dbo.MeteoblueWeatherData", "WeatherStationId", "dbo.WeatherStation");
            DropForeignKey("dbo.Message", "TitleId", "dbo.Title");
            DropForeignKey("dbo.Title", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.Message", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.Location", "RegionId", "dbo.Region");
            DropForeignKey("dbo.Location", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Location", "CountryId", "dbo.Country");
            DropForeignKey("dbo.Location", "CityId", "dbo.City");
            DropForeignKey("dbo.CropIrrigationWeather", "SoilId", "dbo.Soil");
            DropForeignKey("dbo.CropIrrigationWeather", "PositionId", "dbo.Position");
            DropForeignKey("dbo.PhenologicalStageAdjustment", "CropIrrigationWeather_CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.PhenologicalStageAdjustment", "StageId", "dbo.Stage");
            DropForeignKey("dbo.PhenologicalStageAdjustment", "PhenologicalStageId", "dbo.PhenologicalStage");
            DropForeignKey("dbo.PhenologicalStageAdjustment", "CropId", "dbo.Crop");
            DropForeignKey("dbo.CropIrrigationWeather", "PhenologicalStageId", "dbo.PhenologicalStage");
            DropForeignKey("dbo.CropIrrigationWeather", "MainWeatherStation_WeatherStationId", "dbo.WeatherStation");
            DropForeignKey("dbo.CropIrrigationWeather", "IrrigationUnitId", "dbo.IrrigationUnit");
            DropForeignKey("dbo.DailyRecord", "Rain_WaterInputId", "dbo.Rain");
            DropForeignKey("dbo.DailyRecord", "PhenologicalStageId", "dbo.PhenologicalStage");
            DropForeignKey("dbo.DailyRecord", "MainWeatherData_WeatherDataId", "dbo.WeatherData");
            DropForeignKey("dbo.DailyRecord", "Irrigation_WaterInputId", "dbo.Irrigation");
            DropForeignKey("dbo.DailyRecord", "EvapotranspirationCrop_WaterOutputId", "dbo.EvapotranspirationCrop");
            DropForeignKey("dbo.DailyRecord", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.DailyRecord", "AlternativeWeatherData_WeatherDataId", "dbo.WeatherData");
            DropForeignKey("dbo.CropIrrigationWeather", "CropInformationByDateId", "dbo.CropInformationByDate");
            DropForeignKey("dbo.CropIrrigationWeather", "CropId", "dbo.Crop");
            DropForeignKey("dbo.Crop", "StopIrrigationStage_StageId", "dbo.Stage");
            DropForeignKey("dbo.Stage", "Crop_CropId", "dbo.Crop");
            DropForeignKey("dbo.Crop", "SpecieId", "dbo.Specie");
            DropForeignKey("dbo.Crop", "RegionId", "dbo.Region");
            DropForeignKey("dbo.PhenologicalStage", "Crop_CropId", "dbo.Crop");
            DropForeignKey("dbo.Crop", "MinStageToConsiderETinHBCalculation_StageId", "dbo.Stage");
            DropForeignKey("dbo.Crop", "CropCoefficientId", "dbo.CropCoefficient");
            DropForeignKey("dbo.CropIrrigationWeather", "AlternativeWeatherStation_WeatherStationId", "dbo.WeatherStation");
            DropForeignKey("dbo.CropInformationByDate", "StageId", "dbo.Stage");
            DropForeignKey("dbo.CropInformationByDate", "SpecieId", "dbo.Specie");
            DropForeignKey("dbo.CropInformationByDate", "RegionId", "dbo.Region");
            DropForeignKey("dbo.PhenologicalStage", "CropInformationByDate_CropInformationByDateId", "dbo.CropInformationByDate");
            DropForeignKey("dbo.PhenologicalStage", "StageId", "dbo.Stage");
            DropForeignKey("dbo.PhenologicalStage", "SpecieId", "dbo.Specie");
            DropForeignKey("dbo.CropInformationByDate", "CropCoefficientId", "dbo.CropCoefficient");
            DropForeignKey("dbo.CropCoefficient", "SpecieId", "dbo.Specie");
            DropForeignKey("dbo.KC", "CropCoefficient_CropCoefficientId", "dbo.CropCoefficient");
            DropForeignKey("dbo.KC", "SpecieId", "dbo.Specie");
            DropForeignKey("dbo.Bomb", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Farm", "WeatherStationId", "dbo.WeatherStation");
            DropForeignKey("dbo.WeatherData", "WeatherStationId", "dbo.WeatherStation");
            DropForeignKey("dbo.UserFarm", "UserId", "dbo.User");
            DropForeignKey("dbo.UserAccess", "UserId", "dbo.User");
            DropForeignKey("dbo.UserFarm", "FarmId", "dbo.Farm");
            DropForeignKey("dbo.Soil", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Horizon", "Soil_SoilId", "dbo.Soil");
            DropForeignKey("dbo.Soil", "FarmId", "dbo.Farm");
            DropForeignKey("dbo.Farm", "PositionId", "dbo.Position");
            DropForeignKey("dbo.IrrigationUnit", "FarmId", "dbo.Farm");
            DropForeignKey("dbo.IrrigationUnit", "BombId", "dbo.Bomb");
            DropForeignKey("dbo.Farm", "CityId", "dbo.City");
            DropForeignKey("dbo.City", "PositionId", "dbo.Position");
            DropForeignKey("dbo.City", "Country_CountryId1", "dbo.Country");
            DropForeignKey("dbo.Region", "Country_CountryId", "dbo.Country");
            DropForeignKey("dbo.TemperatureData", "RegionId", "dbo.Region");
            DropForeignKey("dbo.Specie", "Region_RegionId", "dbo.Region");
            DropForeignKey("dbo.Specie", "SpecieCycleId", "dbo.SpecieCycle");
            DropForeignKey("dbo.SpecieCycle", "Region_RegionId", "dbo.Region");
            DropForeignKey("dbo.Region", "PositionId", "dbo.Position");
            DropForeignKey("dbo.EffectiveRain", "Region_RegionId", "dbo.Region");
            DropForeignKey("dbo.Country", "LanguageId", "dbo.Language");
            DropForeignKey("dbo.City", "Country_CountryId", "dbo.Country");
            DropForeignKey("dbo.Country", "Capital_CityId", "dbo.City");
            DropForeignKey("dbo.Bomb", "FarmId", "dbo.Farm");
            DropIndex("dbo.Sprinkler", new[] { "IrrigationUnitId" });
            DropIndex("dbo.Rain", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            DropIndex("dbo.Rain", new[] { "WaterInputId" });
            DropIndex("dbo.Pivot", new[] { "IrrigationUnitId" });
            DropIndex("dbo.Irrigation", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            DropIndex("dbo.Irrigation", new[] { "WaterInputId" });
            DropIndex("dbo.EvapotranspirationCrop", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            DropIndex("dbo.EvapotranspirationCrop", new[] { "WaterOutputId" });
            DropIndex("dbo.Drip", new[] { "IrrigationUnitId" });
            DropIndex("dbo.WeatherInformation", new[] { "WeatherDataId" });
            DropIndex("dbo.SiteMap", new[] { "CameFrom_SiteItemId" });
            DropIndex("dbo.MeteoblueWeatherData", new[] { "WeatherStationId" });
            DropIndex("dbo.Title", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.Message", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.Message", new[] { "TitleId" });
            DropIndex("dbo.Location", new[] { "CityId" });
            DropIndex("dbo.Location", new[] { "RegionId" });
            DropIndex("dbo.Location", new[] { "CountryId" });
            DropIndex("dbo.Location", new[] { "PositionId" });
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "PhenologicalStageId" });
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "StageId" });
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "CropId" });
            DropIndex("dbo.WaterInput", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.WaterOutput", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.DailyRecord", new[] { "Rain_WaterInputId" });
            DropIndex("dbo.DailyRecord", new[] { "MainWeatherData_WeatherDataId" });
            DropIndex("dbo.DailyRecord", new[] { "Irrigation_WaterInputId" });
            DropIndex("dbo.DailyRecord", new[] { "EvapotranspirationCrop_WaterOutputId" });
            DropIndex("dbo.DailyRecord", new[] { "AlternativeWeatherData_WeatherDataId" });
            DropIndex("dbo.DailyRecord", new[] { "PhenologicalStageId" });
            DropIndex("dbo.DailyRecord", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.Crop", new[] { "StopIrrigationStage_StageId" });
            DropIndex("dbo.Crop", new[] { "MinStageToConsiderETinHBCalculation_StageId" });
            DropIndex("dbo.Crop", new[] { "CropCoefficientId" });
            DropIndex("dbo.Crop", new[] { "SpecieId" });
            DropIndex("dbo.Crop", new[] { "RegionId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "MainWeatherStation_WeatherStationId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "AlternativeWeatherStation_WeatherStationId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "PositionId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "IrrigationUnitId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "CropInformationByDateId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "PhenologicalStageId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "SoilId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "CropId" });
            DropIndex("dbo.Stage", new[] { "Crop_CropId" });
            DropIndex("dbo.PhenologicalStage", new[] { "Crop_CropId" });
            DropIndex("dbo.PhenologicalStage", new[] { "CropInformationByDate_CropInformationByDateId" });
            DropIndex("dbo.PhenologicalStage", new[] { "StageId" });
            DropIndex("dbo.PhenologicalStage", new[] { "SpecieId" });
            DropIndex("dbo.CropInformationByDate", new[] { "StageId" });
            DropIndex("dbo.CropInformationByDate", new[] { "RegionId" });
            DropIndex("dbo.CropInformationByDate", new[] { "CropCoefficientId" });
            DropIndex("dbo.CropInformationByDate", new[] { "SpecieId" });
            DropIndex("dbo.KC", new[] { "CropCoefficient_CropCoefficientId" });
            DropIndex("dbo.KC", new[] { "SpecieId" });
            DropIndex("dbo.CropCoefficient", new[] { "SpecieId" });
            DropIndex("dbo.WeatherData", new[] { "WeatherStationId" });
            DropIndex("dbo.UserAccess", new[] { "UserId" });
            DropIndex("dbo.User", new[] { "RoleId" });
            DropIndex("dbo.UserFarm", new[] { "FarmId" });
            DropIndex("dbo.UserFarm", new[] { "UserId" });
            DropIndex("dbo.Horizon", new[] { "Soil_SoilId" });
            DropIndex("dbo.Soil", new[] { "FarmId" });
            DropIndex("dbo.Soil", new[] { "PositionId" });
            DropIndex("dbo.IrrigationUnit", new[] { "FarmId" });
            DropIndex("dbo.IrrigationUnit", new[] { "BombId" });
            DropIndex("dbo.TemperatureData", new[] { "RegionId" });
            DropIndex("dbo.Specie", new[] { "Region_RegionId" });
            DropIndex("dbo.Specie", new[] { "SpecieCycleId" });
            DropIndex("dbo.SpecieCycle", new[] { "Region_RegionId" });
            DropIndex("dbo.EffectiveRain", new[] { "Region_RegionId" });
            DropIndex("dbo.Region", new[] { "Country_CountryId" });
            DropIndex("dbo.Region", new[] { "PositionId" });
            DropIndex("dbo.Country", new[] { "Capital_CityId" });
            DropIndex("dbo.Country", new[] { "LanguageId" });
            DropIndex("dbo.City", new[] { "Country_CountryId1" });
            DropIndex("dbo.City", new[] { "Country_CountryId" });
            DropIndex("dbo.City", new[] { "PositionId" });
            DropIndex("dbo.Farm", new[] { "CityId" });
            DropIndex("dbo.Farm", new[] { "WeatherStationId" });
            DropIndex("dbo.Farm", new[] { "PositionId" });
            DropIndex("dbo.Bomb", new[] { "FarmId" });
            DropIndex("dbo.Bomb", new[] { "PositionId" });
            DropTable("dbo.Sprinkler");
            DropTable("dbo.Rain");
            DropTable("dbo.Pivot");
            DropTable("dbo.Irrigation");
            DropTable("dbo.EvapotranspirationCrop");
            DropTable("dbo.Drip");
            DropTable("dbo.WeatherInformation");
            DropTable("dbo.Status");
            DropTable("dbo.SiteMap");
            DropTable("dbo.SiteItem");
            DropTable("dbo.Role");
            DropTable("dbo.MeteoblueWeatherData");
            DropTable("dbo.Title");
            DropTable("dbo.Message");
            DropTable("dbo.Menu");
            DropTable("dbo.Location");
            DropTable("dbo.PhenologicalStageAdjustment");
            DropTable("dbo.WaterInput");
            DropTable("dbo.WaterOutput");
            DropTable("dbo.DailyRecord");
            DropTable("dbo.Crop");
            DropTable("dbo.CropIrrigationWeather");
            DropTable("dbo.Stage");
            DropTable("dbo.PhenologicalStage");
            DropTable("dbo.CropInformationByDate");
            DropTable("dbo.KC");
            DropTable("dbo.CropCoefficient");
            DropTable("dbo.WeatherData");
            DropTable("dbo.WeatherStation");
            DropTable("dbo.UserAccess");
            DropTable("dbo.User");
            DropTable("dbo.UserFarm");
            DropTable("dbo.Horizon");
            DropTable("dbo.Soil");
            DropTable("dbo.IrrigationUnit");
            DropTable("dbo.TemperatureData");
            DropTable("dbo.Specie");
            DropTable("dbo.SpecieCycle");
            DropTable("dbo.Position");
            DropTable("dbo.EffectiveRain");
            DropTable("dbo.Region");
            DropTable("dbo.Language");
            DropTable("dbo.Country");
            DropTable("dbo.City");
            DropTable("dbo.Farm");
            DropTable("dbo.Bomb");
            DropTable("dbo.Access");
        }

    }
}
