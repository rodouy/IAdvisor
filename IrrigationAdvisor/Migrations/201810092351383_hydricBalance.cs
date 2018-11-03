namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hydricBalance : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HydricBalanceAdjustment", "CropIrrigationWeatherId", "dbo.CropIrrigationWeather");
            DropIndex("dbo.HydricBalanceAdjustment", new[] { "CropIrrigationWeatherId" });
            DropTable("dbo.HydricBalanceAdjustment");
        }
    }
}
