namespace CVSITEHT2021.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CVs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        education = c.String(),
                        workplace = c.String(),
                        competances = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CVs");
        }
    }
}
