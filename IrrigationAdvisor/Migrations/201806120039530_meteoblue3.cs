namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class meteoblue3 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.MeteoblueWeatherData", "WeatherStationId");
            AddForeignKey("dbo.MeteoblueWeatherData", "WeatherStationId", "dbo.WeatherStation", "WeatherStationId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MeteoblueWeatherData", "WeatherStationId", "dbo.WeatherStation");
            DropIndex("dbo.MeteoblueWeatherData", new[] { "WeatherStationId" });
        }
    }
}
