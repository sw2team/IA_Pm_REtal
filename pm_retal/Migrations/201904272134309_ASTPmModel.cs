namespace pm_retal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ASTPmModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ASTPMs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PM_ID = c.Int(nullable: false),
                        Project_ID = c.Int(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
           /* CreateIndex("dbo.Projects", "Customer_ID");
            CreateIndex("dbo.Projects", "PM_ID");
            AddForeignKey("dbo.Projects", "Customer_ID", "dbo.UserAccounts", "UserID", cascadeDelete: true);
            AddForeignKey("dbo.Projects", "PM_ID", "dbo.UserAccounts", "UserID", cascadeDelete: true);*/
        }
        
        public override void Down()
        {
          /*  DropForeignKey("dbo.Projects", "PM_ID", "dbo.UserAccounts");
            DropForeignKey("dbo.Projects", "Customer_ID", "dbo.UserAccounts");
            DropIndex("dbo.Projects", new[] { "PM_ID" });
            DropIndex("dbo.Projects", new[] { "Customer_ID" });
            DropTable("dbo.ASTPMs");*/
        }
    }
}
