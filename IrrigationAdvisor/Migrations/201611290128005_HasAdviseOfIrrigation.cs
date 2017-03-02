namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HasAdviseOfIrrigation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CropIrrigationWeather", "HasAdviseOfIrrigation", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CropIrrigationWeather", "HasAdviseOfIrrigation");
        }
    }
}
