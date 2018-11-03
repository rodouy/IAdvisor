namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addExecutingColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CalculationByCropIrrigationWeather", "IsExecuting", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CalculationByCropIrrigationWeather", "IsExecuting");
        }
    }
}
