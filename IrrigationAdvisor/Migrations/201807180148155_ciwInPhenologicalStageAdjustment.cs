namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ciwInPhenologicalStageAdjustment : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            RenameColumn(table: "dbo.PhenologicalStageAdjustment", name: "CropIrrigationWeather_CropIrrigationWeatherId", newName: "CropIrrigationWeatherId");
            AlterColumn("dbo.PhenologicalStageAdjustment", "CropIrrigationWeatherId", c => c.Long(nullable: false));
            CreateIndex("dbo.PhenologicalStageAdjustment", "CropIrrigationWeatherId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "CropIrrigationWeatherId" });
            AlterColumn("dbo.PhenologicalStageAdjustment", "CropIrrigationWeatherId", c => c.Long());
            RenameColumn(table: "dbo.PhenologicalStageAdjustment", name: "CropIrrigationWeatherId", newName: "CropIrrigationWeather_CropIrrigationWeatherId");
            CreateIndex("dbo.PhenologicalStageAdjustment", "CropIrrigationWeather_CropIrrigationWeatherId");
        }
    }
}
