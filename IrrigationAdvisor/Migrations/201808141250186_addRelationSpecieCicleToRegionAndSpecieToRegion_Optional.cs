namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addRelationSpecieCicleToRegionAndSpecieToRegion_Optional : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SpecieCycle", new[] { "RegionId" });
            DropIndex("dbo.Specie", new[] { "RegionId" });
            AlterColumn("dbo.SpecieCycle", "RegionId", c => c.Long());
            AlterColumn("dbo.Specie", "RegionId", c => c.Long());
            CreateIndex("dbo.SpecieCycle", "RegionId");
            CreateIndex("dbo.Specie", "RegionId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Specie", new[] { "RegionId" });
            DropIndex("dbo.SpecieCycle", new[] { "RegionId" });
            AlterColumn("dbo.Specie", "RegionId", c => c.Long(nullable: false));
            AlterColumn("dbo.SpecieCycle", "RegionId", c => c.Long(nullable: false));
            CreateIndex("dbo.Specie", "RegionId");
            CreateIndex("dbo.SpecieCycle", "RegionId");
        }
    }
}
