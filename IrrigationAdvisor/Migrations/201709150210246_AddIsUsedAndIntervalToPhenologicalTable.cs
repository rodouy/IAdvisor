namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsUsedAndIntervalToPhenologicalTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhenologicalStage", "PhenologicalStageIsUsed", c => c.Boolean(nullable: false));
            AddColumn("dbo.PhenologicalStage", "DegreesDaysInterval", c => c.Double(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "GrowingDegreeDaysExtraGap", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CropIrrigationWeather", "GrowingDegreeDaysExtraGap");
            DropColumn("dbo.PhenologicalStage", "DegreesDaysInterval");
            DropColumn("dbo.PhenologicalStage", "PhenologicalStageIsUsed");
        }
    }
}
