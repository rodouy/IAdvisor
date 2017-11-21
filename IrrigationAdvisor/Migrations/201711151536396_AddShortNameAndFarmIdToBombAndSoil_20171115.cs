namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddShortNameAndFarmIdToBombAndSoil_20171115 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Bomb", new[] { "Farm_FarmId" });
            DropIndex("dbo.Soil", new[] { "Farm_FarmId" });
            RenameColumn(table: "dbo.Bomb", name: "Farm_FarmId", newName: "FarmId");
            RenameColumn(table: "dbo.Soil", name: "Farm_FarmId", newName: "FarmId");
            AddColumn("dbo.Bomb", "ShortName", c => c.String());
            AddColumn("dbo.Soil", "ShortName", c => c.String());
            AlterColumn("dbo.Bomb", "FarmId", c => c.Long(nullable: false));
            AlterColumn("dbo.Soil", "FarmId", c => c.Long(nullable: false));
            CreateIndex("dbo.Bomb", "FarmId");
            CreateIndex("dbo.Soil", "PositionId");
            CreateIndex("dbo.Soil", "FarmId");
            AddForeignKey("dbo.Soil", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Soil", "PositionId", "dbo.Position");
            DropIndex("dbo.Soil", new[] { "FarmId" });
            DropIndex("dbo.Soil", new[] { "PositionId" });
            DropIndex("dbo.Bomb", new[] { "FarmId" });
            AlterColumn("dbo.Soil", "FarmId", c => c.Long());
            AlterColumn("dbo.Bomb", "FarmId", c => c.Long());
            DropColumn("dbo.Soil", "ShortName");
            DropColumn("dbo.Bomb", "ShortName");
            RenameColumn(table: "dbo.Soil", name: "FarmId", newName: "Farm_FarmId");
            RenameColumn(table: "dbo.Bomb", name: "FarmId", newName: "Farm_FarmId");
            CreateIndex("dbo.Soil", "Farm_FarmId");
            CreateIndex("dbo.Bomb", "Farm_FarmId");
        }
    }
}
