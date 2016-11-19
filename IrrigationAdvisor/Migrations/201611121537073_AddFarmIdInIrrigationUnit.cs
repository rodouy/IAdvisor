namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFarmIdInIrrigationUnit : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.IrrigationUnit", new[] { "Farm_FarmId" });
            RenameColumn(table: "dbo.IrrigationUnit", name: "Farm_FarmId", newName: "FarmId");
            AlterColumn("dbo.IrrigationUnit", "FarmId", c => c.Long(nullable: false));
            CreateIndex("dbo.IrrigationUnit", "FarmId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.IrrigationUnit", new[] { "FarmId" });
            AlterColumn("dbo.IrrigationUnit", "FarmId", c => c.Long());
            RenameColumn(table: "dbo.IrrigationUnit", name: "FarmId", newName: "Farm_FarmId");
            CreateIndex("dbo.IrrigationUnit", "Farm_FarmId");
        }
    }
}
