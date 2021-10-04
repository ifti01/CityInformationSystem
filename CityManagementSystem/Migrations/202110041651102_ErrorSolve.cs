namespace CityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ErrorSolve : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            RenameColumn(table: "dbo.Cities", name: "Country_Id", newName: "countryId");
            AlterColumn("dbo.Cities", "countryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "countryId");
            AddForeignKey("dbo.Cities", "countryId", "dbo.Countries", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "countryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "countryId" });
            AlterColumn("dbo.Cities", "countryId", c => c.Int());
            RenameColumn(table: "dbo.Cities", name: "countryId", newName: "Country_Id");
            CreateIndex("dbo.Cities", "Country_Id");
            AddForeignKey("dbo.Cities", "Country_Id", "dbo.Countries", "Id");
        }
    }
}
