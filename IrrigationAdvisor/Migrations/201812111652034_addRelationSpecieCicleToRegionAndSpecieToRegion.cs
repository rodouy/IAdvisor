namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationSpecieCicleToRegionAndSpecieToRegion : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SpecieCycle", new[] { "Region_RegionId" });
            DropIndex("dbo.Specie", new[] { "Region_RegionId" });
            RenameColumn(table: "dbo.SpecieCycle", name: "Region_RegionId", newName: "RegionId");
            RenameColumn(table: "dbo.Specie", name: "Region_RegionId", newName: "RegionId");
            AlterColumn("dbo.SpecieCycle", "RegionId", c => c.Long(nullable: false));
            AlterColumn("dbo.Specie", "RegionId", c => c.Long(nullable: false));
            CreateIndex("dbo.SpecieCycle", "RegionId");
            CreateIndex("dbo.Specie", "RegionId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Specie", new[] { "RegionId" });
            DropIndex("dbo.SpecieCycle", new[] { "RegionId" });
            AlterColumn("dbo.Specie", "RegionId", c => c.Long());
            AlterColumn("dbo.SpecieCycle", "RegionId", c => c.Long());
            RenameColumn(table: "dbo.Specie", name: "RegionId", newName: "Region_RegionId");
            RenameColumn(table: "dbo.SpecieCycle", name: "RegionId", newName: "Region_RegionId");
            CreateIndex("dbo.Specie", "Region_RegionId");
            CreateIndex("dbo.SpecieCycle", "Region_RegionId");
        }
    }
}
