namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PredeterminatedIrrigationQuantityAdjustableIrrigationQuantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CropIrrigationWeather", "MaxIrrigationQuantity", c => c.Double(nullable: false));
            AddColumn("dbo.CropIrrigationWeather", "AdjustableIrrigationQuantity", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CropIrrigationWeather", "AdjustableIrrigationQuantity");
            DropColumn("dbo.CropIrrigationWeather", "MaxIrrigationQuantity");
        }
    }
}
