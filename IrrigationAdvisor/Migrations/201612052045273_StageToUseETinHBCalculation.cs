namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StageToUseETinHBCalculation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CropIrrigationWeather", "Density", c => c.Double(nullable: false));
            AddColumn("dbo.Crop", "MinStageToConsiderETinHBCalculationId", c => c.Long(nullable: false));
            AddColumn("dbo.Crop", "MinStageToConsiderETinHBCalculation_StageId", c => c.Long());
            CreateIndex("dbo.Crop", "MinStageToConsiderETinHBCalculation_StageId");
            AddForeignKey("dbo.Crop", "MinStageToConsiderETinHBCalculation_StageId", "dbo.Stage", "StageId");
            DropColumn("dbo.Crop", "Density");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Crop", "Density", c => c.Double(nullable: false));
            DropForeignKey("dbo.Crop", "MinStageToConsiderETinHBCalculation_StageId", "dbo.Stage");
            DropIndex("dbo.Crop", new[] { "MinStageToConsiderETinHBCalculation_StageId" });
            DropColumn("dbo.Crop", "MinStageToConsiderETinHBCalculation_StageId");
            DropColumn("dbo.Crop", "MinStageToConsiderETinHBCalculationId");
            DropColumn("dbo.CropIrrigationWeather", "Density");
        }
    }
}
