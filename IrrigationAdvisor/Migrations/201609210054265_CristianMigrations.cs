namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CristianMigrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherData", "Observations", c => c.String(nullable: false, defaultValue: string.Empty));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeatherData", "Observations");
        }
    }
}
