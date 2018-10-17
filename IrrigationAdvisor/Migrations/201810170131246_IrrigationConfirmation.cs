namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IrrigationConfirmation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IrrigationConfirmation",
                c => new
                    {
                        IrrigationConfirmationId = c.Long(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        IrrigationId = c.Long(nullable: false),
                        Irrigation_WaterInputId = c.Long(),
                    })
                .PrimaryKey(t => t.IrrigationConfirmationId)
                .ForeignKey("dbo.Irrigation", t => t.Irrigation_WaterInputId)
                .Index(t => t.Irrigation_WaterInputId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IrrigationConfirmation", "Irrigation_WaterInputId", "dbo.Irrigation");
            DropIndex("dbo.IrrigationConfirmation", new[] { "Irrigation_WaterInputId" });
            DropTable("dbo.IrrigationConfirmation");
        }
    }
}
