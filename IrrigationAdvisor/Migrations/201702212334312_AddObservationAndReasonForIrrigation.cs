namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddObservationAndReasonForIrrigation : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Irrigation", "Observations", c => c.String());
            //AddColumn("dbo.Irrigation", "ReasonId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Irrigation", "ReasonId");
            DropColumn("dbo.Irrigation", "Observations");
        }
    }
}
