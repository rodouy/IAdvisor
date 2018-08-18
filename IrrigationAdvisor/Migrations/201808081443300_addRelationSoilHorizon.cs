namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationSoilHorizon : DbMigration
    {
        public override void Up()
        {
     //       DropForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position");
            DropIndex("dbo.Horizon", new[] { "Soil_SoilId" });
    //        DropIndex("dbo.WeatherStation", new[] { "PositionId" });
            RenameColumn(table: "dbo.Horizon", name: "Soil_SoilId", newName: "SoilId");
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long(nullable: false));
            CreateIndex("dbo.Horizon", "SoilId");
   //         DropColumn("dbo.Farm", "IsActive");
   //         DropColumn("dbo.WeatherStation", "Enabled");
        }
        
        public override void Down()
        {
    //        AddColumn("dbo.WeatherStation", "Enabled", c => c.Boolean(nullable: false));
    //        AddColumn("dbo.Farm", "IsActive", c => c.Boolean(nullable: false));
            DropIndex("dbo.Horizon", new[] { "SoilId" });
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long());
            RenameColumn(table: "dbo.Horizon", name: "SoilId", newName: "Soil_SoilId");
   //         CreateIndex("dbo.WeatherStation", "PositionId");
            CreateIndex("dbo.Horizon", "Soil_SoilId");
   //         AddForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position", "PositionId");
        }
    }
}
