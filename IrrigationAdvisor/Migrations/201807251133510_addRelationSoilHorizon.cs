namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationSoilHorizon : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Horizon", new[] { "Soil_SoilId" });
            RenameColumn(table: "dbo.Horizon", name: "Soil_SoilId", newName: "SoilId");
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long(nullable: false));
            CreateIndex("dbo.Horizon", "SoilId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Horizon", new[] { "SoilId" });
            AlterColumn("dbo.Horizon", "SoilId", c => c.Long());
            RenameColumn(table: "dbo.Horizon", name: "SoilId", newName: "Soil_SoilId");
            CreateIndex("dbo.Horizon", "Soil_SoilId");
        }
    }
}
