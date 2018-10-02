namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserAccessNewColumn : DbMigration
    {
        public override void Up()
        {
            //DropIndex("dbo.UserAccess", new[] { "User_UserId" });
            //RenameColumn(table: "dbo.UserAccess", name: "User_UserId", newName: "UserId");
            //AddColumn("dbo.Irrigation", "Observations", c => c.String());
            //AddColumn("dbo.Irrigation", "ReasonId", c => c.Int());
            //AlterColumn("dbo.UserAccess", "UserId", c => c.Long(nullable: false));
            //CreateIndex("dbo.UserAccess", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.UserAccess", new[] { "UserId" });
            AlterColumn("dbo.UserAccess", "UserId", c => c.Long());
            DropColumn("dbo.Irrigation", "ReasonId");
            DropColumn("dbo.Irrigation", "Observations");
            RenameColumn(table: "dbo.UserAccess", name: "UserId", newName: "User_UserId");
            CreateIndex("dbo.UserAccess", "User_UserId");
        }
    }
}
