namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addFieldEnabledToWeatherStation : DbMigration
    {
        public override void Up()
        {
           // AddColumn("dbo.WeatherStation", "Enabled", c => c.Boolean(nullable: false, defaultValue: true));
        }

        public override void Down()
        {
           // DropColumn("dbo.WeatherStation", "Enabled");
        }
    }
}

