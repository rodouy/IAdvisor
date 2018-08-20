namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldIsActiveToFarm : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Farm", "IsActive", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
           // DropColumn("dbo.Farm", "IsActive");
        }
    }
}
