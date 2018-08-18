namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class meteoblue : DbMigration
    {
        public override void Up()
        {
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
                .PrimaryKey(t => t.MeteoblueWeatherDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MeteoblueWeatherData");
        }
    }
}
