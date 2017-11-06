namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIrrigationReasonToEnum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Irrigation", "Reason", c => c.Int(nullable: false));
            DropColumn("dbo.Irrigation", "ReasonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Irrigation", "ReasonId", c => c.Int());
            DropColumn("dbo.Irrigation", "Reason");
        }
    }
}
