namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _20171222_AddFieldToFarmForShowInReportIrrigationUnit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Farm", "IrrigationUnitReportShowTemperature", c => c.Boolean(nullable: false));
            AddColumn("dbo.Farm", "IrrigationUnitReportShowEvapotranspiration", c => c.Boolean(nullable: false));
            AddColumn("dbo.Farm", "IrrigationUnitReportShowAvailableWater", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Farm", "IrrigationUnitReportShowAvailableWater");
            DropColumn("dbo.Farm", "IrrigationUnitReportShowEvapotranspiration");
            DropColumn("dbo.Farm", "IrrigationUnitReportShowTemperature");
        }
    }
}
