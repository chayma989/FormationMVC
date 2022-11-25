namespace _12_Security_Strategy2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImofificationUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserId", c => c.String());


            Sql("Insert into Roles(Name) Values('Admin')");
            Sql("Insert into Roles(Name) Values('Manager')");
            Sql("Insert into Roles(Name) Values('Visitor')");

            Sql("Insert into Users(UserId,UserName,Password,RoleId) Values('admin','admin admin','admin',1)");
            Sql("Insert into Users(UserId,UserName,Password,RoleId) Values('manager','manager manager','manager',2)");
            Sql("Insert into Users(UserId,UserName,Password,RoleId) Values('visitor','visitor visitor','visitor',3)");
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "UserId", c => c.Int(nullable: false));
        }

    }
}
