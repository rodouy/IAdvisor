namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba88 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Horizon", new[] { "Soil_SoilId" });
            RenameColumn(table: "dbo.Horizon", name: "Soil_SoilId", newName: "SoilId");
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
            
            AddColumn("dbo.Farm", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.WeatherStation", "Enabled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Country", "CapitalId", c => c.Long());
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long(nullable: false));
            CreateIndex("dbo.IrrigationUnit", "PositionId");
            CreateIndex("dbo.Horizon", "SoilId");
            CreateIndex("dbo.WeatherStation", "PositionId");
            AddForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position", "PositionId");
            AddForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeteoblueWeatherData", "WeatherStationId", "dbo.WeatherStation");
            DropForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position");
            DropForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position");
            DropIndex("dbo.MeteoblueWeatherData", new[] { "WeatherStationId" });
            DropIndex("dbo.WeatherStation", new[] { "PositionId" });
            DropIndex("dbo.Horizon", new[] { "SoilId" });
            DropIndex("dbo.IrrigationUnit", new[] { "PositionId" });
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long());
            AlterColumn("dbo.Country", "CapitalId", c => c.Long(nullable: false));
            DropColumn("dbo.WeatherStation", "Enabled");
            DropColumn("dbo.Farm", "IsActive");
            DropTable("dbo.MeteoblueWeatherData");
            RenameColumn(table: "dbo.Horizon", name: "SoilId", newName: "Soil_SoilId");
            CreateIndex("dbo.Horizon", "Soil_SoilId");
        }
    }
}
