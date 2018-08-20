namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFKInIrrigationUnitToPosition : DbMigration
    {
        public override void Up()
        {

            //CreateIndex("dbo.IrrigationUnit", "PositionId");
            //AddForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position", "PositionId");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.IrrigationUnit", "PositionId", "dbo.Position");
            //DropIndex("dbo.IrrigationUnit", new[] { "PositionId" });

        }
    }
}
