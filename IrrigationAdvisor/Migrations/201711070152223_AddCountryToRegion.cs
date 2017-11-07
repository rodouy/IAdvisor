namespace IrrigationAdvisor.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCountryToRegion : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Region", new[] { "Country_CountryId" });
            RenameColumn(table: "dbo.Region", name: "Country_CountryId", newName: "CountryId");
            AlterColumn("dbo.Region", "CountryId", c => c.Long(nullable: false));
            CreateIndex("dbo.Region", "CountryId");
        }

        public override void Down()
        {
            DropIndex("dbo.Region", new[] { "CountryId" });
            AlterColumn("dbo.Region", "CountryId", c => c.Long());
            RenameColumn(table: "dbo.Region", name: "CountryId", newName: "Country_CountryId");
            CreateIndex("dbo.Region", "Country_CountryId");
        }
    }
}
