namespace _11_Security_Strategy1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUtilisateurClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        UtilisateurId = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Admin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UtilisateurId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilisateurs");
        }
    }
}
