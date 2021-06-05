namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMermbershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "MembershipTypeName", c => c.String());
            AddColumn("dbo.MembershipTypes", "MembershipTypeName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
            DropColumn("dbo.Customers", "MembershipTypeName");
        }
    }
}
