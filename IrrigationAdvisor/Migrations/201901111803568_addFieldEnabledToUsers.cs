namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class addFieldEnabledToUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "Enable", c => c.Boolean(nullable: false, defaultValueSql: "1"));
        }

        public override void Down()
        {
            DropColumn("dbo.User", "Enable");
        }
    }
}

