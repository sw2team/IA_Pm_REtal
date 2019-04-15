namespace pm_retal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserAccounts", "UserType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.UserAccounts", "ImagePath", c => c.String());
            AlterColumn("dbo.UserAccounts", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserAccounts", "Email", c => c.String());
            AlterColumn("dbo.UserAccounts", "ImagePath", c => c.String(nullable: false));
            DropColumn("dbo.UserAccounts", "UserType_Id");
        }
    }
}
