namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCostumerColumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "Name");
            DropColumn("dbo.Customers", "MembershipTypeName");
            DropColumn("dbo.MembershipTypes", "MembershipTypeName");
        }
        
        public override void Down()
        {

        }
    }
}
