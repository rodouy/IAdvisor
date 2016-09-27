namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddObservations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WeatherData", "Observations", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.WeatherData", "Observations");
        }
    }
}
