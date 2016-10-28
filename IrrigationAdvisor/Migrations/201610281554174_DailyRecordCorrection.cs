namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DailyRecordCorrection : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.DailyRecord", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            RenameColumn(table: "dbo.DailyRecord", name: "CropIrrigationWeather_CropIrrigationWeatherId", newName: "CropIrrigationWeatherId");
            AlterColumn("dbo.DailyRecord", "CropIrrigationWeatherId", c => c.Long(nullable: false));
            CreateIndex("dbo.DailyRecord", "CropIrrigationWeatherId");
            DropColumn("dbo.DailyRecord", "CropIrrgationWeatherId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DailyRecord", "CropIrrgationWeatherId", c => c.Long(nullable: false));
            DropIndex("dbo.DailyRecord", new[] { "CropIrrigationWeatherId" });
            AlterColumn("dbo.DailyRecord", "CropIrrigationWeatherId", c => c.Long());
            RenameColumn(table: "dbo.DailyRecord", name: "CropIrrigationWeatherId", newName: "CropIrrigationWeather_CropIrrigationWeatherId");
            CreateIndex("dbo.DailyRecord", "CropIrrigationWeather_CropIrrigationWeatherId");
        }
    }
}
