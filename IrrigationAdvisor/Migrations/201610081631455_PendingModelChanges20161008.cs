namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PendingModelChanges20161008 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DailyRecord", "CropIrrgationWeatherId", c => c.Long(nullable: false));
            AlterColumn("dbo.Access", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Menu", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SiteItem", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.SiteMap", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SiteMap", "Name", c => c.String());
            AlterColumn("dbo.SiteItem", "Name", c => c.String());
            AlterColumn("dbo.Menu", "Name", c => c.String());
            AlterColumn("dbo.Access", "Name", c => c.String());
            DropColumn("dbo.DailyRecord", "CropIrrgationWeatherId");
        }
    }
}
