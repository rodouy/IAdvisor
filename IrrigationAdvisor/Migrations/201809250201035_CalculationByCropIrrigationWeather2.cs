namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalculationByCropIrrigationWeather2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CalculationByCropIrrigationWeather", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            DropColumn("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId");
            RenameColumn(table: "dbo.CalculationByCropIrrigationWeather", name: "CropIrrigationWeather_CropIrrigationWeatherId", newName: "CropIrrigationWeatherId");
            DropPrimaryKey("dbo.CalculationByCropIrrigationWeather");
            AlterColumn("dbo.CalculationByCropIrrigationWeather", "CalculationByCropIrrigationWeatherId", c => c.Long(nullable: false, identity: true));
            AlterColumn("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId", c => c.Long(nullable: false));
            AlterColumn("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId", c => c.Long(nullable: false));
            AddPrimaryKey("dbo.CalculationByCropIrrigationWeather", "CalculationByCropIrrigationWeatherId");
            CreateIndex("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CalculationByCropIrrigationWeather", new[] { "CropIrrigationWeatherId" });
            DropPrimaryKey("dbo.CalculationByCropIrrigationWeather");
            AlterColumn("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId", c => c.Long());
            AlterColumn("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId", c => c.Int(nullable: false));
            AlterColumn("dbo.CalculationByCropIrrigationWeather", "CalculationByCropIrrigationWeatherId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.CalculationByCropIrrigationWeather", "CalculationByCropIrrigationWeatherId");
            RenameColumn(table: "dbo.CalculationByCropIrrigationWeather", name: "CropIrrigationWeatherId", newName: "CropIrrigationWeather_CropIrrigationWeatherId");
            AddColumn("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId", c => c.Int(nullable: false));
            CreateIndex("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeather_CropIrrigationWeatherId");
        }
    }
}
