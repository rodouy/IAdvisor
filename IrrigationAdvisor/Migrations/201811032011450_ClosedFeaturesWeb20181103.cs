namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClosedFeaturesWeb20181103 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IrrigationUnit", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Soil", "Enabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Horizon", "Enabled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Horizon", "Enabled");
            DropColumn("dbo.Soil", "Enabled");
            DropColumn("dbo.IrrigationUnit", "Enabled");
        }
    }
}
