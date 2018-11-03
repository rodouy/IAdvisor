namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CalculationByCropIrrigationWeather : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CalculationByCropIrrigationWeather",
                c => new
                    {
                        CalculationByCropIrrigationWeatherId = c.Int(nullable: false, identity: true),
                        CropIrrigationWeatherId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        Application = c.String(),
                        Details = c.String(),
                        CropIrrigationWeather_CropIrrigationWeatherId = c.Long(),
                    })
                .PrimaryKey(t => t.CalculationByCropIrrigationWeatherId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeather_CropIrrigationWeatherId)
                .Index(t => t.CropIrrigationWeather_CropIrrigationWeatherId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeather_CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropIndex("dbo.CalculationByCropIrrigationWeather", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            DropTable("dbo.CalculationByCropIrrigationWeather");
        }
    }
}
