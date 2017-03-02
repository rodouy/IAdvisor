namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnLastDayOfGrowingDegreeDays : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CropIrrigationWeather", "LastDayOfGrowingDegreeDays", c => c.DateTime(nullable: false));
            AddColumn("dbo.DailyRecord", "LastDayOfGrowingDegreeDays", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DailyRecord", "LastDayOfGrowingDegreeDays");
            DropColumn("dbo.CropIrrigationWeather", "LastDayOfGrowingDegreeDays");
        }
    }
}
