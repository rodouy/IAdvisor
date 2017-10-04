namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFarmIdToSoilAndShortName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Soil", new[] { "Farm_FarmId" });
            RenameColumn(table: "dbo.Soil", name: "Farm_FarmId", newName: "FarmId");
            AddColumn("dbo.Soil", "ShortName", c => c.String());
            AlterColumn("dbo.Soil", "FarmId", c => c.Long(nullable: false));
            CreateIndex("dbo.Soil", "FarmId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Soil", new[] { "FarmId" });
            AlterColumn("dbo.Soil", "FarmId", c => c.Long());
            DropColumn("dbo.Soil", "ShortName");
            RenameColumn(table: "dbo.Soil", name: "FarmId", newName: "Farm_FarmId");
            CreateIndex("dbo.Soil", "Farm_FarmId");
        }
    }
}
