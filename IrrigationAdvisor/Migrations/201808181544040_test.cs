namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farm", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.WeatherStation", "Enabled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Country", "CapitalId", c => c.Long());
            CreateIndex("dbo.IrrigationUnit", "PositionId");
            CreateIndex("dbo.WeatherStation", "PositionId");
            AddForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position", "PositionId");
            AddForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position");
            DropForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position");
            DropIndex("dbo.WeatherStation", new[] { "PositionId" });
            DropIndex("dbo.IrrigationUnit", new[] { "PositionId" });
            AlterColumn("dbo.Country", "CapitalId", c => c.Long(nullable: false));
            DropColumn("dbo.WeatherStation", "Enabled");
            DropColumn("dbo.Farm", "IsActive");
        }
    }
}
