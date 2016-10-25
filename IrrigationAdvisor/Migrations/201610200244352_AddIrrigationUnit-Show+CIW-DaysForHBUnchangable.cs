namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIrrigationUnitShowCIWDaysForHBUnchangable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CropIrrigationWeather", "DaysForHydricBalanceUnchangableAfterSowing", c => c.Int(nullable: false));
            AddColumn("dbo.IrrigationUnit", "Show", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IrrigationUnit", "Show");
            DropColumn("dbo.CropIrrigationWeather", "DaysForHydricBalanceUnchangableAfterSowing");
        }
    }
}
