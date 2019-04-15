namespace pm_retal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtoSkills : DbMigration
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
                        user_type_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
        }
    }
}
