namespace pm_retal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjectsModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "status", c => c.String());
        }
        
        public override void Down()
        {
            /*DropColumn("dbo.Projects", "status");*/
        }
    }
}
