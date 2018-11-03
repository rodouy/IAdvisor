namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Merge20181103 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Horizon", new[] { "Soil_SoilId" });
            RenameColumn(table: "dbo.Horizon", name: "Soil_SoilId", newName: "SoilId");
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
            DropForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position");
            DropForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position");
            DropIndex("dbo.WeatherStation", new[] { "PositionId" });
            DropIndex("dbo.Horizon", new[] { "SoilId" });
            DropIndex("dbo.IrrigationUnit", new[] { "PositionId" });
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long());
            AlterColumn("dbo.Country", "CapitalId", c => c.Long(nullable: false));
            DropColumn("dbo.WeatherStation", "Enabled");
            DropColumn("dbo.Farm", "IsActive");
            RenameColumn(table: "dbo.Horizon", name: "SoilId", newName: "Soil_SoilId");
            CreateIndex("dbo.Horizon", "Soil_SoilId");
        }
    }
}
