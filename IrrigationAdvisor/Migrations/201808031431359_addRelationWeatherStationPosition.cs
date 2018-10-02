namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationWeatherStationPosition : DbMigration
    {
        public override void Up()
        {
        //    CreateIndex("dbo.WeatherStation", "PositionId");
        //    AddForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
        //    DropForeignKey("dbo.WeatherStation", "PositionId", "dbo.Position");
        //    DropIndex("dbo.WeatherStation", new[] { "PositionId" });
        }
    }
}
