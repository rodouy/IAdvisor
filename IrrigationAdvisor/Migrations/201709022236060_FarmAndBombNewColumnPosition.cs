namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FarmAndBombNewColumnPosition : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Bomb", "PositionId");
            CreateIndex("dbo.Farm", "PositionId");
            AddForeignKey("dbo.Bomb", "PositionId", "dbo.Position", "PositionId");
            AddForeignKey("dbo.Farm", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Farm", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Bomb", "PositionId", "dbo.Position");
            DropIndex("dbo.Farm", new[] { "PositionId" });
            DropIndex("dbo.Bomb", new[] { "PositionId" });
        }
    }
}
