namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeatherEventType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CropIrrigationWeather", "WeatherEventType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CropIrrigationWeather", "WeatherEventType");
        }
    }
}
