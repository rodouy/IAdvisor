namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnWeatherData : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherData", "WindSpeed", c => c.Double(nullable: false));
            AddColumn("dbo.WeatherData", "WeatherDataInputType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeatherData", "WeatherDataInputType");
            DropColumn("dbo.WeatherData", "WindSpeed");
        }
    }
}
