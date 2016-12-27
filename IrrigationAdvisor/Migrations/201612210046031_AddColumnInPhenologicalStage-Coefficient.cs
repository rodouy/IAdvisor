namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumnInPhenologicalStageCoefficient : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PhenologicalStage", "Coefficient", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PhenologicalStage", "Coefficient");
        }
    }
}
