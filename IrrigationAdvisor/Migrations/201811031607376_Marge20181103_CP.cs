namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Marge20181103_CP : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "CropIrrigationWeather_CropIrrigationWeatherId" });
            RenameColumn(table: "dbo.PhenologicalStageAdjustment", name: "CropIrrigationWeather_CropIrrigationWeatherId", newName: "CropIrrigationWeatherId");
            CreateTable(
                "dbo.CalculationByCropIrrigationWeather",
                c => new
                    {
                        CalculationByCropIrrigationWeatherId = c.Long(nullable: false, identity: true),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        IsCompleted = c.Boolean(nullable: false),
                        IsExecuting = c.Boolean(nullable: false),
                        Application = c.String(),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.CalculationByCropIrrigationWeatherId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .Index(t => t.CropIrrigationWeatherId);
            
            CreateTable(
                "dbo.FarmContact",
                c => new
                    {
                        FarmContactId = c.Long(nullable: false, identity: true),
                        FarmId = c.Long(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(nullable: false),
                        SendEmail = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FarmContactId)
                .ForeignKey("dbo.Farm", t => t.FarmId)
                .Index(t => t.FarmId);
            
            CreateTable(
                "dbo.HydricBalanceAdjustment",
                c => new
                    {
                        HydricBalanceAdjustmentId = c.Long(nullable: false, identity: true),
                        Percentage = c.Double(nullable: false),
                        HydricBalance = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        CropIrrigationWeatherId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.HydricBalanceAdjustmentId)
                .ForeignKey("dbo.CropIrrigationWeather", t => t.CropIrrigationWeatherId)
                .Index(t => t.CropIrrigationWeatherId);
            
            AddColumn("dbo.IrrigationUnit", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Soil", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Horizon", "Enabled", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PhenologicalStageAdjustment", "CropIrrigationWeatherId", c => c.Long(nullable: false));
            CreateIndex("dbo.PhenologicalStageAdjustment", "CropIrrigationWeatherId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HydricBalanceAdjustment", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropForeignKey("dbo.FarmContact", "FarmId", "dbo.Farm");
            DropForeignKey("dbo.CalculationByCropIrrigationWeather", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropIndex("dbo.HydricBalanceAdjustment", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.FarmContact", new[] { "FarmId" });
            DropIndex("dbo.PhenologicalStageAdjustment", new[] { "CropIrrigationWeatherId" });
            DropIndex("dbo.CalculationByCropIrrigationWeather", new[] { "CropIrrigationWeatherId" });
            AlterColumn("dbo.PhenologicalStageAdjustment", "CropIrrigationWeatherId", c => c.Long());
            DropColumn("dbo.Horizon", "Enabled");
            DropColumn("dbo.Soil", "Enabled");
            DropColumn("dbo.IrrigationUnit", "Enabled");
            DropTable("dbo.HydricBalanceAdjustment");
            DropTable("dbo.FarmContact");
            DropTable("dbo.CalculationByCropIrrigationWeather");
            RenameColumn(table: "dbo.PhenologicalStageAdjustment", name: "CropIrrigationWeatherId", newName: "CropIrrigationWeather_CropIrrigationWeatherId");
            CreateIndex("dbo.PhenologicalStageAdjustment", "CropIrrigationWeather_CropIrrigationWeatherId");
        }
    }
}
