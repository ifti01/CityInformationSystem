namespace CityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CityModelAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CId = c.Int(nullable: false),
                        Name = c.String(),
                        About = c.String(),
                        DwellerNo = c.Int(nullable: false),
                        Location = c.String(),
                        Weather = c.String(),
                        Country_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id)
                .Index(t => t.Country_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Country_Id", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "Country_Id" });
            DropTable("dbo.Cities");
        }
    }
}
