namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKInIrrigationUnitToPosition : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Horizon", new[] { "SoilId" });
            RenameColumn(table: "dbo.Horizon", name: "SoilId", newName: "Soil_SoilId");
            AlterColumn("dbo.Horizon", "Soil_SoilId", c => c.Long());
            CreateIndex("dbo.IrrigationUnit", "PositionId");
            CreateIndex("dbo.Horizon", "Soil_SoilId");
            AddForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position");
            DropIndex("dbo.Horizon", new[] { "Soil_SoilId" });
            DropIndex("dbo.IrrigationUnit", new[] { "PositionId" });
            AlterColumn("dbo.Horizon", "Soil_SoilId", c => c.Long(nullable: false));
            RenameColumn(table: "dbo.Horizon", name: "Soil_SoilId", newName: "SoilId");
            CreateIndex("dbo.Horizon", "SoilId");
        }
    }
}
