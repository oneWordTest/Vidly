namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "DateAdded");
        }
    }
}
