namespace _12_Security_Strategy2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Data.SqlTypes;

    public partial class InitialModelData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            //insertion d'un jeu de données de test

            Sql("Insert into Roles(Name) Values('Admin')");
            Sql("Insert into Roles(Name) Values('Manager')");
            Sql("Insert into Roles(Name) Values('Visitor')");

            Sql("Insert into Users(UserId,UserName,Password,RoleId) Values('admin','admin admin','admin',1)");
            Sql("Insert into Users(UserId,UserName,Password,RoleId) Values('manager','manager manager','manager',2)");
            Sql("Insert into Users(UserId,UserName,Password,RoleId) Values('visitor','visitor visitor','visitor',3)");




        }
        
       

        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
        }
    }
}
