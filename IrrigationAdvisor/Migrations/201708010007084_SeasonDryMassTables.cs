namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeasonDryMassTables : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.EffectiveRain", new[] { "Region_RegionId" });
            DropIndex("dbo.Specie", new[] { "Region_RegionId" });
            RenameColumn(table: "dbo.EffectiveRain", name: "Region_RegionId", newName: "RegionId");
            RenameColumn(table: "dbo.Specie", name: "Region_RegionId", newName: "RegionId");
            CreateTable(
                "dbo.DryMass",
                c => new
                    {
                        DryMassId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        SpecieId = c.Long(nullable: false),
                        AgeOfCrop = c.Int(nullable: false),
                        SeasonId = c.Long(nullable: false),
                        Day = c.Int(nullable: false),
                        RatePerHectareByDay = c.Double(nullable: false),
                        InitialWeightPerHectareInKG = c.Double(nullable: false),
                        WeightPerHectareInKG = c.Double(nullable: false),
                        Exponent = c.Double(nullable: false),
                        Multiplier = c.Double(nullable: false),
                        MaxCoefficient = c.Double(nullable: false),
                        Coefficient = c.Double(nullable: false),
                        RootDepth = c.Double(nullable: false),
                        Crop_CropId = c.Long(),
                    })
                .PrimaryKey(t => t.DryMassId)
                .ForeignKey("dbo.Season", t => t.SeasonId)
                .ForeignKey("dbo.Specie", t => t.SpecieId)
                .ForeignKey("dbo.Crop", t => t.Crop_CropId)
                .Index(t => t.SpecieId)
                .Index(t => t.SeasonId)
                .Index(t => t.Crop_CropId);
            
            CreateTable(
                "dbo.Season",
                c => new
                    {
                        SeasonId = c.Long(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Year = c.Int(nullable: false),
                        WeatherSeason = c.Int(nullable: false),
                        RegionId = c.Long(nullable: false),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SeasonId)
                .ForeignKey("dbo.Region", t => t.RegionId)
                .Index(t => t.RegionId);
            
            AddColumn("dbo.CropIrrigationWeather", "CropStatus", c => c.Int(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "AgeOfCrop", c => c.Int(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "SeasonId", c => c.Long(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "DayAfterSeasonStart", c => c.Int(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "DryMassRatePerHectareByDay", c => c.Double(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "DryMassWeightPerHectare", c => c.Double(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "DryMassWeightPerHectareModified", c => c.Double(nullable: false));
            AlterColumn("dbo.EffectiveRain", "RegionId", c => c.Long(nullable: false));
            AlterColumn("dbo.Specie", "RegionId", c => c.Long(nullable: false));
            CreateIndex("dbo.EffectiveRain", "RegionId");
            CreateIndex("dbo.Specie", "RegionId");
            CreateIndex("dbo.CropIrrigationWeather", "SeasonId");
            AddForeignKey("dbo.CropIrrigationWeather", "SeasonId", "dbo.Season", "SeasonId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CropIrrigationWeather", "SeasonId", "dbo.Season");
            DropForeignKey("dbo.DryMass", "Crop_CropId", "dbo.Crop");
            DropForeignKey("dbo.DryMass", "SpecieId", "dbo.Specie");
            DropForeignKey("dbo.DryMass", "SeasonId", "dbo.Season");
            DropForeignKey("dbo.Season", "RegionId", "dbo.Region");
            DropIndex("dbo.Season", new[] { "RegionId" });
            DropIndex("dbo.DryMass", new[] { "Crop_CropId" });
            DropIndex("dbo.DryMass", new[] { "SeasonId" });
            DropIndex("dbo.DryMass", new[] { "SpecieId" });
            DropIndex("dbo.CropIrrigationWeather", new[] { "SeasonId" });
            DropIndex("dbo.Specie", new[] { "RegionId" });
            DropIndex("dbo.EffectiveRain", new[] { "RegionId" });
            AlterColumn("dbo.Specie", "RegionId", c => c.Long());
            AlterColumn("dbo.EffectiveRain", "RegionId", c => c.Long());
            DropColumn("dbo.CropIrrigationWeather", "DryMassWeightPerHectareModified");
            DropColumn("dbo.CropIrrigationWeather", "DryMassWeightPerHectare");
            DropColumn("dbo.CropIrrigationWeather", "DryMassRatePerHectareByDay");
            DropColumn("dbo.CropIrrigationWeather", "DayAfterSeasonStart");
            DropColumn("dbo.CropIrrigationWeather", "SeasonId");
            DropColumn("dbo.CropIrrigationWeather", "AgeOfCrop");
            DropColumn("dbo.CropIrrigationWeather", "CropStatus");
            DropTable("dbo.Season");
            DropTable("dbo.DryMass");
            RenameColumn(table: "dbo.Specie", name: "RegionId", newName: "Region_RegionId");
            RenameColumn(table: "dbo.EffectiveRain", name: "RegionId", newName: "Region_RegionId");
            CreateIndex("dbo.Specie", "Region_RegionId");
            CreateIndex("dbo.EffectiveRain", "Region_RegionId");
        }
    }
}
