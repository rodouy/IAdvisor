namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserAccess : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserAccess",
                c => new
                    {
                        UserAccessId = c.Long(nullable: false, identity: true),
                        LogInDate = c.DateTime(nullable: false),
                        LogOutDate = c.DateTime(),
                        User_UserId = c.Long(),
                    })
                .PrimaryKey(t => t.UserAccessId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .Index(t => t.User_UserId);           
        }
        
        public override void Down()
        {          
            DropForeignKey("dbo.UserAccess", "User_UserId", "dbo.User");
            DropIndex("dbo.UserAccess", new[] { "User_UserId" });
            DropTable("dbo.UserAccess");
        }
    }
}
