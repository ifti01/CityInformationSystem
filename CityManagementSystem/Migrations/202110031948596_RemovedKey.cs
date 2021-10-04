namespace CityManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedKey : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cities", "CId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "CId", c => c.Int(nullable: false));
        }
    }
}
