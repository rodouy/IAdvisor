namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFarmIdToBombAndShortName : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Bomb", new[] { "Farm_FarmId" });
            RenameColumn(table: "dbo.Bomb", name: "Farm_FarmId", newName: "FarmId");
            AddColumn("dbo.Bomb", "ShortName", c => c.String());
            AlterColumn("dbo.Bomb", "FarmId", c => c.Long(nullable: false));
            CreateIndex("dbo.Bomb", "FarmId");
            CreateIndex("dbo.Soil", "PositionId");
            AddForeignKey("dbo.Soil", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Soil", "PositionId", "dbo.Position");
            DropIndex("dbo.Soil", new[] { "PositionId" });
            DropIndex("dbo.Bomb", new[] { "FarmId" });
            AlterColumn("dbo.Bomb", "FarmId", c => c.Long());
            DropColumn("dbo.Bomb", "ShortName");
            RenameColumn(table: "dbo.Bomb", name: "FarmId", newName: "Farm_FarmId");
            CreateIndex("dbo.Bomb", "Farm_FarmId");
        }
    }
}
