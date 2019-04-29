namespace pm_retal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        post_Name = c.String(nullable: false),
                        post_Description = c.String(nullable: false),
                        Customer_ID = c.Int(nullable: false),
                        PM_ID = c.Int(nullable: false),
                    status = c.String(nullable: false),
                })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Skills", "skillName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            /*AlterColumn("dbo.Skills", "skillName", c => c.String());
            DropTable("dbo.Projects");*/
        }
    }
}
