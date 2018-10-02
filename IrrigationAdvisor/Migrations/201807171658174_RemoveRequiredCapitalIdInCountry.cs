namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredCapitalIdInCountry : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Country", "CapitalId", c => c.Long());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Country", "CapitalId", c => c.Long(nullable: false));
        }
    }
}
