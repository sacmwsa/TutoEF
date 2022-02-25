namespace TutoEF.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PremiereMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnes",
                c => new
                    {
                        PersonneId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(maxLength: 55),
                        Lastname = c.String(),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonneId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personnes");
        }
    }
}
