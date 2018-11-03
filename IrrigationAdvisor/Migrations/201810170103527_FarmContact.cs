namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FarmContact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FarmContact",
                c => new
                    {
                        FarmContactId = c.Long(nullable: false, identity: true),
                        FarmId = c.Long(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Phone = c.String(),
                        Email = c.String(nullable: false),
                        SendEmail = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FarmContactId)
                .ForeignKey("dbo.Farm", t => t.FarmId)
                .Index(t => t.FarmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FarmContact", "FarmId", "dbo.Farm");
            DropIndex("dbo.FarmContact", new[] { "FarmId" });
            DropTable("dbo.FarmContact");
        }
    }
}
