namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestChangeNameMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay as U GO' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
