namespace Repository.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_users_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UsersASP",
                c => new
                    {
                        IdUser = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 10),
                        IsActive = c.Boolean(nullable: false),
                        ProfileId = c.Int(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdUser);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UsersASP");
        }
    }
}
