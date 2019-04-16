namespace pm_retal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intialskills : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        skillName = c.String(),
                        value = c.Int(nullable: false),
                        Suser_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            /*AddColumn("dbo.UserAccounts", "UserType_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.UserAccounts", "ImagePath", c => c.String());
            AlterColumn("dbo.UserAccounts", "Email", c => c.String(nullable: false));*/
        }
        
        public override void Down()
        {
           /* AlterColumn("dbo.UserAccounts", "Email", c => c.String());
            AlterColumn("dbo.UserAccounts", "ImagePath", c => c.String(nullable: false));
            DropColumn("dbo.UserAccounts", "UserType_Id");
            DropTable("dbo.Skills");*/
        }
    }
}
